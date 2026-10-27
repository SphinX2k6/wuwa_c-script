using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.RailSlideFollower;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B8 RID: 28856
	public class RailSlideFollowerParams
	{
		// Token: 0x060465BE RID: 288190 RVA: 0x011A1DE8 File Offset: 0x0119FFE8
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

		// Token: 0x04024DC7 RID: 150983
		public float DelayStartFollow;

		// Token: 0x04024DC8 RID: 150984
		public bool FollowOnRight = true;

		// Token: 0x04024DC9 RID: 150985
		public bool AutoChangeSide;

		// Token: 0x04024DCA RID: 150986
		public float DynamicDistance;

		// Token: 0x04024DCB RID: 150987
		public float FrontDistance;

		// Token: 0x04024DCC RID: 150988
		public float FollowerLerpSpeed;

		// Token: 0x04024DCD RID: 150989
		public float FollowSpeedStepRate;

		// Token: 0x04024DCE RID: 150990
		public ValueTuple<float, float> SideDistance = new ValueTuple<float, float>(0f, 0f);

		// Token: 0x04024DCF RID: 150991
		public float ToleranceDistance;

		// Token: 0x04024DD0 RID: 150992
		private const float FOLLOWER_TOLERANCE_DIST = 20f;
	}
}
