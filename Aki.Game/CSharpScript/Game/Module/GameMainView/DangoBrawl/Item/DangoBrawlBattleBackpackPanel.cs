using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GameMainView.DangoBrawl.Item
{
	// Token: 0x02005A0B RID: 23051
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBackpackPanel : UiPanelBase
	{
		// Token: 0x0603A72E RID: 239406 RVA: 0x00DE7FE8 File Offset: 0x00DE61E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A72F RID: 239407 RVA: 0x00DE80B4 File Offset: 0x00DE62B4
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0603A730 RID: 239408 RVA: 0x00DE80DC File Offset: 0x00DE62DC
		public UniTask RefreshOnShow([Nullable(new byte[]
		{
			2,
			1
		})] List<DangoBrawlBackpackItemData> itemDataList)
		{
			DangoBrawlBattleBackpackPanel.<RefreshOnShow>d__11 <RefreshOnShow>d__;
			<RefreshOnShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshOnShow>d__.<>4__this = this;
			<RefreshOnShow>d__.itemDataList = itemDataList;
			<RefreshOnShow>d__.<>1__state = -1;
			<RefreshOnShow>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<RefreshOnShow>d__11>(ref <RefreshOnShow>d__);
			return <RefreshOnShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603A731 RID: 239409 RVA: 0x00DE8128 File Offset: 0x00DE6328
		[NullableContext(2)]
		public UniTask RefreshOnShow(DangoBrawlBackPackServerData serverData)
		{
			DangoBrawlBattleBackpackPanel.<RefreshOnShow>d__12 <RefreshOnShow>d__;
			<RefreshOnShow>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshOnShow>d__.<>4__this = this;
			<RefreshOnShow>d__.serverData = serverData;
			<RefreshOnShow>d__.<>1__state = -1;
			<RefreshOnShow>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<RefreshOnShow>d__12>(ref <RefreshOnShow>d__);
			return <RefreshOnShow>d__.<>t__builder.Task;
		}

		// Token: 0x0603A732 RID: 239410 RVA: 0x00DE8174 File Offset: 0x00DE6374
		private void Init()
		{
			this.ClearItemSelected();
			foreach (KeyValuePair<int, DangoBrawlBattleBackpack> keyValuePair in this.BagMap)
			{
				keyValuePair.Value.ResetOnInit();
				this.BagPool.Push(keyValuePair.Value);
			}
			this.BagMap.Clear();
			foreach (KeyValuePair<int, DangoBrawlBattleBackpackItem> keyValuePair2 in this.BagItemMap)
			{
				keyValuePair2.Value.ResetOnInit();
				this.BagItemPool.Push(keyValuePair2.Value);
			}
			this.BagItemMap.Clear();
			this.ItemConfigMap.Clear();
		}

		// Token: 0x0603A733 RID: 239411 RVA: 0x00DE8260 File Offset: 0x00DE6460
		private UniTask RefreshBackpack(DangoBrawlNormalBagItemInfo info)
		{
			if (DangoBrawlUtil.GetTemplateType(DangoBrawlUtil.GetTemplateId(info.Inst.ConfigId)) == EDangoBrawlTemplateType.Bag)
			{
				return this.CreateBag(info);
			}
			return this.CreateBagItem(info);
		}

		// Token: 0x0603A734 RID: 239412 RVA: 0x00DE8288 File Offset: 0x00DE6488
		private UniTask CreateBag(DangoBrawlNormalBagItemInfo info)
		{
			DangoBrawlBattleBackpackPanel.<CreateBag>d__15 <CreateBag>d__;
			<CreateBag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBag>d__.<>4__this = this;
			<CreateBag>d__.info = info;
			<CreateBag>d__.<>1__state = -1;
			<CreateBag>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<CreateBag>d__15>(ref <CreateBag>d__);
			return <CreateBag>d__.<>t__builder.Task;
		}

		// Token: 0x0603A735 RID: 239413 RVA: 0x00DE82D4 File Offset: 0x00DE64D4
		private UniTask CreateBag(DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlBattleBackpackPanel.<CreateBag>d__16 <CreateBag>d__;
			<CreateBag>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBag>d__.<>4__this = this;
			<CreateBag>d__.itemData = itemData;
			<CreateBag>d__.<>1__state = -1;
			<CreateBag>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<CreateBag>d__16>(ref <CreateBag>d__);
			return <CreateBag>d__.<>t__builder.Task;
		}

		// Token: 0x0603A736 RID: 239414 RVA: 0x00DE8320 File Offset: 0x00DE6520
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<DangoBrawlBattleBackpack> AcquireBag()
		{
			DangoBrawlBattleBackpackPanel.<AcquireBag>d__17 <AcquireBag>d__;
			<AcquireBag>d__.<>t__builder = AsyncUniTaskMethodBuilder<DangoBrawlBattleBackpack>.Create();
			<AcquireBag>d__.<>4__this = this;
			<AcquireBag>d__.<>1__state = -1;
			<AcquireBag>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<AcquireBag>d__17>(ref <AcquireBag>d__);
			return <AcquireBag>d__.<>t__builder.Task;
		}

		// Token: 0x0603A737 RID: 239415 RVA: 0x00DE8364 File Offset: 0x00DE6564
		private UniTask CreateBagItem(DangoBrawlNormalBagItemInfo info)
		{
			DangoBrawlBattleBackpackPanel.<CreateBagItem>d__18 <CreateBagItem>d__;
			<CreateBagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagItem>d__.<>4__this = this;
			<CreateBagItem>d__.info = info;
			<CreateBagItem>d__.<>1__state = -1;
			<CreateBagItem>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<CreateBagItem>d__18>(ref <CreateBagItem>d__);
			return <CreateBagItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603A738 RID: 239416 RVA: 0x00DE83B0 File Offset: 0x00DE65B0
		private UniTask CreateBagItem(DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlBattleBackpackPanel.<CreateBagItem>d__19 <CreateBagItem>d__;
			<CreateBagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagItem>d__.<>4__this = this;
			<CreateBagItem>d__.itemData = itemData;
			<CreateBagItem>d__.<>1__state = -1;
			<CreateBagItem>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<CreateBagItem>d__19>(ref <CreateBagItem>d__);
			return <CreateBagItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603A739 RID: 239417 RVA: 0x00DE83FC File Offset: 0x00DE65FC
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private UniTask<DangoBrawlBattleBackpackItem> AcquireBagItem()
		{
			DangoBrawlBattleBackpackPanel.<AcquireBagItem>d__20 <AcquireBagItem>d__;
			<AcquireBagItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<DangoBrawlBattleBackpackItem>.Create();
			<AcquireBagItem>d__.<>4__this = this;
			<AcquireBagItem>d__.<>1__state = -1;
			<AcquireBagItem>d__.<>t__builder.Start<DangoBrawlBattleBackpackPanel.<AcquireBagItem>d__20>(ref <AcquireBagItem>d__);
			return <AcquireBagItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603A73A RID: 239418 RVA: 0x00DE8440 File Offset: 0x00DE6640
		private void RegisterBagItem(int uid, int configId, DangoBrawlBattleBackpackItem bagItem)
		{
			this.BagItemMap[uid] = bagItem;
			List<DangoBrawlBattleBackpackItem> list;
			if (!this.ItemConfigMap.TryGetValue(configId, out list))
			{
				list = new List<DangoBrawlBattleBackpackItem>();
				this.ItemConfigMap[configId] = list;
			}
			list.Add(bagItem);
			bagItem.OnClickItem = new Action<DangoBrawlBattleBackpackItem>(this.OnClickBagItem);
		}

		// Token: 0x0603A73B RID: 239419 RVA: 0x00DE8498 File Offset: 0x00DE6698
		public void ShowItemDamageText(int itemUid, int uiDamageConfigId, bool isSelf, int value, bool isCrit, bool isCure)
		{
			UUIItem uuiitem = null;
			DangoBrawlBattleBackpackItem dangoBrawlBattleBackpackItem;
			DangoBrawlBattleBackpack dangoBrawlBattleBackpack;
			if (this.BagItemMap.TryGetValue(itemUid, out dangoBrawlBattleBackpackItem))
			{
				uuiitem = dangoBrawlBattleBackpackItem.GetCenterItem();
			}
			else if (this.BagMap.TryGetValue(itemUid, out dangoBrawlBattleBackpack))
			{
				uuiitem = dangoBrawlBattleBackpack.GetCenterItem();
			}
			if (uuiitem == null)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			if (battleManager == null)
			{
				return;
			}
			battleManager.ShowUiDamageText(uiDamageConfigId, uuiitem, isSelf, value, isCrit, isCure, null);
		}

		// Token: 0x0603A73C RID: 239420 RVA: 0x00DE8504 File Offset: 0x00DE6704
		public void RegisterTimerHandle()
		{
			foreach (KeyValuePair<int, DangoBrawlBattleBackpackItem> keyValuePair in this.BagItemMap)
			{
				keyValuePair.Value.RegisterFightingTickCallback();
			}
		}

		// Token: 0x0603A73D RID: 239421 RVA: 0x00DE855C File Offset: 0x00DE675C
		public void UnRegisterTimerHandle()
		{
			foreach (KeyValuePair<int, DangoBrawlBattleBackpackItem> keyValuePair in this.BagItemMap)
			{
				keyValuePair.Value.UnregisterFightingTickCallback();
			}
			foreach (DangoBrawlBattleBackpackItem dangoBrawlBattleBackpackItem in this.BagItemPool)
			{
				dangoBrawlBattleBackpackItem.UnregisterFightingTickCallback();
			}
		}

		// Token: 0x0603A73E RID: 239422 RVA: 0x00DE85F0 File Offset: 0x00DE67F0
		public void CaptureCdSnapshots()
		{
			this.CdSnapshotCache.Clear();
			foreach (KeyValuePair<int, DangoBrawlBattleBackpackItem> keyValuePair in this.BagItemMap)
			{
				DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot value;
				if (keyValuePair.Value.TryGetCdSnapshot(out value))
				{
					this.CdSnapshotCache[keyValuePair.Key] = value;
				}
			}
		}

		// Token: 0x0603A73F RID: 239423 RVA: 0x00DE866C File Offset: 0x00DE686C
		public void RestoreCdSnapshots()
		{
			if (this.CdSnapshotCache.Count == 0)
			{
				return;
			}
			foreach (KeyValuePair<int, DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot> keyValuePair in this.CdSnapshotCache)
			{
				DangoBrawlBattleBackpackItem dangoBrawlBattleBackpackItem;
				if (this.BagItemMap.TryGetValue(keyValuePair.Key, out dangoBrawlBattleBackpackItem))
				{
					dangoBrawlBattleBackpackItem.ApplyCdSnapshot(keyValuePair.Value);
				}
			}
		}

		// Token: 0x0603A740 RID: 239424 RVA: 0x00DE86EC File Offset: 0x00DE68EC
		public void ClearCdSnapshots()
		{
			this.CdSnapshotCache.Clear();
		}

		// Token: 0x0603A741 RID: 239425 RVA: 0x00DE86FC File Offset: 0x00DE68FC
		public bool OnItemCdUpdate(int itemUid, int nextReadyMs)
		{
			DangoBrawlBattleBackpackItem dangoBrawlBattleBackpackItem;
			if (!this.BagItemMap.TryGetValue(itemUid, out dangoBrawlBattleBackpackItem))
			{
				return false;
			}
			dangoBrawlBattleBackpackItem.RefreshOnCDChange(nextReadyMs);
			return true;
		}

		// Token: 0x0603A742 RID: 239426 RVA: 0x00DE8724 File Offset: 0x00DE6924
		public bool OnWeaponStop(int itemUid, int stopMs)
		{
			DangoBrawlBattleBackpackItem dangoBrawlBattleBackpackItem;
			if (!this.BagItemMap.TryGetValue(itemUid, out dangoBrawlBattleBackpackItem))
			{
				return false;
			}
			dangoBrawlBattleBackpackItem.OnWeaponStop(stopMs);
			return true;
		}

		// Token: 0x0603A743 RID: 239427 RVA: 0x00DE874C File Offset: 0x00DE694C
		public bool OnItemEffectShow(DangoBrawlItemUIEffectData data)
		{
			DangoBrawlBattleBackpackItem dangoBrawlBattleBackpackItem;
			if (this.BagItemMap.TryGetValue(data.ItemUId, out dangoBrawlBattleBackpackItem))
			{
				dangoBrawlBattleBackpackItem.OnItemEffectShow(data);
				return true;
			}
			DangoBrawlBattleBackpack dangoBrawlBattleBackpack;
			if (this.BagMap.TryGetValue(data.ItemUId, out dangoBrawlBattleBackpack))
			{
				dangoBrawlBattleBackpack.OnItemEffectShow(data);
				return true;
			}
			return false;
		}

		// Token: 0x0603A744 RID: 239428 RVA: 0x00DE8796 File Offset: 0x00DE6996
		public void ClearItemSelected()
		{
			DangoBrawlBattleBackpack curSelectBag = this.CurSelectBag;
			if (curSelectBag != null)
			{
				curSelectBag.SetSelected(false);
			}
			DangoBrawlBattleBackpackItem curSelectBagItem = this.CurSelectBagItem;
			if (curSelectBagItem != null)
			{
				curSelectBagItem.SetSelected(false);
			}
			this.CurSelectBag = null;
			this.CurSelectBagItem = null;
		}

		// Token: 0x0603A745 RID: 239429 RVA: 0x00DE87CA File Offset: 0x00DE69CA
		private void SelectBag(DangoBrawlBattleBackpack bag)
		{
			if (this.CurSelectBag == bag)
			{
				return;
			}
			this.ClearItemSelected();
			this.CurSelectBag = bag;
			bag.SetSelected(true);
		}

		// Token: 0x0603A746 RID: 239430 RVA: 0x00DE87EA File Offset: 0x00DE69EA
		private void SelectBagItem(DangoBrawlBattleBackpackItem bagItem)
		{
			if (this.CurSelectBagItem == bagItem)
			{
				return;
			}
			this.ClearItemSelected();
			this.CurSelectBagItem = bagItem;
			bagItem.SetSelected(true);
		}

		// Token: 0x0603A747 RID: 239431 RVA: 0x00DE880C File Offset: 0x00DE6A0C
		private void OnClickBag(DangoBrawlBattleBackpack bag)
		{
			this.SelectBag(bag);
			DangoBrawlBackpackItemData myItemData = bag.MyItemData;
			if (myItemData != null)
			{
				Action<UUIItem, DangoBrawlBackpackItemData> onItemClick = this.OnItemClick;
				if (onItemClick == null)
				{
					return;
				}
				onItemClick(bag.GetRootItem(), myItemData);
			}
		}

		// Token: 0x0603A748 RID: 239432 RVA: 0x00DE8844 File Offset: 0x00DE6A44
		private void OnClickBagItem(DangoBrawlBattleBackpackItem bagItem)
		{
			this.SelectBagItem(bagItem);
			DangoBrawlBackpackItemData myItemData = bagItem.MyItemData;
			if (myItemData != null)
			{
				Action<UUIItem, DangoBrawlBackpackItemData> onItemClick = this.OnItemClick;
				if (onItemClick == null)
				{
					return;
				}
				onItemClick(bagItem.GetRootItem(), myItemData);
			}
		}

		// Token: 0x0401E74C RID: 124748
		private readonly Dictionary<int, DangoBrawlBattleBackpack> BagMap = new Dictionary<int, DangoBrawlBattleBackpack>();

		// Token: 0x0401E74D RID: 124749
		private readonly Dictionary<int, DangoBrawlBattleBackpackItem> BagItemMap = new Dictionary<int, DangoBrawlBattleBackpackItem>();

		// Token: 0x0401E74E RID: 124750
		private readonly global::Stack<DangoBrawlBattleBackpack> BagPool = new global::Stack<DangoBrawlBattleBackpack>();

		// Token: 0x0401E74F RID: 124751
		private readonly global::Stack<DangoBrawlBattleBackpackItem> BagItemPool = new global::Stack<DangoBrawlBattleBackpackItem>();

		// Token: 0x0401E750 RID: 124752
		private readonly Dictionary<int, List<DangoBrawlBattleBackpackItem>> ItemConfigMap = new Dictionary<int, List<DangoBrawlBattleBackpackItem>>();

		// Token: 0x0401E751 RID: 124753
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<UUIItem, DangoBrawlBackpackItemData> OnItemClick;

		// Token: 0x0401E752 RID: 124754
		[Nullable(2)]
		private DangoBrawlBattleBackpack CurSelectBag;

		// Token: 0x0401E753 RID: 124755
		[Nullable(2)]
		private DangoBrawlBattleBackpackItem CurSelectBagItem;

		// Token: 0x0401E754 RID: 124756
		private readonly Dictionary<int, DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot> CdSnapshotCache = new Dictionary<int, DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot>();

		// Token: 0x0200BC69 RID: 48233
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x04038D8E RID: 232846
			PnlOffsetL,
			// Token: 0x04038D8F RID: 232847
			BackpackItem,
			// Token: 0x04038D90 RID: 232848
			BackpackBagItem,
			// Token: 0x04038D91 RID: 232849
			PnlBagLayer,
			// Token: 0x04038D92 RID: 232850
			PnlItemLayer
		}
	}
}
