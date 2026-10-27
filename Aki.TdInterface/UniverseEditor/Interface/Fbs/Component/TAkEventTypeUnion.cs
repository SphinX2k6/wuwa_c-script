using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BE6 RID: 23526
	public class TAkEventTypeUnion
	{
		// Token: 0x1700B1C3 RID: 45507
		// (get) Token: 0x06028511 RID: 165137 RVA: 0x0058A142 File Offset: 0x00588342
		// (set) Token: 0x06028512 RID: 165138 RVA: 0x0058A14A File Offset: 0x0058834A
		public TAkEventType Type { get; set; }

		// Token: 0x1700B1C4 RID: 45508
		// (get) Token: 0x06028513 RID: 165139 RVA: 0x0058A153 File Offset: 0x00588353
		// (set) Token: 0x06028514 RID: 165140 RVA: 0x0058A15B File Offset: 0x0058835B
		public object Value { get; set; }

		// Token: 0x06028515 RID: 165141 RVA: 0x0058A164 File Offset: 0x00588364
		public TAkEventTypeUnion()
		{
			this.Type = TAkEventType.NONE;
			this.Value = null;
		}

		// Token: 0x06028516 RID: 165142 RVA: 0x0058A17A File Offset: 0x0058837A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028517 RID: 165143 RVA: 0x0058A18C File Offset: 0x0058838C
		public IBoxAkEventT AsIBoxAkEvent()
		{
			return this.As<IBoxAkEventT>();
		}

		// Token: 0x06028518 RID: 165144 RVA: 0x0058A194 File Offset: 0x00588394
		public static TAkEventTypeUnion FromIBoxAkEvent(IBoxAkEventT _iboxakevent)
		{
			return new TAkEventTypeUnion
			{
				Type = TAkEventType.IBoxAkEvent,
				Value = _iboxakevent
			};
		}

		// Token: 0x06028519 RID: 165145 RVA: 0x0058A1A9 File Offset: 0x005883A9
		public IDefaultAkEventT AsIDefaultAkEvent()
		{
			return this.As<IDefaultAkEventT>();
		}

		// Token: 0x0602851A RID: 165146 RVA: 0x0058A1B1 File Offset: 0x005883B1
		public static TAkEventTypeUnion FromIDefaultAkEvent(IDefaultAkEventT _idefaultakevent)
		{
			return new TAkEventTypeUnion
			{
				Type = TAkEventType.IDefaultAkEvent,
				Value = _idefaultakevent
			};
		}

		// Token: 0x0602851B RID: 165147 RVA: 0x0058A1C6 File Offset: 0x005883C6
		public IPointAkEventT AsIPointAkEvent()
		{
			return this.As<IPointAkEventT>();
		}

		// Token: 0x0602851C RID: 165148 RVA: 0x0058A1CE File Offset: 0x005883CE
		public static TAkEventTypeUnion FromIPointAkEvent(IPointAkEventT _ipointakevent)
		{
			return new TAkEventTypeUnion
			{
				Type = TAkEventType.IPointAkEvent,
				Value = _ipointakevent
			};
		}

		// Token: 0x0602851D RID: 165149 RVA: 0x0058A1E4 File Offset: 0x005883E4
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
