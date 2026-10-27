using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001244 RID: 4676
[NullableContext(1)]
[Nullable(0)]
public class DangoMonopolyRollDiceView : DangoMonopolyViewBase
{
	// Token: 0x17000ABE RID: 2750
	// (get) Token: 0x06007EE6 RID: 32486 RVA: 0x001AE537 File Offset: 0x001AC737
	[Nullable(2)]
	public new DangoMonopolyRollDiceViewParam OpenParam
	{
		[NullableContext(2)]
		get
		{
			return this.OpenParam as DangoMonopolyRollDiceViewParam;
		}
	}

	// Token: 0x06007EE7 RID: 32487 RVA: 0x001AE544 File Offset: 0x001AC744
	public DangoMonopolyRollDiceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007EE8 RID: 32488 RVA: 0x001AE558 File Offset: 0x001AC758
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

	// Token: 0x06007EE9 RID: 32489 RVA: 0x001AE645 File Offset: 0x001AC845
	private void InitDataParam()
	{
	}

	// Token: 0x06007EEA RID: 32490 RVA: 0x001AE648 File Offset: 0x001AC848
	protected override UniTask OnBeforeStartAsync()
	{
		DangoMonopolyRollDiceView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06007EEB RID: 32491 RVA: 0x001AE68B File Offset: 0x001AC88B
	protected override void OnStart()
	{
		this.ActivityData.UpdateBoardGridUiInfoShow(false).Forget();
	}

	// Token: 0x06007EEC RID: 32492 RVA: 0x001AE69E File Offset: 0x001AC89E
	protected override void OnAddEventListener()
	{
	}

	// Token: 0x06007EED RID: 32493 RVA: 0x001AE6A0 File Offset: 0x001AC8A0
	protected override void OnRemoveEventListener()
	{
	}

	// Token: 0x06007EEE RID: 32494 RVA: 0x001AE6A2 File Offset: 0x001AC8A2
	protected override void OnBeforeShow()
	{
		this.UpdateData().Forget();
	}

	// Token: 0x06007EEF RID: 32495 RVA: 0x001AE6B0 File Offset: 0x001AC8B0
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

	// Token: 0x06007EF0 RID: 32496 RVA: 0x001AE700 File Offset: 0x001AC900
	private void OnClickBtnSpeed()
	{
		this.ActivityData.SetActivitySpeed(null);
		this.UpdateSpeed();
	}

	// Token: 0x06007EF1 RID: 32497 RVA: 0x001AE727 File Offset: 0x001AC927
	private void OnClickBtnEmpty()
	{
		if (this.IsRollDiceFinish)
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06007EF2 RID: 32498 RVA: 0x001AE738 File Offset: 0x001AC938
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

	// Token: 0x06007EF3 RID: 32499 RVA: 0x001AE764 File Offset: 0x001AC964
	public UniTask UpdateData()
	{
		DangoMonopolyRollDiceView.<UpdateData>d__18 <UpdateData>d__;
		<UpdateData>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateData>d__.<>4__this = this;
		<UpdateData>d__.<>1__state = -1;
		<UpdateData>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<UpdateData>d__18>(ref <UpdateData>d__);
		return <UpdateData>d__.<>t__builder.Task;
	}

	// Token: 0x06007EF4 RID: 32500 RVA: 0x001AE7A8 File Offset: 0x001AC9A8
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

	// Token: 0x06007EF5 RID: 32501 RVA: 0x001AE7F4 File Offset: 0x001AC9F4
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

	// Token: 0x06007EF6 RID: 32502 RVA: 0x001AE8BC File Offset: 0x001ACABC
	public void DiceAnimStart()
	{
		Log.Instance.Info(ELogModule.DangoMonopoly, ELogAuthor.CX, "RollDice=>掷骰子动画开始", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.SetDiceVisible(true);
	}

	// Token: 0x06007EF7 RID: 32503 RVA: 0x001AE8F0 File Offset: 0x001ACAF0
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

	// Token: 0x06007EF8 RID: 32504 RVA: 0x001AE948 File Offset: 0x001ACB48
	public UniTask CheckTriggerBuff()
	{
		DangoMonopolyRollDiceView.<CheckTriggerBuff>d__23 <CheckTriggerBuff>d__;
		<CheckTriggerBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CheckTriggerBuff>d__.<>4__this = this;
		<CheckTriggerBuff>d__.<>1__state = -1;
		<CheckTriggerBuff>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<CheckTriggerBuff>d__23>(ref <CheckTriggerBuff>d__);
		return <CheckTriggerBuff>d__.<>t__builder.Task;
	}

	// Token: 0x06007EF9 RID: 32505 RVA: 0x001AE98C File Offset: 0x001ACB8C
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

	// Token: 0x06007EFA RID: 32506 RVA: 0x001AE9D8 File Offset: 0x001ACBD8
	public UniTask AgainPlayRollDice()
	{
		DangoMonopolyRollDiceView.<AgainPlayRollDice>d__25 <AgainPlayRollDice>d__;
		<AgainPlayRollDice>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AgainPlayRollDice>d__.<>4__this = this;
		<AgainPlayRollDice>d__.<>1__state = -1;
		<AgainPlayRollDice>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<AgainPlayRollDice>d__25>(ref <AgainPlayRollDice>d__);
		return <AgainPlayRollDice>d__.<>t__builder.Task;
	}

	// Token: 0x06007EFB RID: 32507 RVA: 0x001AEA1C File Offset: 0x001ACC1C
	public UniTask MoreStep()
	{
		DangoMonopolyRollDiceView.<MoreStep>d__26 <MoreStep>d__;
		<MoreStep>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<MoreStep>d__.<>4__this = this;
		<MoreStep>d__.<>1__state = -1;
		<MoreStep>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<MoreStep>d__26>(ref <MoreStep>d__);
		return <MoreStep>d__.<>t__builder.Task;
	}

	// Token: 0x06007EFC RID: 32508 RVA: 0x001AEA60 File Offset: 0x001ACC60
	public UniTask PointDouble()
	{
		DangoMonopolyRollDiceView.<PointDouble>d__27 <PointDouble>d__;
		<PointDouble>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PointDouble>d__.<>4__this = this;
		<PointDouble>d__.<>1__state = -1;
		<PointDouble>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<PointDouble>d__27>(ref <PointDouble>d__);
		return <PointDouble>d__.<>t__builder.Task;
	}

	// Token: 0x06007EFD RID: 32509 RVA: 0x001AEAA4 File Offset: 0x001ACCA4
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

	// Token: 0x06007EFE RID: 32510 RVA: 0x001AEAEF File Offset: 0x001ACCEF
	public void SetDiceVisible(bool visible)
	{
		base.GetItem(3).SetUIActive(visible);
	}

	// Token: 0x06007EFF RID: 32511 RVA: 0x001AEB00 File Offset: 0x001ACD00
	public UniTask WaitAutoTime()
	{
		DangoMonopolyRollDiceView.<WaitAutoTime>d__30 <WaitAutoTime>d__;
		<WaitAutoTime>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitAutoTime>d__.<>4__this = this;
		<WaitAutoTime>d__.<>1__state = -1;
		<WaitAutoTime>d__.<>t__builder.Start<DangoMonopolyRollDiceView.<WaitAutoTime>d__30>(ref <WaitAutoTime>d__);
		return <WaitAutoTime>d__.<>t__builder.Task;
	}

	// Token: 0x040039CE RID: 14798
	public bool IsRollDiceFinish;

	// Token: 0x040039CF RID: 14799
	public DangoMonopolyDiceBuffPanel DiceBuffPanel;

	// Token: 0x040039D0 RID: 14800
	public readonly float AutoWaitTime = 1000f;

	// Token: 0x02007852 RID: 30802
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027A6A RID: 162410
		BtnSpeed,
		// Token: 0x04027A6B RID: 162411
		TxtSpeedTitle,
		// Token: 0x04027A6C RID: 162412
		BtnEmpty,
		// Token: 0x04027A6D RID: 162413
		DiceRoot,
		// Token: 0x04027A6E RID: 162414
		TextureDice,
		// Token: 0x04027A6F RID: 162415
		TxtDebug,
		// Token: 0x04027A70 RID: 162416
		ItemBuffPos
	}
}
