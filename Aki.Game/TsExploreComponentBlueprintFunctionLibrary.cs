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

// Token: 0x0200239B RID: 9115
[UClass("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsExploreComponentBlueprintFunctionLibrary.TsExploreComponentBlueprintFunctionLibrary_C")]
public class TsExploreComponentBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
{
	// Token: 0x060168E4 RID: 92388 RVA: 0x00697708 File Offset: 0x00695908
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

	// Token: 0x060168E5 RID: 92389 RVA: 0x00697804 File Offset: 0x00695A04
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

	// Token: 0x060168E6 RID: 92390 RVA: 0x00697900 File Offset: 0x00695B00
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

	// Token: 0x060168E7 RID: 92391 RVA: 0x006979F8 File Offset: 0x00695BF8
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

	// Token: 0x060168E8 RID: 92392 RVA: 0x00697AF0 File Offset: 0x00695CF0
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

	// Token: 0x060168E9 RID: 92393 RVA: 0x00697BE0 File Offset: 0x00695DE0
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

	// Token: 0x060168EA RID: 92394 RVA: 0x00697CD0 File Offset: 0x00695ED0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool MotorcyclePullCollection(int motorcycleEntityId)
	{
		MotorcycleExploreComponent component = EntitySystem.Instance.GetComponent<MotorcycleExploreComponent>(motorcycleEntityId);
		return component != null && component.Valid && component.TryPullCollection();
	}

	// Token: 0x060168EB RID: 92395 RVA: 0x00697CFC File Offset: 0x00695EFC
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

	// Token: 0x060168EC RID: 92396 RVA: 0x00697D34 File Offset: 0x00695F34
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

	// Token: 0x060168ED RID: 92397 RVA: 0x00697E38 File Offset: 0x00696038
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

	// Token: 0x060168EE RID: 92398 RVA: 0x00697F24 File Offset: 0x00696124
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

	// Token: 0x060168EF RID: 92399 RVA: 0x00698010 File Offset: 0x00696210
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

	// Token: 0x060168F0 RID: 92400 RVA: 0x00698078 File Offset: 0x00696278
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

	// Token: 0x060168F1 RID: 92401 RVA: 0x00698148 File Offset: 0x00696348
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

	// Token: 0x060168F2 RID: 92402 RVA: 0x00698270 File Offset: 0x00696470
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

	// Token: 0x060168F3 RID: 92403 RVA: 0x00698318 File Offset: 0x00696518
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

	// Token: 0x060168F4 RID: 92404 RVA: 0x006983C0 File Offset: 0x006965C0
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

	// Token: 0x060168F5 RID: 92405 RVA: 0x0069842C File Offset: 0x0069662C
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

	// Token: 0x060168F6 RID: 92406 RVA: 0x006984D0 File Offset: 0x006966D0
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

