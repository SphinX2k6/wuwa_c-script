using System;
using System.Runtime.CompilerServices;

namespace System.Globalization
{
	// Token: 0x02000300 RID: 768
	[NullableContext(1)]
	[Nullable(0)]
	public class JapaneseLunisolarCalendar : EastAsianLunisolarCalendar
	{
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x000B86BE File Offset: 0x000B68BE
		public override DateTime MinSupportedDateTime
		{
			get
			{
				return JapaneseLunisolarCalendar.s_minDate;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x000B86C5 File Offset: 0x000B68C5
		public override DateTime MaxSupportedDateTime
		{
			get
			{
				return JapaneseLunisolarCalendar.s_maxDate;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x000B5750 File Offset: 0x000B3950
		protected override int DaysInYearBeforeMinSupportedYear
		{
			get
			{
				return 354;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x000B86CC File Offset: 0x000B68CC
		internal override int MinCalendarYear
		{
			get
			{
				return 1960;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x000B86D3 File Offset: 0x000B68D3
		internal override int MaxCalendarYear
		{
			get
			{
				return 2049;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x000B86BE File Offset: 0x000B68BE
		internal override DateTime MinDate
		{
			get
			{
				return JapaneseLunisolarCalendar.s_minDate;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x000B86C5 File Offset: 0x000B68C5
		internal override DateTime MaxDate
		{
			get
			{
				return JapaneseLunisolarCalendar.s_maxDate;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x000B86DA File Offset: 0x000B68DA
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal override EraInfo[] CalEraInfo
		{
			get
			{
				return JapaneseCalendar.GetEraInfo();
			}
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x000B86E4 File Offset: 0x000B68E4
		internal override int GetYearInfo(int lunarYear, int index)
		{
			if (lunarYear < 1960 || lunarYear > 2049)
			{
				throw new ArgumentOutOfRangeException("year", lunarYear, SR.Format(SR.ArgumentOutOfRange_Range, 1960, 2049));
			}
			return JapaneseLunisolarCalendar.s_yinfo[lunarYear - 1960, index];
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x000B8742 File Offset: 0x000B6942
		internal override int GetYear(int year, DateTime time)
		{
			return this._helper.GetYear(year, time);
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x000B8751 File Offset: 0x000B6951
		internal override int GetGregorianYear(int year, int era)
		{
			return this._helper.GetGregorianYear(year, era);
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x000B8760 File Offset: 0x000B6960
		private static EraInfo[] TrimEras(EraInfo[] baseEras)
		{
			EraInfo[] array = new EraInfo[baseEras.Length];
			int num = 0;
			for (int i = 0; i < baseEras.Length; i++)
			{
				if (baseEras[i].yearOffset + baseEras[i].minEraYear < 2049)
				{
					if (baseEras[i].yearOffset + baseEras[i].maxEraYear < 1960)
					{
						break;
					}
					array[num] = baseEras[i];
					num++;
				}
			}
			if (num == 0)
			{
				return baseEras;
			}
			Array.Resize<EraInfo>(ref array, num);
			return array;
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000B87CE File Offset: 0x000B69CE
		public JapaneseLunisolarCalendar()
		{
			this._helper = new GregorianCalendarHelper(this, JapaneseLunisolarCalendar.TrimEras(JapaneseCalendar.GetEraInfo()));
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x000B87EC File Offset: 0x000B69EC
		public override int GetEra(DateTime time)
		{
			return this._helper.GetEra(time);
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x0001FC46 File Offset: 0x0001DE46
		internal override CalendarId BaseCalendarID
		{
			get
			{
				return CalendarId.JAPAN;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x060037EC RID: 14316 RVA: 0x0002E978 File Offset: 0x0002CB78
		internal override CalendarId ID
		{
			get
			{
				return CalendarId.JAPANESELUNISOLAR;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x000B87FA File Offset: 0x000B69FA
		public override int[] Eras
		{
			get
			{
				return this._helper.Eras;
			}
		}

		// Token: 0x04000AEC RID: 2796
		public const int JapaneseEra = 1;

		// Token: 0x04000AED RID: 2797
		private readonly GregorianCalendarHelper _helper;

		// Token: 0x04000AEE RID: 2798
		private static readonly DateTime s_minDate = new DateTime(1960, 1, 28);

		// Token: 0x04000AEF RID: 2799
		private static readonly DateTime s_maxDate = new DateTime(new DateTime(2050, 1, 22, 23, 59, 59, 999).Ticks + 9999L);

		// Token: 0x04000AF0 RID: 2800
		private static readonly int[,] s_yinfo = new int[,]
		{
			{
				6,
				1,
				28,
				44368
			},
			{
				0,
				2,
				15,
				43856
			},
			{
				0,
				2,
				5,
				19296
			},
			{
				4,
				1,
				25,
				42352
			},
			{
				0,
				2,
				13,
				42352
			},
			{
				0,
				2,
				2,
				21104
			},
			{
				3,
				1,
				22,
				26928
			},
			{
				0,
				2,
				9,
				55632
			},
			{
				7,
				1,
				30,
				27304
			},
			{
				0,
				2,
				17,
				22176
			},
			{
				0,
				2,
				6,
				39632
			},
			{
				5,
				1,
				27,
				19176
			},
			{
				0,
				2,
				15,
				19168
			},
			{
				0,
				2,
				3,
				42208
			},
			{
				4,
				1,
				23,
				53864
			},
			{
				0,
				2,
				11,
				53840
			},
			{
				8,
				1,
				31,
				54600
			},
			{
				0,
				2,
				18,
				46400
			},
			{
				0,
				2,
				7,
				54944
			},
			{
				6,
				1,
				28,
				38608
			},
			{
				0,
				2,
				16,
				38320
			},
			{
				0,
				2,
				5,
				18864
			},
			{
				4,
				1,
				25,
				42200
			},
			{
				0,
				2,
				13,
				42160
			},
			{
				10,
				2,
				2,
				45656
			},
			{
				0,
				2,
				20,
				27216
			},
			{
				0,
				2,
				9,
				27968
			},
			{
				6,
				1,
				29,
				46504
			},
			{
				0,
				2,
				18,
				11104
			},
			{
				0,
				2,
				6,
				38320
			},
			{
				5,
				1,
				27,
				18872
			},
			{
				0,
				2,
				15,
				18800
			},
			{
				0,
				2,
				4,
				25776
			},
			{
				3,
				1,
				23,
				27216
			},
			{
				0,
				2,
				10,
				59984
			},
			{
				8,
				1,
				31,
				27976
			},
			{
				0,
				2,
				19,
				23248
			},
			{
				0,
				2,
				8,
				11104
			},
			{
				5,
				1,
				28,
				37744
			},
			{
				0,
				2,
				16,
				37600
			},
			{
				0,
				2,
				5,
				51552
			},
			{
				4,
				1,
				24,
				58536
			},
			{
				0,
				2,
				12,
				54432
			},
			{
				0,
				2,
				1,
				55888
			},
			{
				2,
				1,
				22,
				23208
			},
			{
				0,
				2,
				9,
				22208
			},
			{
				7,
				1,
				29,
				43736
			},
			{
				0,
				2,
				18,
				9680
			},
			{
				0,
				2,
				7,
				37584
			},
			{
				5,
				1,
				26,
				51544
			},
			{
				0,
				2,
				14,
				43344
			},
			{
				0,
				2,
				3,
				46240
			},
			{
				3,
				1,
				23,
				47696
			},
			{
				0,
				2,
				10,
				46416
			},
			{
				9,
				1,
				31,
				21928
			},
			{
				0,
				2,
				19,
				19360
			},
			{
				0,
				2,
				8,
				42416
			},
			{
				5,
				1,
				28,
				21176
			},
			{
				0,
				2,
				16,
				21168
			},
			{
				0,
				2,
				5,
				43344
			},
			{
				4,
				1,
				25,
				46248
			},
			{
				0,
				2,
				12,
				27296
			},
			{
				0,
				2,
				1,
				44368
			},
			{
				2,
				1,
				22,
				21928
			},
			{
				0,
				2,
				10,
				19296
			},
			{
				6,
				1,
				29,
				42352
			},
			{
				0,
				2,
				17,
				42352
			},
			{
				0,
				2,
				7,
				21104
			},
			{
				5,
				1,
				27,
				26928
			},
			{
				0,
				2,
				13,
				55600
			},
			{
				0,
				2,
				3,
				23200
			},
			{
				3,
				1,
				23,
				43856
			},
			{
				0,
				2,
				11,
				38608
			},
			{
				11,
				1,
				31,
				19176
			},
			{
				0,
				2,
				19,
				19168
			},
			{
				0,
				2,
				8,
				42192
			},
			{
				6,
				1,
				28,
				53864
			},
			{
				0,
				2,
				15,
				53840
			},
			{
				0,
				2,
				4,
				54560
			},
			{
				5,
				1,
				24,
				55968
			},
			{
				0,
				2,
				12,
				46752
			},
			{
				0,
				2,
				1,
				38608
			},
			{
				2,
				1,
				22,
				19160
			},
			{
				0,
				2,
				10,
				18864
			},
			{
				7,
				1,
				30,
				42168
			},
			{
				0,
				2,
				17,
				42160
			},
			{
				0,
				2,
				6,
				45648
			},
			{
				5,
				1,
				26,
				46376
			},
			{
				0,
				2,
				14,
				27968
			},
			{
				0,
				2,
				2,
				44448
			}
		};
	}
}
