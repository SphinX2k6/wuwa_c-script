using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using UnrealEngine;

// Token: 0x02000227 RID: 551
[NullableContext(1)]
[Nullable(0)]
public class ZoneFollowCamera : ISpecialGameplayCamera
{
	// Token: 0x06002220 RID: 8736 RVA: 0x000C8539 File Offset: 0x000C6739
	public void OnInit(ACameraActor camera, CameraModelInstance cameraModel)
	{
		this.CameraActor = camera;
		FightCamera fightCamera = cameraModel.FightCamera;
		this.FightCameraLogicComp = ((fightCamera != null) ? fightCamera.LogicComponent : null);
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000C855C File Offset: 0x000C675C
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

	// Token: 0x06002222 RID: 8738 RVA: 0x000C85D8 File Offset: 0x000C67D8
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

	// Token: 0x06002223 RID: 8739 RVA: 0x000C8668 File Offset: 0x000C6868
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

	// Token: 0x06002224 RID: 8740 RVA: 0x000C87F4 File Offset: 0x000C69F4
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

	// Token: 0x06002225 RID: 8741 RVA: 0x000C8907 File Offset: 0x000C6B07
	public void UpdateExternalPlayerPosition(Vector position)
	{
		this.ExternalPlayerPosition.DeepCopy(position);
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000C8915 File Offset: 0x000C6B15
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

	// Token: 0x06002227 RID: 8743 RVA: 0x000C8950 File Offset: 0x000C6B50
	private Vector GetCurrentPlayerPosition()
	{
		if (this.UseExternalPlayerPosition)
		{
			return this.ExternalPlayerPosition;
		}
		return this.FightCameraLogicComp.PlayerLocation;
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000C896C File Offset: 0x000C6B6C
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

	// Token: 0x06002229 RID: 8745 RVA: 0x000C8AB0 File Offset: 0x000C6CB0
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

	// Token: 0x0600222A RID: 8746 RVA: 0x000C8B14 File Offset: 0x000C6D14
	private bool IsPointInBoxWithTransform(Vector point, Transform boxWorldTransform, Vector boxExtent)
	{
		boxWorldTransform.InverseTransformPosition(point, this.TempVec2);
		return Math.Abs(this.TempVec2.X) <= Math.Abs(boxExtent.X) && Math.Abs(this.TempVec2.Y) <= Math.Abs(boxExtent.Y) && Math.Abs(this.TempVec2.Z) <= Math.Abs(boxExtent.Z);
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x000C8B8C File Offset: 0x000C6D8C
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

	// Token: 0x0600222C RID: 8748 RVA: 0x000C8D60 File Offset: 0x000C6F60
	private void UpdateTargetPositionFromPlayerPosition(Vector playerPosition)
	{
		playerPosition.Addition(this.DefaultCameraOffset, this.TargetCameraPosition);
		this.TargetCameraRotation.DeepCopy(this.DefaultCameraRotation);
	}

	// Token: 0x04001654 RID: 5716
	[Nullable(2)]
	private ACameraActor CameraActor;

	// Token: 0x04001655 RID: 5717
	[Nullable(2)]
	private FightCameraLogicComponent FightCameraLogicComp;

	// Token: 0x04001656 RID: 5718
	private bool IsSettingsValid;

	// Token: 0x04001657 RID: 5719
	private float LerpSpeed;

	// Token: 0x04001658 RID: 5720
	private readonly Vector DefaultCameraOffset = Vector.Create();

	// Token: 0x04001659 RID: 5721
	private readonly Rotator DefaultCameraRotation = Rotator.Create();

	// Token: 0x0400165A RID: 5722
	private readonly List<ZoneSnapshot> CachedZoneConfigs = new List<ZoneSnapshot>();

	// Token: 0x0400165B RID: 5723
	private float? TargetFov;

	// Token: 0x0400165C RID: 5724
	private float? CurrentFov;

	// Token: 0x0400165D RID: 5725
	private readonly Vector TargetCameraPosition = Vector.Create();

	// Token: 0x0400165E RID: 5726
	private readonly Rotator TargetCameraRotation = Rotator.Create();

	// Token: 0x0400165F RID: 5727
	private readonly Vector TempVec0 = Vector.Create();

	// Token: 0x04001660 RID: 5728
	private readonly Vector TempVec1 = Vector.Create();

	// Token: 0x04001661 RID: 5729
	private readonly Vector TempVec2 = Vector.Create();

	// Token: 0x04001662 RID: 5730
	private readonly Vector TempVec3 = Vector.Create();

	// Token: 0x04001663 RID: 5731
	private readonly Rotator TempRot0 = Rotator.Create();

	// Token: 0x04001664 RID: 5732
	private readonly Vector CurPositionCache = Vector.Create();

	// Token: 0x04001665 RID: 5733
	private readonly Rotator CurRotationCache = Rotator.Create();

	// Token: 0x04001666 RID: 5734
	private readonly List<int> ZoneIndexListCache = new List<int>();

	// Token: 0x04001667 RID: 5735
	private readonly List<float> DistanceListCache = new List<float>();

	// Token: 0x04001668 RID: 5736
	private readonly Vector LastPlayerPosition = Vector.Create();

	// Token: 0x04001669 RID: 5737
	private bool HasLastPlayerPosition;

	// Token: 0x0400166A RID: 5738
	private readonly Vector ExternalPlayerPosition = Vector.Create();

	// Token: 0x0400166B RID: 5739
	private bool UseExternalPlayerPosition;
}
