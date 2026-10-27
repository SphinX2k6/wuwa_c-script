using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045DE RID: 17886
	public class WaterEffectItem
	{
		// Token: 0x0602E1F6 RID: 188918 RVA: 0x00AA5783 File Offset: 0x00AA3983
		[NullableContext(1)]
		public void Init(SWaterEffectItem configData)
		{
			this.SpeedThreshold = (double)configData.Speed;
			this.EffectDataPath = configData.EffectDataRef;
			this.AudioEffectDataPath = configData.AudioEffectDataRef;
		}

		// Token: 0x04018BC6 RID: 101318
		public double SpeedThreshold;

		// Token: 0x04018BC7 RID: 101319
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UEffectModelBase> EffectDataPath;

		// Token: 0x04018BC8 RID: 101320
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UEffectModelBase> AudioEffectDataPath;
	}
}
