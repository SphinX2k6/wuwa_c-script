using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005999 RID: 22937
	public class SolarSchoolLocationNameItem : UiPanelBase
	{
		// Token: 0x060388F4 RID: 231668 RVA: 0x00FD3190 File Offset: 0x00FD1390
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

		// Token: 0x060388F5 RID: 231669 RVA: 0x00FD31D8 File Offset: 0x00FD13D8
		[NullableContext(1)]
		public void SetLocationName(string txtId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(0), txtId, Array.Empty<object>());
		}

		// Token: 0x0200B542 RID: 46402
		private class EComponents
		{
			// Token: 0x040380B0 RID: 229552
			public const int TxtContent = 0;
		}
	}
}
