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
	// Token: 0x02003DD5 RID: 15829
	public class BlackFlowerRewardPreviewListItem : UiPanelBase, IGridProxy<TLevelDropReward>
	{
		// Token: 0x1700527B RID: 21115
		// (get) Token: 0x0602872C RID: 165676 RVA: 0x00B55B1F File Offset: 0x00B53D1F
		// (set) Token: 0x0602872D RID: 165677 RVA: 0x00B55B27 File Offset: 0x00B53D27
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

		// Token: 0x1700527C RID: 21116
		// (get) Token: 0x0602872E RID: 165678 RVA: 0x00B55B30 File Offset: 0x00B53D30
		// (set) Token: 0x0602872F RID: 165679 RVA: 0x00B55B38 File Offset: 0x00B53D38
		public int GridIndex { get; set; }

		// Token: 0x1700527D RID: 21117
		// (get) Token: 0x06028730 RID: 165680 RVA: 0x00B55B41 File Offset: 0x00B53D41
		// (set) Token: 0x06028731 RID: 165681 RVA: 0x00B55B49 File Offset: 0x00B53D49
		public int DisplayIndex { get; set; }

		// Token: 0x1700527E RID: 21118
		// (get) Token: 0x06028732 RID: 165682 RVA: 0x00B55B52 File Offset: 0x00B53D52
		// (set) Token: 0x06028733 RID: 165683 RVA: 0x00B55B5A File Offset: 0x00B53D5A
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

		// Token: 0x06028734 RID: 165684 RVA: 0x00B55B64 File Offset: 0x00B53D64
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

		// Token: 0x06028735 RID: 165685 RVA: 0x00B55C1A File Offset: 0x00B53E1A
		protected override void OnStart()
		{
			this.ItemsLayout = new GenericLayout<CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem, TPreviewItem>(base.GetGridLayout(2), new Func<CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem>(this.CreateRewardItemFunc), null, false, true);
		}

		// Token: 0x06028736 RID: 165686 RVA: 0x00B55C40 File Offset: 0x00B53E40
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

		// Token: 0x06028737 RID: 165687 RVA: 0x00B55D1C File Offset: 0x00B53F1C
		public void Clear()
		{
		}

		// Token: 0x06028738 RID: 165688 RVA: 0x00B55D1E File Offset: 0x00B53F1E
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06028739 RID: 165689 RVA: 0x00B55D20 File Offset: 0x00B53F20
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0602873A RID: 165690 RVA: 0x00B55D22 File Offset: 0x00B53F22
		[NullableContext(1)]
		public object GetKey(TLevelDropReward data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0602873B RID: 165691 RVA: 0x00B55D2F File Offset: 0x00B53F2F
		[NullableContext(1)]
		private CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem CreateRewardItemFunc()
		{
			return new CSharpScript.Game.Module.WorldMap.SubViews.Popup.RewardItem();
		}

		// Token: 0x04015F52 RID: 89938
		private int DropId;

		// Token: 0x020099D6 RID: 39382
		private class EComponents
		{
			// Token: 0x0402FF55 RID: 196437
			public const int TxtRewardTitle = 0;

			// Token: 0x0402FF56 RID: 196438
			public const int PnlCurrent = 1;

			// Token: 0x0402FF57 RID: 196439
			public const int PnlGridLayout = 2;

			// Token: 0x0402FF58 RID: 196440
			public const int ItemGrid = 3;
		}
	}
}
