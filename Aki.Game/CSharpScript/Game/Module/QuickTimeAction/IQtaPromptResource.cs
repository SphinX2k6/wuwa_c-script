using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02003F06 RID: 16134
	[NullableContext(2)]
	[Nullable(0)]
	public class IQtaPromptResource
	{
		// Token: 0x040163D6 RID: 91094
		public List<long> CueIds;

		// Token: 0x040163D7 RID: 91095
		public EffectScreenPlayData_C ScreenEffect1;

		// Token: 0x040163D8 RID: 91096
		public EffectModelPostProcess ScreenEffect2;

		// Token: 0x040163D9 RID: 91097
		public string ScreenEffect2Path;

		// Token: 0x040163DA RID: 91098
		public UClass CameraShake;

		// Token: 0x040163DB RID: 91099
		public UKuroForceFeedbackEffect GamepadShake;

		// Token: 0x040163DC RID: 91100
		public string Audio;
	}
}
