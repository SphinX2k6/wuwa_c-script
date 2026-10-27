using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using UnrealEngine;

// Token: 0x02000223 RID: 547
[NullableContext(1)]
[Nullable(0)]
public class ZoneFollowCamera : ISpecialGameplayCamera
{
	// Token: 0x06002172 RID: 8562 RVA: 0x000C1219 File Offset: 0x000BF419
	public void OnInit(ACameraActor camera, CameraModelInstance cameraModel)
	{
		this.CameraActor = camera;
		FightCamera fightCamera = cameraModel.FightCamera;
		this.FightCameraLogicComp = ((fightCamera != null) ? fightCamera.LogicComponent : null);
	}

	// Token: 0x06002173 RID: 8563 RVA: 0x000C123C File Offset: 0x000BF43C
	public void Update(float deltaTime)
	{
		ACameraActor cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid() || !this.IsSettingsValid)
		{
			return;
		}
		Vector currentPlayerPosition = this.GetCurrentPlayerPosition();
		if (this.HasLastPlayerPosition && Vector.Distance(currentPlayerPosition, this.LastPlayerPosition) < 0.0001)
		{
			this.LerpCameraToTarget(deltaTime);
			return;
		}
		this.LastPlayerPosition.DeepCopy(currentPlayerPosition);
		this.HasLastPlayerPosition = true;
		this.UpdateTargetCameraPositionAndRotation(currentPlayerPosition);
		this.LerpCameraToTarget(deltaTime);
	}

	// Token: 0x06002174 RID: 8564 RVA: 0x000C12B8 File Offset: 0x000BF4B8
	public void OnDestroy()
	{
		this.IsSettingsValid = false;
		this.HasLastPlayerPosition = false;
		this.UseExternalPlayerPosition = false;
		this.ExternalPlayerPosition.Set(0.0, 0.0, 0.0);
		this.ZoneIndexListCache.Clear();
		this.DistanceListCache.Clear();
		this.CachedZoneConfigs.Clear();
		this.CameraActor = null;
		this.FightCameraLogicComp = null;
		this.TargetFov = null;
		this.CurrentFov = null;
	}

	// Token: 0x06002175 RID: 8565 RVA: 0x000C1348 File Offset: 0x000BF548
	public void SetCameraSettings(SZoneFollowCameraSettings settings)
	{
		this.LerpSpeed = settings.LerpSpeed;
		Vector defaultCameraOffset = this.DefaultCameraOffset;
		FVector fvector = settings.DefaultCameraOffset;
		defaultCameraOffset.FromUeVector(fvector);
		Rotator defaultCameraRotation = this.DefaultCameraRotation;
		FRotator frotator = settings.DefaultCameraRotation;
		defaultCameraRotation.FromUeRotator(frotator);
		if (this.TargetFov == null)
		{
			this.CurrentFov = new float?(settings.CameraFov);
		}
		this.TargetFov = new float?(settings.CameraFov);
		int num = settings.ZoneConfigs.Num();
		while (this.CachedZoneConfigs.Count < num)
		{
			this.CachedZoneConfigs.Add(new ZoneSnapshot());
		}
		if (this.CachedZoneConfigs.Count > num)
		{
			this.CachedZoneConfigs.RemoveRange(num, this.CachedZoneConfigs.Count - num);
		}
		for (int i = 0; i < num; i++)
		{
			SZoneFollowCameraZoneSetting szoneFollowCameraZoneSetting = settings.ZoneConfigs.Get(i);
			ZoneSnapshot zoneSnapshot = this.CachedZoneConfigs[i];
			Vector centerPosition = zoneSnapshot.CenterPosition;
			fvector = szoneFollowCameraZoneSetting.CenterPosition;
			centerPosition.FromUeVector(fvector);
			Vector cameraOffset = zoneSnapshot.CameraOffset;
			fvector = szoneFollowCameraZoneSetting.CameraOffset;
			cameraOffset.FromUeVector(fvector);
			Vector cameraOffsetAlpha = zoneSnapshot.CameraOffsetAlpha;
			fvector = szoneFollowCameraZoneSetting.CameraOffsetAlpha;
			cameraOffsetAlpha.FromUeVector(fvector);
			Rotator cameraRotation = zoneSnapshot.CameraRotation;
			frotator = szoneFollowCameraZoneSetting.CameraRotation;
			cameraRotation.FromUeRotator(frotator);
			zoneSnapshot.HasBox = true;
			Transform boxTransform = zoneSnapshot.BoxTransform;
			FTransform boxTransform2 = szoneFollowCameraZoneSetting.BoxTransform;
			boxTransform.FromUeTransform(boxTransform2);
			Vector boxExtend = zoneSnapshot.BoxExtend;
			fvector = szoneFollowCameraZoneSetting.BoxExtend;
			boxExtend.FromUeVector(fvector);
		}
		this.IsSettingsValid = true;
		this.HasLastPlayerPosition = false;
	}

	// Token: 0x06002176 RID: 8566 RVA: 0x000C14D4 File Offset: 0x000BF6D4
	public void ApplyInitialTransform()
	{
		ACameraActor cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid())
		{
			return;
		}
		Vector currentPlayerPosition = this.GetCurrentPlayerPosition();
		if (this.IsSettingsValid)
		{
			this.UpdateTargetCameraPositionAndRotation(currentPlayerPosition);
		}
		else
		{
			currentPlayerPosition.Addition(this.DefaultCameraOffset, this.TargetCameraPosition);
			this.TargetCameraRotation.DeepCopy(this.DefaultCameraRotation);
		}
		this.LastPlayerPosition.DeepCopy(currentPlayerPosition);
		this.HasLastPlayerPosition = true;
		this.CameraActor.D_K2_SetActorLocationAndRotation(this.TargetCameraPosition.ToUeVector(false), this.TargetCameraRotation.ToUeRotator(), false, ref WorldGlobal.SweepHitResult, false);
		this.CameraActor.CameraComponent.SetFieldOfView(this.TargetFov.GetValueOrDefault(90f));
		this.CurrentFov = new float?(this.TargetFov.GetValueOrDefault(90f));
		if (this.TargetFov == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "ApplyInitialTransform";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(" TargetFov is undefined, using default FOV", 90);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06002177 RID: 8567 RVA: 0x000C15E7 File Offset: 0x000BF7E7
	public void UpdateExternalPlayerPosition(Vector position)
	{
		this.ExternalPlayerPosition.DeepCopy(position);
	}

	// Token: 0x06002178 RID: 8568 RVA: 0x000C15F5 File Offset: 0x000BF7F5
	public void EnableExternalPlayerPosition(bool isUseExternal)
	{
		if (this.UseExternalPlayerPosition == isUseExternal)
		{
			return;
		}
		this.HasLastPlayerPosition = false;
		if (isUseExternal && this.FightCameraLogicComp != null)
		{
			this.ExternalPlayerPosition.DeepCopy(this.FightCameraLogicComp.PlayerLocation);
		}
		this.UseExternalPlayerPosition = isUseExternal;
	}

	// Token: 0x06002179 RID: 8569 RVA: 0x000C1630 File Offset: 0x000BF830
	private Vector GetCurrentPlayerPosition()
	{
		if (this.UseExternalPlayerPosition)
		{
			return this.ExternalPlayerPosition;
		}
		return this.FightCameraLogicComp.PlayerLocation;
	}

	// Token: 0x0600217A RID: 8570 RVA: 0x000C164C File Offset: 0x000BF84C
	private void LerpCameraToTarget(float deltaTime)
	{
		ACameraActor cameraActor = this.CameraActor;
		if (cameraActor == null || !cameraActor.IsValid())
		{
			return;
		}
		Vector curPositionCache = this.CurPositionCache;
		FVectorDouble fvectorDouble = this.CameraActor.D_K2_GetActorLocation();
		curPositionCache.FromUeVector(fvectorDouble);
		Rotator curRotationCache = this.CurRotationCache;
		FRotator frotator = this.CameraActor.K2_GetActorRotation();
		curRotationCache.FromUeRotator(frotator);
		MathUtils.Instance.VectorInterpTo(this.CurPositionCache, this.TargetCameraPosition, (double)deltaTime, (double)this.LerpSpeed, this.TempVec1);
		MathUtils.Instance.RotatorInterpTo(this.CurRotationCache, this.TargetCameraRotation, (double)deltaTime, (double)this.LerpSpeed, this.TempRot0);
		this.CameraActor.D_K2_SetActorLocation(this.TempVec1.ToUeVector(false), false, ref WorldGlobal.SweepHitResult, false);
		this.CameraActor.K2_SetActorRotation(this.TempRot0.ToUeRotator(), false);
		if (this.TargetFov != null && this.CurrentFov != null)
		{
			this.CurrentFov = new float?((float)MathUtils.Instance.InterpTo((double)this.CurrentFov.Value, (double)this.TargetFov.Value, (double)deltaTime, (double)this.LerpSpeed));
			this.CameraActor.CameraComponent.SetFieldOfView(this.CurrentFov.Value);
		}
	}

	// Token: 0x0600217B RID: 8571 RVA: 0x000C1790 File Offset: 0x000BF990
	private void FindActorInZone(Vector curPosition)
	{
		this.ZoneIndexListCache.Clear();
		for (int i = 0; i < this.CachedZoneConfigs.Count; i++)
		{
			ZoneSnapshot zoneSnapshot = this.CachedZoneConfigs[i];
			if (zoneSnapshot.HasBox && this.IsPointInBoxWithTransform(curPosition, zoneSnapshot.BoxTransform, zoneSnapshot.BoxExtend))
			{
				this.ZoneIndexListCache.Add(i);
			}
		}
	}

	// Token: 0x0600217C RID: 8572 RVA: 0x000C17F4 File Offset: 0x000BF9F4
	private bool IsPointInBoxWithTransform(Vector point, Transform boxWorldTransform, Vector boxExtent)
	{
		boxWorldTransform.InverseTransformPosition(point, this.TempVec2);
		return Math.Abs(this.TempVec2.X) <= Math.Abs(boxExtent.X) && Math.Abs(this.TempVec2.Y) <= Math.Abs(boxExtent.Y) && Math.Abs(this.TempVec2.Z) <= Math.Abs(boxExtent.Z);
	}

	// Token: 0x0600217D RID: 8573 RVA: 0x000C186C File Offset: 0x000BFA6C
	private void UpdateTargetCameraPositionAndRotation(Vector curPosition)
	{
		this.FindActorInZone(curPosition);
		int count = this.ZoneIndexListCache.Count;
		if (count == 0)
		{
			this.UpdateTargetPositionFromPlayerPosition(curPosition);
			return;
		}
		this.DistanceListCache.Clear();
		float num = 0f;
		for (int i = 0; i < count; i++)
		{
			ZoneSnapshot zoneSnapshot = this.CachedZoneConfigs[this.ZoneIndexListCache[i]];
			float num2 = (float)(1.0 / (Vector.Distance(curPosition, zoneSnapshot.CenterPosition) + 1E-08));
			num += num2;
			this.DistanceListCache.Add(num2);
		}
		this.TargetCameraPosition.Set(0.0, 0.0, 0.0);
		float num3 = 0f;
		for (int j = 0; j < count; j++)
		{
			float num4 = this.DistanceListCache[j] / num;
			ZoneSnapshot zoneSnapshot2 = this.CachedZoneConfigs[this.ZoneIndexListCache[j]];
			curPosition.Subtraction(zoneSnapshot2.CenterPosition, this.TempVec1);
			this.TempVec1.Multiply(zoneSnapshot2.CameraOffsetAlpha, this.TempVec1);
			zoneSnapshot2.CenterPosition.Addition(zoneSnapshot2.CameraOffset, this.TempVec3);
			this.TempVec3.Addition(this.TempVec1, this.TempVec1);
			this.TempVec1.Multiply((double)num4, this.TempVec0);
			this.TargetCameraPosition.AdditionEqual(this.TempVec0);
			num3 += num4;
			if (j == 0)
			{
				this.TargetCameraRotation.DeepCopy(zoneSnapshot2.CameraRotation);
			}
			else
			{
				Rotator.Lerp(this.TargetCameraRotation, zoneSnapshot2.CameraRotation, num4 / num3, this.TempRot0);
				this.TargetCameraRotation.DeepCopy(this.TempRot0);
			}
		}
	}

	// Token: 0x0600217E RID: 8574 RVA: 0x000C1A40 File Offset: 0x000BFC40
	private void UpdateTargetPositionFromPlayerPosition(Vector playerPosition)
	{
		playerPosition.Addition(this.DefaultCameraOffset, this.TargetCameraPosition);
		this.TargetCameraRotation.DeepCopy(this.DefaultCameraRotation);
	}

	// Token: 0x04001612 RID: 5650
	[Nullable(2)]
	private ACameraActor CameraActor;

	// Token: 0x04001613 RID: 5651
	[Nullable(2)]
	private FightCameraLogicComponent FightCameraLogicComp;

	// Token: 0x04001614 RID: 5652
	private bool IsSettingsValid;

	// Token: 0x04001615 RID: 5653
	private float LerpSpeed;

	// Token: 0x04001616 RID: 5654
	private readonly Vector DefaultCameraOffset = Vector.Create();

	// Token: 0x04001617 RID: 5655
	private readonly Rotator DefaultCameraRotation = Rotator.Create();

	// Token: 0x04001618 RID: 5656
	private readonly List<ZoneSnapshot> CachedZoneConfigs = new List<ZoneSnapshot>();

	// Token: 0x04001619 RID: 5657
	private float? TargetFov;

	// Token: 0x0400161A RID: 5658
	private float? CurrentFov;

	// Token: 0x0400161B RID: 5659
	private readonly Vector TargetCameraPosition = Vector.Create();

	// Token: 0x0400161C RID: 5660
	private readonly Rotator TargetCameraRotation = Rotator.Create();

	// Token: 0x0400161D RID: 5661
	private readonly Vector TempVec0 = Vector.Create();

	// Token: 0x0400161E RID: 5662
	private readonly Vector TempVec1 = Vector.Create();

	// Token: 0x0400161F RID: 5663
	private readonly Vector TempVec2 = Vector.Create();

	// Token: 0x04001620 RID: 5664
	private readonly Vector TempVec3 = Vector.Create();

	// Token: 0x04001621 RID: 5665
	private readonly Rotator TempRot0 = Rotator.Create();

	// Token: 0x04001622 RID: 5666
	private readonly Vector CurPositionCache = Vector.Create();

	// Token: 0x04001623 RID: 5667
	private readonly Rotator CurRotationCache = Rotator.Create();

	// Token: 0x04001624 RID: 5668
	private readonly List<int> ZoneIndexListCache = new List<int>();

	// Token: 0x04001625 RID: 5669
	private readonly List<float> DistanceListCache = new List<float>();

	// Token: 0x04001626 RID: 5670
	private readonly Vector LastPlayerPosition = Vector.Create();

	// Token: 0x04001627 RID: 5671
	private bool HasLastPlayerPosition;

	// Token: 0x04001628 RID: 5672
	private readonly Vector ExternalPlayerPosition = Vector.Create();

	// Token: 0x04001629 RID: 5673
	private bool UseExternalPlayerPosition;
}
