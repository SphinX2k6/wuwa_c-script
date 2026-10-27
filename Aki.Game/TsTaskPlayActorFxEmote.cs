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
	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x060009B5 RID: 2485 RVA: 0x0003133B File Offset: 0x0002F53B
	// (set) Token: 0x060009B6 RID: 2486 RVA: 0x0003134B File Offset: 0x0002F54B
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

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003135C File Offset: 0x0002F55C
	// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00031370 File Offset: 0x0002F570
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

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00031385 File Offset: 0x0002F585
	// (set) Token: 0x060009BA RID: 2490 RVA: 0x00031399 File Offset: 0x0002F599
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

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060009BB RID: 2491 RVA: 0x000313AE File Offset: 0x0002F5AE
	// (set) Token: 0x060009BC RID: 2492 RVA: 0x000313C2 File Offset: 0x0002F5C2
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

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060009BD RID: 2493 RVA: 0x000313D7 File Offset: 0x0002F5D7
	// (set) Token: 0x060009BE RID: 2494 RVA: 0x000313EB File Offset: 0x0002F5EB
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

	// Token: 0x170001B7 RID: 439
	// (get) Token: 0x060009BF RID: 2495 RVA: 0x00031400 File Offset: 0x0002F600
	// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00031414 File Offset: 0x0002F614
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

	// Token: 0x060009C1 RID: 2497 RVA: 0x0003142C File Offset: 0x0002F62C
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

	// Token: 0x060009C2 RID: 2498 RVA: 0x000314F8 File Offset: 0x0002F6F8
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

	// Token: 0x060009C3 RID: 2499 RVA: 0x00031594 File Offset: 0x0002F794
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

	// Token: 0x060009C4 RID: 2500 RVA: 0x00031676 File Offset: 0x0002F876
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskPlayActorFxEmote._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayActorFxEmote.TsTaskPlayActorFxEmote_C");
		}
		return TsTaskPlayActorFxEmote._ClassPtr;
	}

	// Token: 0x060009C5 RID: 2501 RVA: 0x0003169C File Offset: 0x0002F89C
	public TsTaskPlayActorFxEmote() : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayActorFxEmote.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060009C6 RID: 2502 RVA: 0x000316C4 File Offset: 0x0002F8C4
	public TsTaskPlayActorFxEmote(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskPlayActorFxEmote.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060009C7 RID: 2503 RVA: 0x000316F8 File Offset: 0x0002F8F8
	protected TsTaskPlayActorFxEmote(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060009C8 RID: 2504 RVA: 0x00031748 File Offset: 0x0002F948
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400077E RID: 1918
	private bool IsInitTsVariables;

	// Token: 0x0400077F RID: 1919
	private long TsEffectBuffId;

	// Token: 0x04000780 RID: 1920
	private readonly Vector TsRelativePosition = Vector.Create();

	// Token: 0x04000781 RID: 1921
	private readonly Rotator TsRelativeRotation = Rotator.Create();

	// Token: 0x04000782 RID: 1922
	private readonly Vector TsScale = Vector.Create(1.0, 1.0, 1.0);

	// Token: 0x04000783 RID: 1923
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskPlayActorFxEmote.TsTaskPlayActorFxEmote_C";

	// Token: 0x04000784 RID: 1924
	private static IntPtr _ClassPtr;

	// Token: 0x04000785 RID: 1925
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000786 RID: 1926
	private static int __PropertyOffset_EffectBuffId;

	// Token: 0x04000787 RID: 1927
	private static int __PropertyOffset_SocketName;

	// Token: 0x04000788 RID: 1928
	private static int __PropertyOffset_RelativePosition;

	// Token: 0x04000789 RID: 1929
	private static int __PropertyOffset_RelativeRotation;

	// Token: 0x0400078A RID: 1930
	private static int __PropertyOffset_Scale;

	// Token: 0x0400078B RID: 1931
	private static int __PropertyOffset_TsSocketName;
}
