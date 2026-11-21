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
	// Token: 0x02003C13 RID: 15379
	public class SheriffErrorView : UiViewBase
	{
		// Token: 0x06027676 RID: 161398 RVA: 0x00B0B8F4 File Offset: 0x00B09AF4
		[NullableContext(1)]
		public SheriffErrorView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06027677 RID: 161399 RVA: 0x00B0B900 File Offset: 0x00B09B00
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

		// Token: 0x06027678 RID: 161400 RVA: 0x00B0B985 File Offset: 0x00B09B85
		private void OnClickBtnClose()
		{
			this.HandleClose().Forget();
		}

		// Token: 0x06027679 RID: 161401 RVA: 0x00B0B994 File Offset: 0x00B09B94
		private UniTask HandleClose()
		{
			SheriffErrorView.<HandleClose>d__4 <HandleClose>d__;
			<HandleClose>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HandleClose>d__.<>1__state = -1;
			<HandleClose>d__.<>t__builder.Start<SheriffErrorView.<HandleClose>d__4>(ref <HandleClose>d__);
			return <HandleClose>d__.<>t__builder.Task;
		}

		// Token: 0x02009829 RID: 38953
		private static class EComponent
		{
			// Token: 0x0402F76B RID: 194411
			public const int BtnClose = 0;
		}
	}
}
