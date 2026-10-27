using System;
using System.Collections.Generic;
using System.Linq;
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
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002189 RID: 8585
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class LordGymController : ControllerBase
{
	// Token: 0x06010AF2 RID: 68338 RVA: 0x0040D23B File Offset: 0x0040B43B
	protected override bool OnInit()
	{
		this.OnRegisterNetEvent();
		this.OnAddEvents();
		return true;
	}

	// Token: 0x06010AF3 RID: 68339 RVA: 0x0040D24A File Offset: 0x0040B44A
	protected override bool OnClear()
	{
		this.OnUnRegisterNetEvent();
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x06010AF4 RID: 68340 RVA: 0x0040D25C File Offset: 0x0040B45C
	protected void OnRegisterNetEvent()
	{
		Net.Instance.Register(ENotifyMessageId.LordGymUnlockNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLordGymUnlockNotify));
		Net.Instance.Register(ENotifyMessageId.LordGymLevelPlayResultNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLordGymLevelPlayResultNotify));
		Net.Instance.Register(ENotifyMessageId.LordGymGroupInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLordGymGroupInfoUpdateNotify));
	}

	// Token: 0x06010AF5 RID: 68341 RVA: 0x0040D2BD File Offset: 0x0040B4BD
	protected void OnUnRegisterNetEvent()
	{
		Net.Instance.UnRegister(ENotifyMessageId.LordGymUnlockNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LordGymLevelPlayResultNotify);
		Net.Instance.UnRegister(ENotifyMessageId.LordGymGroupInfoUpdateNotify);
	}

	// Token: 0x06010AF6 RID: 68342 RVA: 0x0040D2EF File Offset: 0x0040B4EF
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.WorldDone));
		EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x06010AF7 RID: 68343 RVA: 0x0040D329 File Offset: 0x0040B529
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.WorldDone));
		EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
	}

	// Token: 0x06010AF8 RID: 68344 RVA: 0x0040D363 File Offset: 0x0040B563
	private void WorldDone()
	{
		LordGymModel.Instance.InitNewLordGymEntranceIdRecord();
		this.LordGymInfoRequest(0).Forget<bool>();
	}

	// Token: 0x06010AF9 RID: 68345 RVA: 0x0040D37B File Offset: 0x0040B57B
	private void OnWorldDoneAndCloseLoading()
	{
		if (!this.IsInLordGymDungeon())
		{
			return;
		}
		this.EnterLordGymDungeon().Forget<bool>();
	}

	// Token: 0x06010AFA RID: 68346 RVA: 0x0040D394 File Offset: 0x0040B594
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

	// Token: 0x06010AFB RID: 68347 RVA: 0x0040D3D8 File Offset: 0x0040B5D8
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

	// Token: 0x06010AFC RID: 68348 RVA: 0x0040D424 File Offset: 0x0040B624
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

	// Token: 0x06010AFD RID: 68349 RVA: 0x0040D454 File Offset: 0x0040B654
	[NullableContext(2)]
	private void OnLordGymGroupInfoUpdateNotify(IMessage msg, Net.CallbackStatus _)
	{
		LordGymGroupInfoUpdateNotify lordGymGroupInfoUpdateNotify = (LordGymGroupInfoUpdateNotify)msg;
		if (lordGymGroupInfoUpdateNotify == null)
		{
			return;
		}
		LordGymModel instance = LordGymModel.Instance;
		RepeatedField<LordGymGroupInfo> lordGymGroupInfos = lordGymGroupInfoUpdateNotify.LordGymGroupInfos;
		instance.UpdateLordGymGroupInfos((lordGymGroupInfos != null) ? lordGymGroupInfos.ToList<LordGymGroupInfo>() : null);
	}

	// Token: 0x06010AFE RID: 68350 RVA: 0x0040D488 File Offset: 0x0040B688
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

	// Token: 0x06010AFF RID: 68351 RVA: 0x0040D4DC File Offset: 0x0040B6DC
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

	// Token: 0x06010B00 RID: 68352 RVA: 0x0040D52F File Offset: 0x0040B72F
	public void OpenGymUnlockTipView(int lordGymId)
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymUnlockTipView, lordGymId, null);
		LordGymModel.Instance.FirstUnLockLordGym = new List<int>();
	}

	// Token: 0x06010B01 RID: 68353 RVA: 0x0040D558 File Offset: 0x0040B758
	public UniTask ReadLordGym(int lordGymId)
	{
		LordGymController.<ReadLordGym>d__17 <ReadLordGym>d__;
		<ReadLordGym>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ReadLordGym>d__.lordGymId = lordGymId;
		<ReadLordGym>d__.<>1__state = -1;
		<ReadLordGym>d__.<>t__builder.Start<LordGymController.<ReadLordGym>d__17>(ref <ReadLordGym>d__);
		return <ReadLordGym>d__.<>t__builder.Task;
	}

	// Token: 0x06010B02 RID: 68354 RVA: 0x0040D59B File Offset: 0x0040B79B
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

	// Token: 0x06010B03 RID: 68355 RVA: 0x0040D5D0 File Offset: 0x0040B7D0
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

	// Token: 0x06010B04 RID: 68356 RVA: 0x0040D624 File Offset: 0x0040B824
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

	// Token: 0x06010B05 RID: 68357 RVA: 0x0040D668 File Offset: 0x0040B868
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
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
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

	// Token: 0x06010B06 RID: 68358 RVA: 0x0040D74C File Offset: 0x0040B94C
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

	// Token: 0x06010B07 RID: 68359 RVA: 0x0040D7C8 File Offset: 0x0040B9C8
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

	// Token: 0x06010B08 RID: 68360 RVA: 0x0040D860 File Offset: 0x0040BA60
	private void HandleFirstGuideFail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeFailView, param, null);
	}

	// Token: 0x06010B09 RID: 68361 RVA: 0x0040D873 File Offset: 0x0040BA73
	private void HandleSecondGuideFail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		UiManager.Instance.OpenView(EUiViewName.LordGymChallengeFailView, param, null);
	}

	// Token: 0x06010B0A RID: 68362 RVA: 0x0040D886 File Offset: 0x0040BA86
	private void HandleThirdFail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		this.OpenChallengeFailViewWithReviveDelay(param, isDeadInChallenge);
	}

	// Token: 0x06010B0B RID: 68363 RVA: 0x0040D890 File Offset: 0x0040BA90
	private void HandleThird5Fail(LordGymChallengeFailViewParam param, bool isDeadInChallenge)
	{
		this.OpenChallengeFailViewWithReviveDelay(param, isDeadInChallenge);
	}

	// Token: 0x06010B0C RID: 68364 RVA: 0x0040D89C File Offset: 0x0040BA9C
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

	// Token: 0x06010B0D RID: 68365 RVA: 0x0040D908 File Offset: 0x0040BB08
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

	// Token: 0x06010B0E RID: 68366 RVA: 0x0040DAC8 File Offset: 0x0040BCC8
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

	// Token: 0x06010B0F RID: 68367 RVA: 0x0040DB2A File Offset: 0x0040BD2A
	private List<IRewardExploreConfirmButton> BuildFirstGuideSuccessButtons(int? nextId)
	{
		return this.BuildGuideReturnButtons(nextId, 3927);
	}

	// Token: 0x06010B10 RID: 68368 RVA: 0x0040DB38 File Offset: 0x0040BD38
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

	// Token: 0x06010B11 RID: 68369 RVA: 0x0040DB6A File Offset: 0x0040BD6A
	private List<IRewardExploreConfirmButton> BuildSecondGuideSuccessButtons(int? nextId)
	{
		return this.BuildGuideReturnButtons(nextId, 3926);
	}

	// Token: 0x06010B12 RID: 68370 RVA: 0x0040DB78 File Offset: 0x0040BD78
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

	// Token: 0x06010B13 RID: 68371 RVA: 0x0040DC9A File Offset: 0x0040BE9A
	private List<IRewardExploreConfirmButton> BuildThirdSuccessButtons(int? nextId)
	{
		return this.BuildThirdLikeSuccessButtons(nextId, 3924, "ChanllengeBackToCockpit");
	}

	// Token: 0x06010B14 RID: 68372 RVA: 0x0040DCAD File Offset: 0x0040BEAD
	private List<IRewardExploreConfirmButton> BuildThird5SuccessButtons(int? nextId)
	{
		return this.BuildThirdLikeSuccessButtons(nextId, 3925, "Text_GymReturnToLordGym3.5_Text");
	}

	// Token: 0x06010B15 RID: 68373 RVA: 0x0040DCC0 File Offset: 0x0040BEC0
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
					InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
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

	// Token: 0x06010B16 RID: 68374 RVA: 0x0040DDF0 File Offset: 0x0040BFF0
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

	// Token: 0x06010B17 RID: 68375 RVA: 0x0040DE64 File Offset: 0x0040C064
	public void CreateLordModelByEntranceId()
	{
		SkeletalObserverHandle lordSkeletalHandle = UiSceneManager.Instance.GetLordSkeletalHandle();
		if (lordSkeletalHandle == null)
		{
			return;
		}
		UiModelUtil.Instance.SetTransformByTag(lordSkeletalHandle.Model, "MonsterCase");
	}

	// Token: 0x06010B18 RID: 68376 RVA: 0x0040DE98 File Offset: 0x0040C098
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

	// Token: 0x06010B19 RID: 68377 RVA: 0x0040DEF4 File Offset: 0x0040C0F4
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

	// Token: 0x06010B1A RID: 68378 RVA: 0x0040E068 File Offset: 0x0040C268
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

	// Token: 0x06010B1B RID: 68379 RVA: 0x0040E0C4 File Offset: 0x0040C2C4
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

	// Token: 0x06010B1C RID: 68380 RVA: 0x0040E238 File Offset: 0x0040C438
	public bool IsInLordGymDungeon()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		return instanceDungeon != null && instanceDungeon.Value.InstSubType == 48;
	}

	// Token: 0x06010B1D RID: 68381 RVA: 0x0040E270 File Offset: 0x0040C470
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

	// Token: 0x06010B1E RID: 68382 RVA: 0x0040E338 File Offset: 0x0040C538
	public void ClearChallengeFailViewDelay()
	{
		if (this.ChallengeFailViewDelayHandle != null)
		{
			TimerSystem.FlowTimeInstance.Remove(this.ChallengeFailViewDelayHandle);
			this.ChallengeFailViewDelayHandle = null;
		}
	}

	// Token: 0x17001528 RID: 5416
	// (get) Token: 0x06010B1F RID: 68383 RVA: 0x0040E35A File Offset: 0x0040C55A
	public static LordGymController Instance
	{
		get
		{
			return LordGymController._Instance;
		}
	}

	// Token: 0x06010B20 RID: 68384 RVA: 0x0040E361 File Offset: 0x0040C561
	public static LordGymController GetOrCreateInstance()
	{
		if (LordGymController._Instance == null)
		{
			LordGymController.CreateInstance();
		}
		return LordGymController._Instance;
	}

	// Token: 0x06010B21 RID: 68385 RVA: 0x0040E375 File Offset: 0x0040C575
	public static bool CreateInstance()
	{
		if (LordGymController._Instance != null)
		{
			return true;
		}
		LordGymController._Instance = new LordGymController();
		return true;
	}

	// Token: 0x06010B22 RID: 68386 RVA: 0x0040E38B File Offset: 0x0040C58B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010B23 RID: 68387 RVA: 0x0040E38D File Offset: 0x0040C58D
	public static void ResetStaticDefaultValue()
	{
		LordGymController._Instance = null;
	}

	// Token: 0x06010B24 RID: 68388 RVA: 0x0040E395 File Offset: 0x0040C595
	static LordGymController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LordGymController.CreateStaticDefaultValue), new Action(LordGymController.ResetStaticDefaultValue));
	}

	// Token: 0x04007EFF RID: 32511
	private const float TIME_TO_REVIVE = 3000f;

	// Token: 0x04007F00 RID: 32512
	[Nullable(2)]
	private TimerHandle ChallengeFailViewDelayHandle;

	// Token: 0x04007F01 RID: 32513
	[Nullable(2)]
	private static LordGymController _Instance;
}
