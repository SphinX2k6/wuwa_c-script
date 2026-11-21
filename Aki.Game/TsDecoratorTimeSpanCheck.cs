using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000027 RID: 39
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorTimeSpanCheck.TsDecoratorTimeSpanCheck_C")]
public class TsDecoratorTimeSpanCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600010D RID: 269 RVA: 0x00005E8F File Offset: 0x0000408F
	// (set) Token: 0x0600010E RID: 270 RVA: 0x00005EA3 File Offset: 0x000040A3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> CheckType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorTimeSpanCheck.__PropertyOffset_CheckType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorTimeSpanCheck.__PropertyOffset_CheckType) = value;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600010F RID: 271 RVA: 0x00005EB8 File Offset: 0x000040B8
	// (set) Token: 0x06000110 RID: 272 RVA: 0x00005ECC File Offset: 0x000040CC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FTimecode StartTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorTimeSpanCheck.__PropertyOffset_StartTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorTimeSpanCheck.__PropertyOffset_StartTime) = value;
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000111 RID: 273 RVA: 0x00005EE1 File Offset: 0x000040E1
	// (set) Token: 0x06000112 RID: 274 RVA: 0x00005EF5 File Offset: 0x000040F5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FTimecode EndTime
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorTimeSpanCheck.__PropertyOffset_EndTime);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorTimeSpanCheck.__PropertyOffset_EndTime) = value;
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x00005F0C File Offset: 0x0000410C
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckType = this.CheckType;
			this.TsStartTime = this.StartTime;
			this.TsEndTime = this.EndTime;
		}
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00005F58 File Offset: 0x00004158
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsDecoratorTimeSpanCheck) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("PerformConditionCheckAI"), TsDecoratorTimeSpanCheck.StaticClass(), out intPtr, out num))
		{
			return this.PerformConditionCheckAI_Implementation(ownerController, controlledPawn);
		}
		UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* ptr = stackalloc UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00006010 File Offset: 0x00004210
	[NullableContext(2)]
	protected virtual bool PerformConditionCheckAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		if ((ownerController as TsAiController).AiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		this.InitTsVariables();
		int startMinute = this.TsStartTime.Hours * 60 + this.TsStartTime.Minutes;
		int endMinute = this.TsEndTime.Hours * 60 + this.TsEndTime.Minutes;
		bool flag = TimeOfDayController.Instance.CheckInMinuteSpan(startMinute, endMinute);
		EArithmeticKeyOperation tsCheckType = this.TsCheckType;
		if (tsCheckType != EArithmeticKeyOperation.Equal)
		{
			return tsCheckType == EArithmeticKeyOperation.NotEqual && !flag;
		}
		return flag;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x000060C4 File Offset: 0x000042C4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorTimeSpanCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorTimeSpanCheck.TsDecoratorTimeSpanCheck_C");
		}
		return TsDecoratorTimeSpanCheck._ClassPtr;
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000060E8 File Offset: 0x000042E8
	public TsDecoratorTimeSpanCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTimeSpanCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00006110 File Offset: 0x00004310
	[NullableContext(1)]
	public TsDecoratorTimeSpanCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorTimeSpanCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00006143 File Offset: 0x00004343
	protected TsDecoratorTimeSpanCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x0000614C File Offset: 0x0000434C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040000A6 RID: 166
	private bool IsInitTsVariables;

	// Token: 0x040000A7 RID: 167
	private EArithmeticKeyOperation TsCheckType;

	// Token: 0x040000A8 RID: 168
	private FTimecode TsStartTime;

	// Token: 0x040000A9 RID: 169
	private FTimecode TsEndTime;

	// Token: 0x040000AA RID: 170
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorTimeSpanCheck.TsDecoratorTimeSpanCheck_C";

	// Token: 0x040000AB RID: 171
	private static IntPtr _ClassPtr;

	// Token: 0x040000AC RID: 172
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040000AD RID: 173
	private static int __PropertyOffset_CheckType;

	// Token: 0x040000AE RID: 174
	private static int __PropertyOffset_StartTime;

	// Token: 0x040000AF RID: 175
	private static int __PropertyOffset_EndTime;
}
