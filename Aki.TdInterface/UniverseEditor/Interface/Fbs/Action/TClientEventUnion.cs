using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200766F RID: 30319
	public class TClientEventUnion
	{
		// Token: 0x1700E5DD RID: 58845
		// (get) Token: 0x060372EA RID: 226026 RVA: 0x0077AFB6 File Offset: 0x007791B6
		// (set) Token: 0x060372EB RID: 226027 RVA: 0x0077AFBE File Offset: 0x007791BE
		public TClientEvent Type { get; set; }

		// Token: 0x1700E5DE RID: 58846
		// (get) Token: 0x060372EC RID: 226028 RVA: 0x0077AFC7 File Offset: 0x007791C7
		// (set) Token: 0x060372ED RID: 226029 RVA: 0x0077AFCF File Offset: 0x007791CF
		public object Value { get; set; }

		// Token: 0x060372EE RID: 226030 RVA: 0x0077AFD8 File Offset: 0x007791D8
		public TClientEventUnion()
		{
			this.Type = TClientEvent.NONE;
			this.Value = null;
		}

		// Token: 0x060372EF RID: 226031 RVA: 0x0077AFEE File Offset: 0x007791EE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372F0 RID: 226032 RVA: 0x0077B000 File Offset: 0x00779200
		public IClientUiEventT AsIClientUiEvent()
		{
			return this.As<IClientUiEventT>();
		}

		// Token: 0x060372F1 RID: 226033 RVA: 0x0077B008 File Offset: 0x00779208
		public static TClientEventUnion FromIClientUiEvent(IClientUiEventT _iclientuievent)
		{
			return new TClientEventUnion
			{
				Type = TClientEvent.IClientUiEvent,
				Value = _iclientuievent
			};
		}

		// Token: 0x060372F2 RID: 226034 RVA: 0x0077B01D File Offset: 0x0077921D
		public ISelfClientEventT AsISelfClientEvent()
		{
			return this.As<ISelfClientEventT>();
		}

		// Token: 0x060372F3 RID: 226035 RVA: 0x0077B025 File Offset: 0x00779225
		public static TClientEventUnion FromISelfClientEvent(ISelfClientEventT _iselfclientevent)
		{
			return new TClientEventUnion
			{
				Type = TClientEvent.ISelfClientEvent,
				Value = _iselfclientevent
			};
		}

		// Token: 0x060372F4 RID: 226036 RVA: 0x0077B03C File Offset: 0x0077923C
		public static int Pack(FlatBufferBuilder builder, TClientEventUnion _o)
		{
			TClientEvent type = _o.Type;
			if (type == TClientEvent.IClientUiEvent)
			{
				return IClientUiEvent.Pack(builder, _o.AsIClientUiEvent()).Value;
			}
			if (type != TClientEvent.ISelfClientEvent)
			{
				return 0;
			}
			return ISelfClientEvent.Pack(builder, _o.AsISelfClientEvent()).Value;
		}
	}
}
