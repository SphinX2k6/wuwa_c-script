using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005212 RID: 21010
	public class IVisibleCondition_UnionUnion
	{
		// Token: 0x17009654 RID: 38484
		// (get) Token: 0x06021163 RID: 135523 RVA: 0x0049217E File Offset: 0x0049037E
		// (set) Token: 0x06021164 RID: 135524 RVA: 0x00492186 File Offset: 0x00490386
		public IVisibleCondition_Union Type { get; set; }

		// Token: 0x17009655 RID: 38485
		// (get) Token: 0x06021165 RID: 135525 RVA: 0x0049218F File Offset: 0x0049038F
		// (set) Token: 0x06021166 RID: 135526 RVA: 0x00492197 File Offset: 0x00490397
		public object Value { get; set; }

		// Token: 0x06021167 RID: 135527 RVA: 0x004921A0 File Offset: 0x004903A0
		public IVisibleCondition_UnionUnion()
		{
			this.Type = IVisibleCondition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021168 RID: 135528 RVA: 0x004921B6 File Offset: 0x004903B6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021169 RID: 135529 RVA: 0x004921C8 File Offset: 0x004903C8
		public IVisibleConditionT AsIVisibleCondition()
		{
			return this.As<IVisibleConditionT>();
		}

		// Token: 0x0602116A RID: 135530 RVA: 0x004921D0 File Offset: 0x004903D0
		public static IVisibleCondition_UnionUnion FromIVisibleCondition(IVisibleConditionT _ivisiblecondition)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IVisibleCondition,
				Value = _ivisiblecondition
			};
		}

		// Token: 0x0602116B RID: 135531 RVA: 0x004921E5 File Offset: 0x004903E5
		public IWeatherT AsIWeather()
		{
			return this.As<IWeatherT>();
		}

		// Token: 0x0602116C RID: 135532 RVA: 0x004921ED File Offset: 0x004903ED
		public static IVisibleCondition_UnionUnion FromIWeather(IWeatherT _iweather)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IWeather,
				Value = _iweather
			};
		}

		// Token: 0x0602116D RID: 135533 RVA: 0x00492202 File Offset: 0x00490402
		public ITimePeriodT AsITimePeriod()
		{
			return this.As<ITimePeriodT>();
		}

		// Token: 0x0602116E RID: 135534 RVA: 0x0049220A File Offset: 0x0049040A
		public static IVisibleCondition_UnionUnion FromITimePeriod(ITimePeriodT _itimeperiod)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ITimePeriod,
				Value = _itimeperiod
			};
		}

		// Token: 0x0602116F RID: 135535 RVA: 0x0049221F File Offset: 0x0049041F
		public IPreQuestT AsIPreQuest()
		{
			return this.As<IPreQuestT>();
		}

		// Token: 0x06021170 RID: 135536 RVA: 0x00492227 File Offset: 0x00490427
		public static IVisibleCondition_UnionUnion FromIPreQuest(IPreQuestT _iprequest)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IPreQuest,
				Value = _iprequest
			};
		}

		// Token: 0x06021171 RID: 135537 RVA: 0x0049223C File Offset: 0x0049043C
		public IPreChildQuestT AsIPreChildQuest()
		{
			return this.As<IPreChildQuestT>();
		}

		// Token: 0x06021172 RID: 135538 RVA: 0x00492244 File Offset: 0x00490444
		public static IVisibleCondition_UnionUnion FromIPreChildQuest(IPreChildQuestT _iprechildquest)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IPreChildQuest,
				Value = _iprechildquest
			};
		}

		// Token: 0x06021173 RID: 135539 RVA: 0x00492259 File Offset: 0x00490459
		public IClockT AsIClock()
		{
			return this.As<IClockT>();
		}

		// Token: 0x06021174 RID: 135540 RVA: 0x00492261 File Offset: 0x00490461
		public static IVisibleCondition_UnionUnion FromIClock(IClockT _iclock)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.IClock,
				Value = _iclock
			};
		}

		// Token: 0x06021175 RID: 135541 RVA: 0x00492276 File Offset: 0x00490476
		public ICompareVarT AsICompareVar()
		{
			return this.As<ICompareVarT>();
		}

		// Token: 0x06021176 RID: 135542 RVA: 0x0049227E File Offset: 0x0049047E
		public static IVisibleCondition_UnionUnion FromICompareVar(ICompareVarT _icomparevar)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ICompareVar,
				Value = _icomparevar
			};
		}

		// Token: 0x06021177 RID: 135543 RVA: 0x00492293 File Offset: 0x00490493
		public ITargetEntityInvisibleT AsITargetEntityInvisible()
		{
			return this.As<ITargetEntityInvisibleT>();
		}

		// Token: 0x06021178 RID: 135544 RVA: 0x0049229B File Offset: 0x0049049B
		public static IVisibleCondition_UnionUnion FromITargetEntityInvisible(ITargetEntityInvisibleT _itargetentityinvisible)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ITargetEntityInvisible,
				Value = _itargetentityinvisible
			};
		}

		// Token: 0x06021179 RID: 135545 RVA: 0x004922B0 File Offset: 0x004904B0
		public ISeasonAndWeatherT AsISeasonAndWeather()
		{
			return this.As<ISeasonAndWeatherT>();
		}

		// Token: 0x0602117A RID: 135546 RVA: 0x004922B8 File Offset: 0x004904B8
		public static IVisibleCondition_UnionUnion FromISeasonAndWeather(ISeasonAndWeatherT _iseasonandweather)
		{
			return new IVisibleCondition_UnionUnion
			{
				Type = IVisibleCondition_Union.ISeasonAndWeather,
				Value = _iseasonandweather
			};
		}

		// Token: 0x0602117B RID: 135547 RVA: 0x004922D0 File Offset: 0x004904D0
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
			case IVisibleCondition_Union.ISeasonAndWeather:
				return ISeasonAndWeather.Pack(builder, _o.AsISeasonAndWeather()).Value;
			default:
				return 0;
			}
		}
	}
}
