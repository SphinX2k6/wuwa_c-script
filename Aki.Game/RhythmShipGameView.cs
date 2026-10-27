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

// Token: 0x02001090 RID: 4240
[NullableContext(2)]
[Nullable(0)]
public class RhythmShipGameView : UiViewBase
{
	// Token: 0x06006E54 RID: 28244 RVA: 0x00167A74 File Offset: 0x00165C74
	[NullableContext(1)]
	public RhythmShipGameView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006E55 RID: 28245 RVA: 0x00167AA8 File Offset: 0x00165CA8
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

	// Token: 0x06006E56 RID: 28246 RVA: 0x00167CC0 File Offset: 0x00165EC0
	protected override UniTask OnBeforeStartAsync()
	{
		RhythmShipGameView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipGameView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006E57 RID: 28247 RVA: 0x00167D04 File Offset: 0x00165F04
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

	// Token: 0x06006E58 RID: 28248 RVA: 0x00167DF0 File Offset: 0x00165FF0
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

	// Token: 0x06006E59 RID: 28249 RVA: 0x00167E53 File Offset: 0x00166053
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
	}

	// Token: 0x06006E5A RID: 28250 RVA: 0x00167E5C File Offset: 0x0016605C
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

	// Token: 0x06006E5B RID: 28251 RVA: 0x001680C0 File Offset: 0x001662C0
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

	// Token: 0x06006E5C RID: 28252 RVA: 0x001681BF File Offset: 0x001663BF
	private void OnRhythmGameStartCoolDown(TTimerAction callback)
	{
		RhythmShipCoolDownPanel coolDownPanel = this.CoolDownPanel;
		if (coolDownPanel == null)
		{
			return;
		}
		coolDownPanel.PlayCoolDownSequence(callback);
	}

	// Token: 0x06006E5D RID: 28253 RVA: 0x001681D2 File Offset: 0x001663D2
	private void OnRhythmGameAutoJudgeCountChanged(int autoJudgeCount)
	{
		this.RefreshAutoJudgeInfo(autoJudgeCount);
	}

	// Token: 0x06006E5E RID: 28254 RVA: 0x001681DB File Offset: 0x001663DB
	private void OnRhythmGameEndCoolDown()
	{
		RhythmShipCoolDownPanel coolDownPanel = this.CoolDownPanel;
		if (coolDownPanel == null)
		{
			return;
		}
		coolDownPanel.StopCoolDownSequence();
	}

	// Token: 0x06006E5F RID: 28255 RVA: 0x001681F0 File Offset: 0x001663F0
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

	// Token: 0x06006E60 RID: 28256 RVA: 0x00168248 File Offset: 0x00166448
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

	// Token: 0x06006E61 RID: 28257 RVA: 0x0016832C File Offset: 0x0016652C
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

	// Token: 0x06006E62 RID: 28258 RVA: 0x00168344 File Offset: 0x00166544
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

	// Token: 0x06006E63 RID: 28259 RVA: 0x00168408 File Offset: 0x00166608
	private void OnBtnPauseClick()
	{
		if (!RhythmGameController.Instance.PlayerCanInput)
		{
			return;
		}
		Log.Instance.Info(ELogModule.RhythmGame, ELogAuthor.CH, "----OnBtnPauseClick----", default(ReadOnlySpan<ValueTuple<string, object>>));
		UiManager.Instance.OpenView(EUiViewName.RhythmShipPauseView, null, null);
	}

