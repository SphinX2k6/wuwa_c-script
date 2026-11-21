using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.ItemDeliver
{
	// Token: 0x020047E9 RID: 18409
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ItemDeliverController : UiControllerBase
	{
		// Token: 0x0602E3F8 RID: 189432 RVA: 0x00CE6260 File Offset: 0x00CE4460
		public void HandInItemRequest(GeneralContext context, List<PbHandInItem> handInItem, [Nullable(2)] Action<bool> onResponseCallback = null)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.GeneralLogicTree)
			{
				Action<bool> onResponseCallback2 = onResponseCallback;
				if (onResponseCallback2 == null)
				{
					return;
				}
				onResponseCallback2(false);
				return;
			}
			else
			{
				GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext == null)
				{
					Log.Instance.Warn(ELogModule.Item, ELogAuthor.LRX, "ItemDeliverController::HandInItemRequest context is " + context.GetType().Name + ", not GeneralLogicTreeContext", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				int? behaviorTreeOwnerId = GeneralLogicTreeModel.Instance.GetBehaviorTreeOwnerId(new long?(generalLogicTreeContext.TreeIncId));
				HandInItemRequest handInItemRequest = Aki.Protocol.HandInItemRequest.Create();
				handInItemRequest.TreeOwnerId = behaviorTreeOwnerId.Value;
				handInItemRequest.TreeIncId = generalLogicTreeContext.TreeIncId;
				handInItemRequest.NodeId = generalLogicTreeContext.NodeId;
				handInItemRequest.HandInItem.AddRange(handInItem);
				Net.Instance.Call(ERequestMessageId.HandInItemRequest, handInItemRequest, delegate(IMessage msg, Net.CallbackStatus _)
				{
					HandInItemResponse handInItemResponse = (HandInItemResponse)msg;
					if (handInItemResponse == null)
					{
						Action<bool> onResponseCallback3 = onResponseCallback;
						if (onResponseCallback3 == null)
						{
							return;
						}
						onResponseCallback3(false);
						return;
					}
					else if (handInItemResponse.ErrorId != Aki.Protocol.ErrorCode.Success)
					{
						ErrorCodeController.Instance.OpenErrorCodeTipView(handInItemResponse.ErrorId, EResponseMessageId.HandInItemResponse, null, true, true);
						Action<bool> onResponseCallback4 = onResponseCallback;
						if (onResponseCallback4 == null)
						{
							return;
						}
						onResponseCallback4(false);
						return;
					}
					else
					{
						Action<bool> onResponseCallback5 = onResponseCallback;
						if (onResponseCallback5 == null)
						{
							return;
						}
						onResponseCallback5(true);
						return;
					}
				}, 0);
				return;
			}
		}

		// Token: 0x0602E3F9 RID: 189433 RVA: 0x00CE6344 File Offset: 0x00CE4544
		public void ItemUseRequest(GeneralContext context, int itemConfigId, int itemCount, [Nullable(2)] Action<bool> onResponseCallback = null)
		{
			if (context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				ItemUseRequest request = Aki.Protocol.ItemUseRequest.Create();
				request.Count = 1;
				request.ItemId = itemConfigId;
				request.Count = itemCount;
				Net.Instance.Call(ERequestMessageId.ItemUseRequest, request, delegate(IMessage msg, Net.CallbackStatus _)
				{
					ItemUseResponse itemUseResponse = (ItemUseResponse)msg;
					if (itemUseResponse == null)
					{
						Action<bool> onResponseCallback3 = onResponseCallback;
						if (onResponseCallback3 == null)
						{
							return;
						}
						onResponseCallback3(false);
						return;
					}
					else
					{
						if (itemUseResponse.ErrCode == Aki.Protocol.ErrorCode.Success)
						{
							Action<bool> onResponseCallback4 = onResponseCallback;
							if (onResponseCallback4 != null)
							{
								onResponseCallback4(true);
							}
							EventSystem.Instance.Emit<int>(EEventName.OnDeliveryProps, request.ItemId);
							return;
						}
						ErrorCodeController.Instance.OpenErrorCodeTipView(itemUseResponse.ErrCode, EResponseMessageId.ItemUseResponse, null, true, true);
						Action<bool> onResponseCallback5 = onResponseCallback;
						if (onResponseCallback5 == null)
						{
							return;
						}
						onResponseCallback5(false);
						return;
					}
				}, 0);
				return;
			}
			Action<bool> onResponseCallback2 = onResponseCallback;
			if (onResponseCallback2 == null)
			{
				return;
			}
			onResponseCallback2(false);
		}

		// Token: 0x0602E3FA RID: 189434 RVA: 0x00CE63D0 File Offset: 0x00CE45D0
		[NullableContext(0)]
		public UniTask<bool> OpenItemDeliverView([Nullable(1)] DeliverData itemDeliverData)
		{
			ItemDeliverController.<OpenItemDeliverView>d__2 <OpenItemDeliverView>d__;
			<OpenItemDeliverView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenItemDeliverView>d__.itemDeliverData = itemDeliverData;
			<OpenItemDeliverView>d__.<>1__state = -1;
			<OpenItemDeliverView>d__.<>t__builder.Start<ItemDeliverController.<OpenItemDeliverView>d__2>(ref <OpenItemDeliverView>d__);
			return <OpenItemDeliverView>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3FB RID: 189435 RVA: 0x00CE6414 File Offset: 0x00CE4614
		[NullableContext(2)]
		[return: Nullable(0)]
		public UniTask<bool> OpenItemDeliverViewByHandInItem([Nullable(1)] List<IHandInItem> items, [Nullable(1)] string npcName, string titleTextId = null, string descriptionTextId = null, GeneralContext content = null)
		{
			ItemDeliverController.<OpenItemDeliverViewByHandInItem>d__3 <OpenItemDeliverViewByHandInItem>d__;
			<OpenItemDeliverViewByHandInItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenItemDeliverViewByHandInItem>d__.<>4__this = this;
			<OpenItemDeliverViewByHandInItem>d__.items = items;
			<OpenItemDeliverViewByHandInItem>d__.npcName = npcName;
			<OpenItemDeliverViewByHandInItem>d__.titleTextId = titleTextId;
			<OpenItemDeliverViewByHandInItem>d__.descriptionTextId = descriptionTextId;
			<OpenItemDeliverViewByHandInItem>d__.content = content;
			<OpenItemDeliverViewByHandInItem>d__.<>1__state = -1;
			<OpenItemDeliverViewByHandInItem>d__.<>t__builder.Start<ItemDeliverController.<OpenItemDeliverViewByHandInItem>d__3>(ref <OpenItemDeliverViewByHandInItem>d__);
			return <OpenItemDeliverViewByHandInItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602E3FC RID: 189436 RVA: 0x00CE6484 File Offset: 0x00CE4684
		[NullableContext(2)]
		public void OpenItemDeliverViewByHandInGroup([Nullable(1)] IHandInGroup handInGroup, [Nullable(1)] string npcName, string titleTextId = null, string descriptionTextId = null, GeneralContext content = null)
		{
			if (handInGroup == null)
			{
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.ItemDeliverView))
			{
				return;
			}
			InventoryModel instance = InventoryModel.Instance;
			DeliverData deliverData = new DeliverData(npcName, titleTextId, descriptionTextId, content);
			EHandInItemType handInType = handInGroup.HandInType;
			List<int> itemIds = handInGroup.ItemIds;
			int count = handInGroup.Count;
			for (int i = 0; i < handInGroup.Slot; i++)
			{
				if (handInType == EHandInItemType.ItemIds)
				{
					DeliverSlotData deliverSlotData = deliverData.AddSlotData(itemIds, count, handInType);
					if (itemIds.Count == 1)
					{
						int itemConfigId = itemIds[0];
						int itemCountByConfigId = instance.GetItemCountByConfigId(itemConfigId, 0);
						if (deliverSlotData != null)
						{
							deliverSlotData.SetItem(itemConfigId, Math.Min(count, itemCountByConfigId));
						}
					}
				}
				else if (handInType == EHandInItemType.ItemType)
				{
					List<int> list = new List<int>();
					ItemConfig instance2 = ItemConfig.Instance;
					foreach (int itemType in itemIds)
					{
						foreach (ItemInfo itemInfo in instance2.GetConfigListByItemType(itemType))
						{
							int id = itemInfo.Id;
							list.Add(id);
						}
					}
					deliverData.AddSlotData(list, count, handInType);
				}
			}
			this.OpenItemDeliverView(deliverData);
		}

		// Token: 0x17005DF1 RID: 24049
		// (get) Token: 0x0602E3FD RID: 189437 RVA: 0x00CE65F0 File Offset: 0x00CE47F0
		public static ItemDeliverController Instance
		{
			get
			{
				return ItemDeliverController._Instance;
			}
		}

		// Token: 0x0602E3FE RID: 189438 RVA: 0x00CE65F7 File Offset: 0x00CE47F7
		public static ItemDeliverController GetOrCreateInstance()
		{
			if (ItemDeliverController._Instance == null)
			{
				ItemDeliverController.CreateInstance();
			}
			return ItemDeliverController._Instance;
		}

		// Token: 0x0602E3FF RID: 189439 RVA: 0x00CE660B File Offset: 0x00CE480B
		public static bool CreateInstance()
		{
			if (ItemDeliverController._Instance != null)
			{
				return true;
			}
			ItemDeliverController._Instance = new ItemDeliverController();
			return true;
		}

		// Token: 0x0602E400 RID: 189440 RVA: 0x00CE6621 File Offset: 0x00CE4821
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E401 RID: 189441 RVA: 0x00CE6623 File Offset: 0x00CE4823
		public static void ResetStaticDefaultValue()
		{
			ItemDeliverController._Instance = null;
		}

		// Token: 0x0602E402 RID: 189442 RVA: 0x00CE662B File Offset: 0x00CE482B
		static ItemDeliverController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemDeliverController.CreateStaticDefaultValue), new Action(ItemDeliverController.ResetStaticDefaultValue));
		}

		// Token: 0x04018A0C RID: 100876
		[Nullable(2)]
		private static ItemDeliverController _Instance;
	}
}
