using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002A11 RID: 10769
[NullableContext(1)]
[Nullable(0)]
public class SignalItem : SignalItemBase
{
	// Token: 0x06016599 RID: 91545 RVA: 0x005A8168 File Offset: 0x005A6368
	public SignalItem(ESignalType type, float rootHalfWidth, int startDecisionSize, int endDecisionSize) : base(type, rootHalfWidth, startDecisionSize, endDecisionSize)
	{
	}

	// Token: 0x0601659A RID: 91546 RVA: 0x005A8178 File Offset: 0x005A6378
	public void Init(UUIItem uiItem, float offsetX)
	{
		base.SetRootActor(uiItem.GetOwner(), true);
		this.Width = this.RootItem.GetWidth();
		this.RootItem.SetAnchorOffsetX(offsetX);
		this.BgOverSpriteYellowColor = new FColor?(FColor.FromHex("E8CD74"));
		this.BgOverSpriteRedColor = new FColor?(FColor.FromHex("FF6A6A"));
		this.BgOverSpriteGreenColor = new FColor?(FColor.FromHex("9DED87"));
		this.BgOverSpriteOrangeColor = new FColor?(FColor.FromHex("FF6827"));
	}

	// Token: 0x0601659B RID: 91547 RVA: 0x005A8204 File Offset: 0x005A6404
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUINiagara)),
			new ValueTuple<int, Type>(2, typeof(UUINiagara)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
	}

	// Token: 0x0601659C RID: 91548 RVA: 0x005A828C File Offset: 0x005A648C
	protected override void OnStart()
	{
		this.BgSprite = base.GetSprite(0);
		this.BgOverSprite = base.GetSprite(4);
		this.GraySignal = base.GetUiNiagara(1);
		this.HighlightSignal = base.GetUiNiagara(2);
		this.Line = base.GetSprite(3);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0601659D RID: 91549 RVA: 0x005A82EC File Offset: 0x005A64EC
	protected override void OnReset()
	{
		this.BgSprite.SetFillAmount(1f);
		this.BgSprite.SetAlpha(1f);
		this.BgSprite.SetUIActive(true);
		this.BgOverSprite.SetFillAmount(0f);
		ESignalGameplayType currentGameplayType = SignalDecodeModel.Instance.CurrentGameplayType;
		FColor? fcolor = (currentGameplayType == ESignalGameplayType.Send) ? this.BgOverSpriteGreenColor : this.BgOverSpriteYellowColor;
		if (currentGameplayType == ESignalGameplayType.DrawSword)
		{
			fcolor = this.BgOverSpriteOrangeColor;
			this.BgSprite.SetColor(fcolor.Value);
		}
		this.BgOverSprite.SetColor(fcolor.Value);
		this.BgSprite.SetAlpha(1f);
		this.BgOverSprite.SetUIActive(false);
		UUINiagara graySignal = this.GraySignal;
		if (graySignal != null)
		{
			graySignal.SetUIActive(currentGameplayType == ESignalGameplayType.Catch);
		}
		this.GraySignal.SetUIItemScale(Vector.OneVector);
		this.GraySignal.SetAlpha(1f);
		this.HighlightSignal.SetNiagaraVarFloat("Dissolve", 1f);
		this.HighlightSignal.SetUIActive(true);
		this.HighlightSignal.SetUIItemScale(Vector.OneVector);
		this.HighlightSignal.SetAlpha(1f);
		this.ResetHighlightSignalColor();
		this.Line.SetAlpha(0f);
		this.State = ESignalState.NotReach;
	}

	// Token: 0x0601659E RID: 91550 RVA: 0x005A8434 File Offset: 0x005A6634
	public override void InitByGameplayType(ESignalGameplayType type)
	{
		base.InitByGameplayType(type);
		string resourceId = (type == ESignalGameplayType.Send) ? "SP_SignalNoteSolidLineGreen" : "SP_SignalNoteSolidLineYellow";
		if (type == ESignalGameplayType.DrawSword)
		{
			resourceId = "SP_SignalNoteSolidLineOrange";
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		this.SetSpriteByPath(resourcePath, this.Line, false, null, null);
		base.Reset();
	}

	// Token: 0x0601659F RID: 91551 RVA: 0x005A8490 File Offset: 0x005A6690
	private void ResetHighlightSignalColor()
	{
		string hexStr = (this.GameplayType == ESignalGameplayType.Send) ? "E0FCDEFF" : "FFFBE8FF";
		if (this.GameplayType == ESignalGameplayType.DrawSword)
		{
			hexStr = "FFBCA4FF";
		}
		this.HighlightSignal.SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x060165A0 RID: 91552 RVA: 0x005A84D5 File Offset: 0x005A66D5
	protected override bool OnUpdate()
	{
		if (!base.OnUpdate())
		{
			return false;
		}
		this.UpdateState();
		if (this.State == ESignalState.Catching)
		{
			this.UpdateOnCatching();
		}
		return true;
	}

	// Token: 0x060165A1 RID: 91553 RVA: 0x005A84F8 File Offset: 0x005A66F8
	protected void UpdateState()
	{
		float num = (float)(-(float)this.StartDecisionSize) / 2f;
		if (this.CurrentRelativeX < num)
		{
			this.SetState(ESignalState.NotReach);
			return;
		}
		float num2 = (float)this.EndDecisionSize / 2f;
		if (this.CurrentRelativeX - this.Width > num2 && this.State != ESignalState.CatchSuccess)
		{
			this.SetState(ESignalState.CatchFailed);
			return;
		}
		float num3 = (float)this.StartDecisionSize / 2f;
		if (this.CurrentRelativeX > num3 && this.State == ESignalState.NotReach)
		{
			this.SetState(ESignalState.CatchFailed);
		}
	}

	// Token: 0x060165A2 RID: 91554 RVA: 0x005A857C File Offset: 0x005A677C
	private void SetState(ESignalState value)
	{
		if (this.State == value)
		{
			return;
		}
		this.State = value;
		switch (value)
		{
		case ESignalState.Catching:
			EventSystem.Instance.Emit(EEventName.OnSignalCatchStart);
			return;
		case ESignalState.CatchSuccess:
			this.OnSignalCatchSuccess();
			EventSystem.Instance.Emit(EEventName.OnSignalCatchSuccess);
			return;
		case ESignalState.CatchFailed:
			this.OnSignalCatchFailed();
			EventSystem.Instance.Emit(EEventName.OnSignalCatchFailed);
			return;
		default:
			return;
		}
	}

	// Token: 0x060165A3 RID: 91555 RVA: 0x005A85F0 File Offset: 0x005A67F0
	private void UpdateOnCatching()
	{
		float progress = this.GetProgress();
		this.HighlightSignal.SetNiagaraVarFloat("Dissolve", 1f - progress);
		this.BgOverSprite.SetUIActive(true);
		this.BgSprite.SetFillAmount(1f - progress);
		this.BgOverSprite.SetFillAmount(progress);
	}

	// Token: 0x060165A4 RID: 91556 RVA: 0x005A8648 File Offset: 0x005A6848
	private void OnSignalCatchFailed()
	{
		ESignalType type = this.Type;
		if (type == ESignalType.Short)
		{
			this.SkipFailedAnim();
			return;
		}
		if (type != ESignalType.Long)
		{
			return;
		}
		if (this.BgOverSprite.bIsUIActive)
		{
			this.BgOverSprite.SetColor(this.BgOverSpriteRedColor.Value);
			this.HighlightSignal.SetColor(FColor.FromHex("FFD6D6FF"));
			this.LevelSequencePlayer.PlayLevelSequenceByName("Trans", false, null, false);
			return;
		}
		if (SignalDecodeModel.Instance.CurrentGameplayType == ESignalGameplayType.Send)
		{
			this.SkipFailedAnim();
			return;
		}
		this.LevelSequencePlayer.PlayLevelSequenceByName("Trans", false, null, false);
	}

	// Token: 0x060165A5 RID: 91557 RVA: 0x005A86F0 File Offset: 0x005A68F0
	private void OnSignalCatchSuccess()
	{
		this.HighlightSignal.SetNiagaraVarFloat("Dissolve", 0f);
		this.HighlightSignal.SetUIActive(true);
		this.GraySignal.SetUIActive(false);
		this.BgSprite.SetUIActive(false);
		this.BgOverSprite.SetUIActive(false);
		this.Line.SetAlpha(0f);
	}

	// Token: 0x060165A6 RID: 91558 RVA: 0x005A8752 File Offset: 0x005A6952
	public override void OnCatchBtnDown()
	{
		base.OnCatchBtnDown();
		if (this.State != ESignalState.NotReach)
		{
			return;
		}
		if (this.CheckMeetCatch())
		{
			this.SetState(ESignalState.Catching);
		}
	}

	// Token: 0x060165A7 RID: 91559 RVA: 0x005A8774 File Offset: 0x005A6974
	public override void OnCatchBtnUp()
	{
		base.OnCatchBtnUp();
		if (this.State == ESignalState.Catching)
		{
			this.SetState(this.CheckMeetSuccess() ? ESignalState.CatchSuccess : ESignalState.CatchFailed);
		}
	}

	// Token: 0x060165A8 RID: 91560 RVA: 0x005A87A4 File Offset: 0x005A69A4
	private bool CheckMeetCatch()
	{
		float num = (float)(-(float)this.StartDecisionSize) / 2f;
		float num2 = (float)this.StartDecisionSize / 2f;
		return this.RelativeXWhenCatchDown > num && this.RelativeXWhenCatchDown < num2;
	}

	// Token: 0x060165A9 RID: 91561 RVA: 0x005A87E4 File Offset: 0x005A69E4
	private bool CheckMeetSuccess()
	{
		float num = (float)this.EndDecisionSize / 2f;
		float num2 = (float)(-(float)this.EndDecisionSize) / 2f;
		float num3 = this.RelativeXWhenCatchUp - this.Width;
		return num3 > num2 && num3 < num;
	}

	// Token: 0x060165AA RID: 91562 RVA: 0x005A8828 File Offset: 0x005A6A28
	public override float GetProgress()
	{
		float num = (float)(-(float)this.DecisionShowSize) / 2f;
		return MathCommon.Clamp((this.CurrentRelativeX - num) / this.Width, 0f, 1f);
	}

	// Token: 0x060165AB RID: 91563 RVA: 0x005A8864 File Offset: 0x005A6A64
	public float GetCompleteness()
	{
		float result = 0f;
		switch (this.State)
		{
		case ESignalState.NotReach:
		case ESignalState.CatchFailed:
			result = 0f;
			break;
		case ESignalState.Catching:
			result = this.GetProgress();
			break;
		case ESignalState.CatchSuccess:
			result = 1f;
			break;
		}
		return result;
	}

	// Token: 0x060165AC RID: 91564 RVA: 0x005A88B0 File Offset: 0x005A6AB0
	private void SkipFailedAnim()
	{
		this.BgOverSprite.SetUIActive(false);
		this.HighlightSignal.SetUIActive(false);
		this.GraySignal.SetUIActive(false);
		this.BgSprite.SetUIActive(false);
		this.Line.SetAlpha(1f);
	}

	// Token: 0x060165AD RID: 91565 RVA: 0x005A8900 File Offset: 0x005A6B00
	public override bool TestCanBtnDown()
	{
		if (this.State != ESignalState.NotReach)
		{
			return false;
		}
		float num = (float)(-(float)this.StartDecisionSize) / 2f;
		float num2 = (float)this.StartDecisionSize / 2f;
		return this.CurrentRelativeX > num && this.CurrentRelativeX < num2;
	}

	// Token: 0x060165AE RID: 91566 RVA: 0x005A8948 File Offset: 0x005A6B48
	public override bool TestCanBtnUp()
	{
		if (this.State == ESignalState.Catching)
		{
			float num = (float)this.EndDecisionSize / 2f;
			float num2 = (float)(-(float)this.EndDecisionSize) / 2f;
			float num3 = this.CurrentRelativeX - this.Width;
			return num3 > num2 && num3 < num;
		}
		return false;
	}

	// Token: 0x0400A652 RID: 42578
	private const string NIAGARA_PARAM_NAME = "Dissolve";

	// Token: 0x0400A653 RID: 42579
	private const string NIAGARA_YELLOW_COLOR = "FFFBE8FF";

	// Token: 0x0400A654 RID: 42580
	private const string NIAGARA_RED_COLOR = "FFD6D6FF";

	// Token: 0x0400A655 RID: 42581
	private const string NIAGARA_GREEN_COLOR = "E0FCDEFF";

	// Token: 0x0400A656 RID: 42582
	private const string NIAGARA_ORANGE_COLOR = "FFBCA4FF";

	// Token: 0x0400A657 RID: 42583
	[Nullable(2)]
	private UUISprite BgSprite;

	// Token: 0x0400A658 RID: 42584
	[Nullable(2)]
	private UUISprite BgOverSprite;

	// Token: 0x0400A659 RID: 42585
	[Nullable(2)]
	private UUINiagara GraySignal;

	// Token: 0x0400A65A RID: 42586
	[Nullable(2)]
	private UUINiagara HighlightSignal;

	// Token: 0x0400A65B RID: 42587
	[Nullable(2)]
	private UUISprite Line;

	// Token: 0x0400A65C RID: 42588
	private FColor? BgOverSpriteYellowColor;

	// Token: 0x0400A65D RID: 42589
	private FColor? BgOverSpriteGreenColor;

	// Token: 0x0400A65E RID: 42590
	private FColor? BgOverSpriteRedColor;

	// Token: 0x0400A65F RID: 42591
	private FColor? BgOverSpriteOrangeColor;

	// Token: 0x0400A660 RID: 42592
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400A661 RID: 42593
	private ESignalState State;

	// Token: 0x02009051 RID: 36945
	[NullableContext(0)]
	private static class EChildComponent
	{
		// Token: 0x0402EBB2 RID: 191410
		public const int BgSprite = 0;

		// Token: 0x0402EBB3 RID: 191411
		public const int GraySignal = 1;

		// Token: 0x0402EBB4 RID: 191412
		public const int HighlightSignal = 2;

		// Token: 0x0402EBB5 RID: 191413
		public const int Line = 3;

		// Token: 0x0402EBB6 RID: 191414
		public const int BgOverSprite = 4;
	}
}
