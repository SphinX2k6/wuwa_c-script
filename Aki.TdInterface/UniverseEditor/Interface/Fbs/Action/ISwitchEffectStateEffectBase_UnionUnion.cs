using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007260 RID: 29280
	public class ISwitchEffectStateEffectBase_UnionUnion
	{
		// Token: 0x1700D93E RID: 55614
		// (get) Token: 0x06033F06 RID: 212742 RVA: 0x006FC535 File Offset: 0x006FA735
		// (set) Token: 0x06033F07 RID: 212743 RVA: 0x006FC53D File Offset: 0x006FA73D
		public ISwitchEffectStateEffectBase_Union Type { get; set; }

		// Token: 0x1700D93F RID: 55615
		// (get) Token: 0x06033F08 RID: 212744 RVA: 0x006FC546 File Offset: 0x006FA746
		// (set) Token: 0x06033F09 RID: 212745 RVA: 0x006FC54E File Offset: 0x006FA74E
		public object Value { get; set; }

		// Token: 0x06033F0A RID: 212746 RVA: 0x006FC557 File Offset: 0x006FA757
		public ISwitchEffectStateEffectBase_UnionUnion()
		{
			this.Type = ISwitchEffectStateEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033F0B RID: 212747 RVA: 0x006FC56D File Offset: 0x006FA76D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033F0C RID: 212748 RVA: 0x006FC57F File Offset: 0x006FA77F
		public ISwitchEffectStateEffectBaseT AsISwitchEffectStateEffectBase()
		{
			return this.As<ISwitchEffectStateEffectBaseT>();
		}

		// Token: 0x06033F0D RID: 212749 RVA: 0x006FC587 File Offset: 0x006FA787
		public static ISwitchEffectStateEffectBase_UnionUnion FromISwitchEffectStateEffectBase(ISwitchEffectStateEffectBaseT _iswitcheffectstateeffectbase)
		{
			return new ISwitchEffectStateEffectBase_UnionUnion
			{
				Type = ISwitchEffectStateEffectBase_Union.ISwitchEffectStateEffectBase,
				Value = _iswitcheffectstateeffectbase
			};
		}

		// Token: 0x06033F0E RID: 212750 RVA: 0x006FC59C File Offset: 0x006FA79C
		public ISwitchScreenEffectStateT AsISwitchScreenEffectState()
		{
			return this.As<ISwitchScreenEffectStateT>();
		}

		// Token: 0x06033F0F RID: 212751 RVA: 0x006FC5A4 File Offset: 0x006FA7A4
		public static ISwitchEffectStateEffectBase_UnionUnion FromISwitchScreenEffectState(ISwitchScreenEffectStateT _iswitchscreeneffectstate)
		{
			return new ISwitchEffectStateEffectBase_UnionUnion
			{
				Type = ISwitchEffectStateEffectBase_Union.ISwitchScreenEffectState,
				Value = _iswitchscreeneffectstate
			};
		}

		// Token: 0x06033F10 RID: 212752 RVA: 0x006FC5B9 File Offset: 0x006FA7B9
		public ISwitchTrailChainEffectStateT AsISwitchTrailChainEffectState()
		{
			return this.As<ISwitchTrailChainEffectStateT>();
		}

		// Token: 0x06033F11 RID: 212753 RVA: 0x006FC5C1 File Offset: 0x006FA7C1
		public static ISwitchEffectStateEffectBase_UnionUnion FromISwitchTrailChainEffectState(ISwitchTrailChainEffectStateT _iswitchtrailchaineffectstate)
		{
			return new ISwitchEffectStateEffectBase_UnionUnion
			{
				Type = ISwitchEffectStateEffectBase_Union.ISwitchTrailChainEffectState,
				Value = _iswitchtrailchaineffectstate
			};
		}

		// Token: 0x06033F12 RID: 212754 RVA: 0x006FC5D8 File Offset: 0x006FA7D8
		public static int Pack(FlatBufferBuilder builder, ISwitchEffectStateEffectBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISwitchEffectStateEffectBase_Union.ISwitchEffectStateEffectBase:
				return ISwitchEffectStateEffectBase.Pack(builder, _o.AsISwitchEffectStateEffectBase()).Value;
			case ISwitchEffectStateEffectBase_Union.ISwitchScreenEffectState:
				return ISwitchScreenEffectState.Pack(builder, _o.AsISwitchScreenEffectState()).Value;
			case ISwitchEffectStateEffectBase_Union.ISwitchTrailChainEffectState:
				return ISwitchTrailChainEffectState.Pack(builder, _o.AsISwitchTrailChainEffectState()).Value;
			default:
				return 0;
			}
		}
	}
}
