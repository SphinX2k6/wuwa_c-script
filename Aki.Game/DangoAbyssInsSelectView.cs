using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EFD RID: 3837
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssInsSelectView : UiViewBase
{
	// Token: 0x06009991 RID: 39313 RVA: 0x002D7F24 File Offset: 0x002D6124
	[NullableContext(1)]
	public DangoAbyssInsSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009992 RID: 39314 RVA: 0x002D7F30 File Offset: 0x002D6130
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUITexture)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(17, typeof(UUIItem)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIItem)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem)),
			new ValueTuple<int, Type>(23, typeof(UUIItem)),
			new ValueTuple<int, Type>(24, typeof(UUIItem)),
			new ValueTuple<int, Type>(25, typeof(UUIItem)),
			new ValueTuple<int, Type>(26, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(27, typeof(UUIItem)),
			new ValueTuple<int, Type>(28, typeof(UUIItem)),
			new ValueTuple<int, Type>(29, typeof(UUIItem)),
			new ValueTuple<int, Type>(30, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnBtnBackClick)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnBtnNextClick))
		};
	}

	// Token: 0x06009993 RID: 39315 RVA: 0x002D825C File Offset: 0x002D645C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Add(EEventName.OnAbyssUnlockChallengeStateUpdate, new Action(this.OnAbyssUnlockChallengeStateUpdate));
	}

	// Token: 0x06009994 RID: 39316 RVA: 0x002D82C0 File Offset: 0x002D64C0
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Remove(EEventName.OnAbyssUnlockChallengeStateUpdate, new Action(this.OnAbyssUnlockChallengeStateUpdate));
	}

	// Token: 0x06009995 RID: 39317 RVA: 0x002D8324 File Offset: 0x002D6524
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssInsSelectView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssInsSelectView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009996 RID: 39318 RVA: 0x002D8368 File Offset: 0x002D6568
	private void OnConfirmB2tnClick(int _)
	{
		if (!DangoAbyssModel.Instance.GetAbyssUnLockState(this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AbyssUnlockTip);
			Dictionary<int, int> dictionary = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.ConsumeItem();
			if (dictionary.Count > 0)
			{
				int key = new List<int>(dictionary.Keys)[0];
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					dictionary[key].ToString()
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					DangoAbyssController.Instance.RequestChallengeUnlock(this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
		}
		else
		{
			int id = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id;
			int instId = this.ViewData.ActivityData.GetAbyssChallengeDataById(id).GetConfig().Value.InstId;
			InstOnlineType onlineType = InstanceDungeonConfig.Instance.GetConfig(instId).Value.OnlineType;
			if (!GameModeModel.Instance.IsMulti || onlineType == InstOnlineType.Single)
			{
				this.OnClickSingle();
				return;
			}
			this.OnClickMultiple();
		}
	}

	// Token: 0x06009997 RID: 39319 RVA: 0x002D84D4 File Offset: 0x002D66D4
	private void OnConfirm1BtnClick(int _)
	{
		if (!DangoAbyssModel.Instance.GetAbyssUnLockState(this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AbyssUnlockTip);
			Dictionary<int, int> dictionary = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.ConsumeItem();
			if (dictionary.Count > 0)
			{
				int key = new List<int>(dictionary.Keys)[0];
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					dictionary[key].ToString()
				});
				confirmBoxDataNew.FunctionMap.Add(2, delegate
				{
					DangoAbyssController.Instance.RequestChallengeUnlock(this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id);
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
		}
		else
		{
			this.OnClickMatch();
		}
	}

	// Token: 0x06009998 RID: 39320 RVA: 0x002D85B4 File Offset: 0x002D67B4
	private void OnClickMatch()
	{
		if (!OnlineController.Instance.ShowTipsWhenOnlineDisabled(new EDisableOnlineType[]
		{
			EDisableOnlineType.TrialRole
		}))
		{
			return;
		}
		AbyssInst value = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value;
		int challengeId = value.InstId;
		int instEntranceId = value.InstEntranceId;
		InstanceDungeonEntranceModel.Instance.EntranceId = instEntranceId;
		BattleTeamModel.Instance.Context.SetMultiEntry(true);
		this.MatchingCountDownItem.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
		if (!FunctionModel.Instance.IsOpen(10021))
		{
			ScrollingTipsController.Instance.ShowTipsById("IsNotOpenOnline", Array.Empty<object>());
			return;
		}
		if (InstanceDungeonController.Instance.IsForbidDungeon(challengeId))
		{
			ScrollingTipsController.Instance.ShowTipsById("PhantomFormationEnterInstanceTip", Array.Empty<object>());
			return;
		}
		if (!GameModeModel.Instance.IsMulti)
		{
			InstanceDungeonEntranceController.Instance.StartMatchRequest(challengeId, false, true);
			return;
		}
		int currentTeamSize = OnlineModel.Instance.GetCurrentTeamSize();
		if (currentTeamSize <= 1)
		{
			InstanceDungeonEntranceController.Instance.StartMatchRequest(challengeId, false, true);
			return;
		}
		if (currentTeamSize < OnlineModel.Instance.TeamMaxSize)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceDungeonMatchStart);
			Action value2 = delegate()
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(challengeId, true, true);
			};
			Action value3 = delegate()
			{
				InstanceDungeonEntranceController.Instance.StartMatchRequest(challengeId, false, true);
			};
			confirmBoxDataNew.IsEscViewTriggerCallBack = false;
			confirmBoxDataNew.FunctionMap.Add(2, value2);
			confirmBoxDataNew.FunctionMap.Add(1, value3);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("CanNotMatching", Array.Empty<object>());
	}

	// Token: 0x06009999 RID: 39321 RVA: 0x002D876C File Offset: 0x002D696C
	private void OnClickSingle()
	{
		BattleTeamModel.Instance.Context.SetMultiEntry(false);
		int id = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id;
		DangoAbyssModel.Instance.CurrentSelectEntranceId = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.InstEntranceId;
		DangoAbyssModel.Instance.CurrentSelectChallengeId = id;
		DangoAbyssController.Instance.StartAbyssChallenge(id);
	}

	// Token: 0x0600999A RID: 39322 RVA: 0x002D87F8 File Offset: 0x002D69F8
	private void OnClickMultiple()
	{
		AbyssInst value = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value;
		int challengeId = value.InstId;
		int instEntranceId = value.InstEntranceId;
		InstanceDungeonEntranceModel.Instance.EntranceId = instEntranceId;
		if (!GameModeModel.Instance.IsMulti)
		{
			Log.Instance.Error(ELogModule.InstanceDungeon, ELogAuthor.YZY, "非联机下无法进行组队挑战，请联系程序查BUG", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		BattleTeamModel.Instance.Context.SetMultiEntry(true);
		InstanceDungeonEntranceModel.Instance.SetMatchingId(challengeId);
		if (OnlineModel.Instance.GetCurrentTeamSize() <= 1)
		{
			InstanceDungeonEntranceController.Instance.TeamChallengeRequest(challengeId, false);
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.InstanceDungeonMultiStart);
		Action value2 = delegate()
		{
			InstanceDungeonEntranceController.Instance.TeamChallengeRequest(challengeId, true);
		};
		Action value3 = delegate()
		{
			InstanceDungeonEntranceController.Instance.TeamChallengeRequest(challengeId, false);
		};
		confirmBoxDataNew.IsEscViewTriggerCallBack = false;
		confirmBoxDataNew.FunctionMap.Add(2, value2);
		confirmBoxDataNew.FunctionMap.Add(1, value3);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600999B RID: 39323 RVA: 0x002D890C File Offset: 0x002D6B0C
	protected override void OnAfterShow()
	{
		this.MatchingCountDownItem.BindOnClickBtnCancelMatching(delegate
		{
			InstanceDungeonEntranceController.Instance.CancelMatchRequest();
		});
		this.MatchingCountDownItem.BindOnAfterCloseAnimation(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetMatchingItemActive(false);
			}
		});
		if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
		{
			this.SetMatchingItemActive(true);
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem != null)
			{
				matchingCountDownItem.PlayAnimation("Start");
			}
			this.MatchingCountDownItem.StartTimer();
		}
	}

	// Token: 0x0600999C RID: 39324 RVA: 0x002D8990 File Offset: 0x002D6B90
	public void RefreshRedDot()
	{
		AbyssButtonItem limitRewardBtnItem = this.LimitRewardBtnItem;
		if (limitRewardBtnItem != null)
		{
			ERedDotName redDotName = ERedDotName.RedDotDangoLimitReward;
			DangoAbyssInsSelectViewData viewData = this.ViewData;
			int? uId;
			if (viewData == null)
			{
				uId = null;
			}
			else
			{
				DangoAbyssActivityData activityData = viewData.ActivityData;
				uId = ((activityData != null) ? new int?(activityData.Id) : null);
			}
			limitRewardBtnItem.BindRedDot(redDotName, uId);
		}
		AbyssButtonItem activityRewardBtnItem = this.ActivityRewardBtnItem;
		if (activityRewardBtnItem != null)
		{
			ERedDotName redDotName2 = ERedDotName.RedDotDangoCommonReward;
			DangoAbyssInsSelectViewData viewData2 = this.ViewData;
			int? uId2;
			if (viewData2 == null)
			{
				uId2 = null;
			}
			else
			{
				DangoAbyssActivityData activityData2 = viewData2.ActivityData;
				uId2 = ((activityData2 != null) ? new int?(activityData2.Id) : null);
			}
			activityRewardBtnItem.BindRedDot(redDotName2, uId2);
		}
		AbyssButtonItem friendRankBtnItem = this.FriendRankBtnItem;
		if (friendRankBtnItem == null)
		{
			return;
		}
		friendRankBtnItem.SetRedDotVisible(false);
	}

	// Token: 0x0600999D RID: 39325 RVA: 0x002D8A40 File Offset: 0x002D6C40
	private void UnbindRedDot()
	{
		AbyssButtonItem limitRewardBtnItem = this.LimitRewardBtnItem;
		if (limitRewardBtnItem != null)
		{
			limitRewardBtnItem.UnBindRedDot();
		}
		AbyssButtonItem activityRewardBtnItem = this.ActivityRewardBtnItem;
		if (activityRewardBtnItem == null)
		{
			return;
		}
		activityRewardBtnItem.UnBindRedDot();
	}

	// Token: 0x0600999E RID: 39326 RVA: 0x002D8A63 File Offset: 0x002D6C63
	[NullableContext(1)]
	private DangoScrollItem InitItem()
	{
		return new DangoScrollItem();
	}

	// Token: 0x0600999F RID: 39327 RVA: 0x002D8A6A File Offset: 0x002D6C6A
	[NullableContext(1)]
	public CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x060099A0 RID: 39328 RVA: 0x002D8A71 File Offset: 0x002D6C71
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x060099A1 RID: 39329 RVA: 0x002D8A7C File Offset: 0x002D6C7C
	private void OnBtnBackClick()
	{
		base.PlaySequence("PreLeft", null, false);
		this.CurrentSelectedIndex--;
		this.RefreshView();
		if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Default)
		{
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem != null)
			{
				matchingCountDownItem.PlayAnimation("Close");
			}
			InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
			if (matchingCountDownItem2 == null)
			{
				return;
			}
			matchingCountDownItem2.SetUiActive(false);
		}
	}

	// Token: 0x060099A2 RID: 39330 RVA: 0x002D8AE0 File Offset: 0x002D6CE0
	private void OnBtnNextClick()
	{
		base.PlaySequence("PreRight", null, false);
		this.CurrentSelectedIndex++;
		this.RefreshView();
		if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Default)
		{
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem != null)
			{
				matchingCountDownItem.PlayAnimation("Close");
			}
			InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
			if (matchingCountDownItem2 == null)
			{
				return;
			}
			matchingCountDownItem2.SetUiActive(false);
		}
	}

	// Token: 0x060099A3 RID: 39331 RVA: 0x002D8B44 File Offset: 0x002D6D44
	protected override void OnBeforeShow()
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem != null)
		{
			dangoWorldQuestItem.Refresh();
		}
		DangoAbyssModel.Instance.SetInAbyssFlow(false);
		UiCameraModel.Instance.PushCameraHandleByHandleName("DangoAbyssLoop2", true, true, "1001", false, null);
		DangoAbyssModel.Instance.SetInAbyssFlow(false);
		this.RefreshView();
		this.RefreshRedDot();
	}

	// Token: 0x060099A4 RID: 39332 RVA: 0x002D8B9D File Offset: 0x002D6D9D
	protected override void OnBeforeHide()
	{
		this.UnbindRedDot();
	}

	// Token: 0x060099A5 RID: 39333 RVA: 0x002D8BA8 File Offset: 0x002D6DA8
	private void RefreshView()
	{
		int id = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id;
		this.RefreshTitleByChallengeId(id);
		this.RefreshSubTitleByChallengeId(id);
		this.RefreshDescByChallengeId(id);
		this.RefreshDangoRewardByChallengeId(id);
		this.RefreshRewardItemLayout(id);
		this.RefreshConsumeInfoByChallengeId(id);
		this.RefreshButtonVisible(id);
		this.RefreshButtonRedDot(id);
		this.RefreshInActiveItemVisible(id);
		this.RefreshUnlockDescription(id);
		this.RefreshRankItemShowState(id);
		this.RefreshChangeIndexBtnVisible(this.ViewData);
		this.RefreshLimitItemShowState(this.ViewData);
		this.RefreshRewardProgressText(this.ViewData);
		this.RefreshGoalLayout();
		this.RefreshInsNameText(id);
		this.RefreshSceneNiagaraByCurrentChallenge(id);
		this.RefreshMaxProgressByChallengeId(id);
	}

	// Token: 0x060099A6 RID: 39334 RVA: 0x002D8C6C File Offset: 0x002D6E6C
	private void RefreshInsNameText(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.Title, Array.Empty<object>());
		}
	}

	// Token: 0x060099A7 RID: 39335 RVA: 0x002D8CC0 File Offset: 0x002D6EC0
	private void RefreshSceneNiagaraByCurrentChallenge(int challengeId)
	{
		AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("shenyuan").Value, ECollectActorType.UI);
		if (actorWithTag != null && actorWithTag.IsValid())
		{
			if (challengeId == 0)
			{
				return;
			}
			FColor fcolor = FColor.FromHex(DangoAbyssConfig.Instance.GetDangoAbyssInstById(challengeId).Value.AbyssColor);
			FLinearColor flinearColor = FLinearColor.FromSRGBColor(fcolor);
			UNiagaraComponent uniagaraComponent = actorWithTag.GetComponentByClass(UNiagaraComponent.StaticClass()) as UNiagaraComponent;
			if (uniagaraComponent == null)
			{
				return;
			}
			uniagaraComponent.SetNiagaraVariableLinearColor("Color", flinearColor);
		}
	}

	// Token: 0x060099A8 RID: 39336 RVA: 0x002D8D4C File Offset: 0x002D6F4C
	private void RefreshRankItemShowState(int challengeId)
	{
		bool rankOpen = DangoAbyssModel.Instance.GetRankOpen();
		AbyssButtonItem friendRankBtnItem = this.FriendRankBtnItem;
		if (friendRankBtnItem == null)
		{
			return;
		}
		friendRankBtnItem.SetActive(rankOpen);
	}

	// Token: 0x060099A9 RID: 39337 RVA: 0x002D8D78 File Offset: 0x002D6F78
	[NullableContext(1)]
	private void RefreshLimitItemShowState(DangoAbyssInsSelectViewData data)
	{
		DangoAbyssActivityData activityData = data.ActivityData;
		bool flag = activityData.CheckInLimitTime();
		base.GetItem(5).SetUIActive(flag);
		if (flag)
		{
			string remainTimeText = activityData.GetRemainTimeText();
			AbyssButtonItem limitRewardBtnItem = this.LimitRewardBtnItem;
			if (limitRewardBtnItem == null)
			{
				return;
			}
			limitRewardBtnItem.SetNumText(remainTimeText);
		}
	}

	// Token: 0x060099AA RID: 39338 RVA: 0x002D8DBC File Offset: 0x002D6FBC
	[NullableContext(1)]
	private void RefreshRewardProgressText(DangoAbyssInsSelectViewData data)
	{
		string rewardFinishProgressText = data.ActivityData.GetRewardFinishProgressText();
		AbyssButtonItem activityRewardBtnItem = this.ActivityRewardBtnItem;
		if (activityRewardBtnItem == null)
		{
			return;
		}
		activityRewardBtnItem.SetNumText(rewardFinishProgressText);
	}

	// Token: 0x060099AB RID: 39339 RVA: 0x002D8DE8 File Offset: 0x002D6FE8
	[NullableContext(1)]
	private void RefreshChangeIndexBtnVisible(DangoAbyssInsSelectViewData data)
	{
		bool uiactive = data.AbyssDataList.Length > 1;
		if (this.CurrentSelectedIndex == 0)
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
		}
		else
		{
			base.GetButton(2).RootUIComp.Get().SetUIActive(uiactive);
		}
		if (this.CurrentSelectedIndex == data.AbyssDataList.Length - 1)
		{
			base.GetButton(3).RootUIComp.Get().SetUIActive(false);
			return;
		}
		base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
	}

	// Token: 0x060099AC RID: 39340 RVA: 0x002D8E88 File Offset: 0x002D7088
	private void RefreshTitleByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), config.Value.Title, Array.Empty<object>());
		}
	}

	// Token: 0x060099AD RID: 39341 RVA: 0x002D8EDC File Offset: 0x002D70DC
	private void RefreshSubTitleByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), config.Value.SubTitle, Array.Empty<object>());
		}
	}

	// Token: 0x060099AE RID: 39342 RVA: 0x002D8F30 File Offset: 0x002D7130
	private void RefreshDescByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), config.Value.Desc, Array.Empty<object>());
		}
	}

	// Token: 0x060099AF RID: 39343 RVA: 0x002D8F84 File Offset: 0x002D7184
	private void RefreshDangoRewardByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			this.DangoRewardLayout.RefreshByData(config.Value.UnlockLittleRole(), null, false);
			base.GetItem(28).SetUIActive(config.Value.UnlockLittleRole().Length != 0);
		}
	}

	// Token: 0x060099B0 RID: 39344 RVA: 0x002D8FF0 File Offset: 0x002D71F0
	private void RefreshMaxProgressByChallengeId(int challengeId)
	{
		bool challengeButtonCanShow = this.GetChallengeButtonCanShow(challengeId);
		base.GetItem(29).SetUIActive(challengeButtonCanShow);
		if (challengeButtonCanShow)
		{
			int abyssMaxProgress = DangoAbyssModel.Instance.GetAbyssMaxProgress(challengeId);
			base.GetText(30).SetText(StringUtils.Format("{0}%", new string[]
			{
				abyssMaxProgress.ToString("F0")
			}), true);
		}
	}

	// Token: 0x060099B1 RID: 39345 RVA: 0x002D9050 File Offset: 0x002D7250
	private void RefreshRewardItemLayout(int challengeId)
	{
		TItem[] reward = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetReward();
		this.ItemLayout.RefreshByData(reward, null, false);
	}

	// Token: 0x060099B2 RID: 39346 RVA: 0x002D9084 File Offset: 0x002D7284
	private void RefreshConsumeInfoByChallengeId(int challengeId)
	{
		bool flag = !DangoAbyssModel.Instance.GetAbyssUnLockState(challengeId);
		base.GetItem(24).SetUIActive(flag);
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null && flag)
		{
			Dictionary<int, int> dictionary = config.Value.ConsumeItem();
			if (dictionary.Count > 0)
			{
				int num = new List<int>(dictionary.Keys)[0];
				int num2 = dictionary[num];
				base.SetTextureByPath(ItemConfig.Instance.GetConfig(num).Value.Icon, base.GetTexture(14), null, null);
				base.GetText(16).SetText(num2.ToString(), true);
			}
		}
	}

	// Token: 0x060099B3 RID: 39347 RVA: 0x002D9158 File Offset: 0x002D7358
	private bool GetChallengeButtonCanShow(int challengeId)
	{
		bool canChallenge = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetCanChallenge();
		bool abyssPreChallengeFinishState = DangoAbyssModel.Instance.GetAbyssPreChallengeFinishState(challengeId);
		bool abyssConditionFinishState = DangoAbyssModel.Instance.GetAbyssConditionFinishState(challengeId);
		bool abyssTimeLimitState = DangoAbyssModel.Instance.GetAbyssTimeLimitState(challengeId);
		return canChallenge && abyssPreChallengeFinishState && abyssConditionFinishState && abyssTimeLimitState;
	}

	// Token: 0x060099B4 RID: 39348 RVA: 0x002D91A8 File Offset: 0x002D73A8
	private void RefreshButtonVisible(int challengeId)
	{
		bool challengeButtonCanShow = this.GetChallengeButtonCanShow(challengeId);
		int instId = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig().Value.InstId;
		InstOnlineType onlineType = InstanceDungeonConfig.Instance.GetConfig(instId).Value.OnlineType;
		if (GameModeModel.Instance.IsMulti && !OnlineModel.Instance.GetIsMyTeam())
		{
			this.ConfirmBtn1.SetActive(false);
			this.ConfirmBtn2.SetActive(false);
			return;
		}
		bool flag = onlineType != InstOnlineType.Single && (onlineType != InstOnlineType.Multi || true);
		this.ConfirmBtn1.SetActive(flag && challengeButtonCanShow);
		this.ConfirmBtn2.SetActive(challengeButtonCanShow);
		if (onlineType == InstOnlineType.Mixture && GameModeModel.Instance.IsMulti)
		{
			ButtonItem confirmBtn = this.ConfirmBtn2;
			if (confirmBtn != null)
			{
				confirmBtn.SetLocalTextNew("AbyssMPChallenge", Array.Empty<object>());
			}
		}
		else
		{
			ButtonItem confirmBtn2 = this.ConfirmBtn2;
			if (confirmBtn2 != null)
			{
				confirmBtn2.SetLocalTextNew("AbyssSoloChallenge", Array.Empty<object>());
			}
		}
		bool p = flag && challengeButtonCanShow;
		EventSystem.Instance.Emit<bool>(EEventName.OnAbyssTeamBtnVisibleRefresh, p);
	}

	// Token: 0x060099B5 RID: 39349 RVA: 0x002D92C9 File Offset: 0x002D74C9
	private void RefreshButtonRedDot(int challengeId)
	{
		ButtonItem confirmBtn = this.ConfirmBtn1;
		if (confirmBtn != null)
		{
			confirmBtn.SetRedDotVisible(false);
		}
		ButtonItem confirmBtn2 = this.ConfirmBtn2;
		if (confirmBtn2 == null)
		{
			return;
		}
		confirmBtn2.SetRedDotVisible(false);
	}

	// Token: 0x060099B6 RID: 39350 RVA: 0x002D92F0 File Offset: 0x002D74F0
	private void RefreshInActiveItemVisible(int challengeId)
	{
		bool canChallenge = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetCanChallenge();
		bool abyssPreChallengeFinishState = DangoAbyssModel.Instance.GetAbyssPreChallengeFinishState(challengeId);
		bool abyssConditionFinishState = DangoAbyssModel.Instance.GetAbyssConditionFinishState(challengeId);
		bool abyssTimeLimitState = DangoAbyssModel.Instance.GetAbyssTimeLimitState(challengeId);
		FunctionalPanelConditionLock panelLock = this.PanelLock;
		if (panelLock == null)
		{
			return;
		}
		panelLock.SetActive(!canChallenge || !abyssTimeLimitState || !abyssPreChallengeFinishState || !abyssConditionFinishState);
	}

	// Token: 0x060099B7 RID: 39351 RVA: 0x002D9358 File Offset: 0x002D7558
	private void RefreshUnlockDescription(int challengeId)
	{
		if (DangoAbyssModel.Instance.GetAbyssPreChallengeFinishState(challengeId))
		{
			if (!DangoAbyssModel.Instance.GetAbyssConditionFinishState(challengeId))
			{
				AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
				if (config != null)
				{
					string unLockDesc = config.Value.UnLockDesc;
					if (unLockDesc != "")
					{
						FunctionalPanelConditionLock panelLock = this.PanelLock;
						if (panelLock == null)
						{
							return;
						}
						panelLock.SetTextByTextId(unLockDesc, Array.Empty<string>());
						return;
					}
				}
			}
			if (!DangoAbyssModel.Instance.GetAbyssTimeLimitState(challengeId))
			{
				string abyssUnlockTimeText = DangoAbyssModel.Instance.GetAbyssUnlockTimeText(challengeId);
				string textByText = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("AbyssUnlockTime", null), new string[]
				{
					abyssUnlockTimeText
				});
				FunctionalPanelConditionLock panelLock2 = this.PanelLock;
				if (panelLock2 == null)
				{
					return;
				}
				panelLock2.SetTextByText(textByText);
			}
			return;
		}
		FunctionalPanelConditionLock panelLock3 = this.PanelLock;
		if (panelLock3 == null)
		{
			return;
		}
		panelLock3.SetTextByTextId("AbyssNeedPreChallengeFinish", Array.Empty<string>());
	}

	// Token: 0x060099B8 RID: 39352 RVA: 0x002D9438 File Offset: 0x002D7638
	private void OnMatchingChange()
	{
		switch (InstanceDungeonEntranceModel.Instance.GetMatchingState())
		{
		case EInstanceMatchState.Default:
		{
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem == null)
			{
				return;
			}
			matchingCountDownItem.PlayAnimation("Close");
			return;
		}
		case EInstanceMatchState.Matching:
		{
			ScrollingTipsController.Instance.ShowTipsById("MatchingOtherCancel", Array.Empty<object>());
			InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
			if (matchingCountDownItem2 != null)
			{
				matchingCountDownItem2.PlayAnimation("Start");
			}
			this.SetMatchingItemActive(true);
			this.BeginMatching();
			return;
		}
		case EInstanceMatchState.MatchConfirm:
		{
			InstanceDungeonMatchingCountDown matchingCountDownItem3 = this.MatchingCountDownItem;
			if (matchingCountDownItem3 != null)
			{
				matchingCountDownItem3.PlayAnimation("Finish");
			}
			UiManager.Instance.OpenView(EUiViewName.OnlineInstanceMatchTips, null, null);
			return;
		}
		case EInstanceMatchState.Waiting:
			break;
		case EInstanceMatchState.ConfirmToReady:
			this.SetMatchingItemActive(false);
			BattleTeamModel.Instance.Context.SetMultiEntry(true);
			if (UiManager.Instance.IsViewOpen(EUiViewName.InstanceDungeonMonsterPreView))
			{
				UiManager.Instance.CloseView(EUiViewName.InstanceDungeonMonsterPreView, null);
			}
			FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.GetMatchingId(), true, true, false, null);
			EventSystem.Instance.Emit(EEventName.OnEnterTeam);
			break;
		default:
			return;
		}
	}

	// Token: 0x060099B9 RID: 39353 RVA: 0x002D9549 File Offset: 0x002D7749
	private void OnAbyssUnlockChallengeStateUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x060099BA RID: 39354 RVA: 0x002D9554 File Offset: 0x002D7754
	private void OnMatchingBegin()
	{
		this.SetMatchingItemActive(true);
		InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
		if (matchingCountDownItem != null)
		{
			matchingCountDownItem.PlayAnimation("Start");
		}
		InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
		if (matchingCountDownItem2 != null)
		{
			matchingCountDownItem2.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
		}
		this.BeginMatching();
	}

	// Token: 0x060099BB RID: 39355 RVA: 0x002D95B4 File Offset: 0x002D77B4
	private void SetMatchingItemActive(bool state)
	{
		base.GetItem(19).SetUIActive(state);
		base.GetItem(25).SetUIActive(!state);
	}

	// Token: 0x060099BC RID: 39356 RVA: 0x002D95D5 File Offset: 0x002D77D5
	private void BeginMatching()
	{
		this.MatchingCountDownItem.SetMatchingTime(0);
		this.MatchingCountDownItem.StartTimer();
	}

	// Token: 0x060099BD RID: 39357 RVA: 0x002D95F0 File Offset: 0x002D77F0
	private void RefreshGoalLayout()
	{
		List<global::Quest> questsByTypeAndSubType = QuestNewModel.Instance.GetQuestsByTypeAndSubType(10, 1);
		List<GoalPanelData> list = new List<GoalPanelData>();
		foreach (global::Quest quest in questsByTypeAndSubType)
		{
			GoalPanelData goalPanelData = new GoalPanelData();
			string questName = QuestNewModel.Instance.GetQuestName(quest.Id);
			goalPanelData.Title = questName;
			list.Add(goalPanelData);
		}
	}

	// Token: 0x060099BE RID: 39358 RVA: 0x002D9670 File Offset: 0x002D7870
	protected override void OnBeforeDestroy()
	{
		CommonCurrencyItem currencyItem = this.CurrencyItem;
		if (currencyItem != null)
		{
			currencyItem.Destroy(null);
		}
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem == null)
		{
			return;
		}
		dangoWorldQuestItem.Clear();
	}

	// Token: 0x04005BE2 RID: 23522
	[Nullable(1)]
	private const string ENTRANCELOOP = "DangoAbyssLoop2";

	// Token: 0x04005BE3 RID: 23523
	private const int MATCHING_ITEM_OFFSET = -98;

	// Token: 0x04005BE4 RID: 23524
	private InstanceDungeonMatchingCountDown MatchingCountDownItem;

	// Token: 0x04005BE5 RID: 23525
	private CommonCurrencyItem CurrencyItem;

	// Token: 0x04005BE6 RID: 23526
	private DangoAbyssInsSelectViewData ViewData;

	// Token: 0x04005BE7 RID: 23527
	private int CurrentSelectedIndex;

	// Token: 0x04005BE8 RID: 23528
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04005BE9 RID: 23529
	private AbyssButtonItem FriendRankBtnItem;

	// Token: 0x04005BEA RID: 23530
	private AbyssButtonItem LimitRewardBtnItem;

	// Token: 0x04005BEB RID: 23531
	private AbyssButtonItem ActivityRewardBtnItem;

	// Token: 0x04005BEC RID: 23532
	private ButtonItem ConfirmBtn1;

	// Token: 0x04005BED RID: 23533
	private ButtonItem ConfirmBtn2;

	// Token: 0x04005BEE RID: 23534
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<DangoScrollItem, int> DangoRewardLayout;

	// Token: 0x04005BEF RID: 23535
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x04005BF0 RID: 23536
	private DangoWorldQuestItem DangoWorldQuestItem;

	// Token: 0x02007112 RID: 28946
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024D3D RID: 150845
		BackBtn,
		// Token: 0x04024D3E RID: 150846
		InsNameText,
		// Token: 0x04024D3F RID: 150847
		BtnBack,
		// Token: 0x04024D40 RID: 150848
		BtnNext,
		// Token: 0x04024D41 RID: 150849
		FriendRankBtnItem,
		// Token: 0x04024D42 RID: 150850
		LimitRewardBtnItem,
		// Token: 0x04024D43 RID: 150851
		ActivityRewardBtnItem,
		// Token: 0x04024D44 RID: 150852
		TitleText,
		// Token: 0x04024D45 RID: 150853
		SubTitleText,
		// Token: 0x04024D46 RID: 150854
		DescText,
		// Token: 0x04024D47 RID: 150855
		UnlockDangoLayout,
		// Token: 0x04024D48 RID: 150856
		DangoItem,
		// Token: 0x04024D49 RID: 150857
		RewardItemLayout,
		// Token: 0x04024D4A RID: 150858
		RewardItem,
		// Token: 0x04024D4B RID: 150859
		ConsumeItemTexture,
		// Token: 0x04024D4C RID: 150860
		ConsumeItemMask,
		// Token: 0x04024D4D RID: 150861
		ConsumeItemText,
		// Token: 0x04024D4E RID: 150862
		ConfirmBtn1,
		// Token: 0x04024D4F RID: 150863
		ConfirmBtn2,
		// Token: 0x04024D50 RID: 150864
		MatchingTextItem,
		// Token: 0x04024D51 RID: 150865
		InActiveItem,
		// Token: 0x04024D52 RID: 150866
		TopItem,
		// Token: 0x04024D53 RID: 150867
		CostItem,
		// Token: 0x04024D54 RID: 150868
		ConsumeItem,
		// Token: 0x04024D55 RID: 150869
		ConsumeCostItem,
		// Token: 0x04024D56 RID: 150870
		DownButtonItem,
		// Token: 0x04024D57 RID: 150871
		GoalScroller,
		// Token: 0x04024D58 RID: 150872
		GoalItem,
		// Token: 0x04024D59 RID: 150873
		DangoRootItem,
		// Token: 0x04024D5A RID: 150874
		MaxProgressItem,
		// Token: 0x04024D5B RID: 150875
		MaxProgressText
	}
}
