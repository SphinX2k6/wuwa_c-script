using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000B3 RID: 179
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPortal.TsTaskPortal_C")]
public class TsTaskPortal : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00034171 File Offset: 0x00032371
	// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00034181 File Offset: 0x00032381
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Distance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_Distance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_Distance) = value;
		}
	}

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00034192 File Offset: 0x00032392
	// (set) Token: 0x06000A37 RID: 2615 RVA: 0x000341A2 File Offset: 0x000323A2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EffectDieTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_EffectDieTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_EffectDieTime) = value;
		}
	}

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000341B3 File Offset: 0x000323B3
	// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000341C3 File Offset: 0x000323C3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float EffectBornTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_EffectBornTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_EffectBornTime) = value;
		}
	}

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000341D4 File Offset: 0x000323D4
	// (set) Token: 0x06000A3B RID: 2619 RVA: 0x000341E4 File Offset: 0x000323E4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ActiveModel
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_ActiveModel) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_ActiveModel) = (value ? 1 : 0);
		}
	}

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000A3C RID: 2620 RVA: 0x000341F5 File Offset: 0x000323F5
	// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00034205 File Offset: 0x00032405
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float WaitTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_WaitTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPortal.__PropertyOffset_WaitTime) = value;
		}
	}

	// Token: 0x170001D7 RID: 471
	// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00034216 File Offset: 0x00032416
	// (set) Token: 0x06000A3F RID: 2623 RVA: 0x0003422A File Offset: 0x0003242A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UObject StartMaterialControllerData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + TsTaskPortal.__PropertyOffset_StartMaterialControllerData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTaskPortal.__PropertyOffset_StartMaterialControllerData, value);
		}
	}

	// Token: 0x170001D8 RID: 472
	// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0003423F File Offset: 0x0003243F
	// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00034253 File Offset: 0x00032453
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe UObject EndMaterialControllerData
	{
		get
		{
			return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + TsTaskPortal.__PropertyOffset_EndMaterialControllerData);
		}
		set
		{
			BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + TsTaskPortal.__PropertyOffset_EndMaterialControllerData, value);
		}
	}

	// Token: 0x170001D9 RID: 473
	// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00034268 File Offset: 0x00032468
	// (set) Token: 0x06000A43 RID: 2627 RVA: 0x0003427C File Offset: 0x0003247C
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string FollowPointName
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPortal.__PropertyOffset_FollowPointName)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPortal.__PropertyOffset_FollowPointName)), value);
		}
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00034294 File Offset: 0x00032494
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsEffectDieTime = this.EffectDieTime;
			this.TsEffectBornTime = this.EffectBornTime;
			this.TsActiveModel = this.ActiveModel;
			this.TsWaitTime = (double)this.WaitTime;
			this.TsStartMaterialControllerData = this.StartMaterialControllerData;
			this.TsEndMaterialControllerData = this.EndMaterialControllerData;
			this.TsFollowPointName = this.FollowPointName;
		}
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x0003430C File Offset: 0x0003250C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPortal) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPortal.StaticClass(), out intPtr, out num))
		{
			this.ReceiveExecuteAI_Implementation(ownerController, controlledPawn);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x000343BC File Offset: 0x000325BC
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		if (((tsAiController != null) ? tsAiController.AiController : null) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.TsActiveModel)
		{
			return;
		}
		base.FinishExecute(false);
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00034428 File Offset: 0x00032628
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPortal) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskPortal.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x000344E0 File Offset: 0x000326E0
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		this.FollowPoint = BlackboardController.Instance.GetVectorValueByEntity(aiController.CharAiDesignComp.Entity.Id, this.TsFollowPointName);
		FVectorDouble zeroVectorDouble = global::Vector.ZeroVectorDouble;
		if (this.FollowPoint != null)
		{
			zeroVectorDouble = new FVectorDouble((double)this.FollowPoint.X, (double)this.FollowPoint.Y, (double)this.FollowPoint.Z);
		}
		if (this.TsActiveModel)
		{
			if (this.TsWaitTime <= Time.Instance.WorldTime)
			{
				charActorComp.Actor.CharRenderingComponent.RemoveMaterialControllerData(this.EffectId);
				charActorComp.Actor.CharRenderingComponent.AddMaterialControllerData(this.TsStartMaterialControllerData);
				this.TsActiveModel = false;
				FVectorDouble fvectorDouble = UKismetMathLibrary.D_ProjectPointOnToPlane(charActorComp.ActorLocation, zeroVectorDouble, new FVectorDouble(0.0, 0.0, 1.0));
				FRotator rotation = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, zeroVectorDouble);
				charActorComp.SetActorLocationAndRotation(zeroVectorDouble, rotation, "行为树节点.传送", true, null);
				this.TsWaitTime = (double)this.TsEffectBornTime + Time.Instance.WorldTime;
				return;
			}
		}
		else if (this.TsWaitTime <= Time.Instance.WorldTime && zeroVectorDouble != global::Vector.ZeroVectorDouble)
		{
			this.TsActiveModel = true;
			this.EffectId = charActorComp.Actor.CharRenderingComponent.AddMaterialControllerData(this.TsEndMaterialControllerData);
			this.TsWaitTime = (double)this.TsEffectDieTime + Time.Instance.WorldTime;
		}
	}

	// Token: 0x06000A49 RID: 2633 RVA: 0x0003468A File Offset: 0x0003288A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPortal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPortal.TsTaskPortal_C");
		}
		return TsTaskPortal._ClassPtr;
	}

	// Token: 0x06000A4A RID: 2634 RVA: 0x000346B0 File Offset: 0x000328B0
	public TsTaskPortal() : this(BuiltinUtils.AllocNativeUObject(TsTaskPortal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A4B RID: 2635 RVA: 0x000346D8 File Offset: 0x000328D8
	[NullableContext(1)]
	public TsTaskPortal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A4C RID: 2636 RVA: 0x0003470B File Offset: 0x0003290B
	protected TsTaskPortal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A4D RID: 2637 RVA: 0x00034720 File Offset: 0x00032920
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000A4E RID: 2638 RVA: 0x00034750 File Offset: 0x00032950
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040007E4 RID: 2020
	private int EffectId;

	// Token: 0x040007E5 RID: 2021
	private Aki.Protocol.Vector FollowPoint;

	// Token: 0x040007E6 RID: 2022
	private bool IsInitTsVariables;

	// Token: 0x040007E7 RID: 2023
	private float TsEffectDieTime;

	// Token: 0x040007E8 RID: 2024
	private float TsEffectBornTime;

	// Token: 0x040007E9 RID: 2025
	private bool TsActiveModel;

	// Token: 0x040007EA RID: 2026
	private double TsWaitTime;

	// Token: 0x040007EB RID: 2027
	private UObject TsStartMaterialControllerData;

	// Token: 0x040007EC RID: 2028
	private UObject TsEndMaterialControllerData;

	// Token: 0x040007ED RID: 2029
	[Nullable(1)]
	private string TsFollowPointName = "";

	// Token: 0x040007EE RID: 2030
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPortal.TsTaskPortal_C";

	// Token: 0x040007EF RID: 2031
	private static IntPtr _ClassPtr;

	// Token: 0x040007F0 RID: 2032
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007F1 RID: 2033
	private static int __PropertyOffset_Distance;

	// Token: 0x040007F2 RID: 2034
	private static int __PropertyOffset_EffectDieTime;

	// Token: 0x040007F3 RID: 2035
	private static int __PropertyOffset_EffectBornTime;

	// Token: 0x040007F4 RID: 2036
	private static int __PropertyOffset_ActiveModel;

	// Token: 0x040007F5 RID: 2037
	private static int __PropertyOffset_WaitTime;

	// Token: 0x040007F6 RID: 2038
	private static int __PropertyOffset_StartMaterialControllerData;

	// Token: 0x040007F7 RID: 2039
	private static int __PropertyOffset_EndMaterialControllerData;

	// Token: 0x040007F8 RID: 2040
	private static int __PropertyOffset_FollowPointName;
}
