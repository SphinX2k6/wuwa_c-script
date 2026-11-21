using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004623 RID: 17955
	public class AttributeItemInternal : AttributeItem
	{
		// Token: 0x0602D1B1 RID: 184753 RVA: 0x00C9BDB0 File Offset: 0x00C99FB0
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

		// Token: 0x0602D1B2 RID: 184754 RVA: 0x00C9BE7C File Offset: 0x00C9A07C
		public void SetBgActive()
		{
		}

		// Token: 0x0200A22B RID: 41515
		public class EAttributeItemInternalDefine
		{
			// Token: 0x040324CB RID: 206027
			public const int Name = 0;

			// Token: 0x040324CC RID: 206028
			public const int CurrentValue = 1;

			// Token: 0x040324CD RID: 206029
			public const int NextItem = 2;

			// Token: 0x040324CE RID: 206030
			public const int NextValue = 3;

			// Token: 0x040324CF RID: 206031
			public const int Icon = 4;
		}
	}
}
