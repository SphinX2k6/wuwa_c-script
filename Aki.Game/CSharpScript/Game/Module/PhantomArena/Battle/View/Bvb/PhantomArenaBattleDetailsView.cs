using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb.DamageStatistics;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02004243 RID: 16963
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsView : UiTickViewBase, IUiProhibitRefreshData, IExtraShowCursor
	{
		// Token: 0x0602AE9C RID: 175772 RVA: 0x00C1303F File Offset: 0x00C1123F
		public PhantomArenaBattleDetailsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602AE9D RID: 175773 RVA: 0x00C13054 File Offset: 0x00C11254
		protected override void OnRegisterComponent()
		{
			this.Proxy = (this.OpenParam as PhantomArenaBattleDetailsViewProxy);
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(5, typeof(UUINiagara)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUINiagara)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnClickBackBtn)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickSkipBtn))
			};
		}

		// Token: 0x0602AE9E RID: 175774 RVA: 0x00C13198 File Offset: 0x00C11398
		private UniTask InitMobileJoystick()
		{
			PhantomArenaBattleDetailsView.<InitMobileJoystick>d__36 <InitMobileJoystick>d__;
			<InitMobileJoystick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMobileJoystick>d__.<>4__this = this;
			<InitMobileJoystick>d__.<>1__state = -1;
			<InitMobileJoystick>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitMobileJoystick>d__36>(ref <InitMobileJoystick>d__);
			return <InitMobileJoystick>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE9F RID: 175775 RVA: 0x00C131DC File Offset: 0x00C113DC
		private UniTask InitOwnArea()
		{
			PhantomArenaBattleDetailsView.<InitOwnArea>d__37 <InitOwnArea>d__;
			<InitOwnArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnArea>d__.<>4__this = this;
			<InitOwnArea>d__.<>1__state = -1;
			<InitOwnArea>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitOwnArea>d__37>(ref <InitOwnArea>d__);
			return <InitOwnArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA0 RID: 175776 RVA: 0x00C13220 File Offset: 0x00C11420
		private UniTask InitOpponentArea()
		{
			PhantomArenaBattleDetailsView.<InitOpponentArea>d__38 <InitOpponentArea>d__;
			<InitOpponentArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOpponentArea>d__.<>4__this = this;
			<InitOpponentArea>d__.<>1__state = -1;
			<InitOpponentArea>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitOpponentArea>d__38>(ref <InitOpponentArea>d__);
			return <InitOpponentArea>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA1 RID: 175777 RVA: 0x00C13264 File Offset: 0x00C11464
		private UniTask InitCurve()
		{
			PhantomArenaBattleDetailsView.<InitCurve>d__39 <InitCurve>d__;
			<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurve>d__.<>4__this = this;
			<InitCurve>d__.<>1__state = -1;
			<InitCurve>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurve>d__39>(ref <InitCurve>d__);
			return <InitCurve>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA2 RID: 175778 RVA: 0x00C132A8 File Offset: 0x00C114A8
		private UniTask InitCurveZ()
		{
			PhantomArenaBattleDetailsView.<InitCurveZ>d__40 <InitCurveZ>d__;
			<InitCurveZ>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveZ>d__.<>4__this = this;
			<InitCurveZ>d__.<>1__state = -1;
			<InitCurveZ>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveZ>d__40>(ref <InitCurveZ>d__);
			return <InitCurveZ>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA3 RID: 175779 RVA: 0x00C132EC File Offset: 0x00C114EC
		private UniTask InitCurveMeX()
		{
			PhantomArenaBattleDetailsView.<InitCurveMeX>d__41 <InitCurveMeX>d__;
			<InitCurveMeX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveMeX>d__.<>4__this = this;
			<InitCurveMeX>d__.<>1__state = -1;
			<InitCurveMeX>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveMeX>d__41>(ref <InitCurveMeX>d__);
			return <InitCurveMeX>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA4 RID: 175780 RVA: 0x00C13330 File Offset: 0x00C11530
		private UniTask InitCurveOppositeX()
		{
			PhantomArenaBattleDetailsView.<InitCurveOppositeX>d__42 <InitCurveOppositeX>d__;
			<InitCurveOppositeX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveOppositeX>d__.<>4__this = this;
			<InitCurveOppositeX>d__.<>1__state = -1;
			<InitCurveOppositeX>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveOppositeX>d__42>(ref <InitCurveOppositeX>d__);
			return <InitCurveOppositeX>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA5 RID: 175781 RVA: 0x00C13374 File Offset: 0x00C11574
		private UniTask InitCurveCommon()
		{
			PhantomArenaBattleDetailsView.<InitCurveCommon>d__43 <InitCurveCommon>d__;
			<InitCurveCommon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveCommon>d__.<>4__this = this;
			<InitCurveCommon>d__.<>1__state = -1;
			<InitCurveCommon>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveCommon>d__43>(ref <InitCurveCommon>d__);
			return <InitCurveCommon>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA6 RID: 175782 RVA: 0x00C133B8 File Offset: 0x00C115B8
		private UniTask InitCurveDamageX()
		{
			PhantomArenaBattleDetailsView.<InitCurveDamageX>d__44 <InitCurveDamageX>d__;
			<InitCurveDamageX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamageX>d__.<>4__this = this;
			<InitCurveDamageX>d__.<>1__state = -1;
			<InitCurveDamageX>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveDamageX>d__44>(ref <InitCurveDamageX>d__);
			return <InitCurveDamageX>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA7 RID: 175783 RVA: 0x00C133FC File Offset: 0x00C115FC
		private UniTask InitCurveDamageYMe()
		{
			PhantomArenaBattleDetailsView.<InitCurveDamageYMe>d__45 <InitCurveDamageYMe>d__;
			<InitCurveDamageYMe>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamageYMe>d__.<>4__this = this;
			<InitCurveDamageYMe>d__.<>1__state = -1;
			<InitCurveDamageYMe>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveDamageYMe>d__45>(ref <InitCurveDamageYMe>d__);
			return <InitCurveDamageYMe>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA8 RID: 175784 RVA: 0x00C13440 File Offset: 0x00C11640
		private UniTask InitCurveDamageYNpc()
		{
			PhantomArenaBattleDetailsView.<InitCurveDamageYNpc>d__46 <InitCurveDamageYNpc>d__;
			<InitCurveDamageYNpc>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamageYNpc>d__.<>4__this = this;
			<InitCurveDamageYNpc>d__.<>1__state = -1;
			<InitCurveDamageYNpc>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveDamageYNpc>d__46>(ref <InitCurveDamageYNpc>d__);
			return <InitCurveDamageYNpc>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEA9 RID: 175785 RVA: 0x00C13484 File Offset: 0x00C11684
		private void InitHeadStatePanel()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
			BattleViewProxy battleViewProxy = ((viewByName != null) ? viewByName.OpenParam : null) as BattleViewProxy;
			this.HeadStatePanel = ((battleViewProxy != null) ? battleViewProxy.HeadStatePanel : null);
		}

		// Token: 0x0602AEAA RID: 175786 RVA: 0x00C134C4 File Offset: 0x00C116C4
		private UniTask InitDamageStatistics()
		{
			PhantomArenaBattleDetailsView.<InitDamageStatistics>d__48 <InitDamageStatistics>d__;
			<InitDamageStatistics>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDamageStatistics>d__.<>4__this = this;
			<InitDamageStatistics>d__.<>1__state = -1;
			<InitDamageStatistics>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitDamageStatistics>d__48>(ref <InitDamageStatistics>d__);
			return <InitDamageStatistics>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEAB RID: 175787 RVA: 0x00C13508 File Offset: 0x00C11708
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsView.<OnBeforeStartAsync>d__49 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<OnBeforeStartAsync>d__49>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEAC RID: 175788 RVA: 0x00C1354C File Offset: 0x00C1174C
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnDamageAnimEnd), false);
			this.TweenerNpcX = new LguiFloatTween();
			this.TweenerNpcX.BindUpdateTween(new Action<float>(this.TweenCallNpcX));
			this.TweenerNpcX.BindCompleteTween(new Action(this.OnTweenerNpcXEnd));
			this.TweenerNpcZ = new LguiFloatTween();
			this.TweenerNpcZ.BindUpdateTween(new Action<float>(this.TweenCallNpcZ));
			this.TweenerMeX = new LguiFloatTween();
			this.TweenerMeX.BindUpdateTween(new Action<float>(this.TweenCallMeX));
			this.TweenerMeX.BindCompleteTween(new Action(this.OnTweenerMeXEnd));
			this.TweenerMeZ = new LguiFloatTween();
			this.TweenerMeZ.BindUpdateTween(new Action<float>(this.TweenCallMeZ));
			UUINiagara uiNiagara = base.GetUiNiagara(5);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			UUINiagara uiNiagara2 = base.GetUiNiagara(7);
			if (uiNiagara2 != null)
			{
				uiNiagara2.SetUIActive(false);
			}
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.AddBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.PhantomArena);
			}
			this.InitBattleEntityList();
			this.RegisterExtraShowCursor();
			this.RegisterExtraUiProhibitRefresh();
			this.SetSpeedText();
			EFunctionType functionId = PhantomArenaBattleModel.Instance.IsOldBvb ? EFunctionType.PhantomArenaSkipFuncUnlock : EFunctionType.PermanentPhantomArenaSkipFuncUnlock;
			bool uiactive = FunctionModel.Instance.IsOpen(functionId);
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			EventSystem.Instance.Add<float>(EEventName.PlotSequencePlay, new Action<float>(this.OnPlotStart));
			EventSystem.Instance.Add(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
		}

		// Token: 0x0602AEAD RID: 175789 RVA: 0x00C1370C File Offset: 0x00C1190C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PhantomArenaStartTurnResult, new Action<PhantomBattleBvBSettleNotify>(this.OnTurnBattleEnd));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaBattleDamageAccumulateEnd, new Action(this.OnAccumulateAnimEnd));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x0602AEAE RID: 175790 RVA: 0x00C1378C File Offset: 0x00C1198C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PhantomArenaStartTurnResult, new Action<PhantomBattleBvBSettleNotify>(this.OnTurnBattleEnd));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaBattleDamageAccumulateEnd, new Action(this.OnAccumulateAnimEnd));
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x0602AEAF RID: 175791 RVA: 0x00C1380C File Offset: 0x00C11A0C
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.PlotSequencePlay, new Action<float>(this.OnPlotStart));
			EventSystem.Instance.Remove(EEventName.PlotNetworkEnd, new Action<PlotResultInfo>(this.OnPlotEnd));
			this.UnRegisterExtraShowCursor();
			this.UnRegisterExtraUiProhibitRefresh();
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.RemoveBattleUiCommonChildVisibleReason(EBattleUiCommonChildVisibleReason.PhantomArena);
			}
			this.Proxy.DialogManager.Clear();
			this.TweenerNpcX.Destroy();
			this.TweenerNpcZ.Destroy();
			this.TweenerMeX.Destroy();
			this.TweenerMeZ.Destroy();
			this.CurveZ = null;
			this.CurveMeX = null;
			this.CurveOppositeX = null;
			this.CurveCommon = null;
			this.CurveDamageX = null;
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomArenaBattleFloatTips))
			{
				UiManager.Instance.CloseView(EUiViewName.PhantomArenaBattleFloatTips, null);
			}
			this.RemoveTimerHandle();
			PhantomArenaBattleModel.Instance.SetIsInBattle(false);
			UiManager.Instance.CloseView(EUiViewName.PhantomArenaBattleDamageView, null);
		}

		// Token: 0x0602AEB0 RID: 175792 RVA: 0x00C13914 File Offset: 0x00C11B14
		protected override void OnTick(float deltaTime)
		{
			BattleHeadStatePanel headStatePanel = this.HeadStatePanel;
			if (headStatePanel != null)
			{
				headStatePanel.Tick(deltaTime);
			}
			PhantomArenaBattleDetailsAreaItem ownArea = this.OwnArea;
			if (ownArea != null)
			{
				ownArea.TickMonster(deltaTime);
			}
			PhantomArenaBattleDetailsAreaItem opponentArea = this.OpponentArea;
			if (opponentArea != null)
			{
				opponentArea.TickMonster(deltaTime);
			}
			PhantomArenaJoystick mobileJoystick = this.MobileJoystick;
			if (mobileJoystick != null)
			{
				mobileJoystick.Tick(deltaTime);
			}
			PhantomArenaBattleDamageStatisticsPanel damageStatistics = this.DamageStatistics;
			if (damageStatistics == null)
			{
				return;
			}
			damageStatistics.Tick(deltaTime);
		}

		// Token: 0x0602AEB1 RID: 175793 RVA: 0x00C1397A File Offset: 0x00C11B7A
		private void OnClickBackBtn()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(new Action(PhantomArenaBattleModel.Instance.OnClickExitButtonConfirm), null, true);
		}

		// Token: 0x0602AEB2 RID: 175794 RVA: 0x00C13998 File Offset: 0x00C11B98
		private void OnClickSkipBtn()
		{
			PhantomArenaBattleModel.Instance.SetSpeedUp();
			this.SetSpeedText();
		}

		// Token: 0x0602AEB3 RID: 175795 RVA: 0x00C139AA File Offset: 0x00C11BAA
		private void RegisterExtraShowCursor()
		{
			InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x0602AEB4 RID: 175796 RVA: 0x00C139C7 File Offset: 0x00C11BC7
		private void UnRegisterExtraShowCursor()
		{
			InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x0602AEB5 RID: 175797 RVA: 0x00C139E3 File Offset: 0x00C11BE3
		private void RegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x0602AEB6 RID: 175798 RVA: 0x00C13A00 File Offset: 0x00C11C00
		private void UnRegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x0602AEB7 RID: 175799 RVA: 0x00C13A1C File Offset: 0x00C11C1C
		private void InitBattleEntityList()
		{
			List<long> allEntityIdList = PhantomArenaBattleModel.Instance.BattleData.GetAllEntityIdList();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "场上的实体列表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityIdList", allEntityIdList);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0602AEB8 RID: 175800 RVA: 0x00C13A64 File Offset: 0x00C11C64
		private void RefreshOwnLife()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			this.OwnArea.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AEB9 RID: 175801 RVA: 0x00C13AA8 File Offset: 0x00C11CA8
		private void RefreshOwnShield()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OwnData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.OwnArea.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x0602AEBA RID: 175802 RVA: 0x00C13AD8 File Offset: 0x00C11CD8
		private void RefreshOpponentLife()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			this.OpponentArea.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x0602AEBB RID: 175803 RVA: 0x00C13B1C File Offset: 0x00C11D1C
		private void RefreshOpponentShield()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OpponentData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.OpponentArea.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x0602AEBC RID: 175804 RVA: 0x00C13B4C File Offset: 0x00C11D4C
		private void SetSpeedText()
		{
			float speedUpText = PhantomArenaBattleModel.Instance.GetSpeedUpText();
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<float>(speedUpText, "F1");
			defaultInterpolatedStringHandler.AppendLiteral("X");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602AEBD RID: 175805 RVA: 0x00C13B9F File Offset: 0x00C11D9F
		public void SetOwnAllSettlePoint(int allSettlePoint)
		{
			this.OwnArea.SetSettlePoint(allSettlePoint);
		}

		// Token: 0x0602AEBE RID: 175806 RVA: 0x00C13BAD File Offset: 0x00C11DAD
		public void SetOpponentSettlePoint(int opponentSettlePoint)
		{
			this.OpponentArea.SetSettlePoint(opponentSettlePoint);
		}

		// Token: 0x0602AEBF RID: 175807 RVA: 0x00C13BBC File Offset: 0x00C11DBC
		public bool CheckCondition()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			HashSet<EUiViewName> hashSet = (instance != null) ? instance.GetNotAllowFightInputViewNameSet() : null;
			if (hashSet == null || hashSet.Count == 0)
			{
				return false;
			}
			List<EUiViewName> list = new List<EUiViewName>(hashSet);
			return !(list[list.Count - 1] != this.ViewInfo.Name);
		}

		// Token: 0x0602AEC0 RID: 175808 RVA: 0x00C13C10 File Offset: 0x00C11E10
		public string[] GetDistributeTags()
		{
			if (this.Proxy.IsInGamepadNavigation)
			{
				return new string[]
				{
					"UiInputRoot.MouseInputTag",
					"UiInputRoot.Navigation"
				};
			}
			if (InputManager.Instance.IsShowMouseCursor() && Info.Instance.IsInKeyBoard())
			{
				return new string[]
				{
					"UiInputRoot.MouseInputTag"
				};
			}
			return new string[]
			{
				"FightInputRoot",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			};
		}

		// Token: 0x0602AEC1 RID: 175809 RVA: 0x00C13C88 File Offset: 0x00C11E88
		public bool IsShowCursor()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			HashSet<EUiViewName> hashSet = (instance != null) ? instance.GetNotAllowFightInputViewNameSet() : null;
			if (hashSet == null || hashSet.Count == 0)
			{
				return true;
			}
			List<EUiViewName> list = new List<EUiViewName>(hashSet);
			return list[list.Count - 1] != this.ViewInfo.Name;
		}

		// Token: 0x0602AEC2 RID: 175810 RVA: 0x00C13CDC File Offset: 0x00C11EDC
		private unsafe void ShowBattleSettleWinAnim()
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "声骸竞技场BvB结算表现开始";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isWin", this.IsWin);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MeDamaged", this.MeDamaged);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("NpcDamaged", this.NpcDamaged);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.NpcBeforeDamaged = this.OwnArea.GetBeforeDamage();
			this.MeBeforeDamaged = this.OpponentArea.GetBeforeDamage();
			if (this.NpcBeforeDamaged == 0 && this.MeBeforeDamaged == 0)
			{
				PhantomArenaBattleModel.Instance.TryPhantomBattleDealCardNotify();
				return;
			}
			PhantomArenaBattleDetailsAreaItem ownArea = this.OwnArea;
			if (ownArea != null)
			{
				ownArea.SetHitNum(this.MeDamaged);
			}
			PhantomArenaBattleDetailsAreaItem opponentArea = this.OpponentArea;
			if (opponentArea != null)
			{
				opponentArea.SetHitNum(this.NpcDamaged);
			}
			if (this.IsWin || this.NpcBeforeDamaged > 0)
			{
				PhantomArenaBattleDetailsAreaItem ownArea2 = this.OwnArea;
				if (ownArea2 != null)
				{
					ownArea2.StartShowWinAnim();
				}
			}
			if (!this.IsWin || this.MeBeforeDamaged > 0)
			{
				PhantomArenaBattleDetailsAreaItem opponentArea2 = this.OpponentArea;
				if (opponentArea2 == null)
				{
					return;
				}
				opponentArea2.StartShowWinAnim();
			}
		}

		// Token: 0x0602AEC3 RID: 175811 RVA: 0x00C13E24 File Offset: 0x00C12024
		private void OnTurnBattleEnd(PhantomBattleBvBSettleNotify resultData)
		{
			this.IsWin = resultData.IsWin;
			this.NpcDamaged = resultData.NpcDeductLife;
			this.NpcOriginalDamage = resultData.NpcOriginalDamage;
			this.MeDamaged = resultData.PlayerDeductLife;
			this.MeOriginalDamage = resultData.PlayerOriginalDamage;
			this.IsFinishSettle = resultData.IsFinalSettle;
			this.ShowBattleSettleWinAnim();
		}

		// Token: 0x0602AEC4 RID: 175812 RVA: 0x00C13E80 File Offset: 0x00C12080
		private void OnAnimEvent(string param)
		{
			if (param == EPhantomBattleHeadAnim.DamageAccumulate.ToString())
			{
				if (this.AccumulateTween)
				{
					return;
				}
				this.AccumulateTween = true;
				if (this.IsWin || this.NpcBeforeDamaged > 0)
				{
					PhantomArenaBattleDetailsAreaItem ownArea = this.OwnArea;
					if (ownArea != null)
					{
						ownArea.StartAccumulate(this.CurveMeX, this.CurveZ, this.CurveCommon);
					}
				}
				if (!this.IsWin && this.MeBeforeDamaged > 0)
				{
					PhantomArenaBattleDetailsAreaItem opponentArea = this.OpponentArea;
					if (opponentArea == null)
					{
						return;
					}
					opponentArea.StartAccumulate(this.CurveOppositeX, this.CurveZ, this.CurveCommon);
					return;
				}
			}
			else if (param == EPhantomBattleHeadAnim.Damage.ToString())
			{
				if (this.AnimDamageTween)
				{
					return;
				}
				this.AnimDamageTween = true;
				if (this.MeDamaged > 0)
				{
					PhantomArenaBattleDetailsAreaItem ownArea2 = this.OwnArea;
					if (ownArea2 == null)
					{
						return;
					}
					ownArea2.SetDamageTween(this.CurveDamageX, this.MeDamaged);
					return;
				}
			}
			else if (param == EPhantomBattleHeadAnim.DamageNPC.ToString())
			{
				if (this.AnimDamageTween)
				{
					return;
				}
				this.AnimDamageTween = true;
				if (this.NpcDamaged > 0)
				{
					PhantomArenaBattleDetailsAreaItem opponentArea2 = this.OpponentArea;
					if (opponentArea2 == null)
					{
						return;
					}
					opponentArea2.SetDamageTween(this.CurveDamageX, this.NpcDamaged);
				}
			}
		}

		// Token: 0x0602AEC5 RID: 175813 RVA: 0x00C13FC0 File Offset: 0x00C121C0
		private string GetDamageNiagaraPath(int damage)
		{
			string resourceId;
			if (damage < 10)
			{
				resourceId = "NS_Fx_LGUI_Trail_0";
			}
			else
			{
				resourceId = "NS_Fx_LGUI_Trail_1";
			}
			return UiResourceConfig.Instance.GetResourcePath(resourceId);
		}

		// Token: 0x0602AEC6 RID: 175814 RVA: 0x00C13FF4 File Offset: 0x00C121F4
		private UniTask OnOpponentWinDamage()
		{
			PhantomArenaBattleDetailsView.<OnOpponentWinDamage>d__76 <OnOpponentWinDamage>d__;
			<OnOpponentWinDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnOpponentWinDamage>d__.<>4__this = this;
			<OnOpponentWinDamage>d__.<>1__state = -1;
			<OnOpponentWinDamage>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<OnOpponentWinDamage>d__76>(ref <OnOpponentWinDamage>d__);
			return <OnOpponentWinDamage>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEC7 RID: 175815 RVA: 0x00C14038 File Offset: 0x00C12238
		private UniTask OnMeWinDamage()
		{
			PhantomArenaBattleDetailsView.<OnMeWinDamage>d__77 <OnMeWinDamage>d__;
			<OnMeWinDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnMeWinDamage>d__.<>4__this = this;
			<OnMeWinDamage>d__.<>1__state = -1;
			<OnMeWinDamage>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<OnMeWinDamage>d__77>(ref <OnMeWinDamage>d__);
			return <OnMeWinDamage>d__.<>t__builder.Task;
		}

		// Token: 0x0602AEC8 RID: 175816 RVA: 0x00C1407B File Offset: 0x00C1227B
		private void RemoveTimerHandle()
		{
			if (this.TimeHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeHandle);
				this.TimeHandle = null;
			}
		}

		// Token: 0x0602AEC9 RID: 175817 RVA: 0x00C1409D File Offset: 0x00C1229D
		protected override string OnGetBgm()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return this.ViewInfo.LoopAudioEvent;
			}
			return "play_ui_music_3_0_arena_card_battle";
		}

		// Token: 0x0602AECA RID: 175818 RVA: 0x00C140BC File Offset: 0x00C122BC
		private void TweenCallNpcX(float value)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(5);
			FVectorDouble? fvectorDouble = (uiNiagara != null) ? new FVectorDouble?(uiNiagara.D_K2_GetComponentLocation()) : null;
			if (fvectorDouble != null)
			{
				FVectorDouble newLocation = global::Vector.Create((double)value, fvectorDouble.Value.Y, fvectorDouble.Value.Z).ToUeVector(false);
				UUINiagara uiNiagara2 = base.GetUiNiagara(5);
				if (uiNiagara2 == null)
				{
					return;
				}
				uiNiagara2.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x0602AECB RID: 175819 RVA: 0x00C14134 File Offset: 0x00C12334
		private void TweenCallNpcZ(float value)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(5);
			FVectorDouble? fvectorDouble = (uiNiagara != null) ? new FVectorDouble?(uiNiagara.D_K2_GetComponentLocation()) : null;
			if (fvectorDouble != null)
			{
				FVectorDouble newLocation = global::Vector.Create(fvectorDouble.Value.X, fvectorDouble.Value.Y, (double)value).ToUeVector(false);
				UUINiagara uiNiagara2 = base.GetUiNiagara(5);
				if (uiNiagara2 == null)
				{
					return;
				}
				uiNiagara2.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x0602AECC RID: 175820 RVA: 0x00C141AC File Offset: 0x00C123AC
		private void TweenCallMeX(float value)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(7);
			FVectorDouble? fvectorDouble = (uiNiagara != null) ? new FVectorDouble?(uiNiagara.D_K2_GetComponentLocation()) : null;
			if (fvectorDouble != null)
			{
				FVectorDouble newLocation = global::Vector.Create((double)value, fvectorDouble.Value.Y, fvectorDouble.Value.Z).ToUeVector(false);
				UUINiagara uiNiagara2 = base.GetUiNiagara(7);
				if (uiNiagara2 == null)
				{
					return;
				}
				uiNiagara2.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x0602AECD RID: 175821 RVA: 0x00C14224 File Offset: 0x00C12424
		private void TweenCallMeZ(float value)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(7);
			FVectorDouble? fvectorDouble = (uiNiagara != null) ? new FVectorDouble?(uiNiagara.D_K2_GetComponentLocation()) : null;
			if (fvectorDouble != null)
			{
				FVectorDouble newLocation = global::Vector.Create(fvectorDouble.Value.X, fvectorDouble.Value.Y, (double)value).ToUeVector(false);
				UUINiagara uiNiagara2 = base.GetUiNiagara(7);
				if (uiNiagara2 == null)
				{
					return;
				}
				uiNiagara2.D_K2_SetWorldLocation(newLocation, false, ref WorldGlobal.SweepHitResult, false);
			}
		}

		// Token: 0x0602AECE RID: 175822 RVA: 0x00C1429C File Offset: 0x00C1249C
		private void OnTweenerNpcXEnd()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(5);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName(EPhantomBattleHeadAnim.Damage.ToString(), false, null, false);
			}
			this.RefreshOwnShield();
		}

		// Token: 0x0602AECF RID: 175823 RVA: 0x00C142F0 File Offset: 0x00C124F0
		private void OnTweenerMeXEnd()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(7);
			if (uiNiagara != null)
			{
				uiNiagara.SetUIActive(false);
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayLevelSequenceByName(EPhantomBattleHeadAnim.DamageNPC.ToString(), false, null, false);
			}
			this.RefreshOpponentShield();
		}

		// Token: 0x0602AED0 RID: 175824 RVA: 0x00C14344 File Offset: 0x00C12544
		private void OnAccumulateAnimEnd()
		{
			if (!this.IsWin || !this.IsFinishSettle)
			{
				if (this.MeBeforeDamaged > 0)
				{
					this.OnOpponentWinDamage().Forget();
				}
				if (this.NpcBeforeDamaged > 0)
				{
					this.OnMeWinDamage().Forget();
				}
				return;
			}
			int instId = PhantomArenaBattleModel.Instance.InstId;
			PhantomBattleWinSeq? seqConfig = PhantomArenaConfig.Instance.GetSeqConfig(instId);
			if (seqConfig == null)
			{
				PhantomArenaBattleModel.Instance.TryPhantomBattleDealCardNotify();
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PhantomArena;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "声骸竞技场3D BvB缺少胜利Seq配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("instId", instId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.FlowListName = seqConfig.Value.FlowListName;
			FlowController.Instance.StartFlow(seqConfig.Value.FlowListName, seqConfig.Value.FlowId, seqConfig.Value.StateId, null, 0L, false, false, false, null);
		}

		// Token: 0x0602AED1 RID: 175825 RVA: 0x00C14440 File Offset: 0x00C12640
		private void OnDamageAnimEnd(string name)
		{
			if (name != EPhantomBattleHeadAnim.Damage.ToString() && name != EPhantomBattleHeadAnim.DamageNPC.ToString())
			{
				return;
			}
			if (this.DamageAnimEnd)
			{
				return;
			}
			this.DamageAnimEnd = true;
			PhantomArenaBattleModel.Instance.TryPhantomBattleDealCardNotify();
		}

		// Token: 0x0602AED2 RID: 175826 RVA: 0x00C14498 File Offset: 0x00C12698
		private void OnPlotStart(float viewBlendDuration)
		{
			if (!this.IsWin || this.FlowListName == "")
			{
				return;
			}
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			PhantomArenaBattleDetailsAreaItem opponentArea = this.OpponentArea;
			if (opponentArea != null)
			{
				opponentArea.RoleItem.RefreshLifeNum(Math.Max(battleStatusValue, 0), battleStatusValue2);
			}
			BattleHeadStatePanel headStatePanel = this.HeadStatePanel;
			if (headStatePanel != null)
			{
				headStatePanel.RefreshAllHeadState(0f);
			}
			this.TimeHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaBattleDamageView, this.MeOriginalDamage, null);
				this.TimeHandle = null;
			}, 4500f, null, null, true, 1f);
		}

		// Token: 0x0602AED3 RID: 175827 RVA: 0x00C14540 File Offset: 0x00C12740
		private void OnPlotEnd(PlotResultInfo plotInfo)
		{
			if (!this.IsWin || plotInfo.FlowListName != this.FlowListName)
			{
				return;
			}
			if (this.TimeHandle != null)
			{
				this.RemoveTimerHandle();
			}
			else
			{
				UiManager.Instance.CloseView(EUiViewName.PhantomArenaBattleDamageView, null);
			}
			PhantomArenaBattleModel.Instance.TryPhantomBattleDealCardNotify();
		}

		// Token: 0x0602AED4 RID: 175828 RVA: 0x00C14593 File Offset: 0x00C12793
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (last == EInputControllerMainType.Gamepad)
			{
				this.Proxy.SetIsInGamepadNavigation(false);
			}
		}

		// Token: 0x04017382 RID: 95106
		private const int ANIM_DAMAGE_DELAY = 4500;

		// Token: 0x04017383 RID: 95107
		private const int DAMAGE_FIRST = 10;

		// Token: 0x04017384 RID: 95108
		protected PhantomArenaBattleDetailsAreaItem OwnArea;

		// Token: 0x04017385 RID: 95109
		protected PhantomArenaBattleDetailsAreaItem OpponentArea;

		// Token: 0x04017386 RID: 95110
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x04017387 RID: 95111
		protected BattleHeadStatePanel HeadStatePanel;

		// Token: 0x04017388 RID: 95112
		protected PhantomArenaJoystick MobileJoystick;

		// Token: 0x04017389 RID: 95113
		protected PhantomArenaBattleDamageStatisticsPanel DamageStatistics;

		// Token: 0x0401738A RID: 95114
		protected bool IsWin;

		// Token: 0x0401738B RID: 95115
		protected bool AccumulateTween;

		// Token: 0x0401738C RID: 95116
		protected bool AnimDamageTween;

		// Token: 0x0401738D RID: 95117
		protected UCurveFloat CurveZ;

		// Token: 0x0401738E RID: 95118
		protected UCurveFloat CurveMeX;

		// Token: 0x0401738F RID: 95119
		protected UCurveFloat CurveOppositeX;

		// Token: 0x04017390 RID: 95120
		protected UCurveFloat CurveCommon;

		// Token: 0x04017391 RID: 95121
		protected UCurveFloat CurveDamageX;

		// Token: 0x04017392 RID: 95122
		protected UCurveFloat CurveDamageYMe;

		// Token: 0x04017393 RID: 95123
		protected UCurveFloat CurveDamageYNpc;

		// Token: 0x04017394 RID: 95124
		protected LguiFloatTween TweenerNpcX;

		// Token: 0x04017395 RID: 95125
		protected LguiFloatTween TweenerNpcZ;

		// Token: 0x04017396 RID: 95126
		protected LguiFloatTween TweenerMeX;

		// Token: 0x04017397 RID: 95127
		protected LguiFloatTween TweenerMeZ;

		// Token: 0x04017398 RID: 95128
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x04017399 RID: 95129
		protected int MeDamaged;

		// Token: 0x0401739A RID: 95130
		protected int MeBeforeDamaged;

		// Token: 0x0401739B RID: 95131
		protected int MeOriginalDamage;

		// Token: 0x0401739C RID: 95132
		protected int NpcDamaged;

		// Token: 0x0401739D RID: 95133
		protected int NpcBeforeDamaged;

		// Token: 0x0401739E RID: 95134
		protected int NpcOriginalDamage;

		// Token: 0x0401739F RID: 95135
		protected bool IsFinishSettle;

		// Token: 0x040173A0 RID: 95136
		protected string FlowListName = "";

		// Token: 0x040173A1 RID: 95137
		protected bool DamageAnimEnd;

		// Token: 0x040173A2 RID: 95138
		protected TimerHandle TimeHandle;

		// Token: 0x02009E9F RID: 40607
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040314DF RID: 201951
			public const int OwnArea = 0;

			// Token: 0x040314E0 RID: 201952
			public const int OpponentArea = 1;

			// Token: 0x040314E1 RID: 201953
			public const int BackBtn = 2;

			// Token: 0x040314E2 RID: 201954
			public const int SkipBtn = 3;

			// Token: 0x040314E3 RID: 201955
			public const int DraggableComponent = 4;

			// Token: 0x040314E4 RID: 201956
			public const int NiagaraPoint = 5;

			// Token: 0x040314E5 RID: 201957
			public const int TxtSpeed = 6;

			// Token: 0x040314E6 RID: 201958
			public const int NiagaraPointMe = 7;

			// Token: 0x040314E7 RID: 201959
			public const int CameraMoveItem = 8;

			// Token: 0x040314E8 RID: 201960
			public const int DamageStatisticsItem = 9;
		}
	}
}
