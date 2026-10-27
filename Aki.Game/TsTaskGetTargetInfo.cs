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
	// Token: 0x170000E0 RID: 224
	// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001A099 File Offset: 0x00018299
	// (set) Token: 0x06000571 RID: 1393 RVA: 0x0001A0AD File Offset: 0x000182AD
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

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001A0C2 File Offset: 0x000182C2
	// (set) Token: 0x06000573 RID: 1395 RVA: 0x0001A0D6 File Offset: 0x000182D6
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

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001A0EB File Offset: 0x000182EB
	// (set) Token: 0x06000575 RID: 1397 RVA: 0x0001A0FF File Offset: 0x000182FF
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

	// Token: 0x06000576 RID: 1398 RVA: 0x0001A114 File Offset: 0x00018314
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

	// Token: 0x06000577 RID: 1399 RVA: 0x0001A150 File Offset: 0x00018350
	[NullableContext(2)]
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

	// Token: 0x06000578 RID: 1400 RVA: 0x0001A1EC File Offset: 0x000183EC
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

	// Token: 0x06000579 RID: 1401 RVA: 0x0001A2CC File Offset: 0x000184CC
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskGetTargetInfo._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskGetTargetInfo.TsTaskGetTargetInfo_C");
		}
		return TsTaskGetTargetInfo._ClassPtr;
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0001A2F0 File Offset: 0x000184F0
	public TsTaskGetTargetInfo() : this(BuiltinUtils.AllocNativeUObject(TsTaskGetTargetInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0001A318 File Offset: 0x00018518
	public TsTaskGetTargetInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskGetTargetInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0001A34B File Offset: 0x0001854B
	protected TsTaskGetTargetInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0001A378 File Offset: 0x00018578
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040003E7 RID: 999
	private bool IsInitTsVariables;

	// Token: 0x040003E8 RID: 1000
	private string TsTargetKey = "";

	// Token: 0x040003E9 RID: 1001
	private string TsPositionKey = "";

	// Token: 0x040003EA RID: 1002
	private string TsHpKey = "";

	// Token: 0x040003EB RID: 1003
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/NPC/TsTaskGetTargetInfo.TsTaskGetTargetInfo_C";

	// Token: 0x040003EC RID: 1004
	private static IntPtr _ClassPtr;

	// Token: 0x040003ED RID: 1005
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040003EE RID: 1006
	private static int __PropertyOffset_TargetKey;

	// Token: 0x040003EF RID: 1007
	private static int __PropertyOffset_PositionKey;

	// Token: 0x040003F0 RID: 1008
	private static int __PropertyOffset_HpKey;
}
