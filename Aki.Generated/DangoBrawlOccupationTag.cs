using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAB RID: 3243
	public struct DangoBrawlOccupationTag : IFlatbufferObject
	{
		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x0600646F RID: 25711 RVA: 0x0022B034 File Offset: 0x00229234
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006470 RID: 25712 RVA: 0x0022B041 File Offset: 0x00229241
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006471 RID: 25713 RVA: 0x0022B048 File Offset: 0x00229248
		public static DangoBrawlOccupationTag GetRootAsDangoBrawlOccupationTag(ByteBuffer _bb)
		{
			return DangoBrawlOccupationTag.GetRootAsDangoBrawlOccupationTag(_bb, default(DangoBrawlOccupationTag));
		}

		// Token: 0x06006472 RID: 25714 RVA: 0x0022B064 File Offset: 0x00229264
		public static DangoBrawlOccupationTag GetRootAsDangoBrawlOccupationTag(ByteBuffer _bb, DangoBrawlOccupationTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006473 RID: 25715 RVA: 0x0022B081 File Offset: 0x00229281
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006474 RID: 25716 RVA: 0x0022B090 File Offset: 0x00229290
		public DangoBrawlOccupationTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06006475 RID: 25717 RVA: 0x0022B0A0 File Offset: 0x002292A0
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

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06006476 RID: 25718 RVA: 0x0022B0DC File Offset: 0x002292DC
		public string Icon
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

		// Token: 0x06006477 RID: 25719 RVA: 0x0022B113 File Offset: 0x00229313
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006478 RID: 25720 RVA: 0x0022B122 File Offset: 0x00229322
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06006479 RID: 25721 RVA: 0x0022B13C File Offset: 0x0022933C
		public string Name
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

		// Token: 0x0600647A RID: 25722 RVA: 0x0022B173 File Offset: 0x00229373
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x0022B182 File Offset: 0x00229382
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600647C RID: 25724 RVA: 0x0022B19C File Offset: 0x0022939C
		public string BgColor
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x0022B1D4 File Offset: 0x002293D4
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600647E RID: 25726 RVA: 0x0022B1E4 File Offset: 0x002293E4
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600647F RID: 25727 RVA: 0x0022B1FC File Offset: 0x002293FC
		public string NameColor
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006480 RID: 25728 RVA: 0x0022B234 File Offset: 0x00229434
		public Span<byte> GetNameColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x0022B244 File Offset: 0x00229444
		public byte[] GetNameColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040051D5 RID: 20949
		private Table __p;
	}
}
