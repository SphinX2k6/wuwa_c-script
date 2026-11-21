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

// Token: 0x020029D9 RID: 10713
[UClass("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateGhost.AnimNotifyStateGhost_C")]
public class AnimNotifyStateGhost : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17002BA5 RID: 11173
	// (get) Token: 0x0601AE55 RID: 110165 RVA: 0x008429E8 File Offset: 0x00840BE8
	// (set) Token: 0x0601AE56 RID: 110166 RVA: 0x00842A21 File Offset: 0x00840C21
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

	// Token: 0x17002BA6 RID: 11174
	// (get) Token: 0x0601AE57 RID: 110167 RVA: 0x00842A46 File Offset: 0x00840C46
	// (set) Token: 0x0601AE58 RID: 110168 RVA: 0x00842A56 File Offset: 0x00840C56
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

	// Token: 0x17002BA7 RID: 11175
	// (get) Token: 0x0601AE59 RID: 110169 RVA: 0x00842A67 File Offset: 0x00840C67
	// (set) Token: 0x0601AE5A RID: 110170 RVA: 0x00842A77 File Offset: 0x00840C77
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

	// Token: 0x17002BA8 RID: 11176
	// (get) Token: 0x0601AE5B RID: 110171 RVA: 0x00842A88 File Offset: 0x00840C88
	// (set) Token: 0x0601AE5C RID: 110172 RVA: 0x00842A98 File Offset: 0x00840C98
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

	// Token: 0x17002BA9 RID: 11177
	// (get) Token: 0x0601AE5D RID: 110173 RVA: 0x00842AA9 File Offset: 0x00840CA9
	// (set) Token: 0x0601AE5E RID: 110174 RVA: 0x00842AB9 File Offset: 0x00840CB9
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

	// Token: 0x17002BAA RID: 11178
	// (get) Token: 0x0601AE5F RID: 110175 RVA: 0x00842ACA File Offset: 0x00840CCA
	// (set) Token: 0x0601AE60 RID: 110176 RVA: 0x00842ADA File Offset: 0x00840CDA
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

	// Token: 0x0601AE61 RID: 110177 RVA: 0x00842AEC File Offset: 0x00840CEC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateGhost) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), AnimNotifyStateGhost.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AE62 RID: 110178 RVA: 0x00842B7C File Offset: 0x00840D7C
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "角色残影";
	}

	// Token: 0x0601AE63 RID: 110179 RVA: 0x00842B84 File Offset: 0x00840D84
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_ValidateAssets()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateGhost) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_ValidateAssets"), AnimNotifyStateGhost.StaticClass(), out intPtr, out num))
		{
			return this.K2_ValidateAssets_Implementation();
		}
		UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601AE64 RID: 110180 RVA: 0x00842C0E File Offset: 0x00840E0E
	protected virtual bool K2_ValidateAssets_Implementation()
	{
		return true;
	}

	// Token: 0x0601AE65 RID: 110181 RVA: 0x00842C14 File Offset: 0x00840E14
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateGhost) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), AnimNotifyStateGhost.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AE66 RID: 110182 RVA: 0x00842CD4 File Offset: 0x00840ED4
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

	// Token: 0x0601AE67 RID: 110183 RVA: 0x00842EDC File Offset: 0x008410DC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(AnimNotifyStateGhost) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), AnimNotifyStateGhost.StaticClass(), out intPtr, out num))
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

	// Token: 0x0601AE68 RID: 110184 RVA: 0x00842F94 File Offset: 0x00841194
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

	// Token: 0x0601AE69 RID: 110185 RVA: 0x00842FFF File Offset: 0x008411FF
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (AnimNotifyStateGhost._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateGhost.AnimNotifyStateGhost_C");
		}
		return AnimNotifyStateGhost._ClassPtr;
	}

	// Token: 0x0601AE6A RID: 110186 RVA: 0x00843024 File Offset: 0x00841224
	public AnimNotifyStateGhost() : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601AE6B RID: 110187 RVA: 0x0084304C File Offset: 0x0084124C
	[NullableContext(1)]
	public AnimNotifyStateGhost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AnimNotifyStateGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601AE6C RID: 110188 RVA: 0x0084307F File Offset: 0x0084127F
	protected AnimNotifyStateGhost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601AE6D RID: 110189 RVA: 0x00843088 File Offset: 0x00841288
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x0601AE6E RID: 110190 RVA: 0x0084309C File Offset: 0x0084129C
	protected unsafe virtual void __CPPCALL_K2_ValidateAssets_Implementation(UKuroAnimNotifyState.__K2_ValidateAssets_FunctionParams* __Params)
	{
		__Params->__Result = this.K2_ValidateAssets_Implementation();
	}

	// Token: 0x0601AE6F RID: 110191 RVA: 0x008430AC File Offset: 0x008412AC
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0601AE70 RID: 110192 RVA: 0x008430E8 File Offset: 0x008412E8
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400E9AE RID: 59822
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected Dictionary<USkeletalMeshComponent, int> EffectHandleMap;

	// Token: 0x0400E9AF RID: 59823
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Render/Effect/AnimNotify/AnimNotifyStateGhost.AnimNotifyStateGhost_C";

	// Token: 0x0400E9B0 RID: 59824
	private static IntPtr _ClassPtr;

	// Token: 0x0400E9B1 RID: 59825
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E9B2 RID: 59826
	private static int __PropertyOffset_EffectDataAssetRef;

	// Token: 0x0400E9B3 RID: 59827
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UEffectModelBase> _EffectDataAssetRef;

	// Token: 0x0400E9B4 RID: 59828
	private static int __PropertyOffset_SpawnRate;

	// Token: 0x0400E9B5 RID: 59829
	private static int __PropertyOffset_UseSpawnRate;

	// Token: 0x0400E9B6 RID: 59830
	private static int __PropertyOffset_SpawnInterval;

	// Token: 0x0400E9B7 RID: 59831
	private static int __PropertyOffset_GhostLifeTime;

	// Token: 0x0400E9B8 RID: 59832
	private static int __PropertyOffset_UseBaseColorTex;
}
