using System;
using System.Collections.Generic;
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
	// Token: 0x02005554 RID: 21844
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class FishingController : UiControllerBase
	{
		// Token: 0x06036301 RID: 221953 RVA: 0x00F1EF68 File Offset: 0x00F1D168
		public void OpenDockyardView()
		{
			DockyardViewModel param = new DockyardViewModel();
			UiManager.Instance.OpenView(EUiViewName.DockyardView, param, null);
		}

		// Token: 0x06036302 RID: 221954 RVA: 0x00F1EF8C File Offset: 0x00F1D18C
		public void OpenDockyardWareHouseView(bool inGameplayFlow = false)
		{
			DockyardWareHouseViewModel dockyardWareHouseViewModel = new DockyardWareHouseViewModel();
			dockyardWareHouseViewModel.InGameplayFlow = inGameplayFlow;
			UiManager.Instance.OpenView(EUiViewName.DockyardWareHouseView, dockyardWareHouseViewModel, null);
		}

		// Token: 0x06036303 RID: 221955 RVA: 0x00F1EFB8 File Offset: 0x00F1D1B8
		public UniTask OpenDockyardCageView(int configId)
		{
			FishingController.<OpenDockyardCageView>d__4 <OpenDockyardCageView>d__;
			<OpenDockyardCageView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenDockyardCageView>d__.configId = configId;
			<OpenDockyardCageView>d__.<>1__state = -1;
			<OpenDockyardCageView>d__.<>t__builder.Start<FishingController.<OpenDockyardCageView>d__4>(ref <OpenDockyardCageView>d__);
			return <OpenDockyardCageView>d__.<>t__builder.Task;
		}

		// Token: 0x06036304 RID: 221956 RVA: 0x00F1EFFC File Offset: 0x00F1D1FC
		public void OpenDockyardInteractView(int configId, int actionIncId)
		{
			DockyardInteractViewModel dockyardInteractViewModel = new DockyardInteractViewModel();
			dockyardInteractViewModel.ConfigId = configId;
			dockyardInteractViewModel.ActionIncId = actionIncId;
			UiManager.Instance.OpenView(EUiViewName.DockyardInteractView, dockyardInteractViewModel, null);
		}

		// Token: 0x06036305 RID: 221957 RVA: 0x00F1F02E File Offset: 0x00F1D22E
		public void OpenDockyardShopView(EDockyardShopTabType? tabType = null)
		{
			if (!FunctionModel.Instance.IsOpen(10077))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.DockyardShopMainView, tabType, null);
		}

		// Token: 0x06036306 RID: 221958 RVA: 0x00F1F06C File Offset: 0x00F1D26C
		public void OpenFishingTechRootView()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingTechRootView, null, null);
		}

		// Token: 0x06036307 RID: 221959 RVA: 0x00F1F07F File Offset: 0x00F1D27F
		public void OpenFishingHandBookView()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingHandBookView, null, null);
		}

		// Token: 0x06036308 RID: 221960 RVA: 0x00F1F092 File Offset: 0x00F1D292
		public void OpenFishingQuestView()
		{
			UiManager.Instance.OpenView(EUiViewName.FishingQuestView, null, null);
		}

		// Token: 0x06036309 RID: 221961 RVA: 0x00F1F0A8 File Offset: 0x00F1D2A8
		protected override void OnAddOpenViewCheckFunction()
		{
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.FishingQuestView, new Func<EUiViewName, object, bool>(this.CanOpenQuestView), "FishingController.CanOpenFishingQuestView");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.FishingHandBookView, new Func<EUiViewName, object, bool>(this.CanOpenHandBookView), "FishingController.CanOpenHandBookView");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.FishingTechRootView, new Func<EUiViewName, object, bool>(this.CanOpenTechRootView), "FishingController.CanOpenTechRootView");
			UiManager.Instance.AddOpenViewCheckFunction(EUiViewName.DockyardShopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDockyardShopView), "FishingController.CanOpenDockyardShopView");
		}

		// Token: 0x0603630A RID: 221962 RVA: 0x00F1F138 File Offset: 0x00F1D338
		protected override void OnRemoveOpenViewCheckFunction()
		{
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.FishingQuestView, new Func<EUiViewName, object, bool>(this.CanOpenQuestView));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.FishingHandBookView, new Func<EUiViewName, object, bool>(this.CanOpenHandBookView));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.FishingTechRootView, new Func<EUiViewName, object, bool>(this.CanOpenTechRootView));
			UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.DockyardShopMainView, new Func<EUiViewName, object, bool>(this.CanOpenDockyardShopView));
		}

		// Token: 0x0603630B RID: 221963 RVA: 0x00F1F1B1 File Offset: 0x00F1D3B1
		private bool CanOpenQuestView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingEntrust);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x0603630C RID: 221964 RVA: 0x00F1F1D9 File Offset: 0x00F1D3D9
		private bool CanOpenHandBookView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingHandBook);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x0603630D RID: 221965 RVA: 0x00F1F201 File Offset: 0x00F1D401
		private bool CanOpenTechRootView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingTech);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x0603630E RID: 221966 RVA: 0x00F1F229 File Offset: 0x00F1D429
		private bool CanOpenDockyardShopView(EUiViewName viewName, object param)
		{
			bool flag = FunctionModel.Instance.IsOpen(EFunctionType.FishingItemDelete);
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_NotOpenFunction", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x0603630F RID: 221967 RVA: 0x00F1F254 File Offset: 0x00F1D454
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

		// Token: 0x06036310 RID: 221968 RVA: 0x00F1F2B4 File Offset: 0x00F1D4B4
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Add<IProto_NormalItem, int, int>(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.ShowFishingLevelUp));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x06036311 RID: 221969 RVA: 0x00F1F330 File Offset: 0x00F1D530
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.RequestFishingInfo));
			EventSystem.Instance.Remove(EEventName.OnCommonItemCountRefresh, new Action<IProto_NormalItem, int, int>(this.ShowFishingLevelUp));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseViewFinish));
		}

		// Token: 0x06036312 RID: 221970 RVA: 0x00F1F3AC File Offset: 0x00F1D5AC
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
				DockyardModel.Instance.SetTrawlDataListFromServer(fishingNetCabinUpdateNotify.NetCabinItems);
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
				FishingModel.Instance.RoleTalkIds = new List<int>(fishingNoticeUpdateNotify.NoticeIds);
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
				FishingQuestModel.Instance.UpdateEntrusts(new Dictionary<int, FishingEntrustStatus>(fishingEntrustUpdateNotify.Entrusts));
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

		// Token: 0x06036313 RID: 221971 RVA: 0x00F1F710 File Offset: 0x00F1D910
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

		// Token: 0x06036314 RID: 221972 RVA: 0x00F1F830 File Offset: 0x00F1DA30
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

		// Token: 0x06036315 RID: 221973 RVA: 0x00F1F8A4 File Offset: 0x00F1DAA4
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

		// Token: 0x06036316 RID: 221974 RVA: 0x00F1F928 File Offset: 0x00F1DB28
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
				FishingModel.Instance.RoleTalkIds = new List<int>(fishingInfoResponse.FishingInfo.NoticeIds);
				FishingModel.Instance.UnlockPort = new List<int>(fishingInfoResponse.FishingInfo.UnlockPortId);
				FishingModel.Instance.CurrentShipSkin = fishingInfoResponse.FishingInfo.ShipInfo.SkinId;
				FishingModel.Instance.UnlockShipSkin = new List<int>(fishingInfoResponse.FishingInfo.UnlockSkins);
				FishingQuestModel.Instance.UpdateEntrusts(new Dictionary<int, FishingEntrustStatus>(fishingInfoResponse.FishingInfo.Entrusts));
				FishingModel.Instance.GetShipData().RefreshData(fishingInfoResponse.FishingInfo.ShipInfo);
				FishingModel.Instance.SetFishingTechData(fishingInfoResponse.FishingInfo.FishingTech);
				FishingModel.Instance.SetCageDataMapFromServer(new Dictionary<int, SceneFishCageInfo>(fishingInfoResponse.FishingInfo.SceneCages));
				FishingModel.Instance.SetInteractData(fishingInfoResponse.FishingInfo.HandInInfo);
				FishingModel.Instance.SetAllFishingPointData(new Dictionary<int, SceneFishPointInfo>(fishingInfoResponse.FishingInfo.SceneFishPoints));
				FishingModel.Instance.SetHandBookData(fishingInfoResponse.FishingInfo.IllustratedInfo);
				FishingQuestModel.Instance.EntrustRefreshCostRatio = fishingInfoResponse.FishingInfo.EntrustRefreshRatio;
				EventSystem.Instance.Emit(EEventName.OnRefreshTempFishingPointNum);
			}, 0);
		}

		// Token: 0x06036317 RID: 221975 RVA: 0x00F1F978 File Offset: 0x00F1DB78
		private void ShowFishingLevelUp(IProto_NormalItem normalItem, int count, int lastCount)
		{
			if (normalItem.Id == FishingModel.Instance.FishingReputationItemId)
			{
				FishingLevelUpData fishingLevelUpData = new FishingLevelUpData(lastCount, count);
				FishingModel.Instance.SetFishingLevelUpInfo(fishingLevelUpData);
				UiManager.Instance.OpenView(EUiViewName.FishingLevelUpTips, fishingLevelUpData, null);
			}
		}

		// Token: 0x06036318 RID: 221976 RVA: 0x00F1F9BC File Offset: 0x00F1DBBC
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

		// Token: 0x06036319 RID: 221977 RVA: 0x00F1FA00 File Offset: 0x00F1DC00
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

		// Token: 0x0603631A RID: 221978 RVA: 0x00F1FA3C File Offset: 0x00F1DC3C
		private bool CanOpenFishingLevelUpView()
		{
			return UiManager.Instance.IsViewOpen(EUiViewName.BattleView) || (UiManager.Instance.IsViewOpen(EUiViewName.FishingQuestView) && FishingModel.Instance.IsInDock);
		}

		// Token: 0x0603631B RID: 221979 RVA: 0x00F1FA70 File Offset: 0x00F1DC70
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(mulFishingIllustratedRewardResponse.ErrorCode, 28177, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0603631C RID: 221980 RVA: 0x00F1FAC0 File Offset: 0x00F1DCC0
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

		// Token: 0x0603631D RID: 221981 RVA: 0x00F1FC30 File Offset: 0x00F1DE30
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingCabinPutResponse.ErrorCode, 27309, null, true, true);
				}
				Action<bool> callback = requestData.Callback;
				if (callback == null)
				{
					return;
				}
				callback(flag);
			}, 0);
		}

		// Token: 0x0603631E RID: 221982 RVA: 0x00F1FCF8 File Offset: 0x00F1DEF8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingQuickSellResponse.ErrorCode, 24478, null, true, true);
				}
				callback(flag);
			}, 0);
		}

		// Token: 0x0603631F RID: 221983 RVA: 0x00F1FD38 File Offset: 0x00F1DF38
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

		// Token: 0x06036320 RID: 221984 RVA: 0x00F1FD90 File Offset: 0x00F1DF90
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingSellResponse.ErrorCode, 23025, null, true, true);
				}
				callback(flag);
			}, 0);
		}

		// Token: 0x06036321 RID: 221985 RVA: 0x00F1FDDC File Offset: 0x00F1DFDC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingSailingResponse.ErrorCode, 20883, null, true, true);
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

		// Token: 0x06036322 RID: 221986 RVA: 0x00F1FE34 File Offset: 0x00F1E034
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingShipFixResponse.ErrorCode, 21934, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06036323 RID: 221987 RVA: 0x00F1FE78 File Offset: 0x00F1E078
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustHandInResponse.ErrorCode, 28305, null, true, true);
					return;
				}
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, false, null);
				FishingQuestModel.Instance.AutoTraceEntrust();
			}, 0);
		}

		// Token: 0x06036324 RID: 221988 RVA: 0x00F1FED0 File Offset: 0x00F1E0D0
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustTraceResponse.ErrorCode, 29628, null, true, true);
					FishingQuestModel.Instance.TraceFormClick = false;
					return;
				}
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, true, null);
			}, 0);
		}

		// Token: 0x06036325 RID: 221989 RVA: 0x00F1FF1C File Offset: 0x00F1E11C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustRefreshResponse.ErrorCode, 16187, null, true, true);
					return;
				}
				int entrustId2 = fishingEntrustRefreshResponse.EntrustId;
				EventSystem.Instance.Emit<bool, int?>(EEventName.FishingRefreshQuestView, false, new int?(entrustId2));
			}, 0);
		}

		// Token: 0x06036326 RID: 221990 RVA: 0x00F1FF68 File Offset: 0x00F1E168
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingEntrustAcceptResponse.ErrorCode, 18952, null, true, true);
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

		// Token: 0x06036327 RID: 221991 RVA: 0x00F1FFB4 File Offset: 0x00F1E1B4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingTechLevelUpResponse.ErrorCode, 24459, null, true, true);
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

		// Token: 0x06036328 RID: 221992 RVA: 0x00F20004 File Offset: 0x00F1E204
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

		// Token: 0x06036329 RID: 221993 RVA: 0x00F20050 File Offset: 0x00F1E250
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingShipSkinChangeResponse.ErrorCode, 21884, null, true, true);
					return;
				}
				FishingModel.Instance.CurrentShipSkin = skinId;
				EventSystem.Instance.Emit(EEventName.FishingShipSkinChangeSuccess);
			}, 0);
		}

		// Token: 0x0603632A RID: 221994 RVA: 0x00F200A9 File Offset: 0x00F1E2A9
		private void RecordNeedShowExitConfirmBox(bool isSelectOn)
		{
			DockyardModel.Instance.IsNeedShowExitConfirmBox = !isSelectOn;
		}

		// Token: 0x0603632B RID: 221995 RVA: 0x00F200BC File Offset: 0x00F1E2BC
		public void ShowExitFishingViewConfirm(Action closeFunc)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DockyardExitFishing);
			confirmBoxDataNew.FunctionMap[2] = closeFunc;
			confirmBoxDataNew.HasToggle = true;
			confirmBoxDataNew.ToggleText = ConfigMultiTextLang.GetLocalTextNew("Fishing_LoginRepeat", null);
			confirmBoxDataNew.SetToggleFunction(new Action<bool>(this.RecordNeedShowExitConfirmBox));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603632C RID: 221996 RVA: 0x00F20118 File Offset: 0x00F1E318
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

		// Token: 0x0603632D RID: 221997 RVA: 0x00F2016C File Offset: 0x00F1E36C
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

		// Token: 0x0603632E RID: 221998 RVA: 0x00F201A9 File Offset: 0x00F1E3A9
		public bool IsInFishingShip()
		{
			return FishingModel.Instance.GetShipData().IsShipDriving();
		}

		// Token: 0x0603632F RID: 221999 RVA: 0x00F201BC File Offset: 0x00F1E3BC
		public void ConfirmToTeleportToPort(Action closeFunc)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ConfirmToTeleportToPort);
			confirmBoxDataNew.FunctionMap[2] = closeFunc;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06036330 RID: 222000 RVA: 0x00F201F0 File Offset: 0x00F1E3F0
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

		// Token: 0x06036331 RID: 222001 RVA: 0x00F202D8 File Offset: 0x00F1E4D8
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingHandInResponse.ErrorCode, 18677, null, true, true);
				}
				Action<bool, bool> callback = requestData.Callback;
				if (callback == null)
				{
					return;
				}
				callback(flag, fishingHandInResponse.HandInComplete);
			}, 0);
		}

		// Token: 0x06036332 RID: 222002 RVA: 0x00F2037C File Offset: 0x00F1E57C
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

		// Token: 0x06036333 RID: 222003 RVA: 0x00F203BC File Offset: 0x00F1E5BC
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

		// Token: 0x06036334 RID: 222004 RVA: 0x00F20439 File Offset: 0x00F1E639
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

		// Token: 0x06036335 RID: 222005 RVA: 0x00F20470 File Offset: 0x00F1E670
		private void RequestFishingSkillTeleport()
		{
			FishingSkillTeleportRequest message = FishingSkillTeleportRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingSkillTeleportRequest, message, delegate(IMessage _, Net.CallbackStatus _)
			{
			}, 0);
		}

		// Token: 0x06036336 RID: 222006 RVA: 0x00F204B4 File Offset: 0x00F1E6B4
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

		// Token: 0x06036337 RID: 222007 RVA: 0x00F2050C File Offset: 0x00F1E70C
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

		// Token: 0x06036338 RID: 222008 RVA: 0x00F20564 File Offset: 0x00F1E764
		private bool CheckFishingSkillCostEnough()
		{
			int fishingSkillCostId = this.GetFishingSkillCostId();
			return fishingSkillCostId > 0 && InventoryModel.Instance.GetItemCountByConfigId(fishingSkillCostId, 0) > 0;
		}

		// Token: 0x06036339 RID: 222009 RVA: 0x00F20590 File Offset: 0x00F1E790
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
			int result = 0;
			using (Dictionary<int, int>.KeyCollection.Enumerator enumerator = dictionary.Keys.GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					result = enumerator.Current;
				}
			}
			return result;
		}

		// Token: 0x0603633A RID: 222010 RVA: 0x00F20640 File Offset: 0x00F1E840
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

		// Token: 0x0603633B RID: 222011 RVA: 0x00F20680 File Offset: 0x00F1E880
		private void RequestFishingTeleportToBoat()
		{
			GameModeModel.Instance.IsTeleport = true;
			FishingTeleportToBoatRequest message = FishingTeleportToBoatRequest.Create();
			Net.Instance.Call(ERequestMessageId.FishingTeleportToBoatRequest, message, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FishingTeleportToBoatResponse fishingTeleportToBoatResponse = (FishingTeleportToBoatResponse)msg;
				if (fishingTeleportToBoatResponse != null && fishingTeleportToBoatResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(fishingTeleportToBoatResponse.ErrorCode, 21519, null, true, true);
				}
				GameModeModel.Instance.IsTeleport = false;
			}, 0);
		}

		// Token: 0x0603633C RID: 222012 RVA: 0x00F206D0 File Offset: 0x00F1E8D0
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

		// Token: 0x0603633D RID: 222013 RVA: 0x00F2075C File Offset: 0x00F1E95C
		public void StopRoleTechAudio()
		{
			if (!StringUtils.IsEmpty(this.RoleTechAudioHandle))
			{
				AudioSystem.Instance.ExecuteAction(this.RoleTechAudioHandle, EAudioActionType.Stop, null);
				this.RoleTechAudioHandle = "";
			}
		}

		// Token: 0x0603633E RID: 222014 RVA: 0x00F2079C File Offset: 0x00F1E99C
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

		// Token: 0x0603633F RID: 222015 RVA: 0x00F2080C File Offset: 0x00F1EA0C
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

		// Token: 0x170068FB RID: 26875
		// (get) Token: 0x06036340 RID: 222016 RVA: 0x00F2087C File Offset: 0x00F1EA7C
		public static FishingController Instance
		{
			get
			{
				return FishingController._Instance;
			}
		}

		// Token: 0x06036341 RID: 222017 RVA: 0x00F20883 File Offset: 0x00F1EA83
		public static FishingController GetOrCreateInstance()
		{
			if (FishingController._Instance == null)
			{
				FishingController.CreateInstance();
			}
			return FishingController._Instance;
		}

		// Token: 0x06036342 RID: 222018 RVA: 0x00F20897 File Offset: 0x00F1EA97
		public static bool CreateInstance()
		{
			if (FishingController._Instance != null)
			{
				return true;
			}
			FishingController._Instance = new FishingController();
			return true;
		}

		// Token: 0x06036343 RID: 222019 RVA: 0x00F208AD File Offset: 0x00F1EAAD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036344 RID: 222020 RVA: 0x00F208AF File Offset: 0x00F1EAAF
		public static void ResetStaticDefaultValue()
		{
			FishingController._Instance = null;
		}

		// Token: 0x06036345 RID: 222021 RVA: 0x00F208B7 File Offset: 0x00F1EAB7
		static FishingController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingController.CreateStaticDefaultValue), new Action(FishingController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C965 RID: 117093
		private const int FISHING_SHIP_DEAD_TIME = 1300;

		// Token: 0x0401C966 RID: 117094
		private string RoleTechAudioHandle = "";

		// Token: 0x0401C967 RID: 117095
		[Nullable(2)]
		private static FishingController _Instance;
	}
}
