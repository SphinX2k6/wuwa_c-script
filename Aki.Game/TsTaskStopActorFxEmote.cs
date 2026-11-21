using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActorFxEmote;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C3 RID: 195
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskStopActorFxEmote.TsTaskStopActorFxEmote_C")]
public class TsTaskStopActorFxEmote : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00039345 File Offset: 0x00037545
	// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00039355 File Offset: 0x00037555
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool StopAll
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskStopActorFxEmote.__PropertyOffset_StopAll) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskStopActorFxEmote.__PropertyOffset_StopAll) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00039368 File Offset: 0x00037568
	// (set) Token: 0x06000B40 RID: 2880 RVA: 0x000393A1 File Offset: 0x000375A1
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> SocketNames
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._SocketNames) == null)
			{
				result = (this._SocketNames = new TArray<string>(base.NativePtr + (IntPtr)TsTaskStopActorFxEmote.__PropertyOffset_SocketNames, this));
			}
			return result;
		}
		set
		{
			this.SocketNames.CopyAssign(value);
		}
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x000393B0 File Offset: 0x000375B0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskStopActorFxEmote) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskStopActorFxEmote.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B42 RID: 2882 RVA: 0x00039460 File Offset: 0x00037660
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[TsTaskStopActorFxEmote] 错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
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
		if (this.StopAll)
		{
			ActorFxEmoteController.Instance.StopEntity(id);
			base.FinishExecute(true);
			return;
		}
		TArray<string> socketNames = this.SocketNames;
		if (socketNames != null && socketNames.Count > 0)
		{
			for (int i = 0; i < socketNames.Num(); i++)
			{
				ActorFxEmoteController.Instance.StopSocket(id, socketNames.Get(i));
			}
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x0003953B File Offset: 0x0003773B
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskStopActorFxEmote._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskStopActorFxEmote.TsTaskStopActorFxEmote_C");
		}
		return TsTaskStopActorFxEmote._ClassPtr;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00039560 File Offset: 0x00037760
	public TsTaskStopActorFxEmote() : this(BuiltinUtils.AllocNativeUObject(TsTaskStopActorFxEmote.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00039588 File Offset: 0x00037788
	public TsTaskStopActorFxEmote(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskStopActorFxEmote.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B46 RID: 2886 RVA: 0x000395BB File Offset: 0x000377BB
	protected TsTaskStopActorFxEmote(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B47 RID: 2887 RVA: 0x000395C4 File Offset: 0x000377C4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040008CF RID: 2255
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskStopActorFxEmote.TsTaskStopActorFxEmote_C";

	// Token: 0x040008D0 RID: 2256
	private static IntPtr _ClassPtr;

	// Token: 0x040008D1 RID: 2257
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008D2 RID: 2258
	private static int __PropertyOffset_StopAll;

	// Token: 0x040008D3 RID: 2259
	private static int __PropertyOffset_SocketNames;

	// Token: 0x040008D4 RID: 2260
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _SocketNames;
}
