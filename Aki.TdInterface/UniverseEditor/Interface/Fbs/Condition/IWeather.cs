using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005220 RID: 21024
	public struct IWeather : IFlatbufferObject
	{
		// Token: 0x17009663 RID: 38499
		// (get) Token: 0x060211C3 RID: 135619 RVA: 0x00492AC6 File Offset: 0x00490CC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060211C4 RID: 135620 RVA: 0x00492AD3 File Offset: 0x00490CD3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060211C5 RID: 135621 RVA: 0x00492ADC File Offset: 0x00490CDC
		public static IWeather GetRootAsIWeather(ByteBuffer _bb)
		{
			return IWeather.GetRootAsIWeather(_bb, default(IWeather));
		}

		// Token: 0x060211C6 RID: 135622 RVA: 0x00492AF8 File Offset: 0x00490CF8
		public static IWeather GetRootAsIWeather(ByteBuffer _bb, IWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060211C7 RID: 135623 RVA: 0x00492B15 File Offset: 0x00490D15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060211C8 RID: 135624 RVA: 0x00492B24 File Offset: 0x00490D24
		public IWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009664 RID: 38500
		// (get) Token: 0x060211C9 RID: 135625 RVA: 0x00492B34 File Offset: 0x00490D34
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

		// Token: 0x17009665 RID: 38501
		// (get) Token: 0x060211CA RID: 135626 RVA: 0x00492B70 File Offset: 0x00490D70
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

		// Token: 0x17009666 RID: 38502
		// (get) Token: 0x060211CB RID: 135627 RVA: 0x00492BAC File Offset: 0x00490DAC
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

		// Token: 0x17009667 RID: 38503
		// (get) Token: 0x060211CC RID: 135628 RVA: 0x00492BE8 File Offset: 0x00490DE8
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

		// Token: 0x17009668 RID: 38504
		// (get) Token: 0x060211CD RID: 135629 RVA: 0x00492C28 File Offset: 0x00490E28
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

		// Token: 0x060211CE RID: 135630 RVA: 0x00492C65 File Offset: 0x00490E65
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

		// Token: 0x060211CF RID: 135631 RVA: 0x00492C99 File Offset: 0x00490E99
		public static void StartIWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060211D0 RID: 135632 RVA: 0x00492CA2 File Offset: 0x00490EA2
		public static void AddType(FlatBufferBuilder builder, EVisibleCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060211D1 RID: 135633 RVA: 0x00492CAD File Offset: 0x00490EAD
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x060211D2 RID: 135634 RVA: 0x00492CB8 File Offset: 0x00490EB8
		public static void AddWeather(FlatBufferBuilder builder, EWeather weather)
		{
			builder.AddByte(2, (byte)weather, 0);
		}

		// Token: 0x060211D3 RID: 135635 RVA: 0x00492CC3 File Offset: 0x00490EC3
		public static void AddWeatherId(FlatBufferBuilder builder, int weatherId)
		{
			builder.AddInt(3, weatherId, 0);
		}

		// Token: 0x060211D4 RID: 135636 RVA: 0x00492CCE File Offset: 0x00490ECE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060211D5 RID: 135637 RVA: 0x00492CD9 File Offset: 0x00490ED9
		public static Offset<IWeather> EndIWeather(FlatBufferBuilder builder)
		{
			return new Offset<IWeather>(builder.EndTable());
		}

		// Token: 0x060211D6 RID: 135638 RVA: 0x00492CE8 File Offset: 0x00490EE8
		public IWeatherT UnPack()
		{
			IWeatherT weatherT = new IWeatherT();
			this.UnPackTo(weatherT);
			return weatherT;
		}

		// Token: 0x060211D7 RID: 135639 RVA: 0x00492D03 File Offset: 0x00490F03
		public void UnPackTo(IWeatherT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Weather = this.Weather;
			_o.WeatherId = this.WeatherId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060211D8 RID: 135640 RVA: 0x00492D44 File Offset: 0x00490F44
		public static Offset<IWeather> Pack(FlatBufferBuilder builder, IWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeather>);
			}
			return IWeather.CreateIWeather(builder, _o.Type, _o.Compare, _o.Weather, _o.WeatherId, _o.NullMask);
		}

		// Token: 0x0400E23D RID: 57917
		private Table __p;
	}
}
