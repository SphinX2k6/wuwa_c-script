using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Popup
{
	// Token: 0x0200372D RID: 14125
	public class RewardPreviewListItem : UiPanelBase, IGridProxy<TLevelDropReward>
	{
		// Token: 0x17004B88 RID: 19336
		// (get) Token: 0x06024BEA RID: 150506 RVA: 0x00A6129F File Offset: 0x00A5F49F
		// (set) Token: 0x06024BEB RID: 150507 RVA: 0x00A612A7 File Offset: 0x00A5F4A7
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

		// Token: 0x17004B89 RID: 19337
		// (get) Token: 0x06024BEC RID: 150508 RVA: 0x00A612B0 File Offset: 0x00A5F4B0
		// (set) Token: 0x06024BED RID: 150509 RVA: 0x00A612B8 File Offset: 0x00A5F4B8
		public int GridIndex { get; set; }

		// Token: 0x17004B8A RID: 19338
		// (get) Token: 0x06024BEE RID: 150510 RVA: 0x00A612C1 File Offset: 0x00A5F4C1
		// (set) Token: 0x06024BEF RID: 150511 RVA: 0x00A612C9 File Offset: 0x00A5F4C9
		public int DisplayIndex { get; set; }

		// Token: 0x06024BF0 RID: 150512 RVA: 0x00A612D4 File Offset: 0x00A5F4D4
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

		// Token: 0x06024BF1 RID: 150513 RVA: 0x00A6138A File Offset: 0x00A5F58A
		protected override void OnStart()
		{
			this.ItemsLayout = new GenericLayout<RewardItem, TPreviewItem>(base.GetGridLayout(2), new Func<RewardItem>(this.CreateRewardItemFunc), null, false, true);
		}

		// Token: 0x06024BF2 RID: 150514 RVA: 0x00A613B0 File Offset: 0x00A5F5B0
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
				if (itemConfigData == null || Array.IndexOf<int>(itemConfigData.ShowTypes, 41) < 0 || valueOrDefault > 0)
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

		// Token: 0x06024BF3 RID: 150515 RVA: 0x00A61553 File Offset: 0x00A5F753
		public void Clear()
		{
		}

		// Token: 0x06024BF4 RID: 150516 RVA: 0x00A61555 File Offset: 0x00A5F755
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06024BF5 RID: 150517 RVA: 0x00A61557 File Offset: 0x00A5F757
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06024BF6 RID: 150518 RVA: 0x00A61559 File Offset: 0x00A5F759
		[NullableContext(1)]
		public object GetKey(TLevelDropReward data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x06024BF7 RID: 150519 RVA: 0x00A61566 File Offset: 0x00A5F766
		[NullableContext(1)]
		private RewardItem CreateRewardItemFunc()
		{
			return new RewardItem();
		}

		// Token: 0x04014655 RID: 83541
		private TLevelDropReward? DropRewardData;

		// Token: 0x04014656 RID: 83542
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<RewardItem, TPreviewItem> ItemsLayout;

		// Token: 0x02009472 RID: 38002
		public static class EComponents
		{
			// Token: 0x0402E682 RID: 190082
			public const int TxtRewardTitle = 0;

			// Token: 0x0402E683 RID: 190083
			public const int PnlCurrent = 1;

			// Token: 0x0402E684 RID: 190084
			public const int PnlGridLayout = 2;

			// Token: 0x0402E685 RID: 190085
			public const int ItemGrid = 3;
		}
	}
}
