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
	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x06001066 RID: 4198 RVA: 0x0005DC3C File Offset: 0x0005BE3C
	// (set) Token: 0x06001067 RID: 4199 RVA: 0x0005DC75 File Offset: 0x0005BE75
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

	// Token: 0x06001068 RID: 4200 RVA: 0x0005DC9C File Offset: 0x0005BE9C
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

	// Token: 0x06001069 RID: 4201 RVA: 0x0005DD44 File Offset: 0x0005BF44
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

	// Token: 0x0600106A RID: 4202 RVA: 0x0005DE50 File Offset: 0x0005C050
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

	// Token: 0x0600106B RID: 4203 RVA: 0x0005DEEF File Offset: 0x0005C0EF
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

	// Token: 0x0600106C RID: 4204 RVA: 0x0005DF10 File Offset: 0x0005C110
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

	// Token: 0x0600106D RID: 4205 RVA: 0x0005DF8B File Offset: 0x0005C18B
	protected override string GetNotifyName_Implementation()
	{
		return "子弹弹幕";
	}

	// Token: 0x0600106E RID: 4206 RVA: 0x0005DF92 File Offset: 0x0005C192
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateBulletPattern._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletPattern.TsAnimNotifyStateBulletPattern_C");
		}
		return TsAnimNotifyStateBulletPattern._ClassPtr;
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x0005DFB8 File Offset: 0x0005C1B8
	public TsAnimNotifyStateBulletPattern() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletPattern.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001070 RID: 4208 RVA: 0x0005DFE0 File Offset: 0x0005C1E0
	public TsAnimNotifyStateBulletPattern(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateBulletPattern.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001071 RID: 4209 RVA: 0x0005E013 File Offset: 0x0005C213
	protected TsAnimNotifyStateBulletPattern(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001072 RID: 4210 RVA: 0x0005E01C File Offset: 0x0005C21C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x0005E058 File Offset: 0x0005C258
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x0005E08B File Offset: 0x0005C28B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C9E RID: 3230
	private int PatternId;

	// Token: 0x04000C9F RID: 3231
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateBulletPattern.TsAnimNotifyStateBulletPattern_C";

	// Token: 0x04000CA0 RID: 3232
	private static IntPtr _ClassPtr;

	// Token: 0x04000CA1 RID: 3233
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000CA2 RID: 3234
	private static int __PropertyOffset_弹幕数据;

	// Token: 0x04000CA3 RID: 3235
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UKuroBulletPatternDataAsset> _弹幕数据;
}
