using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000195 RID: 405
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleQte.TsAnimNotifyBattleQte_C")]
public class TsAnimNotifyBattleQte : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000430 RID: 1072
	// (get) Token: 0x060019CB RID: 6603 RVA: 0x00087FEB File Offset: 0x000861EB
	// (set) Token: 0x060019CC RID: 6604 RVA: 0x00087FFB File Offset: 0x000861FB
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

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x060019CD RID: 6605 RVA: 0x0008800C File Offset: 0x0008620C
	// (set) Token: 0x060019CE RID: 6606 RVA: 0x0008801C File Offset: 0x0008621C
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

	// Token: 0x17000432 RID: 1074
	// (get) Token: 0x060019CF RID: 6607 RVA: 0x0008802D File Offset: 0x0008622D
	// (set) Token: 0x060019D0 RID: 6608 RVA: 0x00088041 File Offset: 0x00086241
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

	// Token: 0x060019D1 RID: 6609 RVA: 0x00088058 File Offset: 0x00086258
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

	// Token: 0x060019D2 RID: 6610 RVA: 0x000880F8 File Offset: 0x000862F8
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

	// Token: 0x060019D3 RID: 6611 RVA: 0x00088228 File Offset: 0x00086428
	[NullableContext(1)]
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

	// Token: 0x060019D4 RID: 6612 RVA: 0x000882A3 File Offset: 0x000864A3
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "战斗QTE";
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x000882AA File Offset: 0x000864AA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyBattleQte._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleQte.TsAnimNotifyBattleQte_C");
		}
		return TsAnimNotifyBattleQte._ClassPtr;
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x000882D0 File Offset: 0x000864D0
	public TsAnimNotifyBattleQte() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleQte.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x000882F8 File Offset: 0x000864F8
	[NullableContext(1)]
	public TsAnimNotifyBattleQte(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyBattleQte.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x0008832B File Offset: 0x0008652B
	protected TsAnimNotifyBattleQte(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x00088334 File Offset: 0x00086534
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x00088367 File Offset: 0x00086567
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010E6 RID: 4326
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyBattleQte.TsAnimNotifyBattleQte_C";

	// Token: 0x040010E7 RID: 4327
	private static IntPtr _ClassPtr;

	// Token: 0x040010E8 RID: 4328
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010E9 RID: 4329
	private static int __PropertyOffset_BattleQteId;

	// Token: 0x040010EA RID: 4330
	private static int __PropertyOffset_当前实体为玩家控制时才触发;

	// Token: 0x040010EB RID: 4331
	private static int __PropertyOffset_存在Tag时才触发;
}
