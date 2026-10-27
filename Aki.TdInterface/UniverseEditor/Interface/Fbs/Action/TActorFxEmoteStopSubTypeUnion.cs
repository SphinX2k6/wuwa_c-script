using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007633 RID: 30259
	public class TActorFxEmoteStopSubTypeUnion
	{
		// Token: 0x1700E5B5 RID: 58805
		// (get) Token: 0x060371BA RID: 225722 RVA: 0x00779362 File Offset: 0x00777562
		// (set) Token: 0x060371BB RID: 225723 RVA: 0x0077936A File Offset: 0x0077756A
		public TActorFxEmoteStopSubType Type { get; set; }

		// Token: 0x1700E5B6 RID: 58806
		// (get) Token: 0x060371BC RID: 225724 RVA: 0x00779373 File Offset: 0x00777573
		// (set) Token: 0x060371BD RID: 225725 RVA: 0x0077937B File Offset: 0x0077757B
		public object Value { get; set; }

		// Token: 0x060371BE RID: 225726 RVA: 0x00779384 File Offset: 0x00777584
		public TActorFxEmoteStopSubTypeUnion()
		{
			this.Type = TActorFxEmoteStopSubType.NONE;
			this.Value = null;
		}

		// Token: 0x060371BF RID: 225727 RVA: 0x0077939A File Offset: 0x0077759A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371C0 RID: 225728 RVA: 0x007793AC File Offset: 0x007775AC
		public IActorFxEmoteStopAllT AsIActorFxEmoteStopAll()
		{
			return this.As<IActorFxEmoteStopAllT>();
		}

		// Token: 0x060371C1 RID: 225729 RVA: 0x007793B4 File Offset: 0x007775B4
		public static TActorFxEmoteStopSubTypeUnion FromIActorFxEmoteStopAll(IActorFxEmoteStopAllT _iactorfxemotestopall)
		{
			return new TActorFxEmoteStopSubTypeUnion
			{
				Type = TActorFxEmoteStopSubType.IActorFxEmoteStopAll,
				Value = _iactorfxemotestopall
			};
		}

		// Token: 0x060371C2 RID: 225730 RVA: 0x007793C9 File Offset: 0x007775C9
		public IActorFxEmoteStopSocketsT AsIActorFxEmoteStopSockets()
		{
			return this.As<IActorFxEmoteStopSocketsT>();
		}

		// Token: 0x060371C3 RID: 225731 RVA: 0x007793D1 File Offset: 0x007775D1
		public static TActorFxEmoteStopSubTypeUnion FromIActorFxEmoteStopSockets(IActorFxEmoteStopSocketsT _iactorfxemotestopsockets)
		{
			return new TActorFxEmoteStopSubTypeUnion
			{
				Type = TActorFxEmoteStopSubType.IActorFxEmoteStopSockets,
				Value = _iactorfxemotestopsockets
			};
		}

		// Token: 0x060371C4 RID: 225732 RVA: 0x007793E8 File Offset: 0x007775E8
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
