using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005AF0 RID: 23280
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class CookController : UiControllerBase
	{
		// Token: 0x0603AEE7 RID: 241383 RVA: 0x00E0CBAC File Offset: 0x00E0ADAC
		protected override bool OnInit()
		{
			this.CookCoinId = ConfigCommonParamById.GetIntConfig("CookCost").GetValueOrDefault(-1);
			return base.OnInit();
		}

		// Token: 0x0603AEE8 RID: 241384 RVA: 0x00E0CBD8 File Offset: 0x00E0ADD8
		protected override bool OnClear()
		{
			this.ClearCookDisplay();
			return true;
		}

		// Token: 0x0603AEE9 RID: 241385 RVA: 0x00E0CBE1 File Offset: 0x00E0ADE1
		protected override bool OnLeaveLevel()
		{
			this.ClearCookDisplay();
			return true;
		}

		// Token: 0x0603AEEA RID: 241386 RVA: 0x00E0CBEC File Offset: 0x00E0ADEC
		protected override void OnAddEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ActiveRole;
			Action<int> handle;
			if ((handle = CookController.<>O.<0>__UpdateCookRoleItemDataList) == null)
			{
				handle = (CookController.<>O.<0>__UpdateCookRoleItemDataList = new Action<int>(CookController.UpdateCookRoleItemDataList));
			}
			instance.Add<int>(name, handle);
			EventSystem.Instance.Add<int, int>(EEventName.OnItemUse, new Action<int, int>(this.ShowCookStudy));
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.LoadNewList));
		}

		// Token: 0x0603AEEB RID: 241387 RVA: 0x00E0CC5C File Offset: 0x00E0AE5C
		protected override void OnRemoveEvents()
		{
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.ActiveRole;
			Action<int> handle;
			if ((handle = CookController.<>O.<0>__UpdateCookRoleItemDataList) == null)
			{
				handle = (CookController.<>O.<0>__UpdateCookRoleItemDataList = new Action<int>(CookController.UpdateCookRoleItemDataList));
			}
			instance.Remove(name, handle);
			EventSystem.Instance.Remove(EEventName.OnItemUse, new Action<int, int>(this.ShowCookStudy));
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.LoadNewList));
		}

		// Token: 0x0603AEEC RID: 241388 RVA: 0x00E0CCCC File Offset: 0x00E0AECC
		private static void UpdateCookRoleItemDataList(int i)
		{
			CookModel.Instance.UpdateCookRoleItemDataList();
		}

		// Token: 0x0603AEED RID: 241389 RVA: 0x00E0CCD8 File Offset: 0x00E0AED8
		private void ShowCookStudy(int configId, int count)
		{
			if (!CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(configId).Value.ShowTypes().Contains(24))
			{
				return;
			}
			CookFormula cookFormulaByFormulaItemId = CookConfig.Instance.GetCookFormulaByFormulaItemId(configId);
			string localText = CookConfig.Instance.GetLocalText(cookFormulaByFormulaItemId.Name);
			GenericPromptController.Instance.ShowPromptByCode("CookStudy", new object[]
			{
				localText
			});
			EventSystem.Instance.Emit(EEventName.UpdateFormula);
		}

		// Token: 0x0603AEEE RID: 241390 RVA: 0x00E0CD51 File Offset: 0x00E0AF51
		private void LoadNewList()
		{
			CookModel.Instance.CreateMachiningDataList();
		}

		// Token: 0x0603AEEF RID: 241391 RVA: 0x00E0CD5D File Offset: 0x00E0AF5D
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.CookingInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleCookingInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.CookingFormulaUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleCookingFormulaUpdateNotify));
		}

		// Token: 0x0603AEF0 RID: 241392 RVA: 0x00E0CD98 File Offset: 0x00E0AF98
		private void HandleCookingInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			CookingInfoUpdateNotify cookingInfoUpdateNotify = (CookingInfoUpdateNotify)msg;
			CookModel.Instance.UpdateCookerInfo(cookingInfoUpdateNotify.CookingInfo);
			EventSystem.Instance.Emit(EEventName.UpdateCookerInfo);
		}

		// Token: 0x0603AEF1 RID: 241393 RVA: 0x00E0CDCC File Offset: 0x00E0AFCC
		private void HandleCookingFormulaUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			CookingFormulaUpdateNotify cookingFormulaUpdateNotify = (CookingFormulaUpdateNotify)msg;
			CookModel.Instance.UpdateCookingDataList(cookingFormulaUpdateNotify.FoodFormulaInfos);
			CookModel.Instance.UpdateMachiningDataList(cookingFormulaUpdateNotify.ProcessedFoodFormulaInfos, true);
		}

		// Token: 0x0603AEF2 RID: 241394 RVA: 0x00E0CE01 File Offset: 0x00E0B001
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.CookingInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.CookingFormulaUpdateNotify);
		}

		// Token: 0x0603AEF3 RID: 241395 RVA: 0x00E0CE23 File Offset: 0x00E0B023
		public bool CheckCanShowExpItem()
		{
			return CookModel.Instance.GetCookerInfo().AddExp != 0;
		}

		// Token: 0x0603AEF4 RID: 241396 RVA: 0x00E0CE38 File Offset: 0x00E0B038
		private void HandleCookingProtocolResponse(CookingDataResponse response)
		{
			CookModel.Instance.CreateCookerInfo(response.CookingInfo);
			CookModel.Instance.CreateCookingDataList(response.FoodFormulaInfos);
			CookModel.Instance.UpdateCookingDataByServerConfig(response.FormulaConfigs);
			CookModel.Instance.UpdateMachiningDataList(response.ProcessedFoodFormulaInfos, false);
			CookModel.Instance.SaveLimitRefreshTime(response.LimitRefreshTime);
		}

		// Token: 0x0603AEF5 RID: 241397 RVA: 0x00E0CE98 File Offset: 0x00E0B098
		[NullableContext(0)]
		public UniTask<bool> SendCookingDataRequestAsync()
		{
			CookController.<SendCookingDataRequestAsync>d__20 <SendCookingDataRequestAsync>d__;
			<SendCookingDataRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SendCookingDataRequestAsync>d__.<>4__this = this;
			<SendCookingDataRequestAsync>d__.<>1__state = -1;
			<SendCookingDataRequestAsync>d__.<>t__builder.Start<CookController.<SendCookingDataRequestAsync>d__20>(ref <SendCookingDataRequestAsync>d__);
			return <SendCookingDataRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEF6 RID: 241398 RVA: 0x00E0CEDC File Offset: 0x00E0B0DC
		public void SendCookFormulaRequest(int formulaId)
		{
			CookFormulaRequest cookFormulaRequest = CookFormulaRequest.Create();
			cookFormulaRequest.CookFormulaId = formulaId;
			Net.Instance.Call(ERequestMessageId.CookFormulaRequest, cookFormulaRequest, new Action<IMessage, Net.CallbackStatus>(this.HandleCookFormulaResponse), 0);
		}

		// Token: 0x0603AEF7 RID: 241399 RVA: 0x00E0CF14 File Offset: 0x00E0B114
		private void HandleCookFormulaResponse(IMessage msg, Net.CallbackStatus _)
		{
			CookFormulaResponse cookFormulaResponse = (CookFormulaResponse)msg;
			if (cookFormulaResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				CookModel.Instance.UnlockCookMenuData(cookFormulaResponse.CookFormulaId);
				CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(cookFormulaResponse.CookFormulaId);
				string localText = CookConfig.Instance.GetLocalText(cookFormulaById.Name);
				GenericPromptController.Instance.ShowPromptByCode("CookStudy", new object[]
				{
					localText
				});
				EventSystem.Instance.Emit(EEventName.UpdateFormula);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(cookFormulaResponse.Code, 25849, null, true, true);
		}

		// Token: 0x0603AEF8 RID: 241400 RVA: 0x00E0CFA8 File Offset: 0x00E0B1A8
		public void SendCookFoodRequest(int formulaId, int roleId, int cookCount)
		{
			CookFoodRequest cookFoodRequest = CookFoodRequest.Create();
			cookFoodRequest.Id = formulaId;
			cookFoodRequest.RoleId = roleId;
			cookFoodRequest.CookCount = cookCount;
			cookFoodRequest.InteractEntityId = CookModel.Instance.CurrentInteractCreatureDataLongId.Value;
			Net.Instance.Call(ERequestMessageId.CookFoodRequest, cookFoodRequest, new Action<IMessage, Net.CallbackStatus>(this.HandleCookFoodResponse), 0);
		}

		// Token: 0x0603AEF9 RID: 241401 RVA: 0x00E0D004 File Offset: 0x00E0B204
		private void HandleCookFoodResponse(IMessage msg, Net.CallbackStatus _)
		{
			CookFoodResponse cookFoodResponse = (CookFoodResponse)msg;
			if (cookFoodResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				ICookingData cookingDataById = CookModel.Instance.GetCookingDataById(cookFoodResponse.Id);
				if (cookingDataById != null)
				{
					cookingDataById.LastRoleId = new int?(cookFoodResponse.RoleId);
				}
				List<SingleItemInfo> list = new List<SingleItemInfo>();
				if (cookFoodResponse.ItemInfos != null)
				{
					foreach (SingleItemInfo item in cookFoodResponse.ItemInfos)
					{
						list.Add(item);
					}
				}
				if (cookFoodResponse.ExtraItemInfos != null && cookFoodResponse.ExtraItemInfos.Count != 0)
				{
					foreach (SingleItemInfo item2 in cookFoodResponse.ExtraItemInfos)
					{
						list.Add(item2);
					}
				}
				CookModel.Instance.UpdateCookItemList(list);
				this.SetCompositeRewardView(cookFoodResponse);
				this.PlayCookSuccessDisplay(delegate
				{
					ItemRewardController.Instance.OpenCompositeRewardView(2001, true, null, null);
				});
				EventSystem.Instance.Emit(EEventName.CookSuccess);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(cookFoodResponse.Code, 23290, null, true, true);
			EventSystem.Instance.Emit(EEventName.CookFail);
		}

		// Token: 0x0603AEFA RID: 241402 RVA: 0x00E0D15C File Offset: 0x00E0B35C
		[NullableContext(1)]
		private void SetCompositeRewardView(CookFoodResponse response)
		{
			CookModel instance = CookModel.Instance;
			ICookerInfoData cookerInfo = instance.GetCookerInfo();
			int cookingLevel = cookerInfo.CookingLevel;
			int cookerMaxLevel = instance.GetCookerMaxLevel();
			CookLevel cookLevelByLevel = instance.GetCookLevelByLevel(cookerMaxLevel);
			int totalProficiencys = cookerInfo.TotalProficiencys;
			int completeness = cookLevelByLevel.Completeness;
			int lastExp = instance.LastExp;
			List<IRewardProgress> progressQueue = null;
			if (lastExp != totalProficiencys && (lastExp < completeness || (cookingLevel < cookerMaxLevel && totalProficiencys < completeness)))
			{
				CookLevel cookLevelByLevel2 = instance.GetCookLevelByLevel(Math.Min(cookerMaxLevel, cookingLevel + 1));
				RewardProgress item = new RewardProgress
				{
					FromProgress = lastExp,
					ToProgress = totalProficiencys,
					MaxProgress = cookLevelByLevel2.Completeness
				};
				progressQueue = new List<IRewardProgress>
				{
					item
				};
			}
			instance.LastExp = totalProficiencys;
			List<RewardItemData> list = new List<RewardItemData>();
			if (response.ItemInfos != null)
			{
				foreach (SingleItemInfo singleItemInfo in response.ItemInfos)
				{
					RewardItemData item2 = new RewardItemData(singleItemInfo.ItemId, singleItemInfo.ItemNum, null, EDropItemType.Normal);
					list.Add(item2);
				}
			}
			if (response.ExtraItemInfos != null)
			{
				foreach (SingleItemInfo singleItemInfo2 in response.ExtraItemInfos)
				{
					RewardItemData item3 = new RewardItemData(singleItemInfo2.ItemId, singleItemInfo2.ItemNum, null, EDropItemType.Normal);
					list.Add(item3);
				}
			}
			ItemRewardController.Instance.SetItemList(list);
			ItemRewardController.Instance.SetProgressQueue(progressQueue);
		}

		// Token: 0x0603AEFB RID: 241403 RVA: 0x00E0D308 File Offset: 0x00E0B508
		[NullableContext(1)]
		private List<ISingleItemInfo> PrimaryFoodFilter(List<ISingleItemInfo> primaryFoodList)
		{
			List<ISingleItemInfo> list = new List<ISingleItemInfo>();
			foreach (ISingleItemInfo singleItemInfo in primaryFoodList)
			{
				if (singleItemInfo.Proto_IsUnlock)
				{
					list.Add(singleItemInfo);
				}
			}
			return list;
		}

		// Token: 0x0603AEFC RID: 241404 RVA: 0x00E0D368 File Offset: 0x00E0B568
		[NullableContext(1)]
		public void SendFoodProcessRequest(int formulaId, List<ISingleItemInfo> primaryFoodList, int cookCount)
		{
			FoodProcessRequest foodProcessRequest = FoodProcessRequest.Create();
			foodProcessRequest.Id = formulaId;
			foreach (ISingleItemInfo singleItemInfo in this.PrimaryFoodFilter(primaryFoodList))
			{
				SingleItemInfo singleItemInfo2 = SingleItemInfo.Create();
				singleItemInfo2.ItemId = singleItemInfo.Proto_ItemId;
				singleItemInfo2.ItemNum = singleItemInfo.Proto_ItemNum;
				foodProcessRequest.PrimaryFood.Add(singleItemInfo2);
			}
			foodProcessRequest.CookCount = cookCount;
			foodProcessRequest.InteractEntityId = CookModel.Instance.CurrentInteractCreatureDataLongId.Value;
			Net.Instance.Call(ERequestMessageId.FoodProcessRequest, foodProcessRequest, new Action<IMessage, Net.CallbackStatus>(this.HandleFoodProcessResponse), 0);
		}

		// Token: 0x0603AEFD RID: 241405 RVA: 0x00E0D428 File Offset: 0x00E0B628
		private void HandleFoodProcessResponse(IMessage msg, Net.CallbackStatus _)
		{
			FoodProcessResponse foodProcessResponse = (FoodProcessResponse)msg;
			if (foodProcessResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(foodProcessResponse.Code, 25197, null, true, true);
				return;
			}
			IMachiningData machiningDataById = CookModel.Instance.GetMachiningDataById(foodProcessResponse.Id);
			bool lockState = foodProcessResponse.LockState;
			if (machiningDataById != null)
			{
				machiningDataById.IsUnLock = lockState;
				if (foodProcessResponse.UnlockParam != null && foodProcessResponse.UnlockParam.Count != 0)
				{
					machiningDataById.UnlockList.Clear();
					foreach (int item in foodProcessResponse.UnlockParam)
					{
						machiningDataById.UnlockList.Add(item);
					}
				}
			}
			CookModel.Instance.UpdateCookItemList(foodProcessResponse.FinalFood);
			if (lockState)
			{
				this.PlayCookSuccessDisplay(delegate
				{
					ItemRewardController.Instance.OpenCompositeRewardView(2002, true, null, null);
				});
			}
			else
			{
				this.PlayCookFailDisplay(delegate
				{
					ItemRewardController.Instance.OpenCompositeRewardView(2005, false, null, null);
				});
			}
			if (foodProcessResponse.LockState)
			{
				EventSystem.Instance.Emit(EEventName.MachiningSuccess);
				return;
			}
			EventSystem.Instance.Emit(EEventName.MachiningStudyFail);
		}

		// Token: 0x0603AEFE RID: 241406 RVA: 0x00E0D574 File Offset: 0x00E0B774
		public void SendCertificateLevelRewardRequest()
		{
			CertificateLevelRewardRequest message = CertificateLevelRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.CertificateLevelRewardRequest, message, new Action<IMessage, Net.CallbackStatus>(this.HandleCertificateLevelRewardResponse), 0);
		}

		// Token: 0x0603AEFF RID: 241407 RVA: 0x00E0D5A4 File Offset: 0x00E0B7A4
		private void HandleCertificateLevelRewardResponse(IMessage msg, Net.CallbackStatus _)
		{
			CertificateLevelRewardResponse certificateLevelRewardResponse = (CertificateLevelRewardResponse)msg;
			if (certificateLevelRewardResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				EventSystem.Instance.Emit(EEventName.UpgradeCookerLevel);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(certificateLevelRewardResponse.Code, 20218, null, true, true);
		}

		// Token: 0x0603AF00 RID: 241408 RVA: 0x00E0D5EC File Offset: 0x00E0B7EC
		public void SendFixToolRequest(int fixId, long entityId)
		{
			FixToolRequest fixToolRequest = FixToolRequest.Create();
			fixToolRequest.FixTool = fixId;
			fixToolRequest.EntityId = entityId;
			Net.Instance.Call(ERequestMessageId.FixToolRequest, fixToolRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				FixToolResponse response = (FixToolResponse)msg;
				this.HandleFixToolResponse(response, _, fixId);
			}, 0);
		}

		// Token: 0x0603AF01 RID: 241409 RVA: 0x00E0D644 File Offset: 0x00E0B844
		private void HandleFixToolResponse(FixToolResponse response, Net.CallbackStatus _, int fixId)
		{
			if (response.Code == Aki.Protocol.ErrorCode.Success)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.LK;
				string message = "请求修复厨具成功";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("修复Id", fixId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				EventSystem.Instance.Emit(EEventName.FixSuccess);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.Code, 23245, null, true, true);
		}

		// Token: 0x0603AF02 RID: 241410 RVA: 0x00E0D6B1 File Offset: 0x00E0B8B1
		public void SetCurrentFixId(int fixId)
		{
			CookModel.Instance.CurrentFixId = fixId;
		}

		// Token: 0x0603AF03 RID: 241411 RVA: 0x00E0D6BE File Offset: 0x00E0B8BE
		public int GetCurrentFixId()
		{
			return CookModel.Instance.CurrentFixId;
		}

		// Token: 0x0603AF04 RID: 241412 RVA: 0x00E0D6CA File Offset: 0x00E0B8CA
		public void SetCurrentEntityId(long entityId)
		{
			CookModel.Instance.CurrentEntityId = new long?(entityId);
		}

		// Token: 0x0603AF05 RID: 241413 RVA: 0x00E0D6DC File Offset: 0x00E0B8DC
		public long? GetCurrentEntityId()
		{
			return CookModel.Instance.CurrentEntityId;
		}

		// Token: 0x0603AF06 RID: 241414 RVA: 0x00E0D6E8 File Offset: 0x00E0B8E8
		public bool CheckCanCook(int itemId)
		{
			return CookModel.Instance.CheckCanCook(itemId);
		}

		// Token: 0x0603AF07 RID: 241415 RVA: 0x00E0D6F8 File Offset: 0x00E0B8F8
		public bool CheckCanProcessed(int itemId)
		{
			CookProcessed cookProcessedById = CookConfig.Instance.GetCookProcessedById(itemId);
			int num = cookProcessedById.ConsumeItemsId().Length;
			for (int i = 0; i < num; i++)
			{
				OneItemConfig oneItemConfig = cookProcessedById.ConsumeItemsId()[i];
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(oneItemConfig.ItemId, 0);
				if (oneItemConfig.Count > itemCountByConfigId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603AF08 RID: 241416 RVA: 0x00E0D758 File Offset: 0x00E0B958
		public bool CheckCanAdd(int sum, int itemId, ECookListType type)
		{
			if (type != ECookListType.Cooking)
			{
				return type == ECookListType.Machining && this.DoCheckCanAdd(sum, CookConfig.Instance.GetCookProcessedById(itemId).ConsumeItemsId());
			}
			return this.DoCheckCanAdd(sum, CookConfig.Instance.GetCookFormulaById(itemId).ConsumeItems());
		}

		// Token: 0x0603AF09 RID: 241417 RVA: 0x00E0D7A8 File Offset: 0x00E0B9A8
		[NullableContext(1)]
		private bool DoCheckCanAdd(int sum, OneItemConfig[] itemMap)
		{
			int num = itemMap.Length;
			for (int i = 0; i < num; i++)
			{
				OneItemConfig oneItemConfig = itemMap[i];
				int num2 = sum * oneItemConfig.Count;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(oneItemConfig.ItemId, 0);
				if (num2 > itemCountByConfigId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603AF0A RID: 241418 RVA: 0x00E0D7F0 File Offset: 0x00E0B9F0
		public int GetMaxCreateCount(int itemId, ECookListType type)
		{
			if (type == ECookListType.Cooking)
			{
				return this.DoGetMaxCreateCount(CookConfig.Instance.GetCookFormulaById(itemId).ConsumeItems());
			}
			if (type != ECookListType.Machining)
			{
				return 0;
			}
			return this.DoGetMaxCreateCount(CookConfig.Instance.GetCookProcessedById(itemId).ConsumeItemsId());
		}

		// Token: 0x0603AF0B RID: 241419 RVA: 0x00E0D83C File Offset: 0x00E0BA3C
		[NullableContext(1)]
		private int DoGetMaxCreateCount(OneItemConfig[] itemMap)
		{
			int num = ConfigCommonParamById.GetIntConfig("max_cooking_count").Value;
			int num2 = itemMap.Length;
			for (int i = 0; i < num2; i++)
			{
				OneItemConfig oneItemConfig = itemMap[i];
				int count = oneItemConfig.Count;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(oneItemConfig.ItemId, 0);
				if (count > itemCountByConfigId)
				{
					return 0;
				}
				double num3 = (double)MathUtils.Instance.GetFloatPointFloor((float)(itemCountByConfigId / count), 0);
				num = (((double)num < num3) ? num : ((int)num3));
			}
			return num;
		}

		// Token: 0x0603AF0C RID: 241420 RVA: 0x00E0D8BC File Offset: 0x00E0BABC
		public bool CheckIsBuff(int roleId, int itemId)
		{
			CookFormula cookFormulaById = CookConfig.Instance.GetCookFormulaById(itemId);
			int num = cookFormulaById.RoleList().Length;
			for (int i = 0; i < num; i++)
			{
				if (cookFormulaById.RoleList()[i] == roleId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603AF0D RID: 241421 RVA: 0x00E0D8FC File Offset: 0x00E0BAFC
		public bool CheckIsBuffEx(int roleId, int itemId)
		{
			int[] array = CookConfig.Instance.GetCookFormulaById(itemId).RoleList();
			int num = array.Length;
			bool flag = false;
			for (int i = 0; i < num; i++)
			{
				if (array[i] == roleId)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				return false;
			}
			foreach (int num2 in RoleModel.Instance.GetRoleIdList())
			{
				for (int j = 0; j < num; j++)
				{
					if (array[j] == num2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603AF0E RID: 241422 RVA: 0x00E0D9AC File Offset: 0x00E0BBAC
		[NullableContext(1)]
		public string GetCookInfoText(int roleId)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
			IReadOnlyList<Aki.Config.Skill> skillList = RoleSkillConfig.Instance.GetSkillList(roleConfig.Value.SkillId);
			string result = "";
			if (skillList != null)
			{
				foreach (Aki.Config.Skill skill in skillList)
				{
					if (skill.LeftSkillEffect != 0)
					{
						result = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(skill.SkillDescribe, null), skill.SkillDetailNum());
					}
				}
			}
			return result;
		}

		// Token: 0x0603AF0F RID: 241423 RVA: 0x00E0DA48 File Offset: 0x00E0BC48
		public bool CheckCanFix()
		{
			foreach (KeyValuePair<int, int> keyValuePair in CookConfig.Instance.GetCookFixToolById(this.GetCurrentFixId()).Items())
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(key, 0);
				if (value > itemCountByConfigId)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0603AF10 RID: 241424 RVA: 0x00E0DAD0 File Offset: 0x00E0BCD0
		[NullableContext(1)]
		public List<CommonItemData> GetCookItemSelectedList(int itemId)
		{
			List<CommonItemData> commonItemByShowType = InventoryModel.Instance.GetCommonItemByShowType(InventoryDefine.EShowType.CookMaterial);
			IMachiningData machiningDataById = CookModel.Instance.GetMachiningDataById(itemId);
			List<CommonItemData> list = new List<CommonItemData>();
			foreach (CommonItemData commonItemData in commonItemByShowType)
			{
				if (!machiningDataById.UnlockList.Contains(commonItemData.GetConfigId()))
				{
					list.Add(commonItemData);
				}
			}
			return list;
		}

		// Token: 0x0603AF11 RID: 241425 RVA: 0x00E0DB50 File Offset: 0x00E0BD50
		public bool CheckTmpListHasLock()
		{
			foreach (ISingleItemInfo singleItemInfo in CookModel.Instance.GetTmpMachiningItemList())
			{
				if (!singleItemInfo.Proto_IsUnlock)
				{
					return true;
				}
				int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(singleItemInfo.Proto_ItemId, 0);
				if (singleItemInfo.Proto_ItemNum > itemCountByConfigId)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603AF12 RID: 241426 RVA: 0x00E0DBD0 File Offset: 0x00E0BDD0
		public bool CheckIsUnlock(int machiningId, int itemId)
		{
			return CookModel.Instance.GetMachiningDataById(machiningId).UnlockList.Contains(itemId);
		}

		// Token: 0x0603AF13 RID: 241427 RVA: 0x00E0DBE8 File Offset: 0x00E0BDE8
		public bool CheckCanGetCookerLevel()
		{
			ICookerInfoData cookerInfo = CookModel.Instance.GetCookerInfo();
			if (cookerInfo.CookingLevel != CookModel.Instance.GetCookerMaxLevel())
			{
				int sumExpByLevel = CookModel.Instance.GetSumExpByLevel(cookerInfo.CookingLevel);
				if (cookerInfo.TotalProficiencys >= sumExpByLevel)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603AF14 RID: 241428 RVA: 0x00E0DC30 File Offset: 0x00E0BE30
		[NullableContext(0)]
		public UniTask<bool> ShowFixCookView()
		{
			CookController.<ShowFixCookView>d__51 <ShowFixCookView>d__;
			<ShowFixCookView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ShowFixCookView>d__.<>4__this = this;
			<ShowFixCookView>d__.<>1__state = -1;
			<ShowFixCookView>d__.<>t__builder.Start<CookController.<ShowFixCookView>d__51>(ref <ShowFixCookView>d__);
			return <ShowFixCookView>d__.<>t__builder.Task;
		}

		// Token: 0x0603AF15 RID: 241429 RVA: 0x00E0DC74 File Offset: 0x00E0BE74
		public void PlayCookSuccessDisplay(Action onFinished = null)
		{
			this.ClearCookDisplay();
			LevelTagComponent currentEntityTagComponent = CookController.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				if (onFinished != null)
				{
					onFinished();
				}
				return;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CookRootView);
			if (viewByName != null)
			{
				UiTimeDilation.Instance.SetGameTimeDilation(new UiViewInfoForTimeDilation
				{
					ViewId = viewByName.GetViewId(),
					TimeDilation = 1f,
					DebugName = new EUiViewName?(EUiViewName.CookRootView),
					Reason = "Cook"
				});
			}
			this.IsPlayingSuccessDisplay = true;
			this.OnCookSuccessFinished = onFinished;
			EventSystem.Instance.Emit(EEventName.OnBeginPlayCookSuccessDisplay);
			currentEntityTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.成功"]));
			this.CookDisplayTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit(EEventName.OnPlayCookSuccessDisplayFinished);
				UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.CookRootView);
				if (viewByName2 != null)
				{
					UiTimeDilation.Instance.SetGameTimeDilation(new UiViewInfoForTimeDilation
					{
						ViewId = viewByName2.GetViewId(),
						TimeDilation = viewByName2.ViewInfo.TimeDilation,
						DebugName = new EUiViewName?(EUiViewName.CookRootView),
						Reason = "Cook"
					});
				}
				this.IsPlayingSuccessDisplay = false;
				if (this.OnCookSuccessFinished != null)
				{
					this.OnCookSuccessFinished();
				}
			}, 300f, null, null, true, 1f);
		}

		// Token: 0x0603AF16 RID: 241430 RVA: 0x00E0DD50 File Offset: 0x00E0BF50
		public void SkipCookSuccessDisplay()
		{
			if (!this.IsPlayingSuccessDisplay)
			{
				return;
			}
			if (this.OnCookSuccessFinished != null)
			{
				this.OnCookSuccessFinished();
			}
			this.OnCookSuccessFinished = null;
		}

		// Token: 0x0603AF17 RID: 241431 RVA: 0x00E0DD78 File Offset: 0x00E0BF78
		public void PlayCookFailDisplay(Action onFinished = null)
		{
			this.ClearCookDisplay();
			LevelTagComponent currentEntityTagComponent = CookController.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent == null)
			{
				return;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.CookRootView);
			if (viewByName != null)
			{
				UiTimeDilation.Instance.SetGameTimeDilation(new UiViewInfoForTimeDilation
				{
					ViewId = viewByName.GetViewId(),
					TimeDilation = 1f,
					DebugName = new EUiViewName?(EUiViewName.CookRootView),
					Reason = "Cook"
				});
			}
			this.IsPlayingFailDisplay = true;
			this.OnCookFailFinished = onFinished;
			EventSystem.Instance.Emit(EEventName.OnBeginPlayCookFailDisplay);
			currentEntityTagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.失败"]));
			this.CookDisplayTimerId = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				EventSystem.Instance.Emit(EEventName.OnPlayCookFailDisplayFinished);
				UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.CookRootView);
				if (viewByName2 != null)
				{
					UiTimeDilation.Instance.SetGameTimeDilation(new UiViewInfoForTimeDilation
					{
						ViewId = viewByName2.GetViewId(),
						TimeDilation = viewByName2.ViewInfo.TimeDilation,
						DebugName = new EUiViewName?(EUiViewName.CookRootView),
						Reason = "Cook"
					});
				}
				this.IsPlayingFailDisplay = false;
				if (this.OnCookFailFinished != null)
				{
					this.OnCookFailFinished();
				}
			}, 300f, null, null, true, 1f);
		}

		// Token: 0x0603AF18 RID: 241432 RVA: 0x00E0DE4B File Offset: 0x00E0C04B
		public void SkipCookFailDisplay()
		{
			if (!this.IsPlayingFailDisplay)
			{
				return;
			}
			if (this.OnCookFailFinished != null)
			{
				this.OnCookFailFinished();
			}
			this.OnCookFailFinished = null;
		}

		// Token: 0x0603AF19 RID: 241433 RVA: 0x00E0DE70 File Offset: 0x00E0C070
		public void ClearCookDisplay()
		{
			LevelTagComponent currentEntityTagComponent = CookController.GetCurrentEntityTagComponent();
			if (currentEntityTagComponent != null)
			{
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.成功"]));
				currentEntityTagComponent.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.场景交互物.失败"]));
			}
			if (this.CookDisplayTimerId != null && TimerSystem.GameplayTimeInstance.Has(this.CookDisplayTimerId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.CookDisplayTimerId);
				this.CookDisplayTimerId = null;
			}
			this.IsPlayingSuccessDisplay = false;
			this.IsPlayingFailDisplay = false;
			this.OnCookSuccessFinished = null;
			this.OnCookFailFinished = null;
		}

		// Token: 0x0603AF1A RID: 241434 RVA: 0x00E0DF0C File Offset: 0x00E0C10C
		private static LevelTagComponent GetCurrentEntityTagComponent()
		{
			int valueOrDefault = InteractionModel.Instance.CurrentInteractEntityId.GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				return null;
			}
			Entity entity = EntitySystem.Instance.Get(valueOrDefault);
			if (entity == null)
			{
				return null;
			}
			return entity.GetComponent<LevelTagComponent>();
		}

		// Token: 0x0603AF1B RID: 241435 RVA: 0x00E0DF48 File Offset: 0x00E0C148
		[NullableContext(1)]
		public void TryRequestChangeEntityStateByEvent(ECookMechanismState @event, UiViewBase view)
		{
			if (!CookDefine.CookEntityCanChangeArray.Contains(view.ViewInfo.Name))
			{
				return;
			}
			int valueOrDefault = InteractionModel.Instance.CurrentInteractEntityId.GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				Log.Instance.Error(ELogModule.Cook, ELogAuthor.WZ, "当前无法获取交互实体的id", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			long creatureDataId = CreatureModel.Instance.GetCreatureDataId(valueOrDefault);
			if (creatureDataId == 0L)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Cook;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "当前交互实体无法获取服务端实体uid";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("client entity uid", valueOrDefault);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LevelGeneralNetworks.RequestEntitySendEvent(creatureDataId, @event.ToString());
		}

		// Token: 0x17008C36 RID: 35894
		// (get) Token: 0x0603AF1C RID: 241436 RVA: 0x00E0DFF6 File Offset: 0x00E0C1F6
		[Nullable(1)]
		public static CookController Instance
		{
			[NullableContext(1)]
			get
			{
				return CookController._Instance;
			}
		}

		// Token: 0x0603AF1D RID: 241437 RVA: 0x00E0DFFD File Offset: 0x00E0C1FD
		[NullableContext(1)]
		public static CookController GetOrCreateInstance()
		{
			if (CookController._Instance == null)
			{
				CookController.CreateInstance();
			}
			return CookController._Instance;
		}

		// Token: 0x0603AF1E RID: 241438 RVA: 0x00E0E011 File Offset: 0x00E0C211
		public static bool CreateInstance()
		{
			if (CookController._Instance != null)
			{
				return true;
			}
			CookController._Instance = new CookController();
			return true;
		}

		// Token: 0x0603AF1F RID: 241439 RVA: 0x00E0E027 File Offset: 0x00E0C227
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AF20 RID: 241440 RVA: 0x00E0E029 File Offset: 0x00E0C229
		public static void ResetStaticDefaultValue()
		{
			CookController._Instance = null;
		}

		// Token: 0x0603AF21 RID: 241441 RVA: 0x00E0E031 File Offset: 0x00E0C231
		static CookController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookController.CreateStaticDefaultValue), new Action(CookController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EC26 RID: 125990
		public int CookCoinId;

		// Token: 0x0401EC27 RID: 125991
		private TimerHandle CookDisplayTimerId;

		// Token: 0x0401EC28 RID: 125992
		public bool IsPlayingSuccessDisplay;

		// Token: 0x0401EC29 RID: 125993
		public bool IsPlayingFailDisplay;

		// Token: 0x0401EC2A RID: 125994
		private Action OnCookSuccessFinished;

		// Token: 0x0401EC2B RID: 125995
		private Action OnCookFailFinished;

		// Token: 0x0401EC2C RID: 125996
		private static CookController _Instance;

		// Token: 0x0200BD40 RID: 48448
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04039138 RID: 233784
			[Nullable(0)]
			public static Action<int> <0>__UpdateCookRoleItemDataList;
		}
	}
}
