using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using AkiClient.Game.Aki.Data.Gameplay.SunSpirit;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x020069EC RID: 27116
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritConfig
	{
		// Token: 0x0604374C RID: 276300 RVA: 0x0107C67C File Offset: 0x0107A87C
		public void UpdateFromUeData(BP_SunSpiritConfig_C ueData)
		{
			this.CrowdAiConfig = ueData.CrowdAiConfig;
			this.CrowdAiSystemIndex = ueData.CrowdAiSystemIndex;
			this.AroundPlayerPosQueryRadius = ueData.AroundPlayerPosQueryRadius;
			this.AroundPlayerPosQueryBoidRadius = ueData.AroundPlayerPosQueryBoidRadius;
			this.AroundPlayerPosQueryMaxTryCount = ueData.AroundPlayerPosQueryMaxTryCount;
			this.FlyingEffectMaxDist = ueData.FlyingEffectMaxDist;
			this.FlyingEffectMinDist = ueData.FlyingEffectMinDist;
			this.FlyingEffectUpdateFailMaxTimeSec = ueData.FlyingEffectUpdateFailMaxTimeSec;
			this.FlyingEffectUpdateFailMaxCount = ueData.FlyingEffectUpdateFailMaxCount;
			this.FlyingEffectMaxFlyingDuration = ueData.FlyingEffectMaxFlyingDuration;
			this.FlyingEffectDaPath = ueData.FlyingEffectDa.ToAssetPathName();
			this.FlyFromPlayerToGearInOrderFromMinToMax = ueData.FlyFromPlayerToGearInOrderFromMinToMax;
			this.FlyFromPlayerToGearDelayInterval = ueData.FlyFromPlayerToGearDelayInterval;
			this.FlyFromPlayerToGearWaitTimeBeforeFly = ueData.FlyFromPlayerToGearWaitTimeBeforeFly;
			this.FlyFromPlayerToGearSpeedForCalc = ueData.FlyFromPlayerToGearSpeedForCalc;
			this.FlyFromPlayerToGearDefaultDuration = ueData.FlyFromPlayerToGearDefaultDuration;
			this.FlyFromGearToPlayerInOrderFromMinToMax = ueData.FlyFromGearToPlayerInOrderFromMinToMax;
			this.FlyFromGearToPlayerDelayInterval = ueData.FlyFromGearToPlayerDelayInterval;
			this.FlyFromGearToPlayerWaitTimeBeforeFly = ueData.FlyFromGearToPlayerWaitTimeBeforeFly;
			this.FlyFromGearToPlayerSpeedForCalc = ueData.FlyFromGearToPlayerSpeedForCalc;
			this.FlyFromGearToPlayerDefaultDuration = ueData.FlyFromGearToPlayerDefaultDuration;
			this.FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc = ueData.FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc;
			this.LauncherHintUiAnchorOffset.FromUeVector2D(ueData.LauncherHintUiAnchorOffset);
			this.LauncherHintUiPosLerpSpeed.FromUeVector2D(ueData.LauncherHintUiPosLerpSpeed);
			this.CharacterHintUiAnchorOffset.FromUeVector2D(ueData.CharacterHintUiAnchorOffset);
			this.CharacterHintUiPosLerpSpeed.FromUeVector2D(ueData.CharacterHintUiPosLerpSpeed);
			this.CharacterHintUiShowDurationWhenUpdate = ueData.CharacterHintUiShowDurationWhenUpdate;
		}

		// Token: 0x0402333F RID: 144191
		[Nullable(2)]
		public BP_CrowdAiConfig_C CrowdAiConfig;

		// Token: 0x04023340 RID: 144192
		public int CrowdAiSystemIndex;

		// Token: 0x04023341 RID: 144193
		public float AroundPlayerPosQueryRadius = 200f;

		// Token: 0x04023342 RID: 144194
		public float AroundPlayerPosQueryBoidRadius = 25f;

		// Token: 0x04023343 RID: 144195
		public int AroundPlayerPosQueryMaxTryCount = 10;

		// Token: 0x04023344 RID: 144196
		public float FlyingEffectMaxDist = 10000f;

		// Token: 0x04023345 RID: 144197
		public float FlyingEffectMinDist = 1f;

		// Token: 0x04023346 RID: 144198
		public float FlyingEffectUpdateFailMaxTimeSec = 1f;

		// Token: 0x04023347 RID: 144199
		public int FlyingEffectUpdateFailMaxCount = 3;

		// Token: 0x04023348 RID: 144200
		public float FlyingEffectMaxFlyingDuration = 10f;

		// Token: 0x04023349 RID: 144201
		public string FlyingEffectDaPath = "/Game/Aki/Effect/EffectGroup/SA1Riling/DA_Fx_Group_Riling_Trail02.DA_Fx_Group_Riling_Trail02";

		// Token: 0x0402334A RID: 144202
		public bool FlyFromPlayerToGearInOrderFromMinToMax = true;

		// Token: 0x0402334B RID: 144203
		public float FlyFromPlayerToGearDelayInterval = 0.15f;

		// Token: 0x0402334C RID: 144204
		public float FlyFromPlayerToGearWaitTimeBeforeFly = 1f;

		// Token: 0x0402334D RID: 144205
		public float FlyFromPlayerToGearSpeedForCalc = 500f;

		// Token: 0x0402334E RID: 144206
		public float FlyFromPlayerToGearDefaultDuration = 2f;

		// Token: 0x0402334F RID: 144207
		public bool FlyFromGearToPlayerInOrderFromMinToMax;

		// Token: 0x04023350 RID: 144208
		public float FlyFromGearToPlayerDelayInterval = 0.15f;

		// Token: 0x04023351 RID: 144209
		public float FlyFromGearToPlayerWaitTimeBeforeFly = 1f;

		// Token: 0x04023352 RID: 144210
		public float FlyFromGearToPlayerSpeedForCalc = 500f;

		// Token: 0x04023353 RID: 144211
		public float FlyFromGearToPlayerDefaultDuration = 2f;

		// Token: 0x04023354 RID: 144212
		public float FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc = 400f;

		// Token: 0x04023355 RID: 144213
		public Vector2D LauncherHintUiAnchorOffset = Vector2D.Create(50.0, -100.0);

		// Token: 0x04023356 RID: 144214
		public Vector2D LauncherHintUiPosLerpSpeed = Vector2D.Create(5.0, 5.0);

		// Token: 0x04023357 RID: 144215
		public Vector2D CharacterHintUiAnchorOffset = Vector2D.Create(100.0, -100.0);

		// Token: 0x04023358 RID: 144216
		public Vector2D CharacterHintUiPosLerpSpeed = Vector2D.Create(5.0, 5.0);

		// Token: 0x04023359 RID: 144217
		public float CharacterHintUiShowDurationWhenUpdate = 3f;
	}
}
