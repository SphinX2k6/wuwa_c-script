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
	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06000679 RID: 1657 RVA: 0x0002032D File Offset: 0x0001E52D
	// (set) Token: 0x0600067A RID: 1658 RVA: 0x00020341 File Offset: 0x0001E541
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

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x0600067B RID: 1659 RVA: 0x00020356 File Offset: 0x0001E556
	// (set) Token: 0x0600067C RID: 1660 RVA: 0x00020366 File Offset: 0x0001E566
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

	// Token: 0x0600067D RID: 1661 RVA: 0x00020378 File Offset: 0x0001E578
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void InitTsVariables()
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

	// Token: 0x0600067E RID: 1662 RVA: 0x000203E8 File Offset: 0x0001E5E8
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsItemBlackboardKey = this.ItemBlackboardKey;
			this.TsSearchFilterIsMarkByAi = this.SearchFilterIsMarkByAi;
		}
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00020418 File Offset: 0x0001E618
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

	// Token: 0x06000680 RID: 1664 RVA: 0x000204B4 File Offset: 0x0001E6B4
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

	// Token: 0x06000681 RID: 1665 RVA: 0x0002060D File Offset: 0x0001E80D
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiMarkItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiMarkItem.TsTaskAiMarkItem_C");
		}
		return TsTaskAiMarkItem._ClassPtr;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00020634 File Offset: 0x0001E834
	public TsTaskAiMarkItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiMarkItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x0002065C File Offset: 0x0001E85C
	public TsTaskAiMarkItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiMarkItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000684 RID: 1668 RVA: 0x0002068F File Offset: 0x0001E88F
	protected TsTaskAiMarkItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000685 RID: 1669 RVA: 0x000206A3 File Offset: 0x0001E8A3
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x000206AC File Offset: 0x0001E8AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004B4 RID: 1204
	private bool IsInitTsVariables;

	// Token: 0x040004B5 RID: 1205
	private string TsItemBlackboardKey = "";

	// Token: 0x040004B6 RID: 1206
	private bool TsSearchFilterIsMarkByAi;

	// Token: 0x040004B7 RID: 1207
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiMarkItem.TsTaskAiMarkItem_C";

	// Token: 0x040004B8 RID: 1208
	private static IntPtr _ClassPtr;

	// Token: 0x040004B9 RID: 1209
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004BA RID: 1210
	private static int __PropertyOffset_ItemBlackboardKey;

	// Token: 0x040004BB RID: 1211
	private static int __PropertyOffset_SearchFilterIsMarkByAi;
}
