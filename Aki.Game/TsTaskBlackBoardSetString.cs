using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200008C RID: 140
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetString.TsTaskBlackBoardSetString_C")]
public class TsTaskBlackBoardSetString : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000709 RID: 1801 RVA: 0x0002425B File Offset: 0x0002245B
	// (set) Token: 0x0600070A RID: 1802 RVA: 0x0002426F File Offset: 0x0002246F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StringName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringName)), value);
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x0600070B RID: 1803 RVA: 0x00024284 File Offset: 0x00022484
	// (set) Token: 0x0600070C RID: 1804 RVA: 0x00024298 File Offset: 0x00022498
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StringValue
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringValue)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskBlackBoardSetString.__PropertyOffset_StringValue)), value);
		}
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x000242B0 File Offset: 0x000224B0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBlackBoardSetString) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskBlackBoardSetString.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00024309 File Offset: 0x00022509
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsStringName = this.StringName;
			this.TsStringValue = this.StringValue;
		}
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x0002433C File Offset: 0x0002253C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskBlackBoardSetString) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskBlackBoardSetString.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000710 RID: 1808 RVA: 0x000243EC File Offset: 0x000225EC
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		int id = aiController.CharActorComp.Entity.Id;
		BlackboardController.Instance.SetStringValueByEntity(id, this.TsStringName, this.TsStringValue);
		base.FinishExecute(true);
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x0002447F File Offset: 0x0002267F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskBlackBoardSetString._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetString.TsTaskBlackBoardSetString_C");
		}
		return TsTaskBlackBoardSetString._ClassPtr;
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x000244A4 File Offset: 0x000226A4
	public TsTaskBlackBoardSetString() : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x000244CC File Offset: 0x000226CC
	public TsTaskBlackBoardSetString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskBlackBoardSetString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x000244FF File Offset: 0x000226FF
	protected TsTaskBlackBoardSetString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x0002451E File Offset: 0x0002271E
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00024528 File Offset: 0x00022728
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400052C RID: 1324
	private bool IsInitTsVariables;

	// Token: 0x0400052D RID: 1325
	private string TsStringName = "";

	// Token: 0x0400052E RID: 1326
	private string TsStringValue = "";

	// Token: 0x0400052F RID: 1327
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskBlackBoardSetString.TsTaskBlackBoardSetString_C";

	// Token: 0x04000530 RID: 1328
	private static IntPtr _ClassPtr;

	// Token: 0x04000531 RID: 1329
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000532 RID: 1330
	private static int __PropertyOffset_StringName;

	// Token: 0x04000533 RID: 1331
	private static int __PropertyOffset_StringValue;
}
