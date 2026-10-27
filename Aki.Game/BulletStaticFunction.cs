using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Core.Common;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Audio;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002DE3 RID: 11747
[NullableContext(1)]
[Nullable(0)]
public class BulletStaticFunction
{
	// Token: 0x06018A83 RID: 100995 RVA: 0x006522C8 File Offset: 0x006504C8
	public static UPrimitiveComponent CreateMultipleBoxToFan(AActor bullet, double radius, double angle, FVector vector, FName profileName, HashSet<UPrimitiveComponent> boxArray)
	{
		int num;
		if (angle < 180.0)
		{
			num = BulletConstant.Instance.FactorBoxSix;
		}
		else
		{
			num = BulletConstant.Instance.FactorBoxTwelve;
		}
		FTransform ftransform = new FTransform();
		FRotator frotator = new FRotator(0f, 0f, 0f);
		double num2 = angle / (double)num;
		Vector vector2 = Vector.Create(radius / 2.0, 0.0, 0.0);
		vector2.AdditionEqual(Vector.Create(vector));
		FVector fvector = vector2.ToUeVectorOld();
		ftransform.SetLocation(fvector);
		UBoxComponent uboxComponent = bullet.AddComponentByClass(UBoxComponent.StaticClass(), false, ftransform, false, default(FName)) as UBoxComponent;
		uboxComponent.LineThickness = 5f;
		uboxComponent.D_SetBoxExtent(Vector.OneVectorDouble, false);
		uboxComponent.SetCollisionProfileName(profileName, true);
		boxArray.Add(uboxComponent);
		Vector vector3 = Vector.Create(0.0, 0.0, 0.0);
		for (int i = 0; i < num / 2; i++)
		{
			vector3.FromUeVector(Vector.ForwardVectorProxy);
			vector3.RotateAngleAxis(num2, Vector.UpVectorProxy, vector3);
			vector3.MultiplyEqual(radius / 2.0);
			vector3.AdditionEqual(Vector.Create(vector));
			fvector = vector3.ToUeVectorOld();
			ftransform.SetLocation(fvector);
			vector3.Reset();
			frotator.Yaw = (float)num2;
			FQuat fquat = frotator.Quaternion();
			ftransform.SetRotation(fquat);
			UBoxComponent uboxComponent2 = bullet.AddComponentByClass(UBoxComponent.StaticClass(), false, ftransform, false, default(FName)) as UBoxComponent;
			uboxComponent2.LineThickness = 5f;
			uboxComponent2.D_SetBoxExtent(Vector.OneVectorDouble, false);
			uboxComponent2.SetCollisionProfileName(profileName, true);
			num2 += angle / (double)num;
			boxArray.Add(uboxComponent2);
		}
		num2 = -angle / (double)num;
		for (int j = 0; j < num / 2; j++)
		{
			vector3.FromUeVector(Vector.ForwardVectorProxy);
			vector3.RotateAngleAxis(num2, Vector.UpVectorProxy, vector3);
			vector3.MultiplyEqual(radius / 2.0);
			vector3.AdditionEqual(Vector.Create(vector));
			fvector = vector3.ToUeVectorOld();
			ftransform.SetLocation(fvector);
			vector3.Reset();
			frotator.Yaw = (float)num2;
			FQuat fquat = frotator.Quaternion();
			ftransform.SetRotation(fquat);
			UBoxComponent uboxComponent3 = bullet.AddComponentByClass(UBoxComponent.StaticClass(), false, ftransform, false, default(FName)) as UBoxComponent;
			uboxComponent3.LineThickness = 5f;
			uboxComponent3.D_SetBoxExtent(Vector.OneVectorDouble, false);
			uboxComponent3.SetCollisionProfileName(profileName, true);
			num2 -= angle / (double)num;
			boxArray.Add(uboxComponent3);
		}
		return uboxComponent;
	}

	// Token: 0x06018A84 RID: 100996 RVA: 0x006525AC File Offset: 0x006507AC
	public static FVector CompCurveVector(double haveTime, double allTime, UCurveVector curve)
	{
		float num = 0f;
		float num2 = 0f;
		curve.GetTimeRange(ref num2, ref num);
		double num3 = MathUtils.Instance.IsNearlyZero(allTime, new double?(0.0001)) ? 0.0001 : allTime;
		return curve.GetVectorValue((float)MathUtils.Instance.RangeClamp(haveTime / num3, 0.0, 1.0, (double)num2, (double)num));
	}

