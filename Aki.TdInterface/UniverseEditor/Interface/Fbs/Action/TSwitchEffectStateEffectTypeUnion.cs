using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B7 RID: 30647
	public class TSwitchEffectStateEffectTypeUnion
	{
		// Token: 0x1700E6BD RID: 59069
		// (get) Token: 0x060379B4 RID: 227764 RVA: 0x007858CA File Offset: 0x00783ACA
		// (set) Token: 0x060379B5 RID: 227765 RVA: 0x007858D2 File Offset: 0x00783AD2
		public TSwitchEffectStateEffectType Type { get; set; }

		// Token: 0x1700E6BE RID: 59070
		// (get) Token: 0x060379B6 RID: 227766 RVA: 0x007858DB File Offset: 0x00783ADB
		// (set) Token: 0x060379B7 RID: 227767 RVA: 0x007858E3 File Offset: 0x00783AE3
		public object Value { get; set; }

		// Token: 0x060379B8 RID: 227768 RVA: 0x007858EC File Offset: 0x00783AEC
		public TSwitchEffectStateEffectTypeUnion()
		{
			this.Type = TSwitchEffectStateEffectType.NONE;
			this.Value = null;
		}

		// Token: 0x060379B9 RID: 227769 RVA: 0x00785902 File Offset: 0x00783B02
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379BA RID: 227770 RVA: 0x00785914 File Offset: 0x00783B14
		public ISwitchScreenEffectStateT AsISwitchScreenEffectState()
		{
			return this.As<ISwitchScreenEffectStateT>();
		}

		// Token: 0x060379BB RID: 227771 RVA: 0x0078591C File Offset: 0x00783B1C
		public static TSwitchEffectStateEffectTypeUnion FromISwitchScreenEffectState(ISwitchScreenEffectStateT _iswitchscreeneffectstate)
		{
			return new TSwitchEffectStateEffectTypeUnion
			{
				Type = TSwitchEffectStateEffectType.ISwitchScreenEffectState,
				Value = _iswitchscreeneffectstate
			};
		}

		// Token: 0x060379BC RID: 227772 RVA: 0x00785931 File Offset: 0x00783B31
		public ISwitchTrailChainEffectStateT AsISwitchTrailChainEffectState()
		{
			return this.As<ISwitchTrailChainEffectStateT>();
		}

		// Token: 0x060379BD RID: 227773 RVA: 0x00785939 File Offset: 0x00783B39
		public static TSwitchEffectStateEffectTypeUnion FromISwitchTrailChainEffectState(ISwitchTrailChainEffectStateT _iswitchtrailchaineffectstate)
		{
			return new TSwitchEffectStateEffectTypeUnion
			{
				Type = TSwitchEffectStateEffectType.ISwitchTrailChainEffectState,
				Value = _iswitchtrailchaineffectstate
			};
		}

		// Token: 0x060379BE RID: 227774 RVA: 0x00785950 File Offset: 0x00783B50
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
