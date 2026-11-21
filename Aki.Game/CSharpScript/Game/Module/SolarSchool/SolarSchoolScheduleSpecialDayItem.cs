using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A5 RID: 22949
	public class SolarSchoolScheduleSpecialDayItem : UiPanelBase
	{
		// Token: 0x06038951 RID: 231761 RVA: 0x00FD5018 File Offset: 0x00FD3218
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

		// Token: 0x06038952 RID: 231762 RVA: 0x00FD5060 File Offset: 0x00FD3260
		[NullableContext(2)]
		public void Refresh(string nameTextKey)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), nameTextKey, Array.Empty<object>());
		}

		// Token: 0x0200B551 RID: 46417
		private class EComponents
		{
			// Token: 0x040380FA RID: 229626
			public const int TxtExamDay = 0;
		}
	}
}
