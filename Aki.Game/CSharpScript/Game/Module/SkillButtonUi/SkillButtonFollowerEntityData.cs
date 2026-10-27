using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi.Custom;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C07 RID: 19463
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillButtonFollowerEntityData : SkillButtonEntityDataBase
	{
		// Token: 0x060325E3 RID: 206307 RVA: 0x00BB8518 File Offset: 0x00BB6718
		[NullableContext(1)]
		public void Init(EntityHandle entityHandle, bool bEnable)
		{
			this.EntityHandle = entityHandle;
			WorldEntity entity = entityHandle.Entity;
			this.IsCurEntity = bEnable;
			this.IsEnable = bEnable;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			this.PbDataId = component.GetPbDataId();
			this.AttributeComponent = entity.GetComponent<BaseAttributeComponent>();
			this.GameplayTagComponent = entity.GetComponent<BaseTagComponent>();
			this.SkillComponent = entity.GetComponent<CharacterSkillComponent>();
			SkillButtonConfig instance = SkillButtonConfig.Instance;
			this.SkillButtonConfigList = instance.GetAllSkillFollowerButtonConfig(this.PbDataId);
			this.NewAllSkillButtonData();
			this.AddEntityEvents();
			if (this.IsEnable)
			{
				this.RefreshAllSkillButton();
			}
		}

		// Token: 0x060325E4 RID: 206308 RVA: 0x00BB85AA File Offset: 0x00BB67AA
		public void SetEnable(bool bEnable)
		{
			this.IsEnable = bEnable;
			this.IsCurEntity = bEnable;
			this.RefreshAllSkillButton();
		}

		// Token: 0x060325E5 RID: 206309 RVA: 0x00BB85C0 File Offset: 0x00BB67C0
		public void RefreshAllSkillButton()
		{
			if (this.SkillButtonDataMap != null)
			{
				this.EnableNextTick();
				foreach (SkillButtonData item in this.SkillButtonDataMap.Values)
				{
					this.SkillIdChanged.Add(item);
				}
			}
		}

		// Token: 0x060325E6 RID: 206310 RVA: 0x00BB862C File Offset: 0x00BB682C
		public override void Clear()
		{
			base.Clear();
			this.ClearAllEvent();
			this.NotOccupyTagSkillButtonMapping = null;
			this.EntityHandle = null;
			this.PbDataId = 0;
			this.AttributeComponent = null;
			this.GameplayTagComponent = null;
			this.SkillComponent = null;
			this.SkillButtonConfigList = null;
		}

		// Token: 0x060325E7 RID: 206311 RVA: 0x00BB866C File Offset: 0x00BB686C
		private void NewAllSkillButtonData()
		{
			if (this.PbDataId <= 0)
			{
				return;
			}
			IReadOnlyList<SkillFollowerButton> skillButtonConfigList = this.SkillButtonConfigList;
			if (skillButtonConfigList != null)
			{
				foreach (SkillFollowerButton config in skillButtonConfigList)
				{
					int buttonType = config.ButtonType;
					SkillButtonData skillButtonData = new SkillButtonData();
					this.SkillButtonDataMap[buttonType] = skillButtonData;
					this.InitSkillButtonData(skillButtonData, config);
				}
			}
		}

		// Token: 0x060325E8 RID: 206312 RVA: 0x00BB86E8 File Offset: 0x00BB68E8
		[NullableContext(1)]
		private void InitSkillButtonData(SkillButtonData skillButtonData, SkillFollowerButton config)
		{
			skillButtonData.Refresh(this.EntityHandle, config, ESkillButtonConfigType.Follower, null);
			this.AttributeIdSkillButtonMapping.AddSingle(skillButtonData.AttributeId, skillButtonData);
			this.AttributeIdSkillButtonMapping.AddSingle(skillButtonData.MaxAttributeId, skillButtonData);
			foreach (int key in skillButtonData.AttributeIdTagMap.Keys)
			{
				this.AttributeIdTagSkillButtonMapping.AddSingle(key, skillButtonData);
			}
			this.DisableTagSkillButtonMapping.Add(skillButtonData.GetDisableTagIds(), skillButtonData);
			this.DisableSkillIdTagSkillButtonMapping.Add(skillButtonData.GetDisableSkillIdTagIds().Keys, skillButtonData);
			this.NotOccupyTagSkillButtonMapping.Add(skillButtonData.GetNotOccupyTagIds(), skillButtonData);
			this.DynamicEffectTagSkillButtonMapping.Add(skillButtonData.DynamicEffectTagIdMap.Keys, skillButtonData);
			this.SkillIconTagSkillButtonMapping.Add(skillButtonData.SkillIconTagIds, skillButtonData);
			foreach (int key2 in skillButtonData.SkillIdTagMap.Keys)
			{
				this.SkillIdTagSkillButtonMapping.AddSingle(key2, skillButtonData);
			}
			foreach (SkillButtonCustomHandleBase skillButtonCustomHandleBase in skillButtonData.CustomHandleList)
			{
				if (skillButtonCustomHandleBase.TagIds.Count > 0)
				{
					this.CustomHandleSkillButtonMapping.Add(skillButtonCustomHandleBase.TagIds, skillButtonData);
				}
			}
		}

		// Token: 0x060325E9 RID: 206313 RVA: 0x00BB8898 File Offset: 0x00BB6A98
		private void AddEntityEvents()
		{
			this.ListenEntityTag();
			this.ListenEntityAttribute();
		}

		// Token: 0x060325EA RID: 206314 RVA: 0x00BB88A8 File Offset: 0x00BB6AA8
		private void ListenEntityTag()
		{
			if (this.PbDataId <= 0)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				if (skillButtonData.GetEntityHandle() != null)
				{
					foreach (int tag in skillButtonData.AttributeIdTagMap.Keys)
					{
						base.ListenForTagSignificantChangedWithTag(tag, new Action<int, bool>(this.OnAttributeIdTagChanged));
					}
					foreach (int tag2 in skillButtonData.GetDisableTagIds())
					{
						base.ListenForTagSignificantChangedWithTag(tag2, new Action<int, bool>(this.OnDisableTagChanged));
					}
					foreach (int tag3 in skillButtonData.GetDisableSkillIdTagIds().Keys)
					{
						base.ListenForTagSignificantChangedWithTag(tag3, new Action<int, bool>(this.OnDisableSkillIdTagChanged));
					}
					foreach (int tag4 in skillButtonData.GetNotOccupyTagIds())
					{
						base.ListenForTagSignificantChangedWithTag(tag4, new Action<int, bool>(this.OnNotOccupyTagChanged));
					}
					foreach (int tag5 in skillButtonData.SkillIdTagMap.Keys)
					{
						base.ListenForTagSignificantChangedWithTag(tag5, new Action<int, bool>(this.OnSkillTagChanged));
					}
					foreach (int tag6 in skillButtonData.SkillIconTagIds)
					{
						base.ListenForTagSignificantChangedWithTag(tag6, new Action<int, bool>(this.OnSkillIconTagChanged));
					}
					foreach (int tag7 in skillButtonData.DynamicEffectTagIdMap.Keys)
					{
						base.ListenForTagSignificantChangedWithTag(tag7, new Action<int, bool>(this.OnDynamicEffectTagChanged));
					}
					foreach (SkillButtonCustomHandleBase skillButtonCustomHandleBase in skillButtonData.CustomHandleList)
					{
						foreach (int tagId in skillButtonCustomHandleBase.TagIds)
						{
							base.ListenForTagAnyCountChanged(tagId, new Action<int, int, int, int>(this.OnCustomTagCountChanged), false);
						}
					}
				}
			}
		}

		// Token: 0x060325EB RID: 206315 RVA: 0x00BB8C3C File Offset: 0x00BB6E3C
		private void ListenEntityAttribute()
		{
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				if (skillButtonData.GetEntityHandle() != null)
				{
					EAttributeType attributeId = skillButtonData.AttributeId;
					EAttributeType maxAttributeId = skillButtonData.MaxAttributeId;
					if (attributeId > EAttributeType.None && maxAttributeId > EAttributeType.None)
					{
						base.ListenForAttributeChanged(attributeId, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
						base.ListenForAttributeChanged(maxAttributeId, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
					}
				}
			}
		}

		// Token: 0x060325EC RID: 206316 RVA: 0x00BB8CD4 File Offset: 0x00BB6ED4
		protected override void EnableNextTick()
		{
			if (this.NextTickTimerId != null)
			{
				return;
			}
			this.NextTickTimerId = TimerSystem.Instance.Next(new TTimerAction(this.NextTick), SkillButtonEntityDataBase.NextTickStat, null);
		}

		// Token: 0x060325ED RID: 206317 RVA: 0x00BB8D04 File Offset: 0x00BB6F04
		private void ClearNextTick()
		{
			if (this.NextTickTimerId == null)
			{
				return;
			}
			if (TimerSystem.Instance.Has(this.NextTickTimerId))
			{
				TimerSystem.Instance.Remove(this.NextTickTimerId);
			}
			this.NextTickTimerId = null;
			this.EnableChanged.Clear();
			this.VisibleChanged.Clear();
			this.SkillIdChanged.Clear();
			this.SkillIconChanged.Clear();
			this.DynamicEffectChanged.Clear();
			this.SkillCdChanged.Clear();
			this.AttributeChanged.Clear();
		}

		// Token: 0x060325EE RID: 206318 RVA: 0x00BB8D94 File Offset: 0x00BB6F94
		private void NextTick(float _)
		{
			this.NextTickTimerId = null;
			foreach (SkillButtonData skillButtonData in this.EnableChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType, int>(EEventName.OnSkillButtonEnableRefresh, skillButtonData.GetButtonType(), -1);
			}
			this.EnableChanged.Clear();
			foreach (SkillButtonData skillButtonData2 in this.VisibleChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonVisibleRefresh, skillButtonData2.GetButtonType());
			}
			this.VisibleChanged.Clear();
			foreach (SkillButtonData skillButtonData3 in this.SkillIdChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, skillButtonData3.GetButtonType());
			}
			this.SkillIdChanged.Clear();
			foreach (SkillButtonData skillButtonData4 in this.SkillIconChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonIconPathRefresh, skillButtonData4.GetButtonType());
			}
			this.SkillIconChanged.Clear();
			foreach (SkillButtonData skillButtonData5 in this.DynamicEffectChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonDynamicEffectRefresh, skillButtonData5.GetButtonType());
			}
			this.DynamicEffectChanged.Clear();
			foreach (ValueTuple<SkillButtonData, int, int> valueTuple in this.CustomHdChanged)
			{
				SkillButtonData item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				int item3 = valueTuple.Item3;
				EventSystem.Instance.Emit<ESkillButtonType, int, int>(EEventName.OnSkillButtonCustomRefresh, item.GetButtonType(), item2, item3);
			}
			this.CustomHdChanged.Clear();
			foreach (SkillButtonData skillButtonData6 in this.SkillCdChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, skillButtonData6.GetButtonType());
			}
			this.SkillCdChanged.Clear();
			foreach (SkillButtonData skillButtonData7 in this.AttributeChanged)
			{
				EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, skillButtonData7.GetButtonType());
			}
			this.AttributeChanged.Clear();
			if (this.SkillButtonDataRefresh)
			{
				EventSystem.Instance.Emit<ESkillButtonRefreshReason>(EEventName.OnSkillButtonDataRefresh, this.SkillButtonDataRefreshReason);
				this.SkillButtonDataRefresh = false;
			}
		}

		// Token: 0x060325EF RID: 206319 RVA: 0x00BB90D8 File Offset: 0x00BB72D8
		public void RefreshSkillButtonData(ESkillButtonRefreshReason refreshReason)
		{
			if (this.SkillButtonDataRefresh)
			{
				if (refreshReason < this.SkillButtonDataRefreshReason)
				{
					this.SkillButtonDataRefreshReason = refreshReason;
				}
				return;
			}
			this.SkillButtonDataRefresh = true;
			this.SkillButtonDataRefreshReason = refreshReason;
			this.EnableNextTick();
		}

		// Token: 0x060325F0 RID: 206320 RVA: 0x00BB9108 File Offset: 0x00BB7308
		private void OnAttributeIdTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> hashSet = this.AttributeIdTagSkillButtonMapping.Get(tagId);
			if (hashSet == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in hashSet)
			{
				EAttributeType attributeId = skillButtonData.AttributeId;
				EAttributeType maxAttributeId = skillButtonData.MaxAttributeId;
				skillButtonData.RefreshAttributeId();
				EAttributeType attributeId2 = skillButtonData.AttributeId;
				EAttributeType maxAttributeId2 = skillButtonData.MaxAttributeId;
				if (attributeId != attributeId2 || maxAttributeId != maxAttributeId2)
				{
					skillButtonData.RefreshFrameSpriteColor();
					this.AttributeIdSkillButtonMapping.RemoveSingle(attributeId, skillButtonData);
					this.AttributeIdSkillButtonMapping.RemoveSingle(maxAttributeId, skillButtonData);
					if (attributeId2 > EAttributeType.None)
					{
						this.AttributeIdSkillButtonMapping.AddSingle(attributeId2, skillButtonData);
						this.AttributeIdSkillButtonMapping.AddSingle(maxAttributeId2, skillButtonData);
						if (!this.AttributeChangedCallbackMap.ContainsKey(attributeId2))
						{
							base.ListenForAttributeChanged(attributeId2, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
						}
						if (!this.AttributeChangedCallbackMap.ContainsKey(maxAttributeId2))
						{
							base.ListenForAttributeChanged(maxAttributeId2, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
						}
					}
					bool flag = skillButtonData.IsEnable();
					skillButtonData.RefreshIsEnable();
					this.AttributeChanged.Add(skillButtonData);
					bool flag2 = skillButtonData.IsEnable();
					if (flag != flag2)
					{
						this.EnableChanged.Add(skillButtonData);
					}
					this.EnableNextTick();
				}
			}
		}

		// Token: 0x060325F1 RID: 206321 RVA: 0x00BB9268 File Offset: 0x00BB7468
		private void OnDisableTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> skillButtonDataByDisableTag = base.GetSkillButtonDataByDisableTag(tagId);
			if (skillButtonDataByDisableTag == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in skillButtonDataByDisableTag)
			{
				bool flag = skillButtonData.IsEnable();
				if (flag == tagExist)
				{
					bool flag2;
					if (tagExist)
					{
						skillButtonData.SetEnable(false, ESkillButtonDisableReason.DisableTag);
						flag2 = true;
					}
					else
					{
						skillButtonData.RefreshIsEnable();
						flag2 = (skillButtonData.IsEnable() != flag);
					}
					if (this.IsEnable && flag2)
					{
						this.EnableChanged.Add(skillButtonData);
						this.EnableNextTick();
					}
				}
			}
		}

		// Token: 0x060325F2 RID: 206322 RVA: 0x00BB930C File Offset: 0x00BB750C
		private void OnDisableSkillIdTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> skillButtonDataByDisableSkillIdTag = base.GetSkillButtonDataByDisableSkillIdTag(tagId);
			if (skillButtonDataByDisableSkillIdTag == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in skillButtonDataByDisableSkillIdTag)
			{
				bool flag = false;
				bool flag2 = skillButtonData.IsEnable();
				if (flag2 == tagExist)
				{
					if (tagExist)
					{
						int? num = new int?(skillButtonData.GetSkillId());
						if (num != null)
						{
							int? num2 = num;
							int num3 = 0;
							HashSet<int> hashSet;
							if (!(num2.GetValueOrDefault() == num3 & num2 != null) && skillButtonData.GetDisableSkillIdTagIds().TryGetValue(tagId, out hashSet) && hashSet.Contains(num.Value))
							{
								skillButtonData.SetEnable(false, ESkillButtonDisableReason.DisableSkillIdTag);
								flag = true;
							}
						}
					}
					else
					{
						skillButtonData.RefreshIsEnable();
						flag = (skillButtonData.IsEnable() != flag2);
					}
					if (this.IsEnable && flag)
					{
						this.EnableChanged.Add(skillButtonData);
						this.EnableNextTick();
					}
				}
			}
		}

		// Token: 0x060325F3 RID: 206323 RVA: 0x00BB940C File Offset: 0x00BB760C
		private void OnNotOccupyTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> hashSet = this.NotOccupyTagSkillButtonMapping.Get(tagId);
			if (hashSet == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in hashSet)
			{
				bool flag = skillButtonData.IsOccupy();
				if (flag == tagExist)
				{
					bool flag2;
					if (tagExist)
					{
						skillButtonData.SetNotOccupy();
						flag2 = true;
					}
					else
					{
						skillButtonData.RefreshIsOccupy();
						flag2 = (skillButtonData.IsOccupy() != flag);
					}
					if (flag2)
					{
						this.SkillIdChanged.Add(skillButtonData);
						this.EnableNextTick();
					}
				}
			}
		}

		// Token: 0x060325F4 RID: 206324 RVA: 0x00BB94AC File Offset: 0x00BB76AC
		private void OnSkillTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> skillButtonDataBySkillIdTag = base.GetSkillButtonDataBySkillIdTag(tagId);
			if (skillButtonDataBySkillIdTag == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in skillButtonDataBySkillIdTag)
			{
				int? num = new int?(skillButtonData.GetSkillId());
				if (tagExist)
				{
					skillButtonData.RefreshSkillIdByTag(tagId);
				}
				else
				{
					skillButtonData.RefreshSkillId();
				}
				int? num2 = new int?(skillButtonData.GetSkillId());
				int? num3 = num;
				int? num4 = num2;
				if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
				{
					skillButtonData.RefreshSkillTexturePath();
					skillButtonData.RefreshIsEnable();
					if (this.IsEnable)
					{
						this.SkillIdChanged.Add(skillButtonData);
						this.EnableNextTick();
					}
				}
			}
		}

		// Token: 0x060325F5 RID: 206325 RVA: 0x00BB9580 File Offset: 0x00BB7780
		private void OnSkillIconTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> skillButtonDataBySkillIconTag = base.GetSkillButtonDataBySkillIconTag(tagId);
			if (skillButtonDataBySkillIconTag == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in skillButtonDataBySkillIconTag)
			{
				string skillTexturePath = skillButtonData.GetSkillTexturePath();
				if (tagExist)
				{
					skillButtonData.RefreshSkillTexturePathBySkillIconTag(tagId);
				}
				else
				{
					skillButtonData.RefreshSkillTexturePath();
				}
				if (this.IsEnable)
				{
					string skillTexturePath2 = skillButtonData.GetSkillTexturePath();
					if (skillTexturePath != skillTexturePath2)
					{
						this.SkillIconChanged.Add(skillButtonData);
						this.EnableNextTick();
					}
				}
			}
		}

		// Token: 0x060325F6 RID: 206326 RVA: 0x00BB961C File Offset: 0x00BB781C
		private void OnDynamicEffectTagChanged(int tagId, bool tagExist)
		{
			HashSet<SkillButtonData> skillButtonDataByDynamicEffectTag = base.GetSkillButtonDataByDynamicEffectTag(tagId);
			if (skillButtonDataByDynamicEffectTag == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in skillButtonDataByDynamicEffectTag)
			{
				skillButtonData.RefreshDynamicEffect();
				if (this.IsEnable)
				{
					this.DynamicEffectChanged.Add(skillButtonData);
					this.EnableNextTick();
				}
			}
		}

		// Token: 0x060325F7 RID: 206327 RVA: 0x00BB9690 File Offset: 0x00BB7890
		private void OnCustomTagCountChanged(int count, int tagId, int exactTagId, int oldCount)
		{
			SkillButtonMapping<int> customHandleSkillButtonMapping = this.CustomHandleSkillButtonMapping;
			HashSet<SkillButtonData> hashSet = (customHandleSkillButtonMapping != null) ? customHandleSkillButtonMapping.Get(tagId) : null;
			if (hashSet == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in hashSet)
			{
				foreach (SkillButtonCustomHandleBase skillButtonCustomHandleBase in skillButtonData.CustomHandleList)
				{
					skillButtonCustomHandleBase.RefreshByTagChanged();
					base.CheckCustomHdModify(skillButtonCustomHandleBase, skillButtonData);
				}
			}
		}

		// Token: 0x060325F8 RID: 206328 RVA: 0x00BB973C File Offset: 0x00BB793C
		private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RefreshSkillButtonEnableByAttributeId(attributeId);
			HashSet<SkillButtonData> skillButtonDataByAttributeId = base.GetSkillButtonDataByAttributeId(attributeId);
			if (skillButtonDataByAttributeId == null)
			{
				return;
			}
			foreach (SkillButtonData item in skillButtonDataByAttributeId)
			{
				this.AttributeChanged.Add(item);
			}
			this.EnableNextTick();
		}

		// Token: 0x060325F9 RID: 206329 RVA: 0x00BB97AC File Offset: 0x00BB79AC
		public void RefreshSkillButtonEnableByAttributeId(EAttributeType attributeId)
		{
			HashSet<SkillButtonData> skillButtonDataByAttributeId = base.GetSkillButtonDataByAttributeId(attributeId);
			if (skillButtonDataByAttributeId == null)
			{
				return;
			}
			foreach (SkillButtonData skillButtonData in skillButtonDataByAttributeId)
			{
				bool flag = skillButtonData.IsEnable();
				skillButtonData.RefreshIsEnable();
				bool flag2 = skillButtonData.IsEnable();
				if (flag != flag2)
				{
					this.EnableChanged.Add(skillButtonData);
					this.EnableNextTick();
				}
			}
		}

		// Token: 0x060325FA RID: 206330 RVA: 0x00BB9828 File Offset: 0x00BB7A28
		public void RefreshEnableByInputEvent(EInputAction inputAction, bool enable)
		{
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				if (!(skillButtonData.GetActionType() != inputAction))
				{
					bool flag = skillButtonData.IsEnable();
					skillButtonData.RefreshIsEnable();
					if (this.IsEnable)
					{
						bool flag2 = skillButtonData.IsEnable();
						if (flag != flag2)
						{
							this.EnableChanged.Add(skillButtonData);
							this.EnableNextTick();
						}
					}
				}
			}
		}

		// Token: 0x060325FB RID: 206331 RVA: 0x00BB98BC File Offset: 0x00BB7ABC
		public void RefreshVisibleByInputEvent(EInputAction inputAction, bool visible)
		{
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				if (!(skillButtonData.GetActionType() != inputAction))
				{
					bool flag = skillButtonData.IsVisible();
					if (!visible)
					{
						skillButtonData.SetInvisible();
					}
					else
					{
						skillButtonData.RefreshIsVisible(true);
					}
					if (this.IsEnable)
					{
						bool flag2 = skillButtonData.IsVisible();
						if (flag != flag2)
						{
							this.VisibleChanged.Add(skillButtonData);
							this.EnableNextTick();
						}
					}
				}
			}
		}

		// Token: 0x060325FC RID: 206332 RVA: 0x00BB995C File Offset: 0x00BB7B5C
		public void RefreshEnableByButtonType(ESkillButtonType buttonType)
		{
			SkillButtonData skillButtonDataByButton = base.GetSkillButtonDataByButton(buttonType);
			if (skillButtonDataByButton == null)
			{
				return;
			}
			bool flag = skillButtonDataByButton.IsEnable();
			skillButtonDataByButton.RefreshIsEnable();
			if (!this.IsEnable)
			{
				return;
			}
			bool flag2 = skillButtonDataByButton.IsEnable();
			if (flag != flag2)
			{
				this.EnableChanged.Add(skillButtonDataByButton);
				this.EnableNextTick();
			}
		}

		// Token: 0x060325FD RID: 206333 RVA: 0x00BB99AC File Offset: 0x00BB7BAC
		public void RefreshVisibleByButtonType(ESkillButtonType buttonType)
		{
			SkillButtonData skillButtonDataByButton = base.GetSkillButtonDataByButton(buttonType);
			if (skillButtonDataByButton == null)
			{
				return;
			}
			bool flag = skillButtonDataByButton.IsVisible();
			skillButtonDataByButton.RefreshIsVisible(true);
			if (!this.IsEnable)
			{
				return;
			}
			bool flag2 = skillButtonDataByButton.IsVisible();
			if (flag != flag2)
			{
				this.VisibleChanged.Add(skillButtonDataByButton);
				this.EnableNextTick();
			}
		}

		// Token: 0x060325FE RID: 206334 RVA: 0x00BB99FC File Offset: 0x00BB7BFC
		public void RefreshSkillTexturePath(ESkillButtonType buttonType)
		{
			SkillButtonData skillButtonDataByButton = base.GetSkillButtonDataByButton(buttonType);
			if (skillButtonDataByButton == null)
			{
				return;
			}
			string skillTexturePath = skillButtonDataByButton.GetSkillTexturePath();
			skillButtonDataByButton.RefreshSkillTexturePath();
			if (!this.IsEnable)
			{
				return;
			}
			if (skillTexturePath != skillButtonDataByButton.GetSkillTexturePath())
			{
				this.SkillIconChanged.Add(skillButtonDataByButton);
				this.EnableNextTick();
			}
		}

		// Token: 0x060325FF RID: 206335 RVA: 0x00BB9A4C File Offset: 0x00BB7C4C
		public void RefreshSkillCd(int skillId)
		{
			foreach (SkillButtonData skillButtonData in this.SkillButtonDataMap.Values)
			{
				if (skillButtonData.GetSkillId() == skillId)
				{
					skillButtonData.RefreshIsEnable();
					if (this.IsEnable && skillButtonData.IsOccupy())
					{
						this.SkillCdChanged.Add(skillButtonData);
						this.EnableNextTick();
					}
				}
			}
		}

		// Token: 0x06032600 RID: 206336 RVA: 0x00BB9AD0 File Offset: 0x00BB7CD0
		private void ClearAllEvent()
		{
			this.ClearNextTick();
		}

		// Token: 0x06032601 RID: 206337 RVA: 0x00BB9AD8 File Offset: 0x00BB7CD8
		public BehaviorButtonData GetBehaviorButtonDataByButton(int buttonType)
		{
			return null;
		}

		// Token: 0x0401ACD8 RID: 109784
		public bool IsEnable;

		// Token: 0x0401ACD9 RID: 109785
		public int PbDataId;

		// Token: 0x0401ACDA RID: 109786
		public IReadOnlyList<SkillFollowerButton> SkillButtonConfigList;

		// Token: 0x0401ACDB RID: 109787
		public SkillButtonMapping<int> NotOccupyTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x0401ACDC RID: 109788
		private TimerHandle NextTickTimerId;

		// Token: 0x0401ACDD RID: 109789
		private bool SkillButtonDataRefresh;

		// Token: 0x0401ACDE RID: 109790
		private ESkillButtonRefreshReason SkillButtonDataRefreshReason = ESkillButtonRefreshReason.None;
	}
}
