using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FEF RID: 32751
	public class TSwitchEffectStateEffectTypeUnion
	{
		// Token: 0x1700F317 RID: 62231
		// (get) Token: 0x0603AF35 RID: 241461 RVA: 0x007EAE9A File Offset: 0x007E909A
		// (set) Token: 0x0603AF36 RID: 241462 RVA: 0x007EAEA2 File Offset: 0x007E90A2
		public TSwitchEffectStateEffectType Type { get; set; }

		// Token: 0x1700F318 RID: 62232
		// (get) Token: 0x0603AF37 RID: 241463 RVA: 0x007EAEAB File Offset: 0x007E90AB
		// (set) Token: 0x0603AF38 RID: 241464 RVA: 0x007EAEB3 File Offset: 0x007E90B3
		public object Value { get; set; }

		// Token: 0x0603AF39 RID: 241465 RVA: 0x007EAEBC File Offset: 0x007E90BC
		public TSwitchEffectStateEffectTypeUnion()
		{
			this.Type = TSwitchEffectStateEffectType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF3A RID: 241466 RVA: 0x007EAED2 File Offset: 0x007E90D2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF3B RID: 241467 RVA: 0x007EAEE4 File Offset: 0x007E90E4
		public ISwitchScreenEffectStateT AsISwitchScreenEffectState()
		{
			return this.As<ISwitchScreenEffectStateT>();
		}

		// Token: 0x0603AF3C RID: 241468 RVA: 0x007EAEEC File Offset: 0x007E90EC
		public static TSwitchEffectStateEffectTypeUnion FromISwitchScreenEffectState(ISwitchScreenEffectStateT _iswitchscreeneffectstate)
		{
			return new TSwitchEffectStateEffectTypeUnion
			{
				Type = TSwitchEffectStateEffectType.ISwitchScreenEffectState,
				Value = _iswitchscreeneffectstate
			};
		}

		// Token: 0x0603AF3D RID: 241469 RVA: 0x007EAF01 File Offset: 0x007E9101
		public ISwitchTrailChainEffectStateT AsISwitchTrailChainEffectState()
		{
			return this.As<ISwitchTrailChainEffectStateT>();
		}

		// Token: 0x0603AF3E RID: 241470 RVA: 0x007EAF09 File Offset: 0x007E9109
		public static TSwitchEffectStateEffectTypeUnion FromISwitchTrailChainEffectState(ISwitchTrailChainEffectStateT _iswitchtrailchaineffectstate)
		{
			return new TSwitchEffectStateEffectTypeUnion
			{
				Type = TSwitchEffectStateEffectType.ISwitchTrailChainEffectState,
				Value = _iswitchtrailchaineffectstate
			};
		}

		// Token: 0x0603AF3F RID: 241471 RVA: 0x007EAF20 File Offset: 0x007E9120
		public static int Pack(FlatBufferBuilder builder, TSwitchEffectStateEffectTypeUnion _o)
		{
			TSwitchEffectStateEffectType type = _o.Type;
			if (type == TSwitchEffectStateEffectType.ISwitchScreenEffectState)
			{
				return ISwitchScreenEffectState.Pack(builder, _o.AsISwitchScreenEffectState()).Value;
			}
			if (type != TSwitchEffectStateEffectType.ISwitchTrailChainEffectState)
			{
				return 0;
			}
			return ISwitchTrailChainEffectState.Pack(builder, _o.AsISwitchTrailChainEffectState()).Value;
		}
	}
}
