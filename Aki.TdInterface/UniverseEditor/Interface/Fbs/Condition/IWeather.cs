using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D24 RID: 19748
	public struct IWeather : IFlatbufferObject
	{
		// Token: 0x17008F2A RID: 36650
		// (get) Token: 0x0601F57C RID: 128380 RVA: 0x0045EB36 File Offset: 0x0045CD36
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F57D RID: 128381 RVA: 0x0045EB43 File Offset: 0x0045CD43
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F57E RID: 128382 RVA: 0x0045EB4C File Offset: 0x0045CD4C
		public static IWeather GetRootAsIWeather(ByteBuffer _bb)
		{
			return IWeather.GetRootAsIWeather(_bb, default(IWeather));
		}

		// Token: 0x0601F57F RID: 128383 RVA: 0x0045EB68 File Offset: 0x0045CD68
		public static IWeather GetRootAsIWeather(ByteBuffer _bb, IWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F580 RID: 128384 RVA: 0x0045EB85 File Offset: 0x0045CD85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F581 RID: 128385 RVA: 0x0045EB94 File Offset: 0x0045CD94
		public IWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F2B RID: 36651
		// (get) Token: 0x0601F582 RID: 128386 RVA: 0x0045EBA4 File Offset: 0x0045CDA4
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

		// Token: 0x17008F2C RID: 36652
		// (get) Token: 0x0601F583 RID: 128387 RVA: 0x0045EBE0 File Offset: 0x0045CDE0
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

		// Token: 0x17008F2D RID: 36653
		// (get) Token: 0x0601F584 RID: 128388 RVA: 0x0045EC1C File Offset: 0x0045CE1C
		public EWeather Weather
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EWeather.Sunny;
				}
				return (EWeather)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F2E RID: 36654
		// (get) Token: 0x0601F585 RID: 128389 RVA: 0x0045EC58 File Offset: 0x0045CE58
		public int WeatherId
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

		// Token: 0x17008F2F RID: 36655
		// (get) Token: 0x0601F586 RID: 128390 RVA: 0x0045EC98 File Offset: 0x0045CE98
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

		// Token: 0x0601F587 RID: 128391 RVA: 0x0045ECD5 File Offset: 0x0045CED5
		public static Offset<IWeather> CreateIWeather(FlatBufferBuilder builder, EVisibleCondition Type = EVisibleCondition.Weather, ECompare Compare = ECompare.Eq, EWeather Weather = EWeather.Sunny, int WeatherId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IWeather.AddWeatherId(builder, WeatherId);
			IWeather.AddNullMask(builder, NullMask);
			IWeather.AddWeather(builder, Weather);
			IWeather.AddCompare(builder, Compare);
			IWeather.AddType(builder, Type);
			return IWeather.EndIWeather(builder);
		}

		// Token: 0x0601F588 RID: 128392 RVA: 0x0045ED09 File Offset: 0x0045CF09
		public static void StartIWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0601F589 RID: 128393 RVA: 0x0045ED12 File Offset: 0x0045CF12
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F58A RID: 128394 RVA: 0x0045ED1D File Offset: 0x0045CF1D
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601F58B RID: 128395 RVA: 0x0045ED28 File Offset: 0x0045CF28
		public static void AddWeather(FlatBufferBuilder builder, EWeather weather)
		{
			builder.AddByte(2, (byte)weather, 0);
		}

		// Token: 0x0601F58C RID: 128396 RVA: 0x0045ED33 File Offset: 0x0045CF33
		public static void AddWeatherId(FlatBufferBuilder builder, int weatherId)
		{
			builder.AddInt(3, weatherId, 0);
		}

		// Token: 0x0601F58D RID: 128397 RVA: 0x0045ED3E File Offset: 0x0045CF3E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0601F58E RID: 128398 RVA: 0x0045ED49 File Offset: 0x0045CF49
		public static Offset<IWeather> EndIWeather(FlatBufferBuilder builder)
		{
			return new Offset<IWeather>(builder.EndTable());
		}

		// Token: 0x0601F58F RID: 128399 RVA: 0x0045ED58 File Offset: 0x0045CF58
		public IWeatherT UnPack()
		{
			IWeatherT weatherT = new IWeatherT();
			this.UnPackTo(weatherT);
			return weatherT;
		}

		// Token: 0x0601F590 RID: 128400 RVA: 0x0045ED73 File Offset: 0x0045CF73
		public void UnPackTo(IWeatherT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Weather = this.Weather;
			_o.WeatherId = this.WeatherId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601F591 RID: 128401 RVA: 0x0045EDB4 File Offset: 0x0045CFB4
		public static Offset<IWeather> Pack(FlatBufferBuilder builder, IWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeather>);
			}
			return IWeather.CreateIWeather(builder, _o.Type, _o.Compare, _o.Weather, _o.WeatherId, _o.NullMask);
		}

		// Token: 0x0400D70F RID: 55055
		private Table __p;
	}
}
