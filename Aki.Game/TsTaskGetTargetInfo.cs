using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000076 RID: 118
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskGetTargetInfo.TsTaskGetTargetInfo_C")]
public class TsTaskGetTargetInfo : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001AB75 File Offset: 0x00018D75
	// (set) Token: 0x06000575 RID: 1397 RVA: 0x0001AB89 File Offset: 0x00018D89
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGetTargetInfo.__PropertyOffset_TargetKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGetTargetInfo.__PropertyOffset_TargetKey)), value);
		}
	}

	// Token: 0x170000E3 RID: 227
	// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001AB9E File Offset: 0x00018D9E
	// (set) Token: 0x06000577 RID: 1399 RVA: 0x0001ABB2 File Offset: 0x00018DB2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string PositionKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGetTargetInfo.__PropertyOffset_PositionKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGetTargetInfo.__PropertyOffset_PositionKey)), value);
		}
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001ABC7 File Offset: 0x00018DC7
	// (set) Token: 0x06000579 RID: 1401 RVA: 0x0001ABDB File Offset: 0x00018DDB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string HpKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGetTargetInfo.__PropertyOffset_HpKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskGetTargetInfo.__PropertyOffset_HpKey)), value);
		}
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0001ABF0 File Offset: 0x00018DF0
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTargetKey = this.TargetKey;
			this.TsPositionKey = this.PositionKey;
			this.TsHpKey = this.HpKey;
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001AC2C File Offset: 0x00018E2C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskGetTargetInfo) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskGetTargetInfo.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600057C RID: 1404 RVA: 0x0001ACDC File Offset: 0x00018EDC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		if (!(ownerController is TsAiController))
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent characterActorComponent = ((TsAiController)ownerController).AiController.CharActorComp;
		if (!string.IsNullOrEmpty(this.TsTargetKey))
		{
			int valueOrDefault = BlackboardController.Instance.GetIntValueByWorld(this.TsTargetKey).GetValueOrDefault();
			if (valueOrDefault == 0)
			{
				base.FinishExecute(false);
				return;
			}
			characterActorComponent = EntitySystem.Instance.Get(valueOrDefault).GetComponent<CharacterActorComponent>();
		}
		if (characterActorComponent == null)
		{
			base.FinishExecute(false);
			return;
		}
		FVectorDouble actorLocation = characterActorComponent.ActorLocation;
		BlackboardController.Instance.SetVectorValueByGlobal(this.TsPositionKey, (float)actorLocation.X, (float)actorLocation.Y, (float)actorLocation.Z);
		BaseAttributeComponent component = characterActorComponent.Entity.GetComponent<BaseAttributeComponent>();
		if (component != null)
		{
			float currentValue = component.GetCurrentValue(EAttributeType.Life);
			BlackboardController.Instance.SetIntValueByWorld(this.TsHpKey, (int)currentValue);
		}
		base.FinishExecute(true);
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001ADBC File Offset: 0x00018FBC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGetTargetInfo._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskGetTargetInfo.TsTaskGetTargetInfo_C");
		}
		return TsTaskGetTargetInfo._ClassPtr;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0001ADE0 File Offset: 0x00018FE0
	public TsTaskGetTargetInfo() : this(BuiltinUtils.AllocNativeUObject(TsTaskGetTargetInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0001AE08 File Offset: 0x00019008
	public TsTaskGetTargetInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetTargetInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0001AE3B File Offset: 0x0001903B
	protected TsTaskGetTargetInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0001AE68 File Offset: 0x00019068
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040003EB RID: 1003
	private bool IsInitTsVariables;

	// Token: 0x040003EC RID: 1004
	private string TsTargetKey = "";

	// Token: 0x040003ED RID: 1005
	private string TsPositionKey = "";

	// Token: 0x040003EE RID: 1006
	private string TsHpKey = "";

	// Token: 0x040003EF RID: 1007
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskGetTargetInfo.TsTaskGetTargetInfo_C";

	// Token: 0x040003F0 RID: 1008
	private static IntPtr _ClassPtr;

	// Token: 0x040003F1 RID: 1009
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003F2 RID: 1010
	private static int __PropertyOffset_TargetKey;

	// Token: 0x040003F3 RID: 1011
	private static int __PropertyOffset_PositionKey;

	// Token: 0x040003F4 RID: 1012
	private static int __PropertyOffset_HpKey;
}
