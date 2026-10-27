using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEB RID: 4075
	public struct RogueQualityConfig : IFlatbufferObject
	{
		// Token: 0x17002F95 RID: 12181
		// (get) Token: 0x0600C039 RID: 49209 RVA: 0x002E79A1 File Offset: 0x002E5BA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C03A RID: 49210 RVA: 0x002E79AE File Offset: 0x002E5BAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C03B RID: 49211 RVA: 0x002E79B8 File Offset: 0x002E5BB8
		public static RogueQualityConfig GetRootAsRogueQualityConfig(ByteBuffer _bb)
		{
			return RogueQualityConfig.GetRootAsRogueQualityConfig(_bb, default(RogueQualityConfig));
		}

		// Token: 0x0600C03C RID: 49212 RVA: 0x002E79D4 File Offset: 0x002E5BD4
		public static RogueQualityConfig GetRootAsRogueQualityConfig(ByteBuffer _bb, RogueQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C03D RID: 49213 RVA: 0x002E79F1 File Offset: 0x002E5BF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C03E RID: 49214 RVA: 0x002E7A00 File Offset: 0x002E5C00
		public RogueQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002F96 RID: 12182
		// (get) Token: 0x0600C03F RID: 49215 RVA: 0x002E7A10 File Offset: 0x002E5C10
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

		// Token: 0x17002F97 RID: 12183
		// (get) Token: 0x0600C040 RID: 49216 RVA: 0x002E7A4C File Offset: 0x002E5C4C
		public string PhantomBgA
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

		// Token: 0x0600C041 RID: 49217 RVA: 0x002E7A83 File Offset: 0x002E5C83
		public Span<byte> GetPhantomBgABytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C042 RID: 49218 RVA: 0x002E7A92 File Offset: 0x002E5C92
		public byte[] GetPhantomBgAArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600C043 RID: 49219 RVA: 0x002E7AAC File Offset: 0x002E5CAC
		public string PhantomBgB
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

		// Token: 0x0600C044 RID: 49220 RVA: 0x002E7AE3 File Offset: 0x002E5CE3
		public Span<byte> GetPhantomBgBBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C045 RID: 49221 RVA: 0x002E7AF2 File Offset: 0x002E5CF2
		public byte[] GetPhantomBgBArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600C046 RID: 49222 RVA: 0x002E7B0C File Offset: 0x002E5D0C
		public string PhantomBgC
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

		// Token: 0x0600C047 RID: 49223 RVA: 0x002E7B44 File Offset: 0x002E5D44
		public Span<byte> GetPhantomBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C048 RID: 49224 RVA: 0x002E7B54 File Offset: 0x002E5D54
		public byte[] GetPhantomBgCArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600C049 RID: 49225 RVA: 0x002E7B6C File Offset: 0x002E5D6C
		public string TokenBg
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

		// Token: 0x0600C04A RID: 49226 RVA: 0x002E7BA4 File Offset: 0x002E5DA4
		public Span<byte> GetTokenBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C04B RID: 49227 RVA: 0x002E7BB4 File Offset: 0x002E5DB4
		public byte[] GetTokenBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F9B RID: 12187
		// (get) Token: 0x0600C04C RID: 49228 RVA: 0x002E7BCC File Offset: 0x002E5DCC
		public string TokenColor
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

		// Token: 0x0600C04D RID: 49229 RVA: 0x002E7C04 File Offset: 0x002E5E04
		public Span<byte> GetTokenColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x002E7C14 File Offset: 0x002E5E14
		public byte[] GetTokenColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600C04F RID: 49231 RVA: 0x002E7C2C File Offset: 0x002E5E2C
		public string RoleNiagaraColor
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

		// Token: 0x0600C050 RID: 49232 RVA: 0x002E7C64 File Offset: 0x002E5E64
		public Span<byte> GetRoleNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C051 RID: 49233 RVA: 0x002E7C74 File Offset: 0x002E5E74
		public byte[] GetRoleNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040050CC RID: 20684
		private Table __p;
	}
}
