using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036E3 RID: 14051
[NullableContext(1)]
[Nullable(0)]
public class __TsAiController_SubClassMissingExportProxy : __TsAiController_InheritProxy
{
	// Token: 0x0601E422 RID: 123938 RVA: 0x0088670C File Offset: 0x0088490C
	protected __TsAiController_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E423 RID: 123939 RVA: 0x0088673F File Offset: 0x0088493F
	protected __TsAiController_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E424 RID: 123940 RVA: 0x00886748 File Offset: 0x00884948
	public unsafe override void OnStart()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OnStart"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E425 RID: 123941 RVA: 0x008867B8 File Offset: 0x008849B8
	public unsafe override void 获取控制权时()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("获取控制权时"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E426 RID: 123942 RVA: 0x00886828 File Offset: 0x00884A28
	public unsafe override void 状态切换时(ECharacterState oldState, ECharacterState newState, bool isAutonomousProxy)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E427 RID: 123943 RVA: 0x008868B4 File Offset: 0x00884AB4
	public unsafe override void 渲染状态改变时(bool wasRendered)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E428 RID: 123944 RVA: 0x0088692C File Offset: 0x00884B2C
	public unsafe override void AddComplicatedEventBinder(SAiConditions conditions, UKuroBooleanEventBinder eventBinder)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E429 RID: 123945 RVA: 0x008869D4 File Offset: 0x00884BD4
	public unsafe override void AddSceneItemDestroyEventBinder(float distance, UKuroActorEventBinder eventBinder)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E42A RID: 123946 RVA: 0x00886A60 File Offset: 0x00884C60
	public unsafe override void AddLevelVarBoolEventBinder(SAiLevelVar levelVar, UKuroBooleanEventBinder eventBinder)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E42B RID: 123947 RVA: 0x00886B08 File Offset: 0x00884D08
	public unsafe override void AddLevelVarIntEventBinder(SAiLevelVar levelVar, UKuroIntEventBinder eventBinder)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E42C RID: 123948 RVA: 0x00886BB0 File Offset: 0x00884DB0
	public unsafe override void AddHateEventBinder(UKuroPerceptionEventBinder handler)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E42D RID: 123949 RVA: 0x00886C38 File Offset: 0x00884E38
	public unsafe override void AddPerceptionEventBinder(UKuroPerceptionEventBinder handler)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E42E RID: 123950 RVA: 0x00886CC0 File Offset: 0x00884EC0
	public unsafe override void SetPerceptionEventState(bool includeFriend, bool includeEnemy, bool includeNeutral)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E42F RID: 123951 RVA: 0x00886D48 File Offset: 0x00884F48
	public unsafe override void AddHateOutRangeEventBinder(UKuroPerceptionEventBinder handler)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E430 RID: 123952 RVA: 0x00886DD0 File Offset: 0x00884FD0
	public unsafe override void ActivateSkillGroup(int skillGroupIndex, bool activate)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E431 RID: 123953 RVA: 0x00886E50 File Offset: 0x00885050
	public unsafe override void AddSkillCd(int skillInfoId, float cdAdd)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E432 RID: 123954 RVA: 0x00886ED0 File Offset: 0x008850D0
	protected unsafe override void AicApplyBuff(long buffId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E433 RID: 123955 RVA: 0x00886F48 File Offset: 0x00885148
	protected unsafe override void AicApplyBuffToTarget(int targetId, long buffId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E434 RID: 123956 RVA: 0x00886FC8 File Offset: 0x008851C8
	protected unsafe override void AicRemoveBuff(long buffId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E435 RID: 123957 RVA: 0x00887040 File Offset: 0x00885240
	protected unsafe override void AicAddTag(FGameplayTag tag)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E436 RID: 123958 RVA: 0x008870B8 File Offset: 0x008852B8
	protected unsafe override void AicRemoveTag(FGameplayTag tag)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E437 RID: 123959 RVA: 0x00887130 File Offset: 0x00885330
	public unsafe override void SetBattleWanderTime(float min, float max)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E438 RID: 123960 RVA: 0x008871B0 File Offset: 0x008853B0
	public unsafe override void SetBattleWanderIndex(int index)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E439 RID: 123961 RVA: 0x00887228 File Offset: 0x00885428
	public unsafe override void AddBattleWanderEndTime(float addTime)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E43A RID: 123962 RVA: 0x008872A0 File Offset: 0x008854A0
	public unsafe override void SetAiSenseEnable(int index, bool enable)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E43B RID: 123963 RVA: 0x00887320 File Offset: 0x00885520
	public unsafe override void AddOrRemoveAiSense(int aiSenseId, bool add)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E43C RID: 123964 RVA: 0x008873A0 File Offset: 0x008855A0
	public unsafe override void EnableAiSenseByType(int type, bool enable)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E43D RID: 123965 RVA: 0x00887420 File Offset: 0x00885620
	public unsafe override void SetAiHateConfig(string configId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E43E RID: 123966 RVA: 0x008874A0 File Offset: 0x008856A0
	public unsafe override void ChangeHatred(int entityId, float rate, float abs)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E43F RID: 123967 RVA: 0x00887528 File Offset: 0x00885728
	public unsafe override void ClearHatred(int entityId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E440 RID: 123968 RVA: 0x008875A0 File Offset: 0x008857A0
	public unsafe override void BindPlayerDamageEvents()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("BindPlayerDamageEvents"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E441 RID: 123969 RVA: 0x00887610 File Offset: 0x00885810
	public unsafe override void AddAlertEventBinder(UKuroBooleanEventBinder eventBinder)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E442 RID: 123970 RVA: 0x00887698 File Offset: 0x00885898
	public unsafe override void SetAiAlertConfig(string configId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E443 RID: 123971 RVA: 0x00887718 File Offset: 0x00885918
	public unsafe override void SetAiEnable(bool enable, string key)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E444 RID: 123972 RVA: 0x0088779C File Offset: 0x0088599C
	public unsafe override void TestChangeAi(string id)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E445 RID: 123973 RVA: 0x0088781C File Offset: 0x00885A1C
	public unsafe override void LogReport(int logId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E446 RID: 123974 RVA: 0x00887894 File Offset: 0x00885A94
	public unsafe override bool 逻辑主控()
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601E447 RID: 123975 RVA: 0x0088790C File Offset: 0x00885B0C
	public unsafe override bool 移动主控()
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601E448 RID: 123976 RVA: 0x00887984 File Offset: 0x00885B84
	public unsafe override bool 检查状态机状态(ref TArray<string> states)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601E449 RID: 123977 RVA: 0x00887A18 File Offset: 0x00885C18
	public unsafe override void 切换状态机状态(ref TArray<string> states)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E44A RID: 123978 RVA: 0x00887AA8 File Offset: 0x00885CA8
	public unsafe override bool GetCoolDownDone(int id)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601E44B RID: 123979 RVA: 0x00887B28 File Offset: 0x00885D28
	public unsafe override float GetCoolDownRemainTime(int id)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601E44C RID: 123980 RVA: 0x00887BA8 File Offset: 0x00885DA8
	public unsafe override void SetCoolDown(int id, float cd)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E44D RID: 123981 RVA: 0x00887C28 File Offset: 0x00885E28
	public unsafe override void InitCooldownEvent(int id, UKuroBooleanEventBinder eventBinder)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E44E RID: 123982 RVA: 0x00887CB4 File Offset: 0x00885EB4
	public unsafe override void StartCooldownTimer(int id, float duration)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E44F RID: 123983 RVA: 0x00887D34 File Offset: 0x00885F34
	public unsafe override void GetDebugStateMachine(ref TArray<FText> output)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601E450 RID: 123984 RVA: 0x00887DC4 File Offset: 0x00885FC4
	public unsafe override FText GetDebugText()
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		FText result = new FText(&ptr2->__Result, true, true);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}
}