	// Token: 0x06018A85 RID: 100997 RVA: 0x00652624 File Offset: 0x00650824
	public static float CompCurveFloat(float haveTime, float allTime, UCurveFloat curve)
	{
		float num = 0f;
		float num2 = 0f;
		curve.GetTimeRange(ref num2, ref num);
		float num3 = MathUtils.Instance.IsNearlyZero((double)allTime, new double?(0.0001)) ? 0.0001f : allTime;
		return curve.GetFloatValue((float)MathUtils.Instance.RangeClamp((double)(haveTime / num3), 0.0, 1.0, (double)num2, (double)num));
	}

	// Token: 0x06018A86 RID: 100998 RVA: 0x00652698 File Offset: 0x00650898
	public static void DebugDrawRing(double halfHeight, double radiusMin, double radiusMax, Vector location, Vector upVector)
	{
		if (radiusMax <= 0.0)
		{
			return;
		}
		FVectorDouble start = new FVectorDouble(location.X + upVector.X * halfHeight, location.Y + upVector.Y * halfHeight, location.Z + upVector.Z * halfHeight);
		FVectorDouble end = new FVectorDouble(location.X - upVector.X * halfHeight, location.Y - upVector.Y * halfHeight, location.Z - upVector.Z * halfHeight);
		if (radiusMin > 0.0)
		{
			UKismetSystemLibrary.D_DrawDebugCylinder(GlobalData.GameInstance, start, end, (float)radiusMin, 32, new FLinearColor?(BulletStaticFunction.collisionColor), 0f, 0f);
		}
		UKismetSystemLibrary.D_DrawDebugCylinder(GlobalData.GameInstance, start, end, (float)radiusMax, 32, new FLinearColor?(BulletStaticFunction.collisionColor), 0f, 0f);
	}

	// Token: 0x06018A87 RID: 100999 RVA: 0x00652774 File Offset: 0x00650974
	public static void DebugDrawRingWithRotation(double halfHeight, double radiusMin, double radiusMax, Vector location, FQuat rotation)
	{
		if (radiusMax <= 0.0)
		{
			return;
		}
		Quat quat = Quat.Create(rotation);
		Vector vector = Vector.Create(0.0, 0.0, halfHeight);
		quat.RotateVector(vector, vector);
		vector.AdditionEqual(location);
		Vector vector2 = Vector.Create(0.0, 0.0, -halfHeight);
		quat.RotateVector(vector2, vector2);
		vector2.AdditionEqual(location);
		if (radiusMin > 0.0)
		{
			UKismetSystemLibrary.D_DrawDebugCylinder(GlobalData.GameInstance, vector.ToUeVector(false), vector2.ToUeVector(false), (float)radiusMin, 32, new FLinearColor?(BulletStaticFunction.collisionColor), 0f, 0f);
		}
		UKismetSystemLibrary.D_DrawDebugCylinder(GlobalData.GameInstance, vector.ToUeVector(false), vector2.ToUeVector(false), (float)radiusMax, 32, new FLinearColor?(BulletStaticFunction.collisionColor), 0f, 0f);
	}

