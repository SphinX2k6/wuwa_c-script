using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003323 RID: 13091
[UClass("/Game/Aki/TypeScript/Game/Recorder/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddCharRendering.TsAnimNotifyStateAddCharRendering_C")]
public class TsAnimNotifyStateAddCharRendering : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700278C RID: 10124
	// (get) Token: 0x0601C83C RID: 116796 RVA: 0x007FF8AB File Offset: 0x007FDAAB
	// (set) Token: 0x0601C83D RID: 116797 RVA: 0x007FF8BB File Offset: 0x007FDABB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe ECharacterRenderingType RenderType
	{
		get
		{
			return (ECharacterRenderingType)(*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddCharRendering.__PropertyOffset_RenderType));
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAddCharRendering.__PropertyOffset_RenderType) = (byte)value;
		}
	}

	// Token: 0x0601C83E RID: 116798 RVA: 0x007FF8CC File Offset: 0x007FDACC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyBegin"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->TotalDuration = totalDuration;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601C83F RID: 116799 RVA: 0x007FF974 File Offset: 0x007FDB74
	[NullableContext(1)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
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

	// Token: 0x0601C840 RID: 116800 RVA: 0x007FF9E7 File Offset: 0x007FDBE7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAddCharRendering._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddCharRendering.TsAnimNotifyStateAddCharRendering_C");
		}
		return TsAnimNotifyStateAddCharRendering._ClassPtr;
	}

	// Token: 0x0601C841 RID: 116801 RVA: 0x007FFA0C File Offset: 0x007FDC0C
	public TsAnimNotifyStateAddCharRendering() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddCharRendering.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C842 RID: 116802 RVA: 0x007FFA34 File Offset: 0x007FDC34
	[NullableContext(1)]
	public TsAnimNotifyStateAddCharRendering(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAddCharRendering.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C843 RID: 116803 RVA: 0x007FFA67 File Offset: 0x007FDC67
	protected TsAnimNotifyStateAddCharRendering(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C844 RID: 116804 RVA: 0x007FFA70 File Offset: 0x007FDC70
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0400E28E RID: 57998
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Recorder/TsAnimNotifyStateAddCharRendering.TsAnimNotifyStateAddCharRendering_C";

	// Token: 0x0400E28F RID: 57999
	private static IntPtr _ClassPtr;

	// Token: 0x0400E290 RID: 58000
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E291 RID: 58001
	private static int __PropertyOffset_RenderType;
}
