using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029FC RID: 10748
[UClass("/Game/Aki/TypeScript/Game/Render/Scene/Item/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Scene/Item/AnimNotifyDaiyuAnimEnd.AnimNotifyDaiyuAnimEnd_C")]
public class AnimNotifyDaiyuAnimEnd : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601AF78 RID: 110456 RVA: 0x00846DF4 File Offset: 0x00844FF4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyDaiyuAnimEnd) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), AnimNotifyDaiyuAnimEnd.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AF79 RID: 110457 RVA: 0x00846EAC File Offset: 0x008450AC
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

	// Token: 0x0601AF7A RID: 110458 RVA: 0x00846EEB File Offset: 0x008450EB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyDaiyuAnimEnd._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Scene/Item/AnimNotifyDaiyuAnimEnd.AnimNotifyDaiyuAnimEnd_C");
		}
		return AnimNotifyDaiyuAnimEnd._ClassPtr;
	}

	// Token: 0x0601AF7B RID: 110459 RVA: 0x00846F10 File Offset: 0x00845110
	public AnimNotifyDaiyuAnimEnd() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDaiyuAnimEnd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AF7C RID: 110460 RVA: 0x00846F38 File Offset: 0x00845138
	[NullableContext(1)]
	public AnimNotifyDaiyuAnimEnd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyDaiyuAnimEnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AF7D RID: 110461 RVA: 0x00846F6B File Offset: 0x0084516B
	protected AnimNotifyDaiyuAnimEnd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AF7E RID: 110462 RVA: 0x00846F74 File Offset: 0x00845174
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400EA6D RID: 60013
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Scene/Item/AnimNotifyDaiyuAnimEnd.AnimNotifyDaiyuAnimEnd_C";

	// Token: 0x0400EA6E RID: 60014
	private static IntPtr _ClassPtr;

	// Token: 0x0400EA6F RID: 60015
	private static IntPtr _ClassDefaultObjectPtr;
}
