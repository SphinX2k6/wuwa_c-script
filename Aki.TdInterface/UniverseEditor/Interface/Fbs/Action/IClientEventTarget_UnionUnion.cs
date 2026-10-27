using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063B0 RID: 25520
	public class IClientEventTarget_UnionUnion
	{
		// Token: 0x1700BE35 RID: 48693
		// (get) Token: 0x0602C251 RID: 180817 RVA: 0x0060FEAD File Offset: 0x0060E0AD
		// (set) Token: 0x0602C252 RID: 180818 RVA: 0x0060FEB5 File Offset: 0x0060E0B5
		public IClientEventTarget_Union Type { get; set; }

		// Token: 0x1700BE36 RID: 48694
		// (get) Token: 0x0602C253 RID: 180819 RVA: 0x0060FEBE File Offset: 0x0060E0BE
		// (set) Token: 0x0602C254 RID: 180820 RVA: 0x0060FEC6 File Offset: 0x0060E0C6
		public object Value { get; set; }

		// Token: 0x0602C255 RID: 180821 RVA: 0x0060FECF File Offset: 0x0060E0CF
		public IClientEventTarget_UnionUnion()
		{
			this.Type = IClientEventTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C256 RID: 180822 RVA: 0x0060FEE5 File Offset: 0x0060E0E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C257 RID: 180823 RVA: 0x0060FEF7 File Offset: 0x0060E0F7
		public IClientEventTargetT AsIClientEventTarget()
		{
			return this.As<IClientEventTargetT>();
		}

		// Token: 0x0602C258 RID: 180824 RVA: 0x0060FEFF File Offset: 0x0060E0FF
		public static IClientEventTarget_UnionUnion FromIClientEventTarget(IClientEventTargetT _iclienteventtarget)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.IClientEventTarget,
				Value = _iclienteventtarget
			};
		}

		// Token: 0x0602C259 RID: 180825 RVA: 0x0060FF14 File Offset: 0x0060E114
		public ISelfClientEventT AsISelfClientEvent()
		{
			return this.As<ISelfClientEventT>();
		}

		// Token: 0x0602C25A RID: 180826 RVA: 0x0060FF1C File Offset: 0x0060E11C
		public static IClientEventTarget_UnionUnion FromISelfClientEvent(ISelfClientEventT _iselfclientevent)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.ISelfClientEvent,
				Value = _iselfclientevent
			};
		}

		// Token: 0x0602C25B RID: 180827 RVA: 0x0060FF31 File Offset: 0x0060E131
		public IClientUiEventT AsIClientUiEvent()
		{
			return this.As<IClientUiEventT>();
		}

		// Token: 0x0602C25C RID: 180828 RVA: 0x0060FF39 File Offset: 0x0060E139
		public static IClientEventTarget_UnionUnion FromIClientUiEvent(IClientUiEventT _iclientuievent)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.IClientUiEvent,
				Value = _iclientuievent
			};
		}

		// Token: 0x0602C25D RID: 180829 RVA: 0x0060FF50 File Offset: 0x0060E150
		public static int Pack(FlatBufferBuilder builder, IClientEventTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientEventTarget_Union.IClientEventTarget:
				return IClientEventTarget.Pack(builder, _o.AsIClientEventTarget()).Value;
			case IClientEventTarget_Union.ISelfClientEvent:
				return ISelfClientEvent.Pack(builder, _o.AsISelfClientEvent()).Value;
			case IClientEventTarget_Union.IClientUiEvent:
				return IClientUiEvent.Pack(builder, _o.AsIClientUiEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
