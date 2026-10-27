using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007630 RID: 30256
	public class TActorFxEmoteUnion
	{
		// Token: 0x1700E5B3 RID: 58803
		// (get) Token: 0x060371AE RID: 225710 RVA: 0x00779266 File Offset: 0x00777466
		// (set) Token: 0x060371AF RID: 225711 RVA: 0x0077926E File Offset: 0x0077746E
		public TActorFxEmote Type { get; set; }

		// Token: 0x1700E5B4 RID: 58804
		// (get) Token: 0x060371B0 RID: 225712 RVA: 0x00779277 File Offset: 0x00777477
		// (set) Token: 0x060371B1 RID: 225713 RVA: 0x0077927F File Offset: 0x0077747F
		public object Value { get; set; }

		// Token: 0x060371B2 RID: 225714 RVA: 0x00779288 File Offset: 0x00777488
		public TActorFxEmoteUnion()
		{
			this.Type = TActorFxEmote.NONE;
			this.Value = null;
		}

		// Token: 0x060371B3 RID: 225715 RVA: 0x0077929E File Offset: 0x0077749E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060371B4 RID: 225716 RVA: 0x007792B0 File Offset: 0x007774B0
		public IActorFxEmotePlayT AsIActorFxEmotePlay()
		{
			return this.As<IActorFxEmotePlayT>();
		}

		// Token: 0x060371B5 RID: 225717 RVA: 0x007792B8 File Offset: 0x007774B8
		public static TActorFxEmoteUnion FromIActorFxEmotePlay(IActorFxEmotePlayT _iactorfxemoteplay)
		{
			return new TActorFxEmoteUnion
			{
				Type = TActorFxEmote.IActorFxEmotePlay,
				Value = _iactorfxemoteplay
			};
		}

		// Token: 0x060371B6 RID: 225718 RVA: 0x007792CD File Offset: 0x007774CD
		public IActorFxEmoteStopT AsIActorFxEmoteStop()
		{
			return this.As<IActorFxEmoteStopT>();
		}

		// Token: 0x060371B7 RID: 225719 RVA: 0x007792D5 File Offset: 0x007774D5
		public static TActorFxEmoteUnion FromIActorFxEmoteStop(IActorFxEmoteStopT _iactorfxemotestop)
		{
			return new TActorFxEmoteUnion
			{
				Type = TActorFxEmote.IActorFxEmoteStop,
				Value = _iactorfxemotestop
			};
		}

		// Token: 0x060371B8 RID: 225720 RVA: 0x007792EC File Offset: 0x007774EC
		public static int Pack(FlatBufferBuilder builder, TActorFxEmoteUnion _o)
		{
			TActorFxEmote type = _o.Type;
			if (type == TActorFxEmote.IActorFxEmotePlay)
			{
				return IActorFxEmotePlay.Pack(builder, _o.AsIActorFxEmotePlay()).Value;
			}
			if (type != TActorFxEmote.IActorFxEmoteStop)
			{
				return 0;
			}
			return IActorFxEmoteStop.Pack(builder, _o.AsIActorFxEmoteStop()).Value;
		}
	}
}
