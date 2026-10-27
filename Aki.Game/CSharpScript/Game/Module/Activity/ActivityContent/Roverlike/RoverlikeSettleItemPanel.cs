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
	// Token: 0x02006140 RID: 24896
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSettleItemPanel : UiPanelBase, IRoverlikeSettleSelectablePanel
	{
		// Token: 0x0603EEEC RID: 257772 RVA: 0x00F33982 File Offset: 0x00F31B82
		public void BindOnItemClick(Action<int, int> callback)
		{
			this.OnItemClick = callback;
		}

		// Token: 0x0603EEED RID: 257773 RVA: 0x00F3398C File Offset: 0x00F31B8C
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

		// Token: 0x0603EEEE RID: 257774 RVA: 0x00F33A37 File Offset: 0x00F31C37
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData>(base.GetGridLayout(1), new Func<RoverlikeEntrySmallGridItem>(this.CreateItemGrid), null, false, true);
		}

		// Token: 0x0603EEEF RID: 257775 RVA: 0x00F33A5C File Offset: 0x00F31C5C
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

		// Token: 0x0603EEF0 RID: 257776 RVA: 0x00F33B28 File Offset: 0x00F31D28
		public void SelectByKey(int key)
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.SelectGridProxyByKey(key, false);
		}

		// Token: 0x0603EEF1 RID: 257777 RVA: 0x00F33B41 File Offset: 0x00F31D41
		public void ClearSelect()
		{
			GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.DeselectCurrentGridProxy();
		}

		// Token: 0x0603EEF2 RID: 257778 RVA: 0x00F33B53 File Offset: 0x00F31D53
		private RoverlikeEntrySmallGridItem CreateItemGrid()
		{
			RoverlikeEntrySmallGridItem roverlikeEntrySmallGridItem = new RoverlikeEntrySmallGridItem();
			roverlikeEntrySmallGridItem.BindOnItemClick(new Action<IRoverlikeEntrySmallGridData, int>(this.OnGridItemClick));
			return roverlikeEntrySmallGridItem;
		}

		// Token: 0x0603EEF3 RID: 257779 RVA: 0x00F33B6C File Offset: 0x00F31D6C
		private void OnGridItemClick(IRoverlikeEntrySmallGridData data, int key)
		{
			Action<int, int> onItemClick = this.OnItemClick;
			if (onItemClick == null)
			{
				return;
			}
			onItemClick(data.ConfigId, key);
		}

		// Token: 0x04020D98 RID: 134552
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeEntrySmallGridItem, IRoverlikeEntrySmallGridData> ItemLayout;

		// Token: 0x04020D99 RID: 134553
		[Nullable(2)]
		private Action<int, int> OnItemClick;

		// Token: 0x0200C39C RID: 50076
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403B074 RID: 241780
			public const int TxtNum = 0;

			// Token: 0x0403B075 RID: 241781
			public const int LayoutItem = 1;

			// Token: 0x0403B076 RID: 241782
			public const int SpoilsItem = 2;

			// Token: 0x0403B077 RID: 241783
			public const int ItemEmpty = 3;
		}
	}
}
