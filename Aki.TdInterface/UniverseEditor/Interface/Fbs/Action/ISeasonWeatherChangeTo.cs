using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200770E RID: 30478
	public struct ISeasonWeatherChangeTo : IFlatbufferObject
	{
		// Token: 0x1700DF84 RID: 57220
		// (get) Token: 0x06035799 RID: 219033 RVA: 0x0072B932 File Offset: 0x00729B32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603579A RID: 219034 RVA: 0x0072B93F File Offset: 0x00729B3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603579B RID: 219035 RVA: 0x0072B948 File Offset: 0x00729B48
		public static ISeasonWeatherChangeTo GetRootAsISeasonWeatherChangeTo(ByteBuffer _bb)
		{
			return ISeasonWeatherChangeTo.GetRootAsISeasonWeatherChangeTo(_bb, default(ISeasonWeatherChangeTo));
		}

		// Token: 0x0603579C RID: 219036 RVA: 0x0072B964 File Offset: 0x00729B64
		public static ISeasonWeatherChangeTo GetRootAsISeasonWeatherChangeTo(ByteBuffer _bb, ISeasonWeatherChangeTo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603579D RID: 219037 RVA: 0x0072B981 File Offset: 0x00729B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603579E RID: 219038 RVA: 0x0072B990 File Offset: 0x00729B90
		public ISeasonWeatherChangeTo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF85 RID: 57221
		// (get) Token: 0x0603579F RID: 219039 RVA: 0x0072B9A0 File Offset: 0x00729BA0
		public int Season
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

		// Token: 0x1700DF86 RID: 57222
		// (get) Token: 0x060357A0 RID: 219040 RVA: 0x0072B9DC File Offset: 0x00729BDC
		public int Weather
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

		// Token: 0x1700DF87 RID: 57223
		// (get) Token: 0x060357A1 RID: 219041 RVA: 0x0072BA18 File Offset: 0x00729C18
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060357A2 RID: 219042 RVA: 0x0072BA54 File Offset: 0x00729C54
		public static Offset<ISeasonWeatherChangeTo> CreateISeasonWeatherChangeTo(FlatBufferBuilder builder, int Season = 0, int Weather = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISeasonWeatherChangeTo.AddWeather(builder, Weather);
			ISeasonWeatherChangeTo.AddSeason(builder, Season);
			ISeasonWeatherChangeTo.AddNullMask(builder, NullMask);
			return ISeasonWeatherChangeTo.EndISeasonWeatherChangeTo(builder);
		}

		// Token: 0x060357A3 RID: 219043 RVA: 0x0072BA78 File Offset: 0x00729C78
		public static void StartISeasonWeatherChangeTo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060357A4 RID: 219044 RVA: 0x0072BA81 File Offset: 0x00729C81
		public static void AddSeason(FlatBufferBuilder builder, int season)
		{
			builder.AddInt(0, season, 0);
		}

		// Token: 0x060357A5 RID: 219045 RVA: 0x0072BA8C File Offset: 0x00729C8C
		public static void AddWeather(FlatBufferBuilder builder, int weather)
		{
			builder.AddInt(1, weather, 0);
		}

		// Token: 0x060357A6 RID: 219046 RVA: 0x0072BA97 File Offset: 0x00729C97
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060357A7 RID: 219047 RVA: 0x0072BAA2 File Offset: 0x00729CA2
		public static Offset<ISeasonWeatherChangeTo> EndISeasonWeatherChangeTo(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonWeatherChangeTo>(builder.EndTable());
		}

		// Token: 0x060357A8 RID: 219048 RVA: 0x0072BAB0 File Offset: 0x00729CB0
		public ISeasonWeatherChangeToT UnPack()
		{
			ISeasonWeatherChangeToT seasonWeatherChangeToT = new ISeasonWeatherChangeToT();
			this.UnPackTo(seasonWeatherChangeToT);
			return seasonWeatherChangeToT;
		}

		// Token: 0x060357A9 RID: 219049 RVA: 0x0072BACB File Offset: 0x00729CCB
		public void UnPackTo(ISeasonWeatherChangeToT _o)
		{
			_o.Season = this.Season;
			_o.Weather = this.Weather;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060357AA RID: 219050 RVA: 0x0072BAF4 File Offset: 0x00729CF4
		public static Offset<ISeasonWeatherChangeTo> Pack(FlatBufferBuilder builder, ISeasonWeatherChangeToT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonWeatherChangeTo>);
			}
			return ISeasonWeatherChangeTo.CreateISeasonWeatherChangeTo(builder, _o.Season, _o.Weather, _o.NullMask);
		}

		// Token: 0x04012927 RID: 76071
		private Table __p;
	}
}
