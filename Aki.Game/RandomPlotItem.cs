using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot.Flow;

// Token: 0x02001C27 RID: 7207
public class RandomPlotItem
{
	// Token: 0x06011EA2 RID: 73378 RVA: 0x0054621C File Offset: 0x0054441C
	[NullableContext(1)]
	public static RandomPlotItem Create(RandomPlot config)
	{
		RandomPlotItem randomPlotItem = new RandomPlotItem();
		randomPlotItem.Probability = (float)config.Probability / 100f;
		randomPlotItem.Cooldown = (float)(config.Cooldown * 1000);
		int clientPlotReferenceListLength = config.ClientPlotReferenceListLength;
		for (int i = 0; i < clientPlotReferenceListLength; i++)
		{
			PlotReference? config2 = ConfigPlotReferenceById.GetConfig(config.ClientPlotReferenceList(i), true);
			if (config2 != null)
			{
				string plot = config2.Value.Plot;
				if (plot != null)
				{
					string[] array = plot.Split(',', StringSplitOptions.None);
					randomPlotItem.FlowConfigs.Add(new RandomPlotItem.FlowConfig
					{
						FlowListName = array[0],
						FlowId = int.Parse(array[1]),
						StateId = int.Parse(array[2])
					});
				}
			}
		}
		return randomPlotItem;
	}

	// Token: 0x06011EA3 RID: 73379 RVA: 0x005462E0 File Offset: 0x005444E0
	public void PlayRandomPlot()
	{
		double playerTime = Time.Instance.PlayerTime;
		if (playerTime < this.CooldownFinishStamp)
		{
			return;
		}
		float probability = this.Probability;
		if (probability == 0f)
		{
			return;
		}
		float num = Random.Shared.NextSingle();
		if (probability < 1f && num > probability)
		{
			return;
		}
		int count = this.FlowConfigs.Count;
		float num2 = Random.Shared.NextSingle();
		int index = MathUtils.Instance.Clamp((int)Math.Floor((double)(num2 * (float)count)), 0, count - 1);
		RandomPlotItem.FlowConfig flowConfig = this.FlowConfigs[index];
		FlowController.Instance.StartFlow(flowConfig.FlowListName, flowConfig.FlowId, flowConfig.StateId, null, 0L, false, false, false, null);
		this.CooldownFinishStamp = playerTime + (double)this.Cooldown;
	}

	// Token: 0x04009C2E RID: 39982
	private float Probability;

	// Token: 0x04009C2F RID: 39983
	private float Cooldown;

	// Token: 0x04009C30 RID: 39984
	[Nullable(1)]
	private readonly List<RandomPlotItem.FlowConfig> FlowConfigs = new List<RandomPlotItem.FlowConfig>();

	// Token: 0x04009C31 RID: 39985
	private double CooldownFinishStamp;

	// Token: 0x02007F39 RID: 32569
	private class FlowConfig
	{
		// Token: 0x040292FE RID: 168702
		[Nullable(1)]
		public string FlowListName = "";

		// Token: 0x040292FF RID: 168703
		public int FlowId;

		// Token: 0x04029300 RID: 168704
		public int StateId;
	}
}
