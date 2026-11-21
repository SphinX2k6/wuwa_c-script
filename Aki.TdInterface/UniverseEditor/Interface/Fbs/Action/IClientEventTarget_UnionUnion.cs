using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A21 RID: 27169
	public class IClientEventTarget_UnionUnion
	{
		// Token: 0x1700C7B9 RID: 51129
		// (get) Token: 0x0602E9B3 RID: 190899 RVA: 0x0065AEE5 File Offset: 0x006590E5
		// (set) Token: 0x0602E9B4 RID: 190900 RVA: 0x0065AEED File Offset: 0x006590ED
		public IClientEventTarget_Union Type { get; set; }

		// Token: 0x1700C7BA RID: 51130
		// (get) Token: 0x0602E9B5 RID: 190901 RVA: 0x0065AEF6 File Offset: 0x006590F6
		// (set) Token: 0x0602E9B6 RID: 190902 RVA: 0x0065AEFE File Offset: 0x006590FE
		public object Value { get; set; }

		// Token: 0x0602E9B7 RID: 190903 RVA: 0x0065AF07 File Offset: 0x00659107
		public IClientEventTarget_UnionUnion()
		{
			this.Type = IClientEventTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E9B8 RID: 190904 RVA: 0x0065AF1D File Offset: 0x0065911D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E9B9 RID: 190905 RVA: 0x0065AF2F File Offset: 0x0065912F
		public IClientEventTargetT AsIClientEventTarget()
		{
			return this.As<IClientEventTargetT>();
		}

		// Token: 0x0602E9BA RID: 190906 RVA: 0x0065AF37 File Offset: 0x00659137
		public static IClientEventTarget_UnionUnion FromIClientEventTarget(IClientEventTargetT _iclienteventtarget)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.IClientEventTarget,
				Value = _iclienteventtarget
			};
		}

		// Token: 0x0602E9BB RID: 190907 RVA: 0x0065AF4C File Offset: 0x0065914C
		public ISelfClientEventT AsISelfClientEvent()
		{
			return this.As<ISelfClientEventT>();
		}

		// Token: 0x0602E9BC RID: 190908 RVA: 0x0065AF54 File Offset: 0x00659154
		public static IClientEventTarget_UnionUnion FromISelfClientEvent(ISelfClientEventT _iselfclientevent)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.ISelfClientEvent,
				Value = _iselfclientevent
			};
		}

		// Token: 0x0602E9BD RID: 190909 RVA: 0x0065AF69 File Offset: 0x00659169
		public IClientUiEventT AsIClientUiEvent()
		{
			return this.As<IClientUiEventT>();
		}

		// Token: 0x0602E9BE RID: 190910 RVA: 0x0065AF71 File Offset: 0x00659171
		public static IClientEventTarget_UnionUnion FromIClientUiEvent(IClientUiEventT _iclientuievent)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.IClientUiEvent,
				Value = _iclientuievent
			};
		}

		// Token: 0x0602E9BF RID: 190911 RVA: 0x0065AF88 File Offset: 0x00659188
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
