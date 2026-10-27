using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200019B RID: 411
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBulletPattern.TsAnimNotifyBulletPattern_C")]
public class TsAnimNotifyBulletPattern : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700043C RID: 1084
	// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00089054 File Offset: 0x00087254
	// (set) Token: 0x06001A20 RID: 6688 RVA: 0x0008908D File Offset: 0x0008728D
	[UProperty(EPropertyFlags.CPF_None)]
	public TSoftObjectPtr<UKuroBulletPatternDataAsset> 弹幕数据
	{
		get
		{
			base.FastCheckIsValid();
			TSoftObjectPtr<UKuroBulletPatternDataAsset> result;
			if ((result = this._弹幕数据) == null)
			{
				result = (this._弹幕数据 = new TSoftObjectPtr<UKuroBulletPatternDataAsset>(base.NativePtr + (IntPtr)TsAnimNotifyBulletPattern.__PropertyOffset_弹幕数据, this));
			}
			return result;
		}
		set
		{
			FSoftObjectPtr.NativeCopy((value != null) ? value.NativePtr : IntPtr.Zero, base.NativePtr + (IntPtr)TsAnimNotifyBulletPattern.__PropertyOffset_弹幕数据, 1);
		}
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x000890B4 File Offset: 0x000872B4
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

	// Token: 0x06001A22 RID: 6690 RVA: 0x00089154 File Offset: 0x00087354
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
			BulletUtil.SpawnPatternFromAN(ownerEntity, patternData, skillId, anMessageId, assetPath);
		}, 100, "js_undefined");
		return true;
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x00089258 File Offset: 0x00087458
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetNotifyName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UAnimNotify.__GetNotifyName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UAnimNotify.__GetNotifyName_FunctionParams*)ptr + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L);
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

	// Token: 0x06001A24 RID: 6692 RVA: 0x000892D3 File Offset: 0x000874D3
	protected override string GetNotifyName_Implementation()
	{
		return "子弹弹幕";
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x000892DA File Offset: 0x000874DA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBulletPattern._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBulletPattern.TsAnimNotifyBulletPattern_C");
		}
		return TsAnimNotifyBulletPattern._ClassPtr;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00089300 File Offset: 0x00087500
	public TsAnimNotifyBulletPattern() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBulletPattern.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x00089328 File Offset: 0x00087528
	public TsAnimNotifyBulletPattern(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBulletPattern.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x0008935B File Offset: 0x0008755B
	protected TsAnimNotifyBulletPattern(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x00089364 File Offset: 0x00087564
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x00089397 File Offset: 0x00087597
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001105 RID: 4357
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBulletPattern.TsAnimNotifyBulletPattern_C";

	// Token: 0x04001106 RID: 4358
	private static IntPtr _ClassPtr;

	// Token: 0x04001107 RID: 4359
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001108 RID: 4360
	private static int __PropertyOffset_弹幕数据;

	// Token: 0x04001109 RID: 4361
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TSoftObjectPtr<UKuroBulletPatternDataAsset> _弹幕数据;
}
