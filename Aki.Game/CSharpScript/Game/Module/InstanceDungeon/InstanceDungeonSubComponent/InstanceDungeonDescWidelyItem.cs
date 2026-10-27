using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x0200589A RID: 22682
	public class InstanceDungeonDescWidelyItem : UiPanelBase
	{
		// Token: 0x06039B60 RID: 236384 RVA: 0x00DB6E0C File Offset: 0x00DB500C
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

		// Token: 0x06039B61 RID: 236385 RVA: 0x00DB6E54 File Offset: 0x00DB5054
		[NullableContext(2)]
		public void RefreshItem(string descTextId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), descTextId, Array.Empty<object>());
		}

		// Token: 0x0200BAF3 RID: 47859
		private enum EComponent
		{
			// Token: 0x040387CB RID: 231371
			ContentText
		}
	}
}
