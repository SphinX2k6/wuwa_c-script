using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000115 RID: 277
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletPattern.TsAnimNotifyStateBulletPattern_C")]
public class TsAnimNotifyStateBulletPattern : TsAnimNotifyStateBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x0600106C RID: 4204 RVA: 0x0005EEF4 File Offset: 0x0005D0F4
	// (set) Token: 0x0600106D RID: 4205 RVA: 0x0005EF2D File Offset: 0x0005D12D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UKuroBulletPatternDataAsset> 弹幕数据
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UKuroBulletPatternDataAsset> result;
			if ((result = this._弹幕数据) == null)
			{
				result = (this._弹幕数据 = new TSoftObjectPtr<UKuroBulletPatternDataAsset>(base.NativePtr + (IntPtr)TsAnimNotifyStateBulletPattern.__PropertyOffset_弹幕数据, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyStateBulletPattern.__PropertyOffset_弹幕数据, 1);
		}
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x0005EF54 File Offset: 0x0005D154
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBulletPattern) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateBulletPattern.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600106F RID: 4207 RVA: 0x0005F014 File Offset: 0x0005D214
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		Entity ownerEntity = (owner as TsBaseCharacter).GetEntityNoBlueprint();
		Entity ownerEntity2 = ownerEntity;
		if (ownerEntity2 == null || !ownerEntity2.Valid)
		{
			return false;
		}
		if (this.弹幕数据 == null)
		{
			return false;
		}
		BaseBuffComponent component = ownerEntity.GetComponent<BaseBuffComponent>();
		long? anMessageId = (component != null) ? component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		BaseSkillComponent component2 = ownerEntity.GetComponent<BaseSkillComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		int currentMontageCorrespondingSkillId = component2.GetCurrentMontageCorrespondingSkillId();
		int skillId = (currentMontageCorrespondingSkillId != 0) ? currentMontageCorrespondingSkillId : component2.GetSkillIdWithGroupId(1);
		string assetPath = this.弹幕数据.ToAssetPathName();
		ResourceSystem.Instance.LoadAsync<UKuroBulletPatternDataAsset>(assetPath, delegate([Nullable(2)] UKuroBulletPatternDataAsset patternData, string _)
		{
			if (patternData == null || !patternData.IsValid())
			{
				return;
			}
			this.PatternId = BulletUtil.SpawnPatternFromAN(ownerEntity, patternData, skillId, anMessageId, assetPath);
		}, 100, "js_undefined");
		return true;
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x0005F120 File Offset: 0x0005D320
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBulletPattern) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateBulletPattern.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001071 RID: 4209 RVA: 0x0005F1D6 File Offset: 0x0005D3D6
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.PatternId > 0)
		{
			BulletUtil.DestroyPatternById(this.PatternId);
			this.PatternId = 0;
		}
		return true;
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x0005F1F4 File Offset: 0x0005D3F4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateBulletPattern) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateBulletPattern.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001073 RID: 4211 RVA: 0x0005F284 File Offset: 0x0005D484
	protected override string GetNotifyName_Implementation()
	{
		return "子弹弹幕";
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x0005F28B File Offset: 0x0005D48B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBulletPattern._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletPattern.TsAnimNotifyStateBulletPattern_C");
		}
		return TsAnimNotifyStateBulletPattern._ClassPtr;
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x0005F2B0 File Offset: 0x0005D4B0
	public TsAnimNotifyStateBulletPattern() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletPattern.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x0005F2D8 File Offset: 0x0005D4D8
	public TsAnimNotifyStateBulletPattern(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletPattern.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x0005F30B File Offset: 0x0005D50B
	protected TsAnimNotifyStateBulletPattern(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x0005F314 File Offset: 0x0005D514
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x0005F350 File Offset: 0x0005D550
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0600107A RID: 4218 RVA: 0x0005F383 File Offset: 0x0005D583
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000CA6 RID: 3238
	private int PatternId;

	// Token: 0x04000CA7 RID: 3239
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletPattern.TsAnimNotifyStateBulletPattern_C";

	// Token: 0x04000CA8 RID: 3240
	private static IntPtr _ClassPtr;

	// Token: 0x04000CA9 RID: 3241
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CAA RID: 3242
	private static int __PropertyOffset_弹幕数据;

	// Token: 0x04000CAB RID: 3243
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UKuroBulletPatternDataAsset> _弹幕数据;
}
