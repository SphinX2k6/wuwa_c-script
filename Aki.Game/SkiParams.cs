using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Ski;
using UnrealEngine;

// Token: 0x020030F6 RID: 12534
[NullableContext(1)]
[Nullable(0)]
public class SkiParams
{
	// Token: 0x0601AE08 RID: 110088 RVA: 0x00744460 File Offset: 0x00742660
	public SkiParams(BP_SkiConfig_C asset)
	{
		this.InitSpeed = asset.初始速度;
		this.BaseAccForSpeedUp = asset.基础加速度;
		this.BaseAccForSpeedDown = asset.基础减速度;
		this.BaseTargetSpeed = asset.基础目标速度;
		this.SlopExtraTargetSpeed = asset.斜坡额外目标速度;
		this.SlopExtraAccel = asset.斜坡额外加速度;
		this.TurnSpeed = asset.转向速度;
		this.IgnoreStepHeight = asset.忽视阶梯高度;
		this.JumpTurnRate = asset.跳跃转向速度系数;
		this.JumpHeightRate = asset.跳跃高度缩放系数;
		this.JumpTimeScale = asset.跳跃滞空缩放系数;
		this.JumpMaxHorizontalSpeed = asset.跳跃下落最大平面速度;
		TArray<FGameplayTag> gameplayTags = asset.期间Tag.GameplayTags;
		int num = gameplayTags.Num();
		for (int i = 0; i < num; i++)
		{
			this.TagList.Add(gameplayTags.Get(i).TagId());
		}
	}

	// Token: 0x0400CFE8 RID: 53224
	public float InitSpeed = 700f;

	// Token: 0x0400CFE9 RID: 53225
	public float BaseAccForSpeedUp = 300f;

	// Token: 0x0400CFEA RID: 53226
	public float BaseAccForSpeedDown = 300f;

	// Token: 0x0400CFEB RID: 53227
	public float BaseTargetSpeed = 1000f;

	// Token: 0x0400CFEC RID: 53228
	public float SlopExtraTargetSpeed = 200f;

	// Token: 0x0400CFED RID: 53229
	public float SlopExtraAccel = 150f;

	// Token: 0x0400CFEE RID: 53230
	public float TurnSpeed = 50f;

	// Token: 0x0400CFEF RID: 53231
	public float IgnoreStepHeight = 20f;

	// Token: 0x0400CFF0 RID: 53232
	public float JumpMaxHorizontalSpeed = 3500f;

	// Token: 0x0400CFF1 RID: 53233
	public float JumpTurnRate = 0.4f;

	// Token: 0x0400CFF2 RID: 53234
	public float JumpHeightRate = 1f;

	// Token: 0x0400CFF3 RID: 53235
	public float JumpTimeScale = 1f;

	// Token: 0x0400CFF4 RID: 53236
	public List<int> TagList = new List<int>();

	// Token: 0x0400CFF5 RID: 53237
	private const int DEFAULT_SKI_MAX_SPEED = 3500;
}
