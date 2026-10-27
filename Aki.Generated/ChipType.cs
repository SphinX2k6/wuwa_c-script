using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B73 RID: 2931
	public struct ChipType : IFlatbufferObject
	{
		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060054E1 RID: 21729 RVA: 0x001F49FD File Offset: 0x001F2BFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x001F4A0A File Offset: 0x001F2C0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x001F4A14 File Offset: 0x001F2C14
		public static ChipType GetRootAsChipType(ByteBuffer _bb)
		{
			return ChipType.GetRootAsChipType(_bb, default(ChipType));
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x001F4A30 File Offset: 0x001F2C30
		public static ChipType GetRootAsChipType(ByteBuffer _bb, ChipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x001F4A4D File Offset: 0x001F2C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x001F4A5C File Offset: 0x001F2C5C
		public ChipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060054E7 RID: 21735 RVA: 0x001F4A6C File Offset: 0x001F2C6C
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

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060054E8 RID: 21736 RVA: 0x001F4AA8 File Offset: 0x001F2CA8
		public string TypeDescription
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

		// Token: 0x060054E9 RID: 21737 RVA: 0x001F4ADF File Offset: 0x001F2CDF
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x001F4AEE File Offset: 0x001F2CEE
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060054EB RID: 21739 RVA: 0x001F4B08 File Offset: 0x001F2D08
		public string Icon
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

		// Token: 0x060054EC RID: 21740 RVA: 0x001F4B3F File Offset: 0x001F2D3F
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x001F4B4E File Offset: 0x001F2D4E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B77 RID: 19319
		private Table __p;
	}
}
