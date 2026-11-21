using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.GongduolaSummon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001E0 RID: 480
[UClass("/Game/Aki/TypeScript/Game/AnimNotify/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonGongduolaSetLocAndRot.TsAnimNotifySummonGongduolaSetLocAndRot_C")]
public class TsAnimNotifySummonGongduolaSetLocAndRot : TsAnimNotifyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001E3D RID: 7741 RVA: 0x0009C248 File Offset: 0x0009A448
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool K2_Notify(USkeletalMeshComponent meshComp, UAnimSequenceBase animation)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsAnimNotifySummonGongduolaSetLocAndRot) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("K2_Notify"), TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), out intPtr, out num))
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

	// Token: 0x06001E3E RID: 7742 RVA: 0x0009C300 File Offset: 0x0009A500
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

	// Token: 0x06001E3F RID: 7743 RVA: 0x0009C47E File Offset: 0x0009A67E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsAnimNotifySummonGongduolaSetLocAndRot._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonGongduolaSetLocAndRot.TsAnimNotifySummonGongduolaSetLocAndRot_C");
		}
		return TsAnimNotifySummonGongduolaSetLocAndRot._ClassPtr;
	}

	// Token: 0x06001E40 RID: 7744 RVA: 0x0009C4A4 File Offset: 0x0009A6A4
	public TsAnimNotifySummonGongduolaSetLocAndRot() : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001E41 RID: 7745 RVA: 0x0009C4CC File Offset: 0x0009A6CC
	[NullableContext(1)]
	public TsAnimNotifySummonGongduolaSetLocAndRot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAnimNotifySummonGongduolaSetLocAndRot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001E42 RID: 7746 RVA: 0x0009C4FF File Offset: 0x0009A6FF
	protected TsAnimNotifySummonGongduolaSetLocAndRot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001E43 RID: 7747 RVA: 0x0009C508 File Offset: 0x0009A708
	protected unsafe virtual void __CPPCALL_K2_Notify_Implementation(UKuroAnimNotify.__K2_Notify_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->MeshComp);
		UAnimSequenceBase orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimSequenceBase>(__Params->Animation);
		__Params->__Result = this.K2_Notify_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040012A5 RID: 4773
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AnimNotify/TsAnimNotifySummonGongduolaSetLocAndRot.TsAnimNotifySummonGongduolaSetLocAndRot_C";

	// Token: 0x040012A6 RID: 4774
	private static IntPtr _ClassPtr;

	// Token: 0x040012A7 RID: 4775
	private static IntPtr _ClassDefaultObjectPtr;
}
