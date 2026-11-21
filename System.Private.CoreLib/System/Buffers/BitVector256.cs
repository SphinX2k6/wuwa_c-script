using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x0200035A RID: 858
	internal struct BitVector256
	{
		// Token: 0x06003B1C RID: 15132 RVA: 0x000C4A28 File Offset: 0x000C2C28
		public unsafe readonly BitVector256 CreateInverse()
		{
			BitVector256 result = default(BitVector256);
			for (int i = 0; i < 8; i++)
			{
				*(ref result._values.FixedElementField + (IntPtr)i * 4) = ~(*(ref this._values.FixedElementField + (IntPtr)i * 4));
			}
			return result;
		}

		// Token: 0x06003B1D RID: 15133 RVA: 0x000C4A70 File Offset: 0x000C2C70
		public unsafe void Set(int c)
		{
			uint num = (uint)(c >> 5);
			uint num2 = 1U << c;
			*(ref this._values.FixedElementField + (IntPtr)((ulong)num * 4UL)) |= num2;
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x000C4A9F File Offset: 0x000C2C9F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Contains128(char c)
		{
			return c < '\u0080' && this.ContainsUnchecked((int)c);
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x000C4AB2 File Offset: 0x000C2CB2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool Contains(byte b)
		{
			return this.ContainsUnchecked((int)b);
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x000C4ABC File Offset: 0x000C2CBC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe readonly bool ContainsUnchecked(int b)
		{
			uint num = (uint)(b >> 5);
			uint num2 = 1U << b;
			return (*(ref this._values.FixedElementField + (IntPtr)((ulong)num * 4UL)) & num2) > 0U;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x000C4AEC File Offset: 0x000C2CEC
		public readonly char[] GetCharValues()
		{
			List<char> list = new List<char>();
			for (int i = 0; i < 256; i++)
			{
				if (this.ContainsUnchecked(i))
				{
					list.Add((char)i);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x000C4B28 File Offset: 0x000C2D28
		public readonly byte[] GetByteValues()
		{
			List<byte> list = new List<byte>();
			for (int i = 0; i < 256; i++)
			{
				if (this.ContainsUnchecked(i))
				{
					list.Add((byte)i);
				}
			}
			return list.ToArray();
		}

		// Token: 0x04000C73 RID: 3187
		[FixedBuffer(typeof(uint), 8)]
		private BitVector256.<_values>e__FixedBuffer _values;

		// Token: 0x0200035B RID: 859
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 32)]
		public struct <_values>e__FixedBuffer
		{
			// Token: 0x04000C74 RID: 3188
			public uint FixedElementField;
		}
	}
}
