using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AF5 RID: 15093
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseLevelDetailElementItem : GridProxyAbstract<string>
	{
		// Token: 0x06026C4A RID: 158794 RVA: 0x00AD86B8 File Offset: 0x00AD68B8
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

		// Token: 0x06026C4B RID: 158795 RVA: 0x00AD8700 File Offset: 0x00AD6900
		[NullableContext(1)]
		public override void Refresh(string data, bool isSelected, int gridIndex)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data, Array.Empty<object>());
		}

		// Token: 0x020096ED RID: 38637
		private class ELevelDetailElementItemComponent
		{
			// Token: 0x0402F1BA RID: 192954
			public const int DescTxt = 0;
		}
	}
}
