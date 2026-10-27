using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058AF RID: 22703
	public class InstanceDungeonTitleWidelyItem : UiPanelBase
	{
		// Token: 0x06039BDD RID: 236509 RVA: 0x00DB9578 File Offset: 0x00DB7778
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

		// Token: 0x06039BDE RID: 236510 RVA: 0x00DB95C0 File Offset: 0x00DB77C0
		[NullableContext(2)]
		public void RefreshItem(string titleTextId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), titleTextId, Array.Empty<object>());
		}

		// Token: 0x0200BB16 RID: 47894
		private enum EComponent
		{
			// Token: 0x04038846 RID: 231494
			TitleText
		}
	}
}
