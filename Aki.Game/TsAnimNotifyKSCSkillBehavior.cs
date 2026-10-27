using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C2 RID: 450
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyKSCSkillBehavior.TsAnimNotifyKSCSkillBehavior_C")]
public class TsAnimNotifyKSCSkillBehavior : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000483 RID: 1155
	// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0008FC73 File Offset: 0x0008DE73
	// (set) Token: 0x06001C26 RID: 7206 RVA: 0x0008FC87 File Offset: 0x0008DE87
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

	// Token: 0x06001C27 RID: 7207 RVA: 0x0008FC9C File Offset: 0x0008DE9C
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

	// Token: 0x06001C28 RID: 7208 RVA: 0x0008FD3C File Offset: 0x0008DF3C
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

	// Token: 0x06001C29 RID: 7209 RVA: 0x0008FDC8 File Offset: 0x0008DFC8
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

	// Token: 0x06001C2A RID: 7210 RVA: 0x0008FE43 File Offset: 0x0008E043
	protected override string GetNotifyName_Implementation()
	{
		return "KSC技能行为";
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x0008FE4C File Offset: 0x0008E04C
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

	// Token: 0x06001C2C RID: 7212 RVA: 0x0008FE80 File Offset: 0x0008E080
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

	// Token: 0x06001C2D RID: 7213 RVA: 0x00090068 File Offset: 0x0008E268
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

	// Token: 0x06001C2E RID: 7214 RVA: 0x000901C4 File Offset: 0x0008E3C4
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

	// Token: 0x06001C2F RID: 7215 RVA: 0x00090260 File Offset: 0x0008E460
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

	// Token: 0x06001C30 RID: 7216 RVA: 0x000902E3 File Offset: 0x0008E4E3
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

	// Token: 0x06001C31 RID: 7217 RVA: 0x000902F5 File Offset: 0x0008E4F5
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyKSCSkillBehavior._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyKSCSkillBehavior.TsAnimNotifyKSCSkillBehavior_C");
		}
		return TsAnimNotifyKSCSkillBehavior._ClassPtr;
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x0009031C File Offset: 0x0008E51C
	public TsAnimNotifyKSCSkillBehavior() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyKSCSkillBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x00090344 File Offset: 0x0008E544
	public TsAnimNotifyKSCSkillBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyKSCSkillBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x00090377 File Offset: 0x0008E577
	protected TsAnimNotifyKSCSkillBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x00090380 File Offset: 0x0008E580
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x000903B3 File Offset: 0x0008E5B3
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040011CF RID: 4559
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyKSCSkillBehavior.TsAnimNotifyKSCSkillBehavior_C";

	// Token: 0x040011D0 RID: 4560
	private static IntPtr _ClassPtr;

	// Token: 0x040011D1 RID: 4561
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011D2 RID: 4562
	private static int __PropertyOffset_Action;
}
