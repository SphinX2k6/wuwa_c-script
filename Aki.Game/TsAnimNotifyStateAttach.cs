using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200010C RID: 268
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttach.TsAnimNotifyStateAttach_C")]
public class TsAnimNotifyStateAttach : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000FAD RID: 4013 RVA: 0x0005B6F0 File Offset: 0x000598F0
	static TsAnimNotifyStateAttach()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAttach.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAttach.ResetStaticDefaultValue));
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x0005B723 File Offset: 0x00059923
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAttach.IsInit = false;
		TsAnimNotifyStateAttach.CacheMap = new Dictionary<AActor, AttachParams>();
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x0005B735 File Offset: 0x00059935
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAttach.IsInit = false;
		TsAnimNotifyStateAttach.CacheMap = null;
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06000FB0 RID: 4016 RVA: 0x0005B743 File Offset: 0x00059943
	// (set) Token: 0x06000FB1 RID: 4017 RVA: 0x0005B757 File Offset: 0x00059957
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag GameplayTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttach.__PropertyOffset_GameplayTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttach.__PropertyOffset_GameplayTag) = value;
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x0005B76C File Offset: 0x0005996C
	// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x0005B780 File Offset: 0x00059980
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName AttachSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttach.__PropertyOffset_AttachSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttach.__PropertyOffset_AttachSocketName) = value;
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x06000FB4 RID: 4020 RVA: 0x0005B795 File Offset: 0x00059995
	// (set) Token: 0x06000FB5 RID: 4021 RVA: 0x0005B7A9 File Offset: 0x000599A9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector AttachSocketOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttach.__PropertyOffset_AttachSocketOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttach.__PropertyOffset_AttachSocketOffset) = value;
		}
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0005B7C0 File Offset: 0x000599C0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttach) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyBegin"), TsAnimNotifyStateAttach.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0005B880 File Offset: 0x00059A80
	protected virtual bool K2_NotifyBegin_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || (characterActorComponent == null || !characterActorComponent.IsAutonomousProxy))
		{
			return false;
		}
		CharacterSkillComponent component = characterActorComponent.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null && component.Valid)
		{
			EntityHandle skillTarget = component.SkillTarget;
			if (((skillTarget != null) ? skillTarget.Entity : null) != null)
			{
				WorldEntity entity = component.SkillTarget.Entity;
				EntityHandle handleByEntity = CharacterModel.Instance.GetHandleByEntity(entity);
				if (handleByEntity == null || !handleByEntity.Valid)
				{
					return false;
				}
				CharacterActorComponent component2 = entity.GetComponent<CharacterActorComponent>();
				if (component2 == null || !component2.Valid)
				{
					return false;
				}
				CharacterAttachComponent component3 = entity.GetComponent<CharacterAttachComponent>();
				if (component3 == null || !component3.Valid)
				{
					return false;
				}
				Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
				CharacterAttachComponent characterAttachComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterAttachComponent>() : null;
				if (characterAttachComponent == null || !characterAttachComponent.Valid)
				{
					return false;
				}
				CharacterPartComponent component4 = entity.GetComponent<CharacterPartComponent>();
				if (component4 == null || !component4.Valid)
				{
					return false;
				}
				this.AttachSocketName = this.GetAttachSocketName();
				CharacterPart partByCombineBoneName = component4.GetPartByCombineBoneName(this.AttachSocketName.ToString());
				if (partByCombineBoneName == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "部位表中不存在合体部位配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("AttachSocketName", this.AttachSocketName);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return false;
				}
				AttachParams attachParams = new AttachParams();
				attachParams.Initialize(characterActorComponent, this.GetAttachTargetLocation(component2), totalDuration);
				TsAnimNotifyStateAttach.Initialize();
				TsAnimNotifyStateAttach.CacheMap.Add(owner, attachParams);
				characterAttachComponent.StartAttachToTarget(handleByEntity, this.AttachSocketName, this.AttachSocketOffset, partByCombineBoneName.Index, new FGameplayTag?(this.GameplayTag));
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x0005BA64 File Offset: 0x00059C64
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttach) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyTick"), TsAnimNotifyStateAttach.StaticClass(), out intPtr, out num))
		{
			return this.K2_NotifyTick_Implementation(meshComp, animation, frameDeltaTime);
		}
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr = stackalloc UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		ptr->FrameDeltaTime = frameDeltaTime;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x0005BB24 File Offset: 0x00059D24
	protected virtual bool K2_NotifyTick_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		CharacterAnimationComponent component = characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		CharacterSkillComponent component2 = characterActorComponent.Entity.GetComponent<CharacterSkillComponent>();
		if (component2 != null && component2.Valid)
		{
			EntityHandle skillTarget = component2.SkillTarget;
			if (((skillTarget != null) ? skillTarget.Entity : null) != null)
			{
				WorldEntity entity = component2.SkillTarget.Entity;
				CharacterAttachComponent component3 = entity.GetComponent<CharacterAttachComponent>();
				if (component3 == null || !component3.Valid)
				{
					return false;
				}
				CharacterActorComponent component4 = entity.GetComponent<CharacterActorComponent>();
				if (component4 == null || !component4.Valid)
				{
					return false;
				}
				AttachParams attachParams;
				if (!TsAnimNotifyStateAttach.CacheMap.TryGetValue(tsBaseCharacter, out attachParams))
				{
					return false;
				}
				attachParams.UpdateAttachLocation(characterActorComponent, this.GetAttachTargetLocation(component4));
				characterActorComponent.AddActorWorldOffset(attachParams.StepFrameLocationOffset(characterActorComponent, frameDeltaTime).ToUeVector(false), "TsAnimNotifyStateAttach", false);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0005BC34 File Offset: 0x00059E34
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttach) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_NotifyEnd"), TsAnimNotifyStateAttach.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000FBB RID: 4027 RVA: 0x0005BCEC File Offset: 0x00059EEC
	protected virtual bool K2_NotifyEnd_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		if (characterActorComponent == null || !characterActorComponent.Valid || !characterActorComponent.IsAutonomousProxy)
		{
			return false;
		}
		CharacterSkillComponent component = characterActorComponent.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null && component.Valid)
		{
			EntityHandle skillTarget = component.SkillTarget;
			if (((skillTarget != null) ? skillTarget.Entity : null) != null)
			{
				WorldEntity entity = component.SkillTarget.Entity;
				CharacterAttachComponent component2 = entity.GetComponent<CharacterAttachComponent>();
				if (component2 == null || !component2.Valid)
				{
					return false;
				}
				CharacterActorComponent component3 = entity.GetComponent<CharacterActorComponent>();
				if (component3 == null || !component3.Valid)
				{
					return false;
				}
				Entity entityNoBlueprint = (owner as TsBaseCharacter).GetEntityNoBlueprint();
				CharacterAttachComponent characterAttachComponent = (entityNoBlueprint != null) ? entityNoBlueprint.GetComponent<CharacterAttachComponent>() : null;
				if (characterAttachComponent == null || !characterAttachComponent.Valid)
				{
					return false;
				}
				AttachParams attachParams;
				if (!TsAnimNotifyStateAttach.CacheMap.TryGetValue(owner, out attachParams))
				{
					return false;
				}
				long? preMessageId = characterActorComponent.Entity.GetComponent<BaseBuffComponent>().CreateAnimNotifyContent(animation.GetName(), base.exportIndex);
				attachParams.UpdateAttachLocation(characterActorComponent, this.GetAttachTargetLocation(component3));
				characterActorComponent.AddActorWorldOffset(attachParams.StepFrameLocationOffset(characterActorComponent, 9999f).ToUeVector(false), "TsAnimNotifyStateAttach", false);
				characterAttachComponent.AttachToTarget(CharacterModel.Instance.GetHandleByEntity(entity), preMessageId, true);
				Dictionary<AActor, AttachParams> cacheMap = TsAnimNotifyStateAttach.CacheMap;
				if (cacheMap != null)
				{
					cacheMap.Remove(owner);
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x0005BE5C File Offset: 0x0005A05C
	private FName GetAttachSocketName()
	{
		if (this.AttachSocketName == null || StringUtils.IsNothing(this.AttachSocketName.ToString()))
		{
			return new FName(this.ATTACH_SOCKET_NAME);
		}
		return this.AttachSocketName;
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x0005BEAC File Offset: 0x0005A0AC
	private Vector GetAttachTargetLocation(CharacterActorComponent targetActorComp)
	{
		Vector tmpVector = TsAnimNotifyStateAttach.TmpVector1;
		FVector attachSocketOffset = this.AttachSocketOffset;
		tmpVector.FromUeVector(attachSocketOffset);
		Vector tmpVector2 = TsAnimNotifyStateAttach.TmpVector2;
		FVectorDouble socketLocation = targetActorComp.GetSocketLocation(this.AttachSocketName);
		tmpVector2.DeepCopy(socketLocation);
		TsAnimNotifyStateAttach.TmpVector2.AdditionEqual(TsAnimNotifyStateAttach.TmpVector1);
		return TsAnimNotifyStateAttach.TmpVector2;
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x0005BEFC File Offset: 0x0005A0FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyStateAttach) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyStateAttach.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000FBF RID: 4031 RVA: 0x0005BF8C File Offset: 0x0005A18C
	protected override string GetNotifyName_Implementation()
	{
		return "绑定到目标身上";
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x0005BF93 File Offset: 0x0005A193
	private static void Initialize()
	{
		if (TsAnimNotifyStateAttach.IsInit)
		{
			return;
		}
		TsAnimNotifyStateAttach.CacheMap = new Dictionary<AActor, AttachParams>();
		TsAnimNotifyStateAttach.IsInit = true;
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x0005BFAD File Offset: 0x0005A1AD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttach._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttach.TsAnimNotifyStateAttach_C");
		}
		return TsAnimNotifyStateAttach._ClassPtr;
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
	public TsAnimNotifyStateAttach() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x0005BFFC File Offset: 0x0005A1FC
	public TsAnimNotifyStateAttach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x0005C02F File Offset: 0x0005A22F
	protected TsAnimNotifyStateAttach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x0005C054 File Offset: 0x0005A254
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x0005C090 File Offset: 0x0005A290
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x0005C0CC File Offset: 0x0005A2CC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0005C0FF File Offset: 0x0005A2FF
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C47 RID: 3143
	private const float MAX_ANIM_TIME = 9999f;

	// Token: 0x04000C48 RID: 3144
	private string ATTACH_SOCKET_NAME = CharacterNameDefines.Instance.ROOT.ToString();

	// Token: 0x04000C49 RID: 3145
	private static bool IsInit;

	// Token: 0x04000C4A RID: 3146
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<AActor, AttachParams> CacheMap;

	// Token: 0x04000C4B RID: 3147
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C4C RID: 3148
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C4D RID: 3149
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttach.TsAnimNotifyStateAttach_C";

	// Token: 0x04000C4E RID: 3150
	private static IntPtr _ClassPtr;

	// Token: 0x04000C4F RID: 3151
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C50 RID: 3152
	private static int __PropertyOffset_GameplayTag;

	// Token: 0x04000C51 RID: 3153
	private static int __PropertyOffset_AttachSocketName;

	// Token: 0x04000C52 RID: 3154
	private static int __PropertyOffset_AttachSocketOffset;
}
