using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E41 RID: 32321
	public class TActorFxEmoteStopSubTypeUnion
	{
		// Token: 0x1700F1F3 RID: 61939
		// (get) Token: 0x0603A65F RID: 239199 RVA: 0x007DD45E File Offset: 0x007DB65E
		// (set) Token: 0x0603A660 RID: 239200 RVA: 0x007DD466 File Offset: 0x007DB666
		public TActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x1700F1F4 RID: 61940
		// (get) Token: 0x0603A661 RID: 239201 RVA: 0x007DD46F File Offset: 0x007DB66F
		// (set) Token: 0x0603A662 RID: 239202 RVA: 0x007DD477 File Offset: 0x007DB677
		public object Value { get; set; }

		// Token: 0x0603A663 RID: 239203 RVA: 0x007DD480 File Offset: 0x007DB680
		public TActorFxEmoteStopSubTypeUnion()
		{
			this.Type = TActorFxEmoteStopSubType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A664 RID: 239204 RVA: 0x007DD496 File Offset: 0x007DB696
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A665 RID: 239205 RVA: 0x007DD4A8 File Offset: 0x007DB6A8
		public IActorFxEmoteStopAllT AsIActorFxEmoteStopAll()
		{
			return this.As<IActorFxEmoteStopAllT>();
		}

		// Token: 0x0603A666 RID: 239206 RVA: 0x007DD4B0 File Offset: 0x007DB6B0
		public static TActorFxEmoteStopSubTypeUnion FromIActorFxEmoteStopAll(IActorFxEmoteStopAllT _iactorfxemotestopall)
		{
			return new TActorFxEmoteStopSubTypeUnion
			{
				Type = TActorFxEmoteStopSubType.IActorFxEmoteStopAll,
				Value = _iactorfxemotestopall
			};
		}

		// Token: 0x0603A667 RID: 239207 RVA: 0x007DD4C5 File Offset: 0x007DB6C5
		public IActorFxEmoteStopSocketsT AsIActorFxEmoteStopSockets()
		{
			return this.As<IActorFxEmoteStopSocketsT>();
		}

		// Token: 0x0603A668 RID: 239208 RVA: 0x007DD4CD File Offset: 0x007DB6CD
		public static TActorFxEmoteStopSubTypeUnion FromIActorFxEmoteStopSockets(IActorFxEmoteStopSocketsT _iactorfxemotestopsockets)
		{
			return new TActorFxEmoteStopSubTypeUnion
			{
				Type = TActorFxEmoteStopSubType.IActorFxEmoteStopSockets,
				Value = _iactorfxemotestopsockets
			};
		}

		// Token: 0x0603A669 RID: 239209 RVA: 0x007DD4E4 File Offset: 0x007DB6E4
		public static int Pack(FlatBufferBuilder builder, TActorFxEmoteStopSubTypeUnion _o)
		{
			TActorFxEmoteStopSubType type = _o.Type;
			if (type == TActorFxEmoteStopSubType.IActorFxEmoteStopAll)
			{
				return IActorFxEmoteStopAll.Pack(builder, _o.AsIActorFxEmoteStopAll()).Value;
			}
			if (type != TActorFxEmoteStopSubType.IActorFxEmoteStopSockets)
			{
				return 0;
			}
			return IActorFxEmoteStopSockets.Pack(builder, _o.AsIActorFxEmoteStopSockets()).Value;
		}
	}
}
