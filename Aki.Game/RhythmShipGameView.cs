using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000544 RID: 1348
[NullableContext(2)]
[Nullable(0)]
public class RhythmShipGameView : UiViewBase
{
	// Token: 0x060041E9 RID: 16873 RVA: 0x001703A8 File Offset: 0x0016E5A8
	[NullableContext(1)]
	public RhythmShipGameView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x001703DC File Offset: 0x0016E5DC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUITexture)),
			new ValueTuple<int, Type>(14, typeof(UUIText)),
			new ValueTuple<int, Type>(15, typeof(UUISprite)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUITexture)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIText)),
			new ValueTuple<int, Type>(20, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnPauseClick))
		};
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x001705F4 File Offset: 0x0016E7F4
	protected override UniTask OnBeforeStartAsync()
	{
		RhythmShipGameView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipGameView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x00170638 File Offset: 0x0016E838
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		UUITexture texture = base.GetTexture(5);
		if (texture != null)
		{
			texture.SetUIActive(false);
		}
		this.FeverProgressSprite = base.GetSprite(15);
		UUISprite feverProgressSprite = this.FeverProgressSprite;
		if (feverProgressSprite != null)
		{
			feverProgressSprite.SetWidth((float)this.DefaultProgessWidth * ((float)this.FeverScoreCache / (float)RhythmGameModel.Instance.FeverCeiling));
		}
		this.ScroeMultiText = base.GetText(1);
		UUIText scroeMultiText = this.ScroeMultiText;
		if (scroeMultiText != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MultiCache);
			scroeMultiText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		this.ScoreText = base.GetText(2);
		UUIText scoreText = this.ScoreText;
		if (scoreText != null)
		{
			scoreText.SetText(this.ScoreCache.ToString(), true);
		}
		this.CurLineBtnDownCount = 0;
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x00170724 File Offset: 0x0016E924
	private void RefreshAutoJudgeInfo(int autoJudgeCount)
	{
		UUIText text = base.GetText(14);
		text.SetText(autoJudgeCount.ToString(), true);
		UUIItem uuiitem = text;
		bool bUseChangeColor = autoJudgeCount <= 0;
		FColor? fcolor = new FColor?(text.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		UUITexture texture = base.GetTexture(13);
		UUIItem uuiitem2 = texture;
		bool bUseChangeColor2 = autoJudgeCount <= 0;
		fcolor = new FColor?(texture.changeColor);
		uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00170787 File Offset: 0x0016E987
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
	}

	// Token: 0x060041EF RID: 16879 RVA: 0x00170790 File Offset: 0x0016E990
	protected override void OnAddEventListener()
	{
		base.OnAddEventListener();
		EventSystem.Instance.Add<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(EEventName.OnRhythmGameNoteResultUpdate, new Action<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(this.OnRhythmGameNoteResultUpdate));
		EventSystem.Instance.Add(EEventName.OnRhythmGameFeverModeChanged, new Action<bool>(this.OnRhythmGameFeverModeChanged));
		EventSystem.Instance.Add(EEventName.OnRhythmGameFeverScoreChanged, new Action<int, int>(this.OnRhythmGameFeverScoreChanged));
		EventSystem.Instance.Add(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, new Action<int>(this.OnRhythmGameSpeedLevelConfigIndexChanged));
		EventSystem.Instance.Add<TTimerAction>(EEventName.OnRhythmGameStartCoolDown, new Action<TTimerAction>(this.OnRhythmGameStartCoolDown));
		EventSystem.Instance.Add(EEventName.OnRhythmGameAutoJudgeCountChanged, new Action<int>(this.OnRhythmGameAutoJudgeCountChanged));
		EventSystem.Instance.Add(EEventName.OnRhythmGameEndCoolDown, new Action(this.OnRhythmGameEndCoolDown));
		if (Info.Instance.IsInTouch())
		{
			EventSystem.Instance.Add(EEventName.OnTouchUiEditSave, new Action<ECommonTouchUiEditGroup>(this.OnTouchUiEditSave));
		}
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			button.OnPointDownCallBack.Bind(new Action(this.OnBtnFlickLeftClick));
		}
		UUIButtonComponent button2 = base.GetButton(7);
		if (button2 != null)
		{
			button2.OnPointDownCallBack.Bind(new Action(this.OnBtnTapLeftClick));
		}
		UUIButtonComponent button3 = base.GetButton(8);
		if (button3 != null)
		{
			button3.OnPointDownCallBack.Bind(new Action(this.OnBtnLineClick));
		}
		UUIButtonComponent button4 = base.GetButton(8);
		if (button4 != null)
		{
			button4.OnPointUpCallBack.Bind(new Action(this.OnBtnLineUp));
		}
		UUIButtonComponent button5 = base.GetButton(8);
		if (button5 != null)
		{
			button5.OnPointCancelCallBack.Bind(new Action(this.OnBtnLineUp));
		}
		UUIButtonComponent button6 = base.GetButton(9);
		if (button6 != null)
		{
			button6.OnPointDownCallBack.Bind(new Action(this.OnBtnFlickRightClick));
		}
		UUIButtonComponent button7 = base.GetButton(10);
		if (button7 != null)
		{
			button7.OnPointDownCallBack.Bind(new Action(this.OnBtnTapRightClick));
		}
		UUIButtonComponent button8 = base.GetButton(11);
		if (button8 != null)
		{
			button8.OnPointDownCallBack.Bind(new Action(this.OnBtnLineClick));
		}
		UUIButtonComponent button9 = base.GetButton(11);
		if (button9 != null)
		{
			button9.OnPointUpCallBack.Bind(new Action(this.OnBtnLineUp));
		}
		UUIButtonComponent button10 = base.GetButton(11);
		if (button10 == null)
		{
			return;
		}
		button10.OnPointCancelCallBack.Bind(new Action(this.OnBtnLineUp));
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x001709F4 File Offset: 0x0016EBF4
	protected override void OnRemoveEventListener()
	{
		base.OnRemoveEventListener();
		EventSystem.Instance.Remove<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(EEventName.OnRhythmGameNoteResultUpdate, new Action<EKuroRhythmGameRating?, FKuroRhythmGameStatistics>(this.OnRhythmGameNoteResultUpdate));
		EventSystem.Instance.Remove(EEventName.OnRhythmGameFeverModeChanged, new Action<bool>(this.OnRhythmGameFeverModeChanged));
		EventSystem.Instance.Remove(EEventName.OnRhythmGameFeverScoreChanged, new Action<int, int>(this.OnRhythmGameFeverScoreChanged));
		EventSystem.Instance.Remove(EEventName.OnRhythmGameSpeedLevelConfigIndexChanged, new Action<int>(this.OnRhythmGameSpeedLevelConfigIndexChanged));
		EventSystem.Instance.Remove<TTimerAction>(EEventName.OnRhythmGameStartCoolDown, new Action<TTimerAction>(this.OnRhythmGameStartCoolDown));
		EventSystem.Instance.Remove(EEventName.OnRhythmGameEndCoolDown, new Action(this.OnRhythmGameEndCoolDown));
		EventSystem.Instance.Remove(EEventName.OnRhythmGameAutoJudgeCountChanged, new Action<int>(this.OnRhythmGameAutoJudgeCountChanged));
		if (Info.Instance.IsInTouch())
		{
			EventSystem.Instance.Remove(EEventName.OnTouchUiEditSave, new Action<ECommonTouchUiEditGroup>(this.OnTouchUiEditSave));
		}
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x00170AF3 File Offset: 0x0016ECF3
	private void OnRhythmGameStartCoolDown(TTimerAction callback)
	{
		RhythmShipCoolDownPanel coolDownPanel = this.CoolDownPanel;
		if (coolDownPanel == null)
		{
			return;
		}
		coolDownPanel.PlayCoolDownSequence(callback);
	}

	// Token: 0x060041F2 RID: 16882 RVA: 0x00170B06 File Offset: 0x0016ED06
	private void OnRhythmGameAutoJudgeCountChanged(int autoJudgeCount)
	{
		this.RefreshAutoJudgeInfo(autoJudgeCount);
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x00170B0F File Offset: 0x0016ED0F
	private void OnRhythmGameEndCoolDown()
	{
		RhythmShipCoolDownPanel coolDownPanel = this.CoolDownPanel;
		if (coolDownPanel == null)
		{
			return;
		}
		coolDownPanel.StopCoolDownSequence();
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x00170B24 File Offset: 0x0016ED24
	private void OnRhythmGameSpeedLevelConfigIndexChanged(int newValue)
	{
		int scoreMultiplierByLevel = RhythmGameModel.Instance.GetScoreMultiplierByLevel(newValue);
		this.MultiCache = scoreMultiplierByLevel;
		UUIText scroeMultiText = this.ScroeMultiText;
		if (scroeMultiText == null)
		{
			return;
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("x");
		defaultInterpolatedStringHandler.AppendFormatted<int>(scoreMultiplierByLevel);
		scroeMultiText.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x00170B7C File Offset: 0x0016ED7C
	private void OnRhythmGameNoteResultUpdate(EKuroRhythmGameRating? result, FKuroRhythmGameStatistics statistics)
	{
		EKuroRhythmGameRating? value = result;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
		defaultInterpolatedStringHandler.AppendLiteral("OnRhythmGameNoteResultUpdate: result: ");
		defaultInterpolatedStringHandler.AppendFormatted<EKuroRhythmGameRating?>(value);
		defaultInterpolatedStringHandler.AppendLiteral(", statistics: ");
		defaultInterpolatedStringHandler.AppendFormatted<FKuroRhythmGameStatistics>(statistics);
		instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		if (value != null)
		{
			RhythmGameHitResultPanel hitResultPanel = this.HitResultPanel;
			if (hitResultPanel != null)
			{
				hitResultPanel.SetHitResult(value.Value);
			}
		}
		UUIText scoreText = this.ScoreText;
		if (scoreText != null)
		{
			scoreText.SetUIActive(true);
		}
		if (statistics == null)
		{
			return;
		}
		UUIText scoreText2 = this.ScoreText;
		if (scoreText2 != null)
		{
			scoreText2.SetText(statistics.TotalScore.ToString(), true);
		}
		this.ScoreCache = statistics.TotalScore;
		RhythmGameComboPanel comboPanel = this.ComboPanel;
		if (comboPanel == null)
		{
			return;
		}
		comboPanel.SetCombo(statistics.Combo);
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x00170C60 File Offset: 0x0016EE60
	private void OnRhythmGameFeverModeChanged(bool bFeverActive)
	{
		if (bFeverActive)
		{
			RhythmGameRoleInfoPanel roleInfoPanel = this.RoleInfoPanel;
			if (roleInfoPanel == null)
			{
				return;
			}
			roleInfoPanel.ShowRoleFeverInfo();
		}
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x00170C78 File Offset: 0x0016EE78
	private unsafe void OnRhythmGameFeverScoreChanged(int newScore, int oldScore)
	{
		float num = (float)newScore / (float)RhythmGameModel.Instance.FeverCeiling;
		UUISprite feverProgressSprite = this.FeverProgressSprite;
		if (feverProgressSprite != null)
		{
			feverProgressSprite.SetWidth((float)this.DefaultProgessWidth * num);
		}
		this.FeverScoreCache = newScore;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.RhythmGame;
		ELogAuthor author = ELogAuthor.CH;
		string message = "OnRhythmGameFeverScoreChanged:";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("newScore", newScore);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("oldScore", oldScore);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("width", (float)this.DefaultProgessWidth * num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x00170D3C File Offset: 0x0016EF3C
	private void OnBtnPauseClick()
	{
		if (!RhythmGameController.Instance.PlayerCanInput)
		{
			return;
		}
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----OnBtnPauseClick----", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiManager.Instance.OpenView(EUiViewName.RhythmShipPauseView, null, null);
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x00170D86 File Offset: 0x0016EF86
	private void OnBtnTapLeftClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.TapLeft);
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x00170D93 File Offset: 0x0016EF93
	private void OnBtnTapRightClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.TapRight);
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x00170DA0 File Offset: 0x0016EFA0
	private void OnBtnFlickLeftClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.FlickLeft);
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x00170DAD File Offset: 0x0016EFAD
	private void OnBtnFlickRightClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.FlickRight);
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x00170DBA File Offset: 0x0016EFBA
	private void OnBtnLineClick()
	{
		this.CurLineBtnDownCount++;
		if (this.CurLineBtnDownCount == 1)
		{
			RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.Line);
		}
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x00170DDE File Offset: 0x0016EFDE
	private void OnBtnLineUp()
	{
		this.CurLineBtnDownCount--;
		if (this.CurLineBtnDownCount == 0)
		{
			RhythmGameController.Instance.OnPlayerInputUp(EKuroRhythmGameInputType.Line);
		}
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x00170E04 File Offset: 0x0016F004
	[NullableContext(1)]
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams[0] == "Button")
		{
			int num = int.Parse(configParams[1]);
			if (num >= 0 && num < this.buttonList.Length)
			{
				UUIButtonComponent button = base.GetButton((int)this.buttonList[num]);
				TWeakObjectPtr<UUIItem>? tweakObjectPtr = (button != null) ? new TWeakObjectPtr<UUIItem>?(button.RootUIComp) : null;
				if (tweakObjectPtr == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					tweakObjectPtr.Value,
					tweakObjectPtr.Value
				};
			}
		}
		return null;
	}

	// Token: 0x06004200 RID: 16896 RVA: 0x00170E91 File Offset: 0x0016F091
	private void OnTouchUiEditSave(ECommonTouchUiEditGroup group)
	{
		if (group != ECommonTouchUiEditGroup.RhythmShip)
		{
			return;
		}
		this.ApplyTouchUiData();
	}

	// Token: 0x06004201 RID: 16897 RVA: 0x00170E9E File Offset: 0x0016F09E
	private void ApplyTouchUiData()
	{
		if (!Info.Instance.IsInTouch())
		{
			return;
		}
		TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.RhythmShip, this, "UiView_RhythmShipGame");
	}

	// Token: 0x040033AD RID: 13229
	private readonly int DefaultProgessWidth = 475;

	// Token: 0x040033AE RID: 13230
	[Nullable(1)]
	private readonly RhythmShipGameView.EViewComponent[] buttonList = new RhythmShipGameView.EViewComponent[]
	{
		RhythmShipGameView.EViewComponent.BtnLeft1,
		RhythmShipGameView.EViewComponent.BtnLeft2,
		RhythmShipGameView.EViewComponent.BtnLeft3,
		RhythmShipGameView.EViewComponent.BtnRight1,
		RhythmShipGameView.EViewComponent.BtnRight2,
		RhythmShipGameView.EViewComponent.BtnRight3
	};

	// Token: 0x040033AF RID: 13231
	private int RoleId;

	// Token: 0x040033B0 RID: 13232
	private UUISprite FeverProgressSprite;

	// Token: 0x040033B1 RID: 13233
	private UUIText ScroeMultiText;

	// Token: 0x040033B2 RID: 13234
	private UUIText ScoreText;

	// Token: 0x040033B3 RID: 13235
	private RhythmGameComboPanel ComboPanel;

	// Token: 0x040033B4 RID: 13236
	private RhythmShipCoolDownPanel CoolDownPanel;

	// Token: 0x040033B5 RID: 13237
	private RhythmGameHitResultPanel HitResultPanel;

	// Token: 0x040033B6 RID: 13238
	private RhythmGameRoleInfoPanel RoleInfoPanel;

	// Token: 0x040033B7 RID: 13239
	private int MultiCache = 1;

	// Token: 0x040033B8 RID: 13240
	private int ScoreCache;

	// Token: 0x040033B9 RID: 13241
	private int FeverScoreCache;

	// Token: 0x040033BA RID: 13242
	private int CurLineBtnDownCount;

	// Token: 0x02006819 RID: 26649
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04022505 RID: 140549
		BtnPause,
		// Token: 0x04022506 RID: 140550
		TextScoreMulti,
		// Token: 0x04022507 RID: 140551
		TextScore,
		// Token: 0x04022508 RID: 140552
		TextScroeProgress,
		// Token: 0x04022509 RID: 140553
		PnlCombo,
		// Token: 0x0402250A RID: 140554
		IconHitResult,
		// Token: 0x0402250B RID: 140555
		BtnLeft1,
		// Token: 0x0402250C RID: 140556
		BtnLeft2,
		// Token: 0x0402250D RID: 140557
		BtnLeft3,
		// Token: 0x0402250E RID: 140558
		BtnRight1,
		// Token: 0x0402250F RID: 140559
		BtnRight2,
		// Token: 0x04022510 RID: 140560
		BtnRight3,
		// Token: 0x04022511 RID: 140561
		ShieldItem,
		// Token: 0x04022512 RID: 140562
		ShieldIcon,
		// Token: 0x04022513 RID: 140563
		TextShieldNum,
		// Token: 0x04022514 RID: 140564
		SprProgress,
		// Token: 0x04022515 RID: 140565
		PnlRoleSpeak,
		// Token: 0x04022516 RID: 140566
		IconRole,
		// Token: 0x04022517 RID: 140567
		PnlSpeak,
		// Token: 0x04022518 RID: 140568
		TextSpeak,
		// Token: 0x04022519 RID: 140569
		PnlTime
	}
}
