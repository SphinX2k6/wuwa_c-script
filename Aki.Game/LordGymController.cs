using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x0200166D RID: 5741
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LordGymController : ControllerBase
{
	// Token: 0x0600DF83 RID: 57219 RVA: 0x00419B17 File Offset: 0x00417D17
	protected override bool OnInit()
	{
		this.OnRegisterNetEvent();
		this.OnAddEvents();
		return true;
	}

	// Token: 0x0600DF84 RID: 57220 RVA: 0x00419B26 File Offset: 0x00417D26
	protected override bool OnClear()
	{
		this.OnUnRegisterNetEvent();
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x0600DF85 RID: 57221 RVA: 0x00419B38 File Offset: 0x00417D38
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LordGymUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLordGymUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.LordGymLevelPlayResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLordGymLevelPlayResultNotify));
		Net.Instance.Register(ENotifyMessageId.LordGymGroupInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLordGymGroupInfoUpdateNotify));
	}

	// Token: 0x0600DF86 RID: 57222 RVA: 0x00419B99 File Offset: 0x00417D99
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LordGymUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LordGymLevelPlayResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LordGymGroupInfoUpdateNotify);
	}

	// Token: 0x0600DF87 RID: 57223 RVA: 0x00419BCB File Offset: 0x00417DCB
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.WorldDone));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600DF88 RID: 57224 RVA: 0x00419C05 File Offset: 0x00417E05
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.WorldDone));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x0600DF89 RID: 57225 RVA: 0x00419C3F File Offset: 0x00417E3F
	private void WorldDone()
	{
		LordGymModel.Instance.InitNewLordGymEntranceIdRecord();
		this.LordGymInfoRequest(0).Forget<bool>();
	}

	// Token: 0x0600DF8A RID: 57226 RVA: 0x00419C57 File Offset: 0x00417E57
	private void OnWorldDoneAndCloseLoading()
	{
		if (!this.IsInLordGymDungeon())
		{
			return;
		}
		this.EnterLordGymDungeon().Forget<bool>();
	}

	// Token: 0x0600DF8B RID: 57227 RVA: 0x00419C70 File Offset: 0x00417E70
	[NullableContext(0)]
	public UniTask<bool> LordGymInfoRequest(int timeoutMs = 0)
	{
		LordGymController.<LordGymInfoRequest>d__10 <LordGymInfoRequest>d__;
		<LordGymInfoRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LordGymInfoRequest>d__.timeoutMs = timeoutMs;
		<LordGymInfoRequest>d__.<>1__state = -1;
		<LordGymInfoRequest>d__.<>t__builder.Start<LordGymController.<LordGymInfoRequest>d__10>(ref <LordGymInfoRequest>d__);
		return <LordGymInfoRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF8C RID: 57228 RVA: 0x00419CB4 File Offset: 0x00417EB4
	[NullableContext(0)]
	public UniTask<bool> LordGymBeginRequest(int lordId)
	{
		LordGymController.<LordGymBeginRequest>d__11 <LordGymBeginRequest>d__;
		<LordGymBeginRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LordGymBeginRequest>d__.<>4__this = this;
		<LordGymBeginRequest>d__.lordId = lordId;
		<LordGymBeginRequest>d__.<>1__state = -1;
		<LordGymBeginRequest>d__.<>t__builder.Start<LordGymController.<LordGymBeginRequest>d__11>(ref <LordGymBeginRequest>d__);
		return <LordGymBeginRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF8D RID: 57229 RVA: 0x00419D00 File Offset: 0x00417F00
	[NullableContext(2)]
	private void OnLordGymUnlockNotify(IMessage msg, Net.CallbackStatus _)
	{
		LordGymUnlockNotify lordGymUnlockNotify = (LordGymUnlockNotify)msg;
		if (lordGymUnlockNotify == null)
		{
			return;
		}
		LordGymModel.Instance.FirstUnLockLordGym = new List<int>(lordGymUnlockNotify.UnlockLoadGymIds);
	}

	// Token: 0x0600DF8E RID: 57230 RVA: 0x00419D30 File Offset: 0x00417F30
	[NullableContext(2)]
	private void OnLordGymGroupInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		LordGymGroupInfoUpdateNotify lordGymGroupInfoUpdateNotify = (LordGymGroupInfoUpdateNotify)msg;
		if (lordGymGroupInfoUpdateNotify == null)
		{
			return;
		}
		LordGymModel.Instance.UpdateLordGymGroupInfos((lordGymGroupInfoUpdateNotify.LordGymGroupInfos == null) ? null : new List<LordGymGroupInfo>(lordGymGroupInfoUpdateNotify.LordGymGroupInfos));
	}

	// Token: 0x0600DF8F RID: 57231 RVA: 0x00419D68 File Offset: 0x00417F68
	[NullableContext(0)]
	public UniTask<bool> OpenLordGymEntrance(int lordEntranceId, int entranceEntityId = 0)
	{
		LordGymController.<OpenLordGymEntrance>d__14 <OpenLordGymEntrance>d__;
		<OpenLordGymEntrance>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenLordGymEntrance>d__.<>4__this = this;
		<OpenLordGymEntrance>d__.lordEntranceId = lordEntranceId;
		<OpenLordGymEntrance>d__.entranceEntityId = entranceEntityId;
		<OpenLordGymEntrance>d__.<>1__state = -1;
		<OpenLordGymEntrance>d__.<>t__builder.Start<LordGymController.<OpenLordGymEntrance>d__14>(ref <OpenLordGymEntrance>d__);
		return <OpenLordGymEntrance>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF90 RID: 57232 RVA: 0x00419DBC File Offset: 0x00417FBC
	[NullableContext(0)]
	public UniTask<bool> OpenLordGymLordEntranceSelectView(int lordEntranceSetId, int entranceEntityId = 0, bool isPlaySpecialSequence = false)
	{
		LordGymController.<OpenLordGymLordEntranceSelectView>d__15 <OpenLordGymLordEntranceSelectView>d__;
		<OpenLordGymLordEntranceSelectView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenLordGymLordEntranceSelectView>d__.lordEntranceSetId = lordEntranceSetId;
		<OpenLordGymLordEntranceSelectView>d__.entranceEntityId = entranceEntityId;
		<OpenLordGymLordEntranceSelectView>d__.isPlaySpecialSequence = isPlaySpecialSequence;
		<OpenLordGymLordEntranceSelectView>d__.<>1__state = -1;
		<OpenLordGymLordEntranceSelectView>d__.<>t__builder.Start<LordGymController.<OpenLordGymLordEntranceSelectView>d__15>(ref <OpenLordGymLordEntranceSelectView>d__);
		return <OpenLordGymLordEntranceSelectView>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF91 RID: 57233 RVA: 0x00419E0F File Offset: 0x0041800F
	public void OpenGymUnlockTipView(int lordGymId)
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymUnlockTipView, lordGymId, null);
		LordGymModel.Instance.FirstUnLockLordGym = new List<int>();
	}

	// Token: 0x0600DF92 RID: 57234 RVA: 0x00419E38 File Offset: 0x00418038
	public UniTask ReadLordGym(int lordGymId)
	{
		LordGymController.<ReadLordGym>d__17 <ReadLordGym>d__;
		<ReadLordGym>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReadLordGym>d__.lordGymId = lordGymId;
		<ReadLordGym>d__.<>1__state = -1;
		<ReadLordGym>d__.<>t__builder.Start<LordGymController.<ReadLordGym>d__17>(ref <ReadLordGym>d__);
		return <ReadLordGym>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF93 RID: 57235 RVA: 0x00419E7B File Offset: 0x0041807B
	public int GetLordGymGuideEntranceId(ELordGymVersion version)
	{
		switch (version)
		{
		case ELordGymVersion.First:
			return 3927;
		case ELordGymVersion.Second:
			return 3926;
		case ELordGymVersion.Third:
			return 3924;
		case ELordGymVersion.Third5:
			return 3925;
		default:
			return 0;
		}
	}

	// Token: 0x0600DF94 RID: 57236 RVA: 0x00419EB0 File Offset: 0x004180B0
	[NullableContext(0)]
	public UniTask<bool> OpenLordGymViaGuide(ELordGymVersion version, int entranceId)
	{
		LordGymController.<OpenLordGymViaGuide>d__19 <OpenLordGymViaGuide>d__;
		<OpenLordGymViaGuide>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenLordGymViaGuide>d__.<>4__this = this;
		<OpenLordGymViaGuide>d__.version = version;
		<OpenLordGymViaGuide>d__.entranceId = entranceId;
		<OpenLordGymViaGuide>d__.<>1__state = -1;
		<OpenLordGymViaGuide>d__.<>t__builder.Start<LordGymController.<OpenLordGymViaGuide>d__19>(ref <OpenLordGymViaGuide>d__);
		return <OpenLordGymViaGuide>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF95 RID: 57237 RVA: 0x00419F04 File Offset: 0x00418104
	[NullableContext(0)]
	public UniTask<bool> EnterLordGymDungeon()
	{
		LordGymController.<EnterLordGymDungeon>d__20 <EnterLordGymDungeon>d__;
		<EnterLordGymDungeon>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<EnterLordGymDungeon>d__.<>4__this = this;
		<EnterLordGymDungeon>d__.<>1__state = -1;
		<EnterLordGymDungeon>d__.<>t__builder.Start<LordGymController.<EnterLordGymDungeon>d__20>(ref <EnterLordGymDungeon>d__);
		return <EnterLordGymDungeon>d__.<>t__builder.Task;
	}

	// Token: 0x0600DF96 RID: 57238 RVA: 0x00419F48 File Offset: 0x00418148
	private List<IRewardExploreConfirmButton> BuildGuideReturnButtons(int? nextId, int returnEntranceId)
	{
		RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
		{
			ButtonTextId = "Text_GymReturnToLordGym1.0_Text",
			DescriptionTextId = null,
			IsTimeDownCloseView = false,
			IsClickedCloseView = true,
			OnClickedCallback = delegate(int _)
			{
				InstanceDungeonEntranceController.Instance.EnterEntrance(returnEntranceId, 0, null).Forget<bool>();
			}
		};
		if (nextId != null && nextId.Value != 0 && LordGymModel.Instance.GetLordGymIsUnLock(nextId.Value))
		{
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_GymContinueChallenge_Text",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					LordGymModel.Instance.EntryChallengeId = nextId.Value;
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
				}
			};
			return new List<IRewardExploreConfirmButton>
			{
				item,
				item2
			};
		}
		return new List<IRewardExploreConfirmButton>
		{
			item
		};
	}

	// Token: 0x0600DF97 RID: 57239 RVA: 0x0041A02C File Offset: 0x0041822C
	[NullableContext(2)]
	private void OnLordGymLevelPlayResultNotify(IMessage msg, Net.CallbackStatus _)
	{
		LordGymLevelPlayResultNotify lordGymLevelPlayResultNotify = (LordGymLevelPlayResultNotify)msg;
		if (lordGymLevelPlayResultNotify == null)
		{
			return;
		}
		LordGymModel instance = LordGymModel.Instance;
		bool isDeadInChallenge = instance.IsDeadInChallenge;
		instance.IsDeadInChallenge = false;
		int loadGymId = lordGymLevelPlayResultNotify.LordGymPassRecord.LoadGymId;
		if (loadGymId != 0)
		{
			instance.LordGymRecord[loadGymId] = lordGymLevelPlayResultNotify.LordGymPassRecord;
		}
		bool isCurrentChallengeFromGuide = instance.IsCurrentChallengeFromGuide;
		instance.IsCurrentChallengeFromGuide = false;
		if (!lordGymLevelPlayResultNotify.IsSuccess)
		{
			this.HandlePlayResultFail(lordGymLevelPlayResultNotify, isCurrentChallengeFromGuide, isDeadInChallenge);
			return;
		}
		this.HandlePlayResultSuccess(lordGymLevelPlayResultNotify, loadGymId, isCurrentChallengeFromGuide);
	}

	// Token: 0x0600DF98 RID: 57240 RVA: 0x0041A0A8 File Offset: 0x004182A8
	private void HandlePlayResultFail(LordGymLevelPlayResultNotify data, bool isFromGuide, bool isDeadInChallenge)
	{
		int failLoadGymId = data.FailLoadGymId;
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(failLoadGymId);
		if (lordGymConfig == null)
		{
			return;
		}
		ELordGymVersion version = (ELordGymVersion)lordGymConfig.Value.Version;
		LordGymChallengeFailViewParam param = new LordGymChallengeFailViewParam
		{
			LordId = failLoadGymId,
			Version = version,
			IsFromGuide = isFromGuide
		};
		switch (version)
		{
		case ELordGymVersion.First:
			if (isFromGuide)
			{
				this.HandleFirstGuideFail(param, isDeadInChallenge);
			}
			return;
		case ELordGymVersion.Second:
			if (isFromGuide)
			{
				this.HandleSecondGuideFail(param, isDeadInChallenge);
			}
			return;
		case ELordGymVersion.Third:
			this.HandleThirdFail(param, isDeadInChallenge);
			return;
		case ELordGymVersion.Third5:
			this.HandleThird5Fail(param, isDeadInChallenge);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600DF99 RID: 57241 RVA: 0x0041A140 File Offset: 0x00418340
	private void HandleFirstGuideFail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeFailView, param, null);
	}

	// Token: 0x0600DF9A RID: 57242 RVA: 0x0041A153 File Offset: 0x00418353
	private void HandleSecondGuideFail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeFailView, param, null);
	}

	// Token: 0x0600DF9B RID: 57243 RVA: 0x0041A166 File Offset: 0x00418366
	private void HandleThirdFail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		this.OpenChallengeFailViewWithReviveDelay(param, isDeadInChallenge);
	}

	// Token: 0x0600DF9C RID: 57244 RVA: 0x0041A170 File Offset: 0x00418370
	private void HandleThird5Fail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		this.OpenChallengeFailViewWithReviveDelay(param, isDeadInChallenge);
	}

	// Token: 0x0600DF9D RID: 57245 RVA: 0x0041A17C File Offset: 0x0041837C
	private void OpenChallengeFailViewWithReviveDelay(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		Action open = delegate()
		{
			this.ChallengeFailViewDelayHandle = null;
			UiManager.Instance.OpenView(EUiViewName.LordGymChallengeFailView, param, null);
		};
		if (isDeadInChallenge)
		{
			this.ChallengeFailViewDelayHandle = TimerSystem.FlowTimeInstance.Delay(delegate(float _)
			{
				open();
			}, 3000f, null, null, true, 1f);
			return;
		}
		open();
	}

	// Token: 0x0600DF9E RID: 57246 RVA: 0x0041A1E8 File Offset: 0x004183E8
	private void HandlePlayResultSuccess(LordGymLevelPlayResultNotify data, int gymId, bool isFromGuide)
	{
		LordGym? lordGymConfig = LordGymConfig.Instance.GetLordGymConfig(gymId);
		if (lordGymConfig == null)
		{
			return;
		}
		ELordGymVersion version = (ELordGymVersion)lordGymConfig.Value.Version;
		int? nextId = LordGymModel.Instance.GetNextGymId(gymId);
		List<IRewardExploreConfirmButton> buttonInfoList = this.BuildSuccessButtonList(version, isFromGuide, nextId);
		List<RewardItemData> list = new List<RewardItemData>();
		foreach (Aki.Protocol.ItemData itemData in data.ItemDatas)
		{
			RewardItemData item = new RewardItemData(itemData.ItemId, itemData.Count, (itemData.ItemIncId != 0) ? new int?(itemData.ItemIncId) : null, EDropItemType.Normal);
			list.Add(item);
		}
		RewardExploreRecordData exploreRecordInfo = new RewardExploreRecordData
		{
			TitleTextId = "LordGym_TimeTitle",
			Record = TimeUtil.Instance.GetTimeString((double)data.PassTime),
			IsNewRecord = data.IsNewRecord
		};
		bool needShowUnlockTip = nextId != null && nextId.Value != 0 && !LordGymModel.Instance.GetLordGymHasRead(nextId.Value) && LordGymModel.Instance.GetLordGymIsUnLock(nextId.Value);
		ItemRewardController.Instance.OpenExploreRewardViewNew(new ExploreRewardViewData
		{
			ConfigId = 3011,
			IsSuccess = true,
			RewardItemDataList = list,
			ExploreRecordInfo = exploreRecordInfo,
			ButtonInfoList = buttonInfoList,
			OnCloseCallback = delegate
			{
				if (needShowUnlockTip)
				{
					UiManager.Instance.OpenView(EUiViewName.LordGymUnlockTipView, nextId.Value, null);
				}
			},
			IsBagFull = new bool?(data.IsPkgFull)
		});
	}

	// Token: 0x0600DF9F RID: 57247 RVA: 0x0041A3A8 File Offset: 0x004185A8
	private List<IRewardExploreConfirmButton> BuildSuccessButtonList(ELordGymVersion version, bool isFromGuide, int? nextId)
	{
		switch (version)
		{
		case ELordGymVersion.First:
			if (!isFromGuide)
			{
				return this.BuildFirstWorldSuccessButtons();
			}
			return this.BuildFirstGuideSuccessButtons(nextId);
		case ELordGymVersion.Second:
			if (!isFromGuide)
			{
				return this.BuildSecondWorldSuccessButtons(nextId);
			}
			return this.BuildSecondGuideSuccessButtons(nextId);
		case ELordGymVersion.Third:
			return this.BuildThirdSuccessButtons(nextId);
		case ELordGymVersion.Third5:
			return this.BuildThird5SuccessButtons(nextId);
		default:
			return this.BuildFirstWorldSuccessButtons();
		}
	}

	// Token: 0x0600DFA0 RID: 57248 RVA: 0x0041A40A File Offset: 0x0041860A
	private List<IRewardExploreConfirmButton> BuildFirstGuideSuccessButtons(int? nextId)
	{
		return this.BuildGuideReturnButtons(nextId, 3927);
	}

	// Token: 0x0600DFA1 RID: 57249 RVA: 0x0041A418 File Offset: 0x00418618
	private List<IRewardExploreConfirmButton> BuildFirstWorldSuccessButtons()
	{
		return new List<IRewardExploreConfirmButton>
		{
			new RewardExploreConfirmButtonData
			{
				ButtonTextId = "ConfirmBox_45_ButtonText_1",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true
			}
		};
	}

	// Token: 0x0600DFA2 RID: 57250 RVA: 0x0041A44A File Offset: 0x0041864A
	private List<IRewardExploreConfirmButton> BuildSecondGuideSuccessButtons(int? nextId)
	{
		return this.BuildGuideReturnButtons(nextId, 3926);
	}

	// Token: 0x0600DFA3 RID: 57251 RVA: 0x0041A458 File Offset: 0x00418658
	private List<IRewardExploreConfirmButton> BuildSecondWorldSuccessButtons(int? nextId)
	{
		RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
		{
			ButtonTextId = "Text_GymReturnToWorld_Text",
			DescriptionTextId = null,
			IsTimeDownCloseView = false,
			IsClickedCloseView = true
		};
		if (nextId != null && nextId.Value != 0 && LordGymModel.Instance.GetLordGymIsUnLock(nextId.Value))
		{
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_GymContinueChallenge_Text",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					this.LordGymBeginRequest(nextId.Value).Forget<bool>();
				}
			};
			return new List<IRewardExploreConfirmButton>
			{
				item,
				item2
			};
		}
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData.ButtonTextId = "Text_GymReturnToLordGym_Text";
		rewardExploreConfirmButtonData.DescriptionTextId = null;
		rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
		rewardExploreConfirmButtonData.IsClickedCloseView = true;
		rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
		{
			int entranceSetId = LordGymModel.Instance.EntranceSetId;
			if (entranceSetId > 0)
			{
				LordGymLordEntranceSelectViewParam param = new LordGymLordEntranceSelectViewParam
				{
					EntranceSetId = entranceSetId,
					IsPlaySpecialSequence = new bool?(false)
				};
				UiManager.Instance.OpenView(EUiViewName.LordGymLordEntranceSelectView, param, null);
			}
		};
		RewardExploreConfirmButtonData item3 = rewardExploreConfirmButtonData;
		return new List<IRewardExploreConfirmButton>
		{
			item,
			item3
		};
	}

	// Token: 0x0600DFA4 RID: 57252 RVA: 0x0041A57A File Offset: 0x0041877A
	private List<IRewardExploreConfirmButton> BuildThirdSuccessButtons(int? nextId)
	{
		return this.BuildThirdLikeSuccessButtons(nextId, 3924, "ChanllengeBackToCockpit");
	}

	// Token: 0x0600DFA5 RID: 57253 RVA: 0x0041A58D File Offset: 0x0041878D
	private List<IRewardExploreConfirmButton> BuildThird5SuccessButtons(int? nextId)
	{
		return this.BuildThirdLikeSuccessButtons(nextId, 3925, "Text_GymReturnToLordGym3.5_Text");
	}

	// Token: 0x0600DFA6 RID: 57254 RVA: 0x0041A5A0 File Offset: 0x004187A0
	private List<IRewardExploreConfirmButton> BuildThirdLikeSuccessButtons(int? nextId, int entranceId, string returnTextId)
	{
		RewardExploreConfirmButtonData item = new RewardExploreConfirmButtonData
		{
			ButtonTextId = returnTextId,
			DescriptionTextId = null,
			IsTimeDownCloseView = false,
			IsClickedCloseView = true,
			OnClickedCallback = delegate(int _)
			{
				InstanceDungeonEntranceController.Instance.EnterEntrance(entranceId, 0, null).Forget<bool>();
			}
		};
		if (nextId != null && nextId.Value != 0 && LordGymModel.Instance.GetLordGymIsUnLock(nextId.Value))
		{
			RewardExploreConfirmButtonData item2 = new RewardExploreConfirmButtonData
			{
				ButtonTextId = "Text_GymContinueChallenge_Text",
				DescriptionTextId = null,
				IsTimeDownCloseView = false,
				IsClickedCloseView = true,
				OnClickedCallback = delegate(int _)
				{
					LordGymModel.Instance.EntryChallengeId = nextId.Value;
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
				}
			};
			return new List<IRewardExploreConfirmButton>
			{
				item,
				item2
			};
		}
		RewardExploreConfirmButtonData rewardExploreConfirmButtonData = new RewardExploreConfirmButtonData();
		rewardExploreConfirmButtonData.ButtonTextId = "Text_GymReturnToWorld_Text";
		rewardExploreConfirmButtonData.DescriptionTextId = null;
		rewardExploreConfirmButtonData.IsTimeDownCloseView = false;
		rewardExploreConfirmButtonData.IsClickedCloseView = true;
		rewardExploreConfirmButtonData.OnClickedCallback = delegate(int _)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		};
		RewardExploreConfirmButtonData item3 = rewardExploreConfirmButtonData;
		return new List<IRewardExploreConfirmButton>
		{
			item,
			item3
		};
	}

	// Token: 0x0600DFA7 RID: 57255 RVA: 0x0041A6D0 File Offset: 0x004188D0
	public bool IsInEntranceEntity()
	{
		int entranceEntityId = LordGymModel.Instance.EntranceEntityId;
		if (entranceEntityId == 0)
		{
			return true;
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entranceEntityId);
		if (entityById == null || !entityById.IsInit)
		{
			return true;
		}
		WorldEntity entity = entityById.Entity;
		bool? flag;
		if (entity == null)
		{
			flag = null;
		}
		else
		{
			PawnPerceptionComponent component = entity.GetComponent<PawnPerceptionComponent>();
			flag = ((component != null) ? new bool?(component.IsInInteractRange) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x0600DFA8 RID: 57256 RVA: 0x0041A744 File Offset: 0x00418944
	public void CreateLordModelByEntranceId()
	{
		SkeletalObserverHandle lordSkeletalHandle = UiSceneManager.Instance.GetLordSkeletalHandle();
		if (lordSkeletalHandle == null)
		{
			return;
		}
		UiModelUtil.Instance.SetTransformByTag(lordSkeletalHandle.Model, "MonsterCase");
	}

	// Token: 0x0600DFA9 RID: 57257 RVA: 0x0041A778 File Offset: 0x00418978
	public UniTask LoadLordModelByEntranceId(int entranceId, bool autoPlayMaterialAnimation = true, bool playBossAudio = false)
	{
		LordGymController.<LoadLordModelByEntranceId>d__40 <LoadLordModelByEntranceId>d__;
		<LoadLordModelByEntranceId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadLordModelByEntranceId>d__.<>4__this = this;
		<LoadLordModelByEntranceId>d__.entranceId = entranceId;
		<LoadLordModelByEntranceId>d__.autoPlayMaterialAnimation = autoPlayMaterialAnimation;
		<LoadLordModelByEntranceId>d__.playBossAudio = playBossAudio;
		<LoadLordModelByEntranceId>d__.<>1__state = -1;
		<LoadLordModelByEntranceId>d__.<>t__builder.Start<LordGymController.<LoadLordModelByEntranceId>d__40>(ref <LoadLordModelByEntranceId>d__);
		return <LoadLordModelByEntranceId>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFAA RID: 57258 RVA: 0x0041A7D4 File Offset: 0x004189D4
	[NullableContext(2)]
	public void PlayLordModelMaterialAnimationByEntranceId(int entranceId, UiModelBase model = null, UiModelLoadComponent loadComponent = null, bool playBossAudio = true, bool isStart = false)
	{
		if (UiSceneManager.Instance.GetLordSkeletalHandle() == null)
		{
			return;
		}
		if (playBossAudio)
		{
			AudioSystem.Instance.PostEvent("play_ui_daoguan_3_1_efx_boss");
		}
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(entranceId);
		if (lordGymEntranceConfig == null)
		{
			return;
		}
		string lordStartMaterialController = lordGymEntranceConfig.Value.LordStartMaterialController;
		string lordChangeMaterialController = lordGymEntranceConfig.Value.LordChangeMaterialController;
		string lordIdleMaterialController = lordGymEntranceConfig.Value.LordIdleMaterialController;
		string text = (isStart && !StringUtils.IsBlank(lordStartMaterialController)) ? lordStartMaterialController : lordChangeMaterialController;
		SkeletalObserverHandle lordSkeletalHandle = UiSceneManager.Instance.GetLordSkeletalHandle();
		UiModelBase uiModelBase = model ?? lordSkeletalHandle.Model;
		UiModelLoadComponent uiModelLoadComponent = loadComponent ?? uiModelBase.CheckGetComponent<UiModelLoadComponent>();
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = uiModelBase.CheckGetComponent<UiModelRenderingMaterialComponent>();
		if (!StringUtils.IsBlank(text))
		{
			UObject loadedResource = uiModelLoadComponent.GetLoadedResource(text);
			if (lordGymEntranceConfig.Value.IsGroup)
			{
				PD_CharacterControllerDataGroup_C pd_CharacterControllerDataGroup_C = loadedResource as PD_CharacterControllerDataGroup_C;
				if (pd_CharacterControllerDataGroup_C != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialGroup(pd_CharacterControllerDataGroup_C);
				}
			}
			else
			{
				PD_CharacterControllerData_C pd_CharacterControllerData_C = loadedResource as PD_CharacterControllerData_C;
				if (pd_CharacterControllerData_C != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C);
				}
			}
		}
		if (!StringUtils.IsBlank(lordIdleMaterialController))
		{
			UObject loadedResource2 = uiModelLoadComponent.GetLoadedResource(lordIdleMaterialController);
			if (lordGymEntranceConfig.Value.IsGroup)
			{
				PD_CharacterControllerDataGroup_C pd_CharacterControllerDataGroup_C2 = loadedResource2 as PD_CharacterControllerDataGroup_C;
				if (pd_CharacterControllerDataGroup_C2 != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialGroup(pd_CharacterControllerDataGroup_C2);
					return;
				}
			}
			else
			{
				PD_CharacterControllerData_C pd_CharacterControllerData_C2 = loadedResource2 as PD_CharacterControllerData_C;
				if (pd_CharacterControllerData_C2 != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C2);
				}
			}
		}
	}

	// Token: 0x0600DFAB RID: 57259 RVA: 0x0041A948 File Offset: 0x00418B48
	public UniTask LoadLordModelByEntranceIdThird5(int entranceId, bool autoPlayMaterialAnimation = true, bool playBossAudio = false)
	{
		LordGymController.<LoadLordModelByEntranceIdThird5>d__42 <LoadLordModelByEntranceIdThird5>d__;
		<LoadLordModelByEntranceIdThird5>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadLordModelByEntranceIdThird5>d__.<>4__this = this;
		<LoadLordModelByEntranceIdThird5>d__.entranceId = entranceId;
		<LoadLordModelByEntranceIdThird5>d__.autoPlayMaterialAnimation = autoPlayMaterialAnimation;
		<LoadLordModelByEntranceIdThird5>d__.playBossAudio = playBossAudio;
		<LoadLordModelByEntranceIdThird5>d__.<>1__state = -1;
		<LoadLordModelByEntranceIdThird5>d__.<>t__builder.Start<LordGymController.<LoadLordModelByEntranceIdThird5>d__42>(ref <LoadLordModelByEntranceIdThird5>d__);
		return <LoadLordModelByEntranceIdThird5>d__.<>t__builder.Task;
	}

	// Token: 0x0600DFAC RID: 57260 RVA: 0x0041A9A4 File Offset: 0x00418BA4
	[NullableContext(2)]
	public void PlayLordModelMaterialAnimationByEntranceIdThird5(int entranceId, UiModelBase model = null, UiModelLoadComponent loadComponent = null, bool playBossAudio = true, bool isStart = false)
	{
		if (UiSceneManager.Instance.GetLordSkeletalHandle() == null)
		{
			return;
		}
		if (playBossAudio)
		{
			AudioSystem.Instance.PostEvent("play_ui_daoguan_3_5_efx_boss");
		}
		LordGymEntrance? lordGymEntranceConfig = LordGymConfig.Instance.GetLordGymEntranceConfig(entranceId);
		if (lordGymEntranceConfig == null)
		{
			return;
		}
		string lordStartMaterialController = lordGymEntranceConfig.Value.LordStartMaterialController;
		string lordChangeMaterialController = lordGymEntranceConfig.Value.LordChangeMaterialController;
		string lordIdleMaterialController = lordGymEntranceConfig.Value.LordIdleMaterialController;
		string text = (isStart && !StringUtils.IsBlank(lordStartMaterialController)) ? lordStartMaterialController : lordChangeMaterialController;
		SkeletalObserverHandle lordSkeletalHandle = UiSceneManager.Instance.GetLordSkeletalHandle();
		UiModelBase uiModelBase = model ?? lordSkeletalHandle.Model;
		UiModelLoadComponent uiModelLoadComponent = loadComponent ?? uiModelBase.CheckGetComponent<UiModelLoadComponent>();
		UiModelRenderingMaterialComponent uiModelRenderingMaterialComponent = uiModelBase.CheckGetComponent<UiModelRenderingMaterialComponent>();
		if (!StringUtils.IsBlank(text))
		{
			UObject loadedResource = uiModelLoadComponent.GetLoadedResource(text);
			if (lordGymEntranceConfig.Value.IsGroup)
			{
				PD_CharacterControllerDataGroup_C pd_CharacterControllerDataGroup_C = loadedResource as PD_CharacterControllerDataGroup_C;
				if (pd_CharacterControllerDataGroup_C != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialGroup(pd_CharacterControllerDataGroup_C);
				}
			}
			else
			{
				PD_CharacterControllerData_C pd_CharacterControllerData_C = loadedResource as PD_CharacterControllerData_C;
				if (pd_CharacterControllerData_C != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C);
				}
			}
		}
		if (!StringUtils.IsBlank(lordIdleMaterialController))
		{
			UObject loadedResource2 = uiModelLoadComponent.GetLoadedResource(lordIdleMaterialController);
			if (lordGymEntranceConfig.Value.IsGroup)
			{
				PD_CharacterControllerDataGroup_C pd_CharacterControllerDataGroup_C2 = loadedResource2 as PD_CharacterControllerDataGroup_C;
				if (pd_CharacterControllerDataGroup_C2 != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialGroup(pd_CharacterControllerDataGroup_C2);
					return;
				}
			}
			else
			{
				PD_CharacterControllerData_C pd_CharacterControllerData_C2 = loadedResource2 as PD_CharacterControllerData_C;
				if (pd_CharacterControllerData_C2 != null && uiModelRenderingMaterialComponent != null)
				{
					uiModelRenderingMaterialComponent.AddRenderingMaterialByData(pd_CharacterControllerData_C2);
				}
			}
		}
	}

	// Token: 0x0600DFAD RID: 57261 RVA: 0x0041AB18 File Offset: 0x00418D18
	public bool IsInLordGymDungeon()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		return instanceDungeon != null && instanceDungeon.Value.InstSubType == 48;
	}

	// Token: 0x0600DFAE RID: 57262 RVA: 0x0041AB50 File Offset: 0x00418D50
	public bool IsInLordGymThird5Dungeon()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		if (instanceDungeon == null || instanceDungeon.Value.InstSubType != 48)
		{
			return false;
		}
		IReadOnlyList<LordGymEntranceSet> configList = ConfigLordGymEntranceSetAll.GetConfigList(true);
		if (configList == null)
		{
			return false;
		}
		LordGymEntranceSet? lordGymEntranceSet = null;
		foreach (LordGymEntranceSet value in configList)
		{
			if (value.DungeonId == instanceDungeon.Value.Id)
			{
				lordGymEntranceSet = new LordGymEntranceSet?(value);
				break;
			}
		}
		return lordGymEntranceSet != null && lordGymEntranceSet.GetValueOrDefault().Id == 200104;
	}

	// Token: 0x0600DFAF RID: 57263 RVA: 0x0041AC18 File Offset: 0x00418E18
	public void ClearChallengeFailViewDelay()
	{
		if (this.ChallengeFailViewDelayHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.ChallengeFailViewDelayHandle);
			this.ChallengeFailViewDelayHandle = null;
		}
	}

	// Token: 0x1700155F RID: 5471
	// (get) Token: 0x0600DFB0 RID: 57264 RVA: 0x0041AC3A File Offset: 0x00418E3A
	public static LordGymController Instance
	{
		get
		{
			return LordGymController._Instance;
		}
	}

	// Token: 0x0600DFB1 RID: 57265 RVA: 0x0041AC41 File Offset: 0x00418E41
	public static LordGymController GetOrCreateInstance()
	{
		if (LordGymController._Instance == null)
		{
			LordGymController.CreateInstance();
		}
		return LordGymController._Instance;
	}

	// Token: 0x0600DFB2 RID: 57266 RVA: 0x0041AC55 File Offset: 0x00418E55
	public static bool CreateInstance()
	{
		if (LordGymController._Instance != null)
		{
			return true;
		}
		LordGymController._Instance = new LordGymController();
		return true;
	}

	// Token: 0x0600DFB3 RID: 57267 RVA: 0x0041AC6B File Offset: 0x00418E6B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DFB4 RID: 57268 RVA: 0x0041AC6D File Offset: 0x00418E6D
	public static void ResetStaticDefaultValue()
	{
		LordGymController._Instance = null;
	}

	// Token: 0x0600DFB5 RID: 57269 RVA: 0x0041AC75 File Offset: 0x00418E75
	static LordGymController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LordGymController.CreateStaticDefaultValue), new Action(LordGymController.ResetStaticDefaultValue));
	}

	// Token: 0x04008046 RID: 32838
	private const float TIME_TO_REVIVE = 3000f;

	// Token: 0x04008047 RID: 32839
	[Nullable(2)]
	private TimerHandle ChallengeFailViewDelayHandle;

	// Token: 0x04008048 RID: 32840
	[Nullable(2)]
	private static LordGymController _Instance;
}
