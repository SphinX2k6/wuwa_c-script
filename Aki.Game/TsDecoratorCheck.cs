using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000017 RID: 23
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheck.TsDecoratorCheck_C")]
public class TsDecoratorCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000069 RID: 105 RVA: 0x000036DF File Offset: 0x000018DF
	// (set) Token: 0x0600006A RID: 106 RVA: 0x000036F3 File Offset: 0x000018F3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string CheckValue
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorCheck.__PropertyOffset_CheckValue)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorCheck.__PropertyOffset_CheckValue)), value);
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003708 File Offset: 0x00001908
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x000037A7 File Offset: 0x000019A7
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		return true;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000037AA File Offset: 0x000019AA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheck.TsDecoratorCheck_C");
		}
		return TsDecoratorCheck._ClassPtr;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000037D0 File Offset: 0x000019D0
	public TsDecoratorCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000037F8 File Offset: 0x000019F8
	public TsDecoratorCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000382B File Offset: 0x00001A2B
	protected TsDecoratorCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00003834 File Offset: 0x00001A34
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400003F RID: 63
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheck.TsDecoratorCheck_C";

	// Token: 0x04000040 RID: 64
	private static IntPtr _ClassPtr;

	// Token: 0x04000041 RID: 65
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000042 RID: 66
	private static int __PropertyOffset_CheckValue;
}
