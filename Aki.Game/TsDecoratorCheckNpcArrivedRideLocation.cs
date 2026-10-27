using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000019 RID: 25
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckNpcArrivedRideLocation.TsDecoratorCheckNpcArrivedRideLocation_C")]
public class TsDecoratorCheckNpcArrivedRideLocation : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x0600007B RID: 123 RVA: 0x00003AF3 File Offset: 0x00001CF3
	// (set) Token: 0x0600007C RID: 124 RVA: 0x00003B03 File Offset: 0x00001D03
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Tolerance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorCheckNpcArrivedRideLocation.__PropertyOffset_Tolerance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorCheckNpcArrivedRideLocation.__PropertyOffset_Tolerance) = value;
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00003B14 File Offset: 0x00001D14
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTolerance = this.Tolerance;
		}
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00003B38 File Offset: 0x00001D38
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("PerformConditionCheckAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00003BD8 File Offset: 0x00001DD8
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		AiController aiController = (ownerController as TsAiController).AiController;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			return false;
		}
		this.InitTsVariables();
		int id = charActorComp.Entity.Id;
		int? ridingVehicle = NpcVehicleRiderController.Instance.GetRidingVehicle(id);
		return ridingVehicle != null && NpcVehicleRiderController.Instance.IsNpcAtVehicleRideLocation(id, ridingVehicle.Value, this.TsTolerance);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00003C78 File Offset: 0x00001E78
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorCheckNpcArrivedRideLocation._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckNpcArrivedRideLocation.TsDecoratorCheckNpcArrivedRideLocation_C");
		}
		return TsDecoratorCheckNpcArrivedRideLocation._ClassPtr;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00003C9C File Offset: 0x00001E9C
	public TsDecoratorCheckNpcArrivedRideLocation() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedRideLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00003CC4 File Offset: 0x00001EC4
	[NullableContext(1)]
	public TsDecoratorCheckNpcArrivedRideLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorCheckNpcArrivedRideLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00003CF7 File Offset: 0x00001EF7
	protected TsDecoratorCheckNpcArrivedRideLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00003D00 File Offset: 0x00001F00
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000047 RID: 71
	private bool IsInitTsVariables;

	// Token: 0x04000048 RID: 72
	private float TsTolerance;

	// Token: 0x04000049 RID: 73
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorCheckNpcArrivedRideLocation.TsDecoratorCheckNpcArrivedRideLocation_C";

	// Token: 0x0400004A RID: 74
	private static IntPtr _ClassPtr;

	// Token: 0x0400004B RID: 75
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400004C RID: 76
	private static int __PropertyOffset_Tolerance;
}
