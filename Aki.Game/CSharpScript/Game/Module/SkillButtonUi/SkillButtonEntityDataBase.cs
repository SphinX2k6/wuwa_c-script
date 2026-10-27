using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.SkillButtonUi.Custom;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C06 RID: 19462
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonEntityDataBase
	{
		// Token: 0x060325D1 RID: 206289 RVA: 0x00BB7F74 File Offset: 0x00BB6174
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

		// Token: 0x060325D2 RID: 206290 RVA: 0x00BB8024 File Offset: 0x00BB6224
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

		// Token: 0x060325D3 RID: 206291 RVA: 0x00BB80A8 File Offset: 0x00BB62A8
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

		// Token: 0x060325D4 RID: 206292 RVA: 0x00BB8100 File Offset: 0x00BB6300
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

		// Token: 0x060325D5 RID: 206293 RVA: 0x00BB816C File Offset: 0x00BB636C
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

		// Token: 0x060325D6 RID: 206294 RVA: 0x00BB826E File Offset: 0x00BB646E
		protected virtual void EnableNextTick()
		{
		}

		// Token: 0x060325D7 RID: 206295 RVA: 0x00BB8270 File Offset: 0x00BB6470
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

		// Token: 0x060325D8 RID: 206296 RVA: 0x00BB82A8 File Offset: 0x00BB64A8
		protected void ClearAllAttributeChanged()
		{
			if (this.AttributeChangedCallbackMap == null)
			{
				return;
			}
			foreach (KeyValuePair<EAttributeType, Action<EAttributeType, float, float>> keyValuePair in this.AttributeChangedCallbackMap)
			{
				BaseAttributeComponent attributeComponent = this.AttributeComponent;
				if (attributeComponent != null)
				{
					attributeComponent.RemoveListener(keyValuePair.Key, keyValuePair.Value);
				}
			}
		}

		// Token: 0x060325D9 RID: 206297 RVA: 0x00BB8320 File Offset: 0x00BB6520
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

		// Token: 0x060325DA RID: 206298 RVA: 0x00BB8340 File Offset: 0x00BB6540
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

		// Token: 0x060325DB RID: 206299 RVA: 0x00BB83A4 File Offset: 0x00BB65A4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByAttributeId(EAttributeType attributeId)
		{
			return this.AttributeIdSkillButtonMapping.Get(attributeId);
		}

		// Token: 0x060325DC RID: 206300 RVA: 0x00BB83B2 File Offset: 0x00BB65B2
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByDisableTag(int tagId)
		{
			return this.DisableTagSkillButtonMapping.Get(tagId);
		}

		// Token: 0x060325DD RID: 206301 RVA: 0x00BB83C0 File Offset: 0x00BB65C0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByDisableSkillIdTag(int tagId)
		{
			return this.DisableSkillIdTagSkillButtonMapping.Get(tagId);
		}

		// Token: 0x060325DE RID: 206302 RVA: 0x00BB83CE File Offset: 0x00BB65CE
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataBySkillIdTag(int tagId)
		{
			return this.SkillIdTagSkillButtonMapping.Get(tagId);
		}

		// Token: 0x060325DF RID: 206303 RVA: 0x00BB83DC File Offset: 0x00BB65DC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataBySkillIconTag(int tag)
		{
			return this.SkillIconTagSkillButtonMapping.Get(tag);
		}

		// Token: 0x060325E0 RID: 206304 RVA: 0x00BB83EA File Offset: 0x00BB65EA
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public HashSet<SkillButtonData> GetSkillButtonDataByDynamicEffectTag(int tag)
		{
			return this.DynamicEffectTagSkillButtonMapping.Get(tag);
		}

		// Token: 0x0401ACBC RID: 109756
		[StaticVariableRuleIgnore]
		protected static readonly Stat NextTickStat = Stat.Create("SkillButtonEntityDataNextTick", "", "");

		// Token: 0x0401ACBD RID: 109757
		public bool IsCurEntity;

		// Token: 0x0401ACBE RID: 109758
		[Nullable(2)]
		public EntityHandle EntityHandle;

		// Token: 0x0401ACBF RID: 109759
		[Nullable(2)]
		public BaseTagComponent GameplayTagComponent;

		// Token: 0x0401ACC0 RID: 109760
		[Nullable(2)]
		public BaseAttributeComponent AttributeComponent;

		// Token: 0x0401ACC1 RID: 109761
		[Nullable(2)]
		public CharacterSkillComponent SkillComponent;

		// Token: 0x0401ACC2 RID: 109762
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, SkillButtonData> SkillButtonDataMap = new Dictionary<int, SkillButtonData>();

		// Token: 0x0401ACC3 RID: 109763
		[Nullable(2)]
		public SkillButtonMapping<EAttributeType> AttributeIdSkillButtonMapping = new SkillButtonMapping<EAttributeType>();

		// Token: 0x0401ACC4 RID: 109764
		[Nullable(2)]
		public SkillButtonMapping<int> AttributeIdTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACC5 RID: 109765
		[Nullable(2)]
		public SkillButtonMapping<int> DisableTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACC6 RID: 109766
		[Nullable(2)]
		public SkillButtonMapping<int> DisableSkillIdTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACC7 RID: 109767
		[Nullable(2)]
		public SkillButtonMapping<int> DynamicEffectTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACC8 RID: 109768
		[Nullable(2)]
		public SkillButtonMapping<int> SkillIconTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACC9 RID: 109769
		[Nullable(2)]
		public SkillButtonMapping<int> SkillIdTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACCA RID: 109770
		[Nullable(2)]
		public SkillButtonMapping<int> CustomHandleSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACCB RID: 109771
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected Dictionary<EAttributeType, Action<EAttributeType, float, float>> AttributeChangedCallbackMap = new Dictionary<EAttributeType, Action<EAttributeType, float, float>>();

		// Token: 0x0401ACCC RID: 109772
		protected readonly Dictionary<int, HashSet<Action<int, bool>>> TagCallbackMap = new Dictionary<int, HashSet<Action<int, bool>>>();

		// Token: 0x0401ACCD RID: 109773
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected HashSet<ITagTask> TagSignificantChangedWithTagTasks = new HashSet<ITagTask>();

		// Token: 0x0401ACCE RID: 109774
		protected readonly HashSet<SkillButtonData> EnableChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACCF RID: 109775
		protected readonly HashSet<SkillButtonData> VisibleChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD0 RID: 109776
		protected readonly HashSet<SkillButtonData> SkillIdChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD1 RID: 109777
		protected readonly HashSet<SkillButtonData> SkillIconChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD2 RID: 109778
		protected readonly HashSet<SkillButtonData> DynamicEffectChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD3 RID: 109779
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected readonly HashSet<ValueTuple<SkillButtonData, int, int>> CustomHdChanged = new HashSet<ValueTuple<SkillButtonData, int, int>>();

		// Token: 0x0401ACD4 RID: 109780
		protected readonly HashSet<SkillButtonData> SkillCdChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD5 RID: 109781
		protected readonly HashSet<SkillButtonData> AttributeChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD6 RID: 109782
		protected readonly HashSet<SkillButtonData> LongPressChanged = new HashSet<SkillButtonData>();

		// Token: 0x0401ACD7 RID: 109783
		protected readonly HashSet<SkillButtonData> EnableSlideControlChanged = new HashSet<SkillButtonData>();
	}
}
