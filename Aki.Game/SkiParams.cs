using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.Ski;
using UnrealEngine;

// Token: 0x0200264E RID: 9806
[NullableContext(1)]
[Nullable(0)]
public class SkiParams
{
	// Token: 0x0601882D RID: 100397 RVA: 0x00769D58 File Offset: 0x00767F58
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

	// Token: 0x0400D3D9 RID: 54233
	public float InitSpeed = 700f;

	// Token: 0x0400D3DA RID: 54234
	public float BaseAccForSpeedUp = 300f;

	// Token: 0x0400D3DB RID: 54235
	public float BaseAccForSpeedDown = 300f;

	// Token: 0x0400D3DC RID: 54236
	public float BaseTargetSpeed = 1000f;

	// Token: 0x0400D3DD RID: 54237
	public float SlopExtraTargetSpeed = 200f;

	// Token: 0x0400D3DE RID: 54238
	public float SlopExtraAccel = 150f;

	// Token: 0x0400D3DF RID: 54239
	public float TurnSpeed = 50f;

	// Token: 0x0400D3E0 RID: 54240
	public float IgnoreStepHeight = 20f;

	// Token: 0x0400D3E1 RID: 54241
	public float JumpMaxHorizontalSpeed = 3500f;

	// Token: 0x0400D3E2 RID: 54242
	public float JumpTurnRate = 0.4f;

	// Token: 0x0400D3E3 RID: 54243
	public float JumpHeightRate = 1f;

	// Token: 0x0400D3E4 RID: 54244
	public float JumpTimeScale = 1f;

	// Token: 0x0400D3E5 RID: 54245
	public List<int> TagList = new List<int>();

	// Token: 0x0400D3E6 RID: 54246
	private const int DEFAULT_SKI_MAX_SPEED = 3500;
}
