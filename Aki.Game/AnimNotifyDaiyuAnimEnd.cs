using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003488 RID: 13448
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/AnimNotifyDaiyuAnimEnd.AnimNotifyDaiyuAnimEnd_C")]
public class AnimNotifyDaiyuAnimEnd : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601D271 RID: 119409 RVA: 0x0081FB00 File Offset: 0x0081DD00
	[NullableContext(1)]
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

	// Token: 0x0601D272 RID: 119410 RVA: 0x0081FBA0 File Offset: 0x0081DDA0
	[NullableContext(1)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (!meshComp.IsVisible())
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		SceneInteractionActor sceneInteractionActor = ((owner != null) ? owner.GetAttachParentActor() : null) as SceneInteractionActor;
		if (sceneInteractionActor != null)
		{
			sceneInteractionActor.OnAnimPlayEnd(animation.GetName());
		}
		return true;
	}

	// Token: 0x0601D273 RID: 119411 RVA: 0x0081FBDF File Offset: 0x0081DDDF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyDaiyuAnimEnd._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/AnimNotifyDaiyuAnimEnd.AnimNotifyDaiyuAnimEnd_C");
		}
		return AnimNotifyDaiyuAnimEnd._ClassPtr;
	}

	// Token: 0x0601D274 RID: 119412 RVA: 0x0081FC04 File Offset: 0x0081DE04
	public AnimNotifyDaiyuAnimEnd() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDaiyuAnimEnd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D275 RID: 119413 RVA: 0x0081FC2C File Offset: 0x0081DE2C
	[NullableContext(1)]
	public AnimNotifyDaiyuAnimEnd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDaiyuAnimEnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D276 RID: 119414 RVA: 0x0081FC5F File Offset: 0x0081DE5F
	protected AnimNotifyDaiyuAnimEnd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D277 RID: 119415 RVA: 0x0081FC68 File Offset: 0x0081DE68
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E5B6 RID: 58806
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/AnimNotifyDaiyuAnimEnd.AnimNotifyDaiyuAnimEnd_C";

	// Token: 0x0400E5B7 RID: 58807
	private static IntPtr _ClassPtr;

	// Token: 0x0400E5B8 RID: 58808
	private static IntPtr _ClassDefaultObjectPtr;
}
