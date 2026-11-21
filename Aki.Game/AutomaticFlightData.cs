using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.ControlMonster;
using UnrealEngine;

// Token: 0x020025C6 RID: 9670
public class AutomaticFlightData
{
	// Token: 0x06018074 RID: 98420 RVA: 0x00732178 File Offset: 0x00730378
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

	// Token: 0x0400CE5A RID: 52826
	public float? MinFlySpeed;

	// Token: 0x0400CE5B RID: 52827
	public float? NormalFlySpeed;

	// Token: 0x0400CE5C RID: 52828
	public float? MaxFlySpeed;

	// Token: 0x0400CE5D RID: 52829
	[Nullable(2)]
	public UCurveVector SpeedTransitionCurve;

	// Token: 0x0400CE5E RID: 52830
	public float? ForwardAxisResponseValue;

	// Token: 0x0400CE5F RID: 52831
	public float? BackwardAxisResponseValue;

	// Token: 0x0400CE60 RID: 52832
	public int? ForwardSkill;

	// Token: 0x0400CE61 RID: 52833
	public int? BackwardSkill;

	// Token: 0x0400CE62 RID: 52834
	public int? CurrentSkill;

	// Token: 0x0400CE63 RID: 52835
	public float? FlySpeed;

	// Token: 0x0400CE64 RID: 52836
	public float? LastFlySpeed;

	// Token: 0x0400CE65 RID: 52837
	public float? TargetFlySpeed;

	// Token: 0x0400CE66 RID: 52838
	public EAutomaticFlightState LastState;

	// Token: 0x0400CE67 RID: 52839
	public EAutomaticFlightState CurrentState;
}
