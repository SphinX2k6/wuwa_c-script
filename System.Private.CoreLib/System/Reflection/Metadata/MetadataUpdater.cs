using System;
using System.Runtime.CompilerServices;

namespace System.Reflection.Metadata
{
	// Token: 0x02000791 RID: 1937
	public static class MetadataUpdater
	{
		// Token: 0x06007B8F RID: 31631 RVA: 0x001233E4 File Offset: 0x001215E4
		public unsafe static void ApplyUpdate([Nullable(1)] Assembly assembly, ReadOnlySpan<byte> metadataDelta, ReadOnlySpan<byte> ilDelta, ReadOnlySpan<byte> pdbDelta)
		{
			RuntimeAssembly runtimeAssembly = assembly as RuntimeAssembly;
			if (runtimeAssembly == null)
			{
				ArgumentNullException.ThrowIfNull(assembly, "assembly");
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			if (runtimeAssembly == typeof(AssemblyExtensions).Assembly)
			{
				throw new InvalidOperationException(SR.InvalidOperation_AssemblyNotEditable);
			}
			IntPtr underlyingNativeHandle = runtimeAssembly.GetUnderlyingNativeHandle();
			fixed (byte* ptr = metadataDelta.GetPinnableReference())
			{
				byte* dmeta_bytes = ptr;
				fixed (byte* ptr2 = ilDelta.GetPinnableReference())
				{
					byte* dil_bytes = ptr2;
					fixed (byte* pinnableReference = pdbDelta.GetPinnableReference())
					{
						byte* dpdb_bytes = pinnableReference;
						MetadataUpdater.ApplyUpdate_internal(underlyingNativeHandle, dmeta_bytes, metadataDelta.Length, dil_bytes, ilDelta.Length, dpdb_bytes, pdbDelta.Length);
						ptr = null;
						ptr2 = null;
					}
					return;
				}
			}
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x00123484 File Offset: 0x00121684
		internal static string GetCapabilities()
		{
			return MetadataUpdater.s_ApplyUpdateCapabilities.Value;
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06007B91 RID: 31633 RVA: 0x00123490 File Offset: 0x00121690
		public static bool IsSupported { get; } = MetadataUpdater.ApplyUpdateEnabled(0) != 0;

		// Token: 0x06007B92 RID: 31634 RVA: 0x00123498 File Offset: 0x00121698
		private static string InitializeApplyUpdateCapabilities()
		{
			string applyUpdateCapabilities = MetadataUpdater.GetApplyUpdateCapabilities();
			if (MetadataUpdater.ApplyUpdateEnabled(1) == 0)
			{
				return string.Empty;
			}
			return applyUpdateCapabilities;
		}

		// Token: 0x06007B93 RID: 31635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int ApplyUpdateEnabled(int justComponentCheck);

		// Token: 0x06007B94 RID: 31636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern string GetApplyUpdateCapabilities();

		// Token: 0x06007B95 RID: 31637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void ApplyUpdate_internal(IntPtr base_assm, byte* dmeta_bytes, int dmeta_length, byte* dil_bytes, int dil_length, byte* dpdb_bytes, int dpdb_length);

		// Token: 0x0400176D RID: 5997
		private static readonly Lazy<string> s_ApplyUpdateCapabilities = new Lazy<string>(new Func<string>(MetadataUpdater.InitializeApplyUpdateCapabilities));
	}
}
