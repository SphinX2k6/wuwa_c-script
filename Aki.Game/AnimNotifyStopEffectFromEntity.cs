using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003468 RID: 13416
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStopEffectFromEntity.AnimNotifyStopEffectFromEntity_C")]
public class AnimNotifyStopEffectFromEntity : UKuroEffectMakerAN, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002812 RID: 10258
	// (get) Token: 0x0601D190 RID: 119184 RVA: 0x0081C984 File Offset: 0x0081AB84
	// (set) Token: 0x0601D191 RID: 119185 RVA: 0x0081C9BD File Offset: 0x0081ABBD
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectDataAssetRef
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectDataAssetRef) == null)
			{
				result = (this._EffectDataAssetRef = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)AnimNotifyStopEffectFromEntity.__PropertyOffset_EffectDataAssetRef, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)AnimNotifyStopEffectFromEntity.__PropertyOffset_EffectDataAssetRef, 1);
		}
	}

	// Token: 0x17002813 RID: 10259
	// (get) Token: 0x0601D192 RID: 119186 RVA: 0x0081C9E2 File Offset: 0x0081ABE2
	// (set) Token: 0x0601D193 RID: 119187 RVA: 0x0081C9F2 File Offset: 0x0081ABF2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Immediately
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStopEffectFromEntity.__PropertyOffset_Immediately) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStopEffectFromEntity.__PropertyOffset_Immediately) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601D194 RID: 119188 RVA: 0x0081CA04 File Offset: 0x0081AC04
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

	// Token: 0x0601D195 RID: 119189 RVA: 0x0081CAA4 File Offset: 0x0081ACA4
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		int num = 0;
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			if (((characterActorComponent != null) ? characterActorComponent.Entity : null) != null)
			{
				CharacterActorComponent characterActorComponent2 = tsBaseCharacter.CharacterActorComponent;
				num = ((characterActorComponent2 != null) ? characterActorComponent2.Entity.Id : 0);
				goto IL_55;
			}
		}
		AEffectSystemActor aeffectSystemActor = owner as AEffectSystemActor;
		if (aeffectSystemActor != null)
		{
			num = aeffectSystemActor.GetOwnerEntityId();
		}
		IL_55:
		if (num == 0)
		{
			return true;
		}
		string text = this.EffectDataAssetRef.ToAssetPathName();
		if (text == null)
		{
			return true;
		}
		UKuroEffectSystemFunctionLibrary.StopEffectFromEntity(num, text, this.Immediately);
		return true;
	}

	// Token: 0x0601D196 RID: 119190 RVA: 0x0081CB2F File Offset: 0x0081AD2F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStopEffectFromEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStopEffectFromEntity.AnimNotifyStopEffectFromEntity_C");
		}
		return AnimNotifyStopEffectFromEntity._ClassPtr;
	}

	// Token: 0x0601D197 RID: 119191 RVA: 0x0081CB54 File Offset: 0x0081AD54
	public AnimNotifyStopEffectFromEntity() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D198 RID: 119192 RVA: 0x0081CB7C File Offset: 0x0081AD7C
	public AnimNotifyStopEffectFromEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D199 RID: 119193 RVA: 0x0081CBAF File Offset: 0x0081ADAF
	protected AnimNotifyStopEffectFromEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D19A RID: 119194 RVA: 0x0081CBB8 File Offset: 0x0081ADB8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E510 RID: 58640
	[StaticVariableRuleIgnore]
	private static readonly Stat NotifyStat = Stat.Create("AnimNotifyStopEffectFromEntity_K2_Notify", "", "");

	// Token: 0x0400E511 RID: 58641
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStopEffectFromEntity.AnimNotifyStopEffectFromEntity_C";

	// Token: 0x0400E512 RID: 58642
	private static IntPtr _ClassPtr;

	// Token: 0x0400E513 RID: 58643
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E514 RID: 58644
	private static int __PropertyOffset_EffectDataAssetRef;

	// Token: 0x0400E515 RID: 58645
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectDataAssetRef;

	// Token: 0x0400E516 RID: 58646
	private static int __PropertyOffset_Immediately;
}
