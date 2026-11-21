using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004856 RID: 18518
	public class InstanceDungeonRewardItem : GridProxyAbstract<ValueTuple<int, int>>
	{
		// Token: 0x0602E9A4 RID: 190884 RVA: 0x00D02C10 File Offset: 0x00D00E10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIGridLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602E9A5 RID: 190885 RVA: 0x00D02C9A File Offset: 0x00D00E9A
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(2), new Func<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null, false, true);
		}

		// Token: 0x0602E9A6 RID: 190886 RVA: 0x00D02CBD File Offset: 0x00D00EBD
		[NullableContext(1)]
		private CommonItemSmallItemGrid OnRewardLayoutUpdater()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0602E9A7 RID: 190887 RVA: 0x00D02CC4 File Offset: 0x00D00EC4
		public override void Refresh(ValueTuple<int, int> data, bool isSelected, int gridIndex)
		{
			Dictionary<int, int> dropShowInfo = AdventureGuideConfig.Instance.GetDropShowInfo(data.Item2);
			List<TItem> list = new List<TItem>();
			foreach (KeyValuePair<int, int> keyValuePair in dropShowInfo)
			{
				TItem item = new TItem
				{
					ItemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0),
					Count = keyValuePair.Value
				};
				list.Add(item);
			}
			this.Layout.RefreshByData(list, null, false);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "InstanceRewardDes", new <>z__ReadOnlySingleElementList<object>(data.Item1));
			this.SelfLevel = data.Item1;
		}

		// Token: 0x0602E9A8 RID: 190888 RVA: 0x00D02D94 File Offset: 0x00D00F94
		public void SetCurrentItem(int currentItemLevel)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.SelfLevel == currentItemLevel);
		}

		// Token: 0x04018CB0 RID: 101552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> Layout;

		// Token: 0x04018CB1 RID: 101553
		private int SelfLevel = -1;

		// Token: 0x0200A4F2 RID: 42226
		private static class EChildType
		{
			// Token: 0x0403316C RID: 209260
			public const int TitleText = 0;

			// Token: 0x0403316D RID: 209261
			public const int CurrentItem = 1;

			// Token: 0x0403316E RID: 209262
			public const int RewardLayout = 2;
		}
	}
}
