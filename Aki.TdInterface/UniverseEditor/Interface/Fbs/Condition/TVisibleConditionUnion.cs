using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200525D RID: 21085
	public class TVisibleConditionUnion
	{
		// Token: 0x17009694 RID: 38548
		// (get) Token: 0x06021317 RID: 135959 RVA: 0x00494BAE File Offset: 0x00492DAE
		// (set) Token: 0x06021318 RID: 135960 RVA: 0x00494BB6 File Offset: 0x00492DB6
		public TVisibleCondition Type { get; set; }

		// Token: 0x17009695 RID: 38549
		// (get) Token: 0x06021319 RID: 135961 RVA: 0x00494BBF File Offset: 0x00492DBF
		// (set) Token: 0x0602131A RID: 135962 RVA: 0x00494BC7 File Offset: 0x00492DC7
		public object Value { get; set; }

		// Token: 0x0602131B RID: 135963 RVA: 0x00494BD0 File Offset: 0x00492DD0
		public TVisibleConditionUnion()
		{
			this.Type = TVisibleCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0602131C RID: 135964 RVA: 0x00494BE6 File Offset: 0x00492DE6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602131D RID: 135965 RVA: 0x00494BF8 File Offset: 0x00492DF8
		public IClockT AsIClock()
		{
			return this.As<IClockT>();
		}

		// Token: 0x0602131E RID: 135966 RVA: 0x00494C00 File Offset: 0x00492E00
		public static TVisibleConditionUnion FromIClock(IClockT _iclock)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IClock,
				Value = _iclock
			};
		}

		// Token: 0x0602131F RID: 135967 RVA: 0x00494C15 File Offset: 0x00492E15
		public ICompareVarT AsICompareVar()
		{
			return this.As<ICompareVarT>();
		}

		// Token: 0x06021320 RID: 135968 RVA: 0x00494C1D File Offset: 0x00492E1D
		public static TVisibleConditionUnion FromICompareVar(ICompareVarT _icomparevar)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ICompareVar,
				Value = _icomparevar
			};
		}

		// Token: 0x06021321 RID: 135969 RVA: 0x00494C32 File Offset: 0x00492E32
		public IPreChildQuestT AsIPreChildQuest()
		{
			return this.As<IPreChildQuestT>();
		}

		// Token: 0x06021322 RID: 135970 RVA: 0x00494C3A File Offset: 0x00492E3A
		public static TVisibleConditionUnion FromIPreChildQuest(IPreChildQuestT _iprechildquest)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IPreChildQuest,
				Value = _iprechildquest
			};
		}

		// Token: 0x06021323 RID: 135971 RVA: 0x00494C4F File Offset: 0x00492E4F
		public IPreQuestT AsIPreQuest()
		{
			return this.As<IPreQuestT>();
		}

		// Token: 0x06021324 RID: 135972 RVA: 0x00494C57 File Offset: 0x00492E57
		public static TVisibleConditionUnion FromIPreQuest(IPreQuestT _iprequest)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IPreQuest,
				Value = _iprequest
			};
		}

		// Token: 0x06021325 RID: 135973 RVA: 0x00494C6C File Offset: 0x00492E6C
		public ISeasonAndWeatherT AsISeasonAndWeather()
		{
			return this.As<ISeasonAndWeatherT>();
		}

		// Token: 0x06021326 RID: 135974 RVA: 0x00494C74 File Offset: 0x00492E74
		public static TVisibleConditionUnion FromISeasonAndWeather(ISeasonAndWeatherT _iseasonandweather)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ISeasonAndWeather,
				Value = _iseasonandweather
			};
		}

		// Token: 0x06021327 RID: 135975 RVA: 0x00494C89 File Offset: 0x00492E89
		public ITargetEntityInvisibleT AsITargetEntityInvisible()
		{
			return this.As<ITargetEntityInvisibleT>();
		}

		// Token: 0x06021328 RID: 135976 RVA: 0x00494C91 File Offset: 0x00492E91
		public static TVisibleConditionUnion FromITargetEntityInvisible(ITargetEntityInvisibleT _itargetentityinvisible)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ITargetEntityInvisible,
				Value = _itargetentityinvisible
			};
		}

		// Token: 0x06021329 RID: 135977 RVA: 0x00494CA6 File Offset: 0x00492EA6
		public ITimePeriodT AsITimePeriod()
		{
			return this.As<ITimePeriodT>();
		}

		// Token: 0x0602132A RID: 135978 RVA: 0x00494CAE File Offset: 0x00492EAE
		public static TVisibleConditionUnion FromITimePeriod(ITimePeriodT _itimeperiod)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ITimePeriod,
				Value = _itimeperiod
			};
		}

		// Token: 0x0602132B RID: 135979 RVA: 0x00494CC3 File Offset: 0x00492EC3
		public IWeatherT AsIWeather()
		{
			return this.As<IWeatherT>();
		}

		// Token: 0x0602132C RID: 135980 RVA: 0x00494CCB File Offset: 0x00492ECB
		public static TVisibleConditionUnion FromIWeather(IWeatherT _iweather)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IWeather,
				Value = _iweather
			};
		}

		// Token: 0x0602132D RID: 135981 RVA: 0x00494CE0 File Offset: 0x00492EE0
		public static int Pack(FlatBufferBuilder builder, TVisibleConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TVisibleCondition.IClock:
				return IClock.Pack(builder, _o.AsIClock()).Value;
			case TVisibleCondition.ICompareVar:
				return ICompareVar.Pack(builder, _o.AsICompareVar()).Value;
			case TVisibleCondition.IPreChildQuest:
				return IPreChildQuest.Pack(builder, _o.AsIPreChildQuest()).Value;
			case TVisibleCondition.IPreQuest:
				return IPreQuest.Pack(builder, _o.AsIPreQuest()).Value;
			case TVisibleCondition.ISeasonAndWeather:
				return ISeasonAndWeather.Pack(builder, _o.AsISeasonAndWeather()).Value;
			case TVisibleCondition.ITargetEntityInvisible:
				return ITargetEntityInvisible.Pack(builder, _o.AsITargetEntityInvisible()).Value;
			case TVisibleCondition.ITimePeriod:
				return ITimePeriod.Pack(builder, _o.AsITimePeriod()).Value;
			case TVisibleCondition.IWeather:
				return IWeather.Pack(builder, _o.AsIWeather()).Value;
			default:
				return 0;
			}
		}
	}
}
