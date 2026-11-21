using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x0200474D RID: 18253
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttrListItem : GridProxyAbstract<string>
	{
		// Token: 0x0602DD1F RID: 187679 RVA: 0x00CD297C File Offset: 0x00CD0B7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DD20 RID: 187680 RVA: 0x00CD29C4 File Offset: 0x00CD0BC4
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200A3A3 RID: 41891
		private class EAttrListItemComp
		{
			// Token: 0x04032B97 RID: 207767
			public const int TextDes = 0;
		}
	}
}