	// Token: 0x06018A88 RID: 101000 RVA: 0x00652854 File Offset: 0x00650A54
	public static void DebugDrawSector(double halfHeight, double radius, double angle, Quat quat, Vector location, Vector upVector, FLinearColor? color = null, float? duration = null)
	{
		quat.RotateVector(upVector, BulletStaticFunction.TmpVector1);
		BulletStaticFunction.TmpVector1.Multiply(halfHeight, BulletStaticFunction.UpOffset);
		BulletStaticFunction.TmpVector1.Multiply(-halfHeight, BulletStaticFunction.DownOffset);
		location.Addition(BulletStaticFunction.UpOffset, BulletStaticFunction.TmpVector1);
		location.Addition(BulletStaticFunction.DownOffset, BulletStaticFunction.TmpVector2);
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector1.ToUeVector(false), BulletStaticFunction.TmpVector2.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		double num = angle * 0.01745329238474369 * 0.5;
		BulletStaticFunction.TmpVector3.Set(Math.Cos(num) * radius, Math.Sin(num) * radius, 0.0);
		quat.RotateVector(BulletStaticFunction.TmpVector3, BulletStaticFunction.TmpVector4);
		BulletStaticFunction.TmpVector4.AdditionEqual(location);
		BulletStaticFunction.TmpVector5.FromUeVector(BulletStaticFunction.TmpVector4);
		BulletStaticFunction.TmpVector4.AdditionEqual(BulletStaticFunction.UpOffset);
		BulletStaticFunction.TmpVector5.AdditionEqual(BulletStaticFunction.DownOffset);
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector1.ToUeVector(false), BulletStaticFunction.TmpVector4.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector2.ToUeVector(false), BulletStaticFunction.TmpVector5.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		BulletStaticFunction.TmpVector3.Set(Math.Cos(-num) * radius, Math.Sin(-num) * radius, 0.0);
		quat.RotateVector(BulletStaticFunction.TmpVector3, BulletStaticFunction.TmpVector4);
		BulletStaticFunction.TmpVector4.AdditionEqual(location);
		BulletStaticFunction.TmpVector5.FromUeVector(BulletStaticFunction.TmpVector4);
		BulletStaticFunction.TmpVector4.AdditionEqual(BulletStaticFunction.UpOffset);
		BulletStaticFunction.TmpVector5.AdditionEqual(BulletStaticFunction.DownOffset);
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector4.ToUeVector(false), BulletStaticFunction.TmpVector5.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector1.ToUeVector(false), BulletStaticFunction.TmpVector4.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector2.ToUeVector(false), BulletStaticFunction.TmpVector5.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		int num2 = Math.Max((int)Math.Ceiling(angle / 30.0), 2);
		double num3 = angle / (double)num2 * 0.01745329238474369;
		for (int i = 1; i <= num2; i++)
		{
			BulletStaticFunction.TmpVector1.FromUeVector(BulletStaticFunction.TmpVector4);
			BulletStaticFunction.TmpVector2.FromUeVector(BulletStaticFunction.TmpVector5);
			double num4 = -num + num3 * (double)i;
			BulletStaticFunction.TmpVector3.Set(Math.Cos(num4) * radius, Math.Sin(num4) * radius, 0.0);
			quat.RotateVector(BulletStaticFunction.TmpVector3, BulletStaticFunction.TmpVector4);
			BulletStaticFunction.TmpVector4.AdditionEqual(location);
			BulletStaticFunction.TmpVector5.FromUeVector(BulletStaticFunction.TmpVector4);
			BulletStaticFunction.TmpVector4.AdditionEqual(BulletStaticFunction.UpOffset);
			BulletStaticFunction.TmpVector5.AdditionEqual(BulletStaticFunction.DownOffset);
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector4.ToUeVector(false), BulletStaticFunction.TmpVector5.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector1.ToUeVector(false), BulletStaticFunction.TmpVector4.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
			UKismetSystemLibrary.D_DrawDebugLine(GlobalData.GameInstance, BulletStaticFunction.TmpVector2.ToUeVector(false), BulletStaticFunction.TmpVector5.ToUeVector(false), color ?? BulletStaticFunction.collisionColor, duration.GetValueOrDefault(), 0f);
		}
	}

	// Token: 0x06018A89 RID: 101001 RVA: 0x00652CF8 File Offset: 0x00650EF8
	public static void SpawnHitEffect(BulletInfo bulletInfo, EBulletHitEffect effectType, string reason)
	{
		if (bulletInfo.EffectInfo.HandOver)
		{
			return;
		}
		FName? valueOrNull = bulletInfo.EffectInfo.EffectData.EffectOnHit.GetValueOrNull(effectType);
		if (valueOrNull != null)
		{
			BulletStaticFunction.PlayBulletEffect(bulletInfo.Actor, valueOrNull.Value.ToString(), bulletInfo.ActorComponent.ActorTransform, bulletInfo, reason);
		}
	}

	// Token: 0x06018A8A RID: 101002 RVA: 0x00652D64 File Offset: 0x00650F64
	public static void BulletHitEffect(BulletInfo bulletInfo, FVectorDouble position)
	{
		FName? valueOrNull = bulletInfo.EffectInfo.EffectData.EffectOnHit.GetValueOrNull(EBulletHitEffect.碰撞障碍物触发);
		if (valueOrNull != null)
		{
			FVector fvector = Vector.OneVectorDouble;
			FTransformDouble transform = new FTransformDouble(ref Rotator.ZeroRotator, ref position, ref fvector);
			BulletStaticFunction.PlayBulletEffect(bulletInfo.Actor, valueOrNull.Value.ToString(), transform, bulletInfo, "[BulletStaticFunction.BulletHitEffect]");
		}
	}

