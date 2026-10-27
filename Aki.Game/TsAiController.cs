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
	// Token: 0x17000264 RID: 612
	// (get) Token: 0x06000E3A RID: 3642 RVA: 0x000521CA File Offset: 0x000503CA
	// (set) Token: 0x06000E3B RID: 3643 RVA: 0x000521DE File Offset: 0x000503DE
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

	// Token: 0x17000265 RID: 613
	// (get) Token: 0x06000E3C RID: 3644 RVA: 0x000521F3 File Offset: 0x000503F3
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

	// Token: 0x06000E3D RID: 3645 RVA: 0x00052207 File Offset: 0x00050407
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

	// Token: 0x06000E3E RID: 3646 RVA: 0x0005221A File Offset: 0x0005041A
	[NullableContext(2)]
	public CharacterAiComponent GetAiComp()
	{
		return this.CharAiDesignComp;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00052222 File Offset: 0x00050422
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

	// Token: 0x06000E40 RID: 3648 RVA: 0x00052250 File Offset: 0x00050450
	[NullableContext(1)]
	public void InitAiController(CharacterAiComponent aiComp)
	{
		this.CharAiDesignComp = aiComp;
		this.AiController = aiComp.AiController;
		this.CharBuffComp = aiComp.Entity.GetComponent<CharacterBuffComponent>();
		this.CharTagComp = aiComp.Entity.GetComponent<BaseTagComponent>();
		this.CharStateMachineComp = aiComp.Entity.GetComponent<CharacterStateMachineNewComponent>();
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x000522A4 File Offset: 0x000504A4
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

	// Token: 0x06000E42 RID: 3650 RVA: 0x00052498 File Offset: 0x00050698
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

	// Token: 0x06000E43 RID: 3651 RVA: 0x000527F0 File Offset: 0x000509F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OnStart()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnStart"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00052860 File Offset: 0x00050A60
	protected void OnStart_Implementation()
	{
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00052864 File Offset: 0x00050A64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 获取控制权时()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("获取控制权时"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x000528D4 File Offset: 0x00050AD4
	protected void 获取控制权时_Implementation()
	{
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x000528D8 File Offset: 0x00050AD8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 状态切换时(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("状态切换时"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__状态切换时_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__状态切换时_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__状态切换时_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->oldState) = (byte)oldState;
			*(&ptr2->newState) = (byte)newState;
			ptr2->isAutonomousProxy = isAutonomousProxy;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00052960 File Offset: 0x00050B60
	protected void 状态切换时_Implementation(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
	{
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00052964 File Offset: 0x00050B64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 渲染状态改变时(bool wasRendered)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("渲染状态改变时"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__渲染状态改变时_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__渲染状态改变时_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__渲染状态改变时_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->wasRendered = wasRendered;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x000529DA File Offset: 0x00050BDA
	protected void 渲染状态改变时_Implementation(bool wasRendered)
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x000529DC File Offset: 0x00050BDC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddComplicatedEventBinder(SAiConditions conditions, UKuroBooleanEventBinder eventBinder)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddComplicatedEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddComplicatedEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddComplicatedEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddComplicatedEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(SAiConditions.StaticStruct(), &ptr2->conditions, (conditions != null) ? conditions.NativePtr : ((IntPtr)0), 1, false);
			*(&ptr2->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00052A80 File Offset: 0x00050C80
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

	// Token: 0x06000E4D RID: 3661 RVA: 0x00052AD0 File Offset: 0x00050CD0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddSceneItemDestroyEventBinder(float distance, UKuroActorEventBinder eventBinder)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddSceneItemDestroyEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->distance = distance;
			*(&ptr2->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00052B5C File Offset: 0x00050D5C
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

	// Token: 0x06000E4F RID: 3663 RVA: 0x00052BAC File Offset: 0x00050DAC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddLevelVarBoolEventBinder(SAiLevelVar levelVar, UKuroBooleanEventBinder eventBinder)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddLevelVarBoolEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddLevelVarBoolEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddLevelVarBoolEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddLevelVarBoolEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(SAiLevelVar.StaticStruct(), &ptr2->levelVar, (levelVar != null) ? levelVar.NativePtr : ((IntPtr)0), 1, false);
			*(&ptr2->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00052C50 File Offset: 0x00050E50
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

	// Token: 0x06000E51 RID: 3665 RVA: 0x00052CA0 File Offset: 0x00050EA0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddLevelVarIntEventBinder(SAiLevelVar levelVar, UKuroIntEventBinder eventBinder)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddLevelVarIntEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddLevelVarIntEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddLevelVarIntEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddLevelVarIntEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(SAiLevelVar.StaticStruct(), &ptr2->levelVar, (levelVar != null) ? levelVar.NativePtr : ((IntPtr)0), 1, false);
			*(&ptr2->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00052D44 File Offset: 0x00050F44
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

	// Token: 0x06000E53 RID: 3667 RVA: 0x00052D94 File Offset: 0x00050F94
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddHateEventBinder(UKuroPerceptionEventBinder handler)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddHateEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddHateEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddHateEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddHateEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->handler) = ((handler != null) ? handler.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00052E18 File Offset: 0x00051018
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

	// Token: 0x06000E55 RID: 3669 RVA: 0x00052E30 File Offset: 0x00051030
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddPerceptionEventBinder(UKuroPerceptionEventBinder handler)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddPerceptionEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddPerceptionEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddPerceptionEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddPerceptionEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->handler) = ((handler != null) ? handler.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x00052EB4 File Offset: 0x000510B4
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

	// Token: 0x06000E57 RID: 3671 RVA: 0x00052ED0 File Offset: 0x000510D0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetPerceptionEventState(bool includeFriend, bool includeEnemy, bool includeNeutral)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetPerceptionEventState"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetPerceptionEventState_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetPerceptionEventState_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetPerceptionEventState_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->includeFriend = includeFriend;
			ptr2->includeEnemy = includeEnemy;
			ptr2->includeNeutral = includeNeutral;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x00052F54 File Offset: 0x00051154
	protected void SetPerceptionEventState_Implementation(bool includeFriend, bool includeEnemy, bool includeNeutral)
	{
		AiController aiController = this.AiController;
		if (aiController == null)
		{
			return;
		}
		aiController.AiPerceptionEvents.SetPerceptionEventState(includeFriend, includeEnemy, includeNeutral);
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00052F70 File Offset: 0x00051170
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddHateOutRangeEventBinder(UKuroPerceptionEventBinder handler)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddHateOutRangeEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddHateOutRangeEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddHateOutRangeEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddHateOutRangeEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->handler) = ((handler != null) ? handler.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E5A RID: 3674 RVA: 0x00052FF4 File Offset: 0x000511F4
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

	// Token: 0x06000E5B RID: 3675 RVA: 0x0005300C File Offset: 0x0005120C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ActivateSkillGroup(int skillGroupIndex, bool activate)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ActivateSkillGroup"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__ActivateSkillGroup_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__ActivateSkillGroup_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__ActivateSkillGroup_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->skillGroupIndex = skillGroupIndex;
			ptr2->activate = activate;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x00053089 File Offset: 0x00051289
	protected void ActivateSkillGroup_Implementation(int skillGroupIndex, bool activate)
	{
		AiController aiController = this.AiController;
		if (((aiController != null) ? aiController.AiSkill : null) != null)
		{
			this.AiController.AiSkill.ActivateSkillGroup(skillGroupIndex, activate);
		}
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x000530B4 File Offset: 0x000512B4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddSkillCd(int skillInfoId, float cdAdd)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddSkillCd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddSkillCd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddSkillCd_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddSkillCd_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->skillInfoId = skillInfoId;
			ptr2->cdAdd = cdAdd;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x00053131 File Offset: 0x00051331
	protected void AddSkillCd_Implementation(int skillInfoId, float cdAdd)
	{
		AiController aiController = this.AiController;
		if (((aiController != null) ? aiController.AiSkill : null) != null)
		{
			this.AiController.AiSkill.AddSkillCd(skillInfoId, cdAdd);
		}
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x0005315C File Offset: 0x0005135C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicApplyBuff(long buffId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AicApplyBuff"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AicApplyBuff_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AicApplyBuff_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AicApplyBuff_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->buffId = buffId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E60 RID: 3680 RVA: 0x000531D4 File Offset: 0x000513D4
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

	// Token: 0x06000E61 RID: 3681 RVA: 0x00053230 File Offset: 0x00051430
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicApplyBuffToTarget(int targetId, long buffId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AicApplyBuffToTarget"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AicApplyBuffToTarget_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AicApplyBuffToTarget_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AicApplyBuffToTarget_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->targetId = targetId;
			ptr2->buffId = buffId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x000532B0 File Offset: 0x000514B0
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

	// Token: 0x06000E63 RID: 3683 RVA: 0x00053314 File Offset: 0x00051514
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicRemoveBuff(long buffId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AicRemoveBuff"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AicRemoveBuff_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AicRemoveBuff_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AicRemoveBuff_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->buffId = buffId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x0005338C File Offset: 0x0005158C
	protected void AicRemoveBuff_Implementation(long buffId)
	{
		CharacterBuffComponent charBuffComp = this.CharBuffComp;
		if (charBuffComp != null && charBuffComp.Valid)
		{
			this.CharBuffComp.RemoveBuff(buffId, -1, "AIC蓝图移除buff（AIC Remove Buff）", null, null, null);
		}
	}

	// Token: 0x06000E65 RID: 3685 RVA: 0x000533DC File Offset: 0x000515DC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicAddTag(FGameplayTag tag)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AicAddTag"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AicAddTag_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AicAddTag_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AicAddTag_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->tag = tag;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E66 RID: 3686 RVA: 0x00053452 File Offset: 0x00051652
	protected void AicAddTag_Implementation(FGameplayTag tag)
	{
		BaseTagComponent charTagComp = this.CharTagComp;
		if (charTagComp != null && charTagComp.Valid)
		{
			this.CharTagComp.AddTag(new int?(tag.TagId()));
		}
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00053480 File Offset: 0x00051680
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void AicRemoveTag(FGameplayTag tag)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AicRemoveTag"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AicRemoveTag_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AicRemoveTag_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AicRemoveTag_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->tag = tag;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x000534F8 File Offset: 0x000516F8
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

	// Token: 0x06000E69 RID: 3689 RVA: 0x00053568 File Offset: 0x00051768
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetBattleWanderTime(float min, float max)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetBattleWanderTime"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetBattleWanderTime_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetBattleWanderTime_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetBattleWanderTime_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->min = min;
			ptr2->max = max;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x000535E8 File Offset: 0x000517E8
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

	// Token: 0x06000E6B RID: 3691 RVA: 0x00053664 File Offset: 0x00051864
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetBattleWanderIndex(int index)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetBattleWanderIndex"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetBattleWanderIndex_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetBattleWanderIndex_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetBattleWanderIndex_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->index = index;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x000536DC File Offset: 0x000518DC
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

	// Token: 0x06000E6D RID: 3693 RVA: 0x000537E8 File Offset: 0x000519E8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddBattleWanderEndTime(float addTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddBattleWanderEndTime"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddBattleWanderEndTime_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddBattleWanderEndTime_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddBattleWanderEndTime_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addTime = addTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00053860 File Offset: 0x00051A60
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

	// Token: 0x06000E6F RID: 3695 RVA: 0x000538E4 File Offset: 0x00051AE4
	[NullableContext(1)]
	private void DrawArrow(global::Vector from, global::Vector to, FLinearColor color)
	{
		to.Subtraction(from, TsAiController.TmpVector);
		double num = TsAiController.TmpVector.Size();
		TsAiController.TmpVector.MultiplyEqual((num - 20.0) / num);
		TsAiController.TmpVector.AdditionEqual(from);
		UKismetSystemLibrary.D_DrawDebugArrow(this, from.ToUeVector(false), TsAiController.TmpVector.ToUeVector(false), 100f, color, 0f, 3f);
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x00053958 File Offset: 0x00051B58
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiSenseEnable(int index, bool enable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetAiSenseEnable"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetAiSenseEnable_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetAiSenseEnable_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetAiSenseEnable_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->index = index;
			ptr2->enable = enable;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x000539D5 File Offset: 0x00051BD5
	protected void SetAiSenseEnable_Implementation(int index, bool enable)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception == null)
		{
			return;
		}
		aiPerception.SetAiSenseEnable(index, enable);
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x000539F0 File Offset: 0x00051BF0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddOrRemoveAiSense(int aiSenseId, bool add)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddOrRemoveAiSense"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddOrRemoveAiSense_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddOrRemoveAiSense_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddOrRemoveAiSense_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->aiSenseId = aiSenseId;
			ptr2->add = add;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E73 RID: 3699 RVA: 0x00053A6D File Offset: 0x00051C6D
	protected void AddOrRemoveAiSense_Implementation(int aiSenseId, bool add)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception == null)
		{
			return;
		}
		aiPerception.AddOrRemoveAiSense(aiSenseId, add);
	}

	// Token: 0x06000E74 RID: 3700 RVA: 0x00053A88 File Offset: 0x00051C88
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void EnableAiSenseByType(int type, bool enable)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("EnableAiSenseByType"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__EnableAiSenseByType_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__EnableAiSenseByType_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__EnableAiSenseByType_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->type = type;
			ptr2->enable = enable;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E75 RID: 3701 RVA: 0x00053B05 File Offset: 0x00051D05
	protected void EnableAiSenseByType_Implementation(int type, bool enable)
	{
		IAiPerception aiPerception = this.AiController.AiPerception;
		if (aiPerception == null)
		{
			return;
		}
		aiPerception.EnableAiSenseByType(type, enable);
	}

	// Token: 0x06000E76 RID: 3702 RVA: 0x00053B20 File Offset: 0x00051D20
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiHateConfig(string configId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetAiHateConfig"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetAiHateConfig_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetAiHateConfig_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetAiHateConfig_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->configId), configId);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00053B9C File Offset: 0x00051D9C
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

	// Token: 0x06000E78 RID: 3704 RVA: 0x00053C04 File Offset: 0x00051E04
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ChangeHatred(int entityId, float rate, float abs)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ChangeHatred"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__ChangeHatred_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__ChangeHatred_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__ChangeHatred_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
			ptr2->rate = rate;
			ptr2->abs = abs;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00053C88 File Offset: 0x00051E88
	protected void ChangeHatred_Implementation(int entityId, float rate, float abs)
	{
		this.AiController.AiHateList.ChangeHatred(entityId, rate, abs);
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00053CA0 File Offset: 0x00051EA0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void ClearHatred(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ClearHatred"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__ClearHatred_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__ClearHatred_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__ClearHatred_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00053D16 File Offset: 0x00051F16
	protected void ClearHatred_Implementation(int entityId)
	{
		this.AiController.AiHateList.ClearHatred(entityId);
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00053D2C File Offset: 0x00051F2C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void BindPlayerDamageEvents()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("BindPlayerDamageEvents"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00053D9C File Offset: 0x00051F9C
	protected void BindPlayerDamageEvents_Implementation()
	{
		this.AiController.AiHateList.BindPlayerDamageEvents();
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00053DB0 File Offset: 0x00051FB0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void AddAlertEventBinder(UKuroBooleanEventBinder eventBinder)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("AddAlertEventBinder"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__AddAlertEventBinder_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__AddAlertEventBinder_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__AddAlertEventBinder_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00053E34 File Offset: 0x00052034
	[NullableContext(1)]
	protected void AddAlertEventBinder_Implementation(UKuroBooleanEventBinder eventBinder)
	{
		this.AiController.AiAlert.CallbackEvent = eventBinder;
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00053E48 File Offset: 0x00052048
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiAlertConfig(string configId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetAiAlertConfig"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetAiAlertConfig_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetAiAlertConfig_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetAiAlertConfig_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->configId), configId);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00053EC4 File Offset: 0x000520C4
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

	// Token: 0x06000E82 RID: 3714 RVA: 0x00053F2C File Offset: 0x0005212C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetAiEnable(bool enable, string key)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetAiEnable"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetAiEnable_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetAiEnable_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetAiEnable_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->enable = enable;
			FString.CopyFrom((void*)(&ptr2->key), key);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00053FB0 File Offset: 0x000521B0
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

	// Token: 0x06000E84 RID: 3716 RVA: 0x00053FE8 File Offset: 0x000521E8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void TestChangeAi(string id)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TestChangeAi"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__TestChangeAi_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__TestChangeAi_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__TestChangeAi_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->id), id);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00054064 File Offset: 0x00052264
	[NullableContext(1)]
	protected void TestChangeAi_Implementation(string id)
	{
		this.CharAiDesignComp.LoadAiConfigs(int.Parse(id));
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x00054078 File Offset: 0x00052278
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void LogReport(int logId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("LogReport"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__LogReport_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__LogReport_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__LogReport_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->logId = logId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E87 RID: 3719 RVA: 0x000540F0 File Offset: 0x000522F0
	protected void LogReport_Implementation(int logId)
	{
		Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJC, "埋点废弃,请删除相关配置", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x06000E88 RID: 3720 RVA: 0x00054118 File Offset: 0x00052318
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool 逻辑主控()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("逻辑主控"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__逻辑主控_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__逻辑主控_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__逻辑主控_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000E89 RID: 3721 RVA: 0x0005418D File Offset: 0x0005238D
	protected bool 逻辑主控_Implementation()
	{
		return this.AiController.CharActorComp.IsAutonomousProxy;
	}

	// Token: 0x06000E8A RID: 3722 RVA: 0x000541A0 File Offset: 0x000523A0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool 移动主控()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("移动主控"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__移动主控_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__移动主控_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__移动主控_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000E8B RID: 3723 RVA: 0x00054215 File Offset: 0x00052415
	protected bool 移动主控_Implementation()
	{
		return this.AiController.CharActorComp.IsMoveAutonomousProxy;
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x00054228 File Offset: 0x00052428
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool 检查状态机状态(ref TArray<string> states)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("检查状态机状态"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__检查状态机状态_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__检查状态机状态_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__检查状态机状态_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			TArray<string> tarray = states;
			if (tarray != null)
			{
				tarray.CopyTo(&ptr2->states, default(UScriptStructStackOnlyPtr));
			}
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		states = new TArray<string>(&ptr2->states, true, true);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x000542CB File Offset: 0x000524CB
	[NullableContext(1)]
	protected bool 检查状态机状态_Implementation(ref TArray<string> states)
	{
		return false;
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x000542D0 File Offset: 0x000524D0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void 切换状态机状态(ref TArray<string> states)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("切换状态机状态"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__切换状态机状态_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__切换状态机状态_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__切换状态机状态_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			TArray<string> tarray = states;
			if (tarray != null)
			{
				tarray.CopyTo(&ptr2->states, default(UScriptStructStackOnlyPtr));
			}
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		states = new TArray<string>(&ptr2->states, true, true);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x0005436D File Offset: 0x0005256D
	[NullableContext(1)]
	protected void 切换状态机状态_Implementation(ref TArray<string> states)
	{
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00054370 File Offset: 0x00052570
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool GetCoolDownDone(int id)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetCoolDownDone"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__GetCoolDownDone_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__GetCoolDownDone_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__GetCoolDownDone_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->id = id;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x000543EC File Offset: 0x000525EC
	protected bool GetCoolDownDone_Implementation(int id)
	{
		return this.AiController.GetCoolDownRemainTime(id) == 0.0;
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00054408 File Offset: 0x00052608
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetCoolDownRemainTime(int id)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetCoolDownRemainTime"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__GetCoolDownRemainTime_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__GetCoolDownRemainTime_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__GetCoolDownRemainTime_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->id = id;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00054484 File Offset: 0x00052684
	protected float GetCoolDownRemainTime_Implementation(int id)
	{
		return (float)this.AiController.GetCoolDownRemainTime(id);
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00054494 File Offset: 0x00052694
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetCoolDown(int id, float cd)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCoolDown"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__SetCoolDown_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__SetCoolDown_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__SetCoolDown_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->id = id;
			ptr2->cd = cd;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00054514 File Offset: 0x00052714
	protected void SetCoolDown_Implementation(int id, float cd)
	{
		double num = GameModeModel.Instance.IsMulti ? Time.Instance.ServerTimeStamp : Time.Instance.WorldTime;
		this.AiController.SetCoolDownTime(id, num + (double)cd, true, "蓝图");
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0005455C File Offset: 0x0005275C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InitCooldownEvent(int id, UKuroBooleanEventBinder eventBinder)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitCooldownEvent"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__InitCooldownEvent_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__InitCooldownEvent_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__InitCooldownEvent_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->id = id;
			*(&ptr2->eventBinder) = ((eventBinder != null) ? eventBinder.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x000545E7 File Offset: 0x000527E7
	[NullableContext(1)]
	protected void InitCooldownEvent_Implementation(int id, UKuroBooleanEventBinder eventBinder)
	{
		this.AiController.InitCooldownTimer(id, eventBinder);
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x000545F8 File Offset: 0x000527F8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void StartCooldownTimer(int id, float duration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("StartCooldownTimer"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__StartCooldownTimer_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__StartCooldownTimer_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__StartCooldownTimer_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->id = id;
			ptr2->duration = duration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00054678 File Offset: 0x00052878
	protected void StartCooldownTimer_Implementation(int id, float duration)
	{
		double num = GameModeModel.Instance.IsMulti ? Time.Instance.ServerTimeStamp : Time.Instance.WorldTime;
		this.AiController.SetCoolDownTime(id, num + (double)duration, true, "蓝图AIC延迟节点");
	}

	// Token: 0x06000E9A RID: 3738 RVA: 0x000546C0 File Offset: 0x000528C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void GetDebugStateMachine(ref TArray<FText> output)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugStateMachine"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__GetDebugStateMachine_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__GetDebugStateMachine_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__GetDebugStateMachine_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			TArray<FText> tarray = output;
			if (tarray != null)
			{
				tarray.CopyTo(&ptr2->output, default(UScriptStructStackOnlyPtr));
			}
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		output = new TArray<FText>(&ptr2->output, true, true);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000E9B RID: 3739 RVA: 0x00054760 File Offset: 0x00052960
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

	// Token: 0x06000E9C RID: 3740 RVA: 0x000547D4 File Offset: 0x000529D4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual FText GetDebugText()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugText"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsAiController.__GetDebugText_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsAiController.__GetDebugText_FunctionParams*)ptr + 15L / (long)sizeof(TsAiController.__GetDebugText_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		FText result = new FText(&ptr2->__Result, true, true);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06000E9D RID: 3741 RVA: 0x00054854 File Offset: 0x00052A54
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

	// Token: 0x06000E9E RID: 3742 RVA: 0x00054AFC File Offset: 0x00052CFC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveDestroyed()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveDestroyed"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06000E9F RID: 3743 RVA: 0x00054B6C File Offset: 0x00052D6C
	protected virtual void ReceiveDestroyed_Implementation()
	{
		if (!ObjectUtils.IsValid(this))
		{
			return;
		}
		this.Clear();
	}

	// Token: 0x06000EA0 RID: 3744 RVA: 0x00054B7D File Offset: 0x00052D7D
	public void Clear()
	{
		this.CharAiDesignComp = null;
		this.CharBuffComp = null;
		this.CharTagComp = null;
		this.AiController = null;
		this.BehaviorTree = null;
		this.CharStateMachineComp = null;
	}

	// Token: 0x06000EA1 RID: 3745 RVA: 0x00054BA9 File Offset: 0x00052DA9
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAiController._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/Controller/TsAiController.TsAiController_C");
		}
		return TsAiController._ClassPtr;
	}

	// Token: 0x06000EA2 RID: 3746 RVA: 0x00054BD0 File Offset: 0x00052DD0
	public TsAiController() : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000EA3 RID: 3747 RVA: 0x00054BF8 File Offset: 0x00052DF8
	[NullableContext(1)]
	public TsAiController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000EA4 RID: 3748 RVA: 0x00054C2B File Offset: 0x00052E2B
	protected TsAiController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000EA5 RID: 3749 RVA: 0x00054C34 File Offset: 0x00052E34
	protected virtual void __CPPCALL_OnStart_Implementation()
	{
		this.OnStart_Implementation();
	}

	// Token: 0x06000EA6 RID: 3750 RVA: 0x00054C3C File Offset: 0x00052E3C
	protected virtual void __CPPCALL_获取控制权时_Implementation()
	{
		this.获取控制权时_Implementation();
	}

	// Token: 0x06000EA7 RID: 3751 RVA: 0x00054C44 File Offset: 0x00052E44
	protected unsafe virtual void __CPPCALL_状态切换时_Implementation(TsAiController.__状态切换时_FunctionParams* __Params)
	{
		ECharacterState oldState = (ECharacterState)__Params->oldState;
		ECharacterState newState = (ECharacterState)__Params->newState;
		this.状态切换时_Implementation(oldState, newState, __Params->isAutonomousProxy);
	}

	// Token: 0x06000EA8 RID: 3752 RVA: 0x00054C6D File Offset: 0x00052E6D
	protected unsafe virtual void __CPPCALL_渲染状态改变时_Implementation(TsAiController.__渲染状态改变时_FunctionParams* __Params)
	{
		this.渲染状态改变时_Implementation(__Params->wasRendered);
	}

	// Token: 0x06000EA9 RID: 3753 RVA: 0x00054C7C File Offset: 0x00052E7C
	protected unsafe virtual void __CPPCALL_AddComplicatedEventBinder_Implementation(TsAiController.__AddComplicatedEventBinder_FunctionParams* __Params)
	{
		SAiConditions conditions = new SAiConditions(&__Params->conditions, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.AddComplicatedEventBinder_Implementation(conditions, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EAA RID: 3754 RVA: 0x00054CAC File Offset: 0x00052EAC
	protected unsafe virtual void __CPPCALL_AddSceneItemDestroyEventBinder_Implementation(TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams* __Params)
	{
		UKuroActorEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroActorEventBinder>(__Params->eventBinder);
		this.AddSceneItemDestroyEventBinder_Implementation(__Params->distance, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x00054CD4 File Offset: 0x00052ED4
	protected unsafe virtual void __CPPCALL_AddLevelVarBoolEventBinder_Implementation(TsAiController.__AddLevelVarBoolEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.AddLevelVarBoolEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EAC RID: 3756 RVA: 0x00054D04 File Offset: 0x00052F04
	protected unsafe virtual void __CPPCALL_AddLevelVarIntEventBinder_Implementation(TsAiController.__AddLevelVarIntEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroIntEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroIntEventBinder>(__Params->eventBinder);
		this.AddLevelVarIntEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EAD RID: 3757 RVA: 0x00054D34 File Offset: 0x00052F34
	protected unsafe virtual void __CPPCALL_AddHateEventBinder_Implementation(TsAiController.__AddHateEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		this.AddHateEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00054D54 File Offset: 0x00052F54
	protected unsafe virtual void __CPPCALL_AddPerceptionEventBinder_Implementation(TsAiController.__AddPerceptionEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		this.AddPerceptionEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00054D74 File Offset: 0x00052F74
	protected unsafe virtual void __CPPCALL_SetPerceptionEventState_Implementation(TsAiController.__SetPerceptionEventState_FunctionParams* __Params)
	{
		this.SetPerceptionEventState_Implementation(__Params->includeFriend, __Params->includeEnemy, __Params->includeNeutral);
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00054D90 File Offset: 0x00052F90
	protected unsafe virtual void __CPPCALL_AddHateOutRangeEventBinder_Implementation(TsAiController.__AddHateOutRangeEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		this.AddHateOutRangeEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00054DB0 File Offset: 0x00052FB0
	protected unsafe virtual void __CPPCALL_ActivateSkillGroup_Implementation(TsAiController.__ActivateSkillGroup_FunctionParams* __Params)
	{
		this.ActivateSkillGroup_Implementation(__Params->skillGroupIndex, __Params->activate);
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00054DC4 File Offset: 0x00052FC4
	protected unsafe virtual void __CPPCALL_AddSkillCd_Implementation(TsAiController.__AddSkillCd_FunctionParams* __Params)
	{
		this.AddSkillCd_Implementation(__Params->skillInfoId, __Params->cdAdd);
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00054DD8 File Offset: 0x00052FD8
	protected unsafe virtual void __CPPCALL_AicApplyBuff_Implementation(TsAiController.__AicApplyBuff_FunctionParams* __Params)
	{
		this.AicApplyBuff_Implementation(__Params->buffId);
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00054DE6 File Offset: 0x00052FE6
	protected unsafe virtual void __CPPCALL_AicApplyBuffToTarget_Implementation(TsAiController.__AicApplyBuffToTarget_FunctionParams* __Params)
	{
		this.AicApplyBuffToTarget_Implementation(__Params->targetId, __Params->buffId);
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00054DFA File Offset: 0x00052FFA
	protected unsafe virtual void __CPPCALL_AicRemoveBuff_Implementation(TsAiController.__AicRemoveBuff_FunctionParams* __Params)
	{
		this.AicRemoveBuff_Implementation(__Params->buffId);
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x00054E08 File Offset: 0x00053008
	protected unsafe virtual void __CPPCALL_AicAddTag_Implementation(TsAiController.__AicAddTag_FunctionParams* __Params)
	{
		this.AicAddTag_Implementation(__Params->tag);
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00054E16 File Offset: 0x00053016
	protected unsafe virtual void __CPPCALL_AicRemoveTag_Implementation(TsAiController.__AicRemoveTag_FunctionParams* __Params)
	{
		this.AicRemoveTag_Implementation(__Params->tag);
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x00054E24 File Offset: 0x00053024
	protected unsafe virtual void __CPPCALL_SetBattleWanderTime_Implementation(TsAiController.__SetBattleWanderTime_FunctionParams* __Params)
	{
		this.SetBattleWanderTime_Implementation(__Params->min, __Params->max);
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00054E38 File Offset: 0x00053038
	protected unsafe virtual void __CPPCALL_SetBattleWanderIndex_Implementation(TsAiController.__SetBattleWanderIndex_FunctionParams* __Params)
	{
		this.SetBattleWanderIndex_Implementation(__Params->index);
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00054E46 File Offset: 0x00053046
	protected unsafe virtual void __CPPCALL_AddBattleWanderEndTime_Implementation(TsAiController.__AddBattleWanderEndTime_FunctionParams* __Params)
	{
		this.AddBattleWanderEndTime_Implementation(__Params->addTime);
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00054E54 File Offset: 0x00053054
	protected unsafe virtual void __CPPCALL_SetAiSenseEnable_Implementation(TsAiController.__SetAiSenseEnable_FunctionParams* __Params)
	{
		this.SetAiSenseEnable_Implementation(__Params->index, __Params->enable);
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00054E68 File Offset: 0x00053068
	protected unsafe virtual void __CPPCALL_AddOrRemoveAiSense_Implementation(TsAiController.__AddOrRemoveAiSense_FunctionParams* __Params)
	{
		this.AddOrRemoveAiSense_Implementation(__Params->aiSenseId, __Params->add);
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00054E7C File Offset: 0x0005307C
	protected unsafe virtual void __CPPCALL_EnableAiSenseByType_Implementation(TsAiController.__EnableAiSenseByType_FunctionParams* __Params)
	{
		this.EnableAiSenseByType_Implementation(__Params->type, __Params->enable);
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00054E90 File Offset: 0x00053090
	protected unsafe virtual void __CPPCALL_SetAiHateConfig_Implementation(TsAiController.__SetAiHateConfig_FunctionParams* __Params)
	{
		string aiHateConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		this.SetAiHateConfig_Implementation(aiHateConfig_Implementation);
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00054EB1 File Offset: 0x000530B1
	protected unsafe virtual void __CPPCALL_ChangeHatred_Implementation(TsAiController.__ChangeHatred_FunctionParams* __Params)
	{
		this.ChangeHatred_Implementation(__Params->entityId, __Params->rate, __Params->abs);
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00054ECB File Offset: 0x000530CB
	protected unsafe virtual void __CPPCALL_ClearHatred_Implementation(TsAiController.__ClearHatred_FunctionParams* __Params)
	{
		this.ClearHatred_Implementation(__Params->entityId);
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00054ED9 File Offset: 0x000530D9
	protected virtual void __CPPCALL_BindPlayerDamageEvents_Implementation()
	{
		this.BindPlayerDamageEvents_Implementation();
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00054EE4 File Offset: 0x000530E4
	protected unsafe virtual void __CPPCALL_AddAlertEventBinder_Implementation(TsAiController.__AddAlertEventBinder_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.AddAlertEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00054F04 File Offset: 0x00053104
	protected unsafe virtual void __CPPCALL_SetAiAlertConfig_Implementation(TsAiController.__SetAiAlertConfig_FunctionParams* __Params)
	{
		string aiAlertConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		this.SetAiAlertConfig_Implementation(aiAlertConfig_Implementation);
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00054F28 File Offset: 0x00053128
	protected unsafe virtual void __CPPCALL_SetAiEnable_Implementation(TsAiController.__SetAiEnable_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		this.SetAiEnable_Implementation(__Params->enable, key);
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00054F50 File Offset: 0x00053150
	protected unsafe virtual void __CPPCALL_TestChangeAi_Implementation(TsAiController.__TestChangeAi_FunctionParams* __Params)
	{
		string id = FString.ToString((void*)(&__Params->id));
		this.TestChangeAi_Implementation(id);
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00054F71 File Offset: 0x00053171
	protected unsafe virtual void __CPPCALL_LogReport_Implementation(TsAiController.__LogReport_FunctionParams* __Params)
	{
		this.LogReport_Implementation(__Params->logId);
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00054F7F File Offset: 0x0005317F
	protected unsafe virtual void __CPPCALL_逻辑主控_Implementation(TsAiController.__逻辑主控_FunctionParams* __Params)
	{
		__Params->__Result = this.逻辑主控_Implementation();
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00054F8D File Offset: 0x0005318D
	protected unsafe virtual void __CPPCALL_移动主控_Implementation(TsAiController.__移动主控_FunctionParams* __Params)
	{
		__Params->__Result = this.移动主控_Implementation();
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x00054F9C File Offset: 0x0005319C
	protected unsafe virtual void __CPPCALL_检查状态机状态_Implementation(TsAiController.__检查状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		__Params->__Result = this.检查状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00054FE0 File Offset: 0x000531E0
	protected unsafe virtual void __CPPCALL_切换状态机状态_Implementation(TsAiController.__切换状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		this.切换状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x0005501D File Offset: 0x0005321D
	protected unsafe virtual void __CPPCALL_GetCoolDownDone_Implementation(TsAiController.__GetCoolDownDone_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCoolDownDone_Implementation(__Params->id);
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00055031 File Offset: 0x00053231
	protected unsafe virtual void __CPPCALL_GetCoolDownRemainTime_Implementation(TsAiController.__GetCoolDownRemainTime_FunctionParams* __Params)
	{
		__Params->__Result = this.GetCoolDownRemainTime_Implementation(__Params->id);
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00055045 File Offset: 0x00053245
	protected unsafe virtual void __CPPCALL_SetCoolDown_Implementation(TsAiController.__SetCoolDown_FunctionParams* __Params)
	{
		this.SetCoolDown_Implementation(__Params->id, __Params->cd);
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x0005505C File Offset: 0x0005325C
	protected unsafe virtual void __CPPCALL_InitCooldownEvent_Implementation(TsAiController.__InitCooldownEvent_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		this.InitCooldownEvent_Implementation(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00055082 File Offset: 0x00053282
	protected unsafe virtual void __CPPCALL_StartCooldownTimer_Implementation(TsAiController.__StartCooldownTimer_FunctionParams* __Params)
	{
		this.StartCooldownTimer_Implementation(__Params->id, __Params->duration);
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00055098 File Offset: 0x00053298
	protected unsafe virtual void __CPPCALL_GetDebugStateMachine_Implementation(TsAiController.__GetDebugStateMachine_FunctionParams* __Params)
	{
		TArray<FText> tarray = new TArray<FText>(&__Params->output, true, true);
		this.GetDebugStateMachine_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->output, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x000550D5 File Offset: 0x000532D5
	protected unsafe virtual void __CPPCALL_GetDebugText_Implementation(TsAiController.__GetDebugText_FunctionParams* __Params)
	{
		void* dest = (void*)(&__Params->__Result);
		FText debugText_Implementation = this.GetDebugText_Implementation();
		FText.NativeCopy(dest, (debugText_Implementation != null) ? debugText_Implementation.NativePtr : null, 1);
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x000550F7 File Offset: 0x000532F7
	protected virtual void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		this.ReceiveDestroyed_Implementation();
	}

	// Token: 0x04000BA0 RID: 2976
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x04000BA1 RID: 2977
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x04000BA2 RID: 2978
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly global::Vector TmpVector3 = global::Vector.Create();

	// Token: 0x04000BA3 RID: 2979
	[Nullable(2)]
	private CharacterAiComponent CharAiDesignComp;

	// Token: 0x04000BA4 RID: 2980
	[Nullable(2)]
	private BaseTagComponent CharTagComp;

	// Token: 0x04000BA5 RID: 2981
	[Nullable(2)]
	private CharacterBuffComponent CharBuffComp;

	// Token: 0x04000BA6 RID: 2982
	[Nullable(2)]
	private CharacterStateMachineNewComponent CharStateMachineComp;

	// Token: 0x04000BA7 RID: 2983
	[Nullable(2)]
	public AiController AiController;

	// Token: 0x04000BA8 RID: 2984
	private const float DRAW_ARROW_SIZE = 100f;

	// Token: 0x04000BA9 RID: 2985
	private const float DRAW_LINE_THICKNESS = 3f;

	// Token: 0x04000BAA RID: 2986
	private const float ARROW_LENGTH_SUB = 20f;

	// Token: 0x04000BAB RID: 2987
	private const int DEFAULT_SEGMENTS = 24;

	// Token: 0x04000BAC RID: 2988
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor initLocationColor = new FLinearColor(0.5f, 0.5f, 0.5f, 1f);

	// Token: 0x04000BAD RID: 2989
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor targetLinkColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000BAE RID: 2990
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor teamMemberLinkColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000BAF RID: 2991
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor allyLinkColor = new FLinearColor(0.6f, 1f, 0.6f, 1f);

	// Token: 0x04000BB0 RID: 2992
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor neutralLinkColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x04000BB1 RID: 2993
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor enemyLinkColor = new FLinearColor(1f, 0f, 1f, 1f);

	// Token: 0x04000BB2 RID: 2994
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor areaCenterColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x04000BB3 RID: 2995
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor minHateAreaColor = new FLinearColor(1f, 0f, 1f, 1f);

	// Token: 0x04000BB4 RID: 2996
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor maxHateAreaColor = new FLinearColor(0f, 1f, 1f, 1f);

	// Token: 0x04000BB5 RID: 2997
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor minHateInitAreaColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000BB6 RID: 2998
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor maxHateInitAreaColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000BB7 RID: 2999
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Stat StatSetAiHateConfig = Stat.Create("SetAiHateConfig", "", "");

	// Token: 0x04000BB8 RID: 3000
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/Controller/TsAiController.TsAiController_C";

	// Token: 0x04000BB9 RID: 3001
	private static IntPtr _ClassPtr;

	// Token: 0x04000BBA RID: 3002
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000BBB RID: 3003
	private static int __PropertyOffset_BehaviorTree;

	// Token: 0x04000BBC RID: 3004
	private static int __PropertyOffset_StateMachineGroup;

	// Token: 0x0200738E RID: 29582
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __状态切换时_FunctionParams
	{
		// Token: 0x04026625 RID: 157221
		[FieldOffset(0)]
		public byte oldState;

		// Token: 0x04026626 RID: 157222
		[FieldOffset(1)]
		public byte newState;

		// Token: 0x04026627 RID: 157223
		[FieldOffset(2)]
		public bool isAutonomousProxy;
	}

	// Token: 0x0200738F RID: 29583
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __渲染状态改变时_FunctionParams
	{
		// Token: 0x04026628 RID: 157224
		[FieldOffset(0)]
		public bool wasRendered;
	}

	// Token: 0x02007390 RID: 29584
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 192)]
	protected ref struct __AddComplicatedEventBinder_FunctionParams
	{
		// Token: 0x04026629 RID: 157225
		[FieldOffset(0)]
		public byte conditions;

		// Token: 0x0402662A RID: 157226
		[FieldOffset(184)]
		public IntPtr eventBinder;
	}

	// Token: 0x02007391 RID: 29585
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AddSceneItemDestroyEventBinder_FunctionParams
	{
		// Token: 0x0402662B RID: 157227
		[FieldOffset(0)]
		public float distance;

		// Token: 0x0402662C RID: 157228
		[FieldOffset(8)]
		public IntPtr eventBinder;
	}

	// Token: 0x02007392 RID: 29586
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AddLevelVarBoolEventBinder_FunctionParams
	{
		// Token: 0x0402662D RID: 157229
		[FieldOffset(0)]
		public byte levelVar;

		// Token: 0x0402662E RID: 157230
		[FieldOffset(32)]
		public IntPtr eventBinder;
	}

	// Token: 0x02007393 RID: 29587
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __AddLevelVarIntEventBinder_FunctionParams
	{
		// Token: 0x0402662F RID: 157231
		[FieldOffset(0)]
		public byte levelVar;

		// Token: 0x04026630 RID: 157232
		[FieldOffset(32)]
		public IntPtr eventBinder;
	}

	// Token: 0x02007394 RID: 29588
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddHateEventBinder_FunctionParams
	{
		// Token: 0x04026631 RID: 157233
		[FieldOffset(0)]
		public IntPtr handler;
	}

	// Token: 0x02007395 RID: 29589
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddPerceptionEventBinder_FunctionParams
	{
		// Token: 0x04026632 RID: 157234
		[FieldOffset(0)]
		public IntPtr handler;
	}

	// Token: 0x02007396 RID: 29590
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 3)]
	protected ref struct __SetPerceptionEventState_FunctionParams
	{
		// Token: 0x04026633 RID: 157235
		[FieldOffset(0)]
		public bool includeFriend;

		// Token: 0x04026634 RID: 157236
		[FieldOffset(1)]
		public bool includeEnemy;

		// Token: 0x04026635 RID: 157237
		[FieldOffset(2)]
		public bool includeNeutral;
	}

	// Token: 0x02007397 RID: 29591
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddHateOutRangeEventBinder_FunctionParams
	{
		// Token: 0x04026636 RID: 157238
		[FieldOffset(0)]
		public IntPtr handler;
	}

	// Token: 0x02007398 RID: 29592
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ActivateSkillGroup_FunctionParams
	{
		// Token: 0x04026637 RID: 157239
		[FieldOffset(0)]
		public int skillGroupIndex;

		// Token: 0x04026638 RID: 157240
		[FieldOffset(4)]
		public bool activate;
	}

	// Token: 0x02007399 RID: 29593
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddSkillCd_FunctionParams
	{
		// Token: 0x04026639 RID: 157241
		[FieldOffset(0)]
		public int skillInfoId;

		// Token: 0x0402663A RID: 157242
		[FieldOffset(4)]
		public float cdAdd;
	}

	// Token: 0x0200739A RID: 29594
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AicApplyBuff_FunctionParams
	{
		// Token: 0x0402663B RID: 157243
		[FieldOffset(0)]
		public long buffId;
	}

	// Token: 0x0200739B RID: 29595
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __AicApplyBuffToTarget_FunctionParams
	{
		// Token: 0x0402663C RID: 157244
		[FieldOffset(0)]
		public int targetId;

		// Token: 0x0402663D RID: 157245
		[FieldOffset(8)]
		public long buffId;
	}

	// Token: 0x0200739C RID: 29596
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AicRemoveBuff_FunctionParams
	{
		// Token: 0x0402663E RID: 157246
		[FieldOffset(0)]
		public long buffId;
	}

	// Token: 0x0200739D RID: 29597
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AicAddTag_FunctionParams
	{
		// Token: 0x0402663F RID: 157247
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x0200739E RID: 29598
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __AicRemoveTag_FunctionParams
	{
		// Token: 0x04026640 RID: 157248
		[FieldOffset(0)]
		public FGameplayTag tag;
	}

	// Token: 0x0200739F RID: 29599
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetBattleWanderTime_FunctionParams
	{
		// Token: 0x04026641 RID: 157249
		[FieldOffset(0)]
		public float min;

		// Token: 0x04026642 RID: 157250
		[FieldOffset(4)]
		public float max;
	}

	// Token: 0x020073A0 RID: 29600
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __SetBattleWanderIndex_FunctionParams
	{
		// Token: 0x04026643 RID: 157251
		[FieldOffset(0)]
		public int index;
	}

	// Token: 0x020073A1 RID: 29601
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __AddBattleWanderEndTime_FunctionParams
	{
		// Token: 0x04026644 RID: 157252
		[FieldOffset(0)]
		public float addTime;
	}

	// Token: 0x020073A2 RID: 29602
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetAiSenseEnable_FunctionParams
	{
		// Token: 0x04026645 RID: 157253
		[FieldOffset(0)]
		public int index;

		// Token: 0x04026646 RID: 157254
		[FieldOffset(4)]
		public bool enable;
	}

	// Token: 0x020073A3 RID: 29603
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddOrRemoveAiSense_FunctionParams
	{
		// Token: 0x04026647 RID: 157255
		[FieldOffset(0)]
		public int aiSenseId;

		// Token: 0x04026648 RID: 157256
		[FieldOffset(4)]
		public bool add;
	}

	// Token: 0x020073A4 RID: 29604
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __EnableAiSenseByType_FunctionParams
	{
		// Token: 0x04026649 RID: 157257
		[FieldOffset(0)]
		public int type;

		// Token: 0x0402664A RID: 157258
		[FieldOffset(4)]
		public bool enable;
	}

	// Token: 0x020073A5 RID: 29605
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAiHateConfig_FunctionParams
	{
		// Token: 0x0402664B RID: 157259
		[FieldOffset(0)]
		public FString configId;
	}

	// Token: 0x020073A6 RID: 29606
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 12)]
	protected ref struct __ChangeHatred_FunctionParams
	{
		// Token: 0x0402664C RID: 157260
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402664D RID: 157261
		[FieldOffset(4)]
		public float rate;

		// Token: 0x0402664E RID: 157262
		[FieldOffset(8)]
		public float abs;
	}

	// Token: 0x020073A7 RID: 29607
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __ClearHatred_FunctionParams
	{
		// Token: 0x0402664F RID: 157263
		[FieldOffset(0)]
		public int entityId;
	}

	// Token: 0x020073A8 RID: 29608
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __AddAlertEventBinder_FunctionParams
	{
		// Token: 0x04026650 RID: 157264
		[FieldOffset(0)]
		public IntPtr eventBinder;
	}

	// Token: 0x020073A9 RID: 29609
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAiAlertConfig_FunctionParams
	{
		// Token: 0x04026651 RID: 157265
		[FieldOffset(0)]
		public FString configId;
	}

	// Token: 0x020073AA RID: 29610
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetAiEnable_FunctionParams
	{
		// Token: 0x04026652 RID: 157266
		[FieldOffset(0)]
		public bool enable;

		// Token: 0x04026653 RID: 157267
		[FieldOffset(8)]
		public FString key;
	}

	// Token: 0x020073AB RID: 29611
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TestChangeAi_FunctionParams
	{
		// Token: 0x04026654 RID: 157268
		[FieldOffset(0)]
		public FString id;
	}

	// Token: 0x020073AC RID: 29612
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __LogReport_FunctionParams
	{
		// Token: 0x04026655 RID: 157269
		[FieldOffset(0)]
		public int logId;
	}

	// Token: 0x020073AD RID: 29613
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __逻辑主控_FunctionParams
	{
		// Token: 0x04026656 RID: 157270
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x020073AE RID: 29614
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 1)]
	protected ref struct __移动主控_FunctionParams
	{
		// Token: 0x04026657 RID: 157271
		[FieldOffset(0)]
		public bool __Result;
	}

	// Token: 0x020073AF RID: 29615
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __检查状态机状态_FunctionParams
	{
		// Token: 0x04026658 RID: 157272
		[FieldOffset(0)]
		public byte states;

		// Token: 0x04026659 RID: 157273
		[FieldOffset(16)]
		public bool __Result;
	}

	// Token: 0x020073B0 RID: 29616
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __切换状态机状态_FunctionParams
	{
		// Token: 0x0402665A RID: 157274
		[FieldOffset(0)]
		public byte states;
	}

	// Token: 0x020073B1 RID: 29617
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetCoolDownDone_FunctionParams
	{
		// Token: 0x0402665B RID: 157275
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402665C RID: 157276
		[FieldOffset(4)]
		public bool __Result;
	}

	// Token: 0x020073B2 RID: 29618
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetCoolDownRemainTime_FunctionParams
	{
		// Token: 0x0402665D RID: 157277
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402665E RID: 157278
		[FieldOffset(4)]
		public float __Result;
	}

	// Token: 0x020073B3 RID: 29619
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetCoolDown_FunctionParams
	{
		// Token: 0x0402665F RID: 157279
		[FieldOffset(0)]
		public int id;

		// Token: 0x04026660 RID: 157280
		[FieldOffset(4)]
		public float cd;
	}

	// Token: 0x020073B4 RID: 29620
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __InitCooldownEvent_FunctionParams
	{
		// Token: 0x04026661 RID: 157281
		[FieldOffset(0)]
		public int id;

		// Token: 0x04026662 RID: 157282
		[FieldOffset(8)]
		public IntPtr eventBinder;
	}

	// Token: 0x020073B5 RID: 29621
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StartCooldownTimer_FunctionParams
	{
		// Token: 0x04026663 RID: 157283
		[FieldOffset(0)]
		public int id;

		// Token: 0x04026664 RID: 157284
		[FieldOffset(4)]
		public float duration;
	}

	// Token: 0x020073B6 RID: 29622
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugStateMachine_FunctionParams
	{
		// Token: 0x04026665 RID: 157285
		[FieldOffset(0)]
		public byte output;
	}

	// Token: 0x020073B7 RID: 29623
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDebugText_FunctionParams
	{
		// Token: 0x04026666 RID: 157286
		[FieldOffset(0)]
		public byte __Result;
	}
}
