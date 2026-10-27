using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x0200564D RID: 22093
	public class AttributeItemInternal : AttributeItem
	{
		// Token: 0x060382B3 RID: 230067 RVA: 0x00D4E060 File Offset: 0x00D4C260
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060382B4 RID: 230068 RVA: 0x00D4E12C File Offset: 0x00D4C32C
		public void SetBgActive()
		{
		}

		// Token: 0x0200B800 RID: 47104
		public class EAttributeItemInternalDefine
		{
			// Token: 0x04037AA1 RID: 228001
			public const int Name = 0;

			// Token: 0x04037AA2 RID: 228002
			public const int CurrentValue = 1;

			// Token: 0x04037AA3 RID: 228003
			public const int NextItem = 2;

			// Token: 0x04037AA4 RID: 228004
			public const int NextValue = 3;

			// Token: 0x04037AA5 RID: 228005
			public const int Icon = 4;
		}
	}
}
