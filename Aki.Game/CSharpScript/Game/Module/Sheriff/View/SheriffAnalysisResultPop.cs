using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02004C53 RID: 19539
	public class SheriffAnalysisResultPop : UiViewBase
	{
		// Token: 0x0603285D RID: 206941 RVA: 0x00BC4B09 File Offset: 0x00BC2D09
		[NullableContext(1)]
		public SheriffAnalysisResultPop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603285E RID: 206942 RVA: 0x00BC4B14 File Offset: 0x00BC2D14
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

		// Token: 0x0603285F RID: 206943 RVA: 0x00BC4B88 File Offset: 0x00BC2D88
		protected override void OnStart()
		{
			bool flag = (bool)this.OpenParam;
			base.GetItem(0).SetUIActive(flag);
			base.GetItem(1).SetUIActive(!flag);
		}

		// Token: 0x06032860 RID: 206944 RVA: 0x00BC4BBE File Offset: 0x00BC2DBE
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x0200ADF8 RID: 44536
		private static class EDefine
		{
			// Token: 0x04034D77 RID: 216439
			public const int PanelSuccess = 0;

			// Token: 0x04034D78 RID: 216440
			public const int PanelFailure = 1;
		}
	}
}
