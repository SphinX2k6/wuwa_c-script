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
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200051B RID: 1307
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerSelectRoleView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x06003FC3 RID: 16323 RVA: 0x0016592E File Offset: 0x00163B2E
	public GuessJokerSelectRoleView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x00165944 File Offset: 0x00163B44
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

	// Token: 0x06003FC5 RID: 16325 RVA: 0x00165C04 File Offset: 0x00163E04
	protected override UniTask OnBeforeStartAsync()
	{
		GuessJokerSelectRoleView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GuessJokerSelectRoleView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003FC6 RID: 16326 RVA: 0x00165C47 File Offset: 0x00163E47
	protected override void OnBeforeShow()
	{
		this.PauseTimeDilation();
		UiCameraModel.Instance.DisablePlayerActor();
	}

	// Token: 0x06003FC7 RID: 16327 RVA: 0x00165C59 File Offset: 0x00163E59
	protected override void OnBeforeHide()
	{
		if (this.IsConfirmHide)
		{
			this.IsConfirmHide = false;
		}
		else
		{
			UiCameraModel.Instance.EnablePlayerActor();
		}
		this.ResumeTimeDilation();
	}

	// Token: 0x06003FC8 RID: 16328 RVA: 0x00165C7C File Offset: 0x00163E7C
	protected void PauseTimeDilation()
	{
		UiTimeDilation.Instance.AddWaitSetTimeDilationTag("GuessJokerSelectRoleView");
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x00165C8D File Offset: 0x00163E8D
	protected void ResumeTimeDilation()
	{
		UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag("GuessJokerSelectRoleView");
	}

	// Token: 0x06003FCA RID: 16330 RVA: 0x00165C9E File Offset: 0x00163E9E
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		if (this.CurCameraName != null)
		{
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)this.CurCameraName, viewId, operationType);
		}
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x00165CBF File Offset: 0x00163EBF
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		if (this.CurCameraName != null)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)this.CurCameraName, nextViewName, closeViewId, operationType);
		}
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x00165CE2 File Offset: 0x00163EE2
	private GuessJokerSelectRoleItem CreateRoleItem()
	{
		GuessJokerSelectRoleItem guessJokerSelectRoleItem = new GuessJokerSelectRoleItem();
		guessJokerSelectRoleItem.BindClickCallBack(new Action<GuessJokerSelectRoleItem>(this.OnClickRoleItem));
		return guessJokerSelectRoleItem;
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x00165CFB File Offset: 0x00163EFB
	private ActivitySmallItemGrid CreateRewardItem()
	{
		return new ActivitySmallItemGrid();
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x00165D04 File Offset: 0x00163F04
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

	// Token: 0x06003FCF RID: 16335 RVA: 0x00165D38 File Offset: 0x00163F38
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

	// Token: 0x06003FD0 RID: 16336 RVA: 0x00165E04 File Offset: 0x00164004
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

	// Token: 0x06003FD1 RID: 16337 RVA: 0x00165E80 File Offset: 0x00164080
	private void PushCamera()
	{
		if (this.CurCameraSettingName != null)
		{
			Log.Instance.Info(ELogModule.GuessJokerCard, ELogAuthor.LRC, "【action】Push Camera：" + this.CurCameraSettingName, default(ReadOnlySpan<ValueTuple<string, object>>));
			UiCameraModel.Instance.PushCameraHandleByHandleName(this.CurCameraSettingName, true, true, "1001", false, null);
		}
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x00165EDC File Offset: 0x001640DC
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

	// Token: 0x06003FD3 RID: 16339 RVA: 0x001661AC File Offset: 0x001643AC
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

	// Token: 0x06003FD4 RID: 16340 RVA: 0x001661E8 File Offset: 0x001643E8
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

	// Token: 0x06003FD5 RID: 16341 RVA: 0x0016628C File Offset: 0x0016448C
	private void OnClickRoleItem(GuessJokerSelectRoleItem roleItem)
	{
		this.ChangeRole(roleItem);
		this.PlaySelectViewSequence("Switch", null);
		this.PushCamera();
	}

	// Token: 0x06003FD6 RID: 16342 RVA: 0x001662A7 File Offset: 0x001644A7
	private void OnClickMaskButton()
	{
		GuessJokerHeroSkillItem heroSkillItem = this.HeroSkillItem;
		if (heroSkillItem == null)
		{
			return;
		}
		heroSkillItem.CloseDetail();
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x001662BC File Offset: 0x001644BC
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

	// Token: 0x06003FD8 RID: 16344 RVA: 0x00166374 File Offset: 0x00164574
	private void OnHideToggleClick(EToggleState state)
	{
		bool uiactive = state != EToggleState.ETT_Checked;
		base.GetItem(19).SetUIActive(uiactive);
		base.GetItem(22).SetUIActive(uiactive);
		base.GetButton(23).RootUIComp.Get().SetUIActive(uiactive);
		base.GetButton(24).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x06003FD9 RID: 16345 RVA: 0x001663DC File Offset: 0x001645DC
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

	// Token: 0x06003FDA RID: 16346 RVA: 0x0016646C File Offset: 0x0016466C
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

	// Token: 0x06003FDB RID: 16347 RVA: 0x001664BC File Offset: 0x001646BC
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

	// Token: 0x040032B0 RID: 12976
	public PopupCaptionItem PopupCaption;

	// Token: 0x040032B1 RID: 12977
	private GenericLayout<GuessJokerSelectRoleItem, int> RoleLayout;

	// Token: 0x040032B2 RID: 12978
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<ActivitySmallItemGrid, IItemGridData> RewardScrollView;

	// Token: 0x040032B3 RID: 12979
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x040032B4 RID: 12980
	[Nullable(2)]
	private GuessJokerSelectRoleItem CurSelectRoleItem;

	// Token: 0x040032B5 RID: 12981
	[Nullable(2)]
	private string CurCameraName;

	// Token: 0x040032B6 RID: 12982
	[Nullable(2)]
	private string CurCameraSettingName;

	// Token: 0x040032B7 RID: 12983
	[Nullable(2)]
	private GuessJokerHeroSkillItem HeroSkillItem;

	// Token: 0x040032B8 RID: 12984
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040032B9 RID: 12985
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x040032BA RID: 12986
	private bool IsConfirmHide;
}
