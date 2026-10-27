using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003322 RID: 13090
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyAddCharRendering.TsAnimNotifyAddCharRendering_C")]
public class TsAnimNotifyAddCharRendering : UKuroAnimNotify, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700278B RID: 10123
	// (get) Token: 0x0601C833 RID: 116787 RVA: 0x007FF6B7 File Offset: 0x007FD8B7
	// (set) Token: 0x0601C834 RID: 116788 RVA: 0x007FF6C7 File Offset: 0x007FD8C7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharacterRenderingType RenderType
	{
		get
		{
			return (ECharacterRenderingType)(*(base.NativePtr + (IntPtr)TsAnimNotifyAddCharRendering.__PropertyOffset_RenderType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAddCharRendering.__PropertyOffset_RenderType) = (byte)value;
		}
	}

	// Token: 0x0601C835 RID: 116789 RVA: 0x007FF6D8 File Offset: 0x007FD8D8
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

	// Token: 0x0601C836 RID: 116790 RVA: 0x007FF778 File Offset: 0x007FD978
	[NullableContext(1)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (meshComp == null)
		{
			return false;
		}
		AKuroRecordCharacter akuroRecordCharacter = meshComp.GetOwner() as AKuroRecordCharacter;
		if (akuroRecordCharacter == null)
		{
			return false;
		}
		AActor aactor = akuroRecordCharacter;
		TSubclassOf<UActorComponent> @class = CharRenderingComponent.StaticClass();
		bool bManualAttachment = false;
		FTransformDouble ftransformDouble = akuroRecordCharacter.D_GetTransform();
		CharRenderingComponent charRenderingComponent = aactor.D_AddComponentByClass(@class, bManualAttachment, ftransformDouble, false, FNameUtil.GetDynamicFName("CharRenderingComponent") ?? FName.NAME_None) as CharRenderingComponent;
		if (charRenderingComponent == null)
		{
			return false;
		}
		charRenderingComponent.Init(this.RenderType);
		return true;
	}

	// Token: 0x0601C837 RID: 116791 RVA: 0x007FF7F0 File Offset: 0x007FD9F0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAddCharRendering._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyAddCharRendering.TsAnimNotifyAddCharRendering_C");
		}
		return TsAnimNotifyAddCharRendering._ClassPtr;
	}

	// Token: 0x0601C838 RID: 116792 RVA: 0x007FF814 File Offset: 0x007FDA14
	public TsAnimNotifyAddCharRendering() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddCharRendering.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C839 RID: 116793 RVA: 0x007FF83C File Offset: 0x007FDA3C
	[NullableContext(1)]
	public TsAnimNotifyAddCharRendering(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddCharRendering.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C83A RID: 116794 RVA: 0x007FF86F File Offset: 0x007FDA6F
	protected TsAnimNotifyAddCharRendering(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C83B RID: 116795 RVA: 0x007FF878 File Offset: 0x007FDA78
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E28A RID: 57994
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyAddCharRendering.TsAnimNotifyAddCharRendering_C";

	// Token: 0x0400E28B RID: 57995
	private static IntPtr _ClassPtr;

	// Token: 0x0400E28C RID: 57996
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E28D RID: 57997
	private static int __PropertyOffset_RenderType;
}
