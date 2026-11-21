using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A5 RID: 165
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskInteractTarget.TsTaskInteractTarget_C")]
public class TsTaskInteractTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000182 RID: 386
	// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0002DC15 File Offset: 0x0002BE15
	// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0002DC29 File Offset: 0x0002BE29
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskInteractTarget.__PropertyOffset_BlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskInteractTarget.__PropertyOffset_BlackboardKey)), value);
		}
	}

	// Token: 0x060008D8 RID: 2264 RVA: 0x0002DC3E File Offset: 0x0002BE3E
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsBlackboardKey = this.BlackboardKey;
		}
	}

	// Token: 0x060008D9 RID: 2265 RVA: 0x0002DC64 File Offset: 0x0002BE64
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskInteractTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskInteractTarget.StaticClass(), out intPtr, out num))
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

	// Token: 0x060008DA RID: 2266 RVA: 0x0002DD14 File Offset: 0x0002BF14
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
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		if (string.IsNullOrEmpty(this.TsBlackboardKey))
		{
			base.FinishExecute(false);
			return;
		}
		if (this.OnMontageEnded == null)
		{
			this.OnMontageEnded = delegate(UAnimMontage montage, bool interrupted)
			{
				this.EndTime = Time.Instance.WorldTime;
			};
		}
		this.EndTime = Time.Instance.WorldTime;
		int id = aiController.CharActorComp.Entity.Id;
		int? entityIdByEntity = BlackboardController.Instance.GetEntityIdByEntity(id, this.TsBlackboardKey);
		if (entityIdByEntity == null)
		{
			base.FinishExecute(false);
			return;
		}
		AActor dynamicEntity = WorldFunctionLibrary.GetDynamicEntity(entityIdByEntity.Value);
		if (dynamicEntity == null)
		{
			base.FinishExecute(false);
			return;
		}
		this.AnimComp = aiController.CharActorComp.Entity.GetComponent<CharacterAnimationComponent>();
		this.ExecuteInteractTarget(dynamicEntity, aiController.CharActorComp);
	}

	// Token: 0x060008DB RID: 2267 RVA: 0x0002DE28 File Offset: 0x0002C028
	private void ExecuteInteractTarget(AActor actor, CharacterActorComponent self)
	{
		EntityHandle entityByActor = ActorUtils.GetEntityByActor(actor, true);
		BaseActorComponent actorComponent = CharacterController.Instance.GetActorComponent(entityByActor);
		FVectorDouble location = actorComponent.ActorLocation;
		FRotator frotator = actorComponent.ActorRotation;
		InteractItemComponent component = entityByActor.Entity.GetComponent<InteractItemComponent>();
		if (component != null && component.IsInit)
		{
			FVectorDouble? interactPosition = component.GetInteractPosition();
			if (interactPosition != null)
			{
				location = interactPosition.Value;
			}
			FRotator? interactRotator = component.GetInteractRotator();
			if (interactRotator != null)
			{
				frotator = interactRotator.Value;
			}
			self.SetInputRotator(frotator);
			self.SetActorLocationAndRotation(location, frotator, "行为树节点.目标交互.强制切换目前", false, null);
		}
	}

	// Token: 0x060008DC RID: 2268 RVA: 0x0002DEC4 File Offset: 0x0002C0C4
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskInteractTarget) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskInteractTarget.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060008DD RID: 2269 RVA: 0x0002DF7C File Offset: 0x0002C17C
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.EndTime < Time.Instance.WorldTime)
		{
			base.Finish(true);
		}
	}

	// Token: 0x060008DE RID: 2270 RVA: 0x0002DF97 File Offset: 0x0002C197
	protected override void OnClear()
	{
		this.EndTime = 0.0;
		if (this.AnimComp != null)
		{
			this.AnimComp.MainAnimInstance.OnMontageEnded.Remove(this.OnMontageEnded);
			this.AnimComp = null;
		}
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x0002DFD2 File Offset: 0x0002C1D2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskInteractTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskInteractTarget.TsTaskInteractTarget_C");
		}
		return TsTaskInteractTarget._ClassPtr;
	}

	// Token: 0x060008E0 RID: 2272 RVA: 0x0002DFF8 File Offset: 0x0002C1F8
	public TsTaskInteractTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskInteractTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060008E1 RID: 2273 RVA: 0x0002E020 File Offset: 0x0002C220
	public TsTaskInteractTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskInteractTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060008E2 RID: 2274 RVA: 0x0002E053 File Offset: 0x0002C253
	protected TsTaskInteractTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060008E3 RID: 2275 RVA: 0x0002E068 File Offset: 0x0002C268
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060008E4 RID: 2276 RVA: 0x0002E098 File Offset: 0x0002C298
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040006C9 RID: 1737
	private bool IsInitTsVariables;

	// Token: 0x040006CA RID: 1738
	private string TsBlackboardKey = "";

	// Token: 0x040006CB RID: 1739
	private double EndTime;

	// Token: 0x040006CC RID: 1740
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x040006CD RID: 1741
	[Nullable(2)]
	private Action<UAnimMontage, bool> OnMontageEnded;

	// Token: 0x040006CE RID: 1742
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskInteractTarget.TsTaskInteractTarget_C";

	// Token: 0x040006CF RID: 1743
	private static IntPtr _ClassPtr;

	// Token: 0x040006D0 RID: 1744
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040006D1 RID: 1745
	private static int __PropertyOffset_BlackboardKey;
}
