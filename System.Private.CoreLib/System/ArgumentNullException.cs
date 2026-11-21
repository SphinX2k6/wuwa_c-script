using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	// Token: 0x020000CD RID: 205
	[NullableContext(2)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class ArgumentNullException : ArgumentException
	{
		// Token: 0x060009D8 RID: 2520 RVA: 0x0001E54C File Offset: 0x0001C74C
		public ArgumentNullException() : base(SR.ArgumentNull_Generic)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x0001E564 File Offset: 0x0001C764
		public ArgumentNullException(string paramName) : base(SR.ArgumentNull_Generic, paramName)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0001E57D File Offset: 0x0001C77D
		public ArgumentNullException(string message, Exception innerException) : base(message ?? SR.ArgumentNull_Generic, innerException)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0001E59B File Offset: 0x0001C79B
		public ArgumentNullException(string paramName, string message) : base(message ?? SR.ArgumentNull_Generic, paramName)
		{
			base.HResult = -2147467261;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0001E5B9 File Offset: 0x0001C7B9
		[NullableContext(1)]
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ArgumentNullException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x0001E5C3 File Offset: 0x0001C7C3
		[Intrinsic]
		public static void ThrowIfNull([NotNull] object argument, [CallerArgumentExpression("argument")] string paramName = null)
		{
			if (argument == null)
			{
				ArgumentNullException.Throw(paramName);
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0001E5CE File Offset: 0x0001C7CE
		[Intrinsic]
		internal static void ThrowIfNull([NotNull] object argument, ExceptionArgument paramName)
		{
			if (argument == null)
			{
				ThrowHelper.ThrowArgumentNullException(paramName);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0001E5D9 File Offset: 0x0001C7D9
		[NullableContext(0)]
		[CLSCompliant(false)]
		public unsafe static void ThrowIfNull([NotNull] void* argument, [Nullable(2)] [CallerArgumentExpression("argument")] string paramName = null)
		{
			if (argument == null)
			{
				ArgumentNullException.Throw(paramName);
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0001E5E6 File Offset: 0x0001C7E6
		internal static void ThrowIfNull(IntPtr argument, [CallerArgumentExpression("argument")] string paramName = null)
		{
			if (argument == IntPtr.Zero)
			{
				ArgumentNullException.Throw(paramName);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0001E5F6 File Offset: 0x0001C7F6
		[DoesNotReturn]
		internal static void Throw(string paramName)
		{
			throw new ArgumentNullException(paramName);
		}
	}
}
