using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.AttrSelect
{
	// Token: 0x02005776 RID: 22390
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class AttrListItem : GridProxyAbstract<string>
	{
		// Token: 0x06038E0F RID: 232975 RVA: 0x00D83E4C File Offset: 0x00D8204C
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

		// Token: 0x06038E10 RID: 232976 RVA: 0x00D83E94 File Offset: 0x00D82094
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			base.GetText(0).SetText(data, true);
		}

		// Token: 0x0200B989 RID: 47497
		private class EAttrListItemComp
		{
			// Token: 0x0403819E RID: 229790
			public const int TextDes = 0;
		}
	}
}
