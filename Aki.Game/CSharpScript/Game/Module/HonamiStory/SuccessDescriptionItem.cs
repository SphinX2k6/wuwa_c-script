using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x02005951 RID: 22865
	internal class SuccessDescriptionItem : UiPanelBase
	{
		// Token: 0x0603A058 RID: 237656 RVA: 0x00DCA9D4 File Offset: 0x00DC8BD4
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

		// Token: 0x0603A059 RID: 237657 RVA: 0x00DCAA1C File Offset: 0x00DC8C1C
		[NullableContext(1)]
		public void SetDescriptionText(string desc, string[] param)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), desc, param);
		}
	}
}
