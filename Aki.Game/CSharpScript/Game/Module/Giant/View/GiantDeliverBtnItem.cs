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
	// Token: 0x02004956 RID: 18774
	public class GiantDeliverBtnItem : UiPanelBase
	{
		// Token: 0x0602F163 RID: 192867 RVA: 0x00D22490 File Offset: 0x00D20690
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

		// Token: 0x0602F164 RID: 192868 RVA: 0x00D224DC File Offset: 0x00D206DC
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

		// Token: 0x0602F165 RID: 192869 RVA: 0x00D22566 File Offset: 0x00D20766
		[NullableContext(2)]
		public UUIItem GetRedDotItem()
		{
			return base.GetItem(2);
		}

		// Token: 0x0200A614 RID: 42516
		private enum EComponents
		{
			// Token: 0x040335F3 RID: 210419
			Root,
			// Token: 0x040335F4 RID: 210420
			TxtConfirm,
			// Token: 0x040335F5 RID: 210421
			RedDot
		}
	}
}
