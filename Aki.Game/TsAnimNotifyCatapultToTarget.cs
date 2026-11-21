using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using Cysharp.Threading.Tasks;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001A5 RID: 421
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCatapultToTarget.TsAnimNotifyCatapultToTarget_C")]
public class TsAnimNotifyCatapultToTarget : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000470 RID: 1136
	// (get) Token: 0x06001B1B RID: 6939 RVA: 0x00090B13 File Offset: 0x0008ED13
	// (set) Token: 0x06001B1C RID: 6940 RVA: 0x00090B27 File Offset: 0x0008ED27
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

	// Token: 0x17000471 RID: 1137
	// (get) Token: 0x06001B1D RID: 6941 RVA: 0x00090B3C File Offset: 0x0008ED3C
	// (set) Token: 0x06001B1E RID: 6942 RVA: 0x00090B4C File Offset: 0x0008ED4C
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

	// Token: 0x06001B1F RID: 6943 RVA: 0x00090B60 File Offset: 0x0008ED60
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

	// Token: 0x06001B20 RID: 6944 RVA: 0x00090BFF File Offset: 0x0008EDFF
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public override string GetNotifyName()
	{
		return "角色弹射到目标";
	}

	// Token: 0x06001B21 RID: 6945 RVA: 0x00090C06 File Offset: 0x0008EE06
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyCatapultToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCatapultToTarget.TsAnimNotifyCatapultToTarget_C");
		}
		return TsAnimNotifyCatapultToTarget._ClassPtr;
	}

	// Token: 0x06001B22 RID: 6946 RVA: 0x00090C2C File Offset: 0x0008EE2C
	public TsAnimNotifyCatapultToTarget() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCatapultToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001B23 RID: 6947 RVA: 0x00090C54 File Offset: 0x0008EE54
	[NullableContext(1)]
	public TsAnimNotifyCatapultToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyCatapultToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001B24 RID: 6948 RVA: 0x00090C87 File Offset: 0x0008EE87
	protected TsAnimNotifyCatapultToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001B25 RID: 6949 RVA: 0x00090C90 File Offset: 0x0008EE90
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001B26 RID: 6950 RVA: 0x00090CC3 File Offset: 0x0008EEC3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName());
	}

	// Token: 0x04001171 RID: 4465
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpPos = Vector.Create();

	// Token: 0x04001172 RID: 4466
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpOffset = Vector.Create();

	// Token: 0x04001173 RID: 4467
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyCatapultToTarget.TsAnimNotifyCatapultToTarget_C";

	// Token: 0x04001174 RID: 4468
	private static IntPtr _ClassPtr;

	// Token: 0x04001175 RID: 4469
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04001176 RID: 4470
	private static int __PropertyOffset_LocationOffset;

	// Token: 0x04001177 RID: 4471
	private static int __PropertyOffset_Time;
}
