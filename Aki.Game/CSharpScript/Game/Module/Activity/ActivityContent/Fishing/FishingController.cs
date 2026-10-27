using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.FishingQte;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065D6 RID: 26070
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FishingController : UiControllerBase
	{
		// Token: 0x0604163C RID: 267836 RVA: 0x00FD7F28 File Offset: 0x00FD6128
		public void OpenDockyardView()
		{
			DockyardViewModel param = new DockyardViewModel();
			UiManager.Instance.OpenView(EUiViewName.DockyardView, param, null);
		}

		// Token: 0x0604163D RID: 267837 RVA: 0x00FD7F4C File Offset: 0x00FD614C
		public void OpenDockyardWareHouseView(bool inGameplayFlow = false)
		{
			DockyardWareHouseViewModel dockyardWareHouseViewModel = new DockyardWareHouseViewModel();
			dockyardWareHouseViewModel.InGameplayFlow = inGameplayFlow;
			UiManager.Instance.OpenView(EUiViewName.DockyardWareHouseView, dockyardWareHouseViewModel, null);
		}

		// Token: 0x0604163E RID: 267838 RVA: 0x00FD7F78 File Offset: 0x00FD6178
		public UniTask OpenDockyardCageView(int configId)
		{
			FishingController.<OpenDockyardCageView>d__4 <OpenDockyardCageView>d__;
			<OpenDockyardCageView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenDockyardCageView>d__.configId = configId;
			<OpenDockyardCageView>d__.<>1__state = -1;
			<OpenDockyardCageView>d__.<>t__builder.Start<FishingController.<OpenDockyardCageView>d__4>(ref <OpenDockyardCageView>d__);
			return <OpenDockyardCageView>d__.<>t__builder.Task;
		}

		// Token: 0x0604163F RID: 267839 RVA: 0x00FD7FBC File Offset: 0x00FD61BC
		public void OpenDockyardInteractView(int configId, int actionIncId)
		{
			DockyardInteractViewModel dockyardInteractViewModel = new DockyardInteractViewModel();
			dockyardInteractViewModel.ConfigId = configId;
			dockyardInteractViewModel.ActionIncId = actionIncId;
			UiManager.Instance.OpenView(EUiViewName.DockyardInteractView, dockyardInteractViewModel, null);
		}

		// Token: 0x06041640 RID: 267840 RVA: 0x00FD7FEE File Offset: 0x00FD61EE
		public void OpenDockyardShopView(EDockyardShopTabType? tabType = null)
		{
			if (!FunctionModel.Instance.IsOpen(10077))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DockyardShopMainView, tabType, null);
		}

		// Token: 0x06041641 RID: 267841 RVA: 0x00FD802C File Offset: 0x00FD622C
		public void OpenFishingTechRootView()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingTechRootView, null, null);
		}

		// Token: 0x06041642 RID: 267842 RVA: 0x00FD803F File Offset: 0x00FD623F
		public void OpenFishingHandBookView()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingHandBookView, null, null);
		}

		// Token: 0x06041643 RID: 267843 RVA: 0x00FD8052 File Offset: 0x00FD6252
		public void OpenFishingQuestView()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingQuestView, null, null);
		}

		// Token: 0x06041644 RID: 267844 RVA: 0x00FD8068 File Offset: 0x00FD6268
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.FishingQuestView, new Func<EUiViewName, object, bool>(this.CanOpenQuestView), "FishingController.CanOpenFishingQuestView");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.FishingHandBookView, new Func<EUiViewName, object, bool>(this.CanOpenHandBookView), "FishingController.CanOpenHandBookView");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.FishingTechRootView, new Func<EUiViewName, object, bool>(this.CanOpenTechRootView), "FishingController.CanOpenTechRootView");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.DockyardShopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDockyardShopView), "FishingController.CanOpenDockyardShopView");
		}

		// Token: 0x06041645 RID: 267845 RVA: 0x00FD80F8 File Offset: 0x00FD62F8
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.FishingQuestView, new Func<EUiViewName, object, bool>(this.CanOpenQuestView));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.FishingHandBookView, new Func<EUiViewName, object, bool>(this.CanOpenHandBookView));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.FishingTechRootView, new Func<EUiViewName, object, bool>(this.CanOpenTechRootView));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.DockyardShopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDockyardShopView));
		}

		// Token: 0x06041646 RID: 267846 RVA: 0x00FD8171 File Offset: 0x00FD6371
		private bool CanOpenQuestView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingEntrust);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x06041647 RID: 267847 RVA: 0x00FD8199 File Offset: 0x00FD6399
		private bool CanOpenHandBookView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingHandBook);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x06041648 RID: 267848 RVA: 0x00FD81C1 File Offset: 0x00FD63C1
		private bool CanOpenTechRootView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingTech);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x06041649 RID: 267849 RVA: 0x00FD81E9 File Offset: 0x00FD63E9
		private bool CanOpenDockyardShopView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingItemDelete);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x0604164A RID: 267850 RVA: 0x00FD8214 File Offset: 0x00FD6414
		public void FishingInputHandler(string actionName)
		{
			if (actionName == "切换角色1")
			{
				this.OpenDockyardView();
				return;
			}
			if (actionName == "切换角色2")
			{
				this.OpenFishingQuestView();
				return;
			}
			if (actionName == "切换角色3")
			{
				this.OpenFishingTechRootView();
				return;
			}
			if (!(actionName == "切换角色4"))
			{
				return;
			}
			this.OpenFishingHandBookView();
		}

		// Token: 0x0604164B RID: 267851 RVA: 0x00FD8274 File Offset: 0x00FD6474
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.ShowFishingLevelUp));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x0604164C RID: 267852 RVA: 0x00FD82F0 File Offset: 0x00FD64F0
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.ShowFishingLevelUp));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x0604164D RID: 267853 RVA: 0x00FD836C File Offset: 0x00FD656C
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.FishingInfoUpdateNotify, delegate(IMessage response, Net.CallbackStatus _)
			{
			});
			Net.Instance.Register(ENotifyMessageId.FishingShipInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingShipInfo shipInfo = ((FishingShipInfoUpdateNotify)msg).ShipInfo;
				if (shipInfo != null)
				{
					DockyardModel.Instance.UpdateDockyardData(shipInfo.CabinInfo);
					FishingModel.Instance.GetShipData().RefreshData(shipInfo);
					if (shipInfo.EntityId == 0L)
					{
						MapModel.Instance.RemoveFishingShipMarkAndCache();
					}
				}
			});
			Net.Instance.Register(ENotifyMessageId.FishingNetCabinUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingNetCabinUpdateNotify fishingNetCabinUpdateNotify = (FishingNetCabinUpdateNotify)msg;
				DockyardModel.Instance.SetTrawlDataListFromServer(fishingNetCabinUpdateNotify.NetCabinItems.ToList<FishingItemInfo>());
			});
			Net.Instance.Register(ENotifyMessageId.FishingTechInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingTechInfoUpdateNotify fishingTechInfoUpdateNotify = (FishingTechInfoUpdateNotify)msg;
				FishingModel.Instance.UpdateFishingTechData(fishingTechInfoUpdateNotify.TechInfo);
			});
			Net.Instance.Register(ENotifyMessageId.FishingIllustratedInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingIllustratedInfoUpdateNotify fishingIllustratedInfoUpdateNotify = (FishingIllustratedInfoUpdateNotify)msg;
				FishingModel.Instance.RefreshHandBookData(fishingIllustratedInfoUpdateNotify.IllustratedInfo);
				FishingModel.Instance.FishingItemHandBookUnlockTraceList.AddRange(fishingIllustratedInfoUpdateNotify.UnlockDetections);
			});
			Net.Instance.Register(ENotifyMessageId.FishingIllustratedRewardInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingIllustratedRewardInfoUpdateNotify fishingIllustratedRewardInfoUpdateNotify = (FishingIllustratedRewardInfoUpdateNotify)msg;
				FishingModel.Instance.RefreshHandBookDataReward(fishingIllustratedRewardInfoUpdateNotify.RewardInfo);
			});
			Net.Instance.Register(ENotifyMessageId.FishingSceneFishCageInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingSceneFishCageInfoUpdateNotify fishingSceneFishCageInfoUpdateNotify = (FishingSceneFishCageInfoUpdateNotify)msg;
				FishingModel.Instance.AddCageDataFromServer(fishingSceneFishCageInfoUpdateNotify.SceneConfigId, fishingSceneFishCageInfoUpdateNotify.Cage);
			});
			Net.Instance.Register(ENotifyMessageId.SceneFishPointInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneFishPointInfoUpdateNotify sceneFishPointInfoUpdateNotify = (SceneFishPointInfoUpdateNotify)msg;
				if (sceneFishPointInfoUpdateNotify.FishPoint != null)
				{
					if (sceneFishPointInfoUpdateNotify.IsRemove)
					{
						FishingModel.Instance.RemoveOneFishingPointData(sceneFishPointInfoUpdateNotify.SceneConfigId, sceneFishPointInfoUpdateNotify.FishPoint);
						return;
					}
					FishingModel.Instance.RefreshFishingPointData(sceneFishPointInfoUpdateNotify.SceneConfigId, sceneFishPointInfoUpdateNotify.FishPoint);
				}
			});
			Net.Instance.Register(ENotifyMessageId.SceneTempFishPointInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				SceneTempFishPointInfoUpdateNotify sceneTempFishPointInfoUpdateNotify = (SceneTempFishPointInfoUpdateNotify)msg;
				if (sceneTempFishPointInfoUpdateNotify.FishPoint != null)
				{
					if (sceneTempFishPointInfoUpdateNotify.IsRemove)
					{
						FishingModel.Instance.RemoveTempFishingPointData(sceneTempFishPointInfoUpdateNotify.FishPoint);
					}
					else
					{
						FishingModel.Instance.SetTempFishingPointData(sceneTempFishPointInfoUpdateNotify.SceneConfigId, sceneTempFishPointInfoUpdateNotify.FishPoint);
					}
					EventSystem.Instance.Emit(EEventName.OnRefreshTempFishingPointNum);
				}
			});
			Net.Instance.Register(ENotifyMessageId.FishingShipForceBackNotify, delegate(IMessage response, Net.CallbackStatus _)
			{
			});
			Net.Instance.Register(ENotifyMessageId.FishingItemAddNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingItemAddNotify fishingItemAddNotify = (FishingItemAddNotify)msg;
				foreach (FishingItemInfo trawlData in fishingItemAddNotify.NetCabinItem)
				{
					DockyardModel.Instance.SetTrawlData(trawlData);
				}
				foreach (FishingItemInfo wareHouseData in fishingItemAddNotify.TempCabinItem)
				{
					DockyardModel.Instance.SetWareHouseData(wareHouseData);
				}
			});
			Net.Instance.Register(ENotifyMessageId.FishingNoticeUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingNoticeUpdateNotify fishingNoticeUpdateNotify = (FishingNoticeUpdateNotify)msg;
				FishingModel.Instance.RoleTalkIds = fishingNoticeUpdateNotify.NoticeIds.ToList<int>();
			});
			Net.Instance.Register(ENotifyMessageId.HandInInfoUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				HandInInfoUpdateNotify handInInfoUpdateNotify = (HandInInfoUpdateNotify)msg;
				FishingModel.Instance.UpdateInteractData(handInInfoUpdateNotify.HandInInfo);
			});
			Net.Instance.Register(ENotifyMessageId.FishingEntrustUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingEntrustUpdateNotify fishingEntrustUpdateNotify = (FishingEntrustUpdateNotify)msg;
				if (FishingQuestModel.Instance.CurrentTraceEntrust != fishingEntrustUpdateNotify.TraceEntrusts)
				{
					FishingQuestModel.Instance.CurrentTraceEntrust = fishingEntrustUpdateNotify.TraceEntrusts;
					FishingQuestModel.Instance.TraceEntrust();
				}
				FishingQuestModel.Instance.EntrustRefreshCostRatio = fishingEntrustUpdateNotify.EntrustRefreshRatio;
				FishingQuestModel.Instance.UpdateEntrusts(fishingEntrustUpdateNotify.Entrusts.ToDictionary((KeyValuePair<int, FishingEntrustStatus> x) => x.Key, (KeyValuePair<int, FishingEntrustStatus> x) => x.Value));
			});
			Net.Instance.Register(ENotifyMessageId.FishingBoatDieNotify, new Action<IMessage, Net.CallbackStatus>(this.FishingBoatDieNotify));
			Net.Instance.Register(ENotifyMessageId.FishingPortUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingPortUnlockNotify fishingPortUnlockNotify = (FishingPortUnlockNotify)msg;
				FishingModel.Instance.UnlockPort.AddRange(fishingPortUnlockNotify.UnlockPortId);
			});
			Net.Instance.Register(ENotifyMessageId.FishingGhostStateNotify, new Action<IMessage, Net.CallbackStatus>(this.FishingGhostStateNotify));
			Net.Instance.Register(ENotifyMessageId.FishingSkinUnlockNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingSkinUnlockNotify fishingSkinUnlockNotify = (FishingSkinUnlockNotify)msg;
				FishingModel.Instance.UnlockShipSkin.AddRange(fishingSkinUnlockNotify.UnlockSkins);
			});
			Net.Instance.Register(ENotifyMessageId.FishingPortUpdateNotify, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingPortUpdateNotify fishingPortUpdateNotify = (FishingPortUpdateNotify)msg;
				FishingShipData shipData = FishingModel.Instance.GetShipData();
				shipData.SetLastPortId(fishingPortUpdateNotify.LastPortId);
				shipData.SetIsInPortInternal(fishingPortUpdateNotify.IsInPort);
			});
		}

		// Token: 0x0604164E RID: 267854 RVA: 0x00FD86D0 File Offset: 0x00FD68D0
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.FishingInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingShipInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingNetCabinUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingTechInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingIllustratedInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingIllustratedRewardInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingSceneFishCageInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.SceneFishPointInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingShipForceBackNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingItemAddNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingNoticeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.HandInInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingEntrustUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingBoatDieNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingPortUnlockNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingGhostStateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.FishingSkinUnlockNotify);
		}

		// Token: 0x0604164F RID: 267855 RVA: 0x00FD87F0 File Offset: 0x00FD69F0
		[NullableContext(2)]
		private void FishingGhostStateNotify(IMessage msg, Net.CallbackStatus _)
		{
			FishingGhostStateNotify fishingGhostStateNotify = (FishingGhostStateNotify)msg;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Fishing;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "幽灵船玩法状态通知";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("是否开启", fishingGhostStateNotify.Open);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (fishingGhostStateNotify.Open)
			{
				UiManager.Instance.OpenView(EUiViewName.FishingWarningTips, null, null);
				return;
			}
			UiManager.Instance.CloseView(EUiViewName.FishingWarningTips, null);
		}

		// Token: 0x06041650 RID: 267856 RVA: 0x00FD8864 File Offset: 0x00FD6A64
		[NullableContext(2)]
		private void FishingBoatDieNotify(IMessage msg, Net.CallbackStatus _)
		{
			FishingController.<>c__DisplayClass22_0 CS$<>8__locals1 = new FishingController.<>c__DisplayClass22_0();
			CS$<>8__locals1.data = (FishingBoatDieNotify)msg;
			FishingController.<>c__DisplayClass22_0 CS$<>8__locals2 = CS$<>8__locals1;
			FishingBoatDieNotify data = CS$<>8__locals1.data;
			CS$<>8__locals2.position = ((data != null) ? data.Pos : null);
			if (CS$<>8__locals1.position == null)
			{
				Log.Instance.Error(ELogModule.Teleport, ELogAuthor.LYY, "捕鱼船死亡时目标位置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				FishingShipData shipData = FishingModel.Instance.GetShipData();
				EntityHandle entityHandle = shipData.GetEntityHandle();
				object obj;
				if (entityHandle == null)
				{
					obj = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					obj = ((entity != null) ? entity.GetComponent<FishingBoatDeathComponent>() : null);
				}
				object obj2 = obj;
				if (obj2 != null)
				{
					obj2.ExecuteRevive();
				}
				bool flag = shipData.IsShipDriving();
				FVectorDouble targetPosition = new FVectorDouble((double)CS$<>8__locals1.position.X, (double)CS$<>8__locals1.position.Y, (double)CS$<>8__locals1.position.Z);
				Aki.Protocol.Rotator rot = CS$<>8__locals1.data.Rot;
				float pitch = (rot != null) ? rot.Pitch : 0f;
				Aki.Protocol.Rotator rot2 = CS$<>8__locals1.data.Rot;
				float yaw = (rot2 != null) ? rot2.Yaw : 0f;
				Aki.Protocol.Rotator rot3 = CS$<>8__locals1.data.Rot;
				global::Rotator targetRotation = global::Rotator.Create(pitch, yaw, (rot3 != null) ? rot3.Roll : 0f);
				TransitionOptionPb transitionOptionPb = TransitionOptionPb.Create();
				transitionOptionPb.TransitionType = TransitionType.CenterText;
				TransitionFlowPb transitionFlowPb = TransitionFlowPb.Create();
				transitionFlowPb.FlowListName = "剧情_V2.1航海活动主线";
				transitionFlowPb.FlowId = 20;
				transitionFlowPb.StateId = 1;
				transitionOptionPb.TransitionFlow = transitionFlowPb;
				if (flag)
				{
					TeleportController.Instance.TeleportPlayerInVehicle(new ITeleportContextParam
					{
						ClientReason = "FishingBoatDie",
						TargetPosition = targetPosition,
						TargetRotation = targetRotation,
						ServerReason = new TeleportReason?(TeleportReason.FlowAction),
						Option = transitionOptionPb
					});
					return;
				}
				TeleportController.Instance.TeleportPlayer(new ITeleportContextParam
				{
					ClientReason = "FishingBoatDie",
					TargetPosition = targetPosition,
					TargetRotation = targetRotation,
					ServerReason = new TeleportReason?(TeleportReason.FlowAction),
					Option = transitionOptionPb
				});
			}, 1300f, null, null, true, 1f);
		}

		// Token: 0x06041651 RID: 267857 RVA: 0x00FD88E8 File Offset: 0x00FD6AE8
		private void RequestFishingInfo(EFunctionType id, bool isOpen)
		{
			if (id != EFunctionType.Fishing)
			{
				return;
			}
			if (!isOpen)
			{
				return;
			}
			FishingInfoRequest message = FishingInfoRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingInfoRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingInfoResponse fishingInfoResponse = (FishingInfoResponse)msg;
				if (fishingInfoResponse == null)
				{
					return;
				}
				DockyardModel.Instance.SetFishingShipData(fishingInfoResponse.FishingInfo.ShipInfo);
				FishingQuestModel.Instance.CurrentTraceEntrust = fishingInfoResponse.FishingInfo.TraceEntrusts;
				FishingQuestModel.Instance.TraceEntrust();
				FishingModel.Instance.RoleTalkIds = fishingInfoResponse.FishingInfo.NoticeIds.ToList<int>();
				FishingModel.Instance.UnlockPort = fishingInfoResponse.FishingInfo.UnlockPortId.ToList<int>();
				FishingModel.Instance.CurrentShipSkin = fishingInfoResponse.FishingInfo.ShipInfo.SkinId;
				FishingModel.Instance.UnlockShipSkin = fishingInfoResponse.FishingInfo.UnlockSkins.ToList<int>();
				FishingQuestModel.Instance.UpdateEntrusts(fishingInfoResponse.FishingInfo.Entrusts.ToDictionary((KeyValuePair<int, FishingEntrustStatus> x) => x.Key, (KeyValuePair<int, FishingEntrustStatus> x) => x.Value));
				FishingModel.Instance.GetShipData().RefreshData(fishingInfoResponse.FishingInfo.ShipInfo);
				FishingModel.Instance.SetFishingTechData(fishingInfoResponse.FishingInfo.FishingTech.ToList<FishingTechInfo>());
				FishingModel.Instance.SetCageDataMapFromServer(fishingInfoResponse.FishingInfo.SceneCages.ToDictionary<int, SceneFishCageInfo>());
				FishingModel.Instance.SetInteractData(fishingInfoResponse.FishingInfo.HandInInfo.ToList<HandInInfo>());
				FishingModel.Instance.SetAllFishingPointData(fishingInfoResponse.FishingInfo.SceneFishPoints.ToDictionary((KeyValuePair<int, SceneFishPointInfo> x) => x.Key, (KeyValuePair<int, SceneFishPointInfo> x) => x.Value));
				FishingModel.Instance.SetHandBookData(fishingInfoResponse.FishingInfo.IllustratedInfo);
				FishingQuestModel.Instance.EntrustRefreshCostRatio = fishingInfoResponse.FishingInfo.EntrustRefreshRatio;
				EventSystem.Instance.Emit(EEventName.OnRefreshTempFishingPointNum);
			}, 0);
		}

		// Token: 0x06041652 RID: 267858 RVA: 0x00FD8938 File Offset: 0x00FD6B38
		private void ShowFishingLevelUp(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (normalItem.Id == FishingModel.Instance.FishingReputationItemId)
			{
				FishingLevelUpData fishingLevelUpData = new FishingLevelUpData(lastCount, count);
				FishingModel.Instance.SetFishingLevelUpInfo(fishingLevelUpData);
				UiManager.Instance.OpenView(EUiViewName.FishingLevelUpTips, fishingLevelUpData, null);
			}
		}

		// Token: 0x06041653 RID: 267859 RVA: 0x00FD897C File Offset: 0x00FD6B7C
		private void OnCloseViewFinish(EUiViewName viewName, int i)
		{
			if (viewName != EUiViewName.DockyardWareHouseView && viewName != EUiViewName.CommonRewardView)
			{
				return;
			}
			FishingLevelUpData fishingLevelUpInfo = FishingModel.Instance.GetFishingLevelUpInfo();
			if (fishingLevelUpInfo != null && fishingLevelUpInfo.IsLevelUp())
			{
				this.TryOpenFishingLevelUpView();
			}
		}

		// Token: 0x06041654 RID: 267860 RVA: 0x00FD89C0 File Offset: 0x00FD6BC0
		private void TryOpenFishingLevelUpView()
		{
			if (!this.CanOpenFishingLevelUpView())
			{
				return;
			}
			FishingLevelUpData fishingLevelUpInfo = FishingModel.Instance.GetFishingLevelUpInfo();
			FishingModel.Instance.ClearLastFishingExp();
			UiManager.Instance.OpenView(EUiViewName.FishingLevelUpView, fishingLevelUpInfo, null);
		}

		// Token: 0x06041655 RID: 267861 RVA: 0x00FD89FC File Offset: 0x00FD6BFC
		private bool CanOpenFishingLevelUpView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.BattleView) || (UiManager.Instance.IsViewOpen(EUiViewName.FishingQuestView) && FishingModel.Instance.IsInDock);
		}

		// Token: 0x06041656 RID: 267862 RVA: 0x00FD8A30 File Offset: 0x00FD6C30
		public void RequestMultiFishingIllustratedRewardRequest(int[] rewardIds)
		{
			MulFishingIllustratedRewardRequest mulFishingIllustratedRewardRequest = MulFishingIllustratedRewardRequest.Create();
			mulFishingIllustratedRewardRequest.RewardId.AddRange(rewardIds);
			Net.Instance.Call(ERequestMessageId.MulFishingIllustratedRewardRequest, mulFishingIllustratedRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MulFishingIllustratedRewardResponse mulFishingIllustratedRewardResponse = (MulFishingIllustratedRewardResponse)msg;
				if (mulFishingIllustratedRewardResponse == null)
				{
					return;
				}
				if (mulFishingIllustratedRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(mulFishingIllustratedRewardResponse.ErrorCode, 29037, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06041657 RID: 267863 RVA: 0x00FD8A80 File Offset: 0x00FD6C80
		private unsafe void PrintRequestRightFishingDataListLog(List<FishingItemInfo> dataList, CabinType type)
		{
			if (DockyardModel.Instance.IsPrintLog)
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (FishingItemInfo fishingItemInfo in dataList)
				{
					stringBuilder.Append("\n");
					StringBuilder stringBuilder2 = stringBuilder;
					StringBuilder stringBuilder3 = stringBuilder2;
					StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(53, 5, stringBuilder2);
					appendInterpolatedStringHandler.AppendLiteral("IcId: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(fishingItemInfo.IncrId);
					appendInterpolatedStringHandler.AppendLiteral(", ItemId: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(fishingItemInfo.ItemId);
					appendInterpolatedStringHandler.AppendLiteral(", RowIndex: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(fishingItemInfo.Pos.Y);
					appendInterpolatedStringHandler.AppendLiteral(", ColumnIndex: ");
					appendInterpolatedStringHandler.AppendFormatted<int>(fishingItemInfo.Pos.X);
					appendInterpolatedStringHandler.AppendLiteral(", Rotate: ");
					appendInterpolatedStringHandler.AppendFormatted<FishingItemRotate>(fishingItemInfo.Rotate);
					stringBuilder3.Append(ref appendInterpolatedStringHandler);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Dockyard;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "输出请求前的背包数据信息";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("请求类型", type);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("背包道具信息", stringBuilder.ToString());
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}

		// Token: 0x06041658 RID: 267864 RVA: 0x00FD8BF0 File Offset: 0x00FD6DF0
		public void RequestFishingCabinPut(IRequestCabinPut requestData)
		{
			FishingCabinPutRequest fishingCabinPutRequest = FishingCabinPutRequest.Create();
			fishingCabinPutRequest.CabinType = requestData.Type;
			fishingCabinPutRequest.Id = requestData.RequestId.GetValueOrDefault();
			fishingCabinPutRequest.LeftFishingItems.AddRange(requestData.LeftDataList);
			fishingCabinPutRequest.RightFishingItems.AddRange(requestData.RightDataList);
			fishingCabinPutRequest.RemoveIncrId = requestData.RemoveIncId.GetValueOrDefault();
			this.PrintRequestRightFishingDataListLog(requestData.RightDataList, requestData.Type);
			Net.Instance.Call(ERequestMessageId.FishingCabinPutRequest, fishingCabinPutRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingCabinPutResponse fishingCabinPutResponse = (FishingCabinPutResponse)msg;
				if (fishingCabinPutResponse == null)
				{
					return;
				}
				bool flag = fishingCabinPutResponse.ErrorCode == Aki.Protocol.ErrorCode.Success;
				if (!flag)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingCabinPutResponse.ErrorCode, 27625, null, true, true);
				}
				Action<bool> callback = requestData.Callback;
				if (callback == null)
				{
					return;
				}
				callback(flag);
			}, 0);
		}

		// Token: 0x06041659 RID: 267865 RVA: 0x00FD8CB8 File Offset: 0x00FD6EB8
		public void RequestFishingQuickSell(Action<bool> callback)
		{
			FishingQuickSellRequest message = FishingQuickSellRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingQuickSellRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingQuickSellResponse fishingQuickSellResponse = (FishingQuickSellResponse)msg;
				if (fishingQuickSellResponse == null)
				{
					return;
				}
				bool flag = fishingQuickSellResponse.ErrorCode == Aki.Protocol.ErrorCode.Success;
				if (!flag)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingQuickSellResponse.ErrorCode, 26816, null, true, true);
				}
				callback(flag);
			}, 0);
		}

		// Token: 0x0604165A RID: 267866 RVA: 0x00FD8CF8 File Offset: 0x00FD6EF8
		public void TryRequestFishingSell(List<int> incIdList, List<int> itemIdList, bool banSkip, Action<bool> callback)
		{
			if (FishingQuestModel.Instance.OnFishingItemSell(itemIdList, banSkip, delegate
			{
				this.RequestFishingSell(incIdList, callback);
			}))
			{
				return;
			}
			this.RequestFishingSell(incIdList, callback);
		}

		// Token: 0x0604165B RID: 267867 RVA: 0x00FD8D50 File Offset: 0x00FD6F50
		public void RequestFishingSell(List<int> incIdList, Action<bool> callback)
		{
			FishingSellRequest fishingSellRequest = FishingSellRequest.Create();
			fishingSellRequest.IncrIds.AddRange(incIdList);
			Net.Instance.Call(ERequestMessageId.FishingSellRequest, fishingSellRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingSellResponse fishingSellResponse = (FishingSellResponse)msg;
				if (fishingSellResponse == null)
				{
					return;
				}
				bool flag = fishingSellResponse.ErrorCode == Aki.Protocol.ErrorCode.Success;
				if (!flag)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingSellResponse.ErrorCode, 29274, null, true, true);
				}
				callback(flag);
			}, 0);
		}

		// Token: 0x0604165C RID: 267868 RVA: 0x00FD8D9C File Offset: 0x00FD6F9C
		public void RequestFishingSailingRequest(bool fix, int portId, int time)
		{
			FishingSailingRequest fishingSailingRequest = FishingSailingRequest.Create();
			fishingSailingRequest.Fix = fix;
			fishingSailingRequest.PortId = portId;
			Net.Instance.Call(ERequestMessageId.FishingSailingRequest, fishingSailingRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingSailingResponse fishingSailingResponse = (FishingSailingResponse)msg;
				if (fishingSailingResponse == null)
				{
					return;
				}
				if (fishingSailingResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingSailingResponse.ErrorCode, 16408, null, true, true);
					return;
				}
				UiManager.Instance.CloseView(EUiViewName.SailingView, null);
				UiManager.Instance.CloseView(EUiViewName.FishingDockView, null);
				FishingModel.Instance.SaveLocalSailingIsFix(fix);
				if (time == 1)
				{
					TimeOfDayController.Instance.AdjustTime(18000.0, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
				}
				else if (time == 2)
				{
					TimeOfDayController.Instance.AdjustTime(68400.0, SceneDateUpdateReason.LevelPlayAuto, 0U, true);
				}
				EventSystem.Instance.Emit<int>(EEventName.OnFishingSailing, FishingQuestModel.Instance.CurrentTraceEntrust);
			}, 0);
		}

		// Token: 0x0604165D RID: 267869 RVA: 0x00FD8DF4 File Offset: 0x00FD6FF4
		public void RequestFishingShipFixRequest()
		{
			FishingShipFixRequest message = FishingShipFixRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingShipFixRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingShipFixResponse fishingShipFixResponse = (FishingShipFixResponse)msg;
				if (fishingShipFixResponse == null)
				{
					return;
				}
				if (fishingShipFixResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingShipFixResponse.ErrorCode, 20583, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0604165E RID: 267870 RVA: 0x00FD8E38 File Offset: 0x00FD7038
		public void RequestFishingEntrustHandInRequest(int entrustId, IReadOnlyList<FishingHandInItem> itemList)
		{
			FishingEntrustHandInRequest fishingEntrustHandInRequest = FishingEntrustHandInRequest.Create();
			fishingEntrustHandInRequest.EntrustId = entrustId;
			fishingEntrustHandInRequest.HandInItem.AddRange(itemList);
			Net.Instance.Call(ERequestMessageId.FishingEntrustHandInRequest, fishingEntrustHandInRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingEntrustHandInResponse fishingEntrustHandInResponse = (FishingEntrustHandInResponse)msg;
				if (fishingEntrustHandInResponse == null)
				{
					return;
				}
				if (fishingEntrustHandInResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustHandInResponse.ErrorCode, 25865, null, true, true);
					return;
				}
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, false, null);
				FishingQuestModel.Instance.AutoTraceEntrust();
			}, 0);
		}

		// Token: 0x0604165F RID: 267871 RVA: 0x00FD8E90 File Offset: 0x00FD7090
		public void RequestFishingEntrustTrace(int entrustId)
		{
			FishingEntrustTraceRequest fishingEntrustTraceRequest = FishingEntrustTraceRequest.Create();
			fishingEntrustTraceRequest.EntrustId = entrustId;
			Net.Instance.Call(ERequestMessageId.FishingEntrustTraceRequest, fishingEntrustTraceRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingEntrustTraceResponse fishingEntrustTraceResponse = (FishingEntrustTraceResponse)msg;
				if (fishingEntrustTraceResponse == null)
				{
					return;
				}
				if (fishingEntrustTraceResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustTraceResponse.ErrorCode, 16672, null, true, true);
					FishingQuestModel.Instance.TraceFormClick = false;
					return;
				}
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, true, null);
			}, 0);
		}

		// Token: 0x06041660 RID: 267872 RVA: 0x00FD8EDC File Offset: 0x00FD70DC
		public void RequestFishingEntrustRefresh(int entrustId)
		{
			FishingEntrustRefreshRequest fishingEntrustRefreshRequest = FishingEntrustRefreshRequest.Create();
			fishingEntrustRefreshRequest.EntrustId = entrustId;
			Net.Instance.Call(ERequestMessageId.FishingEntrustRefreshRequest, fishingEntrustRefreshRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingEntrustRefreshResponse fishingEntrustRefreshResponse = (FishingEntrustRefreshResponse)msg;
				if (fishingEntrustRefreshResponse == null)
				{
					return;
				}
				if (fishingEntrustRefreshResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustRefreshResponse.ErrorCode, 28664, null, true, true);
					return;
				}
				int entrustId2 = fishingEntrustRefreshResponse.EntrustId;
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, false, new int?(entrustId2));
			}, 0);
		}

		// Token: 0x06041661 RID: 267873 RVA: 0x00FD8F28 File Offset: 0x00FD7128
		public void RequestFishingEntrustAccept(int entrustId, bool isAccept, Action func = null)
		{
			FishingEntrustAcceptRequest fishingEntrustAcceptRequest = FishingEntrustAcceptRequest.Create();
			fishingEntrustAcceptRequest.EntrustId = entrustId;
			fishingEntrustAcceptRequest.Accept = isAccept;
			Net.Instance.Call(ERequestMessageId.FishingEntrustAcceptRequest, fishingEntrustAcceptRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingEntrustAcceptResponse fishingEntrustAcceptResponse = (FishingEntrustAcceptResponse)msg;
				if (fishingEntrustAcceptResponse == null)
				{
					return;
				}
				if (fishingEntrustAcceptResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustAcceptResponse.ErrorCode, 28877, null, true, true);
					return;
				}
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, true, null);
				Action func2 = func;
				if (func2 == null)
				{
					return;
				}
				func2();
			}, 0);
		}

		// Token: 0x06041662 RID: 267874 RVA: 0x00FD8F74 File Offset: 0x00FD7174
		public void RequestFishingTechLevelUp(int nodeId)
		{
			FishingTechLevelUpRequest fishingTechLevelUpRequest = FishingTechLevelUpRequest.Create();
			fishingTechLevelUpRequest.NodeId = nodeId;
			Net.Instance.Call(ERequestMessageId.FishingTechLevelUpRequest, fishingTechLevelUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingTechLevelUpResponse fishingTechLevelUpResponse = (FishingTechLevelUpResponse)msg;
				if (fishingTechLevelUpResponse == null)
				{
					return;
				}
				if (fishingTechLevelUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingTechLevelUpResponse.ErrorCode, 25533, null, true, true);
					return;
				}
				FishingTech fishingTechById = FishingConfig.Instance.GetFishingTechById(nodeId);
				int techNodeCurrentLevel = FishingModel.Instance.GetTechNodeCurrentLevel(nodeId);
				if (techNodeCurrentLevel == 0)
				{
					return;
				}
				FishingTechEffect fishingTechEffectById = FishingConfig.Instance.GetFishingTechEffectById(fishingTechById.Effect(techNodeCurrentLevel - 1));
				LevelUpSuccessEffectData param = new LevelUpSuccessEffectData
				{
					Title = "FishingTechLevelUpSuccessTitle",
					TextList = new List<SingleText>
					{
						new SingleText
						{
							TextId = fishingTechEffectById.Desc,
							Params = fishingTechEffectById.ShowParams()
						}
					}
				};
				UiManager.Instance.OpenView(EUiViewName.FishingTechLevelUpSuccessView, param, null);
				this.PlayRoleTechAudio((EFishingTechNodeType)fishingTechById.Type);
			}, 0);
		}

		// Token: 0x06041663 RID: 267875 RVA: 0x00FD8FC4 File Offset: 0x00FD71C4
		public UniTask RequestFishingPointInfo(int sceneId, int id)
		{
			FishingController.<RequestFishingPointInfo>d__41 <RequestFishingPointInfo>d__;
			<RequestFishingPointInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestFishingPointInfo>d__.sceneId = sceneId;
			<RequestFishingPointInfo>d__.id = id;
			<RequestFishingPointInfo>d__.<>1__state = -1;
			<RequestFishingPointInfo>d__.<>t__builder.Start<FishingController.<RequestFishingPointInfo>d__41>(ref <RequestFishingPointInfo>d__);
			return <RequestFishingPointInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06041664 RID: 267876 RVA: 0x00FD9010 File Offset: 0x00FD7210
		public void RequestFishingShipSkinChange(int skinId)
		{
			FishingShipSkinChangeRequest fishingShipSkinChangeRequest = FishingShipSkinChangeRequest.Create();
			fishingShipSkinChangeRequest.SkinId = skinId;
			fishingShipSkinChangeRequest.PortId = FishingModel.Instance.DockId;
			Net.Instance.Call(ERequestMessageId.FishingShipSkinChangeRequest, fishingShipSkinChangeRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingShipSkinChangeResponse fishingShipSkinChangeResponse = (FishingShipSkinChangeResponse)msg;
				if (fishingShipSkinChangeResponse == null)
				{
					return;
				}
				if (fishingShipSkinChangeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingShipSkinChangeResponse.ErrorCode, 15401, null, true, true);
					return;
				}
				FishingModel.Instance.CurrentShipSkin = skinId;
				EventSystem.Instance.Emit(EEventName.FishingShipSkinChangeSuccess);
			}, 0);
		}

		// Token: 0x06041665 RID: 267877 RVA: 0x00FD9069 File Offset: 0x00FD7269
		private void RecordNeedShowExitConfirmBox(bool isSelectOn)
		{
			DockyardModel.Instance.IsNeedShowExitConfirmBox = !isSelectOn;
		}

		// Token: 0x06041666 RID: 267878 RVA: 0x00FD907C File Offset: 0x00FD727C
		public void ShowExitFishingViewConfirm(Action closeFunc)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DockyardExitFishing);
			confirmBoxDataNew.FunctionMap[2] = closeFunc;
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = ConfigMultiTextLang.GetLocalTextNew("Fishing_LoginRepeat", null);
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.RecordNeedShowExitConfirmBox));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06041667 RID: 267879 RVA: 0x00FD90D8 File Offset: 0x00FD72D8
		[NullableContext(2)]
		public void ShowConfirmBoxAndRequestFishingExit(Action<bool> callback = null)
		{
			bool flag = DockyardModel.Instance.GetWareHouseDataSize() > 0;
			Action<bool> <>9__1;
			Action action = delegate()
			{
				FishingController instance = FishingController.Instance;
				Action<bool> callback2;
				if ((callback2 = <>9__1) == null)
				{
					callback2 = (<>9__1 = delegate(bool success)
					{
						FishingQteGameInfo gameInfo = FishingQteModel.Instance.GameInfo;
						if (gameInfo != null)
						{
							gameInfo.SetGameStage(EFishingQteStage.Destroy);
						}
						Action<bool> callback3 = callback;
						if (callback3 == null)
						{
							return;
						}
						callback3(success);
					});
				}
				instance.RequestFishingExit(callback2);
			};
			if (flag && DockyardModel.Instance.IsNeedShowExitConfirmBox)
			{
				FishingController.Instance.ShowExitFishingViewConfirm(action);
				return;
			}
			action();
		}

		// Token: 0x06041668 RID: 267880 RVA: 0x00FD912C File Offset: 0x00FD732C
		[NullableContext(2)]
		public void RequestFishingExit(Action<bool> callback = null)
		{
			FishingExitRequest message = FishingExitRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingExitRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				if ((FishingExitResponse)msg == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else
				{
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06041669 RID: 267881 RVA: 0x00FD9169 File Offset: 0x00FD7369
		public bool IsInFishingShip()
		{
			return FishingModel.Instance.GetShipData().IsShipDriving();
		}

		// Token: 0x0604166A RID: 267882 RVA: 0x00FD917C File Offset: 0x00FD737C
		public void ConfirmToTeleportToPort(Action closeFunc)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ConfirmToTeleportToPort);
			confirmBoxDataNew.FunctionMap[2] = closeFunc;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0604166B RID: 267883 RVA: 0x00FD91B0 File Offset: 0x00FD73B0
		public void TeleportToPortPosition(int portId)
		{
			FishingPort fishingPortConfig = FishingConfig.Instance.GetFishingPortConfig(portId);
			FishingPosition fishingPortPosition = FishingConfig.Instance.GetFishingPortPosition(fishingPortConfig.AshorePoint);
			EntityHandle entityHandle = FishingModel.Instance.GetShipData().GetEntityHandle();
			object obj;
			if (entityHandle == null)
			{
				obj = null;
			}
			else
			{
				WorldEntity entity = entityHandle.Entity;
				obj = ((entity != null) ? entity.GetComponent<BaseVehiclePerformComponent>() : null);
			}
			object obj2 = obj;
			if (obj2 != null)
			{
				obj2.TryLeave(Global.BaseCharacter.CharacterActorComponent.Entity, ELeaveVehicleType.StandUp);
			}
			int[] array = fishingPortPosition.Position();
			global::Vector vector = global::Vector.Create((double)array[0], (double)array[1], (double)array[2]);
			int[] array2 = fishingPortPosition.Rotation();
			global::Rotator rotator = global::Rotator.Create((float)array2[1], (float)array2[2], (float)array2[0]);
			ITeleportContextParam param = new ITeleportContextParam
			{
				ClientReason = "FishingController",
				TargetPosition = vector.ToUeVector(false),
				TargetRotation = rotator.ToUeRotator()
			};
			TeleportController.Instance.TeleportPlayer(param);
		}

		// Token: 0x0604166C RID: 267884 RVA: 0x00FD9298 File Offset: 0x00FD7498
		public void RequestFishingHandIn(IRequestHandleIn requestData)
		{
			FishingHandInRequest fishingHandInRequest = FishingHandInRequest.Create();
			fishingHandInRequest.Id = requestData.InteractId;
			fishingHandInRequest.LeftFishingItems.AddRange(requestData.LeftDataList);
			fishingHandInRequest.RightFishingItems.AddRange(requestData.RightDataList);
			fishingHandInRequest.RemoveIncrId = requestData.RemoveIncId.GetValueOrDefault();
			fishingHandInRequest.ActionIncrId = requestData.ActionIncId;
			Net.Instance.Call(ERequestMessageId.FishingHandInRequest, fishingHandInRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingHandInResponse fishingHandInResponse = (FishingHandInResponse)msg;
				if (fishingHandInResponse == null)
				{
					return;
				}
				bool flag = fishingHandInResponse.ErrorCode == Aki.Protocol.ErrorCode.Success;
				if (!flag)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingHandInResponse.ErrorCode, 15662, null, true, true);
				}
				Action<bool, bool> callback = requestData.Callback;
				if (callback == null)
				{
					return;
				}
				callback(flag, fishingHandInResponse.HandInComplete);
			}, 0);
		}

		// Token: 0x0604166D RID: 267885 RVA: 0x00FD933C File Offset: 0x00FD753C
		public EFishingSkillCheckResult CheckFishingSkillCanBegin(EFishingSkillType type)
		{
			if (type != EFishingSkillType.炸鱼)
			{
				if (type != EFishingSkillType.鱼饵)
				{
					return EFishingSkillCheckResult.Usable;
				}
				if (!this.CheckFishingSkillCostEnough())
				{
					return EFishingSkillCheckResult.ItemNotEnough;
				}
				if (FishingModel.Instance.GetTempFishingPointNum() >= FishingModel.Instance.GetTempFishingPointLimit())
				{
					return EFishingSkillCheckResult.TempFishingPointLimit;
				}
				return EFishingSkillCheckResult.Usable;
			}
			else
			{
				if (!this.CheckFishingSkillCostEnough())
				{
					return EFishingSkillCheckResult.ItemNotEnough;
				}
				return EFishingSkillCheckResult.Usable;
			}
		}

		// Token: 0x0604166E RID: 267886 RVA: 0x00FD937C File Offset: 0x00FD757C
		public void ShowFishingSkillTips(EFishingSkillType type, EFishingSkillCheckResult result)
		{
			switch (result)
			{
			case EFishingSkillCheckResult.ItemNotEnough:
				if (type == EFishingSkillType.炸鱼)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillTip1", Array.Empty<object>());
					return;
				}
				if (type == EFishingSkillType.鱼饵)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillTip3", Array.Empty<object>());
					return;
				}
				break;
			case EFishingSkillCheckResult.SkillInCd:
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillTip2", Array.Empty<object>());
				return;
			case EFishingSkillCheckResult.TempFishingPointLimit:
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillTip6", Array.Empty<object>());
				break;
			default:
				return;
			}
		}

		// Token: 0x0604166F RID: 267887 RVA: 0x00FD93F9 File Offset: 0x00FD75F9
		public void BeginFishingSkill(EFishingSkillType type)
		{
			switch (type)
			{
			case EFishingSkillType.传送:
				FishingController.Instance.RequestFishingSkillTeleport();
				return;
			case EFishingSkillType.炸鱼:
				FishingController.Instance.RequestFishingSkillBomb();
				return;
			case EFishingSkillType.鱼饵:
				FishingController.Instance.RequestFishingSkillBait();
				return;
			default:
				return;
			}
		}

		// Token: 0x06041670 RID: 267888 RVA: 0x00FD9430 File Offset: 0x00FD7630
		private void RequestFishingSkillTeleport()
		{
			FishingSkillTeleportRequest message = FishingSkillTeleportRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingSkillTeleportRequest, message, delegate(IMessage _, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x06041671 RID: 267889 RVA: 0x00FD9474 File Offset: 0x00FD7674
		private void RequestFishingSkillBomb()
		{
			int fishingSkillCostId = this.GetFishingSkillCostId();
			if (fishingSkillCostId <= 0)
			{
				return;
			}
			FishingSkillBombRequest fishingSkillBombRequest = FishingSkillBombRequest.Create();
			fishingSkillBombRequest.ItemId = fishingSkillCostId;
			Net.Instance.Call(ERequestMessageId.FishingSkillBombRequest, fishingSkillBombRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingSkillBombResponse fishingSkillBombResponse = (FishingSkillBombResponse)msg;
				if (fishingSkillBombResponse == null || fishingSkillBombResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					return;
				}
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillTip5", Array.Empty<object>());
				List<DockyardItemBlockOriginalData> list = new List<DockyardItemBlockOriginalData>();
				foreach (FishingItemInfo data in fishingSkillBombResponse.Items)
				{
					DockyardItemBlockOriginalData item = new DockyardItemBlockOriginalData(data);
					list.Add(item);
				}
				FishingQteController.Instance.OpenFishingSuccessView(list, null);
			}, 0);
		}

		// Token: 0x06041672 RID: 267890 RVA: 0x00FD94CC File Offset: 0x00FD76CC
		private void RequestFishingSkillBait()
		{
			int fishingSkillCostId = this.GetFishingSkillCostId();
			if (fishingSkillCostId <= 0)
			{
				return;
			}
			FishingSkillBaitRequest fishingSkillBaitRequest = FishingSkillBaitRequest.Create();
			fishingSkillBaitRequest.ItemId = fishingSkillCostId;
			Net.Instance.Call(ERequestMessageId.FishingSkillBaitRequest, fishingSkillBaitRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingSkillBaitResponse fishingSkillBaitResponse = (FishingSkillBaitResponse)msg;
				if (fishingSkillBaitResponse != null && fishingSkillBaitResponse.ErrorCode == Aki.Protocol.ErrorCode.Success)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_SkillTip4", Array.Empty<object>());
				}
			}, 0);
		}

		// Token: 0x06041673 RID: 267891 RVA: 0x00FD9524 File Offset: 0x00FD7724
		private bool CheckFishingSkillCostEnough()
		{
			int fishingSkillCostId = this.GetFishingSkillCostId();
			return fishingSkillCostId > 0 && InventoryModel.Instance.GetItemCountByConfigId(fishingSkillCostId, 0) > 0;
		}

		// Token: 0x06041674 RID: 267892 RVA: 0x00FD9550 File Offset: 0x00FD7750
		public int GetFishingSkillCostId()
		{
			int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
			ExploreTools value;
			ExploreTools? exploreTools = RouletteModel.Instance.UnlockExploreSkillDataMap.TryGetValue(currentExploreSkillId, out value) ? new ExploreTools?(value) : null;
			if (exploreTools == null)
			{
				return 0;
			}
			Dictionary<int, int> dictionary = exploreTools.Value.Cost();
			if (dictionary.Count <= 0)
			{
				return 0;
			}
			return dictionary.Keys.First<int>();
		}

		// Token: 0x06041675 RID: 267893 RVA: 0x00FD95C1 File Offset: 0x00FD77C1
		public void FishingTeleportToBoat()
		{
			if (!TeleportModel.Instance.AllowTeleportByUi)
			{
				GenericPromptController.Instance.ShowPromptByCode("TrialRoleTransmitLimit", Array.Empty<object>());
				return;
			}
			if (TeleportMisc.ShowTeleportConfirmBox(new Action(this.RequestFishingTeleportToBoat)))
			{
				return;
			}
			this.RequestFishingTeleportToBoat();
		}

		// Token: 0x06041676 RID: 267894 RVA: 0x00FD9600 File Offset: 0x00FD7800
		private void RequestFishingTeleportToBoat()
		{
			GameModeModel.Instance.IsTeleport = true;
			FishingTeleportToBoatRequest message = FishingTeleportToBoatRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingTeleportToBoatRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingTeleportToBoatResponse fishingTeleportToBoatResponse = (FishingTeleportToBoatResponse)msg;
				if (fishingTeleportToBoatResponse != null && fishingTeleportToBoatResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingTeleportToBoatResponse.ErrorCode, 16996, null, true, true);
				}
				GameModeModel.Instance.IsTeleport = false;
			}, 0);
		}

		// Token: 0x06041677 RID: 267895 RVA: 0x00FD9650 File Offset: 0x00FD7850
		public void PlayRoleTechAudio(EFishingTechNodeType type)
		{
			this.StopRoleTechAudio();
			double num = Math.Ceiling(new Random().NextDouble() * 3.0);
			string text = "";
			if (type == EFishingTechNodeType.MainRole)
			{
				text = ((PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? "play_vo_nvzhu_sys_fishing_techupgrade0" : "play_vo_nanzhu_sys_fishing_techupgrade0");
			}
			else if (type == EFishingTechNodeType.Phoebe)
			{
				text = "play_vo_feibi_sys_fishing_techupgrade0";
			}
			if (text == "")
			{
				return;
			}
			text += num.ToString();
			this.RoleTechAudioHandle = text;
			AudioSystem.Instance.PostEvent(text);
		}

		// Token: 0x06041678 RID: 267896 RVA: 0x00FD96DC File Offset: 0x00FD78DC
		public void StopRoleTechAudio()
		{
			if (!StringUtils.IsEmpty(this.RoleTechAudioHandle))
			{
				AudioSystem.Instance.ExecuteAction(this.RoleTechAudioHandle, EAudioActionType.Stop, null);
				this.RoleTechAudioHandle = "";
			}
		}

		// Token: 0x06041679 RID: 267897 RVA: 0x00FD971C File Offset: 0x00FD791C
		public void HideEffectInWorld()
		{
			foreach (int pbDataId in FishingDefine.fishingEffectList)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null)
				{
					WorldEntity entity = entityByPbDataId.Entity;
					if (entity != null)
					{
						entity.DisableByKey(EEntityDisableKey.FishingEffect, true);
					}
				}
			}
		}

		// Token: 0x0604167A RID: 267898 RVA: 0x00FD978C File Offset: 0x00FD798C
		public void ShowEffectInWorld()
		{
			foreach (int pbDataId in FishingDefine.fishingEffectList)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
				if (entityByPbDataId != null)
				{
					WorldEntity entity = entityByPbDataId.Entity;
					if (entity != null)
					{
						entity.EnableByKey(EEntityDisableKey.FishingEffect, true);
					}
				}
			}
		}

		// Token: 0x17009599 RID: 38297
		// (get) Token: 0x0604167B RID: 267899 RVA: 0x00FD97FC File Offset: 0x00FD79FC
		public static FishingController Instance
		{
			get
			{
				return FishingController._Instance;
			}
		}

		// Token: 0x0604167C RID: 267900 RVA: 0x00FD9803 File Offset: 0x00FD7A03
		public static FishingController GetOrCreateInstance()
		{
			if (FishingController._Instance == null)
			{
				FishingController.CreateInstance();
			}
			return FishingController._Instance;
		}

		// Token: 0x0604167D RID: 267901 RVA: 0x00FD9817 File Offset: 0x00FD7A17
		public static bool CreateInstance()
		{
			if (FishingController._Instance != null)
			{
				return true;
			}
			FishingController._Instance = new FishingController();
			return true;
		}

		// Token: 0x0604167E RID: 267902 RVA: 0x00FD982D File Offset: 0x00FD7A2D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604167F RID: 267903 RVA: 0x00FD982F File Offset: 0x00FD7A2F
		public static void ResetStaticDefaultValue()
		{
			FishingController._Instance = null;
		}

		// Token: 0x06041680 RID: 267904 RVA: 0x00FD9837 File Offset: 0x00FD7A37
		static FishingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingController.CreateStaticDefaultValue), new Action(FishingController.ResetStaticDefaultValue));
		}

		// Token: 0x04022034 RID: 139316
		private const int FISHING_SHIP_DEAD_TIME = 1300;

		// Token: 0x04022035 RID: 139317
		private string RoleTechAudioHandle = "";

		// Token: 0x04022036 RID: 139318
		[Nullable(2)]
		private static FishingController _Instance;
	}
}
