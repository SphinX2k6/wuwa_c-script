using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011DB RID: 4571
	public struct SolarSchoolDatePeriod : IFlatbufferObject
	{
		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x0600E051 RID: 57425 RVA: 0x0033E865 File Offset: 0x0033CA65
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x0033E872 File Offset: 0x0033CA72
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E053 RID: 57427 RVA: 0x0033E87C File Offset: 0x0033CA7C
		public static SolarSchoolDatePeriod GetRootAsSolarSchoolDatePeriod(ByteBuffer _bb)
		{
			return SolarSchoolDatePeriod.GetRootAsSolarSchoolDatePeriod(_bb, default(SolarSchoolDatePeriod));
		}

		// Token: 0x0600E054 RID: 57428 RVA: 0x0033E898 File Offset: 0x0033CA98
		public static SolarSchoolDatePeriod GetRootAsSolarSchoolDatePeriod(ByteBuffer _bb, SolarSchoolDatePeriod obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E055 RID: 57429 RVA: 0x0033E8B5 File Offset: 0x0033CAB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E056 RID: 57430 RVA: 0x0033E8C4 File Offset: 0x0033CAC4
		public SolarSchoolDatePeriod __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x0600E057 RID: 57431 RVA: 0x0033E8D4 File Offset: 0x0033CAD4
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

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x0600E058 RID: 57432 RVA: 0x0033E910 File Offset: 0x0033CB10
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

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x0600E059 RID: 57433 RVA: 0x0033E94C File Offset: 0x0033CB4C
		public string Name
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

		// Token: 0x0600E05A RID: 57434 RVA: 0x0033E983 File Offset: 0x0033CB83
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E05B RID: 57435 RVA: 0x0033E992 File Offset: 0x0033CB92
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600E05C RID: 57436 RVA: 0x0033E9AC File Offset: 0x0033CBAC
		public int StartDayIndex
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

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x0600E05D RID: 57437 RVA: 0x0033E9EC File Offset: 0x0033CBEC
		public int EndDayIndex
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x0600E05E RID: 57438 RVA: 0x0033EA2C File Offset: 0x0033CC2C
		public string SaveSlotTex
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

		// Token: 0x0600E05F RID: 57439 RVA: 0x0033EA64 File Offset: 0x0033CC64
		public Span<byte> GetSaveSlotTexBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E060 RID: 57440 RVA: 0x0033EA74 File Offset: 0x0033CC74
		public byte[] GetSaveSlotTexArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x0600E061 RID: 57441 RVA: 0x0033EA8C File Offset: 0x0033CC8C
		public string SeasonFxRes
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

		// Token: 0x0600E062 RID: 57442 RVA: 0x0033EAC4 File Offset: 0x0033CCC4
		public Span<byte> GetSeasonFxResBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E063 RID: 57443 RVA: 0x0033EAD4 File Offset: 0x0033CCD4
		public byte[] GetSeasonFxResArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x0033EAEC File Offset: 0x0033CCEC
		public string MapSeasonRes
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

		// Token: 0x0600E065 RID: 57445 RVA: 0x0033EB24 File Offset: 0x0033CD24
		public Span<byte> GetMapSeasonResBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x0033EB34 File Offset: 0x0033CD34
		public byte[] GetMapSeasonResArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x0600E067 RID: 57447 RVA: 0x0033EB4C File Offset: 0x0033CD4C
		public string BgmState
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E068 RID: 57448 RVA: 0x0033EB84 File Offset: 0x0033CD84
		public Span<byte> GetBgmStateBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E069 RID: 57449 RVA: 0x0033EB94 File Offset: 0x0033CD94
		public byte[] GetBgmStateArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x0600E06A RID: 57450 RVA: 0x0033EBAC File Offset: 0x0033CDAC
		public string AudioState
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E06B RID: 57451 RVA: 0x0033EBE4 File Offset: 0x0033CDE4
		public Span<byte> GetAudioStateBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x0033EBF4 File Offset: 0x0033CDF4
		public byte[] GetAudioStateArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005818 RID: 22552
		private Table __p;
	}
}
