using System;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000206 RID: 518
	internal static class FixedBufferExtensions
	{
		// Token: 0x060028AE RID: 10414 RVA: 0x0007E05C File Offset: 0x0007C25C
		internal unsafe static string GetStringFromFixedBuffer(this ReadOnlySpan<char> span)
		{
			fixed (char* reference = MemoryMarshal.GetReference<char>(span))
			{
				return new string(reference, 0, span.GetFixedBufferStringLength());
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0007E080 File Offset: 0x0007C280
		internal static int GetFixedBufferStringLength(this ReadOnlySpan<char> span)
		{
			int num = span.IndexOf('\0');
			if (num >= 0)
			{
				return num;
			}
			return span.Length;
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x0007E0A4 File Offset: 0x0007C2A4
		internal unsafe static bool FixedBufferEqualsString(this ReadOnlySpan<char> span, string value)
		{
			if (value == null || value.Length > span.Length)
			{
				return false;
			}
			int i;
			for (i = 0; i < value.Length; i++)
			{
				if (value[i] == '\0' || value[i] != (char)(*span[i]))
				{
					return false;
				}
			}
			return i == span.Length || *span[i] == 0;
		}
	}
}
