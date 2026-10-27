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
	// Token: 0x02004C5A RID: 19546
	public class SheriffShowClueViewPop : UiViewBase
	{
		// Token: 0x0603288A RID: 206986 RVA: 0x00BC5CAB File Offset: 0x00BC3EAB
		[NullableContext(1)]
		public SheriffShowClueViewPop(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603288B RID: 206987 RVA: 0x00BC5CB4 File Offset: 0x00BC3EB4
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

		// Token: 0x0603288C RID: 206988 RVA: 0x00BC5D60 File Offset: 0x00BC3F60
		protected override UniTask OnBeforeStartAsync()
		{
			SheriffShowClueViewPop.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SheriffShowClueViewPop.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603288D RID: 206989 RVA: 0x00BC5DA3 File Offset: 0x00BC3FA3
		private void OnClickedClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401AE63 RID: 110179
		[Nullable(1)]
		protected SheriffShowClueViewPanel DetailPanel;

		// Token: 0x0200ADFE RID: 44542
		private static class EDefine
		{
			// Token: 0x04034D92 RID: 216466
			public const int Caption = 0;

			// Token: 0x04034D93 RID: 216467
			public const int Content = 1;

			// Token: 0x04034D94 RID: 216468
			public const int BtnTips = 2;

			// Token: 0x04034D95 RID: 216469
			public const int DialogItem = 3;
		}
	}
}
