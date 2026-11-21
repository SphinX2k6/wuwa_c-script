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
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x0600066B RID: 1643 RVA: 0x00020B21 File Offset: 0x0001ED21
	// (set) Token: 0x0600066C RID: 1644 RVA: 0x00020B35 File Offset: 0x0001ED35
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

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x0600066D RID: 1645 RVA: 0x00020B4A File Offset: 0x0001ED4A
	// (set) Token: 0x0600066E RID: 1646 RVA: 0x00020B5E File Offset: 0x0001ED5E
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

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x0600066F RID: 1647 RVA: 0x00020B73 File Offset: 0x0001ED73
	// (set) Token: 0x06000670 RID: 1648 RVA: 0x00020B87 File Offset: 0x0001ED87
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

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x00020B9C File Offset: 0x0001ED9C
	// (set) Token: 0x06000672 RID: 1650 RVA: 0x00020BAC File Offset: 0x0001EDAC
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

	// Token: 0x06000673 RID: 1651 RVA: 0x00020BC0 File Offset: 0x0001EDC0
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	protected virtual void InitTsVariables()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAiGetItemInfo) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("InitTsVariables"), TsTaskAiGetItemInfo.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.InitTsVariables_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00020C1C File Offset: 0x0001EE1C
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

	// Token: 0x06000675 RID: 1653 RVA: 0x00020C70 File Offset: 0x0001EE70
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskAiGetItemInfo) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskAiGetItemInfo.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000676 RID: 1654 RVA: 0x00020D20 File Offset: 0x0001EF20
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

	// Token: 0x06000677 RID: 1655 RVA: 0x00020ED0 File Offset: 0x0001F0D0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskAiGetItemInfo._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiGetItemInfo.TsTaskAiGetItemInfo_C");
		}
		return TsTaskAiGetItemInfo._ClassPtr;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00020EF4 File Offset: 0x0001F0F4
	public TsTaskAiGetItemInfo() : this(BuiltinUtils.AllocNativeUObject(TsTaskAiGetItemInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00020F1C File Offset: 0x0001F11C
	public TsTaskAiGetItemInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskAiGetItemInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00020F4F File Offset: 0x0001F14F
	protected TsTaskAiGetItemInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00020F79 File Offset: 0x0001F179
	protected virtual void __CPPCALL_InitTsVariables_Implementation()
	{
		this.InitTsVariables_Implementation();
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00020F84 File Offset: 0x0001F184
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040004AB RID: 1195
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<global::Vector> VectorArray;

	// Token: 0x040004AC RID: 1196
	private bool IsInitTsVariables;

	// Token: 0x040004AD RID: 1197
	private string TsItemBlackboardKey = "";

	// Token: 0x040004AE RID: 1198
	private string TsItemDistanceBlackboardKey = "";

	// Token: 0x040004AF RID: 1199
	private string TsItemLocationBlackboardKey = "";

	// Token: 0x040004B0 RID: 1200
	private bool TsUseNavigation;

	// Token: 0x040004B1 RID: 1201
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskAiGetItemInfo.TsTaskAiGetItemInfo_C";

	// Token: 0x040004B2 RID: 1202
	private static IntPtr _ClassPtr;

	// Token: 0x040004B3 RID: 1203
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040004B4 RID: 1204
	private static int __PropertyOffset_ItemBlackboardKey;

	// Token: 0x040004B5 RID: 1205
	private static int __PropertyOffset_ItemDistanceBlackboardKey;

	// Token: 0x040004B6 RID: 1206
	private static int __PropertyOffset_ItemLocationBlackboardKey;

	// Token: 0x040004B7 RID: 1207
	private static int __PropertyOffset_UseNavigation;
}
