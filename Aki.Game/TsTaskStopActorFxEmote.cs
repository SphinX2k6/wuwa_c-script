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
	// Token: 0x1700020C RID: 524
	// (get) Token: 0x06000B37 RID: 2871 RVA: 0x00038181 File Offset: 0x00036381
	// (set) Token: 0x06000B38 RID: 2872 RVA: 0x00038191 File Offset: 0x00036391
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

	// Token: 0x1700020D RID: 525
	// (get) Token: 0x06000B39 RID: 2873 RVA: 0x000381A4 File Offset: 0x000363A4
	// (set) Token: 0x06000B3A RID: 2874 RVA: 0x000381DD File Offset: 0x000363DD
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

	// Token: 0x06000B3B RID: 2875 RVA: 0x000381EC File Offset: 0x000363EC
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

	// Token: 0x06000B3C RID: 2876 RVA: 0x00038288 File Offset: 0x00036488
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

	// Token: 0x06000B3D RID: 2877 RVA: 0x00038363 File Offset: 0x00036563
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskStopActorFxEmote._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskStopActorFxEmote.TsTaskStopActorFxEmote_C");
		}
		return TsTaskStopActorFxEmote._ClassPtr;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00038388 File Offset: 0x00036588
	public TsTaskStopActorFxEmote() : this(BuiltinUtils.AllocNativeUObject(TsTaskStopActorFxEmote.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x000383B0 File Offset: 0x000365B0
	public TsTaskStopActorFxEmote(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskStopActorFxEmote.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x000383E3 File Offset: 0x000365E3
	protected TsTaskStopActorFxEmote(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x000383EC File Offset: 0x000365EC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040008C7 RID: 2247
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskStopActorFxEmote.TsTaskStopActorFxEmote_C";

	// Token: 0x040008C8 RID: 2248
	private static IntPtr _ClassPtr;

	// Token: 0x040008C9 RID: 2249
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008CA RID: 2250
	private static int __PropertyOffset_StopAll;

	// Token: 0x040008CB RID: 2251
	private static int __PropertyOffset_SocketNames;

	// Token: 0x040008CC RID: 2252
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _SocketNames;
}
