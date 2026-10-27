using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction
{
	// Token: 0x02004F3D RID: 20285
	[NullableContext(2)]
	[Nullable(0)]
	public class IQtaPromptResource
	{
		// Token: 0x0401BA01 RID: 113153
		public List<long> CueIds;

		// Token: 0x0401BA02 RID: 113154
		public EffectScreenPlayData_C ScreenEffect1;

		// Token: 0x0401BA03 RID: 113155
		public EffectModelPostProcess ScreenEffect2;

		// Token: 0x0401BA04 RID: 113156
		public string ScreenEffect2Path;

		// Token: 0x0401BA05 RID: 113157
		public UClass CameraShake;

		// Token: 0x0401BA06 RID: 113158
		public UKuroForceFeedbackEffect GamepadShake;

		// Token: 0x0401BA07 RID: 113159
		public string Audio;
	}
}
