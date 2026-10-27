using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BF RID: 447
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyIgnoreLookInput.TsAnimNotifyIgnoreLookInput_C")]
public class TsAnimNotifyIgnoreLookInput : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700047F RID: 1151
	// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0008F6CF File Offset: 0x0008D8CF
	// (set) Token: 0x06001C0A RID: 7178 RVA: 0x0008F6DF File Offset: 0x0008D8DF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool bIgnoreLookInput
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyIgnoreLookInput.__PropertyOffset_bIgnoreLookInput) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyIgnoreLookInput.__PropertyOffset_bIgnoreLookInput) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x0008F6F0 File Offset: 0x0008D8F0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_Notify"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotify.__K2_Notify_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x0008F790 File Offset: 0x0008D990
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsCharacterController characterController = Global.CharacterController;
		if (characterController != null && characterController.IsValid() && characterController.IsLookInputIgnored() != this.bIgnoreLookInput)
		{
			characterController.SetIgnoreLookInput(this.bIgnoreLookInput);
		}
		return true;
	}

	// Token: 0x06001C0D RID: 7181 RVA: 0x0008F7CC File Offset: 0x0008D9CC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x06001C0E RID: 7182 RVA: 0x0008F847 File Offset: 0x0008DA47
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "设置禁用镜头输入";
	}

	// Token: 0x06001C0F RID: 7183 RVA: 0x0008F84E File Offset: 0x0008DA4E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyIgnoreLookInput._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyIgnoreLookInput.TsAnimNotifyIgnoreLookInput_C");
		}
		return TsAnimNotifyIgnoreLookInput._ClassPtr;
	}

	// Token: 0x06001C10 RID: 7184 RVA: 0x0008F874 File Offset: 0x0008DA74
	public TsAnimNotifyIgnoreLookInput() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyIgnoreLookInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C11 RID: 7185 RVA: 0x0008F89C File Offset: 0x0008DA9C
	[NullableContext(1)]
	public TsAnimNotifyIgnoreLookInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyIgnoreLookInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C12 RID: 7186 RVA: 0x0008F8CF File Offset: 0x0008DACF
	protected TsAnimNotifyIgnoreLookInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C13 RID: 7187 RVA: 0x0008F8D8 File Offset: 0x0008DAD8
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C14 RID: 7188 RVA: 0x0008F90B File Offset: 0x0008DB0B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011C2 RID: 4546
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyIgnoreLookInput.TsAnimNotifyIgnoreLookInput_C";

	// Token: 0x040011C3 RID: 4547
	private static IntPtr _ClassPtr;

	// Token: 0x040011C4 RID: 4548
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011C5 RID: 4549
	private static int __PropertyOffset_bIgnoreLookInput;
}
