using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108D RID: 4237
	public struct RedDot : IFlatbufferObject
	{
		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x0600C0B3 RID: 49331 RVA: 0x002F7394 File Offset: 0x002F5594
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x002F73A1 File Offset: 0x002F55A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x002F73A8 File Offset: 0x002F55A8
		public static RedDot GetRootAsRedDot(ByteBuffer _bb)
		{
			return RedDot.GetRootAsRedDot(_bb, default(RedDot));
		}

		// Token: 0x0600C0B6 RID: 49334 RVA: 0x002F73C4 File Offset: 0x002F55C4
		public static RedDot GetRootAsRedDot(ByteBuffer _bb, RedDot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C0B7 RID: 49335 RVA: 0x002F73E1 File Offset: 0x002F55E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C0B8 RID: 49336 RVA: 0x002F73F0 File Offset: 0x002F55F0
		public RedDot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0600C0B9 RID: 49337 RVA: 0x002F7400 File Offset: 0x002F5600
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x002F7437 File Offset: 0x002F5637
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x002F7446 File Offset: 0x002F5646
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600C0BC RID: 49340 RVA: 0x002F7460 File Offset: 0x002F5660
		public string RelativeName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x002F7497 File Offset: 0x002F5697
		public Span<byte> GetRelativeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C0BE RID: 49342 RVA: 0x002F74A6 File Offset: 0x002F56A6
		public byte[] GetRelativeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005666 RID: 22118
		private Table __p;
	}
}
