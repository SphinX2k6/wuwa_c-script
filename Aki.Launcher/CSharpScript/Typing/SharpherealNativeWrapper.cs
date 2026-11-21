using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x0200003B RID: 59
	public static class SharpherealNativeWrapper
	{
		// Token: 0x06000237 RID: 567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsEnabled_Internal();

		// Token: 0x06000238 RID: 568 RVA: 0x0000B386 File Offset: 0x00009586
		public static bool IsEnabled()
		{
			return SharpherealNativeWrapper.IsEnabled_Internal();
		}
	}
}