	// Token: 0x060168F7 RID: 92407 RVA: 0x00698515 File Offset: 0x00696715
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsExploreComponentBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsExploreComponentBlueprintFunctionLibrary.TsExploreComponentBlueprintFunctionLibrary_C");
		}
		return TsExploreComponentBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x060168F8 RID: 92408 RVA: 0x0069853C File Offset: 0x0069673C
	public TsExploreComponentBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(TsExploreComponentBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060168F9 RID: 92409 RVA: 0x00698564 File Offset: 0x00696764
	[NullableContext(1)]
	public TsExploreComponentBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsExploreComponentBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060168FA RID: 92410 RVA: 0x00698597 File Offset: 0x00696797
	protected TsExploreComponentBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060168FB RID: 92411 RVA: 0x006985A0 File Offset: 0x006967A0
	protected unsafe static void __CPPCALL_CharacterGetHookLocation_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterGetHookLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterGetHookLocation(__Params->characterEntityId);
	}

	// Token: 0x060168FC RID: 92412 RVA: 0x006985B3 File Offset: 0x006967B3
	protected unsafe static void __CPPCALL_MotorcycleGetHookLocation_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetHookLocation_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetHookLocation(__Params->motorcycleEntityId);
	}

	// Token: 0x060168FD RID: 92413 RVA: 0x006985C6 File Offset: 0x006967C6
	protected unsafe static void __CPPCALL_CharacterGetInteractingHookEntityId_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterGetInteractingHookEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterGetInteractingHookEntityId(__Params->characterEntityId);
	}

	// Token: 0x060168FE RID: 92414 RVA: 0x006985D9 File Offset: 0x006967D9
	protected unsafe static void __CPPCALL_MotorcycleGetInteractingHookEntityId_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetInteractingHookEntityId_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetInteractingHookEntityId(__Params->motorcycleEntityId);
	}

	// Token: 0x060168FF RID: 92415 RVA: 0x006985EC File Offset: 0x006967EC
	protected unsafe static void __CPPCALL_CharacterGetInteractingHookType_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterGetInteractingHookType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsExploreComponentBlueprintFunctionLibrary.CharacterGetInteractingHookType(__Params->characterEntityId);
	}

	// Token: 0x06016900 RID: 92416 RVA: 0x00698601 File Offset: 0x00696801
	protected unsafe static void __CPPCALL_MotorcycleGetInteractingHookType_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetInteractingHookType_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetInteractingHookType(__Params->motorcycleEntityId);
	}

	// Token: 0x06016901 RID: 92417 RVA: 0x00698616 File Offset: 0x00696816
	protected unsafe static void __CPPCALL_MotorcyclePullCollection_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcyclePullCollection_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcyclePullCollection(__Params->motorcycleEntityId);
	}

	// Token: 0x06016902 RID: 92418 RVA: 0x00698629 File Offset: 0x00696829
	protected unsafe static void __CPPCALL_IsMotorcyclePullingCollectionWithProgress_Implementation(TsExploreComponentBlueprintFunctionLibrary.__IsMotorcyclePullingCollectionWithProgress_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.IsMotorcyclePullingCollectionWithProgress(__Params->motorcycleEntityId);
	}

	// Token: 0x06016903 RID: 92419 RVA: 0x0069863C File Offset: 0x0069683C
	protected unsafe static void __CPPCALL_MotorcycleCheckPullCollectionFinished_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleCheckPullCollectionFinished_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleCheckPullCollectionFinished(__Params->motorcycleEntityId);
	}

	// Token: 0x06016904 RID: 92420 RVA: 0x0069864F File Offset: 0x0069684F
	protected unsafe static void __CPPCALL_MotorcycleForceLockTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleForceLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleForceLockTarget(__Params->motorcycleEntityId, __Params->targetEntityId);
	}

	// Token: 0x06016905 RID: 92421 RVA: 0x00698668 File Offset: 0x00696868
	protected unsafe static void __CPPCALL_CharacterForceLockTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterForceLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterForceLockTarget(__Params->characterEntityId, __Params->targetEntityId);
	}

	// Token: 0x06016906 RID: 92422 RVA: 0x00698681 File Offset: 0x00696881
	protected unsafe static void __CPPCALL_CharacterCancelLockTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__CharacterCancelLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.CharacterCancelLockTarget(__Params->characterEntityId, __Params->resetFocusTarget);
	}

	// Token: 0x06016907 RID: 92423 RVA: 0x0069869C File Offset: 0x0069689C
	protected unsafe static void __CPPCALL_MotorcycleGetFixHookParams_Implementation(TsExploreComponentBlueprintFunctionLibrary.__MotorcycleGetFixHookParams_FunctionParams* __Params)
	{
		UCurveFloat orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->speedCurve);
		UCurveFloat orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->quatCurve);
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.MotorcycleGetFixHookParams(__Params->motorcycleEntityId, ref __Params->speed, ref orCreateUObjectByNativePointer, ref __Params->needQuat, ref __Params->targetQuat, ref orCreateUObjectByNativePointer2);
		*(&__Params->speedCurve) = ((orCreateUObjectByNativePointer != null) ? orCreateUObjectByNativePointer.NativePtr : ((IntPtr)0));
		*(&__Params->quatCurve) = ((orCreateUObjectByNativePointer2 != null) ? orCreateUObjectByNativePointer2.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06016908 RID: 92424 RVA: 0x00698712 File Offset: 0x00696912
	protected unsafe static void __CPPCALL_SetExploreComponentSyncEnabled_Implementation(TsExploreComponentBlueprintFunctionLibrary.__SetExploreComponentSyncEnabled_FunctionParams* __Params)
	{
		TsExploreComponentBlueprintFunctionLibrary.SetExploreComponentSyncEnabled(__Params->entityId, __Params->enabled);
	}

	// Token: 0x06016909 RID: 92425 RVA: 0x00698725 File Offset: 0x00696925
	protected unsafe static void __CPPCALL_GetCharacterFixHookBuffIdByTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__GetCharacterFixHookBuffIdByTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.GetCharacterFixHookBuffIdByTarget(__Params->characterEntityId);
	}

	// Token: 0x0601690A RID: 92426 RVA: 0x00698738 File Offset: 0x00696938
	protected unsafe static void __CPPCALL_GetMotorcyclePullCollectionBuffIdByTarget_Implementation(TsExploreComponentBlueprintFunctionLibrary.__GetMotorcyclePullCollectionBuffIdByTarget_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.GetMotorcyclePullCollectionBuffIdByTarget(__Params->motorcycleEntityId);
	}

	// Token: 0x0601690B RID: 92427 RVA: 0x0069874B File Offset: 0x0069694B
	protected unsafe static void __CPPCALL_TransferRoleInteractingTargetToVehicle_Implementation(TsExploreComponentBlueprintFunctionLibrary.__TransferRoleInteractingTargetToVehicle_FunctionParams* __Params)
	{
		__Params->__Result = TsExploreComponentBlueprintFunctionLibrary.TransferRoleInteractingTargetToVehicle(__Params->roleEntityId, __Params->vehicleEntityId);
	}

	// Token: 0x0601690C RID: 92428 RVA: 0x00698764 File Offset: 0x00696964
	protected unsafe static void __CPPCALL_SetIsHookEndByInterrupt_Implementation(TsExploreComponentBlueprintFunctionLibrary.__SetIsHookEndByInterrupt_FunctionParams* __Params)
	{
		TsExploreComponentBlueprintFunctionLibrary.SetIsHookEndByInterrupt(__Params->motorcycleEntityId, __Params->isInterrupt);
	}

	// Token: 0x0400BF1F RID: 48927
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/Character/Common/Blueprint/Utils/TsExploreComponentBlueprintFunctionLibrary.TsExploreComponentBlueprintFunctionLibrary_C";

	// Token: 0x0400BF20 RID: 48928
	private static IntPtr _ClassPtr;

	// Token: 0x0400BF21 RID: 48929
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020085D5 RID: 34261
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __CharacterGetHookLocation_FunctionParams
	{
		// Token: 0x0402B0E3 RID: 176355
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402B0E4 RID: 176356
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0E5 RID: 176357
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020085D6 RID: 34262
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __MotorcycleGetHookLocation_FunctionParams
	{
		// Token: 0x0402B0E6 RID: 176358
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0E7 RID: 176359
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0E8 RID: 176360
		[FieldOffset(16)]
		public FVectorDouble __Result;
	}

	// Token: 0x020085D7 RID: 34263
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterGetInteractingHookEntityId_FunctionParams
	{
		// Token: 0x0402B0E9 RID: 176361
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402B0EA RID: 176362
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0EB RID: 176363
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020085D8 RID: 34264
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleGetInteractingHookEntityId_FunctionParams
	{
		// Token: 0x0402B0EC RID: 176364
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0ED RID: 176365
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0EE RID: 176366
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020085D9 RID: 34265
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterGetInteractingHookType_FunctionParams
	{
		// Token: 0x0402B0EF RID: 176367
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402B0F0 RID: 176368
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0F1 RID: 176369
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020085DA RID: 34266
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleGetInteractingHookType_FunctionParams
	{
		// Token: 0x0402B0F2 RID: 176370
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0F3 RID: 176371
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0F4 RID: 176372
		[FieldOffset(16)]
		public byte __Result;
	}

	// Token: 0x020085DB RID: 34267
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcyclePullCollection_FunctionParams
	{
		// Token: 0x0402B0F5 RID: 176373
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0F6 RID: 176374
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0F7 RID: 176375
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085DC RID: 34268
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __IsMotorcyclePullingCollectionWithProgress_FunctionParams
	{
		// Token: 0x0402B0F8 RID: 176376
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0F9 RID: 176377
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0FA RID: 176378
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085DD RID: 34269
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleCheckPullCollectionFinished_FunctionParams
	{
		// Token: 0x0402B0FB RID: 176379
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0FC RID: 176380
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B0FD RID: 176381
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085DE RID: 34270
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __MotorcycleForceLockTarget_FunctionParams
	{
		// Token: 0x0402B0FE RID: 176382
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B0FF RID: 176383
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B100 RID: 176384
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B101 RID: 176385
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085DF RID: 34271
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterForceLockTarget_FunctionParams
	{
		// Token: 0x0402B102 RID: 176386
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402B103 RID: 176387
		[FieldOffset(4)]
		public int targetEntityId;

		// Token: 0x0402B104 RID: 176388
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B105 RID: 176389
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085E0 RID: 34272
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __CharacterCancelLockTarget_FunctionParams
	{
		// Token: 0x0402B106 RID: 176390
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402B107 RID: 176391
		[FieldOffset(4)]
		public bool resetFocusTarget;

		// Token: 0x0402B108 RID: 176392
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B109 RID: 176393
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085E1 RID: 34273
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __MotorcycleGetFixHookParams_FunctionParams
	{
		// Token: 0x0402B10A RID: 176394
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B10B RID: 176395
		[FieldOffset(4)]
		public float speed;

		// Token: 0x0402B10C RID: 176396
		[FieldOffset(8)]
		public IntPtr speedCurve;

		// Token: 0x0402B10D RID: 176397
		[FieldOffset(16)]
		public bool needQuat;

		// Token: 0x0402B10E RID: 176398
		[FieldOffset(32)]
		public FQuat targetQuat;

		// Token: 0x0402B10F RID: 176399
		[FieldOffset(48)]
		public IntPtr quatCurve;

		// Token: 0x0402B110 RID: 176400
		[FieldOffset(56)]
		public IntPtr __WorldContext;

		// Token: 0x0402B111 RID: 176401
		[FieldOffset(64)]
		public bool __Result;
	}

	// Token: 0x020085E2 RID: 34274
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetExploreComponentSyncEnabled_FunctionParams
	{
		// Token: 0x0402B112 RID: 176402
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402B113 RID: 176403
		[FieldOffset(4)]
		public bool enabled;

		// Token: 0x0402B114 RID: 176404
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020085E3 RID: 34275
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCharacterFixHookBuffIdByTarget_FunctionParams
	{
		// Token: 0x0402B115 RID: 176405
		[FieldOffset(0)]
		public int characterEntityId;

		// Token: 0x0402B116 RID: 176406
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B117 RID: 176407
		[FieldOffset(16)]
		public long __Result;
	}

	// Token: 0x020085E4 RID: 34276
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetMotorcyclePullCollectionBuffIdByTarget_FunctionParams
	{
		// Token: 0x0402B118 RID: 176408
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B119 RID: 176409
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B11A RID: 176410
		[FieldOffset(16)]
		public long __Result;
	}

	// Token: 0x020085E5 RID: 34277
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __TransferRoleInteractingTargetToVehicle_FunctionParams
	{
		// Token: 0x0402B11B RID: 176411
		[FieldOffset(0)]
		public int roleEntityId;

		// Token: 0x0402B11C RID: 176412
		[FieldOffset(4)]
		public int vehicleEntityId;

		// Token: 0x0402B11D RID: 176413
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x0402B11E RID: 176414
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020085E6 RID: 34278
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetIsHookEndByInterrupt_FunctionParams
	{
		// Token: 0x0402B11F RID: 176415
		[FieldOffset(0)]
		public int motorcycleEntityId;

		// Token: 0x0402B120 RID: 176416
		[FieldOffset(4)]
		public bool isInterrupt;

		// Token: 0x0402B121 RID: 176417
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
