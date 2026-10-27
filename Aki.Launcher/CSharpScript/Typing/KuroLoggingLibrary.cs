using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x02000039 RID: 57
	[NullableContext(1)]
	[Nullable(0)]
	public static class KuroLoggingLibrary
	{
		// Token: 0x0600021D RID: 541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PromoteGlobalLogVerbosity_Internal(byte verbosity);

		// Token: 0x0600021E RID: 542 RVA: 0x0000B2F0 File Offset: 0x000094F0
		public static void PromoteGlobalLogVerbosity(byte verbosity)
		{
			KuroLoggingLibrary.PromoteGlobalLogVerbosity_Internal(verbosity);
		}

		// Token: 0x0600021F RID: 543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResetGlobalLogVerbosity_Internal();

		// Token: 0x06000220 RID: 544 RVA: 0x0000B2F8 File Offset: 0x000094F8
		public static void ResetGlobalLogVerbosity()
		{
			KuroLoggingLibrary.ResetGlobalLogVerbosity_Internal();
		}

		// Token: 0x06000221 RID: 545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetCategoryVerbosity_Internal(string categoryName, byte verbosity);

		// Token: 0x06000222 RID: 546 RVA: 0x0000B2FF File Offset: 0x000094FF
		public static void SetCategoryVerbosity(string categoryName, byte verbosity)
		{
			KuroLoggingLibrary.SetCategoryVerbosity_Internal(categoryName, verbosity);
		}

		// Token: 0x06000223 RID: 547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterTerminateDelegate_Internal();

		// Token: 0x06000224 RID: 548 RVA: 0x0000B308 File Offset: 0x00009508
		public static void RegisterTerminateDelegate()
		{
			KuroLoggingLibrary.RegisterTerminateDelegate_Internal();
		}

		// Token: 0x06000225 RID: 549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetLogFilename_Internal();

		// Token: 0x06000226 RID: 550 RVA: 0x0000B30F File Offset: 0x0000950F
		public static string GetLogFilename()
		{
			return KuroLoggingLibrary.GetLogFilename_Internal();
		}
	}
}
