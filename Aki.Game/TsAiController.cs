using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using Aki.Config;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Monster.Common;
using CSharpScript.Game.AI.StateMachine;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000FD RID: 253
[UClass("/Game/Aki/TypeScript/Game/AI/Controller/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/Controller/TsAiController.TsAiController_C")]
public class TsAiController : AKuroAIController, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000267 RID: 615
	// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00052D5E File Offset: 0x00050F5E
	// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00052D72 File Offset: 0x00050F72
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe UBehaviorTree BehaviorTree
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UBehaviorTree>(base.NativePtr / (IntPtr)sizeof(void*) + TsAiController.__PropertyOffset_BehaviorTree);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAiController.__PropertyOffset_BehaviorTree, value);
		}
	}

	// Token: 0x17000268 RID: 616
	// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00052D87 File Offset: 0x00050F87
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UKuroStateMachineGroup StateMachineGroup
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UKuroStateMachineGroup>(base.NativePtr / (IntPtr)sizeof(void*) + TsAiController.__PropertyOffset_StateMachineGroup);
		}
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00052D9B File Offset: 0x00050F9B
	[NullableContext(2)]
	public Entity GetEntity()
	{
		CharacterAiComponent charAiDesignComp = this.CharAiDesignComp;
		if (charAiDesignComp == null)
		{
			return null;
		}
		return charAiDesignComp.Entity;
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00052DAE File Offset: 0x00050FAE
	[NullableContext(2)]
	public CharacterAiComponent GetAiComp()
	{
		return this.CharAiDesignComp;
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00052DB6 File Offset: 0x00050FB6
	[NullableContext(2)]
	public bool SetupBehaviorTree(UBehaviorTree behaviorTree)
	{
		if (this.BehaviorTree == behaviorTree)
		{
			return false;
		}
		CharacterAiComponent charAiDesignComp = this.CharAiDesignComp;
		if (charAiDesignComp != null)
		{
			charAiDesignComp.ClearBehaviorTreeBubble();
		}
		this.BehaviorTree = behaviorTree;
		base.RunBehaviorTree(behaviorTree);
		return true;
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00052DE4 File Offset: 0x00050FE4
	[NullableContext(1)]
	public void InitAiController(CharacterAiComponent aiComp)
	{
		this.CharAiDesignComp = aiComp;
		this.AiController = aiComp.AiController;
		this.CharBuffComp = aiComp.Entity.GetComponent<CharacterBuffComponent>();
		this.CharTagComp = aiComp.Entity.GetComponent<BaseTagComponent>();
		this.CharStateMachineComp = aiComp.Entity.GetComponent<CharacterStateMachineNewComponent>();
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00052E38 File Offset: 0x00051038
	public void DrawDebugLines(float deltaSeconds)
	{
		CharacterAiComponent charAiDesignComp = this.CharAiDesignComp;
		if (charAiDesignComp == null || !charAiDesignComp.Valid)
		{
			return;
		}
		global::Vector actorLocationProxy = this.AiController.CharActorComp.ActorLocationProxy;
		EntityHandle currentTarget = this.AiController.AiHateList.GetCurrentTarget();
		this.DrawPerception(actorLocationProxy, currentTarget);
		if (currentTarget != null && currentTarget.Valid)
		{
			CharacterActorComponent component = currentTarget.Entity.GetComponent<CharacterActorComponent>();
			this.DrawArrow(actorLocationProxy, component.ActorLocationProxy, TsAiController.targetLinkColor);
			AiAreaMemberData aiTeamAreaMemberData = this.AiController.AiTeam.GetAiTeamAreaMemberData(this.AiController);
			if (aiTeamAreaMemberData != null && aiTeamAreaMemberData.IsAttacker)
			{
				TsAiController.TmpVector.DeepCopy(actorLocationProxy);
				GravityUtils.Instance.AddZnInGravityForActor(this.AiController.CharActorComp, TsAiController.TmpVector, (double)this.AiController.CharActorComp.HalfHeight);
				UKismetSystemLibrary.D_DrawDebugBox(this, TsAiController.TmpVector.ToUeVector(false), new FVectorDouble(10.0, 10.0, 10.0), TsAiController.enemyLinkColor, this.AiController.CharActorComp.ActorRotation, 0f, 3f);
			}
			if (aiTeamAreaMemberData != null && aiTeamAreaMemberData.AreaIndex >= 0)
			{
				global::Vector tmpVector = TsAiController.TmpVector3;
				global::Vector tmpVector2 = TsAiController.TmpVector2;
				tmpVector.DeepCopy(actorLocationProxy);
				GravityUtils.Instance.AddZnInGravityForActor(this.AiController.CharActorComp, tmpVector, (double)(10f - this.AiController.CharActorComp.HalfHeight));
				float num = (aiTeamAreaMemberData.CachedControllerYaw + aiTeamAreaMemberData.AngleCenter) * 0.017453292f;
				tmpVector2.Set(Math.Cos((double)num) * (double)aiTeamAreaMemberData.DistanceCenter, Math.Sin((double)num) * (double)aiTeamAreaMemberData.DistanceCenter, 0.0);
				aiTeamAreaMemberData.Group.GravityQuat.RotateVector(tmpVector2, tmpVector2);
				tmpVector2.AdditionEqual(tmpVector);
				this.DrawArrow(tmpVector, tmpVector2, TsAiController.areaCenterColor);
			}
		}
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x0005302C File Offset: 0x0005122C
	[NullableContext(1)]
	protected void DrawPerception(global::Vector myLocation, [Nullable(2)] EntityHandle currentTarget)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception != null)
		{
			foreach (int id in aiPerception.ShareAllyLink)
			{
				CharacterActorComponent characterActorComponentById = CharacterController.Instance.GetCharacterActorComponentById(id);
				if (characterActorComponentById != null)
				{
					this.DrawArrow(myLocation, characterActorComponentById.ActorLocationProxy, TsAiController.teamMemberLinkColor);
				}
			}
			foreach (int num in aiPerception.Allies)
			{
				if (!aiPerception.ShareAllyLink.Contains(num))
				{
					CharacterActorComponent characterActorComponentById2 = CharacterController.Instance.GetCharacterActorComponentById(num);
					if (characterActorComponentById2 != null)
					{
						this.DrawArrow(myLocation, characterActorComponentById2.ActorLocationProxy, TsAiController.allyLinkColor);
					}
				}
			}
			foreach (int num2 in aiPerception.AllEnemies)
			{
				if (currentTarget == null || !currentTarget.Valid || num2 != currentTarget.Id)
				{
					CharacterActorComponent characterActorComponentById3 = CharacterController.Instance.GetCharacterActorComponentById(num2);
					if (characterActorComponentById3 != null)
					{
						this.DrawArrow(myLocation, characterActorComponentById3.ActorLocationProxy, TsAiController.enemyLinkColor);
					}
				}
			}
			foreach (int id2 in aiPerception.Neutrals)
			{
				CharacterActorComponent characterActorComponentById4 = CharacterController.Instance.GetCharacterActorComponentById(id2);
				if (characterActorComponentById4 != null)
				{
					this.DrawArrow(myLocation, characterActorComponentById4.ActorLocationProxy, TsAiController.neutralLinkColor);
				}
			}
		}
		CharacterActorComponent charActorComp = this.AiController.CharActorComp;
		TsAiController.TmpVector.FromUeVector(this.AiController.CharAiDesignComp.HatredInitLocation);
		UKismetSystemLibrary.D_DrawDebugSphere(this, TsAiController.TmpVector.ToUeVector(false), 30f, 24, new FLinearColor?(TsAiController.initLocationColor), 0f, 0f);
		global::Vector tmpVector = TsAiController.TmpVector;
		GravityUtils.Instance.AddZnInGravityForActor(charActorComp, tmpVector, (double)(-(double)charActorComp.HalfHeight));
		AiHate value = this.AiController.AiHateList.AiHate.Value;
		global::Vector floorLocation = charActorComp.FloorLocation;
		UKismetSystemLibrary.D_DrawDebugSphere(this, floorLocation.ToUeVector(false), value.DisengageDistanceRange.Value.Min, 24, new FLinearColor?(TsAiController.minHateAreaColor), 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(this, floorLocation.ToUeVector(false), value.DisengageDistanceRange.Value.Max, 24, new FLinearColor?(TsAiController.maxHateAreaColor), 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(this, tmpVector.ToUeVector(false), value.DisengageBornDistance.Value.Min, 24, new FLinearColor?(TsAiController.minHateInitAreaColor), 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(this, tmpVector.ToUeVector(false), value.DisengageBornDistance.Value.Max, 24, new FLinearColor?(TsAiController.maxHateInitAreaColor), 0f, 0f);
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00053384 File Offset: 0x00051584
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void OnStart()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OnStart"), TsAiController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OnStart_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x000533DD File Offset: 0x000515DD
	protected void OnStart_Implementation()
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x000533E0 File Offset: 0x000515E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void 获取控制权时()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("获取控制权时"), TsAiController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.获取控制权时_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00053439 File Offset: 0x00051639
	protected void 获取控制权时_Implementation()
	{
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x0005343C File Offset: 0x0005163C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 状态切换时(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("状态切换时"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.状态切换时_Implementation(oldState, newState, isAutonomousProxy);
			return;
		}
		TsAiController.__状态切换时_FunctionParams* ptr = stackalloc TsAiController.__状态切换时_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__状态切换时_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->oldState) = (byte)oldState;
		*(&ptr->newState) = (byte)newState;
		ptr->isAutonomousProxy = isAutonomousProxy;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x000534DC File Offset: 0x000516DC
	protected void 状态切换时_Implementation(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
	{
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x000534E0 File Offset: 0x000516E0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 渲染状态改变时(bool wasRendered)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("渲染状态改变时"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.渲染状态改变时_Implementation(wasRendered);
			return;
		}
		TsAiController.__渲染状态改变时_FunctionParams* ptr = stackalloc TsAiController.__渲染状态改变时_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__渲染状态改变时_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->wasRendered = wasRendered;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x0005356C File Offset: 0x0005176C
	protected void 渲染状态改变时_Implementation(bool wasRendered)
	{
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00053570 File Offset: 0x00051770
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddComplicatedEventBinder(SAiConditions conditions, UKuroBooleanEventBinder eventBinder)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddComplicatedEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddComplicatedEventBinder_Implementation(conditions, eventBinder);
			return;
		}
		TsAiController.__AddComplicatedEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddComplicatedEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddComplicatedEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), &ptr->conditions, (conditions != null) ? conditions.NativePtr : ((IntPtr)0), 1, false);
		*(&ptr->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x0005362C File Offset: 0x0005182C
	[NullableContext(1)]
	protected void AddComplicatedEventBinder_Implementation(SAiConditions conditions, UKuroBooleanEventBinder eventBinder)
	{
		if (this.AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Error Call AddComplicatedEventBinder";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AIC", this);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AiController.AiConditionEvents.AddConditionEvent(conditions, eventBinder);
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x0005367C File Offset: 0x0005187C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddSceneItemDestroyEventBinder(float distance, UKuroActorEventBinder eventBinder)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddSceneItemDestroyEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddSceneItemDestroyEventBinder_Implementation(distance, eventBinder);
			return;
		}
		TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->distance = distance;
		*(&ptr->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00053720 File Offset: 0x00051920
	[NullableContext(1)]
	protected void AddSceneItemDestroyEventBinder_Implementation(float distance, UKuroActorEventBinder eventBinder)
	{
		if (this.AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Error Call AddSceneItemDestroyEventBinder";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AIC", this);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AiController.AiPerceptionEvents.AddSceneItemDestroyEvent(distance, eventBinder);
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x00053770 File Offset: 0x00051970
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddLevelVarBoolEventBinder(SAiLevelVar levelVar, UKuroBooleanEventBinder eventBinder)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddLevelVarBoolEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddLevelVarBoolEventBinder_Implementation(levelVar, eventBinder);
			return;
		}
		TsAiController.__AddLevelVarBoolEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddLevelVarBoolEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddLevelVarBoolEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(SAiLevelVar.StaticStruct(), &ptr->levelVar, (levelVar != null) ? levelVar.NativePtr : ((IntPtr)0), 1, false);
		*(&ptr->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x0005382C File Offset: 0x00051A2C
	[NullableContext(1)]
	protected void AddLevelVarBoolEventBinder_Implementation(SAiLevelVar levelVar, UKuroBooleanEventBinder eventBinder)
	{
		if (this.AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.CH;
			string message = "Error Call AddLevelVarBoolEventBinder";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AIC", this);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AiController.AiLevelVarEvents.AddLevelVarEvent(levelVar, eventBinder);
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x0005387C File Offset: 0x00051A7C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddLevelVarIntEventBinder(SAiLevelVar levelVar, UKuroIntEventBinder eventBinder)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddLevelVarIntEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddLevelVarIntEventBinder_Implementation(levelVar, eventBinder);
			return;
		}
		TsAiController.__AddLevelVarIntEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddLevelVarIntEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddLevelVarIntEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(SAiLevelVar.StaticStruct(), &ptr->levelVar, (levelVar != null) ? levelVar.NativePtr : ((IntPtr)0), 1, false);
		*(&ptr->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00053938 File Offset: 0x00051B38
	[NullableContext(1)]
	protected void AddLevelVarIntEventBinder_Implementation(SAiLevelVar levelVar, UKuroIntEventBinder eventBinder)
	{
		if (this.AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.CH;
			string message = "Error Call AddLevelVarBoolEventBinder";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AIC", this);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AiController.AiLevelVarEvents.AddLevelVarEvent(levelVar, eventBinder);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00053988 File Offset: 0x00051B88
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddHateEventBinder(UKuroPerceptionEventBinder handler)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddHateEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddHateEventBinder_Implementation(handler);
			return;
		}
		TsAiController.__AddHateEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddHateEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddHateEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->handler) = ((handler != null) ? handler.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00053A22 File Offset: 0x00051C22
	[NullableContext(1)]
	protected void AddHateEventBinder_Implementation(UKuroPerceptionEventBinder handler)
	{
		AiController aiController = this.AiController;
		if (aiController == null)
		{
			return;
		}
		aiController.AiPerceptionEvents.AddAiHateEvent(handler);
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x00053A3C File Offset: 0x00051C3C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddPerceptionEventBinder(UKuroPerceptionEventBinder handler)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddPerceptionEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddPerceptionEventBinder_Implementation(handler);
			return;
		}
		TsAiController.__AddPerceptionEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddPerceptionEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddPerceptionEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->handler) = ((handler != null) ? handler.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00053AD6 File Offset: 0x00051CD6
	[NullableContext(1)]
	protected void AddPerceptionEventBinder_Implementation(UKuroPerceptionEventBinder handler)
	{
		AiController aiController = this.AiController;
		if (aiController == null)
		{
			return;
		}
		aiController.AiPerceptionEvents.AddAiPerceptionEvent(handler, false, true, false);
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x00053AF4 File Offset: 0x00051CF4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetPerceptionEventState(bool includeFriend, bool includeEnemy, bool includeNeutral)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetPerceptionEventState"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetPerceptionEventState_Implementation(includeFriend, includeEnemy, includeNeutral);
			return;
		}
		TsAiController.__SetPerceptionEventState_FunctionParams* ptr = stackalloc TsAiController.__SetPerceptionEventState_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetPerceptionEventState_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->includeFriend = includeFriend;
		ptr->includeEnemy = includeEnemy;
		ptr->includeNeutral = includeNeutral;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00053B90 File Offset: 0x00051D90
	protected void SetPerceptionEventState_Implementation(bool includeFriend, bool includeEnemy, bool includeNeutral)
	{
		AiController aiController = this.AiController;
		if (aiController == null)
		{
			return;
		}
		aiController.AiPerceptionEvents.SetPerceptionEventState(includeFriend, includeEnemy, includeNeutral);
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x00053BAC File Offset: 0x00051DAC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddHateOutRangeEventBinder(UKuroPerceptionEventBinder handler)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddHateOutRangeEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddHateOutRangeEventBinder_Implementation(handler);
			return;
		}
		TsAiController.__AddHateOutRangeEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddHateOutRangeEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddHateOutRangeEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->handler) = ((handler != null) ? handler.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x00053C46 File Offset: 0x00051E46
	[NullableContext(1)]
	protected void AddHateOutRangeEventBinder_Implementation(UKuroPerceptionEventBinder handler)
	{
		AiController aiController = this.AiController;
		if (aiController == null)
		{
			return;
		}
		aiController.AiPerceptionEvents.AddAiHateOutRangeEvent(handler);
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00053C60 File Offset: 0x00051E60
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ActivateSkillGroup(int skillGroupIndex, bool activate)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ActivateSkillGroup"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.ActivateSkillGroup_Implementation(skillGroupIndex, activate);
			return;
		}
		TsAiController.__ActivateSkillGroup_FunctionParams* ptr = stackalloc TsAiController.__ActivateSkillGroup_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__ActivateSkillGroup_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->skillGroupIndex = skillGroupIndex;
		ptr->activate = activate;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00053CF4 File Offset: 0x00051EF4
	protected void ActivateSkillGroup_Implementation(int skillGroupIndex, bool activate)
	{
		AiController aiController = this.AiController;
		if (((aiController != null) ? aiController.AiSkill : null) != null)
		{
			this.AiController.AiSkill.ActivateSkillGroup(skillGroupIndex, activate);
		}
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00053D1C File Offset: 0x00051F1C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddSkillCd(int skillInfoId, float cdAdd)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddSkillCd"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddSkillCd_Implementation(skillInfoId, cdAdd);
			return;
		}
		TsAiController.__AddSkillCd_FunctionParams* ptr = stackalloc TsAiController.__AddSkillCd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddSkillCd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->skillInfoId = skillInfoId;
		ptr->cdAdd = cdAdd;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00053DB0 File Offset: 0x00051FB0
	protected void AddSkillCd_Implementation(int skillInfoId, float cdAdd)
	{
		AiController aiController = this.AiController;
		if (((aiController != null) ? aiController.AiSkill : null) != null)
		{
			this.AiController.AiSkill.AddSkillCd(skillInfoId, cdAdd);
		}
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x00053DD8 File Offset: 0x00051FD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicApplyBuff(long buffId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AicApplyBuff"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AicApplyBuff_Implementation(buffId);
			return;
		}
		TsAiController.__AicApplyBuff_FunctionParams* ptr = stackalloc TsAiController.__AicApplyBuff_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AicApplyBuff_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->buffId = buffId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00053E64 File Offset: 0x00052064
	protected void AicApplyBuff_Implementation(long buffId)
	{
		CharacterBuffComponent charBuffComp = this.CharBuffComp;
		if (charBuffComp != null && charBuffComp.Valid)
		{
			this.CharBuffComp.AddBuffFromAi(this.AiController.AiCombatMessageId, buffId, new AddBuffParam
			{
				InstigatorId = this.CharBuffComp.CreatureDataId,
				Reason = "AIC蓝图添加buff(AicApplyBuff)"
			});
		}
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00053EC0 File Offset: 0x000520C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicApplyBuffToTarget(int targetId, long buffId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AicApplyBuffToTarget"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AicApplyBuffToTarget_Implementation(targetId, buffId);
			return;
		}
		TsAiController.__AicApplyBuffToTarget_FunctionParams* ptr = stackalloc TsAiController.__AicApplyBuffToTarget_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AicApplyBuffToTarget_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->targetId = targetId;
		ptr->buffId = buffId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00053F54 File Offset: 0x00052154
	protected void AicApplyBuffToTarget_Implementation(int targetId, long buffId)
	{
		BaseBuffComponent component = EntitySystem.Instance.GetComponent<BaseBuffComponent>(targetId);
		if (component != null)
		{
			CharacterBuffComponent charBuffComp = this.CharBuffComp;
			if (charBuffComp != null && charBuffComp.Valid)
			{
				component.AddBuffFromAi(this.AiController.AiCombatMessageId, buffId, new AddBuffParam
				{
					InstigatorId = this.CharBuffComp.CreatureDataId,
					Reason = "AIC蓝图添加buff(AicApplyBuffToTarget)"
				});
			}
		}
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00053FB8 File Offset: 0x000521B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicRemoveBuff(long buffId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AicRemoveBuff"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AicRemoveBuff_Implementation(buffId);
			return;
		}
		TsAiController.__AicRemoveBuff_FunctionParams* ptr = stackalloc TsAiController.__AicRemoveBuff_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AicRemoveBuff_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->buffId = buffId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00054044 File Offset: 0x00052244
	protected void AicRemoveBuff_Implementation(long buffId)
	{
		CharacterBuffComponent charBuffComp = this.CharBuffComp;
		if (charBuffComp != null && charBuffComp.Valid)
		{
			this.CharBuffComp.RemoveBuff(buffId, -1, "AIC蓝图移除buff（AIC Remove Buff）", null, null, null);
		}
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00054094 File Offset: 0x00052294
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicAddTag(FGameplayTag tag)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AicAddTag"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AicAddTag_Implementation(tag);
			return;
		}
		TsAiController.__AicAddTag_FunctionParams* ptr = stackalloc TsAiController.__AicAddTag_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AicAddTag_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->tag = tag;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00054120 File Offset: 0x00052320
	protected void AicAddTag_Implementation(FGameplayTag tag)
	{
		BaseTagComponent charTagComp = this.CharTagComp;
		if (charTagComp != null && charTagComp.Valid)
		{
			this.CharTagComp.AddTag(new int?(tag.TagId()));
		}
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x0005414C File Offset: 0x0005234C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicRemoveTag(FGameplayTag tag)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AicRemoveTag"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AicRemoveTag_Implementation(tag);
			return;
		}
		TsAiController.__AicRemoveTag_FunctionParams* ptr = stackalloc TsAiController.__AicRemoveTag_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AicRemoveTag_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->tag = tag;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x000541D8 File Offset: 0x000523D8
	protected void AicRemoveTag_Implementation(FGameplayTag tag)
	{
		BaseTagComponent charTagComp = this.CharTagComp;
		if (charTagComp != null && charTagComp.Valid)
		{
			this.CharTagComp.RemoveTag(new int?(tag.TagId()));
		}
		CharacterBuffComponent charBuffComp = this.CharBuffComp;
		if (charBuffComp != null && charBuffComp.Valid)
		{
			this.CharBuffComp.RemoveBuffByTag(new int?(tag.TagId()), "AIC蓝图移除buff", null);
		}
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00054248 File Offset: 0x00052448
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetBattleWanderTime(float min, float max)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetBattleWanderTime"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetBattleWanderTime_Implementation(min, max);
			return;
		}
		TsAiController.__SetBattleWanderTime_FunctionParams* ptr = stackalloc TsAiController.__SetBattleWanderTime_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetBattleWanderTime_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->min = min;
		ptr->max = max;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x000542DC File Offset: 0x000524DC
	protected void SetBattleWanderTime_Implementation(float min, float max)
	{
		AiWanderInfos aiWanderInfos = this.AiController.AiWanderInfos;
		if (((aiWanderInfos != null) ? aiWanderInfos.AiBattleWanderGroups : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "没有配置战斗游荡，不能设置战斗游荡时长";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseConfigId", this.AiController.AiBase.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AiController.AiWanderInfos.SetOverrideBattleWanderTime(min, max);
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00054358 File Offset: 0x00052558
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetBattleWanderIndex(int index)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetBattleWanderIndex"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetBattleWanderIndex_Implementation(index);
			return;
		}
		TsAiController.__SetBattleWanderIndex_FunctionParams* ptr = stackalloc TsAiController.__SetBattleWanderIndex_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetBattleWanderIndex_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->index = index;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x000543E4 File Offset: 0x000525E4
	protected unsafe void SetBattleWanderIndex_Implementation(int index)
	{
		AiWanderInfos aiWanderInfos = this.AiController.AiWanderInfos;
		if (((aiWanderInfos != null) ? aiWanderInfos.AiBattleWanderGroups : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "没有配置战斗游荡，不能设置战斗游荡组";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseConfigId", this.AiController.AiBase.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (index < 0 || this.AiController.AiWanderInfos.AiBattleWanderGroups.Count <= index)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.AI;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "设置战斗游荡组不合法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("AiBaseConfigId", this.AiController.AiBase.Value.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TargetIndex", index);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.AiController.AiWanderInfos.CurrentBattleWanderIndex = index;
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x000544F0 File Offset: 0x000526F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddBattleWanderEndTime(float addTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddBattleWanderEndTime"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddBattleWanderEndTime_Implementation(addTime);
			return;
		}
		TsAiController.__AddBattleWanderEndTime_FunctionParams* ptr = stackalloc TsAiController.__AddBattleWanderEndTime_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddBattleWanderEndTime_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->addTime = addTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x0005457C File Offset: 0x0005277C
	protected void AddBattleWanderEndTime_Implementation(float addTime)
	{
		AiWanderInfos aiWanderInfos = this.AiController.AiWanderInfos;
		if (((aiWanderInfos != null) ? aiWanderInfos.AiBattleWanderGroups : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "没有配置战斗游荡，不能增加游荡结束时间";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AiBaseConfigId", this.AiController.AiBase.Value.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.AiController.AiWanderInfos.BattleWanderAddTime += addTime;
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00054600 File Offset: 0x00052800
	[NullableContext(1)]
	private void DrawArrow(global::Vector from, global::Vector to, FLinearColor color)
	{
		to.Subtraction(from, TsAiController.TmpVector);
		double num = TsAiController.TmpVector.Size();
		TsAiController.TmpVector.MultiplyEqual((num - 20.0) / num);
		TsAiController.TmpVector.AdditionEqual(from);
		UKismetSystemLibrary.D_DrawDebugArrow(this, from.ToUeVector(false), TsAiController.TmpVector.ToUeVector(false), 100f, color, 0f, 3f);
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00054674 File Offset: 0x00052874
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiSenseEnable(int index, bool enable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetAiSenseEnable"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetAiSenseEnable_Implementation(index, enable);
			return;
		}
		TsAiController.__SetAiSenseEnable_FunctionParams* ptr = stackalloc TsAiController.__SetAiSenseEnable_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetAiSenseEnable_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->index = index;
		ptr->enable = enable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00054708 File Offset: 0x00052908
	protected void SetAiSenseEnable_Implementation(int index, bool enable)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception == null)
		{
			return;
		}
		aiPerception.SetAiSenseEnable(index, enable);
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00054724 File Offset: 0x00052924
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddOrRemoveAiSense(int aiSenseId, bool add)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddOrRemoveAiSense"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddOrRemoveAiSense_Implementation(aiSenseId, add);
			return;
		}
		TsAiController.__AddOrRemoveAiSense_FunctionParams* ptr = stackalloc TsAiController.__AddOrRemoveAiSense_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddOrRemoveAiSense_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->aiSenseId = aiSenseId;
		ptr->add = add;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x000547B8 File Offset: 0x000529B8
	protected void AddOrRemoveAiSense_Implementation(int aiSenseId, bool add)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception == null)
		{
			return;
		}
		aiPerception.AddOrRemoveAiSense(aiSenseId, add);
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x000547D4 File Offset: 0x000529D4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void EnableAiSenseByType(int type, bool enable)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("EnableAiSenseByType"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.EnableAiSenseByType_Implementation(type, enable);
			return;
		}
		TsAiController.__EnableAiSenseByType_FunctionParams* ptr = stackalloc TsAiController.__EnableAiSenseByType_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__EnableAiSenseByType_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->type = type;
		ptr->enable = enable;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00054868 File Offset: 0x00052A68
	protected void EnableAiSenseByType_Implementation(int type, bool enable)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception == null)
		{
			return;
		}
		aiPerception.EnableAiSenseByType(type, enable);
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00054884 File Offset: 0x00052A84
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiHateConfig(string configId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetAiHateConfig"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetAiHateConfig_Implementation(configId);
			return;
		}
		TsAiController.__SetAiHateConfig_FunctionParams* ptr = stackalloc TsAiController.__SetAiHateConfig_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetAiHateConfig_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->configId), configId);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00054918 File Offset: 0x00052B18
	[NullableContext(1)]
	protected void SetAiHateConfig_Implementation(string configId)
	{
		if (!string.IsNullOrEmpty(configId))
		{
			this.AiController.AiHateList.AiHate = AiConfig.Instance.LoadAiHate(int.Parse(configId));
			return;
		}
		this.AiController.AiHateList.AiHate = AiConfig.Instance.LoadAiHateByController(this.AiController, null, null);
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00054980 File Offset: 0x00052B80
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeHatred(int entityId, float rate, float abs)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ChangeHatred"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.ChangeHatred_Implementation(entityId, rate, abs);
			return;
		}
		TsAiController.__ChangeHatred_FunctionParams* ptr = stackalloc TsAiController.__ChangeHatred_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__ChangeHatred_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		ptr->rate = rate;
		ptr->abs = abs;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00054A1C File Offset: 0x00052C1C
	protected void ChangeHatred_Implementation(int entityId, float rate, float abs)
	{
		this.AiController.AiHateList.ChangeHatred(entityId, rate, abs);
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00054A34 File Offset: 0x00052C34
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ClearHatred(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ClearHatred"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.ClearHatred_Implementation(entityId);
			return;
		}
		TsAiController.__ClearHatred_FunctionParams* ptr = stackalloc TsAiController.__ClearHatred_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__ClearHatred_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00054AC0 File Offset: 0x00052CC0
	protected void ClearHatred_Implementation(int entityId)
	{
		this.AiController.AiHateList.ClearHatred(entityId);
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00054AD4 File Offset: 0x00052CD4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void BindPlayerDamageEvents()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("BindPlayerDamageEvents"), TsAiController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.BindPlayerDamageEvents_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00054B2D File Offset: 0x00052D2D
	protected void BindPlayerDamageEvents_Implementation()
	{
		this.AiController.AiHateList.BindPlayerDamageEvents();
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00054B40 File Offset: 0x00052D40
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAlertEventBinder(UKuroBooleanEventBinder eventBinder)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("AddAlertEventBinder"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.AddAlertEventBinder_Implementation(eventBinder);
			return;
		}
		TsAiController.__AddAlertEventBinder_FunctionParams* ptr = stackalloc TsAiController.__AddAlertEventBinder_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__AddAlertEventBinder_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00054BDA File Offset: 0x00052DDA
	[NullableContext(1)]
	protected void AddAlertEventBinder_Implementation(UKuroBooleanEventBinder eventBinder)
	{
		this.AiController.AiAlert.CallbackEvent = eventBinder;
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00054BF0 File Offset: 0x00052DF0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiAlertConfig(string configId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetAiAlertConfig"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetAiAlertConfig_Implementation(configId);
			return;
		}
		TsAiController.__SetAiAlertConfig_FunctionParams* ptr = stackalloc TsAiController.__SetAiAlertConfig_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetAiAlertConfig_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->configId), configId);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x00054C84 File Offset: 0x00052E84
	[NullableContext(1)]
	protected void SetAiAlertConfig_Implementation(string configId)
	{
		if (!string.IsNullOrEmpty(configId))
		{
			this.AiController.AiAlert.AiAlertConfig = AiConfig.Instance.LoadAiAlert(configId);
			return;
		}
		this.AiController.AiAlert.AiAlertConfig = AiConfig.Instance.LoadAiAlert(this.AiController.AiBase.Value.GetSubBehaviorConfigs("AiAlert"));
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00054CEC File Offset: 0x00052EEC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiEnable(bool enable, string key)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetAiEnable"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetAiEnable_Implementation(enable, key);
			return;
		}
		TsAiController.__SetAiEnable_FunctionParams* ptr = stackalloc TsAiController.__SetAiEnable_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetAiEnable_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->enable = enable;
		FString.CopyFrom((void*)(&ptr->key), key);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x00054D88 File Offset: 0x00052F88
	[NullableContext(1)]
	protected void SetAiEnable_Implementation(bool enable, string key)
	{
		string key2 = "TsAiController_" + key;
		if (enable)
		{
			this.CharAiDesignComp.EnableAi(key2);
			return;
		}
		this.CharAiDesignComp.DisableAi(key2);
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x00054DC0 File Offset: 0x00052FC0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void TestChangeAi(string id)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TestChangeAi"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.TestChangeAi_Implementation(id);
			return;
		}
		TsAiController.__TestChangeAi_FunctionParams* ptr = stackalloc TsAiController.__TestChangeAi_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__TestChangeAi_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->id), id);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00054E52 File Offset: 0x00053052
	[NullableContext(1)]
	protected void TestChangeAi_Implementation(string id)
	{
		this.CharAiDesignComp.LoadAiConfigs(int.Parse(id));
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00054E68 File Offset: 0x00053068
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void LogReport(int logId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("LogReport"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.LogReport_Implementation(logId);
			return;
		}
		TsAiController.__LogReport_FunctionParams* ptr = stackalloc TsAiController.__LogReport_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__LogReport_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->logId = logId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x00054EF4 File Offset: 0x000530F4
	protected void LogReport_Implementation(int logId)
	{
		Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJC, "埋点废弃,请删除相关配置", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x00054F1C File Offset: 0x0005311C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool 逻辑主控()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("逻辑主控"), TsAiController.StaticClass(), out intPtr, out num))
		{
			return this.逻辑主控_Implementation();
		}
		TsAiController.__逻辑主控_FunctionParams* ptr = stackalloc TsAiController.__逻辑主控_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__逻辑主控_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00054FA6 File Offset: 0x000531A6
	protected bool 逻辑主控_Implementation()
	{
		return this.AiController.CharActorComp.IsAutonomousProxy;
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00054FB8 File Offset: 0x000531B8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool 移动主控()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("移动主控"), TsAiController.StaticClass(), out intPtr, out num))
		{
			return this.移动主控_Implementation();
		}
		TsAiController.__移动主控_FunctionParams* ptr = stackalloc TsAiController.__移动主控_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__移动主控_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00055042 File Offset: 0x00053242
	protected bool 移动主控_Implementation()
	{
		return this.AiController.CharActorComp.IsMoveAutonomousProxy;
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00055054 File Offset: 0x00053254
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool 检查状态机状态(ref TArray<string> states)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("检查状态机状态"), TsAiController.StaticClass(), out intPtr, out num))
		{
			return this.检查状态机状态_Implementation(ref states);
		}
		TsAiController.__检查状态机状态_FunctionParams* ptr = stackalloc TsAiController.__检查状态机状态_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__检查状态机状态_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		TArray<string> tarray = states;
		if (tarray != null)
		{
			tarray.CopyTo(&ptr->states, default(UScriptStructStackOnlyPtr));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		states = new TArray<string>(&ptr->states, true, true);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x0005510C File Offset: 0x0005330C
	[NullableContext(1)]
	protected bool 检查状态机状态_Implementation(ref TArray<string> states)
	{
		return false;
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00055110 File Offset: 0x00053310
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换状态机状态(ref TArray<string> states)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("切换状态机状态"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.切换状态机状态_Implementation(ref states);
			return;
		}
		TsAiController.__切换状态机状态_FunctionParams* ptr = stackalloc TsAiController.__切换状态机状态_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__切换状态机状态_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		TArray<string> tarray = states;
		if (tarray != null)
		{
			tarray.CopyTo(&ptr->states, default(UScriptStructStackOnlyPtr));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		states = new TArray<string>(&ptr->states, true, true);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x000551C2 File Offset: 0x000533C2
	[NullableContext(1)]
	protected void 切换状态机状态_Implementation(ref TArray<string> states)
	{
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x000551C4 File Offset: 0x000533C4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool GetCoolDownDone(int id)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetCoolDownDone"), TsAiController.StaticClass(), out intPtr, out num))
		{
			return this.GetCoolDownDone_Implementation(id);
		}
		TsAiController.__GetCoolDownDone_FunctionParams* ptr = stackalloc TsAiController.__GetCoolDownDone_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__GetCoolDownDone_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->id = id;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x00055256 File Offset: 0x00053456
	protected bool GetCoolDownDone_Implementation(int id)
	{
		return this.AiController.GetCoolDownRemainTime(id) == 0.0;
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00055270 File Offset: 0x00053470
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetCoolDownRemainTime(int id)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetCoolDownRemainTime"), TsAiController.StaticClass(), out intPtr, out num))
		{
			return this.GetCoolDownRemainTime_Implementation(id);
		}
		TsAiController.__GetCoolDownRemainTime_FunctionParams* ptr = stackalloc TsAiController.__GetCoolDownRemainTime_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__GetCoolDownRemainTime_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->id = id;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00055302 File Offset: 0x00053502
	protected float GetCoolDownRemainTime_Implementation(int id)
	{
		return (float)this.AiController.GetCoolDownRemainTime(id);
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x00055314 File Offset: 0x00053514
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCoolDown(int id, float cd)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetCoolDown"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.SetCoolDown_Implementation(id, cd);
			return;
		}
		TsAiController.__SetCoolDown_FunctionParams* ptr = stackalloc TsAiController.__SetCoolDown_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__SetCoolDown_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->id = id;
		ptr->cd = cd;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x000553A8 File Offset: 0x000535A8
	protected void SetCoolDown_Implementation(int id, float cd)
	{
		double num = GameModeModel.Instance.IsMulti ? Time.Instance.ServerTimeStamp : Time.Instance.WorldTime;
		this.AiController.SetCoolDownTime(id, num + (double)cd, true, "蓝图");
	}

	// Token: 0x06000E9C RID: 3740 RVA: 0x000553F0 File Offset: 0x000535F0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InitCooldownEvent(int id, UKuroBooleanEventBinder eventBinder)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitCooldownEvent"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.InitCooldownEvent_Implementation(id, eventBinder);
			return;
		}
		TsAiController.__InitCooldownEvent_FunctionParams* ptr = stackalloc TsAiController.__InitCooldownEvent_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__InitCooldownEvent_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->id = id;
		*(&ptr->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00055492 File Offset: 0x00053692
	[NullableContext(1)]
	protected void InitCooldownEvent_Implementation(int id, UKuroBooleanEventBinder eventBinder)
	{
		this.AiController.InitCooldownTimer(id, eventBinder);
	}

	// Token: 0x06000E9E RID: 3742 RVA: 0x000554A4 File Offset: 0x000536A4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StartCooldownTimer(int id, float duration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("StartCooldownTimer"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.StartCooldownTimer_Implementation(id, duration);
			return;
		}
		TsAiController.__StartCooldownTimer_FunctionParams* ptr = stackalloc TsAiController.__StartCooldownTimer_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__StartCooldownTimer_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->id = id;
		ptr->duration = duration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00055538 File Offset: 0x00053738
	protected void StartCooldownTimer_Implementation(int id, float duration)
	{
		double num = GameModeModel.Instance.IsMulti ? Time.Instance.ServerTimeStamp : Time.Instance.WorldTime;
		this.AiController.SetCoolDownTime(id, num + (double)duration, true, "蓝图AIC延迟节点");
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00055580 File Offset: 0x00053780
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GetDebugStateMachine(ref TArray<FText> output)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugStateMachine"), TsAiController.StaticClass(), out intPtr, out num))
		{
			this.GetDebugStateMachine_Implementation(ref output);
			return;
		}
		TsAiController.__GetDebugStateMachine_FunctionParams* ptr = stackalloc TsAiController.__GetDebugStateMachine_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__GetDebugStateMachine_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		TArray<FText> tarray = output;
		if (tarray != null)
		{
			tarray.CopyTo(&ptr->output, default(UScriptStructStackOnlyPtr));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		output = new TArray<FText>(&ptr->output, true, true);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00055634 File Offset: 0x00053834
	[NullableContext(1)]
	protected void GetDebugStateMachine_Implementation(ref TArray<FText> output)
	{
		CharacterStateMachineNewComponent charStateMachineComp = this.CharStateMachineComp;
		if (charStateMachineComp != null)
		{
			AiStateMachineGroup stateMachineGroup = charStateMachineComp.StateMachineGroup;
			if (stateMachineGroup != null)
			{
				stateMachineGroup.RequestServerDebugInfo();
			}
		}
		CharacterStateMachineNewComponent charStateMachineComp2 = this.CharStateMachineComp;
		string[] array;
		if (charStateMachineComp2 == null)
		{
			array = null;
		}
		else
		{
			AiStateMachineGroup stateMachineGroup2 = charStateMachineComp2.StateMachineGroup;
			array = ((stateMachineGroup2 != null) ? stateMachineGroup2.ToString(false, false) : null);
		}
		string[] array2 = array;
		if (array2 != null)
		{
			foreach (string text in array2)
			{
				output.Add(text.ToString());
			}
		}
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x000556A8 File Offset: 0x000538A8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual FText GetDebugText()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugText"), TsAiController.StaticClass(), out intPtr, out num))
		{
			return this.GetDebugText_Implementation();
		}
		TsAiController.__GetDebugText_FunctionParams* ptr = stackalloc TsAiController.__GetDebugText_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsAiController.__GetDebugText_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		FText result = new FText(&ptr->__Result, true, true);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x0005573C File Offset: 0x0005393C
	[NullableContext(1)]
	protected FText GetDebugText_Implementation()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(83, 12);
		defaultInterpolatedStringHandler.AppendLiteral("激活的技能组：\n ");
		defaultInterpolatedStringHandler.AppendFormatted(JsonSerializer.Serialize<HashSet<int>>(this.AiController.AiSkill.ActiveSkillGroup, null));
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("技能CD：");
		defaultInterpolatedStringHandler.AppendFormatted(this.AiController.AiSkill.GetCdDebugString());
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("战斗游荡组：");
		AiWanderInfos aiWanderInfos = this.AiController.AiWanderInfos;
		defaultInterpolatedStringHandler.AppendFormatted<int?>((aiWanderInfos != null) ? new int?(aiWanderInfos.CurrentBattleWanderIndex) : null);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("仇恨：\n");
		defaultInterpolatedStringHandler.AppendFormatted(this.AiController.AiHateList.GetHatredMapDebugText());
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("团队AI：\n");
		defaultInterpolatedStringHandler.AppendLiteral("逻辑主控：");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.AiController.CharActorComp.IsAutonomousProxy);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("移动主控：");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.AiController.CharActorComp.IsMoveAutonomousProxy);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("等待切换主控：");
		defaultInterpolatedStringHandler.AppendFormatted<bool>(this.AiController.IsWaitingSwitchControl());
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("感知：");
		IAiPerception aiPerception = this.AiController.AiPerception;
		defaultInterpolatedStringHandler.AppendFormatted((aiPerception != null) ? aiPerception.GetEnableAiSenseDebug() : null);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("怪物仇恨组： ");
		defaultInterpolatedStringHandler.AppendFormatted<long?>(this.AiController.HatredGroupId);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("部位血量: ");
		CharacterBuffComponent charBuffComp = this.CharBuffComp;
		string value;
		if (charBuffComp == null)
		{
			value = null;
		}
		else
		{
			Entity entity = charBuffComp.Entity;
			if (entity == null)
			{
				value = null;
			}
			else
			{
				CharacterPartComponent component = entity.GetComponent<CharacterPartComponent>();
				value = ((component != null) ? component.GetDebugText() : null);
			}
		}
		defaultInterpolatedStringHandler.AppendFormatted(value);
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("集群Id：");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.AiController.GetTeamLevelId());
		defaultInterpolatedStringHandler.AppendLiteral("\n");
		defaultInterpolatedStringHandler.AppendLiteral("阵营: ");
		Entity entity2 = this.GetEntity();
		ECamp? value2;
		if (entity2 == null)
		{
			value2 = null;
		}
		else
		{
			CreatureDataComponent component2 = entity2.GetComponent<CreatureDataComponent>();
			value2 = ((component2 != null) ? new ECamp?(component2.GetEntityCamp()) : null);
		}
		defaultInterpolatedStringHandler.AppendFormatted<ECamp?>(value2);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x000559E4 File Offset: 0x00053BE4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public override void ReceiveDestroyed()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsAiController) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveDestroyed"), TsAiController.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.ReceiveDestroyed_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00055A3D File Offset: 0x00053C3D
	protected virtual void ReceiveDestroyed_Implementation()
	{
		if (!ObjectUtils.IsValid(this))
		{
			return;
		}
		this.Clear();
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00055A4E File Offset: 0x00053C4E
	public void Clear()
	{
		this.CharAiDesignComp = null;
		this.CharBuffComp = null;
		this.CharTagComp = null;
		this.AiController = null;
		this.BehaviorTree = null;
		this.CharStateMachineComp = null;
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00055A7A File Offset: 0x00053C7A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAiController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/Controller/TsAiController.TsAiController_C");
		}
		return TsAiController._ClassPtr;
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00055AA0 File Offset: 0x00053CA0
	public TsAiController() : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00055AC8 File Offset: 0x00053CC8
	[NullableContext(1)]
	public TsAiController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00055AFB File Offset: 0x00053CFB
	protected TsAiController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00055B04 File Offset: 0x00053D04
	protected virtual void __CPPCALL_OnStart_Implementation()
	{
		this.OnStart_Implementation();
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00055B0C File Offset: 0x00053D0C
	protected virtual void __CPPCALL_获取控制权时_Implementation()
	{
		this.获取控制权时_Implementation();
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00055B14 File Offset: 0x00053D14
	protected unsafe virtual void __CPPCALL_状态切换时_Implementation(TsAiController.__状态切换时_FunctionParams* __Params)
	{
		ECharacterState oldState = (ECharacterState)__Params->oldState;
		ECharacterState newState = (ECharacterState)__Params->newState;
		this.状态切换时_Implementation(oldState, newState, __Params->isAutonomousProxy);
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00055B3D File Offset: 0x00053D3D
	protected unsafe virtual void __CPPCALL_渲染状态改变时_Implementation(TsAiController.__渲染状态改变时_FunctionParams* __Params)
	{
		this.渲染状态改变时_Implementation(__Params->wasRendered);
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00055B4C File Offset: 0x00053D4C
	protected unsafe virtual void __CPPCALL_AddComplicatedEventBinder_Implementation(TsAiController.__AddComplicatedEventBinder_FunctionParams* __Params)
	{
		SAiConditions conditions = new SAiConditions(&__Params->conditions, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.AddComplicatedEventBinder_Implementation(conditions, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00055B7C File Offset: 0x00053D7C
	protected unsafe virtual void __CPPCALL_AddSceneItemDestroyEventBinder_Implementation(TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams* __Params)
	{
		UKuroActorEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroActorEventBinder>(__Params->eventBinder);
		this.AddSceneItemDestroyEventBinder_Implementation(__Params->distance, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00055BA4 File Offset: 0x00053DA4
	protected unsafe virtual void __CPPCALL_AddLevelVarBoolEventBinder_Implementation(TsAiController.__AddLevelVarBoolEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.AddLevelVarBoolEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00055BD4 File Offset: 0x00053DD4
	protected unsafe virtual void __CPPCALL_AddLevelVarIntEventBinder_Implementation(TsAiController.__AddLevelVarIntEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroIntEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroIntEventBinder>(__Params->eventBinder);
		this.AddLevelVarIntEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00055C04 File Offset: 0x00053E04
	protected unsafe virtual void __CPPCALL_AddHateEventBinder_Implementation(TsAiController.__AddHateEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		this.AddHateEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00055C24 File Offset: 0x00053E24
	protected unsafe virtual void __CPPCALL_AddPerceptionEventBinder_Implementation(TsAiController.__AddPerceptionEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		this.AddPerceptionEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00055C44 File Offset: 0x00053E44
	protected unsafe virtual void __CPPCALL_SetPerceptionEventState_Implementation(TsAiController.__SetPerceptionEventState_FunctionParams* __Params)
	{
		this.SetPerceptionEventState_Implementation(__Params->includeFriend, __Params->includeEnemy, __Params->includeNeutral);
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00055C60 File Offset: 0x00053E60
	protected unsafe virtual void __CPPCALL_AddHateOutRangeEventBinder_Implementation(TsAiController.__AddHateOutRangeEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		this.AddHateOutRangeEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00055C80 File Offset: 0x00053E80
	protected unsafe virtual void __CPPCALL_ActivateSkillGroup_Implementation(TsAiController.__ActivateSkillGroup_FunctionParams* __Params)
	{
		this.ActivateSkillGroup_Implementation(__Params->skillGroupIndex, __Params->activate);
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00055C94 File Offset: 0x00053E94
	protected unsafe virtual void __CPPCALL_AddSkillCd_Implementation(TsAiController.__AddSkillCd_FunctionParams* __Params)
	{
		this.AddSkillCd_Implementation(__Params->skillInfoId, __Params->cdAdd);
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00055CA8 File Offset: 0x00053EA8
	protected unsafe virtual void __CPPCALL_AicApplyBuff_Implementation(TsAiController.__AicApplyBuff_FunctionParams* __Params)
	{
		this.AicApplyBuff_Implementation(__Params->buffId);
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00055CB6 File Offset: 0x00053EB6
	protected unsafe virtual void __CPPCALL_AicApplyBuffToTarget_Implementation(TsAiController.__AicApplyBuffToTarget_FunctionParams* __Params)
	{
		this.AicApplyBuffToTarget_Implementation(__Params->targetId, __Params->buffId);
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00055CCA File Offset: 0x00053ECA
	protected unsafe virtual void __CPPCALL_AicRemoveBuff_Implementation(TsAiController.__AicRemoveBuff_FunctionParams* __Params)
	{
		this.AicRemoveBuff_Implementation(__Params->buffId);
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00055CD8 File Offset: 0x00053ED8
	protected unsafe virtual void __CPPCALL_AicAddTag_Implementation(TsAiController.__AicAddTag_FunctionParams* __Params)
	{
		this.AicAddTag_Implementation(__Params->tag);
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00055CE6 File Offset: 0x00053EE6
	protected unsafe virtual void __CPPCALL_AicRemoveTag_Implementation(TsAiController.__AicRemoveTag_FunctionParams* __Params)
	{
		this.AicRemoveTag_Implementation(__Params->tag);
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00055CF4 File Offset: 0x00053EF4
	protected unsafe virtual void __CPPCALL_SetBattleWanderTime_Implementation(TsAiController.__SetBattleWanderTime_FunctionParams* __Params)
	{
		this.SetBattleWanderTime_Implementation(__Params->min, __Params->max);
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00055D08 File Offset: 0x00053F08
	protected unsafe virtual void __CPPCALL_SetBattleWanderIndex_Implementation(TsAiController.__SetBattleWanderIndex_FunctionParams* __Params)
	{
		this.SetBattleWanderIndex_Implementation(__Params->index);
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00055D16 File Offset: 0x00053F16
	protected unsafe virtual void __CPPCALL_AddBattleWanderEndTime_Implementation(TsAiController.__AddBattleWanderEndTime_FunctionParams* __Params)
	{
		this.AddBattleWanderEndTime_Implementation(__Params->addTime);
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00055D24 File Offset: 0x00053F24
	protected unsafe virtual void __CPPCALL_SetAiSenseEnable_Implementation(TsAiController.__SetAiSenseEnable_FunctionParams* __Params)
	{
		this.SetAiSenseEnable_Implementation(__Params->index, __Params->enable);
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00055D38 File Offset: 0x00053F38
	protected unsafe virtual void __CPPCALL_AddOrRemoveAiSense_Implementation(TsAiController.__AddOrRemoveAiSense_FunctionParams* __Params)
	{
		this.AddOrRemoveAiSense_Implementation(__Params->aiSenseId, __Params->add);
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00055D4C File Offset: 0x00053F4C
	protected unsafe virtual void __CPPCALL_EnableAiSenseByType_Implementation(TsAiController.__EnableAiSenseByType_FunctionParams* __Params)
	{
		this.EnableAiSenseByType_Implementation(__Params->type, __Params->enable);
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00055D60 File Offset: 0x00053F60
	protected unsafe virtual void __CPPCALL_SetAiHateConfig_Implementation(TsAiController.__SetAiHateConfig_FunctionParams* __Params)
	{
		string aiHateConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		this.SetAiHateConfig_Implementation(aiHateConfig_Implementation);
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00055D81 File Offset: 0x00053F81
	protected unsafe virtual void __CPPCALL_ChangeHatred_Implementation(TsAiController.__ChangeHatred_FunctionParams* __Params)
	{
		this.ChangeHatred_Implementation(__Params->entityId, __Params->rate, __Params->abs);
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00055D9B File Offset: 0x00053F9B
	protected unsafe virtual void __CPPCALL_ClearHatred_Implementation(TsAiController.__ClearHatred_FunctionParams* __Params)
	{
		this.ClearHatred_Implementation(__Params->entityId);
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00055DA9 File Offset: 0x00053FA9
	protected virtual void __CPPCALL_BindPlayerDamageEvents_Implementation()
	{
		this.BindPlayerDamageEvents_Implementation();
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00055DB4 File Offset: 0x00053FB4
	protected unsafe virtual void __CPPCALL_AddAlertEventBinder_Implementation(TsAiController.__AddAlertEventBinder_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.AddAlertEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00055DD4 File Offset: 0x00053FD4
	protected unsafe virtual void __CPPCALL_SetAiAlertConfig_Implementation(TsAiController.__SetAiAlertConfig_FunctionParams* __Params)
	{
		string aiAlertConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		this.SetAiAlertConfig_Implementation(aiAlertConfig_Implementation);
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00055DF8 File Offset: 0x00053FF8
	protected unsafe virtual void __CPPCALL_SetAiEnable_Implementation(TsAiController.__SetAiEnable_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		this.SetAiEnable_Implementation(__Params->enable, key);
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00055E20 File Offset: 0x00054020
	protected unsafe virtual void __CPPCALL_TestChangeAi_Implementation(TsAiController.__TestChangeAi_FunctionParams* __Params)
	{
		string id = FString.ToString((void*)(&__Params->id));
		this.TestChangeAi_Implementation(id);
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00055E41 File Offset: 0x00054041
	protected unsafe virtual void __CPPCALL_LogReport_Implementation(TsAiController.__LogReport_FunctionParams* __Params)
	{
		this.LogReport_Implementation(__Params->logId);
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00055E4F File Offset: 0x0005404F
	protected unsafe virtual void __CPPCALL_逻辑主控_Implementation(TsAiController.__逻辑主控_FunctionParams* __Params)
	{
		__Params->__Result = this.逻辑主控_Implementation();
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00055E5D File Offset: 0x0005405D
	protected unsafe virtual void __CPPCALL_移动主控_Implementation(TsAiController.__移动主控_FunctionParams* __Params)
	{
		__Params->__Result = this.移动主控_Implementation();
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00055E6C File Offset: 0x0005406C
	protected unsafe virtual void __CPPCALL_检查状态机状态_Implementation(TsAiController.__检查状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		__Params->__Result = this.检查状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00055EB0 File Offset: 0x000540B0
	protected unsafe virtual void __CPPCALL_切换状态机状态_Implementation(TsAiController.__切换状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		this.切换状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00055EED File Offset: 0x000540ED
	protected unsafe virtual void __CPPCALL_GetCoolDownDone_Implementation(TsAiController.__GetCoolDownDone_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCoolDownDone_Implementation(__Params->id);
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x00055F01 File Offset: 0x00054101
	protected unsafe virtual void __CPPCALL_GetCoolDownRemainTime_Implementation(TsAiController.__GetCoolDownRemainTime_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCoolDownRemainTime_Implementation(__Params->id);
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x00055F15 File Offset: 0x00054115
	protected unsafe virtual void __CPPCALL_SetCoolDown_Implementation(TsAiController.__SetCoolDown_FunctionParams* __Params)
	{
		this.SetCoolDown_Implementation(__Params->id, __Params->cd);
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00055F2C File Offset: 0x0005412C
	protected unsafe virtual void __CPPCALL_InitCooldownEvent_Implementation(TsAiController.__InitCooldownEvent_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.InitCooldownEvent_Implementation(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00055F52 File Offset: 0x00054152
	protected unsafe virtual void __CPPCALL_StartCooldownTimer_Implementation(TsAiController.__StartCooldownTimer_FunctionParams* __Params)
	{
		this.StartCooldownTimer_Implementation(__Params->id, __Params->duration);
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00055F68 File Offset: 0x00054168
	protected unsafe virtual void __CPPCALL_GetDebugStateMachine_Implementation(TsAiController.__GetDebugStateMachine_FunctionParams* __Params)
	{
		TArray<FText> tarray = new TArray<FText>(&__Params->output, true, true);
		this.GetDebugStateMachine_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->output, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00055FA5 File Offset: 0x000541A5
	protected unsafe virtual void __CPPCALL_GetDebugText_Implementation(TsAiController.__GetDebugText_FunctionParams* __Params)
	{
		void* dest = (void*)(&__Params->__Result);
		FText debugText_Implementation = this.GetDebugText_Implementation();
		FText.NativeCopy(dest, (debugText_Implementation != null) ? debugText_Implementation.NativePtr : null, 1);
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00055FC7 File Offset: 0x000541C7
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x04000BA8 RID: 2984
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x04000BA9 RID: 2985
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x04000BAA RID: 2986
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector3 = global::Vector.Create();

	// Token: 0x04000BAB RID: 2987
	[Nullable(2)]
	private CharacterAiComponent CharAiDesignComp;

	// Token: 0x04000BAC RID: 2988
	[Nullable(2)]
	private BaseTagComponent CharTagComp;

	// Token: 0x04000BAD RID: 2989
	[Nullable(2)]
	private CharacterBuffComponent CharBuffComp;

	// Token: 0x04000BAE RID: 2990
	[Nullable(2)]
	private CharacterStateMachineNewComponent CharStateMachineComp;

	// Token: 0x04000BAF RID: 2991
	[Nullable(2)]
	public AiController AiController;

	// Token: 0x04000BB0 RID: 2992
	private const float DRAW_ARROW_SIZE = 100f;

	// Token: 0x04000BB1 RID: 2993
	private const float DRAW_LINE_THICKNESS = 3f;

	// Token: 0x04000BB2 RID: 2994
	private const float ARROW_LENGTH_SUB = 20f;

	// Token: 0x04000BB3 RID: 2995
	private const int DEFAULT_SEGMENTS = 24;

	// Token: 0x04000BB4 RID: 2996
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor initLocationColor = new FLinearColor(0.5f, 0.5f, 0.5f, 1f);

	// Token: 0x04000BB5 RID: 2997
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor targetLinkColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000BB6 RID: 2998
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor teamMemberLinkColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000BB7 RID: 2999
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor allyLinkColor = new FLinearColor(0.6f, 1f, 0.6f, 1f);

	// Token: 0x04000BB8 RID: 3000
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor neutralLinkColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x04000BB9 RID: 3001
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor enemyLinkColor = new FLinearColor(1f, 0f, 1f, 1f);

	// Token: 0x04000BBA RID: 3002
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor areaCenterColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x04000BBB RID: 3003
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor minHateAreaColor = new FLinearColor(1f, 0f, 1f, 1f);

	// Token: 0x04000BBC RID: 3004
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor maxHateAreaColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x04000BBD RID: 3005
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor minHateInitAreaColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000BBE RID: 3006
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor maxHateInitAreaColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000BBF RID: 3007
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat StatSetAiHateConfig = Stat.Create("SetAiHateConfig", "", "");

	// Token: 0x04000BC0 RID: 3008
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/Controller/TsAiController.TsAiController_C";

	// Token: 0x04000BC1 RID: 3009
	private static IntPtr _ClassPtr;

	// Token: 0x04000BC2 RID: 3010
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000BC3 RID: 3011
	private static int __PropertyOffset_BehaviorTree;

	// Token: 0x04000BC4 RID: 3012
	private static int __PropertyOffset_StateMachineGroup;

	// Token: 0x02006511 RID: 25873
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __状态切换时_FunctionParams
	{
		// Token: 0x0402191B RID: 137499
		[FieldOffset(0)]
		public byte oldState;

		// Token: 0x0402191C RID: 137500
		[FieldOffset(1)]
		public byte newState;

		// Token: 0x0402191D RID: 137501
		[FieldOffset(2)]
		public bool isAutonomousProxy;
	}

	// Token: 0x02006512 RID: 25874
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __渲染状态改变时_FunctionParams
	{
		// Token: 0x0402191E RID: 137502
		[FieldOffset(0)]
		public bool wasRendered;
	}

	// Token: 0x02006513 RID: 25875
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 192)]
	protected ref struct __AddComplicatedEventBinder_FunctionParams
	{
		// Token: 0x0402191F RID: 137503
		[FieldOffset(0)]
		public byte conditions;

		// Token: 0x04021920 RID: 137504
		[FieldOffset(184)]
		public IntPtr eventBinder;
	}

	// Token: 0x02006514 RID: 25876
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddSceneItemDestroyEventBinder_FunctionParams
	{
		// Token: 0x04021921 RID: 137505
		[FieldOffset(0)]
		public float distance;

		// Token: 0x04021922 RID: 137506
		[FieldOffset(8)]
		public IntPtr eventBinder;
	}

	// Token: 0x02006515 RID: 25877
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AddLevelVarBoolEventBinder_FunctionParams
	{
		// Token: 0x04021923 RID: 137507
		[FieldOffset(0)]
		public byte levelVar;

		// Token: 0x04021924 RID: 137508
		[FieldOffset(32)]
		public IntPtr eventBinder;
	}

	// Token: 0x02006516 RID: 25878
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AddLevelVarIntEventBinder_FunctionParams
	{
		// Token: 0x04021925 RID: 137509
		[FieldOffset(0)]
		public byte levelVar;

		// Token: 0x04021926 RID: 137510
		[FieldOffset(32)]
		public IntPtr eventBinder;
	}

	// Token: 0x02006517 RID: 25879
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddHateEventBinder_FunctionParams
	{
		// Token: 0x04021927 RID: 137511
		[FieldOffset(0)]
		public IntPtr handler;
	}

	// Token: 0x02006518 RID: 25880
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddPerceptionEventBinder_FunctionParams
	{
		// Token: 0x04021928 RID: 137512
		[FieldOffset(0)]
		public IntPtr handler;
	}

	// Token: 0x02006519 RID: 25881
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __SetPerceptionEventState_FunctionParams
	{
		// Token: 0x04021929 RID: 137513
		[FieldOffset(0)]
		public bool includeFriend;

		// Token: 0x0402192A RID: 137514
		[FieldOffset(1)]
		public bool includeEnemy;

		// Token: 0x0402192B RID: 137515
		[FieldOffset(2)]
		public bool includeNeutral;
	}

	// Token: 0x0200651A RID: 25882
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddHateOutRangeEventBinder_FunctionParams
	{
		// Token: 0x0402192C RID: 137516
		[FieldOffset(0)]
		public IntPtr handler;
	}

	// Token: 0x0200651B RID: 25883
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ActivateSkillGroup_FunctionParams
	{
		// Token: 0x0402192D RID: 137517
		[FieldOffset(0)]
		public int skillGroupIndex;

		// Token: 0x0402192E RID: 137518
		[FieldOffset(4)]
		public bool activate;
	}

	// Token: 0x0200651C RID: 25884
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddSkillCd_FunctionParams
	{
		// Token: 0x0402192F RID: 137519
		[FieldOffset(0)]
		public int skillInfoId;

		// Token: 0x04021930 RID: 137520
		[FieldOffset(4)]
		public float cdAdd;
	}

	// Token: 0x0200651D RID: 25885
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AicApplyBuff_FunctionParams
	{
		// Token: 0x04021931 RID: 137521
		[FieldOffset(0)]
		public long buffId;
	}

	// Token: 0x0200651E RID: 25886
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AicApplyBuffToTarget_FunctionParams
	{
		// Token: 0x04021932 RID: 137522
		[FieldOffset(0)]
		public int targetId;

		// Token: 0x04021933 RID: 137523
		[FieldOffset(8)]
		public long buffId;
	}

	// Token: 0x0200651F RID: 25887
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AicRemoveBuff_FunctionParams
	{
		// Token: 0x04021934 RID: 137524
		[FieldOffset(0)]
		public long buffId;
	}

	// Token: 0x02006520 RID: 25888
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AicAddTag_FunctionParams
	{
		// Token: 0x04021935 RID: 137525
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x02006521 RID: 25889
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AicRemoveTag_FunctionParams
	{
		// Token: 0x04021936 RID: 137526
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x02006522 RID: 25890
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetBattleWanderTime_FunctionParams
	{
		// Token: 0x04021937 RID: 137527
		[FieldOffset(0)]
		public float min;

		// Token: 0x04021938 RID: 137528
		[FieldOffset(4)]
		public float max;
	}

	// Token: 0x02006523 RID: 25891
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetBattleWanderIndex_FunctionParams
	{
		// Token: 0x04021939 RID: 137529
		[FieldOffset(0)]
		public int index;
	}

	// Token: 0x02006524 RID: 25892
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __AddBattleWanderEndTime_FunctionParams
	{
		// Token: 0x0402193A RID: 137530
		[FieldOffset(0)]
		public float addTime;
	}

	// Token: 0x02006525 RID: 25893
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetAiSenseEnable_FunctionParams
	{
		// Token: 0x0402193B RID: 137531
		[FieldOffset(0)]
		public int index;

		// Token: 0x0402193C RID: 137532
		[FieldOffset(4)]
		public bool enable;
	}

	// Token: 0x02006526 RID: 25894
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddOrRemoveAiSense_FunctionParams
	{
		// Token: 0x0402193D RID: 137533
		[FieldOffset(0)]
		public int aiSenseId;

		// Token: 0x0402193E RID: 137534
		[FieldOffset(4)]
		public bool add;
	}

	// Token: 0x02006527 RID: 25895
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __EnableAiSenseByType_FunctionParams
	{
		// Token: 0x0402193F RID: 137535
		[FieldOffset(0)]
		public int type;

		// Token: 0x04021940 RID: 137536
		[FieldOffset(4)]
		public bool enable;
	}

	// Token: 0x02006528 RID: 25896
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAiHateConfig_FunctionParams
	{
		// Token: 0x04021941 RID: 137537
		[FieldOffset(0)]
		public FString configId;
	}

	// Token: 0x02006529 RID: 25897
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __ChangeHatred_FunctionParams
	{
		// Token: 0x04021942 RID: 137538
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04021943 RID: 137539
		[FieldOffset(4)]
		public float rate;

		// Token: 0x04021944 RID: 137540
		[FieldOffset(8)]
		public float abs;
	}

	// Token: 0x0200652A RID: 25898
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __ClearHatred_FunctionParams
	{
		// Token: 0x04021945 RID: 137541
		[FieldOffset(0)]
		public int entityId;
	}

	// Token: 0x0200652B RID: 25899
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddAlertEventBinder_FunctionParams
	{
		// Token: 0x04021946 RID: 137542
		[FieldOffset(0)]
		public IntPtr eventBinder;
	}

	// Token: 0x0200652C RID: 25900
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAiAlertConfig_FunctionParams
	{
		// Token: 0x04021947 RID: 137543
		[FieldOffset(0)]
		public FString configId;
	}

	// Token: 0x0200652D RID: 25901
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetAiEnable_FunctionParams
	{
		// Token: 0x04021948 RID: 137544
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x04021949 RID: 137545
		[FieldOffset(8)]
		public FString key;
	}

	// Token: 0x0200652E RID: 25902
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TestChangeAi_FunctionParams
	{
		// Token: 0x0402194A RID: 137546
		[FieldOffset(0)]
		public FString id;
	}

	// Token: 0x0200652F RID: 25903
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __LogReport_FunctionParams
	{
		// Token: 0x0402194B RID: 137547
		[FieldOffset(0)]
		public int logId;
	}

	// Token: 0x02006530 RID: 25904
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __逻辑主控_FunctionParams
	{
		// Token: 0x0402194C RID: 137548
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02006531 RID: 25905
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __移动主控_FunctionParams
	{
		// Token: 0x0402194D RID: 137549
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x02006532 RID: 25906
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __检查状态机状态_FunctionParams
	{
		// Token: 0x0402194E RID: 137550
		[FieldOffset(0)]
		public byte states;

		// Token: 0x0402194F RID: 137551
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x02006533 RID: 25907
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __切换状态机状态_FunctionParams
	{
		// Token: 0x04021950 RID: 137552
		[FieldOffset(0)]
		public byte states;
	}

	// Token: 0x02006534 RID: 25908
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetCoolDownDone_FunctionParams
	{
		// Token: 0x04021951 RID: 137553
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021952 RID: 137554
		[FieldOffset(4)]
		public bool __Result;
	}

	// Token: 0x02006535 RID: 25909
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetCoolDownRemainTime_FunctionParams
	{
		// Token: 0x04021953 RID: 137555
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021954 RID: 137556
		[FieldOffset(4)]
		public float __Result;
	}

	// Token: 0x02006536 RID: 25910
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetCoolDown_FunctionParams
	{
		// Token: 0x04021955 RID: 137557
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021956 RID: 137558
		[FieldOffset(4)]
		public float cd;
	}

	// Token: 0x02006537 RID: 25911
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InitCooldownEvent_FunctionParams
	{
		// Token: 0x04021957 RID: 137559
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021958 RID: 137560
		[FieldOffset(8)]
		public IntPtr eventBinder;
	}

	// Token: 0x02006538 RID: 25912
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StartCooldownTimer_FunctionParams
	{
		// Token: 0x04021959 RID: 137561
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402195A RID: 137562
		[FieldOffset(4)]
		public float duration;
	}

	// Token: 0x02006539 RID: 25913
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugStateMachine_FunctionParams
	{
		// Token: 0x0402195B RID: 137563
		[FieldOffset(0)]
		public byte output;
	}

	// Token: 0x0200653A RID: 25914
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDebugText_FunctionParams
	{
		// Token: 0x0402195C RID: 137564
		[FieldOffset(0)]
		public byte __Result;
	}
}
