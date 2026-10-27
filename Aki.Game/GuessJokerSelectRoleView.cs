using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001067 RID: 4199
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerSelectRoleView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x06006C2E RID: 27694 RVA: 0x0015CFEA File Offset: 0x0015B1EA
	public GuessJokerSelectRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006C2F RID: 27695 RVA: 0x0015D000 File Offset: 0x0015B200
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUISprite)),
			new ValueTuple<int, Type>(13, typeof(UUISprite)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIText)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(21, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(24, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickConfirm)),
			new ValueTuple<int, Delegate>(17, new Action(this.OnClickMaskButton)),
			new ValueTuple<int, Delegate>(20, new Action<EToggleState>(this.OnHideToggleClick)),
			new ValueTuple<int, Delegate>(21, new Action(this.OnClickGetReward))
		};
	}

	// Token: 0x06006C30 RID: 27696 RVA: 0x0015D2C0 File Offset: 0x0015B4C0
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerSelectRoleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerSelectRoleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006C31 RID: 27697 RVA: 0x0015D303 File Offset: 0x0015B503
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		UiCameraAnimationManager.Instance.DisablePlayerActor();
	}

	// Token: 0x06006C32 RID: 27698 RVA: 0x0015D315 File Offset: 0x0015B515
	protected override void OnBeforeHide()
	{
		if (this.IsConfirmHide)
		{
			this.IsConfirmHide = false;
		}
		else
		{
			UiCameraAnimationManager.Instance.EnablePlayerActor();
		}
		this.ResumeTimeDilation();
	}

	// Token: 0x06006C33 RID: 27699 RVA: 0x0015D338 File Offset: 0x0015B538
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("GuessJokerSelectRoleView");
	}

	// Token: 0x06006C34 RID: 27700 RVA: 0x0015D349 File Offset: 0x0015B549
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("GuessJokerSelectRoleView");
	}

	// Token: 0x06006C35 RID: 27701 RVA: 0x0015D35A File Offset: 0x0015B55A
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		if (this.CurCameraName != null)
		{
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)this.CurCameraName, new int?(viewId), isBlend);
		}
	}

	// Token: 0x06006C36 RID: 27702 RVA: 0x0015D380 File Offset: 0x0015B580
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		if (this.CurCameraName != null)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)this.CurCameraName, stackTopInfo, closeViewId, popOrDelete);
		}
	}

	// Token: 0x06006C37 RID: 27703 RVA: 0x0015D3A3 File Offset: 0x0015B5A3
	private GuessJokerSelectRoleItem CreateRoleItem()
	{
		GuessJokerSelectRoleItem guessJokerSelectRoleItem = new GuessJokerSelectRoleItem();
		guessJokerSelectRoleItem.BindClickCallBack(new Action<GuessJokerSelectRoleItem>(this.OnClickRoleItem));
		return guessJokerSelectRoleItem;
	}

	// Token: 0x06006C38 RID: 27704 RVA: 0x0015D3BC File Offset: 0x0015B5BC
	private ActivitySmallItemGrid CreateRewardItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x06006C39 RID: 27705 RVA: 0x0015D3C4 File Offset: 0x0015B5C4
	private void OnSelectViewSequenceFinish(string sequenceName)
	{
		Action action;
		this.SequenceFinishCallbackMap.TryGetValue(sequenceName, out action);
		if (action != null)
		{
			action();
			this.SequenceFinishCallbackMap.Remove(sequenceName);
		}
	}

	// Token: 0x06006C3A RID: 27706 RVA: 0x0015D3F8 File Offset: 0x0015B5F8
	private void ChangeRole(GuessJokerSelectRoleItem roleItem)
	{
		if (this.CurSelectRoleItem == roleItem)
		{
			return;
		}
		if (this.CurSelectRoleItem != null)
		{
			this.CurSelectRoleItem.OnDeselected(true);
		}
		roleItem.OnSelected(true);
		this.CurSelectRoleItem = roleItem;
		int level = this.CurSelectRoleItem.Level;
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(level);
		if (jokerLevelById == null)
		{
			return;
		}
		int aiRole = jokerLevelById.Value.AiRole;
		GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(aiRole);
		if (jokerAiConfigByRoleId == null)
		{
			return;
		}
		this.CheckClick(level);
		roleItem.RefreshRedDot();
		int selectRoleCameraId = jokerAiConfigByRoleId.Value.SelectRoleCameraId;
		string cameraNameByCameraId = GuessJokerUtils.GetCameraNameByCameraId(selectRoleCameraId);
		this.CurCameraName = cameraNameByCameraId;
		this.CurCameraSettingName = GuessJokerUtils.GetCameraSettingNameByCameraId(selectRoleCameraId);
		this.RefreshDetailView(roleItem.Level);
	}

	// Token: 0x06006C3B RID: 27707 RVA: 0x0015D4C4 File Offset: 0x0015B6C4
	private void CheckClick(int levelId)
	{
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		IGuessJokerLevelInfo guessJokerGameData = activityData.GetGuessJokerGameData(levelId);
		if (guessJokerGameData == null)
		{
			return;
		}
		if (!guessJokerGameData.Unlock || guessJokerGameData.FirstPass)
		{
			return;
		}
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerUnlockLevelClicked, null) ?? new HashSet<int>();
		if (!hashSet.Contains(levelId))
		{
			hashSet.Add(levelId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerUnlockLevelClicked, hashSet);
			EventSystem.Instance.Emit(EEventName.OnGuessJokerRedDotNotify);
		}
	}

	// Token: 0x06006C3C RID: 27708 RVA: 0x0015D540 File Offset: 0x0015B740
	private void PushCamera()
	{
		if (this.CurCameraSettingName != null)
		{
			Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "【action】Push Camera：" + this.CurCameraSettingName, default(ReadOnlySpan<ValueTuple<string, object>>));
			UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(this.CurCameraSettingName, true, true, "1001", false, null, null);
		}
	}

	// Token: 0x06006C3D RID: 27709 RVA: 0x0015D5A4 File Offset: 0x0015B7A4
	private void RefreshDetailView(int levelId)
	{
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(levelId);
		int aiRole = jokerLevelById.Value.AiRole;
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(RoleConfig.Instance.GetRoleConfig(aiRole).Value.Name, null);
		base.GetText(3).SetText(localTextNew, true);
		SpringManorData activityData = SpringManorModel.Instance.ActivityData;
		if (activityData == null)
		{
			return;
		}
		IGuessJokerLevelInfo guessJokerGameData = activityData.GetGuessJokerGameData(levelId);
		if (guessJokerGameData == null)
		{
			return;
		}
		bool isFinished = guessJokerGameData.FirstPass;
		bool unlock = guessJokerGameData.Unlock;
		bool rewardGet = guessJokerGameData.RewardGet;
		base.GetItem(5).SetUIActive(guessJokerGameData.PlayerWin);
		base.GetSprite(12).SetUIActive(!unlock || !isFinished);
		base.GetSprite(13).SetUIActive(isFinished && rewardGet);
		base.GetButton(21).RootUIComp.Get().SetUIActive(isFinished && !rewardGet);
		int aiCardSkill = jokerLevelById.Value.AiCardSkill;
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(aiCardSkill);
		base.GetText(6).ShowTextNew(isFinished ? jokerSkill.Value.SkillName : "GuessJoker_SkillNameLockText");
		base.GetText(7).ShowTextNew(isFinished ? jokerSkill.Value.SkillDesc : "GuessJoker_SkillDescLockText");
		string textStringId = isFinished ? "GuessJoker_RematchConfirmText" : "GuessJoker_ConfirmText";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(18), textStringId, new <>z__ReadOnlySingleElementList<object>(localTextNew));
		base.SetTextureByPath(jokerSkill.Value.SkillIconPath, base.GetTexture(9), null, null);
		int passReward = jokerLevelById.Value.PassReward;
		this.RefreshRewardData(passReward, rewardGet);
		base.GetButton(14).RootUIComp.Get().SetUIActive(unlock);
		if (!unlock)
		{
			this.PanelLock.SetTextByTextId(jokerLevelById.Value.LockText, Array.Empty<string>());
		}
		this.PanelLock.SetUiActive(!unlock);
		HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerFirstFinishAnim, null) ?? new HashSet<int>();
		if (hashSet.Contains(levelId))
		{
			this.PlaySelectViewSequence("Unlock", delegate
			{
				this.GetTexture(9).SetUIActive(isFinished);
				this.GetSprite(8).SetUIActive(!isFinished);
			});
			hashSet.Remove(levelId);
			LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.GuessJokerFirstFinishAnim, hashSet);
			return;
		}
		base.GetTexture(9).SetUIActive(isFinished);
		base.GetSprite(8).SetUIActive(!isFinished);
	}

	// Token: 0x06006C3E RID: 27710 RVA: 0x0015D874 File Offset: 0x0015BA74
	private void PlaySelectViewSequence(string sequenceName, [Nullable(2)] Action finishCallback = null)
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}
		if (finishCallback != null)
		{
			this.SequenceFinishCallbackMap[sequenceName] = finishCallback;
		}
	}

	// Token: 0x06006C3F RID: 27711 RVA: 0x0015D8B0 File Offset: 0x0015BAB0
	private void RefreshRewardData(int dropId, bool isClaimed)
	{
		if (dropId == 0)
		{
			this.RewardScrollView.SetActive(false);
			return;
		}
		List<IItemGridData> list = new List<IItemGridData>();
		foreach (TItem item in CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreviewItemList(dropId))
		{
			ItemGridData item2 = new ItemGridData
			{
				Item = item,
				HasClaimed = isClaimed
			};
			list.Add(item2);
		}
		this.RewardScrollView.RefreshByData(list, null, false);
		this.RewardScrollView.SetActive(list.Count > 0);
	}

	// Token: 0x06006C40 RID: 27712 RVA: 0x0015D954 File Offset: 0x0015BB54
	private void OnClickRoleItem(GuessJokerSelectRoleItem roleItem)
	{
		this.ChangeRole(roleItem);
		this.PlaySelectViewSequence("Switch", null);
		this.PushCamera();
	}

	// Token: 0x06006C41 RID: 27713 RVA: 0x0015D96F File Offset: 0x0015BB6F
	private void OnClickMaskButton()
	{
		GuessJokerHeroSkillItem heroSkillItem = this.HeroSkillItem;
		if (heroSkillItem == null)
		{
			return;
		}
		heroSkillItem.CloseDetail();
	}

	// Token: 0x06006C42 RID: 27714 RVA: 0x0015D984 File Offset: 0x0015BB84
	private void OnClickConfirm()
	{
		if (this.CurSelectRoleItem == null)
		{
			return;
		}
		int level = this.CurSelectRoleItem.Level;
		GuessJokerLevel? jokerLevelById = GuessJokerConfig.Instance.GetJokerLevelById(level);
		GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(jokerLevelById.Value.AiRole);
		if (jokerAiConfigByRoleId != null)
		{
			GuessJokerGamePlayModel.Instance.ShowOnlyGuessJokerNpc(jokerAiConfigByRoleId.Value.NpcId);
		}
		string[] array = jokerLevelById.Value.FirstEnterFlow();
		if (array.Length == 3)
		{
			FlowController.Instance.StartFlow(array[0], int.Parse(array[1]), int.Parse(array[2]), null, 0L, false, false, false, null);
		}
		this.IsConfirmHide = true;
		base.CloseMe(null);
	}

	// Token: 0x06006C43 RID: 27715 RVA: 0x0015DA3C File Offset: 0x0015BC3C
	private void OnHideToggleClick(EToggleState state)
	{
		bool uiactive = state != EToggleState.ETT_Checked;
		base.GetItem(19).SetUIActive(uiactive);
		base.GetItem(22).SetUIActive(uiactive);
		base.GetButton(23).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(24).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06006C44 RID: 27716 RVA: 0x0015DAA4 File Offset: 0x0015BCA4
	private void OnClickBack()
	{
		int levelId = GuessJokerGamePlayModel.Instance.GetLevelId();
		if (levelId != -1)
		{
			int aiRole = GuessJokerConfig.Instance.GetJokerLevelById(levelId).Value.AiRole;
			GuessJokerAiConfig? jokerAiConfigByRoleId = GuessJokerConfig.Instance.GetJokerAiConfigByRoleId(aiRole);
			if (jokerAiConfigByRoleId == null)
			{
				base.CloseMe(null);
				return;
			}
			int npcId = jokerAiConfigByRoleId.Value.NpcId;
			if (npcId != 0)
			{
				GuessJokerGamePlayModel.Instance.ShowOnlyGuessJokerNpc(npcId);
			}
		}
		else
		{
			GuessJokerGamePlayModel.Instance.HideAllGuessJokerNpc();
		}
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x06006C45 RID: 27717 RVA: 0x0015DB34 File Offset: 0x0015BD34
	private void OnClickGetReward()
	{
		if (this.CurSelectRoleItem == null)
		{
			return;
		}
		int levelId = this.CurSelectRoleItem.Level;
		GuessJokerController.Instance.JokerGuessRewardRequest(levelId, delegate
		{
			this.RefreshDetailView(levelId);
			GuessJokerSelectRoleItem curSelectRoleItem = this.CurSelectRoleItem;
			if (curSelectRoleItem == null)
			{
				return;
			}
			curSelectRoleItem.RefreshRedDot();
		});
	}

	// Token: 0x06006C46 RID: 27718 RVA: 0x0015DB84 File Offset: 0x0015BD84
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (!(configParams[0] == "Role"))
		{
			return null;
		}
		int index = int.Parse(configParams[1]);
		GuessJokerSelectRoleItem layoutItemByIndex = this.RoleLayout.GetLayoutItemByIndex(index);
		UUIItem uuiitem = (layoutItemByIndex != null) ? layoutItemByIndex.GuideGetToggleItem() : null;
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

	// Token: 0x04003217 RID: 12823
	public PopupCaptionItem PopupCaption;

	// Token: 0x04003218 RID: 12824
	private GenericLayout<GuessJokerSelectRoleItem, int> RoleLayout;

	// Token: 0x04003219 RID: 12825
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x0400321A RID: 12826
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x0400321B RID: 12827
	[Nullable(2)]
	private GuessJokerSelectRoleItem CurSelectRoleItem;

	// Token: 0x0400321C RID: 12828
	[Nullable(2)]
	private string CurCameraName;

	// Token: 0x0400321D RID: 12829
	[Nullable(2)]
	private string CurCameraSettingName;

	// Token: 0x0400321E RID: 12830
	[Nullable(2)]
	private GuessJokerHeroSkillItem HeroSkillItem;

	// Token: 0x0400321F RID: 12831
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04003220 RID: 12832
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x04003221 RID: 12833
	private bool IsConfirmHide;
}
