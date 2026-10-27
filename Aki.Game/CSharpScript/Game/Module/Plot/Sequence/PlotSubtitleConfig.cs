using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005014 RID: 20500
	public class PlotSubtitleConfig
	{
		// Token: 0x0603477D RID: 214909 RVA: 0x00C5BBD2 File Offset: 0x00C59DD2
		[NullableContext(1)]
		public void CopyFrom(PlotSubtitleConfig other)
		{
			this.Subtitles = other.Subtitles;
			this.GuardTime = other.GuardTime;
			this.AudioDelay = other.AudioDelay;
			this.AudioTransitionDuration = other.AudioTransitionDuration;
			this.AutoPlayDelay = other.AutoPlayDelay;
		}

		// Token: 0x0603477E RID: 214910 RVA: 0x00C5BC10 File Offset: 0x00C59E10
		public void Clear()
		{
			this.Subtitles = null;
			this.GuardTime = 0f;
			this.AudioDelay = 0f;
			this.AudioTransitionDuration = 0f;
			this.AutoPlayDelay = 0f;
		}

		// Token: 0x0401BF2B RID: 114475
		[Nullable(2)]
		public ITalkItem Subtitles;

		// Token: 0x0401BF2C RID: 114476
		public float GuardTime;

		// Token: 0x0401BF2D RID: 114477
		public float AudioDelay;

		// Token: 0x0401BF2E RID: 114478
		public float AudioTransitionDuration;

		// Token: 0x0401BF2F RID: 114479
		public float AutoPlayDelay;
	}
}
