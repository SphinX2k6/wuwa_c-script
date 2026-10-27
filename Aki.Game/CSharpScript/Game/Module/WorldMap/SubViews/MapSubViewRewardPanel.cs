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
	// Token: 0x020047BE RID: 18366
	[NullableContext(1)]
	[Nullable(0)]
	public class MapSubViewRewardPanel : UiPanelBase
	{
		// Token: 0x060301CF RID: 197071 RVA: 0x00B26FDC File Offset: 0x00B251DC
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

		// Token: 0x060301D0 RID: 197072 RVA: 0x00B27066 File Offset: 0x00B25266
		protected override void OnStart()
		{
			this.ConsumeList = new GenericLayoutNew<MapSubViewRewardItem>(base.GetGridLayout(1), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<MapSubViewRewardItem>(this.CreatePropItem), null);
		}

		// Token: 0x060301D1 RID: 197073 RVA: 0x00B27088 File Offset: 0x00B25288
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

		// Token: 0x060301D2 RID: 197074 RVA: 0x00B270D0 File Offset: 0x00B252D0
		public void RebuildRewardsByData(TItem[] data)
		{
			this.ConsumeList.RebuildLayoutByDataNew<TItem>(data, null);
		}

		// Token: 0x060301D3 RID: 197075 RVA: 0x00B270F2 File Offset: 0x00B252F2
		public void SetTitleNewTxt(string newTxtId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), newTxtId, Array.Empty<object>());
		}

		// Token: 0x04019ED2 RID: 106194
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayoutNew<MapSubViewRewardItem> ConsumeList;

		// Token: 0x0200AA80 RID: 43648
		[NullableContext(0)]
		public static class ERewardItemBarChildCom
		{
			// Token: 0x04033E0A RID: 212490
			public const int UiTextInstanceTitle = 0;

			// Token: 0x04033E0B RID: 212491
			public const int UiItemContainer = 1;

			// Token: 0x04033E0C RID: 212492
			public const int UiItemItem = 2;
		}
	}
}
