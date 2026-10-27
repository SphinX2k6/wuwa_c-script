using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Giant.View
{
	// Token: 0x0200597D RID: 22909
	public class GiantDeliverBtnItem : UiPanelBase
	{
		// Token: 0x0603A23D RID: 238141 RVA: 0x00DD3000 File Offset: 0x00DD1200
		[NullableContext(1)]
		public UniTask Init(UUIButtonComponent button)
		{
			GiantDeliverBtnItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.button = button;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<GiantDeliverBtnItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603A23E RID: 238142 RVA: 0x00DD304C File Offset: 0x00DD124C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603A23F RID: 238143 RVA: 0x00DD30D6 File Offset: 0x00DD12D6
		[NullableContext(2)]
		public UUIItem GetRedDotItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x0200BC09 RID: 48137
		private enum EComponents
		{
			// Token: 0x04038C24 RID: 232484
			Root,
			// Token: 0x04038C25 RID: 232485
			TxtConfirm,
			// Token: 0x04038C26 RID: 232486
			RedDot
		}
	}
}
