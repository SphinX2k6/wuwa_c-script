using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047FD RID: 18429
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ItemController : UiControllerBase
	{
		// Token: 0x0602E460 RID: 189536 RVA: 0x00CE7EE4 File Offset: 0x00CE60E4
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
			EventSystem.Instance.Add<IProto_NormalItem, bool>(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Add<WeaponItem, bool, bool>(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
			EventSystem.Instance.Add<TItem[]>(EEventName.OnAddOrnamentItemList, new Action<TItem[]>(this.OnAddOrnamentItemList));
		}

		// Token: 0x0602E461 RID: 189537 RVA: 0x00CE7F64 File Offset: 0x00CE6164
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnLoadingNetDataDone, new Action(this.OnDataDone));
			EventSystem.Instance.Remove(EEventName.OnAddCommonItem, new Action<IProto_NormalItem, bool>(this.OnAddCommonItem));
			EventSystem.Instance.Remove(EEventName.OnAddWeaponItem, new Action<WeaponItem, bool, bool>(this.OnAddWeaponItem));
			EventSystem.Instance.Remove<TItem[]>(EEventName.OnAddOrnamentItemList, new Action<TItem[]>(this.OnAddOrnamentItemList));
		}

		// Token: 0x0602E462 RID: 189538 RVA: 0x00CE7FE1 File Offset: 0x00CE61E1
		private void OnDataDone()
		{
			ItemModel.Instance.LoadGetItemConfigIdList();
		}

		// Token: 0x0602E463 RID: 189539 RVA: 0x00CE7FF0 File Offset: 0x00CE61F0
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

		// Token: 0x0602E464 RID: 189540 RVA: 0x00CE8054 File Offset: 0x00CE6254
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

		// Token: 0x0602E465 RID: 189541 RVA: 0x00CE808C File Offset: 0x00CE628C
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

		// Token: 0x0602E466 RID: 189542 RVA: 0x00CE80D8 File Offset: 0x00CE62D8
		[NullableContext(2)]
		public void OpenItemTipsByItemId(int itemId, bool canSkip = true, TOpenViewCallBack finishCallback = null, bool hideNum = false)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemId = itemId;
			itemTipsParam.CanSkip = canSkip;
			itemTipsParam.HideNum = hideNum;
			EventSystem.Instance.Emit<int, bool>(EEventName.CsSyncItemTipsData, itemId, canSkip);
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, finishCallback);
		}

		// Token: 0x0602E467 RID: 189543 RVA: 0x00CE8124 File Offset: 0x00CE6324
		public void OpenTitleTipsByItemId(int titleId)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemId = titleId;
			itemTipsParam.CanSkip = true;
			itemTipsParam.ExtraParam = "OpenTitlePreviewView";
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, null);
		}

		// Token: 0x0602E468 RID: 189544 RVA: 0x00CE8164 File Offset: 0x00CE6364
		[NullableContext(2)]
		public void OpenItemTipsByItemUid(int itemUid, int itemConfigId, bool canSkip = true, TOpenViewCallBack finishCallback = null)
		{
			ItemTipsParam itemTipsParam = new ItemTipsParam();
			itemTipsParam.ItemUid = itemUid;
			itemTipsParam.ItemId = itemConfigId;
			itemTipsParam.CanSkip = canSkip;
			UiManager.Instance.OpenView(EUiViewName.ItemTipsView, itemTipsParam, finishCallback);
		}

		// Token: 0x0602E469 RID: 189545 RVA: 0x00CE81A0 File Offset: 0x00CE63A0
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

		// Token: 0x0602E46A RID: 189546 RVA: 0x00CE81E2 File Offset: 0x00CE63E2
		public void AddNewItemTip(int itemId)
		{
			ItemModel.Instance.PushWaitItemList(itemId);
		}

		// Token: 0x0602E46B RID: 189547 RVA: 0x00CE81F0 File Offset: 0x00CE63F0
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

		// Token: 0x17005DF4 RID: 24052
		// (get) Token: 0x0602E46C RID: 189548 RVA: 0x00CE83E4 File Offset: 0x00CE65E4
		public static ItemController Instance
		{
			get
			{
				return ItemController._Instance;
			}
		}

		// Token: 0x0602E46D RID: 189549 RVA: 0x00CE83EB File Offset: 0x00CE65EB
		public static ItemController GetOrCreateInstance()
		{
			if (ItemController._Instance == null)
			{
				ItemController.CreateInstance();
			}
			return ItemController._Instance;
		}

		// Token: 0x0602E46E RID: 189550 RVA: 0x00CE83FF File Offset: 0x00CE65FF
		public static bool CreateInstance()
		{
			if (ItemController._Instance != null)
			{
				return true;
			}
			ItemController._Instance = new ItemController();
			return true;
		}

		// Token: 0x0602E46F RID: 189551 RVA: 0x00CE8415 File Offset: 0x00CE6615
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E470 RID: 189552 RVA: 0x00CE8417 File Offset: 0x00CE6617
		public static void ResetStaticDefaultValue()
		{
			ItemController._Instance = null;
		}

		// Token: 0x0602E471 RID: 189553 RVA: 0x00CE841F File Offset: 0x00CE661F
		static ItemController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemController.CreateStaticDefaultValue), new Action(ItemController.ResetStaticDefaultValue));
		}

		// Token: 0x04018A57 RID: 100951
		public double? LastItemHintAudioPlayedTime;

		// Token: 0x04018A58 RID: 100952
		public int LastItemHintAudioLevel;

		// Token: 0x04018A59 RID: 100953
		public bool IsPrintNoRewardReason;

		// Token: 0x04018A5A RID: 100954
		[Nullable(2)]
		private static ItemController _Instance;
	}
}
