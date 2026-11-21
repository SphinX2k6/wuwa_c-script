using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using AkiClient.Game.Aki.Data.Gameplay.SunSpirit;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x02005B49 RID: 23369
	[NullableContext(1)]
	[Nullable(0)]
	public class SunSpiritConfig
	{
		// Token: 0x06039795 RID: 235413 RVA: 0x01020D54 File Offset: 0x0101EF54
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

		// Token: 0x0401E531 RID: 124209
		[Nullable(2)]
		public BP_CrowdAiConfig_C CrowdAiConfig;

		// Token: 0x0401E532 RID: 124210
		public int CrowdAiSystemIndex;

		// Token: 0x0401E533 RID: 124211
		public float AroundPlayerPosQueryRadius = 200f;

		// Token: 0x0401E534 RID: 124212
		public float AroundPlayerPosQueryBoidRadius = 25f;

		// Token: 0x0401E535 RID: 124213
		public int AroundPlayerPosQueryMaxTryCount = 10;

		// Token: 0x0401E536 RID: 124214
		public float FlyingEffectMaxDist = 10000f;

		// Token: 0x0401E537 RID: 124215
		public float FlyingEffectMinDist = 1f;

		// Token: 0x0401E538 RID: 124216
		public float FlyingEffectUpdateFailMaxTimeSec = 1f;

		// Token: 0x0401E539 RID: 124217
		public int FlyingEffectUpdateFailMaxCount = 3;

		// Token: 0x0401E53A RID: 124218
		public float FlyingEffectMaxFlyingDuration = 10f;

		// Token: 0x0401E53B RID: 124219
		public string FlyingEffectDaPath = "/Game/Aki/Effect/EffectGroup/SA1Riling/DA_Fx_Group_Riling_Trail02.DA_Fx_Group_Riling_Trail02";

		// Token: 0x0401E53C RID: 124220
		public bool FlyFromPlayerToGearInOrderFromMinToMax = true;

		// Token: 0x0401E53D RID: 124221
		public float FlyFromPlayerToGearDelayInterval = 0.15f;

		// Token: 0x0401E53E RID: 124222
		public float FlyFromPlayerToGearWaitTimeBeforeFly = 1f;

		// Token: 0x0401E53F RID: 124223
		public float FlyFromPlayerToGearSpeedForCalc = 500f;

		// Token: 0x0401E540 RID: 124224
		public float FlyFromPlayerToGearDefaultDuration = 2f;

		// Token: 0x0401E541 RID: 124225
		public bool FlyFromGearToPlayerInOrderFromMinToMax;

		// Token: 0x0401E542 RID: 124226
		public float FlyFromGearToPlayerDelayInterval = 0.15f;

		// Token: 0x0401E543 RID: 124227
		public float FlyFromGearToPlayerWaitTimeBeforeFly = 1f;

		// Token: 0x0401E544 RID: 124228
		public float FlyFromGearToPlayerSpeedForCalc = 500f;

		// Token: 0x0401E545 RID: 124229
		public float FlyFromGearToPlayerDefaultDuration = 2f;

		// Token: 0x0401E546 RID: 124230
		public float FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc = 400f;

		// Token: 0x0401E547 RID: 124231
		public Vector2D LauncherHintUiAnchorOffset = Vector2D.Create(50.0, -100.0);

		// Token: 0x0401E548 RID: 124232
		public Vector2D LauncherHintUiPosLerpSpeed = Vector2D.Create(5.0, 5.0);

		// Token: 0x0401E549 RID: 124233
		public Vector2D CharacterHintUiAnchorOffset = Vector2D.Create(100.0, -100.0);

		// Token: 0x0401E54A RID: 124234
		public Vector2D CharacterHintUiPosLerpSpeed = Vector2D.Create(5.0, 5.0);

		// Token: 0x0401E54B RID: 124235
		public float CharacterHintUiShowDurationWhenUpdate = 3f;
	}
}
