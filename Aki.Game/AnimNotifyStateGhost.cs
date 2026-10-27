using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02003465 RID: 13413
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateGhost.AnimNotifyStateGhost_C")]
public class AnimNotifyStateGhost : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002806 RID: 10246
	// (get) Token: 0x0601D14D RID: 119117 RVA: 0x0081B7E8 File Offset: 0x008199E8
	// (set) Token: 0x0601D14E RID: 119118 RVA: 0x0081B821 File Offset: 0x00819A21
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UEffectModelBase> EffectDataAssetRef
	{
		[NullableContext(1)]
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UEffectModelBase> result;
			if ((result = this._EffectDataAssetRef) == null)
			{
				result = (this._EffectDataAssetRef = new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_EffectDataAssetRef, this));
			}
			return result;
		}
		[NullableContext(1)]
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_EffectDataAssetRef, 1);
		}
	}

	// Token: 0x17002807 RID: 10247
	// (get) Token: 0x0601D14F RID: 119119 RVA: 0x0081B846 File Offset: 0x00819A46
	// (set) Token: 0x0601D150 RID: 119120 RVA: 0x0081B856 File Offset: 0x00819A56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SpawnRate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_SpawnRate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_SpawnRate) = value;
		}
	}

	// Token: 0x17002808 RID: 10248
	// (get) Token: 0x0601D151 RID: 119121 RVA: 0x0081B867 File Offset: 0x00819A67
	// (set) Token: 0x0601D152 RID: 119122 RVA: 0x0081B877 File Offset: 0x00819A77
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseSpawnRate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_UseSpawnRate) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_UseSpawnRate) = (value ? 1 : 0);
		}
	}

	// Token: 0x17002809 RID: 10249
	// (get) Token: 0x0601D153 RID: 119123 RVA: 0x0081B888 File Offset: 0x00819A88
	// (set) Token: 0x0601D154 RID: 119124 RVA: 0x0081B898 File Offset: 0x00819A98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float SpawnInterval
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_SpawnInterval);
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_SpawnInterval) = value;
		}
	}

	// Token: 0x1700280A RID: 10250
	// (get) Token: 0x0601D155 RID: 119125 RVA: 0x0081B8A9 File Offset: 0x00819AA9
	// (set) Token: 0x0601D156 RID: 119126 RVA: 0x0081B8B9 File Offset: 0x00819AB9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float GhostLifeTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_GhostLifeTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_GhostLifeTime) = value;
		}
	}

	// Token: 0x1700280B RID: 10251
	// (get) Token: 0x0601D157 RID: 119127 RVA: 0x0081B8CA File Offset: 0x00819ACA
	// (set) Token: 0x0601D158 RID: 119128 RVA: 0x0081B8DA File Offset: 0x00819ADA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseBaseColorTex
	{
		get
		{
			return *(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_UseBaseColorTex) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)AnimNotifyStateGhost.__PropertyOffset_UseBaseColorTex) = (value ? 1 : 0);
		}
	}

	// Token: 0x0601D159 RID: 119129 RVA: 0x0081B8EC File Offset: 0x00819AEC
	[NullableContext(1)]
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

	// Token: 0x0601D15A RID: 119130 RVA: 0x0081B967 File Offset: 0x00819B67
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色残影";
	}

	// Token: 0x0601D15B RID: 119131 RVA: 0x0081B970 File Offset: 0x00819B70
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_ValidateAssets()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_ValidateAssets"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601D15C RID: 119132 RVA: 0x0081B9E5 File Offset: 0x00819BE5
	protected virtual bool K2_ValidateAssets_Implementation()
	{
		return true;
	}

	// Token: 0x0601D15D RID: 119133 RVA: 0x0081B9E8 File Offset: 0x00819BE8
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

	// Token: 0x0601D15E RID: 119134 RVA: 0x0081BA90 File Offset: 0x00819C90
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.EffectHandleMap == null)
		{
			this.EffectHandleMap = new Dictionary<USkeletalMeshComponent, int>();
		}
		EffectSystem.Instance.InitializeWithPreview(false);
		AActor owner = meshComp.GetOwner();
		EffectRuntimeGhostEffectContext effectRuntimeGhostEffectContext = new EffectRuntimeGhostEffectContext(null, null, false);
		string text = this.EffectDataAssetRef.ToAssetPathName();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			effectRuntimeGhostEffectContext.EntityId = new int?(tsBaseCharacter.GetEntityIdNoBlueprint());
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			text = (((characterActorComponent != null) ? characterActorComponent.GetReplaceEffect(text) : null) ?? text);
		}
		else
		{
			TsBaseVehicle tsBaseVehicle = owner as TsBaseVehicle;
			if (tsBaseVehicle != null)
			{
				effectRuntimeGhostEffectContext.EntityId = new int?(tsBaseVehicle.GetEntityIdNoBlueprint());
				VehicleActorComponent vehicleActorComponent = tsBaseVehicle.VehicleActorComponent;
				text = (((vehicleActorComponent != null) ? vehicleActorComponent.GetReplaceEffect(text) : null) ?? text);
			}
		}
		effectRuntimeGhostEffectContext.SkeletalMeshComp = meshComp;
		effectRuntimeGhostEffectContext.SpawnRate = this.SpawnRate;
		effectRuntimeGhostEffectContext.UseSpawnRate = this.UseSpawnRate;
		effectRuntimeGhostEffectContext.SpawnInterval = this.SpawnInterval;
		effectRuntimeGhostEffectContext.GhostLifeTime = this.GhostLifeTime;
		effectRuntimeGhostEffectContext.UseBaseColorTex = this.UseBaseColorTex;
		effectRuntimeGhostEffectContext.SourceObject = owner;
		int? num = null;
		EffectSystem instance = EffectSystem.Instance;
		UObject worldContext = owner;
		FRotator frotator = new FRotator();
		FVectorDouble fvectorDouble = owner.D_K2_GetActorLocation();
		FVectorDouble fvectorDouble2 = new FVectorDouble(1.0, 1.0, 1.0);
		FVector fvector = fvectorDouble2;
		FTransformDouble? ftransformDouble = new FTransformDouble?(new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector));
		num = new int?(instance.SpawnEffect(worldContext, ftransformDouble, text, "[AnimNotifyStateGhost.K2_NotifyBegin]", effectRuntimeGhostEffectContext, EEffectType.Fight, null, null, null, false, false));
		TsBaseCharacter tsBaseCharacter2 = owner as TsBaseCharacter;
		if (tsBaseCharacter2 != null)
		{
			CharacterActorComponent characterActorComponent2 = tsBaseCharacter2.CharacterActorComponent;
			CharacterSelfCenterComponent characterSelfCenterComponent;
			if (characterActorComponent2 == null)
			{
				characterSelfCenterComponent = null;
			}
			else
			{
				Entity entity = characterActorComponent2.Entity;
				characterSelfCenterComponent = ((entity != null) ? entity.GetComponent<CharacterSelfCenterComponent>() : null);
			}
			CharacterSelfCenterComponent characterSelfCenterComponent2 = characterSelfCenterComponent;
			if (characterSelfCenterComponent2 != null && characterSelfCenterComponent2.Valid)
			{
				characterSelfCenterComponent2.AddEffect(num.Value);
			}
		}
		if (num != null && EffectSystem.Instance.IsValid(num.Value))
		{
			EffectSystem.Instance.SetEffectNotRecord(num.Value, true);
			this.EffectHandleMap[meshComp] = num.Value;
		}
		return false;
	}

	// Token: 0x0601D15F RID: 119135 RVA: 0x0081BC98 File Offset: 0x00819E98
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

	// Token: 0x0601D160 RID: 119136 RVA: 0x0081BD38 File Offset: 0x00819F38
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.EffectHandleMap == null || !this.EffectHandleMap.ContainsKey(meshComp))
		{
			return true;
		}
		int num = this.EffectHandleMap[meshComp];
		if (num != 0 && EffectSystem.Instance.IsValid(num))
		{
			EffectSystem.Instance.StopEffectById(num, "[AnimNotifyStateGhost.K2_NotifyEnd]", false, null);
		}
		this.EffectHandleMap.Remove(meshComp);
		return true;
	}

	// Token: 0x0601D161 RID: 119137 RVA: 0x0081BDA3 File Offset: 0x00819FA3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateGhost._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateGhost.AnimNotifyStateGhost_C");
		}
		return AnimNotifyStateGhost._ClassPtr;
	}

	// Token: 0x0601D162 RID: 119138 RVA: 0x0081BDC8 File Offset: 0x00819FC8
	public AnimNotifyStateGhost() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601D163 RID: 119139 RVA: 0x0081BDF0 File Offset: 0x00819FF0
	[NullableContext(1)]
	public AnimNotifyStateGhost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601D164 RID: 119140 RVA: 0x0081BE23 File Offset: 0x0081A023
	protected AnimNotifyStateGhost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601D165 RID: 119141 RVA: 0x0081BE2C File Offset: 0x0081A02C
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0601D166 RID: 119142 RVA: 0x0081BE40 File Offset: 0x0081A040
	protected unsafe virtual void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = this.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601D167 RID: 119143 RVA: 0x0081BE50 File Offset: 0x0081A050
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601D168 RID: 119144 RVA: 0x0081BE8C File Offset: 0x0081A08C
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E4F6 RID: 58614
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<USkeletalMeshComponent, int> EffectHandleMap;

	// Token: 0x0400E4F7 RID: 58615
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateGhost.AnimNotifyStateGhost_C";

	// Token: 0x0400E4F8 RID: 58616
	private static IntPtr _ClassPtr;

	// Token: 0x0400E4F9 RID: 58617
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E4FA RID: 58618
	private static int __PropertyOffset_EffectDataAssetRef;

	// Token: 0x0400E4FB RID: 58619
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectDataAssetRef;

	// Token: 0x0400E4FC RID: 58620
	private static int __PropertyOffset_SpawnRate;

	// Token: 0x0400E4FD RID: 58621
	private static int __PropertyOffset_UseSpawnRate;

	// Token: 0x0400E4FE RID: 58622
	private static int __PropertyOffset_SpawnInterval;

	// Token: 0x0400E4FF RID: 58623
	private static int __PropertyOffset_GhostLifeTime;

	// Token: 0x0400E500 RID: 58624
	private static int __PropertyOffset_UseBaseColorTex;
}
