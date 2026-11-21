using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Effect;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000110 RID: 272
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttackWindUp.TsAnimNotifyStateAttackWindUp_C")]
public class TsAnimNotifyStateAttackWindUp : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001004 RID: 4100 RVA: 0x0005CFEB File Offset: 0x0005B1EB
	static TsAnimNotifyStateAttackWindUp()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAttackWindUp.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAttackWindUp.ResetStaticDefaultValue));
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x0005D00A File Offset: 0x0005B20A
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAttackWindUp.entityEffectMap = new Dictionary<int, int>();
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x0005D016 File Offset: 0x0005B216
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAttackWindUp.entityEffectMap = null;
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x06001007 RID: 4103 RVA: 0x0005D020 File Offset: 0x0005B220
	// (set) Token: 0x06001008 RID: 4104 RVA: 0x0005D059 File Offset: 0x0005B259
	[UProperty(EPropertyFlags.CPF_None)]
	public SCounterWindupAttack Info
	{
		get
		{
			base.FastCheckIsValid();
			SCounterWindupAttack result;
			if ((result = this._Info) == null)
			{
				result = (this._Info = new SCounterWindupAttack(base.NativePtr + (IntPtr)TsAnimNotifyStateAttackWindUp.__PropertyOffset_Info, this));
			}
			return result;
		}
		set
		{
			UnrealReflectionUtils.CopyNativeStruct(SCounterWindupAttack.StaticStruct(), base.NativePtr + (IntPtr)TsAnimNotifyStateAttackWindUp.__PropertyOffset_Info, (value != null) ? value.NativePtr : ((IntPtr)0), 1, false);
		}
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x0005D084 File Offset: 0x0005B284
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttackWindUp) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAttackWindUp.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600100A RID: 4106 RVA: 0x0005D144 File Offset: 0x0005B344
	[NullableContext(2)]
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		if (this.Info == null)
		{
			return false;
		}
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		CharacterActorComponent characterActorComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		Entity entity = characterActorComponent.Entity;
		CharacterHitComponent component = entity.GetComponent<CharacterHitComponent>();
		BaseBuffComponent component2 = entity.GetComponent<BaseBuffComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		long? num = (component2 != null) ? component2.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null;
		component.SetWindupAttackInfo(this.Info, num.GetValueOrDefault());
		component.SetCounterAttackEndTime(totalDuration);
		TSoftObjectPtr<UEffectModelBase> effect = this.Info.Effect;
		if (ObjectUtils.SoftObjectReferenceValid<UEffectModelBase>(effect))
		{
			SkeletalMeshEffectContext skeletalMeshEffectContext;
			if (owner is TsBaseCharacter)
			{
				CharacterActorComponent characterActorComponent2 = (owner as TsBaseCharacter).CharacterActorComponent;
				if (((characterActorComponent2 != null) ? characterActorComponent2.Entity : null) != null)
				{
					CharacterActorComponent characterActorComponent3 = (owner as TsBaseCharacter).CharacterActorComponent;
					skeletalMeshEffectContext = new SkeletalMeshEffectContext((characterActorComponent3 != null) ? new int?(characterActorComponent3.Entity.Id) : null, null, false);
					goto IL_12A;
				}
			}
			skeletalMeshEffectContext = new SkeletalMeshEffectContext(null, null, false);
			IL_12A:
			skeletalMeshEffectContext.SkeletalMeshComp = meshComp;
			skeletalMeshEffectContext.SourceObject = owner;
			skeletalMeshEffectContext.CreateFromType = EEffectCreateFromType.An;
			string path = effect.ToAssetPathName();
			FTransformDouble socketTransform = characterActorComponent.GetSocketTransform(this.Info.SocketName);
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(socketTransform);
			int num2 = instance.SpawnEffect(world, ftransformDouble, path, "[TsAnimNotifyStateAttackWindUp.K2_NotifyBegin]", skeletalMeshEffectContext, EEffectType.Fight, null, null, null, false, false);
			TsAnimNotifyStateAttackWindUp.entityEffectMap.Add(entity.Id, num2);
			if (this.Info.EffectAttach)
			{
				this.SetupEffectTransform(EffectSystem.Instance.GetEffectActor(num2), characterActorComponent.SkeletalMesh);
			}
		}
		return true;
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0005D318 File Offset: 0x0005B518
	private void SetupEffectTransform(object effectActor, USkeletalMeshComponent meshComp)
	{
		AActor aactor = effectActor as AActor;
		if (aactor != null)
		{
			aactor.K2_AttachToComponent(meshComp, this.Info.SocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
		}
		FTransformDouble ftransformDouble = UKismetMathLibrary.Conv_TransformToTransformDouble(this.Info.RelativeTransform);
		FHitResult fhitResult = new FHitResult();
		if (aactor == null)
		{
			return;
		}
		aactor.D_K2_SetActorRelativeTransform(ftransformDouble, false, ref fhitResult, true);
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x0005D370 File Offset: 0x0005B570
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttackWindUp) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAttackWindUp.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600100D RID: 4109 RVA: 0x0005D428 File Offset: 0x0005B628
	[NullableContext(2)]
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		if (this.Info == null)
		{
			return false;
		}
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		CharacterActorComponent characterActorComponent = (tsBaseCharacter != null) ? tsBaseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null || !characterActorComponent.Valid)
		{
			return false;
		}
		Entity entity = characterActorComponent.Entity;
		CharacterHitComponent component = entity.GetComponent<CharacterHitComponent>();
		CharacterSkillComponent component2 = entity.GetComponent<CharacterSkillComponent>();
		if (component2 == null || !component2.Valid || (component == null || !component.Valid))
		{
			return false;
		}
		component.WindupAttackEnd();
		int handle;
		if (TsAnimNotifyStateAttackWindUp.entityEffectMap.TryGetValue(entity.Id, out handle))
		{
			EffectSystem.Instance.StopEffectById(handle, "[TsAnimNotifyStateAttackWindUp.K2_NotifyEnd]", false, null);
			TsAnimNotifyStateAttackWindUp.entityEffectMap.Remove(entity.Id);
		}
		return true;
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x0005D4F0 File Offset: 0x0005B6F0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttackWindUp) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAttackWindUp.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600100F RID: 4111 RVA: 0x0005D580 File Offset: 0x0005B780
	protected override string GetNotifyName_Implementation()
	{
		return "前摇配置";
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x0005D587 File Offset: 0x0005B787
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttackWindUp._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttackWindUp.TsAnimNotifyStateAttackWindUp_C");
		}
		return TsAnimNotifyStateAttackWindUp._ClassPtr;
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x0005D5AC File Offset: 0x0005B7AC
	public TsAnimNotifyStateAttackWindUp() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttackWindUp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0005D5D4 File Offset: 0x0005B7D4
	public TsAnimNotifyStateAttackWindUp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttackWindUp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x0005D607 File Offset: 0x0005B807
	protected TsAnimNotifyStateAttackWindUp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x0005D610 File Offset: 0x0005B810
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x0005D64C File Offset: 0x0005B84C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x0005D67F File Offset: 0x0005B87F
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C76 RID: 3190
	private static Dictionary<int, int> entityEffectMap;

	// Token: 0x04000C77 RID: 3191
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttackWindUp.TsAnimNotifyStateAttackWindUp_C";

	// Token: 0x04000C78 RID: 3192
	private static IntPtr _ClassPtr;

	// Token: 0x04000C79 RID: 3193
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C7A RID: 3194
	private static int __PropertyOffset_Info;

	// Token: 0x04000C7B RID: 3195
	[Nullable(2)]
	private SCounterWindupAttack _Info;
}
