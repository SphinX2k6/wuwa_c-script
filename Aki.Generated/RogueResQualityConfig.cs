using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200100F RID: 4111
	public struct RogueResQualityConfig : IFlatbufferObject
	{
		// Token: 0x170030AB RID: 12459
		// (get) Token: 0x0600C398 RID: 50072 RVA: 0x002EF0E9 File Offset: 0x002ED2E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x002EF0F6 File Offset: 0x002ED2F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x002EF100 File Offset: 0x002ED300
		public static RogueResQualityConfig GetRootAsRogueResQualityConfig(ByteBuffer _bb)
		{
			return RogueResQualityConfig.GetRootAsRogueResQualityConfig(_bb, default(RogueResQualityConfig));
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x002EF11C File Offset: 0x002ED31C
		public static RogueResQualityConfig GetRootAsRogueResQualityConfig(ByteBuffer _bb, RogueResQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x002EF139 File Offset: 0x002ED339
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C39D RID: 50077 RVA: 0x002EF148 File Offset: 0x002ED348
		public RogueResQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030AC RID: 12460
		// (get) Token: 0x0600C39E RID: 50078 RVA: 0x002EF158 File Offset: 0x002ED358
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

		// Token: 0x170030AD RID: 12461
		// (get) Token: 0x0600C39F RID: 50079 RVA: 0x002EF194 File Offset: 0x002ED394
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

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x002EF1CB File Offset: 0x002ED3CB
		public Span<byte> GetPhantomBgABytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x002EF1DA File Offset: 0x002ED3DA
		public byte[] GetPhantomBgAArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170030AE RID: 12462
		// (get) Token: 0x0600C3A2 RID: 50082 RVA: 0x002EF1F4 File Offset: 0x002ED3F4
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

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x002EF22B File Offset: 0x002ED42B
		public Span<byte> GetPhantomBgBBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x002EF23A File Offset: 0x002ED43A
		public byte[] GetPhantomBgBArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170030AF RID: 12463
		// (get) Token: 0x0600C3A5 RID: 50085 RVA: 0x002EF254 File Offset: 0x002ED454
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

		// Token: 0x0600C3A6 RID: 50086 RVA: 0x002EF28C File Offset: 0x002ED48C
		public Span<byte> GetPhantomBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x002EF29C File Offset: 0x002ED49C
		public byte[] GetPhantomBgCArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B0 RID: 12464
		// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x002EF2B4 File Offset: 0x002ED4B4
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

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x002EF2EC File Offset: 0x002ED4EC
		public Span<byte> GetTokenBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x002EF2FC File Offset: 0x002ED4FC
		public byte[] GetTokenBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B1 RID: 12465
		// (get) Token: 0x0600C3AB RID: 50091 RVA: 0x002EF314 File Offset: 0x002ED514
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

		// Token: 0x0600C3AC RID: 50092 RVA: 0x002EF34C File Offset: 0x002ED54C
		public Span<byte> GetTokenColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x002EF35C File Offset: 0x002ED55C
		public byte[] GetTokenColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170030B2 RID: 12466
		// (get) Token: 0x0600C3AE RID: 50094 RVA: 0x002EF374 File Offset: 0x002ED574
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

		// Token: 0x0600C3AF RID: 50095 RVA: 0x002EF3AC File Offset: 0x002ED5AC
		public Span<byte> GetRoleNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x002EF3BC File Offset: 0x002ED5BC
		public byte[] GetRoleNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x040050FC RID: 20732
		private Table __p;
	}
}
