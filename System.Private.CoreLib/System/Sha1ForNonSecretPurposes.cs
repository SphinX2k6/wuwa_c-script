using System;
using System.Numerics;

namespace System
{
	// Token: 0x02000205 RID: 517
	internal struct Sha1ForNonSecretPurposes
	{
		// Token: 0x060028A9 RID: 10409 RVA: 0x0007DC5C File Offset: 0x0007BE5C
		public void Start()
		{
			if (this._w == null)
			{
				this._w = new uint[85];
			}
			this._length = 0L;
			this._pos = 0;
			this._w[80] = 1732584193U;
			this._w[81] = 4023233417U;
			this._w[82] = 2562383102U;
			this._w[83] = 271733878U;
			this._w[84] = 3285377520U;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x0007DCD4 File Offset: 0x0007BED4
		public void Append(byte input)
		{
			int num = this._pos >> 2;
			this._w[num] = (this._w[num] << 8 | (uint)input);
			int num2 = 64;
			int num3 = this._pos + 1;
			this._pos = num3;
			if (num2 == num3)
			{
				this.Drain();
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x0007DD1C File Offset: 0x0007BF1C
		public unsafe void Append(ReadOnlySpan<byte> input)
		{
			ReadOnlySpan<byte> readOnlySpan = input;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				byte input2 = *readOnlySpan[i];
				this.Append(input2);
			}
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x0007DD50 File Offset: 0x0007BF50
		public unsafe void Finish(Span<byte> output)
		{
			long num = this._length + (long)(8 * this._pos);
			this.Append(128);
			while (this._pos != 56)
			{
				this.Append(0);
			}
			this.Append((byte)(num >> 56));
			this.Append((byte)(num >> 48));
			this.Append((byte)(num >> 40));
			this.Append((byte)(num >> 32));
			this.Append((byte)(num >> 24));
			this.Append((byte)(num >> 16));
			this.Append((byte)(num >> 8));
			this.Append((byte)num);
			int num2 = (output.Length < 20) ? output.Length : 20;
			for (int num3 = 0; num3 != num2; num3++)
			{
				uint num4 = this._w[80 + num3 / 4];
				*output[num3] = (byte)(num4 >> 24);
				this._w[80 + num3 / 4] = num4 << 8;
			}
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x0007DE30 File Offset: 0x0007C030
		private void Drain()
		{
			for (int num = 16; num != 80; num++)
			{
				this._w[num] = BitOperations.RotateLeft(this._w[num - 3] ^ this._w[num - 8] ^ this._w[num - 14] ^ this._w[num - 16], 1);
			}
			uint num2 = this._w[80];
			uint num3 = this._w[81];
			uint num4 = this._w[82];
			uint num5 = this._w[83];
			uint num6 = this._w[84];
			for (int num7 = 0; num7 != 20; num7++)
			{
				uint num8 = (num3 & num4) | (~num3 & num5);
				uint num9 = BitOperations.RotateLeft(num2, 5) + num8 + num6 + 1518500249U + this._w[num7];
				num6 = num5;
				num5 = num4;
				num4 = BitOperations.RotateLeft(num3, 30);
				num3 = num2;
				num2 = num9;
			}
			for (int num10 = 20; num10 != 40; num10++)
			{
				uint num11 = num3 ^ num4 ^ num5;
				uint num12 = BitOperations.RotateLeft(num2, 5) + num11 + num6 + 1859775393U + this._w[num10];
				num6 = num5;
				num5 = num4;
				num4 = BitOperations.RotateLeft(num3, 30);
				num3 = num2;
				num2 = num12;
			}
			for (int num13 = 40; num13 != 60; num13++)
			{
				uint num14 = (num3 & num4) | (num3 & num5) | (num4 & num5);
				uint num15 = BitOperations.RotateLeft(num2, 5) + num14 + num6 + 2400959708U + this._w[num13];
				num6 = num5;
				num5 = num4;
				num4 = BitOperations.RotateLeft(num3, 30);
				num3 = num2;
				num2 = num15;
			}
			for (int num16 = 60; num16 != 80; num16++)
			{
				uint num17 = num3 ^ num4 ^ num5;
				uint num18 = BitOperations.RotateLeft(num2, 5) + num17 + num6 + 3395469782U + this._w[num16];
				num6 = num5;
				num5 = num4;
				num4 = BitOperations.RotateLeft(num3, 30);
				num3 = num2;
				num2 = num18;
			}
			this._w[80] += num2;
			this._w[81] += num3;
			this._w[82] += num4;
			this._w[83] += num5;
			this._w[84] += num6;
			this._length += 512L;
			this._pos = 0;
		}

		// Token: 0x04000726 RID: 1830
		private long _length;

		// Token: 0x04000727 RID: 1831
		private uint[] _w;

		// Token: 0x04000728 RID: 1832
		private int _pos;
	}
}
