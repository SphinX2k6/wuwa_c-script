using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View
{
	// Token: 0x02003C0B RID: 15371
	public class SheriffShowClueViewPop : UiViewBase
	{
		// Token: 0x0602763D RID: 161341 RVA: 0x00B0A8F7 File Offset: 0x00B08AF7
		[NullableContext(1)]
		public SheriffShowClueViewPop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602763E RID: 161342 RVA: 0x00B0A900 File Offset: 0x00B08B00
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602763F RID: 161343 RVA: 0x00B0A9AC File Offset: 0x00B08BAC
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffShowClueViewPop.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffShowClueViewPop.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027640 RID: 161344 RVA: 0x00B0A9EF File Offset: 0x00B08BEF
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x040157C0 RID: 88000
		[Nullable(1)]
		protected SheriffShowClueViewPanel DetailPanel;

		// Token: 0x0200981C RID: 38940
		private static class EDefine
		{
			// Token: 0x0402F737 RID: 194359
			public const int Caption = 0;

			// Token: 0x0402F738 RID: 194360
			public const int Content = 1;

			// Token: 0x0402F739 RID: 194361
			public const int BtnTips = 2;

			// Token: 0x0402F73A RID: 194362
			public const int DialogItem = 3;
		}
	}
}
