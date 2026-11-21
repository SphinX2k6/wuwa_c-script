using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000519 RID: 1305
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerGamePlayView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x06003F73 RID: 16243 RVA: 0x00164080 File Offset: 0x00162280
	public GuessJokerGamePlayView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003F74 RID: 16244 RVA: 0x001640B8 File Offset: 0x001622B8
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

	// Token: 0x06003F75 RID: 16245 RVA: 0x0016456C File Offset: 0x0016276C
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerGamePlayView.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerGamePlayView.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003F76 RID: 16246 RVA: 0x001645AF File Offset: 0x001627AF
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		this.InitPlayer();
		this.InitButtons();
		this.InitRound();
		this.InitInfo();
	}

	// Token: 0x06003F77 RID: 16247 RVA: 0x001645CF File Offset: 0x001627CF
	protected override void OnAfterShow()
	{
		GuessJokerGamePlayModel instance = GuessJokerGamePlayModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.SetActiveDialogLogic(this.DialogLogic);
	}

	// Token: 0x06003F78 RID: 16248 RVA: 0x001645E6 File Offset: 0x001627E6
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

	// Token: 0x06003F79 RID: 16249 RVA: 0x00164610 File Offset: 0x00162810
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("GuessJokerGamePlayView");
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x00164621 File Offset: 0x00162821
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("GuessJokerGamePlayView");
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x00164634 File Offset: 0x00162834
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		GuessJokerAiConfig? jokerAiConfigByEntityId = GuessJokerConfig.Instance.GetJokerAiConfigByEntityId(this.NpcId);
		if (jokerAiConfigByEntityId == null)
		{
			return;
		}
		string cameraNameByCameraId = GuessJokerUtils.GetCameraNameByCameraId(jokerAiConfigByEntityId.Value.GamePlayCameraId);
		if (cameraNameByCameraId != null)
		{
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)cameraNameByCameraId, viewId, operationType);
		}
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x00164688 File Offset: 0x00162888
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		GuessJokerAiConfig? jokerAiConfigByEntityId = GuessJokerConfig.Instance.GetJokerAiConfigByEntityId(this.NpcId);
		if (jokerAiConfigByEntityId == null)
		{
			return;
		}
		string cameraNameByCameraId = GuessJokerUtils.GetCameraNameByCameraId(jokerAiConfigByEntityId.Value.GamePlayCameraId);
		if (cameraNameByCameraId != null)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)cameraNameByCameraId, nextViewName, closeViewId, operationType);
		}
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x001646DC File Offset: 0x001628DC
	private void OnGamePlayViewSequenceFinish(string sequenceName)
	{
		Action action;
		if (this.SequenceFinishCallbackMap.TryGetValue(sequenceName, out action) && action != null)
		{
			action();
			this.SequenceFinishCallbackMap.Remove(sequenceName);
		}
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x00164711 File Offset: 0x00162911
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (sequenceName == "LevelChange" && eventName == "LevelChange")
		{
			this.UpdateRoundNumber();
		}
	}

	// Token: 0x06003F7F RID: 16255 RVA: 0x00164733 File Offset: 0x00162933
	private void InitPlayer()
	{
		this.AiPlayerItem.SetRoleData(GuessJokerGamePlayModel.Instance.GetRoleData(EGuessJokerPlayerType.Ai));
		this.MePlayerItem.SetRoleData(GuessJokerGamePlayModel.Instance.GetRoleData(EGuessJokerPlayerType.Me));
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x00164764 File Offset: 0x00162964
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

	// Token: 0x06003F81 RID: 16257 RVA: 0x00164804 File Offset: 0x00162A04
	private UniTask InitAllCards()
	{
		GuessJokerGamePlayView.<InitAllCards>d__36 <InitAllCards>d__;
		<InitAllCards>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitAllCards>d__.<>4__this = this;
		<InitAllCards>d__.<>1__state = -1;
		<InitAllCards>d__.<>t__builder.Start<GuessJokerGamePlayView.<InitAllCards>d__36>(ref <InitAllCards>d__);
		return <InitAllCards>d__.<>t__builder.Task;
	}

	// Token: 0x06003F82 RID: 16258 RVA: 0x00164848 File Offset: 0x00162A48
	private UniTask InitBlankCard()
	{
		GuessJokerGamePlayView.<InitBlankCard>d__37 <InitBlankCard>d__;
		<InitBlankCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBlankCard>d__.<>4__this = this;
		<InitBlankCard>d__.<>1__state = -1;
		<InitBlankCard>d__.<>t__builder.Start<GuessJokerGamePlayView.<InitBlankCard>d__37>(ref <InitBlankCard>d__);
		return <InitBlankCard>d__.<>t__builder.Task;
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x0016488C File Offset: 0x00162A8C
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

	// Token: 0x06003F84 RID: 16260 RVA: 0x00164934 File Offset: 0x00162B34
	private void InitInfo()
	{
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(EGuessJokerPlayerType.Ai);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(39), "GuessJoker_AiSelectText", new <>z__ReadOnlySingleElementList<object>(playerNameByType));
	}

	// Token: 0x06003F85 RID: 16261 RVA: 0x0016496A File Offset: 0x00162B6A
	public void HidePlayerButtons()
	{
		this.PlayGamePlayViewSequence("BtnHide", delegate
		{
			base.GetItem(29).SetUIActive(false);
		});
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x00164984 File Offset: 0x00162B84
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

	// Token: 0x06003F87 RID: 16263 RVA: 0x001649D0 File Offset: 0x00162BD0
	protected override void OnBeforeDestroy()
	{
		foreach (GuessJokerCardItem guessJokerCardItem in this.CardItemMap.Values)
		{
			guessJokerCardItem.Destroy(null);
		}
		this.CardItemMap.Clear();
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x00164A34 File Offset: 0x00162C34
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

	// Token: 0x06003F89 RID: 16265 RVA: 0x00164A54 File Offset: 0x00162C54
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

	// Token: 0x06003F8A RID: 16266 RVA: 0x00164AAC File Offset: 0x00162CAC
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

	// Token: 0x06003F8B RID: 16267 RVA: 0x00164B2C File Offset: 0x00162D2C
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

	// Token: 0x06003F8C RID: 16268 RVA: 0x00164B5F File Offset: 0x00162D5F
	[NullableContext(2)]
	public void SetPlayerCardClickCallback(Action<int, int, bool> callback)
	{
		this.PlayerCardClickCallback = callback;
	}

	// Token: 0x06003F8D RID: 16269 RVA: 0x00164B68 File Offset: 0x00162D68
	public void SetFlipCoinClickEnable()
	{
		GuessJokerCoinFlipItem flipCoinItem = this.FlipCoinItem;
		if (flipCoinItem == null)
		{
			return;
		}
		flipCoinItem.SetClickEnable(true);
	}

	// Token: 0x06003F8E RID: 16270 RVA: 0x00164B7B File Offset: 0x00162D7B
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

	// Token: 0x06003F8F RID: 16271 RVA: 0x00164BA2 File Offset: 0x00162DA2
	public void SetPlayerSkillRequestCallback(Action<bool> callback)
	{
		this.PlayerSkillRequestCallback = callback;
	}

	// Token: 0x06003F90 RID: 16272 RVA: 0x00164BAC File Offset: 0x00162DAC
	public void UpdateRoundNumber()
	{
		int roundNumber = GuessJokerGamePlayModel.Instance.RoundNumber;
		UUIText text = base.GetText(3);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>((roundNumber == 0) ? 1 : roundNumber);
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
	}

	// Token: 0x06003F91 RID: 16273 RVA: 0x00164BF0 File Offset: 0x00162DF0
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

	// Token: 0x06003F92 RID: 16274 RVA: 0x00164C2C File Offset: 0x00162E2C
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

	// Token: 0x06003F93 RID: 16275 RVA: 0x00164CD3 File Offset: 0x00162ED3
	public void ShowAiSkillProgress(bool isShow)
	{
		this.PlayStartOrCloseSequence(isShow, 30, null);
	}

	// Token: 0x06003F94 RID: 16276 RVA: 0x00164CE0 File Offset: 0x00162EE0
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

	// Token: 0x06003F95 RID: 16277 RVA: 0x00164D58 File Offset: 0x00162F58
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

	// Token: 0x06003F96 RID: 16278 RVA: 0x00164D8C File Offset: 0x00162F8C
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

	// Token: 0x06003F97 RID: 16279 RVA: 0x00164E14 File Offset: 0x00163014
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

	// Token: 0x06003F98 RID: 16280 RVA: 0x00164E5E File Offset: 0x0016305E
	public void UpdateCurrentPlayer(EGuessJokerPlayerType playerType)
	{
		this.AiPlayerItem.SetSelfRound(playerType == EGuessJokerPlayerType.Ai);
		this.MePlayerItem.SetSelfRound(playerType == EGuessJokerPlayerType.Me);
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x00164E7E File Offset: 0x0016307E
	public void SetCurrentSkillInfo(int skillId, int skillRemindCount)
	{
		this.CurrentSkillRemindCount = skillRemindCount;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(15), "GuessJoker_SkillChargesText", new <>z__ReadOnlySingleElementList<object>(this.CurrentSkillRemindCount));
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x00164EB0 File Offset: 0x001630B0
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

	// Token: 0x06003F9B RID: 16283 RVA: 0x00164EE4 File Offset: 0x001630E4
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

	// Token: 0x06003F9C RID: 16284 RVA: 0x00164F88 File Offset: 0x00163188
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

	// Token: 0x06003F9D RID: 16285 RVA: 0x00165018 File Offset: 0x00163218
	public void SetBlankCardDisable()
	{
		this.BlankCardItem.SetBlankCardDisable();
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x00165028 File Offset: 0x00163228
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

	// Token: 0x06003F9F RID: 16287 RVA: 0x00165138 File Offset: 0x00163338
	public void SetPositionPanelCardsDark(ECardPositionType position, bool isDark, int[] excludeCardIdList = null)
	{
		if (excludeCardIdList == null)
		{
			excludeCardIdList = Array.Empty<int>();
		}
		this.GetPositionPanel(position).SetCardsDarkExcept(isDark, new List<int>(excludeCardIdList));
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x00165158 File Offset: 0x00163358
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

	// Token: 0x06003FA1 RID: 16289 RVA: 0x001651F0 File Offset: 0x001633F0
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

	// Token: 0x06003FA2 RID: 16290 RVA: 0x0016528E File Offset: 0x0016348E
	public void PlaySkillEffect(int skillId, Action completeCallback)
	{
		GuessJokerSkillActivateItem skillActivateItem = this.SkillActivateItem;
		if (skillActivateItem != null)
		{
			skillActivateItem.Refresh(skillId);
		}
		this.PlayContinuousSequence(17, completeCallback);
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x001652AB File Offset: 0x001634AB
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

	// Token: 0x06003FA4 RID: 16292 RVA: 0x001652D8 File Offset: 0x001634D8
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

	// Token: 0x06003FA5 RID: 16293 RVA: 0x0016530C File Offset: 0x0016350C
	public void UpdateSkill(EGuessJokerPlayerType playerType)
	{
		GuessJokerHeadItem guessJokerHeadItem = (playerType == EGuessJokerPlayerType.Ai) ? this.AiPlayerItem : this.MePlayerItem;
		if (guessJokerHeadItem != null)
		{
			guessJokerHeadItem.SetSkillUnlock(true);
		}
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x00165336 File Offset: 0x00163536
	private void UseSkill(bool isUse)
	{
		Action<bool> playerSkillRequestCallback = this.PlayerSkillRequestCallback;
		if (playerSkillRequestCallback == null)
		{
			return;
		}
		playerSkillRequestCallback(isUse);
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x0016534C File Offset: 0x0016354C
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

	// Token: 0x06003FA8 RID: 16296 RVA: 0x001653A7 File Offset: 0x001635A7
	public void ClearChooseCard()
	{
		if (this.CurChooseCardItem != null)
		{
			this.CurChooseCardItem.SetChoose(false, false);
			this.CurChooseCardItem = null;
		}
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x001653C8 File Offset: 0x001635C8
	public void SetCardsSelect(int cardId, Action finishCallback)
	{
		GuessJokerCardItem cardItemById = this.GetCardItemById(cardId);
		if (cardItemById != null)
		{
			cardItemById.SetSelectCardItem(finishCallback);
		}
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x001653E8 File Offset: 0x001635E8
	public void UpdateCardItemsHierarchyIndex()
	{
		List<GuessJokerCardItem> list = new List<GuessJokerCardItem>(this.CardItemMap.Values);
		list.Sort((GuessJokerCardItem a, GuessJokerCardItem b) => a.GetGlobalIndex() - b.GetGlobalIndex());
		for (int i = 0; i < list.Count; i++)
		{
			list[i].SetHierarchyIndex(i);
		}
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x0016544C File Offset: 0x0016364C
	public void ClearAllCardsChecking()
	{
		foreach (GuessJokerCardItem guessJokerCardItem in this.CardItemMap.Values)
		{
			guessJokerCardItem.ClearCheckingSign();
		}
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x001654A4 File Offset: 0x001636A4
	public void ShowPlayerRoundStartTip(EGuessJokerPlayerType playerType, Action completeCallback)
	{
		int componentDefine = (playerType == EGuessJokerPlayerType.Ai) ? 21 : 22;
		this.PlayContinuousSequence(componentDefine, completeCallback);
	}

	// Token: 0x06003FAD RID: 16301 RVA: 0x001654C4 File Offset: 0x001636C4
	public void ShowPlayerDrawCardTip(bool isShow, Action completeCallback)
	{
		int componentDefine = 25;
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06003FAE RID: 16302 RVA: 0x001654E0 File Offset: 0x001636E0
	public void ShowInitialRoundTip(bool isShow, Action completeCallback)
	{
		int componentDefine = 26;
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x001654FC File Offset: 0x001636FC
	public void ShowDrawSpecialTip(bool isShow, bool isGood, EGuessJokerPlayerType playerType, Action completeCallback)
	{
		int componentDefine = isGood ? 24 : 23;
		int name = isGood ? 46 : 45;
		string text = isGood ? "GuessJoker_DrawBlankCardTipText" : "GuessJoker_DrawJokerTipText";
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(playerType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(name), text.ToString(), new <>z__ReadOnlySingleElementList<object>(playerNameByType));
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x00165560 File Offset: 0x00163760
	public void ShowWinLoseReasonTip(EGuessJokerPlayerType playerType, string textKey, bool isGood, Action completeCallback)
	{
		int name = isGood ? 46 : 45;
		string playerNameByType = GuessJokerGamePlayModel.Instance.GetPlayerNameByType(playerType);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(name), textKey, new <>z__ReadOnlySingleElementList<object>(playerNameByType));
		base.GetText(name).ShowTextNew(textKey);
		int componentDefine = isGood ? 24 : 23;
		this.PlayContinuousSequence(componentDefine, completeCallback);
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x001655BB File Offset: 0x001637BB
	public void ShowOfficialRoundStartTip(Action completeCallback)
	{
		this.PlayContinuousSequence(27, completeCallback);
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x001655C8 File Offset: 0x001637C8
	public void ShowAiSelectCardTip(bool isShow, Action completeCallback)
	{
		int componentDefine = 38;
		this.PlayStartOrCloseSequence(isShow, componentDefine, completeCallback);
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x001655E4 File Offset: 0x001637E4
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

	// Token: 0x06003FB4 RID: 16308 RVA: 0x00165618 File Offset: 0x00163818
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

	// Token: 0x06003FB5 RID: 16309 RVA: 0x00165688 File Offset: 0x00163888
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

	// Token: 0x06003FB6 RID: 16310 RVA: 0x001656E0 File Offset: 0x001638E0
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

	// Token: 0x06003FB7 RID: 16311 RVA: 0x0016579C File Offset: 0x0016399C
	private void OnUseSkillButtonClick()
	{
		this.UseSkill(true);
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x001657A5 File Offset: 0x001639A5
	private void OnGiveUpSkillButtonClick()
	{
		this.UseSkill(false);
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x001657B0 File Offset: 0x001639B0
	private void OnHideToggleClick(EToggleState state)
	{
		bool uiactive = state != EToggleState.ETT_Checked;
		base.GetItem(37).SetUIActive(uiactive);
		base.GetItem(40).SetUIActive(uiactive);
		base.GetItem(41).SetUIActive(uiactive);
		base.GetButton(42).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(43).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x00165825 File Offset: 0x00163A25
	private void OnMaskButtonClick()
	{
		GuessJokerHeadItem aiPlayerItem = this.AiPlayerItem;
		if (aiPlayerItem == null)
		{
			return;
		}
		aiPlayerItem.ShowLockSkillTips(false);
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x00165838 File Offset: 0x00163A38
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

	// Token: 0x04003281 RID: 12929
	private int NpcId;

	// Token: 0x04003282 RID: 12930
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04003283 RID: 12931
	[Nullable(2)]
	private GuessJokerHeadItem AiPlayerItem;

	// Token: 0x04003284 RID: 12932
	[Nullable(2)]
	private GuessJokerHeadItem MePlayerItem;

	// Token: 0x04003285 RID: 12933
	[Nullable(2)]
	private GuessJokerCardItem BlankCardItem;

	// Token: 0x04003286 RID: 12934
	[Nullable(2)]
	private GuessJokerSkillItem UseSkillItem;

	// Token: 0x04003287 RID: 12935
	[Nullable(2)]
	private GuessJokerSkillItem GiveUpSkillItem;

	// Token: 0x04003288 RID: 12936
	[Nullable(2)]
	private GuessJokerSkillActivateItem SkillActivateItem;

	// Token: 0x04003289 RID: 12937
	[Nullable(2)]
	private GuessJokerCoinFlipItem FlipCoinItem;

	// Token: 0x0400328A RID: 12938
	private readonly Dictionary<ECardPositionType, GuessJokerPositionPanelBase> PositionPanelMap = new Dictionary<ECardPositionType, GuessJokerPositionPanelBase>();

	// Token: 0x0400328B RID: 12939
	private readonly Dictionary<int, GuessJokerCardItem> CardItemMap = new Dictionary<int, GuessJokerCardItem>();

	// Token: 0x0400328C RID: 12940
	[Nullable(2)]
	private GuessJokerCardItem CurChooseCardItem;

	// Token: 0x0400328D RID: 12941
	private bool? LastSkillProgressAboveThreshold;

	// Token: 0x0400328E RID: 12942
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<int[]> PlayerPlayCardInteractiveCallback;

	// Token: 0x0400328F RID: 12943
	[Nullable(2)]
	private Action<int, int, bool> PlayerCardClickCallback;

	// Token: 0x04003290 RID: 12944
	private int CurrentSkillRemindCount;

	// Token: 0x04003291 RID: 12945
	[Nullable(2)]
	private LevelSequencePlayer GamePlayViewSequencePlayer;

	// Token: 0x04003292 RID: 12946
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x04003293 RID: 12947
	private readonly Dictionary<int, LevelSequencePlayer> SequencePlayerMap = new Dictionary<int, LevelSequencePlayer>();

	// Token: 0x04003294 RID: 12948
	[Nullable(2)]
	private GuessJokerDialogLogic DialogLogic;

	// Token: 0x04003295 RID: 12949
	[Nullable(2)]
	private Action<bool> PlayerSkillRequestCallback;

	// Token: 0x020067DE RID: 26590
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04022403 RID: 140291
		public const int CaptionItem = 0;

		// Token: 0x04022404 RID: 140292
		public const int AiPlayerItem = 1;

		// Token: 0x04022405 RID: 140293
		public const int MePlayerItem = 2;

		// Token: 0x04022406 RID: 140294
		public const int RoundText = 3;

		// Token: 0x04022407 RID: 140295
		public const int CardItem = 4;

		// Token: 0x04022408 RID: 140296
		public const int PlayerSelectArea = 5;

		// Token: 0x04022409 RID: 140297
		public const int AiSelectArea = 6;

		// Token: 0x0402240A RID: 140298
		public const int WithoutBlankButton = 7;

		// Token: 0x0402240B RID: 140299
		public const int PlayCardButton = 8;

		// Token: 0x0402240C RID: 140300
		public const int MiddleArea = 9;

		// Token: 0x0402240D RID: 140301
		public const int GiveUpButton = 10;

		// Token: 0x0402240E RID: 140302
		public const int SkillInteractivePanel = 11;

		// Token: 0x0402240F RID: 140303
		public const int UseSkillItem = 12;

		// Token: 0x04022410 RID: 140304
		public const int GiveUpSkillItem = 13;

		// Token: 0x04022411 RID: 140305
		public const int TimeSlider = 14;

		// Token: 0x04022412 RID: 140306
		public const int SkillLeftTimeText = 15;

		// Token: 0x04022413 RID: 140307
		public const int BarItem = 16;

		// Token: 0x04022414 RID: 140308
		public const int SkillActivateItem = 17;

		// Token: 0x04022415 RID: 140309
		public const int FlipCoinItem = 18;

		// Token: 0x04022416 RID: 140310
		public const int NumberBackPanel1 = 19;

		// Token: 0x04022417 RID: 140311
		public const int NumberBackPanel2 = 20;

		// Token: 0x04022418 RID: 140312
		public const int AiRoundStartTipItem = 21;

		// Token: 0x04022419 RID: 140313
		public const int PlayerRoundStartTipItem = 22;

		// Token: 0x0402241A RID: 140314
		public const int DrawJokerTipItem = 23;

		// Token: 0x0402241B RID: 140315
		public const int DrawBlankCardTipItem = 24;

		// Token: 0x0402241C RID: 140316
		public const int PlayerDrawCardTipItem = 25;

		// Token: 0x0402241D RID: 140317
		public const int InitialRoundTipItem = 26;

		// Token: 0x0402241E RID: 140318
		public const int OfficialRoundTipItem = 27;

		// Token: 0x0402241F RID: 140319
		public const int CheckItem = 28;

		// Token: 0x04022420 RID: 140320
		public const int PlayerButtonPanel = 29;

		// Token: 0x04022421 RID: 140321
		public const int AiProgressPanel = 30;

		// Token: 0x04022422 RID: 140322
		public const int AiProgressSprite = 31;

		// Token: 0x04022423 RID: 140323
		public const int BlankCardButton = 32;

		// Token: 0x04022424 RID: 140324
		public const int AiDialogItem = 33;

		// Token: 0x04022425 RID: 140325
		public const int AiDialogText = 34;

		// Token: 0x04022426 RID: 140326
		public const int HideToggle = 35;

		// Token: 0x04022427 RID: 140327
		public const int PlayButtonText = 36;

		// Token: 0x04022428 RID: 140328
		public const int HideItem = 37;

		// Token: 0x04022429 RID: 140329
		public const int AiSelectTipItem = 38;

		// Token: 0x0402242A RID: 140330
		public const int AiSelectText = 39;

		// Token: 0x0402242B RID: 140331
		public const int TipHideItem = 40;

		// Token: 0x0402242C RID: 140332
		public const int TitlePanel = 41;

		// Token: 0x0402242D RID: 140333
		public const int HelpButton = 42;

		// Token: 0x0402242E RID: 140334
		public const int CloseButton = 43;

		// Token: 0x0402242F RID: 140335
		public const int MaskButton = 44;

		// Token: 0x04022430 RID: 140336
		public const int BadTipText = 45;

		// Token: 0x04022431 RID: 140337
		public const int GoodTipText = 46;

		// Token: 0x04022432 RID: 140338
		public const int PlayerSkillProgressSprite = 47;
	}
}
