using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B4D RID: 19277
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseLevelDetailElementItem : GridProxyAbstract<string>
	{
		// Token: 0x06031EBA RID: 204474 RVA: 0x00B9464C File Offset: 0x00B9284C
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

		// Token: 0x06031EBB RID: 204475 RVA: 0x00B94694 File Offset: 0x00B92894
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data, Array.Empty<object>());
		}

		// Token: 0x0200ACCD RID: 44237
		private class ELevelDetailElementItemComponent
		{
			// Token: 0x0403480A RID: 215050
			public const int DescTxt = 0;
		}
	}
}
