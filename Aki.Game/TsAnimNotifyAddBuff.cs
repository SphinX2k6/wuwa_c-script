using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.CombatMessage;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200018E RID: 398
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddBuff.TsAnimNotifyAddBuff_C")]
public class TsAnimNotifyAddBuff : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x06001968 RID: 6504 RVA: 0x000865A7 File Offset: 0x000847A7
	// (set) Token: 0x06001969 RID: 6505 RVA: 0x000865B7 File Offset: 0x000847B7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long BuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyAddBuff.__PropertyOffset_BuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyAddBuff.__PropertyOffset_BuffId) = value;
		}
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x000865C8 File Offset: 0x000847C8
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

	// Token: 0x0600196B RID: 6507 RVA: 0x00086668 File Offset: 0x00084868
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter != null)
		{
			CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
			Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
			CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
			CharacterBuffComponent component = entity.GetComponent<CharacterBuffComponent>();
			if (component == null)
			{
				return true;
			}
			if (!component.HasBuffAuthority() && !SkillMessageController.Instance.CloseMonsterServerLogic)
			{
				return true;
			}
			if (creatureDataComponent.IsRole() && !component.HasBuffAuthority())
			{
				return true;
			}
			long? preMessageId = component.CreateAnimNotifyContent(animation.GetName(), base.exportIndex);
			component.AddBuff(this.BuffId, new AddBuffParam
			{
				InstigatorId = component.CreatureDataId,
				PreMessageId = preMessageId,
				Reason = "动画" + animation.GetName() + "的AN添加"
			});
		}
		return true;
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x00086730 File Offset: 0x00084930
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

	// Token: 0x0600196D RID: 6509 RVA: 0x000867AB File Offset: 0x000849AB
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "添加BUFF";
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x000867B2 File Offset: 0x000849B2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyAddBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddBuff.TsAnimNotifyAddBuff_C");
		}
		return TsAnimNotifyAddBuff._ClassPtr;
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x000867D8 File Offset: 0x000849D8
	public TsAnimNotifyAddBuff() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x00086800 File Offset: 0x00084A00
	[NullableContext(1)]
	public TsAnimNotifyAddBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyAddBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x00086833 File Offset: 0x00084A33
	protected TsAnimNotifyAddBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x0008683C File Offset: 0x00084A3C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x0008686F File Offset: 0x00084A6F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040010BC RID: 4284
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyAddBuff.TsAnimNotifyAddBuff_C";

	// Token: 0x040010BD RID: 4285
	private static IntPtr _ClassPtr;

	// Token: 0x040010BE RID: 4286
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040010BF RID: 4287
	private static int __PropertyOffset_BuffId;
}
