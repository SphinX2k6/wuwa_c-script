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
	// Token: 0x06000FFE RID: 4094 RVA: 0x0005BE43 File Offset: 0x0005A043
	static TsAnimNotifyStateAttackWindUp()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAttackWindUp.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAttackWindUp.ResetStaticDefaultValue));
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x0005BE62 File Offset: 0x0005A062
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAttackWindUp.entityEffectMap = new Dictionary<int, int>();
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x0005BE6E File Offset: 0x0005A06E
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAttackWindUp.entityEffectMap = null;
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x06001001 RID: 4097 RVA: 0x0005BE78 File Offset: 0x0005A078
	// (set) Token: 0x06001002 RID: 4098 RVA: 0x0005BEB1 File Offset: 0x0005A0B1
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

	// Token: 0x06001003 RID: 4099 RVA: 0x0005BEDC File Offset: 0x0005A0DC
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

	// Token: 0x06001004 RID: 4100 RVA: 0x0005BF84 File Offset: 0x0005A184
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

	// Token: 0x06001005 RID: 4101 RVA: 0x0005C158 File Offset: 0x0005A358
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

	// Token: 0x06001006 RID: 4102 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
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

	// Token: 0x06001007 RID: 4103 RVA: 0x0005C250 File Offset: 0x0005A450
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

	// Token: 0x06001008 RID: 4104 RVA: 0x0005C318 File Offset: 0x0005A518
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

	// Token: 0x06001009 RID: 4105 RVA: 0x0005C393 File Offset: 0x0005A593
	protected override string GetNotifyName_Implementation()
	{
		return "前摇配置";
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x0005C39A File Offset: 0x0005A59A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttackWindUp._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttackWindUp.TsAnimNotifyStateAttackWindUp_C");
		}
		return TsAnimNotifyStateAttackWindUp._ClassPtr;
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0005C3C0 File Offset: 0x0005A5C0
	public TsAnimNotifyStateAttackWindUp() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttackWindUp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x0005C3E8 File Offset: 0x0005A5E8
	public TsAnimNotifyStateAttackWindUp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttackWindUp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x0005C41B File Offset: 0x0005A61B
	protected TsAnimNotifyStateAttackWindUp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x0005C424 File Offset: 0x0005A624
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x0005C460 File Offset: 0x0005A660
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x0005C493 File Offset: 0x0005A693
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C6E RID: 3182
	private static Dictionary<int, int> entityEffectMap;

	// Token: 0x04000C6F RID: 3183
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttackWindUp.TsAnimNotifyStateAttackWindUp_C";

	// Token: 0x04000C70 RID: 3184
	private static IntPtr _ClassPtr;

	// Token: 0x04000C71 RID: 3185
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C72 RID: 3186
	private static int __PropertyOffset_Info;

	// Token: 0x04000C73 RID: 3187
	[Nullable(2)]
	private SCounterWindupAttack _Info;
}
