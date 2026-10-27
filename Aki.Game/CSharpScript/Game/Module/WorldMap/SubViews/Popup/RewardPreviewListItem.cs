using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Popup
{
	// Token: 0x020047FC RID: 18428
	public class RewardPreviewListItem : UiPanelBase, IGridProxy<TLevelDropReward>
	{
		// Token: 0x170078CB RID: 30923
		// (get) Token: 0x0603041A RID: 197658 RVA: 0x00B312FF File Offset: 0x00B2F4FF
		// (set) Token: 0x0603041B RID: 197659 RVA: 0x00B31307 File Offset: 0x00B2F507
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

		// Token: 0x170078CC RID: 30924
		// (get) Token: 0x0603041C RID: 197660 RVA: 0x00B31310 File Offset: 0x00B2F510
		// (set) Token: 0x0603041D RID: 197661 RVA: 0x00B31318 File Offset: 0x00B2F518
		public int GridIndex { get; set; }

		// Token: 0x170078CD RID: 30925
		// (get) Token: 0x0603041E RID: 197662 RVA: 0x00B31321 File Offset: 0x00B2F521
		// (set) Token: 0x0603041F RID: 197663 RVA: 0x00B31329 File Offset: 0x00B2F529
		public int DisplayIndex { get; set; }

		// Token: 0x06030420 RID: 197664 RVA: 0x00B31334 File Offset: 0x00B2F534
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

		// Token: 0x06030421 RID: 197665 RVA: 0x00B313EA File Offset: 0x00B2F5EA
		protected override void OnStart()
		{
			this.ItemsLayout = new GenericLayout<RewardItem, TPreviewItem>(base.GetGridLayout(2), new Func<RewardItem>(this.CreateRewardItemFunc), null, false, true);
		}

		// Token: 0x06030422 RID: 197666 RVA: 0x00B31410 File Offset: 0x00B2F610
		public void Refresh(TLevelDropReward data, bool isSelected, int gridIndex)
		{
			this.DropRewardData = new TLevelDropReward?(data);
			int worldLevel = data.WorldLevel;
			DropPackage? config = ConfigDropPackageById.GetConfig(data.DropId, true);
			WorldLevelModel instance = WorldLevelModel.Instance;
			int num = (instance != null) ? instance.CurWorldLevel : 0;
			bool uiactive = worldLevel == num;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "World_Level_Text", new <>z__ReadOnlySingleElementList<object>(worldLevel));
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			List<TPreviewItem> list = new List<TPreviewItem>();
			int calabashLevel = CalabashModel.Instance.GetCalabashLevel();
			CalabashLevel? calabashConfigByLevel = CalabashConfig.Instance.GetCalabashConfigByLevel(calabashLevel);
			for (int i = 0; i < config.Value.DropPreviewLength; i++)
			{
				DicIntInt? dicIntInt = config.Value.DropPreview(i);
				ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(dicIntInt.Value.Key);
				int valueOrDefault = calabashConfigByLevel.Value.GetQualityDropWeight(itemConfigData.QualityId).GetValueOrDefault();
				if (itemConfigData == null || !itemConfigData.ShowTypes.Contains(41) || valueOrDefault > 0)
				{
					list.Add(new TPreviewItem
					{
						ItemId = dicIntInt.Value.Key,
						Count = dicIntInt.Value.Value
					});
				}
			}
			list.Sort((TPreviewItem a, TPreviewItem b) => a.ItemId - b.ItemId);
			GenericLayout<RewardItem, TPreviewItem> itemsLayout = this.ItemsLayout;
			if (itemsLayout == null)
			{
				return;
			}
			itemsLayout.RefreshByData(list, null, false);
		}

		// Token: 0x06030423 RID: 197667 RVA: 0x00B315B2 File Offset: 0x00B2F7B2
		public void Clear()
		{
		}

		// Token: 0x06030424 RID: 197668 RVA: 0x00B315B4 File Offset: 0x00B2F7B4
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06030425 RID: 197669 RVA: 0x00B315B6 File Offset: 0x00B2F7B6
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06030426 RID: 197670 RVA: 0x00B315B8 File Offset: 0x00B2F7B8
		[NullableContext(1)]
		public object GetKey(TLevelDropReward data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x06030427 RID: 197671 RVA: 0x00B315C5 File Offset: 0x00B2F7C5
		[NullableContext(1)]
		private RewardItem CreateRewardItemFunc()
		{
			return new RewardItem();
		}

		// Token: 0x04019FA1 RID: 106401
		private TLevelDropReward? DropRewardData;

		// Token: 0x04019FA2 RID: 106402
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RewardItem, TPreviewItem> ItemsLayout;

		// Token: 0x0200AAC1 RID: 43713
		public static class EComponents
		{
			// Token: 0x04033EFF RID: 212735
			public const int TxtRewardTitle = 0;

			// Token: 0x04033F00 RID: 212736
			public const int PnlCurrent = 1;

			// Token: 0x04033F01 RID: 212737
			public const int PnlGridLayout = 2;

			// Token: 0x04033F02 RID: 212738
			public const int ItemGrid = 3;
		}
	}
}
