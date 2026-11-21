using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.World.Controller;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000AD RID: 173
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayAction.TsTaskPlayAction_C")]
public class TsTaskPlayAction : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x060009A7 RID: 2471 RVA: 0x00031C99 File Offset: 0x0002FE99
	// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00031CAD File Offset: 0x0002FEAD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string MontageName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayAction.__PropertyOffset_MontageName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayAction.__PropertyOffset_MontageName)), value);
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00031CC2 File Offset: 0x0002FEC2
	// (set) Token: 0x060009AA RID: 2474 RVA: 0x00031CD2 File Offset: 0x0002FED2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int LoopTimeMillisecond
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayAction.__PropertyOffset_LoopTimeMillisecond);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayAction.__PropertyOffset_LoopTimeMillisecond) = value;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060009AB RID: 2475 RVA: 0x00031CE3 File Offset: 0x0002FEE3
	// (set) Token: 0x060009AC RID: 2476 RVA: 0x00031CF7 File Offset: 0x0002FEF7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BlackboardKeyTime
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayAction.__PropertyOffset_BlackboardKeyTime)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayAction.__PropertyOffset_BlackboardKeyTime)), value);
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x060009AD RID: 2477 RVA: 0x00031D0C File Offset: 0x0002FF0C
	// (set) Token: 0x060009AE RID: 2478 RVA: 0x00031D1C File Offset: 0x0002FF1C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool MaskInteract
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayAction.__PropertyOffset_MaskInteract) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayAction.__PropertyOffset_MaskInteract) = (value ? 1 : 0);
		}
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x00031D30 File Offset: 0x0002FF30
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMontageName = this.MontageName;
			this.TsLoopTimeMillisecond = this.LoopTimeMillisecond;
			this.TsBlackboardKeyTime = this.BlackboardKeyTime;
			this.TsMaskInteract = this.MaskInteract;
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00031D84 File Offset: 0x0002FF84
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPlayAction) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPlayAction.StaticClass(), out intPtr, out num))
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

	// Token: 0x060009B1 RID: 2481 RVA: 0x00031E34 File Offset: 0x00030034
	[NullableContext(2)]
	protected unsafe virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		bool log = ServerGmController.Instance.AnimalDebug;
		if (log)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "AnimalDebug PlayAction";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Tree", base.TreeAsset);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("aiController", aiController != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("aiComp", ((aiController != null) ? aiController.CharAiDesignComp : null) != null);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item = "SelfId";
			int? num;
			if (aiController == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent charActorComp = aiController.CharActorComp;
				num = ((charActorComp != null) ? new int?(charActorComp.Entity.Id) : null);
			}
			ptr = new ValueTuple<string, object>(item, num);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		if (aiController == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
		Entity entity = aiController.CharActorComp.Entity;
		int time = this.TsLoopTimeMillisecond;
		if (!string.IsNullOrEmpty(this.TsBlackboardKeyTime))
		{
			int valueOrDefault = BlackboardController.Instance.GetIntValueByEntity(entity.Id, this.TsBlackboardKeyTime).GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				time = valueOrDefault;
			}
		}
		string text = this.TsMontageName;
		string stringValueByEntity = BlackboardController.Instance.GetStringValueByEntity(entity.Id, "TargetMontageName");
		if (!string.IsNullOrEmpty(stringValueByEntity))
		{
			text = stringValueByEntity;
			BlackboardController.Instance.RemoveValueByEntity(entity.Id, "TargetMontageName");
		}
		if (log)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.AI;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "AnimalDebug PlayAction2";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("TsLoopTimeMillisecond", this.TsLoopTimeMillisecond);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("time", time);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("TsMontageName", this.TsMontageName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("spMontageName", stringValueByEntity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("montageName", text);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 5));
		}
		this.InteractComponent = entity.GetComponent<PawnInteractNewComponent>();
		if (this.TsMaskInteract && this.InteractComponent != null)
		{
			this.InteractComponent.SetInteractionState(false, "TsTaskPlayAction ReceiveExecuteAI");
		}
		this.EndTime = (double)time + Time.Instance.WorldTime;
		this.AnimComp = entity.GetComponent<CharacterAnimationComponent>();
		if (this.AnimComp != null)
		{
			string montageResPathByName = this.AnimComp.GetMontageResPathByName(text);
			if (log)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.AI;
				ELogAuthor author4 = ELogAuthor.LCZ;
				string message4 = "AnimalDebug PlayAction3";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("montageResPath", montageResPathByName);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			}
			if (montageResPathByName != null && montageResPathByName.Contains("/"))
			{
				ResourceSystem.Instance.LoadAsync<UAnimMontage>(montageResPathByName, delegate([Nullable(2)] UAnimMontage montageAsset, string _)
				{
					if (log)
					{
						Log instance5 = Log.Instance;
						ELogModule module5 = ELogModule.AI;
						ELogAuthor author5 = ELogAuthor.LCZ;
						string message5 = "AnimalDebug PlayAction4";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("montageAsset", montageAsset);
						ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1);
						string item2 = "MainAnimInstance";
						CharacterAnimationComponent animComp = this.AnimComp;
						ptr2 = new ValueTuple<string, object>(item2, (animComp != null) ? animComp.MainAnimInstance : null);
						instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
					}
					if (ObjectUtils.IsValid(montageAsset))
					{
						CharacterAnimationComponent animComp2 = this.AnimComp;
						if (((animComp2 != null) ? animComp2.MainAnimInstance : null) != null)
						{
							if (time == 0)
							{
								this.EndTime = 60000.0 + Time.Instance.WorldTime;
								if (this.OnMontageEnded != null)
								{
									this.AnimComp.MainAnimInstance.OnMontageEnded.Add(this.OnMontageEnded);
								}
							}
							this.AnimComp.MainAnimInstance.Montage_Play(montageAsset, 1f, EMontagePlayReturnType.MontageLength, 0f, true);
						}
					}
				}, 100, "js_undefined");
			}
		}
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x000321D0 File Offset: 0x000303D0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPlayAction) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskPlayAction.StaticClass(), out intPtr, out num))
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

	// Token: 0x060009B3 RID: 2483 RVA: 0x00032288 File Offset: 0x00030488
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		if (this.EndTime < Time.Instance.WorldTime)
		{
			if (this.TsMaskInteract && this.InteractComponent != null)
			{
				this.InteractComponent.SetInteractionState(true, "TsTaskPlayAction ReceiveTickAI");
			}
			base.Finish(true);
		}
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x000322C4 File Offset: 0x000304C4
	protected override void OnClear()
	{
		this.EndTime = 0.0;
		if (this.AnimComp != null)
		{
			if (this.AnimComp.MainAnimInstance != null && this.OnMontageEnded != null)
			{
				this.AnimComp.MainAnimInstance.OnMontageEnded.Remove(this.OnMontageEnded);
			}
			this.AnimComp = null;
		}
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x0003231F File Offset: 0x0003051F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayAction._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayAction.TsTaskPlayAction_C");
		}
		return TsTaskPlayAction._ClassPtr;
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00032344 File Offset: 0x00030544
	public TsTaskPlayAction() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x0003236C File Offset: 0x0003056C
	public TsTaskPlayAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x0003239F File Offset: 0x0003059F
	protected TsTaskPlayAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x000323C0 File Offset: 0x000305C0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x000323F0 File Offset: 0x000305F0
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000775 RID: 1909
	private const int DEFAULT_FINISHED_TIME = 60000;

	// Token: 0x04000776 RID: 1910
	private bool IsInitTsVariables;

	// Token: 0x04000777 RID: 1911
	private string TsMontageName = "";

	// Token: 0x04000778 RID: 1912
	private int TsLoopTimeMillisecond;

	// Token: 0x04000779 RID: 1913
	private string TsBlackboardKeyTime = "";

	// Token: 0x0400077A RID: 1914
	private bool TsMaskInteract;

	// Token: 0x0400077B RID: 1915
	private double EndTime;

	// Token: 0x0400077C RID: 1916
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400077D RID: 1917
	[Nullable(2)]
	private PawnInteractNewComponent InteractComponent;

	// Token: 0x0400077E RID: 1918
	[Nullable(2)]
	private Action<UAnimMontage, bool> OnMontageEnded;

	// Token: 0x0400077F RID: 1919
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayAction.TsTaskPlayAction_C";

	// Token: 0x04000780 RID: 1920
	private static IntPtr _ClassPtr;

	// Token: 0x04000781 RID: 1921
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000782 RID: 1922
	private static int __PropertyOffset_MontageName;

	// Token: 0x04000783 RID: 1923
	private static int __PropertyOffset_LoopTimeMillisecond;

	// Token: 0x04000784 RID: 1924
	private static int __PropertyOffset_BlackboardKeyTime;

	// Token: 0x04000785 RID: 1925
	private static int __PropertyOffset_MaskInteract;
}
