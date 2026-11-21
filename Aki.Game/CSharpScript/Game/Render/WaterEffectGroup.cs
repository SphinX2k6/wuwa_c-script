using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003508 RID: 13576
	[NullableContext(1)]
	[Nullable(0)]
	public class WaterEffectGroup
	{
		// Token: 0x060228EC RID: 141548 RVA: 0x009D1E90 File Offset: 0x009D0090
		[NullableContext(2)]
		public WaterEffectItem FindEffectAtSpeed(double speed)
		{
			int num = 0;
			while (num < this.EffectItems.Count && speed >= this.EffectItems[num].SpeedThreshold)
			{
				num++;
			}
			if (num == 0)
			{
				return null;
			}
			return this.EffectItems[num - 1];
		}

		// Token: 0x060228ED RID: 141549 RVA: 0x009D1EDC File Offset: 0x009D00DC
		public void Init(SWaterEffectGroup configData)
		{
			this.WaterDepthThreshold = (double)configData.WaterDepth;
			int num = configData.EffectConfig.Num();
			this.EffectItems.Clear();
			for (int i = 0; i < num; i++)
			{
				WaterEffectItem waterEffectItem = new WaterEffectItem();
				waterEffectItem.Init(configData.EffectConfig.Get(i));
				this.EffectItems.Add(waterEffectItem);
			}
		}

		// Token: 0x04013207 RID: 78343
		public double WaterDepthThreshold;

		// Token: 0x04013208 RID: 78344
		public List<WaterEffectItem> EffectItems = new List<WaterEffectItem>();
	}
}
