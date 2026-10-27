using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003466 RID: 13414
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateScreenEffect.AnimNotifyStateScreenEffect_C")]
public class AnimNotifyStateScreenEffect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700280C RID: 10252
	// (get) Token: 0x0601D169 RID: 119145 RVA: 0x0081BEC0 File Offset: 0x0081A0C0
	// (set) Token: 0x0601D16A RID: 119146 RVA: 0x0081BEF9 File Offset: 0x0081A0F9
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<EffectScreenPlayData_C> EffectDataAssetRef
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<EffectScreenPlayData_C> result;
			if ((result = this._EffectDataAssetRef) == null)
			{
				result = (this._EffectDataAssetRef = new TSoftObjectPtr<EffectScreenPlayData_C>(base.NativePtr + (IntPtr)AnimNotifyStateScreenEffect.__PropertyOffset_EffectDataAssetRef, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)AnimNotifyStateScreenEffect.__PropertyOffset_EffectDataAssetRef, 1);
		}
	}

	// Token: 0x1700280D RID: 10253
	// (get) Token: 0x0601D16B RID: 119147 RVA: 0x0081BF1E File Offset: 0x0081A11E
	// (set) Token: 0x0601D16C RID: 119148 RVA: 0x0081BF2E File Offset: 0x0081A12E
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float HandleId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateScreenEffect.__PropertyOffset_HandleId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateScreenEffect.__PropertyOffset_HandleId) = value;
		}
	}

	// Token: 0x1700280E RID: 10254
	// (get) Token: 0x0601D16D RID: 119149 RVA: 0x0081BF3F File Offset: 0x0081A13F
	// (set) Token: 0x0601D16E RID: 119150 RVA: 0x0081BF53 File Offset: 0x0081A153
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe EffectScreenPlayData_C EffectData
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<EffectScreenPlayData_C>(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyStateScreenEffect.__PropertyOffset_EffectData);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AnimNotifyStateScreenEffect.__PropertyOffset_EffectData, value);
		}
	}

	// Token: 0x0601D16F RID: 119151 RVA: 0x0081BF68 File Offset: 0x0081A168
	[NullableContext(2)]
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

	// Token: 0x0601D170 RID: 119152 RVA: 0x0081C010 File Offset: 0x0081A210
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.EffectDataAssetRef == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			EntityHandle entityById = CreatureModel.Instance.GetEntityById(tsBaseCharacter.EntityId);
			if (entityById != null && entityById.Valid && !CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(entityById))
			{
				return false;
			}
		}
		bool flag = owner is TsUiSceneRoleActor;
		bool flag2 = owner is TsSkeletalObserver;
		if (!flag && !flag2)
		{
			this.HandleId = (float)ScreenEffectModel.Instance.PlayScreenEffect(this.EffectDataAssetRef.ToAssetPathName(), null, null);
			return true;
		}
		this.HandleId = (float)ResourceSystem.Instance.LoadAsync<EffectScreenPlayData_C>(this.EffectDataAssetRef.ToAssetPathName(), delegate([Nullable(2)] EffectScreenPlayData_C res, string _)
		{
			this.EffectData = res;
			ScreenEffectSystem.GetInstance().PlayScreenEffectNoPaused(res);
		}, ResourceSystem.EResourceLoadPriority.Ui, null);
		return true;
	}

	// Token: 0x0601D171 RID: 119153 RVA: 0x0081C0D0 File Offset: 0x0081A2D0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyEnd"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L);
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

	// Token: 0x0601D172 RID: 119154 RVA: 0x0081C170 File Offset: 0x0081A370
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.EffectDataAssetRef == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		bool flag = owner is TsUiSceneRoleActor;
		bool flag2 = owner is TsSkeletalObserver;
		if (!flag && !flag2)
		{
			ScreenEffectModel.Instance.EndScreenEffect((int)this.HandleId);
			this.HandleId = 0f;
			return true;
		}
		if (this.EffectData != null)
		{
			ScreenEffectSystem.GetInstance().EndScreenEffect(this.EffectData);
		}
		if (this.HandleId != 0f)
		{
			ResourceSystem.Instance.CancelAsyncLoad((int)this.HandleId);
			this.HandleId = 0f;
		}
		return true;
	}

	// Token: 0x0601D173 RID: 119155 RVA: 0x0081C20C File Offset: 0x0081A40C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotifyState.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x0601D174 RID: 119156 RVA: 0x0081C288 File Offset: 0x0081A488
	protected override string GetNotifyName_Implementation()
	{
		TSoftObjectPtr<EffectScreenPlayData_C> effectDataAssetRef = this.EffectDataAssetRef;
		string text = (effectDataAssetRef != null) ? effectDataAssetRef.ToAssetPathName() : null;
		if (!string.IsNullOrEmpty(text))
		{
			return UBlueprintPathsLibrary.GetBaseFilename(text, true);
		}
		return "屏幕特效数据状态";
	}

	// Token: 0x0601D175 RID: 119157 RVA: 0x0081C2BD File Offset: 0x0081A4BD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateScreenEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateScreenEffect.AnimNotifyStateScreenEffect_C");
		}
		return AnimNotifyStateScreenEffect._ClassPtr;
	}

	// Token: 0x0601D176 RID: 119158 RVA: 0x0081C2E4 File Offset: 0x0081A4E4
	public AnimNotifyStateScreenEffect() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateScreenEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D177 RID: 119159 RVA: 0x0081C30C File Offset: 0x0081A50C
	public AnimNotifyStateScreenEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateScreenEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D178 RID: 119160 RVA: 0x0081C33F File Offset: 0x0081A53F
	protected AnimNotifyStateScreenEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D179 RID: 119161 RVA: 0x0081C348 File Offset: 0x0081A548
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601D17A RID: 119162 RVA: 0x0081C384 File Offset: 0x0081A584
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601D17B RID: 119163 RVA: 0x0081C3B7 File Offset: 0x0081A5B7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E501 RID: 58625
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateScreenEffect.AnimNotifyStateScreenEffect_C";

	// Token: 0x0400E502 RID: 58626
	private static IntPtr _ClassPtr;

	// Token: 0x0400E503 RID: 58627
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E504 RID: 58628
	private static int __PropertyOffset_EffectDataAssetRef;

	// Token: 0x0400E505 RID: 58629
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<EffectScreenPlayData_C> _EffectDataAssetRef;

	// Token: 0x0400E506 RID: 58630
	private static int __PropertyOffset_HandleId;

	// Token: 0x0400E507 RID: 58631
	private static int __PropertyOffset_EffectData;
}
