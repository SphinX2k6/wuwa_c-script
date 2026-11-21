using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.RailSlideFollower;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006317 RID: 25367
	public class RailSlideFollowerParams
	{
		// Token: 0x0603D668 RID: 251496 RVA: 0x011BF6BC File Offset: 0x011BD8BC
		[NullableContext(1)]
		public RailSlideFollowerParams(BP_RailSlideFollowerConfig_C asset = null)
		{
			if (asset != null)
			{
				this.AutoChangeSide = asset.AutoChangeSide;
				this.DelayStartFollow = (float)asset.DelayStartFollow;
				this.DynamicDistance = (float)asset.DynamicDistance;
				this.FollowOnRight = asset.FollowOnRight;
				this.FrontDistance = (float)asset.FrontDistance;
				this.SideDistance = new ValueTuple<float, float>(asset.SideDistance.X, asset.SideDistance.Y);
				this.ToleranceDistance = Math.Max(20f, (float)asset.ToleranceDistance);
				this.FollowerLerpSpeed = (float)asset.FollowerLerpSpeed;
				this.FollowSpeedStepRate = asset.FollowSpeedStepRate;
			}
		}

		// Token: 0x040208EE RID: 133358
		public float DelayStartFollow;

		// Token: 0x040208EF RID: 133359
		public bool FollowOnRight = true;

		// Token: 0x040208F0 RID: 133360
		public bool AutoChangeSide;

		// Token: 0x040208F1 RID: 133361
		public float DynamicDistance;

		// Token: 0x040208F2 RID: 133362
		public float FrontDistance;

		// Token: 0x040208F3 RID: 133363
		public float FollowerLerpSpeed;

		// Token: 0x040208F4 RID: 133364
		public float FollowSpeedStepRate;

		// Token: 0x040208F5 RID: 133365
		public ValueTuple<float, float> SideDistance = new ValueTuple<float, float>(0f, 0f);

		// Token: 0x040208F6 RID: 133366
		public float ToleranceDistance;

		// Token: 0x040208F7 RID: 133367
		private const float FOLLOWER_TOLERANCE_DIST = 20f;
	}
}