	// Token: 0x06018A8B RID: 101003 RVA: 0x00652DD4 File Offset: 0x00650FD4
	public static int PlayBulletEffect(UObject worldContextObject, string path, FTransformDouble transform, BulletInfo bulletInfo, string reason)
	{
		EffectContext effectContext = null;
		BaseActorComponent attackerActorComp = bulletInfo.AttackerActorComp;
		if (attackerActorComp != null && attackerActorComp.Valid)
		{
			if (bulletInfo.AttackerAudioComponent != null)
			{
				effectContext = new EffectAudioContext
				{
					FromPrimaryRole = (bulletInfo.AttackerAudioComponent.CurrentPriority == ERoleAudioPriorityType.PlayerControl)
				};
			}
			else
			{
				effectContext = new EffectContext();
			}
			effectContext.EntityId = ((bulletInfo.Attacker != null) ? new int?(bulletInfo.Attacker.Id) : null);
			effectContext.SourceObject = bulletInfo.AttackerActorComp.Owner;
			effectContext.DisablePostProcess = bulletInfo.EffectInfo.DisablePostProcess;
		}
		string text = null;
		BaseActorComponent component = bulletInfo.BulletInitParams.Owner.GetComponent<BaseActorComponent>();
		if (component != null)
		{
			text = component.GetReplaceEffect(path);
		}
		EffectSystem instance = EffectSystem.Instance;
		FTransformDouble? ftransformDouble = new FTransformDouble?(transform);
		int num = instance.SpawnEffect(worldContextObject, ftransformDouble, (!string.IsNullOrEmpty(text)) ? text : path, reason, effectContext, EEffectType.Fight, null, null, null, false, false);
		EffectSystem instance2 = EffectSystem.Instance;
		ETimeScaleSourceType sourceType = ETimeScaleSourceType.SelfCentered;
		int id = num;
		Entity attacker = bulletInfo.Attacker;
		float? num2;
		if (attacker == null)
		{
			num2 = null;
		}
		else
		{
			PawnTimeScaleComponent component2 = attacker.GetComponent<PawnTimeScaleComponent>();
			num2 = ((component2 != null) ? new float?(component2.GetTopForeverTimeScale(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView))) : null);
		}
		instance2.SetAdditionTimeScale(sourceType, id, num2 ?? CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		OneOf<KuroEffectNiagaraComponentHandle, UNiagaraComponent> niagaraComponent = EffectSystem.Instance.GetNiagaraComponent(num);
		BaseActorComponent attackerActorComp2 = bulletInfo.AttackerActorComp;
		if (attackerActorComp2 != null && attackerActorComp2.Valid)
		{
			AActor owner = bulletInfo.AttackerActorComp.Owner;
			int? num3 = (bulletInfo.Attacker != null) ? new int?(bulletInfo.Attacker.Id) : null;
			if (owner != null && num3 != null)
			{
				UKuroEnviInteractionComponent ukuroEnviInteractionComponent = owner.GetComponentByClass(UKuroEnviInteractionComponent.StaticClass()) as UKuroEnviInteractionComponent;
				if (ukuroEnviInteractionComponent != null && ukuroEnviInteractionComponent.IsValid() && ukuroEnviInteractionComponent.bUseSPModelShiftColor)
				{
					if (niagaraComponent.IsT2)
					{
						ukuroEnviInteractionComponent.SetNiagaraCompShiftColor(niagaraComponent.AsT2);
					}
					else if (niagaraComponent.IsT1)
					{
						niagaraComponent.AsT1.SetEnviInteractionComp(ukuroEnviInteractionComponent);
					}
				}
			}
		}
		return num;
	}

