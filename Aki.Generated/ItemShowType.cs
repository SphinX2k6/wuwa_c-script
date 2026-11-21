using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E69 RID: 3689
	public struct ItemShowType : IFlatbufferObject
	{
		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06008D10 RID: 36112 RVA: 0x00285884 File Offset: 0x00283A84
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008D11 RID: 36113 RVA: 0x00285891 File Offset: 0x00283A91
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008D12 RID: 36114 RVA: 0x00285898 File Offset: 0x00283A98
		public static ItemShowType GetRootAsItemShowType(ByteBuffer _bb)
		{
			return ItemShowType.GetRootAsItemShowType(_bb, default(ItemShowType));
		}

		// Token: 0x06008D13 RID: 36115 RVA: 0x002858B4 File Offset: 0x00283AB4
		public static ItemShowType GetRootAsItemShowType(ByteBuffer _bb, ItemShowType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008D14 RID: 36116 RVA: 0x002858D1 File Offset: 0x00283AD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008D15 RID: 36117 RVA: 0x002858E0 File Offset: 0x00283AE0
		public ItemShowType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06008D16 RID: 36118 RVA: 0x002858F0 File Offset: 0x00283AF0
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

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06008D17 RID: 36119 RVA: 0x0028592C File Offset: 0x00283B2C
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

		// Token: 0x06008D18 RID: 36120 RVA: 0x00285963 File Offset: 0x00283B63
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008D19 RID: 36121 RVA: 0x00285972 File Offset: 0x00283B72
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06008D1A RID: 36122 RVA: 0x0028598C File Offset: 0x00283B8C
		public int ItemSort
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040053F5 RID: 21493
		private Table __p;
	}
}
