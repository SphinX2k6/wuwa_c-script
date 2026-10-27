using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.ControlMonster;
using UnrealEngine;

// Token: 0x0200306F RID: 12399
public class AutomaticFlightData
{
	// Token: 0x0601A6B9 RID: 108217 RVA: 0x0070B980 File Offset: 0x00709B80
	[NullableContext(1)]
	public AutomaticFlightData(ICM_AutomaticFlight_DataBase_C dataAsset)
	{
		this.MinFlySpeed = new float?(dataAsset.低飞行速度);
		this.NormalFlySpeed = new float?(dataAsset.标准飞行速度);
		this.MaxFlySpeed = new float?(dataAsset.高飞行速度);
		this.SpeedTransitionCurve = dataAsset.速度过渡曲线;
		this.ForwardAxisResponseValue = new float?(dataAsset.前向轴输入响应比例);
		this.BackwardAxisResponseValue = new float?((dataAsset.后向轴输入响应比例 > 0f) ? (-dataAsset.后向轴输入响应比例) : dataAsset.后向轴输入响应比例);
		this.ForwardSkill = new int?(dataAsset.前向轴输入响应技能);
		this.BackwardSkill = new int?(dataAsset.后向轴输入响应技能);
	}

	// Token: 0x0400CA80 RID: 51840
	public float? MinFlySpeed;

	// Token: 0x0400CA81 RID: 51841
	public float? NormalFlySpeed;

	// Token: 0x0400CA82 RID: 51842
	public float? MaxFlySpeed;

	// Token: 0x0400CA83 RID: 51843
	[Nullable(2)]
	public UCurveVector SpeedTransitionCurve;

	// Token: 0x0400CA84 RID: 51844
	public float? ForwardAxisResponseValue;

	// Token: 0x0400CA85 RID: 51845
	public float? BackwardAxisResponseValue;

	// Token: 0x0400CA86 RID: 51846
	public int? ForwardSkill;

	// Token: 0x0400CA87 RID: 51847
	public int? BackwardSkill;

	// Token: 0x0400CA88 RID: 51848
	public int? CurrentSkill;

	// Token: 0x0400CA89 RID: 51849
	public float? FlySpeed;

	// Token: 0x0400CA8A RID: 51850
	public float? LastFlySpeed;

	// Token: 0x0400CA8B RID: 51851
	public float? TargetFlySpeed;

	// Token: 0x0400CA8C RID: 51852
	public EAutomaticFlightState LastState;

	// Token: 0x0400CA8D RID: 51853
	public EAutomaticFlightState CurrentState;
}
