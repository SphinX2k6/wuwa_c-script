using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000084 RID: 132
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiGetItemInfo.TsTaskAiGetItemInfo_C")]
public class TsTaskAiGetItemInfo : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001FE9D File Offset: 0x0001E09D
	// (set) Token: 0x06000668 RID: 1640 RVA: 0x0001FEB1 File Offset: 0x0001E0B1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_ItemBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_ItemBlackboardKey)), value);
		}
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001FEC6 File Offset: 0x0001E0C6
	// (set) Token: 0x0600066A RID: 1642 RVA: 0x0001FEDA File Offset: 0x0001E0DA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemDistanceBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_ItemDistanceBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_ItemDistanceBlackboardKey)), value);
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001FEEF File Offset: 0x0001E0EF
	// (set) Token: 0x0600066C RID: 1644 RVA: 0x0001FF03 File Offset: 0x0001E103
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string ItemLocationBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_ItemLocationBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_ItemLocationBlackboardKey)), value);
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x0600066D RID: 1645 RVA: 0x0001FF18 File Offset: 0x0001E118
	// (set) Token: 0x0600066E RID: 1646 RVA: 0x0001FF28 File Offset: 0x0001E128
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool UseNavigation
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_UseNavigation) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskAiGetItemInfo.__PropertyOffset_UseNavigation) = (value ? 1 : 0);
		}
	}

	// Token: 0x0600066F RID: 1647 RVA: 0x0001FF3C File Offset: 0x0001E13C
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

	// Token: 0x06000670 RID: 1648 RVA: 0x0001FFAC File Offset: 0x0001E1AC
	protected void InitTsVariables_Implementation()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsItemBlackboardKey = this.ItemBlackboardKey;
			this.TsItemDistanceBlackboardKey = this.ItemDistanceBlackboardKey;
			this.TsItemLocationBlackboardKey = this.ItemLocationBlackboardKey;
			this.TsUseNavigation = this.UseNavigation;
		}
	}

	// Token: 0x06000671 RID: 1649 RVA: 0x00020000 File Offset: 0x0001E200
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

	// Token: 0x06000672 RID: 1650 RVA: 0x0002009C File Offset: 0x0001E29C
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
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(charActorComp.Entity.Id, this.TsItemBlackboardKey);
		Entity entity = EntitySystem.Instance.Get(intValueByEntity.Value);
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		if (entity == null || component.GetEntityType() != EEntityType.SceneItem)
		{
			base.FinishExecute(false);
			return;
		}
		FVectorDouble actorLocation = entity.GetComponent<SceneItemActorComponent>().ActorLocation;
		if (this.VectorArray == null)
		{
			this.VectorArray = new List<global::Vector>();
		}
		FVectorDouble fvectorDouble = controlledPawn.D_K2_GetActorLocation();
		double num;
		if (this.TsUseNavigation)
		{
			AiControllerLibrary.NavigationFindPath(ownerController, fvectorDouble, actorLocation, this.VectorArray, null, null);
			num = AiControllerLibrary.GetPathLength(fvectorDouble, this.VectorArray);
		}
		else
		{
			global::Vector vector = global::Vector.Create(actorLocation);
			global::Vector inB = global::Vector.Create(fvectorDouble);
			num = vector.SubtractionEqual(inB).Size();
		}
		BlackboardController.Instance.SetFloatValueByEntity(charActorComp.Entity.Id, this.TsItemDistanceBlackboardKey, (float)num);
		BlackboardController.Instance.SetVectorValueByEntity(charActorComp.Entity.Id, this.TsItemLocationBlackboardKey, (double)((float)actorLocation.X), (double)((float)actorLocation.Y), (double)((float)actorLocation.Z));
		base.FinishExecute(true);
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x0002024C File Offset: 0x0001E44C
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiGetItemInfo._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiGetItemInfo.TsTaskAiGetItemInfo_C");
		}
		return TsTaskAiGetItemInfo._ClassPtr;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00020270 File Offset: 0x0001E470
	public TsTaskAiGetItemInfo() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiGetItemInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00020298 File Offset: 0x0001E498
	public TsTaskAiGetItemInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiGetItemInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x000202CB File Offset: 0x0001E4CB
	protected TsTaskAiGetItemInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x000202F5 File Offset: 0x0001E4F5
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00020300 File Offset: 0x0001E500
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004A7 RID: 1191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> VectorArray;

	// Token: 0x040004A8 RID: 1192
	private bool IsInitTsVariables;

	// Token: 0x040004A9 RID: 1193
	private string TsItemBlackboardKey = "";

	// Token: 0x040004AA RID: 1194
	private string TsItemDistanceBlackboardKey = "";

	// Token: 0x040004AB RID: 1195
	private string TsItemLocationBlackboardKey = "";

	// Token: 0x040004AC RID: 1196
	private bool TsUseNavigation;

	// Token: 0x040004AD RID: 1197
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiGetItemInfo.TsTaskAiGetItemInfo_C";

	// Token: 0x040004AE RID: 1198
	private static IntPtr _ClassPtr;

	// Token: 0x040004AF RID: 1199
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004B0 RID: 1200
	private static int __PropertyOffset_ItemBlackboardKey;

	// Token: 0x040004B1 RID: 1201
	private static int __PropertyOffset_ItemDistanceBlackboardKey;

	// Token: 0x040004B2 RID: 1202
	private static int __PropertyOffset_ItemLocationBlackboardKey;

	// Token: 0x040004B3 RID: 1203
	private static int __PropertyOffset_UseNavigation;
}
