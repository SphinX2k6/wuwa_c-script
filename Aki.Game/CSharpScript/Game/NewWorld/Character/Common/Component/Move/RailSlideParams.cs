using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Level.RailSlide;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020070F8 RID: 28920
	[NullableContext(2)]
	[Nullable(0)]
	public class RailSlideParams
	{
		// Token: 0x0604699F RID: 289183 RVA: 0x011C2E34 File Offset: 0x011C1034
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

		// Token: 0x060469A0 RID: 289184 RVA: 0x011C312C File Offset: 0x011C132C
		[NullableContext(1)]
		public void SetControlState(bool innerArc, List<ISwordRiderRailSplinePoint> points, float halfHeight)
		{
			this.IsControlState = true;
			this.ControlData.InitSplinePoints(innerArc, points, halfHeight);
		}

		// Token: 0x060469A1 RID: 289185 RVA: 0x011C3143 File Offset: 0x011C1343
		public void ClearControlState()
		{
			this.IsControlState = false;
		}

		// Token: 0x060469A2 RID: 289186 RVA: 0x011C314C File Offset: 0x011C134C
		public bool IsCurrentFreeJump()
		{
			return this.CurrentFreeJump;
		}

		// Token: 0x060469A3 RID: 289187 RVA: 0x011C3154 File Offset: 0x011C1354
		public void SetCurrentFreeJump(bool value)
		{
			this.CurrentFreeJump = value;
		}

		// Token: 0x17009CEF RID: 40175
		// (get) Token: 0x060469A4 RID: 289188 RVA: 0x011C315D File Offset: 0x011C135D
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

		// Token: 0x17009CF0 RID: 40176
		// (get) Token: 0x060469A5 RID: 289189 RVA: 0x011C3186 File Offset: 0x011C1386
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

		// Token: 0x17009CF1 RID: 40177
		// (get) Token: 0x060469A6 RID: 289190 RVA: 0x011C31AF File Offset: 0x011C13AF
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

		// Token: 0x17009CF2 RID: 40178
		// (get) Token: 0x060469A7 RID: 289191 RVA: 0x011C31D8 File Offset: 0x011C13D8
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

		// Token: 0x17009CF3 RID: 40179
		// (get) Token: 0x060469A8 RID: 289192 RVA: 0x011C3201 File Offset: 0x011C1401
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

		// Token: 0x17009CF4 RID: 40180
		// (get) Token: 0x060469A9 RID: 289193 RVA: 0x011C322A File Offset: 0x011C142A
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

		// Token: 0x17009CF5 RID: 40181
		// (get) Token: 0x060469AA RID: 289194 RVA: 0x011C3253 File Offset: 0x011C1453
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

		// Token: 0x17009CF6 RID: 40182
		// (get) Token: 0x060469AB RID: 289195 RVA: 0x011C327C File Offset: 0x011C147C
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

		// Token: 0x17009CF7 RID: 40183
		// (get) Token: 0x060469AC RID: 289196 RVA: 0x011C32A5 File Offset: 0x011C14A5
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

		// Token: 0x04025092 RID: 151698
		public int InitSpeed = 700;

		// Token: 0x04025093 RID: 151699
		public int BaseTargetSpeed = 1000;

		// Token: 0x04025094 RID: 151700
		public int BaseAcceleration = 300;

		// Token: 0x04025095 RID: 151701
		public int AccelerationForUp = -300;

		// Token: 0x04025096 RID: 151702
		public int TargetSpeedForUp = 700;

		// Token: 0x04025097 RID: 151703
		public int AccelerationForDown = 300;

		// Token: 0x04025098 RID: 151704
		public int TargetSpeedForDown = 1000;

		// Token: 0x04025099 RID: 151705
		public int AccelerationAngle = 20;

		// Token: 0x0402509A RID: 151706
		public int MaxLandSpeed = 2000;

		// Token: 0x0402509B RID: 151707
		public int MinLandSpeed = 500;

		// Token: 0x0402509C RID: 151708
		public RailSlideJumpParams SideJumpParams;

		// Token: 0x0402509D RID: 151709
		public RailSlideJumpParams FreeJumpParams;

		// Token: 0x0402509E RID: 151710
		public RailControlData ControlData;

		// Token: 0x0402509F RID: 151711
		public float LeaningBlendAlpha = 0.1f;

		// Token: 0x040250A0 RID: 151712
		public int MaxLeaningAngle = 45;

		// Token: 0x040250A1 RID: 151713
		public int LimitInputAngle = 5;

		// Token: 0x040250A2 RID: 151714
		public bool DisableGravityLean;

		// Token: 0x040250A3 RID: 151715
		public bool DisablePitchLean;

		// Token: 0x040250A4 RID: 151716
		public int ChangeRailCooldownTime = 1000;

		// Token: 0x040250A5 RID: 151717
		public int ChangeRailDistance = 1000;

		// Token: 0x040250A6 RID: 151718
		public int ChangeRailHeight = 400;

		// Token: 0x040250A7 RID: 151719
		public int ChangeRailSpeed = 1000;

		// Token: 0x040250A8 RID: 151720
		public int StartJumpSpeed = 1000;

		// Token: 0x040250A9 RID: 151721
		[Nullable(1)]
		public List<long> InterruptSkillList = new List<long>();

		// Token: 0x040250AA RID: 151722
		public UCurveFloat MoveCurve;

		// Token: 0x040250AB RID: 151723
		[Nullable(1)]
		public List<int> TagList = new List<int>();

		// Token: 0x040250AC RID: 151724
		public bool DebugDraw;

		// Token: 0x040250AD RID: 151725
		public bool LandAnimation;

		// Token: 0x040250AE RID: 151726
		public ERailSlideAnimType AnimationType;

		// Token: 0x040250AF RID: 151727
		private readonly int PbDataId;

		// Token: 0x040250B0 RID: 151728
		public bool IsControlState;

		// Token: 0x040250B1 RID: 151729
		private bool CurrentFreeJump;
	}
}
