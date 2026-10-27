using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200587E RID: 22654
	public class InstanceDungeonRewardItem : GridProxyAbstract<ValueTuple<int, int>>
	{
		// Token: 0x06039A81 RID: 236161 RVA: 0x00DB3CFC File Offset: 0x00DB1EFC
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

		// Token: 0x06039A82 RID: 236162 RVA: 0x00DB3D86 File Offset: 0x00DB1F86
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(2), new Func<CommonItemSmallItemGrid>(this.OnRewardLayoutUpdater), null, false, true);
		}

		// Token: 0x06039A83 RID: 236163 RVA: 0x00DB3DA9 File Offset: 0x00DB1FA9
		[NullableContext(1)]
		private CommonItemSmallItemGrid OnRewardLayoutUpdater()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06039A84 RID: 236164 RVA: 0x00DB3DB0 File Offset: 0x00DB1FB0
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

		// Token: 0x06039A85 RID: 236165 RVA: 0x00DB3E80 File Offset: 0x00DB2080
		public void SetCurrentItem(int currentItemLevel)
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(this.SelfLevel == currentItemLevel);
		}

		// Token: 0x0401E213 RID: 123411
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> Layout;

		// Token: 0x0401E214 RID: 123412
		private int SelfLevel = -1;

		// Token: 0x0200BAD9 RID: 47833
		private static class EChildType
		{
			// Token: 0x0403876B RID: 231275
			public const int TitleText = 0;

			// Token: 0x0403876C RID: 231276
			public const int CurrentItem = 1;

			// Token: 0x0403876D RID: 231277
			public const int RewardLayout = 2;
		}
	}
}
