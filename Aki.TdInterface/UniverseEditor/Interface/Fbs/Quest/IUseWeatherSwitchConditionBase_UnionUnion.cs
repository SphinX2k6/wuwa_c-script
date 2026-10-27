using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004269 RID: 17001
	public class IUseWeatherSwitchConditionBase_UnionUnion
	{
		// Token: 0x170078B2 RID: 30898
		// (get) Token: 0x0601928F RID: 103055 RVA: 0x0039DC11 File Offset: 0x0039BE11
		// (set) Token: 0x06019290 RID: 103056 RVA: 0x0039DC19 File Offset: 0x0039BE19
		public IUseWeatherSwitchConditionBase_Union Type { get; set; }

		// Token: 0x170078B3 RID: 30899
		// (get) Token: 0x06019291 RID: 103057 RVA: 0x0039DC22 File Offset: 0x0039BE22
		// (set) Token: 0x06019292 RID: 103058 RVA: 0x0039DC2A File Offset: 0x0039BE2A
		public object Value { get; set; }

		// Token: 0x06019293 RID: 103059 RVA: 0x0039DC33 File Offset: 0x0039BE33
		public IUseWeatherSwitchConditionBase_UnionUnion()
		{
			this.Type = IUseWeatherSwitchConditionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019294 RID: 103060 RVA: 0x0039DC49 File Offset: 0x0039BE49
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019295 RID: 103061 RVA: 0x0039DC5B File Offset: 0x0039BE5B
		public IUseWeatherSwitchConditionBaseT AsIUseWeatherSwitchConditionBase()
		{
			return this.As<IUseWeatherSwitchConditionBaseT>();
		}

		// Token: 0x06019296 RID: 103062 RVA: 0x0039DC63 File Offset: 0x0039BE63
		public static IUseWeatherSwitchConditionBase_UnionUnion FromIUseWeatherSwitchConditionBase(IUseWeatherSwitchConditionBaseT _iuseweatherswitchconditionbase)
		{
			return new IUseWeatherSwitchConditionBase_UnionUnion
			{
				Type = IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionBase,
				Value = _iuseweatherswitchconditionbase
			};
		}

		// Token: 0x06019297 RID: 103063 RVA: 0x0039DC78 File Offset: 0x0039BE78
		public IUseWeatherSwitchConditionSpecifiedWeatherT AsIUseWeatherSwitchConditionSpecifiedWeather()
		{
			return this.As<IUseWeatherSwitchConditionSpecifiedWeatherT>();
		}

		// Token: 0x06019298 RID: 103064 RVA: 0x0039DC80 File Offset: 0x0039BE80
		public static IUseWeatherSwitchConditionBase_UnionUnion FromIUseWeatherSwitchConditionSpecifiedWeather(IUseWeatherSwitchConditionSpecifiedWeatherT _iuseweatherswitchconditionspecifiedweather)
		{
			return new IUseWeatherSwitchConditionBase_UnionUnion
			{
				Type = IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionSpecifiedWeather,
				Value = _iuseweatherswitchconditionspecifiedweather
			};
		}

		// Token: 0x06019299 RID: 103065 RVA: 0x0039DC95 File Offset: 0x0039BE95
		public IUseWeatherSwitchConditionAnyWeatherT AsIUseWeatherSwitchConditionAnyWeather()
		{
			return this.As<IUseWeatherSwitchConditionAnyWeatherT>();
		}

		// Token: 0x0601929A RID: 103066 RVA: 0x0039DC9D File Offset: 0x0039BE9D
		public static IUseWeatherSwitchConditionBase_UnionUnion FromIUseWeatherSwitchConditionAnyWeather(IUseWeatherSwitchConditionAnyWeatherT _iuseweatherswitchconditionanyweather)
		{
			return new IUseWeatherSwitchConditionBase_UnionUnion
			{
				Type = IUseWeatherSwitchConditionBase_Union.IUseWeatherSwitchConditionAnyWeather,
				Value = _iuseweatherswitchconditionanyweather
			};
		}

		// Token: 0x0601929B RID: 103067 RVA: 0x0039DCB4 File Offset: 0x0039BEB4
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
