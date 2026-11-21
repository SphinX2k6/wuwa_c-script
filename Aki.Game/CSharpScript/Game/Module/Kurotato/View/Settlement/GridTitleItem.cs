using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x020046FF RID: 18175
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GridTitleItem : SyncGridProxyAbstract<GridTitleItemDataInner>
	{
		// Token: 0x0602DAC8 RID: 187080 RVA: 0x00CC5978 File Offset: 0x00CC3B78
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DAC9 RID: 187081 RVA: 0x00CC59E1 File Offset: 0x00CC3BE1
		[NullableContext(1)]
		public override void Refresh(GridTitleItemDataInner data)
		{
			base.GetText(0).ShowTextNew(data.Title);
			base.GetText(1).SetText(data.Num, true);
		}

		// Token: 0x0200A315 RID: 41749
		private class ETitleComp
		{
			// Token: 0x04032926 RID: 207142
			public const int TextTitle = 0;

			// Token: 0x04032927 RID: 207143
			public const int TextNum = 1;
		}
	}
}
