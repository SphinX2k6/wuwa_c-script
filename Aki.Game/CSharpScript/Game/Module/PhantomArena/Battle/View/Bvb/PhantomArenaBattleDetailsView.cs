using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005273 RID: 21107
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsView : UiTickViewBase, IUiProhibitRefreshData, IExtraShowCursor
	{
		// Token: 0x06035FA1 RID: 221089 RVA: 0x00CC593F File Offset: 0x00CC3B3F
		public PhantomArenaBattleDetailsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035FA2 RID: 221090 RVA: 0x00CC5954 File Offset: 0x00CC3B54
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

		// Token: 0x06035FA3 RID: 221091 RVA: 0x00CC5A98 File Offset: 0x00CC3C98
		private UniTask InitMobileJoystick()
		{
			PhantomArenaBattleDetailsView.<InitMobileJoystick>d__36 <InitMobileJoystick>d__;
			<InitMobileJoystick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitMobileJoystick>d__.<>4__this = this;
			<InitMobileJoystick>d__.<>1__state = -1;
			<InitMobileJoystick>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitMobileJoystick>d__36>(ref <InitMobileJoystick>d__);
			return <InitMobileJoystick>d__.<>t__builder.Task;
		}

		// Token: 0x06035FA4 RID: 221092 RVA: 0x00CC5ADC File Offset: 0x00CC3CDC
		private UniTask InitOwnArea()
		{
			PhantomArenaBattleDetailsView.<InitOwnArea>d__37 <InitOwnArea>d__;
			<InitOwnArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOwnArea>d__.<>4__this = this;
			<InitOwnArea>d__.<>1__state = -1;
			<InitOwnArea>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitOwnArea>d__37>(ref <InitOwnArea>d__);
			return <InitOwnArea>d__.<>t__builder.Task;
		}

		// Token: 0x06035FA5 RID: 221093 RVA: 0x00CC5B20 File Offset: 0x00CC3D20
		private UniTask InitOpponentArea()
		{
			PhantomArenaBattleDetailsView.<InitOpponentArea>d__38 <InitOpponentArea>d__;
			<InitOpponentArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitOpponentArea>d__.<>4__this = this;
			<InitOpponentArea>d__.<>1__state = -1;
			<InitOpponentArea>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitOpponentArea>d__38>(ref <InitOpponentArea>d__);
			return <InitOpponentArea>d__.<>t__builder.Task;
		}

		// Token: 0x06035FA6 RID: 221094 RVA: 0x00CC5B64 File Offset: 0x00CC3D64
		private UniTask InitCurve()
		{
			PhantomArenaBattleDetailsView.<InitCurve>d__39 <InitCurve>d__;
			<InitCurve>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurve>d__.<>4__this = this;
			<InitCurve>d__.<>1__state = -1;
			<InitCurve>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurve>d__39>(ref <InitCurve>d__);
			return <InitCurve>d__.<>t__builder.Task;
		}

		// Token: 0x06035FA7 RID: 221095 RVA: 0x00CC5BA8 File Offset: 0x00CC3DA8
		private UniTask InitCurveZ()
		{
			PhantomArenaBattleDetailsView.<InitCurveZ>d__40 <InitCurveZ>d__;
			<InitCurveZ>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveZ>d__.<>4__this = this;
			<InitCurveZ>d__.<>1__state = -1;
			<InitCurveZ>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveZ>d__40>(ref <InitCurveZ>d__);
			return <InitCurveZ>d__.<>t__builder.Task;
		}

		// Token: 0x06035FA8 RID: 221096 RVA: 0x00CC5BEC File Offset: 0x00CC3DEC
		private UniTask InitCurveMeX()
		{
			PhantomArenaBattleDetailsView.<InitCurveMeX>d__41 <InitCurveMeX>d__;
			<InitCurveMeX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveMeX>d__.<>4__this = this;
			<InitCurveMeX>d__.<>1__state = -1;
			<InitCurveMeX>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveMeX>d__41>(ref <InitCurveMeX>d__);
			return <InitCurveMeX>d__.<>t__builder.Task;
		}

		// Token: 0x06035FA9 RID: 221097 RVA: 0x00CC5C30 File Offset: 0x00CC3E30
		private UniTask InitCurveOppositeX()
		{
			PhantomArenaBattleDetailsView.<InitCurveOppositeX>d__42 <InitCurveOppositeX>d__;
			<InitCurveOppositeX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveOppositeX>d__.<>4__this = this;
			<InitCurveOppositeX>d__.<>1__state = -1;
			<InitCurveOppositeX>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveOppositeX>d__42>(ref <InitCurveOppositeX>d__);
			return <InitCurveOppositeX>d__.<>t__builder.Task;
		}

		// Token: 0x06035FAA RID: 221098 RVA: 0x00CC5C74 File Offset: 0x00CC3E74
		private UniTask InitCurveCommon()
		{
			PhantomArenaBattleDetailsView.<InitCurveCommon>d__43 <InitCurveCommon>d__;
			<InitCurveCommon>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveCommon>d__.<>4__this = this;
			<InitCurveCommon>d__.<>1__state = -1;
			<InitCurveCommon>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveCommon>d__43>(ref <InitCurveCommon>d__);
			return <InitCurveCommon>d__.<>t__builder.Task;
		}

		// Token: 0x06035FAB RID: 221099 RVA: 0x00CC5CB8 File Offset: 0x00CC3EB8
		private UniTask InitCurveDamageX()
		{
			PhantomArenaBattleDetailsView.<InitCurveDamageX>d__44 <InitCurveDamageX>d__;
			<InitCurveDamageX>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamageX>d__.<>4__this = this;
			<InitCurveDamageX>d__.<>1__state = -1;
			<InitCurveDamageX>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveDamageX>d__44>(ref <InitCurveDamageX>d__);
			return <InitCurveDamageX>d__.<>t__builder.Task;
		}

		// Token: 0x06035FAC RID: 221100 RVA: 0x00CC5CFC File Offset: 0x00CC3EFC
		private UniTask InitCurveDamageYMe()
		{
			PhantomArenaBattleDetailsView.<InitCurveDamageYMe>d__45 <InitCurveDamageYMe>d__;
			<InitCurveDamageYMe>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamageYMe>d__.<>4__this = this;
			<InitCurveDamageYMe>d__.<>1__state = -1;
			<InitCurveDamageYMe>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveDamageYMe>d__45>(ref <InitCurveDamageYMe>d__);
			return <InitCurveDamageYMe>d__.<>t__builder.Task;
		}

		// Token: 0x06035FAD RID: 221101 RVA: 0x00CC5D40 File Offset: 0x00CC3F40
		private UniTask InitCurveDamageYNpc()
		{
			PhantomArenaBattleDetailsView.<InitCurveDamageYNpc>d__46 <InitCurveDamageYNpc>d__;
			<InitCurveDamageYNpc>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitCurveDamageYNpc>d__.<>4__this = this;
			<InitCurveDamageYNpc>d__.<>1__state = -1;
			<InitCurveDamageYNpc>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitCurveDamageYNpc>d__46>(ref <InitCurveDamageYNpc>d__);
			return <InitCurveDamageYNpc>d__.<>t__builder.Task;
		}

		// Token: 0x06035FAE RID: 221102 RVA: 0x00CC5D84 File Offset: 0x00CC3F84
		private void InitHeadStatePanel()
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
			BattleViewProxy battleViewProxy = ((viewByName != null) ? viewByName.OpenParam : null) as BattleViewProxy;
			this.HeadStatePanel = ((battleViewProxy != null) ? battleViewProxy.HeadStatePanel : null);
		}

		// Token: 0x06035FAF RID: 221103 RVA: 0x00CC5DC4 File Offset: 0x00CC3FC4
		private UniTask InitDamageStatistics()
		{
			PhantomArenaBattleDetailsView.<InitDamageStatistics>d__48 <InitDamageStatistics>d__;
			<InitDamageStatistics>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDamageStatistics>d__.<>4__this = this;
			<InitDamageStatistics>d__.<>1__state = -1;
			<InitDamageStatistics>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<InitDamageStatistics>d__48>(ref <InitDamageStatistics>d__);
			return <InitDamageStatistics>d__.<>t__builder.Task;
		}

		// Token: 0x06035FB0 RID: 221104 RVA: 0x00CC5E08 File Offset: 0x00CC4008
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaBattleDetailsView.<OnBeforeStartAsync>d__49 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<OnBeforeStartAsync>d__49>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035FB1 RID: 221105 RVA: 0x00CC5E4C File Offset: 0x00CC404C
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

		// Token: 0x06035FB2 RID: 221106 RVA: 0x00CC600C File Offset: 0x00CC420C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.PhantomArenaStartTurnResult, new Action<PhantomBattleBvBSettleNotify>(this.OnTurnBattleEnd));
			EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaBattleDamageAccumulateEnd, new Action(this.OnAccumulateAnimEnd));
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x06035FB3 RID: 221107 RVA: 0x00CC608C File Offset: 0x00CC428C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.PhantomArenaStartTurnResult, new Action<PhantomBattleBvBSettleNotify>(this.OnTurnBattleEnd));
			EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnAnimEvent));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaBattleDamageAccumulateEnd, new Action(this.OnAccumulateAnimEnd));
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.OnInputControllerMainTypeChange));
		}

		// Token: 0x06035FB4 RID: 221108 RVA: 0x00CC610C File Offset: 0x00CC430C
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

		// Token: 0x06035FB5 RID: 221109 RVA: 0x00CC6214 File Offset: 0x00CC4414
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

		// Token: 0x06035FB6 RID: 221110 RVA: 0x00CC627A File Offset: 0x00CC447A
		private void OnClickBackBtn()
		{
			InstanceDungeonController.Instance.OnClickInstanceDungeonExitButton(new Action(PhantomArenaBattleModel.Instance.OnClickExitButtonConfirm), null, true);
		}

		// Token: 0x06035FB7 RID: 221111 RVA: 0x00CC6298 File Offset: 0x00CC4498
		private void OnClickSkipBtn()
		{
			PhantomArenaBattleModel.Instance.SetSpeedUp();
			this.SetSpeedText();
		}

		// Token: 0x06035FB8 RID: 221112 RVA: 0x00CC62AA File Offset: 0x00CC44AA
		private void RegisterExtraShowCursor()
		{
			InputExtraShowCursorCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x06035FB9 RID: 221113 RVA: 0x00CC62C7 File Offset: 0x00CC44C7
		private void UnRegisterExtraShowCursor()
		{
			InputExtraShowCursorCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x06035FBA RID: 221114 RVA: 0x00CC62E3 File Offset: 0x00CC44E3
		private void RegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(this.ViewInfo.Name, this);
		}

		// Token: 0x06035FBB RID: 221115 RVA: 0x00CC6300 File Offset: 0x00CC4500
		private void UnRegisterExtraUiProhibitRefresh()
		{
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(this.ViewInfo.Name);
		}

		// Token: 0x06035FBC RID: 221116 RVA: 0x00CC631C File Offset: 0x00CC451C
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

		// Token: 0x06035FBD RID: 221117 RVA: 0x00CC6364 File Offset: 0x00CC4564
		private void RefreshOwnLife()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OwnData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			this.OwnArea.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035FBE RID: 221118 RVA: 0x00CC63A8 File Offset: 0x00CC45A8
		private void RefreshOwnShield()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OwnData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.OwnArea.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x06035FBF RID: 221119 RVA: 0x00CC63D8 File Offset: 0x00CC45D8
		private void RefreshOpponentLife()
		{
			int battleStatusValue = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleLife);
			int battleStatusValue2 = PhantomArenaBattleModel.Instance.OpponentData.GetBattleStatusValue(PhantomBattleRoleStatus.PhantomBattleMaxLife);
			this.OpponentArea.RoleItem.RefreshLifeNum(battleStatusValue, battleStatusValue2);
		}

		// Token: 0x06035FC0 RID: 221120 RVA: 0x00CC641C File Offset: 0x00CC461C
		private void RefreshOpponentShield()
		{
			int battleBattleAttr = PhantomArenaBattleModel.Instance.OpponentData.GetBattleBattleAttr(PhantomBattleCardAttr.Defence);
			this.OpponentArea.RoleItem.RefreshShieldNum(battleBattleAttr);
		}

		// Token: 0x06035FC1 RID: 221121 RVA: 0x00CC644C File Offset: 0x00CC464C
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

		// Token: 0x06035FC2 RID: 221122 RVA: 0x00CC649F File Offset: 0x00CC469F
		public void SetOwnAllSettlePoint(int allSettlePoint)
		{
			this.OwnArea.SetSettlePoint(allSettlePoint);
		}

		// Token: 0x06035FC3 RID: 221123 RVA: 0x00CC64AD File Offset: 0x00CC46AD
		public void SetOpponentSettlePoint(int opponentSettlePoint)
		{
			this.OpponentArea.SetSettlePoint(opponentSettlePoint);
		}

		// Token: 0x06035FC4 RID: 221124 RVA: 0x00CC64BC File Offset: 0x00CC46BC
		public bool CheckCondition()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			HashSet<EUiViewName> hashSet = (instance != null) ? instance.GetNotAllowFightInputViewNameSet() : null;
			if (hashSet == null || hashSet.Count == 0)
			{
				return false;
			}
			List<EUiViewName> list = hashSet.ToList<EUiViewName>();
			return !(list[list.Count - 1] != this.ViewInfo.Name);
		}

		// Token: 0x06035FC5 RID: 221125 RVA: 0x00CC6510 File Offset: 0x00CC4710
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

		// Token: 0x06035FC6 RID: 221126 RVA: 0x00CC6588 File Offset: 0x00CC4788
		public bool IsShowCursor()
		{
			InputDistributeModel instance = InputDistributeModel.Instance;
			HashSet<EUiViewName> hashSet = (instance != null) ? instance.GetNotAllowFightInputViewNameSet() : null;
			if (hashSet == null || hashSet.Count == 0)
			{
				return true;
			}
			List<EUiViewName> list = hashSet.ToList<EUiViewName>();
			return list[list.Count - 1] != this.ViewInfo.Name;
		}

		// Token: 0x06035FC7 RID: 221127 RVA: 0x00CC65DC File Offset: 0x00CC47DC
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

		// Token: 0x06035FC8 RID: 221128 RVA: 0x00CC6724 File Offset: 0x00CC4924
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

		// Token: 0x06035FC9 RID: 221129 RVA: 0x00CC6780 File Offset: 0x00CC4980
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

		// Token: 0x06035FCA RID: 221130 RVA: 0x00CC68C0 File Offset: 0x00CC4AC0
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

		// Token: 0x06035FCB RID: 221131 RVA: 0x00CC68F4 File Offset: 0x00CC4AF4
		private UniTask OnOpponentWinDamage()
		{
			PhantomArenaBattleDetailsView.<OnOpponentWinDamage>d__76 <OnOpponentWinDamage>d__;
			<OnOpponentWinDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnOpponentWinDamage>d__.<>4__this = this;
			<OnOpponentWinDamage>d__.<>1__state = -1;
			<OnOpponentWinDamage>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<OnOpponentWinDamage>d__76>(ref <OnOpponentWinDamage>d__);
			return <OnOpponentWinDamage>d__.<>t__builder.Task;
		}

		// Token: 0x06035FCC RID: 221132 RVA: 0x00CC6938 File Offset: 0x00CC4B38
		private UniTask OnMeWinDamage()
		{
			PhantomArenaBattleDetailsView.<OnMeWinDamage>d__77 <OnMeWinDamage>d__;
			<OnMeWinDamage>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnMeWinDamage>d__.<>4__this = this;
			<OnMeWinDamage>d__.<>1__state = -1;
			<OnMeWinDamage>d__.<>t__builder.Start<PhantomArenaBattleDetailsView.<OnMeWinDamage>d__77>(ref <OnMeWinDamage>d__);
			return <OnMeWinDamage>d__.<>t__builder.Task;
		}

		// Token: 0x06035FCD RID: 221133 RVA: 0x00CC697B File Offset: 0x00CC4B7B
		private void RemoveTimerHandle()
		{
			if (this.TimeHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimeHandle);
				this.TimeHandle = null;
			}
		}

		// Token: 0x06035FCE RID: 221134 RVA: 0x00CC699D File Offset: 0x00CC4B9D
		protected override string OnGetLoopAudioEvent()
		{
			if (PhantomArenaBattleModel.Instance.IsOldBvb)
			{
				return this.ViewInfo.LoopAudioEvent;
			}
			return "play_ui_music_3_0_arena_card_battle";
		}

		// Token: 0x06035FCF RID: 221135 RVA: 0x00CC69BC File Offset: 0x00CC4BBC
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

		// Token: 0x06035FD0 RID: 221136 RVA: 0x00CC6A34 File Offset: 0x00CC4C34
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

		// Token: 0x06035FD1 RID: 221137 RVA: 0x00CC6AAC File Offset: 0x00CC4CAC
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

		// Token: 0x06035FD2 RID: 221138 RVA: 0x00CC6B24 File Offset: 0x00CC4D24
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

		// Token: 0x06035FD3 RID: 221139 RVA: 0x00CC6B9C File Offset: 0x00CC4D9C
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

		// Token: 0x06035FD4 RID: 221140 RVA: 0x00CC6BF0 File Offset: 0x00CC4DF0
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

		// Token: 0x06035FD5 RID: 221141 RVA: 0x00CC6C44 File Offset: 0x00CC4E44
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

		// Token: 0x06035FD6 RID: 221142 RVA: 0x00CC6D40 File Offset: 0x00CC4F40
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

		// Token: 0x06035FD7 RID: 221143 RVA: 0x00CC6D98 File Offset: 0x00CC4F98
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

		// Token: 0x06035FD8 RID: 221144 RVA: 0x00CC6E40 File Offset: 0x00CC5040
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

		// Token: 0x06035FD9 RID: 221145 RVA: 0x00CC6E93 File Offset: 0x00CC5093
		private void OnInputControllerMainTypeChange(EInputControllerMainType last, EInputControllerMainType now)
		{
			if (last == EInputControllerMainType.Gamepad)
			{
				this.Proxy.SetIsInGamepadNavigation(false);
			}
		}

		// Token: 0x0401C94D RID: 117069
		private const int ANIM_DAMAGE_DELAY = 4500;

		// Token: 0x0401C94E RID: 117070
		private const int DAMAGE_FIRST = 10;

		// Token: 0x0401C94F RID: 117071
		protected PhantomArenaBattleDetailsAreaItem OwnArea;

		// Token: 0x0401C950 RID: 117072
		protected PhantomArenaBattleDetailsAreaItem OpponentArea;

		// Token: 0x0401C951 RID: 117073
		protected PhantomArenaBattleDetailsViewProxy Proxy;

		// Token: 0x0401C952 RID: 117074
		protected BattleHeadStatePanel HeadStatePanel;

		// Token: 0x0401C953 RID: 117075
		protected PhantomArenaJoystick MobileJoystick;

		// Token: 0x0401C954 RID: 117076
		protected PhantomArenaBattleDamageStatisticsPanel DamageStatistics;

		// Token: 0x0401C955 RID: 117077
		protected bool IsWin;

		// Token: 0x0401C956 RID: 117078
		protected bool AccumulateTween;

		// Token: 0x0401C957 RID: 117079
		protected bool AnimDamageTween;

		// Token: 0x0401C958 RID: 117080
		protected UCurveFloat CurveZ;

		// Token: 0x0401C959 RID: 117081
		protected UCurveFloat CurveMeX;

		// Token: 0x0401C95A RID: 117082
		protected UCurveFloat CurveOppositeX;

		// Token: 0x0401C95B RID: 117083
		protected UCurveFloat CurveCommon;

		// Token: 0x0401C95C RID: 117084
		protected UCurveFloat CurveDamageX;

		// Token: 0x0401C95D RID: 117085
		protected UCurveFloat CurveDamageYMe;

		// Token: 0x0401C95E RID: 117086
		protected UCurveFloat CurveDamageYNpc;

		// Token: 0x0401C95F RID: 117087
		protected LguiFloatTween TweenerNpcX;

		// Token: 0x0401C960 RID: 117088
		protected LguiFloatTween TweenerNpcZ;

		// Token: 0x0401C961 RID: 117089
		protected LguiFloatTween TweenerMeX;

		// Token: 0x0401C962 RID: 117090
		protected LguiFloatTween TweenerMeZ;

		// Token: 0x0401C963 RID: 117091
		protected LevelSequencePlayer SequencePlayer;

		// Token: 0x0401C964 RID: 117092
		protected int MeDamaged;

		// Token: 0x0401C965 RID: 117093
		protected int MeBeforeDamaged;

		// Token: 0x0401C966 RID: 117094
		protected int MeOriginalDamage;

		// Token: 0x0401C967 RID: 117095
		protected int NpcDamaged;

		// Token: 0x0401C968 RID: 117096
		protected int NpcBeforeDamaged;

		// Token: 0x0401C969 RID: 117097
		protected int NpcOriginalDamage;

		// Token: 0x0401C96A RID: 117098
		protected bool IsFinishSettle;

		// Token: 0x0401C96B RID: 117099
		protected string FlowListName = "";

		// Token: 0x0401C96C RID: 117100
		protected bool DamageAnimEnd;

		// Token: 0x0401C96D RID: 117101
		protected TimerHandle TimeHandle;

		// Token: 0x0200B467 RID: 46183
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036A8C RID: 223884
			public const int OwnArea = 0;

			// Token: 0x04036A8D RID: 223885
			public const int OpponentArea = 1;

			// Token: 0x04036A8E RID: 223886
			public const int BackBtn = 2;

			// Token: 0x04036A8F RID: 223887
			public const int SkipBtn = 3;

			// Token: 0x04036A90 RID: 223888
			public const int DraggableComponent = 4;

			// Token: 0x04036A91 RID: 223889
			public const int NiagaraPoint = 5;

			// Token: 0x04036A92 RID: 223890
			public const int TxtSpeed = 6;

			// Token: 0x04036A93 RID: 223891
			public const int NiagaraPointMe = 7;

			// Token: 0x04036A94 RID: 223892
			public const int CameraMoveItem = 8;

			// Token: 0x04036A95 RID: 223893
			public const int DamageStatisticsItem = 9;
		}
	}
}
