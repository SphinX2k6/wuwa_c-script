using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap.SubViews.Popup;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E0C RID: 19980
	public class BlackFlowerRewardPreviewListItem : UiPanelBase, IGridProxy<TLevelDropReward>
	{
		// Token: 0x17007ECB RID: 32459
		// (get) Token: 0x060338C1 RID: 211137 RVA: 0x00C0C613 File Offset: 0x00C0A813
		// (set) Token: 0x060338C2 RID: 211138 RVA: 0x00C0C61B File Offset: 0x00C0A81B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public IScrollViewDelegate<IGridProxy<TLevelDropReward>, TLevelDropReward> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007ECC RID: 32460
		// (get) Token: 0x060338C3 RID: 211139 RVA: 0x00C0C624 File Offset: 0x00C0A824
		// (set) Token: 0x060338C4 RID: 211140 RVA: 0x00C0C62C File Offset: 0x00C0A82C
		public int GridIndex { get; set; }

		// Token: 0x17007ECD RID: 32461
		// (get) Token: 0x060338C5 RID: 211141 RVA: 0x00C0C635 File Offset: 0x00C0A835
		// (set) Token: 0x060338C6 RID: 211142 RVA: 0x00C0C63D File Offset: 0x00C0A83D
		public int DisplayIndex { get; set; }

		// Token: 0x17007ECE RID: 32462
		// (get) Token: 0x060338C7 RID: 211143 RVA: 0x00C0C646 File Offset: 0x00C0A846
		// (set) Token: 0x060338C8 RID: 211144 RVA: 0x00C0C64E File Offset: 0x00C0A84E
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem, TPreviewItem> ItemsLayout { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x060338C9 RID: 211145 RVA: 0x00C0C658 File Offset: 0x00C0A858
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x060338CA RID: 211146 RVA: 0x00C0C70E File Offset: 0x00C0A90E
		protected override void OnStart()
		{
			this.ItemsLayout = new GenericLayout<CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem, TPreviewItem>(base.GetGridLayout(2), new Func<CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem>(this.CreateRewardItemFunc), null, false, true);
		}

		// Token: 0x060338CB RID: 211147 RVA: 0x00C0C734 File Offset: 0x00C0A934
		public void Refresh(TLevelDropReward data, bool isSelected, int gridIndex)
		{
			this.DropId = data.DropId;
			DropPackage? config = ConfigDropPackageById.GetConfig(this.DropId, true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "BlackFlower_Reward_Title", Array.Empty<object>());
			base.GetItem(1).SetUIActive(false);
			List<TPreviewItem> list = new List<TPreviewItem>();
			foreach (DicIntInt dicIntInt in config.Value.DropPreviewIter())
			{
				TPreviewItem item = new TPreviewItem
				{
					ItemId = dicIntInt.Key,
					Count = dicIntInt.Value
				};
				list.Add(item);
			}
			GenericLayout<CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem, TPreviewItem> itemsLayout = this.ItemsLayout;
			if (itemsLayout == null)
			{
				return;
			}
			itemsLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060338CC RID: 211148 RVA: 0x00C0C810 File Offset: 0x00C0AA10
		public void Clear()
		{
		}

		// Token: 0x060338CD RID: 211149 RVA: 0x00C0C812 File Offset: 0x00C0AA12
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060338CE RID: 211150 RVA: 0x00C0C814 File Offset: 0x00C0AA14
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060338CF RID: 211151 RVA: 0x00C0C816 File Offset: 0x00C0AA16
		[NullableContext(1)]
		public object GetKey(TLevelDropReward data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x060338D0 RID: 211152 RVA: 0x00C0C823 File Offset: 0x00C0AA23
		[NullableContext(1)]
		private CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem CreateRewardItemFunc()
		{
			return new CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem();
		}

		// Token: 0x0401B57F RID: 111999
		private int DropId;

		// Token: 0x0200AFA1 RID: 44961
		private class EComponents
		{
			// Token: 0x04035522 RID: 218402
			public const int TxtRewardTitle = 0;

			// Token: 0x04035523 RID: 218403
			public const int PnlCurrent = 1;

			// Token: 0x04035524 RID: 218404
			public const int PnlGridLayout = 2;

			// Token: 0x04035525 RID: 218405
			public const int ItemGrid = 3;
		}
	}
}
