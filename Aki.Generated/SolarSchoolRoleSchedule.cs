using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011FF RID: 4607
	public struct SolarSchoolRoleSchedule : IFlatbufferObject
	{
		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0600E37C RID: 58236 RVA: 0x0034599C File Offset: 0x00343B9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E37D RID: 58237 RVA: 0x003459A9 File Offset: 0x00343BA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E37E RID: 58238 RVA: 0x003459B0 File Offset: 0x00343BB0
		public static SolarSchoolRoleSchedule GetRootAsSolarSchoolRoleSchedule(ByteBuffer _bb)
		{
			return SolarSchoolRoleSchedule.GetRootAsSolarSchoolRoleSchedule(_bb, default(SolarSchoolRoleSchedule));
		}

		// Token: 0x0600E37F RID: 58239 RVA: 0x003459CC File Offset: 0x00343BCC
		public static SolarSchoolRoleSchedule GetRootAsSolarSchoolRoleSchedule(ByteBuffer _bb, SolarSchoolRoleSchedule obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E380 RID: 58240 RVA: 0x003459E9 File Offset: 0x00343BE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E381 RID: 58241 RVA: 0x003459F8 File Offset: 0x00343BF8
		public SolarSchoolRoleSchedule __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0600E382 RID: 58242 RVA: 0x00345A08 File Offset: 0x00343C08
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

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0600E383 RID: 58243 RVA: 0x00345A44 File Offset: 0x00343C44
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

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x0600E384 RID: 58244 RVA: 0x00345A80 File Offset: 0x00343C80
		public int RoleId
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

		// Token: 0x0600E385 RID: 58245 RVA: 0x00345ABC File Offset: 0x00343CBC
		public int Monday(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0600E386 RID: 58246 RVA: 0x00345AFC File Offset: 0x00343CFC
		public int MondayLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E387 RID: 58247 RVA: 0x00345B28 File Offset: 0x00343D28
		public Span<int> GetMondayBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0600E388 RID: 58248 RVA: 0x00345B38 File Offset: 0x00343D38
		public int[] GetMondayArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x0600E389 RID: 58249 RVA: 0x00345B50 File Offset: 0x00343D50
		public int Tuesday(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7B RID: 14971
		// (get) Token: 0x0600E38A RID: 58250 RVA: 0x00345B90 File Offset: 0x00343D90
		public int TuesdayLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E38B RID: 58251 RVA: 0x00345BBC File Offset: 0x00343DBC
		public Span<int> GetTuesdayBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600E38C RID: 58252 RVA: 0x00345BCC File Offset: 0x00343DCC
		public int[] GetTuesdayArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600E38D RID: 58253 RVA: 0x00345BE4 File Offset: 0x00343DE4
		public int Wednesday(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7C RID: 14972
		// (get) Token: 0x0600E38E RID: 58254 RVA: 0x00345C24 File Offset: 0x00343E24
		public int WednesdayLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E38F RID: 58255 RVA: 0x00345C50 File Offset: 0x00343E50
		public Span<int> GetWednesdayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600E390 RID: 58256 RVA: 0x00345C60 File Offset: 0x00343E60
		public int[] GetWednesdayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600E391 RID: 58257 RVA: 0x00345C78 File Offset: 0x00343E78
		public int Thursday(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0600E392 RID: 58258 RVA: 0x00345CB8 File Offset: 0x00343EB8
		public int ThursdayLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E393 RID: 58259 RVA: 0x00345CE4 File Offset: 0x00343EE4
		public Span<int> GetThursdayBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600E394 RID: 58260 RVA: 0x00345CF4 File Offset: 0x00343EF4
		public int[] GetThursdayArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600E395 RID: 58261 RVA: 0x00345D0C File Offset: 0x00343F0C
		public int Friday(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0600E396 RID: 58262 RVA: 0x00345D4C File Offset: 0x00343F4C
		public int FridayLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x00345D78 File Offset: 0x00343F78
		public Span<int> GetFridayBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x00345D88 File Offset: 0x00343F88
		public int[] GetFridayArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600E399 RID: 58265 RVA: 0x00345DA0 File Offset: 0x00343FA0
		public int Saturday(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A7F RID: 14975
		// (get) Token: 0x0600E39A RID: 58266 RVA: 0x00345DE0 File Offset: 0x00343FE0
		public int SaturdayLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E39B RID: 58267 RVA: 0x00345E0C File Offset: 0x0034400C
		public Span<int> GetSaturdayBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E39C RID: 58268 RVA: 0x00345E1C File Offset: 0x0034401C
		public int[] GetSaturdayArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E39D RID: 58269 RVA: 0x00345E34 File Offset: 0x00344034
		public int Sunday(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A80 RID: 14976
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x00345E74 File Offset: 0x00344074
		public int SundayLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E39F RID: 58271 RVA: 0x00345EA0 File Offset: 0x003440A0
		public Span<int> GetSundayBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x00345EB0 File Offset: 0x003440B0
		public int[] GetSundayArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x00345EC8 File Offset: 0x003440C8
		[NullableContext(1)]
		public int[] Friday()
		{
			return this.GetFridayArray();
		}

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00345ED0 File Offset: 0x003440D0
		[NullableContext(1)]
		public IEnumerable<int> FridayIter()
		{
			SolarSchoolRoleSchedule.<FridayIter>d__50 <FridayIter>d__ = new SolarSchoolRoleSchedule.<FridayIter>d__50(-2);
			<FridayIter>d__.<>3__<>4__this = this;
			return <FridayIter>d__;
		}

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x00345EE5 File Offset: 0x003440E5
		[NullableContext(1)]
		public int[] Monday()
		{
			return this.GetMondayArray();
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00345EED File Offset: 0x003440ED
		[NullableContext(1)]
		public IEnumerable<int> MondayIter()
		{
			SolarSchoolRoleSchedule.<MondayIter>d__52 <MondayIter>d__ = new SolarSchoolRoleSchedule.<MondayIter>d__52(-2);
			<MondayIter>d__.<>3__<>4__this = this;
			return <MondayIter>d__;
		}

		// Token: 0x0600E3A5 RID: 58277 RVA: 0x00345F02 File Offset: 0x00344102
		[NullableContext(1)]
		public int[] Saturday()
		{
			return this.GetSaturdayArray();
		}

		// Token: 0x0600E3A6 RID: 58278 RVA: 0x00345F0A File Offset: 0x0034410A
		[NullableContext(1)]
		public IEnumerable<int> SaturdayIter()
		{
			SolarSchoolRoleSchedule.<SaturdayIter>d__54 <SaturdayIter>d__ = new SolarSchoolRoleSchedule.<SaturdayIter>d__54(-2);
			<SaturdayIter>d__.<>3__<>4__this = this;
			return <SaturdayIter>d__;
		}

		// Token: 0x0600E3A7 RID: 58279 RVA: 0x00345F1F File Offset: 0x0034411F
		[NullableContext(1)]
		public int[] Sunday()
		{
			return this.GetSundayArray();
		}

		// Token: 0x0600E3A8 RID: 58280 RVA: 0x00345F27 File Offset: 0x00344127
		[NullableContext(1)]
		public IEnumerable<int> SundayIter()
		{
			SolarSchoolRoleSchedule.<SundayIter>d__56 <SundayIter>d__ = new SolarSchoolRoleSchedule.<SundayIter>d__56(-2);
			<SundayIter>d__.<>3__<>4__this = this;
			return <SundayIter>d__;
		}

		// Token: 0x0600E3A9 RID: 58281 RVA: 0x00345F3C File Offset: 0x0034413C
		[NullableContext(1)]
		public int[] Thursday()
		{
			return this.GetThursdayArray();
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x00345F44 File Offset: 0x00344144
		[NullableContext(1)]
		public IEnumerable<int> ThursdayIter()
		{
			SolarSchoolRoleSchedule.<ThursdayIter>d__58 <ThursdayIter>d__ = new SolarSchoolRoleSchedule.<ThursdayIter>d__58(-2);
			<ThursdayIter>d__.<>3__<>4__this = this;
			return <ThursdayIter>d__;
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x00345F59 File Offset: 0x00344159
		[NullableContext(1)]
		public int[] Tuesday()
		{
			return this.GetTuesdayArray();
		}

		// Token: 0x0600E3AC RID: 58284 RVA: 0x00345F61 File Offset: 0x00344161
		[NullableContext(1)]
		public IEnumerable<int> TuesdayIter()
		{
			SolarSchoolRoleSchedule.<TuesdayIter>d__60 <TuesdayIter>d__ = new SolarSchoolRoleSchedule.<TuesdayIter>d__60(-2);
			<TuesdayIter>d__.<>3__<>4__this = this;
			return <TuesdayIter>d__;
		}

		// Token: 0x0600E3AD RID: 58285 RVA: 0x00345F76 File Offset: 0x00344176
		[NullableContext(1)]
		public int[] Wednesday()
		{
			return this.GetWednesdayArray();
		}

		// Token: 0x0600E3AE RID: 58286 RVA: 0x00345F7E File Offset: 0x0034417E
		[NullableContext(1)]
		public IEnumerable<int> WednesdayIter()
		{
			SolarSchoolRoleSchedule.<WednesdayIter>d__62 <WednesdayIter>d__ = new SolarSchoolRoleSchedule.<WednesdayIter>d__62(-2);
			<WednesdayIter>d__.<>3__<>4__this = this;
			return <WednesdayIter>d__;
		}

		// Token: 0x0400583D RID: 22589
		private Table __p;
	}
}
