using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FC5 RID: 4037
	public struct RhythmShipPlanet : IFlatbufferObject
	{
		// Token: 0x17002E53 RID: 11859
		// (get) Token: 0x0600BCC6 RID: 48326 RVA: 0x002DFC31 File Offset: 0x002DDE31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BCC7 RID: 48327 RVA: 0x002DFC3E File Offset: 0x002DDE3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BCC8 RID: 48328 RVA: 0x002DFC48 File Offset: 0x002DDE48
		public static RhythmShipPlanet GetRootAsRhythmShipPlanet(ByteBuffer _bb)
		{
			return RhythmShipPlanet.GetRootAsRhythmShipPlanet(_bb, default(RhythmShipPlanet));
		}

		// Token: 0x0600BCC9 RID: 48329 RVA: 0x002DFC64 File Offset: 0x002DDE64
		public static RhythmShipPlanet GetRootAsRhythmShipPlanet(ByteBuffer _bb, RhythmShipPlanet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BCCA RID: 48330 RVA: 0x002DFC81 File Offset: 0x002DDE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BCCB RID: 48331 RVA: 0x002DFC90 File Offset: 0x002DDE90
		public RhythmShipPlanet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002E54 RID: 11860
		// (get) Token: 0x0600BCCC RID: 48332 RVA: 0x002DFCA0 File Offset: 0x002DDEA0
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

		// Token: 0x17002E55 RID: 11861
		// (get) Token: 0x0600BCCD RID: 48333 RVA: 0x002DFCDC File Offset: 0x002DDEDC
		public int Type
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

		// Token: 0x17002E56 RID: 11862
		// (get) Token: 0x0600BCCE RID: 48334 RVA: 0x002DFD18 File Offset: 0x002DDF18
		public int ActivityId
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

		// Token: 0x17002E57 RID: 11863
		// (get) Token: 0x0600BCCF RID: 48335 RVA: 0x002DFD54 File Offset: 0x002DDF54
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E58 RID: 11864
		// (get) Token: 0x0600BCD0 RID: 48336 RVA: 0x002DFD94 File Offset: 0x002DDF94
		public string Name
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

		// Token: 0x0600BCD1 RID: 48337 RVA: 0x002DFDCC File Offset: 0x002DDFCC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BCD2 RID: 48338 RVA: 0x002DFDDC File Offset: 0x002DDFDC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x0600BCD3 RID: 48339 RVA: 0x002DFDF4 File Offset: 0x002DDFF4
		public string BgTexture
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

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x002DFE2C File Offset: 0x002DE02C
		public Span<byte> GetBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BCD5 RID: 48341 RVA: 0x002DFE3C File Offset: 0x002DE03C
		public byte[] GetBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002E5A RID: 11866
		// (get) Token: 0x0600BCD6 RID: 48342 RVA: 0x002DFE54 File Offset: 0x002DE054
		public int LoadingId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E5B RID: 11867
		// (get) Token: 0x0600BCD7 RID: 48343 RVA: 0x002DFE94 File Offset: 0x002DE094
		public int BgId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x0600BCD8 RID: 48344 RVA: 0x002DFED4 File Offset: 0x002DE0D4
		public int LevelType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0400509F RID: 20639
		private Table __p;
	}
}
