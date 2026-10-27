using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D16 RID: 19734
	public class IVisibleCondition_UnionUnion
	{
		// Token: 0x17008F1B RID: 36635
		// (get) Token: 0x0601F51E RID: 128286 RVA: 0x0045E22E File Offset: 0x0045C42E
		// (set) Token: 0x0601F51F RID: 128287 RVA: 0x0045E236 File Offset: 0x0045C436
		public IVisibleCondition_Union Type { get; set; }

		// Token: 0x17008F1C RID: 36636
		// (get) Token: 0x0601F520 RID: 128288 RVA: 0x0045E23F File Offset: 0x0045C43F
		// (set) Token: 0x0601F521 RID: 128289 RVA: 0x0045E247 File Offset: 0x0045C447
		public object Value { get; set; }

		// Token: 0x0601F522 RID: 128290 RVA: 0x0045E250 File Offset: 0x0045C450
		public IVisibleCondition_UnionUnion()
		{
			this.Type = IVisibleCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601F523 RID: 128291 RVA: 0x0045E266 File Offset: 0x0045C466
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F524 RID: 128292 RVA: 0x0045E278 File Offset: 0x0045C478
		public IVisibleConditionT AsIVisibleCondition()
		{
			return this.As<IVisibleConditionT>();
		}

		// Token: 0x0601F525 RID: 128293 RVA: 0x0045E280 File Offset: 0x0045C480
		public static IVisibleCondition_UnionUnion FromIVisibleCondition(IVisibleConditionT _ivisiblecondition)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IVisibleCondition,
				Value = _ivisiblecondition
			};
		}

		// Token: 0x0601F526 RID: 128294 RVA: 0x0045E295 File Offset: 0x0045C495
		public IWeatherT AsIWeather()
		{
			return this.As<IWeatherT>();
		}

		// Token: 0x0601F527 RID: 128295 RVA: 0x0045E29D File Offset: 0x0045C49D
		public static IVisibleCondition_UnionUnion FromIWeather(IWeatherT _iweather)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IWeather,
				Value = _iweather
			};
		}

		// Token: 0x0601F528 RID: 128296 RVA: 0x0045E2B2 File Offset: 0x0045C4B2
		public ITimePeriodT AsITimePeriod()
		{
			return this.As<ITimePeriodT>();
		}

		// Token: 0x0601F529 RID: 128297 RVA: 0x0045E2BA File Offset: 0x0045C4BA
		public static IVisibleCondition_UnionUnion FromITimePeriod(ITimePeriodT _itimeperiod)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ITimePeriod,
				Value = _itimeperiod
			};
		}

		// Token: 0x0601F52A RID: 128298 RVA: 0x0045E2CF File Offset: 0x0045C4CF
		public IPreQuestT AsIPreQuest()
		{
			return this.As<IPreQuestT>();
		}

		// Token: 0x0601F52B RID: 128299 RVA: 0x0045E2D7 File Offset: 0x0045C4D7
		public static IVisibleCondition_UnionUnion FromIPreQuest(IPreQuestT _iprequest)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IPreQuest,
				Value = _iprequest
			};
		}

		// Token: 0x0601F52C RID: 128300 RVA: 0x0045E2EC File Offset: 0x0045C4EC
		public IPreChildQuestT AsIPreChildQuest()
		{
			return this.As<IPreChildQuestT>();
		}

		// Token: 0x0601F52D RID: 128301 RVA: 0x0045E2F4 File Offset: 0x0045C4F4
		public static IVisibleCondition_UnionUnion FromIPreChildQuest(IPreChildQuestT _iprechildquest)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IPreChildQuest,
				Value = _iprechildquest
			};
		}

		// Token: 0x0601F52E RID: 128302 RVA: 0x0045E309 File Offset: 0x0045C509
		public IClockT AsIClock()
		{
			return this.As<IClockT>();
		}

		// Token: 0x0601F52F RID: 128303 RVA: 0x0045E311 File Offset: 0x0045C511
		public static IVisibleCondition_UnionUnion FromIClock(IClockT _iclock)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IClock,
				Value = _iclock
			};
		}

		// Token: 0x0601F530 RID: 128304 RVA: 0x0045E326 File Offset: 0x0045C526
		public ICompareVarT AsICompareVar()
		{
			return this.As<ICompareVarT>();
		}

		// Token: 0x0601F531 RID: 128305 RVA: 0x0045E32E File Offset: 0x0045C52E
		public static IVisibleCondition_UnionUnion FromICompareVar(ICompareVarT _icomparevar)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ICompareVar,
				Value = _icomparevar
			};
		}

		// Token: 0x0601F532 RID: 128306 RVA: 0x0045E343 File Offset: 0x0045C543
		public ITargetEntityInvisibleT AsITargetEntityInvisible()
		{
			return this.As<ITargetEntityInvisibleT>();
		}

		// Token: 0x0601F533 RID: 128307 RVA: 0x0045E34B File Offset: 0x0045C54B
		public static IVisibleCondition_UnionUnion FromITargetEntityInvisible(ITargetEntityInvisibleT _itargetentityinvisible)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ITargetEntityInvisible,
				Value = _itargetentityinvisible
			};
		}

		// Token: 0x0601F534 RID: 128308 RVA: 0x0045E360 File Offset: 0x0045C560
		public static int Pack(FlatBufferBuilder builder, IVisibleCondition_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisibleCondition_Union.IVisibleCondition:
				return IVisibleCondition.Pack(builder, _o.AsIVisibleCondition()).Value;
			case IVisibleCondition_Union.IWeather:
				return IWeather.Pack(builder, _o.AsIWeather()).Value;
			case IVisibleCondition_Union.ITimePeriod:
				return ITimePeriod.Pack(builder, _o.AsITimePeriod()).Value;
			case IVisibleCondition_Union.IPreQuest:
				return IPreQuest.Pack(builder, _o.AsIPreQuest()).Value;
			case IVisibleCondition_Union.IPreChildQuest:
				return IPreChildQuest.Pack(builder, _o.AsIPreChildQuest()).Value;
			case IVisibleCondition_Union.IClock:
				return IClock.Pack(builder, _o.AsIClock()).Value;
			case IVisibleCondition_Union.ICompareVar:
				return ICompareVar.Pack(builder, _o.AsICompareVar()).Value;
			case IVisibleCondition_Union.ITargetEntityInvisible:
				return ITargetEntityInvisible.Pack(builder, _o.AsITargetEntityInvisible()).Value;
			default:
				return 0;
			}
		}
	}
}
