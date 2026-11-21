using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004720 RID: 18208
	public class TCommonEventTypeUnion
	{
		// Token: 0x17007F68 RID: 32616
		// (get) Token: 0x0601AD0B RID: 109835 RVA: 0x003CEC83 File Offset: 0x003CCE83
		// (set) Token: 0x0601AD0C RID: 109836 RVA: 0x003CEC8B File Offset: 0x003CCE8B
		public TCommonEventType Type { get; set; }

		// Token: 0x17007F69 RID: 32617
		// (get) Token: 0x0601AD0D RID: 109837 RVA: 0x003CEC94 File Offset: 0x003CCE94
		// (set) Token: 0x0601AD0E RID: 109838 RVA: 0x003CEC9C File Offset: 0x003CCE9C
		public object Value { get; set; }

		// Token: 0x0601AD0F RID: 109839 RVA: 0x003CECA5 File Offset: 0x003CCEA5
		public TCommonEventTypeUnion()
		{
			this.Type = TCommonEventType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AD10 RID: 109840 RVA: 0x003CECBB File Offset: 0x003CCEBB
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AD11 RID: 109841 RVA: 0x003CECCD File Offset: 0x003CCECD
		public ICommonEventEntityStateChangeT AsICommonEventEntityStateChange()
		{
			return this.As<ICommonEventEntityStateChangeT>();
		}

		// Token: 0x0601AD12 RID: 109842 RVA: 0x003CECD5 File Offset: 0x003CCED5
		public static TCommonEventTypeUnion FromICommonEventEntityStateChange(ICommonEventEntityStateChangeT _icommonevententitystatechange)
		{
			return new TCommonEventTypeUnion
			{
				Type = TCommonEventType.ICommonEventEntityStateChange,
				Value = _icommonevententitystatechange
			};
		}

		// Token: 0x0601AD13 RID: 109843 RVA: 0x003CECEA File Offset: 0x003CCEEA
		public ICommonEventVarValueChangeT AsICommonEventVarValueChange()
		{
			return this.As<ICommonEventVarValueChangeT>();
		}

		// Token: 0x0601AD14 RID: 109844 RVA: 0x003CECF2 File Offset: 0x003CCEF2
		public static TCommonEventTypeUnion FromICommonEventVarValueChange(ICommonEventVarValueChangeT _icommoneventvarvaluechange)
		{
			return new TCommonEventTypeUnion
			{
				Type = TCommonEventType.ICommonEventVarValueChange,
				Value = _icommoneventvarvaluechange
			};
		}

		// Token: 0x0601AD15 RID: 109845 RVA: 0x003CED08 File Offset: 0x003CCF08
		public static int Pack(FlatBufferBuilder builder, TCommonEventTypeUnion _o)
		{
			TCommonEventType type = _o.Type;
			if (type == TCommonEventType.ICommonEventEntityStateChange)
			{
				return ICommonEventEntityStateChange.Pack(builder, _o.AsICommonEventEntityStateChange()).Value;
			}
			if (type != TCommonEventType.ICommonEventVarValueChange)
			{
				return 0;
			}
			return ICommonEventVarValueChange.Pack(builder, _o.AsICommonEventVarValueChange()).Value;
		}
	}
}
