using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050BE RID: 20670
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSettleItemPanel : UiPanelBase, IRoverlikeSettleSelectablePanel
	{
		// Token: 0x06033BAC RID: 211884 RVA: 0x00E7A862 File Offset: 0x00E78A62
		public void BindOnItemClick(Action<int, int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x06033BAD RID: 211885 RVA: 0x00E7A86C File Offset: 0x00E78A6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033BAE RID: 211886 RVA: 0x00E7A917 File Offset: 0x00E78B17
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData>(base.GetGridLayout(1), new Func<RoverlikeEntrySmallGridItem>(this.CreateItemGrid), null, false, true);
		}

		// Token: 0x06033BAF RID: 211887 RVA: 0x00E7A93C File Offset: 0x00E78B3C
		public void Refresh(List<int> configIdList)
		{
			base.GetText(0).SetText(configIdList.Count.ToString(), true);
			List<IRoverlikeEntrySmallGridData> list = new List<IRoverlikeEntrySmallGridData>();
			foreach (int configId in configIdList)
			{
				RoverlikeEntrySmallGridData item = new RoverlikeEntrySmallGridData
				{
					ConfigId = configId,
					Type = RoverRogueGainDataType.RoverRogueGainItem
				};
				list.Add(item);
			}
			bool flag = list.Count > 0;
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> itemLayout = this.ItemLayout;
			if (itemLayout != null)
			{
				itemLayout.SetActive(flag);
			}
			UUIItem item2 = base.GetItem(3);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (flag)
			{
				this.ItemLayout.RefreshByData(list, null, true);
			}
		}

		// Token: 0x06033BB0 RID: 211888 RVA: 0x00E7AA08 File Offset: 0x00E78C08
		public void SelectByKey(int key)
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.SelectGridProxyByKey(key, false);
		}

		// Token: 0x06033BB1 RID: 211889 RVA: 0x00E7AA21 File Offset: 0x00E78C21
		public void ClearSelect()
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.DeselectCurrentGridProxy();
		}

		// Token: 0x06033BB2 RID: 211890 RVA: 0x00E7AA33 File Offset: 0x00E78C33
		private RoverlikeEntrySmallGridItem CreateItemGrid()
		{
			RoverlikeEntrySmallGridItem roverlikeEntrySmallGridItem = new RoverlikeEntrySmallGridItem();
			roverlikeEntrySmallGridItem.BindOnItemClick(new Action<IRoverlikeEntrySmallGridData, int>(this.OnGridItemClick));
			return roverlikeEntrySmallGridItem;
		}

		// Token: 0x06033BB3 RID: 211891 RVA: 0x00E7AA4C File Offset: 0x00E78C4C
		private void OnGridItemClick(IRoverlikeEntrySmallGridData data, int key)
		{
			Action<int, int> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(data.ConfigId, key);
		}

		// Token: 0x0401B6C5 RID: 112325
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> ItemLayout;

		// Token: 0x0401B6C6 RID: 112326
		[Nullable(2)]
		private Action<int, int> OnItemClick;

		// Token: 0x0200AD83 RID: 44419
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040359D5 RID: 219605
			public const int TxtNum = 0;

			// Token: 0x040359D6 RID: 219606
			public const int LayoutItem = 1;

			// Token: 0x040359D7 RID: 219607
			public const int SpoilsItem = 2;

			// Token: 0x040359D8 RID: 219608
			public const int ItemEmpty = 3;
		}
	}
}
