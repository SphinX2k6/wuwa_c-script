using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x0200591C RID: 22812
	public class InfrMaterialsDeliveryDoneItem : InfrMaterialsDeliveryLockItemBase
	{
		// Token: 0x06039EEB RID: 237291 RVA: 0x00DC479C File Offset: 0x00DC299C
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

		// Token: 0x0200BBA4 RID: 48036
		private class EChildType
		{
			// Token: 0x04038A67 RID: 232039
			public const int LockSprite = 0;

			// Token: 0x04038A68 RID: 232040
			public const int LockDescriptionText = 1;

			// Token: 0x04038A69 RID: 232041
			public const int FunctionButton = 2;
		}
	}
}
