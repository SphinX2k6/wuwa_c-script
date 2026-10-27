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
	// Token: 0x170001CF RID: 463
	// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0003300D File Offset: 0x0003120D
	// (set) Token: 0x06000A2F RID: 2607 RVA: 0x0003301D File Offset: 0x0003121D
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

	// Token: 0x170001D0 RID: 464
	// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0003302E File Offset: 0x0003122E
	// (set) Token: 0x06000A31 RID: 2609 RVA: 0x0003303E File Offset: 0x0003123E
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

	// Token: 0x170001D1 RID: 465
	// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0003304F File Offset: 0x0003124F
	// (set) Token: 0x06000A33 RID: 2611 RVA: 0x0003305F File Offset: 0x0003125F
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

	// Token: 0x170001D2 RID: 466
	// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00033070 File Offset: 0x00031270
	// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00033080 File Offset: 0x00031280
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

	// Token: 0x170001D3 RID: 467
	// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00033091 File Offset: 0x00031291
	// (set) Token: 0x06000A37 RID: 2615 RVA: 0x000330A1 File Offset: 0x000312A1
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

	// Token: 0x170001D4 RID: 468
	// (get) Token: 0x06000A38 RID: 2616 RVA: 0x000330B2 File Offset: 0x000312B2
	// (set) Token: 0x06000A39 RID: 2617 RVA: 0x000330C6 File Offset: 0x000312C6
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

	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06000A3A RID: 2618 RVA: 0x000330DB File Offset: 0x000312DB
	// (set) Token: 0x06000A3B RID: 2619 RVA: 0x000330EF File Offset: 0x000312EF
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

	// Token: 0x170001D6 RID: 470
	// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00033104 File Offset: 0x00031304
	// (set) Token: 0x06000A3D RID: 2621 RVA: 0x00033118 File Offset: 0x00031318
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

	// Token: 0x06000A3E RID: 2622 RVA: 0x00033130 File Offset: 0x00031330
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

	// Token: 0x06000A3F RID: 2623 RVA: 0x000331A8 File Offset: 0x000313A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveExecuteAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00033244 File Offset: 0x00031444
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

	// Token: 0x06000A41 RID: 2625 RVA: 0x000332B0 File Offset: 0x000314B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00033350 File Offset: 0x00031550
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

	// Token: 0x06000A43 RID: 2627 RVA: 0x000334FA File Offset: 0x000316FA
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPortal._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPortal.TsTaskPortal_C");
		}
		return TsTaskPortal._ClassPtr;
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00033520 File Offset: 0x00031720
	public TsTaskPortal() : this(BuiltinUtils.AllocNativeUObject(TsTaskPortal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00033548 File Offset: 0x00031748
	[NullableContext(1)]
	public TsTaskPortal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x0003357B File Offset: 0x0003177B
	protected TsTaskPortal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00033590 File Offset: 0x00031790
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x000335C0 File Offset: 0x000317C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040007DC RID: 2012
	private int EffectId;

	// Token: 0x040007DD RID: 2013
	private Aki.Protocol.Vector FollowPoint;

	// Token: 0x040007DE RID: 2014
	private bool IsInitTsVariables;

	// Token: 0x040007DF RID: 2015
	private float TsEffectDieTime;

	// Token: 0x040007E0 RID: 2016
	private float TsEffectBornTime;

	// Token: 0x040007E1 RID: 2017
	private bool TsActiveModel;

	// Token: 0x040007E2 RID: 2018
	private double TsWaitTime;

	// Token: 0x040007E3 RID: 2019
	private UObject TsStartMaterialControllerData;

	// Token: 0x040007E4 RID: 2020
	private UObject TsEndMaterialControllerData;

	// Token: 0x040007E5 RID: 2021
	[Nullable(1)]
	private string TsFollowPointName = "";

	// Token: 0x040007E6 RID: 2022
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPortal.TsTaskPortal_C";

	// Token: 0x040007E7 RID: 2023
	private static IntPtr _ClassPtr;

	// Token: 0x040007E8 RID: 2024
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040007E9 RID: 2025
	private static int __PropertyOffset_Distance;

	// Token: 0x040007EA RID: 2026
	private static int __PropertyOffset_EffectDieTime;

	// Token: 0x040007EB RID: 2027
	private static int __PropertyOffset_EffectBornTime;

	// Token: 0x040007EC RID: 2028
	private static int __PropertyOffset_ActiveModel;

	// Token: 0x040007ED RID: 2029
	private static int __PropertyOffset_WaitTime;

	// Token: 0x040007EE RID: 2030
	private static int __PropertyOffset_StartMaterialControllerData;

	// Token: 0x040007EF RID: 2031
	private static int __PropertyOffset_EndMaterialControllerData;

	// Token: 0x040007F0 RID: 2032
	private static int __PropertyOffset_FollowPointName;
}
