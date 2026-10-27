using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000023 RID: 35
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorEntityStateCheck.TsDecoratorEntityStateCheck_C")]
public class TsDecoratorEntityStateCheck : UBTDecorator_BlueprintBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005153 File Offset: 0x00003353
	// (set) Token: 0x060000D7 RID: 215 RVA: 0x00005167 File Offset: 0x00003367
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe TEnumAsByte<EArithmeticKeyOperation> CheckType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorEntityStateCheck.__PropertyOffset_CheckType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorEntityStateCheck.__PropertyOffset_CheckType) = value;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000517C File Offset: 0x0000337C
	// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000518C File Offset: 0x0000338C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int StatusEntityId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsDecoratorEntityStateCheck.__PropertyOffset_StatusEntityId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsDecoratorEntityStateCheck.__PropertyOffset_StatusEntityId) = value;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000DA RID: 218 RVA: 0x0000519D File Offset: 0x0000339D
	// (set) Token: 0x060000DB RID: 219 RVA: 0x000051B1 File Offset: 0x000033B1
	[Nullable(1)]
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string State
	{
		[NullableContext(1)]
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorEntityStateCheck.__PropertyOffset_State)));
		}
		[NullableContext(1)]
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsDecoratorEntityStateCheck.__PropertyOffset_State)), value);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x000051C8 File Offset: 0x000033C8
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckType = this.CheckType;
			this.TsStatusEntityId = this.StatusEntityId;
			this.TsState = this.State;
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00005214 File Offset: 0x00003414
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

	// Token: 0x060000DE RID: 222 RVA: 0x000052B4 File Offset: 0x000034B4
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
		if (this.TsStatusEntityId == 0 || this.TsState == "")
		{
			return false;
		}
		EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.TsStatusEntityId);
		if (entityByPbDataId == null || !entityByPbDataId.Valid)
		{
			return false;
		}
		LevelTagComponent component = entityByPbDataId.Entity.GetComponent<LevelTagComponent>();
		if (!component)
		{
			return false;
		}
		bool flag = component.ContainsTagByName(this.TsState);
		EArithmeticKeyOperation tsCheckType = this.TsCheckType;
		if (tsCheckType != EArithmeticKeyOperation.Equal)
		{
			return tsCheckType == EArithmeticKeyOperation.NotEqual && !flag;
		}
		return flag;
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00005388 File Offset: 0x00003588
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsDecoratorEntityStateCheck._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorEntityStateCheck.TsDecoratorEntityStateCheck_C");
		}
		return TsDecoratorEntityStateCheck._ClassPtr;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x000053AC File Offset: 0x000035AC
	public TsDecoratorEntityStateCheck() : this(BuiltinUtils.AllocNativeUObject(TsDecoratorEntityStateCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000053D4 File Offset: 0x000035D4
	[NullableContext(1)]
	public TsDecoratorEntityStateCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDecoratorEntityStateCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00005407 File Offset: 0x00003607
	protected TsDecoratorEntityStateCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000541C File Offset: 0x0000361C
	protected unsafe virtual void __CPPCALL_PerformConditionCheckAI_Implementation(UBTDecorator_BlueprintBase.__PerformConditionCheckAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		__Params->__Result = this.PerformConditionCheckAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400007C RID: 124
	private bool IsInitTsVariables;

	// Token: 0x0400007D RID: 125
	private EArithmeticKeyOperation TsCheckType;

	// Token: 0x0400007E RID: 126
	private int TsStatusEntityId;

	// Token: 0x0400007F RID: 127
	[Nullable(1)]
	private string TsState = "";

	// Token: 0x04000080 RID: 128
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Decorator/Npc/LevelAiDecorator/TsDecoratorEntityStateCheck.TsDecoratorEntityStateCheck_C";

	// Token: 0x04000081 RID: 129
	private static IntPtr _ClassPtr;

	// Token: 0x04000082 RID: 130
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000083 RID: 131
	private static int __PropertyOffset_CheckType;

	// Token: 0x04000084 RID: 132
	private static int __PropertyOffset_StatusEntityId;

	// Token: 0x04000085 RID: 133
	private static int __PropertyOffset_State;
}
