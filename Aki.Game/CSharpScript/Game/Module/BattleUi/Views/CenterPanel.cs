using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.AutoPilot;
using CSharpScript.Game.Module.QuickHack;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CB9 RID: 23737
	[NullableContext(2)]
	[Nullable(0)]
	public class CenterPanel : BattleChildViewPanel
	{
		// Token: 0x0603BFB3 RID: 245683 RVA: 0x00E563C0 File Offset: 0x00E545C0
		protected unsafe override void OnRegisterComponent()
		{
			EOperationType operationType = base.GetOperationType();
			if (operationType == EOperationType.Desktop)
			{
				int num = 3;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				return;
			}
			if (operationType == EOperationType.Pad)
			{
				int num2 = 5;
				List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
				int num = 0;
				*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				this.ComponentRegisterInfos = list2;
			}
		}

		// Token: 0x0603BFB4 RID: 245684 RVA: 0x00E5651C File Offset: 0x00E5471C
		public override void InitializeTemp()
		{
			this.OnBattleHudVisibleChanged();
			this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x0603BFB5 RID: 245685 RVA: 0x00E56534 File Offset: 0x00E54734
		public override UniTask InitializeAsync()
		{
			CenterPanel.<InitializeAsync>d__30 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<CenterPanel.<InitializeAsync>d__30>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFB6 RID: 245686 RVA: 0x00E56578 File Offset: 0x00E54778
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			Joystick joystick = this.Joystick;
			if (joystick != null)
			{
				joystick.ShowBattleVisibleChildView();
			}
			this.RefreshJoystickEnable();
			TrackedMarksView trackedMarksView = this.TrackedMarksView;
			if (trackedMarksView != null)
			{
				trackedMarksView.OnShowBattleChildViewPanel();
			}
			AutoPilotTrackedMarksView autoPilotTrackedMarksView = this.AutoPilotTrackedMarksView;
			if (autoPilotTrackedMarksView != null)
			{
				autoPilotTrackedMarksView.OnShowBattleChildViewPanel();
			}
			MotorcycleControlTopPanel motorcycleControlTopPanel = this.MotorcycleControlTopPanel;
			if (motorcycleControlTopPanel != null)
			{
				motorcycleControlTopPanel.OnShowBattleChildViewPanel();
			}
			QuickHackMarksView quickHackMarksView = this.QuickHackMarksView;
			if (quickHackMarksView == null)
			{
				return;
			}
			quickHackMarksView.OnShowBattleChildViewPanel();
		}

		// Token: 0x0603BFB7 RID: 245687 RVA: 0x00E565E0 File Offset: 0x00E547E0
		protected override void OnHideBattleChildViewPanel()
		{
			Joystick joystick = this.Joystick;
			if (joystick != null)
			{
				joystick.HideBattleVisibleChildView();
			}
			TrackedMarksView trackedMarksView = this.TrackedMarksView;
			if (trackedMarksView != null)
			{
				trackedMarksView.OnHideBattleChildViewPanel();
			}
			AutoPilotTrackedMarksView autoPilotTrackedMarksView = this.AutoPilotTrackedMarksView;
			if (autoPilotTrackedMarksView != null)
			{
				autoPilotTrackedMarksView.OnHideBattleChildViewPanel();
			}
			MotorcycleControlTopPanel motorcycleControlTopPanel = this.MotorcycleControlTopPanel;
			if (motorcycleControlTopPanel == null)
			{
				return;
			}
			motorcycleControlTopPanel.OnHideBattleChildViewPanel();
		}

		// Token: 0x0603BFB8 RID: 245688 RVA: 0x00E56630 File Offset: 0x00E54830
		public void SetEventVisible(bool value)
		{
		}

		// Token: 0x0603BFB9 RID: 245689 RVA: 0x00E56634 File Offset: 0x00E54834
		public override void Reset()
		{
			this.TrackedMarksView = null;
			this.AutoPilotTrackedMarksView = null;
			this.AlterMarksView = null;
			this.Joystick = null;
			GrapplingHookPoint hookPointMakerPanel = this.HookPointMakerPanel;
			if (hookPointMakerPanel != null)
			{
				hookPointMakerPanel.Destroy(null);
			}
			this.HookPointMakerPanel = null;
			ExecutionPanel executionPanel = this.ExecutionPanel;
			if (executionPanel != null)
			{
				executionPanel.Destroy(null);
			}
			this.ExecutionPanel = null;
			BreakWeaknessPanel breakWeaknessPanel = this.BreakWeaknessPanel;
			if (breakWeaknessPanel != null)
			{
				breakWeaknessPanel.Destroy(null);
			}
			this.BreakWeaknessPanel = null;
			if (this.MotorcycleControlPanel != null)
			{
				this.MotorcycleControlPanel.Destroy(null);
				this.MotorcycleControlPanel = null;
			}
			if (this.MotorcycleControlTopPanel != null)
			{
				this.MotorcycleControlTopPanel.Destroy(null);
				this.MotorcycleControlTopPanel = null;
			}
			if (this.MotorcycleControlHudPanel != null)
			{
				this.MotorcycleControlHudPanel.Destroy(null);
				this.MotorcycleControlHudPanel = null;
			}
			if (this.SlideControlComponent != null)
			{
				this.SlideControlComponent.Destroy(null);
				this.SlideControlComponent = null;
				BattleUiModel.Instance.SlideControlData.ForceStop();
			}
			this.EntityList.Clear();
			base.Reset();
		}

		// Token: 0x0603BFBA RID: 245690 RVA: 0x00E56734 File Offset: 0x00E54934
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRoleCompleted));
			EventSystem.Instance.Add(EEventName.ExploreComponentTargetChanged, new Action(this.OnExploreComponentTargetChanged));
			EventSystem.Instance.Add(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
			EventSystem.Instance.Add<bool, int, ECustomOptionType?>(EEventName.OnEnterOrExitExecutionRange, new Action<bool, int, ECustomOptionType?>(this.OnEnterOrExitExecutionRange));
			EventSystem.Instance.Add(EEventName.GmOnlyShowJoyStick, new Action<bool>(this.OnGmOnlyShowJoyStick));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
			EventSystem.Instance.Add(EEventName.EnableGrapplingHookMark, new Action<bool>(this.OnEnableGrapplingHookMark));
			EventSystem.Instance.Add(EEventName.OnSetBattleUiChildCacheState, new Action<EBattleUiChildCacheType, bool>(this.OnSetBattleUiChildCacheState));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiSlideControlVisibleChanged, new Action<bool>(this.OnSlideControlVisibleChanged));
			EventSystem.Instance.Add<bool>(EEventName.OnMotorcycleRoundJoystickChanged, new Action<bool>(this.OnMotorcycleRoundJoystickChanged));
			EventSystem.Instance.Add(EEventName.OnAutoPilotTrackMarkVisibleChanged, new Action<bool>(this.OnAutoPilotTrackMarkVisibleChanged));
			this.ChildViewData.AddCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleHudVisibleChanged));
		}

		// Token: 0x0603BFBB RID: 245691 RVA: 0x00E56890 File Offset: 0x00E54A90
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnChangeRoleCompleted));
			EventSystem.Instance.Remove(EEventName.ExploreComponentTargetChanged, new Action(this.OnExploreComponentTargetChanged));
			EventSystem.Instance.Remove(EEventName.OnRouletteViewVisibleChanged, new Action<bool>(this.OnRouletteViewVisibleChanged));
			EventSystem.Instance.Remove(EEventName.OnEnterOrExitExecutionRange, new Action<bool, int, ECustomOptionType?>(this.OnEnterOrExitExecutionRange));
			EventSystem.Instance.Remove(EEventName.GmOnlyShowJoyStick, new Action<bool>(this.OnGmOnlyShowJoyStick));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
			EventSystem.Instance.Remove(EEventName.EnableGrapplingHookMark, new Action<bool>(this.OnEnableGrapplingHookMark));
			EventSystem.Instance.Remove(EEventName.OnSetBattleUiChildCacheState, new Action<EBattleUiChildCacheType, bool>(this.OnSetBattleUiChildCacheState));
			EventSystem.Instance.Remove(EEventName.BattleUiSlideControlVisibleChanged, new Action<bool>(this.OnSlideControlVisibleChanged));
			EventSystem.Instance.Remove(EEventName.OnMotorcycleRoundJoystickChanged, new Action<bool>(this.OnMotorcycleRoundJoystickChanged));
			EventSystem.Instance.Remove(EEventName.OnAutoPilotTrackMarkVisibleChanged, new Action<bool>(this.OnAutoPilotTrackMarkVisibleChanged));
			this.ChildViewData.RemoveCallback(EBattleUiChild.BattleHud, new Action(this.OnBattleHudVisibleChanged));
		}

		// Token: 0x0603BFBC RID: 245692 RVA: 0x00E569EC File Offset: 0x00E54BEC
		public override void OnTickBattleChildViewPanel(float delta)
		{
			Joystick joystick = this.Joystick;
			if (joystick != null)
			{
				joystick.Tick(delta);
			}
			IBattleUiCenterPanelOtherMovePanel otherMovePanel = this.OtherMovePanel;
			if (otherMovePanel != null)
			{
				otherMovePanel.Tick(delta);
			}
			MotorcycleControlPanelBase motorcycleControlPanel = this.MotorcycleControlPanel;
			if (motorcycleControlPanel != null)
			{
				motorcycleControlPanel.Tick(delta);
			}
			MotorcycleControlTopPanel motorcycleControlTopPanel = this.MotorcycleControlTopPanel;
			if (motorcycleControlTopPanel != null)
			{
				motorcycleControlTopPanel.Tick(delta);
			}
			MotorcycleControlHudPanel motorcycleControlHudPanel = this.MotorcycleControlHudPanel;
			if (motorcycleControlHudPanel != null)
			{
				motorcycleControlHudPanel.Tick(delta);
			}
			BattleSkillSlideControlItem slideControlComponent = this.SlideControlComponent;
			if (slideControlComponent != null)
			{
				slideControlComponent.Tick(delta);
			}
			this.AlterMarksView.Update(delta);
			this.UpdateHookPointPosition();
			BreakWeaknessPanel breakWeaknessPanel = this.BreakWeaknessPanel;
			if (breakWeaknessPanel == null)
			{
				return;
			}
			breakWeaknessPanel.Tick(delta);
		}

		// Token: 0x0603BFBD RID: 245693 RVA: 0x00E56A88 File Offset: 0x00E54C88
		public override void OnAfterTickBattleChildViewPanel(float delta)
		{
			TrackedMarksView trackedMarksView = this.TrackedMarksView;
			if (trackedMarksView != null)
			{
				trackedMarksView.Update(delta);
			}
			this.ScanTrackedMarksView.Update();
			this.GrapplingHookPointAfterTick();
			AutoPilotTrackedMarksView autoPilotTrackedMarksView = this.AutoPilotTrackedMarksView;
			if (autoPilotTrackedMarksView != null)
			{
				autoPilotTrackedMarksView.Update(delta);
			}
			QuickHackMarksView quickHackMarksView = this.QuickHackMarksView;
			if (quickHackMarksView == null)
			{
				return;
			}
			quickHackMarksView.Update();
		}

		// Token: 0x0603BFBE RID: 245694 RVA: 0x00E56ADA File Offset: 0x00E54CDA
		private void OnExploreComponentTargetChanged()
		{
			this.UpdateHookPointMarker();
		}

		// Token: 0x0603BFBF RID: 245695 RVA: 0x00E56AE4 File Offset: 0x00E54CE4
		private void OnBattleHudVisibleChanged()
		{
			bool childVisible = this.ChildViewData.GetChildVisible(EBattleUiChild.BattleHud);
			base.GetItem(0).SetUIActive(childVisible);
			AlterMarksView alterMarksView = this.AlterMarksView;
			if (alterMarksView == null)
			{
				return;
			}
			alterMarksView.OnBattleHudVisibleChanged(childVisible);
		}

		// Token: 0x0603BFC0 RID: 245696 RVA: 0x00E56B1D File Offset: 0x00E54D1D
		private void OnEnableGrapplingHookMark(bool isEnable)
		{
			this.ForceHideHookPointMaker = !isEnable;
		}

		// Token: 0x0603BFC1 RID: 245697 RVA: 0x00E56B2C File Offset: 0x00E54D2C
		private void OnRouletteViewVisibleChanged(bool bVisible)
		{
			UUIItem item = base.GetItem(2);
			item.SetUIActive(bVisible);
			item.SetRaycastTarget(bVisible);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BattleUiSet;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "轮盘界面显隐，设置CenterPanel遮罩";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bVisible", bVisible);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603BFC2 RID: 245698 RVA: 0x00E56B7C File Offset: 0x00E54D7C
		private void OnEnterOrExitExecutionRange(bool isEnter, int entityId, ECustomOptionType? optionType)
		{
			if (isEnter)
			{
				if (optionType.GetValueOrDefault() == ECustomOptionType.Execution)
				{
					if (this.ExecutionPanel == null)
					{
						this.ExecutionPanel = new ExecutionPanel();
						this.ExecutionPanel.Init(this.RootItem);
					}
					this.ExecutionPanel.ShowByEntity(entityId, optionType);
					return;
				}
				if (optionType.GetValueOrDefault() == ECustomOptionType.BreakWeakness)
				{
					if (this.BreakWeaknessPanel == null)
					{
						this.BreakWeaknessPanel = new BreakWeaknessPanel();
						if (Info.Instance.IsInTouch())
						{
							this.BreakWeaknessPanel.Init(this.RootItem, base.GetItem(4));
						}
						else
						{
							this.BreakWeaknessPanel.Init(UiLayer.Instance.GetBattleViewUnit(1), null);
						}
					}
					this.BreakWeaknessPanel.ShowByEntity(entityId, optionType);
				}
				return;
			}
			else
			{
				ExecutionPanel executionPanel = this.ExecutionPanel;
				if (executionPanel != null)
				{
					executionPanel.HideByEntity(entityId);
				}
				BreakWeaknessPanel breakWeaknessPanel = this.BreakWeaknessPanel;
				if (breakWeaknessPanel == null)
				{
					return;
				}
				breakWeaknessPanel.HideByEntity(entityId);
				return;
			}
		}

		// Token: 0x0603BFC3 RID: 245699 RVA: 0x00E56C56 File Offset: 0x00E54E56
		private void OnGmOnlyShowJoyStick(bool isVisible)
		{
			base.GetItem(0).SetUIActive(isVisible);
			base.GetItem(1).SetUIActive(isVisible);
			base.GetItem(2).SetUIActive(isVisible);
		}

		// Token: 0x0603BFC4 RID: 245700 RVA: 0x00E56C80 File Offset: 0x00E54E80
		[NullableContext(1)]
		private void CreateHookPointMaker(Vector targetLocation)
		{
			if (this.HookPointMakerPanel != null)
			{
				GrapplingHookPoint hookPointMakerPanel = this.HookPointMakerPanel;
				FVectorDouble fvectorDouble = targetLocation.ToUeVector(false);
				hookPointMakerPanel.UpdateHookPointLocation(fvectorDouble);
				return;
			}
			UUIItem battleViewUnit = UiLayer.Instance.GetBattleViewUnit(1);
			this.HookPointMakerPanel = new GrapplingHookPoint(targetLocation, battleViewUnit);
		}

		// Token: 0x0603BFC5 RID: 245701 RVA: 0x00E56CC4 File Offset: 0x00E54EC4
		private void RemoveHookPointMaker()
		{
			if (this.HookPointMakerPanel == null)
			{
				return;
			}
			this.HookPointMakerPanel.Destroy(null);
			this.HookPointMakerPanel = null;
		}

		// Token: 0x0603BFC6 RID: 245702 RVA: 0x00E56CE4 File Offset: 0x00E54EE4
		private void UpdateHookPointPosition()
		{
			if (this.HookPointMakerPanel == null)
			{
				return;
			}
			BaseExploreComponent activeExploreComponent = CharacterExploreModel.Instance.GetActiveExploreComponent();
			if (activeExploreComponent == null || !activeExploreComponent.Valid)
			{
				return;
			}
			GrapplingHookPointComponent focusTarget = activeExploreComponent.FocusTarget;
			if (activeExploreComponent.FocusTargetLegal && focusTarget != null && focusTarget.IsMovable())
			{
				GrapplingHookPoint hookPointMakerPanel = this.HookPointMakerPanel;
				FVectorDouble fvectorDouble = focusTarget.HookLocation.ToUeVector(false);
				hookPointMakerPanel.UpdateHookPointLocation(fvectorDouble);
			}
		}

		// Token: 0x0603BFC7 RID: 245703 RVA: 0x00E56D4C File Offset: 0x00E54F4C
		private void UpdateHookPointMarker()
		{
			BaseExploreComponent activeExploreComponent = CharacterExploreModel.Instance.GetActiveExploreComponent();
			if (activeExploreComponent == null || !activeExploreComponent.Valid)
			{
				this.RemoveHookPointMaker();
				return;
			}
			GrapplingHookPointComponent focusTarget = activeExploreComponent.FocusTarget;
			bool focusTargetLegal = activeExploreComponent.FocusTargetLegal;
			if (focusTarget == null || this.ForceHideHookPointMaker)
			{
				this.RemoveHookPointMaker();
				return;
			}
			this.CreateHookPointMaker(focusTarget.HookLocation);
			if (focusTargetLegal)
			{
				GrapplingHookPoint hookPointMakerPanel = this.HookPointMakerPanel;
				if (hookPointMakerPanel == null)
				{
					return;
				}
				hookPointMakerPanel.EnableMarker();
				return;
			}
			else
			{
				GrapplingHookPoint hookPointMakerPanel2 = this.HookPointMakerPanel;
				if (hookPointMakerPanel2 == null)
				{
					return;
				}
				hookPointMakerPanel2.DisableMarker();
				return;
			}
		}

		// Token: 0x0603BFC8 RID: 245704 RVA: 0x00E56DCC File Offset: 0x00E54FCC
		public UUIItem GetExecutionItem()
		{
			ExecutionPanel executionPanel = this.ExecutionPanel;
			if (executionPanel == null)
			{
				return null;
			}
			return executionPanel.GetExecutionItem();
		}

		// Token: 0x0603BFC9 RID: 245705 RVA: 0x00E56DE0 File Offset: 0x00E54FE0
		private void GrapplingHookPointAfterTick()
		{
			if (this.HookPointMakerPanel == null)
			{
				return;
			}
			BaseExploreComponent activeExploreComponent = CharacterExploreModel.Instance.GetActiveExploreComponent();
			if (activeExploreComponent == null || !activeExploreComponent.Valid || activeExploreComponent.FocusTarget == null)
			{
				this.RemoveHookPointMaker();
				return;
			}
			if (activeExploreComponent.FocusTargetLegal)
			{
				this.HookPointMakerPanel.EnableMarker();
				this.HookPointMakerPanel.AfterTick();
				return;
			}
			this.HookPointMakerPanel.DisableMarker();
		}

		// Token: 0x0603BFCA RID: 245706 RVA: 0x00E56E4C File Offset: 0x00E5504C
		private UniTask NewTrackedMarksView()
		{
			CenterPanel.<NewTrackedMarksView>d__51 <NewTrackedMarksView>d__;
			<NewTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewTrackedMarksView>d__.<>4__this = this;
			<NewTrackedMarksView>d__.<>1__state = -1;
			<NewTrackedMarksView>d__.<>t__builder.Start<CenterPanel.<NewTrackedMarksView>d__51>(ref <NewTrackedMarksView>d__);
			return <NewTrackedMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFCB RID: 245707 RVA: 0x00E56E90 File Offset: 0x00E55090
		private UniTask NewScanTrackedMarksView()
		{
			CenterPanel.<NewScanTrackedMarksView>d__52 <NewScanTrackedMarksView>d__;
			<NewScanTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewScanTrackedMarksView>d__.<>4__this = this;
			<NewScanTrackedMarksView>d__.<>1__state = -1;
			<NewScanTrackedMarksView>d__.<>t__builder.Start<CenterPanel.<NewScanTrackedMarksView>d__52>(ref <NewScanTrackedMarksView>d__);
			return <NewScanTrackedMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFCC RID: 245708 RVA: 0x00E56ED4 File Offset: 0x00E550D4
		private UniTask NewAlterMarksView()
		{
			CenterPanel.<NewAlterMarksView>d__53 <NewAlterMarksView>d__;
			<NewAlterMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAlterMarksView>d__.<>4__this = this;
			<NewAlterMarksView>d__.<>1__state = -1;
			<NewAlterMarksView>d__.<>t__builder.Start<CenterPanel.<NewAlterMarksView>d__53>(ref <NewAlterMarksView>d__);
			return <NewAlterMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFCD RID: 245709 RVA: 0x00E56F18 File Offset: 0x00E55118
		private UniTask NewAutoPilotTrackedMarksView()
		{
			CenterPanel.<NewAutoPilotTrackedMarksView>d__54 <NewAutoPilotTrackedMarksView>d__;
			<NewAutoPilotTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAutoPilotTrackedMarksView>d__.<>4__this = this;
			<NewAutoPilotTrackedMarksView>d__.<>1__state = -1;
			<NewAutoPilotTrackedMarksView>d__.<>t__builder.Start<CenterPanel.<NewAutoPilotTrackedMarksView>d__54>(ref <NewAutoPilotTrackedMarksView>d__);
			return <NewAutoPilotTrackedMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFCE RID: 245710 RVA: 0x00E56F5C File Offset: 0x00E5515C
		private UniTask NewQuickHackMarksView()
		{
			CenterPanel.<NewQuickHackMarksView>d__55 <NewQuickHackMarksView>d__;
			<NewQuickHackMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewQuickHackMarksView>d__.<>4__this = this;
			<NewQuickHackMarksView>d__.<>1__state = -1;
			<NewQuickHackMarksView>d__.<>t__builder.Start<CenterPanel.<NewQuickHackMarksView>d__55>(ref <NewQuickHackMarksView>d__);
			return <NewQuickHackMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFCF RID: 245711 RVA: 0x00E56FA0 File Offset: 0x00E551A0
		private UniTask NewJoysticks()
		{
			CenterPanel.<NewJoysticks>d__56 <NewJoysticks>d__;
			<NewJoysticks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewJoysticks>d__.<>4__this = this;
			<NewJoysticks>d__.<>1__state = -1;
			<NewJoysticks>d__.<>t__builder.Start<CenterPanel.<NewJoysticks>d__56>(ref <NewJoysticks>d__);
			return <NewJoysticks>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFD0 RID: 245712 RVA: 0x00E56FE4 File Offset: 0x00E551E4
		private void RefreshJoystick()
		{
			EntityHandle currentEntity = this.CurrentEntity;
			if (currentEntity == null || !currentEntity.Valid)
			{
				return;
			}
			if (this.Joystick != null)
			{
				base.ClearAllTagSignificantChangedCallback();
				base.ListenForTagSignificantChanged(this.CurrentEntity, CenterPanel.ForbidMoveTagId, delegate(int _, bool tagExists)
				{
					this.Joystick.SetForbidMove(tagExists);
				});
				this.Joystick.SetForbidMove(base.ContainsTag(this.CurrentEntity, CenterPanel.ForbidMoveTagId));
			}
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			int num = 0;
			if (curRoleData != null && curRoleData.RoleBattleViewInfo != null)
			{
				num = curRoleData.RoleBattleViewInfo.Value.JoystickType;
			}
			if (this.JoystickType == num)
			{
				return;
			}
			this.JoystickType = num;
			Joystick joystick2 = this.Joystick;
			if (joystick2 != null)
			{
				joystick2.SetVisible(EBattleUiVisibleReason.RoleConfig, num == 0);
			}
			this.RefreshJoystickEnable();
			if (this.OtherMovePanel != null)
			{
				this.OtherMovePanel.Destroy(null);
				this.OtherMovePanel = null;
			}
			if (num == 1)
			{
				MoveSkillPanel moveSkillPanel = new MoveSkillPanel();
				moveSkillPanel.CreateDynamic(base.GetRootItem());
				this.OtherMovePanel = moveSkillPanel;
			}
			if (num == 3)
			{
				if (base.GetOperationType() == EOperationType.Pad)
				{
					base.NewDynamicChildViewByResourceIdWithCallback<JoystickStatic>(this.RootItem, "PnlLevelJoystick", true, delegate(JoystickStatic joystick)
					{
						this.OtherMovePanel = joystick;
						joystick.SetVisible(EBattleUiVisibleReason.RoleConfig, true);
						joystick.SetEnable(true);
						joystick.ShowBattleVisibleChildView();
					}, this.RootItem);
					return;
				}
				MoveCursorPanel moveCursorPanel = new MoveCursorPanel();
				moveCursorPanel.CreateDynamic(base.GetRootItem());
				this.OtherMovePanel = moveCursorPanel;
			}
		}

		// Token: 0x0603BFD1 RID: 245713 RVA: 0x00E57138 File Offset: 0x00E55338
		private void RefreshJoystickEnable()
		{
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			if (motorcycleData.IsDriving && !motorcycleData.GetIsRoundJoystick())
			{
				Joystick joystick = this.Joystick;
				if (joystick == null)
				{
					return;
				}
				joystick.SetEnable(false);
				return;
			}
			else
			{
				Joystick joystick2 = this.Joystick;
				if (joystick2 == null)
				{
					return;
				}
				joystick2.SetEnable(this.JoystickType == 0);
				return;
			}
		}

		// Token: 0x0603BFD2 RID: 245714 RVA: 0x00E5718C File Offset: 0x00E5538C
		private void OnChangeRoleCompleted(int i, int i1)
		{
			BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
			this.CurrentEntity = curRoleData.EntityHandle;
			this.RefreshJoystick();
			BreakWeaknessPanel breakWeaknessPanel = this.BreakWeaknessPanel;
			if (breakWeaknessPanel == null)
			{
				return;
			}
			breakWeaknessPanel.ChangeRole();
		}

		// Token: 0x0603BFD3 RID: 245715 RVA: 0x00E571C6 File Offset: 0x00E553C6
		private void OnMotorcycleStateChanged(bool b)
		{
			this.RefreshMotorcycleControl();
			this.RefreshJoystickEnable();
		}

		// Token: 0x0603BFD4 RID: 245716 RVA: 0x00E571D4 File Offset: 0x00E553D4
		private void RefreshMotorcycleControl()
		{
			this.RefreshMotorcycleControlWithCache();
		}

		// Token: 0x0603BFD5 RID: 245717 RVA: 0x00E571DC File Offset: 0x00E553DC
		private void RefreshMotorcycleControlWithCache()
		{
			bool isDriving = BattleUiModel.Instance.MotorcycleData.IsDriving;
			bool isNeedCacheUi = BattleUiModel.Instance.MotorcycleData.IsNeedCacheUi;
			bool flag = false;
			if (isNeedCacheUi)
			{
				if (this.MotorcycleControlPanel == null)
				{
					if (Info.Instance.IsInTouch())
					{
						this.MotorcycleControlPanel = new MotorcycleControlMobilePanel();
						this.MotorcycleControlPanel.Init(base.GetRootItem(), "UiItem_MotorcycleControl").Forget();
					}
					else
					{
						this.MotorcycleControlPanel = new MotorcycleControlPanel();
						this.MotorcycleControlPanel.Init(base.GetRootItem(), "UiItem_MotorcycleControl").Forget();
					}
					flag = true;
				}
				if (this.MotorcycleControlTopPanel == null)
				{
					this.MotorcycleControlTopPanel = new MotorcycleControlTopPanel();
					this.MotorcycleControlTopPanel.Init(base.GetRootItem(), "UiItem_MotorcycleControlTop").Forget();
				}
				if (this.MotorcycleControlHudPanel == null)
				{
					this.MotorcycleControlHudPanel = new MotorcycleControlHudPanel();
					UUIItem battleViewUnit = UiLayer.Instance.GetBattleViewUnit(1);
					this.MotorcycleControlHudPanel.Init(battleViewUnit, "UiItem_MotoParkourHUD_T").Forget();
				}
				if (flag)
				{
					return;
				}
			}
			else if (isDriving)
			{
				if (this.MotorcycleControlPanel == null)
				{
					if (Info.Instance.IsInTouch())
					{
						this.MotorcycleControlPanel = new MotorcycleControlMobilePanel();
						this.MotorcycleControlPanel.Init(base.GetRootItem(), "UiItem_MotorcycleControl").Forget();
					}
					else
					{
						this.MotorcycleControlPanel = new MotorcycleControlPanel();
						this.MotorcycleControlPanel.Init(base.GetRootItem(), "UiItem_MotorcycleControl").Forget();
					}
				}
				if (this.MotorcycleControlTopPanel == null)
				{
					this.MotorcycleControlTopPanel = new MotorcycleControlTopPanel();
					this.MotorcycleControlTopPanel.Init(base.GetRootItem(), "UiItem_MotorcycleControlTop").Forget();
				}
				if (this.MotorcycleControlHudPanel == null)
				{
					this.MotorcycleControlHudPanel = new MotorcycleControlHudPanel();
					UUIItem battleViewUnit2 = UiLayer.Instance.GetBattleViewUnit(1);
					this.MotorcycleControlHudPanel.Init(battleViewUnit2, "UiItem_MotoParkourHUD_T").Forget();
				}
				return;
			}
			if (isDriving)
			{
				if (this.MotorcycleControlPanel != null && !this.MotorcycleControlPanel.IsCreateOrCreating)
				{
					this.MotorcycleControlPanel.ShowBattleVisibleChildView(false);
				}
				if (this.MotorcycleControlTopPanel != null && !this.MotorcycleControlTopPanel.IsCreateOrCreating)
				{
					this.MotorcycleControlTopPanel.ShowBattleVisibleChildView(false);
				}
				if (this.MotorcycleControlHudPanel != null && !this.MotorcycleControlHudPanel.IsCreateOrCreating)
				{
					this.MotorcycleControlHudPanel.ShowBattleVisibleChildView(false);
					return;
				}
			}
			else
			{
				if (this.MotorcycleControlPanel != null)
				{
					if (!isNeedCacheUi)
					{
						this.MotorcycleControlPanel.Destroy(null);
						this.MotorcycleControlPanel = null;
					}
					else
					{
						this.MotorcycleControlPanel.HideBattleVisibleChildView();
					}
				}
				if (this.MotorcycleControlTopPanel != null)
				{
					if (!isNeedCacheUi)
					{
						this.MotorcycleControlTopPanel.Destroy(null);
						this.MotorcycleControlTopPanel = null;
					}
					else
					{
						this.MotorcycleControlTopPanel.HideBattleVisibleChildView();
					}
				}
				if (this.MotorcycleControlHudPanel != null)
				{
					if (!isNeedCacheUi)
					{
						this.MotorcycleControlHudPanel.Destroy(null);
						this.MotorcycleControlHudPanel = null;
						return;
					}
					this.MotorcycleControlHudPanel.HideBattleVisibleChildView();
				}
			}
		}

		// Token: 0x0603BFD6 RID: 245718 RVA: 0x00E5749A File Offset: 0x00E5569A
		private void OnSetBattleUiChildCacheState(EBattleUiChildCacheType cacheType, bool needCache)
		{
			if (cacheType == EBattleUiChildCacheType.Motorcycle)
			{
				this.RefreshMotorcycleControl();
			}
		}

		// Token: 0x0603BFD7 RID: 245719 RVA: 0x00E574A8 File Offset: 0x00E556A8
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams[0] == "MotorMobile")
			{
				UUIItem[] result;
				if ((result = this.GetGuideItemFromPanel(this.MotorcycleControlPanel, configParams)) == null)
				{
					result = (this.GetGuideItemFromPanel(this.MotorcycleControlTopPanel, configParams) ?? this.GetGuideItemFromPanel(AutoPilotController.Instance.AutoPilotViewInstance, configParams));
				}
				return result;
			}
			return null;
		}

		// Token: 0x0603BFD8 RID: 245720 RVA: 0x00E574FC File Offset: 0x00E556FC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private UUIItem[] GetGuideItemFromPanel([Nullable(2)] UiPanelBase panel, string[] configParams)
		{
			if (panel == null)
			{
				return null;
			}
			string text = (configParams.Length > 1) ? configParams[1] : null;
			string text2 = (configParams.Length > 2) ? configParams[2] : null;
			UUIItem uuiitem = (!string.IsNullOrEmpty(text)) ? panel.GetGuideUiItem(text) : null;
			UUIItem uuiitem2 = (!string.IsNullOrEmpty(text2)) ? panel.GetGuideUiItem(text2) : null;
			if (uuiitem != null && uuiitem2 != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					uuiitem2
				};
			}
			if (uuiitem != null)
			{
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			return null;
		}

		// Token: 0x0603BFD9 RID: 245721 RVA: 0x00E57576 File Offset: 0x00E55776
		private void OnSlideControlVisibleChanged(bool visible)
		{
			this.RefreshSlideControlItem();
		}

		// Token: 0x0603BFDA RID: 245722 RVA: 0x00E57580 File Offset: 0x00E55780
		private void RefreshSlideControlItem()
		{
			if (BattleUiModel.Instance.SlideControlData.GetVisible())
			{
				if (this.SlideControlComponent == null)
				{
					this.SlideControlComponent = new BattleSkillSlideControlItem();
					this.SlideControlComponent.CreateByResourceIdAsync("UiItem_AimisiFlyControl", this.RootItem, false).AsTask();
				}
				this.SlideControlComponent.SetComponentActive(true);
				return;
			}
			if (this.SlideControlComponent != null)
			{
				this.SlideControlComponent.SetComponentActive(false);
			}
		}

		// Token: 0x0603BFDB RID: 245723 RVA: 0x00E575EF File Offset: 0x00E557EF
		private void OnMotorcycleRoundJoystickChanged(bool b)
		{
			this.RefreshJoystickEnable();
		}

		// Token: 0x0603BFDC RID: 245724 RVA: 0x00E575F7 File Offset: 0x00E557F7
		private void OnAutoPilotTrackMarkVisibleChanged(bool visible)
		{
			base.GetItem(0).SetUIActive(visible);
		}

		// Token: 0x0401F4C5 RID: 128197
		[StaticVariableRuleIgnore]
		private static int ForbidMoveTagId = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"];

		// Token: 0x0401F4C6 RID: 128198
		private TrackedMarksView TrackedMarksView;

		// Token: 0x0401F4C7 RID: 128199
		private ScanTrackedMarksView ScanTrackedMarksView;

		// Token: 0x0401F4C8 RID: 128200
		private AlterMarksView AlterMarksView;

		// Token: 0x0401F4C9 RID: 128201
		private AutoPilotTrackedMarksView AutoPilotTrackedMarksView;

		// Token: 0x0401F4CA RID: 128202
		private QuickHackMarksView QuickHackMarksView;

		// Token: 0x0401F4CB RID: 128203
		private Joystick Joystick;

		// Token: 0x0401F4CC RID: 128204
		private GrapplingHookPoint HookPointMakerPanel;

		// Token: 0x0401F4CD RID: 128205
		private ExecutionPanel ExecutionPanel;

		// Token: 0x0401F4CE RID: 128206
		private BreakWeaknessPanel BreakWeaknessPanel;

		// Token: 0x0401F4CF RID: 128207
		private MotorcycleControlPanelBase MotorcycleControlPanel;

		// Token: 0x0401F4D0 RID: 128208
		private MotorcycleControlTopPanel MotorcycleControlTopPanel;

		// Token: 0x0401F4D1 RID: 128209
		private MotorcycleControlHudPanel MotorcycleControlHudPanel;

		// Token: 0x0401F4D2 RID: 128210
		private BattleSkillSlideControlItem SlideControlComponent;

		// Token: 0x0401F4D3 RID: 128211
		private IBattleUiCenterPanelOtherMovePanel OtherMovePanel;

		// Token: 0x0401F4D4 RID: 128212
		private EntityHandle CurrentEntity;

		// Token: 0x0401F4D5 RID: 128213
		[Nullable(1)]
		private readonly List<Entity> EntityList = new List<Entity>();

		// Token: 0x0401F4D6 RID: 128214
		private int JoystickType;

		// Token: 0x0401F4D7 RID: 128215
		private bool ForceHideHookPointMaker;

		// Token: 0x0401F4D8 RID: 128216
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject1 = Stat.Create("[BattleView]CenterPanelTick1", "", "");

		// Token: 0x0401F4D9 RID: 128217
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject2 = Stat.Create("[BattleView]CenterPanelTick2", "", "");

		// Token: 0x0401F4DA RID: 128218
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject5 = Stat.Create("[BattleView]CenterPanelTick5", "", "");

		// Token: 0x0401F4DB RID: 128219
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject6 = Stat.Create("[BattleView]CenterPanelTick6", "", "");

		// Token: 0x0401F4DC RID: 128220
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject7 = Stat.Create("[BattleView]CenterPanelTick7", "", "");

		// Token: 0x0401F4DD RID: 128221
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject8 = Stat.Create("[BattleView]CenterPanelTick8", "", "");

		// Token: 0x0401F4DE RID: 128222
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject9 = Stat.Create("[BattleView]CenterPanelTick9", "", "");

		// Token: 0x0200BE9E RID: 48798
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040397BE RID: 235454
			TrackItem,
			// Token: 0x040397BF RID: 235455
			AlterCursorItem,
			// Token: 0x040397C0 RID: 235456
			PanelMask,
			// Token: 0x040397C1 RID: 235457
			JoystickItem,
			// Token: 0x040397C2 RID: 235458
			BreakWeaknessItem
		}

		// Token: 0x0200BE9F RID: 48799
		[NullableContext(0)]
		private enum EJoystickType
		{
			// Token: 0x040397C4 RID: 235460
			NormalJoyStick,
			// Token: 0x040397C5 RID: 235461
			UpDownButton,
			// Token: 0x040397C6 RID: 235462
			None,
			// Token: 0x040397C7 RID: 235463
			StaticJoystick
		}
	}
}
