using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B7 RID: 20919
	public struct ISeasonAndWeather : IFlatbufferObject
	{
		// Token: 0x170095D1 RID: 38353
		// (get) Token: 0x06020EE5 RID: 134885 RVA: 0x0048E090 File Offset: 0x0048C290
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020EE6 RID: 134886 RVA: 0x0048E09D File Offset: 0x0048C29D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020EE7 RID: 134887 RVA: 0x0048E0A4 File Offset: 0x0048C2A4
		public static ISeasonAndWeather GetRootAsISeasonAndWeather(ByteBuffer _bb)
		{
			return ISeasonAndWeather.GetRootAsISeasonAndWeather(_bb, default(ISeasonAndWeather));
		}

		// Token: 0x06020EE8 RID: 134888 RVA: 0x0048E0C0 File Offset: 0x0048C2C0
		public static ISeasonAndWeather GetRootAsISeasonAndWeather(ByteBuffer _bb, ISeasonAndWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020EE9 RID: 134889 RVA: 0x0048E0DD File Offset: 0x0048C2DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020EEA RID: 134890 RVA: 0x0048E0EC File Offset: 0x0048C2EC
		public ISeasonAndWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095D2 RID: 38354
		// (get) Token: 0x06020EEB RID: 134891 RVA: 0x0048E0FC File Offset: 0x0048C2FC
		public EVisibleCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVisibleCondition.Weather;
				}
				return (EVisibleCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095D3 RID: 38355
		// (get) Token: 0x06020EEC RID: 134892 RVA: 0x0048E138 File Offset: 0x0048C338
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170095D4 RID: 38356
		// (get) Token: 0x06020EED RID: 134893 RVA: 0x0048E174 File Offset: 0x0048C374
		public int Season
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

		// Token: 0x170095D5 RID: 38357
		// (get) Token: 0x06020EEE RID: 134894 RVA: 0x0048E1B0 File Offset: 0x0048C3B0
		public int Weather
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

		// Token: 0x170095D6 RID: 38358
		// (get) Token: 0x06020EEF RID: 134895 RVA: 0x0048E1F0 File Offset: 0x0048C3F0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020EF0 RID: 134896 RVA: 0x0048E22D File Offset: 0x0048C42D
		public static Offset<ISeasonAndWeather> CreateISeasonAndWeather(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, int Season = 0, int Weather = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISeasonAndWeather.AddWeather(builder, Weather);
			ISeasonAndWeather.AddSeason(builder, Season);
			ISeasonAndWeather.AddNullMask(builder, NullMask);
			ISeasonAndWeather.AddCompare(builder, Compare);
			ISeasonAndWeather.AddType(builder, Type);
			return ISeasonAndWeather.EndISeasonAndWeather(builder);
		}

		// Token: 0x06020EF1 RID: 134897 RVA: 0x0048E261 File Offset: 0x0048C461
		public static void StartISeasonAndWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020EF2 RID: 134898 RVA: 0x0048E26A File Offset: 0x0048C46A
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020EF3 RID: 134899 RVA: 0x0048E275 File Offset: 0x0048C475
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020EF4 RID: 134900 RVA: 0x0048E280 File Offset: 0x0048C480
		public static void AddSeason(FlatBufferBuilder builder, int season)
		{
			builder.AddInt(2, season, 0);
		}

		// Token: 0x06020EF5 RID: 134901 RVA: 0x0048E28B File Offset: 0x0048C48B
		public static void AddWeather(FlatBufferBuilder builder, int weather)
		{
			builder.AddInt(3, weather, 0);
		}

		// Token: 0x06020EF6 RID: 134902 RVA: 0x0048E296 File Offset: 0x0048C496
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06020EF7 RID: 134903 RVA: 0x0048E2A1 File Offset: 0x0048C4A1
		public static Offset<ISeasonAndWeather> EndISeasonAndWeather(FlatBufferBuilder builder)
		{
			return new Offset<ISeasonAndWeather>(builder.EndTable());
		}

		// Token: 0x06020EF8 RID: 134904 RVA: 0x0048E2B0 File Offset: 0x0048C4B0
		public ISeasonAndWeatherT UnPack()
		{
			ISeasonAndWeatherT seasonAndWeatherT = new ISeasonAndWeatherT();
			this.UnPackTo(seasonAndWeatherT);
			return seasonAndWeatherT;
		}

		// Token: 0x06020EF9 RID: 134905 RVA: 0x0048E2CB File Offset: 0x0048C4CB
		public void UnPackTo(ISeasonAndWeatherT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Season = this.Season;
			_o.Weather = this.Weather;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06020EFA RID: 134906 RVA: 0x0048E30C File Offset: 0x0048C50C
		public static Offset<ISeasonAndWeather> Pack(FlatBufferBuilder builder, ISeasonAndWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISeasonAndWeather>);
			}
			return ISeasonAndWeather.CreateISeasonAndWeather(builder, _o.Type, _o.Compare, _o.Season, _o.Weather, _o.NullMask);
		}

		// Token: 0x0400E1AB RID: 57771
		private Table __p;
	}
}
