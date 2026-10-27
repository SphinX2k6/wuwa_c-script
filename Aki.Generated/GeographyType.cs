using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CF7 RID: 3319
	public struct GeographyType : IFlatbufferObject
	{
		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x0024A5BD File Offset: 0x002487BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x0024A5CA File Offset: 0x002487CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x0024A5D4 File Offset: 0x002487D4
		public static GeographyType GetRootAsGeographyType(ByteBuffer _bb)
		{
			return GeographyType.GetRootAsGeographyType(_bb, default(GeographyType));
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x0024A5F0 File Offset: 0x002487F0
		public static GeographyType GetRootAsGeographyType(ByteBuffer _bb, GeographyType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A21 RID: 31265 RVA: 0x0024A60D File Offset: 0x0024880D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x0024A61C File Offset: 0x0024881C
		public GeographyType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x06007A23 RID: 31267 RVA: 0x0024A62C File Offset: 0x0024882C
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

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06007A24 RID: 31268 RVA: 0x0024A668 File Offset: 0x00248868
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

		// Token: 0x06007A25 RID: 31269 RVA: 0x0024A69F File Offset: 0x0024889F
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x0024A6AE File Offset: 0x002488AE
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06007A27 RID: 31271 RVA: 0x0024A6C8 File Offset: 0x002488C8
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

		// Token: 0x06007A28 RID: 31272 RVA: 0x0024A6FF File Offset: 0x002488FF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0024A70E File Offset: 0x0024890E
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D6A RID: 19818
		private Table __p;
	}
}
