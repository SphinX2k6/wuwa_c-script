using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F4 RID: 18676
	public class InfrMaterialsDeliveryLockItem : InfrMaterialsDeliveryLockItemBase
	{
		// Token: 0x0602EE0A RID: 192010 RVA: 0x00D139A4 File Offset: 0x00D11BA4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickFunction));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602EE0B RID: 192011 RVA: 0x00D13A6B File Offset: 0x00D11C6B
		[NullableContext(1)]
		public void SetOnClickFunction(Action cb)
		{
			this.OnClickFunctionCb = cb;
		}

		// Token: 0x0602EE0C RID: 192012 RVA: 0x00D13A74 File Offset: 0x00D11C74
		private void OnClickFunction()
		{
			Action onClickFunctionCb = this.OnClickFunctionCb;
			if (onClickFunctionCb == null)
			{
				return;
			}
			onClickFunctionCb();
		}

		// Token: 0x04018DE6 RID: 101862
		[Nullable(1)]
		private Action OnClickFunctionCb;

		// Token: 0x0200A5B3 RID: 42419
		private class EChildType
		{
			// Token: 0x0403344A RID: 209994
			public const int LockSprite = 0;

			// Token: 0x0403344B RID: 209995
			public const int LockDescriptionText = 1;

			// Token: 0x0403344C RID: 209996
			public const int FunctionButton = 2;
		}
	}
}
