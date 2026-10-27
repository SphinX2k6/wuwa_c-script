using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200006A RID: 106
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcDisableEntityLookAt.TsTaskNpcDisableEntityLookAt_C")]
public class TsTaskNpcDisableEntityLookAt : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000483 RID: 1155 RVA: 0x00015938 File Offset: 0x00013B38
	// (set) Token: 0x06000484 RID: 1156 RVA: 0x0001594C File Offset: 0x00013B4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string Key
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcDisableEntityLookAt.__PropertyOffset_Key)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskNpcDisableEntityLookAt.__PropertyOffset_Key)), value);
		}
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00015964 File Offset: 0x00013B64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00015A00 File Offset: 0x00013C00
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if (this.Key == "")
		{
			base.FinishExecute(true);
			return;
		}
		if (!NpcPerformController.Instance.EntityLookAtCacheForKey.ContainsKey(this.Key))
		{
			base.FinishExecute(true);
			return;
		}
		NpcPerformController.Instance.RemoveNpcLookAtParams(this.Key);
		base.FinishExecute(true);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00015A5D File Offset: 0x00013C5D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskNpcDisableEntityLookAt._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcDisableEntityLookAt.TsTaskNpcDisableEntityLookAt_C");
		}
		return TsTaskNpcDisableEntityLookAt._ClassPtr;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00015A84 File Offset: 0x00013C84
	public TsTaskNpcDisableEntityLookAt() : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcDisableEntityLookAt.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00015AAC File Offset: 0x00013CAC
	public TsTaskNpcDisableEntityLookAt(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskNpcDisableEntityLookAt.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00015ADF File Offset: 0x00013CDF
	protected TsTaskNpcDisableEntityLookAt(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00015AE8 File Offset: 0x00013CE8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400031D RID: 797
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/LevelAiTask/TsTaskNpcDisableEntityLookAt.TsTaskNpcDisableEntityLookAt_C";

	// Token: 0x0400031E RID: 798
	private static IntPtr _ClassPtr;

	// Token: 0x0400031F RID: 799
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000320 RID: 800
	private static int __PropertyOffset_Key;
}
