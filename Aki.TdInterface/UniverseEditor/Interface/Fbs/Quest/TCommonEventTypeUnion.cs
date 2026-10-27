using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042C4 RID: 17092
	public class TCommonEventTypeUnion
	{
		// Token: 0x17007937 RID: 31031
		// (get) Token: 0x0601959F RID: 103839 RVA: 0x003A35AB File Offset: 0x003A17AB
		// (set) Token: 0x060195A0 RID: 103840 RVA: 0x003A35B3 File Offset: 0x003A17B3
		public TCommonEventType Type { get; set; }

		// Token: 0x17007938 RID: 31032
		// (get) Token: 0x060195A1 RID: 103841 RVA: 0x003A35BC File Offset: 0x003A17BC
		// (set) Token: 0x060195A2 RID: 103842 RVA: 0x003A35C4 File Offset: 0x003A17C4
		public object Value { get; set; }

		// Token: 0x060195A3 RID: 103843 RVA: 0x003A35CD File Offset: 0x003A17CD
		public TCommonEventTypeUnion()
		{
			this.Type = TCommonEventType.NONE;
			this.Value = null;
		}

		// Token: 0x060195A4 RID: 103844 RVA: 0x003A35E3 File Offset: 0x003A17E3
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060195A5 RID: 103845 RVA: 0x003A35F5 File Offset: 0x003A17F5
		public ICommonEventEntityStateChangeT AsICommonEventEntityStateChange()
		{
			return this.As<ICommonEventEntityStateChangeT>();
		}

		// Token: 0x060195A6 RID: 103846 RVA: 0x003A35FD File Offset: 0x003A17FD
		public static TCommonEventTypeUnion FromICommonEventEntityStateChange(ICommonEventEntityStateChangeT _icommonevententitystatechange)
		{
			return new TCommonEventTypeUnion
			{
				Type = TCommonEventType.ICommonEventEntityStateChange,
				Value = _icommonevententitystatechange
			};
		}

		// Token: 0x060195A7 RID: 103847 RVA: 0x003A3612 File Offset: 0x003A1812
		public ICommonEventVarValueChangeT AsICommonEventVarValueChange()
		{
			return this.As<ICommonEventVarValueChangeT>();
		}

		// Token: 0x060195A8 RID: 103848 RVA: 0x003A361A File Offset: 0x003A181A
		public static TCommonEventTypeUnion FromICommonEventVarValueChange(ICommonEventVarValueChangeT _icommoneventvarvaluechange)
		{
			return new TCommonEventTypeUnion
			{
				Type = TCommonEventType.ICommonEventVarValueChange,
				Value = _icommoneventvarvaluechange
			};
		}

		// Token: 0x060195A9 RID: 103849 RVA: 0x003A3630 File Offset: 0x003A1830
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
