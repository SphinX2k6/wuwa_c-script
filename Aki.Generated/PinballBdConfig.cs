using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001007 RID: 4103
	public struct PinballBdConfig : IFlatbufferObject
	{
		// Token: 0x1700295B RID: 10587
		// (get) Token: 0x0600B42F RID: 46127 RVA: 0x002DC885 File Offset: 0x002DAA85
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B430 RID: 46128 RVA: 0x002DC892 File Offset: 0x002DAA92
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x002DC89C File Offset: 0x002DAA9C
		public static PinballBdConfig GetRootAsPinballBdConfig(ByteBuffer _bb)
		{
			return PinballBdConfig.GetRootAsPinballBdConfig(_bb, default(PinballBdConfig));
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x002DC8B8 File Offset: 0x002DAAB8
		public static PinballBdConfig GetRootAsPinballBdConfig(ByteBuffer _bb, PinballBdConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x002DC8D5 File Offset: 0x002DAAD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B434 RID: 46132 RVA: 0x002DC8E4 File Offset: 0x002DAAE4
		public PinballBdConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x0600B435 RID: 46133 RVA: 0x002DC8F4 File Offset: 0x002DAAF4
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

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x0600B436 RID: 46134 RVA: 0x002DC930 File Offset: 0x002DAB30
		public string BdName
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

		// Token: 0x0600B437 RID: 46135 RVA: 0x002DC967 File Offset: 0x002DAB67
		public Span<byte> GetBdNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x002DC976 File Offset: 0x002DAB76
		public byte[] GetBdNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x0600B439 RID: 46137 RVA: 0x002DC990 File Offset: 0x002DAB90
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

		// Token: 0x0600B43A RID: 46138 RVA: 0x002DC9C7 File Offset: 0x002DABC7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B43B RID: 46139 RVA: 0x002DC9D6 File Offset: 0x002DABD6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x0600B43C RID: 46140 RVA: 0x002DC9F0 File Offset: 0x002DABF0
		public string MiddleIcon
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

		// Token: 0x0600B43D RID: 46141 RVA: 0x002DCA28 File Offset: 0x002DAC28
		public Span<byte> GetMiddleIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x002DCA38 File Offset: 0x002DAC38
		public byte[] GetMiddleIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x0600B43F RID: 46143 RVA: 0x002DCA50 File Offset: 0x002DAC50
		public string BigIcon
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

		// Token: 0x0600B440 RID: 46144 RVA: 0x002DCA88 File Offset: 0x002DAC88
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x002DCA98 File Offset: 0x002DAC98
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x0600B442 RID: 46146 RVA: 0x002DCAB0 File Offset: 0x002DACB0
		public string BgColor
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

		// Token: 0x0600B443 RID: 46147 RVA: 0x002DCAE8 File Offset: 0x002DACE8
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x002DCAF8 File Offset: 0x002DACF8
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040055D0 RID: 21968
		private Table __p;
	}
}
