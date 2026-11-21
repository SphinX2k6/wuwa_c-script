using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200492A RID: 18730
	internal class SuccessDescriptionItem : UiPanelBase
	{
		// Token: 0x0602EF7B RID: 192379 RVA: 0x00D19C88 File Offset: 0x00D17E88
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

		// Token: 0x0602EF7C RID: 192380 RVA: 0x00D19CD0 File Offset: 0x00D17ED0
		[NullableContext(1)]
		public void SetDescriptionText(string desc, string[] param)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), desc, param);
		}
	}
}
