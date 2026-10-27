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
	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00038623 File Offset: 0x00036823
	// (set) Token: 0x06000B4C RID: 2892 RVA: 0x00038633 File Offset: 0x00036833
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

	// Token: 0x17000210 RID: 528
	// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00038644 File Offset: 0x00036844
	// (set) Token: 0x06000B4E RID: 2894 RVA: 0x00038654 File Offset: 0x00036854
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

	// Token: 0x17000211 RID: 529
	// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00038665 File Offset: 0x00036865
	// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00038675 File Offset: 0x00036875
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

	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00038686 File Offset: 0x00036886
	// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00038696 File Offset: 0x00036896
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

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000386A7 File Offset: 0x000368A7
	// (set) Token: 0x06000B54 RID: 2900 RVA: 0x000386B7 File Offset: 0x000368B7
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

	// Token: 0x17000214 RID: 532
	// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000386C8 File Offset: 0x000368C8
	// (set) Token: 0x06000B56 RID: 2902 RVA: 0x000386D8 File Offset: 0x000368D8
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

	// Token: 0x06000B57 RID: 2903 RVA: 0x000386EC File Offset: 0x000368EC
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

	// Token: 0x06000B58 RID: 2904 RVA: 0x00038758 File Offset: 0x00036958
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

	// Token: 0x06000B59 RID: 2905 RVA: 0x000387F4 File Offset: 0x000369F4
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

	// Token: 0x06000B5A RID: 2906 RVA: 0x000388D4 File Offset: 0x00036AD4
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSwitchGazeAwareness._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchGazeAwareness.TsTaskSwitchGazeAwareness_C");
		}
		return TsTaskSwitchGazeAwareness._ClassPtr;
	}

	// Token: 0x06000B5B RID: 2907 RVA: 0x000388F8 File Offset: 0x00036AF8
	public TsTaskSwitchGazeAwareness() : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchGazeAwareness.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00038920 File Offset: 0x00036B20
	[NullableContext(1)]
	public TsTaskSwitchGazeAwareness(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSwitchGazeAwareness.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00038953 File Offset: 0x00036B53
	protected TsTaskSwitchGazeAwareness(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B5E RID: 2910 RVA: 0x00038964 File Offset: 0x00036B64
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040008D2 RID: 2258
	private bool IsInitTsVariables;

	// Token: 0x040008D3 RID: 2259
	private bool TsIsEnable = true;

	// Token: 0x040008D4 RID: 2260
	private float TsAwarenessAngle;

	// Token: 0x040008D5 RID: 2261
	private float TsAwarenessDistance;

	// Token: 0x040008D6 RID: 2262
	private float TsAwarenessHeight;

	// Token: 0x040008D7 RID: 2263
	private float TsPlayerGazeAngle;

	// Token: 0x040008D8 RID: 2264
	private bool TsEnableDebugDraw;

	// Token: 0x040008D9 RID: 2265
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSwitchGazeAwareness.TsTaskSwitchGazeAwareness_C";

	// Token: 0x040008DA RID: 2266
	private static IntPtr _ClassPtr;

	// Token: 0x040008DB RID: 2267
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008DC RID: 2268
	private static int __PropertyOffset_IsEnable;

	// Token: 0x040008DD RID: 2269
	private static int __PropertyOffset_AwarenessAngle;

	// Token: 0x040008DE RID: 2270
	private static int __PropertyOffset_AwarenessDistance;

	// Token: 0x040008DF RID: 2271
	private static int __PropertyOffset_AwarenessHeight;

	// Token: 0x040008E0 RID: 2272
	private static int __PropertyOffset_PlayerGazeAngle;

	// Token: 0x040008E1 RID: 2273
	private static int __PropertyOffset_EnableDebugDraw;
}
