using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02005826 RID: 22566
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ItemController : UiControllerBase
	{
		// Token: 0x0603954C RID: 234828 RVA: 0x00D99058 File Offset: 0x00D97258
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
			EventSystem.Instance.Add<IProto_NormalItem, bool>(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Add<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
			EventSystem.Instance.Add<TItem[]>(EEventName.OnAddOrnamentItemList, new Action<TItem[]>(this.OnAddOrnamentItemList));
		}

		// Token: 0x0603954D RID: 234829 RVA: 0x00D990D8 File Offset: 0x00D972D8
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
			EventSystem.Instance.Remove(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Remove(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
			EventSystem.Instance.Remove<TItem[]>(EEventName.OnAddOrnamentItemList, new Action<TItem[]>(this.OnAddOrnamentItemList));
		}

		// Token: 0x0603954E RID: 234830 RVA: 0x00D99155 File Offset: 0x00D97355
		private void OnDataDone()
		{
			ItemModel.Instance.LoadGetItemConfigIdList();
		}

		// Token: 0x0603954F RID: 234831 RVA: 0x00D99164 File Offset: 0x00D97364
		private void OnAddCommonItem(IProto_NormalItem normalItem, bool isShowNewTips)
		{
			ItemModel instance = ItemModel.Instance;
			int id = normalItem.Id;
			if (instance.IsGotItem(id))
			{
				return;
			}
			ItemInfo? config = ItemConfig.Instance.GetConfig(id);
			if (config != null && config.GetValueOrDefault().ObtainedShow == 0)
			{
				return;
			}
			if (isShowNewTips)
			{
				this.AddNewItemTip(id);
			}
			instance.AddGetItemConfigIdList(id);
		}

		// Token: 0x06039550 RID: 234832 RVA: 0x00D991C8 File Offset: 0x00D973C8
		private void OnAddWeaponItem(WeaponItem weaponItem, bool bAddFromRole, bool isShowNewTips)
		{
			int id = weaponItem.Id;
			ItemModel instance = ItemModel.Instance;
			if (instance.IsGotItem(id))
			{
				return;
			}
			if (isShowNewTips)
			{
				this.AddNewItemTip(id);
			}
			instance.AddGetItemConfigIdList(id);
		}

		// Token: 0x06039551 RID: 234833 RVA: 0x00D99200 File Offset: 0x00D97400
		private void OnAddOrnamentItemList(TItem[] itemList)
		{
			ItemModel instance = ItemModel.Instance;
			for (int i = 0; i < itemList.Length; i++)
			{
				int itemId = itemList[i].ItemData.ItemId;
				if (!instance.IsGotItem(itemId))
				{
					this.AddNewItemTip(itemId);
					instance.AddGetItemConfigIdList(itemId);
				}
			}
		}

		// Token: 0x06039552 RID: 234834 RVA: 0x00D9924C File Offset: 0x00D9744C
		[NullableContext(2)]
		public void OpenItemTipsByItemId(int itemId, bool canSkip = true, TOpenViewCallBack finishCallback = null)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemId = itemId;
			itemTipsParam.CanSkip = canSkip;
			EventSystem.Instance.Emit<int, bool>(EEventName.CsSyncItemTipsData, itemId, canSkip);
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, finishCallback);
		}

		// Token: 0x06039553 RID: 234835 RVA: 0x00D99290 File Offset: 0x00D97490
		public void OpenTitleTipsByItemId(int titleId)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemId = titleId;
			itemTipsParam.CanSkip = true;
			itemTipsParam.ExtraParam = "OpenTitlePreviewView";
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, null);
		}

		// Token: 0x06039554 RID: 234836 RVA: 0x00D992D0 File Offset: 0x00D974D0
		[NullableContext(2)]
		public void OpenItemTipsByItemUid(int itemUid, int itemConfigId, bool canSkip = true, TOpenViewCallBack finishCallback = null)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemUid = itemUid;
			itemTipsParam.ItemId = itemConfigId;
			itemTipsParam.CanSkip = canSkip;
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, finishCallback);
		}

		// Token: 0x06039555 RID: 234837 RVA: 0x00D9930C File Offset: 0x00D9750C
		[NullableContext(2)]
		public void OpenItemTipsByExtraParam(int itemUid, int itemConfigId, object extraParam, bool canSkip = true, TOpenViewCallBack finishCallback = null)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemUid = itemUid;
			itemTipsParam.ItemId = itemConfigId;
			itemTipsParam.ExtraParam = extraParam;
			itemTipsParam.CanSkip = canSkip;
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, finishCallback);
		}

		// Token: 0x06039556 RID: 234838 RVA: 0x00D9934E File Offset: 0x00D9754E
		public void AddNewItemTip(int itemId)
		{
			ItemModel.Instance.PushWaitItemList(itemId);
		}

		// Token: 0x06039557 RID: 234839 RVA: 0x00D9935C File Offset: 0x00D9755C
		public void CheckNewItemTips()
		{
			if (ItemModel.Instance.IsWaitItemListEmpty() && ItemModel.Instance.IsWaitPhantomListEmpty() && ItemModel.Instance.IsWaitVillageInfrTreeListEmpty())
			{
				bool isPrintNoRewardReason = this.IsPrintNoRewardReason;
				return;
			}
			if (UiManager.Instance.IsViewOpen(EUiViewName.NewItemTipsView) || UiManager.Instance.IsViewOpen(EUiViewName.PhantomTipsView) || UiManager.Instance.IsViewOpen(EUiViewName.VillageInfrNewTipsView) || !UiManager.Instance.IsViewShow(EUiViewName.BattleView))
			{
				bool isPrintNoRewardReason2 = this.IsPrintNoRewardReason;
				return;
			}
			if (SundryModel.Instance.IsBlockTips)
			{
				bool isPrintNoRewardReason3 = this.IsPrintNoRewardReason;
				return;
			}
			int? intConfig = ConfigCommonParamById.GetIntConfig("next_new_item_show_time");
			double serverTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
			double lastCloseTimeStamp = ItemModel.Instance.LastCloseTimeStamp;
			int? num = intConfig;
			double? num2 = lastCloseTimeStamp + ((num != null) ? new double?((double)num.GetValueOrDefault()) : null);
			if (serverTimeStamp < num2.GetValueOrDefault() & num2 != null)
			{
				return;
			}
			if (!ItemModel.Instance.IsWaitItemListEmpty())
			{
				int? num3 = ItemModel.Instance.ShiftWaitItemList();
				UiManager.Instance.OpenView(EUiViewName.NewItemTipsView, num3, null);
			}
			else if (!ItemModel.Instance.IsWaitPhantomListEmpty())
			{
				int? num4 = ItemModel.Instance.ShiftWaitPhantomList();
				UiManager.Instance.OpenView(EUiViewName.PhantomTipsView, num4, null);
			}
			else if (!ItemModel.Instance.IsWaitVillageInfrTreeListEmpty())
			{
				int? num5 = ItemModel.Instance.ShiftWaitVillageInfrTree();
				UiManager.Instance.OpenView(EUiViewName.VillageInfrNewTipsView, num5, null);
			}
			AudioSystem.Instance.PostEvent("play_ui_item_hint_get_item_first_time");
			this.LastItemHintAudioPlayedTime = new double?(Time.Instance.Now);
			this.LastItemHintAudioLevel = 3;
			Log.Instance.Info(ELogModule.Audio, ELogAuthor.YJY, "[Item] 播放新物品提示音效", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x17008A2A RID: 35370
		// (get) Token: 0x06039558 RID: 234840 RVA: 0x00D99550 File Offset: 0x00D97750
		public static ItemController Instance
		{
			get
			{
				return ItemController._Instance;
			}
		}

		// Token: 0x06039559 RID: 234841 RVA: 0x00D99557 File Offset: 0x00D97757
		public static ItemController GetOrCreateInstance()
		{
			if (ItemController._Instance == null)
			{
				ItemController.CreateInstance();
			}
			return ItemController._Instance;
		}

		// Token: 0x0603955A RID: 234842 RVA: 0x00D9956B File Offset: 0x00D9776B
		public static bool CreateInstance()
		{
			if (ItemController._Instance != null)
			{
				return true;
			}
			ItemController._Instance = new ItemController();
			return true;
		}

		// Token: 0x0603955B RID: 234843 RVA: 0x00D99581 File Offset: 0x00D97781
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603955C RID: 234844 RVA: 0x00D99583 File Offset: 0x00D97783
		public static void ResetStaticDefaultValue()
		{
			ItemController._Instance = null;
		}

		// Token: 0x0603955D RID: 234845 RVA: 0x00D9958B File Offset: 0x00D9778B
		static ItemController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemController.CreateStaticDefaultValue), new Action(ItemController.ResetStaticDefaultValue));
		}

		// Token: 0x0401DFC0 RID: 122816
		public double? LastItemHintAudioPlayedTime;

		// Token: 0x0401DFC1 RID: 122817
		public int LastItemHintAudioLevel;

		// Token: 0x0401DFC2 RID: 122818
		public bool IsPrintNoRewardReason;

		// Token: 0x0401DFC3 RID: 122819
		[Nullable(2)]
		private static ItemController _Instance;
	}
}
