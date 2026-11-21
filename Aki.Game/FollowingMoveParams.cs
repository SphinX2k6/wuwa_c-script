using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.KeepFollowing;
using UnrealEngine;

// Token: 0x02002655 RID: 9813
public class FollowingMoveParams
{
	// Token: 0x06018861 RID: 100449 RVA: 0x0076D340 File Offset: 0x0076B540
	[NullableContext(2)]
	public FollowingMoveParams(BP_KeepFollowingConfig_C data = null)
	{
		if (data != null)
		{
			this.KeepStandDistance = (float)data.保持站立距离;
			this.WalkRunDivideSpeed = (float)data.走跑状态分界速度;
			this.WalkRunDivideFloat = (float)data.走跑分界速度浮动;
			this.RunSprintDivideSpeed = (float)data.跑冲刺分界速度;
			this.RunSprintDivideFloat = (float)data.跑冲刺分界速度浮动;
			this.ChangeSpeedAcceleration = (float)data.变速加速度;
			this.ToleranceDistance = (float)data.跟随距离容差;
			this.WalkOffsetLocation = new ValueTuple<double, double>((double)data.步行跟随方位向量.X, (double)data.步行跟随方位向量.Y);
			this.RunOffsetLocation = new ValueTuple<double, double>((double)data.跑步跟随方位向量.X, (double)data.跑步跟随方位向量.Y);
			this.FollowingSpeedRange = new ValueTuple<double, double>((double)data.跟随变速范围.X, (double)data.跟随变速范围.Y);
			this.EnableCompensate = data.是否启用位移修正;
			this.CompensateDistance = (float)data.位移修正距离;
			this.CompensateSpeed = (float)data.位移修正速度;
			this.EnableTimeOutTeleport = data.是否启用超时传送;
			this.IllegalDistance = (float)data.异常距离;
			this.TimeOutDuration = (float)data.超时时间;
			this.HeightDifference = (float)data.高低差允许范围;
			this.ObstacleTime = (float)data.被阻挡触发传送时间;
			this.StandardWalkSpeed = (float)data.StandardWalkSpeed;
			this.StandardRunSpeed = (float)data.StandardRunSpeed;
			this.StandardSprintSpeed = (float)data.StandardSprintSpeed;
			this.UseStandardSpeed = data.只使用标准速度;
			this.KeepStandDistanceWithTarget = (float)data.保持站立角色距离;
			this.StartMoveDelayTime = (float)data.移动延迟时间;
			this.ChangeRunDelayTime = (float)data.加速延迟时间;
			this.NotKeepSync = data.非近距离同步跟随;
			this.AutoTurnToTarget = data.自动转向目标;
			this.FreeFollowing = new FreeFollowingParams(data.自动跟随信息);
			SFollowSitConfig 跟随坐下信息 = data.跟随坐下信息;
			this.FollowSitEnable = 跟随坐下信息.Enable;
			this.FollowSitFindChairRadius = (float)跟随坐下信息.FindChairRadius;
			this.FollowSitExitDistance = (float)跟随坐下信息.ExitSitDownDistance;
			this.FollowSitExitDistanceSquared = this.FollowSitExitDistance * this.FollowSitExitDistance;
			for (int i = 0; i < data.步行跟随方位备选.Num(); i++)
			{
				FVector2D fvector2D = data.步行跟随方位备选.Get(i);
				ValueTuple<double, double> valueTuple = new ValueTuple<double, double>((double)fvector2D.X, (double)fvector2D.Y);
				if ((Math.Abs(valueTuple.Item1) >= 0.0001 || Math.Abs(valueTuple.Item2) >= 0.0001) && !this.WalkOffsetList.Contains(valueTuple))
				{
					this.WalkOffsetList.Add(valueTuple);
				}
			}
			for (int j = 0; j < data.跑步跟随方位备选.Num(); j++)
			{
				FVector2D fvector2D2 = data.跑步跟随方位备选.Get(j);
				ValueTuple<double, double> valueTuple2 = new ValueTuple<double, double>((double)fvector2D2.X, (double)fvector2D2.Y);
				if ((Math.Abs(valueTuple2.Item1) >= 0.0001 || Math.Abs(valueTuple2.Item2) >= 0.0001) && !this.RunOffsetList.Contains(valueTuple2))
				{
					this.RunOffsetList.Add(valueTuple2);
				}
			}
			for (int k = 0; k < data.传送特效buffID.Num(); k++)
			{
				int item = data.传送特效buffID.Get(k);
				if (!this.TeleportEffectBuffId.Contains(item))
				{
					this.TeleportEffectBuffId.Add(item);
				}
			}
			this.CompensateDistanceSquared = this.CompensateDistance * this.CompensateDistance;
			this.MinFollowingSpeed = (float)(this.FollowingSpeedRange.Item1 * 0.30000001192092896);
		}
	}

