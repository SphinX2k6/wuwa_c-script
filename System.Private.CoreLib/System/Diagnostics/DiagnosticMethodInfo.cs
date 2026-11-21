using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	// Token: 0x0200088D RID: 2189
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class DiagnosticMethodInfo
	{
		// Token: 0x0600896D RID: 35181 RVA: 0x0014E00A File Offset: 0x0014C20A
		private DiagnosticMethodInfo(MethodBase method)
		{
			this._method = method;
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x0600896E RID: 35182 RVA: 0x0014E019 File Offset: 0x0014C219
		public string Name
		{
			get
			{
				return this._method.Name;
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x0600896F RID: 35183 RVA: 0x0014E028 File Offset: 0x0014C228
		[Nullable(2)]
		public string DeclaringTypeName
		{
			[NullableContext(2)]
			get
			{
				Type type = this._method.DeclaringType;
				if (type != null && type.IsConstructedGenericType)
				{
					type = type.GetGenericTypeDefinition();
				}
				if (type == null)
				{
					return null;
				}
				return type.FullName;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06008970 RID: 35184 RVA: 0x0014E05E File Offset: 0x0014C25E
		[Nullable(2)]
		public string DeclaringAssemblyName
		{
			[NullableContext(2)]
			get
			{
				return this._method.Module.Assembly.FullName;
			}
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x0014E075 File Offset: 0x0014C275
		[return: Nullable(2)]
		public static DiagnosticMethodInfo Create(Delegate @delegate)
		{
			ArgumentNullException.ThrowIfNull(@delegate, "@delegate");
			if (!StackTrace.IsSupported)
			{
				return null;
			}
			return new DiagnosticMethodInfo(@delegate.Method);
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x0014E098 File Offset: 0x0014C298
		[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "IL-level trimming doesn't remove method name and owning type information; this implementation is not used with native AOT trimming")]
		[return: Nullable(2)]
		public static DiagnosticMethodInfo Create(StackFrame frame)
		{
			ArgumentNullException.ThrowIfNull(frame, "frame");
			if (!StackTrace.IsSupported)
			{
				return null;
			}
			MethodBase method = frame.GetMethod();
			if (method != null)
			{
				return new DiagnosticMethodInfo(method);
			}
			return null;
		}

		// Token: 0x04001E45 RID: 7749
		private readonly MethodBase _method;
	}
}
