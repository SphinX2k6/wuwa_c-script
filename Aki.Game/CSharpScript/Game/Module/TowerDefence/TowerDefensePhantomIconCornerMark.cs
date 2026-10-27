using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B56 RID: 19286
	public class TowerDefensePhantomIconCornerMark : UiPanelBase
	{
		// Token: 0x06031F12 RID: 204562 RVA: 0x00B96BC0 File Offset: 0x00B94DC0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031F13 RID: 204563 RVA: 0x00B96C08 File Offset: 0x00B94E08
		[NullableContext(1)]
		public void RefreshColor(string hexColorPath)
		{
			this.SetSpriteByPath(hexColorPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0401AA24 RID: 109092
		private const int MARK_COMPONENT_INDEX = 0;
	}
}
