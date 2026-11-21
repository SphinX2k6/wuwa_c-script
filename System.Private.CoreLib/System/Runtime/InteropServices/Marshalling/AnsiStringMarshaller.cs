using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x02000609 RID: 1545
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(string), MarshalMode.Default, typeof(AnsiStringMarshaller))]
	[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(AnsiStringMarshaller.ManagedToUnmanagedIn))]
	public static class AnsiStringMarshaller
	{
		// Token: 0x060071C6 RID: 29126 RVA: 0x00110968 File Offset: 0x0010EB68
		public unsafe static byte* ConvertToUnmanaged([Nullable(2)] string managed)
		{
			if (managed == null)
			{
				return null;
			}
			int ansiStringByteCount = Marshal.GetAnsiStringByteCount(managed);
			byte* ptr = Marshal.AllocCoTaskMem(ansiStringByteCount);
			Span<byte> bytes = new Span<byte>((void*)ptr, ansiStringByteCount);
			Marshal.GetAnsiStringBytes(managed, bytes);
			return ptr;
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x001109A4 File Offset: 0x0010EBA4
		[return: Nullable(2)]
		public unsafe static string ConvertToManaged(byte* unmanaged)
		{
			return Marshal.PtrToStringAnsi(unmanaged);
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x001109AC File Offset: 0x0010EBAC
		public unsafe static void Free(byte* unmanaged)
		{
			Marshal.FreeCoTaskMem(unmanaged);
		}

		// Token: 0x0200060A RID: 1546
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x060071C9 RID: 29129 RVA: 0x001109B4 File Offset: 0x0010EBB4
			public static int BufferSize
			{
				get
				{
					return 256;
				}
			}

			// Token: 0x060071CA RID: 29130 RVA: 0x001109BC File Offset: 0x0010EBBC
			public unsafe void FromManaged([Nullable(2)] string managed, Span<byte> buffer)
			{
				this._allocated = false;
				if (managed == null)
				{
					this._unmanagedValue = null;
					return;
				}
				if ((long)Marshal.SystemMaxDBCSCharSize * (long)managed.Length >= (long)buffer.Length)
				{
					int ansiStringByteCount = Marshal.GetAnsiStringByteCount(managed);
					if (ansiStringByteCount > buffer.Length)
					{
						buffer = new Span<byte>(NativeMemory.Alloc((UIntPtr)((IntPtr)ansiStringByteCount)), ansiStringByteCount);
						this._allocated = true;
					}
				}
				this._unmanagedValue = (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(buffer));
				Marshal.GetAnsiStringBytes(managed, buffer);
			}

			// Token: 0x060071CB RID: 29131 RVA: 0x00110A3D File Offset: 0x0010EC3D
			public unsafe byte* ToUnmanaged()
			{
				return this._unmanagedValue;
			}

			// Token: 0x060071CC RID: 29132 RVA: 0x00110A45 File Offset: 0x0010EC45
			public unsafe void Free()
			{
				if (this._allocated)
				{
					NativeMemory.Free((void*)this._unmanagedValue);
				}
			}

			// Token: 0x04001340 RID: 4928
			private unsafe byte* _unmanagedValue;

			// Token: 0x04001341 RID: 4929
			private bool _allocated;
		}
	}
}
