using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x0200060D RID: 1549
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(string), MarshalMode.Default, typeof(BStrStringMarshaller))]
	[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(BStrStringMarshaller.ManagedToUnmanagedIn))]
	public static class BStrStringMarshaller
	{
		// Token: 0x060071DD RID: 29149 RVA: 0x00110B9B File Offset: 0x0010ED9B
		public unsafe static ushort* ConvertToUnmanaged([Nullable(2)] string managed)
		{
			return Marshal.StringToBSTR(managed);
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00110BA3 File Offset: 0x0010EDA3
		[return: Nullable(2)]
		public unsafe static string ConvertToManaged(ushort* unmanaged)
		{
			if (unmanaged == null)
			{
				return null;
			}
			return Marshal.PtrToStringBSTR(unmanaged);
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00110BB2 File Offset: 0x0010EDB2
		public unsafe static void Free(ushort* unmanaged)
		{
			Marshal.FreeBSTR(unmanaged);
		}

		// Token: 0x0200060E RID: 1550
		[CompilerFeatureRequired("RefStructs")]
		public ref struct ManagedToUnmanagedIn
		{
			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x060071E0 RID: 29152 RVA: 0x001109B4 File Offset: 0x0010EBB4
			public static int BufferSize
			{
				get
				{
					return 256;
				}
			}

			// Token: 0x060071E1 RID: 29153 RVA: 0x00110BBC File Offset: 0x0010EDBC
			public unsafe void FromManaged([Nullable(2)] string managed, Span<byte> buffer)
			{
				this._allocated = false;
				if (managed == null)
				{
					this._ptrToFirstChar = null;
					return;
				}
				int num = checked(2 * managed.Length);
				ushort* ptr;
				if (checked(num + 6) > buffer.Length)
				{
					ptr = Marshal.AllocBSTRByteLen((uint)num);
					this._allocated = true;
				}
				else
				{
					byte* ptr2 = (byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(buffer));
					*(int*)ptr2 = num;
					ptr = (ushort*)(ptr2 + 4);
				}
				managed.CopyTo(new Span<char>((void*)ptr, managed.Length));
				ptr[managed.Length] = 0;
				this._ptrToFirstChar = ptr;
			}

			// Token: 0x060071E2 RID: 29154 RVA: 0x00110C3A File Offset: 0x0010EE3A
			public unsafe ushort* ToUnmanaged()
			{
				return this._ptrToFirstChar;
			}

			// Token: 0x060071E3 RID: 29155 RVA: 0x00110C42 File Offset: 0x0010EE42
			public void Free()
			{
				if (this._allocated)
				{
					BStrStringMarshaller.Free(this._ptrToFirstChar);
				}
			}

			// Token: 0x04001346 RID: 4934
			private unsafe ushort* _ptrToFirstChar;

			// Token: 0x04001347 RID: 4935
			private bool _allocated;
		}
	}
}
