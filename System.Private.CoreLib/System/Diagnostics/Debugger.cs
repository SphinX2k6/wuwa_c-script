using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x02000876 RID: 2166
	[NullableContext(2)]
	[Nullable(0)]
	public static class Debugger
	{
		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x060088B8 RID: 35000 RVA: 0x0014C9A2 File Offset: 0x0014ABA2
		public static bool IsAttached
		{
			get
			{
				return Debugger.IsAttached_internal();
			}
		}

		// Token: 0x060088B9 RID: 35001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsAttached_internal();

		// Token: 0x060088BA RID: 35002 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Intrinsic]
		public static void Break()
		{
		}

		// Token: 0x060088BB RID: 35003
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLogging();

		// Token: 0x060088BC RID: 35004 RVA: 0x0000FD41 File Offset: 0x0000DF41
		public static bool Launch()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060088BD RID: 35005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Log_icall(int level, ref string category, ref string message);

		// Token: 0x060088BE RID: 35006 RVA: 0x0014C9A9 File Offset: 0x0014ABA9
		public static void Log(int level, string category, string message)
		{
			if (category == null)
			{
				category = string.Empty;
			}
			if (message == null)
			{
				message = string.Empty;
			}
			Debugger.Log_icall(level, ref category, ref message);
		}

		// Token: 0x060088BF RID: 35007 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void NotifyOfCrossThreadDependency()
		{
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void BreakForUserUnhandledException(Exception exception)
		{
		}

		// Token: 0x04001E05 RID: 7685
		public static readonly string DefaultCategory;
	}
}
