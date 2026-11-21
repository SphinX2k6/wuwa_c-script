using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000126 RID: 294
	public class KuroCharacterShadowLibrary
	{
		// Token: 0x06000AF5 RID: 2805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Set_Internal(in FGuid a);

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00034A43 File Offset: 0x00032C43
		public static void Set(in FGuid a)
		{
			KuroCharacterShadowLibrary.Set_Internal(a);
		}

		// Token: 0x06000AF7 RID: 2807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetR_Internal(in FArrayBuffer view);

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00034A4B File Offset: 0x00032C4B
		public static void SetR(in FArrayBuffer view)
		{
			KuroCharacterShadowLibrary.SetR_Internal(view);
		}
	}
}
