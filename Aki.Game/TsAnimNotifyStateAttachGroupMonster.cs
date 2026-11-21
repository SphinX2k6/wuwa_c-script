using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200010F RID: 271
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotifyState/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachGroupMonster.TsAnimNotifyStateAttachGroupMonster_C")]
public class TsAnimNotifyStateAttachGroupMonster : TsAnimNotifyStateBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06000FEC RID: 4076 RVA: 0x0005C8BC File Offset: 0x0005AABC
	static TsAnimNotifyStateAttachGroupMonster()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyStateAttachGroupMonster.CreateStaticDefaultValue), new Action(TsAnimNotifyStateAttachGroupMonster.ResetStaticDefaultValue));
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x0005C8EF File Offset: 0x0005AAEF
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyStateAttachGroupMonster.IsInit = false;
		TsAnimNotifyStateAttachGroupMonster.CacheMap = new Dictionary<AActor, AttachGroupMonsterParams>();
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x0005C901 File Offset: 0x0005AB01
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyStateAttachGroupMonster.IsInit = false;
		TsAnimNotifyStateAttachGroupMonster.CacheMap = null;
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0005C90F File Offset: 0x0005AB0F
	// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x0005C923 File Offset: 0x0005AB23
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag GameplayTag
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachGroupMonster.__PropertyOffset_GameplayTag);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachGroupMonster.__PropertyOffset_GameplayTag) = value;
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x0005C938 File Offset: 0x0005AB38
	// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x0005C94C File Offset: 0x0005AB4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FName AttachSocketName
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachGroupMonster.__PropertyOffset_AttachSocketName);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachGroupMonster.__PropertyOffset_AttachSocketName) = value;
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x0005C961 File Offset: 0x0005AB61
	// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0005C975 File Offset: 0x0005AB75
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector AttachSocketOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachGroupMonster.__PropertyOffset_AttachSocketOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyStateAttachGroupMonster.__PropertyOffset_AttachSocketOffset) = value;
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0005C98C File Offset: 0x0005AB8C
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyBegin(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float totalDuration)
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
		BaseGroupAiComponent component = characterActorComponent.Entity.GetComponent<BaseGroupAiComponent>();
		EntityHandle entityHandle = (component != null) ? component.GetEcologyAttachTarget() : null;
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (entityHandle == null || !entityHandle.Valid || (worldEntity == null || !worldEntity.Valid))
		{
			return false;
		}
		CharacterActorComponent component2 = worldEntity.GetComponent<CharacterActorComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		CharacterAttachComponent component3 = worldEntity.GetComponent<CharacterAttachComponent>();
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
		CharacterPartComponent component4 = worldEntity.GetComponent<CharacterPartComponent>();
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
		AttachGroupMonsterParams attachGroupMonsterParams = new AttachGroupMonsterParams();
		attachGroupMonsterParams.Initialize(characterActorComponent, this.GetAttachTargetLocation(component2), totalDuration);
		TsAnimNotifyStateAttachGroupMonster.Initialize();
		TsAnimNotifyStateAttachGroupMonster.CacheMap.Add(owner, attachGroupMonsterParams);
		characterAttachComponent.StartAttachToTarget(entityHandle, this.AttachSocketName, this.AttachSocketOffset, partByCombineBoneName.Index, new FGameplayTag?(this.GameplayTag));
		return true;
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0005CB58 File Offset: 0x0005AD58
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyTick(USkeletalMeshComponent meshComp, UAnimSequenceBase animation, float frameDeltaTime)
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
		CharacterAnimationComponent component = characterActorComponent.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			return false;
		}
		BaseGroupAiComponent component2 = characterActorComponent.Entity.GetComponent<BaseGroupAiComponent>();
		WorldEntity worldEntity;
		if (component2 == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle ecologyAttachTarget = component2.GetEcologyAttachTarget();
			worldEntity = ((ecologyAttachTarget != null) ? ecologyAttachTarget.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null || !worldEntity2.Valid)
		{
			return false;
		}
		CharacterAttachComponent component3 = worldEntity2.GetComponent<CharacterAttachComponent>();
		if (component3 == null || !component3.Valid)
		{
			return false;
		}
		CharacterActorComponent component4 = worldEntity2.GetComponent<CharacterActorComponent>();
		if (component4 == null || !component4.Valid)
		{
			return false;
		}
		AttachGroupMonsterParams attachGroupMonsterParams;
		if (!TsAnimNotifyStateAttachGroupMonster.CacheMap.TryGetValue(owner, out attachGroupMonsterParams))
		{
			return false;
		}
		attachGroupMonsterParams.UpdateAttachLocation(characterActorComponent, this.GetAttachTargetLocation(component4));
		characterActorComponent.AddActorWorldOffset(attachGroupMonsterParams.StepFrameLocationOffset(characterActorComponent, frameDeltaTime).ToUeVector(false), "TsAnimNotifyStateAttachGroupMonster", false);
		return true;
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0005CC64 File Offset: 0x0005AE64
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_NotifyEnd(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
		BaseGroupAiComponent component = characterActorComponent.Entity.GetComponent<BaseGroupAiComponent>();
		WorldEntity worldEntity;
		if (component == null)
		{
			worldEntity = null;
		}
		else
		{
			EntityHandle ecologyAttachTarget = component.GetEcologyAttachTarget();
			worldEntity = ((ecologyAttachTarget != null) ? ecologyAttachTarget.Entity : null);
		}
		WorldEntity worldEntity2 = worldEntity;
		if (worldEntity2 == null || !worldEntity2.Valid)
		{
			return false;
		}
		CharacterAttachComponent component2 = worldEntity2.GetComponent<CharacterAttachComponent>();
		if (component2 == null || !component2.Valid)
		{
			return false;
		}
		CharacterActorComponent component3 = worldEntity2.GetComponent<CharacterActorComponent>();
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
		AttachGroupMonsterParams attachGroupMonsterParams;
		if (!TsAnimNotifyStateAttachGroupMonster.CacheMap.TryGetValue(owner, out attachGroupMonsterParams))
		{
			return false;
		}
		long? preMessageId = characterActorComponent.Entity.GetComponent<BaseBuffComponent>().CreateAnimNotifyContent(animation.GetName(), base.exportIndex);
		attachGroupMonsterParams.UpdateAttachLocation(characterActorComponent, this.GetAttachTargetLocation(component3));
		characterActorComponent.AddActorWorldOffset(attachGroupMonsterParams.StepFrameLocationOffset(characterActorComponent, 9999f).ToUeVector(false), "TsAnimNotifyStateAttachGroupMonster", false);
		characterAttachComponent.AttachToTarget(CharacterModel.Instance.GetHandleByEntity(worldEntity2), preMessageId, true);
		Dictionary<AActor, AttachGroupMonsterParams> cacheMap = TsAnimNotifyStateAttachGroupMonster.CacheMap;
		if (cacheMap != null)
		{
			cacheMap.Remove(owner);
		}
		return true;
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x0005CDC8 File Offset: 0x0005AFC8
	private FName GetAttachSocketName()
	{
		if (this.AttachSocketName == null || StringUtils.IsNothing(this.AttachSocketName.ToString()))
		{
			return new FName(this.ATTACH_SOCKET_NAME);
		}
		return this.AttachSocketName;
	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0005CE18 File Offset: 0x0005B018
	private Vector GetAttachTargetLocation(CharacterActorComponent targetActorComp)
	{
		Vector tmpVector = TsAnimNotifyStateAttachGroupMonster.TmpVector1;
		FVector attachSocketOffset = this.AttachSocketOffset;
		tmpVector.FromUeVector(attachSocketOffset);
		Vector tmpVector2 = TsAnimNotifyStateAttachGroupMonster.TmpVector2;
		FVectorDouble socketLocation = targetActorComp.GetSocketLocation(this.AttachSocketName);
		tmpVector2.DeepCopy(socketLocation);
		TsAnimNotifyStateAttachGroupMonster.TmpVector2.AdditionEqual(TsAnimNotifyStateAttachGroupMonster.TmpVector1);
		return TsAnimNotifyStateAttachGroupMonster.TmpVector2;
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x0005CE66 File Offset: 0x0005B066
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "绑定到怪物组队长身上";
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0005CE6D File Offset: 0x0005B06D
	private static void Initialize()
	{
		if (TsAnimNotifyStateAttachGroupMonster.IsInit)
		{
			return;
		}
		TsAnimNotifyStateAttachGroupMonster.CacheMap = new Dictionary<AActor, AttachGroupMonsterParams>();
		TsAnimNotifyStateAttachGroupMonster.IsInit = true;
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x0005CE87 File Offset: 0x0005B087
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyStateAttachGroupMonster._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachGroupMonster.TsAnimNotifyStateAttachGroupMonster_C");
		}
		return TsAnimNotifyStateAttachGroupMonster._ClassPtr;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0005CEAC File Offset: 0x0005B0AC
	public TsAnimNotifyStateAttachGroupMonster() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttachGroupMonster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x0005CED4 File Offset: 0x0005B0D4
	public TsAnimNotifyStateAttachGroupMonster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyStateAttachGroupMonster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x0005CF07 File Offset: 0x0005B107
	protected TsAnimNotifyStateAttachGroupMonster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x0005CF2C File Offset: 0x0005B12C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyBegin_Implementation(UKuroAnimNotifyState.__K2_NotifyBegin_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyBegin(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->TotalDuration);
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x0005CF68 File Offset: 0x0005B168
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyTick_Implementation(UKuroAnimNotifyState.__K2_NotifyTick_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyTick(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->FrameDeltaTime);
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_NotifyEnd_Implementation(UKuroAnimNotifyState.__K2_NotifyEnd_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_NotifyEnd(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x0005CFD7 File Offset: 0x0005B1D7
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotifyState.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04000C6A RID: 3178
	private const float MAX_ANIM_TIME = 9999f;

	// Token: 0x04000C6B RID: 3179
	private string ATTACH_SOCKET_NAME = CharacterNameDefines.Instance.ROOT.ToString();

	// Token: 0x04000C6C RID: 3180
	private static bool IsInit;

	// Token: 0x04000C6D RID: 3181
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<AActor, AttachGroupMonsterParams> CacheMap;

	// Token: 0x04000C6E RID: 3182
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector1 = Vector.Create();

	// Token: 0x04000C6F RID: 3183
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector2 = Vector.Create();

	// Token: 0x04000C70 RID: 3184
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotifyState/TsAnimNotifyStateAttachGroupMonster.TsAnimNotifyStateAttachGroupMonster_C";

	// Token: 0x04000C71 RID: 3185
	private static IntPtr _ClassPtr;

	// Token: 0x04000C72 RID: 3186
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000C73 RID: 3187
	private static int __PropertyOffset_GameplayTag;

	// Token: 0x04000C74 RID: 3188
	private static int __PropertyOffset_AttachSocketName;

	// Token: 0x04000C75 RID: 3189
	private static int __PropertyOffset_AttachSocketOffset;
}
