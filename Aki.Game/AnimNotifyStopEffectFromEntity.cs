using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029DC RID: 10716
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStopEffectFromEntity.AnimNotifyStopEffectFromEntity_C")]
public class AnimNotifyStopEffectFromEntity : UKuroEffectMakerAN, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BB1 RID: 11185
	// (get) Token: 0x0601AE98 RID: 110232 RVA: 0x00843C6C File Offset: 0x00841E6C
	// (set) Token: 0x0601AE99 RID: 110233 RVA: 0x00843CA5 File Offset: 0x00841EA5
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

	// Token: 0x17002BB2 RID: 11186
	// (get) Token: 0x0601AE9A RID: 110234 RVA: 0x00843CCA File Offset: 0x00841ECA
	// (set) Token: 0x0601AE9B RID: 110235 RVA: 0x00843CDA File Offset: 0x00841EDA
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

	// Token: 0x0601AE9C RID: 110236 RVA: 0x00843CEC File Offset: 0x00841EEC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStopEffectFromEntity) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), AnimNotifyStopEffectFromEntity.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AE9D RID: 110237 RVA: 0x00843DA4 File Offset: 0x00841FA4
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

	// Token: 0x0601AE9E RID: 110238 RVA: 0x00843E2F File Offset: 0x0084202F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStopEffectFromEntity._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStopEffectFromEntity.AnimNotifyStopEffectFromEntity_C");
		}
		return AnimNotifyStopEffectFromEntity._ClassPtr;
	}

	// Token: 0x0601AE9F RID: 110239 RVA: 0x00843E54 File Offset: 0x00842054
	public AnimNotifyStopEffectFromEntity() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AEA0 RID: 110240 RVA: 0x00843E7C File Offset: 0x0084207C
	public AnimNotifyStopEffectFromEntity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStopEffectFromEntity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AEA1 RID: 110241 RVA: 0x00843EAF File Offset: 0x008420AF
	protected AnimNotifyStopEffectFromEntity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AEA2 RID: 110242 RVA: 0x00843EB8 File Offset: 0x008420B8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E9C8 RID: 59848
	[StaticVariableRuleIgnore]
	private static readonly Stat NotifyStat = Stat.Create("AnimNotifyStopEffectFromEntity_K2_Notify", "", "");

	// Token: 0x0400E9C9 RID: 59849
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStopEffectFromEntity.AnimNotifyStopEffectFromEntity_C";

	// Token: 0x0400E9CA RID: 59850
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9CB RID: 59851
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E9CC RID: 59852
	private static int __PropertyOffset_EffectDataAssetRef;

	// Token: 0x0400E9CD RID: 59853
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectDataAssetRef;

	// Token: 0x0400E9CE RID: 59854
	private static int __PropertyOffset_Immediately;
}
