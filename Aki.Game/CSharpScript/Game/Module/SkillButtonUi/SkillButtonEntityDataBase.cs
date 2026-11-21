using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.SkillButtonUi.Custom;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BB7 RID: 15287
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonEntityDataBase
	{
		// Token: 0x06027381 RID: 160641 RVA: 0x00AFCB04 File Offset: 0x00AFAD04
		public virtual void Clear()
		{
			this.ClearAllTagSignificantChangedWithTagTasks();
			this.ClearAllAttributeChanged();
			this.GameplayTagComponent = null;
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				skillButtonData.Reset();
			}
			this.SkillButtonDataMap = null;
			this.AttributeIdSkillButtonMapping = null;
			this.AttributeIdTagSkillButtonMapping = null;
			this.DisableTagSkillButtonMapping = null;
			this.DisableSkillIdTagSkillButtonMapping = null;
			this.DynamicEffectTagSkillButtonMapping = null;
			this.SkillIconTagSkillButtonMapping = null;
			this.SkillIdTagSkillButtonMapping = null;
			this.CustomHandleSkillButtonMapping = null;
			this.AttributeChangedCallbackMap = null;
		}

		// Token: 0x06027382 RID: 160642 RVA: 0x00AFCBB4 File Offset: 0x00AFADB4
		protected void ListenForTagSignificantChangedWithTag(int tag, Action<int, bool> callback)
		{
			if (tag == 0)
			{
				return;
			}
			HashSet<Action<int, bool>> hashSet;
			if (!this.TagCallbackMap.TryGetValue(tag, out hashSet))
			{
				hashSet = new HashSet<Action<int, bool>>();
				hashSet.Add(callback);
				this.TagCallbackMap[tag] = hashSet;
			}
			else
			{
				if (hashSet.Contains(callback))
				{
					return;
				}
				hashSet.Add(callback);
			}
			ITagTask tagTask = this.GameplayTagComponent.ListenForTagAddOrRemove(new int?(tag), new BaseTagComponent.TTagSwitchedCallback(callback.Invoke), null);
			if (tagTask == null)
			{
				return;
			}
			this.TagSignificantChangedWithTagTasks.Add(tagTask);
		}

		// Token: 0x06027383 RID: 160643 RVA: 0x00AFCC38 File Offset: 0x00AFAE38
		protected void ListenForTagAnyCountChanged(int tagId, Action<int, int, int, int> callback, bool checkExistImmediately = false)
		{
			if (tagId != 0)
			{
				ITagTask tagTask = this.GameplayTagComponent.ListenForTagAnyCountChanged(tagId, new BaseTagComponent.TTagChangedCallback(callback.Invoke));
				if (tagTask != null)
				{
					this.TagSignificantChangedWithTagTasks.Add(tagTask);
				}
				if (checkExistImmediately)
				{
					int tagCount = this.GameplayTagComponent.GetTagCount(tagId);
					if (tagCount > 0)
					{
						callback(tagCount, tagId, tagId, 0);
					}
				}
			}
		}

		// Token: 0x06027384 RID: 160644 RVA: 0x00AFCC90 File Offset: 0x00AFAE90
		protected void ClearAllTagSignificantChangedWithTagTasks()
		{
			foreach (ITagTask tagTask in this.TagSignificantChangedWithTagTasks)
			{
				if (tagTask != null)
				{
					tagTask.EndTask();
				}
			}
			this.TagSignificantChangedWithTagTasks.Clear();
			this.TagCallbackMap.Clear();
		}

		// Token: 0x06027385 RID: 160645 RVA: 0x00AFCCFC File Offset: 0x00AFAEFC
		protected void CheckCustomHdModify(SkillButtonCustomHandleBase customHd, SkillButtonData skillButtonData)
		{
			if (!this.IsCurEntity)
			{
				if (customHd.EnableModifyMark)
				{
					skillButtonData.RefreshIsEnable();
				}
				if (customHd.CustomSkillIconNameModifyMark || customHd.CustomSkillTexturePathModifyMark)
				{
					skillButtonData.RefreshSkillTexturePath();
				}
				customHd.ClearModifyMark();
				return;
			}
			if (customHd.SkillCdModifyMark)
			{
				this.SkillCdChanged.Add(skillButtonData);
				this.EnableNextTick();
			}
			if (customHd.EnableModifyMark)
			{
				bool flag = skillButtonData.IsEnable();
				skillButtonData.RefreshIsEnable();
				if (flag != skillButtonData.IsEnable())
				{
					this.EnableChanged.Add(skillButtonData);
					this.EnableNextTick();
				}
			}
			if (customHd.CustomHdModifyMark)
			{
				customHd.CustomHdModifyMark = false;
				this.CustomHdChanged.Add(new ValueTuple<SkillButtonData, int, int>(skillButtonData, customHd.CustomHdMarkFrom, 0));
				this.EnableNextTick();
			}
			if (customHd.EnableSlideControlModifyMark)
			{
				this.EnableSlideControlChanged.Add(skillButtonData);
				this.EnableNextTick();
			}
			if (customHd.CustomSkillIconNameModifyMark || customHd.CustomSkillTexturePathModifyMark)
			{
				skillButtonData.RefreshSkillTexturePath();
				this.SkillIconChanged.Add(skillButtonData);
				this.EnableNextTick();
			}
			customHd.ClearModifyMark();
		}

		// Token: 0x06027386 RID: 160646 RVA: 0x00AFCDFE File Offset: 0x00AFAFFE
		protected virtual void EnableNextTick()
		{
		}

		// Token: 0x06027387 RID: 160647 RVA: 0x00AFCE00 File Offset: 0x00AFB000
		protected void ListenForAttributeChanged(EAttributeType attributeId, Action<EAttributeType, float, float> onAttributeChanged)
		{
			if (this.AttributeChangedCallbackMap.ContainsKey(attributeId))
			{
				return;
			}
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			if (attributeComponent != null)
			{
				attributeComponent.AddListener(attributeId, onAttributeChanged, "SkillButtonUiController");
			}
			this.AttributeChangedCallbackMap[attributeId] = onAttributeChanged;
		}

		// Token: 0x06027388 RID: 160648 RVA: 0x00AFCE38 File Offset: 0x00AFB038
		protected void ClearAllAttributeChanged()
		{
			foreach (KeyValuePair<EAttributeType, Action<EAttributeType, float, float>> keyValuePair in this.AttributeChangedCallbackMap)
			{
				BaseAttributeComponent attributeComponent = this.AttributeComponent;
				if (attributeComponent != null)
				{
					attributeComponent.RemoveListener(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x06027389 RID: 160649 RVA: 0x00AFCEA4 File Offset: 0x00AFB0A4
		[NullableContext(2)]
		public SkillButtonData GetSkillButtonDataByButton(ESkillButtonType buttonType)
		{
			SkillButtonData result;
			if (!this.SkillButtonDataMap.TryGetValue((int)buttonType, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0602738A RID: 160650 RVA: 0x00AFCEC4 File Offset: 0x00AFB0C4
		[NullableContext(2)]
		public SkillButtonData GetSkillButtonDataBySkillId(int skillId)
		{
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				if (skillButtonData.GetSkillId() == skillId)
				{
					return skillButtonData;
				}
			}
			return null;
		}

		// Token: 0x0602738B RID: 160651 RVA: 0x00AFCF28 File Offset: 0x00AFB128
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByAttributeId(EAttributeType attributeId)
		{
			return this.AttributeIdSkillButtonMapping.Get(attributeId);
		}

		// Token: 0x0602738C RID: 160652 RVA: 0x00AFCF36 File Offset: 0x00AFB136
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByDisableTag(int tagId)
		{
			return this.DisableTagSkillButtonMapping.Get(tagId);
		}

		// Token: 0x0602738D RID: 160653 RVA: 0x00AFCF44 File Offset: 0x00AFB144
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByDisableSkillIdTag(int tagId)
		{
			return this.DisableSkillIdTagSkillButtonMapping.Get(tagId);
		}

		// Token: 0x0602738E RID: 160654 RVA: 0x00AFCF52 File Offset: 0x00AFB152
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataBySkillIdTag(int tagId)
		{
			return this.SkillIdTagSkillButtonMapping.Get(tagId);
		}

		// Token: 0x0602738F RID: 160655 RVA: 0x00AFCF60 File Offset: 0x00AFB160
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataBySkillIconTag(int tag)
		{
			return this.SkillIconTagSkillButtonMapping.Get(tag);
		}

		// Token: 0x06027390 RID: 160656 RVA: 0x00AFCF6E File Offset: 0x00AFB16E
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByDynamicEffectTag(int tag)
		{
			return this.DynamicEffectTagSkillButtonMapping.Get(tag);
		}

		// Token: 0x04015618 RID: 87576
		[StaticVariableRuleIgnore]
		protected static readonly Stat NextTickStat = Stat.Create("SkillButtonEntityDataNextTick", "", "");

		// Token: 0x04015619 RID: 87577
		public bool IsCurEntity;

		// Token: 0x0401561A RID: 87578
		[Nullable(2)]
		public EntityHandle EntityHandle;

		// Token: 0x0401561B RID: 87579
		[Nullable(2)]
		public BaseTagComponent GameplayTagComponent;

		// Token: 0x0401561C RID: 87580
		[Nullable(2)]
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x0401561D RID: 87581
		[Nullable(2)]
		public CharacterSkillComponent SkillComponent;

		// Token: 0x0401561E RID: 87582
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SkillButtonData> SkillButtonDataMap = new Dictionary<int, SkillButtonData>();

		// Token: 0x0401561F RID: 87583
		[Nullable(2)]
		public SkillButtonMapping<EAttributeType> AttributeIdSkillButtonMapping = new SkillButtonMapping<EAttributeType>();

		// Token: 0x04015620 RID: 87584
		[Nullable(2)]
		public SkillButtonMapping<int> AttributeIdTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015621 RID: 87585
		[Nullable(2)]
		public SkillButtonMapping<int> DisableTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015622 RID: 87586
		[Nullable(2)]
		public SkillButtonMapping<int> DisableSkillIdTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015623 RID: 87587
		[Nullable(2)]
		public SkillButtonMapping<int> DynamicEffectTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015624 RID: 87588
		[Nullable(2)]
		public SkillButtonMapping<int> SkillIconTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015625 RID: 87589
		[Nullable(2)]
		public SkillButtonMapping<int> SkillIdTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015626 RID: 87590
		[Nullable(2)]
		public SkillButtonMapping<int> CustomHandleSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015627 RID: 87591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

		// Token: 0x04015628 RID: 87592
		protected readonly Dictionary<int, HashSet<Action<int, bool>>> TagCallbackMap = new Dictionary<int, HashSet<Action<int, bool>>>();

		// Token: 0x04015629 RID: 87593
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected HashSet<ITagTask> TagSignificantChangedWithTagTasks = new HashSet<ITagTask>();

		// Token: 0x0401562A RID: 87594
		protected readonly HashSet<SkillButtonData> EnableChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401562B RID: 87595
		protected readonly HashSet<SkillButtonData> VisibleChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401562C RID: 87596
		protected readonly HashSet<SkillButtonData> SkillIdChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401562D RID: 87597
		protected readonly HashSet<SkillButtonData> SkillIconChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401562E RID: 87598
		protected readonly HashSet<SkillButtonData> DynamicEffectChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401562F RID: 87599
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected readonly HashSet<ValueTuple<SkillButtonData, int, int>> CustomHdChanged = new HashSet<ValueTuple<SkillButtonData, int, int>>();

		// Token: 0x04015630 RID: 87600
		protected readonly HashSet<SkillButtonData> SkillCdChanged = new HashSet<SkillButtonData>();

		// Token: 0x04015631 RID: 87601
		protected readonly HashSet<SkillButtonData> AttributeChanged = new HashSet<SkillButtonData>();

		// Token: 0x04015632 RID: 87602
		protected readonly HashSet<SkillButtonData> LongPressChanged = new HashSet<SkillButtonData>();

		// Token: 0x04015633 RID: 87603
		protected readonly HashSet<SkillButtonData> EnableSlideControlChanged = new HashSet<SkillButtonData>();
	}
}
