using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000125 RID: 293
	public class KuroCharacterShadowLibrary
	{
		// Token: 0x06000A9E RID: 2718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Set_Internal(in FGuid a);

		// Token: 0x06000A9F RID: 2719 RVA: 0x00033FCF File Offset: 0x000321CF
		public static void Set(in FGuid a)
		{
			KuroCharacterShadowLibrary.Set_Internal(a);
		}

		// Token: 0x06000AA0 RID: 2720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetR_Internal(in FArrayBuffer view);

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00033FD7 File Offset: 0x000321D7
		public static void SetR(in FArrayBuffer view)
		{
			KuroCharacterShadowLibrary.SetR_Internal(view);
		}
	}
}
