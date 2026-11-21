using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020029DA RID: 10714
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateScreenEffect.AnimNotifyStateScreenEffect_C")]
public class AnimNotifyStateScreenEffect : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BAB RID: 11179
	// (get) Token: 0x0601AE71 RID: 110193 RVA: 0x0084311C File Offset: 0x0084131C
	// (set) Token: 0x0601AE72 RID: 110194 RVA: 0x00843155 File Offset: 0x00841355
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

	// Token: 0x17002BAC RID: 11180
	// (get) Token: 0x0601AE73 RID: 110195 RVA: 0x0084317A File Offset: 0x0084137A
	// (set) Token: 0x0601AE74 RID: 110196 RVA: 0x0084318A File Offset: 0x0084138A
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

	// Token: 0x17002BAD RID: 11181
	// (get) Token: 0x0601AE75 RID: 110197 RVA: 0x0084319B File Offset: 0x0084139B
	// (set) Token: 0x0601AE76 RID: 110198 RVA: 0x008431AF File Offset: 0x008413AF
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

	// Token: 0x0601AE77 RID: 110199 RVA: 0x008431C4 File Offset: 0x008413C4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateScreenEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), AnimNotifyStateScreenEffect.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyBegin_Implementation(meshComp, animation, totalDuration);
		}
		UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->TotalDuration = totalDuration;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AE78 RID: 110200 RVA: 0x00843284 File Offset: 0x00841484
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

	// Token: 0x0601AE79 RID: 110201 RVA: 0x00843344 File Offset: 0x00841544
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateScreenEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), AnimNotifyStateScreenEffect.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyEnd_Implementation(meshComp, animation);
		}
		UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AE7A RID: 110202 RVA: 0x008433FC File Offset: 0x008415FC
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

	// Token: 0x0601AE7B RID: 110203 RVA: 0x00843498 File Offset: 0x00841698
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateScreenEffect) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyStateScreenEffect.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotifyState.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotifyState.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotifyState.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601AE7C RID: 110204 RVA: 0x00843528 File Offset: 0x00841728
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

	// Token: 0x0601AE7D RID: 110205 RVA: 0x0084355D File Offset: 0x0084175D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateScreenEffect._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateScreenEffect.AnimNotifyStateScreenEffect_C");
		}
		return AnimNotifyStateScreenEffect._ClassPtr;
	}

	// Token: 0x0601AE7E RID: 110206 RVA: 0x00843584 File Offset: 0x00841784
	public AnimNotifyStateScreenEffect() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateScreenEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AE7F RID: 110207 RVA: 0x008435AC File Offset: 0x008417AC
	public AnimNotifyStateScreenEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateScreenEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AE80 RID: 110208 RVA: 0x008435DF File Offset: 0x008417DF
	protected AnimNotifyStateScreenEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AE81 RID: 110209 RVA: 0x008435E8 File Offset: 0x008417E8
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601AE82 RID: 110210 RVA: 0x00843624 File Offset: 0x00841824
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601AE83 RID: 110211 RVA: 0x00843657 File Offset: 0x00841857
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0400E9B9 RID: 59833
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateScreenEffect.AnimNotifyStateScreenEffect_C";

	// Token: 0x0400E9BA RID: 59834
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9BB RID: 59835
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E9BC RID: 59836
	private static int __PropertyOffset_EffectDataAssetRef;

	// Token: 0x0400E9BD RID: 59837
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<EffectScreenPlayData_C> _EffectDataAssetRef;

	// Token: 0x0400E9BE RID: 59838
	private static int __PropertyOffset_HandleId;

	// Token: 0x0400E9BF RID: 59839
	private static int __PropertyOffset_EffectData;
}
