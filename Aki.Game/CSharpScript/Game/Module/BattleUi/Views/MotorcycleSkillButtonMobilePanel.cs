using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DA2 RID: 23970
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleSkillButtonMobilePanel : UiPanelBase
	{
		// Token: 0x0603CDB2 RID: 249266 RVA: 0x00E9E05C File Offset: 0x00E9C25C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603CDB3 RID: 249267 RVA: 0x00E9E1D0 File Offset: 0x00E9C3D0
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleSkillButtonMobilePanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603CDB4 RID: 249268 RVA: 0x00E9E213 File Offset: 0x00E9C413
		protected override void OnBeforeDestroy()
		{
			this.BattleSkillItemList.Clear();
			this.BehaviorButtonMap.Clear();
			BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.MotorcycleMobileSkillButton, new Action(this.OnSkillButtonVisibleChanged));
		}

		// Token: 0x0603CDB5 RID: 249269 RVA: 0x00E9E248 File Offset: 0x00E9C448
		protected override void OnAfterShow()
		{
			this.AddEvents();
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshEnable(true);
			}
			foreach (BehaviorButton behaviorButton in this.BehaviorButtonMap.Values)
			{
				behaviorButton.UpdateAlpha();
			}
			this.DataDirty = true;
		}

		// Token: 0x0603CDB6 RID: 249270 RVA: 0x00E9E2EC File Offset: 0x00E9C4EC
		protected override void OnBeforeHide()
		{
			this.RemoveEvents();
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				if (battleSkillItem.IsShowOrShowing)
				{
					battleSkillItem.TryReleaseButton();
				}
			}
		}

		// Token: 0x0603CDB7 RID: 249271 RVA: 0x00E9E34C File Offset: 0x00E9C54C
		protected override void OnBeforeShow()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshSkillCoolDownOnShow();
			}
		}

		// Token: 0x0603CDB8 RID: 249272 RVA: 0x00E9E39C File Offset: 0x00E9C59C
		public void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (this.DataDirty)
			{
				this.DataDirty = false;
				this.RefreshAllBattleSkillItems();
				this.RefreshAllBehaviorButton();
			}
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Tick(delta);
			}
		}

		// Token: 0x0603CDB9 RID: 249273 RVA: 0x00E9E414 File Offset: 0x00E9C614
		private void RefreshAllBattleSkillItems()
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			IList<int> motorPadButtonTypeList = instance.GetMotorPadButtonTypeList();
			for (int i = 0; i < this.BattleSkillItemList.Count; i++)
			{
				int num = (motorPadButtonTypeList.Count > i) ? motorPadButtonTypeList[i] : 0;
				BattleSkillItem battleSkillItem = this.BattleSkillItemList[i];
				SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)num);
				if (skillButtonDataByButton == null)
				{
					battleSkillItem.Deactivate();
				}
				else if (num == 0)
				{
					battleSkillItem.Deactivate();
				}
				else if (num < 0)
				{
					battleSkillItem.Deactivate();
				}
				else
				{
					skillButtonDataByButton.GetSkillId();
					battleSkillItem.Refresh(skillButtonDataByButton);
				}
			}
		}

		// Token: 0x0603CDBA RID: 249274 RVA: 0x00E9E4A8 File Offset: 0x00E9C6A8
		private void DeactivateAllBattleSkillItems()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Deactivate();
			}
		}

		// Token: 0x0603CDBB RID: 249275 RVA: 0x00E9E4F8 File Offset: 0x00E9C6F8
		public UniTask NewAllBattleSkillItems()
		{
			MotorcycleSkillButtonMobilePanel.<NewAllBattleSkillItems>d__17 <NewAllBattleSkillItems>d__;
			<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBattleSkillItems>d__.<>4__this = this;
			<NewAllBattleSkillItems>d__.<>1__state = -1;
			<NewAllBattleSkillItems>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewAllBattleSkillItems>d__17>(ref <NewAllBattleSkillItems>d__);
			return <NewAllBattleSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603CDBC RID: 249276 RVA: 0x00E9E53C File Offset: 0x00E9C73C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleSkillItem> NewBattleSkillItem(AActor rootActor, int inputIndex)
		{
			MotorcycleSkillButtonMobilePanel.<NewBattleSkillItem>d__18 <NewBattleSkillItem>d__;
			<NewBattleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleSkillItem>.Create();
			<NewBattleSkillItem>d__.<>4__this = this;
			<NewBattleSkillItem>d__.rootActor = rootActor;
			<NewBattleSkillItem>d__.inputIndex = inputIndex;
			<NewBattleSkillItem>d__.<>1__state = -1;
			<NewBattleSkillItem>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewBattleSkillItem>d__18>(ref <NewBattleSkillItem>d__);
			return <NewBattleSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603CDBD RID: 249277 RVA: 0x00E9E58F File Offset: 0x00E9C78F
		private BattleSkillItem GetBattleSkillItem(int inputIndex)
		{
			return this.BattleSkillItemList[inputIndex];
		}

		// Token: 0x0603CDBE RID: 249278 RVA: 0x00E9E5A0 File Offset: 0x00E9C7A0
		[NullableContext(2)]
		public BattleSkillItem GetBattleSkillItemByButtonType(ESkillButtonType buttonType)
		{
			int motorPadSkillButtonIndexByButton = SkillButtonUiModel.Instance.GetMotorPadSkillButtonIndexByButton((int)buttonType);
			if (motorPadSkillButtonIndexByButton < 0)
			{
				return null;
			}
			return this.GetBattleSkillItem(motorPadSkillButtonIndexByButton);
		}

		// Token: 0x0603CDBF RID: 249279 RVA: 0x00E9E5C8 File Offset: 0x00E9C7C8
		private UniTask NewAllBehaviorButton()
		{
			MotorcycleSkillButtonMobilePanel.<NewAllBehaviorButton>d__21 <NewAllBehaviorButton>d__;
			<NewAllBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBehaviorButton>d__.<>4__this = this;
			<NewAllBehaviorButton>d__.<>1__state = -1;
			<NewAllBehaviorButton>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewAllBehaviorButton>d__21>(ref <NewAllBehaviorButton>d__);
			return <NewAllBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603CDC0 RID: 249280 RVA: 0x00E9E60C File Offset: 0x00E9C80C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BehaviorButton> NewBehaviorButton(AActor rootActor, EBehaviorType inputActionType)
		{
			MotorcycleSkillButtonMobilePanel.<NewBehaviorButton>d__22 <NewBehaviorButton>d__;
			<NewBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BehaviorButton>.Create();
			<NewBehaviorButton>d__.<>4__this = this;
			<NewBehaviorButton>d__.rootActor = rootActor;
			<NewBehaviorButton>d__.inputActionType = inputActionType;
			<NewBehaviorButton>d__.<>1__state = -1;
			<NewBehaviorButton>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewBehaviorButton>d__22>(ref <NewBehaviorButton>d__);
			return <NewBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603CDC1 RID: 249281 RVA: 0x00E9E660 File Offset: 0x00E9C860
		private void RefreshAllBehaviorButton()
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			foreach (BehaviorButton behaviorButton in this.BehaviorButtonMap.Values)
			{
				BehaviorButtonData behaviorButtonDataByButton = instance.GetBehaviorButtonDataByButton(behaviorButton.BehaviorType);
				if (behaviorButtonDataByButton != null)
				{
					behaviorButton.Refresh(behaviorButtonDataByButton);
				}
			}
		}

		// Token: 0x0603CDC2 RID: 249282 RVA: 0x00E9E6D0 File Offset: 0x00E9C8D0
		[NullableContext(2)]
		private BehaviorButton GetBehaviorButton(EBehaviorType inputActionType)
		{
			return this.BehaviorButtonMap.GetValueOrDefault(inputActionType);
		}

		// Token: 0x0603CDC3 RID: 249283 RVA: 0x00E9E6E0 File Offset: 0x00E9C8E0
		protected void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnSetUiVisible));
			EventSystem.Instance.Add<ESkillButtonRefreshReason>(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Add(EEventName.OnSkillButtonDataClear, new Action(this.OnSkillButtonDataClear));
			EventSystem.Instance.Add(EEventName.OnMotorPadSkillButtonIndexRefresh, new Action(this.OnSkillButtonIndexRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int>(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int, int>(EEventName.OnSkillButtonCustomRefresh, new Action<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Add<bool>(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
		}

		// Token: 0x0603CDC4 RID: 249284 RVA: 0x00E9E950 File Offset: 0x00E9CB50
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnSetUiVisible));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataClear, new Action(this.OnSkillButtonDataClear));
			EventSystem.Instance.Remove(EEventName.OnMotorPadSkillButtonIndexRefresh, new Action(this.OnSkillButtonIndexRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCustomRefresh, new Action<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Remove(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
		}

		// Token: 0x0603CDC5 RID: 249285 RVA: 0x00E9EBC0 File Offset: 0x00E9CDC0
		private void OnSetUiVisible(bool bVisible)
		{
			if (bVisible)
			{
				foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
				{
					battleSkillItem.RefreshEnable(true);
				}
			}
		}

		// Token: 0x0603CDC6 RID: 249286 RVA: 0x00E9EC14 File Offset: 0x00E9CE14
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			if (refreshReason == ESkillButtonRefreshReason.GamepadRefreshAimState || refreshReason == ESkillButtonRefreshReason.GamepadRefreshKeyAction)
			{
				return;
			}
			this.DataDirty = true;
		}

		// Token: 0x0603CDC7 RID: 249287 RVA: 0x00E9EC26 File Offset: 0x00E9CE26
		private void OnSkillButtonDataClear()
		{
			this.DeactivateAllBattleSkillItems();
		}

		// Token: 0x0603CDC8 RID: 249288 RVA: 0x00E9EC2E File Offset: 0x00E9CE2E
		private void OnSkillButtonIndexRefresh()
		{
			if (!BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				return;
			}
			this.DataDirty = true;
		}

		// Token: 0x0603CDC9 RID: 249289 RVA: 0x00E9EC4C File Offset: 0x00E9CE4C
		private void OnSkillButtonEnableRefresh(ESkillButtonType buttonType, int extendCoolDown)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (battleSkillItemByButtonType.GetSkillButtonData() == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshEnable(false);
		}

		// Token: 0x0603CDCA RID: 249290 RVA: 0x00E9EC78 File Offset: 0x00E9CE78
		private void OnSkillButtonVisibleRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (battleSkillItemByButtonType.GetSkillButtonData() == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshVisible();
			battleSkillItemByButtonType.RefreshKey();
		}

		// Token: 0x0603CDCB RID: 249291 RVA: 0x00E9ECA8 File Offset: 0x00E9CEA8
		private void OnSkillButtonDynamicEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (battleSkillItemByButtonType.GetSkillButtonData() == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshDynamicEffect();
		}

		// Token: 0x0603CDCC RID: 249292 RVA: 0x00E9ECD0 File Offset: 0x00E9CED0
		private void OnSkillButtonCustomRefresh(ESkillButtonType buttonType, int from, int param)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshCustomHdData(from, param);
			}
		}

		// Token: 0x0603CDCD RID: 249293 RVA: 0x00E9ECFC File Offset: 0x00E9CEFC
		private void OnSkillButtonSkillIdRefresh(ESkillButtonType actionType)
		{
			SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(actionType);
			if (skillButtonDataByButton == null)
			{
				return;
			}
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(actionType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			skillButtonDataByButton.GetSkillId();
			battleSkillItemByButtonType.Refresh(skillButtonDataByButton);
		}

		// Token: 0x0603CDCE RID: 249294 RVA: 0x00E9ED34 File Offset: 0x00E9CF34
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshAttribute(true);
		}

		// Token: 0x0603CDCF RID: 249295 RVA: 0x00E9ED54 File Offset: 0x00E9CF54
		private void OnSkillButtonIconPathRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillIcon();
			battleSkillItemByButtonType.RefreshSkillName();
		}

		// Token: 0x0603CDD0 RID: 249296 RVA: 0x00E9ED7C File Offset: 0x00E9CF7C
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillCoolDown();
		}

		// Token: 0x0603CDD1 RID: 249297 RVA: 0x00E9ED9C File Offset: 0x00E9CF9C
		private void OnSkillButtonLongPressRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillButtonLongPress();
			battleSkillItemByButtonType.RefreshConfigLongPress(-1, 0);
		}

		// Token: 0x0603CDD2 RID: 249298 RVA: 0x00E9EDC4 File Offset: 0x00E9CFC4
		private void OnSkillButtonExtraEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshExtraEffect();
		}

		// Token: 0x0603CDD3 RID: 249299 RVA: 0x00E9EDE4 File Offset: 0x00E9CFE4
		private void OnBehaviorButtonEnableRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshEnable(false);
		}

		// Token: 0x0603CDD4 RID: 249300 RVA: 0x00E9EE04 File Offset: 0x00E9D004
		private void OnBehaviorButtonVisibleRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshVisible();
		}

		// Token: 0x0603CDD5 RID: 249301 RVA: 0x00E9EE24 File Offset: 0x00E9D024
		private void OnBehaviorButtonSkillIdRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshAll();
		}

		// Token: 0x0603CDD6 RID: 249302 RVA: 0x00E9EE44 File Offset: 0x00E9D044
		private void OnBehaviorButtonIconPathRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshSkillIcon();
		}

		// Token: 0x0603CDD7 RID: 249303 RVA: 0x00E9EE64 File Offset: 0x00E9D064
		private void OnBehaviorButtonDynamicEffectRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshDynamicEffect();
		}

		// Token: 0x0603CDD8 RID: 249304 RVA: 0x00E9EE84 File Offset: 0x00E9D084
		private void OnPauseGame(int flag)
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.PauseGame(flag);
			}
		}

		// Token: 0x0603CDD9 RID: 249305 RVA: 0x00E9EED8 File Offset: 0x00E9D0D8
		private void OnChangedTimeScale()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshTimeDilation();
			}
		}

		// Token: 0x0603CDDA RID: 249306 RVA: 0x00E9EF28 File Offset: 0x00E9D128
		private void OnCharSkillCdPauseStateChanged(bool _)
		{
			this.OnChangedTimeScale();
		}

		// Token: 0x0603CDDB RID: 249307 RVA: 0x00E9EF30 File Offset: 0x00E9D130
		private void OnSkillButtonVisibleChanged()
		{
			bool visible = this.GetVisible();
			this.BaseVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.MotorcycleMobileSkillButton);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x0603CDDC RID: 249308 RVA: 0x00E9EF64 File Offset: 0x00E9D164
		public override void SetActive(bool visibility)
		{
			if (this.GetVisible() != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "战斗子界面不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x0603CDDD RID: 249309 RVA: 0x00E9EFA0 File Offset: 0x00E9D1A0
		public void SetVisible(int visibleReason, bool bVisible)
		{
			bool visible = this.GetVisible();
			this.SetVisibleInner(visibleReason, bVisible);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x0603CDDE RID: 249310 RVA: 0x00E9EFC3 File Offset: 0x00E9D1C3
		private void SetVisibleInner(int visibleReason, bool bVisible)
		{
			this.InnerVisibleState = VisibleStateUtil.SetVisible(this.InnerVisibleState, bVisible, visibleReason);
		}

		// Token: 0x0603CDDF RID: 249311 RVA: 0x00E9EFD8 File Offset: 0x00E9D1D8
		public bool GetVisible()
		{
			return this.BaseVisible && this.InnerVisibleState == 0;
		}

		// Token: 0x0603CDE0 RID: 249312 RVA: 0x00E9EFF0 File Offset: 0x00E9D1F0
		private void CheckVisibleChange(bool oldVisible)
		{
			bool visible = this.GetVisible();
			if (oldVisible == visible)
			{
				return;
			}
			this.SetActive(visible);
		}

		// Token: 0x0401FB42 RID: 129858
		private const int MOBILE_INDEX_EXPLORE_ITEM = 3;

		// Token: 0x0401FB43 RID: 129859
		private readonly List<BattleSkillItem> BattleSkillItemList = new List<BattleSkillItem>();

		// Token: 0x0401FB44 RID: 129860
		private readonly Dictionary<EBehaviorType, BehaviorButton> BehaviorButtonMap = new Dictionary<EBehaviorType, BehaviorButton>();

		// Token: 0x0401FB45 RID: 129861
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshAllBattleSkillItemObject = Stat.Create("[SkillButton]RefreshAllBattleSkillItem", "", "");

		// Token: 0x0401FB46 RID: 129862
		private bool BaseVisible;

		// Token: 0x0401FB47 RID: 129863
		private int InnerVisibleState = 1;

		// Token: 0x0401FB48 RID: 129864
		private bool DataDirty;

		// Token: 0x0200C07A RID: 49274
		[NullableContext(0)]
		private enum EPadChildType
		{
			// Token: 0x0403A151 RID: 237905
			SkillItem1,
			// Token: 0x0403A152 RID: 237906
			SkillItem2,
			// Token: 0x0403A153 RID: 237907
			SkillItem3,
			// Token: 0x0403A154 RID: 237908
			SkillItem4,
			// Token: 0x0403A155 RID: 237909
			SkillItem5,
			// Token: 0x0403A156 RID: 237910
			SkillItem6,
			// Token: 0x0403A157 RID: 237911
			SkillItem7,
			// Token: 0x0403A158 RID: 237912
			LockButtonItem,
			// Token: 0x0403A159 RID: 237913
			AimItem,
			// Token: 0x0403A15A RID: 237914
			SkillItem8
		}
	}
}
