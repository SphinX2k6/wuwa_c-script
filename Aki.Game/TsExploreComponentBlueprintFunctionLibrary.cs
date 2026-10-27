using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Core.World;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002E3F RID: 11839
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsExploreComponentBlueprintFunctionLibrary.TsExploreComponentBlueprintFunctionLibrary_C")]
public class TsExploreComponentBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x06019017 RID: 102423 RVA: 0x00671840 File Offset: 0x0066FA40
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static FVectorDouble CharacterGetHookLocation(int characterEntityId)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(characterEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || grapplingHookPointComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 角色获取当前交互钩锁点坐标失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CharacterEntityId", characterEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return FVectorDouble.ZeroVector;
		}
		return grapplingHookPointComponent.HookLocation.ToUeVector(false);
	}

	// Token: 0x06019018 RID: 102424 RVA: 0x0067193C File Offset: 0x0066FB3C
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static FVectorDouble MotorcycleGetHookLocation(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || grapplingHookPointComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车获取当前交互钩锁点坐标失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return FVectorDouble.ZeroVector;
		}
		return grapplingHookPointComponent.HookLocation.ToUeVector(false);
	}

	// Token: 0x06019019 RID: 102425 RVA: 0x00671A38 File Offset: 0x0066FC38
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int CharacterGetInteractingHookEntityId(int characterEntityId)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(characterEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || grapplingHookPointComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车获取当前交互钩锁点实体Id失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CharacterEntityId", characterEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		return grapplingHookPointComponent.Entity.Id;
	}

	// Token: 0x0601901A RID: 102426 RVA: 0x00671B30 File Offset: 0x0066FD30
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int MotorcycleGetInteractingHookEntityId(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || grapplingHookPointComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车获取当前交互钩锁点实体Id失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return 0;
		}
		return grapplingHookPointComponent.Entity.Id;
	}

	// Token: 0x0601901B RID: 102427 RVA: 0x00671C28 File Offset: 0x0066FE28
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static EHookInteractTypeBp CharacterGetInteractingHookType(int characterEntityId)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(characterEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || grapplingHookPointComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 角色获取当前交互物类型失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CharacterEntityId", characterEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return EHookInteractTypeBp.FixedPointHook;
		}
		return grapplingHookPointComponent.GetHookInteractTypeBp();
	}

	// Token: 0x0601901C RID: 102428 RVA: 0x00671D18 File Offset: 0x0066FF18
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static EHookInteractTypeBp MotorcycleGetInteractingHookType(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || grapplingHookPointComponent == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车获取当前交互物类型失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return EHookInteractTypeBp.FixedPointHook;
		}
		return grapplingHookPointComponent.GetHookInteractTypeBp();
	}

	// Token: 0x0601901D RID: 102429 RVA: 0x00671E08 File Offset: 0x00670008
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool MotorcyclePullCollection(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		return component != null && component.Valid && component.TryPullCollection();
	}

	// Token: 0x0601901E RID: 102430 RVA: 0x00671E34 File Offset: 0x00670034
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsMotorcyclePullingCollectionWithProgress(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		if (component != null && component.Valid)
		{
			GrapplingHookPointComponent pullingTarget = component.PullingTarget;
			return pullingTarget != null && pullingTarget.PullCollectionWithProgress;
		}
		return false;
	}

	// Token: 0x0601901F RID: 102431 RVA: 0x00671E6C File Offset: 0x0067006C
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool MotorcycleCheckPullCollectionFinished(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		if (component == null || !component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 检查摩托车拉取采集物是否完成失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "EntityConfigId";
			int? num;
			if (component == null)
			{
				num = null;
			}
			else
			{
				GrapplingHookPointComponent pullingTarget = component.PullingTarget;
				num = ((pullingTarget != null) ? new int?(pullingTarget.EntityConfigId) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		GrapplingHookPointComponent pullingTarget2 = component.PullingTarget;
		return pullingTarget2 == null || pullingTarget2.MoveFinish;
	}

	// Token: 0x06019020 RID: 102432 RVA: 0x00671F70 File Offset: 0x00670170
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool MotorcycleForceLockTarget(int motorcycleEntityId, int targetEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		GrapplingHookPointComponent component2 = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(targetEntityId);
		if (component == null || !component.Valid || (component2 == null || !component2.Valid))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车强制锁定目标失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetEntityId", targetEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetEntityConfigId", (component2 != null) ? new int?(component2.EntityConfigId) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		return component.ForceLockTarget(component2, "MotorcycleForceLockTarget");
	}

	// Token: 0x06019021 RID: 102433 RVA: 0x0067205C File Offset: 0x0067025C
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool CharacterForceLockTarget(int characterEntityId, int targetEntityId)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(characterEntityId);
		GrapplingHookPointComponent component2 = EntitySystem.Instance.GetComponent<GrapplingHookPointComponent>(targetEntityId);
		if (component == null || !component.Valid || (component2 == null || !component2.Valid))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 角色强制锁定目标失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CharacterEntityId", characterEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetEntityId", targetEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetEntityConfigId", (component2 != null) ? new int?(component2.EntityConfigId) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		return component.ForceLockTarget(component2, "CharacterForceLockTarget");
	}

	// Token: 0x06019022 RID: 102434 RVA: 0x00672148 File Offset: 0x00670348
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool CharacterCancelLockTarget(int characterEntityId, bool resetFocusTarget)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(characterEntityId);
		if (component == null || !component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 角色取消锁定目标失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CharacterEntityId", characterEntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		component.CancelLockTarget("CharacterCancelLockTarget", resetFocusTarget);
		return true;
	}

	// Token: 0x06019023 RID: 102435 RVA: 0x006721B0 File Offset: 0x006703B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static bool MotorcycleGetFixHookParams(int motorcycleEntityId, ref float speed, ref UCurveFloat speedCurve, ref bool needQuat, ref FQuat targetQuat, ref UCurveFloat quatCurve)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		GrapplingHookPointComponent grapplingHookPointComponent = (component != null) ? component.InteractingTarget : null;
		if (component == null || !component.Valid || (grapplingHookPointComponent == null || !grapplingHookPointComponent.Valid))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车获取钩锁配置失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetEntityConfigId", (grapplingHookPointComponent != null) ? new int?(grapplingHookPointComponent.EntityConfigId) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		grapplingHookPointComponent.GetMotorcycleFixHookParams(ref speed, ref speedCurve, ref needQuat, ref targetQuat, ref quatCurve);
		return true;
	}

	// Token: 0x06019024 RID: 102436 RVA: 0x00672280 File Offset: 0x00670480
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static void SetExploreComponentSyncEnabled(int entityId, bool enabled)
	{
		BaseExploreComponent component = EntitySystem.Instance.GetComponent<BaseExploreComponent>(entityId);
		if (component == null || !component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 探索组件同步开关设置失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", entityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Character;
		ELogAuthor author2 = ELogAuthor.CK;
		string message2 = "[TsExploreComponentBlueprintFunctionLibrary] 探索组件同步开关";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", entityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("SyncEnabled(Before)", component.SyncEnabled);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("SyncEnabled(After))", enabled);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		component.SyncEnabled = enabled;
	}

	// Token: 0x06019025 RID: 102437 RVA: 0x006723A8 File Offset: 0x006705A8
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static long GetCharacterFixHookBuffIdByTarget(int characterEntityId)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(characterEntityId);
		if (component == null || !component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 角色获取定点钩锁BuffId失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CharacterEntityId", characterEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0L;
		}
		return component.GetFixHookBuffIdByTarget();
	}

	// Token: 0x06019026 RID: 102438 RVA: 0x00672450 File Offset: 0x00670650
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static long GetMotorcyclePullCollectionBuffIdByTarget(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		if (component == null || !component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车获取拉取采集物BuffId失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0L;
		}
		return component.GetPullCollectionBuffIdByTarget();
	}

	// Token: 0x06019027 RID: 102439 RVA: 0x006724F8 File Offset: 0x006706F8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool TransferRoleInteractingTargetToVehicle(int roleEntityId, int vehicleEntityId)
	{
		CharacterExploreComponent component = EntitySystem.Instance.GetComponent<CharacterExploreComponent>(roleEntityId);
		if (component == null || !component.Valid)
		{
			return false;
		}
		GrapplingHookPointComponent grapplingHookPointComponent = component.InteractingTarget;
		if (grapplingHookPointComponent == null)
		{
			grapplingHookPointComponent = component.FocusTarget;
		}
		if (grapplingHookPointComponent == null)
		{
			return false;
		}
		MotorcycleExploreComponent component2 = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(vehicleEntityId);
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		component2.SetFocusTarget(grapplingHookPointComponent, true);
		return true;
	}

	// Token: 0x06019028 RID: 102440 RVA: 0x00672564 File Offset: 0x00670764
	[UFunction(EFunctionFlags.FUNC_None)]
	protected unsafe static void SetIsHookEndByInterrupt(int motorcycleEntityId, bool isInterrupt)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		if (component != null && component.Valid)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[TsExploreComponentBlueprintFunctionLibrary] 摩托车设置钩锁打断标志";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("MotorcycleEntityId", motorcycleEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ExploreComponent", (component != null) ? new bool?(component.Valid) : null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			component.SetIsHookEndByInterruptProxy(isInterrupt);
		}
	}

	// Token: 0x06019029 RID: 102441 RVA: 0x00672608 File Offset: 0x00670808
	protected static FVectorDouble GetManipulateInteractTargetLocation(int entityId)
	{
		CharacterManipulateInteractComponent component = EntitySystem.Instance.GetComponent<CharacterManipulateInteractComponent>(entityId);
		SceneItemExploreInteractComponent sceneItemExploreInteractComponent = (component != null) ? component.GetCurrentTarget : null;
		BaseActorComponent baseActorComponent = (sceneItemExploreInteractComponent != null) ? sceneItemExploreInteractComponent.Entity.GetComponent<BaseActorComponent>() : null;
		if (baseActorComponent == null)
		{
			return FVectorDouble.ZeroVector;
		}
		return baseActorComponent.ActorLocation;
	}

	// Token: 0x0601902A RID: 102442 RVA: 0x0067264D File Offset: 0x0067084D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsExploreComponentBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsExploreComponentBlueprintFunctionLibrary.TsExploreComponentBlueprintFunctionLibrary_C");
		}
		return TsExploreComponentBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x0601902B RID: 102443 RVA: 0x00672674 File Offset: 0x00670874
	public TsExploreComponentBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsExploreComponentBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601902C RID: 102444 RVA: 0x0067269C File Offset: 0x0067089C
	[NullableContext(1)]
	public TsExploreComponentBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreComponentBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601902D RID: 102445 RVA: 0x006726CF File Offset: 0x006708CF
	protected TsExploreComponentBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601902E RID: 102446 RVA: 0x006726D8 File Offset: 0x006708D8
	protected unsafe static void __CPPCALL_CharacterGetHookLocation_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterGetHookLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterGetHookLocation(__Params->characterEntityId);
	}

	// Token: 0x0601902F RID: 102447 RVA: 0x006726EB File Offset: 0x006708EB
	protected unsafe static void __CPPCALL_MotorcycleGetHookLocation_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetHookLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetHookLocation(__Params->motorcycleEntityId);
	}

	// Token: 0x06019030 RID: 102448 RVA: 0x006726FE File Offset: 0x006708FE
	protected unsafe static void __CPPCALL_CharacterGetInteractingHookEntityId_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterGetInteractingHookEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterGetInteractingHookEntityId(__Params->characterEntityId);
	}

	// Token: 0x06019031 RID: 102449 RVA: 0x00672711 File Offset: 0x00670911
	protected unsafe static void __CPPCALL_MotorcycleGetInteractingHookEntityId_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetInteractingHookEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetInteractingHookEntityId(__Params->motorcycleEntityId);
	}

	// Token: 0x06019032 RID: 102450 RVA: 0x00672724 File Offset: 0x00670924
	protected unsafe static void __CPPCALL_CharacterGetInteractingHookType_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterGetInteractingHookType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsExploreComponentBlueprintFunctionLibrary.CharacterGetInteractingHookType(__Params->characterEntityId);
	}

	// Token: 0x06019033 RID: 102451 RVA: 0x00672739 File Offset: 0x00670939
	protected unsafe static void __CPPCALL_MotorcycleGetInteractingHookType_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetInteractingHookType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetInteractingHookType(__Params->motorcycleEntityId);
	}

	// Token: 0x06019034 RID: 102452 RVA: 0x0067274E File Offset: 0x0067094E
	protected unsafe static void __CPPCALL_MotorcyclePullCollection_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcyclePullCollection_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcyclePullCollection(__Params->motorcycleEntityId);
	}

	// Token: 0x06019035 RID: 102453 RVA: 0x00672761 File Offset: 0x00670961
	protected unsafe static void __CPPCALL_IsMotorcyclePullingCollectionWithProgress_Implementation(TsExploreComponentBlueprintFunctionLibrary.__IsMotorcyclePullingCollectionWithProgress_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.IsMotorcyclePullingCollectionWithProgress(__Params->motorcycleEntityId);
	}

	// Token: 0x06019036 RID: 102454 RVA: 0x00672774 File Offset: 0x00670974
	protected unsafe static void __CPPCALL_MotorcycleCheckPullCollectionFinished_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleCheckPullCollectionFinished_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleCheckPullCollectionFinished(__Params->motorcycleEntityId);
	}

	// Token: 0x06019037 RID: 102455 RVA: 0x00672787 File Offset: 0x00670987
	protected unsafe static void __CPPCALL_MotorcycleForceLockTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleForceLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleForceLockTarget(__Params->motorcycleEntityId, __Params->targetEntityId);
	}

	// Token: 0x06019038 RID: 102456 RVA: 0x006727A0 File Offset: 0x006709A0
	protected unsafe static void __CPPCALL_CharacterForceLockTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterForceLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterForceLockTarget(__Params->characterEntityId, __Params->targetEntityId);
	}

	// Token: 0x06019039 RID: 102457 RVA: 0x006727B9 File Offset: 0x006709B9
	protected unsafe static void __CPPCALL_CharacterCancelLockTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterCancelLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterCancelLockTarget(__Params->characterEntityId, __Params->resetFocusTarget);
	}

	// Token: 0x0601903A RID: 102458 RVA: 0x006727D4 File Offset: 0x006709D4
	protected unsafe static void __CPPCALL_MotorcycleGetFixHookParams_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetFixHookParams_FunctionParams* __Params)
	{
		UCurveFloat orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->speedCurve);
		UCurveFloat orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->quatCurve);
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetFixHookParams(__Params->motorcycleEntityId, ref __Params->speed, ref orCreateUObjectByNativePointer, ref __Params->needQuat, ref __Params->targetQuat, ref orCreateUObjectByNativePointer2);
		*(&__Params->speedCurve) = ((orCreateUObjectByNativePointer != null) ? orCreateUObjectByNativePointer.NativePtr : ((IntPtr)0));
		*(&__Params->quatCurve) = ((orCreateUObjectByNativePointer2 != null) ? orCreateUObjectByNativePointer2.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601903B RID: 102459 RVA: 0x0067284A File Offset: 0x00670A4A
	protected unsafe static void __CPPCALL_SetExploreComponentSyncEnabled_Implementation(TsExploreComponentBlueprintFunctionLibrary.__SetExploreComponentSyncEnabled_FunctionParams* __Params)
	{
		TsExploreComponentBlueprintFunctionLibrary.SetExploreComponentSyncEnabled(__Params->entityId, __Params->enabled);
	}

	// Token: 0x0601903C RID: 102460 RVA: 0x0067285D File Offset: 0x00670A5D
	protected unsafe static void __CPPCALL_GetCharacterFixHookBuffIdByTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__GetCharacterFixHookBuffIdByTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.GetCharacterFixHookBuffIdByTarget(__Params->characterEntityId);
	}

	// Token: 0x0601903D RID: 102461 RVA: 0x00672870 File Offset: 0x00670A70
	protected unsafe static void __CPPCALL_GetMotorcyclePullCollectionBuffIdByTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__GetMotorcyclePullCollectionBuffIdByTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.GetMotorcyclePullCollectionBuffIdByTarget(__Params->motorcycleEntityId);
	}

	// Token: 0x0601903E RID: 102462 RVA: 0x00672883 File Offset: 0x00670A83
	protected unsafe static void __CPPCALL_TransferRoleInteractingTargetToVehicle_Implementation(TsExploreComponentBlueprintFunctionLibrary.__TransferRoleInteractingTargetToVehicle_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.TransferRoleInteractingTargetToVehicle(__Params->roleEntityId, __Params->vehicleEntityId);
	}

	// Token: 0x0601903F RID: 102463 RVA: 0x0067289C File Offset: 0x00670A9C
	protected unsafe static void __CPPCALL_SetIsHookEndByInterrupt_Implementation(TsExploreComponentBlueprintFunctionLibrary.__SetIsHookEndByInterrupt_FunctionParams* __Params)
	{
		TsExploreComponentBlueprintFunctionLibrary.SetIsHookEndByInterrupt(__Params->motorcycleEntityId, __Params->isInterrupt);
	}

	// Token: 0x0400BB91 RID: 48017
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsExploreComponentBlueprintFunctionLibrary.TsExploreComponentBlueprintFunctionLibrary_C";

	// Token: 0x0400BB92 RID: 48018
	private static IntPtr _ClassPtr;

	// Token: 0x0400BB93 RID: 48019
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020093AF RID: 37807
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CharacterGetHookLocation_FunctionParams
	{
		// Token: 0x0402FA5D RID: 195165
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402FA5E RID: 195166
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA5F RID: 195167
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020093B0 RID: 37808
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __MotorcycleGetHookLocation_FunctionParams
	{
		// Token: 0x0402FA60 RID: 195168
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA61 RID: 195169
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA62 RID: 195170
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020093B1 RID: 37809
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterGetInteractingHookEntityId_FunctionParams
	{
		// Token: 0x0402FA63 RID: 195171
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402FA64 RID: 195172
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA65 RID: 195173
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020093B2 RID: 37810
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleGetInteractingHookEntityId_FunctionParams
	{
		// Token: 0x0402FA66 RID: 195174
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA67 RID: 195175
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA68 RID: 195176
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020093B3 RID: 37811
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterGetInteractingHookType_FunctionParams
	{
		// Token: 0x0402FA69 RID: 195177
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402FA6A RID: 195178
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA6B RID: 195179
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020093B4 RID: 37812
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleGetInteractingHookType_FunctionParams
	{
		// Token: 0x0402FA6C RID: 195180
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA6D RID: 195181
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA6E RID: 195182
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020093B5 RID: 37813
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcyclePullCollection_FunctionParams
	{
		// Token: 0x0402FA6F RID: 195183
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA70 RID: 195184
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA71 RID: 195185
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093B6 RID: 37814
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsMotorcyclePullingCollectionWithProgress_FunctionParams
	{
		// Token: 0x0402FA72 RID: 195186
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA73 RID: 195187
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA74 RID: 195188
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093B7 RID: 37815
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleCheckPullCollectionFinished_FunctionParams
	{
		// Token: 0x0402FA75 RID: 195189
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA76 RID: 195190
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA77 RID: 195191
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093B8 RID: 37816
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleForceLockTarget_FunctionParams
	{
		// Token: 0x0402FA78 RID: 195192
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA79 RID: 195193
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402FA7A RID: 195194
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA7B RID: 195195
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093B9 RID: 37817
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterForceLockTarget_FunctionParams
	{
		// Token: 0x0402FA7C RID: 195196
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402FA7D RID: 195197
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402FA7E RID: 195198
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA7F RID: 195199
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093BA RID: 37818
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterCancelLockTarget_FunctionParams
	{
		// Token: 0x0402FA80 RID: 195200
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402FA81 RID: 195201
		[FieldOffset(4)]
		public bool resetFocusTarget;

		// Token: 0x0402FA82 RID: 195202
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA83 RID: 195203
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093BB RID: 37819
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __MotorcycleGetFixHookParams_FunctionParams
	{
		// Token: 0x0402FA84 RID: 195204
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA85 RID: 195205
		[FieldOffset(4)]
		public float speed;

		// Token: 0x0402FA86 RID: 195206
		[FieldOffset(8)]
		public IntPtr speedCurve;

		// Token: 0x0402FA87 RID: 195207
		[FieldOffset(16)]
		public bool needQuat;

		// Token: 0x0402FA88 RID: 195208
		[FieldOffset(32)]
		public FQuat targetQuat;

		// Token: 0x0402FA89 RID: 195209
		[FieldOffset(48)]
		public IntPtr quatCurve;

		// Token: 0x0402FA8A RID: 195210
		[FieldOffset(56)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA8B RID: 195211
		[FieldOffset(64)]
		public bool __Result;
	}

	// Token: 0x020093BC RID: 37820
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetExploreComponentSyncEnabled_FunctionParams
	{
		// Token: 0x0402FA8C RID: 195212
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402FA8D RID: 195213
		[FieldOffset(4)]
		public bool enabled;

		// Token: 0x0402FA8E RID: 195214
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020093BD RID: 37821
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharacterFixHookBuffIdByTarget_FunctionParams
	{
		// Token: 0x0402FA8F RID: 195215
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402FA90 RID: 195216
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA91 RID: 195217
		[FieldOffset(16)]
		public long __Result;
	}

	// Token: 0x020093BE RID: 37822
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMotorcyclePullCollectionBuffIdByTarget_FunctionParams
	{
		// Token: 0x0402FA92 RID: 195218
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA93 RID: 195219
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA94 RID: 195220
		[FieldOffset(16)]
		public long __Result;
	}

	// Token: 0x020093BF RID: 37823
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TransferRoleInteractingTargetToVehicle_FunctionParams
	{
		// Token: 0x0402FA95 RID: 195221
		[FieldOffset(0)]
		public int roleEntityId;

		// Token: 0x0402FA96 RID: 195222
		[FieldOffset(4)]
		public int vehicleEntityId;

		// Token: 0x0402FA97 RID: 195223
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402FA98 RID: 195224
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020093C0 RID: 37824
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetIsHookEndByInterrupt_FunctionParams
	{
		// Token: 0x0402FA99 RID: 195225
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402FA9A RID: 195226
		[FieldOffset(4)]
		public bool isInterrupt;

		// Token: 0x0402FA9B RID: 195227
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
