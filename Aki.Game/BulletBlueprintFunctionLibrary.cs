using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Core.Common;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002DA3 RID: 11683
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Bullet/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Bullet/BulletBlueprintFunctionLibrary.BulletBlueprintFunctionLibrary_C")]
public class BulletBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06018885 RID: 100485 RVA: 0x00644AB8 File Offset: 0x00642CB8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static float CreateBulletForDebug(TsBaseCharacter owner, string bulletRowName)
	{
		return (float)BulletController.Instance.CreateBulletForDebug(owner, bulletRowName);
	}

	// Token: 0x06018886 RID: 100486 RVA: 0x00644AC8 File Offset: 0x00642CC8
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

	// Token: 0x06018887 RID: 100487 RVA: 0x00644B04 File Offset: 0x00642D04
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

	// Token: 0x06018888 RID: 100488 RVA: 0x00644BEC File Offset: 0x00642DEC
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

	// Token: 0x06018889 RID: 100489 RVA: 0x00644C23 File Offset: 0x00642E23
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool DestroyBullet(int id, bool isSummonChildBullet, bool destroyEffectImmediately = false)
	{
		BulletController.Instance.DestroyBullet(id, isSummonChildBullet, EBulletDestroyReason.Normal, destroyEffectImmediately);
		return true;
	}

	// Token: 0x0601888A RID: 100490 RVA: 0x00644C34 File Offset: 0x00642E34
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DestroyAllBullet(bool summonChild = false)
	{
		BulletController.Instance.DestroyAllBullet(summonChild);
	}

	// Token: 0x0601888B RID: 100491 RVA: 0x00644C41 File Offset: 0x00642E41
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DestroySpecifiedBullet(int ownerId, FName bulletName, bool summonChild = false, int includeTeammate = 0, float interval = 0f)
	{
		BulletController.Instance.DestroySpecifiedBullet(ownerId, bulletName, summonChild, includeTeammate, interval);
	}

	// Token: 0x0601888C RID: 100492 RVA: 0x00644C53 File Offset: 0x00642E53
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetSpecifiedBulletCount(int ownerId, FName bulletName)
	{
		return BulletController.Instance.GetSpecifiedBulletCount(ownerId, bulletName);
	}

	// Token: 0x0601888D RID: 100493 RVA: 0x00644C64 File Offset: 0x00642E64
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

	// Token: 0x0601888E RID: 100494 RVA: 0x00644CCC File Offset: 0x00642ECC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DebugShowBulletCollision(bool isShow, int entityId)
	{
		BulletModel.Instance.SetBulletCollisionDraw(entityId, isShow);
	}

	// Token: 0x0601888F RID: 100495 RVA: 0x00644CDA File Offset: 0x00642EDA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DebugShowBulletTrace(bool isShow, int entityId)
	{
		BulletModel.Instance.SetBulletTraceDraw(entityId, isShow);
	}

	// Token: 0x06018890 RID: 100496 RVA: 0x00644CE8 File Offset: 0x00642EE8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsShowBulletCollision(int entityId)
	{
		return BulletModel.Instance.ShowBulletCollision(entityId);
	}

	// Token: 0x06018891 RID: 100497 RVA: 0x00644CF5 File Offset: 0x00642EF5
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsShowBulletTrace(int entityId)
	{
		BulletModel instance = BulletModel.Instance;
		return instance != null && instance.ShowBulletTrace(entityId);
	}

	// Token: 0x06018892 RID: 100498 RVA: 0x00644D08 File Offset: 0x00642F08
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FrozenBulletTimeByBulletName(TsBaseCharacter character, string bulletDataName, float time)
	{
		BulletUtil.FrozenCharacterBullet(character.GetEntityIdNoBlueprint(), bulletDataName, time);
	}

	// Token: 0x06018893 RID: 100499 RVA: 0x00644D17 File Offset: 0x00642F17
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetEntityIdByCustomKey(int attackerId, string customKey, int targetId)
	{
		BulletModel.Instance.SetEntityIdByCustomKey(attackerId, customKey, targetId);
	}

	// Token: 0x06018894 RID: 100500 RVA: 0x00644D28 File Offset: 0x00642F28
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

	// Token: 0x06018895 RID: 100501 RVA: 0x00644DBC File Offset: 0x00642FBC
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

	// Token: 0x06018896 RID: 100502 RVA: 0x00644E13 File Offset: 0x00643013
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TsBaseCharacter GetBulletAttacker(int id)
	{
		BulletInfo bulletInfo = BulletBlueprintFunctionLibrary.GetBulletInfo(id);
		return ((bulletInfo != null) ? bulletInfo.AttackerActorComp.Owner : null) as TsBaseCharacter;
	}

	// Token: 0x06018897 RID: 100503 RVA: 0x00644E31 File Offset: 0x00643031
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

	// Token: 0x06018898 RID: 100504 RVA: 0x00644E49 File Offset: 0x00643049
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

	// Token: 0x06018899 RID: 100505 RVA: 0x00644E64 File Offset: 0x00643064
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

	// Token: 0x0601889A RID: 100506 RVA: 0x00644E90 File Offset: 0x00643090
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

	// Token: 0x0601889B RID: 100507 RVA: 0x00644EC1 File Offset: 0x006430C1
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

	// Token: 0x0601889C RID: 100508 RVA: 0x00644EE0 File Offset: 0x006430E0
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

	// Token: 0x0601889D RID: 100509 RVA: 0x00644F13 File Offset: 0x00643113
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetBeginSpeed(int id, float newSpeed)
	{
		BulletController.Instance.SetBulletSpeedRatio(id, newSpeed);
	}

	// Token: 0x0601889E RID: 100510 RVA: 0x00644F21 File Offset: 0x00643121
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

	// Token: 0x0601889F RID: 100511 RVA: 0x00644F3C File Offset: 0x0064313C
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

	// Token: 0x060188A0 RID: 100512 RVA: 0x00644FD2 File Offset: 0x006431D2
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

	// Token: 0x060188A1 RID: 100513 RVA: 0x00645004 File Offset: 0x00643204
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

	// Token: 0x060188A2 RID: 100514 RVA: 0x006451CC File Offset: 0x006433CC
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

	// Token: 0x060188A3 RID: 100515 RVA: 0x00645220 File Offset: 0x00643420
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

	// Token: 0x060188A4 RID: 100516 RVA: 0x00645374 File Offset: 0x00643574
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

	// Token: 0x060188A5 RID: 100517 RVA: 0x006455E0 File Offset: 0x006437E0
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

	// Token: 0x060188A6 RID: 100518 RVA: 0x00645674 File Offset: 0x00643874
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

	// Token: 0x060188A7 RID: 100519 RVA: 0x006457A0 File Offset: 0x006439A0
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

	// Token: 0x060188A8 RID: 100520 RVA: 0x00645914 File Offset: 0x00643B14
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble CalcBulletLocation(SReBulletDataMain dataMain, AActor bulletActor, float delta)
	{
		FVectorDouble fvectorDouble = bulletActor.D_K2_GetActorLocation();
		FVectorDouble fvectorDouble2 = bulletActor.D_GetActorForwardVector();
		FVectorDouble fvectorDouble3 = fvectorDouble2 * (double)(dataMain.移动设置.移动速度 * delta);
		return fvectorDouble + fvectorDouble3;
	}

	// Token: 0x060188A9 RID: 100521 RVA: 0x0064594E File Offset: 0x00643B4E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetCampRelationship(int camp1, int camp2)
	{
		return (int)CampUtils.GetCampRelationship((ECamp)camp1, (ECamp)camp2);
	}

	// Token: 0x060188AA RID: 100522 RVA: 0x0064595C File Offset: 0x00643B5C
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

	// Token: 0x060188AB RID: 100523 RVA: 0x0064599E File Offset: 0x00643B9E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void NotifyProcessKuroBulletOperationList()
	{
		BulletController.Instance.ProcessKuroBulletOperationList();
	}

	// Token: 0x060188AC RID: 100524 RVA: 0x006459AA File Offset: 0x00643BAA
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void NotifyExistedImmediatelyOperation(FBulletHitWorldEntityOperation operation)
	{
		BulletController.Instance.ProcessKuroBulletOperation(operation);
	}

	// Token: 0x060188AD RID: 100525 RVA: 0x006459B7 File Offset: 0x00643BB7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (BulletBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Bullet/BulletBlueprintFunctionLibrary.BulletBlueprintFunctionLibrary_C");
		}
		return BulletBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060188AE RID: 100526 RVA: 0x006459DC File Offset: 0x00643BDC
	public BulletBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060188AF RID: 100527 RVA: 0x00645A04 File Offset: 0x00643C04
	[NullableContext(1)]
	public BulletBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BulletBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060188B0 RID: 100528 RVA: 0x00645A37 File Offset: 0x00643C37
	protected BulletBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060188B1 RID: 100529 RVA: 0x00645A40 File Offset: 0x00643C40
	protected unsafe static void __CPPCALL_CreateBulletForDebug_Implementation(BulletBlueprintFunctionLibrary.__CreateBulletForDebug_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		string bulletRowName = FString.ToString((void*)(&__Params->bulletRowName));
		__Params->__Result = BulletBlueprintFunctionLibrary.CreateBulletForDebug(orCreateUObjectByNativePointer, bulletRowName);
	}

	// Token: 0x060188B2 RID: 100530 RVA: 0x00645A74 File Offset: 0x00643C74
	protected unsafe static void __CPPCALL_CreateBulletFromGA_Implementation(BulletBlueprintFunctionLibrary.__CreateBulletFromGA_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->owner);
		string bulletRowName = FString.ToString((void*)(&__Params->bulletRowName));
		string skillId = FString.ToString((void*)(&__Params->skillId));
		__Params->__Result = BulletBlueprintFunctionLibrary.CreateBulletFromGA(orCreateUObjectByNativePointer, bulletRowName, __Params->initialTransform, skillId, __Params->needSync, __Params->targetLocation);
	}

	// Token: 0x060188B3 RID: 100531 RVA: 0x00645AC7 File Offset: 0x00643CC7
	protected unsafe static void __CPPCALL_GetBulletActorById_Implementation(BulletBlueprintFunctionLibrary.__GetBulletActorById_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor bulletActorById = BulletBlueprintFunctionLibrary.GetBulletActorById(__Params->id);
		ptr = ((bulletActorById != null) ? bulletActorById.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060188B4 RID: 100532 RVA: 0x00645AE9 File Offset: 0x00643CE9
	protected unsafe static void __CPPCALL_DestroyBullet_Implementation(BulletBlueprintFunctionLibrary.__DestroyBullet_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.DestroyBullet(__Params->id, __Params->isSummonChildBullet, __Params->destroyEffectImmediately);
	}

	// Token: 0x060188B5 RID: 100533 RVA: 0x00645B08 File Offset: 0x00643D08
	protected unsafe static void __CPPCALL_DestroyAllBullet_Implementation(BulletBlueprintFunctionLibrary.__DestroyAllBullet_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DestroyAllBullet(__Params->summonChild);
	}

	// Token: 0x060188B6 RID: 100534 RVA: 0x00645B15 File Offset: 0x00643D15
	protected unsafe static void __CPPCALL_DestroySpecifiedBullet_Implementation(BulletBlueprintFunctionLibrary.__DestroySpecifiedBullet_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DestroySpecifiedBullet(__Params->ownerId, __Params->bulletName, __Params->summonChild, __Params->includeTeammate, __Params->interval);
	}

	// Token: 0x060188B7 RID: 100535 RVA: 0x00645B3A File Offset: 0x00643D3A
	protected unsafe static void __CPPCALL_GetSpecifiedBulletCount_Implementation(BulletBlueprintFunctionLibrary.__GetSpecifiedBulletCount_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetSpecifiedBulletCount(__Params->ownerId, __Params->bulletName);
	}

	// Token: 0x060188B8 RID: 100536 RVA: 0x00645B54 File Offset: 0x00643D54
	protected unsafe static void __CPPCALL_GetCharacterLaunchedBulletIds_Implementation(BulletBlueprintFunctionLibrary.__GetCharacterLaunchedBulletIds_FunctionParams* __Params)
	{
		TArray<int> characterLaunchedBulletIds = BulletBlueprintFunctionLibrary.GetCharacterLaunchedBulletIds(__Params->characterId);
		if (characterLaunchedBulletIds == null)
		{
			return;
		}
		characterLaunchedBulletIds.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x060188B9 RID: 100537 RVA: 0x00645B86 File Offset: 0x00643D86
	protected unsafe static void __CPPCALL_DebugShowBulletCollision_Implementation(BulletBlueprintFunctionLibrary.__DebugShowBulletCollision_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DebugShowBulletCollision(__Params->isShow, __Params->entityId);
	}

	// Token: 0x060188BA RID: 100538 RVA: 0x00645B99 File Offset: 0x00643D99
	protected unsafe static void __CPPCALL_DebugShowBulletTrace_Implementation(BulletBlueprintFunctionLibrary.__DebugShowBulletTrace_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.DebugShowBulletTrace(__Params->isShow, __Params->entityId);
	}

	// Token: 0x060188BB RID: 100539 RVA: 0x00645BAC File Offset: 0x00643DAC
	protected unsafe static void __CPPCALL_GetIsShowBulletCollision_Implementation(BulletBlueprintFunctionLibrary.__GetIsShowBulletCollision_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetIsShowBulletCollision(__Params->entityId);
	}

	// Token: 0x060188BC RID: 100540 RVA: 0x00645BBF File Offset: 0x00643DBF
	protected unsafe static void __CPPCALL_GetIsShowBulletTrace_Implementation(BulletBlueprintFunctionLibrary.__GetIsShowBulletTrace_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetIsShowBulletTrace(__Params->entityId);
	}

	// Token: 0x060188BD RID: 100541 RVA: 0x00645BD4 File Offset: 0x00643DD4
	protected unsafe static void __CPPCALL_FrozenBulletTimeByBulletName_Implementation(BulletBlueprintFunctionLibrary.__FrozenBulletTimeByBulletName_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		string bulletDataName = FString.ToString((void*)(&__Params->bulletDataName));
		BulletBlueprintFunctionLibrary.FrozenBulletTimeByBulletName(orCreateUObjectByNativePointer, bulletDataName, __Params->time);
	}

	// Token: 0x060188BE RID: 100542 RVA: 0x00645C08 File Offset: 0x00643E08
	protected unsafe static void __CPPCALL_SetEntityIdByCustomKey_Implementation(BulletBlueprintFunctionLibrary.__SetEntityIdByCustomKey_FunctionParams* __Params)
	{
		string customKey = FString.ToString((void*)(&__Params->customKey));
		BulletBlueprintFunctionLibrary.SetEntityIdByCustomKey(__Params->attackerId, customKey, __Params->targetId);
	}

	// Token: 0x060188BF RID: 100543 RVA: 0x00645C34 File Offset: 0x00643E34
	protected unsafe static void __CPPCALL_GetAllBullet_Implementation(BulletBlueprintFunctionLibrary.__GetAllBullet_FunctionParams* __Params)
	{
		TArray<int> allBullet = BulletBlueprintFunctionLibrary.GetAllBullet();
		if (allBullet == null)
		{
			return;
		}
		allBullet.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x060188C0 RID: 100544 RVA: 0x00645C60 File Offset: 0x00643E60
	protected unsafe static void __CPPCALL_GetBulletTransform_Implementation(BulletBlueprintFunctionLibrary.__GetBulletTransform_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetBulletTransform(__Params->id);
	}

	// Token: 0x060188C1 RID: 100545 RVA: 0x00645C73 File Offset: 0x00643E73
	protected unsafe static void __CPPCALL_GetBulletAttacker_Implementation(BulletBlueprintFunctionLibrary.__GetBulletAttacker_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		TsBaseCharacter bulletAttacker = BulletBlueprintFunctionLibrary.GetBulletAttacker(__Params->id);
		ptr = ((bulletAttacker != null) ? bulletAttacker.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060188C2 RID: 100546 RVA: 0x00645C95 File Offset: 0x00643E95
	protected unsafe static void __CPPCALL_GetBulletCollision_Implementation(BulletBlueprintFunctionLibrary.__GetBulletCollision_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UPrimitiveComponent bulletCollision = BulletBlueprintFunctionLibrary.GetBulletCollision(__Params->id);
		ptr = ((bulletCollision != null) ? bulletCollision.NativePtr : ((IntPtr)0));
	}

	// Token: 0x060188C3 RID: 100547 RVA: 0x00645CB7 File Offset: 0x00643EB7
	protected unsafe static void __CPPCALL_GetBulletName_Implementation(BulletBlueprintFunctionLibrary.__GetBulletName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), BulletBlueprintFunctionLibrary.GetBulletName(__Params->id));
	}

	// Token: 0x060188C4 RID: 100548 RVA: 0x00645CD0 File Offset: 0x00643ED0
	protected unsafe static void __CPPCALL_SetBulletStopHitTrue_Implementation(BulletBlueprintFunctionLibrary.__SetBulletStopHitTrue_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBulletStopHitTrue(__Params->id);
	}

	// Token: 0x060188C5 RID: 100549 RVA: 0x00645CE0 File Offset: 0x00643EE0
	protected unsafe static void __CPPCALL_SetBulletTarget_Implementation(BulletBlueprintFunctionLibrary.__SetBulletTarget_FunctionParams* __Params)
	{
		TsBaseCharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<TsBaseCharacter>(__Params->character);
		BulletBlueprintFunctionLibrary.SetBulletTarget(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x060188C6 RID: 100550 RVA: 0x00645D05 File Offset: 0x00643F05
	protected unsafe static void __CPPCALL_SetBulletSummon_Implementation(BulletBlueprintFunctionLibrary.__SetBulletSummon_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBulletSummon(__Params->id);
	}

	// Token: 0x060188C7 RID: 100551 RVA: 0x00645D12 File Offset: 0x00643F12
	protected unsafe static void __CPPCALL_SetBulletTransform_Implementation(BulletBlueprintFunctionLibrary.__SetBulletTransform_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBulletTransform(__Params->id, __Params->newTransform);
	}

	// Token: 0x060188C8 RID: 100552 RVA: 0x00645D25 File Offset: 0x00643F25
	protected unsafe static void __CPPCALL_SetBeginSpeed_Implementation(BulletBlueprintFunctionLibrary.__SetBeginSpeed_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.SetBeginSpeed(__Params->id, __Params->newSpeed);
	}

	// Token: 0x060188C9 RID: 100553 RVA: 0x00645D38 File Offset: 0x00643F38
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

	// Token: 0x060188CA RID: 100554 RVA: 0x00645DC8 File Offset: 0x00643FC8
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

	// Token: 0x060188CB RID: 100555 RVA: 0x00645E58 File Offset: 0x00644058
	protected unsafe static void __CPPCALL_CalcBulletInitLocation_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletInitLocation_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->attacker);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletInitLocation(dataMain, orCreateUObjectByNativePointer, __Params->target);
	}

	// Token: 0x060188CC RID: 100556 RVA: 0x00645E94 File Offset: 0x00644094
	protected unsafe static void __CPPCALL_AttachToBone_Implementation(BulletBlueprintFunctionLibrary.__AttachToBone_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->meshComp);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		BulletBlueprintFunctionLibrary.AttachToBone(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, dataMain);
	}

	// Token: 0x060188CD RID: 100557 RVA: 0x00645ED0 File Offset: 0x006440D0
	protected unsafe static void __CPPCALL_CalcBulletInitRotator_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletInitRotator_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->attacker);
		AActor orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->parentBulletActor);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletInitRotator(dataMain, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->target, orCreateUObjectByNativePointer3);
	}

	// Token: 0x060188CE RID: 100558 RVA: 0x00645F28 File Offset: 0x00644128
	protected unsafe static void __CPPCALL_CalcBulletRotator_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletRotator_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->attacker);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletRotator(dataMain, orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->target, __Params->delta);
	}

	// Token: 0x060188CF RID: 100559 RVA: 0x00645F78 File Offset: 0x00644178
	protected unsafe static void __CPPCALL_CalcBulletLocation_Implementation(BulletBlueprintFunctionLibrary.__CalcBulletLocation_FunctionParams* __Params)
	{
		SReBulletDataMain dataMain = new SReBulletDataMain(&__Params->dataMain, true, true);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->bulletActor);
		__Params->__Result = BulletBlueprintFunctionLibrary.CalcBulletLocation(dataMain, orCreateUObjectByNativePointer, __Params->delta);
	}

	// Token: 0x060188D0 RID: 100560 RVA: 0x00645FB3 File Offset: 0x006441B3
	protected unsafe static void __CPPCALL_GetCampRelationship_Implementation(BulletBlueprintFunctionLibrary.__GetCampRelationship_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetCampRelationship(__Params->camp1, __Params->camp2);
	}

	// Token: 0x060188D1 RID: 100561 RVA: 0x00645FCC File Offset: 0x006441CC
	protected unsafe static void __CPPCALL_GetCamp_Implementation(BulletBlueprintFunctionLibrary.__GetCamp_FunctionParams* __Params)
	{
		__Params->__Result = BulletBlueprintFunctionLibrary.GetCamp(__Params->entityId);
	}

	// Token: 0x060188D2 RID: 100562 RVA: 0x00645FDF File Offset: 0x006441DF
	protected unsafe static void __CPPCALL_NotifyProcessKuroBulletOperationList_Implementation(BulletBlueprintFunctionLibrary.__NotifyProcessKuroBulletOperationList_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.NotifyProcessKuroBulletOperationList();
	}

	// Token: 0x060188D3 RID: 100563 RVA: 0x00645FE6 File Offset: 0x006441E6
	protected unsafe static void __CPPCALL_NotifyExistedImmediatelyOperation_Implementation(BulletBlueprintFunctionLibrary.__NotifyExistedImmediatelyOperation_FunctionParams* __Params)
	{
		BulletBlueprintFunctionLibrary.NotifyExistedImmediatelyOperation(new FBulletHitWorldEntityOperation(&__Params->operation, true, true));
	}

	// Token: 0x0400B5F0 RID: 46576
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Bullet/BulletBlueprintFunctionLibrary.BulletBlueprintFunctionLibrary_C";

	// Token: 0x0400B5F1 RID: 46577
	private static IntPtr _ClassPtr;

	// Token: 0x0400B5F2 RID: 46578
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02009316 RID: 37654
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CreateBulletForDebug_FunctionParams
	{
		// Token: 0x0402F86C RID: 194668
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402F86D RID: 194669
		[FieldOffset(8)]
		public FString bulletRowName;

		// Token: 0x0402F86E RID: 194670
		[FieldOffset(24)]
		public IntPtr __WorldContext;

		// Token: 0x0402F86F RID: 194671
		[FieldOffset(32)]
		public float __Result;
	}

	// Token: 0x02009317 RID: 37655
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 160)]
	protected ref struct __CreateBulletFromGA_FunctionParams
	{
		// Token: 0x0402F870 RID: 194672
		[FieldOffset(0)]
		public IntPtr owner;

		// Token: 0x0402F871 RID: 194673
		[FieldOffset(8)]
		public FString bulletRowName;

		// Token: 0x0402F872 RID: 194674
		[FieldOffset(32)]
		public FTransformDouble initialTransform;

		// Token: 0x0402F873 RID: 194675
		[FieldOffset(96)]
		public FString skillId;

		// Token: 0x0402F874 RID: 194676
		[FieldOffset(112)]
		public bool needSync;

		// Token: 0x0402F875 RID: 194677
		[FieldOffset(120)]
		public FVectorDouble targetLocation;

		// Token: 0x0402F876 RID: 194678
		[FieldOffset(144)]
		public IntPtr __WorldContext;

		// Token: 0x0402F877 RID: 194679
		[FieldOffset(152)]
		public int __Result;
	}

	// Token: 0x02009318 RID: 37656
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBulletActorById_FunctionParams
	{
		// Token: 0x0402F878 RID: 194680
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F879 RID: 194681
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F87A RID: 194682
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009319 RID: 37657
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DestroyBullet_FunctionParams
	{
		// Token: 0x0402F87B RID: 194683
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F87C RID: 194684
		[FieldOffset(4)]
		public bool isSummonChildBullet;

		// Token: 0x0402F87D RID: 194685
		[FieldOffset(5)]
		public bool destroyEffectImmediately;

		// Token: 0x0402F87E RID: 194686
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F87F RID: 194687
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x0200931A RID: 37658
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DestroyAllBullet_FunctionParams
	{
		// Token: 0x0402F880 RID: 194688
		[FieldOffset(0)]
		public bool summonChild;

		// Token: 0x0402F881 RID: 194689
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200931B RID: 37659
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __DestroySpecifiedBullet_FunctionParams
	{
		// Token: 0x0402F882 RID: 194690
		[FieldOffset(0)]
		public int ownerId;

		// Token: 0x0402F883 RID: 194691
		[FieldOffset(4)]
		public FName bulletName;

		// Token: 0x0402F884 RID: 194692
		[FieldOffset(16)]
		public bool summonChild;

		// Token: 0x0402F885 RID: 194693
		[FieldOffset(20)]
		public int includeTeammate;

		// Token: 0x0402F886 RID: 194694
		[FieldOffset(24)]
		public float interval;

		// Token: 0x0402F887 RID: 194695
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200931C RID: 37660
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetSpecifiedBulletCount_FunctionParams
	{
		// Token: 0x0402F888 RID: 194696
		[FieldOffset(0)]
		public int ownerId;

		// Token: 0x0402F889 RID: 194697
		[FieldOffset(4)]
		public FName bulletName;

		// Token: 0x0402F88A RID: 194698
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x0402F88B RID: 194699
		[FieldOffset(24)]
		public int __Result;
	}

	// Token: 0x0200931D RID: 37661
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCharacterLaunchedBulletIds_FunctionParams
	{
		// Token: 0x0402F88C RID: 194700
		[FieldOffset(0)]
		public int characterId;

		// Token: 0x0402F88D RID: 194701
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F88E RID: 194702
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x0200931E RID: 37662
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DebugShowBulletCollision_FunctionParams
	{
		// Token: 0x0402F88F RID: 194703
		[FieldOffset(0)]
		public bool isShow;

		// Token: 0x0402F890 RID: 194704
		[FieldOffset(4)]
		public int entityId;

		// Token: 0x0402F891 RID: 194705
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200931F RID: 37663
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DebugShowBulletTrace_FunctionParams
	{
		// Token: 0x0402F892 RID: 194706
		[FieldOffset(0)]
		public bool isShow;

		// Token: 0x0402F893 RID: 194707
		[FieldOffset(4)]
		public int entityId;

		// Token: 0x0402F894 RID: 194708
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009320 RID: 37664
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsShowBulletCollision_FunctionParams
	{
		// Token: 0x0402F895 RID: 194709
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402F896 RID: 194710
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F897 RID: 194711
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009321 RID: 37665
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetIsShowBulletTrace_FunctionParams
	{
		// Token: 0x0402F898 RID: 194712
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402F899 RID: 194713
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F89A RID: 194714
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02009322 RID: 37666
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __FrozenBulletTimeByBulletName_FunctionParams
	{
		// Token: 0x0402F89B RID: 194715
		[FieldOffset(0)]
		public IntPtr character;

		// Token: 0x0402F89C RID: 194716
		[FieldOffset(8)]
		public FString bulletDataName;

		// Token: 0x0402F89D RID: 194717
		[FieldOffset(24)]
		public float time;

		// Token: 0x0402F89E RID: 194718
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009323 RID: 37667
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetEntityIdByCustomKey_FunctionParams
	{
		// Token: 0x0402F89F RID: 194719
		[FieldOffset(0)]
		public int attackerId;

		// Token: 0x0402F8A0 RID: 194720
		[FieldOffset(8)]
		public FString customKey;

		// Token: 0x0402F8A1 RID: 194721
		[FieldOffset(24)]
		public int targetId;

		// Token: 0x0402F8A2 RID: 194722
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009324 RID: 37668
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetAllBullet_FunctionParams
	{
		// Token: 0x0402F8A3 RID: 194723
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8A4 RID: 194724
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02009325 RID: 37669
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __GetBulletTransform_FunctionParams
	{
		// Token: 0x0402F8A5 RID: 194725
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8A6 RID: 194726
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8A7 RID: 194727
		[FieldOffset(16)]
		public FTransformDouble __Result;
	}

	// Token: 0x02009326 RID: 37670
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBulletAttacker_FunctionParams
	{
		// Token: 0x0402F8A8 RID: 194728
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8A9 RID: 194729
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8AA RID: 194730
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009327 RID: 37671
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetBulletCollision_FunctionParams
	{
		// Token: 0x0402F8AB RID: 194731
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8AC RID: 194732
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8AD RID: 194733
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02009328 RID: 37672
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetBulletName_FunctionParams
	{
		// Token: 0x0402F8AE RID: 194734
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8AF RID: 194735
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8B0 RID: 194736
		[FieldOffset(16)]
		public FString __Result;
	}

	// Token: 0x02009329 RID: 37673
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBulletStopHitTrue_FunctionParams
	{
		// Token: 0x0402F8B1 RID: 194737
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8B2 RID: 194738
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200932A RID: 37674
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetBulletTarget_FunctionParams
	{
		// Token: 0x0402F8B3 RID: 194739
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8B4 RID: 194740
		[FieldOffset(8)]
		public IntPtr character;

		// Token: 0x0402F8B5 RID: 194741
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200932B RID: 37675
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBulletSummon_FunctionParams
	{
		// Token: 0x0402F8B6 RID: 194742
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8B7 RID: 194743
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200932C RID: 37676
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __SetBulletTransform_FunctionParams
	{
		// Token: 0x0402F8B8 RID: 194744
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8B9 RID: 194745
		[FieldOffset(16)]
		public FTransformDouble newTransform;

		// Token: 0x0402F8BA RID: 194746
		[FieldOffset(80)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200932D RID: 37677
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetBeginSpeed_FunctionParams
	{
		// Token: 0x0402F8BB RID: 194747
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402F8BC RID: 194748
		[FieldOffset(4)]
		public float newSpeed;

		// Token: 0x0402F8BD RID: 194749
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200932E RID: 37678
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __CalcPipe_FunctionParams
	{
		// Token: 0x0402F8BE RID: 194750
		[FieldOffset(0)]
		public FVector centerPoint;

		// Token: 0x0402F8BF RID: 194751
		[FieldOffset(12)]
		public FVector forward;

		// Token: 0x0402F8C0 RID: 194752
		[FieldOffset(24)]
		public FVector up;

		// Token: 0x0402F8C1 RID: 194753
		[FieldOffset(36)]
		public float outsideRadius;

		// Token: 0x0402F8C2 RID: 194754
		[FieldOffset(40)]
		public float insideRadius;

		// Token: 0x0402F8C3 RID: 194755
		[FieldOffset(44)]
		public float height;

		// Token: 0x0402F8C4 RID: 194756
		[FieldOffset(48)]
		public int sectionNum;

		// Token: 0x0402F8C5 RID: 194757
		[FieldOffset(56)]
		public byte outVertices;

		// Token: 0x0402F8C6 RID: 194758
		[FieldOffset(72)]
		public byte outTriangles;

		// Token: 0x0402F8C7 RID: 194759
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200932F RID: 37679
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __CalcSector_FunctionParams
	{
		// Token: 0x0402F8C8 RID: 194760
		[FieldOffset(0)]
		public FVector centerPoint;

		// Token: 0x0402F8C9 RID: 194761
		[FieldOffset(12)]
		public FVector forward;

		// Token: 0x0402F8CA RID: 194762
		[FieldOffset(24)]
		public FVector up;

		// Token: 0x0402F8CB RID: 194763
		[FieldOffset(36)]
		public float inAngle;

		// Token: 0x0402F8CC RID: 194764
		[FieldOffset(40)]
		public float radius;

		// Token: 0x0402F8CD RID: 194765
		[FieldOffset(44)]
		public float height;

		// Token: 0x0402F8CE RID: 194766
		[FieldOffset(48)]
		public int sectionNum;

		// Token: 0x0402F8CF RID: 194767
		[FieldOffset(56)]
		public byte verticesArray;

		// Token: 0x0402F8D0 RID: 194768
		[FieldOffset(72)]
		public byte trianglesArray;

		// Token: 0x0402F8D1 RID: 194769
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009330 RID: 37680
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2096)]
	protected ref struct __CalcBulletInitLocation_FunctionParams
	{
		// Token: 0x0402F8D2 RID: 194770
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402F8D3 RID: 194771
		[FieldOffset(1992)]
		public IntPtr attacker;

		// Token: 0x0402F8D4 RID: 194772
		[FieldOffset(2000)]
		public FTransformDouble target;

		// Token: 0x0402F8D5 RID: 194773
		[FieldOffset(2064)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8D6 RID: 194774
		[FieldOffset(2072)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009331 RID: 37681
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2016)]
	protected ref struct __AttachToBone_FunctionParams
	{
		// Token: 0x0402F8D7 RID: 194775
		[FieldOffset(0)]
		public IntPtr meshComp;

		// Token: 0x0402F8D8 RID: 194776
		[FieldOffset(8)]
		public IntPtr bulletActor;

		// Token: 0x0402F8D9 RID: 194777
		[FieldOffset(16)]
		public byte dataMain;

		// Token: 0x0402F8DA RID: 194778
		[FieldOffset(2008)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009332 RID: 37682
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2112)]
	protected ref struct __CalcBulletInitRotator_FunctionParams
	{
		// Token: 0x0402F8DB RID: 194779
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402F8DC RID: 194780
		[FieldOffset(1992)]
		public IntPtr bulletActor;

		// Token: 0x0402F8DD RID: 194781
		[FieldOffset(2000)]
		public IntPtr attacker;

		// Token: 0x0402F8DE RID: 194782
		[FieldOffset(2016)]
		public FTransformDouble target;

		// Token: 0x0402F8DF RID: 194783
		[FieldOffset(2080)]
		public IntPtr parentBulletActor;

		// Token: 0x0402F8E0 RID: 194784
		[FieldOffset(2088)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8E1 RID: 194785
		[FieldOffset(2096)]
		public FRotator __Result;
	}

	// Token: 0x02009333 RID: 37683
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2064)]
	protected ref struct __CalcBulletRotator_FunctionParams
	{
		// Token: 0x0402F8E2 RID: 194786
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402F8E3 RID: 194787
		[FieldOffset(1992)]
		public IntPtr bulletActor;

		// Token: 0x0402F8E4 RID: 194788
		[FieldOffset(2000)]
		public IntPtr attacker;

		// Token: 0x0402F8E5 RID: 194789
		[FieldOffset(2008)]
		public FVectorDouble target;

		// Token: 0x0402F8E6 RID: 194790
		[FieldOffset(2032)]
		public float delta;

		// Token: 0x0402F8E7 RID: 194791
		[FieldOffset(2040)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8E8 RID: 194792
		[FieldOffset(2048)]
		public FRotator __Result;
	}

	// Token: 0x02009334 RID: 37684
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 2040)]
	protected ref struct __CalcBulletLocation_FunctionParams
	{
		// Token: 0x0402F8E9 RID: 194793
		[FieldOffset(0)]
		public byte dataMain;

		// Token: 0x0402F8EA RID: 194794
		[FieldOffset(1992)]
		public IntPtr bulletActor;

		// Token: 0x0402F8EB RID: 194795
		[FieldOffset(2000)]
		public float delta;

		// Token: 0x0402F8EC RID: 194796
		[FieldOffset(2008)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8ED RID: 194797
		[FieldOffset(2016)]
		public FVectorDouble __Result;
	}

	// Token: 0x02009335 RID: 37685
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCampRelationship_FunctionParams
	{
		// Token: 0x0402F8EE RID: 194798
		[FieldOffset(0)]
		public int camp1;

		// Token: 0x0402F8EF RID: 194799
		[FieldOffset(4)]
		public int camp2;

		// Token: 0x0402F8F0 RID: 194800
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8F1 RID: 194801
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02009336 RID: 37686
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCamp_FunctionParams
	{
		// Token: 0x0402F8F2 RID: 194802
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402F8F3 RID: 194803
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402F8F4 RID: 194804
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02009337 RID: 37687
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __NotifyProcessKuroBulletOperationList_FunctionParams
	{
		// Token: 0x0402F8F5 RID: 194805
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02009338 RID: 37688
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 96)]
	protected ref struct __NotifyExistedImmediatelyOperation_FunctionParams
	{
		// Token: 0x0402F8F6 RID: 194806
		[FieldOffset(0)]
		public byte operation;

		// Token: 0x0402F8F7 RID: 194807
		[FieldOffset(88)]
		public IntPtr __WorldContext;
	}
}
