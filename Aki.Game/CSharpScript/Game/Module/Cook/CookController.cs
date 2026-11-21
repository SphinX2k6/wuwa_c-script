using System;
using System.Collections.Generic;
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
	// Token: 0x02004AD1 RID: 19153
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class CookController : UiControllerBase
	{
		// Token: 0x0602FE59 RID: 196185 RVA: 0x00D5D870 File Offset: 0x00D5BA70
		protected override bool OnInit()
		{
			this.CookCoinId = ConfigCommonParamById.GetIntConfig("CookCost").GetValueOrDefault(-1);
			return base.OnInit();
		}

		// Token: 0x0602FE5A RID: 196186 RVA: 0x00D5D89C File Offset: 0x00D5BA9C
		protected override bool OnClear()
		{
			this.ClearCookDisplay();
			return true;
		}

		// Token: 0x0602FE5B RID: 196187 RVA: 0x00D5D8A5 File Offset: 0x00D5BAA5
		protected override bool OnLeaveLevel()
		{
			this.ClearCookDisplay();
			return true;
		}

		// Token: 0x0602FE5C RID: 196188 RVA: 0x00D5D8B0 File Offset: 0x00D5BAB0
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

		// Token: 0x0602FE5D RID: 196189 RVA: 0x00D5D920 File Offset: 0x00D5BB20
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

		// Token: 0x0602FE5E RID: 196190 RVA: 0x00D5D990 File Offset: 0x00D5BB90
		private static void UpdateCookRoleItemDataList(int i)
		{
			CookModel.Instance.UpdateCookRoleItemDataList();
		}

		// Token: 0x0602FE5F RID: 196191 RVA: 0x00D5D99C File Offset: 0x00D5BB9C
		private void ShowCookStudy(int configId, int count)
		{
			if (Array.IndexOf<int>(CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(configId).Value.ShowTypes(), 24) < 0)
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

		// Token: 0x0602FE60 RID: 196192 RVA: 0x00D5DA16 File Offset: 0x00D5BC16
		private void LoadNewList()
		{
			CookModel.Instance.CreateMachiningDataList();
		}

		// Token: 0x0602FE61 RID: 196193 RVA: 0x00D5DA22 File Offset: 0x00D5BC22
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.CookingInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleCookingInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.CookingFormulaUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.HandleCookingFormulaUpdateNotify));
		}

		// Token: 0x0602FE62 RID: 196194 RVA: 0x00D5DA5C File Offset: 0x00D5BC5C
		private void HandleCookingInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			CookingInfoUpdateNotify cookingInfoUpdateNotify = (CookingInfoUpdateNotify)msg;
			CookModel.Instance.UpdateCookerInfo(cookingInfoUpdateNotify.CookingInfo);
			EventSystem.Instance.Emit(EEventName.UpdateCookerInfo);
		}

		// Token: 0x0602FE63 RID: 196195 RVA: 0x00D5DA90 File Offset: 0x00D5BC90
		private void HandleCookingFormulaUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			CookingFormulaUpdateNotify cookingFormulaUpdateNotify = (CookingFormulaUpdateNotify)msg;
			CookModel.Instance.UpdateCookingDataList(cookingFormulaUpdateNotify.FoodFormulaInfos);
			CookModel.Instance.UpdateMachiningDataList(cookingFormulaUpdateNotify.ProcessedFoodFormulaInfos, true);
		}

		// Token: 0x0602FE64 RID: 196196 RVA: 0x00D5DAC5 File Offset: 0x00D5BCC5
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.CookingInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.CookingFormulaUpdateNotify);
		}

		// Token: 0x0602FE65 RID: 196197 RVA: 0x00D5DAE7 File Offset: 0x00D5BCE7
		public bool CheckCanShowExpItem()
		{
			return CookModel.Instance.GetCookerInfo().AddExp != 0;
		}

		// Token: 0x0602FE66 RID: 196198 RVA: 0x00D5DAFC File Offset: 0x00D5BCFC
		private void HandleCookingProtocolResponse(CookingDataResponse response)
		{
			CookModel.Instance.CreateCookerInfo(response.CookingInfo);
			CookModel.Instance.CreateCookingDataList(response.FoodFormulaInfos);
			CookModel.Instance.UpdateCookingDataByServerConfig(response.FormulaConfigs);
			CookModel.Instance.UpdateMachiningDataList(response.ProcessedFoodFormulaInfos, false);
			CookModel.Instance.SaveLimitRefreshTime(response.LimitRefreshTime);
		}

		// Token: 0x0602FE67 RID: 196199 RVA: 0x00D5DB5C File Offset: 0x00D5BD5C
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

		// Token: 0x0602FE68 RID: 196200 RVA: 0x00D5DBA0 File Offset: 0x00D5BDA0
		public void SendCookFormulaRequest(int formulaId)
		{
			CookFormulaRequest cookFormulaRequest = CookFormulaRequest.Create();
			cookFormulaRequest.CookFormulaId = formulaId;
			Net.Instance.Call(ERequestMessageId.CookFormulaRequest, cookFormulaRequest, new Action<IMessage, Net.CallbackStatus>(this.HandleCookFormulaResponse), 0);
		}

		// Token: 0x0602FE69 RID: 196201 RVA: 0x00D5DBD8 File Offset: 0x00D5BDD8
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(cookFormulaResponse.Code, 23024, null, true, true);
		}

		// Token: 0x0602FE6A RID: 196202 RVA: 0x00D5DC6C File Offset: 0x00D5BE6C
		public void SendCookFoodRequest(int formulaId, int roleId, int cookCount)
		{
			CookFoodRequest cookFoodRequest = CookFoodRequest.Create();
			cookFoodRequest.Id = formulaId;
			cookFoodRequest.RoleId = roleId;
			cookFoodRequest.CookCount = cookCount;
			cookFoodRequest.InteractEntityId = CookModel.Instance.CurrentInteractCreatureDataLongId.Value;
			Net.Instance.Call(ERequestMessageId.CookFoodRequest, cookFoodRequest, new Action<IMessage, Net.CallbackStatus>(this.HandleCookFoodResponse), 0);
		}

		// Token: 0x0602FE6B RID: 196203 RVA: 0x00D5DCC8 File Offset: 0x00D5BEC8
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(cookFoodResponse.Code, 23883, null, true, true);
			EventSystem.Instance.Emit(EEventName.CookFail);
		}

		// Token: 0x0602FE6C RID: 196204 RVA: 0x00D5DE20 File Offset: 0x00D5C020
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

		// Token: 0x0602FE6D RID: 196205 RVA: 0x00D5DFCC File Offset: 0x00D5C1CC
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

		// Token: 0x0602FE6E RID: 196206 RVA: 0x00D5E02C File Offset: 0x00D5C22C
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

		// Token: 0x0602FE6F RID: 196207 RVA: 0x00D5E0EC File Offset: 0x00D5C2EC
		private void HandleFoodProcessResponse(IMessage msg, Net.CallbackStatus _)
		{
			FoodProcessResponse foodProcessResponse = (FoodProcessResponse)msg;
			if (foodProcessResponse.Code != Aki.Protocol.ErrorCode.Success)
			{
				ErrorCodeController.Instance.OpenErrorCodeTipView(foodProcessResponse.Code, 23327, null, true, true);
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

		// Token: 0x0602FE70 RID: 196208 RVA: 0x00D5E238 File Offset: 0x00D5C438
		public void SendCertificateLevelRewardRequest()
		{
			CertificateLevelRewardRequest message = CertificateLevelRewardRequest.Create();
			Net.Instance.Call(ERequestMessageId.CertificateLevelRewardRequest, message, new Action<IMessage, Net.CallbackStatus>(this.HandleCertificateLevelRewardResponse), 0);
		}

		// Token: 0x0602FE71 RID: 196209 RVA: 0x00D5E268 File Offset: 0x00D5C468
		private void HandleCertificateLevelRewardResponse(IMessage msg, Net.CallbackStatus _)
		{
			CertificateLevelRewardResponse certificateLevelRewardResponse = (CertificateLevelRewardResponse)msg;
			if (certificateLevelRewardResponse.Code == Aki.Protocol.ErrorCode.Success)
			{
				EventSystem.Instance.Emit(EEventName.UpgradeCookerLevel);
				return;
			}
			ErrorCodeController.Instance.OpenErrorCodeTipView(certificateLevelRewardResponse.Code, 25731, null, true, true);
		}

		// Token: 0x0602FE72 RID: 196210 RVA: 0x00D5E2B0 File Offset: 0x00D5C4B0
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

		// Token: 0x0602FE73 RID: 196211 RVA: 0x00D5E308 File Offset: 0x00D5C508
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
			ErrorCodeController.Instance.OpenErrorCodeTipView(response.Code, 20809, null, true, true);
		}

		// Token: 0x0602FE74 RID: 196212 RVA: 0x00D5E375 File Offset: 0x00D5C575
		public void SetCurrentFixId(int fixId)
		{
			CookModel.Instance.CurrentFixId = fixId;
		}

		// Token: 0x0602FE75 RID: 196213 RVA: 0x00D5E382 File Offset: 0x00D5C582
		public int GetCurrentFixId()
		{
			return CookModel.Instance.CurrentFixId;
		}

		// Token: 0x0602FE76 RID: 196214 RVA: 0x00D5E38E File Offset: 0x00D5C58E
		public void SetCurrentEntityId(long entityId)
		{
			CookModel.Instance.CurrentEntityId = new long?(entityId);
		}

		// Token: 0x0602FE77 RID: 196215 RVA: 0x00D5E3A0 File Offset: 0x00D5C5A0
		public long? GetCurrentEntityId()
		{
			return CookModel.Instance.CurrentEntityId;
		}

		// Token: 0x0602FE78 RID: 196216 RVA: 0x00D5E3AC File Offset: 0x00D5C5AC
		public bool CheckCanCook(int itemId)
		{
			return CookModel.Instance.CheckCanCook(itemId);
		}

		// Token: 0x0602FE79 RID: 196217 RVA: 0x00D5E3BC File Offset: 0x00D5C5BC
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

		// Token: 0x0602FE7A RID: 196218 RVA: 0x00D5E41C File Offset: 0x00D5C61C
		public bool CheckCanAdd(int sum, int itemId, ECookListType type)
		{
			if (type != ECookListType.Cooking)
			{
				return type == ECookListType.Machining && this.DoCheckCanAdd(sum, CookConfig.Instance.GetCookProcessedById(itemId).ConsumeItemsId());
			}
			return this.DoCheckCanAdd(sum, CookConfig.Instance.GetCookFormulaById(itemId).ConsumeItems());
		}

		// Token: 0x0602FE7B RID: 196219 RVA: 0x00D5E46C File Offset: 0x00D5C66C
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

		// Token: 0x0602FE7C RID: 196220 RVA: 0x00D5E4B4 File Offset: 0x00D5C6B4
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

		// Token: 0x0602FE7D RID: 196221 RVA: 0x00D5E500 File Offset: 0x00D5C700
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

		// Token: 0x0602FE7E RID: 196222 RVA: 0x00D5E580 File Offset: 0x00D5C780
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

		// Token: 0x0602FE7F RID: 196223 RVA: 0x00D5E5C0 File Offset: 0x00D5C7C0
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
			foreach (int num2 in RoleModel.Instance.GetRoleIdList(null))
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

		// Token: 0x0602FE80 RID: 196224 RVA: 0x00D5E670 File Offset: 0x00D5C870
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

		// Token: 0x0602FE81 RID: 196225 RVA: 0x00D5E70C File Offset: 0x00D5C90C
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

		// Token: 0x0602FE82 RID: 196226 RVA: 0x00D5E794 File Offset: 0x00D5C994
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

		// Token: 0x0602FE83 RID: 196227 RVA: 0x00D5E814 File Offset: 0x00D5CA14
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

		// Token: 0x0602FE84 RID: 196228 RVA: 0x00D5E894 File Offset: 0x00D5CA94
		public bool CheckIsUnlock(int machiningId, int itemId)
		{
			return CookModel.Instance.GetMachiningDataById(machiningId).UnlockList.Contains(itemId);
		}

		// Token: 0x0602FE85 RID: 196229 RVA: 0x00D5E8AC File Offset: 0x00D5CAAC
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

		// Token: 0x0602FE86 RID: 196230 RVA: 0x00D5E8F4 File Offset: 0x00D5CAF4
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

		// Token: 0x0602FE87 RID: 196231 RVA: 0x00D5E938 File Offset: 0x00D5CB38
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

		// Token: 0x0602FE88 RID: 196232 RVA: 0x00D5EA14 File Offset: 0x00D5CC14
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

		// Token: 0x0602FE89 RID: 196233 RVA: 0x00D5EA3C File Offset: 0x00D5CC3C
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

		// Token: 0x0602FE8A RID: 196234 RVA: 0x00D5EB0F File Offset: 0x00D5CD0F
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

		// Token: 0x0602FE8B RID: 196235 RVA: 0x00D5EB34 File Offset: 0x00D5CD34
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

		// Token: 0x0602FE8C RID: 196236 RVA: 0x00D5EBD0 File Offset: 0x00D5CDD0
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

		// Token: 0x0602FE8D RID: 196237 RVA: 0x00D5EC0C File Offset: 0x00D5CE0C
		[NullableContext(1)]
		public void TryRequestChangeEntityStateByEvent(ECookMechanismState @event, UiViewBase view)
		{
			bool flag = false;
			IReadOnlyList<EUiViewName> cookEntityCanChangeArray = CookDefine.CookEntityCanChangeArray;
			EUiViewName name = view.ViewInfo.Name;
			for (int i = 0; i < cookEntityCanChangeArray.Count; i++)
			{
				if (cookEntityCanChangeArray[i] == name)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
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

		// Token: 0x17006010 RID: 24592
		// (get) Token: 0x0602FE8E RID: 196238 RVA: 0x00D5ECE7 File Offset: 0x00D5CEE7
		[Nullable(1)]
		public static CookController Instance
		{
			[NullableContext(1)]
			get
			{
				return CookController._Instance;
			}
		}

		// Token: 0x0602FE8F RID: 196239 RVA: 0x00D5ECEE File Offset: 0x00D5CEEE
		[NullableContext(1)]
		public static CookController GetOrCreateInstance()
		{
			if (CookController._Instance == null)
			{
				CookController.CreateInstance();
			}
			return CookController._Instance;
		}

		// Token: 0x0602FE90 RID: 196240 RVA: 0x00D5ED02 File Offset: 0x00D5CF02
		public static bool CreateInstance()
		{
			if (CookController._Instance != null)
			{
				return true;
			}
			CookController._Instance = new CookController();
			return true;
		}

		// Token: 0x0602FE91 RID: 196241 RVA: 0x00D5ED18 File Offset: 0x00D5CF18
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602FE92 RID: 196242 RVA: 0x00D5ED1A File Offset: 0x00D5CF1A
		public static void ResetStaticDefaultValue()
		{
			CookController._Instance = null;
		}

		// Token: 0x0602FE93 RID: 196243 RVA: 0x00D5ED22 File Offset: 0x00D5CF22
		static CookController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CookController.CreateStaticDefaultValue), new Action(CookController.ResetStaticDefaultValue));
		}

		// Token: 0x040196E2 RID: 104162
		public int CookCoinId;

		// Token: 0x040196E3 RID: 104163
		private TimerHandle CookDisplayTimerId;

		// Token: 0x040196E4 RID: 104164
		public bool IsPlayingSuccessDisplay;

		// Token: 0x040196E5 RID: 104165
		public bool IsPlayingFailDisplay;

		// Token: 0x040196E6 RID: 104166
		private Action OnCookSuccessFinished;

		// Token: 0x040196E7 RID: 104167
		private Action OnCookFailFinished;

		// Token: 0x040196E8 RID: 104168
		private static CookController _Instance;

		// Token: 0x0200A748 RID: 42824
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04033B02 RID: 211714
			[Nullable(0)]
			public static Action<int> <0>__UpdateCookRoleItemDataList;
		}
	}
}
