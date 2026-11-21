using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001BF RID: 447
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootprint.TsAnimNotifyFootprint_C")]
public class TsAnimNotifyFootprint : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000498 RID: 1176
	// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0009561B File Offset: 0x0009381B
	// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0009562B File Offset: 0x0009382B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsLeftFoot
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyFootprint.__PropertyOffset_IsLeftFoot) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyFootprint.__PropertyOffset_IsLeftFoot) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x0009563C File Offset: 0x0009383C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFootprint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyFootprint.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C6F RID: 7279 RVA: 0x000956F4 File Offset: 0x000938F4
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		CharacterFootEffectComponent characterFootEffectComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterFootEffectComponent>() : null;
		if (characterFootEffectComponent == null)
		{
			return false;
		}
		characterFootEffectComponent.TriggerFootprint(this.IsLeftFoot);
		return true;
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x0009573C File Offset: 0x0009393C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyFootprint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyFootprint.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001C71 RID: 7281 RVA: 0x000957CC File Offset: 0x000939CC
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "脚印特效";
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x000957D3 File Offset: 0x000939D3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyFootprint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootprint.TsAnimNotifyFootprint_C");
		}
		return TsAnimNotifyFootprint._ClassPtr;
	}

	// Token: 0x06001C73 RID: 7283 RVA: 0x000957F8 File Offset: 0x000939F8
	public TsAnimNotifyFootprint() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFootprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x00095820 File Offset: 0x00093A20
	[NullableContext(1)]
	public TsAnimNotifyFootprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyFootprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x00095853 File Offset: 0x00093A53
	protected TsAnimNotifyFootprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x0009585C File Offset: 0x00093A5C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x0009588F File Offset: 0x00093A8F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011F0 RID: 4592
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyFootprint.TsAnimNotifyFootprint_C";

	// Token: 0x040011F1 RID: 4593
	private static IntPtr _ClassPtr;

	// Token: 0x040011F2 RID: 4594
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011F3 RID: 4595
	private static int __PropertyOffset_IsLeftFoot;
}
