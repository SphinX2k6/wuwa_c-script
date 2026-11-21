using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F5 RID: 18677
	public class InfrMaterialsDeliveryDoneItem : InfrMaterialsDeliveryLockItemBase
	{
		// Token: 0x0602EE0E RID: 192014 RVA: 0x00D13A90 File Offset: 0x00D11C90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0200A5B4 RID: 42420
		private class EChildType
		{
			// Token: 0x0403344D RID: 209997
			public const int LockSprite = 0;

			// Token: 0x0403344E RID: 209998
			public const int LockDescriptionText = 1;

			// Token: 0x0403344F RID: 209999
			public const int FunctionButton = 2;
		}
	}
}
