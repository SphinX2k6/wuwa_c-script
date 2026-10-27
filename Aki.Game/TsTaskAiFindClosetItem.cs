using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000083 RID: 131
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiFindClosetItem.TsTaskAiFindClosetItem_C")]
public class TsTaskAiFindClosetItem : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001F90F File Offset: 0x0001DB0F
	// (set) Token: 0x0600064F RID: 1615 RVA: 0x0001F91F File Offset: 0x0001DB1F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Range
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_Range);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_Range) = value;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001F930 File Offset: 0x0001DB30
	// (set) Token: 0x06000651 RID: 1617 RVA: 0x0001F944 File Offset: 0x0001DB44
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_ItemBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_ItemBlackboardKey)), value);
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001F959 File Offset: 0x0001DB59
	// (set) Token: 0x06000653 RID: 1619 RVA: 0x0001F96D File Offset: 0x0001DB6D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemDistanceBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_ItemDistanceBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_ItemDistanceBlackboardKey)), value);
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001F982 File Offset: 0x0001DB82
	// (set) Token: 0x06000655 RID: 1621 RVA: 0x0001F996 File Offset: 0x0001DB96
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemLocationBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_ItemLocationBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_ItemLocationBlackboardKey)), value);
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001F9AB File Offset: 0x0001DBAB
	// (set) Token: 0x06000657 RID: 1623 RVA: 0x0001F9BB File Offset: 0x0001DBBB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool SearchFilterIsMarkByAi
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_SearchFilterIsMarkByAi) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_SearchFilterIsMarkByAi) = (value ? 1 : 0);
		}
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x0001F9CC File Offset: 0x0001DBCC
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<string> Tag
	{
		get
		{
			base.FastCheckIsValid();
			TArray<string> result;
			if ((result = this._Tag) == null)
			{
				result = (this._Tag = new TArray<string>(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_Tag, this));
			}
			return result;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001FA05 File Offset: 0x0001DC05
	// (set) Token: 0x0600065A RID: 1626 RVA: 0x0001FA15 File Offset: 0x0001DC15
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseNavigation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_UseNavigation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_UseNavigation) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001FA26 File Offset: 0x0001DC26
	// (set) Token: 0x0600065C RID: 1628 RVA: 0x0001FA36 File Offset: 0x0001DC36
	[UProperty(EPropertyFlags.CPF_None)]
	private unsafe bool TsUseNavigation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_TsUseNavigation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAiFindClosetItem.__PropertyOffset_TsUseNavigation) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x0001FA48 File Offset: 0x0001DC48
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

	// Token: 0x0600065E RID: 1630 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsRange = this.Range;
			this.TsItemBlackboardKey = this.ItemBlackboardKey;
			this.TsItemDistanceBlackboardKey = this.ItemDistanceBlackboardKey;
			this.TsItemLocationBlackboardKey = this.ItemLocationBlackboardKey;
			this.TsSearchFilterIsMarkByAi = this.SearchFilterIsMarkByAi;
			this.TsFilter = new AiInteractionSearchFilter();
			TArray<string> tag = this.Tag;
			if (tag != null && tag.Num() == 0)
			{
				this.TsFilter.Tag = null;
			}
			else
			{
				for (int i = 0; i < this.Tag.Num(); i++)
				{
					this.TsFilter.Tag = new List<string>();
					this.TsFilter.Tag.Add(this.Tag.Get(i));
				}
			}
			this.TsUseNavigation = this.UseNavigation;
		}
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x0001FB98 File Offset: 0x0001DD98
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

	// Token: 0x06000660 RID: 1632 RVA: 0x0001FC34 File Offset: 0x0001DE34
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
		FVectorDouble origin = controlledPawn.D_K2_GetActorLocation();
		this.TsFilter.IsSearchedMarkByAi = new bool?(this.TsSearchFilterIsMarkByAi);
		this.TsFilter.Entity = charActorComp.Entity;
		ItemQueryResult closeActor = AiInteractionItemQueryManager.Get().GetCloseActor(origin, this.TsUseNavigation ? EItemQuerySearchType.Path : EItemQuerySearchType.Line, this.TsFilter, ownerController);
		if (closeActor == null)
		{
			base.FinishExecute(false);
			return;
		}
		if (closeActor.Length > (double)this.TsRange)
		{
			base.FinishExecute(false);
			return;
		}
		BlackboardController.Instance.SetIntValueByEntity(charActorComp.Entity.Id, this.TsItemBlackboardKey, closeActor.Entity.Id);
		BlackboardController.Instance.SetFloatValueByEntity(charActorComp.Entity.Id, this.TsItemDistanceBlackboardKey, (float)closeActor.Length);
		CreatureDataComponent component = closeActor.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		if (component.GetEntityType() == EEntityType.SceneItem)
		{
			FVectorDouble actorLocation = closeActor.Entity.GetComponent<SceneItemActorComponent>().ActorLocation;
			BlackboardController.Instance.SetVectorValueByEntity(charActorComp.Entity.Id, this.TsItemLocationBlackboardKey, (double)((float)actorLocation.X), (double)((float)actorLocation.Y), (double)((float)actorLocation.Z));
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x0001FDBB File Offset: 0x0001DFBB
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiFindClosetItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiFindClosetItem.TsTaskAiFindClosetItem_C");
		}
		return TsTaskAiFindClosetItem._ClassPtr;
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x0001FDE0 File Offset: 0x0001DFE0
	public TsTaskAiFindClosetItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiFindClosetItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000663 RID: 1635 RVA: 0x0001FE08 File Offset: 0x0001E008
	public TsTaskAiFindClosetItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiFindClosetItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x0001FE3B File Offset: 0x0001E03B
	protected TsTaskAiFindClosetItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x0001FE65 File Offset: 0x0001E065
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x0001FE70 File Offset: 0x0001E070
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000494 RID: 1172
	private bool IsInitTsVariables;

	// Token: 0x04000495 RID: 1173
	private float TsRange;

	// Token: 0x04000496 RID: 1174
	private string TsItemBlackboardKey = "";

	// Token: 0x04000497 RID: 1175
	private string TsItemDistanceBlackboardKey = "";

	// Token: 0x04000498 RID: 1176
	private string TsItemLocationBlackboardKey = "";

	// Token: 0x04000499 RID: 1177
	private bool TsSearchFilterIsMarkByAi;

	// Token: 0x0400049A RID: 1178
	[Nullable(2)]
	private AiInteractionSearchFilter TsFilter;

	// Token: 0x0400049B RID: 1179
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiFindClosetItem.TsTaskAiFindClosetItem_C";

	// Token: 0x0400049C RID: 1180
	private static IntPtr _ClassPtr;

	// Token: 0x0400049D RID: 1181
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400049E RID: 1182
	private static int __PropertyOffset_Range;

	// Token: 0x0400049F RID: 1183
	private static int __PropertyOffset_ItemBlackboardKey;

	// Token: 0x040004A0 RID: 1184
	private static int __PropertyOffset_ItemDistanceBlackboardKey;

	// Token: 0x040004A1 RID: 1185
	private static int __PropertyOffset_ItemLocationBlackboardKey;

	// Token: 0x040004A2 RID: 1186
	private static int __PropertyOffset_SearchFilterIsMarkByAi;

	// Token: 0x040004A3 RID: 1187
	private static int __PropertyOffset_Tag;

	// Token: 0x040004A4 RID: 1188
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _Tag;

	// Token: 0x040004A5 RID: 1189
	private static int __PropertyOffset_UseNavigation;

	// Token: 0x040004A6 RID: 1190
	private static int __PropertyOffset_TsUseNavigation;
}
