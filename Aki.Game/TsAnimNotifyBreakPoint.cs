using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019E RID: 414
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakPoint.TsAnimNotifyBreakPoint_C")]
public class TsAnimNotifyBreakPoint : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001AB2 RID: 6834 RVA: 0x0008F364 File Offset: 0x0008D564
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBreakPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBreakPoint.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001AB3 RID: 6835 RVA: 0x0008F41C File Offset: 0x0008D61C
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterInputComponent component = tsBaseCharacter.CharacterActorComponent.Entity.GetComponent<CharacterInputComponent>();
			if (component != null)
			{
				component.AnimBreakPoint();
			}
		}
		return true;
	}

	// Token: 0x06001AB4 RID: 6836 RVA: 0x0008F454 File Offset: 0x0008D654
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBreakPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBreakPoint.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001AB5 RID: 6837 RVA: 0x0008F4E4 File Offset: 0x0008D6E4
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "打断点（强制执行一次按键缓存检测）";
	}

	// Token: 0x06001AB6 RID: 6838 RVA: 0x0008F4EB File Offset: 0x0008D6EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBreakPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakPoint.TsAnimNotifyBreakPoint_C");
		}
		return TsAnimNotifyBreakPoint._ClassPtr;
	}

	// Token: 0x06001AB7 RID: 6839 RVA: 0x0008F510 File Offset: 0x0008D710
	public TsAnimNotifyBreakPoint() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001AB8 RID: 6840 RVA: 0x0008F538 File Offset: 0x0008D738
	[NullableContext(1)]
	public TsAnimNotifyBreakPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBreakPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001AB9 RID: 6841 RVA: 0x0008F56B File Offset: 0x0008D76B
	protected TsAnimNotifyBreakPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001ABA RID: 6842 RVA: 0x0008F574 File Offset: 0x0008D774
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001ABB RID: 6843 RVA: 0x0008F5A7 File Offset: 0x0008D7A7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001145 RID: 4421
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBreakPoint.TsAnimNotifyBreakPoint_C";

	// Token: 0x04001146 RID: 4422
	private static IntPtr _ClassPtr;

	// Token: 0x04001147 RID: 4423
	private static IntPtr _ClassDefaultObjectPtr;
}
