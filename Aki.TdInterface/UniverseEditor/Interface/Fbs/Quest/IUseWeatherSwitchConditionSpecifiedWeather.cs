using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C7 RID: 18119
	public struct IUseWeatherSwitchConditionSpecifiedWeather : IFlatbufferObject
	{
		// Token: 0x17007EE5 RID: 32485
		// (get) Token: 0x0601AA09 RID: 109065 RVA: 0x003C9434 File Offset: 0x003C7634
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA0A RID: 109066 RVA: 0x003C9441 File Offset: 0x003C7641
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA0B RID: 109067 RVA: 0x003C9448 File Offset: 0x003C7648
		public static IUseWeatherSwitchConditionSpecifiedWeather GetRootAsIUseWeatherSwitchConditionSpecifiedWeather(ByteBuffer _bb)
		{
			return IUseWeatherSwitchConditionSpecifiedWeather.GetRootAsIUseWeatherSwitchConditionSpecifiedWeather(_bb, default(IUseWeatherSwitchConditionSpecifiedWeather));
		}

		// Token: 0x0601AA0C RID: 109068 RVA: 0x003C9464 File Offset: 0x003C7664
		public static IUseWeatherSwitchConditionSpecifiedWeather GetRootAsIUseWeatherSwitchConditionSpecifiedWeather(ByteBuffer _bb, IUseWeatherSwitchConditionSpecifiedWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA0D RID: 109069 RVA: 0x003C9481 File Offset: 0x003C7681
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA0E RID: 109070 RVA: 0x003C9490 File Offset: 0x003C7690
		public IUseWeatherSwitchConditionSpecifiedWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EE6 RID: 32486
		// (get) Token: 0x0601AA0F RID: 109071 RVA: 0x003C94A0 File Offset: 0x003C76A0
		public EUseWeatherSwitchCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseWeatherSwitchCheckType.SpecifiedWeather;
				}
				return (EUseWeatherSwitchCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007EE7 RID: 32487
		// (get) Token: 0x0601AA10 RID: 109072 RVA: 0x003C94DC File Offset: 0x003C76DC
		public int WeatherSwitchId
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

		// Token: 0x0601AA11 RID: 109073 RVA: 0x003C9518 File Offset: 0x003C7718
		public static Offset<IUseWeatherSwitchConditionSpecifiedWeather> CreateIUseWeatherSwitchConditionSpecifiedWeather(FlatBufferBuilder builder, EUseWeatherSwitchCheckType Type = EUseWeatherSwitchCheckType.SpecifiedWeather, int WeatherSwitchId = 0)
		{
			builder.StartTable(2);
			IUseWeatherSwitchConditionSpecifiedWeather.AddWeatherSwitchId(builder, WeatherSwitchId);
			IUseWeatherSwitchConditionSpecifiedWeather.AddType(builder, Type);
			return IUseWeatherSwitchConditionSpecifiedWeather.EndIUseWeatherSwitchConditionSpecifiedWeather(builder);
		}

		// Token: 0x0601AA12 RID: 109074 RVA: 0x003C9535 File Offset: 0x003C7735
		public static void StartIUseWeatherSwitchConditionSpecifiedWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601AA13 RID: 109075 RVA: 0x003C953E File Offset: 0x003C773E
		public static void AddType(FlatBufferBuilder builder, EUseWeatherSwitchCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA14 RID: 109076 RVA: 0x003C9549 File Offset: 0x003C7749
		public static void AddWeatherSwitchId(FlatBufferBuilder builder, int weatherSwitchId)
		{
			builder.AddInt(1, weatherSwitchId, 0);
		}

		// Token: 0x0601AA15 RID: 109077 RVA: 0x003C9554 File Offset: 0x003C7754
		public static Offset<IUseWeatherSwitchConditionSpecifiedWeather> EndIUseWeatherSwitchConditionSpecifiedWeather(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchConditionSpecifiedWeather>(builder.EndTable());
		}

		// Token: 0x0601AA16 RID: 109078 RVA: 0x003C9564 File Offset: 0x003C7764
		public IUseWeatherSwitchConditionSpecifiedWeatherT UnPack()
		{
			IUseWeatherSwitchConditionSpecifiedWeatherT useWeatherSwitchConditionSpecifiedWeatherT = new IUseWeatherSwitchConditionSpecifiedWeatherT();
			this.UnPackTo(useWeatherSwitchConditionSpecifiedWeatherT);
			return useWeatherSwitchConditionSpecifiedWeatherT;
		}

		// Token: 0x0601AA17 RID: 109079 RVA: 0x003C957F File Offset: 0x003C777F
		public void UnPackTo(IUseWeatherSwitchConditionSpecifiedWeatherT _o)
		{
			_o.Type = this.Type;
			_o.WeatherSwitchId = this.WeatherSwitchId;
		}

		// Token: 0x0601AA18 RID: 109080 RVA: 0x003C959C File Offset: 0x003C779C
		public static Offset<IUseWeatherSwitchConditionSpecifiedWeather> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionSpecifiedWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchConditionSpecifiedWeather>);
			}
			return IUseWeatherSwitchConditionSpecifiedWeather.CreateIUseWeatherSwitchConditionSpecifiedWeather(builder, _o.Type, _o.WeatherSwitchId);
		}

		// Token: 0x0400C90A RID: 51466
		private Table __p;
	}
}
