using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BB RID: 187
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetCoolDown.TsTaskSetCoolDown_C")]
public class TsTaskSetCoolDown : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x00036C1B File Offset: 0x00034E1B
	// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x00036C2B File Offset: 0x00034E2B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int Id
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_Id);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_Id) = value;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00036C3C File Offset: 0x00034E3C
	// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00036C4C File Offset: 0x00034E4C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CoolDownTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_CoolDownTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetCoolDown.__PropertyOffset_CoolDownTime) = value;
		}
	}

	// Token: 0x06000AD7 RID: 2775 RVA: 0x00036C5D File Offset: 0x00034E5D
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsId = this.Id;
			this.TsCoolDownTime = this.CoolDownTime * (float)TimeUtil.Instance.InverseMillisecond;
		}
	}

	// Token: 0x06000AD8 RID: 2776 RVA: 0x00036C9C File Offset: 0x00034E9C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskSetCoolDown) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskSetCoolDown.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000AD9 RID: 2777 RVA: 0x00036D4C File Offset: 0x00034F4C
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ((ownerController != null) ? ownerController.GetClass().GetName() : null) ?? "undefined");
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		double num = GameModeModel.Instance.IsMulti ? TimeUtil.Instance.GetServerTimeStamp() : Time.Instance.WorldTime;
		aiController.SetCoolDownTime(this.TsId, num + (double)this.TsCoolDownTime, true, "行为树Task");
		base.FinishExecute(true);
	}

	// Token: 0x06000ADA RID: 2778 RVA: 0x00036E05 File Offset: 0x00035005
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetCoolDown._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetCoolDown.TsTaskSetCoolDown_C");
		}
		return TsTaskSetCoolDown._ClassPtr;
	}

	// Token: 0x06000ADB RID: 2779 RVA: 0x00036E2C File Offset: 0x0003502C
	public TsTaskSetCoolDown() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetCoolDown.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000ADC RID: 2780 RVA: 0x00036E54 File Offset: 0x00035054
	[NullableContext(1)]
	public TsTaskSetCoolDown(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetCoolDown.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000ADD RID: 2781 RVA: 0x00036E87 File Offset: 0x00035087
	protected TsTaskSetCoolDown(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000ADE RID: 2782 RVA: 0x00036E90 File Offset: 0x00035090
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000875 RID: 2165
	private bool IsInitTsVariables;

	// Token: 0x04000876 RID: 2166
	private int TsId;

	// Token: 0x04000877 RID: 2167
	private float TsCoolDownTime;

	// Token: 0x04000878 RID: 2168
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetCoolDown.TsTaskSetCoolDown_C";

	// Token: 0x04000879 RID: 2169
	private static IntPtr _ClassPtr;

	// Token: 0x0400087A RID: 2170
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400087B RID: 2171
	private static int __PropertyOffset_Id;

	// Token: 0x0400087C RID: 2172
	private static int __PropertyOffset_CoolDownTime;
}
