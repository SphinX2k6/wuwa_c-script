using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C04 RID: 15364
	public class SheriffAnalysisResultPop : UiViewBase
	{
		// Token: 0x06027610 RID: 161296 RVA: 0x00B09755 File Offset: 0x00B07955
		[NullableContext(1)]
		public SheriffAnalysisResultPop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06027611 RID: 161297 RVA: 0x00B09760 File Offset: 0x00B07960
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>();
		}

		// Token: 0x06027612 RID: 161298 RVA: 0x00B097D4 File Offset: 0x00B079D4
		protected override void OnStart()
		{
			bool flag = (bool)this.OpenParam;
			base.GetItem(0).SetUIActive(flag);
			base.GetItem(1).SetUIActive(!flag);
		}

		// Token: 0x06027613 RID: 161299 RVA: 0x00B0980A File Offset: 0x00B07A0A
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x02009816 RID: 38934
		private static class EDefine
		{
			// Token: 0x0402F71C RID: 194332
			public const int PanelSuccess = 0;

			// Token: 0x0402F71D RID: 194333
			public const int PanelFailure = 1;
		}
	}
}
