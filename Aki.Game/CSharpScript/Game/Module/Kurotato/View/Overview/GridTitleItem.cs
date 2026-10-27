using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Overview
{
	// Token: 0x0200574F RID: 22351
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class GridTitleItem : SyncGridProxyAbstract<GridTitleItemDataInner>
	{
		// Token: 0x06038CFE RID: 232702 RVA: 0x00D7E544 File Offset: 0x00D7C744
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

		// Token: 0x06038CFF RID: 232703 RVA: 0x00D7E5AD File Offset: 0x00D7C7AD
		[NullableContext(1)]
		public override void Refresh(GridTitleItemDataInner data)
		{
			base.GetText(0).ShowTextNew(data.Title);
			base.GetText(1).SetText(data.Num, true);
		}

		// Token: 0x0200B948 RID: 47432
		private enum ETitleComp
		{
			// Token: 0x0403809A RID: 229530
			TextTitle,
			// Token: 0x0403809B RID: 229531
			TextNum
		}
	}
}
