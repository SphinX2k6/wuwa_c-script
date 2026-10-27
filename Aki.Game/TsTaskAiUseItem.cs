using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AiInteraction.AiWeapon;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000087 RID: 135
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiUseItem.TsTaskAiUseItem_C")]
public class TsTaskAiUseItem : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x060006AC RID: 1708 RVA: 0x000212E3 File Offset: 0x0001F4E3
	// (set) Token: 0x060006AD RID: 1709 RVA: 0x000212F7 File Offset: 0x0001F4F7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiUseItem.__PropertyOffset_ItemBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiUseItem.__PropertyOffset_ItemBlackboardKey)), value);
		}
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x0002130C File Offset: 0x0001F50C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected unsafe virtual void InitTsVariables()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("InitTsVariables"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x0002137C File Offset: 0x0001F57C
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsItemBlackboardKey = this.ItemBlackboardKey;
		}
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000213A0 File Offset: 0x0001F5A0
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

	// Token: 0x060006B1 RID: 1713 RVA: 0x0002143C File Offset: 0x0001F63C
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
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
			return;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(charActorComp.Entity.Id, this.TsItemBlackboardKey);
		if (!GlobalData.Networking())
		{
			return;
		}
		AiWeaponModel.Instance.Net.SendHoldWeaponPushOnSafe(charActorComp.Entity.Id, intValueByEntity.Value);
		base.FinishExecute(true);
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x000214EE File Offset: 0x0001F6EE
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiUseItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiUseItem.TsTaskAiUseItem_C");
		}
		return TsTaskAiUseItem._ClassPtr;
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x00021514 File Offset: 0x0001F714
	public TsTaskAiUseItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiUseItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x0002153C File Offset: 0x0001F73C
	public TsTaskAiUseItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiUseItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x0002156F File Offset: 0x0001F76F
	protected TsTaskAiUseItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00021583 File Offset: 0x0001F783
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x0002158C File Offset: 0x0001F78C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004DC RID: 1244
	private bool IsInitTsVariables;

	// Token: 0x040004DD RID: 1245
	private string TsItemBlackboardKey = "";

	// Token: 0x040004DE RID: 1246
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiUseItem.TsTaskAiUseItem_C";

	// Token: 0x040004DF RID: 1247
	private static IntPtr _ClassPtr;

	// Token: 0x040004E0 RID: 1248
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004E1 RID: 1249
	private static int __PropertyOffset_ItemBlackboardKey;
}
