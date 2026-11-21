using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C5 RID: 18117
	public class IUseWeatherSwitchConditionBase_UnionUnion
	{
		// Token: 0x17007EE3 RID: 32483
		// (get) Token: 0x0601A9FB RID: 109051 RVA: 0x003C92E9 File Offset: 0x003C74E9
		// (set) Token: 0x0601A9FC RID: 109052 RVA: 0x003C92F1 File Offset: 0x003C74F1
		public IUseWeatherSwitchConditionBase_Union Type { get; set; }

		// Token: 0x17007EE4 RID: 32484
		// (get) Token: 0x0601A9FD RID: 109053 RVA: 0x003C92FA File Offset: 0x003C74FA
		// (set) Token: 0x0601A9FE RID: 109054 RVA: 0x003C9302 File Offset: 0x003C7502
		public object Value { get; set; }

		// Token: 0x0601A9FF RID: 109055 RVA: 0x003C930B File Offset: 0x003C750B
		public IUseWeatherSwitchConditionBase_UnionUnion()
		{
			this.Type = IUseWeatherSwitchConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601AA00 RID: 109056 RVA: 0x003C9321 File Offset: 0x003C7521
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AA01 RID: 109057 RVA: 0x003C9333 File Offset: 0x003C7533
		public IUseWeatherSwitchConditionBaseT AsIUseWeatherSwitchConditionBase()
		{
			return this.As<IUseWeatherSwitchConditionBaseT>();
		}

		// Token: 0x0601AA02 RID: 109058 RVA: 0x003C933B File Offset: 0x003C753B
		public static IUseWeatherSwitchConditionBase_UnionUnion FromIUseWeatherSwitchConditionBase(IUseWeatherSwitchConditionBaseT _iuseweatherswitchconditionbase)
		{
			return new IUseWeatherSwitchConditionBase_UnionUnion
			{
				Type = IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionBase,
				Value = _iuseweatherswitchconditionbase
			};
		}

		// Token: 0x0601AA03 RID: 109059 RVA: 0x003C9350 File Offset: 0x003C7550
		public IUseWeatherSwitchConditionSpecifiedWeatherT AsIUseWeatherSwitchConditionSpecifiedWeather()
		{
			return this.As<IUseWeatherSwitchConditionSpecifiedWeatherT>();
		}

		// Token: 0x0601AA04 RID: 109060 RVA: 0x003C9358 File Offset: 0x003C7558
		public static IUseWeatherSwitchConditionBase_UnionUnion FromIUseWeatherSwitchConditionSpecifiedWeather(IUseWeatherSwitchConditionSpecifiedWeatherT _iuseweatherswitchconditionspecifiedweather)
		{
			return new IUseWeatherSwitchConditionBase_UnionUnion
			{
				Type = IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionSpecifiedWeather,
				Value = _iuseweatherswitchconditionspecifiedweather
			};
		}

		// Token: 0x0601AA05 RID: 109061 RVA: 0x003C936D File Offset: 0x003C756D
		public IUseWeatherSwitchConditionAnyWeatherT AsIUseWeatherSwitchConditionAnyWeather()
		{
			return this.As<IUseWeatherSwitchConditionAnyWeatherT>();
		}

		// Token: 0x0601AA06 RID: 109062 RVA: 0x003C9375 File Offset: 0x003C7575
		public static IUseWeatherSwitchConditionBase_UnionUnion FromIUseWeatherSwitchConditionAnyWeather(IUseWeatherSwitchConditionAnyWeatherT _iuseweatherswitchconditionanyweather)
		{
			return new IUseWeatherSwitchConditionBase_UnionUnion
			{
				Type = IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionAnyWeather,
				Value = _iuseweatherswitchconditionanyweather
			};
		}

		// Token: 0x0601AA07 RID: 109063 RVA: 0x003C938C File Offset: 0x003C758C
		public static int Pack(FlatBufferBuilder builder, IUseWeatherSwitchConditionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionBase:
				return IUseWeatherSwitchConditionBase.Pack(builder, _o.AsIUseWeatherSwitchConditionBase()).Value;
			case IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionSpecifiedWeather:
				return IUseWeatherSwitchConditionSpecifiedWeather.Pack(builder, _o.AsIUseWeatherSwitchConditionSpecifiedWeather()).Value;
			case IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionAnyWeather:
				return IUseWeatherSwitchConditionAnyWeather.Pack(builder, _o.AsIUseWeatherSwitchConditionAnyWeather()).Value;
			default:
				return 0;
			}
		}
	}
}
