using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A3E RID: 6718
[NullableContext(2)]
[Nullable(0)]
public class DangoAbyssInsSelectView : UiViewBase
{
	// Token: 0x0600C581 RID: 50561 RVA: 0x002CCE00 File Offset: 0x002CB000
	[NullableContext(1)]
	public DangoAbyssInsSelectView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C582 RID: 50562 RVA: 0x002CCE0C File Offset: 0x002CB00C
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

	// Token: 0x0600C583 RID: 50563 RVA: 0x002CD138 File Offset: 0x002CB338
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Add(EEventName.OnAbyssUnlockChallengeStateUpdate, new Action(this.OnAbyssUnlockChallengeStateUpdate));
	}

	// Token: 0x0600C584 RID: 50564 RVA: 0x002CD19C File Offset: 0x002CB39C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		EventSystem.Instance.Remove(EEventName.OnAbyssUnlockChallengeStateUpdate, new Action(this.OnAbyssUnlockChallengeStateUpdate));
	}

	// Token: 0x0600C585 RID: 50565 RVA: 0x002CD200 File Offset: 0x002CB400
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssInsSelectView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssInsSelectView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C586 RID: 50566 RVA: 0x002CD244 File Offset: 0x002CB444
	private void OnConfirmB2tnClick(int _)
	{
		if (!DangoAbyssModel.Instance.GetAbyssUnLockState(this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AbyssUnlockTip);
			Dictionary<int, int> dictionary = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.ConsumeItem();
			if (dictionary.Count > 0)
			{
				int key = dictionary.Keys.ToList<int>()[0];
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

	// Token: 0x0600C587 RID: 50567 RVA: 0x002CD3B0 File Offset: 0x002CB5B0
	private void OnConfirm1BtnClick(int _)
	{
		if (!DangoAbyssModel.Instance.GetAbyssUnLockState(this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id))
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.AbyssUnlockTip);
			Dictionary<int, int> dictionary = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.ConsumeItem();
			if (dictionary.Count > 0)
			{
				int key = dictionary.Keys.ToList<int>()[0];
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

	// Token: 0x0600C588 RID: 50568 RVA: 0x002CD490 File Offset: 0x002CB690
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

	// Token: 0x0600C589 RID: 50569 RVA: 0x002CD648 File Offset: 0x002CB848
	private void OnClickSingle()
	{
		BattleTeamModel.Instance.Context.SetMultiEntry(false);
		int id = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.Id;
		DangoAbyssModel.Instance.CurrentSelectEntranceId = this.ViewData.AbyssDataList[this.CurrentSelectedIndex].GetConfig().Value.InstEntranceId;
		DangoAbyssModel.Instance.CurrentSelectChallengeId = id;
		DangoAbyssController.Instance.StartAbyssChallenge(id);
	}

	// Token: 0x0600C58A RID: 50570 RVA: 0x002CD6D4 File Offset: 0x002CB8D4
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

	// Token: 0x0600C58B RID: 50571 RVA: 0x002CD7E8 File Offset: 0x002CB9E8
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

	// Token: 0x0600C58C RID: 50572 RVA: 0x002CD86C File Offset: 0x002CBA6C
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

	// Token: 0x0600C58D RID: 50573 RVA: 0x002CD91C File Offset: 0x002CBB1C
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

	// Token: 0x0600C58E RID: 50574 RVA: 0x002CD93F File Offset: 0x002CBB3F
	[NullableContext(1)]
	private DangoScrollItem InitItem()
	{
		return new DangoScrollItem();
	}

	// Token: 0x0600C58F RID: 50575 RVA: 0x002CD946 File Offset: 0x002CBB46
	[NullableContext(1)]
	public CommonItemSmallItemGrid InitCommonGridItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600C590 RID: 50576 RVA: 0x002CD94D File Offset: 0x002CBB4D
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C591 RID: 50577 RVA: 0x002CD958 File Offset: 0x002CBB58
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

	// Token: 0x0600C592 RID: 50578 RVA: 0x002CD9BC File Offset: 0x002CBBBC
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

	// Token: 0x0600C593 RID: 50579 RVA: 0x002CDA20 File Offset: 0x002CBC20
	protected override void OnBeforeShow()
	{
		DangoWorldQuestItem dangoWorldQuestItem = this.DangoWorldQuestItem;
		if (dangoWorldQuestItem != null)
		{
			dangoWorldQuestItem.Refresh();
		}
		DangoAbyssModel.Instance.SetInAbyssFlow(false);
		UiCameraAnimationManager.Instance.PushCameraHandleByHandleName("DangoAbyssLoop2", true, true, "1001", false, null, null);
		DangoAbyssModel.Instance.SetInAbyssFlow(false);
		this.RefreshView();
		this.RefreshRedDot();
	}

	// Token: 0x0600C594 RID: 50580 RVA: 0x002CDA82 File Offset: 0x002CBC82
	protected override void OnBeforeHide()
	{
		this.UnbindRedDot();
	}

	// Token: 0x0600C595 RID: 50581 RVA: 0x002CDA8C File Offset: 0x002CBC8C
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

	// Token: 0x0600C596 RID: 50582 RVA: 0x002CDB50 File Offset: 0x002CBD50
	private void RefreshInsNameText(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), config.Value.Title, Array.Empty<object>());
		}
	}

	// Token: 0x0600C597 RID: 50583 RVA: 0x002CDBA4 File Offset: 0x002CBDA4
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

	// Token: 0x0600C598 RID: 50584 RVA: 0x002CDC30 File Offset: 0x002CBE30
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

	// Token: 0x0600C599 RID: 50585 RVA: 0x002CDC5C File Offset: 0x002CBE5C
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

	// Token: 0x0600C59A RID: 50586 RVA: 0x002CDCA0 File Offset: 0x002CBEA0
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

	// Token: 0x0600C59B RID: 50587 RVA: 0x002CDCCC File Offset: 0x002CBECC
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

	// Token: 0x0600C59C RID: 50588 RVA: 0x002CDD6C File Offset: 0x002CBF6C
	private void RefreshTitleByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), config.Value.Title, Array.Empty<object>());
		}
	}

	// Token: 0x0600C59D RID: 50589 RVA: 0x002CDDC0 File Offset: 0x002CBFC0
	private void RefreshSubTitleByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), config.Value.SubTitle, Array.Empty<object>());
		}
	}

	// Token: 0x0600C59E RID: 50590 RVA: 0x002CDE14 File Offset: 0x002CC014
	private void RefreshDescByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), config.Value.Desc, Array.Empty<object>());
		}
	}

	// Token: 0x0600C59F RID: 50591 RVA: 0x002CDE68 File Offset: 0x002CC068
	private void RefreshDangoRewardByChallengeId(int challengeId)
	{
		AbyssInst? config = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetConfig();
		if (config != null)
		{
			this.DangoRewardLayout.RefreshByData(config.Value.UnlockLittleRole().ToList<int>(), null, false);
			base.GetItem(28).SetUIActive(config.Value.UnlockLittleRole().Length != 0);
		}
	}

	// Token: 0x0600C5A0 RID: 50592 RVA: 0x002CDED8 File Offset: 0x002CC0D8
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

	// Token: 0x0600C5A1 RID: 50593 RVA: 0x002CDF38 File Offset: 0x002CC138
	private void RefreshRewardItemLayout(int challengeId)
	{
		TItem[] reward = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetReward();
		this.ItemLayout.RefreshByData(reward.ToList<TItem>(), null, false);
	}

	// Token: 0x0600C5A2 RID: 50594 RVA: 0x002CDF70 File Offset: 0x002CC170
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
				int num = dictionary.Keys.ToList<int>()[0];
				int num2 = dictionary[num];
				base.SetTextureByPath(ItemConfig.Instance.GetConfig(num).Value.Icon, base.GetTexture(14), null, null);
				base.GetText(16).SetText(num2.ToString(), true);
			}
		}
	}

	// Token: 0x0600C5A3 RID: 50595 RVA: 0x002CE044 File Offset: 0x002CC244
	private bool GetChallengeButtonCanShow(int challengeId)
	{
		bool canChallenge = this.ViewData.ActivityData.GetAbyssChallengeDataById(challengeId).GetCanChallenge();
		bool abyssPreChallengeFinishState = DangoAbyssModel.Instance.GetAbyssPreChallengeFinishState(challengeId);
		bool abyssConditionFinishState = DangoAbyssModel.Instance.GetAbyssConditionFinishState(challengeId);
		bool abyssTimeLimitState = DangoAbyssModel.Instance.GetAbyssTimeLimitState(challengeId);
		return canChallenge && abyssPreChallengeFinishState && abyssConditionFinishState && abyssTimeLimitState;
	}

	// Token: 0x0600C5A4 RID: 50596 RVA: 0x002CE094 File Offset: 0x002CC294
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

	// Token: 0x0600C5A5 RID: 50597 RVA: 0x002CE1B5 File Offset: 0x002CC3B5
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

	// Token: 0x0600C5A6 RID: 50598 RVA: 0x002CE1DC File Offset: 0x002CC3DC
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

	// Token: 0x0600C5A7 RID: 50599 RVA: 0x002CE244 File Offset: 0x002CC444
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

	// Token: 0x0600C5A8 RID: 50600 RVA: 0x002CE324 File Offset: 0x002CC524
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

	// Token: 0x0600C5A9 RID: 50601 RVA: 0x002CE435 File Offset: 0x002CC635
	private void OnAbyssUnlockChallengeStateUpdate()
	{
		this.RefreshView();
	}

	// Token: 0x0600C5AA RID: 50602 RVA: 0x002CE440 File Offset: 0x002CC640
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

	// Token: 0x0600C5AB RID: 50603 RVA: 0x002CE4A0 File Offset: 0x002CC6A0
	private void SetMatchingItemActive(bool state)
	{
		base.GetItem(19).SetUIActive(state);
		base.GetItem(25).SetUIActive(!state);
	}

	// Token: 0x0600C5AC RID: 50604 RVA: 0x002CE4C1 File Offset: 0x002CC6C1
	private void BeginMatching()
	{
		this.MatchingCountDownItem.SetMatchingTime(0);
		this.MatchingCountDownItem.StartTimer();
	}

	// Token: 0x0600C5AD RID: 50605 RVA: 0x002CE4DC File Offset: 0x002CC6DC
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

	// Token: 0x0600C5AE RID: 50606 RVA: 0x002CE55C File Offset: 0x002CC75C
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

	// Token: 0x04005B13 RID: 23315
	[Nullable(1)]
	private const string ENTRANCELOOP = "DangoAbyssLoop2";

	// Token: 0x04005B14 RID: 23316
	private const int MATCHING_ITEM_OFFSET = -98;

	// Token: 0x04005B15 RID: 23317
	private InstanceDungeonMatchingCountDown MatchingCountDownItem;

	// Token: 0x04005B16 RID: 23318
	private CommonCurrencyItem CurrencyItem;

	// Token: 0x04005B17 RID: 23319
	private DangoAbyssInsSelectViewData ViewData;

	// Token: 0x04005B18 RID: 23320
	private int CurrentSelectedIndex;

	// Token: 0x04005B19 RID: 23321
	private FunctionalPanelConditionLock PanelLock;

	// Token: 0x04005B1A RID: 23322
	private AbyssButtonItem FriendRankBtnItem;

	// Token: 0x04005B1B RID: 23323
	private AbyssButtonItem LimitRewardBtnItem;

	// Token: 0x04005B1C RID: 23324
	private AbyssButtonItem ActivityRewardBtnItem;

	// Token: 0x04005B1D RID: 23325
	private ButtonItem ConfirmBtn1;

	// Token: 0x04005B1E RID: 23326
	private ButtonItem ConfirmBtn2;

	// Token: 0x04005B1F RID: 23327
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<DangoScrollItem, int> DangoRewardLayout;

	// Token: 0x04005B20 RID: 23328
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

	// Token: 0x04005B21 RID: 23329
	private DangoWorldQuestItem DangoWorldQuestItem;

	// Token: 0x02007F83 RID: 32643
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029A00 RID: 170496
		BackBtn,
		// Token: 0x04029A01 RID: 170497
		InsNameText,
		// Token: 0x04029A02 RID: 170498
		BtnBack,
		// Token: 0x04029A03 RID: 170499
		BtnNext,
		// Token: 0x04029A04 RID: 170500
		FriendRankBtnItem,
		// Token: 0x04029A05 RID: 170501
		LimitRewardBtnItem,
		// Token: 0x04029A06 RID: 170502
		ActivityRewardBtnItem,
		// Token: 0x04029A07 RID: 170503
		TitleText,
		// Token: 0x04029A08 RID: 170504
		SubTitleText,
		// Token: 0x04029A09 RID: 170505
		DescText,
		// Token: 0x04029A0A RID: 170506
		UnlockDangoLayout,
		// Token: 0x04029A0B RID: 170507
		DangoItem,
		// Token: 0x04029A0C RID: 170508
		RewardItemLayout,
		// Token: 0x04029A0D RID: 170509
		RewardItem,
		// Token: 0x04029A0E RID: 170510
		ConsumeItemTexture,
		// Token: 0x04029A0F RID: 170511
		ConsumeItemMask,
		// Token: 0x04029A10 RID: 170512
		ConsumeItemText,
		// Token: 0x04029A11 RID: 170513
		ConfirmBtn1,
		// Token: 0x04029A12 RID: 170514
		ConfirmBtn2,
		// Token: 0x04029A13 RID: 170515
		MatchingTextItem,
		// Token: 0x04029A14 RID: 170516
		InActiveItem,
		// Token: 0x04029A15 RID: 170517
		TopItem,
		// Token: 0x04029A16 RID: 170518
		CostItem,
		// Token: 0x04029A17 RID: 170519
		ConsumeItem,
		// Token: 0x04029A18 RID: 170520
		ConsumeCostItem,
		// Token: 0x04029A19 RID: 170521
		DownButtonItem,
		// Token: 0x04029A1A RID: 170522
		GoalScroller,
		// Token: 0x04029A1B RID: 170523
		GoalItem,
		// Token: 0x04029A1C RID: 170524
		DangoRootItem,
		// Token: 0x04029A1D RID: 170525
		MaxProgressItem,
		// Token: 0x04029A1E RID: 170526
		MaxProgressText
	}
}
