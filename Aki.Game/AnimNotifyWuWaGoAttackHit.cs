using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.WuwaGo;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020022D7 RID: 8919
[UClass("/Game/Aki/TypeScript/Game/Module/WuwaGo/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Module/WuwaGo/AnimNotify/AnimNotifyWuWaGoAttackHit.AnimNotifyWuWaGoAttackHit_C")]
public class AnimNotifyWuWaGoAttackHit : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601604F RID: 90191 RVA: 0x00660AB8 File Offset: 0x0065ECB8
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyWuWaGoAttackHit) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), AnimNotifyWuWaGoAttackHit.StaticClass(), out intPtr, out num))
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

	// Token: 0x06016050 RID: 90192 RVA: 0x00660B70 File Offset: 0x0065ED70
	[NullableContext(2)]
	protected bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (owner == null || !owner.IsValid())
		{
			return false;
		}
		WuWaGoFactory.DispatchAttackHit(owner);
		return true;
	}

	// Token: 0x06016051 RID: 90193 RVA: 0x00660B9E File Offset: 0x0065ED9E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyWuWaGoAttackHit._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Module/WuwaGo/AnimNotify/AnimNotifyWuWaGoAttackHit.AnimNotifyWuWaGoAttackHit_C");
		}
		return AnimNotifyWuWaGoAttackHit._ClassPtr;
	}

	// Token: 0x06016052 RID: 90194 RVA: 0x00660BC4 File Offset: 0x0065EDC4
	public AnimNotifyWuWaGoAttackHit() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyWuWaGoAttackHit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06016053 RID: 90195 RVA: 0x00660BEC File Offset: 0x0065EDEC
	[NullableContext(1)]
	public AnimNotifyWuWaGoAttackHit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyWuWaGoAttackHit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06016054 RID: 90196 RVA: 0x00660C1F File Offset: 0x0065EE1F
	protected AnimNotifyWuWaGoAttackHit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06016055 RID: 90197 RVA: 0x00660C28 File Offset: 0x0065EE28
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400B8E6 RID: 47334
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Module/WuwaGo/AnimNotify/AnimNotifyWuWaGoAttackHit.AnimNotifyWuWaGoAttackHit_C";

	// Token: 0x0400B8E7 RID: 47335
	private static IntPtr _ClassPtr;

	// Token: 0x0400B8E8 RID: 47336
	private static IntPtr _ClassDefaultObjectPtr;
}
