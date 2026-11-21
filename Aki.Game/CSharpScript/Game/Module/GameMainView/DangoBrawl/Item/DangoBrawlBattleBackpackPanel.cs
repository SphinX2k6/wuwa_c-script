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
	// Token: 0x020049E7 RID: 18919
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlBattleBackpackPanel : UiPanelBase
	{
		// Token: 0x0602F677 RID: 194167 RVA: 0x00D38568 File Offset: 0x00D36768
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

		// Token: 0x0602F678 RID: 194168 RVA: 0x00D38634 File Offset: 0x00D36834
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

		// Token: 0x0602F679 RID: 194169 RVA: 0x00D3865C File Offset: 0x00D3685C
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

		// Token: 0x0602F67A RID: 194170 RVA: 0x00D386A8 File Offset: 0x00D368A8
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

		// Token: 0x0602F67B RID: 194171 RVA: 0x00D386F4 File Offset: 0x00D368F4
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

		// Token: 0x0602F67C RID: 194172 RVA: 0x00D387E0 File Offset: 0x00D369E0
		private UniTask RefreshBackpack(DangoBrawlNormalBagItemInfo info)
		{
			if (DangoBrawlUtil.GetTemplateType(DangoBrawlUtil.GetTemplateId(info.Inst.ConfigId)) == EDangoBrawlTemplateType.Bag)
			{
				return this.CreateBag(info);
			}
			return this.CreateBagItem(info);
		}

		// Token: 0x0602F67D RID: 194173 RVA: 0x00D38808 File Offset: 0x00D36A08
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

		// Token: 0x0602F67E RID: 194174 RVA: 0x00D38854 File Offset: 0x00D36A54
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

		// Token: 0x0602F67F RID: 194175 RVA: 0x00D388A0 File Offset: 0x00D36AA0
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

		// Token: 0x0602F680 RID: 194176 RVA: 0x00D388E4 File Offset: 0x00D36AE4
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

		// Token: 0x0602F681 RID: 194177 RVA: 0x00D38930 File Offset: 0x00D36B30
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

		// Token: 0x0602F682 RID: 194178 RVA: 0x00D3897C File Offset: 0x00D36B7C
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

		// Token: 0x0602F683 RID: 194179 RVA: 0x00D389C0 File Offset: 0x00D36BC0
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

		// Token: 0x0602F684 RID: 194180 RVA: 0x00D38A18 File Offset: 0x00D36C18
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

		// Token: 0x0602F685 RID: 194181 RVA: 0x00D38A84 File Offset: 0x00D36C84
		public void RegisterTimerHandle()
		{
			foreach (KeyValuePair<int, DangoBrawlBattleBackpackItem> keyValuePair in this.BagItemMap)
			{
				keyValuePair.Value.RegisterFightingTickCallback();
			}
		}

		// Token: 0x0602F686 RID: 194182 RVA: 0x00D38ADC File Offset: 0x00D36CDC
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

		// Token: 0x0602F687 RID: 194183 RVA: 0x00D38B70 File Offset: 0x00D36D70
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

		// Token: 0x0602F688 RID: 194184 RVA: 0x00D38BEC File Offset: 0x00D36DEC
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

		// Token: 0x0602F689 RID: 194185 RVA: 0x00D38C6C File Offset: 0x00D36E6C
		public void ClearCdSnapshots()
		{
			this.CdSnapshotCache.Clear();
		}

		// Token: 0x0602F68A RID: 194186 RVA: 0x00D38C7C File Offset: 0x00D36E7C
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

		// Token: 0x0602F68B RID: 194187 RVA: 0x00D38CA4 File Offset: 0x00D36EA4
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

		// Token: 0x0602F68C RID: 194188 RVA: 0x00D38CCC File Offset: 0x00D36ECC
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

		// Token: 0x0602F68D RID: 194189 RVA: 0x00D38D16 File Offset: 0x00D36F16
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

		// Token: 0x0602F68E RID: 194190 RVA: 0x00D38D4A File Offset: 0x00D36F4A
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

		// Token: 0x0602F68F RID: 194191 RVA: 0x00D38D6A File Offset: 0x00D36F6A
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

		// Token: 0x0602F690 RID: 194192 RVA: 0x00D38D8C File Offset: 0x00D36F8C
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

		// Token: 0x0602F691 RID: 194193 RVA: 0x00D38DC4 File Offset: 0x00D36FC4
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

		// Token: 0x040191F3 RID: 102899
		private readonly Dictionary<int, DangoBrawlBattleBackpack> BagMap = new Dictionary<int, DangoBrawlBattleBackpack>();

		// Token: 0x040191F4 RID: 102900
		private readonly Dictionary<int, DangoBrawlBattleBackpackItem> BagItemMap = new Dictionary<int, DangoBrawlBattleBackpackItem>();

		// Token: 0x040191F5 RID: 102901
		private readonly global::Stack<DangoBrawlBattleBackpack> BagPool = new global::Stack<DangoBrawlBattleBackpack>();

		// Token: 0x040191F6 RID: 102902
		private readonly global::Stack<DangoBrawlBattleBackpackItem> BagItemPool = new global::Stack<DangoBrawlBattleBackpackItem>();

		// Token: 0x040191F7 RID: 102903
		private readonly Dictionary<int, List<DangoBrawlBattleBackpackItem>> ItemConfigMap = new Dictionary<int, List<DangoBrawlBattleBackpackItem>>();

		// Token: 0x040191F8 RID: 102904
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<UUIItem, DangoBrawlBackpackItemData> OnItemClick;

		// Token: 0x040191F9 RID: 102905
		[Nullable(2)]
		private DangoBrawlBattleBackpack CurSelectBag;

		// Token: 0x040191FA RID: 102906
		[Nullable(2)]
		private DangoBrawlBattleBackpackItem CurSelectBagItem;

		// Token: 0x040191FB RID: 102907
		private readonly Dictionary<int, DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot> CdSnapshotCache = new Dictionary<int, DangoBrawlBattleBackpackItem.DangoBrawlCdSnapshot>();

		// Token: 0x0200A672 RID: 42610
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403375A RID: 210778
			PnlOffsetL,
			// Token: 0x0403375B RID: 210779
			BackpackItem,
			// Token: 0x0403375C RID: 210780
			BackpackBagItem,
			// Token: 0x0403375D RID: 210781
			PnlBagLayer,
			// Token: 0x0403375E RID: 210782
			PnlItemLayer
		}
	}
}
