using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B7C RID: 2940
	public struct CiacconaGalText : IFlatbufferObject
	{
		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x001F641C File Offset: 0x001F461C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060055A6 RID: 21926 RVA: 0x001F6429 File Offset: 0x001F4629
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060055A7 RID: 21927 RVA: 0x001F6430 File Offset: 0x001F4630
		public static CiacconaGalText GetRootAsCiacconaGalText(ByteBuffer _bb)
		{
			return CiacconaGalText.GetRootAsCiacconaGalText(_bb, default(CiacconaGalText));
		}

		// Token: 0x060055A8 RID: 21928 RVA: 0x001F644C File Offset: 0x001F464C
		public static CiacconaGalText GetRootAsCiacconaGalText(ByteBuffer _bb, CiacconaGalText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060055A9 RID: 21929 RVA: 0x001F6469 File Offset: 0x001F4669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x001F6478 File Offset: 0x001F4678
		public CiacconaGalText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x060055AB RID: 21931 RVA: 0x001F6488 File Offset: 0x001F4688
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

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x001F64C4 File Offset: 0x001F46C4
		public string TextId
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

		// Token: 0x060055AD RID: 21933 RVA: 0x001F64FB File Offset: 0x001F46FB
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x001F650A File Offset: 0x001F470A
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B80 RID: 19328
		private Table __p;
	}
}
