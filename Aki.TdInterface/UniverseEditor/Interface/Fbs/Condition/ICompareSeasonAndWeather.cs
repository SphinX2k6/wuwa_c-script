using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050AF RID: 20655
	public struct ICompareSeasonAndWeather : IFlatbufferObject
	{
		// Token: 0x170093F7 RID: 37879
		// (get) Token: 0x06020569 RID: 132457 RVA: 0x0047A9AC File Offset: 0x00478BAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602056A RID: 132458 RVA: 0x0047A9B9 File Offset: 0x00478BB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602056B RID: 132459 RVA: 0x0047A9C0 File Offset: 0x00478BC0
		public static ICompareSeasonAndWeather GetRootAsICompareSeasonAndWeather(ByteBuffer _bb)
		{
			return ICompareSeasonAndWeather.GetRootAsICompareSeasonAndWeather(_bb, default(ICompareSeasonAndWeather));
		}

		// Token: 0x0602056C RID: 132460 RVA: 0x0047A9DC File Offset: 0x00478BDC
		public static ICompareSeasonAndWeather GetRootAsICompareSeasonAndWeather(ByteBuffer _bb, ICompareSeasonAndWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602056D RID: 132461 RVA: 0x0047A9F9 File Offset: 0x00478BF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602056E RID: 132462 RVA: 0x0047AA08 File Offset: 0x00478C08
		public ICompareSeasonAndWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093F8 RID: 37880
		// (get) Token: 0x0602056F RID: 132463 RVA: 0x0047AA18 File Offset: 0x00478C18
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093F9 RID: 37881
		// (get) Token: 0x06020570 RID: 132464 RVA: 0x0047AA54 File Offset: 0x00478C54
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

		// Token: 0x170093FA RID: 37882
		// (get) Token: 0x06020571 RID: 132465 RVA: 0x0047AA90 File Offset: 0x00478C90
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

		// Token: 0x170093FB RID: 37883
		// (get) Token: 0x06020572 RID: 132466 RVA: 0x0047AACC File Offset: 0x00478CCC
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

		// Token: 0x170093FC RID: 37884
		// (get) Token: 0x06020573 RID: 132467 RVA: 0x0047AB0C File Offset: 0x00478D0C
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

		// Token: 0x06020574 RID: 132468 RVA: 0x0047AB49 File Offset: 0x00478D49
		public static Offset<ICompareSeasonAndWeather> CreateICompareSeasonAndWeather(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Season = 0, int Weather = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			ICompareSeasonAndWeather.AddWeather(builder, Weather);
			ICompareSeasonAndWeather.AddSeason(builder, Season);
			ICompareSeasonAndWeather.AddNullMask(builder, NullMask);
			ICompareSeasonAndWeather.AddCompare(builder, Compare);
			ICompareSeasonAndWeather.AddType(builder, Type);
			return ICompareSeasonAndWeather.EndICompareSeasonAndWeather(builder);
		}

		// Token: 0x06020575 RID: 132469 RVA: 0x0047AB7D File Offset: 0x00478D7D
		public static void StartICompareSeasonAndWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06020576 RID: 132470 RVA: 0x0047AB86 File Offset: 0x00478D86
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020577 RID: 132471 RVA: 0x0047AB91 File Offset: 0x00478D91
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x06020578 RID: 132472 RVA: 0x0047AB9C File Offset: 0x00478D9C
		public static void AddSeason(FlatBufferBuilder builder, int season)
		{
			builder.AddInt(2, season, 0);
		}

		// Token: 0x06020579 RID: 132473 RVA: 0x0047ABA7 File Offset: 0x00478DA7
		public static void AddWeather(FlatBufferBuilder builder, int weather)
		{
			builder.AddInt(3, weather, 0);
		}

		// Token: 0x0602057A RID: 132474 RVA: 0x0047ABB2 File Offset: 0x00478DB2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602057B RID: 132475 RVA: 0x0047ABBD File Offset: 0x00478DBD
		public static Offset<ICompareSeasonAndWeather> EndICompareSeasonAndWeather(FlatBufferBuilder builder)
		{
			return new Offset<ICompareSeasonAndWeather>(builder.EndTable());
		}

		// Token: 0x0602057C RID: 132476 RVA: 0x0047ABCC File Offset: 0x00478DCC
		public ICompareSeasonAndWeatherT UnPack()
		{
			ICompareSeasonAndWeatherT compareSeasonAndWeatherT = new ICompareSeasonAndWeatherT();
			this.UnPackTo(compareSeasonAndWeatherT);
			return compareSeasonAndWeatherT;
		}

		// Token: 0x0602057D RID: 132477 RVA: 0x0047ABE7 File Offset: 0x00478DE7
		public void UnPackTo(ICompareSeasonAndWeatherT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Season = this.Season;
			_o.Weather = this.Weather;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602057E RID: 132478 RVA: 0x0047AC28 File Offset: 0x00478E28
		public static Offset<ICompareSeasonAndWeather> Pack(FlatBufferBuilder builder, ICompareSeasonAndWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareSeasonAndWeather>);
			}
			return ICompareSeasonAndWeather.CreateICompareSeasonAndWeather(builder, _o.Type, _o.Compare, _o.Season, _o.Weather, _o.NullMask);
		}

		// Token: 0x0400DFB5 RID: 57269
		private Table __p;
	}
}
