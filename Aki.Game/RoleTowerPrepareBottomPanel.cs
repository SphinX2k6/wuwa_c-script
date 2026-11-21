using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CE3 RID: 7395
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerPrepareBottomPanel : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x060124D2 RID: 74962 RVA: 0x00565A7B File Offset: 0x00563C7B
	static RoleTowerPrepareBottomPanel()
	{
		Aki.Common.Proxy.StaticVariableRegister.RegisterAndExecute(new Action(RoleTowerPrepareBottomPanel.CreateStaticDefaultValue), new Action(RoleTowerPrepareBottomPanel.ResetStaticDefaultValue));
	}

	// Token: 0x060124D3 RID: 74963 RVA: 0x00565A9A File Offset: 0x00563C9A
	public static void CreateStaticDefaultValue()
	{
		RoleTowerPrepareBottomPanel._tokenConfirmSkippedThisLogin = false;
	}

	// Token: 0x060124D4 RID: 74964 RVA: 0x00565AA2 File Offset: 0x00563CA2
	public static void ResetStaticDefaultValue()
	{
		RoleTowerPrepareBottomPanel._tokenConfirmSkippedThisLogin = false;
	}

	// Token: 0x060124D5 RID: 74965 RVA: 0x00565AAC File Offset: 0x00563CAC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickStart)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickMultiModule))
		};
	}

	// Token: 0x060124D6 RID: 74966 RVA: 0x00565C0B File Offset: 0x00563E0B
	protected override void OnStart()
	{
		EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060124D7 RID: 74967 RVA: 0x00565C29 File Offset: 0x00563E29
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleSkillBranchChanged));
	}

	// Token: 0x060124D8 RID: 74968 RVA: 0x00565C48 File Offset: 0x00563E48
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerPrepareBottomPanel.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerPrepareBottomPanel.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060124D9 RID: 74969 RVA: 0x00565C8C File Offset: 0x00563E8C
	private UniTask CreateTokenItem()
	{
		RoleTowerPrepareBottomPanel.<CreateTokenItem>d__19 <CreateTokenItem>d__;
		<CreateTokenItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateTokenItem>d__.<>4__this = this;
		<CreateTokenItem>d__.<>1__state = -1;
		<CreateTokenItem>d__.<>t__builder.Start<RoleTowerPrepareBottomPanel.<CreateTokenItem>d__19>(ref <CreateTokenItem>d__);
		return <CreateTokenItem>d__.<>t__builder.Task;
	}

	// Token: 0x060124DA RID: 74970 RVA: 0x00565CD0 File Offset: 0x00563ED0
	private UniTask CreateCannotStartLockPanel()
	{
		RoleTowerPrepareBottomPanel.<CreateCannotStartLockPanel>d__20 <CreateCannotStartLockPanel>d__;
		<CreateCannotStartLockPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateCannotStartLockPanel>d__.<>4__this = this;
		<CreateCannotStartLockPanel>d__.<>1__state = -1;
		<CreateCannotStartLockPanel>d__.<>t__builder.Start<RoleTowerPrepareBottomPanel.<CreateCannotStartLockPanel>d__20>(ref <CreateCannotStartLockPanel>d__);
		return <CreateCannotStartLockPanel>d__.<>t__builder.Task;
	}

	// Token: 0x060124DB RID: 74971 RVA: 0x00565D14 File Offset: 0x00563F14
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private UniTask<RoleTowerRoleAvatarItem> CreateAvatar(int childIdx, ERoleTowerSlotType slot)
	{
		RoleTowerPrepareBottomPanel.<CreateAvatar>d__21 <CreateAvatar>d__;
		<CreateAvatar>d__.<>t__builder = AsyncUniTaskMethodBuilder<RoleTowerRoleAvatarItem>.Create();
		<CreateAvatar>d__.<>4__this = this;
		<CreateAvatar>d__.childIdx = childIdx;
		<CreateAvatar>d__.slot = slot;
		<CreateAvatar>d__.<>1__state = -1;
		<CreateAvatar>d__.<>t__builder.Start<RoleTowerPrepareBottomPanel.<CreateAvatar>d__21>(ref <CreateAvatar>d__);
		return <CreateAvatar>d__.<>t__builder.Task;
	}

	// Token: 0x060124DC RID: 74972 RVA: 0x00565D68 File Offset: 0x00563F68
	public void Refresh(int stageId, bool isInPrepare = false, bool isCheckPoint = false)
	{
		this.CurStageId = stageId;
		this.CurInPrepare = isInPrepare;
		this.CurIsCheckPoint = isCheckPoint;
		int challengeFatigueCost = this.GetChallengeFatigueCost();
		this.RefreshAvatars(challengeFatigueCost);
		this.RefreshToken(stageId);
		this.RefreshStartBtn(stageId, challengeFatigueCost);
		this.RefreshMultiModuleBtn();
	}

	// Token: 0x060124DD RID: 74973 RVA: 0x00565DB0 File Offset: 0x00563FB0
	[NullableContext(1)]
	private List<int> GetTeamRoleIdList()
	{
		List<int> list = new List<int>();
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				list.Add(slotRoleId);
			}
		}
		return list;
	}

	// Token: 0x060124DE RID: 74974 RVA: 0x00565E00 File Offset: 0x00564000
	private void RefreshMultiModuleBtn()
	{
		bool uiactive = this.GetTeamRoleIdList().Exists((int roleId) => RoleModel.Instance.IsRoleHasBranch(roleId));
		UUIButtonComponent button = base.GetButton(9);
		if (button == null)
		{
			return;
		}
		UUIItem uuiitem = button.RootUIComp.Get();
		if (uuiitem == null)
		{
			return;
		}
		uuiitem.SetUIActive(uiactive);
	}

	// Token: 0x060124DF RID: 74975 RVA: 0x00565E60 File Offset: 0x00564060
	private void OnClickMultiModule()
	{
		List<int> teamRoleIdList = this.GetTeamRoleIdList();
		if (teamRoleIdList.Count == 0)
		{
			return;
		}
		RoleModel.Instance.StartGamePlayRoleEdit(ESkillBranchCacheType.Mowing);
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = new RoleSkillBranchPopViewParams();
		roleSkillBranchPopViewParams.Load(new int[][]
		{
			teamRoleIdList.ToArray()
		});
		UiManager.Instance.OpenView(EUiViewName.RoleSkillBranchPopView, roleSkillBranchPopViewParams, null);
	}

	// Token: 0x060124E0 RID: 74976 RVA: 0x00565EB4 File Offset: 0x005640B4
	private void OnRoleSkillBranchChanged(int roleId)
	{
		this.RefreshAvatars(this.GetChallengeFatigueCost());
	}

	// Token: 0x060124E1 RID: 74977 RVA: 0x00565EC4 File Offset: 0x005640C4
	private void RefreshAvatars(int fatigueCost)
	{
		RoleTowerSaveData curChallengeSave = RoleTowerModel.Instance.GetCurChallengeSave();
		bool hasSave = curChallengeSave != null;
		RoleTowerRoleAvatarItem mainAvatar = this.MainAvatar;
		if (mainAvatar != null)
		{
			mainAvatar.Refresh(this.BuildMainData(curChallengeSave, hasSave, fatigueCost));
		}
		RoleTowerRoleAvatarItem assist1Avatar = this.Assist1Avatar;
		if (assist1Avatar != null)
		{
			assist1Avatar.Refresh(this.BuildAssistData(ERoleTowerSlotType.Assist1, curChallengeSave, hasSave, fatigueCost));
		}
		RoleTowerRoleAvatarItem assist2Avatar = this.Assist2Avatar;
		if (assist2Avatar == null)
		{
			return;
		}
		assist2Avatar.Refresh(this.BuildAssistData(ERoleTowerSlotType.Assist2, curChallengeSave, hasSave, fatigueCost));
	}

	// Token: 0x060124E2 RID: 74978 RVA: 0x00565F30 File Offset: 0x00564130
	[NullableContext(1)]
	private RoleTowerRoleAvatarData BuildMainData([Nullable(2)] RoleTowerSaveData save, bool hasSave, int fatigueCost)
	{
		int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Main);
		bool slotIsTrial = RoleTowerModel.Instance.GetSlotIsTrial(ERoleTowerSlotType.Main);
		return new RoleTowerRoleAvatarData
		{
			Slot = ERoleTowerSlotType.Main,
			RoleId = slotRoleId,
			IsTrial = slotIsTrial,
			Fatigue = 0,
			FatigueCost = fatigueCost,
			IsEquipLocked = (!slotIsTrial && RoleTowerModel.Instance.IsRoleEquipLocked(slotRoleId))
		};
	}

	// Token: 0x060124E3 RID: 74979 RVA: 0x00565F94 File Offset: 0x00564194
	[NullableContext(1)]
	private RoleTowerRoleAvatarData BuildAssistData(ERoleTowerSlotType slot, [Nullable(2)] RoleTowerSaveData save, bool hasSave, int fatigueCost)
	{
		int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(slot);
		bool slotIsTrial = RoleTowerModel.Instance.GetSlotIsTrial(slot);
		int fatigue = (slotRoleId > 0) ? RoleTowerModel.Instance.GetRoleFatigue(slotRoleId) : 0;
		if (slotRoleId == 0 && hasSave)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.Bottom 协战取存档(TODO 存档协战字段未定)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("slot", slot);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return new RoleTowerRoleAvatarData
		{
			Slot = slot,
			RoleId = slotRoleId,
			IsTrial = slotIsTrial,
			Fatigue = fatigue,
			FatigueCost = fatigueCost,
			IsEquipLocked = (!slotIsTrial && RoleTowerModel.Instance.IsRoleEquipLocked(slotRoleId))
		};
	}

	// Token: 0x060124E4 RID: 74980 RVA: 0x00566040 File Offset: 0x00564240
	private void RefreshToken(int stageId)
	{
		int num = RoleTowerModel.Instance.GetEquipTokenId();
		if (this.CurInPrepare && num > 0 && RoleTowerModel.Instance.GetTokenCount(num) <= 0)
		{
			RoleTowerModel.Instance.SetEquipToken(0);
			num = 0;
		}
		RoleTowerPrepareTokenItem tokenItem = this.TokenItem;
		if (tokenItem == null)
		{
			return;
		}
		tokenItem.Refresh(num);
	}

	// Token: 0x060124E5 RID: 74981 RVA: 0x00566090 File Offset: 0x00564290
	private void RefreshStartBtn(int stageId, int fatigueCost)
	{
		ERoleTowerStartBtnState eroleTowerStartBtnState = this.CalcStartBtnState(stageId);
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(fatigueCost.ToString(), true);
		}
		bool flag = eroleTowerStartBtnState == ERoleTowerStartBtnState.Challenge || eroleTowerStartBtnState == ERoleTowerStartBtnState.SelectEnemy;
		bool uiactive = eroleTowerStartBtnState == ERoleTowerStartBtnState.Finished;
		bool flag2 = eroleTowerStartBtnState == ERoleTowerStartBtnState.NeedPrevious;
		bool flag3 = flag && RoleTowerModel.Instance.IsTeamEquipLocked();
		bool flag4 = (flag && !flag3) || flag2;
		UUIButtonComponent button = base.GetButton(6);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(flag4);
			}
		}
		UUIInteractionGroup startBtnInteraction = this.StartBtnInteraction;
		if (startBtnInteraction != null)
		{
			startBtnInteraction.SetInteractable(flag && !this.IsStartingChallenge);
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(flag3);
		}
		if (flag3)
		{
			FunctionalPanelConditionLock cannotStartLockPanel = this.CannotStartLockPanel;
			if (cannotStartLockPanel != null)
			{
				cannotStartLockPanel.SetTextByTextId("RoleTowerWeaponEchoLockTips", Array.Empty<string>());
			}
		}
		if (flag4)
		{
			this.SetStartBtnText(eroleTowerStartBtnState, stageId);
		}
		UUIItem item3 = base.GetItem(11);
		if (item3 == null)
		{
			return;
		}
		item3.SetUIActive(flag4 && fatigueCost > 0);
	}

	// Token: 0x060124E6 RID: 74982 RVA: 0x005661AC File Offset: 0x005643AC
	private ERoleTowerStartBtnState CalcStartBtnState(int stageId)
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int challengeableStageId = RoleTowerModel.Instance.GetChallengeableStageId(curSelectLevel);
		if (stageId == challengeableStageId)
		{
			if (!this.HasBranchWave(stageId))
			{
				return ERoleTowerStartBtnState.Challenge;
			}
			return ERoleTowerStartBtnState.SelectEnemy;
		}
		else
		{
			int stageSeqById = RoleTowerModel.Instance.GetStageSeqById(stageId);
			int stageSeqById2 = RoleTowerModel.Instance.GetStageSeqById(challengeableStageId);
			if (stageSeqById >= stageSeqById2)
			{
				return ERoleTowerStartBtnState.NeedPrevious;
			}
			return ERoleTowerStartBtnState.Finished;
		}
	}

	// Token: 0x060124E7 RID: 74983 RVA: 0x00566200 File Offset: 0x00564400
	private void SetStartBtnText(ERoleTowerStartBtnState state, int stageId)
	{
		UUIText text = base.GetText(10);
		if (text == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.Bottom 开始按钮文本节点未找到(idx10 BtnConfirmText 未绑定，检查预制体)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("state", state);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		switch (state)
		{
		case ERoleTowerStartBtnState.Challenge:
			LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerLevelMain_01", new <>z__ReadOnlySingleElementList<object>(this.GetStageName(stageId)));
			return;
		case ERoleTowerStartBtnState.SelectEnemy:
			LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerLevelMain_02", Array.Empty<object>());
			return;
		case ERoleTowerStartBtnState.Finished:
			break;
		case ERoleTowerStartBtnState.NeedPrevious:
			LguiUtil.Instance.SetLocalTextNew(text, "RoleTowerNeedPreviousFloor", Array.Empty<object>());
			break;
		default:
			return;
		}
	}

	// Token: 0x060124E8 RID: 74984 RVA: 0x005662A3 File Offset: 0x005644A3
	private void OnClickToken()
	{
		RoleTowerModel.Instance.OpenTokenEquipView(this.GetStageEntryFloorId(this.CurStageId));
	}

	// Token: 0x060124E9 RID: 74985 RVA: 0x005662BC File Offset: 0x005644BC
	private void OnClickStart()
	{
		if (this.IsStartingChallenge || base.IsDestroyOrDestroying)
		{
			return;
		}
		int curStageId = this.CurStageId;
		ERoleTowerStartBtnState state = this.CalcStartBtnState(curStageId);
		switch (state)
		{
		case ERoleTowerStartBtnState.Challenge:
		case ERoleTowerStartBtnState.SelectEnemy:
			this.TryStartChallenge(curStageId, state);
			return;
		case ERoleTowerStartBtnState.Finished:
			return;
		case ERoleTowerStartBtnState.NeedPrevious:
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerNeedPreviousFloor", Array.Empty<object>());
			return;
		default:
			return;
		}
	}

	// Token: 0x060124EA RID: 74986 RVA: 0x00566320 File Offset: 0x00564520
	private void TryStartChallenge(int stageId, ERoleTowerStartBtnState state)
	{
		if (!this.IsTeamFull())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerTeamNotFull", Array.Empty<object>());
			return;
		}
		if (!this.IsFatigueEnough())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerFatigueNotEnough", Array.Empty<object>());
			return;
		}
		if (RoleTowerModel.Instance.IsTeamEquipLocked())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerEquipLocked", Array.Empty<object>());
			return;
		}
		if (!this.HasCarriedToken() && this.HasAvailableToken() && !RoleTowerPrepareBottomPanel._tokenConfirmSkippedThisLogin)
		{
			this.ShowNoTokenConfirm(stageId, state);
			return;
		}
		this.DoStartChallenge(stageId, state);
	}

	// Token: 0x060124EB RID: 74987 RVA: 0x005663B0 File Offset: 0x005645B0
	private void ShowNoTokenConfirm(int stageId, ERoleTowerStartBtnState state)
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleTowerNoTokenConfirm);
		bool notRemind = false;
		confirmBoxDataNew.HasToggle = true;
		confirmBoxDataNew.SetToggleFunction(delegate(bool isOn)
		{
			notRemind = isOn;
		});
		confirmBoxDataNew.FunctionMap[2] = delegate()
		{
			RoleTowerPrepareBottomPanel._tokenConfirmSkippedThisLogin = notRemind;
			this.DoStartChallenge(stageId, state);
		};
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x060124EC RID: 74988 RVA: 0x00566428 File Offset: 0x00564628
	private unsafe void DoStartChallenge(int stageId, ERoleTowerStartBtnState state)
	{
		int levelId = RoleTowerModel.Instance.CurSelectLevel;
		bool isContinue = RoleTowerModel.Instance.GetCurChallengeSave() != null;
		if (state == ERoleTowerStartBtnState.SelectEnemy)
		{
			RoleTowerModel.Instance.OpenMonsterSelectView(stageId, delegate(int branchId)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "RoleTower.Bottom 强敌已选→开始阶段";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("stageId", stageId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("branchId", branchId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("inPrepare", this.CurInPrepare);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.StartOrAdvance(levelId, isContinue);
			});
			return;
		}
		this.StartOrAdvance(levelId, isContinue);
	}

	// Token: 0x060124ED RID: 74989 RVA: 0x005664A0 File Offset: 0x005646A0
	private void StartOrAdvance(int levelId, bool isContinue)
	{
		if (this.IsStartingChallenge || base.IsDestroyOrDestroying)
		{
			return;
		}
		if (this.CurIsCheckPoint)
		{
			this.AdvancePrepareAndClose(true).Forget();
			return;
		}
		if (this.CurInPrepare)
		{
			this.AdvancePrepareAndClose(false).Forget();
			return;
		}
		RoleTowerModel.Instance.EnterDungeon(levelId, isContinue);
	}

	// Token: 0x060124EE RID: 74990 RVA: 0x005664F4 File Offset: 0x005646F4
	private UniTask AdvancePrepareAndClose(bool isCheckPoint = false)
	{
		RoleTowerPrepareBottomPanel.<AdvancePrepareAndClose>d__40 <AdvancePrepareAndClose>d__;
		<AdvancePrepareAndClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<AdvancePrepareAndClose>d__.<>4__this = this;
		<AdvancePrepareAndClose>d__.isCheckPoint = isCheckPoint;
		<AdvancePrepareAndClose>d__.<>1__state = -1;
		<AdvancePrepareAndClose>d__.<>t__builder.Start<RoleTowerPrepareBottomPanel.<AdvancePrepareAndClose>d__40>(ref <AdvancePrepareAndClose>d__);
		return <AdvancePrepareAndClose>d__.<>t__builder.Task;
	}

	// Token: 0x060124EF RID: 74991 RVA: 0x0056653F File Offset: 0x0056473F
	private bool IsTeamFull()
	{
		return RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Main) > 0 && RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Assist1) > 0 && RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Assist2) > 0;
	}

	// Token: 0x060124F0 RID: 74992 RVA: 0x00566570 File Offset: 0x00564770
	private bool IsFatigueEnough()
	{
		int challengeFatigueCost = this.GetChallengeFatigueCost();
		if (challengeFatigueCost <= 0)
		{
			return true;
		}
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(slot);
			if (slotRoleId > 0 && RoleTowerModel.Instance.GetRoleFatigue(slotRoleId) < challengeFatigueCost)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060124F1 RID: 74993 RVA: 0x005665CF File Offset: 0x005647CF
	private bool HasCarriedToken()
	{
		return RoleTowerModel.Instance.GetEquipTokenId() > 0;
	}

	// Token: 0x060124F2 RID: 74994 RVA: 0x005665DE File Offset: 0x005647DE
	private bool HasAvailableToken()
	{
		return RoleTowerModel.Instance.HasAnyEquippableToken();
	}

	// Token: 0x060124F3 RID: 74995 RVA: 0x005665EA File Offset: 0x005647EA
	private int GetStageFatigueCost(int stageId)
	{
		return RoleTowerModel.Instance.GetStageFatigueCost(stageId);
	}

	// Token: 0x060124F4 RID: 74996 RVA: 0x005665F8 File Offset: 0x005647F8
	private int GetChallengeFatigueCost()
	{
		int challengeableStageId = RoleTowerModel.Instance.GetChallengeableStageId(RoleTowerModel.Instance.CurSelectLevel);
		return this.GetStageFatigueCost(challengeableStageId);
	}

	// Token: 0x060124F5 RID: 74997 RVA: 0x00566624 File Offset: 0x00564824
	private bool HasBranchWave(int stageId)
	{
		if (this.CurIsCheckPoint)
		{
			return RoleTowerModel.Instance.NeedBranchSelectForRetry();
		}
		if (this.CurInPrepare)
		{
			return RoleTowerModel.Instance.NeedBranchSelectInPrepare();
		}
		return RoleTowerModel.Instance.GetCurChallengeSave() != null && RoleTowerModel.Instance.GetStageBranchOptionsByCfg(RoleTowerModel.Instance.CurSelectLevel, stageId).Count > 0;
	}

	// Token: 0x060124F6 RID: 74998 RVA: 0x00566684 File Offset: 0x00564884
	[NullableContext(1)]
	private string GetStageName(int stageId)
	{
		RoleTowerStage? stageCfg = RoleTowerModel.Instance.GetStageCfg(stageId);
		if (stageCfg == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(stageCfg.Value.RoleTowerStageName, null) ?? "";
	}

	// Token: 0x060124F7 RID: 74999 RVA: 0x005666CC File Offset: 0x005648CC
	private int GetStageEntryFloorId(int stageId)
	{
		int curSelectLevel = RoleTowerModel.Instance.CurSelectLevel;
		int stageSeqById = RoleTowerModel.Instance.GetStageSeqById(stageId);
		IReadOnlyList<RoleTowerFloor> floorCfgListByStage = RoleTowerModel.Instance.GetFloorCfgListByStage(curSelectLevel, stageSeqById);
		if (floorCfgListByStage.Count == 0)
		{
			return 0;
		}
		foreach (RoleTowerFloor roleTowerFloor in floorCfgListByStage)
		{
			RoleTowerFloorData floorState = RoleTowerModel.Instance.GetFloorState(roleTowerFloor.Id);
			if (floorState != null && floorState.IsCurrent)
			{
				return roleTowerFloor.Id;
			}
		}
		return floorCfgListByStage[0].Id;
	}

	// Token: 0x04009FAA RID: 40874
	private static bool _tokenConfirmSkippedThisLogin;

	// Token: 0x04009FAB RID: 40875
	private int CurStageId;

	// Token: 0x04009FAC RID: 40876
	private bool CurInPrepare;

	// Token: 0x04009FAD RID: 40877
	private bool CurIsCheckPoint;

	// Token: 0x04009FAE RID: 40878
	private bool IsStartingChallenge;

	// Token: 0x04009FAF RID: 40879
	private RoleTowerRoleAvatarItem MainAvatar;

	// Token: 0x04009FB0 RID: 40880
	private RoleTowerRoleAvatarItem Assist1Avatar;

	// Token: 0x04009FB1 RID: 40881
	private RoleTowerRoleAvatarItem Assist2Avatar;

	// Token: 0x04009FB2 RID: 40882
	private RoleTowerPrepareTokenItem TokenItem;

	// Token: 0x04009FB3 RID: 40883
	private UUIInteractionGroup StartBtnInteraction;

	// Token: 0x04009FB4 RID: 40884
	private FunctionalPanelConditionLock CannotStartLockPanel;

	// Token: 0x02007FE1 RID: 32737
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040295ED RID: 169453
		public const int UiItemRoleAvatar1 = 0;

		// Token: 0x040295EE RID: 169454
		public const int UiItemRoleAvatar2 = 1;

		// Token: 0x040295EF RID: 169455
		public const int UiItemRoleAvatar3 = 2;

		// Token: 0x040295F0 RID: 169456
		public const int TxtBuffTitle = 3;

		// Token: 0x040295F1 RID: 169457
		public const int UiItemBuffItem = 4;

		// Token: 0x040295F2 RID: 169458
		public const int TxtNum = 5;

		// Token: 0x040295F3 RID: 169459
		public const int BtnConfirmStar = 6;

		// Token: 0x040295F4 RID: 169460
		public const int PnlCannotStartActivate = 7;

		// Token: 0x040295F5 RID: 169461
		public const int PnlCannotStartLock = 8;

		// Token: 0x040295F6 RID: 169462
		public const int BtnMultiModule = 9;

		// Token: 0x040295F7 RID: 169463
		public const int BtnConfirmText = 10;

		// Token: 0x040295F8 RID: 169464
		public const int BtnConfirmCostPnl = 11;
	}
}
