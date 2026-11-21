using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E3E RID: 32318
	public class TActorFxEmoteUnion
	{
		// Token: 0x1700F1F1 RID: 61937
		// (get) Token: 0x0603A653 RID: 239187 RVA: 0x007DD362 File Offset: 0x007DB562
		// (set) Token: 0x0603A654 RID: 239188 RVA: 0x007DD36A File Offset: 0x007DB56A
		public TActorFxEmote Type { get; set; }

		// Token: 0x1700F1F2 RID: 61938
		// (get) Token: 0x0603A655 RID: 239189 RVA: 0x007DD373 File Offset: 0x007DB573
		// (set) Token: 0x0603A656 RID: 239190 RVA: 0x007DD37B File Offset: 0x007DB57B
		public object Value { get; set; }

		// Token: 0x0603A657 RID: 239191 RVA: 0x007DD384 File Offset: 0x007DB584
		public TActorFxEmoteUnion()
		{
			this.Type = TActorFxEmote.NONE;
			this.Value = null;
		}

		// Token: 0x0603A658 RID: 239192 RVA: 0x007DD39A File Offset: 0x007DB59A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A659 RID: 239193 RVA: 0x007DD3AC File Offset: 0x007DB5AC
		public IActorFxEmotePlayT AsIActorFxEmotePlay()
		{
			return this.As<IActorFxEmotePlayT>();
		}

		// Token: 0x0603A65A RID: 239194 RVA: 0x007DD3B4 File Offset: 0x007DB5B4
		public static TActorFxEmoteUnion FromIActorFxEmotePlay(IActorFxEmotePlayT _iactorfxemoteplay)
		{
			return new TActorFxEmoteUnion
			{
				Type = TActorFxEmote.IActorFxEmotePlay,
				Value = _iactorfxemoteplay
			};
		}

		// Token: 0x0603A65B RID: 239195 RVA: 0x007DD3C9 File Offset: 0x007DB5C9
		public IActorFxEmoteStopT AsIActorFxEmoteStop()
		{
			return this.As<IActorFxEmoteStopT>();
		}

		// Token: 0x0603A65C RID: 239196 RVA: 0x007DD3D1 File Offset: 0x007DB5D1
		public static TActorFxEmoteUnion FromIActorFxEmoteStop(IActorFxEmoteStopT _iactorfxemotestop)
		{
			return new TActorFxEmoteUnion
			{
				Type = TActorFxEmote.IActorFxEmoteStop,
				Value = _iactorfxemotestop
			};
		}

		// Token: 0x0603A65D RID: 239197 RVA: 0x007DD3E8 File Offset: 0x007DB5E8
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
