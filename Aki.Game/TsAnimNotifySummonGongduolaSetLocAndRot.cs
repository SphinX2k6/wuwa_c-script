using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.GongduolaSummon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001DC RID: 476
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonGongduolaSetLocAndRot.TsAnimNotifySummonGongduolaSetLocAndRot_C")]
public class TsAnimNotifySummonGongduolaSetLocAndRot : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001DA0 RID: 7584 RVA: 0x000952D0 File Offset: 0x000934D0
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

	// Token: 0x06001DA1 RID: 7585 RVA: 0x00095370 File Offset: 0x00093570
	[NullableContext(2)]
	protected virtual bool K2_Notify_Implementation(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		TsAnimNotifySummonGongduolaSetLocAndRot.<>c__DisplayClass1_0 CS$<>8__locals1 = new TsAnimNotifySummonGongduolaSetLocAndRot.<>c__DisplayClass1_0();
		AActor owner = meshComp.GetOwner();
		TsAnimNotifySummonGongduolaSetLocAndRot.<>c__DisplayClass1_0 CS$<>8__locals2 = CS$<>8__locals1;
		GongduolaSummonModel instance = GongduolaSummonModel.Instance;
		CS$<>8__locals2.newLoc = ((instance != null) ? instance.SummonLocation : null);
		TsAnimNotifySummonGongduolaSetLocAndRot.<>c__DisplayClass1_0 CS$<>8__locals3 = CS$<>8__locals1;
		GongduolaSummonModel instance2 = GongduolaSummonModel.Instance;
		CS$<>8__locals3.newRot = ((instance2 != null) ? instance2.SummonRotation : null);
		GongduolaSummonModel instance3 = GongduolaSummonModel.Instance;
		Vector vector = (instance3 != null) ? instance3.SummonGravityDir : null;
		CS$<>8__locals1.tsBaseVehicle = (owner as TsBaseVehicle);
		if (CS$<>8__locals1.tsBaseVehicle != null && CS$<>8__locals1.newLoc != null && CS$<>8__locals1.newRot != null && vector != null)
		{
			CS$<>8__locals1.entity = CS$<>8__locals1.tsBaseVehicle.VehicleActorComponent.Entity;
			VehicleMoveComponent component = CS$<>8__locals1.entity.GetComponent<VehicleMoveComponent>();
			if (component == null || !component.Valid)
			{
				Log instance4 = Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[TsAnimNotifySummonGongduolaSetLocAndRot] moveComp is invalid";
				string item = "EntityId";
				Entity entity = CS$<>8__locals1.entity;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
				instance4.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			CreatureController.Instance.SetEntityEnable(CS$<>8__locals1.entity, false, "GongduolaSummonController.AfterPlayCancelSummonAnim", false);
			GongduolaSummonController.Instance.StopCancelSummonAnim(CS$<>8__locals1.entity);
			if (!vector.IsZero())
			{
				VehicleGravityComponent component2 = CS$<>8__locals1.entity.GetComponent<VehicleGravityComponent>();
				if (component2 != null)
				{
					component2.SetGravityByPriority(0, vector, true, -1f, false);
				}
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				CS$<>8__locals1.tsBaseVehicle.VehicleActorComponent.SetActorLocationAndRotation(CS$<>8__locals1.newLoc.ToUeVector(false), CS$<>8__locals1.newRot.ToUeRotator(), "TsAnimNotifySummonGongduolaSetLocAndRot", false, null);
				CreatureController.Instance.SetEntityEnable(CS$<>8__locals1.tsBaseVehicle.VehicleActorComponent.Entity, true, "GongduolaSummonController.BeforePlaySummonAnim", false);
				GongduolaSummonModel.Instance.SummonLocation = null;
				GongduolaSummonModel.Instance.SummonRotation = null;
				GongduolaSummonController.Instance.PlaySummonAnim(CS$<>8__locals1.entity);
				Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[ChTest]TsAnimNotifySummonGongduolaSetLocAndRot", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, 500f, null, null, true, 1f);
		}
		return true;
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x000954EE File Offset: 0x000936EE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySummonGongduolaSetLocAndRot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonGongduolaSetLocAndRot.TsAnimNotifySummonGongduolaSetLocAndRot_C");
		}
		return TsAnimNotifySummonGongduolaSetLocAndRot._ClassPtr;
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x00095514 File Offset: 0x00093714
	public TsAnimNotifySummonGongduolaSetLocAndRot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x0009553C File Offset: 0x0009373C
	[NullableContext(1)]
	public TsAnimNotifySummonGongduolaSetLocAndRot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x0009556F File Offset: 0x0009376F
	protected TsAnimNotifySummonGongduolaSetLocAndRot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x00095578 File Offset: 0x00093778
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04001262 RID: 4706
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonGongduolaSetLocAndRot.TsAnimNotifySummonGongduolaSetLocAndRot_C";

	// Token: 0x04001263 RID: 4707
	private static IntPtr _ClassPtr;

	// Token: 0x04001264 RID: 4708
	private static IntPtr _ClassDefaultObjectPtr;
}
