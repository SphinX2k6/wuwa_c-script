using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C53 RID: 3155
	public struct ChipHandBook : IFlatbufferObject
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x002146E6 File Offset: 0x002128E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x002146F3 File Offset: 0x002128F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x002146FC File Offset: 0x002128FC
		public static ChipHandBook GetRootAsChipHandBook(ByteBuffer _bb)
		{
			return ChipHandBook.GetRootAsChipHandBook(_bb, default(ChipHandBook));
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x00214718 File Offset: 0x00212918
		public static ChipHandBook GetRootAsChipHandBook(ByteBuffer _bb, ChipHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00214735 File Offset: 0x00212935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00214744 File Offset: 0x00212944
		public ChipHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x00214754 File Offset: 0x00212954
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06005AAB RID: 23211 RVA: 0x00214790 File Offset: 0x00212990
		public int Type
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x002147CC File Offset: 0x002129CC
		public string VoiceDescrtption
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005AAD RID: 23213 RVA: 0x00214803 File Offset: 0x00212A03
		public Span<byte> GetVoiceDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005AAE RID: 23214 RVA: 0x00214812 File Offset: 0x00212A12
		public byte[] GetVoiceDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04005157 RID: 20823
		private Table __p;
	}
}
