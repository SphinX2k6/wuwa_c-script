using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020036EF RID: 14063
	[NullableContext(1)]
	[Nullable(0)]
	public class MapSubViewRewardPanel : UiPanelBase
	{
		// Token: 0x0602499F RID: 149919 RVA: 0x00A56DE8 File Offset: 0x00A54FE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060249A0 RID: 149920 RVA: 0x00A56E72 File Offset: 0x00A55072
		protected override void OnStart()
		{
			this.ConsumeList = new GenericLayoutNew<MapSubViewRewardItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MapSubViewRewardItem>(this.CreatePropItem), null);
		}

		// Token: 0x060249A1 RID: 149921 RVA: 0x00A56E94 File Offset: 0x00A55094
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		private ILayoutItem<MapSubViewRewardItem> CreatePropItem(object data, UUIItem uiitem, int index)
		{
			MapSubViewRewardItem mapSubViewRewardItem = new MapSubViewRewardItem();
			mapSubViewRewardItem.Initialize(uiitem.GetOwner());
			mapSubViewRewardItem.Refresh((TItem)data, false, index);
			return new LayoutItem<MapSubViewRewardItem>
			{
				Key = index,
				Value = mapSubViewRewardItem
			};
		}

		// Token: 0x060249A2 RID: 149922 RVA: 0x00A56EDC File Offset: 0x00A550DC
		public void RebuildRewardsByData(TItem[] data)
		{
			this.ConsumeList.RebuildLayoutByDataNew<TItem>(data, null);
		}

		// Token: 0x060249A3 RID: 149923 RVA: 0x00A56EFE File Offset: 0x00A550FE
		public void SetTitleNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x04014583 RID: 83331
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MapSubViewRewardItem> ConsumeList;

		// Token: 0x02009433 RID: 37939
		[NullableContext(0)]
		public static class ERewardItemBarChildCom
		{
			// Token: 0x0402E593 RID: 189843
			public const int UiTextInstanceTitle = 0;

			// Token: 0x0402E594 RID: 189844
			public const int UiItemContainer = 1;

			// Token: 0x0402E595 RID: 189845
			public const int UiItemItem = 2;
		}
	}
}
