using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B49 RID: 2889
	public struct BossRushTaskTab : IFlatbufferObject
	{
		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x001E8041 File Offset: 0x001E6241
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004F56 RID: 20310 RVA: 0x001E804E File Offset: 0x001E624E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x001E8058 File Offset: 0x001E6258
		public static BossRushTaskTab GetRootAsBossRushTaskTab(ByteBuffer _bb)
		{
			return BossRushTaskTab.GetRootAsBossRushTaskTab(_bb, default(BossRushTaskTab));
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x001E8074 File Offset: 0x001E6274
		public static BossRushTaskTab GetRootAsBossRushTaskTab(ByteBuffer _bb, BossRushTaskTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x001E8091 File Offset: 0x001E6291
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x001E80A0 File Offset: 0x001E62A0
		public BossRushTaskTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x001E80B0 File Offset: 0x001E62B0
		public int TabId
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

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06004F5C RID: 20316 RVA: 0x001E80EC File Offset: 0x001E62EC
		public int ActivityId
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

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x001E8128 File Offset: 0x001E6328
		public string Texture
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

		// Token: 0x06004F5E RID: 20318 RVA: 0x001E815F File Offset: 0x001E635F
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x001E816E File Offset: 0x001E636E
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06004F60 RID: 20320 RVA: 0x001E8188 File Offset: 0x001E6388
		public string TabTitle
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

		// Token: 0x06004F61 RID: 20321 RVA: 0x001E81C0 File Offset: 0x001E63C0
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x001E81D0 File Offset: 0x001E63D0
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B44 RID: 19268
		private Table __p;
	}
}
