using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A35 RID: 31285
	public class ISwitchEffectStateEffectBase_UnionUnion
	{
		// Token: 0x1700E537 RID: 58679
		// (get) Token: 0x06037208 RID: 225800 RVA: 0x0075D895 File Offset: 0x0075BA95
		// (set) Token: 0x06037209 RID: 225801 RVA: 0x0075D89D File Offset: 0x0075BA9D
		public ISwitchEffectStateEffectBase_Union Type { get; set; }

		// Token: 0x1700E538 RID: 58680
		// (get) Token: 0x0603720A RID: 225802 RVA: 0x0075D8A6 File Offset: 0x0075BAA6
		// (set) Token: 0x0603720B RID: 225803 RVA: 0x0075D8AE File Offset: 0x0075BAAE
		public object Value { get; set; }

		// Token: 0x0603720C RID: 225804 RVA: 0x0075D8B7 File Offset: 0x0075BAB7
		public ISwitchEffectStateEffectBase_UnionUnion()
		{
			this.Type = ISwitchEffectStateEffectBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603720D RID: 225805 RVA: 0x0075D8CD File Offset: 0x0075BACD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603720E RID: 225806 RVA: 0x0075D8DF File Offset: 0x0075BADF
		public ISwitchEffectStateEffectBaseT AsISwitchEffectStateEffectBase()
		{
			return this.As<ISwitchEffectStateEffectBaseT>();
		}

		// Token: 0x0603720F RID: 225807 RVA: 0x0075D8E7 File Offset: 0x0075BAE7
		public static ISwitchEffectStateEffectBase_UnionUnion FromISwitchEffectStateEffectBase(ISwitchEffectStateEffectBaseT _iswitcheffectstateeffectbase)
		{
			return new ISwitchEffectStateEffectBase_UnionUnion
			{
				Type = ISwitchEffectStateEffectBase_Union.ISwitchEffectStateEffectBase,
				Value = _iswitcheffectstateeffectbase
			};
		}

		// Token: 0x06037210 RID: 225808 RVA: 0x0075D8FC File Offset: 0x0075BAFC
		public ISwitchScreenEffectStateT AsISwitchScreenEffectState()
		{
			return this.As<ISwitchScreenEffectStateT>();
		}

		// Token: 0x06037211 RID: 225809 RVA: 0x0075D904 File Offset: 0x0075BB04
		public static ISwitchEffectStateEffectBase_UnionUnion FromISwitchScreenEffectState(ISwitchScreenEffectStateT _iswitchscreeneffectstate)
		{
			return new ISwitchEffectStateEffectBase_UnionUnion
			{
				Type = ISwitchEffectStateEffectBase_Union.ISwitchScreenEffectState,
				Value = _iswitchscreeneffectstate
			};
		}

		// Token: 0x06037212 RID: 225810 RVA: 0x0075D919 File Offset: 0x0075BB19
		public ISwitchTrailChainEffectStateT AsISwitchTrailChainEffectState()
		{
			return this.As<ISwitchTrailChainEffectStateT>();
		}

		// Token: 0x06037213 RID: 225811 RVA: 0x0075D921 File Offset: 0x0075BB21
		public static ISwitchEffectStateEffectBase_UnionUnion FromISwitchTrailChainEffectState(ISwitchTrailChainEffectStateT _iswitchtrailchaineffectstate)
		{
			return new ISwitchEffectStateEffectBase_UnionUnion
			{
				Type = ISwitchEffectStateEffectBase_Union.ISwitchTrailChainEffectState,
				Value = _iswitchtrailchaineffectstate
			};
		}

		// Token: 0x06037214 RID: 225812 RVA: 0x0075D938 File Offset: 0x0075BB38
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
