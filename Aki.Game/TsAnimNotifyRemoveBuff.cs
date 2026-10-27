using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.CombatMessage;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001C9 RID: 457
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveBuff.TsAnimNotifyRemoveBuff_C")]
public class TsAnimNotifyRemoveBuff : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000491 RID: 1169
	// (get) Token: 0x06001C8D RID: 7309 RVA: 0x00091547 File Offset: 0x0008F747
	// (set) Token: 0x06001C8E RID: 7310 RVA: 0x00091557 File Offset: 0x0008F757
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

	// Token: 0x17000492 RID: 1170
	// (get) Token: 0x06001C8F RID: 7311 RVA: 0x00091568 File Offset: 0x0008F768
	// (set) Token: 0x06001C90 RID: 7312 RVA: 0x00091578 File Offset: 0x0008F778
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

	// Token: 0x06001C91 RID: 7313 RVA: 0x0009158C File Offset: 0x0008F78C
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

	// Token: 0x06001C92 RID: 7314 RVA: 0x0009164E File Offset: 0x0008F84E
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "移除BUFF";
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x00091655 File Offset: 0x0008F855
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyRemoveBuff._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveBuff.TsAnimNotifyRemoveBuff_C");
		}
		return TsAnimNotifyRemoveBuff._ClassPtr;
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x0009167C File Offset: 0x0008F87C
	public TsAnimNotifyRemoveBuff() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveBuff.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x000916A4 File Offset: 0x0008F8A4
	[NullableContext(1)]
	public TsAnimNotifyRemoveBuff(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyRemoveBuff.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x000916D7 File Offset: 0x0008F8D7
	protected TsAnimNotifyRemoveBuff(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x000916E0 File Offset: 0x0008F8E0
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x00091713 File Offset: 0x0008F913
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x040011F2 RID: 4594
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyRemoveBuff.TsAnimNotifyRemoveBuff_C";

	// Token: 0x040011F3 RID: 4595
	private static IntPtr _ClassPtr;

	// Token: 0x040011F4 RID: 4596
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040011F5 RID: 4597
	private static int __PropertyOffset_BuffId;

	// Token: 0x040011F6 RID: 4598
	private static int __PropertyOffset_StackCount;
}
