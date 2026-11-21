using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AFE RID: 15102
	public class TowerDefensePhantomIconCornerMark : UiPanelBase
	{
		// Token: 0x06026CA1 RID: 158881 RVA: 0x00ADADFC File Offset: 0x00AD8FFC
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

		// Token: 0x06026CA2 RID: 158882 RVA: 0x00ADAE44 File Offset: 0x00AD9044
		[NullableContext(1)]
		public void RefreshColor(string hexColorPath)
		{
			this.SetSpriteByPath(hexColorPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x04015376 RID: 86902
		private const int MARK_COMPONENT_INDEX = 0;
	}
}
