using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActorFxEmote;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000AE RID: 174
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayActorFxEmote.TsTaskPlayActorFxEmote_C")]
public class TsTaskPlayActorFxEmote : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060009BB RID: 2491 RVA: 0x00032423 File Offset: 0x00030623
	// (set) Token: 0x060009BC RID: 2492 RVA: 0x00032433 File Offset: 0x00030633
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe long EffectBuffId
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_EffectBuffId);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_EffectBuffId) = value;
		}
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060009BD RID: 2493 RVA: 0x00032444 File Offset: 0x00030644
	// (set) Token: 0x060009BE RID: 2494 RVA: 0x00032458 File Offset: 0x00030658
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string SocketName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_SocketName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_SocketName)), value);
		}
	}

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060009BF RID: 2495 RVA: 0x0003246D File Offset: 0x0003066D
	// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00032481 File Offset: 0x00030681
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector RelativePosition
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_RelativePosition);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_RelativePosition) = value;
		}
	}

	// Token: 0x170001B8 RID: 440
	// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00032496 File Offset: 0x00030696
	// (set) Token: 0x060009C2 RID: 2498 RVA: 0x000324AA File Offset: 0x000306AA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FRotator RelativeRotation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_RelativeRotation);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_RelativeRotation) = value;
		}
	}

	// Token: 0x170001B9 RID: 441
	// (get) Token: 0x060009C3 RID: 2499 RVA: 0x000324BF File Offset: 0x000306BF
	// (set) Token: 0x060009C4 RID: 2500 RVA: 0x000324D3 File Offset: 0x000306D3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector Scale
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_Scale);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_Scale) = value;
		}
	}

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x060009C5 RID: 2501 RVA: 0x000324E8 File Offset: 0x000306E8
	// (set) Token: 0x060009C6 RID: 2502 RVA: 0x000324FC File Offset: 0x000306FC
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TsSocketName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_TsSocketName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskPlayActorFxEmote.__PropertyOffset_TsSocketName)), value);
		}
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x00032514 File Offset: 0x00030714
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsEffectBuffId = this.EffectBuffId;
			this.TsSocketName = this.SocketName;
			Vector tsRelativePosition = this.TsRelativePosition;
			FVector fvector = this.RelativePosition;
			tsRelativePosition.FromUeVector(fvector);
			Rotator tsRelativeRotation = this.TsRelativeRotation;
			FRotator relativeRotation = this.RelativeRotation;
			tsRelativeRotation.FromUeRotator(relativeRotation);
			Vector tsScale = this.TsScale;
			fvector = this.Scale;
			tsScale.FromUeVector(fvector);
			if (this.TsScale.IsZero())
			{
				this.TsScale.Set(1.0, 1.0, 1.0);
				Log.Instance.Info(ELogModule.BehaviorTree, ELogAuthor.ZJL, "[TsTaskPlayActorFxEmote] Scale为零，兜底为单位缩放", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x000325E0 File Offset: 0x000307E0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskPlayActorFxEmote) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskPlayActorFxEmote.StaticClass(), out intPtr, out num))
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

	// Token: 0x060009C9 RID: 2505 RVA: 0x00032690 File Offset: 0x00030890
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
			string message = "[TsTaskPlayActorFxEmote] 错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		if (this.TsEffectBuffId == 0L)
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "[TsTaskPlayActorFxEmote] 未配置EffectBuffId", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		ActorFxEmoteController.Instance.Play(id, this.TsEffectBuffId, this.TsSocketName, this.TsRelativePosition, this.TsRelativeRotation, this.TsScale);
		base.FinishExecute(true);
	}

	// Token: 0x060009CA RID: 2506 RVA: 0x00032772 File Offset: 0x00030972
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayActorFxEmote._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayActorFxEmote.TsTaskPlayActorFxEmote_C");
		}
		return TsTaskPlayActorFxEmote._ClassPtr;
	}

	// Token: 0x060009CB RID: 2507 RVA: 0x00032798 File Offset: 0x00030998
	public TsTaskPlayActorFxEmote() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayActorFxEmote.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060009CC RID: 2508 RVA: 0x000327C0 File Offset: 0x000309C0
	public TsTaskPlayActorFxEmote(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayActorFxEmote.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060009CD RID: 2509 RVA: 0x000327F4 File Offset: 0x000309F4
	protected TsTaskPlayActorFxEmote(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060009CE RID: 2510 RVA: 0x00032844 File Offset: 0x00030A44
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000786 RID: 1926
	private bool IsInitTsVariables;

	// Token: 0x04000787 RID: 1927
	private long TsEffectBuffId;

	// Token: 0x04000788 RID: 1928
	private readonly Vector TsRelativePosition = Vector.Create();

	// Token: 0x04000789 RID: 1929
	private readonly Rotator TsRelativeRotation = Rotator.Create();

	// Token: 0x0400078A RID: 1930
	private readonly Vector TsScale = Vector.Create(1.0, 1.0, 1.0);

	// Token: 0x0400078B RID: 1931
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayActorFxEmote.TsTaskPlayActorFxEmote_C";

	// Token: 0x0400078C RID: 1932
	private static IntPtr _ClassPtr;

	// Token: 0x0400078D RID: 1933
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400078E RID: 1934
	private static int __PropertyOffset_EffectBuffId;

	// Token: 0x0400078F RID: 1935
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000790 RID: 1936
	private static int __PropertyOffset_RelativePosition;

	// Token: 0x04000791 RID: 1937
	private static int __PropertyOffset_RelativeRotation;

	// Token: 0x04000792 RID: 1938
	private static int __PropertyOffset_Scale;

	// Token: 0x04000793 RID: 1939
	private static int __PropertyOffset_TsSocketName;
}
