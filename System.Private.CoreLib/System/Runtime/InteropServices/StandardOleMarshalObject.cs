using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005FE RID: 1534
	public class StandardOleMarshalObject : MarshalByRefObject, IMarshal
	{
		// Token: 0x060071A4 RID: 29092 RVA: 0x000227E2 File Offset: 0x000209E2
		protected StandardOleMarshalObject()
		{
		}

		// Token: 0x060071A5 RID: 29093 RVA: 0x00110778 File Offset: 0x0010E978
		private IntPtr GetStdMarshaler(ref Guid riid, int dwDestContext, int mshlflags)
		{
			IntPtr iunknownForObject = Marshal.GetIUnknownForObject(this);
			if (iunknownForObject != IntPtr.Zero)
			{
				try
				{
					IntPtr zero = IntPtr.Zero;
					if (Interop.Ole32.CoGetStandardMarshal(ref riid, iunknownForObject, dwDestContext, IntPtr.Zero, mshlflags, out zero) == 0)
					{
						return zero;
					}
				}
				finally
				{
					Marshal.Release(iunknownForObject);
				}
			}
			throw new InvalidOperationException(SR.Format(SR.StandardOleMarshalObjectGetMarshalerFailed, riid));
		}

		// Token: 0x060071A6 RID: 29094 RVA: 0x001107E8 File Offset: 0x0010E9E8
		int IMarshal.GetUnmarshalClass(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out Guid pCid)
		{
			pCid = StandardOleMarshalObject.CLSID_StdMarshal;
			return 0;
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x001107F8 File Offset: 0x0010E9F8
		unsafe int IMarshal.GetMarshalSizeMax(ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags, out int pSize)
		{
			IntPtr stdMarshaler = this.GetStdMarshaler(ref riid, dwDestContext, mshlflags);
			int result;
			try
			{
				try
				{
					fixed (Guid* ptr = &riid)
					{
						Guid* ptr2 = ptr;
						try
						{
							fixed (int* ptr3 = &pSize)
							{
								int* ptr4 = ptr3;
								method system.Int32_u0020(System.IntPtr,System.Guid*,System.IntPtr,System.Int32,System.IntPtr,System.Int32,System.Int32*) = *(*stdMarshaler + (IntPtr)4 * 8);
								result = calli(System.Int32(System.IntPtr,System.Guid*,System.IntPtr,System.Int32,System.IntPtr,System.Int32,System.Int32*), stdMarshaler, ptr2, pv, dwDestContext, pvDestContext, mshlflags, ptr4, system.Int32_u0020(System.IntPtr,System.Guid*,System.IntPtr,System.Int32,System.IntPtr,System.Int32,System.Int32*));
							}
						}
						finally
						{
							int* ptr3 = null;
						}
					}
				}
				finally
				{
					Guid* ptr = null;
				}
			}
			finally
			{
				Marshal.Release(stdMarshaler);
			}
			return result;
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x0011087C File Offset: 0x0010EA7C
		unsafe int IMarshal.MarshalInterface(IntPtr pStm, ref Guid riid, IntPtr pv, int dwDestContext, IntPtr pvDestContext, int mshlflags)
		{
			IntPtr stdMarshaler = this.GetStdMarshaler(ref riid, dwDestContext, mshlflags);
			int result;
			try
			{
				try
				{
					fixed (Guid* ptr = &riid)
					{
						Guid* ptr2 = ptr;
						method system.Int32_u0020(System.IntPtr,System.IntPtr,System.Guid*,System.IntPtr,System.Int32,System.IntPtr,System.Int32) = *(*stdMarshaler + (IntPtr)5 * 8);
						result = calli(System.Int32(System.IntPtr,System.IntPtr,System.Guid*,System.IntPtr,System.Int32,System.IntPtr,System.Int32), stdMarshaler, pStm, ptr2, pv, dwDestContext, pvDestContext, mshlflags, system.Int32_u0020(System.IntPtr,System.IntPtr,System.Guid*,System.IntPtr,System.Int32,System.IntPtr,System.Int32));
					}
				}
				finally
				{
					Guid* ptr = null;
				}
			}
			finally
			{
				Marshal.Release(stdMarshaler);
			}
			return result;
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x001108E8 File Offset: 0x0010EAE8
		int IMarshal.UnmarshalInterface(IntPtr pStm, ref Guid riid, out IntPtr ppv)
		{
			ppv = IntPtr.Zero;
			return -2147467263;
		}

		// Token: 0x060071AA RID: 29098 RVA: 0x001108F6 File Offset: 0x0010EAF6
		int IMarshal.ReleaseMarshalData(IntPtr pStm)
		{
			return -2147467263;
		}

		// Token: 0x060071AB RID: 29099 RVA: 0x001108F6 File Offset: 0x0010EAF6
		int IMarshal.DisconnectObject(int dwReserved)
		{
			return -2147467263;
		}

		// Token: 0x04001335 RID: 4917
		private static readonly Guid CLSID_StdMarshal = new Guid("00000017-0000-0000-c000-000000000046");
	}
}
