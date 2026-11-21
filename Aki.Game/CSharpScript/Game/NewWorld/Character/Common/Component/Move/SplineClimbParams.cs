using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.SplineClimb;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063AD RID: 25517
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineClimbParams
	{
		// Token: 0x0603DDE0 RID: 253408 RVA: 0x011F36E8 File Offset: 0x011F18E8
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

		// Token: 0x04020D78 RID: 134520
		public IList<int> Tags = new List<int>();

		// Token: 0x04020D79 RID: 134521
		public List<long> InterruptSkills = new List<long>();

		// Token: 0x04020D7A RID: 134522
		public float SampleLength = 200f;

		// Token: 0x04020D7B RID: 134523
		public double SampleInterval = 50.0;

		// Token: 0x04020D7C RID: 134524
		public double TraceLength = 1500.0;

		// Token: 0x04020D7D RID: 134525
		public double TraceStartOffset = -200.0;

		// Token: 0x04020D7E RID: 134526
		public double ExtraWallRadius = 2.5;

		// Token: 0x04020D7F RID: 134527
		public bool DebugDraw;
	}
}
