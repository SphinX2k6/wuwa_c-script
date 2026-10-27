using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Sheriff.View.Map
{
	// Token: 0x02004C62 RID: 19554
	public class SheriffErrorView : UiViewBase
	{
		// Token: 0x060328C3 RID: 207043 RVA: 0x00BC6C88 File Offset: 0x00BC4E88
		[NullableContext(1)]
		public SheriffErrorView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060328C4 RID: 207044 RVA: 0x00BC6C94 File Offset: 0x00BC4E94
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060328C5 RID: 207045 RVA: 0x00BC6D19 File Offset: 0x00BC4F19
		private void OnClickBtnClose()
		{
			this.HandleClose().Forget();
		}

		// Token: 0x060328C6 RID: 207046 RVA: 0x00BC6D28 File Offset: 0x00BC4F28
		private UniTask HandleClose()
		{
			SheriffErrorView.<HandleClose>d__4 <HandleClose>d__;
			<HandleClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleClose>d__.<>1__state = -1;
			<HandleClose>d__.<>t__builder.Start<SheriffErrorView.<HandleClose>d__4>(ref <HandleClose>d__);
			return <HandleClose>d__.<>t__builder.Task;
		}

		// Token: 0x0200AE0B RID: 44555
		private static class EComponent
		{
			// Token: 0x04034DC6 RID: 216518
			public const int BtnClose = 0;
		}
	}
}
