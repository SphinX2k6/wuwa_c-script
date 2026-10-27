using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004333 RID: 17203
	public class TUseWeatherSwitchConditionUnion
	{
		// Token: 0x17007984 RID: 31108
		// (get) Token: 0x06019821 RID: 104481 RVA: 0x003A74C4 File Offset: 0x003A56C4
		// (set) Token: 0x06019822 RID: 104482 RVA: 0x003A74CC File Offset: 0x003A56CC
		public TUseWeatherSwitchCondition Type { get; set; }

		// Token: 0x17007985 RID: 31109
		// (get) Token: 0x06019823 RID: 104483 RVA: 0x003A74D5 File Offset: 0x003A56D5
		// (set) Token: 0x06019824 RID: 104484 RVA: 0x003A74DD File Offset: 0x003A56DD
		public object Value { get; set; }

		// Token: 0x06019825 RID: 104485 RVA: 0x003A74E6 File Offset: 0x003A56E6
		public TUseWeatherSwitchConditionUnion()
		{
			this.Type = TUseWeatherSwitchCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06019826 RID: 104486 RVA: 0x003A74FC File Offset: 0x003A56FC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019827 RID: 104487 RVA: 0x003A750E File Offset: 0x003A570E
		public IUseWeatherSwitchConditionAnyWeatherT AsIUseWeatherSwitchConditionAnyWeather()
		{
			return this.As<IUseWeatherSwitchConditionAnyWeatherT>();
		}

		// Token: 0x06019828 RID: 104488 RVA: 0x003A7516 File Offset: 0x003A5716
		public static TUseWeatherSwitchConditionUnion FromIUseWeatherSwitchConditionAnyWeather(IUseWeatherSwitchConditionAnyWeatherT _iuseweatherswitchconditionanyweather)
		{
			return new TUseWeatherSwitchConditionUnion
			{
				Type = TUseWeatherSwitchCondition.IUseWeatherSwitchConditionAnyWeather,
				Value = _iuseweatherswitchconditionanyweather
			};
		}

		// Token: 0x06019829 RID: 104489 RVA: 0x003A752B File Offset: 0x003A572B
		public IUseWeatherSwitchConditionSpecifiedWeatherT AsIUseWeatherSwitchConditionSpecifiedWeather()
		{
			return this.As<IUseWeatherSwitchConditionSpecifiedWeatherT>();
		}

		// Token: 0x0601982A RID: 104490 RVA: 0x003A7533 File Offset: 0x003A5733
		public static TUseWeatherSwitchConditionUnion FromIUseWeatherSwitchConditionSpecifiedWeather(IUseWeatherSwitchConditionSpecifiedWeatherT _iuseweatherswitchconditionspecifiedweather)
		{
			return new TUseWeatherSwitchConditionUnion
			{
				Type = TUseWeatherSwitchCondition.IUseWeatherSwitchConditionSpecifiedWeather,
				Value = _iuseweatherswitchconditionspecifiedweather
			};
		}

		// Token: 0x0601982B RID: 104491 RVA: 0x003A7548 File Offset: 0x003A5748
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
