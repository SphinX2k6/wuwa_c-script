using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Level.RailSlide;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A8 RID: 25512
	[NullableContext(2)]
	[Nullable(0)]
	public class RailSlideParams
	{
		// Token: 0x0603DD98 RID: 253336 RVA: 0x011F1FE8 File Offset: 0x011F01E8
		public RailSlideParams(BP_RailSlideConfig_C asset = null, bool? isKatixiya = null, int pbDataId = 0)
		{
			if (asset != null)
			{
				this.PbDataId = pbDataId;
				this.InitSpeed = asset.初始速度;
				this.BaseTargetSpeed = asset.基础目标速度;
				this.BaseAcceleration = asset.基础加速度;
				this.AccelerationForUp = asset.上坡加速度;
				this.AccelerationForDown = asset.下坡加速度;
				this.TargetSpeedForUp = asset.上坡目标速度;
				this.TargetSpeedForDown = asset.下坡目标速度;
				this.AccelerationAngle = asset.最大加速度角度;
				this.MaxLandSpeed = asset.落地最大速度;
				this.MinLandSpeed = asset.落地最小速度;
				this.SideJumpParams = new RailSlideJumpParams();
				this.SideJumpParams.InitSideJump(asset, isKatixiya);
				this.StartJumpSpeed = asset.初始进入轨道速度;
				this.LeaningBlendAlpha = asset.倾斜输入插值;
				this.MaxLeaningAngle = asset.最大倾斜角度;
				this.LimitInputAngle = asset.限制输入角度;
				this.DisableGravityLean = asset.禁止重力方向倾斜;
				this.DisablePitchLean = asset.禁止前后俯仰倾斜;
				this.ChangeRailCooldownTime = asset.切换轨道CD;
				this.ChangeRailDistance = asset.切换轨道水平距离;
				this.ChangeRailHeight = asset.切换轨道垂直距离;
				this.ChangeRailSpeed = asset.切换轨道基速度;
				this.MoveCurve = (isKatixiya.GetValueOrDefault() ? asset.位移曲线_卡提西亚.FloatCurve : asset.位移曲线.FloatCurve);
				this.DebugDraw = asset.DebugDraw;
				this.AnimationType = (asset.是否启用定制动作 ? ERailSlideAnimType.SlopeSlide : asset.滑轨动画类型);
				this.LandAnimation = (asset.是否有落地动画 || (isKatixiya.GetValueOrDefault() && this.AnimationType == ERailSlideAnimType.Normal));
				this.FreeJumpParams = new RailSlideJumpParams();
				this.FreeJumpParams.InitFreeJump(asset);
				this.ControlData = new RailControlData(asset, pbDataId);
				for (int i = 0; i < asset.打断技能列表.Num(); i++)
				{
					this.InterruptSkillList.Add((long)asset.打断技能列表.Get(i));
				}
				for (int j = 0; j < asset.期间Tag.GameplayTags.Num(); j++)
				{
					this.TagList.Add(asset.期间Tag.GameplayTags.Get(j).TagId());
				}
			}
		}

		// Token: 0x0603DD99 RID: 253337 RVA: 0x011F22E0 File Offset: 0x011F04E0
		[NullableContext(1)]
		public void SetControlState(bool innerArc, List<ISwordRiderRailSplinePoint> points, float halfHeight)
		{
			this.IsControlState = true;
			this.ControlData.InitSplinePoints(innerArc, points, halfHeight);
		}

		// Token: 0x0603DD9A RID: 253338 RVA: 0x011F22F7 File Offset: 0x011F04F7
		public void ClearControlState()
		{
			this.IsControlState = false;
		}

		// Token: 0x0603DD9B RID: 253339 RVA: 0x011F2300 File Offset: 0x011F0500
		public bool IsCurrentFreeJump()
		{
			return this.CurrentFreeJump;
		}

		// Token: 0x0603DD9C RID: 253340 RVA: 0x011F2308 File Offset: 0x011F0508
		public void SetCurrentFreeJump(bool value)
		{
			this.CurrentFreeJump = value;
		}

		// Token: 0x17007578 RID: 30072
		// (get) Token: 0x0603DD9D RID: 253341 RVA: 0x011F2311 File Offset: 0x011F0511
		public int BaseJumpHeight
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.BaseJumpHeight;
				}
				return this.SideJumpParams.BaseJumpHeight;
			}
		}

		// Token: 0x17007579 RID: 30073
		// (get) Token: 0x0603DD9E RID: 253342 RVA: 0x011F233A File Offset: 0x011F053A
		public float BaseJumpDistanceRate
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.BaseJumpDistanceRate;
				}
				return this.SideJumpParams.BaseJumpDistanceRate;
			}
		}

		// Token: 0x1700757A RID: 30074
		// (get) Token: 0x0603DD9F RID: 253343 RVA: 0x011F2363 File Offset: 0x011F0563
		public int MaxJumpDistance
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.MaxJumpDistance;
				}
				return this.SideJumpParams.MaxJumpDistance;
			}
		}

		// Token: 0x1700757B RID: 30075
		// (get) Token: 0x0603DDA0 RID: 253344 RVA: 0x011F238C File Offset: 0x011F058C
		public int MaxJumpHeight
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.MaxJumpHeight;
				}
				return this.SideJumpParams.MaxJumpHeight;
			}
		}

		// Token: 0x1700757C RID: 30076
		// (get) Token: 0x0603DDA1 RID: 253345 RVA: 0x011F23B5 File Offset: 0x011F05B5
		public int JumpAcceleration
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.JumpAcceleration;
				}
				return this.SideJumpParams.JumpAcceleration;
			}
		}

		// Token: 0x1700757D RID: 30077
		// (get) Token: 0x0603DDA2 RID: 253346 RVA: 0x011F23DE File Offset: 0x011F05DE
		public int TargetSpeedForJump
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.TargetSpeedForJump;
				}
				return this.SideJumpParams.TargetSpeedForJump;
			}
		}

		// Token: 0x1700757E RID: 30078
		// (get) Token: 0x0603DDA3 RID: 253347 RVA: 0x011F2407 File Offset: 0x011F0607
		public int AllTimeForJump
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.AllTimeForJump;
				}
				return this.SideJumpParams.AllTimeForJump;
			}
		}

		// Token: 0x1700757F RID: 30079
		// (get) Token: 0x0603DDA4 RID: 253348 RVA: 0x011F2430 File Offset: 0x011F0630
		public int JumpBlendTime
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.JumpBlendTime;
				}
				return this.SideJumpParams.JumpBlendTime;
			}
		}

		// Token: 0x17007580 RID: 30080
		// (get) Token: 0x0603DDA5 RID: 253349 RVA: 0x011F2459 File Offset: 0x011F0659
		public int LandBlendTime
		{
			get
			{
				if (this.CurrentFreeJump && this.FreeJumpParams != null)
				{
					return this.FreeJumpParams.LandBlendTime;
				}
				return this.SideJumpParams.LandBlendTime;
			}
		}

		// Token: 0x04020D27 RID: 134439
		public int InitSpeed = 700;

		// Token: 0x04020D28 RID: 134440
		public int BaseTargetSpeed = 1000;

		// Token: 0x04020D29 RID: 134441
		public int BaseAcceleration = 300;

		// Token: 0x04020D2A RID: 134442
		public int AccelerationForUp = -300;

		// Token: 0x04020D2B RID: 134443
		public int TargetSpeedForUp = 700;

		// Token: 0x04020D2C RID: 134444
		public int AccelerationForDown = 300;

		// Token: 0x04020D2D RID: 134445
		public int TargetSpeedForDown = 1000;

		// Token: 0x04020D2E RID: 134446
		public int AccelerationAngle = 20;

		// Token: 0x04020D2F RID: 134447
		public int MaxLandSpeed = 2000;

		// Token: 0x04020D30 RID: 134448
		public int MinLandSpeed = 500;

		// Token: 0x04020D31 RID: 134449
		public RailSlideJumpParams SideJumpParams;

		// Token: 0x04020D32 RID: 134450
		public RailSlideJumpParams FreeJumpParams;

		// Token: 0x04020D33 RID: 134451
		public RailControlData ControlData;

		// Token: 0x04020D34 RID: 134452
		public float LeaningBlendAlpha = 0.1f;

		// Token: 0x04020D35 RID: 134453
		public int MaxLeaningAngle = 45;

		// Token: 0x04020D36 RID: 134454
		public int LimitInputAngle = 5;

		// Token: 0x04020D37 RID: 134455
		public bool DisableGravityLean;

		// Token: 0x04020D38 RID: 134456
		public bool DisablePitchLean;

		// Token: 0x04020D39 RID: 134457
		public int ChangeRailCooldownTime = 1000;

		// Token: 0x04020D3A RID: 134458
		public int ChangeRailDistance = 1000;

		// Token: 0x04020D3B RID: 134459
		public int ChangeRailHeight = 400;

		// Token: 0x04020D3C RID: 134460
		public int ChangeRailSpeed = 1000;

		// Token: 0x04020D3D RID: 134461
		public int StartJumpSpeed = 1000;

		// Token: 0x04020D3E RID: 134462
		[Nullable(1)]
		public List<long> InterruptSkillList = new List<long>();

		// Token: 0x04020D3F RID: 134463
		public UCurveFloat MoveCurve;

		// Token: 0x04020D40 RID: 134464
		[Nullable(1)]
		public List<int> TagList = new List<int>();

		// Token: 0x04020D41 RID: 134465
		public bool DebugDraw;

		// Token: 0x04020D42 RID: 134466
		public bool LandAnimation;

		// Token: 0x04020D43 RID: 134467
		public ERailSlideAnimType AnimationType;

		// Token: 0x04020D44 RID: 134468
		private readonly int PbDataId;

		// Token: 0x04020D45 RID: 134469
		public bool IsControlState;

		// Token: 0x04020D46 RID: 134470
		private bool CurrentFreeJump;
	}
}
