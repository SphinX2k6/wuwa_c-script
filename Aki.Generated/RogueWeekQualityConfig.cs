using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001119 RID: 4377
	public struct RogueWeekQualityConfig : IFlatbufferObject
	{
		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x00311A7D File Offset: 0x0030FC7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CCCD RID: 52429 RVA: 0x00311A8A File Offset: 0x0030FC8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x00311A94 File Offset: 0x0030FC94
		public static RogueWeekQualityConfig GetRootAsRogueWeekQualityConfig(ByteBuffer _bb)
		{
			return RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(_bb, default(RogueWeekQualityConfig));
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x00311AB0 File Offset: 0x0030FCB0
		public static RogueWeekQualityConfig GetRootAsRogueWeekQualityConfig(ByteBuffer _bb, RogueWeekQualityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x00311ACD File Offset: 0x0030FCCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x00311ADC File Offset: 0x0030FCDC
		public RogueWeekQualityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600CCD2 RID: 52434 RVA: 0x00311AEC File Offset: 0x0030FCEC
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

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x00311B28 File Offset: 0x0030FD28
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

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x00311B5F File Offset: 0x0030FD5F
		public Span<byte> GetPhantomBgABytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x00311B6E File Offset: 0x0030FD6E
		public byte[] GetPhantomBgAArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x00311B88 File Offset: 0x0030FD88
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

		// Token: 0x0600CCD7 RID: 52439 RVA: 0x00311BBF File Offset: 0x0030FDBF
		public Span<byte> GetPhantomBgBBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x00311BCE File Offset: 0x0030FDCE
		public byte[] GetPhantomBgBArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600CCD9 RID: 52441 RVA: 0x00311BE8 File Offset: 0x0030FDE8
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

		// Token: 0x0600CCDA RID: 52442 RVA: 0x00311C20 File Offset: 0x0030FE20
		public Span<byte> GetPhantomBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x00311C30 File Offset: 0x0030FE30
		public byte[] GetPhantomBgCArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600CCDC RID: 52444 RVA: 0x00311C48 File Offset: 0x0030FE48
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

		// Token: 0x0600CCDD RID: 52445 RVA: 0x00311C80 File Offset: 0x0030FE80
		public Span<byte> GetTokenBgBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x00311C90 File Offset: 0x0030FE90
		public byte[] GetTokenBgArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600CCDF RID: 52447 RVA: 0x00311CA8 File Offset: 0x0030FEA8
		public string TokenBgNew
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

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x00311CE0 File Offset: 0x0030FEE0
		public Span<byte> GetTokenBgNewBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x00311CF0 File Offset: 0x0030FEF0
		public byte[] GetTokenBgNewArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600CCE2 RID: 52450 RVA: 0x00311D08 File Offset: 0x0030FF08
		public string TokenColor
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

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x00311D40 File Offset: 0x0030FF40
		public Span<byte> GetTokenColorBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x00311D50 File Offset: 0x0030FF50
		public byte[] GetTokenColorArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600CCE5 RID: 52453 RVA: 0x00311D68 File Offset: 0x0030FF68
		public string RoleNiagaraColor
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x00311DA0 File Offset: 0x0030FFA0
		public Span<byte> GetRoleNiagaraColorBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x00311DB0 File Offset: 0x0030FFB0
		public byte[] GetRoleNiagaraColorArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005711 RID: 22289
		private Table __p;
	}
}
