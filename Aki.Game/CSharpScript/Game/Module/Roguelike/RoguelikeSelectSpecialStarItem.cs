using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DEA RID: 15850
	public class RoguelikeSelectSpecialStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x060287C5 RID: 165829 RVA: 0x00B59964 File Offset: 0x00B57B64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060287C6 RID: 165830 RVA: 0x00B599AC File Offset: 0x00B57BAC
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(data);
		}

		// Token: 0x020099F5 RID: 39413
		private class EComponent
		{
			// Token: 0x0402FFE9 RID: 196585
			public const int StarObj = 0;
		}
	}
}
