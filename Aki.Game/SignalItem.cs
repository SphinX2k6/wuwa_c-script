using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02001F8C RID: 8076
[NullableContext(1)]
[Nullable(0)]
public class SignalItem : SignalItemBase
{
	// Token: 0x06013FA0 RID: 81824 RVA: 0x005D3140 File Offset: 0x005D1340
	public SignalItem(ESignalType type, float rootHalfWidth, int startDecisionSize, int endDecisionSize) : base(type, rootHalfWidth, startDecisionSize, endDecisionSize)
	{
	}

	// Token: 0x06013FA1 RID: 81825 RVA: 0x005D3150 File Offset: 0x005D1350
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

	// Token: 0x06013FA2 RID: 81826 RVA: 0x005D31DC File Offset: 0x005D13DC
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

	// Token: 0x06013FA3 RID: 81827 RVA: 0x005D3264 File Offset: 0x005D1464
	protected override void OnStart()
	{
		this.BgSprite = base.GetSprite(0);
		this.BgOverSprite = base.GetSprite(4);
		this.GraySignal = base.GetUiNiagara(1);
		this.HighlightSignal = base.GetUiNiagara(2);
		this.Line = base.GetSprite(3);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x06013FA4 RID: 81828 RVA: 0x005D32C4 File Offset: 0x005D14C4
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

	// Token: 0x06013FA5 RID: 81829 RVA: 0x005D340C File Offset: 0x005D160C
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

	// Token: 0x06013FA6 RID: 81830 RVA: 0x005D3468 File Offset: 0x005D1668
	private void ResetHighlightSignalColor()
	{
		string hexStr = (this.GameplayType == ESignalGameplayType.Send) ? "E0FCDEFF" : "FFFBE8FF";
		if (this.GameplayType == ESignalGameplayType.DrawSword)
		{
			hexStr = "FFBCA4FF";
		}
		this.HighlightSignal.SetColor(FColor.FromHex(hexStr));
	}

	// Token: 0x06013FA7 RID: 81831 RVA: 0x005D34AD File Offset: 0x005D16AD
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

	// Token: 0x06013FA8 RID: 81832 RVA: 0x005D34D0 File Offset: 0x005D16D0
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

	// Token: 0x06013FA9 RID: 81833 RVA: 0x005D3554 File Offset: 0x005D1754
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

	// Token: 0x06013FAA RID: 81834 RVA: 0x005D35C8 File Offset: 0x005D17C8
	private void UpdateOnCatching()
	{
		float progress = this.GetProgress();
		this.HighlightSignal.SetNiagaraVarFloat("Dissolve", 1f - progress);
		this.BgOverSprite.SetUIActive(true);
		this.BgSprite.SetFillAmount(1f - progress);
		this.BgOverSprite.SetFillAmount(progress);
	}

	// Token: 0x06013FAB RID: 81835 RVA: 0x005D3620 File Offset: 0x005D1820
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

	// Token: 0x06013FAC RID: 81836 RVA: 0x005D36C8 File Offset: 0x005D18C8
	private void OnSignalCatchSuccess()
	{
		this.HighlightSignal.SetNiagaraVarFloat("Dissolve", 0f);
		this.HighlightSignal.SetUIActive(true);
		this.GraySignal.SetUIActive(false);
		this.BgSprite.SetUIActive(false);
		this.BgOverSprite.SetUIActive(false);
		this.Line.SetAlpha(0f);
	}

	// Token: 0x06013FAD RID: 81837 RVA: 0x005D372A File Offset: 0x005D192A
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

	// Token: 0x06013FAE RID: 81838 RVA: 0x005D374C File Offset: 0x005D194C
	public override void OnCatchBtnUp()
	{
		base.OnCatchBtnUp();
		if (this.State == ESignalState.Catching)
		{
			this.SetState(this.CheckMeetSuccess() ? ESignalState.CatchSuccess : ESignalState.CatchFailed);
		}
	}

	// Token: 0x06013FAF RID: 81839 RVA: 0x005D377C File Offset: 0x005D197C
	private bool CheckMeetCatch()
	{
		float num = (float)(-(float)this.StartDecisionSize) / 2f;
		float num2 = (float)this.StartDecisionSize / 2f;
		return this.RelativeXWhenCatchDown > num && this.RelativeXWhenCatchDown < num2;
	}

	// Token: 0x06013FB0 RID: 81840 RVA: 0x005D37BC File Offset: 0x005D19BC
	private bool CheckMeetSuccess()
	{
		float num = (float)this.EndDecisionSize / 2f;
		float num2 = (float)(-(float)this.EndDecisionSize) / 2f;
		float num3 = this.RelativeXWhenCatchUp - this.Width;
		return num3 > num2 && num3 < num;
	}

	// Token: 0x06013FB1 RID: 81841 RVA: 0x005D3800 File Offset: 0x005D1A00
	public override float GetProgress()
	{
		float num = (float)(-(float)this.DecisionShowSize) / 2f;
		return MathCommon.Clamp((this.CurrentRelativeX - num) / this.Width, 0f, 1f);
	}

	// Token: 0x06013FB2 RID: 81842 RVA: 0x005D383C File Offset: 0x005D1A3C
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

	// Token: 0x06013FB3 RID: 81843 RVA: 0x005D3888 File Offset: 0x005D1A88
	private void SkipFailedAnim()
	{
		this.BgOverSprite.SetUIActive(false);
		this.HighlightSignal.SetUIActive(false);
		this.GraySignal.SetUIActive(false);
		this.BgSprite.SetUIActive(false);
		this.Line.SetAlpha(1f);
	}

	// Token: 0x06013FB4 RID: 81844 RVA: 0x005D38D8 File Offset: 0x005D1AD8
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

	// Token: 0x06013FB5 RID: 81845 RVA: 0x005D3920 File Offset: 0x005D1B20
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

	// Token: 0x0400AA3C RID: 43580
	private const string NIAGARA_PARAM_NAME = "Dissolve";

	// Token: 0x0400AA3D RID: 43581
	private const string NIAGARA_YELLOW_COLOR = "FFFBE8FF";

	// Token: 0x0400AA3E RID: 43582
	private const string NIAGARA_RED_COLOR = "FFD6D6FF";

	// Token: 0x0400AA3F RID: 43583
	private const string NIAGARA_GREEN_COLOR = "E0FCDEFF";

	// Token: 0x0400AA40 RID: 43584
	private const string NIAGARA_ORANGE_COLOR = "FFBCA4FF";

	// Token: 0x0400AA41 RID: 43585
	[Nullable(2)]
	private UUISprite BgSprite;

	// Token: 0x0400AA42 RID: 43586
	[Nullable(2)]
	private UUISprite BgOverSprite;

	// Token: 0x0400AA43 RID: 43587
	[Nullable(2)]
	private UUINiagara GraySignal;

	// Token: 0x0400AA44 RID: 43588
	[Nullable(2)]
	private UUINiagara HighlightSignal;

	// Token: 0x0400AA45 RID: 43589
	[Nullable(2)]
	private UUISprite Line;

	// Token: 0x0400AA46 RID: 43590
	private FColor? BgOverSpriteYellowColor;

	// Token: 0x0400AA47 RID: 43591
	private FColor? BgOverSpriteGreenColor;

	// Token: 0x0400AA48 RID: 43592
	private FColor? BgOverSpriteRedColor;

	// Token: 0x0400AA49 RID: 43593
	private FColor? BgOverSpriteOrangeColor;

	// Token: 0x0400AA4A RID: 43594
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400AA4B RID: 43595
	private ESignalState State;

	// Token: 0x02008298 RID: 33432
	[NullableContext(0)]
	private static class EChildComponent
	{
		// Token: 0x0402A2AA RID: 172714
		public const int BgSprite = 0;

		// Token: 0x0402A2AB RID: 172715
		public const int GraySignal = 1;

		// Token: 0x0402A2AC RID: 172716
		public const int HighlightSignal = 2;

		// Token: 0x0402A2AD RID: 172717
		public const int Line = 3;

		// Token: 0x0402A2AE RID: 172718
		public const int BgOverSprite = 4;
	}
}
