using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Marshalling
{
	// Token: 0x02000629 RID: 1577
	[CLSCompliant(false)]
	[CustomMarshaller(typeof(string), MarshalMode.Default, typeof(Utf16StringMarshaller))]
	public static class Utf16StringMarshaller
	{
		// Token: 0x0600723C RID: 29244 RVA: 0x0010C235 File Offset: 0x0010A435
		public unsafe static ushort* ConvertToUnmanaged([Nullable(2)] string managed)
		{
			return Marshal.StringToCoTaskMemUni(managed);
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x0010C225 File Offset: 0x0010A425
		[return: Nullable(2)]
		public unsafe static string ConvertToManaged(ushort* unmanaged)
		{
			return Marshal.PtrToStringUni(unmanaged);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x001109AC File Offset: 0x0010EBAC
		public unsafe static void Free(ushort* unmanaged)
		{
			Marshal.FreeCoTaskMem(unmanaged);
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00112083 File Offset: 0x00110283
		[NullableContext(2)]
		public static ref readonly char GetPinnableReference(string str)
		{
			if (str != null)
			{
				return str.GetPinnableReference();
			}
			return (IntPtr)0;
		}
	}
}
