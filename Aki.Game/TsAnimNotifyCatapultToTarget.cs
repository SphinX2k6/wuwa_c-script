using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A1 RID: 417
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCatapultToTarget.TsAnimNotifyCatapultToTarget_C")]
public class TsAnimNotifyCatapultToTarget : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700044E RID: 1102
	// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0008A49F File Offset: 0x0008869F
	// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0008A4B3 File Offset: 0x000886B3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector LocationOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCatapultToTarget.__PropertyOffset_LocationOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCatapultToTarget.__PropertyOffset_LocationOffset) = value;
		}
	}

	// Token: 0x1700044F RID: 1103
	// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0008A4C8 File Offset: 0x000886C8
	// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0008A4D8 File Offset: 0x000886D8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Time
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyCatapultToTarget.__PropertyOffset_Time);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyCatapultToTarget.__PropertyOffset_Time) = value;
		}
	}

	// Token: 0x06001A82 RID: 6786 RVA: 0x0008A4EC File Offset: 0x000886EC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsBaseCharacter tsBaseCharacter = meshComp.GetOwner() as TsBaseCharacter;
		if (tsBaseCharacter == null)
		{
			return false;
		}
		CharacterActorComponent characterActorComponent = tsBaseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterActionComponent characterActionComponent = (entity != null) ? entity.GetComponent<CharacterActionComponent>() : null;
		if (characterActionComponent == null)
		{
			return false;
		}
		CharacterExploreComponent characterExploreComponent = (entity != null) ? entity.GetComponent<CharacterExploreComponent>() : null;
		Vector vector = (characterExploreComponent != null) ? characterExploreComponent.GetInteractingTargetLocation() : null;
		if (vector == null)
		{
			return false;
		}
		Vector tmpPos = TsAnimNotifyCatapultToTarget.TmpPos;
		tmpPos.DeepCopy(vector);
		Vector tmpOffset = TsAnimNotifyCatapultToTarget.TmpOffset;
		Vector vector2 = tmpOffset;
		FVector locationOffset = this.LocationOffset;
		vector2.FromUeVector(locationOffset);
		characterActionComponent.StartCatapultToTargetByTime(tmpPos, tmpOffset, this.Time, 0).Forget<bool>();
		return true;
	}

	// Token: 0x06001A83 RID: 6787 RVA: 0x0008A58B File Offset: 0x0008878B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "角色弹射到目标";
	}

	// Token: 0x06001A84 RID: 6788 RVA: 0x0008A592 File Offset: 0x00088792
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCatapultToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCatapultToTarget.TsAnimNotifyCatapultToTarget_C");
		}
		return TsAnimNotifyCatapultToTarget._ClassPtr;
	}

	// Token: 0x06001A85 RID: 6789 RVA: 0x0008A5B8 File Offset: 0x000887B8
	public TsAnimNotifyCatapultToTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCatapultToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001A86 RID: 6790 RVA: 0x0008A5E0 File Offset: 0x000887E0
	[NullableContext(1)]
	public TsAnimNotifyCatapultToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCatapultToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001A87 RID: 6791 RVA: 0x0008A613 File Offset: 0x00088813
	protected TsAnimNotifyCatapultToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001A88 RID: 6792 RVA: 0x0008A61C File Offset: 0x0008881C
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001A89 RID: 6793 RVA: 0x0008A64F File Offset: 0x0008884F
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x0400112E RID: 4398
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpPos = Vector.Create();

	// Token: 0x0400112F RID: 4399
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpOffset = Vector.Create();

	// Token: 0x04001130 RID: 4400
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCatapultToTarget.TsAnimNotifyCatapultToTarget_C";

	// Token: 0x04001131 RID: 4401
	private static IntPtr _ClassPtr;

	// Token: 0x04001132 RID: 4402
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001133 RID: 4403
	private static int __PropertyOffset_LocationOffset;

	// Token: 0x04001134 RID: 4404
	private static int __PropertyOffset_Time;
}
