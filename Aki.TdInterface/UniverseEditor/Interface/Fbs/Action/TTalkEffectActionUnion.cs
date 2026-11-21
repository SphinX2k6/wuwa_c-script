using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FFB RID: 32763
	public class TTalkEffectActionUnion
	{
		// Token: 0x1700F31F RID: 62239
		// (get) Token: 0x0603AF71 RID: 241521 RVA: 0x007EB43C File Offset: 0x007E963C
		// (set) Token: 0x0603AF72 RID: 241522 RVA: 0x007EB444 File Offset: 0x007E9644
		public TTalkEffectAction Type { get; set; }

		// Token: 0x1700F320 RID: 62240
		// (get) Token: 0x0603AF73 RID: 241523 RVA: 0x007EB44D File Offset: 0x007E964D
		// (set) Token: 0x0603AF74 RID: 241524 RVA: 0x007EB455 File Offset: 0x007E9655
		public object Value { get; set; }

		// Token: 0x0603AF75 RID: 241525 RVA: 0x007EB45E File Offset: 0x007E965E
		public TTalkEffectActionUnion()
		{
			this.Type = TTalkEffectAction.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF76 RID: 241526 RVA: 0x007EB474 File Offset: 0x007E9674
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF77 RID: 241527 RVA: 0x007EB486 File Offset: 0x007E9686
		public ITalkEffectPlayT AsITalkEffectPlay()
		{
			return this.As<ITalkEffectPlayT>();
		}

		// Token: 0x0603AF78 RID: 241528 RVA: 0x007EB48E File Offset: 0x007E968E
		public static TTalkEffectActionUnion FromITalkEffectPlay(ITalkEffectPlayT _italkeffectplay)
		{
			return new TTalkEffectActionUnion
			{
				Type = TTalkEffectAction.ITalkEffectPlay,
				Value = _italkeffectplay
			};
		}

		// Token: 0x0603AF79 RID: 241529 RVA: 0x007EB4A3 File Offset: 0x007E96A3
		public ITalkEffectStopT AsITalkEffectStop()
		{
			return this.As<ITalkEffectStopT>();
		}

		// Token: 0x0603AF7A RID: 241530 RVA: 0x007EB4AB File Offset: 0x007E96AB
		public static TTalkEffectActionUnion FromITalkEffectStop(ITalkEffectStopT _italkeffectstop)
		{
			return new TTalkEffectActionUnion
			{
				Type = TTalkEffectAction.ITalkEffectStop,
				Value = _italkeffectstop
			};
		}

		// Token: 0x0603AF7B RID: 241531 RVA: 0x007EB4C0 File Offset: 0x007E96C0
		public static int Pack(FlatBufferBuilder builder, TTalkEffectActionUnion _o)
		{
			TTalkEffectAction type = _o.Type;
			if (type == TTalkEffectAction.ITalkEffectPlay)
			{
				return ITalkEffectPlay.Pack(builder, _o.AsITalkEffectPlay()).Value;
			}
			if (type != TTalkEffectAction.ITalkEffectStop)
			{
				return 0;
			}
			return ITalkEffectStop.Pack(builder, _o.AsITalkEffectStop()).Value;
		}
	}
}
