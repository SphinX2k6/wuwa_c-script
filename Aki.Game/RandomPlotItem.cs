using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Plot.Flow;

// Token: 0x0200273C RID: 10044
public class RandomPlotItem
{
	// Token: 0x060149C0 RID: 84416 RVA: 0x00537510 File Offset: 0x00535710
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

	// Token: 0x060149C1 RID: 84417 RVA: 0x005375D4 File Offset: 0x005357D4
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

	// Token: 0x04009AD6 RID: 39638
	private float Probability;

	// Token: 0x04009AD7 RID: 39639
	private float Cooldown;

	// Token: 0x04009AD8 RID: 39640
	[Nullable(1)]
	private readonly List<RandomPlotItem.FlowConfig> FlowConfigs = new List<RandomPlotItem.FlowConfig>();

	// Token: 0x04009AD9 RID: 39641
	private double CooldownFinishStamp;

	// Token: 0x02008DB1 RID: 36273
	private class FlowConfig
	{
		// Token: 0x0402DFE8 RID: 188392
		[Nullable(1)]
		public string FlowListName = "";

		// Token: 0x0402DFE9 RID: 188393
		public int FlowId;

		// Token: 0x0402DFEA RID: 188394
		public int StateId;
	}
}
