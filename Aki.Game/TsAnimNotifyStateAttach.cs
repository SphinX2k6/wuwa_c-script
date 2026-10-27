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
	// Token: 0x06000FA7 RID: 4007 RVA: 0x0005A5EC File Offset: 0x000587EC
	static TsAnimNotifyStateAttach()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAttach.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAttach.ResetStaticDefaultValue));
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0005A61F File Offset: 0x0005881F
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAttach.IsInit = false;
		TsAnimNotifyStateAttach.CacheMap = new Dictionary<AActor, AttachParams>();
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0005A631 File Offset: 0x00058831
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAttach.IsInit = false;
		TsAnimNotifyStateAttach.CacheMap = null;
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x06000FAA RID: 4010 RVA: 0x0005A63F File Offset: 0x0005883F
	// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0005A653 File Offset: 0x00058853
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

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06000FAC RID: 4012 RVA: 0x0005A668 File Offset: 0x00058868
	// (set) Token: 0x06000FAD RID: 4013 RVA: 0x0005A67C File Offset: 0x0005887C
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

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06000FAE RID: 4014 RVA: 0x0005A691 File Offset: 0x00058891
	// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0005A6A5 File Offset: 0x000588A5
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

	// Token: 0x06000FB0 RID: 4016 RVA: 0x0005A6BC File Offset: 0x000588BC
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

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0005A764 File Offset: 0x00058964
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

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0005A948 File Offset: 0x00058B48
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("K2_NotifyTick"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams*)ptr + 15L / (long)sizeof(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
			*(&ptr2->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
			ptr2->FrameDeltaTime = frameDeltaTime;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0005A9F0 File Offset: 0x00058BF0
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

	// Token: 0x06000FB4 RID: 4020 RVA: 0x0005AB00 File Offset: 0x00058D00
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

	// Token: 0x06000FB5 RID: 4021 RVA: 0x0005ABA0 File Offset: 0x00058DA0
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

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0005AD10 File Offset: 0x00058F10
	private FName GetAttachSocketName()
	{
		if (this.AttachSocketName == null || StringUtils.IsNothing(this.AttachSocketName.ToString()))
		{
			return new FName(this.ATTACH_SOCKET_NAME);
		}
		return this.AttachSocketName;
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0005AD60 File Offset: 0x00058F60
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

	// Token: 0x06000FB8 RID: 4024 RVA: 0x0005ADB0 File Offset: 0x00058FB0
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

	// Token: 0x06000FB9 RID: 4025 RVA: 0x0005AE2B File Offset: 0x0005902B
	protected override string GetNotifyName_Implementation()
	{
		return "绑定到目标身上";
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0005AE32 File Offset: 0x00059032
	private static void Initialize()
	{
		if (TsAnimNotifyStateAttach.IsInit)
		{
			return;
		}
		TsAnimNotifyStateAttach.CacheMap = new Dictionary<AActor, AttachParams>();
		TsAnimNotifyStateAttach.IsInit = true;
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x0005AE4C File Offset: 0x0005904C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttach._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttach.TsAnimNotifyStateAttach_C");
		}
		return TsAnimNotifyStateAttach._ClassPtr;
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x0005AE70 File Offset: 0x00059070
	public TsAnimNotifyStateAttach() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x0005AE98 File Offset: 0x00059098
	public TsAnimNotifyStateAttach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x0005AECB File Offset: 0x000590CB
	protected TsAnimNotifyStateAttach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x0005AEF0 File Offset: 0x000590F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x0005AF2C File Offset: 0x0005912C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x0005AF68 File Offset: 0x00059168
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0005AF9B File Offset: 0x0005919B
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04000C3F RID: 3135
	private const float MAX_ANIM_TIME = 9999f;

	// Token: 0x04000C40 RID: 3136
	private string ATTACH_SOCKET_NAME = CharacterNameDefines.Instance.ROOT.ToString();

	// Token: 0x04000C41 RID: 3137
	private static bool IsInit;

	// Token: 0x04000C42 RID: 3138
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<AActor, AttachParams> CacheMap;

	// Token: 0x04000C43 RID: 3139
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C44 RID: 3140
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C45 RID: 3141
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttach.TsAnimNotifyStateAttach_C";

	// Token: 0x04000C46 RID: 3142
	private static IntPtr _ClassPtr;

	// Token: 0x04000C47 RID: 3143
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C48 RID: 3144
	private static int __PropertyOffset_GameplayTag;

	// Token: 0x04000C49 RID: 3145
	private static int __PropertyOffset_AttachSocketName;

	// Token: 0x04000C4A RID: 3146
	private static int __PropertyOffset_AttachSocketOffset;
}
