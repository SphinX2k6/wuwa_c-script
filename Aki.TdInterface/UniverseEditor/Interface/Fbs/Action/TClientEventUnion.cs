using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E7D RID: 32381
	public class TClientEventUnion
	{
		// Token: 0x1700F21B RID: 61979
		// (get) Token: 0x0603A78F RID: 239503 RVA: 0x007DF0B2 File Offset: 0x007DD2B2
		// (set) Token: 0x0603A790 RID: 239504 RVA: 0x007DF0BA File Offset: 0x007DD2BA
		public TClientEvent Type { get; set; }

		// Token: 0x1700F21C RID: 61980
		// (get) Token: 0x0603A791 RID: 239505 RVA: 0x007DF0C3 File Offset: 0x007DD2C3
		// (set) Token: 0x0603A792 RID: 239506 RVA: 0x007DF0CB File Offset: 0x007DD2CB
		public object Value { get; set; }

		// Token: 0x0603A793 RID: 239507 RVA: 0x007DF0D4 File Offset: 0x007DD2D4
		public TClientEventUnion()
		{
			this.Type = TClientEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0603A794 RID: 239508 RVA: 0x007DF0EA File Offset: 0x007DD2EA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A795 RID: 239509 RVA: 0x007DF0FC File Offset: 0x007DD2FC
		public IClientUiEventT AsIClientUiEvent()
		{
			return this.As<IClientUiEventT>();
		}

		// Token: 0x0603A796 RID: 239510 RVA: 0x007DF104 File Offset: 0x007DD304
		public static TClientEventUnion FromIClientUiEvent(IClientUiEventT _iclientuievent)
		{
			return new TClientEventUnion
			{
				Type = TClientEvent.IClientUiEvent,
				Value = _iclientuievent
			};
		}

		// Token: 0x0603A797 RID: 239511 RVA: 0x007DF119 File Offset: 0x007DD319
		public ISelfClientEventT AsISelfClientEvent()
		{
			return this.As<ISelfClientEventT>();
		}

		// Token: 0x0603A798 RID: 239512 RVA: 0x007DF121 File Offset: 0x007DD321
		public static TClientEventUnion FromISelfClientEvent(ISelfClientEventT _iselfclientevent)
		{
			return new TClientEventUnion
			{
				Type = TClientEvent.ISelfClientEvent,
				Value = _iselfclientevent
			};
		}

		// Token: 0x0603A799 RID: 239513 RVA: 0x007DF138 File Offset: 0x007DD338
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
