using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426B RID: 17003
	public struct IUseWeatherSwitchConditionSpecifiedWeather : IFlatbufferObject
	{
		// Token: 0x170078B4 RID: 30900
		// (get) Token: 0x0601929D RID: 103069 RVA: 0x0039DD5C File Offset: 0x0039BF5C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601929E RID: 103070 RVA: 0x0039DD69 File Offset: 0x0039BF69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601929F RID: 103071 RVA: 0x0039DD70 File Offset: 0x0039BF70
		public static IUseWeatherSwitchConditionSpecifiedWeather GetRootAsIUseWeatherSwitchConditionSpecifiedWeather(ByteBuffer _bb)
		{
			return IUseWeatherSwitchConditionSpecifiedWeather.GetRootAsIUseWeatherSwitchConditionSpecifiedWeather(_bb, default(IUseWeatherSwitchConditionSpecifiedWeather));
		}

		// Token: 0x060192A0 RID: 103072 RVA: 0x0039DD8C File Offset: 0x0039BF8C
		public static IUseWeatherSwitchConditionSpecifiedWeather GetRootAsIUseWeatherSwitchConditionSpecifiedWeather(ByteBuffer _bb, IUseWeatherSwitchConditionSpecifiedWeather obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060192A1 RID: 103073 RVA: 0x0039DDA9 File Offset: 0x0039BFA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060192A2 RID: 103074 RVA: 0x0039DDB8 File Offset: 0x0039BFB8
		public IUseWeatherSwitchConditionSpecifiedWeather __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078B5 RID: 30901
		// (get) Token: 0x060192A3 RID: 103075 RVA: 0x0039DDC8 File Offset: 0x0039BFC8
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

		// Token: 0x170078B6 RID: 30902
		// (get) Token: 0x060192A4 RID: 103076 RVA: 0x0039DE04 File Offset: 0x0039C004
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

		// Token: 0x060192A5 RID: 103077 RVA: 0x0039DE40 File Offset: 0x0039C040
		public static Offset<IUseWeatherSwitchConditionSpecifiedWeather> CreateIUseWeatherSwitchConditionSpecifiedWeather(FlatBufferBuilder builder, EUseWeatherSwitchCheckType Type = EUseWeatherSwitchCheckType.SpecifiedWeather, int WeatherSwitchId = 0)
		{
			builder.StartTable(2);
			IUseWeatherSwitchConditionSpecifiedWeather.AddWeatherSwitchId(builder, WeatherSwitchId);
			IUseWeatherSwitchConditionSpecifiedWeather.AddType(builder, Type);
			return IUseWeatherSwitchConditionSpecifiedWeather.EndIUseWeatherSwitchConditionSpecifiedWeather(builder);
		}

		// Token: 0x060192A6 RID: 103078 RVA: 0x0039DE5D File Offset: 0x0039C05D
		public static void StartIUseWeatherSwitchConditionSpecifiedWeather(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060192A7 RID: 103079 RVA: 0x0039DE66 File Offset: 0x0039C066
		public static void AddType(FlatBufferBuilder builder, EUseWeatherSwitchCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060192A8 RID: 103080 RVA: 0x0039DE71 File Offset: 0x0039C071
		public static void AddWeatherSwitchId(FlatBufferBuilder builder, int weatherSwitchId)
		{
			builder.AddInt(1, weatherSwitchId, 0);
		}

		// Token: 0x060192A9 RID: 103081 RVA: 0x0039DE7C File Offset: 0x0039C07C
		public static Offset<IUseWeatherSwitchConditionSpecifiedWeather> EndIUseWeatherSwitchConditionSpecifiedWeather(FlatBufferBuilder builder)
		{
			return new Offset<IUseWeatherSwitchConditionSpecifiedWeather>(builder.EndTable());
		}

		// Token: 0x060192AA RID: 103082 RVA: 0x0039DE8C File Offset: 0x0039C08C
		public IUseWeatherSwitchConditionSpecifiedWeatherT UnPack()
		{
			IUseWeatherSwitchConditionSpecifiedWeatherT useWeatherSwitchConditionSpecifiedWeatherT = new IUseWeatherSwitchConditionSpecifiedWeatherT();
			this.UnPackTo(useWeatherSwitchConditionSpecifiedWeatherT);
			return useWeatherSwitchConditionSpecifiedWeatherT;
		}

		// Token: 0x060192AB RID: 103083 RVA: 0x0039DEA7 File Offset: 0x0039C0A7
		public void UnPackTo(IUseWeatherSwitchConditionSpecifiedWeatherT _o)
		{
			_o.Type = this.Type;
			_o.WeatherSwitchId = this.WeatherSwitchId;
		}

		// Token: 0x060192AC RID: 103084 RVA: 0x0039DEC4 File Offset: 0x0039C0C4
		public static Offset<IUseWeatherSwitchConditionSpecifiedWeather> Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionSpecifiedWeatherT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseWeatherSwitchConditionSpecifiedWeather>);
			}
			return IUseWeatherSwitchConditionSpecifiedWeather.CreateIUseWeatherSwitchConditionSpecifiedWeather(builder, _o.Type, _o.WeatherSwitchId);
		}

		// Token: 0x0400BEFD RID: 48893
		private Table __p;
	}
}
