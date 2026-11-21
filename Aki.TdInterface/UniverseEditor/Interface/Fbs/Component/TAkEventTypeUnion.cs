using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061FF RID: 25087
	public class TAkEventTypeUnion
	{
		// Token: 0x1700BB0D RID: 47885
		// (get) Token: 0x0602AAE1 RID: 174817 RVA: 0x005D1CCE File Offset: 0x005CFECE
		// (set) Token: 0x0602AAE2 RID: 174818 RVA: 0x005D1CD6 File Offset: 0x005CFED6
		public TAkEventType Type { get; set; }

		// Token: 0x1700BB0E RID: 47886
		// (get) Token: 0x0602AAE3 RID: 174819 RVA: 0x005D1CDF File Offset: 0x005CFEDF
		// (set) Token: 0x0602AAE4 RID: 174820 RVA: 0x005D1CE7 File Offset: 0x005CFEE7
		public object Value { get; set; }

		// Token: 0x0602AAE5 RID: 174821 RVA: 0x005D1CF0 File Offset: 0x005CFEF0
		public TAkEventTypeUnion()
		{
			this.Type = TAkEventType.NONE;
			this.Value = null;
		}

		// Token: 0x0602AAE6 RID: 174822 RVA: 0x005D1D06 File Offset: 0x005CFF06
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AAE7 RID: 174823 RVA: 0x005D1D18 File Offset: 0x005CFF18
		public IBoxAkEventT AsIBoxAkEvent()
		{
			return this.As<IBoxAkEventT>();
		}

		// Token: 0x0602AAE8 RID: 174824 RVA: 0x005D1D20 File Offset: 0x005CFF20
		public static TAkEventTypeUnion FromIBoxAkEvent(IBoxAkEventT _iboxakevent)
		{
			return new TAkEventTypeUnion
			{
				Type = TAkEventType.IBoxAkEvent,
				Value = _iboxakevent
			};
		}

		// Token: 0x0602AAE9 RID: 174825 RVA: 0x005D1D35 File Offset: 0x005CFF35
		public IDefaultAkEventT AsIDefaultAkEvent()
		{
			return this.As<IDefaultAkEventT>();
		}

		// Token: 0x0602AAEA RID: 174826 RVA: 0x005D1D3D File Offset: 0x005CFF3D
		public static TAkEventTypeUnion FromIDefaultAkEvent(IDefaultAkEventT _idefaultakevent)
		{
			return new TAkEventTypeUnion
			{
				Type = TAkEventType.IDefaultAkEvent,
				Value = _idefaultakevent
			};
		}

		// Token: 0x0602AAEB RID: 174827 RVA: 0x005D1D52 File Offset: 0x005CFF52
		public IPointAkEventT AsIPointAkEvent()
		{
			return this.As<IPointAkEventT>();
		}

		// Token: 0x0602AAEC RID: 174828 RVA: 0x005D1D5A File Offset: 0x005CFF5A
		public static TAkEventTypeUnion FromIPointAkEvent(IPointAkEventT _ipointakevent)
		{
			return new TAkEventTypeUnion
			{
				Type = TAkEventType.IPointAkEvent,
				Value = _ipointakevent
			};
		}

		// Token: 0x0602AAED RID: 174829 RVA: 0x005D1D70 File Offset: 0x005CFF70
		public static int Pack(FlatBufferBuilder builder, TAkEventTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TAkEventType.IBoxAkEvent:
				return IBoxAkEvent.Pack(builder, _o.AsIBoxAkEvent()).Value;
			case TAkEventType.IDefaultAkEvent:
				return IDefaultAkEvent.Pack(builder, _o.AsIDefaultAkEvent()).Value;
			case TAkEventType.IPointAkEvent:
				return IPointAkEvent.Pack(builder, _o.AsIPointAkEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
