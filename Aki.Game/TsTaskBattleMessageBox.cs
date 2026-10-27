using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000089 RID: 137
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBattleMessageBox.TsTaskBattleMessageBox_C")]
public class TsTaskBattleMessageBox : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000112 RID: 274
	// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00021819 File Offset: 0x0001FA19
	// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00021829 File Offset: 0x0001FA29
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int BoardId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskBattleMessageBox.__PropertyOffset_BoardId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskBattleMessageBox.__PropertyOffset_BoardId) = value;
		}
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x0002183C File Offset: 0x0001FA3C
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

	// Token: 0x060006C5 RID: 1733 RVA: 0x000218D8 File Offset: 0x0001FAD8
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
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
		if (this.BoardId > 0)
		{
			SoundAreaPlayTipsController.Instance.OpenSoundAreaPlayTips(this.BoardId);
		}
		base.FinishExecute(true);
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x0002194E File Offset: 0x0001FB4E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBattleMessageBox._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBattleMessageBox.TsTaskBattleMessageBox_C");
		}
		return TsTaskBattleMessageBox._ClassPtr;
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00021974 File Offset: 0x0001FB74
	public TsTaskBattleMessageBox() : this(BuiltinUtils.AllocNativeUObject(TsTaskBattleMessageBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x0002199C File Offset: 0x0001FB9C
	[NullableContext(1)]
	public TsTaskBattleMessageBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBattleMessageBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x000219CF File Offset: 0x0001FBCF
	protected TsTaskBattleMessageBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x000219D8 File Offset: 0x0001FBD8
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004E9 RID: 1257
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBattleMessageBox.TsTaskBattleMessageBox_C";

	// Token: 0x040004EA RID: 1258
	private static IntPtr _ClassPtr;

	// Token: 0x040004EB RID: 1259
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004EC RID: 1260
	private static int __PropertyOffset_BoardId;
}
