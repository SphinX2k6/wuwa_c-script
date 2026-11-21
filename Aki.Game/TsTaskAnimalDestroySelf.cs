using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000058 RID: 88
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalDestroySelf.TsTaskAnimalDestroySelf_C")]
public class TsTaskAnimalDestroySelf : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x0600035B RID: 859 RVA: 0x00010188 File Offset: 0x0000E388
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAnimalDestroySelf) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAnimalDestroySelf.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600035C RID: 860 RVA: 0x00010238 File Offset: 0x0000E438
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.CJH;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		Entity entity = aiController.CharActorComp.Entity;
		CharacterAiComponent component = entity.GetComponent<CharacterAiComponent>();
		if (component != null)
		{
			component.DisableAi("动物销毁");
		}
		AnimalPerformComponent component2 = entity.GetComponent<AnimalPerformComponent>();
		if (component2 != null)
		{
			component2.PendingDestroy = false;
		}
		CreatureDataComponent component3 = entity.GetComponent<CreatureDataComponent>();
		CreatureController.Instance.AnimalDestroyRequest(component3.GetCreatureDataId());
		base.FinishExecute(true);
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000102E6 File Offset: 0x0000E4E6
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAnimalDestroySelf._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalDestroySelf.TsTaskAnimalDestroySelf_C");
		}
		return TsTaskAnimalDestroySelf._ClassPtr;
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0001030C File Offset: 0x0000E50C
	public TsTaskAnimalDestroySelf() : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDestroySelf.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00010334 File Offset: 0x0000E534
	[NullableContext(1)]
	public TsTaskAnimalDestroySelf(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAnimalDestroySelf.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00010367 File Offset: 0x0000E567
	protected TsTaskAnimalDestroySelf(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00010370 File Offset: 0x0000E570
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000235 RID: 565
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/Animal/TsTaskAnimalDestroySelf.TsTaskAnimalDestroySelf_C";

	// Token: 0x04000236 RID: 566
	private static IntPtr _ClassPtr;

	// Token: 0x04000237 RID: 567
	private static IntPtr _ClassDefaultObjectPtr;
}
