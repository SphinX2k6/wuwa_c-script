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
	// Token: 0x02003BB8 RID: 15288
	[NullableContext(2)]
	[Nullable(0)]
	public class SkillButtonFollowerEntityData : SkillButtonEntityDataBase
	{
		// Token: 0x06027393 RID: 160659 RVA: 0x00AFD09C File Offset: 0x00AFB29C
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

		// Token: 0x06027394 RID: 160660 RVA: 0x00AFD12E File Offset: 0x00AFB32E
		public void SetEnable(bool bEnable)
		{
			this.IsEnable = bEnable;
			this.IsCurEntity = bEnable;
			this.RefreshAllSkillButton();
		}

		// Token: 0x06027395 RID: 160661 RVA: 0x00AFD144 File Offset: 0x00AFB344
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

		// Token: 0x06027396 RID: 160662 RVA: 0x00AFD1B0 File Offset: 0x00AFB3B0
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

		// Token: 0x06027397 RID: 160663 RVA: 0x00AFD1F0 File Offset: 0x00AFB3F0
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

		// Token: 0x06027398 RID: 160664 RVA: 0x00AFD26C File Offset: 0x00AFB46C
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

		// Token: 0x06027399 RID: 160665 RVA: 0x00AFD41C File Offset: 0x00AFB61C
		private void AddEntityEvents()
		{
			this.ListenEntityTag();
			this.ListenEntityAttribute();
		}

		// Token: 0x0602739A RID: 160666 RVA: 0x00AFD42C File Offset: 0x00AFB62C
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

		// Token: 0x0602739B RID: 160667 RVA: 0x00AFD7C0 File Offset: 0x00AFB9C0
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

		// Token: 0x0602739C RID: 160668 RVA: 0x00AFD858 File Offset: 0x00AFBA58
		protected override void EnableNextTick()
		{
			if (this.NextTickTimerId != null)
			{
				return;
			}
			this.NextTickTimerId = TimerSystem.Instance.Next(new TTimerAction(this.NextTick), SkillButtonEntityDataBase.NextTickStat, null);
		}

		// Token: 0x0602739D RID: 160669 RVA: 0x00AFD888 File Offset: 0x00AFBA88
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

		// Token: 0x0602739E RID: 160670 RVA: 0x00AFD918 File Offset: 0x00AFBB18
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

		// Token: 0x0602739F RID: 160671 RVA: 0x00AFDC5C File Offset: 0x00AFBE5C
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

		// Token: 0x060273A0 RID: 160672 RVA: 0x00AFDC8C File Offset: 0x00AFBE8C
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

		// Token: 0x060273A1 RID: 160673 RVA: 0x00AFDDEC File Offset: 0x00AFBFEC
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

		// Token: 0x060273A2 RID: 160674 RVA: 0x00AFDE90 File Offset: 0x00AFC090
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

		// Token: 0x060273A3 RID: 160675 RVA: 0x00AFDF90 File Offset: 0x00AFC190
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

		// Token: 0x060273A4 RID: 160676 RVA: 0x00AFE030 File Offset: 0x00AFC230
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

		// Token: 0x060273A5 RID: 160677 RVA: 0x00AFE104 File Offset: 0x00AFC304
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

		// Token: 0x060273A6 RID: 160678 RVA: 0x00AFE1A0 File Offset: 0x00AFC3A0
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

		// Token: 0x060273A7 RID: 160679 RVA: 0x00AFE214 File Offset: 0x00AFC414
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

		// Token: 0x060273A8 RID: 160680 RVA: 0x00AFE2C0 File Offset: 0x00AFC4C0
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

		// Token: 0x060273A9 RID: 160681 RVA: 0x00AFE330 File Offset: 0x00AFC530
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

		// Token: 0x060273AA RID: 160682 RVA: 0x00AFE3AC File Offset: 0x00AFC5AC
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

		// Token: 0x060273AB RID: 160683 RVA: 0x00AFE440 File Offset: 0x00AFC640
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

		// Token: 0x060273AC RID: 160684 RVA: 0x00AFE4E0 File Offset: 0x00AFC6E0
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

		// Token: 0x060273AD RID: 160685 RVA: 0x00AFE530 File Offset: 0x00AFC730
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

		// Token: 0x060273AE RID: 160686 RVA: 0x00AFE580 File Offset: 0x00AFC780
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

		// Token: 0x060273AF RID: 160687 RVA: 0x00AFE5D0 File Offset: 0x00AFC7D0
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

		// Token: 0x060273B0 RID: 160688 RVA: 0x00AFE654 File Offset: 0x00AFC854
		private void ClearAllEvent()
		{
			this.ClearNextTick();
		}

		// Token: 0x060273B1 RID: 160689 RVA: 0x00AFE65C File Offset: 0x00AFC85C
		public BehaviorButtonData GetBehaviorButtonDataByButton(int buttonType)
		{
			return null;
		}

		// Token: 0x04015634 RID: 87604
		public bool IsEnable;

		// Token: 0x04015635 RID: 87605
		public int PbDataId;

		// Token: 0x04015636 RID: 87606
		public IReadOnlyList<SkillFollowerButton> SkillButtonConfigList;

		// Token: 0x04015637 RID: 87607
		public SkillButtonMapping<int> NotOccupyTagSkillButtonMapping = new SkillButtonMapping<int>();

		// Token: 0x04015638 RID: 87608
		private TimerHandle NextTickTimerId;

		// Token: 0x04015639 RID: 87609
		private bool SkillButtonDataRefresh;

		// Token: 0x0401563A RID: 87610
		private ESkillButtonRefreshReason SkillButtonDataRefreshReason = ESkillButtonRefreshReason.None;
	}
}
