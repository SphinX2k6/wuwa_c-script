using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02003C39 RID: 15417
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelFinishParams
	{
		// Token: 0x060277E1 RID: 161761 RVA: 0x00B13020 File Offset: 0x00B11220
		public void ParseFinishParamsByProto(SeamlessTeleportFinishConfigPb config)
		{
			this.NotStopScreenEffect = config.IsNotStopScreenEffect;
			this.ScreenEffectExtraState = config.EffectExtraState;
		}

		// Token: 0x060277E2 RID: 161762 RVA: 0x00B1303C File Offset: 0x00B1123C
		public void ParseFinishParamsByConfig(ISeamlessTeleportFinishConfig config)
		{
			this.NotStopScreenEffect = config.IsNotStopScreenEffect.GetValueOrDefault();
			this.ScreenEffectExtraState = config.EffectExtraState.GetValueOrDefault(-1);
		}

		// Token: 0x04015854 RID: 88148
		public bool NotStopScreenEffect;

		// Token: 0x04015855 RID: 88149
		public int ScreenEffectExtraState = -1;
	}
}