	// Token: 0x06006E64 RID: 28260 RVA: 0x00168452 File Offset: 0x00166652
	private void OnBtnTapLeftClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.TapLeft);
	}

	// Token: 0x06006E65 RID: 28261 RVA: 0x0016845F File Offset: 0x0016665F
	private void OnBtnTapRightClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.TapRight);
	}

	// Token: 0x06006E66 RID: 28262 RVA: 0x0016846C File Offset: 0x0016666C
	private void OnBtnFlickLeftClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.FlickLeft);
	}

	// Token: 0x06006E67 RID: 28263 RVA: 0x00168479 File Offset: 0x00166679
	private void OnBtnFlickRightClick()
	{
		RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.FlickRight);
	}

	// Token: 0x06006E68 RID: 28264 RVA: 0x00168486 File Offset: 0x00166686
	private void OnBtnLineClick()
	{
		this.CurLineBtnDownCount++;
		if (this.CurLineBtnDownCount == 1)
		{
			RhythmGameController.Instance.OnPlayerInputDown(EKuroRhythmGameInputType.Line);
		}
	}

	// Token: 0x06006E69 RID: 28265 RVA: 0x001684AA File Offset: 0x001666AA
	private void OnBtnLineUp()
	{
		this.CurLineBtnDownCount--;
		if (this.CurLineBtnDownCount == 0)
		{
			RhythmGameController.Instance.OnPlayerInputUp(EKuroRhythmGameInputType.Line);
		}
	}

	// Token: 0x06006E6A RID: 28266 RVA: 0x001684D0 File Offset: 0x001666D0
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

	// Token: 0x06006E6B RID: 28267 RVA: 0x0016855D File Offset: 0x0016675D
	private void OnTouchUiEditSave(ECommonTouchUiEditGroup group)
	{
		if (group != ECommonTouchUiEditGroup.RhythmShip)
		{
			return;
		}
		this.ApplyTouchUiData();
	}

	// Token: 0x06006E6C RID: 28268 RVA: 0x0016856A File Offset: 0x0016676A
	private void ApplyTouchUiData()
	{
		if (!Info.Instance.IsInTouch())
		{
			return;
		}
		TouchUiEditApplyHelper.ApplyCommonTouchUiEditData(ECommonTouchUiEditGroup.RhythmShip, this, "UiView_RhythmShipGame");
	}

	// Token: 0x04003314 RID: 13076
	private readonly int DefaultProgessWidth = 475;

	// Token: 0x04003315 RID: 13077
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

	// Token: 0x04003316 RID: 13078
	private int RoleId;

	// Token: 0x04003317 RID: 13079
	private UUISprite FeverProgressSprite;

	// Token: 0x04003318 RID: 13080
	private UUIText ScroeMultiText;

	// Token: 0x04003319 RID: 13081
	private UUIText ScoreText;

	// Token: 0x0400331A RID: 13082
	private RhythmGameComboPanel ComboPanel;

	// Token: 0x0400331B RID: 13083
	private RhythmShipCoolDownPanel CoolDownPanel;

	// Token: 0x0400331C RID: 13084
	private RhythmGameHitResultPanel HitResultPanel;

	// Token: 0x0400331D RID: 13085
	private RhythmGameRoleInfoPanel RoleInfoPanel;

	// Token: 0x0400331E RID: 13086
	private int MultiCache = 1;

	// Token: 0x0400331F RID: 13087
	private int ScoreCache;

	// Token: 0x04003320 RID: 13088
	private int FeverScoreCache;

	// Token: 0x04003321 RID: 13089
	private int CurLineBtnDownCount;

	// Token: 0x02007685 RID: 30341
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x040271BA RID: 160186
		BtnPause,
		// Token: 0x040271BB RID: 160187
		TextScoreMulti,
		// Token: 0x040271BC RID: 160188
		TextScore,
		// Token: 0x040271BD RID: 160189
		TextScroeProgress,
		// Token: 0x040271BE RID: 160190
		PnlCombo,
		// Token: 0x040271BF RID: 160191
		IconHitResult,
		// Token: 0x040271C0 RID: 160192
		BtnLeft1,
		// Token: 0x040271C1 RID: 160193
		BtnLeft2,
		// Token: 0x040271C2 RID: 160194
		BtnLeft3,
		// Token: 0x040271C3 RID: 160195
		BtnRight1,
		// Token: 0x040271C4 RID: 160196
		BtnRight2,
		// Token: 0x040271C5 RID: 160197
		BtnRight3,
		// Token: 0x040271C6 RID: 160198
		ShieldItem,
		// Token: 0x040271C7 RID: 160199
		ShieldIcon,
		// Token: 0x040271C8 RID: 160200
		TextShieldNum,
		// Token: 0x040271C9 RID: 160201
		SprProgress,
		// Token: 0x040271CA RID: 160202
		PnlRoleSpeak,
		// Token: 0x040271CB RID: 160203
		IconRole,
		// Token: 0x040271CC RID: 160204
		PnlSpeak,
		// Token: 0x040271CD RID: 160205
		TextSpeak,
		// Token: 0x040271CE RID: 160206
		PnlTime
	}
}
