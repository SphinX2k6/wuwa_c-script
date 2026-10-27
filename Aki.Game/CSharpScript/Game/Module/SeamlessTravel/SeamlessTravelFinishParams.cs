using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.SeamlessTravel
{
	// Token: 0x02004C88 RID: 19592
	[NullableContext(1)]
	[Nullable(0)]
	public class SeamlessTravelFinishParams
	{
		// Token: 0x06032A2E RID: 207406 RVA: 0x00BCE3BC File Offset: 0x00BCC5BC
		public void ParseFinishParamsByProto(SeamlessTeleportFinishConfigPb config)
		{
			this.NotStopScreenEffect = config.IsNotStopScreenEffect;
			this.ScreenEffectExtraState = config.EffectExtraState;
		}

		// Token: 0x06032A2F RID: 207407 RVA: 0x00BCE3D8 File Offset: 0x00BCC5D8
		public void ParseFinishParamsByConfig(ISeamlessTeleportFinishConfig config)
		{
			this.NotStopScreenEffect = config.IsNotStopScreenEffect.GetValueOrDefault();
			this.ScreenEffectExtraState = config.EffectExtraState.GetValueOrDefault(-1);
		}

		// Token: 0x0401AEF7 RID: 110327
		public bool NotStopScreenEffect;

		// Token: 0x0401AEF8 RID: 110328
		public int ScreenEffectExtraState = -1;
	}
}
