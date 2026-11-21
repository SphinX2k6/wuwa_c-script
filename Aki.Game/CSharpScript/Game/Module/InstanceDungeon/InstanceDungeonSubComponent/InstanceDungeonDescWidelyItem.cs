using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004872 RID: 18546
	public class InstanceDungeonDescWidelyItem : UiPanelBase
	{
		// Token: 0x0602EA83 RID: 191107 RVA: 0x00D05D24 File Offset: 0x00D03F24
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

		// Token: 0x0602EA84 RID: 191108 RVA: 0x00D05D6C File Offset: 0x00D03F6C
		[NullableContext(2)]
		public void RefreshItem(string descTextId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), descTextId, Array.Empty<object>());
		}

		// Token: 0x0200A50C RID: 42252
		private enum EComponent
		{
			// Token: 0x040331CC RID: 209356
			ContentText
		}
	}
}
