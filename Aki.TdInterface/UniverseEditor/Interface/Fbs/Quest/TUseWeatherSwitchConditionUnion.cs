using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004795 RID: 18325
	public class TUseWeatherSwitchConditionUnion
	{
		// Token: 0x17007FB9 RID: 32697
		// (get) Token: 0x0601AFAF RID: 110511 RVA: 0x003D2EEC File Offset: 0x003D10EC
		// (set) Token: 0x0601AFB0 RID: 110512 RVA: 0x003D2EF4 File Offset: 0x003D10F4
		public TUseWeatherSwitchCondition Type { get; set; }

		// Token: 0x17007FBA RID: 32698
		// (get) Token: 0x0601AFB1 RID: 110513 RVA: 0x003D2EFD File Offset: 0x003D10FD
		// (set) Token: 0x0601AFB2 RID: 110514 RVA: 0x003D2F05 File Offset: 0x003D1105
		public object Value { get; set; }

		// Token: 0x0601AFB3 RID: 110515 RVA: 0x003D2F0E File Offset: 0x003D110E
		public TUseWeatherSwitchConditionUnion()
		{
			this.Type = TUseWeatherSwitchCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601AFB4 RID: 110516 RVA: 0x003D2F24 File Offset: 0x003D1124
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AFB5 RID: 110517 RVA: 0x003D2F36 File Offset: 0x003D1136
		public IUseWeatherSwitchConditionAnyWeatherT AsIUseWeatherSwitchConditionAnyWeather()
		{
			return this.As<IUseWeatherSwitchConditionAnyWeatherT>();
		}

		// Token: 0x0601AFB6 RID: 110518 RVA: 0x003D2F3E File Offset: 0x003D113E
		public static TUseWeatherSwitchConditionUnion FromIUseWeatherSwitchConditionAnyWeather(IUseWeatherSwitchConditionAnyWeatherT _iuseweatherswitchconditionanyweather)
		{
			return new TUseWeatherSwitchConditionUnion
			{
				Type = TUseWeatherSwitchCondition.IUseWeatherSwitchConditionAnyWeather,
				Value = _iuseweatherswitchconditionanyweather
			};
		}

		// Token: 0x0601AFB7 RID: 110519 RVA: 0x003D2F53 File Offset: 0x003D1153
		public IUseWeatherSwitchConditionSpecifiedWeatherT AsIUseWeatherSwitchConditionSpecifiedWeather()
		{
			return this.As<IUseWeatherSwitchConditionSpecifiedWeatherT>();
		}

		// Token: 0x0601AFB8 RID: 110520 RVA: 0x003D2F5B File Offset: 0x003D115B
		public static TUseWeatherSwitchConditionUnion FromIUseWeatherSwitchConditionSpecifiedWeather(IUseWeatherSwitchConditionSpecifiedWeatherT _iuseweatherswitchconditionspecifiedweather)
		{
			return new TUseWeatherSwitchConditionUnion
			{
				Type = TUseWeatherSwitchCondition.IUseWeatherSwitchConditionSpecifiedWeather,
				Value = _iuseweatherswitchconditionspecifiedweather
			};
		}

		// Token: 0x0601AFB9 RID: 110521 RVA: 0x003D2F70 File Offset: 0x003D1170
		public static int Pack(FlatBufferBuilder builder, TUseWeatherSwitchConditionUnion _o)
		{
			TUseWeatherSwitchCondition type = _o.Type;
			if (type == TUseWeatherSwitchCondition.IUseWeatherSwitchConditionAnyWeather)
			{
				return IUseWeatherSwitchConditionAnyWeather.Pack(builder, _o.AsIUseWeatherSwitchConditionAnyWeather()).Value;
			}
			if (type != TUseWeatherSwitchCondition.IUseWeatherSwitchConditionSpecifiedWeather)
			{
				return 0;
			}
			return IUseWeatherSwitchConditionSpecifiedWeather.Pack(builder, _o.AsIUseWeatherSwitchConditionSpecifiedWeather()).Value;
		}
	}
}
