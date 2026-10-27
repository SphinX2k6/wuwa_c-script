using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF6 RID: 3318
	public struct GeographyTabType : IFlatbufferObject
	{
		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06007A10 RID: 31248 RVA: 0x0024A458 File Offset: 0x00248658
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0024A465 File Offset: 0x00248665
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0024A46C File Offset: 0x0024866C
		public static GeographyTabType GetRootAsGeographyTabType(ByteBuffer _bb)
		{
			return GeographyTabType.GetRootAsGeographyTabType(_bb, default(GeographyTabType));
		}

		// Token: 0x06007A13 RID: 31251 RVA: 0x0024A488 File Offset: 0x00248688
		public static GeographyTabType GetRootAsGeographyTabType(ByteBuffer _bb, GeographyTabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A14 RID: 31252 RVA: 0x0024A4A5 File Offset: 0x002486A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A15 RID: 31253 RVA: 0x0024A4B4 File Offset: 0x002486B4
		public GeographyTabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x0024A4C4 File Offset: 0x002486C4
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

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06007A17 RID: 31255 RVA: 0x0024A500 File Offset: 0x00248700
		public string TypeName
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

		// Token: 0x06007A18 RID: 31256 RVA: 0x0024A537 File Offset: 0x00248737
		public Span<byte> GetTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x0024A546 File Offset: 0x00248746
		public byte[] GetTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06007A1A RID: 31258 RVA: 0x0024A560 File Offset: 0x00248760
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

		// Token: 0x06007A1B RID: 31259 RVA: 0x0024A597 File Offset: 0x00248797
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007A1C RID: 31260 RVA: 0x0024A5A6 File Offset: 0x002487A6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D69 RID: 19817
		private Table __p;
	}
}
