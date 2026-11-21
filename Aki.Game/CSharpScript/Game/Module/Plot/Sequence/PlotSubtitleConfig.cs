using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FDE RID: 16350
	public class PlotSubtitleConfig
	{
		// Token: 0x06029620 RID: 169504 RVA: 0x00BA7112 File Offset: 0x00BA5312
		[NullableContext(1)]
		public void CopyFrom(PlotSubtitleConfig other)
		{
			this.Subtitles = other.Subtitles;
			this.GuardTime = other.GuardTime;
			this.AudioDelay = other.AudioDelay;
			this.AudioTransitionDuration = other.AudioTransitionDuration;
			this.AutoPlayDelay = other.AutoPlayDelay;
		}

		// Token: 0x06029621 RID: 169505 RVA: 0x00BA7150 File Offset: 0x00BA5350
		public void Clear()
		{
			this.Subtitles = null;
			this.GuardTime = 0f;
			this.AudioDelay = 0f;
			this.AudioTransitionDuration = 0f;
			this.AutoPlayDelay = 0f;
		}

		// Token: 0x04016914 RID: 92436
		[Nullable(2)]
		public ITalkItem Subtitles;

		// Token: 0x04016915 RID: 92437
		public float GuardTime;

		// Token: 0x04016916 RID: 92438
		public float AudioDelay;

		// Token: 0x04016917 RID: 92439
		public float AudioTransitionDuration;

		// Token: 0x04016918 RID: 92440
		public float AutoPlayDelay;
	}
}
