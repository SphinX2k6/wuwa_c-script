using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000C5 RID: 197
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchGazeAwareness.TsTaskSwitchGazeAwareness_C")]
public class TsTaskSwitchGazeAwareness : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00039813 File Offset: 0x00037A13
	// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00039823 File Offset: 0x00037A23
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool IsEnable
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_IsEnable) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_IsEnable) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00039834 File Offset: 0x00037A34
	// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00039844 File Offset: 0x00037A44
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AwarenessAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_AwarenessAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_AwarenessAngle) = value;
		}
	}

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00039855 File Offset: 0x00037A55
	// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00039865 File Offset: 0x00037A65
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AwarenessDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_AwarenessDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_AwarenessDistance) = value;
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06000B57 RID: 2903 RVA: 0x00039876 File Offset: 0x00037A76
	// (set) Token: 0x06000B58 RID: 2904 RVA: 0x00039886 File Offset: 0x00037A86
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float AwarenessHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_AwarenessHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_AwarenessHeight) = value;
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000B59 RID: 2905 RVA: 0x00039897 File Offset: 0x00037A97
	// (set) Token: 0x06000B5A RID: 2906 RVA: 0x000398A7 File Offset: 0x00037AA7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float PlayerGazeAngle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_PlayerGazeAngle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_PlayerGazeAngle) = value;
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000B5B RID: 2907 RVA: 0x000398B8 File Offset: 0x00037AB8
	// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000398C8 File Offset: 0x00037AC8
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_EnableDebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSwitchGazeAwareness.__PropertyOffset_EnableDebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x000398DC File Offset: 0x00037ADC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsIsEnable = this.IsEnable;
			this.TsAwarenessAngle = this.AwarenessAngle;
			this.TsAwarenessDistance = this.AwarenessDistance;
			this.TsPlayerGazeAngle = this.PlayerGazeAngle;
			this.TsAwarenessHeight = this.AwarenessHeight;
			this.TsEnableDebugDraw = this.EnableDebugDraw;
		}
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00039948 File Offset: 0x00037B48
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskSwitchGazeAwareness) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskSwitchGazeAwareness.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000B5F RID: 2911 RVA: 0x000399F8 File Offset: 0x00037BF8
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
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		this.InitTsVariables();
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		IdlePerformModel instance2 = IdlePerformModel.Instance;
		if (instance2 == null)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		if (this.TsIsEnable)
		{
			instance2.StartGazeAwarenessCheckByEntityId(id, this.TsAwarenessAngle, this.TsAwarenessDistance, this.TsAwarenessHeight, this.TsPlayerGazeAngle, this.TsEnableDebugDraw);
		}
		else
		{
			instance2.StopGazeAwarenessCheckByEntityId(id);
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000B60 RID: 2912 RVA: 0x00039AD8 File Offset: 0x00037CD8
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSwitchGazeAwareness._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchGazeAwareness.TsTaskSwitchGazeAwareness_C");
		}
		return TsTaskSwitchGazeAwareness._ClassPtr;
	}

	// Token: 0x06000B61 RID: 2913 RVA: 0x00039AFC File Offset: 0x00037CFC
	public TsTaskSwitchGazeAwareness() : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchGazeAwareness.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B62 RID: 2914 RVA: 0x00039B24 File Offset: 0x00037D24
	[NullableContext(1)]
	public TsTaskSwitchGazeAwareness(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchGazeAwareness.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B63 RID: 2915 RVA: 0x00039B57 File Offset: 0x00037D57
	protected TsTaskSwitchGazeAwareness(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B64 RID: 2916 RVA: 0x00039B68 File Offset: 0x00037D68
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040008DA RID: 2266
	private bool IsInitTsVariables;

	// Token: 0x040008DB RID: 2267
	private bool TsIsEnable = true;

	// Token: 0x040008DC RID: 2268
	private float TsAwarenessAngle;

	// Token: 0x040008DD RID: 2269
	private float TsAwarenessDistance;

	// Token: 0x040008DE RID: 2270
	private float TsAwarenessHeight;

	// Token: 0x040008DF RID: 2271
	private float TsPlayerGazeAngle;

	// Token: 0x040008E0 RID: 2272
	private bool TsEnableDebugDraw;

	// Token: 0x040008E1 RID: 2273
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchGazeAwareness.TsTaskSwitchGazeAwareness_C";

	// Token: 0x040008E2 RID: 2274
	private static IntPtr _ClassPtr;

	// Token: 0x040008E3 RID: 2275
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008E4 RID: 2276
	private static int __PropertyOffset_IsEnable;

	// Token: 0x040008E5 RID: 2277
	private static int __PropertyOffset_AwarenessAngle;

	// Token: 0x040008E6 RID: 2278
	private static int __PropertyOffset_AwarenessDistance;

	// Token: 0x040008E7 RID: 2279
	private static int __PropertyOffset_AwarenessHeight;

	// Token: 0x040008E8 RID: 2280
	private static int __PropertyOffset_PlayerGazeAngle;

	// Token: 0x040008E9 RID: 2281
	private static int __PropertyOffset_EnableDebugDraw;
}
