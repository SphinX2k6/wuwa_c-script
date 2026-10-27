using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SplineClimb;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070FD RID: 28925
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineClimbParams
	{
		// Token: 0x060469E4 RID: 289252 RVA: 0x011C4590 File Offset: 0x011C2790
		[NullableContext(2)]
		public SplineClimbParams(BP_SplineClimbConfig_C asset = null)
		{
			if (asset == null)
			{
				return;
			}
			this.Tags = GameplayTagUtils.ConvertFromUeContainer(asset.期间Tag);
			for (int i = 0; i < asset.打断技能.Num(); i++)
			{
				this.InterruptSkills.Add((long)asset.打断技能.Get(i));
			}
			this.SampleLength = asset.采样长度;
			this.SampleInterval = (double)asset.采样间隔;
			this.TraceLength = (double)asset.检测距离;
			this.TraceStartOffset = (double)asset.检测起始偏移;
			this.ExtraWallRadius = (double)asset.离墙额外距离;
			this.DebugDraw = asset.DebugDraw;
		}

		// Token: 0x040250E3 RID: 151779
		public IList<int> Tags = new List<int>();

		// Token: 0x040250E4 RID: 151780
		public List<long> InterruptSkills = new List<long>();

		// Token: 0x040250E5 RID: 151781
		public float SampleLength = 200f;

		// Token: 0x040250E6 RID: 151782
		public double SampleInterval = 50.0;

		// Token: 0x040250E7 RID: 151783
		public double TraceLength = 1500.0;

		// Token: 0x040250E8 RID: 151784
		public double TraceStartOffset = -200.0;

		// Token: 0x040250E9 RID: 151785
		public double ExtraWallRadius = 2.5;

		// Token: 0x040250EA RID: 151786
		public bool DebugDraw;
	}
}
