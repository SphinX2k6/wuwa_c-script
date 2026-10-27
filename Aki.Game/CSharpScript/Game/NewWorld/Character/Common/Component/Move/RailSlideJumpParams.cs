using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.RailSlide;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F7 RID: 28919
	[NullableContext(1)]
	[Nullable(0)]
	public class RailSlideJumpParams
	{
		// Token: 0x0604699C RID: 289180 RVA: 0x011C2CA4 File Offset: 0x011C0EA4
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

		// Token: 0x0604699D RID: 289181 RVA: 0x011C2D50 File Offset: 0x011C0F50
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

		// Token: 0x04025089 RID: 151689
		public int BaseJumpHeight = 50;

		// Token: 0x0402508A RID: 151690
		public float BaseJumpDistanceRate = 0.5f;

		// Token: 0x0402508B RID: 151691
		public int MaxJumpDistance = 1000;

		// Token: 0x0402508C RID: 151692
		public int MaxJumpHeight = 300;

		// Token: 0x0402508D RID: 151693
		public int JumpAcceleration = -1000;

		// Token: 0x0402508E RID: 151694
		public int TargetSpeedForJump = 300;

		// Token: 0x0402508F RID: 151695
		public int AllTimeForJump = 800;

		// Token: 0x04025090 RID: 151696
		public int JumpBlendTime = 200;

		// Token: 0x04025091 RID: 151697
		public int LandBlendTime;
	}
}
