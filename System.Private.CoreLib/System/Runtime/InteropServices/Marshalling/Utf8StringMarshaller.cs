using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200062A RID: 1578
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(string), MarshalMode.Default, typeof(Utf8StringMarshaller))]
	[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(Utf8StringMarshaller.ManagedToUnmanagedIn))]
	public static class Utf8StringMarshaller
	{
		// Token: 0x06007240 RID: 29248 RVA: 0x00112094 File Offset: 0x00110294
		public unsafe static byte* ConvertToUnmanaged([Nullable(2)] string managed)
		{
			if (managed == null)
			{
				return null;
			}
			int num = checked(Encoding.UTF8.GetByteCount(managed) + 1);
			byte* ptr = Marshal.AllocCoTaskMem(num);
			Span<byte> bytes = new Span<byte>((void*)ptr, num);
			int bytes2 = Encoding.UTF8.GetBytes(managed, bytes);
			*bytes[bytes2] = 0;
			return ptr;
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x001120E2 File Offset: 0x001102E2
		[return: Nullable(2)]
		public unsafe static string ConvertToManaged(byte* unmanaged)
		{
			return Marshal.PtrToStringUTF8(unmanaged);
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x001109AC File Offset: 0x0010EBAC
		public unsafe static void Free(byte* unmanaged)
		{
			Marshal.FreeCoTaskMem(unmanaged);
		}

		// Token: 0x0200062B RID: 1579
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x06007243 RID: 29251 RVA: 0x001109B4 File Offset: 0x0010EBB4
			public static int BufferSize
			{
				get
				{
					return 256;
				}
			}

			// Token: 0x06007244 RID: 29252 RVA: 0x001120EC File Offset: 0x001102EC
			public unsafe void FromManaged([Nullable(2)] string managed, Span<byte> buffer)
			{
				this._allocated = false;
				if (managed == null)
				{
					this._unmanagedValue = null;
					return;
				}
				if (3L * (long)managed.Length >= (long)buffer.Length)
				{
					int num = checked(Encoding.UTF8.GetByteCount(managed) + 1);
					if (num > buffer.Length)
					{
						buffer = new Span<byte>(NativeMemory.Alloc((UIntPtr)((IntPtr)num)), num);
						this._allocated = true;
					}
				}
				this._unmanagedValue = (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(buffer));
				int bytes = Encoding.UTF8.GetBytes(managed, buffer);
				*buffer[bytes] = 0;
			}

			// Token: 0x06007245 RID: 29253 RVA: 0x0011217B File Offset: 0x0011037B
			public unsafe byte* ToUnmanaged()
			{
				return this._unmanagedValue;
			}

			// Token: 0x06007246 RID: 29254 RVA: 0x00112183 File Offset: 0x00110383
			public unsafe void Free()
			{
				if (this._allocated)
				{
					NativeMemory.Free((void*)this._unmanagedValue);
				}
			}

			// Token: 0x0400139F RID: 5023
			private unsafe byte* _unmanagedValue;

			// Token: 0x040013A0 RID: 5024
			private bool _allocated;
		}
	}
}
