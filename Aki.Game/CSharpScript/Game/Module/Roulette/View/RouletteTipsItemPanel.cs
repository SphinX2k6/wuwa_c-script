using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02003C4B RID: 15435
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteTipsItemPanel : UiPanelBase
	{
		// Token: 0x0602788D RID: 161933 RVA: 0x00B1743C File Offset: 0x00B1563C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602788E RID: 161934 RVA: 0x00B174C6 File Offset: 0x00B156C6
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGridWrap, ItemRefreshData>(base.GetGridLayout(0), new Func<CommonItemSmallItemGridWrap>(this.InitGridItem), null, false, true);
		}

		// Token: 0x0602788F RID: 161935 RVA: 0x00B174E9 File Offset: 0x00B156E9
		private CommonItemSmallItemGridWrap InitGridItem()
		{
			return new CommonItemSmallItemGridWrap();
		}

		// Token: 0x06027890 RID: 161936 RVA: 0x00B174F0 File Offset: 0x00B156F0
		public void RefreshTitle(string textId)
		{
			base.GetText(2).ShowTextNew(textId);
		}

		// Token: 0x06027891 RID: 161937 RVA: 0x00B174FF File Offset: 0x00B156FF
		public void RefreshItemPanel(List<ItemRefreshData> dataList)
		{
			this.ItemLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x0401590C RID: 88332
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CommonItemSmallItemGridWrap, ItemRefreshData> ItemLayout;
	}
}
