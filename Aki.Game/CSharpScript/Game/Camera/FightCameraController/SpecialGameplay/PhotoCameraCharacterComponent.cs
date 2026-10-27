using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F8 RID: 29432
	[NullableContext(1)]
	[Nullable(0)]
	[RegisterPhotoCameraComponent(EPhotoCameraComponent.Character)]
	public class PhotoCameraCharacterComponent : PhotoCameraComponentBase
	{
		// Token: 0x06048380 RID: 295808 RVA: 0x0128D064 File Offset: 0x0128B264
		protected override void OnInit()
		{
			TsBaseCharacter character = this.Host.Character;
			this.NpcSphereTrace = new UTraceSphereElement();
			this.NpcSphereTrace.bIsSingle = false;
			this.NpcSphereTrace.bTraceComplex = false;
			this.NpcSphereTrace.bIgnoreSelf = true;
			this.NpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
			this.NpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
			this.NpcSphereTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
			if (character != null)
			{
				this.NpcSphereTrace.ActorsToIgnore.Add(character);
			}
		}

		// Token: 0x06048381 RID: 295809 RVA: 0x0128D0F0 File Offset: 0x0128B2F0
		protected override void OnModeChangeStart(PhotoCameraType? prev, PhotoCameraType next)
		{
			this.RefreshModeTag();
			this.ApplyModeCollision(this.Host.Character, new PhotoCameraType?(next));
		}

		// Token: 0x06048382 RID: 295810 RVA: 0x0128D110 File Offset: 0x0128B310
		protected override void OnModeChangeFinish(PhotoCameraType? prev, PhotoCameraType next)
		{
			this.StopAutoMoving();
			this.RestoreAllNpcDither();
			TsBaseCharacter character = this.Host.Character;
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (character == null || !character.IsValid() || currentConfig == null)
			{
				this.RestoreDither();
				return;
			}
			if (currentConfig.Type != PhotoCameraType.Normal && currentConfig.Type != PhotoCameraType.Drone)
			{
				this.RestoreDither();
				return;
			}
			this.UpdatePlayerDither(character, currentConfig);
		}

		// Token: 0x06048383 RID: 295811 RVA: 0x0128D18C File Offset: 0x0128B38C
		private void StopAutoMoving()
		{
			IPhotoCameraHost host = this.Host;
			TsBaseCharacter tsBaseCharacter = (host != null) ? host.Character : null;
			if (tsBaseCharacter == null || !tsBaseCharacter.IsValid())
			{
				return;
			}
			Entity entityNoBlueprint = tsBaseCharacter.GetEntityNoBlueprint();
			if (entityNoBlueprint == null)
			{
				return;
			}
			CharacterInputComponent component = entityNoBlueprint.GetComponent<CharacterInputComponent>();
			if (component == null)
			{
				return;
			}
			component.InterruptAutoMoving("拍照切换模式", true);
		}

		// Token: 0x06048384 RID: 295812 RVA: 0x0128D1DC File Offset: 0x0128B3DC
		[NullableContext(2)]
		protected override void OnCharacterChanged(TsBaseCharacter character)
		{
			this.RestoreDither();
			this.RestoreAllNpcDither();
			this.ApplyModeCollision(character, this.Host.CurrentMode);
			if (this.NpcSphereTrace == null)
			{
				return;
			}
			this.NpcSphereTrace.ActorsToIgnore.Empty(true);
			if (character != null)
			{
				this.NpcSphereTrace.ActorsToIgnore.Add(character);
			}
		}

		// Token: 0x06048385 RID: 295813 RVA: 0x0128D235 File Offset: 0x0128B435
		protected override void OnActivate()
		{
			this.SetFightCameraDitherEnable(false);
			TsBaseCharacter character = this.Host.Character;
			if (character == null)
			{
				return;
			}
			character.SetDitherEffect(1f, ECharacterDitherType.Fight);
		}

		// Token: 0x06048386 RID: 295814 RVA: 0x0128D259 File Offset: 0x0128B459
		protected override void OnDeactivate()
		{
			this.RestoreModeTag();
			this.RestoreModeCollision();
			this.RestoreDither();
			this.RestoreAllNpcDither();
			this.SetFightCameraDitherEnable(true);
		}

		// Token: 0x06048387 RID: 295815 RVA: 0x0128D27A File Offset: 0x0128B47A
		private void SetFightCameraDitherEnable(bool enable)
		{
			CameraModelInstance cameraModel = this.Host.CameraModel;
			if (cameraModel == null)
			{
				return;
			}
			FightCamera fightCamera = cameraModel.FightCamera;
			if (fightCamera == null)
			{
				return;
			}
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			if (logicComponent == null)
			{
				return;
			}
			logicComponent.SetIsDitherEffectEnable(enable);
		}

		// Token: 0x06048388 RID: 295816 RVA: 0x0128D2A8 File Offset: 0x0128B4A8
		protected override void OnTick(float deltaTime)
		{
			TsBaseCharacter character = this.Host.Character;
			if (character == null || !character.IsValid())
			{
				return;
			}
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			if (currentConfig == null)
			{
				return;
			}
			if (!(currentConfig.Type == PhotoCameraType.Normal) && !(currentConfig.Type == PhotoCameraType.Drone))
			{
				this.ApplyDither(character, 1f);
				this.RestoreAllNpcDither();
				return;
			}
			this.UpdatePlayerDither(character, currentConfig);
			this.UpdateNpcDither(currentConfig);
		}

		// Token: 0x06048389 RID: 295817 RVA: 0x0128D328 File Offset: 0x0128B528
		private void UpdatePlayerDither(TsBaseCharacter character, BP_PhotoCameraConfig_C config)
		{
			Vector playerLocation = this.PlayerLocation;
			FVectorDouble fvectorDouble = character.D_K2_GetActorLocation();
			playerLocation.FromUeVector(fvectorDouble);
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			float distance = (float)Vector.Dist(this.PlayerLocation, virtualCamera.WorldLocation);
			float pitch = virtualCamera.WorldRotation.Pitch;
			float dither = this.ComputePlayerDither(config, character, distance, pitch, virtualCamera.Fov);
			this.ApplyDither(character, dither);
		}

		// Token: 0x0604838A RID: 295818 RVA: 0x0128D38E File Offset: 0x0128B58E
		protected override void OnDestroy()
		{
			this.RestoreDither();
			this.RestoreAllNpcDither();
			if (this.NpcSphereTrace != null)
			{
				this.NpcSphereTrace.Dispose();
				this.NpcSphereTrace = null;
			}
		}

		// Token: 0x0604838B RID: 295819 RVA: 0x0128D3B8 File Offset: 0x0128B5B8
		private float ComputePlayerDither(BP_PhotoCameraConfig_C config, TsBaseCharacter character, float distance, float cameraPitch, float fov)
		{
			SPhotoCameraMoveConfig moveConfig = config.MoveConfig;
			float num = 1f;
			float num2 = Math.Max(moveConfig.RoleHideDistanceRange.X, moveConfig.RoleHideDistanceRange.Y) + 50f;
			float inRangeB = Math.Min(moveConfig.RoleHideDistanceRange.X, moveConfig.RoleHideDistanceRange.Y) + 50f;
			if (distance < num2)
			{
				num = Math.Min(num, MathUtils.Instance.RangeClamp(distance, num2, inRangeB, 0.3f, 0.01f));
			}
			float num3 = MathUtils.Instance.WrapAngle(cameraPitch);
			float x = moveConfig.HidePitchRange.X;
			float y = moveConfig.HidePitchRange.Y;
			if (num3 > x)
			{
				num = Math.Min(num, MathUtils.Instance.RangeClamp(num3, x, y, 0.3f, 0.01f));
			}
			CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
			float num4 = (characterActorComponent != null) ? characterActorComponent.HalfHeight : 0f;
			if (num4 > 0f && (double)distance > 0.0001 && (double)fov > 0.0001)
			{
				double num5 = Math.Atan((double)(num4 / distance)) * 57.295780181884766 * 2.0 / (double)fov;
				float x2 = moveConfig.HideSizeInFrameRange.X;
				float y2 = moveConfig.HideSizeInFrameRange.Y;
				if (num5 > (double)x2)
				{
					num = (float)Math.Min((double)num, MathUtils.Instance.RangeClamp(num5, (double)x2, (double)y2, 0.30000001192092896, 0.009999999776482582));
				}
			}
			return num;
		}

		// Token: 0x0604838C RID: 295820 RVA: 0x0128D53C File Offset: 0x0128B73C
		private void ApplyDither(TsBaseCharacter character, float dither)
		{
			this.DitheredCharacter = character;
			character.SetDitherEffect(dither, ECharacterDitherType.Fight);
		}

		// Token: 0x0604838D RID: 295821 RVA: 0x0128D550 File Offset: 0x0128B750
		private void RestoreDither()
		{
			TsBaseCharacter ditheredCharacter = this.DitheredCharacter;
			if (ditheredCharacter != null && ditheredCharacter.IsValid())
			{
				ditheredCharacter.SetDitherEffect(1f, ECharacterDitherType.Fight);
			}
			this.DitheredCharacter = null;
		}

		// Token: 0x0604838E RID: 295822 RVA: 0x0128D584 File Offset: 0x0128B784
		private void UpdateNpcDither(BP_PhotoCameraConfig_C config)
		{
			if (!(config.Type == PhotoCameraType.Normal) && !(config.Type == PhotoCameraType.Drone))
			{
				this.RestoreAllNpcDither();
				return;
			}
			ACameraActor cameraActor = this.Host.CameraActor;
			if (cameraActor == null || !cameraActor.IsValid())
			{
				return;
			}
			VirtualPhotoCamera virtualCamera = this.Host.VirtualCamera;
			SPhotoCameraMoveConfig moveConfig = config.MoveConfig;
			float num = Math.Max(moveConfig.RoleHideDistanceRange.X, moveConfig.RoleHideDistanceRange.Y) + 50f;
			float completeHideDistance = Math.Min(moveConfig.RoleHideDistanceRange.X, moveConfig.RoleHideDistanceRange.Y) + 50f;
			UCameraComponent cameraComponent = cameraActor.CameraComponent;
			float num2 = (cameraComponent != null) ? cameraComponent.AspectRatio : 1f;
			double num3 = MathUtils.Instance.VerticalFovToHorizontally((double)virtualCamera.Fov, (double)num2);
			if (!MathUtils.Instance.IsNearlyEqual((double)this.CurrentNpcDitherFov, (double)virtualCamera.Fov, null))
			{
				this.CurrentNpcDitherFov = virtualCamera.Fov;
				double c = Math.Sin(num3 / 2.0 * 0.01745329238474369) * (double)num * 2.0;
				this.NpcCollisionRadius = (float)MathUtils.Instance.GetTriangleCircumradius((double)num, (double)num, c);
			}
			Vector tmpVector = this.TmpVector;
			FVectorDouble fvectorDouble = cameraActor.D_GetActorForwardVector();
			tmpVector.FromUeVector(fvectorDouble);
			this.TmpVector.Normalize(9.99999993922529E-09);
			this.TmpVector.Multiply((double)this.NpcCollisionRadius, this.TmpVector);
			virtualCamera.WorldLocation.Addition(this.TmpVector, this.NpcSweepEnd);
			UTraceSphereElement npcSphereTrace = this.NpcSphereTrace;
			UKuroHitResult hitResult = npcSphereTrace.HitResult;
			if (hitResult != null)
			{
				hitResult.Clear();
			}
			npcSphereTrace.WorldContextObject = GlobalData.World;
			npcSphereTrace.Radius = this.NpcCollisionRadius;
			TraceElementCommon.Instance.SetStartLocation(npcSphereTrace, virtualCamera.WorldLocation);
			TraceElementCommon.Instance.SetEndLocation(npcSphereTrace, this.NpcSweepEnd);
			bool flag = TraceElementCommon.Instance.SphereTrace(npcSphereTrace, "PhotoCameraCharacterComponent_NpcSweep");
			int hitCount = npcSphereTrace.HitResult.GetHitCount();
			if (flag)
			{
				this.UpdateDitheredNpcDistance(npcSphereTrace.HitResult, virtualCamera.WorldLocation);
				foreach (KeyValuePair<TsBaseCharacter, float> keyValuePair in this.DitheredNpcDistanceMap)
				{
					TsBaseCharacter key = keyValuePair.Key;
					float value = keyValuePair.Value;
					if (this.IsCharacterIgnoreNpcDither(key))
					{
						key.SetDitherEffect(1f, ECharacterDitherType.Temporary);
					}
					else
					{
						key.SetDitherEffect(this.GetNpcDitherValue(value, num, completeHideDistance), ECharacterDitherType.Temporary);
						if (this.DitheredNpcSet.Contains(key))
						{
							this.DitheredNpcSet.Remove(key);
						}
						this.DitheredNpcSet.Add(key);
					}
				}
			}
			int num4 = this.DitheredNpcSet.Count - hitCount;
			for (int i = 0; i < num4; i++)
			{
				TsBaseCharacter tsBaseCharacter = (this.DitheredNpcSet.Count > 0) ? this.DitheredNpcSet[0] : null;
				if (tsBaseCharacter != null)
				{
					if (this.IsCharacterRenderingType(tsBaseCharacter))
					{
						tsBaseCharacter.SetDitherEffect(1f, ECharacterDitherType.Temporary);
					}
					this.DitheredNpcSet.Remove(tsBaseCharacter);
				}
			}
		}

		// Token: 0x0604838F RID: 295823 RVA: 0x0128D8CC File Offset: 0x0128BACC
		private void UpdateDitheredNpcDistance(UKuroHitResult hitResult, Vector cameraLocation)
		{
			int hitCount = hitResult.GetHitCount();
			this.DitheredNpcDistanceMap.Clear();
			for (int i = 0; i < hitCount; i++)
			{
				TsBaseCharacter tsBaseCharacter = hitResult.Actors.Get(i).Get() as TsBaseCharacter;
				if (tsBaseCharacter != null && this.IsCharacterRenderingType(tsBaseCharacter))
				{
					TraceElementCommon.Instance.GetImpactPoint(hitResult, i, this.TmpVector);
					float num2;
					float num = this.DitheredNpcDistanceMap.TryGetValue(tsBaseCharacter, out num2) ? num2 : 9999999f;
					float num3 = (float)Vector.Dist(this.TmpVector, cameraLocation);
					if (num3 < num)
					{
						this.DitheredNpcDistanceMap[tsBaseCharacter] = num3;
					}
				}
			}
		}

		// Token: 0x06048390 RID: 295824 RVA: 0x0128D96C File Offset: 0x0128BB6C
		private float GetNpcDitherValue(float distance, float startHideDistance, float completeHideDistance)
		{
			if (distance >= startHideDistance)
			{
				return 1f;
			}
			return MathUtils.Instance.RangeClamp(distance, startHideDistance, completeHideDistance, 0.3f, 0.01f);
		}

		// Token: 0x06048391 RID: 295825 RVA: 0x0128D990 File Offset: 0x0128BB90
		private bool IsCharacterIgnoreNpcDither(TsBaseCharacter character)
		{
			Entity entityNoBlueprint = character.GetEntityNoBlueprint();
			if (entityNoBlueprint == null)
			{
				return false;
			}
			BaseTagComponent component = entityNoBlueprint.GetComponent<BaseTagComponent>();
			return ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.忽略碰撞隐藏"])) : null).GetValueOrDefault();
		}

		// Token: 0x06048392 RID: 295826 RVA: 0x0128D9E0 File Offset: 0x0128BBE0
		[NullableContext(2)]
		private bool IsCharacterRenderingType(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return false;
			}
			TsBaseCharacter tsBaseCharacter = actor as TsBaseCharacter;
			if (tsBaseCharacter != null)
			{
				EntityHandle handle = CharacterModel.Instance.GetHandle(tsBaseCharacter.GetEntityIdNoBlueprint());
				return handle != null && handle.Valid;
			}
			return false;
		}

		// Token: 0x06048393 RID: 295827 RVA: 0x0128DA28 File Offset: 0x0128BC28
		private void RestoreAllNpcDither()
		{
			foreach (TsBaseCharacter tsBaseCharacter in this.DitheredNpcSet)
			{
				if (tsBaseCharacter.IsValid())
				{
					tsBaseCharacter.SetDitherEffect(1f, ECharacterDitherType.Temporary);
				}
			}
			this.DitheredNpcSet.Clear();
			this.DitheredNpcDistanceMap.Clear();
		}

		// Token: 0x06048394 RID: 295828 RVA: 0x0128DAA0 File Offset: 0x0128BCA0
		private void RefreshModeTag()
		{
			this.RestoreModeTag();
			BP_PhotoCameraConfig_C currentConfig = this.Host.CurrentConfig;
			TArray<string> tarray = (currentConfig != null) ? currentConfig.Tags : null;
			if (tarray == null)
			{
				return;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			for (int i = 0; i < tarray.Num(); i++)
			{
				string text = tarray.Get(i);
				if (!string.IsNullOrEmpty(text))
				{
					int num;
					if (!GameplayTagDefine.EGameplayTagId.TryGetValue(text, out num))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.PhotoCamera;
						ELogAuthor author = ELogAuthor.CXJ;
						string message = "拍照相机模式Tag配置不存在";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("tag", text);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else if (!this.AppliedModeTagIds.Contains(num))
					{
						FormationDataController.Instance.AddPlayerTag(playerId, new int?(num));
						this.AppliedModeTagIds.Add(num);
					}
				}
			}
		}

		// Token: 0x06048395 RID: 295829 RVA: 0x0128DB70 File Offset: 0x0128BD70
		private void RestoreModeTag()
		{
			if (this.AppliedModeTagIds.Count == 0)
			{
				return;
			}
			int playerId = CreatureModel.Instance.GetPlayerId();
			foreach (int value in this.AppliedModeTagIds)
			{
				FormationDataController.Instance.RemovePlayerTag(playerId, new int?(value));
			}
			this.AppliedModeTagIds.Clear();
		}

		// Token: 0x06048396 RID: 295830 RVA: 0x0128DBF4 File Offset: 0x0128BDF4
		[NullableContext(2)]
		private void ApplyModeCollision(TsBaseCharacter character, PhotoCameraType? mode)
		{
			this.RestoreModeCollision();
			if (character == null || mode == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = character.CharacterActorComponent;
			if (characterActorComponent == null)
			{
				return;
			}
			float defaultRadius = characterActorComponent.DefaultRadius;
			float modeCollisionRadius = PhotographConfig.Instance.GetModeCollisionRadius(mode.Value, defaultRadius);
			if (modeCollisionRadius == defaultRadius)
			{
				return;
			}
			this.CollisionAppliedCharacter = character;
			characterActorComponent.SetRadiusAndHalfHeight(modeCollisionRadius, characterActorComponent.HalfHeight, false, false);
		}

		// Token: 0x06048397 RID: 295831 RVA: 0x0128DC54 File Offset: 0x0128BE54
		private void RestoreModeCollision()
		{
			if (this.CollisionAppliedCharacter == null)
			{
				return;
			}
			CharacterActorComponent characterActorComponent = this.CollisionAppliedCharacter.IsValid() ? this.CollisionAppliedCharacter.CharacterActorComponent : null;
			this.CollisionAppliedCharacter = null;
			if (characterActorComponent == null)
			{
				return;
			}
			characterActorComponent.SetRadiusAndHalfHeight(characterActorComponent.DefaultRadius, characterActorComponent.HalfHeight, false, false);
		}

		// Token: 0x04026273 RID: 156275
		private const float MIN_DITHER = 0.01f;

		// Token: 0x04026274 RID: 156276
		private const float START_DITHER_VALUE = 0.3f;

		// Token: 0x04026275 RID: 156277
		private const float NPC_START_DITHER_VALUE = 0.3f;

		// Token: 0x04026276 RID: 156278
		private const float HIDE_DISTANCE_OFFSET = 50f;

		// Token: 0x04026277 RID: 156279
		private const float MAX_DISTANCE = 9999999f;

		// Token: 0x04026278 RID: 156280
		private const string NPC_PROFILE_KEY = "PhotoCameraCharacterComponent_NpcSweep";

		// Token: 0x04026279 RID: 156281
		private readonly Vector PlayerLocation = Vector.Create();

		// Token: 0x0402627A RID: 156282
		[Nullable(2)]
		private TsBaseCharacter DitheredCharacter;

		// Token: 0x0402627B RID: 156283
		[Nullable(2)]
		private UTraceSphereElement NpcSphereTrace;

		// Token: 0x0402627C RID: 156284
		private float CurrentNpcDitherFov;

		// Token: 0x0402627D RID: 156285
		private float NpcCollisionRadius;

		// Token: 0x0402627E RID: 156286
		private readonly Vector NpcSweepEnd = Vector.Create();

		// Token: 0x0402627F RID: 156287
		private readonly Vector TmpVector = Vector.Create();

		// Token: 0x04026280 RID: 156288
		private readonly List<TsBaseCharacter> DitheredNpcSet = new List<TsBaseCharacter>();

		// Token: 0x04026281 RID: 156289
		private readonly Dictionary<TsBaseCharacter, float> DitheredNpcDistanceMap = new Dictionary<TsBaseCharacter, float>();

		// Token: 0x04026282 RID: 156290
		private readonly List<int> AppliedModeTagIds = new List<int>();

		// Token: 0x04026283 RID: 156291
		[Nullable(2)]
		private TsBaseCharacter CollisionAppliedCharacter;
	}
}
