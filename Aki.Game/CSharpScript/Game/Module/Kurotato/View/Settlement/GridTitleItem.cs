using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Settlement
{
	// Token: 0x02005728 RID: 22312
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GridTitleItem : SyncGridProxyAbstract<GridTitleItemDataInner>
	{
		// Token: 0x06038BB8 RID: 232376 RVA: 0x00D772CC File Offset: 0x00D754CC
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

		// Token: 0x06038BB9 RID: 232377 RVA: 0x00D77335 File Offset: 0x00D75535
		[NullableContext(1)]
		public override void Refresh(GridTitleItemDataInner data)
		{
			base.GetText(0).ShowTextNew(data.Title);
			base.GetText(1).SetText(data.Num, true);
		}

		// Token: 0x0200B8F4 RID: 47348
		private class ETitleComp
		{
			// Token: 0x04037F16 RID: 229142
			public const int TextTitle = 0;

			// Token: 0x04037F17 RID: 229143
			public const int TextNum = 1;
		}
	}
}
