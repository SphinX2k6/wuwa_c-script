using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020006F8 RID: 1784
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyRollDiceView : DangoMonopolyViewBase
{
	// Token: 0x17000ADE RID: 2782
	// (get) Token: 0x0600527D RID: 21117 RVA: 0x001B71EF File Offset: 0x001B53EF
	[Nullable(2)]
	public new DangoMonopolyRollDiceViewParam OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyRollDiceViewParam;
		}
	}

	// Token: 0x0600527E RID: 21118 RVA: 0x001B71FC File Offset: 0x001B53FC
	public DangoMonopolyRollDiceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600527F RID: 21119 RVA: 0x001B7210 File Offset: 0x001B5410
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnSpeed)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnEmpty))
		};
	}

	// Token: 0x06005280 RID: 21120 RVA: 0x001B72FD File Offset: 0x001B54FD
	private void InitDataParam()
	{
	}

	// Token: 0x06005281 RID: 21121 RVA: 0x001B7300 File Offset: 0x001B5500
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRollDiceView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005282 RID: 21122 RVA: 0x001B7343 File Offset: 0x001B5543
	protected override void OnStart()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
	}

	// Token: 0x06005283 RID: 21123 RVA: 0x001B7356 File Offset: 0x001B5556
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06005284 RID: 21124 RVA: 0x001B7358 File Offset: 0x001B5558
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06005285 RID: 21125 RVA: 0x001B735A File Offset: 0x001B555A
	protected override void OnBeforeShow()
	{
		this.UpdateData().Forget();
	}

	// Token: 0x06005286 RID: 21126 RVA: 0x001B7368 File Offset: 0x001B5568
	protected override void OnBeforeDestroy()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(true).Forget();
		EventSystem.Instance.Emit(EEventName.DangoMonopolyMoveStart);
		EventSystem.Instance.Emit<bool>(EEventName.DangoMonopolyMoveStepStartOrEnd, true);
		DangoMonopolyDiceBuffPanel diceBuffPanel = this.DiceBuffPanel;
		if (diceBuffPanel == null)
		{
			return;
		}
		diceBuffPanel.Destroy(null);
	}

	// Token: 0x06005287 RID: 21127 RVA: 0x001B73B8 File Offset: 0x001B55B8
	private void OnClickBtnSpeed()
	{
		this.ActivityData.SetActivitySpeed(null);
		this.UpdateSpeed();
	}

	// Token: 0x06005288 RID: 21128 RVA: 0x001B73DF File Offset: 0x001B55DF
	private void OnClickBtnEmpty()
	{
		if (this.IsRollDiceFinish)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06005289 RID: 21129 RVA: 0x001B73F0 File Offset: 0x001B55F0
	public void UpdateSpeed()
	{
		string speedStr = this.ActivityData.GetSpeedStr();
		UUIText text = base.GetText(1);
		if (text == null)
		{
			return;
		}
		text.SetText(speedStr, true);
	}

	// Token: 0x0600528A RID: 21130 RVA: 0x001B741C File Offset: 0x001B561C
	public UniTask UpdateData()
	{
		DangoMonopolyRollDiceView.<UpdateData>d__18 <UpdateData>d__;
		<UpdateData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateData>d__.<>4__this = this;
		<UpdateData>d__.<>1__state = -1;
		<UpdateData>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<UpdateData>d__18>(ref <UpdateData>d__);
		return <UpdateData>d__.<>t__builder.Task;
	}

	// Token: 0x0600528B RID: 21131 RVA: 0x001B7460 File Offset: 0x001B5660
	public UniTask PlayRollDice(int diceNum)
	{
		DangoMonopolyRollDiceView.<PlayRollDice>d__19 <PlayRollDice>d__;
		<PlayRollDice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayRollDice>d__.<>4__this = this;
		<PlayRollDice>d__.diceNum = diceNum;
		<PlayRollDice>d__.<>1__state = -1;
		<PlayRollDice>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<PlayRollDice>d__19>(ref <PlayRollDice>d__);
		return <PlayRollDice>d__.<>t__builder.Task;
	}

	// Token: 0x0600528C RID: 21132 RVA: 0x001B74AC File Offset: 0x001B56AC
	public string GetDebugText(string suffix)
	{
		DangoMonopolyRollDiceViewParam openParam = this.OpenParam;
		int value = (openParam != null) ? openParam.DiceResult : 1;
		DangoMonopolyRollDiceViewParam openParam2 = this.OpenParam;
		int valueOrDefault = ((openParam2 != null) ? openParam2.TriggerBuffId : null).GetValueOrDefault();
		DangoMonopolyRollDiceViewParam openParam3 = this.OpenParam;
		int valueOrDefault2 = ((openParam3 != null) ? openParam3.TriggerBuffResult : null).GetValueOrDefault();
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 4);
		defaultInterpolatedStringHandler.AppendLiteral("骰子: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral(", 特性id: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault);
		defaultInterpolatedStringHandler.AppendLiteral(", 特性结果: ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(valueOrDefault2);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendFormatted(suffix);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600528D RID: 21133 RVA: 0x001B7574 File Offset: 0x001B5774
	public void DiceAnimStart()
	{
		Log.Instance.Info(ELogModule.DangoMonopoly, ELogAuthor.CX, "RollDice=>掷骰子动画开始", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.SetDiceVisible(true);
	}

	// Token: 0x0600528E RID: 21134 RVA: 0x001B75A8 File Offset: 0x001B57A8
	public void DiceAnimEnd()
	{
		Log.Instance.Info(ELogModule.DangoMonopoly, ELogAuthor.CX, "RollDice=>掷骰子动画结束", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.IsRollDiceFinish = true;
		BP_DiceOL_C diceOutlineBp = this.ActivityData.RollDice.DiceOutlineBp;
		if (diceOutlineBp != null)
		{
			diceOutlineBp.SetActorHiddenInGame(true);
		}
		base.CloseMe(null);
	}

	// Token: 0x0600528F RID: 21135 RVA: 0x001B7600 File Offset: 0x001B5800
	public UniTask CheckTriggerBuff()
	{
		DangoMonopolyRollDiceView.<CheckTriggerBuff>d__23 <CheckTriggerBuff>d__;
		<CheckTriggerBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckTriggerBuff>d__.<>4__this = this;
		<CheckTriggerBuff>d__.<>1__state = -1;
		<CheckTriggerBuff>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<CheckTriggerBuff>d__23>(ref <CheckTriggerBuff>d__);
		return <CheckTriggerBuff>d__.<>t__builder.Task;
	}

	// Token: 0x06005290 RID: 21136 RVA: 0x001B7644 File Offset: 0x001B5844
	public UniTask PlayBuffEffect(int buffId)
	{
		DangoMonopolyRollDiceView.<PlayBuffEffect>d__24 <PlayBuffEffect>d__;
		<PlayBuffEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayBuffEffect>d__.<>4__this = this;
		<PlayBuffEffect>d__.buffId = buffId;
		<PlayBuffEffect>d__.<>1__state = -1;
		<PlayBuffEffect>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<PlayBuffEffect>d__24>(ref <PlayBuffEffect>d__);
		return <PlayBuffEffect>d__.<>t__builder.Task;
	}

	// Token: 0x06005291 RID: 21137 RVA: 0x001B7690 File Offset: 0x001B5890
	public UniTask AgainPlayRollDice()
	{
		DangoMonopolyRollDiceView.<AgainPlayRollDice>d__25 <AgainPlayRollDice>d__;
		<AgainPlayRollDice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AgainPlayRollDice>d__.<>4__this = this;
		<AgainPlayRollDice>d__.<>1__state = -1;
		<AgainPlayRollDice>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<AgainPlayRollDice>d__25>(ref <AgainPlayRollDice>d__);
		return <AgainPlayRollDice>d__.<>t__builder.Task;
	}

	// Token: 0x06005292 RID: 21138 RVA: 0x001B76D4 File Offset: 0x001B58D4
	public UniTask MoreStep()
	{
		DangoMonopolyRollDiceView.<MoreStep>d__26 <MoreStep>d__;
		<MoreStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoreStep>d__.<>4__this = this;
		<MoreStep>d__.<>1__state = -1;
		<MoreStep>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<MoreStep>d__26>(ref <MoreStep>d__);
		return <MoreStep>d__.<>t__builder.Task;
	}

	// Token: 0x06005293 RID: 21139 RVA: 0x001B7718 File Offset: 0x001B5918
	public UniTask PointDouble()
	{
		DangoMonopolyRollDiceView.<PointDouble>d__27 <PointDouble>d__;
		<PointDouble>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PointDouble>d__.<>4__this = this;
		<PointDouble>d__.<>1__state = -1;
		<PointDouble>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<PointDouble>d__27>(ref <PointDouble>d__);
		return <PointDouble>d__.<>t__builder.Task;
	}

	// Token: 0x06005294 RID: 21140 RVA: 0x001B775C File Offset: 0x001B595C
	public UniTask PointReplace(int? point = null)
	{
		DangoMonopolyRollDiceView.<PointReplace>d__28 <PointReplace>d__;
		<PointReplace>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PointReplace>d__.<>4__this = this;
		<PointReplace>d__.point = point;
		<PointReplace>d__.<>1__state = -1;
		<PointReplace>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<PointReplace>d__28>(ref <PointReplace>d__);
		return <PointReplace>d__.<>t__builder.Task;
	}

	// Token: 0x06005295 RID: 21141 RVA: 0x001B77A7 File Offset: 0x001B59A7
	public void SetDiceVisible(bool visible)
	{
		base.GetItem(3).SetUIActive(visible);
	}

	// Token: 0x06005296 RID: 21142 RVA: 0x001B77B8 File Offset: 0x001B59B8
	public UniTask WaitAutoTime()
	{
		DangoMonopolyRollDiceView.<WaitAutoTime>d__30 <WaitAutoTime>d__;
		<WaitAutoTime>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitAutoTime>d__.<>4__this = this;
		<WaitAutoTime>d__.<>1__state = -1;
		<WaitAutoTime>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<WaitAutoTime>d__30>(ref <WaitAutoTime>d__);
		return <WaitAutoTime>d__.<>t__builder.Task;
	}

	// Token: 0x04003A66 RID: 14950
	public bool IsRollDiceFinish;

	// Token: 0x04003A67 RID: 14951
	public DangoMonopolyDiceBuffPanel DiceBuffPanel;

	// Token: 0x04003A68 RID: 14952
	public readonly float AutoWaitTime = 1000f;

	// Token: 0x020069DD RID: 27101
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04022D9B RID: 142747
		BtnSpeed,
		// Token: 0x04022D9C RID: 142748
		TxtSpeedTitle,
		// Token: 0x04022D9D RID: 142749
		BtnEmpty,
		// Token: 0x04022D9E RID: 142750
		DiceRoot,
		// Token: 0x04022D9F RID: 142751
		TextureDice,
		// Token: 0x04022DA0 RID: 142752
		TxtDebug,
		// Token: 0x04022DA1 RID: 142753
		ItemBuffPos
	}
}
