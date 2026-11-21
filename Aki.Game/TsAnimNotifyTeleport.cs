using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E3 RID: 483
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTeleport.TsAnimNotifyTeleport_C")]
public class TsAnimNotifyTeleport : TsAnimNotifyBase, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0009D137 File Offset: 0x0009B337
	// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0009D147 File Offset: 0x0009B347
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

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0009D158 File Offset: 0x0009B358
	// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0009D16C File Offset: 0x0009B36C
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

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0009D181 File Offset: 0x0009B381
	// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0009D191 File Offset: 0x0009B391
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

	// Token: 0x06001E8A RID: 7818 RVA: 0x0009D1A2 File Offset: 0x0009B3A2
	static TsAnimNotifyTeleport()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsAnimNotifyTeleport.CreateStaticDefaultValue), new Action(TsAnimNotifyTeleport.ResetStaticDefaultValue));
	}

	// Token: 0x06001E8B RID: 7819 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
	public static void CreateStaticDefaultValue()
	{
		TsAnimNotifyTeleport.GravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		TsAnimNotifyTeleport.InverseGravityQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
		TsAnimNotifyTeleport.TempVector = new Vector();
	}

	// Token: 0x06001E8C RID: 7820 RVA: 0x0009D237 File Offset: 0x0009B437
	public static void ResetStaticDefaultValue()
	{
		TsAnimNotifyTeleport.GravityQuat = null;
		TsAnimNotifyTeleport.InverseGravityQuat = null;
		TsAnimNotifyTeleport.TempVector = null;
	}

	// Token: 0x06001E8D RID: 7821 RVA: 0x0009D24C File Offset: 0x0009B44C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyTeleport) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifyTeleport.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E8E RID: 7822 RVA: 0x0009D304 File Offset: 0x0009B504
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

	// Token: 0x06001E8F RID: 7823 RVA: 0x0009D408 File Offset: 0x0009B608
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

	// Token: 0x06001E90 RID: 7824 RVA: 0x0009D484 File Offset: 0x0009B684
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override string GetNotifyName()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifyTeleport) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetNotifyName"), TsAnimNotifyTeleport.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E91 RID: 7825 RVA: 0x0009D514 File Offset: 0x0009B714
	[NullableContext(1)]
	protected override string GetNotifyName_Implementation()
	{
		return "传送并设置镜头位置";
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x0009D51B File Offset: 0x0009B71B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifyTeleport._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTeleport.TsAnimNotifyTeleport_C");
		}
		return TsAnimNotifyTeleport._ClassPtr;
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x0009D540 File Offset: 0x0009B740
	public TsAnimNotifyTeleport() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTeleport.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x0009D568 File Offset: 0x0009B768
	[NullableContext(1)]
	public TsAnimNotifyTeleport(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifyTeleport.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x0009D59B File Offset: 0x0009B79B
	protected TsAnimNotifyTeleport(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x0009D5A4 File Offset: 0x0009B7A4
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06001E97 RID: 7831 RVA: 0x0009D5D7 File Offset: 0x0009B7D7
	protected unsafe virtual void __CPPCALL_GetNotifyName_Implementation(UAnimNotify.__GetNotifyName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetNotifyName_Implementation());
	}

	// Token: 0x040012C7 RID: 4807
	[Nullable(2)]
	private static Quat GravityQuat;

	// Token: 0x040012C8 RID: 4808
	[Nullable(2)]
	private static Quat InverseGravityQuat;

	// Token: 0x040012C9 RID: 4809
	[Nullable(2)]
	private static Vector TempVector;

	// Token: 0x040012CA RID: 4810
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifyTeleport.TsAnimNotifyTeleport_C";

	// Token: 0x040012CB RID: 4811
	private static IntPtr _ClassPtr;

	// Token: 0x040012CC RID: 4812
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040012CD RID: 4813
	private static int __PropertyOffset_传送基于角色坐标系;

	// Token: 0x040012CE RID: 4814
	private static int __PropertyOffset_传送偏移;

	// Token: 0x040012CF RID: 4815
	private static int __PropertyOffset_镜头瞬移;
}
