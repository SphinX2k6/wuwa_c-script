using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BC5 RID: 3013
	public struct DangoBrawlItemType : IFlatbufferObject
	{
		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06005E1C RID: 24092 RVA: 0x0020A919 File Offset: 0x00208B19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x0020A926 File Offset: 0x00208B26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x0020A930 File Offset: 0x00208B30
		public static DangoBrawlItemType GetRootAsDangoBrawlItemType(ByteBuffer _bb)
		{
			return DangoBrawlItemType.GetRootAsDangoBrawlItemType(_bb, default(DangoBrawlItemType));
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x0020A94C File Offset: 0x00208B4C
		public static DangoBrawlItemType GetRootAsDangoBrawlItemType(ByteBuffer _bb, DangoBrawlItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x0020A969 File Offset: 0x00208B69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x0020A978 File Offset: 0x00208B78
		public DangoBrawlItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06005E22 RID: 24098 RVA: 0x0020A988 File Offset: 0x00208B88
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06005E23 RID: 24099 RVA: 0x0020A9C4 File Offset: 0x00208BC4
		public string Name
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

		// Token: 0x06005E24 RID: 24100 RVA: 0x0020A9FB File Offset: 0x00208BFB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x0020AA0A File Offset: 0x00208C0A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06005E26 RID: 24102 RVA: 0x0020AA24 File Offset: 0x00208C24
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

		// Token: 0x06005E27 RID: 24103 RVA: 0x0020AA5B File Offset: 0x00208C5B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x0020AA6A File Offset: 0x00208C6A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004BEE RID: 19438
		private Table __p;
	}
}
