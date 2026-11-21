using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Metadata
{
	// Token: 0x02000790 RID: 1936
	public static class AssemblyExtensions
	{
		// Token: 0x06007B8E RID: 31630 RVA: 0x001233CF File Offset: 0x001215CF
		[CLSCompliant(false)]
		public unsafe static bool TryGetRawMetadata([Nullable(1)] this Assembly assembly, out byte* blob, out int length)
		{
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			blob = (IntPtr)((UIntPtr)0);
			length = 0;
			return false;
		}
	}
}
