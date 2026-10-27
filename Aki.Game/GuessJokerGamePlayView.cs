using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001065 RID: 4197
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerGamePlayView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x06006BDE RID: 27614 RVA: 0x0015B738 File Offset: 0x00159938
	public GuessJokerGamePlayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006BDF RID: 27615 RVA: 0x0015B770 File Offset: 0x00159970
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIText)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIItem)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIItem)),
			new ValueTuple<int, Type>(30, typeof(UUIItem)),
			new ValueTuple<int, Type>(31, typeof(UUISprite)),
			new ValueTuple<int, Type>(32, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(33, typeof(UUIItem)),
			new ValueTuple<int, Type>(34, typeof(UUIText)),
			new ValueTuple<int, Type>(35, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(36, typeof(UUIText)),
			new ValueTuple<int, Type>(37, typeof(UUIItem)),
			new ValueTuple<int, Type>(38, typeof(UUIItem)),
			new ValueTuple<int, Type>(39, typeof(UUIText)),
			new ValueTuple<int, Type>(40, typeof(UUIItem)),
			new ValueTuple<int, Type>(41, typeof(UUIItem)),
			new ValueTuple<int, Type>(42, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(43, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(44, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(45, typeof(UUIText)),
			new ValueTuple<int, Type>(46, typeof(UUIText)),
			new ValueTuple<int, Type>(47, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(8, new Action(this.OnPlayCardButtonClick)),
			new ValueTuple<int, Delegate>(35, new Action<EToggleState>(this.OnHideToggleClick)),
			new ValueTuple<int, Delegate>(44, new Action(this.OnMaskButtonClick))
		};
	}

	// Token: 0x06006BE0 RID: 27616 RVA: 0x0015BC24 File Offset: 0x00159E24
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerGamePlayView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerGamePlayView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006BE1 RID: 27617 RVA: 0x0015BC67 File Offset: 0x00159E67
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		this.InitPlayer();
		this.InitButtons();
		this.InitRound();
		this.InitInfo();
	}

	// Token: 0x06006BE2 RID: 27618 RVA: 0x0015BC87 File Offset: 0x00159E87
	protected override void OnAfterShow()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SetActiveDialogLogic(this.DialogLogic);
	}

	// Token: 0x06006BE3 RID: 27619 RVA: 0x0015BC9E File Offset: 0x00159E9E
	protected override void OnBeforeHide()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance != null)
		{
			instance.SetActiveDialogLogic(null);
		}
		GuessJokerDialogLogic dialogLogic = this.DialogLogic;
		if (dialogLogic != null)
		{
			dialogLogic.Clear();
		}
		this.ResumeTimeDilation();
	}

	// Token: 0x06006BE4 RID: 27620 RVA: 0x0015BCC8 File Offset: 0x00159EC8
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("GuessJokerGamePlayView");
	}

	// Token: 0x06006BE5 RID: 27621 RVA: 0x0015BCD9 File Offset: 0x00159ED9
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("GuessJokerGamePlayView");
	}

	// Token: 0x06006BE6 RID: 27622 RVA: 0x0015BCEC File Offset: 0x00159EEC
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		GuessJokerAiConfig? jokerAiConfigByEntityId = GuessJokerConfig.Instance.GetJokerAiConfigByEntityId(this.NpcId);
		if (jokerAiConfigByEntityId == null)
		{
			return;
		}
		string cameraNameByCameraId = GuessJokerUtils.GetCameraNameByCameraId(jokerAiConfigByEntityId.Value.GamePlayCameraId);
		if (cameraNameByCameraId != null)
		{
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)cameraNameByCameraId, new int?(viewId), isBlend);
		}
	}

	// Token: 0x06006BE7 RID: 27623 RVA: 0x0015BD44 File Offset: 0x00159F44
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		GuessJokerAiConfig? jokerAiConfigByEntityId = GuessJokerConfig.Instance.GetJokerAiConfigByEntityId(this.NpcId);
		if (jokerAiConfigByEntityId == null)
		{
			return;
		}
		string cameraNameByCameraId = GuessJokerUtils.GetCameraNameByCameraId(jokerAiConfigByEntityId.Value.GamePlayCameraId);
		if (cameraNameByCameraId != null)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)cameraNameByCameraId, stackTopInfo, closeViewId, popOrDelete);
		}
	}

	// Token: 0x06006BE8 RID: 27624 RVA: 0x0015BD98 File Offset: 0x00159F98
	private void OnGamePlayViewSequenceFinish(string sequenceName)
	{
		Action action;
		if (this.SequenceFinishCallbackMap.TryGetValue(sequenceName, out action) && action != null)
		{
			action();
			this.SequenceFinishCallbackMap.Remove(sequenceName);
		}
	}

	// Token: 0x06006BE9 RID: 27625 RVA: 0x0015BDCD File Offset: 0x00159FCD
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "LevelChange" && eventName == "LevelChange")
		{
			this.UpdateRoundNumber();
		}
	}

	// Token: 0x06006BEA RID: 27626 RVA: 0x0015BDEF File Offset: 0x00159FEF
	private void InitPlayer()
	{
		this.AiPlayerItem.SetRoleData(GuessJokerGamePlayModel.Instance.GetRoleData(EGuessJokerPlayerType.Ai));
		this.MePlayerItem.SetRoleData(GuessJokerGamePlayModel.Instance.GetRoleData(EGuessJokerPlayerType.Me));
	}

	// Token: 0x06006BEB RID: 27627 RVA: 0x0015BE20 File Offset: 0x0015A020
	private void InitButtons()
	{
		int roleId = GuessJokerGamePlayModel.Instance.GetRoleId();
		GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(roleId);
		if (jokerAiConfigByRoleId == null)
		{
			return;
		}
		string useSkillText = jokerAiConfigByRoleId.Value.UseSkillText;
		if (useSkillText != null)
		{
			string text = ConfigMultiTextLang.GetLocalTextNew(useSkillText, null) ?? "";
			GuessJokerSkillItem useSkillItem = this.UseSkillItem;
			if (useSkillItem != null)
			{
				useSkillItem.SetText(text);
			}
		}
		string giveUpSkillText = jokerAiConfigByRoleId.Value.GiveUpSkillText;
		if (giveUpSkillText != null)
		{
			string text2 = ConfigMultiTextLang.GetLocalTextNew(giveUpSkillText, null) ?? "";
			GuessJokerSkillItem giveUpSkillItem = this.GiveUpSkillItem;
			if (giveUpSkillItem == null)
			{
				return;
			}
			giveUpSkillItem.SetText(text2);
		}
	}

	// Token: 0x06006BEC RID: 27628 RVA: 0x0015BEC0 File Offset: 0x0015A0C0
	private UniTask InitAllCards()
	{
		GuessJokerGamePlayView.<InitAllCards>d__36 <InitAllCards>d__;
		<InitAllCards>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAllCards>d__.<>4__this = this;
		<InitAllCards>d__.<>1__state = -1;
		<InitAllCards>d__.<>t__builder.Start<GuessJokerGamePlayView.<InitAllCards>d__36>(ref <InitAllCards>d__);
		return <InitAllCards>d__.<>t__builder.Task;
	}

	// Token: 0x06006BED RID: 27629 RVA: 0x0015BF04 File Offset: 0x0015A104
	private UniTask InitBlankCard()
	{
		GuessJokerGamePlayView.<InitBlankCard>d__37 <InitBlankCard>d__;
		<InitBlankCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBlankCard>d__.<>4__this = this;
		<InitBlankCard>d__.<>1__state = -1;
		<InitBlankCard>d__.<>t__builder.Start<GuessJokerGamePlayView.<InitBlankCard>d__37>(ref <InitBlankCard>d__);
		return <InitBlankCard>d__.<>t__builder.Task;
	}

	// Token: 0x06006BEE RID: 27630 RVA: 0x0015BF48 File Offset: 0x0015A148
	private void InitRound()
	{
		int roundNumber = GuessJokerGamePlayModel.Instance.RoundNumber;
		UUIText text = base.GetText(3);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>((roundNumber == 0) ? 1 : roundNumber);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		this.BlankCardItem.RefreshCardItem();
		foreach (GuessJokerCardItem guessJokerCardItem in this.CardItemMap.Values)
		{
			if (guessJokerCardItem.Data.IsBlank())
			{
				guessJokerCardItem.RefreshCardItem();
			}
		}
	}

	// Token: 0x06006BEF RID: 27631 RVA: 0x0015BFF0 File Offset: 0x0015A1F0
	private void InitInfo()
	{
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Ai);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(39), "GuessJoker_AiSelectText", new <>z__ReadOnlySingleElementList<object>(playerNameByType));
	}

	// Token: 0x06006BF0 RID: 27632 RVA: 0x0015C026 File Offset: 0x0015A226
	public void HidePlayerButtons()
	{
		this.PlayGamePlayViewSequence("BtnHide", delegate
		{
			base.GetItem(29).SetUIActive(false);
		});
	}

	// Token: 0x06006BF1 RID: 27633 RVA: 0x0015C040 File Offset: 0x0015A240
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<GuessJokerCardItem> CreateCardItem(GuessJokerCardData cardData)
	{
		GuessJokerGamePlayView.<CreateCardItem>d__41 <CreateCardItem>d__;
		<CreateCardItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<GuessJokerCardItem>.Create();
		<CreateCardItem>d__.<>4__this = this;
		<CreateCardItem>d__.cardData = cardData;
		<CreateCardItem>d__.<>1__state = -1;
		<CreateCardItem>d__.<>t__builder.Start<GuessJokerGamePlayView.<CreateCardItem>d__41>(ref <CreateCardItem>d__);
		return <CreateCardItem>d__.<>t__builder.Task;
	}

	// Token: 0x06006BF2 RID: 27634 RVA: 0x0015C08C File Offset: 0x0015A28C
	protected override void OnBeforeDestroy()
	{
		foreach (GuessJokerCardItem guessJokerCardItem in this.CardItemMap.Values)
		{
			guessJokerCardItem.Destroy(null);
		}
		this.CardItemMap.Clear();
	}

	// Token: 0x06006BF3 RID: 27635 RVA: 0x0015C0F0 File Offset: 0x0015A2F0
	[NullableContext(2)]
	public GuessJokerCardItem GetCardItemById(int cardId)
	{
		GuessJokerCardItem result;
		if (!this.CardItemMap.TryGetValue(cardId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06006BF4 RID: 27636 RVA: 0x0015C110 File Offset: 0x0015A310
	public void SwapCardItemMap(int cardId1, int cardId2)
	{
		GuessJokerCardItem guessJokerCardItem2;
		GuessJokerCardItem guessJokerCardItem = this.CardItemMap.TryGetValue(cardId1, out guessJokerCardItem2) ? guessJokerCardItem2 : null;
		GuessJokerCardItem guessJokerCardItem4;
		GuessJokerCardItem guessJokerCardItem3 = this.CardItemMap.TryGetValue(cardId2, out guessJokerCardItem4) ? guessJokerCardItem4 : null;
		if (guessJokerCardItem != null && guessJokerCardItem3 != null)
		{
			this.CardItemMap[cardId1] = guessJokerCardItem3;
			this.CardItemMap[cardId2] = guessJokerCardItem;
		}
	}

	// Token: 0x06006BF5 RID: 27637 RVA: 0x0015C168 File Offset: 0x0015A368
	[NullableContext(2)]
	private LevelSequencePlayer GetOrCreateSequencePlayer(int componentDefine)
	{
		LevelSequencePlayer levelSequencePlayer;
		if (!this.SequencePlayerMap.TryGetValue(componentDefine, out levelSequencePlayer))
		{
			UUIItem item = base.GetItem(componentDefine);
			if (item == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GuessJokerCard;
				ELogAuthor author = ELogAuthor.LRC;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Item not found, $");
				defaultInterpolatedStringHandler.AppendFormatted<int>(componentDefine);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			levelSequencePlayer = new LevelSequencePlayer(item);
			this.SequencePlayerMap[componentDefine] = levelSequencePlayer;
		}
		return levelSequencePlayer;
	}

	// Token: 0x06006BF6 RID: 27638 RVA: 0x0015C1E8 File Offset: 0x0015A3E8
	public void SetPlayerPlayCardInteractiveCallback([Nullable(new byte[]
	{
		2,
		1
	})] Action<int[]> callback)
	{
		this.PlayerPlayCardInteractiveCallback = delegate(int[] playCardList)
		{
			this.HidePlayerButtons();
			Action<int[]> callback2 = callback;
			if (callback2 == null)
			{
				return;
			}
			callback2(playCardList);
		};
	}

	// Token: 0x06006BF7 RID: 27639 RVA: 0x0015C21B File Offset: 0x0015A41B
	[NullableContext(2)]
	public void SetPlayerCardClickCallback(Action<int, int, bool> callback)
	{
		this.PlayerCardClickCallback = callback;
	}

	// Token: 0x06006BF8 RID: 27640 RVA: 0x0015C224 File Offset: 0x0015A424
	public void SetFlipCoinClickEnable()
	{
		GuessJokerCoinFlipItem flipCoinItem = this.FlipCoinItem;
		if (flipCoinItem == null)
		{
			return;
		}
		flipCoinItem.SetClickEnable(true);
	}

	// Token: 0x06006BF9 RID: 27641 RVA: 0x0015C237 File Offset: 0x0015A437
	private void FlipCoinClickCallback()
	{
		GuessJokerCoinFlipItem flipCoinItem = this.FlipCoinItem;
		if (flipCoinItem != null)
		{
			flipCoinItem.SetClickEnable(false);
		}
		this.ShowFlipCoinEffect(false, delegate
		{
			this.ShowInitialRoundTip(true, delegate
			{
				GuessJokerGamePlayModel.Instance.ChangeState(EGuessJokerCardStateType.RoundPlay);
			});
		});
	}

	// Token: 0x06006BFA RID: 27642 RVA: 0x0015C25E File Offset: 0x0015A45E
	public void SetPlayerSkillRequestCallback(Action<bool> callback)
	{
		this.PlayerSkillRequestCallback = callback;
	}

	// Token: 0x06006BFB RID: 27643 RVA: 0x0015C268 File Offset: 0x0015A468
	public void UpdateRoundNumber()
	{
		int roundNumber = GuessJokerGamePlayModel.Instance.RoundNumber;
		UUIText text = base.GetText(3);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>((roundNumber == 0) ? 1 : roundNumber);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06006BFC RID: 27644 RVA: 0x0015C2AC File Offset: 0x0015A4AC
	public void PlayGamePlayViewSequence(string sequenceName, [Nullable(2)] Action finishCallback = null)
	{
		LevelSequencePlayer gamePlayViewSequencePlayer = this.GamePlayViewSequencePlayer;
		if (gamePlayViewSequencePlayer != null)
		{
			gamePlayViewSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}
		if (finishCallback != null)
		{
			this.SequenceFinishCallbackMap[sequenceName] = finishCallback;
		}
	}

	// Token: 0x06006BFD RID: 27645 RVA: 0x0015C2E8 File Offset: 0x0015A4E8
	public void SetSkillProgress(EGuessJokerPlayerType playerType, float progress)
	{
		UUISprite uuisprite;
		if (playerType == EGuessJokerPlayerType.Ai)
		{
			UUISprite sprite = base.GetSprite(31);
			sprite.SetFillAmount(1f - progress);
			uuisprite = sprite;
		}
		else
		{
			base.GetSlider(14).SetValue(1f - progress, true);
			uuisprite = base.GetSprite(47);
		}
		if (uuisprite != null)
		{
			bool flag = 1f - progress > 0.3f;
			bool? lastSkillProgressAboveThreshold = this.LastSkillProgressAboveThreshold;
			bool flag2 = flag;
			if (!(lastSkillProgressAboveThreshold.GetValueOrDefault() == flag2 & lastSkillProgressAboveThreshold != null))
			{
				FColor color = flag ? FColor.FromHex("#98edf2") : FColor.FromHex("#ec435f");
				uuisprite.SetColor(color);
				this.LastSkillProgressAboveThreshold = new bool?(flag);
			}
		}
	}

	// Token: 0x06006BFE RID: 27646 RVA: 0x0015C38F File Offset: 0x0015A58F
	public void ShowAiSkillProgress(bool isShow)
	{
		this.PlayStartOrCloseSequence(isShow, 30, null);
	}

	// Token: 0x06006BFF RID: 27647 RVA: 0x0015C39C File Offset: 0x0015A59C
	[NullableContext(2)]
	public void ShowDialog(EGuessJokerPlayerType playerType, bool isShow, Action onComplete = null)
	{
		if (playerType != EGuessJokerPlayerType.Ai)
		{
			GuessJokerHeadItem mePlayerItem = this.MePlayerItem;
			if (mePlayerItem != null)
			{
				mePlayerItem.SetDialogueItemActive(isShow, onComplete);
			}
			return;
		}
		if (isShow)
		{
			base.GetItem(33).SetUIActive(true);
			this.PlayGamePlayViewSequence("DialogTipShow", onComplete);
			return;
		}
		this.PlayGamePlayViewSequence("DialogTipHide", delegate
		{
			this.GetItem(33).SetUIActive(false);
			Action onComplete2 = onComplete;
			if (onComplete2 == null)
			{
				return;
			}
			onComplete2();
		});
	}

	// Token: 0x06006C00 RID: 27648 RVA: 0x0015C414 File Offset: 0x0015A614
	public void SetDialogText(EGuessJokerPlayerType playerType, string textKey)
	{
		if (playerType == EGuessJokerPlayerType.Ai)
		{
			base.GetText(34).ShowTextNew(textKey);
			return;
		}
		GuessJokerHeadItem mePlayerItem = this.MePlayerItem;
		if (mePlayerItem != null)
		{
			mePlayerItem.SetDialogueText(textKey);
		}
	}

	// Token: 0x06006C01 RID: 27649 RVA: 0x0015C448 File Offset: 0x0015A648
	public void ShowPlayerButtons(int normalCardPairCount)
	{
		base.GetButton(7).RootUIComp.Get().SetUIActive(false);
		base.GetButton(10).RootUIComp.Get().SetUIActive(false);
		base.GetText(36).ShowTextNew("GuessJoker_PlayCardConfirmText");
		base.GetItem(29).SetUIActive(true);
		this.PlayGamePlayViewSequence("BtnShow", null);
		if (normalCardPairCount > 0)
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "GuessJokerHasPair");
		}
	}

	// Token: 0x06006C02 RID: 27650 RVA: 0x0015C4D0 File Offset: 0x0015A6D0
	public void ShowSkillInteractivePanel(bool isActive)
	{
		string sequenceName = isActive ? "SkillShow" : "SkillHide";
		if (isActive)
		{
			base.GetItem(11).SetUIActive(true);
			this.PlayGamePlayViewSequence(sequenceName, null);
			return;
		}
		this.PlayGamePlayViewSequence(sequenceName, delegate
		{
			base.GetItem(11).SetUIActive(false);
			this.PlayerSkillRequestCallback = null;
		});
	}

	// Token: 0x06006C03 RID: 27651 RVA: 0x0015C51A File Offset: 0x0015A71A
	public void UpdateCurrentPlayer(EGuessJokerPlayerType playerType)
	{
		this.AiPlayerItem.SetSelfRound(playerType == EGuessJokerPlayerType.Ai);
		this.MePlayerItem.SetSelfRound(playerType == EGuessJokerPlayerType.Me);
	}

	// Token: 0x06006C04 RID: 27652 RVA: 0x0015C53A File Offset: 0x0015A73A
	public void SetCurrentSkillInfo(int skillId, int skillRemindCount)
	{
		this.CurrentSkillRemindCount = skillRemindCount;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "GuessJoker_SkillChargesText", new <>z__ReadOnlySingleElementList<object>(this.CurrentSkillRemindCount));
	}

	// Token: 0x06006C05 RID: 27653 RVA: 0x0015C56C File Offset: 0x0015A76C
	public void ShowCards(int[] cardIdList, bool isShow)
	{
		foreach (int cardId in cardIdList)
		{
			GuessJokerCardItem cardItemById = this.GetCardItemById(cardId);
			if (cardItemById != null)
			{
				cardItemById.CardFlip(isShow, true);
			}
		}
	}

	// Token: 0x06006C06 RID: 27654 RVA: 0x0015C5A0 File Offset: 0x0015A7A0
	public void BlankCardAnimPlay()
	{
		GuessJokerCardData blankCardData = GuessJokerGamePlayModel.Instance.GetBlankCardData();
		if (blankCardData == null)
		{
			return;
		}
		if (!blankCardData.GetChange())
		{
			return;
		}
		this.BlankCardItem.RefreshCardChangeTexture();
		this.BlankCardItem.PlayCardSequence("Change", null);
		foreach (GuessJokerCardItem guessJokerCardItem in this.CardItemMap.Values)
		{
			if (guessJokerCardItem.Data.IsBlank())
			{
				guessJokerCardItem.RefreshCardChangeTexture();
				guessJokerCardItem.PlayCardSequence("Change", null);
			}
		}
	}

	// Token: 0x06006C07 RID: 27655 RVA: 0x0015C644 File Offset: 0x0015A844
	public void RemoveCardFromMiddleArea(Action finishCallback)
	{
		GuessJokerPositionPanelBase middlePanel = this.GetPositionPanel(ECardPositionType.Middle);
		foreach (int key in middlePanel.GetCardIdList())
		{
			this.CardItemMap.Remove(key);
		}
		middlePanel.ShowCardPairNotice(delegate
		{
			middlePanel.RemoveCards(finishCallback);
		});
	}

	// Token: 0x06006C08 RID: 27656 RVA: 0x0015C6D4 File Offset: 0x0015A8D4
	public void SetBlankCardDisable()
	{
		this.BlankCardItem.SetBlankCardDisable();
	}

	// Token: 0x06006C09 RID: 27657 RVA: 0x0015C6E4 File Offset: 0x0015A8E4
	public void DealCards(Action finishCallback)
	{
		List<GuessJokerCardData> allCardDataList = GuessJokerGamePlayModel.Instance.GetAllCardDataList();
		List<GuessJokerCardItem> list = new List<GuessJokerCardItem>();
		List<GuessJokerCardItem> list2 = new List<GuessJokerCardItem>();
		foreach (GuessJokerCardData guessJokerCardData in allCardDataList)
		{
			GuessJokerCardItem item = this.CardItemMap[guessJokerCardData.Id];
			EGuessJokerPlayerType? belongPlayerType = guessJokerCardData.GetBelongPlayerType();
			if (belongPlayerType.GetValueOrDefault() == EGuessJokerPlayerType.Ai)
			{
				list.Add(item);
			}
			else
			{
				EGuessJokerPlayerType? eguessJokerPlayerType = belongPlayerType;
				EGuessJokerPlayerType eguessJokerPlayerType2 = EGuessJokerPlayerType.Me;
				if (eguessJokerPlayerType.GetValueOrDefault() == eguessJokerPlayerType2 & eguessJokerPlayerType != null)
				{
					list2.Add(item);
				}
			}
		}
		GuessJokerPositionPanelBase positionPanel = this.GetPositionPanel(ECardPositionType.AiInitial);
		GuessJokerPositionPanelBase positionPanel2 = this.GetPositionPanel(ECardPositionType.PlayerInitial);
		int completedCount = 0;
		Action finishCallback2 = delegate()
		{
			int completedCount = completedCount;
			completedCount++;
			if (completedCount == 2)
			{
				finishCallback();
			}
		};
		AudioSystem.Instance.PostEvent("play_ui_springfestival_ghostcard_card_deal");
		positionPanel.DealCards(list, finishCallback2, 150);
		positionPanel2.DealCards(list2, finishCallback2, 150);
	}

	// Token: 0x06006C0A RID: 27658 RVA: 0x0015C7F4 File Offset: 0x0015A9F4
	public void SetPositionPanelCardsDark(ECardPositionType position, bool isDark, int[] excludeCardIdList = null)
	{
		if (excludeCardIdList == null)
		{
			excludeCardIdList = Array.Empty<int>();
		}
		this.GetPositionPanel(position).SetCardsDarkExcept(isDark, excludeCardIdList.ToList<int>());
	}

	// Token: 0x06006C0B RID: 27659 RVA: 0x0015C814 File Offset: 0x0015AA14
	[NullableContext(2)]
	private void PlayContinuousSequence(int componentDefine, Action completeCallback = null)
	{
		LevelSequencePlayer levelSequencePlayer = this.GetOrCreateSequencePlayer(componentDefine);
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Start")
				{
					levelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
					return;
				}
				if (sequenceName == "Close")
				{
					this.GetItem(componentDefine).SetUIActive(false);
					Action completeCallback3 = completeCallback;
					if (completeCallback3 == null)
					{
						return;
					}
					completeCallback3();
				}
			}, true);
			base.GetItem(componentDefine).SetUIActive(true);
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			return;
		}
		Action completeCallback2 = completeCallback;
		if (completeCallback2 == null)
		{
			return;
		}
		completeCallback2();
	}

	// Token: 0x06006C0C RID: 27660 RVA: 0x0015C8AC File Offset: 0x0015AAAC
	[NullableContext(2)]
	private void PlayStartOrCloseSequence(bool isShow, int componentDefine, Action completeCallback = null)
	{
		LevelSequencePlayer orCreateSequencePlayer = this.GetOrCreateSequencePlayer(componentDefine);
		if (orCreateSequencePlayer == null)
		{
			Action completeCallback2 = completeCallback;
			if (completeCallback2 == null)
			{
				return;
			}
			completeCallback2();
			return;
		}
		else
		{
			orCreateSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					this.GetItem(componentDefine).SetUIActive(false);
				}
				Action completeCallback3 = completeCallback;
				if (completeCallback3 == null)
				{
					return;
				}
				completeCallback3();
			}, true);
			if (isShow)
			{
				base.GetItem(componentDefine).SetUIActive(true);
				orCreateSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
				return;
			}
			orCreateSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
			return;
		}
	}

	// Token: 0x06006C0D RID: 27661 RVA: 0x0015C94A File Offset: 0x0015AB4A
	public void PlaySkillEffect(int skillId, Action completeCallback)
	{
		GuessJokerSkillActivateItem skillActivateItem = this.SkillActivateItem;
		if (skillActivateItem != null)
		{
			skillActivateItem.Refresh(skillId);
		}
		this.PlayContinuousSequence(17, completeCallback);
	}

	// Token: 0x06006C0E RID: 27662 RVA: 0x0015C967 File Offset: 0x0015AB67
	public void ShowFlipCoinEffect(bool isShow, Action completeCallback)
	{
		if (isShow)
		{
			GuessJokerCoinFlipItem flipCoinItem = this.FlipCoinItem;
			if (flipCoinItem != null)
			{
				flipCoinItem.Refresh();
			}
			this.PlayStartOrCloseSequence(true, 18, completeCallback);
			return;
		}
		this.PlayStartOrCloseSequence(false, 18, completeCallback);
	}

	// Token: 0x06006C0F RID: 27663 RVA: 0x0015C994 File Offset: 0x0015AB94
	public void UpdateHp(EGuessJokerPlayerType playerType, Action completeCallback)
	{
		GuessJokerHeadItem guessJokerHeadItem = (playerType == EGuessJokerPlayerType.Ai) ? this.AiPlayerItem : this.MePlayerItem;
		if (guessJokerHeadItem != null)
		{
			guessJokerHeadItem.UpdateHp(completeCallback);
			return;
		}
		completeCallback();
	}

	// Token: 0x06006C10 RID: 27664 RVA: 0x0015C9C8 File Offset: 0x0015ABC8
	public void UpdateSkill(EGuessJokerPlayerType playerType)
	{
		GuessJokerHeadItem guessJokerHeadItem = (playerType == EGuessJokerPlayerType.Ai) ? this.AiPlayerItem : this.MePlayerItem;
		if (guessJokerHeadItem != null)
		{
			guessJokerHeadItem.SetSkillUnlock(true);
		}
	}

	// Token: 0x06006C11 RID: 27665 RVA: 0x0015C9F2 File Offset: 0x0015ABF2
	private void UseSkill(bool isUse)
	{
		Action<bool> playerSkillRequestCallback = this.PlayerSkillRequestCallback;
		if (playerSkillRequestCallback == null)
		{
			return;
		}
		playerSkillRequestCallback(isUse);
	}

	// Token: 0x06006C12 RID: 27666 RVA: 0x0015CA08 File Offset: 0x0015AC08
	public void SetCardChoose(int cardId, bool isSelected)
	{
		GuessJokerCardItem cardItemById = this.GetCardItemById(cardId);
		if (cardItemById == null)
		{
			return;
		}
		if (isSelected)
		{
			if (this.CurChooseCardItem != null && this.CurChooseCardItem != cardItemById)
			{
				this.CurChooseCardItem.SetChoose(false, true);
			}
			this.CurChooseCardItem = cardItemById;
		}
		else if (this.CurChooseCardItem == cardItemById)
		{
			this.CurChooseCardItem = null;
		}
		cardItemById.SetChoose(isSelected, true);
	}

	// Token: 0x06006C13 RID: 27667 RVA: 0x0015CA63 File Offset: 0x0015AC63
	public void ClearChooseCard()
	{
		if (this.CurChooseCardItem != null)
		{
			this.CurChooseCardItem.SetChoose(false, false);
			this.CurChooseCardItem = null;
		}
	}

	// Token: 0x06006C14 RID: 27668 RVA: 0x0015CA84 File Offset: 0x0015AC84
	public void SetCardsSelect(int cardId, Action finishCallback)
	{
		GuessJokerCardItem cardItemById = this.GetCardItemById(cardId);
		if (cardItemById != null)
		{
			cardItemById.SetSelectCardItem(finishCallback);
		}
	}

	// Token: 0x06006C15 RID: 27669 RVA: 0x0015CAA4 File Offset: 0x0015ACA4
	public void UpdateCardItemsHierarchyIndex()
	{
		List<GuessJokerCardItem> list = new List<GuessJokerCardItem>(this.CardItemMap.Values);
		list.Sort((GuessJokerCardItem a, GuessJokerCardItem b) => a.GetGlobalIndex() - b.GetGlobalIndex());
		for (int i = 0; i < list.Count; i++)
		{
			list[i].SetHierarchyIndex(i);
		}
	}

	// Token: 0x06006C16 RID: 27670 RVA: 0x0015CB08 File Offset: 0x0015AD08
	public void ClearAllCardsChecking()
	{
		foreach (GuessJokerCardItem guessJokerCardItem in this.CardItemMap.Values)
		{
			guessJokerCardItem.ClearCheckingSign();
		}
	}

	// Token: 0x06006C17 RID: 27671 RVA: 0x0015CB60 File Offset: 0x0015AD60
	public void ShowPlayerRoundStartTip(EGuessJokerPlayerType playerType, Action completeCallback)
	{
		int componentDefine = (playerType == EGuessJokerPlayerType.Ai) ? 21 : 22;
		this.PlayContinuousSequence(componentDefine, completeCallback);
	}

	// Token: 0x06006C18 RID: 27672 RVA: 0x0015CB80 File Offset: 0x0015AD80
	public void ShowPlayerDrawCardTip(bool isShow, Action completeCallback)
	{
		int componentDefine = 25;
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06006C19 RID: 27673 RVA: 0x0015CB9C File Offset: 0x0015AD9C
	public void ShowInitialRoundTip(bool isShow, Action completeCallback)
	{
		int componentDefine = 26;
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06006C1A RID: 27674 RVA: 0x0015CBB8 File Offset: 0x0015ADB8
	public void ShowDrawSpecialTip(bool isShow, bool isGood, EGuessJokerPlayerType playerType, Action completeCallback)
	{
		int componentDefine = isGood ? 24 : 23;
		int name = isGood ? 46 : 45;
		string text = isGood ? "GuessJoker_DrawBlankCardTipText" : "GuessJoker_DrawJokerTipText";
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(playerType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(name), text.ToString(), new <>z__ReadOnlySingleElementList<object>(playerNameByType));
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06006C1B RID: 27675 RVA: 0x0015CC1C File Offset: 0x0015AE1C
	public void ShowWinLoseReasonTip(EGuessJokerPlayerType playerType, string textKey, bool isGood, Action completeCallback)
	{
		int name = isGood ? 46 : 45;
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(playerType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(name), textKey, new <>z__ReadOnlySingleElementList<object>(playerNameByType));
		base.GetText(name).ShowTextNew(textKey);
		int componentDefine = isGood ? 24 : 23;
		this.PlayContinuousSequence(componentDefine, completeCallback);
	}

	// Token: 0x06006C1C RID: 27676 RVA: 0x0015CC77 File Offset: 0x0015AE77
	public void ShowOfficialRoundStartTip(Action completeCallback)
	{
		this.PlayContinuousSequence(27, completeCallback);
	}

	// Token: 0x06006C1D RID: 27677 RVA: 0x0015CC84 File Offset: 0x0015AE84
	public void ShowAiSelectCardTip(bool isShow, Action completeCallback)
	{
		int componentDefine = 38;
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06006C1E RID: 27678 RVA: 0x0015CCA0 File Offset: 0x0015AEA0
	public GuessJokerPositionPanelBase GetPositionPanel(ECardPositionType position)
	{
		GuessJokerPositionPanelBase guessJokerPositionPanelBase;
		if (!this.PositionPanelMap.TryGetValue(position, out guessJokerPositionPanelBase))
		{
			guessJokerPositionPanelBase = new GuessJokerPositionPanelBase(position, this);
			this.PositionPanelMap[position] = guessJokerPositionPanelBase;
		}
		return guessJokerPositionPanelBase;
	}

	// Token: 0x06006C1F RID: 27679 RVA: 0x0015CCD4 File Offset: 0x0015AED4
	private void OnCardItemClick(GuessJokerCardItem cardItem)
	{
		GuessJokerCardData data = cardItem.Data;
		bool choose = cardItem.GetChoose();
		int id = data.Id;
		GuessJokerCardItem curChooseCardItem = this.CurChooseCardItem;
		int? num;
		if (curChooseCardItem == null)
		{
			num = null;
		}
		else
		{
			GuessJokerCardData data2 = curChooseCardItem.Data;
			num = ((data2 != null) ? new int?(data2.Id) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		Action<int, int, bool> playerCardClickCallback = this.PlayerCardClickCallback;
		if (playerCardClickCallback == null)
		{
			return;
		}
		playerCardClickCallback(id, valueOrDefault, choose);
	}

	// Token: 0x06006C20 RID: 27680 RVA: 0x0015CD44 File Offset: 0x0015AF44
	private void OnCloseButtonClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GuessJokerExitConfirm);
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			GuessJokerGamePlayModel.Instance.GuessJokerExitSaveReport();
			GuessJokerGamePlayModel.Instance.ExitGame();
			bool flag = false;
			int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
			bool firstPass = SpringManorModel.Instance.ActivityData.GetGuessJokerGameData(levelId).FirstPass;
			if (!GuessJokerGamePlayModel.Instance.IsFinish && firstPass)
			{
				flag = true;
			}
			if (flag && levelId == 1010)
			{
				GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
				if (instance == null)
				{
					return;
				}
				instance.HideAllGuessJokerNpc();
			}
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06006C21 RID: 27681 RVA: 0x0015CD9C File Offset: 0x0015AF9C
	private void OnPlayCardButtonClick()
	{
		List<IPlayCardInfo> playerPlayCardIdList = GuessJokerGamePlayModel.Instance.GetPlayerPlayCardIdList();
		List<int> list = new List<int>();
		foreach (IPlayCardInfo playCardInfo in playerPlayCardIdList)
		{
			foreach (int item in playCardInfo.CardIdList)
			{
				list.Add(item);
			}
		}
		Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "玩家出牌, $" + string.Join<int>(",", list), default(ReadOnlySpan<ValueTuple<string, object>>));
		Action<int[]> playerPlayCardInteractiveCallback = this.PlayerPlayCardInteractiveCallback;
		if (playerPlayCardInteractiveCallback == null)
		{
			return;
		}
		playerPlayCardInteractiveCallback(list.ToArray());
	}

	// Token: 0x06006C22 RID: 27682 RVA: 0x0015CE58 File Offset: 0x0015B058
	private void OnUseSkillButtonClick()
	{
		this.UseSkill(true);
	}

	// Token: 0x06006C23 RID: 27683 RVA: 0x0015CE61 File Offset: 0x0015B061
	private void OnGiveUpSkillButtonClick()
	{
		this.UseSkill(false);
	}

	// Token: 0x06006C24 RID: 27684 RVA: 0x0015CE6C File Offset: 0x0015B06C
	private void OnHideToggleClick(EToggleState state)
	{
		bool uiactive = state != EToggleState.ETT_Checked;
		base.GetItem(37).SetUIActive(uiactive);
		base.GetItem(40).SetUIActive(uiactive);
		base.GetItem(41).SetUIActive(uiactive);
		base.GetButton(42).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(43).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06006C25 RID: 27685 RVA: 0x0015CEE1 File Offset: 0x0015B0E1
	private void OnMaskButtonClick()
	{
		GuessJokerHeadItem aiPlayerItem = this.AiPlayerItem;
		if (aiPlayerItem == null)
		{
			return;
		}
		aiPlayerItem.ShowLockSkillTips(false);
	}

	// Token: 0x06006C26 RID: 27686 RVA: 0x0015CEF4 File Offset: 0x0015B0F4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "CardById"))
		{
			return null;
		}
		int cardId = int.Parse(configParams[1]);
		GuessJokerCardItem cardItemById = this.GetCardItemById(cardId);
		UUIItem uuiitem = (cardItemById != null) ? cardItemById.GetRootItem() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x040031E8 RID: 12776
	private int NpcId;

	// Token: 0x040031E9 RID: 12777
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040031EA RID: 12778
	[Nullable(2)]
	private GuessJokerHeadItem AiPlayerItem;

	// Token: 0x040031EB RID: 12779
	[Nullable(2)]
	private GuessJokerHeadItem MePlayerItem;

	// Token: 0x040031EC RID: 12780
	[Nullable(2)]
	private GuessJokerCardItem BlankCardItem;

	// Token: 0x040031ED RID: 12781
	[Nullable(2)]
	private GuessJokerSkillItem UseSkillItem;

	// Token: 0x040031EE RID: 12782
	[Nullable(2)]
	private GuessJokerSkillItem GiveUpSkillItem;

	// Token: 0x040031EF RID: 12783
	[Nullable(2)]
	private GuessJokerSkillActivateItem SkillActivateItem;

	// Token: 0x040031F0 RID: 12784
	[Nullable(2)]
	private GuessJokerCoinFlipItem FlipCoinItem;

	// Token: 0x040031F1 RID: 12785
	private readonly Dictionary<ECardPositionType, GuessJokerPositionPanelBase> PositionPanelMap = new Dictionary<ECardPositionType, GuessJokerPositionPanelBase>();

	// Token: 0x040031F2 RID: 12786
	private readonly Dictionary<int, GuessJokerCardItem> CardItemMap = new Dictionary<int, GuessJokerCardItem>();

	// Token: 0x040031F3 RID: 12787
	[Nullable(2)]
	private GuessJokerCardItem CurChooseCardItem;

	// Token: 0x040031F4 RID: 12788
	private bool? LastSkillProgressAboveThreshold;

	// Token: 0x040031F5 RID: 12789
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int[]> PlayerPlayCardInteractiveCallback;

	// Token: 0x040031F6 RID: 12790
	[Nullable(2)]
	private Action<int, int, bool> PlayerCardClickCallback;

	// Token: 0x040031F7 RID: 12791
	private int CurrentSkillRemindCount;

	// Token: 0x040031F8 RID: 12792
	[Nullable(2)]
	private LevelSequencePlayer GamePlayViewSequencePlayer;

	// Token: 0x040031F9 RID: 12793
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x040031FA RID: 12794
	private readonly Dictionary<int, LevelSequencePlayer> SequencePlayerMap = new Dictionary<int, LevelSequencePlayer>();

	// Token: 0x040031FB RID: 12795
	[Nullable(2)]
	private GuessJokerDialogLogic DialogLogic;

	// Token: 0x040031FC RID: 12796
	[Nullable(2)]
	private Action<bool> PlayerSkillRequestCallback;

	// Token: 0x0200764A RID: 30282
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040270B8 RID: 159928
		public const int CaptionItem = 0;

		// Token: 0x040270B9 RID: 159929
		public const int AiPlayerItem = 1;

		// Token: 0x040270BA RID: 159930
		public const int MePlayerItem = 2;

		// Token: 0x040270BB RID: 159931
		public const int RoundText = 3;

		// Token: 0x040270BC RID: 159932
		public const int CardItem = 4;

		// Token: 0x040270BD RID: 159933
		public const int PlayerSelectArea = 5;

		// Token: 0x040270BE RID: 159934
		public const int AiSelectArea = 6;

		// Token: 0x040270BF RID: 159935
		public const int WithoutBlankButton = 7;

		// Token: 0x040270C0 RID: 159936
		public const int PlayCardButton = 8;

		// Token: 0x040270C1 RID: 159937
		public const int MiddleArea = 9;

		// Token: 0x040270C2 RID: 159938
		public const int GiveUpButton = 10;

		// Token: 0x040270C3 RID: 159939
		public const int SkillInteractivePanel = 11;

		// Token: 0x040270C4 RID: 159940
		public const int UseSkillItem = 12;

		// Token: 0x040270C5 RID: 159941
		public const int GiveUpSkillItem = 13;

		// Token: 0x040270C6 RID: 159942
		public const int TimeSlider = 14;

		// Token: 0x040270C7 RID: 159943
		public const int SkillLeftTimeText = 15;

		// Token: 0x040270C8 RID: 159944
		public const int BarItem = 16;

		// Token: 0x040270C9 RID: 159945
		public const int SkillActivateItem = 17;

		// Token: 0x040270CA RID: 159946
		public const int FlipCoinItem = 18;

		// Token: 0x040270CB RID: 159947
		public const int NumberBackPanel1 = 19;

		// Token: 0x040270CC RID: 159948
		public const int NumberBackPanel2 = 20;

		// Token: 0x040270CD RID: 159949
		public const int AiRoundStartTipItem = 21;

		// Token: 0x040270CE RID: 159950
		public const int PlayerRoundStartTipItem = 22;

		// Token: 0x040270CF RID: 159951
		public const int DrawJokerTipItem = 23;

		// Token: 0x040270D0 RID: 159952
		public const int DrawBlankCardTipItem = 24;

		// Token: 0x040270D1 RID: 159953
		public const int PlayerDrawCardTipItem = 25;

		// Token: 0x040270D2 RID: 159954
		public const int InitialRoundTipItem = 26;

		// Token: 0x040270D3 RID: 159955
		public const int OfficialRoundTipItem = 27;

		// Token: 0x040270D4 RID: 159956
		public const int CheckItem = 28;

		// Token: 0x040270D5 RID: 159957
		public const int PlayerButtonPanel = 29;

		// Token: 0x040270D6 RID: 159958
		public const int AiProgressPanel = 30;

		// Token: 0x040270D7 RID: 159959
		public const int AiProgressSprite = 31;

		// Token: 0x040270D8 RID: 159960
		public const int BlankCardButton = 32;

		// Token: 0x040270D9 RID: 159961
		public const int AiDialogItem = 33;

		// Token: 0x040270DA RID: 159962
		public const int AiDialogText = 34;

		// Token: 0x040270DB RID: 159963
		public const int HideToggle = 35;

		// Token: 0x040270DC RID: 159964
		public const int PlayButtonText = 36;

		// Token: 0x040270DD RID: 159965
		public const int HideItem = 37;

		// Token: 0x040270DE RID: 159966
		public const int AiSelectTipItem = 38;

		// Token: 0x040270DF RID: 159967
		public const int AiSelectText = 39;

		// Token: 0x040270E0 RID: 159968
		public const int TipHideItem = 40;

		// Token: 0x040270E1 RID: 159969
		public const int TitlePanel = 41;

		// Token: 0x040270E2 RID: 159970
		public const int HelpButton = 42;

		// Token: 0x040270E3 RID: 159971
		public const int CloseButton = 43;

		// Token: 0x040270E4 RID: 159972
		public const int MaskButton = 44;

		// Token: 0x040270E5 RID: 159973
		public const int BadTipText = 45;

		// Token: 0x040270E6 RID: 159974
		public const int GoodTipText = 46;

		// Token: 0x040270E7 RID: 159975
		public const int PlayerSkillProgressSprite = 47;
	}
}
