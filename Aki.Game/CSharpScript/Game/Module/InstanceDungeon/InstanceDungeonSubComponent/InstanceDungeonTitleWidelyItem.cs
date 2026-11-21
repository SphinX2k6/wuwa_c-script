using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004887 RID: 18567
	public class InstanceDungeonTitleWidelyItem : UiPanelBase
	{
		// Token: 0x0602EB00 RID: 191232 RVA: 0x00D08490 File Offset: 0x00D06690
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

		// Token: 0x0602EB01 RID: 191233 RVA: 0x00D084D8 File Offset: 0x00D066D8
		[NullableContext(2)]
		public void RefreshItem(string titleTextId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), titleTextId, Array.Empty<object>());
		}

		// Token: 0x0200A52F RID: 42287
		private enum EComponent
		{
			// Token: 0x04033247 RID: 209479
			TitleText
		}
	}
}