	// Token: 0x0400D460 RID: 54368
	public float KeepStandDistance = 10f;

	// Token: 0x0400D461 RID: 54369
	public float WalkRunDivideSpeed = 250f;

	// Token: 0x0400D462 RID: 54370
	public float WalkRunDivideFloat = 30f;

	// Token: 0x0400D463 RID: 54371
	public float RunSprintDivideSpeed = 550f;

	// Token: 0x0400D464 RID: 54372
	public float RunSprintDivideFloat = 50f;

	// Token: 0x0400D465 RID: 54373
	public float ChangeSpeedAcceleration = 20f;

	// Token: 0x0400D466 RID: 54374
	public float ToleranceDistance = 20f;

	// Token: 0x0400D467 RID: 54375
	public bool EnableCompensate = true;

	// Token: 0x0400D468 RID: 54376
	public float CompensateDistance = 50f;

	// Token: 0x0400D469 RID: 54377
	public float CompensateDistanceSquared = 2500f;

	// Token: 0x0400D46A RID: 54378
	public float CompensateSpeed = 600f;

	// Token: 0x0400D46B RID: 54379
	public bool EnableTimeOutTeleport = true;

	// Token: 0x0400D46C RID: 54380
	public float IllegalDistance = 500f;

	// Token: 0x0400D46D RID: 54381
	public float TimeOutDuration = 3000f;

	// Token: 0x0400D46E RID: 54382
	[TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	public ValueTuple<double, double> WalkOffsetLocation = new ValueTuple<double, double>(0.0, 60.0);

	// Token: 0x0400D46F RID: 54383
	[TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	public ValueTuple<double, double> RunOffsetLocation = new ValueTuple<double, double>(0.0, 80.0);

	// Token: 0x0400D470 RID: 54384
	[TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	public ValueTuple<double, double> FollowingSpeedRange = new ValueTuple<double, double>(50.0, 600.0);

	// Token: 0x0400D471 RID: 54385
	public float MinFollowingSpeed = 15.000001f;

	// Token: 0x0400D472 RID: 54386
	public float HeightDifference = 30f;

	// Token: 0x0400D473 RID: 54387
	public float ObstacleTime = 2000f;

	// Token: 0x0400D474 RID: 54388
	[Nullable(1)]
	public List<int> TeleportEffectBuffId = new List<int>();

	// Token: 0x0400D475 RID: 54389
	public float StandardWalkSpeed = 100f;

	// Token: 0x0400D476 RID: 54390
	public float StandardRunSpeed = 400f;

	// Token: 0x0400D477 RID: 54391
	public float StandardSprintSpeed = 700f;

	// Token: 0x0400D478 RID: 54392
	public bool UseStandardSpeed;

	// Token: 0x0400D479 RID: 54393
	public bool NotKeepSync;

	// Token: 0x0400D47A RID: 54394
	public bool AutoTurnToTarget;

	// Token: 0x0400D47B RID: 54395
	public float StartMoveDelayTime;

	// Token: 0x0400D47C RID: 54396
	public float ChangeRunDelayTime;

	// Token: 0x0400D47D RID: 54397
	public float KeepStandDistanceWithTarget;

	// Token: 0x0400D47E RID: 54398
	[Nullable(1)]
	public FreeFollowingParams FreeFollowing = new FreeFollowingParams();

	// Token: 0x0400D47F RID: 54399
	public bool FollowSitEnable;

	// Token: 0x0400D480 RID: 54400
	public float FollowSitFindChairRadius;

	// Token: 0x0400D481 RID: 54401
	public float FollowSitExitDistance;

	// Token: 0x0400D482 RID: 54402
	public float FollowSitExitDistanceSquared;

	// Token: 0x0400D483 RID: 54403
	[TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public List<ValueTuple<double, double>> WalkOffsetList = new List<ValueTuple<double, double>>();

	// Token: 0x0400D484 RID: 54404
	[TupleElementNames(new string[]
	{
		"X",
		"Y"
	})]
	[Nullable(new byte[]
	{
		1,
		0
	})]
	public List<ValueTuple<double, double>> RunOffsetList = new List<ValueTuple<double, double>>();
}
