using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F0E RID: 3854
	public struct MoraleLvPower : IFlatbufferObject
	{
		// Token: 0x17002047 RID: 8263
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x002A7DD1 File Offset: 0x002A5FD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009C66 RID: 40038 RVA: 0x002A7DDE File Offset: 0x002A5FDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x002A7DE8 File Offset: 0x002A5FE8
		public static MoraleLvPower GetRootAsMoraleLvPower(ByteBuffer _bb)
		{
			return MoraleLvPower.GetRootAsMoraleLvPower(_bb, default(MoraleLvPower));
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x002A7E04 File Offset: 0x002A6004
		public static MoraleLvPower GetRootAsMoraleLvPower(ByteBuffer _bb, MoraleLvPower obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x002A7E21 File Offset: 0x002A6021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x002A7E30 File Offset: 0x002A6030
		public MoraleLvPower __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002048 RID: 8264
		// (get) Token: 0x06009C6B RID: 40043 RVA: 0x002A7E40 File Offset: 0x002A6040
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

		// Token: 0x17002049 RID: 8265
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x002A7E7C File Offset: 0x002A607C
		public int LvStage
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

		// Token: 0x1700204A RID: 8266
		// (get) Token: 0x06009C6D RID: 40045 RVA: 0x002A7EB8 File Offset: 0x002A60B8
		public string BuffName
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

		// Token: 0x06009C6E RID: 40046 RVA: 0x002A7EEF File Offset: 0x002A60EF
		public Span<byte> GetBuffNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x002A7EFE File Offset: 0x002A60FE
		public byte[] GetBuffNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700204B RID: 8267
		// (get) Token: 0x06009C70 RID: 40048 RVA: 0x002A7F18 File Offset: 0x002A6118
		public string BuffDesc
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

		// Token: 0x06009C71 RID: 40049 RVA: 0x002A7F50 File Offset: 0x002A6150
		public Span<byte> GetBuffDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x002A7F60 File Offset: 0x002A6160
		public byte[] GetBuffDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700204C RID: 8268
		// (get) Token: 0x06009C73 RID: 40051 RVA: 0x002A7F78 File Offset: 0x002A6178
		public string BuffDescDetail
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

		// Token: 0x06009C74 RID: 40052 RVA: 0x002A7FB0 File Offset: 0x002A61B0
		public Span<byte> GetBuffDescDetailBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x002A7FC0 File Offset: 0x002A61C0
		public byte[] GetBuffDescDetailArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700204D RID: 8269
		// (get) Token: 0x06009C76 RID: 40054 RVA: 0x002A7FD8 File Offset: 0x002A61D8
		public string IconPathNormal
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C77 RID: 40055 RVA: 0x002A8010 File Offset: 0x002A6210
		public Span<byte> GetIconPathNormalBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009C78 RID: 40056 RVA: 0x002A8020 File Offset: 0x002A6220
		public byte[] GetIconPathNormalArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700204E RID: 8270
		// (get) Token: 0x06009C79 RID: 40057 RVA: 0x002A8038 File Offset: 0x002A6238
		public string IconPathActive
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x002A8070 File Offset: 0x002A6270
		public Span<byte> GetIconPathActiveBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x002A8080 File Offset: 0x002A6280
		public byte[] GetIconPathActiveArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040054B3 RID: 21683
		private Table __p;
	}
}
