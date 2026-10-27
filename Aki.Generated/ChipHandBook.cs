using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B72 RID: 2930
	public struct ChipHandBook : IFlatbufferObject
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060054D6 RID: 21718 RVA: 0x001F48BA File Offset: 0x001F2ABA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x001F48C7 File Offset: 0x001F2AC7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x001F48D0 File Offset: 0x001F2AD0
		public static ChipHandBook GetRootAsChipHandBook(ByteBuffer _bb)
		{
			return ChipHandBook.GetRootAsChipHandBook(_bb, default(ChipHandBook));
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x001F48EC File Offset: 0x001F2AEC
		public static ChipHandBook GetRootAsChipHandBook(ByteBuffer _bb, ChipHandBook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x001F4909 File Offset: 0x001F2B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x001F4918 File Offset: 0x001F2B18
		public ChipHandBook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060054DC RID: 21724 RVA: 0x001F4928 File Offset: 0x001F2B28
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

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060054DD RID: 21725 RVA: 0x001F4964 File Offset: 0x001F2B64
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

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060054DE RID: 21726 RVA: 0x001F49A0 File Offset: 0x001F2BA0
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

		// Token: 0x060054DF RID: 21727 RVA: 0x001F49D7 File Offset: 0x001F2BD7
		public Span<byte> GetVoiceDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x001F49E6 File Offset: 0x001F2BE6
		public byte[] GetVoiceDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B76 RID: 19318
		private Table __p;
	}
}
