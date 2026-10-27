using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D61 RID: 19809
	public class TVisibleConditionUnion
	{
		// Token: 0x17008F5B RID: 36699
		// (get) Token: 0x0601F6CE RID: 128718 RVA: 0x00460BDA File Offset: 0x0045EDDA
		// (set) Token: 0x0601F6CF RID: 128719 RVA: 0x00460BE2 File Offset: 0x0045EDE2
		public TVisibleCondition Type { get; set; }

		// Token: 0x17008F5C RID: 36700
		// (get) Token: 0x0601F6D0 RID: 128720 RVA: 0x00460BEB File Offset: 0x0045EDEB
		// (set) Token: 0x0601F6D1 RID: 128721 RVA: 0x00460BF3 File Offset: 0x0045EDF3
		public object Value { get; set; }

		// Token: 0x0601F6D2 RID: 128722 RVA: 0x00460BFC File Offset: 0x0045EDFC
		public TVisibleConditionUnion()
		{
			this.Type = TVisibleCondition.NONE;
			this.Value = null;
		}

		// Token: 0x0601F6D3 RID: 128723 RVA: 0x00460C12 File Offset: 0x0045EE12
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F6D4 RID: 128724 RVA: 0x00460C24 File Offset: 0x0045EE24
		public IClockT AsIClock()
		{
			return this.As<IClockT>();
		}

		// Token: 0x0601F6D5 RID: 128725 RVA: 0x00460C2C File Offset: 0x0045EE2C
		public static TVisibleConditionUnion FromIClock(IClockT _iclock)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IClock,
				Value = _iclock
			};
		}

		// Token: 0x0601F6D6 RID: 128726 RVA: 0x00460C41 File Offset: 0x0045EE41
		public ICompareVarT AsICompareVar()
		{
			return this.As<ICompareVarT>();
		}

		// Token: 0x0601F6D7 RID: 128727 RVA: 0x00460C49 File Offset: 0x0045EE49
		public static TVisibleConditionUnion FromICompareVar(ICompareVarT _icomparevar)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ICompareVar,
				Value = _icomparevar
			};
		}

		// Token: 0x0601F6D8 RID: 128728 RVA: 0x00460C5E File Offset: 0x0045EE5E
		public IPreChildQuestT AsIPreChildQuest()
		{
			return this.As<IPreChildQuestT>();
		}

		// Token: 0x0601F6D9 RID: 128729 RVA: 0x00460C66 File Offset: 0x0045EE66
		public static TVisibleConditionUnion FromIPreChildQuest(IPreChildQuestT _iprechildquest)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IPreChildQuest,
				Value = _iprechildquest
			};
		}

		// Token: 0x0601F6DA RID: 128730 RVA: 0x00460C7B File Offset: 0x0045EE7B
		public IPreQuestT AsIPreQuest()
		{
			return this.As<IPreQuestT>();
		}

		// Token: 0x0601F6DB RID: 128731 RVA: 0x00460C83 File Offset: 0x0045EE83
		public static TVisibleConditionUnion FromIPreQuest(IPreQuestT _iprequest)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IPreQuest,
				Value = _iprequest
			};
		}

		// Token: 0x0601F6DC RID: 128732 RVA: 0x00460C98 File Offset: 0x0045EE98
		public ITargetEntityInvisibleT AsITargetEntityInvisible()
		{
			return this.As<ITargetEntityInvisibleT>();
		}

		// Token: 0x0601F6DD RID: 128733 RVA: 0x00460CA0 File Offset: 0x0045EEA0
		public static TVisibleConditionUnion FromITargetEntityInvisible(ITargetEntityInvisibleT _itargetentityinvisible)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ITargetEntityInvisible,
				Value = _itargetentityinvisible
			};
		}

		// Token: 0x0601F6DE RID: 128734 RVA: 0x00460CB5 File Offset: 0x0045EEB5
		public ITimePeriodT AsITimePeriod()
		{
			return this.As<ITimePeriodT>();
		}

		// Token: 0x0601F6DF RID: 128735 RVA: 0x00460CBD File Offset: 0x0045EEBD
		public static TVisibleConditionUnion FromITimePeriod(ITimePeriodT _itimeperiod)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.ITimePeriod,
				Value = _itimeperiod
			};
		}

		// Token: 0x0601F6E0 RID: 128736 RVA: 0x00460CD2 File Offset: 0x0045EED2
		public IWeatherT AsIWeather()
		{
			return this.As<IWeatherT>();
		}

		// Token: 0x0601F6E1 RID: 128737 RVA: 0x00460CDA File Offset: 0x0045EEDA
		public static TVisibleConditionUnion FromIWeather(IWeatherT _iweather)
		{
			return new TVisibleConditionUnion
			{
				Type = TVisibleCondition.IWeather,
				Value = _iweather
			};
		}

		// Token: 0x0601F6E2 RID: 128738 RVA: 0x00460CF0 File Offset: 0x0045EEF0
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
