using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Mono.HotReload
{
	// Token: 0x02000A09 RID: 2569
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class FieldStore
	{
		// Token: 0x06009440 RID: 37952 RVA: 0x00171C24 File Offset: 0x0016FE24
		private FieldStore(object loc)
		{
			this._loc = loc;
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x00171C34 File Offset: 0x0016FE34
		[RequiresUnreferencedCode("Hot reload required untrimmed apps")]
		public static FieldStore Create(RuntimeTypeHandle type)
		{
			Type typeFromHandle = Type.GetTypeFromHandle(type);
			if (typeFromHandle == null)
			{
				throw new ArgumentException(SR.Arg_InvalidHandle, "type");
			}
			Type type2 = typeFromHandle;
			object loc;
			if (type2.IsPrimitive || type2.IsValueType)
			{
				loc = RuntimeHelpers.GetUninitializedObject(type2);
			}
			else
			{
				if (!type2.IsClass && !type2.IsInterface)
				{
					throw new ArgumentException(SR.Arg_EnC_ExpectedPrimitive);
				}
				loc = null;
			}
			return new FieldStore(loc);
		}

		// Token: 0x04002300 RID: 8960
		private readonly object _loc;
	}
}
