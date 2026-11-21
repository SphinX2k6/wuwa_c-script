using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000085 RID: 133
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiMarkItem.TsTaskAiMarkItem_C")]
public class TsTaskAiMarkItem : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x0600067D RID: 1661 RVA: 0x00020FB1 File Offset: 0x0001F1B1
	// (set) Token: 0x0600067E RID: 1662 RVA: 0x00020FC5 File Offset: 0x0001F1C5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiMarkItem.__PropertyOffset_ItemBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiMarkItem.__PropertyOffset_ItemBlackboardKey)), value);
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x0600067F RID: 1663 RVA: 0x00020FDA File Offset: 0x0001F1DA
	// (set) Token: 0x06000680 RID: 1664 RVA: 0x00020FEA File Offset: 0x0001F1EA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SearchFilterIsMarkByAi
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAiMarkItem.__PropertyOffset_SearchFilterIsMarkByAi) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAiMarkItem.__PropertyOffset_SearchFilterIsMarkByAi) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00020FFC File Offset: 0x0001F1FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAiMarkItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskAiMarkItem.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00021055 File Offset: 0x0001F255
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsItemBlackboardKey = this.ItemBlackboardKey;
			this.TsSearchFilterIsMarkByAi = this.SearchFilterIsMarkByAi;
		}
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00021088 File Offset: 0x0001F288
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAiMarkItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAiMarkItem.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000684 RID: 1668 RVA: 0x00021138 File Offset: 0x0001F338
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
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		CharacterWeaponComponent component = charActorComp.Entity.GetComponent<CharacterWeaponComponent>();
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(charActorComp.Entity.Id, this.TsItemBlackboardKey);
		if (component.AiItemMarkId != 0 && this.TsSearchFilterIsMarkByAi)
		{
			int aiItemMarkId = component.AiItemMarkId;
			int? num = intValueByEntity;
			if (aiItemMarkId == num.GetValueOrDefault() & num != null)
			{
				base.FinishExecute(true);
				return;
			}
			base.FinishExecute(false);
			return;
		}
		else
		{
			Entity entity = EntitySystem.Instance.Get(intValueByEntity.Value);
			if (entity == null)
			{
				base.FinishExecute(false);
				return;
			}
			SceneItemAiInteractionComponent component2 = entity.GetComponent<SceneItemAiInteractionComponent>();
			if (component2 == null)
			{
				base.FinishExecute(false);
				return;
			}
			if (!component2.IsSearchByOther(charActorComp.Entity.Id))
			{
				if (this.TsSearchFilterIsMarkByAi)
				{
					component.AiItemMarkId = entity.Id;
					component2.SetSearched(charActorComp.Entity);
				}
				else
				{
					component.AiItemMarkId = 0;
					component2.SetUnSearched();
				}
				base.FinishExecute(true);
				return;
			}
			base.FinishExecute(false);
			return;
		}
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x00021291 File Offset: 0x0001F491
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiMarkItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiMarkItem.TsTaskAiMarkItem_C");
		}
		return TsTaskAiMarkItem._ClassPtr;
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x000212B8 File Offset: 0x0001F4B8
	public TsTaskAiMarkItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiMarkItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x000212E0 File Offset: 0x0001F4E0
	public TsTaskAiMarkItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiMarkItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00021313 File Offset: 0x0001F513
	protected TsTaskAiMarkItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00021327 File Offset: 0x0001F527
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00021330 File Offset: 0x0001F530
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004B8 RID: 1208
	private bool IsInitTsVariables;

	// Token: 0x040004B9 RID: 1209
	private string TsItemBlackboardKey = "";

	// Token: 0x040004BA RID: 1210
	private bool TsSearchFilterIsMarkByAi;

	// Token: 0x040004BB RID: 1211
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiMarkItem.TsTaskAiMarkItem_C";

	// Token: 0x040004BC RID: 1212
	private static IntPtr _ClassPtr;

	// Token: 0x040004BD RID: 1213
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004BE RID: 1214
	private static int __PropertyOffset_ItemBlackboardKey;

	// Token: 0x040004BF RID: 1215
	private static int __PropertyOffset_SearchFilterIsMarkByAi;
}
