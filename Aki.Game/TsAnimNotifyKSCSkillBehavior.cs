using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C6 RID: 454
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyKSCSkillBehavior.TsAnimNotifyKSCSkillBehavior_C")]
public class TsAnimNotifyKSCSkillBehavior : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004A5 RID: 1189
	// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000967B7 File Offset: 0x000949B7
	// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x000967CB File Offset: 0x000949CB
	[Nullable(2)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe KscBpDataBase Action
	{
		[NullableContext(2)]
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<KscBpDataBase>(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyKSCSkillBehavior.__PropertyOffset_Action);
		}
		[NullableContext(2)]
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsAnimNotifyKSCSkillBehavior.__PropertyOffset_Action, value);
		}
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x000967E0 File Offset: 0x000949E0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyKSCSkillBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyKSCSkillBehavior.StaticClass(), out intPtr, out num))
		{
			return this.K2_Notify_Implementation(meshComp, animation);
		}
		UKuroAnimNotify.__K2_Notify_FunctionParams* ptr = stackalloc UKuroAnimNotify.__K2_Notify_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UKuroAnimNotify.__K2_Notify_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->MeshComp) = ((meshComp != null) ? meshComp.NativePtr : ((IntPtr)0));
		*(&ptr->Animation) = ((animation != null) ? animation.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x00096898 File Offset: 0x00094A98
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		KscBpDataBase action = this.Action;
		if (action == null)
		{
			this.Warn((meshComp != null) ? meshComp.GetOwner() : null, "KSC技能行为执行失败: 未配置Action", Array.Empty<ValueTuple<string, object>>());
			return false;
		}
		KscSkillData kscSkillData = action as KscSkillData;
		if (kscSkillData != null)
		{
			return this.ExecuteSkillAction(meshComp, kscSkillData);
		}
		KscBulletData kscBulletData = action as KscBulletData;
		if (kscBulletData != null)
		{
			return this.ExecuteBulletAction(meshComp, kscBulletData);
		}
		this.Warn((meshComp != null) ? meshComp.GetOwner() : null, "KSC技能行为执行失败: 未支持的Action类型", new ValueTuple<string, object>[]
		{
			new ValueTuple<string, object>("action", action)
		});
		return false;
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x00096924 File Offset: 0x00094B24
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyKSCSkillBehavior) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyKSCSkillBehavior.StaticClass(), out intPtr, out num))
		{
			return this.GetNotifyName_Implementation();
		}
		UAnimNotify.__GetNotifyName_FunctionParams* ptr = stackalloc UAnimNotify.__GetNotifyName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UAnimNotify.__GetNotifyName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x000969B4 File Offset: 0x00094BB4
	protected override string GetNotifyName_Implementation()
	{
		return "KSC技能行为";
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x000969BC File Offset: 0x00094BBC
	private bool ExecuteSkillAction(USkeletalMeshComponent meshComp, KscSkillData action)
	{
		KscNotifyCharacterContext characterContext = this.GetCharacterContext(meshComp, "技能");
		if (characterContext == null)
		{
			return false;
		}
		TowerDefensePlayerController.DoSkill(characterContext.Entity, action.SkillIndex);
		return true;
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x000969F0 File Offset: 0x00094BF0
	private bool ExecuteBulletAction(USkeletalMeshComponent meshComp, KscBulletData action)
	{
		if (action.BulletConfigId <= 0)
		{
			this.Warn(meshComp.GetOwner(), "KSC子弹行为执行失败: BulletConfigId非法", new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("BulletConfigId", action.BulletConfigId)
			});
			return false;
		}
		KscNotifyCharacterContext characterContext = this.GetCharacterContext(meshComp, "子弹");
		if (characterContext == null)
		{
			return false;
		}
		UBulletWorld kuroBulletWorld = BulletModel.Instance.GetKuroBulletWorld();
		if (kuroBulletWorld == null)
		{
			this.Warn(characterContext.Owner, "KSC子弹行为执行失败: BulletWorld不存在", Array.Empty<ValueTuple<string, object>>());
			return false;
		}
		CreatureDataComponent component = characterContext.Entity.GetComponent<CreatureDataComponent>();
		long? num = (component != null) ? new long?(component.GetCreatureDataId()) : null;
		if (num != null)
		{
			long? num2 = num;
			long num3 = 0L;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				AKSC_Entity kscEntityHandle = KuroSimpleCombatController.Instance.GetKscEntityHandle(num.Value);
				if (kscEntityHandle == null)
				{
					this.Warn(characterContext.Owner, "KSC子弹行为执行失败: 无已绑定的KSC实体", new ValueTuple<string, object>[]
					{
						new ValueTuple<string, object>("creatureId", num.Value),
						new ValueTuple<string, object>("hasSubModel", KuroSimpleCombatController.Instance.CurSubModel != null)
					});
					return false;
				}
				UKSC_Bullet_Context uksc_Bullet_Context = kuroBulletWorld.PoolGet(UKSC_Bullet_Context.StaticClass()) as UKSC_Bullet_Context;
				if (uksc_Bullet_Context == null)
				{
					this.Warn(characterContext.Owner, "KSC子弹行为执行失败: 无法从BulletWorld对象池获取BulletContext", Array.Empty<ValueTuple<string, object>>());
					return false;
				}
				uksc_Bullet_Context.Owner = new TWeakObjectPtr<AKSC_Entity>(kscEntityHandle);
				uksc_Bullet_Context.SkillTargetEntityId = 0;
				FBulletSpawnParams fbulletSpawnParams = new FBulletSpawnParams();
				fbulletSpawnParams.InitialTransform = this.ResolveBulletSpawnTransform(meshComp, characterContext.Owner, action);
				kuroBulletWorld.CreateBullet(uksc_Bullet_Context, (long)action.BulletConfigId, fbulletSpawnParams);
				return true;
			}
		}
		this.Warn(characterContext.Owner, "KSC子弹行为执行失败: 无法获取CreatureDataId", new ValueTuple<string, object>[]
		{
			new ValueTuple<string, object>("entityId", characterContext.Entity.Id)
		});
		return false;
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x00096BD8 File Offset: 0x00094DD8
	private FTransformDouble ResolveBulletSpawnTransform(USkeletalMeshComponent meshComp, TsBaseCharacter owner, KscBulletData action)
	{
		FTransformDouble result = owner.D_GetTransform();
		string meshComponentName = action.LaunchMeshComponentName.Trim();
		string text = action.LaunchBoneOrSocketName.Trim();
		if (text.Length == 0)
		{
			return result;
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.FindLaunchMeshComponent(owner, meshComp, meshComponentName);
		if (uskeletalMeshComponent == null)
		{
			this.Warn(owner, "KSC子弹行为执行警告: 发射骨骼网格体不存在，回退RootTransform", new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("LaunchMeshComponentName", action.LaunchMeshComponentName),
				new ValueTuple<string, object>("LaunchBoneOrSocketName", action.LaunchBoneOrSocketName)
			});
			return result;
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(text);
		if (dynamicFName == null)
		{
			this.Warn(owner, "KSC子弹行为执行警告: 发射骨骼/Socket名字非法，回退RootTransform", new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("LaunchMeshComponentName", action.LaunchMeshComponentName),
				new ValueTuple<string, object>("LaunchBoneOrSocketName", action.LaunchBoneOrSocketName)
			});
			return result;
		}
		if (uskeletalMeshComponent.DoesSocketExist(dynamicFName.Value) || uskeletalMeshComponent.GetBoneIndex(dynamicFName.Value) >= 0)
		{
			return uskeletalMeshComponent.D_GetSocketTransform(dynamicFName.Value, ERelativeTransformSpace.RTS_World);
		}
		this.Warn(owner, "KSC子弹行为执行警告: 发射骨骼/Socket不存在，回退RootTransform", new ValueTuple<string, object>[]
		{
			new ValueTuple<string, object>("LaunchMeshComponentName", action.LaunchMeshComponentName),
			new ValueTuple<string, object>("LaunchBoneOrSocketName", action.LaunchBoneOrSocketName),
			new ValueTuple<string, object>("ResolvedMeshComponent", uskeletalMeshComponent)
		});
		return result;
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x00096D34 File Offset: 0x00094F34
	[return: Nullable(2)]
	private USkeletalMeshComponent FindLaunchMeshComponent(TsBaseCharacter owner, USkeletalMeshComponent currentMeshComp, string meshComponentName)
	{
		if (meshComponentName.Length == 0 || meshComponentName == "None")
		{
			CharacterActorComponent characterActorComponent = owner.CharacterActorComponent;
			if (characterActorComponent == null)
			{
				return null;
			}
			return characterActorComponent.SkeletalMesh;
		}
		else
		{
			if (currentMeshComp.GetName() == meshComponentName)
			{
				return currentMeshComp;
			}
			TArray<UActorComponent> tarray = owner.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				USkeletalMeshComponent uskeletalMeshComponent = tarray.Get(i) as USkeletalMeshComponent;
				if (uskeletalMeshComponent != null && uskeletalMeshComponent.GetName() == meshComponentName)
				{
					return uskeletalMeshComponent;
				}
			}
			CharacterActorComponent characterActorComponent2 = owner.CharacterActorComponent;
			if (characterActorComponent2 == null)
			{
				return null;
			}
			return characterActorComponent2.SkeletalMesh;
		}
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x00096DD0 File Offset: 0x00094FD0
	[return: Nullable(2)]
	private KscNotifyCharacterContext GetCharacterContext(USkeletalMeshComponent meshComp, string actionType)
	{
		AActor owner = meshComp.GetOwner();
		TsBaseCharacter tsBaseCharacter = owner as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			this.Warn(owner, "KSC" + actionType + "行为执行失败: Owner不是TsBaseCharacter", Array.Empty<ValueTuple<string, object>>());
			return null;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			this.Warn(owner, "KSC" + actionType + "行为执行失败: 缺少角色实体", Array.Empty<ValueTuple<string, object>>());
			return null;
		}
		return new KscNotifyCharacterContext
		{
			Owner = tsBaseCharacter,
			Entity = entity
		};
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x00096E53 File Offset: 0x00095053
	private void Warn([Nullable(2)] UObject obj, string log, [Nullable(new byte[]
	{
		1,
		0,
		1,
		2
	})] params ValueTuple<string, object>[] pairs)
	{
		KscLog.Warn(KscLog.EModule.Skill, ELogAuthor.TZQ, obj, log, pairs);
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x00096E65 File Offset: 0x00095065
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyKSCSkillBehavior._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyKSCSkillBehavior.TsAnimNotifyKSCSkillBehavior_C");
		}
		return TsAnimNotifyKSCSkillBehavior._ClassPtr;
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x00096E8C File Offset: 0x0009508C
	public TsAnimNotifyKSCSkillBehavior() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyKSCSkillBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001CD0 RID: 7376 RVA: 0x00096EB4 File Offset: 0x000950B4
	public TsAnimNotifyKSCSkillBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyKSCSkillBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001CD1 RID: 7377 RVA: 0x00096EE7 File Offset: 0x000950E7
	protected TsAnimNotifyKSCSkillBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001CD2 RID: 7378 RVA: 0x00096EF0 File Offset: 0x000950F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001CD3 RID: 7379 RVA: 0x00096F23 File Offset: 0x00095123
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001212 RID: 4626
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyKSCSkillBehavior.TsAnimNotifyKSCSkillBehavior_C";

	// Token: 0x04001213 RID: 4627
	private static IntPtr _ClassPtr;

	// Token: 0x04001214 RID: 4628
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001215 RID: 4629
	private static int __PropertyOffset_Action;
}
