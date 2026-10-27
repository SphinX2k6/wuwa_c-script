using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DF RID: 479
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTeleport.TsAnimNotifyTeleport_C")]
public class TsAnimNotifyTeleport : TsAnimNotifyBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004D4 RID: 1236
	// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0009614F File Offset: 0x0009434F
	// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0009615F File Offset: 0x0009435F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 传送基于角色坐标系
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyTeleport.__PropertyOffset_传送基于角色坐标系) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyTeleport.__PropertyOffset_传送基于角色坐标系) = (value ? 1 : 0);
		}
	}

	// Token: 0x170004D5 RID: 1237
	// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00096170 File Offset: 0x00094370
	// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00096184 File Offset: 0x00094384
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVectorDouble 传送偏移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyTeleport.__PropertyOffset_传送偏移);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyTeleport.__PropertyOffset_传送偏移) = value;
		}
	}

	// Token: 0x170004D6 RID: 1238
	// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00096199 File Offset: 0x00094399
	// (set) Token: 0x06001DEC RID: 7660 RVA: 0x000961A9 File Offset: 0x000943A9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool 镜头瞬移
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsAnimNotifyTeleport.__PropertyOffset_镜头瞬移) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsAnimNotifyTeleport.__PropertyOffset_镜头瞬移) = (value ? 1 : 0);
		}
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x000961BA File Offset: 0x000943BA
	static TsAnimNotifyTeleport()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyTeleport.CreateStaticDefaultValue), new Action(TsAnimNotifyTeleport.ResetStaticDefaultValue));
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x000961DC File Offset: 0x000943DC
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyTeleport.GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		TsAnimNotifyTeleport.InverseGravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		TsAnimNotifyTeleport.TempVector = new Vector();
	}

	// Token: 0x06001DEF RID: 7663 RVA: 0x0009624F File Offset: 0x0009444F
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyTeleport.GravityQuat = null;
		TsAnimNotifyTeleport.InverseGravityQuat = null;
		TsAnimNotifyTeleport.TempVector = null;
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x00096264 File Offset: 0x00094464
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

	// Token: 0x06001DF1 RID: 7665 RVA: 0x00096304 File Offset: 0x00094504
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
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
		TsAnimNotifyTeleport.Initialize();
		if (this.传送基于角色坐标系)
		{
			characterActorComponent.AddActorLocalOffset(this.传送偏移, "传送并设置镜头位置", true);
		}
		else
		{
			Vector tempVector = TsAnimNotifyTeleport.TempVector;
			FVectorDouble 传送偏移 = this.传送偏移;
			tempVector.DeepCopy(传送偏移);
			GravityUtils.Instance.GetBaseQuatInGravityForActor(characterActorComponent, TsAnimNotifyTeleport.GravityQuat);
			TsAnimNotifyTeleport.GravityQuat.Inverse(TsAnimNotifyTeleport.InverseGravityQuat);
			GravityUtils.Instance.GetVectorInNormal(TsAnimNotifyTeleport.TempVector, TsAnimNotifyTeleport.InverseGravityQuat, TsAnimNotifyTeleport.TempVector);
			characterActorComponent.AddActorWorldOffset(TsAnimNotifyTeleport.TempVector.ToUeVector(false), "传送并设置镜头位置", true);
		}
		if (this.镜头瞬移)
		{
			FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
			if (fightCamera != null)
			{
				FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
				if (logicComponent != null)
				{
					logicComponent.ResetFightCameraLogic(false, true);
				}
			}
		}
		return true;
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x00096408 File Offset: 0x00094608
	private static void Initialize()
	{
		if (TsAnimNotifyTeleport.GravityQuat != null)
		{
			return;
		}
		TsAnimNotifyTeleport.GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		TsAnimNotifyTeleport.InverseGravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		TsAnimNotifyTeleport.TempVector = Vector.Create();
	}

	// Token: 0x06001DF3 RID: 7667 RVA: 0x00096484 File Offset: 0x00094684
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

	// Token: 0x06001DF4 RID: 7668 RVA: 0x000964FF File Offset: 0x000946FF
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "传送并设置镜头位置";
	}

	// Token: 0x06001DF5 RID: 7669 RVA: 0x00096506 File Offset: 0x00094706
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyTeleport._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTeleport.TsAnimNotifyTeleport_C");
		}
		return TsAnimNotifyTeleport._ClassPtr;
	}

	// Token: 0x06001DF6 RID: 7670 RVA: 0x0009652C File Offset: 0x0009472C
	public TsAnimNotifyTeleport() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTeleport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DF7 RID: 7671 RVA: 0x00096554 File Offset: 0x00094754
	[NullableContext(1)]
	public TsAnimNotifyTeleport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTeleport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DF8 RID: 7672 RVA: 0x00096587 File Offset: 0x00094787
	protected TsAnimNotifyTeleport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DF9 RID: 7673 RVA: 0x00096590 File Offset: 0x00094790
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001DFA RID: 7674 RVA: 0x000965C3 File Offset: 0x000947C3
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x04001284 RID: 4740
	[Nullable(2)]
	private static Quat GravityQuat;

	// Token: 0x04001285 RID: 4741
	[Nullable(2)]
	private static Quat InverseGravityQuat;

	// Token: 0x04001286 RID: 4742
	[Nullable(2)]
	private static Vector TempVector;

	// Token: 0x04001287 RID: 4743
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTeleport.TsAnimNotifyTeleport_C";

	// Token: 0x04001288 RID: 4744
	private static IntPtr _ClassPtr;

	// Token: 0x04001289 RID: 4745
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400128A RID: 4746
	private static int __PropertyOffset_传送基于角色坐标系;

	// Token: 0x0400128B RID: 4747
	private static int __PropertyOffset_传送偏移;

	// Token: 0x0400128C RID: 4748
	private static int __PropertyOffset_镜头瞬移;
}
