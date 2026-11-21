using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003507 RID: 13575
	public class WaterEffectItem
	{
		// Token: 0x060228EA RID: 141546 RVA: 0x009D1E5F File Offset: 0x009D005F
		[NullableContext(1)]
		public void Init(SWaterEffectItem configData)
		{
			this.SpeedThreshold = (double)configData.Speed;
			this.EffectDataPath = configData.EffectDataRef;
			this.AudioEffectDataPath = configData.AudioEffectDataRef;
		}

		// Token: 0x04013204 RID: 78340
		public double SpeedThreshold;

		// Token: 0x04013205 RID: 78341
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UEffectModelBase> EffectDataPath;

		// Token: 0x04013206 RID: 78342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public TSoftObjectPtr<UEffectModelBase> AudioEffectDataPath;
	}
}
