using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.WaterInteraction;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045DF RID: 17887
	[NullableContext(1)]
	[Nullable(0)]
	public class WaterEffectGroup
	{
		// Token: 0x0602E1F8 RID: 188920 RVA: 0x00AA57B4 File Offset: 0x00AA39B4
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

		// Token: 0x0602E1F9 RID: 188921 RVA: 0x00AA5800 File Offset: 0x00AA3A00
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

		// Token: 0x04018BC9 RID: 101321
		public double WaterDepthThreshold;

		// Token: 0x04018BCA RID: 101322
		public List<WaterEffectItem> EffectItems = new List<WaterEffectItem>();
	}
}
