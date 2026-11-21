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
	// Token: 0x02004C9B RID: 19611
	[NullableContext(2)]
	[Nullable(0)]
	public class CenterPanel : BattleChildViewPanel
	{
		// Token: 0x06030F06 RID: 200454 RVA: 0x00DA6A68 File Offset: 0x00DA4C68
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

		// Token: 0x06030F07 RID: 200455 RVA: 0x00DA6BC4 File Offset: 0x00DA4DC4
		public override void InitializeTemp()
		{
			this.OnBattleHudVisibleChanged();
			this.CurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		}

		// Token: 0x06030F08 RID: 200456 RVA: 0x00DA6BDC File Offset: 0x00DA4DDC
		public override UniTask InitializeAsync()
		{
			CenterPanel.<InitializeAsync>d__30 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<CenterPanel.<InitializeAsync>d__30>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030F09 RID: 200457 RVA: 0x00DA6C20 File Offset: 0x00DA4E20
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

		// Token: 0x06030F0A RID: 200458 RVA: 0x00DA6C88 File Offset: 0x00DA4E88
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

		// Token: 0x06030F0B RID: 200459 RVA: 0x00DA6CD8 File Offset: 0x00DA4ED8
		public void SetEventVisible(bool value)
		{
		}

		// Token: 0x06030F0C RID: 200460 RVA: 0x00DA6CDC File Offset: 0x00DA4EDC
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

		// Token: 0x06030F0D RID: 200461 RVA: 0x00DA6DDC File Offset: 0x00DA4FDC
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

		// Token: 0x06030F0E RID: 200462 RVA: 0x00DA6F38 File Offset: 0x00DA5138
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

		// Token: 0x06030F0F RID: 200463 RVA: 0x00DA7094 File Offset: 0x00DA5294
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

		// Token: 0x06030F10 RID: 200464 RVA: 0x00DA7130 File Offset: 0x00DA5330
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

		// Token: 0x06030F11 RID: 200465 RVA: 0x00DA7182 File Offset: 0x00DA5382
		private void OnExploreComponentTargetChanged()
		{
			this.UpdateHookPointMarker();
		}

		// Token: 0x06030F12 RID: 200466 RVA: 0x00DA718C File Offset: 0x00DA538C
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

		// Token: 0x06030F13 RID: 200467 RVA: 0x00DA71C5 File Offset: 0x00DA53C5
		private void OnEnableGrapplingHookMark(bool isEnable)
		{
			this.ForceHideHookPointMaker = !isEnable;
		}

		// Token: 0x06030F14 RID: 200468 RVA: 0x00DA71D4 File Offset: 0x00DA53D4
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

		// Token: 0x06030F15 RID: 200469 RVA: 0x00DA7224 File Offset: 0x00DA5424
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

		// Token: 0x06030F16 RID: 200470 RVA: 0x00DA72FE File Offset: 0x00DA54FE
		private void OnGmOnlyShowJoyStick(bool isVisible)
		{
			base.GetItem(0).SetUIActive(isVisible);
			base.GetItem(1).SetUIActive(isVisible);
			base.GetItem(2).SetUIActive(isVisible);
		}

		// Token: 0x06030F17 RID: 200471 RVA: 0x00DA7328 File Offset: 0x00DA5528
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

		// Token: 0x06030F18 RID: 200472 RVA: 0x00DA736C File Offset: 0x00DA556C
		private void RemoveHookPointMaker()
		{
			if (this.HookPointMakerPanel == null)
			{
				return;
			}
			this.HookPointMakerPanel.Destroy(null);
			this.HookPointMakerPanel = null;
		}

		// Token: 0x06030F19 RID: 200473 RVA: 0x00DA738C File Offset: 0x00DA558C
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

		// Token: 0x06030F1A RID: 200474 RVA: 0x00DA73F4 File Offset: 0x00DA55F4
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

		// Token: 0x06030F1B RID: 200475 RVA: 0x00DA7474 File Offset: 0x00DA5674
		public UUIItem GetExecutionItem()
		{
			ExecutionPanel executionPanel = this.ExecutionPanel;
			if (executionPanel == null)
			{
				return null;
			}
			return executionPanel.GetExecutionItem();
		}

		// Token: 0x06030F1C RID: 200476 RVA: 0x00DA7488 File Offset: 0x00DA5688
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

		// Token: 0x06030F1D RID: 200477 RVA: 0x00DA74F4 File Offset: 0x00DA56F4
		private UniTask NewTrackedMarksView()
		{
			CenterPanel.<NewTrackedMarksView>d__51 <NewTrackedMarksView>d__;
			<NewTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewTrackedMarksView>d__.<>4__this = this;
			<NewTrackedMarksView>d__.<>1__state = -1;
			<NewTrackedMarksView>d__.<>t__builder.Start<CenterPanel.<NewTrackedMarksView>d__51>(ref <NewTrackedMarksView>d__);
			return <NewTrackedMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x06030F1E RID: 200478 RVA: 0x00DA7538 File Offset: 0x00DA5738
		private UniTask NewScanTrackedMarksView()
		{
			CenterPanel.<NewScanTrackedMarksView>d__52 <NewScanTrackedMarksView>d__;
			<NewScanTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewScanTrackedMarksView>d__.<>4__this = this;
			<NewScanTrackedMarksView>d__.<>1__state = -1;
			<NewScanTrackedMarksView>d__.<>t__builder.Start<CenterPanel.<NewScanTrackedMarksView>d__52>(ref <NewScanTrackedMarksView>d__);
			return <NewScanTrackedMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x06030F1F RID: 200479 RVA: 0x00DA757C File Offset: 0x00DA577C
		private UniTask NewAlterMarksView()
		{
			CenterPanel.<NewAlterMarksView>d__53 <NewAlterMarksView>d__;
			<NewAlterMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAlterMarksView>d__.<>4__this = this;
			<NewAlterMarksView>d__.<>1__state = -1;
			<NewAlterMarksView>d__.<>t__builder.Start<CenterPanel.<NewAlterMarksView>d__53>(ref <NewAlterMarksView>d__);
			return <NewAlterMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x06030F20 RID: 200480 RVA: 0x00DA75C0 File Offset: 0x00DA57C0
		private UniTask NewAutoPilotTrackedMarksView()
		{
			CenterPanel.<NewAutoPilotTrackedMarksView>d__54 <NewAutoPilotTrackedMarksView>d__;
			<NewAutoPilotTrackedMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAutoPilotTrackedMarksView>d__.<>4__this = this;
			<NewAutoPilotTrackedMarksView>d__.<>1__state = -1;
			<NewAutoPilotTrackedMarksView>d__.<>t__builder.Start<CenterPanel.<NewAutoPilotTrackedMarksView>d__54>(ref <NewAutoPilotTrackedMarksView>d__);
			return <NewAutoPilotTrackedMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x06030F21 RID: 200481 RVA: 0x00DA7604 File Offset: 0x00DA5804
		private UniTask NewQuickHackMarksView()
		{
			CenterPanel.<NewQuickHackMarksView>d__55 <NewQuickHackMarksView>d__;
			<NewQuickHackMarksView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewQuickHackMarksView>d__.<>4__this = this;
			<NewQuickHackMarksView>d__.<>1__state = -1;
			<NewQuickHackMarksView>d__.<>t__builder.Start<CenterPanel.<NewQuickHackMarksView>d__55>(ref <NewQuickHackMarksView>d__);
			return <NewQuickHackMarksView>d__.<>t__builder.Task;
		}

		// Token: 0x06030F22 RID: 200482 RVA: 0x00DA7648 File Offset: 0x00DA5848
		private UniTask NewJoysticks()
		{
			CenterPanel.<NewJoysticks>d__56 <NewJoysticks>d__;
			<NewJoysticks>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewJoysticks>d__.<>4__this = this;
			<NewJoysticks>d__.<>1__state = -1;
			<NewJoysticks>d__.<>t__builder.Start<CenterPanel.<NewJoysticks>d__56>(ref <NewJoysticks>d__);
			return <NewJoysticks>d__.<>t__builder.Task;
		}

		// Token: 0x06030F23 RID: 200483 RVA: 0x00DA768C File Offset: 0x00DA588C
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

		// Token: 0x06030F24 RID: 200484 RVA: 0x00DA77E0 File Offset: 0x00DA59E0
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

		// Token: 0x06030F25 RID: 200485 RVA: 0x00DA7834 File Offset: 0x00DA5A34
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

		// Token: 0x06030F26 RID: 200486 RVA: 0x00DA786E File Offset: 0x00DA5A6E
		private void OnMotorcycleStateChanged(bool b)
		{
			this.RefreshMotorcycleControl();
			this.RefreshJoystickEnable();
		}

		// Token: 0x06030F27 RID: 200487 RVA: 0x00DA787C File Offset: 0x00DA5A7C
		private void RefreshMotorcycleControl()
		{
			this.RefreshMotorcycleControlWithCache();
		}

		// Token: 0x06030F28 RID: 200488 RVA: 0x00DA7884 File Offset: 0x00DA5A84
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

		// Token: 0x06030F29 RID: 200489 RVA: 0x00DA7B42 File Offset: 0x00DA5D42
		private void OnSetBattleUiChildCacheState(EBattleUiChildCacheType cacheType, bool needCache)
		{
			if (cacheType == EBattleUiChildCacheType.Motorcycle)
			{
				this.RefreshMotorcycleControl();
			}
		}

		// Token: 0x06030F2A RID: 200490 RVA: 0x00DA7B50 File Offset: 0x00DA5D50
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

		// Token: 0x06030F2B RID: 200491 RVA: 0x00DA7BA4 File Offset: 0x00DA5DA4
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

		// Token: 0x06030F2C RID: 200492 RVA: 0x00DA7C1E File Offset: 0x00DA5E1E
		private void OnSlideControlVisibleChanged(bool visible)
		{
			this.RefreshSlideControlItem();
		}

		// Token: 0x06030F2D RID: 200493 RVA: 0x00DA7C28 File Offset: 0x00DA5E28
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

		// Token: 0x06030F2E RID: 200494 RVA: 0x00DA7C97 File Offset: 0x00DA5E97
		private void OnMotorcycleRoundJoystickChanged(bool b)
		{
			this.RefreshJoystickEnable();
		}

		// Token: 0x06030F2F RID: 200495 RVA: 0x00DA7C9F File Offset: 0x00DA5E9F
		private void OnAutoPilotTrackMarkVisibleChanged(bool visible)
		{
			base.GetItem(0).SetUIActive(visible);
		}

		// Token: 0x04019F7E RID: 106366
		[StaticVariableRuleIgnore]
		private static int ForbidMoveTagId = GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止移动"];

		// Token: 0x04019F7F RID: 106367
		private TrackedMarksView TrackedMarksView;

		// Token: 0x04019F80 RID: 106368
		private ScanTrackedMarksView ScanTrackedMarksView;

		// Token: 0x04019F81 RID: 106369
		private AlterMarksView AlterMarksView;

		// Token: 0x04019F82 RID: 106370
		private AutoPilotTrackedMarksView AutoPilotTrackedMarksView;

		// Token: 0x04019F83 RID: 106371
		private QuickHackMarksView QuickHackMarksView;

		// Token: 0x04019F84 RID: 106372
		private Joystick Joystick;

		// Token: 0x04019F85 RID: 106373
		private GrapplingHookPoint HookPointMakerPanel;

		// Token: 0x04019F86 RID: 106374
		private ExecutionPanel ExecutionPanel;

		// Token: 0x04019F87 RID: 106375
		private BreakWeaknessPanel BreakWeaknessPanel;

		// Token: 0x04019F88 RID: 106376
		private MotorcycleControlPanelBase MotorcycleControlPanel;

		// Token: 0x04019F89 RID: 106377
		private MotorcycleControlTopPanel MotorcycleControlTopPanel;

		// Token: 0x04019F8A RID: 106378
		private MotorcycleControlHudPanel MotorcycleControlHudPanel;

		// Token: 0x04019F8B RID: 106379
		private BattleSkillSlideControlItem SlideControlComponent;

		// Token: 0x04019F8C RID: 106380
		private IBattleUiCenterPanelOtherMovePanel OtherMovePanel;

		// Token: 0x04019F8D RID: 106381
		private EntityHandle CurrentEntity;

		// Token: 0x04019F8E RID: 106382
		[Nullable(1)]
		private readonly List<Entity> EntityList = new List<Entity>();

		// Token: 0x04019F8F RID: 106383
		private int JoystickType;

		// Token: 0x04019F90 RID: 106384
		private bool ForceHideHookPointMaker;

		// Token: 0x04019F91 RID: 106385
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject1 = Stat.Create("[BattleView]CenterPanelTick1", "", "");

		// Token: 0x04019F92 RID: 106386
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject2 = Stat.Create("[BattleView]CenterPanelTick2", "", "");

		// Token: 0x04019F93 RID: 106387
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject5 = Stat.Create("[BattleView]CenterPanelTick5", "", "");

		// Token: 0x04019F94 RID: 106388
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject6 = Stat.Create("[BattleView]CenterPanelTick6", "", "");

		// Token: 0x04019F95 RID: 106389
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject7 = Stat.Create("[BattleView]CenterPanelTick7", "", "");

		// Token: 0x04019F96 RID: 106390
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject8 = Stat.Create("[BattleView]CenterPanelTick8", "", "");

		// Token: 0x04019F97 RID: 106391
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat BattleViewTickStatsObject9 = Stat.Create("[BattleView]CenterPanelTick9", "", "");

		// Token: 0x0200A8A4 RID: 43172
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403417F RID: 213375
			TrackItem,
			// Token: 0x04034180 RID: 213376
			AlterCursorItem,
			// Token: 0x04034181 RID: 213377
			PanelMask,
			// Token: 0x04034182 RID: 213378
			JoystickItem,
			// Token: 0x04034183 RID: 213379
			BreakWeaknessItem
		}

		// Token: 0x0200A8A5 RID: 43173
		[NullableContext(0)]
		private enum EJoystickType
		{
			// Token: 0x04034185 RID: 213381
			NormalJoyStick,
			// Token: 0x04034186 RID: 213382
			UpDownButton,
			// Token: 0x04034187 RID: 213383
			None,
			// Token: 0x04034188 RID: 213384
			StaticJoystick
		}
	}
}
