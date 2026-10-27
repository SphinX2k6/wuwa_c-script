using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D06 RID: 3334
	public struct GmOrderConfig : IFlatbufferObject
	{
		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06007B2C RID: 31532 RVA: 0x0024CBAD File Offset: 0x0024ADAD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x0024CBBA File Offset: 0x0024ADBA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x0024CBC4 File Offset: 0x0024ADC4
		public static GmOrderConfig GetRootAsGmOrderConfig(ByteBuffer _bb)
		{
			return GmOrderConfig.GetRootAsGmOrderConfig(_bb, default(GmOrderConfig));
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x0024CBE0 File Offset: 0x0024ADE0
		public static GmOrderConfig GetRootAsGmOrderConfig(ByteBuffer _bb, GmOrderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x0024CBFD File Offset: 0x0024ADFD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x0024CC0C File Offset: 0x0024AE0C
		public GmOrderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x0024CC1C File Offset: 0x0024AE1C
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

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06007B33 RID: 31539 RVA: 0x0024CC58 File Offset: 0x0024AE58
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

		// Token: 0x06007B34 RID: 31540 RVA: 0x0024CC8F File Offset: 0x0024AE8F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x0024CC9E File Offset: 0x0024AE9E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06007B36 RID: 31542 RVA: 0x0024CCB8 File Offset: 0x0024AEB8
		public string NameOverride
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

		// Token: 0x06007B37 RID: 31543 RVA: 0x0024CCEF File Offset: 0x0024AEEF
		public Span<byte> GetNameOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x0024CCFE File Offset: 0x0024AEFE
		public byte[] GetNameOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06007B39 RID: 31545 RVA: 0x0024CD18 File Offset: 0x0024AF18
		public string Code
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

		// Token: 0x06007B3A RID: 31546 RVA: 0x0024CD50 File Offset: 0x0024AF50
		public Span<byte> GetCodeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x0024CD60 File Offset: 0x0024AF60
		public byte[] GetCodeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x06007B3C RID: 31548 RVA: 0x0024CD78 File Offset: 0x0024AF78
		public string CodeOverride
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

		// Token: 0x06007B3D RID: 31549 RVA: 0x0024CDB0 File Offset: 0x0024AFB0
		public Span<byte> GetCodeOverrideBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x0024CDC0 File Offset: 0x0024AFC0
		public byte[] GetCodeOverrideArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06007B3F RID: 31551 RVA: 0x0024CDD8 File Offset: 0x0024AFD8
		public int Sort
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06007B40 RID: 31552 RVA: 0x0024CE18 File Offset: 0x0024B018
		public bool Visible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004D7C RID: 19836
		private Table __p;
	}
}