	// Token: 0x06018A8C RID: 101004 RVA: 0x00652FE0 File Offset: 0x006511E0
	public static void DestroyEffect(BulletInfo bulletInfo, bool resetTimeScale = true)
	{
		BulletEffectInfo effectInfo = bulletInfo.EffectInfo;
		if (effectInfo.HandOver)
		{
			return;
		}
		if (effectInfo.IsEffectDestroy)
		{
			return;
		}
		effectInfo.IsEffectDestroy = true;
		if (!EffectSystem.Instance.IsValid(effectInfo.Effect))
		{
			return;
		}
		AActor sureEffectActor = EffectSystem.Instance.GetSureEffectActor(effectInfo.Effect);
		if (sureEffectActor != null && sureEffectActor.IsValid())
		{
			sureEffectActor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}
		if (effectInfo.IsFinishAuto)
		{
			if (resetTimeScale)
			{
				EffectSystem.Instance.SetTimeScale(effectInfo.Effect, 1f, false);
				Entity attacker = bulletInfo.Attacker;
				float? num;
				if (attacker == null)
				{
					num = null;
				}
				else
				{
					PawnTimeScaleComponent component = attacker.GetComponent<PawnTimeScaleComponent>();
					num = ((component != null) ? new float?(component.GetTopForeverTimeScale(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView))) : null);
				}
				float timeScale = num ?? CharacterModel.Instance.InverseSelfCenteredTimeDilation;
				EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.SelfCentered, effectInfo.Effect, timeScale);
			}
			EffectSystem.Instance.StopEffectById(effectInfo.Effect, "[BulletStaticFunction.DestroyEffect] IsFinishAuto=true", false, null);
			return;
		}
		EffectSystem.Instance.StopEffectById(effectInfo.Effect, "[BulletStaticFunction.DestroyEffect] IsFinishAuto=false", true, null);
	}

	// Token: 0x06018A8D RID: 101005 RVA: 0x0065311B File Offset: 0x0065131B
	public static void SetBulletEffectTimeScale(BulletEffectInfo effectInfo, double newScale, bool ignoreGlobalTimeScale = false)
	{
		if (!EffectSystem.Instance.IsValid(effectInfo.Effect))
		{
			return;
		}
		EffectSystem.Instance.SetTimeScale(effectInfo.Effect, (float)newScale, ignoreGlobalTimeScale);
	}

	// Token: 0x06018A8E RID: 101006 RVA: 0x00653144 File Offset: 0x00651344
	public static void HandOverEffects(BulletInfo oldBulletInfo, BulletInfo newBulletInfo)
	{
		BulletEffectInfo effectInfo = oldBulletInfo.EffectInfo;
		BulletEffectInfo effectInfo2 = newBulletInfo.EffectInfo;
		BulletStaticFunction.DestroyEffect(newBulletInfo, true);
		effectInfo2.EffectData = effectInfo.EffectData;
		effectInfo2.Effect = effectInfo.Effect;
		effectInfo2.IsEffectDestroy = false;
		effectInfo.HandOver = true;
		effectInfo.Effect = 0;
	}

	// Token: 0x06018A8F RID: 101007 RVA: 0x00653194 File Offset: 0x00651394
	public static void HandOverEffectsAfterInitTransform(BulletInfo bulletInfo)
	{
		BulletEffectInfo effectInfo = bulletInfo.EffectInfo;
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(effectInfo.Effect);
		if (effectActor.IsValid())
		{
			OneOf<KuroEffectActorHandle, AActor> self = effectActor;
			AActor actor = bulletInfo.Actor;
			FName? fname = new FName?(FNameUtil.NONE);
			self.K2_AttachToActor(actor, fname, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, true);
		}
	}

	// Token: 0x06018A90 RID: 101008 RVA: 0x006531E0 File Offset: 0x006513E0
	public static int GetNiagaraQualityLevel(double configValue)
	{
		int num = (int)Math.Min((double)GameSettingsManager.Instance.GetCurrentValue(EFunction.NIAGARAQUALITY, true, true).GetValueOrDefault(), configValue);
		if (!Info.Instance.IsPcOrGamepadPlatform())
		{
			num = ((num > 0) ? 1 : 0);
		}
		else
		{
			num = ((num > 0) ? 2 : 1);
		}
		return num;
	}

	// Token: 0x06018A91 RID: 101009 RVA: 0x0065322C File Offset: 0x0065142C
	public static void UpdateEffectQualityLevel(BulletInfo bulletInfo)
	{
		BulletEffectInfo effectInfo = bulletInfo.EffectInfo;
		if (EffectSystem.Instance.IsValid(effectInfo.Effect))
		{
			string valueOrDefault = bulletInfo.BulletDataMain.Render.EffectBulletParams.GetValueOrDefault(5);
			double configValue;
			if (valueOrDefault != null && double.TryParse(valueOrDefault, out configValue))
			{
				int niagaraQualityLevel = BulletStaticFunction.GetNiagaraQualityLevel(configValue);
				EffectSystem.Instance.SetEffectQualityLevel(effectInfo.Effect, niagaraQualityLevel);
			}
		}
	}

	// Token: 0x0400B7B6 RID: 47030
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor collisionColor = new FLinearColor(255f, 80f, 77f, 1f);

	// Token: 0x0400B7B7 RID: 47031
	private const int DRAW_SECTOR_ANGLE_PERIOD = 30;

	// Token: 0x0400B7B8 RID: 47032
	[StaticVariableRuleIgnore]
	private static readonly Vector UpOffset = Vector.Create();

	// Token: 0x0400B7B9 RID: 47033
	[StaticVariableRuleIgnore]
	private static readonly Vector DownOffset = Vector.Create();

	// Token: 0x0400B7BA RID: 47034
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x0400B7BB RID: 47035
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x0400B7BC RID: 47036
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector3 = Vector.Create();

	// Token: 0x0400B7BD RID: 47037
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector4 = Vector.Create();

	// Token: 0x0400B7BE RID: 47038
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector5 = Vector.Create();
}
