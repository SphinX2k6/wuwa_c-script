using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020022FD RID: 8957
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/BulletBlueprintFunctionLibrary.BulletBlueprintFunctionLibrary_C")]
public class BulletBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601612A RID: 90410 RVA: 0x0066A8F4 File Offset: 0x00668AF4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float CreateBulletForDebug(TsBaseCharacter owner, string bulletRowName)
	{
		return (float)BulletController.Instance.CreateBulletForDebug(owner, bulletRowName);
	}

	// Token: 0x0601612B RID: 90411 RVA: 0x0066A904 File Offset: 0x00668B04
	[NullableContext(1)]
	private static string GetSpecialBulletToSkillId(string bulletRowName, string skillId)
	{
		if (skillId != "")
		{
			return skillId;
		}
		int valueOrDefault = SpecialBulletToSkillIdMap.Values.GetValueOrDefault(bulletRowName, 0);
		if (valueOrDefault == 0)
		{
			return "";
		}
		return valueOrDefault.ToString();
	}

	// Token: 0x0601612C RID: 90412 RVA: 0x0066A940 File Offset: 0x00668B40
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int CreateBulletFromGA(TsBaseCharacter owner, string bulletRowName, FTransformDouble initialTransform, string skillId, bool needSync = true, FVectorDouble targetLocation = default(FVectorDouble))
	{
		string specialBulletToSkillId = BulletBlueprintFunctionLibrary.GetSpecialBulletToSkillId(bulletRowName, skillId);
		if (specialBulletToSkillId == "")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "CreateBulletFromGA的SkillId为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bullet", bulletRowName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return -1;
		}
		long? skillContextId = BulletUtil.GetSkillContextId(owner.GetEntityNoBlueprint(), int.Parse(specialBulletToSkillId));
		BulletController instance2 = BulletController.Instance;
		FTransformDouble? initialTransform2 = new FTransformDouble?(initialTransform);
		BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
		bulletCreateParams.SkillId = int.Parse(specialBulletToSkillId);
		bulletCreateParams.SkillContextId = skillContextId;
		bulletCreateParams.SyncType = (needSync ? global::EBulletSyncType.SyncCreate : global::EBulletSyncType.Local);
		bulletCreateParams.InitTargetLocation = new FVectorDouble?(targetLocation);
		Entity entityNoBlueprint = owner.GetEntityNoBlueprint();
		ISkillBattleContext battleContext;
		if (entityNoBlueprint == null)
		{
			battleContext = null;
		}
		else
		{
			BaseSkillComponent component = entityNoBlueprint.GetComponent<BaseSkillComponent>();
			if (component == null)
			{
				battleContext = null;
			}
			else
			{
				Skill skill = component.GetSkill(int.Parse(specialBulletToSkillId));
				battleContext = ((skill != null) ? skill.BattleContext : null);
			}
		}
		bulletCreateParams.BattleContext = battleContext;
		BulletEntity bulletEntity = instance2.CreateBulletCustomTarget(owner, bulletRowName, initialTransform2, bulletCreateParams, skillContextId, EBulletCreateSource.Skill);
		if (bulletEntity != null)
		{
			return bulletEntity.Id;
		}
		return -1;
	}

	// Token: 0x0601612D RID: 90413 RVA: 0x0066AA28 File Offset: 0x00668C28
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static AActor GetBulletActorById(int id)
	{
		Entity entity = EntitySystem.Instance.Get(id);
		if (entity == null || !entity.Valid)
		{
			return null;
		}
		return entity.GetComponent<BulletActorComponent>().Owner;
	}

	// Token: 0x0601612E RID: 90414 RVA: 0x0066AA5F File Offset: 0x00668C5F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool DestroyBullet(int id, bool isSummonChildBullet, bool destroyEffectImmediately = false)
	{
		BulletController.Instance.DestroyBullet(id, isSummonChildBullet, EBulletDestroyReason.Normal, destroyEffectImmediately);
		return true;
	}

	// Token: 0x0601612F RID: 90415 RVA: 0x0066AA70 File Offset: 0x00668C70
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DestroyAllBullet(bool summonChild = false)
	{
		BulletController.Instance.DestroyAllBullet(summonChild);
	}

	// Token: 0x06016130 RID: 90416 RVA: 0x0066AA7D File Offset: 0x00668C7D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DestroySpecifiedBullet(int ownerId, FName bulletName, bool summonChild = false, int includeTeammate = 0, float interval = 0f)
	{
		BulletController.Instance.DestroySpecifiedBullet(ownerId, bulletName, summonChild, includeTeammate, interval);
	}

	// Token: 0x06016131 RID: 90417 RVA: 0x0066AA8F File Offset: 0x00668C8F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetSpecifiedBulletCount(int ownerId, FName bulletName)
	{
		return BulletController.Instance.GetSpecifiedBulletCount(ownerId, bulletName);
	}

	// Token: 0x06016132 RID: 90418 RVA: 0x0066AAA0 File Offset: 0x00668CA0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<int> GetCharacterLaunchedBulletIds(int characterId)
	{
		IReadOnlyCollection<BulletEntity> bulletSetByAttacker = BulletModel.Instance.GetBulletSetByAttacker(characterId);
		if (bulletSetByAttacker == null)
		{
			return null;
		}
		TArray<int> tarray = new TArray<int>();
		foreach (BulletEntity bulletEntity in bulletSetByAttacker)
		{
			tarray.Add(bulletEntity.Id);
		}
		return tarray;
	}

	// Token: 0x06016133 RID: 90419 RVA: 0x0066AB08 File Offset: 0x00668D08
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DebugShowBulletCollision(bool isShow, int entityId)
	{
		BulletModel.Instance.SetBulletCollisionDraw(entityId, isShow);
	}

	// Token: 0x06016134 RID: 90420 RVA: 0x0066AB16 File Offset: 0x00668D16
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DebugShowBulletTrace(bool isShow, int entityId)
	{
		BulletModel.Instance.SetBulletTraceDraw(entityId, isShow);
	}

	// Token: 0x06016135 RID: 90421 RVA: 0x0066AB24 File Offset: 0x00668D24
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsShowBulletCollision(int entityId)
	{
		return BulletModel.Instance.ShowBulletCollision(entityId);
	}

	// Token: 0x06016136 RID: 90422 RVA: 0x0066AB31 File Offset: 0x00668D31
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsShowBulletTrace(int entityId)
	{
		BulletModel instance = BulletModel.Instance;
		return instance != null && instance.ShowBulletTrace(entityId);
	}

	// Token: 0x06016137 RID: 90423 RVA: 0x0066AB44 File Offset: 0x00668D44
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FrozenBulletTimeByBulletName(TsBaseCharacter character, string bulletDataName, float time)
	{
		BulletUtil.FrozenCharacterBullet(character.GetEntityIdNoBlueprint(), bulletDataName, time);
	}

	// Token: 0x06016138 RID: 90424 RVA: 0x0066AB53 File Offset: 0x00668D53
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEntityIdByCustomKey(int attackerId, string customKey, int targetId)
	{
		BulletModel.Instance.SetEntityIdByCustomKey(attackerId, customKey, targetId);
	}

	// Token: 0x06016139 RID: 90425 RVA: 0x0066AB64 File Offset: 0x00668D64
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<int> GetAllBullet()
	{
		TArray<int> tarray = new TArray<int>();
		foreach (OrderedSet<BulletEntity> orderedSet in BulletModel.Instance.GetAttackerBulletIterator())
		{
			foreach (BulletEntity bulletEntity in orderedSet)
			{
				tarray.Add(bulletEntity.Id);
			}
		}
		return tarray;
	}

	// Token: 0x0601613A RID: 90426 RVA: 0x0066ABF8 File Offset: 0x00668DF8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FTransformDouble GetBulletTransform(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		FTransformDouble? ftransformDouble;
		if (bulletInfo == null)
		{
			ftransformDouble = null;
		}
		else
		{
			BulletActorComponent actorComponent = bulletInfo.ActorComponent;
			ftransformDouble = ((actorComponent != null) ? new FTransformDouble?(actorComponent.ActorTransform) : null);
		}
		FTransformDouble? ftransformDouble2 = ftransformDouble;
		if (ftransformDouble2 == null)
		{
			return FTransformDouble.Identity;
		}
		return ftransformDouble2.GetValueOrDefault();
	}

	// Token: 0x0601613B RID: 90427 RVA: 0x0066AC4F File Offset: 0x00668E4F
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TsBaseCharacter GetBulletAttacker(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		return ((bulletInfo != null) ? bulletInfo.AttackerActorComp.Owner : null) as TsBaseCharacter;
	}

	// Token: 0x0601613C RID: 90428 RVA: 0x0066AC6D File Offset: 0x00668E6D
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UPrimitiveComponent GetBulletCollision(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		if (bulletInfo == null)
		{
			return null;
		}
		return bulletInfo.CollisionInfo.CollisionComponent;
	}

	// Token: 0x0601613D RID: 90429 RVA: 0x0066AC85 File Offset: 0x00668E85
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static string GetBulletName(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		if (bulletInfo == null)
		{
			return null;
		}
		return bulletInfo.BulletDataMain.BulletName;
	}

	// Token: 0x0601613E RID: 90430 RVA: 0x0066ACA0 File Offset: 0x00668EA0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetBulletStopHitTrue(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		BulletCollisionInfo bulletCollisionInfo = (bulletInfo != null) ? bulletInfo.CollisionInfo : null;
		if (bulletCollisionInfo != null)
		{
			bulletCollisionInfo.StopHit = true;
		}
	}

	// Token: 0x0601613F RID: 90431 RVA: 0x0066ACCC File Offset: 0x00668ECC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetBulletTarget(int id, TsBaseCharacter character)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		if (character != null)
		{
			if (bulletInfo != null)
			{
				bulletInfo.SetTargetById(character.GetEntityIdNoBlueprint());
				return;
			}
		}
		else if (bulletInfo != null)
		{
			bulletInfo.SetTargetById(0);
		}
	}

	// Token: 0x06016140 RID: 90432 RVA: 0x0066ACFD File Offset: 0x00668EFD
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetBulletSummon(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		if (bulletInfo == null)
		{
			return;
		}
		BulletChildInfo childInfo = bulletInfo.ChildInfo;
		if (childInfo == null)
		{
			return;
		}
		childInfo.SetIsActiveSummonChildBullet(true);
	}

	// Token: 0x06016141 RID: 90433 RVA: 0x0066AD1C File Offset: 0x00668F1C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetBulletTransform(int id, FTransformDouble newTransform)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		if (bulletInfo == null)
		{
			return;
		}
		bulletInfo.ActorComponent.SetActorTransform(newTransform, "unknown", true, null);
	}

	// Token: 0x06016142 RID: 90434 RVA: 0x0066AD4F File Offset: 0x00668F4F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetBeginSpeed(int id, float newSpeed)
	{
		BulletController.Instance.SetBulletSpeedRatio(id, newSpeed);
	}

	// Token: 0x06016143 RID: 90435 RVA: 0x0066AD5D File Offset: 0x00668F5D
	[NullableContext(2)]
	private static BulletInfo GetBulletInfo(int id)
	{
		BulletEntity bulletEntityById = BulletModel.Instance.GetBulletEntityById(id);
		if (bulletEntityById == null)
		{
			return null;
		}
		return bulletEntityById.GetBulletInfo();
	}

	// Token: 0x06016144 RID: 90436 RVA: 0x0066AD78 File Offset: 0x00668F78
	[NullableContext(1)]
	private static void CalSectorPoints(FVector centerPoint, FVector forward, FVector up, float angle, float radius, int sectionNum, TArray<FVector> outVectorArray)
	{
		forward.Normalize(1E-08f);
		up.Normalize(1E-08f);
		float angleDeg = (sectionNum > 0) ? (angle / (float)sectionNum) : angle;
		FVector fvector = forward.RotateAngleAxis(-1f * (angle / 2f), up);
		FVector fvector2 = fvector * radius;
		FVector value = centerPoint + fvector2;
		outVectorArray.Add(value);
		for (int i = 0; i < sectionNum; i++)
		{
			fvector2 = fvector2.RotateAngleAxis(angleDeg, up);
			FVector value2 = centerPoint + fvector2;
			outVectorArray.Add(value2);
		}
	}

	// Token: 0x06016145 RID: 90437 RVA: 0x0066AE0E File Offset: 0x0066900E
	[NullableContext(1)]
	private static void RectangleTriangles(int leftDown, int leftTop, int rightDown, int rightTop, TArray<int> outTriangles)
	{
		outTriangles.Add(rightDown);
		outTriangles.Add(rightTop);
		outTriangles.Add(leftTop);
		outTriangles.Add(rightDown);
		outTriangles.Add(leftTop);
		outTriangles.Add(leftDown);
	}

	// Token: 0x06016146 RID: 90438 RVA: 0x0066AE40 File Offset: 0x00669040
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CalcPipe(FVector centerPoint, FVector forward, FVector up, float outsideRadius, float insideRadius, float height, int sectionNum, ref TArray<FVector> outVertices, ref TArray<int> outTriangles)
	{
		forward.Normalize(1E-08f);
		up.Normalize(1E-08f);
		Vector vector = Vector.Create(up);
		vector.MultiplyEqual((double)height);
		Vector vector2 = Vector.Create(centerPoint);
		Vector vector3 = Vector.Create();
		vector2.Subtraction(vector, vector3);
		Vector vector4 = Vector.Create();
		vector2.Addition(vector, vector4);
		int num = 0;
		BulletBlueprintFunctionLibrary.CalSectorPoints(vector3.ToUeVectorOld(), forward, up, 360f, insideRadius, sectionNum, outVertices);
		int num2 = outVertices.Num();
		BulletBlueprintFunctionLibrary.CalSectorPoints(vector3.ToUeVectorOld(), forward, up, 360f, outsideRadius, sectionNum, outVertices);
		int num3 = outVertices.Num();
		BulletBlueprintFunctionLibrary.CalSectorPoints(vector4.ToUeVectorOld(), forward, up, 360f, insideRadius, sectionNum, outVertices);
		int num4 = outVertices.Num();
		BulletBlueprintFunctionLibrary.CalSectorPoints(vector4.ToUeVectorOld(), forward, up, 360f, outsideRadius, sectionNum, outVertices);
		for (int i = 0; i < num2 - 1; i++)
		{
			int leftDown = num3 + i;
			int rightDown = num3 + i + 1;
			int leftTop = num4 + i;
			int rightTop = num4 + i + 1;
			BulletBlueprintFunctionLibrary.RectangleTriangles(leftDown, leftTop, rightDown, rightTop, outTriangles);
			leftDown = num + i + 1;
			rightDown = num + i;
			leftTop = num2 + i + 1;
			rightTop = num2 + i;
			BulletBlueprintFunctionLibrary.RectangleTriangles(leftDown, leftTop, rightDown, rightTop, outTriangles);
			leftDown = num + i;
			rightDown = num + i + 1;
			leftTop = num3 + i;
			rightTop = num3 + i + 1;
			BulletBlueprintFunctionLibrary.RectangleTriangles(leftDown, leftTop, rightDown, rightTop, outTriangles);
			leftDown = num2 + i + 1;
			rightDown = num2 + i;
			leftTop = num4 + i + 1;
			rightTop = num4 + i;
			BulletBlueprintFunctionLibrary.RectangleTriangles(leftDown, leftTop, rightDown, rightTop, outTriangles);
		}
	}

	// Token: 0x06016147 RID: 90439 RVA: 0x0066B008 File Offset: 0x00669208
	[NullableContext(1)]
	private static void CircleTriangles(int centerIndex, int startIndex, int endIndex, bool bAnticlockwise, TArray<int> triangles)
	{
		for (int i = startIndex; i < endIndex; i++)
		{
			if (bAnticlockwise)
			{
				triangles.Add(centerIndex);
				triangles.Add(i + 1);
				triangles.Add(i);
			}
			else
			{
				triangles.Add(centerIndex);
				triangles.Add(i);
				triangles.Add(i + 1);
			}
		}
	}

	// Token: 0x06016148 RID: 90440 RVA: 0x0066B05C File Offset: 0x0066925C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void CalcSector(FVector centerPoint, FVector forward, FVector up, float inAngle, float radius, float height, int sectionNum, ref TArray<FVector> verticesArray, ref TArray<int> trianglesArray)
	{
		forward.Normalize(1E-08f);
		up.Normalize(1E-08f);
		float num = (inAngle > 360f) ? 360f : inAngle;
		FVector fvector = up * height;
		FVector fvector2 = centerPoint - fvector;
		fvector = up * height;
		FVector fvector3 = centerPoint + fvector;
		verticesArray.Add(fvector2);
		BulletBlueprintFunctionLibrary.CalSectorPoints(fvector2, forward, up, num, radius, sectionNum, verticesArray);
		int num2 = 0;
		int num3 = verticesArray.Num() - 1;
		int num4 = verticesArray.Num();
		verticesArray.Add(fvector3);
		BulletBlueprintFunctionLibrary.CalSectorPoints(fvector3, forward, up, num, radius, sectionNum, verticesArray);
		int num5 = verticesArray.Num() - 1;
		BulletBlueprintFunctionLibrary.CircleTriangles(num2, num2 + 1, num3, false, trianglesArray);
		BulletBlueprintFunctionLibrary.CircleTriangles(num4, num4 + 1, num5, true, trianglesArray);
		if (!MathUtils.Instance.IsNearlyEqual((double)num, 360.0, null))
		{
			BulletBlueprintFunctionLibrary.RectangleTriangles(num2 + 1, num4 + 1, num2, num4, trianglesArray);
			BulletBlueprintFunctionLibrary.RectangleTriangles(num2, num4, num3, num5, trianglesArray);
		}
		for (int i = 1; i < num3; i++)
		{
			int num6 = i;
			int num7 = i + 1;
			int rightTop = num4 + num6;
			int leftTop = num4 + num7;
			BulletBlueprintFunctionLibrary.RectangleTriangles(num7, leftTop, num6, rightTop, trianglesArray);
		}
	}

	// Token: 0x06016149 RID: 90441 RVA: 0x0066B1B0 File Offset: 0x006693B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble CalcBulletInitLocation(SReBulletDataMain dataMain, AActor attacker, FTransformDouble target)
	{
		FTransformDouble ftransformDouble = attacker.D_GetTransform();
		Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		Rotator.Create(0f, 90f, 0f).Quaternion(quat);
		FQuat fquat = quat.ToUeQuat();
		ftransformDouble.SetRotation(fquat);
		FVector fvector;
		if (dataMain.移动设置.运动轨迹类型 == EMoveTrajectory.围绕中心旋转)
		{
			FVectorDouble location;
			float yaw;
			FVectorDouble fvectorDouble;
			if (dataMain.移动设置.运动轨迹参数目标 == EBulletTarget.空 || dataMain.移动设置.运动轨迹参数目标 == EBulletTarget.子弹发射者 || dataMain.移动设置.运动轨迹参数目标 == EBulletTarget.队伍角色)
			{
				location = ftransformDouble.GetLocation();
				yaw = ftransformDouble.Rotator().Yaw;
				fquat = ftransformDouble.GetRotation();
				fvector = fquat.GetForwardVector();
				fvectorDouble = fvector;
			}
			else
			{
				location = target.GetLocation();
				fquat = target.GetRotation();
				yaw = fquat.Rotator().Yaw;
				fquat = target.GetRotation();
				fvector = fquat.Vector();
				fvectorDouble = fvector;
			}
			FVector fvector2 = dataMain.移动设置.运动轨迹参数数据[0];
			FVectorDouble result = fvectorDouble.RotateAngleAxis((double)fvector2.Y, Vector.UpVectorDouble);
			result.Z = (double)((float)(-(float)Math.Sin((double)((yaw + fvector2.Y) * 0.017453292f)) * Math.Tan((double)(fvector2.Z * 0.017453292f))));
			result.Normalize(9.99999993922529E-09);
			result = result * (double)fvector2.X;
			result = result + location;
			return result;
		}
		Vector vector = Vector.Create();
		Vector vector2 = Vector.Create();
		Vector vector3 = vector2;
		fvector = dataMain.基础设置.出生位置偏移;
		vector3.FromUeVector(fvector);
		switch (dataMain.基础设置.出生位置基准)
		{
		case EPositionStandard.发射者位置:
		case EPositionStandard.队伍角色:
		{
			Vector vector4 = vector;
			FVectorDouble fvectorDouble2 = vector2.ToUeVector(false);
			FVectorDouble fvectorDouble3 = ftransformDouble.TransformPosition(fvectorDouble2);
			vector4.FromUeVector(fvectorDouble3);
			break;
		}
		case EPositionStandard.技能目标位置:
		case EPositionStandard.世界位置:
		case EPositionStandard.父子弹或外部位置:
		case EPositionStandard.攻击者锁定目标位置:
		case EPositionStandard.自定义目标:
		case EPositionStandard.父子弹受击者:
		case EPositionStandard.父子弹目标:
		case EPositionStandard.前台角色锁定目标:
		case EPositionStandard.伴生物:
		{
			Vector vector5 = vector;
			FVectorDouble fvectorDouble2 = vector2.ToUeVector(false);
			FVectorDouble fvectorDouble3 = target.TransformPosition(fvectorDouble2);
			vector5.FromUeVector(fvectorDouble3);
			break;
		}
		}
		return vector.ToUeVector(false);
	}

	// Token: 0x0601614A RID: 90442 RVA: 0x0066B41C File Offset: 0x0066961C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void AttachToBone(USkeletalMeshComponent meshComp, AActor bulletActor, SReBulletDataMain dataMain)
	{
		TEnumAsByte<EBulletFollowType> 子弹跟随类型 = dataMain.移动设置.子弹跟随类型;
		if (子弹跟随类型 == EBulletFollowType.跟随骨骼)
		{
			bulletActor.K2_AttachToComponent(meshComp, dataMain.移动设置.骨骼名字, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, true, true);
			return;
		}
		if (子弹跟随类型 == EBulletFollowType.跟随骨骼位置旋转)
		{
			bulletActor.K2_AttachToComponent(meshComp, dataMain.移动设置.骨骼名字, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, true, true);
			FVectorDouble newRelativeLocation = UKismetMathLibrary.Conv_VectorToVectorDouble(dataMain.基础设置.出生位置偏移);
			FHitResult fhitResult = null;
			bulletActor.D_K2_SetActorRelativeLocation(newRelativeLocation, false, ref fhitResult, false);
			FHitResult fhitResult2 = null;
			bulletActor.K2_SetActorRelativeRotation(Rotator.ZeroRotator, false, ref fhitResult2, true);
		}
	}

	// Token: 0x0601614B RID: 90443 RVA: 0x0066B4B0 File Offset: 0x006696B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FRotator CalcBulletInitRotator(SReBulletDataMain dataMain, AActor bulletActor, AActor attacker, FTransformDouble target, AActor parentBulletActor)
	{
		Rotator rotator = Rotator.Create();
		if (dataMain.移动设置.运动轨迹类型 == EMoveTrajectory.围绕中心旋转)
		{
			return bulletActor.K2_GetActorRotation();
		}
		switch (dataMain.移动设置.出生初速度方向基准)
		{
		case EInitialVelocityDirection.默认:
		{
			FVector fvector = bulletActor.GetActorForwardVector().RotateAngleAxis(90f, Vector.UpVector);
			Rotator rotator2 = rotator;
			FRotator frotator = fvector.Rotation();
			rotator2.FromUeRotator(frotator);
			break;
		}
		case EInitialVelocityDirection.面向目标:
		case EInitialVelocityDirection.面向发射者锁定目标:
		case EInitialVelocityDirection.面向自定义目标:
		case EInitialVelocityDirection.父子弹受击者:
		case EInitialVelocityDirection.父子弹目标:
		case EInitialVelocityDirection.前台角色锁定目标:
		case EInitialVelocityDirection.伴生物:
		{
			Rotator rotator3 = rotator;
			FVectorDouble fvectorDouble = bulletActor.D_K2_GetActorLocation();
			FVectorDouble fvectorDouble2 = target.GetLocation();
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble2);
			rotator3.FromUeRotator(frotator);
			break;
		}
		case EInitialVelocityDirection.面向发射者:
		case EInitialVelocityDirection.队伍角色:
		{
			Rotator rotator4 = rotator;
			FVectorDouble fvectorDouble = bulletActor.D_K2_GetActorLocation();
			FVectorDouble fvectorDouble2 = attacker.D_K2_GetActorLocation();
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble2);
			rotator4.FromUeRotator(frotator);
			break;
		}
		case EInitialVelocityDirection.父子弹方向:
		{
			Rotator rotator5 = rotator;
			FRotator frotator = parentBulletActor.K2_GetActorRotation();
			rotator5.FromUeRotator(frotator);
			break;
		}
		case EInitialVelocityDirection.跟随骨骼默认朝向:
		{
			Rotator rotator6 = rotator;
			FRotator frotator = bulletActor.K2_GetActorRotation();
			rotator6.FromUeRotator(frotator);
			break;
		}
		}
		bool openCreateLog = BulletConstant.Instance.OpenCreateLog;
		return rotator.ToUeRotator();
	}

	// Token: 0x0601614C RID: 90444 RVA: 0x0066B5DC File Offset: 0x006697DC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FRotator CalcBulletRotator(SReBulletDataMain dataMain, AActor bulletActor, AActor attacker, FVectorDouble target, float delta)
	{
		Rotator rotator = Rotator.Create();
		Vector vector = Vector.Create();
		switch (dataMain.移动设置.运动轨迹类型)
		{
		case EMoveTrajectory.默认:
		{
			Rotator rotator2 = rotator;
			FRotator frotator = bulletActor.K2_GetActorRotation();
			rotator2.FromUeRotator(frotator);
			break;
		}
		case EMoveTrajectory.限时命中子弹:
		{
			Rotator rotator3 = rotator;
			FVectorDouble fvectorDouble = bulletActor.D_K2_GetActorLocation();
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, target);
			rotator3.FromUeRotator(frotator);
			break;
		}
		case EMoveTrajectory.围绕中心旋转:
		{
			FVector fvector = dataMain.移动设置.运动轨迹参数数据[0];
			float num = dataMain.移动设置.移动速度 * delta * 57.29578f / fvector.X;
			vector.Set(0.0, Math.Sin((double)(fvector.Z * 0.017453292f)), Math.Cos((double)(fvector.Z * 0.017453292f)));
			EBulletTarget ebulletTarget = dataMain.移动设置.运动轨迹参数目标;
			FVectorDouble fvectorDouble2;
			if (ebulletTarget == EBulletTarget.空 || ebulletTarget == EBulletTarget.子弹发射者 || ebulletTarget == EBulletTarget.队伍角色)
			{
				fvectorDouble2 = attacker.D_K2_GetActorLocation();
			}
			else
			{
				fvectorDouble2 = target;
			}
			FVectorDouble fvectorDouble = bulletActor.D_K2_GetActorLocation();
			FVectorDouble fvectorDouble3 = fvectorDouble2 - fvectorDouble;
			double angleDeg = (double)num;
			fvectorDouble = vector.ToUeVector(false);
			FVectorDouble fvectorDouble4 = fvectorDouble3.RotateAngleAxis(angleDeg, fvectorDouble);
			FVectorDouble newLocation = fvectorDouble2 + fvectorDouble4;
			bulletActor.K2_SetActorRotation(UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble2, newLocation), false);
			FHitResult fhitResult = null;
			bulletActor.D_K2_SetActorLocation(newLocation, false, ref fhitResult, true);
			break;
		}
		}
		return rotator.ToUeRotator();
	}

	// Token: 0x0601614D RID: 90445 RVA: 0x0066B750 File Offset: 0x00669950
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble CalcBulletLocation(SReBulletDataMain dataMain, AActor bulletActor, float delta)
	{
		FVectorDouble fvectorDouble = bulletActor.D_K2_GetActorLocation();
		FVectorDouble fvectorDouble2 = bulletActor.D_GetActorForwardVector();
		FVectorDouble fvectorDouble3 = fvectorDouble2 * (double)(dataMain.移动设置.移动速度 * delta);
		return fvectorDouble + fvectorDouble3;
	}

	// Token: 0x0601614E RID: 90446 RVA: 0x0066B78A File Offset: 0x0066998A
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetCampRelationship(int camp1, int camp2)
	{
		return (int)CampUtils.GetCampRelationship((ECamp)camp1, (ECamp)camp2);
	}

	// Token: 0x0601614F RID: 90447 RVA: 0x0066B798 File Offset: 0x00669998
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetCamp(int entityId)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(entityId);
		if (handle != null && handle.Valid)
		{
			WorldEntity entity = handle.Entity;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			if (creatureDataComponent != null)
			{
				return (int)creatureDataComponent.GetEntityCamp();
			}
		}
		return -1;
	}

	// Token: 0x06016150 RID: 90448 RVA: 0x0066B7DA File Offset: 0x006699DA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void NotifyProcessKuroBulletOperationList()
	{
		BulletController.Instance.ProcessKuroBulletOperationList();
	}

	// Token: 0x06016151 RID: 90449 RVA: 0x0066B7E6 File Offset: 0x006699E6
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void NotifyExistedImmediatelyOperation(FBulletHitWorldEntityOperation operation)
	{
		BulletController.Instance.ProcessKuroBulletOperation(operation);
	}

	// Token: 0x06016152 RID: 90450 RVA: 0x0066B7F3 File Offset: 0x006699F3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (BulletBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/BulletBlueprintFunctionLibrary.BulletBlueprintFunctionLibrary_C");
		}
		return BulletBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06016153 RID: 90451 RVA: 0x0066B818 File Offset: 0x00669A18
	public BulletBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016154 RID: 90452 RVA: 0x0066B840 File Offset: 0x00669A40
	[NullableContext(1)]
	public BulletBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016155 RID: 90453 RVA: 0x0066B873 File Offset: 0x00669A73
	protected BulletBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016156 RID: 90454 RVA: 0x0066B87C File Offset: 0x00669A7C
	protected unsafe static void __CPPCALL_CreateBulletForDebug_Implementation(BulletBlueprintFunctionLibrary.__CreateBulletForDebug_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		string bulletRowName = FString.ToString((void*)(&__Params->bulletRowName));
		__Params->__Result = BulletBlueprintFunctionLibrary.CreateBulletForDebug(orCreateUObjectByNativePointer, bulletRowName);
	}

	// Token: 0x06016157 RID: 90455 RVA: 0x0066B8B0 File Offset: 0x00669AB0
	protected unsafe static void __CPPCALL_CreateBulletFromGA_Implementation(BulletBlueprintFunctionLibrary.__CreateBulletFromGA_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		string bulletRowName = FString.ToString((void*)(&__Params->bulletRowName));
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = BulletBlueprintFunctionLibrary.CreateBulletFromGA(orCreateUObjectByNativePointer, bulletRowName, __Params->initialTransform, skillId, __Params->needSync, __Params->targetLocation);
	}

	// Token: 0x06016158 RID: 90456 RVA: 0x0066B903 File Offset: 0x00669B03
	protected unsafe static void __CPPCALL_GetBulletActorById_Implementation(BulletBlueprintFunctionLibrary.__GetBulletActorById_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor bulletActorById = BulletBlueprintFunctionLibrary.GetBulletActorById(__Params->id);
		ptr = ((bulletActorById != null) ? bulletActorById.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016159 RID: 90457 RVA: 0x0066B925 File Offset: 0x00669B25
	protected unsafe static void __CPPCALL_DestroyBullet_Implementation(BulletBlueprintFunctionLibrary.__DestroyBullet_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.DestroyBullet(__Params->id, __Params->isSummonChildBullet, __Params->destroyEffectImmediately);
	}

	// Token: 0x0601615A RID: 90458 RVA: 0x0066B944 File Offset: 0x00669B44
	protected unsafe static void __CPPCALL_DestroyAllBullet_Implementation(BulletBlueprintFunctionLibrary.__DestroyAllBullet_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DestroyAllBullet(__Params->summonChild);
	}

	// Token: 0x0601615B RID: 90459 RVA: 0x0066B951 File Offset: 0x00669B51
	protected unsafe static void __CPPCALL_DestroySpecifiedBullet_Implementation(BulletBlueprintFunctionLibrary.__DestroySpecifiedBullet_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DestroySpecifiedBullet(__Params->ownerId, __Params->bulletName, __Params->summonChild, __Params->includeTeammate, __Params->interval);
	}

	// Token: 0x0601615C RID: 90460 RVA: 0x0066B976 File Offset: 0x00669B76
	protected unsafe static void __CPPCALL_GetSpecifiedBulletCount_Implementation(BulletBlueprintFunctionLibrary.__GetSpecifiedBulletCount_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetSpecifiedBulletCount(__Params->ownerId, __Params->bulletName);
	}

	// Token: 0x0601615D RID: 90461 RVA: 0x0066B990 File Offset: 0x00669B90
	protected unsafe static void __CPPCALL_GetCharacterLaunchedBulletIds_Implementation(BulletBlueprintFunctionLibrary.__GetCharacterLaunchedBulletIds_FunctionParams* __Params)
	{
		TArray<int> characterLaunchedBulletIds = BulletBlueprintFunctionLibrary.GetCharacterLaunchedBulletIds(__Params->characterId);
		if (characterLaunchedBulletIds == null)
		{
			return;
		}
		characterLaunchedBulletIds.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601615E RID: 90462 RVA: 0x0066B9C2 File Offset: 0x00669BC2
	protected unsafe static void __CPPCALL_DebugShowBulletCollision_Implementation(BulletBlueprintFunctionLibrary.__DebugShowBulletCollision_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DebugShowBulletCollision(__Params->isShow, __Params->entityId);
	}

	// Token: 0x0601615F RID: 90463 RVA: 0x0066B9D5 File Offset: 0x00669BD5
	protected unsafe static void __CPPCALL_DebugShowBulletTrace_Implementation(BulletBlueprintFunctionLibrary.__DebugShowBulletTrace_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DebugShowBulletTrace(__Params->isShow, __Params->entityId);
	}

	// Token: 0x06016160 RID: 90464 RVA: 0x0066B9E8 File Offset: 0x00669BE8
	protected unsafe static void __CPPCALL_GetIsShowBulletCollision_Implementation(BulletBlueprintFunctionLibrary.__GetIsShowBulletCollision_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetIsShowBulletCollision(__Params->entityId);
	}

	// Token: 0x06016161 RID: 90465 RVA: 0x0066B9FB File Offset: 0x00669BFB
	protected unsafe static void __CPPCALL_GetIsShowBulletTrace_Implementation(BulletBlueprintFunctionLibrary.__GetIsShowBulletTrace_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetIsShowBulletTrace(__Params->entityId);
	}

	// Token: 0x06016162 RID: 90466 RVA: 0x0066BA10 File Offset: 0x00669C10
	protected unsafe static void __CPPCALL_FrozenBulletTimeByBulletName_Implementation(BulletBlueprintFunctionLibrary.__FrozenBulletTimeByBulletName_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		string bulletDataName = FString.ToString((void*)(&__Params->bulletDataName));
		BulletBlueprintFunctionLibrary.FrozenBulletTimeByBulletName(orCreateUObjectByNativePointer, bulletDataName, __Params->time);
	}

	// Token: 0x06016163 RID: 90467 RVA: 0x0066BA44 File Offset: 0x00669C44
	protected unsafe static void __CPPCALL_SetEntityIdByCustomKey_Implementation(BulletBlueprintFunctionLibrary.__SetEntityIdByCustomKey_FunctionParams* __Params)
	{
		string customKey = FString.ToString((void*)(&__Params->customKey));
		BulletBlueprintFunctionLibrary.SetEntityIdByCustomKey(__Params->attackerId, customKey, __Params->targetId);
	}

	// Token: 0x06016164 RID: 90468 RVA: 0x0066BA70 File Offset: 0x00669C70
	protected unsafe static void __CPPCALL_GetAllBullet_Implementation(BulletBlueprintFunctionLibrary.__GetAllBullet_FunctionParams* __Params)
	{
		TArray<int> allBullet = BulletBlueprintFunctionLibrary.GetAllBullet();
		if (allBullet == null)
		{
			return;
		}
		allBullet.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06016165 RID: 90469 RVA: 0x0066BA9C File Offset: 0x00669C9C
	protected unsafe static void __CPPCALL_GetBulletTransform_Implementation(BulletBlueprintFunctionLibrary.__GetBulletTransform_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetBulletTransform(__Params->id);
	}

	// Token: 0x06016166 RID: 90470 RVA: 0x0066BAAF File Offset: 0x00669CAF
	protected unsafe static void __CPPCALL_GetBulletAttacker_Implementation(BulletBlueprintFunctionLibrary.__GetBulletAttacker_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter bulletAttacker = BulletBlueprintFunctionLibrary.GetBulletAttacker(__Params->id);
		ptr = ((bulletAttacker != null) ? bulletAttacker.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016167 RID: 90471 RVA: 0x0066BAD1 File Offset: 0x00669CD1
	protected unsafe static void __CPPCALL_GetBulletCollision_Implementation(BulletBlueprintFunctionLibrary.__GetBulletCollision_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UPrimitiveComponent bulletCollision = BulletBlueprintFunctionLibrary.GetBulletCollision(__Params->id);
		ptr = ((bulletCollision != null) ? bulletCollision.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016168 RID: 90472 RVA: 0x0066BAF3 File Offset: 0x00669CF3
	protected unsafe static void __CPPCALL_GetBulletName_Implementation(BulletBlueprintFunctionLibrary.__GetBulletName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), BulletBlueprintFunctionLibrary.GetBulletName(__Params->id));
	}

	// Token: 0x06016169 RID: 90473 RVA: 0x0066BB0C File Offset: 0x00669D0C
	protected unsafe static void __CPPCALL_SetBulletStopHitTrue_Implementation(BulletBlueprintFunctionLibrary.__SetBulletStopHitTrue_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBulletStopHitTrue(__Params->id);
	}

	// Token: 0x0601616A RID: 90474 RVA: 0x0066BB1C File Offset: 0x00669D1C
	protected unsafe static void __CPPCALL_SetBulletTarget_Implementation(BulletBlueprintFunctionLibrary.__SetBulletTarget_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		BulletBlueprintFunctionLibrary.SetBulletTarget(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601616B RID: 90475 RVA: 0x0066BB41 File Offset: 0x00669D41
	protected unsafe static void __CPPCALL_SetBulletSummon_Implementation(BulletBlueprintFunctionLibrary.__SetBulletSummon_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBulletSummon(__Params->id);
	}

	// Token: 0x0601616C RID: 90476 RVA: 0x0066BB4E File Offset: 0x00669D4E
	protected unsafe static void __CPPCALL_SetBulletTransform_Implementation(BulletBlueprintFunctionLibrary.__SetBulletTransform_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBulletTransform(__Params->id, __Params->newTransform);
	}

	// Token: 0x0601616D RID: 90477 RVA: 0x0066BB61 File Offset: 0x00669D61
	protected unsafe static void __CPPCALL_SetBeginSpeed_Implementation(BulletBlueprintFunctionLibrary.__SetBeginSpeed_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBeginSpeed(__Params->id, __Params->newSpeed);
	}

	// Token: 0x0601616E RID: 90478 RVA: 0x0066BB74 File Offset: 0x00669D74
	protected unsafe static void __CPPCALL_CalcPipe_Implementation(BulletBlueprintFunctionLibrary.__CalcPipe_FunctionParams* __Params)
	{
		TArray<FVector> tarray = new TArray<FVector>(&__Params->outVertices, true, true);
		TArray<int> tarray2 = new TArray<int>(&__Params->outTriangles, true, true);
		BulletBlueprintFunctionLibrary.CalcPipe(__Params->centerPoint, __Params->forward, __Params->up, __Params->outsideRadius, __Params->insideRadius, __Params->height, __Params->sectionNum, ref tarray, ref tarray2);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->outVertices, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->outTriangles, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601616F RID: 90479 RVA: 0x0066BC04 File Offset: 0x00669E04
	protected unsafe static void __CPPCALL_CalcSector_Implementation(BulletBlueprintFunctionLibrary.__CalcSector_FunctionParams* __Params)
	{
		TArray<FVector> tarray = new TArray<FVector>(&__Params->verticesArray, true, true);
		TArray<int> tarray2 = new TArray<int>(&__Params->trianglesArray, true, true);
		BulletBlueprintFunctionLibrary.CalcSector(__Params->centerPoint, __Params->forward, __Params->up, __Params->inAngle, __Params->radius, __Params->height, __Params->sectionNum, ref tarray, ref tarray2);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->verticesArray, default(UScriptStructStackOnlyPtr));
		}
		if (tarray2 != null)
		{
			tarray2.CopyTo(&__Params->trianglesArray, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06016170 RID: 90480 RVA: 0x0066BC94 File Offset: 0x00669E94
	protected unsafe static void __CPPCALL_CalcBulletInitLocation_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletInitLocation_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->attacker);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletInitLocation(dataMain, orCreateUObjectByNativePointer, __Params->target);
	}

	// Token: 0x06016171 RID: 90481 RVA: 0x0066BCD0 File Offset: 0x00669ED0
	protected unsafe static void __CPPCALL_AttachToBone_Implementation(BulletBlueprintFunctionLibrary.__AttachToBone_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->meshComp);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		BulletBlueprintFunctionLibrary.AttachToBone(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, dataMain);
	}

	// Token: 0x06016172 RID: 90482 RVA: 0x0066BD0C File Offset: 0x00669F0C
	protected unsafe static void __CPPCALL_CalcBulletInitRotator_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletInitRotator_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->attacker);
		AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->parentBulletActor);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletInitRotator(dataMain, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->target, orCreateUObjectByNativePointer3);
	}

	// Token: 0x06016173 RID: 90483 RVA: 0x0066BD64 File Offset: 0x00669F64
	protected unsafe static void __CPPCALL_CalcBulletRotator_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletRotator_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->attacker);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletRotator(dataMain, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->target, __Params->delta);
	}

	// Token: 0x06016174 RID: 90484 RVA: 0x0066BDB4 File Offset: 0x00669FB4
	protected unsafe static void __CPPCALL_CalcBulletLocation_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletLocation_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletLocation(dataMain, orCreateUObjectByNativePointer, __Params->delta);
	}

	// Token: 0x06016175 RID: 90485 RVA: 0x0066BDEF File Offset: 0x00669FEF
	protected unsafe static void __CPPCALL_GetCampRelationship_Implementation(BulletBlueprintFunctionLibrary.__GetCampRelationship_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetCampRelationship(__Params->camp1, __Params->camp2);
	}

	// Token: 0x06016176 RID: 90486 RVA: 0x0066BE08 File Offset: 0x0066A008
	protected unsafe static void __CPPCALL_GetCamp_Implementation(BulletBlueprintFunctionLibrary.__GetCamp_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetCamp(__Params->entityId);
	}

	// Token: 0x06016177 RID: 90487 RVA: 0x0066BE1B File Offset: 0x0066A01B
	protected unsafe static void __CPPCALL_NotifyProcessKuroBulletOperationList_Implementation(BulletBlueprintFunctionLibrary.__NotifyProcessKuroBulletOperationList_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.NotifyProcessKuroBulletOperationList();
	}

	// Token: 0x06016178 RID: 90488 RVA: 0x0066BE22 File Offset: 0x0066A022
	protected unsafe static void __CPPCALL_NotifyExistedImmediatelyOperation_Implementation(BulletBlueprintFunctionLibrary.__NotifyExistedImmediatelyOperation_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.NotifyExistedImmediatelyOperation(new FBulletHitWorldEntityOperation(&__Params->operation, true, true));
	}

	// Token: 0x0400B966 RID: 47462
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/BulletBlueprintFunctionLibrary.BulletBlueprintFunctionLibrary_C";

	// Token: 0x0400B967 RID: 47463
	private static IntPtr _ClassPtr;

	// Token: 0x0400B968 RID: 47464
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0200853D RID: 34109
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CreateBulletForDebug_FunctionParams
	{
		// Token: 0x0402AEF4 RID: 175860
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402AEF5 RID: 175861
		[FieldOffset(8)]
		public FString bulletRowName;

		// Token: 0x0402AEF6 RID: 175862
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402AEF7 RID: 175863
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x0200853E RID: 34110
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 160)]
	protected ref struct __CreateBulletFromGA_FunctionParams
	{
		// Token: 0x0402AEF8 RID: 175864
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402AEF9 RID: 175865
		[FieldOffset(8)]
		public FString bulletRowName;

		// Token: 0x0402AEFA RID: 175866
		[FieldOffset(32)]
		public FTransformDouble initialTransform;

		// Token: 0x0402AEFB RID: 175867
		[FieldOffset(96)]
		public FString skillId;

		// Token: 0x0402AEFC RID: 175868
		[FieldOffset(112)]
		public bool needSync;

		// Token: 0x0402AEFD RID: 175869
		[FieldOffset(120)]
		public FVectorDouble targetLocation;

		// Token: 0x0402AEFE RID: 175870
		[FieldOffset(144)]
		public IntPtr __WorldContext;

		// Token: 0x0402AEFF RID: 175871
		[FieldOffset(152)]
		public int __Result;
	}

	// Token: 0x0200853F RID: 34111
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBulletActorById_FunctionParams
	{
		// Token: 0x0402AF00 RID: 175872
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF01 RID: 175873
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF02 RID: 175874
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02008540 RID: 34112
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DestroyBullet_FunctionParams
	{
		// Token: 0x0402AF03 RID: 175875
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF04 RID: 175876
		[FieldOffset(4)]
		public bool isSummonChildBullet;

		// Token: 0x0402AF05 RID: 175877
		[FieldOffset(5)]
		public bool destroyEffectImmediately;

		// Token: 0x0402AF06 RID: 175878
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF07 RID: 175879
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008541 RID: 34113
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DestroyAllBullet_FunctionParams
	{
		// Token: 0x0402AF08 RID: 175880
		[FieldOffset(0)]
		public bool summonChild;

		// Token: 0x0402AF09 RID: 175881
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008542 RID: 34114
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __DestroySpecifiedBullet_FunctionParams
	{
		// Token: 0x0402AF0A RID: 175882
		[FieldOffset(0)]
		public int ownerId;

		// Token: 0x0402AF0B RID: 175883
		[FieldOffset(4)]
		public FName bulletName;

		// Token: 0x0402AF0C RID: 175884
		[FieldOffset(16)]
		public bool summonChild;

		// Token: 0x0402AF0D RID: 175885
		[FieldOffset(20)]
		public int includeTeammate;

		// Token: 0x0402AF0E RID: 175886
		[FieldOffset(24)]
		public float interval;

		// Token: 0x0402AF0F RID: 175887
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008543 RID: 34115
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSpecifiedBulletCount_FunctionParams
	{
		// Token: 0x0402AF10 RID: 175888
		[FieldOffset(0)]
		public int ownerId;

		// Token: 0x0402AF11 RID: 175889
		[FieldOffset(4)]
		public FName bulletName;

		// Token: 0x0402AF12 RID: 175890
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF13 RID: 175891
		[FieldOffset(24)]
		public int __Result;
	}

	// Token: 0x02008544 RID: 34116
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterLaunchedBulletIds_FunctionParams
	{
		// Token: 0x0402AF14 RID: 175892
		[FieldOffset(0)]
		public int characterId;

		// Token: 0x0402AF15 RID: 175893
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF16 RID: 175894
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x02008545 RID: 34117
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DebugShowBulletCollision_FunctionParams
	{
		// Token: 0x0402AF17 RID: 175895
		[FieldOffset(0)]
		public bool isShow;

		// Token: 0x0402AF18 RID: 175896
		[FieldOffset(4)]
		public int entityId;

		// Token: 0x0402AF19 RID: 175897
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008546 RID: 34118
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DebugShowBulletTrace_FunctionParams
	{
		// Token: 0x0402AF1A RID: 175898
		[FieldOffset(0)]
		public bool isShow;

		// Token: 0x0402AF1B RID: 175899
		[FieldOffset(4)]
		public int entityId;

		// Token: 0x0402AF1C RID: 175900
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008547 RID: 34119
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsShowBulletCollision_FunctionParams
	{
		// Token: 0x0402AF1D RID: 175901
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402AF1E RID: 175902
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF1F RID: 175903
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008548 RID: 34120
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsShowBulletTrace_FunctionParams
	{
		// Token: 0x0402AF20 RID: 175904
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402AF21 RID: 175905
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF22 RID: 175906
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02008549 RID: 34121
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FrozenBulletTimeByBulletName_FunctionParams
	{
		// Token: 0x0402AF23 RID: 175907
		[FieldOffset(0)]
		public IntPtr character;

		// Token: 0x0402AF24 RID: 175908
		[FieldOffset(8)]
		public FString bulletDataName;

		// Token: 0x0402AF25 RID: 175909
		[FieldOffset(24)]
		public float time;

		// Token: 0x0402AF26 RID: 175910
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200854A RID: 34122
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetEntityIdByCustomKey_FunctionParams
	{
		// Token: 0x0402AF27 RID: 175911
		[FieldOffset(0)]
		public int attackerId;

		// Token: 0x0402AF28 RID: 175912
		[FieldOffset(8)]
		public FString customKey;

		// Token: 0x0402AF29 RID: 175913
		[FieldOffset(24)]
		public int targetId;

		// Token: 0x0402AF2A RID: 175914
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200854B RID: 34123
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAllBullet_FunctionParams
	{
		// Token: 0x0402AF2B RID: 175915
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF2C RID: 175916
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200854C RID: 34124
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __GetBulletTransform_FunctionParams
	{
		// Token: 0x0402AF2D RID: 175917
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF2E RID: 175918
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF2F RID: 175919
		[FieldOffset(16)]
		public FTransformDouble __Result;
	}

	// Token: 0x0200854D RID: 34125
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBulletAttacker_FunctionParams
	{
		// Token: 0x0402AF30 RID: 175920
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF31 RID: 175921
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF32 RID: 175922
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200854E RID: 34126
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBulletCollision_FunctionParams
	{
		// Token: 0x0402AF33 RID: 175923
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF34 RID: 175924
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF35 RID: 175925
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x0200854F RID: 34127
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBulletName_FunctionParams
	{
		// Token: 0x0402AF36 RID: 175926
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF37 RID: 175927
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF38 RID: 175928
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02008550 RID: 34128
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBulletStopHitTrue_FunctionParams
	{
		// Token: 0x0402AF39 RID: 175929
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF3A RID: 175930
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008551 RID: 34129
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetBulletTarget_FunctionParams
	{
		// Token: 0x0402AF3B RID: 175931
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF3C RID: 175932
		[FieldOffset(8)]
		public IntPtr character;

		// Token: 0x0402AF3D RID: 175933
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008552 RID: 34130
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBulletSummon_FunctionParams
	{
		// Token: 0x0402AF3E RID: 175934
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF3F RID: 175935
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008553 RID: 34131
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SetBulletTransform_FunctionParams
	{
		// Token: 0x0402AF40 RID: 175936
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF41 RID: 175937
		[FieldOffset(16)]
		public FTransformDouble newTransform;

		// Token: 0x0402AF42 RID: 175938
		[FieldOffset(80)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008554 RID: 34132
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBeginSpeed_FunctionParams
	{
		// Token: 0x0402AF43 RID: 175939
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402AF44 RID: 175940
		[FieldOffset(4)]
		public float newSpeed;

		// Token: 0x0402AF45 RID: 175941
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008555 RID: 34133
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __CalcPipe_FunctionParams
	{
		// Token: 0x0402AF46 RID: 175942
		[FieldOffset(0)]
		public FVector centerPoint;

		// Token: 0x0402AF47 RID: 175943
		[FieldOffset(12)]
		public FVector forward;

		// Token: 0x0402AF48 RID: 175944
		[FieldOffset(24)]
		public FVector up;

		// Token: 0x0402AF49 RID: 175945
		[FieldOffset(36)]
		public float outsideRadius;

		// Token: 0x0402AF4A RID: 175946
		[FieldOffset(40)]
		public float insideRadius;

		// Token: 0x0402AF4B RID: 175947
		[FieldOffset(44)]
		public float height;

		// Token: 0x0402AF4C RID: 175948
		[FieldOffset(48)]
		public int sectionNum;

		// Token: 0x0402AF4D RID: 175949
		[FieldOffset(56)]
		public byte outVertices;

		// Token: 0x0402AF4E RID: 175950
		[FieldOffset(72)]
		public byte outTriangles;

		// Token: 0x0402AF4F RID: 175951
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008556 RID: 34134
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __CalcSector_FunctionParams
	{
		// Token: 0x0402AF50 RID: 175952
		[FieldOffset(0)]
		public FVector centerPoint;

		// Token: 0x0402AF51 RID: 175953
		[FieldOffset(12)]
		public FVector forward;

		// Token: 0x0402AF52 RID: 175954
		[FieldOffset(24)]
		public FVector up;

		// Token: 0x0402AF53 RID: 175955
		[FieldOffset(36)]
		public float inAngle;

		// Token: 0x0402AF54 RID: 175956
		[FieldOffset(40)]
		public float radius;

		// Token: 0x0402AF55 RID: 175957
		[FieldOffset(44)]
		public float height;

		// Token: 0x0402AF56 RID: 175958
		[FieldOffset(48)]
		public int sectionNum;

		// Token: 0x0402AF57 RID: 175959
		[FieldOffset(56)]
		public byte verticesArray;

		// Token: 0x0402AF58 RID: 175960
		[FieldOffset(72)]
		public byte trianglesArray;

		// Token: 0x0402AF59 RID: 175961
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008557 RID: 34135
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2096)]
	protected ref struct __CalcBulletInitLocation_FunctionParams
	{
		// Token: 0x0402AF5A RID: 175962
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402AF5B RID: 175963
		[FieldOffset(1992)]
		public IntPtr attacker;

		// Token: 0x0402AF5C RID: 175964
		[FieldOffset(2000)]
		public FTransformDouble target;

		// Token: 0x0402AF5D RID: 175965
		[FieldOffset(2064)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF5E RID: 175966
		[FieldOffset(2072)]
		public FVectorDouble __Result;
	}

	// Token: 0x02008558 RID: 34136
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2016)]
	protected ref struct __AttachToBone_FunctionParams
	{
		// Token: 0x0402AF5F RID: 175967
		[FieldOffset(0)]
		public IntPtr meshComp;

		// Token: 0x0402AF60 RID: 175968
		[FieldOffset(8)]
		public IntPtr bulletActor;

		// Token: 0x0402AF61 RID: 175969
		[FieldOffset(16)]
		public byte dataMain;

		// Token: 0x0402AF62 RID: 175970
		[FieldOffset(2008)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02008559 RID: 34137
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2112)]
	protected ref struct __CalcBulletInitRotator_FunctionParams
	{
		// Token: 0x0402AF63 RID: 175971
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402AF64 RID: 175972
		[FieldOffset(1992)]
		public IntPtr bulletActor;

		// Token: 0x0402AF65 RID: 175973
		[FieldOffset(2000)]
		public IntPtr attacker;

		// Token: 0x0402AF66 RID: 175974
		[FieldOffset(2016)]
		public FTransformDouble target;

		// Token: 0x0402AF67 RID: 175975
		[FieldOffset(2080)]
		public IntPtr parentBulletActor;

		// Token: 0x0402AF68 RID: 175976
		[FieldOffset(2088)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF69 RID: 175977
		[FieldOffset(2096)]
		public FRotator __Result;
	}

	// Token: 0x0200855A RID: 34138
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2064)]
	protected ref struct __CalcBulletRotator_FunctionParams
	{
		// Token: 0x0402AF6A RID: 175978
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402AF6B RID: 175979
		[FieldOffset(1992)]
		public IntPtr bulletActor;

		// Token: 0x0402AF6C RID: 175980
		[FieldOffset(2000)]
		public IntPtr attacker;

		// Token: 0x0402AF6D RID: 175981
		[FieldOffset(2008)]
		public FVectorDouble target;

		// Token: 0x0402AF6E RID: 175982
		[FieldOffset(2032)]
		public float delta;

		// Token: 0x0402AF6F RID: 175983
		[FieldOffset(2040)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF70 RID: 175984
		[FieldOffset(2048)]
		public FRotator __Result;
	}

	// Token: 0x0200855B RID: 34139
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2040)]
	protected ref struct __CalcBulletLocation_FunctionParams
	{
		// Token: 0x0402AF71 RID: 175985
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402AF72 RID: 175986
		[FieldOffset(1992)]
		public IntPtr bulletActor;

		// Token: 0x0402AF73 RID: 175987
		[FieldOffset(2000)]
		public float delta;

		// Token: 0x0402AF74 RID: 175988
		[FieldOffset(2008)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF75 RID: 175989
		[FieldOffset(2016)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200855C RID: 34140
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCampRelationship_FunctionParams
	{
		// Token: 0x0402AF76 RID: 175990
		[FieldOffset(0)]
		public int camp1;

		// Token: 0x0402AF77 RID: 175991
		[FieldOffset(4)]
		public int camp2;

		// Token: 0x0402AF78 RID: 175992
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF79 RID: 175993
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x0200855D RID: 34141
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCamp_FunctionParams
	{
		// Token: 0x0402AF7A RID: 175994
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402AF7B RID: 175995
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402AF7C RID: 175996
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x0200855E RID: 34142
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __NotifyProcessKuroBulletOperationList_FunctionParams
	{
		// Token: 0x0402AF7D RID: 175997
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200855F RID: 34143
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __NotifyExistedImmediatelyOperation_FunctionParams
	{
		// Token: 0x0402AF7E RID: 175998
		[FieldOffset(0)]
		public byte operation;

		// Token: 0x0402AF7F RID: 175999
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}
}
