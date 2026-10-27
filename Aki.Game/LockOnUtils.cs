using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020030E0 RID: 12512
[NullableContext(2)]
[Nullable(0)]
public class LockOnUtils : IStaticVariableResetter
{
	// Token: 0x0601ACB8 RID: 109752 RVA: 0x0073AA98 File Offset: 0x00738C98
	static LockOnUtils()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LockOnUtils.CreateStaticDefaultValue), new Action(LockOnUtils.ResetStaticDefaultValue));
	}

	// Token: 0x0601ACB9 RID: 109753 RVA: 0x0073AAB7 File Offset: 0x00738CB7
	public static void CreateStaticDefaultValue()
	{
		LockOnUtils._lockOnIgnoreBlockTag = GameplayTagDefine.EGameplayTagId["角色.Common.索敌无视遮挡"];
	}

	// Token: 0x0601ACBA RID: 109754 RVA: 0x0073AACD File Offset: 0x00738CCD
	public static void ResetStaticDefaultValue()
	{
		LockOnUtils._lockOnIgnoreBlockTag = 0;
		LockOnUtils._lineTrace = null;
	}

	// Token: 0x0601ACBB RID: 109755 RVA: 0x0073AADB File Offset: 0x00738CDB
	public static bool CheckFriendCamp(int camp)
	{
		return camp == 0 || camp == 2 || camp == 4;
	}

	// Token: 0x0601ACBC RID: 109756 RVA: 0x0073AAEC File Offset: 0x00738CEC
	[NullableContext(1)]
	public static UTraceLineElement GetLockOnLineTrace([Nullable(2)] UObject worldContextObject, bool showLine = false)
	{
		if (LockOnUtils._lineTrace == null)
		{
			LockOnUtils._lineTrace = UE.NewObject<UTraceLineElement>(null, null, EObjectFlags.RF_NoFlags);
			LockOnUtils._lineTrace.bIsSingle = true;
			LockOnUtils._lineTrace.bIgnoreSelf = true;
			LockOnUtils._lineTrace.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		}
		LockOnUtils._lineTrace.WorldContextObject = worldContextObject;
		if (showLine)
		{
			LockOnUtils._lineTrace.DrawTime = 5f;
			LockOnUtils._lineTrace.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
			TraceElementCommon.Instance.SetTraceColor(LockOnUtils._lineTrace, ColorUtils.LinearGreen);
			TraceElementCommon.Instance.SetTraceHitColor(LockOnUtils._lineTrace, ColorUtils.LinearRed);
		}
		else
		{
			LockOnUtils._lineTrace.SetDrawDebugTrace(EDrawDebugTrace.None);
		}
		return LockOnUtils._lineTrace;
	}

	// Token: 0x0601ACBD RID: 109757 RVA: 0x0073AB94 File Offset: 0x00738D94
	public static bool TraceDetectBlock(UObject worldContextObject, FVector from, FVector to, AActor targetActor, bool showLine = false, BaseTagComponent tagComp = null)
	{
		if (tagComp != null && tagComp.HasTag(LockOnUtils._lockOnIgnoreBlockTag))
		{
			return false;
		}
		UTraceLineElement lockOnLineTrace = LockOnUtils.GetLockOnLineTrace(worldContextObject, showLine);
		TraceElementCommon.Instance.SetStartLocation(lockOnLineTrace, from);
		TraceElementCommon.Instance.SetEndLocation(lockOnLineTrace, to);
		if (!TraceElementCommon.Instance.LineTrace(lockOnLineTrace, "LockOnUtils_TraceDetectBlock") || !lockOnLineTrace.HitResult.bBlockingHit)
		{
			return false;
		}
		AActor aactor = lockOnLineTrace.HitResult.Actors.Get(0).Get();
		AActor entityActorByChildActor = CreatureModel.Instance.GetEntityActorByChildActor(aactor);
		return aactor != targetActor && entityActorByChildActor != targetActor;
	}

	// Token: 0x0601ACBE RID: 109758 RVA: 0x0073AC38 File Offset: 0x00738E38
	public unsafe static bool IsValidLockOnTarget(EntityHandle handle, FGameplayTagContainer lockOnGameplayTags = null, FGameplayTagContainer ignoreLockOnGameplayTagContainer = null, bool forceCheckTag = false)
	{
		if (handle == null || !handle.Valid || (handle == null || !handle.IsInit))
		{
			return false;
		}
		WorldEntity entity = handle.Entity;
		if (entity == null || !entity.Active)
		{
			return false;
		}
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component != null && component.GetRemoveState())
		{
			return false;
		}
		if (component == null || !component.GetVisible())
		{
			return false;
		}
		BaseTagComponent component2 = handle.Entity.GetComponent<BaseTagComponent>();
		if (component2 == null && forceCheckTag)
		{
			return false;
		}
		if (component2 != null)
		{
			int num = (ignoreLockOnGameplayTagContainer != null) ? ignoreLockOnGameplayTagContainer.GameplayTags.Num() : 0;
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					FGameplayTag tag = ignoreLockOnGameplayTagContainer.GameplayTags.Get(i);
					if (component2.HasTag(tag.TagId()))
					{
						return false;
					}
				}
			}
			else
			{
				BaseTagComponent baseTagComponent = component2;
				<>y__InlineArray2<int> <>y__InlineArray = default(<>y__InlineArray2<int>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<int>, int>(ref <>y__InlineArray, 0) = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"];
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<int>, int>(ref <>y__InlineArray, 1) = GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身.不可锁定"];
				ReadOnlySpan<int> readOnlySpan = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<int>, int>(<>y__InlineArray, 2);
				if (baseTagComponent.HasAnyTag(readOnlySpan))
				{
					return false;
				}
			}
			int num2 = (lockOnGameplayTags != null) ? lockOnGameplayTags.GameplayTags.Num() : 0;
			if (num2 > 0)
			{
				bool result = false;
				for (int j = 0; j < num2; j++)
				{
					FGameplayTag tag2 = lockOnGameplayTags.GameplayTags.Get(j);
					if (component2.HasTag(tag2.TagId()))
					{
						result = true;
						break;
					}
				}
				return result;
			}
		}
		return true;
	}

	// Token: 0x0601ACBF RID: 109759 RVA: 0x0073ADC0 File Offset: 0x00738FC0
	public static FVectorDouble? GetLockOnTargetLocation(AActor target)
	{
		FVectorDouble? result = null;
		if (target == null || !target.IsValid())
		{
			return result;
		}
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(target, false);
		if (entityByActor != null)
		{
			WorldEntity entity = entityByActor.Entity;
			SceneItemActorComponent sceneItemActorComponent = (entity != null) ? entity.GetComponent<SceneItemActorComponent>() : null;
			if (sceneItemActorComponent != null)
			{
				SceneInteractionActor sceneInteractionActor = sceneItemActorComponent.GetInteractionMainActor() as SceneInteractionActor;
				if (sceneInteractionActor != null)
				{
					AActor actorByKey = sceneInteractionActor.GetActorByKey("Center");
					if (actorByKey != null)
					{
						result = new FVectorDouble?(actorByKey.D_K2_GetActorLocation());
					}
				}
			}
			FVectorDouble value = result.GetValueOrDefault();
			if (result == null)
			{
				value = entityByActor.Entity.GetComponent<BaseActorComponent>().ActorLocation;
				result = new FVectorDouble?(value);
			}
		}
		else
		{
			result = new FVectorDouble?(target.D_K2_GetActorLocation());
		}
		return result;
	}

	// Token: 0x0400CEF4 RID: 52980
	[Nullable(1)]
	private const string SCENE_ITEM_ACTOR_KEY = "Center";

	// Token: 0x0400CEF5 RID: 52981
	[Nullable(1)]
	private const string PROFILE_KEY = "LockOnUtils_TraceDetectBlock";

	// Token: 0x0400CEF6 RID: 52982
	private static int _lockOnIgnoreBlockTag;

	// Token: 0x0400CEF7 RID: 52983
	private static UTraceLineElement _lineTrace;
}
