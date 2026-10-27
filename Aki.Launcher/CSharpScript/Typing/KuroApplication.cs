using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x02000038 RID: 56
	[NullableContext(1)]
	[Nullable(0)]
	public static class KuroApplication
	{
		// Token: 0x06000203 RID: 515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ExitWithReason_Internal(bool isForce, string reason);

		// Token: 0x06000204 RID: 516 RVA: 0x0000B290 File Offset: 0x00009490
		public static void ExitWithReason(bool isForce, string reason)
		{
			KuroApplication.ExitWithReason_Internal(isForce, reason);
		}

		// Token: 0x06000205 RID: 517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ExitWithCode_Internal(bool isForce, string reason, int exitCode);

		// Token: 0x06000206 RID: 518 RVA: 0x0000B299 File Offset: 0x00009499
		public static void ExitWithCode(bool isForce, string reason, int exitCode)
		{
			KuroApplication.ExitWithCode_Internal(isForce, reason, exitCode);
		}

		// Token: 0x06000207 RID: 519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetAppReleaseType_Internal();

		// Token: 0x06000208 RID: 520 RVA: 0x0000B2A3 File Offset: 0x000094A3
		public static string GetAppReleaseType()
		{
			return KuroApplication.GetAppReleaseType_Internal();
		}

		// Token: 0x06000209 RID: 521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetCommandLine_Internal();

		// Token: 0x0600020A RID: 522 RVA: 0x0000B2AA File Offset: 0x000094AA
		public static string GetCommandLine()
		{
			return KuroApplication.GetCommandLine_Internal();
		}

		// Token: 0x0600020B RID: 523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string IniPlatformName_Internal();

		// Token: 0x0600020C RID: 524 RVA: 0x0000B2B1 File Offset: 0x000094B1
		public static string IniPlatformName()
		{
			return KuroApplication.IniPlatformName_Internal();
		}

		// Token: 0x0600020D RID: 525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string IniPlatformNameIncludeEditor_Internal();

		// Token: 0x0600020E RID: 526 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public static string IniPlatformNameIncludeEditor()
		{
			return KuroApplication.IniPlatformNameIncludeEditor_Internal();
		}

		// Token: 0x0600020F RID: 527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsAsyncLoadingThreadEnabled_Internal();

		// Token: 0x06000210 RID: 528 RVA: 0x0000B2BF File Offset: 0x000094BF
		public static bool IsAsyncLoadingThreadEnabled()
		{
			return KuroApplication.IsAsyncLoadingThreadEnabled_Internal();
		}

		// Token: 0x06000211 RID: 529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsBuildShipping_Internal();

		// Token: 0x06000212 RID: 530 RVA: 0x0000B2C6 File Offset: 0x000094C6
		public static bool IsBuildShipping()
		{
			return KuroApplication.IsBuildShipping_Internal();
		}

		// Token: 0x06000213 RID: 531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsBuildTest_Internal();

		// Token: 0x06000214 RID: 532 RVA: 0x0000B2CD File Offset: 0x000094CD
		public static bool IsBuildTest()
		{
			return KuroApplication.IsBuildTest_Internal();
		}

		// Token: 0x06000215 RID: 533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsWithEditor_Internal();

		// Token: 0x06000216 RID: 534 RVA: 0x0000B2D4 File Offset: 0x000094D4
		public static bool IsWithEditor()
		{
			return KuroApplication.IsWithEditor_Internal();
		}

		// Token: 0x06000217 RID: 535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsWithStat_Internal();

		// Token: 0x06000218 RID: 536 RVA: 0x0000B2DB File Offset: 0x000094DB
		public static bool IsWithStat()
		{
			return KuroApplication.IsWithStat_Internal();
		}

		// Token: 0x06000219 RID: 537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string ProjectContentDir_Internal();

		// Token: 0x0600021A RID: 538 RVA: 0x0000B2E2 File Offset: 0x000094E2
		public static string ProjectContentDir()
		{
			return KuroApplication.ProjectContentDir_Internal();
		}

		// Token: 0x0600021B RID: 539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetSessionCachedUserName_Internal();

		// Token: 0x0600021C RID: 540 RVA: 0x0000B2E9 File Offset: 0x000094E9
		public static string GetSessionCachedUserName()
		{
			return KuroApplication.GetSessionCachedUserName_Internal();
		}
	}
}
