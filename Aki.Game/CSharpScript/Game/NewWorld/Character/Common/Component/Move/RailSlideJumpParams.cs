using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.RailSlide;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A7 RID: 25511
	[NullableContext(1)]
	[Nullable(0)]
	public class RailSlideJumpParams
	{
		// Token: 0x0603DD95 RID: 253333 RVA: 0x011F1E58 File Offset: 0x011F0058
		public void InitSideJump(BP_RailSlideConfig_C asset, bool? isKatixiya = null)
		{
			this.BaseJumpDistanceRate = asset.基础跳远倍率;
			this.BaseJumpHeight = asset.基础跳跃高度;
			this.MaxJumpDistance = asset.最大跳跃距离;
			this.MaxJumpHeight = asset.最大跳跃高度;
			this.JumpAcceleration = (isKatixiya.GetValueOrDefault() ? asset.起跳加速度_卡提西亚 : asset.起跳加速度);
			this.TargetSpeedForJump = asset.起跳目标速度;
			this.AllTimeForJump = asset.跳跃空中总时长;
			this.JumpBlendTime = (isKatixiya.GetValueOrDefault() ? asset.起跳时长_卡提西亚 : asset.起跳时长);
			this.LandBlendTime = (isKatixiya.GetValueOrDefault() ? asset.落地时长_卡提西亚 : asset.落地时长);
		}

		// Token: 0x0603DD96 RID: 253334 RVA: 0x011F1F04 File Offset: 0x011F0104
		public void InitFreeJump(BP_RailSlideConfig_C asset)
		{
			this.BaseJumpDistanceRate = asset.前向基础跳远倍率;
			this.BaseJumpHeight = asset.前向基础跳跃高度;
			this.MaxJumpDistance = asset.前向最大跳跃距离;
			this.MaxJumpHeight = asset.前向最大跳跃高度;
			this.JumpAcceleration = asset.前向起跳加速度;
			this.TargetSpeedForJump = asset.前向起跳目标速度;
			this.AllTimeForJump = asset.前向跳跃空中总时长;
			this.JumpBlendTime = asset.前向起跳时长;
			this.LandBlendTime = asset.前向落地时长;
		}

		// Token: 0x04020D1E RID: 134430
		public int BaseJumpHeight = 50;

		// Token: 0x04020D1F RID: 134431
		public float BaseJumpDistanceRate = 0.5f;

		// Token: 0x04020D20 RID: 134432
		public int MaxJumpDistance = 1000;

		// Token: 0x04020D21 RID: 134433
		public int MaxJumpHeight = 300;

		// Token: 0x04020D22 RID: 134434
		public int JumpAcceleration = -1000;

		// Token: 0x04020D23 RID: 134435
		public int TargetSpeedForJump = 300;

		// Token: 0x04020D24 RID: 134436
		public int AllTimeForJump = 800;

		// Token: 0x04020D25 RID: 134437
		public int JumpBlendTime = 200;

		// Token: 0x04020D26 RID: 134438
		public int LandBlendTime;
	}
}
