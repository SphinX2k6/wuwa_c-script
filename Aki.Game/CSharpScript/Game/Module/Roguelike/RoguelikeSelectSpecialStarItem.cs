using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E21 RID: 20001
	public class RoguelikeSelectSpecialStarItem : GridProxyAbstract<bool>
	{
		// Token: 0x0603395A RID: 211290 RVA: 0x00C10430 File Offset: 0x00C0E630
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

		// Token: 0x0603395B RID: 211291 RVA: 0x00C10478 File Offset: 0x00C0E678
		public override void Refresh(bool data, bool isSelected, int gridIndex)
		{
			base.GetItem(0).SetUIActive(data);
		}

		// Token: 0x0200AFC3 RID: 44995
		private class EComponent
		{
			// Token: 0x040355B9 RID: 218553
			public const int StarObj = 0;
		}
	}
}
