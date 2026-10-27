using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02004C9A RID: 19610
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteTipsItemPanel : UiPanelBase
	{
		// Token: 0x06032ADA RID: 207578 RVA: 0x00BD27D8 File Offset: 0x00BD09D8
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

		// Token: 0x06032ADB RID: 207579 RVA: 0x00BD2862 File Offset: 0x00BD0A62
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGridWrap, ItemRefreshData>(base.GetGridLayout(0), new Func<CommonItemSmallItemGridWrap>(this.InitGridItem), null, false, true);
		}

		// Token: 0x06032ADC RID: 207580 RVA: 0x00BD2885 File Offset: 0x00BD0A85
		private CommonItemSmallItemGridWrap InitGridItem()
		{
			return new CommonItemSmallItemGridWrap();
		}

		// Token: 0x06032ADD RID: 207581 RVA: 0x00BD288C File Offset: 0x00BD0A8C
		public void RefreshTitle(string textId)
		{
			base.GetText(2).ShowTextNew(textId);
		}

		// Token: 0x06032ADE RID: 207582 RVA: 0x00BD289B File Offset: 0x00BD0A9B
		public void RefreshItemPanel(List<ItemRefreshData> dataList)
		{
			this.ItemLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x0401AFAF RID: 110511
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CommonItemSmallItemGridWrap, ItemRefreshData> ItemLayout;
	}
}
