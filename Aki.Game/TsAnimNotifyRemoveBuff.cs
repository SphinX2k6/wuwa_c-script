using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.CombatMessage;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001CD RID: 461
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveBuff.TsAnimNotifyRemoveBuff_C")]
public class TsAnimNotifyRemoveBuff : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004B3 RID: 1203
	// (get) Token: 0x06001D2A RID: 7466 RVA: 0x000981BF File Offset: 0x000963BF
	// (set) Token: 0x06001D2B RID: 7467 RVA: 0x000981CF File Offset: 0x000963CF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long BuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveBuff.__PropertyOffset_BuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveBuff.__PropertyOffset_BuffId) = value;
		}
	}

	// Token: 0x170004B4 RID: 1204
	// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000981E0 File Offset: 0x000963E0
	// (set) Token: 0x06001D2D RID: 7469 RVA: 0x000981F0 File Offset: 0x000963F0
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int StackCount
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyRemoveBuff.__PropertyOffset_StackCount);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyRemoveBuff.__PropertyOffset_StackCount) = value;
		}
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x00098204 File Offset: 0x00096404
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
			component.RemoveBuff(this.BuffId, this.StackCount, "动画" + animation.GetName() + "的AN移除", preMessageId, null, null);
		}
		return true;
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x000982C6 File Offset: 0x000964C6
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "移除BUFF";
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x000982CD File Offset: 0x000964CD
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRemoveBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveBuff.TsAnimNotifyRemoveBuff_C");
		}
		return TsAnimNotifyRemoveBuff._ClassPtr;
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x000982F4 File Offset: 0x000964F4
	public TsAnimNotifyRemoveBuff() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x0009831C File Offset: 0x0009651C
	[NullableContext(1)]
	public TsAnimNotifyRemoveBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x0009834F File Offset: 0x0009654F
	protected TsAnimNotifyRemoveBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x00098358 File Offset: 0x00096558
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x0009838B File Offset: 0x0009658B
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04001235 RID: 4661
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveBuff.TsAnimNotifyRemoveBuff_C";

	// Token: 0x04001236 RID: 4662
	private static IntPtr _ClassPtr;

	// Token: 0x04001237 RID: 4663
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001238 RID: 4664
	private static int __PropertyOffset_BuffId;

	// Token: 0x04001239 RID: 4665
	private static int __PropertyOffset_StackCount;
}
