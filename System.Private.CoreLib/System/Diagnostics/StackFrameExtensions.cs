using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x0200088E RID: 2190
	[NullableContext(1)]
	[Nullable(0)]
	public static class StackFrameExtensions
	{
		// Token: 0x06008973 RID: 35187 RVA: 0x0014E0D1 File Offset: 0x0014C2D1
		public static bool HasNativeImage(this StackFrame stackFrame)
		{
			return stackFrame.GetNativeImageBase() != IntPtr.Zero;
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x0014E0E3 File Offset: 0x0014C2E3
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "StackFrame.GetMethod is used to establish if method is available.")]
		public static bool HasMethod(this StackFrame stackFrame)
		{
			return stackFrame.GetMethod() != null;
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x0014E0F1 File Offset: 0x0014C2F1
		public static bool HasILOffset(this StackFrame stackFrame)
		{
			return stackFrame.GetILOffset() != -1;
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x0014E0FF File Offset: 0x0014C2FF
		public static bool HasSource(this StackFrame stackFrame)
		{
			return stackFrame.GetFileName() != null;
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x000F2A6E File Offset: 0x000F0C6E
		public static IntPtr GetNativeIP(this StackFrame stackFrame)
		{
			return IntPtr.Zero;
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x000F2A6E File Offset: 0x000F0C6E
		public static IntPtr GetNativeImageBase(this StackFrame stackFrame)
		{
			return IntPtr.Zero;
		}
	}
}
