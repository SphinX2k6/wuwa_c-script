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
	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000652 RID: 1618 RVA: 0x00020593 File Offset: 0x0001E793
	// (set) Token: 0x06000653 RID: 1619 RVA: 0x000205A3 File Offset: 0x0001E7A3
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

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x06000654 RID: 1620 RVA: 0x000205B4 File Offset: 0x0001E7B4
	// (set) Token: 0x06000655 RID: 1621 RVA: 0x000205C8 File Offset: 0x0001E7C8
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

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x06000656 RID: 1622 RVA: 0x000205DD File Offset: 0x0001E7DD
	// (set) Token: 0x06000657 RID: 1623 RVA: 0x000205F1 File Offset: 0x0001E7F1
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

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000658 RID: 1624 RVA: 0x00020606 File Offset: 0x0001E806
	// (set) Token: 0x06000659 RID: 1625 RVA: 0x0002061A File Offset: 0x0001E81A
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

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600065A RID: 1626 RVA: 0x0002062F File Offset: 0x0001E82F
	// (set) Token: 0x0600065B RID: 1627 RVA: 0x0002063F File Offset: 0x0001E83F
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

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600065C RID: 1628 RVA: 0x00020650 File Offset: 0x0001E850
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

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600065D RID: 1629 RVA: 0x00020689 File Offset: 0x0001E889
	// (set) Token: 0x0600065E RID: 1630 RVA: 0x00020699 File Offset: 0x0001E899
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

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x0600065F RID: 1631 RVA: 0x000206AA File Offset: 0x0001E8AA
	// (set) Token: 0x06000660 RID: 1632 RVA: 0x000206BA File Offset: 0x0001E8BA
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

	// Token: 0x06000661 RID: 1633 RVA: 0x000206CC File Offset: 0x0001E8CC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAiFindClosetItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskAiFindClosetItem.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000662 RID: 1634 RVA: 0x00020728 File Offset: 0x0001E928
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

	// Token: 0x06000663 RID: 1635 RVA: 0x00020808 File Offset: 0x0001EA08
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAiFindClosetItem) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAiFindClosetItem.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000664 RID: 1636 RVA: 0x000208B8 File Offset: 0x0001EAB8
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

	// Token: 0x06000665 RID: 1637 RVA: 0x00020A3F File Offset: 0x0001EC3F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiFindClosetItem._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiFindClosetItem.TsTaskAiFindClosetItem_C");
		}
		return TsTaskAiFindClosetItem._ClassPtr;
	}

	// Token: 0x06000666 RID: 1638 RVA: 0x00020A64 File Offset: 0x0001EC64
	public TsTaskAiFindClosetItem() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiFindClosetItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000667 RID: 1639 RVA: 0x00020A8C File Offset: 0x0001EC8C
	public TsTaskAiFindClosetItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiFindClosetItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000668 RID: 1640 RVA: 0x00020ABF File Offset: 0x0001ECBF
	protected TsTaskAiFindClosetItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000669 RID: 1641 RVA: 0x00020AE9 File Offset: 0x0001ECE9
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x0600066A RID: 1642 RVA: 0x00020AF4 File Offset: 0x0001ECF4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x04000498 RID: 1176
	private bool IsInitTsVariables;

	// Token: 0x04000499 RID: 1177
	private float TsRange;

	// Token: 0x0400049A RID: 1178
	private string TsItemBlackboardKey = "";

	// Token: 0x0400049B RID: 1179
	private string TsItemDistanceBlackboardKey = "";

	// Token: 0x0400049C RID: 1180
	private string TsItemLocationBlackboardKey = "";

	// Token: 0x0400049D RID: 1181
	private bool TsSearchFilterIsMarkByAi;

	// Token: 0x0400049E RID: 1182
	[Nullable(2)]
	private AiInteractionSearchFilter TsFilter;

	// Token: 0x0400049F RID: 1183
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiFindClosetItem.TsTaskAiFindClosetItem_C";

	// Token: 0x040004A0 RID: 1184
	private static IntPtr _ClassPtr;

	// Token: 0x040004A1 RID: 1185
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004A2 RID: 1186
	private static int __PropertyOffset_Range;

	// Token: 0x040004A3 RID: 1187
	private static int __PropertyOffset_ItemBlackboardKey;

	// Token: 0x040004A4 RID: 1188
	private static int __PropertyOffset_ItemDistanceBlackboardKey;

	// Token: 0x040004A5 RID: 1189
	private static int __PropertyOffset_ItemLocationBlackboardKey;

	// Token: 0x040004A6 RID: 1190
	private static int __PropertyOffset_SearchFilterIsMarkByAi;

	// Token: 0x040004A7 RID: 1191
	private static int __PropertyOffset_Tag;

	// Token: 0x040004A8 RID: 1192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TArray<string> _Tag;

	// Token: 0x040004A9 RID: 1193
	private static int __PropertyOffset_UseNavigation;

	// Token: 0x040004AA RID: 1194
	private static int __PropertyOffset_TsUseNavigation;
}
