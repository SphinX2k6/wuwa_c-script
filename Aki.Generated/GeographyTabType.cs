using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDB RID: 3547
	public struct GeographyTabType : IFlatbufferObject
	{
		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06008028 RID: 32808 RVA: 0x00269028 File Offset: 0x00267228
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008029 RID: 32809 RVA: 0x00269035 File Offset: 0x00267235
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x0026903C File Offset: 0x0026723C
		public static GeographyTabType GetRootAsGeographyTabType(ByteBuffer _bb)
		{
			return GeographyTabType.GetRootAsGeographyTabType(_bb, default(GeographyTabType));
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x00269058 File Offset: 0x00267258
		public static GeographyTabType GetRootAsGeographyTabType(ByteBuffer _bb, GeographyTabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x00269075 File Offset: 0x00267275
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x00269084 File Offset: 0x00267284
		public GeographyTabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x0600802E RID: 32814 RVA: 0x00269094 File Offset: 0x00267294
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

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x0600802F RID: 32815 RVA: 0x002690D0 File Offset: 0x002672D0
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

		// Token: 0x06008030 RID: 32816 RVA: 0x00269107 File Offset: 0x00267307
		public Span<byte> GetTypeNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x00269116 File Offset: 0x00267316
		public byte[] GetTypeNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06008032 RID: 32818 RVA: 0x00269130 File Offset: 0x00267330
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

		// Token: 0x06008033 RID: 32819 RVA: 0x00269167 File Offset: 0x00267367
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008034 RID: 32820 RVA: 0x00269176 File Offset: 0x00267376
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0400534E RID: 21326
		private Table __p;
	}
}
