using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000199 RID: 409
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleQte.TsAnimNotifyBattleQte_C")]
public class TsAnimNotifyBattleQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0008E44F File Offset: 0x0008C64F
	// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0008E45F File Offset: 0x0008C65F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BattleQteId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBattleQte.__PropertyOffset_BattleQteId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBattleQte.__PropertyOffset_BattleQteId) = value;
		}
	}

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0008E470 File Offset: 0x0008C670
	// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0008E480 File Offset: 0x0008C680
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 当前实体为玩家控制时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBattleQte.__PropertyOffset_当前实体为玩家控制时才触发) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBattleQte.__PropertyOffset_当前实体为玩家控制时才触发) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0008E491 File Offset: 0x0008C691
	// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0008E4A5 File Offset: 0x0008C6A5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FGameplayTag 存在Tag时才触发
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyBattleQte.__PropertyOffset_存在Tag时才触发);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyBattleQte.__PropertyOffset_存在Tag时才触发) = value;
		}
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x0008E4BC File Offset: 0x0008C6BC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBattleQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyBattleQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A6F RID: 6767 RVA: 0x0008E574 File Offset: 0x0008C774
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		AActor owner = meshComp.GetOwner();
		if (!(owner is TsBaseCharacter))
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = (owner as TsBaseCharacter).CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (this.当前实体为玩家控制时才触发)
		{
			if (characterActorComponent == null || !characterActorComponent.Valid)
			{
				return false;
			}
			if (!characterActorComponent.IsAutonomousProxy)
			{
				return false;
			}
		}
		FGameplayTag 存在Tag时才触发 = this.存在Tag时才触发;
		if (this.存在Tag时才触发.TagName != FName.NAME_None)
		{
			bool flag;
			if (entity == null)
			{
				flag = true;
			}
			else
			{
				BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
				flag = !((component != null) ? new bool?(component.HasTag(this.存在Tag时才触发.TagId())) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return false;
			}
		}
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandleByEntity(entity) : null;
		long? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			BaseBuffComponent component2 = entity.GetComponent<BaseBuffComponent>();
			num = ((component2 != null) ? component2.CreateAnimNotifyContent(animation.GetName(), base.exportIndex) : null);
		}
		long? num2 = num;
		if (entityHandle != null && num2 != null)
		{
			BattleQteController.Instance.StartBattleQte(this.BattleQteId, num2.Value, entityHandle, EBattleQteSource.AnimNotify);
		}
		return true;
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x0008E6A4 File Offset: 0x0008C8A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyBattleQte) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyBattleQte.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001A71 RID: 6769 RVA: 0x0008E734 File Offset: 0x0008C934
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "战斗QTE";
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x0008E73B File Offset: 0x0008C93B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBattleQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleQte.TsAnimNotifyBattleQte_C");
		}
		return TsAnimNotifyBattleQte._ClassPtr;
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x0008E760 File Offset: 0x0008C960
	public TsAnimNotifyBattleQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x0008E788 File Offset: 0x0008C988
	[NullableContext(1)]
	public TsAnimNotifyBattleQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x0008E7BB File Offset: 0x0008C9BB
	protected TsAnimNotifyBattleQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x0008E7C4 File Offset: 0x0008C9C4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x0008E7F7 File Offset: 0x0008C9F7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001129 RID: 4393
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleQte.TsAnimNotifyBattleQte_C";

	// Token: 0x0400112A RID: 4394
	private static IntPtr _ClassPtr;

	// Token: 0x0400112B RID: 4395
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400112C RID: 4396
	private static int __PropertyOffset_BattleQteId;

	// Token: 0x0400112D RID: 4397
	private static int __PropertyOffset_当前实体为玩家控制时才触发;

	// Token: 0x0400112E RID: 4398
	private static int __PropertyOffset_存在Tag时才触发;
}
