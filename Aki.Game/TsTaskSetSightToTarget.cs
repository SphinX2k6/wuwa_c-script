using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BD RID: 189
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetSightToTarget.TsTaskSetSightToTarget_C")]
public class TsTaskSetSightToTarget : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0003600B File Offset: 0x0003420B
	// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x0003601F File Offset: 0x0003421F
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string TargetBlackboardKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetSightToTarget.__PropertyOffset_TargetBlackboardKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetSightToTarget.__PropertyOffset_TargetBlackboardKey)), value);
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00036034 File Offset: 0x00034234
	// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x00036048 File Offset: 0x00034248
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string BoneName
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetSightToTarget.__PropertyOffset_BoneName)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskSetSightToTarget.__PropertyOffset_BoneName)), value);
		}
	}

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0003605D File Offset: 0x0003425D
	// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x0003606D File Offset: 0x0003426D
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool EnableDebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSetSightToTarget.__PropertyOffset_EnableDebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSetSightToTarget.__PropertyOffset_EnableDebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000AE9 RID: 2793 RVA: 0x0003607E File Offset: 0x0003427E
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsTargetBlackboardKey = this.TargetBlackboardKey;
			this.TsBoneName = FNameUtil.GetDynamicFName(this.BoneName);
		}
	}

	// Token: 0x06000AEA RID: 2794 RVA: 0x000360B4 File Offset: 0x000342B4
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

	// Token: 0x06000AEB RID: 2795 RVA: 0x00036150 File Offset: 0x00034350
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
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
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		if (charActorComp == null || !charActorComp.Valid)
		{
			base.FinishExecute(false);
			return;
		}
		int id = charActorComp.Entity.Id;
		if (string.IsNullOrEmpty(this.TsTargetBlackboardKey))
		{
			Log.Instance.Error(ELogModule.BehaviorTree, ELogAuthor.ZJL, "TsTaskSetSightToTarget 未配置目标黑板键", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.FinishExecute(false);
			return;
		}
		CharacterAnimationComponent component = charActorComp.Entity.GetComponent<CharacterAnimationComponent>();
		if (component == null || !component.Valid)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.BehaviorTree;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "TsTaskSetSightToTarget 拿不到AnimationComponent";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", id);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			base.FinishExecute(false);
			return;
		}
		if (!component.EnableSightDirect)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.BehaviorTree;
			ELogAuthor author3 = ELogAuthor.ZJL;
			string message3 = "TsTaskSetSightToTarget 没有开启视线驱动";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", id);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			base.FinishExecute(false);
			return;
		}
		int? intValueByEntity = BlackboardController.Instance.GetIntValueByEntity(id, this.TsTargetBlackboardKey);
		BaseActorComponent baseActorComponent;
		if (intValueByEntity != null)
		{
			int? num = intValueByEntity;
			int num2 = 0;
			if (num.GetValueOrDefault() >= num2 & num != null)
			{
				baseActorComponent = EntitySystem.Instance.GetComponent<BaseActorComponent>(intValueByEntity.Value);
				goto IL_193;
			}
		}
		baseActorComponent = null;
		IL_193:
		BaseActorComponent baseActorComponent2 = baseActorComponent;
		if (baseActorComponent2 != null && baseActorComponent2.Valid)
		{
			component.SetSightTargetItem(baseActorComponent2);
		}
		else
		{
			Vector inB = (this.TsBoneName != null) ? component.GetBoneWorldLocation(this.TsBoneName.Value, this.TmpBoneLocation) : charActorComp.ActorLocationProxy;
			component.GetWorldDefaultSightDirect(this.SightForwardPoint);
			this.SightForwardPoint.MultiplyEqual(10000.0);
			this.SightForwardPoint.AdditionEqual(inB);
			component.SetSightTargetPoint(this.SightForwardPoint);
		}
		if (this.EnableDebugDraw)
		{
			Vector vector = (this.TsBoneName != null) ? component.GetBoneWorldLocation(this.TsBoneName.Value, this.TmpBoneLocation) : charActorComp.ActorLocationProxy;
			Vector worldSightDirect = component.GetWorldSightDirect(this.TmpSightDir);
			this.TmpArrowEnd.DeepCopy(worldSightDirect);
			this.TmpArrowEnd.MultiplyEqual(500.0);
			this.TmpArrowEnd.AdditionEqual(vector);
			UKismetSystemLibrary.D_DrawDebugArrow(this, vector.ToUeVector(false), this.TmpArrowEnd.ToUeVector(false), 100f, TsTaskSetSightToTarget.currentDirColor, 1f, 2f);
			if (baseActorComponent2 != null && baseActorComponent2.Valid)
			{
				this.TmpTargetDir.DeepCopy(baseActorComponent2.ActorLocationProxy);
				this.TmpTargetDir.SubtractionEqual(vector);
				this.TmpTargetDir.Normalize(9.99999993922529E-09);
			}
			else
			{
				component.GetWorldDefaultSightDirect(this.TmpTargetDir);
			}
			this.TmpArrowEnd.DeepCopy(this.TmpTargetDir);
			this.TmpArrowEnd.MultiplyEqual(500.0);
			this.TmpArrowEnd.AdditionEqual(vector);
			UKismetSystemLibrary.D_DrawDebugArrow(this, vector.ToUeVector(false), this.TmpArrowEnd.ToUeVector(false), 100f, TsTaskSetSightToTarget.targetDirColor, 1f, 2f);
		}
		base.FinishExecute(true);
	}

	// Token: 0x06000AEC RID: 2796 RVA: 0x000364D2 File Offset: 0x000346D2
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSetSightToTarget._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetSightToTarget.TsTaskSetSightToTarget_C");
		}
		return TsTaskSetSightToTarget._ClassPtr;
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x000364F8 File Offset: 0x000346F8
	public TsTaskSetSightToTarget() : this(BuiltinUtils.AllocNativeUObject(TsTaskSetSightToTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x00036520 File Offset: 0x00034720
	public TsTaskSetSightToTarget(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSetSightToTarget.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x00036554 File Offset: 0x00034754
	protected TsTaskSetSightToTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x000365AC File Offset: 0x000347AC
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0400087B RID: 2171
	private const float FORWARD_TARGET_DISTANCE = 10000f;

	// Token: 0x0400087C RID: 2172
	private const float SIGHT_DEBUG_LENGTH = 500f;

	// Token: 0x0400087D RID: 2173
	private const float SIGHT_DEBUG_ARROW_SIZE = 100f;

	// Token: 0x0400087E RID: 2174
	private const float SIGHT_DEBUG_DURATION = 1f;

	// Token: 0x0400087F RID: 2175
	private const float SIGHT_DEBUG_THICKNESS = 2f;

	// Token: 0x04000880 RID: 2176
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor currentDirColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x04000881 RID: 2177
	[StaticVariableRuleIgnore]
	private static readonly FLinearColor targetDirColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x04000882 RID: 2178
	private bool IsInitTsVariables;

	// Token: 0x04000883 RID: 2179
	private string TsTargetBlackboardKey = "";

	// Token: 0x04000884 RID: 2180
	private FName? TsBoneName;

	// Token: 0x04000885 RID: 2181
	private readonly Vector TmpBoneLocation = Vector.Create();

	// Token: 0x04000886 RID: 2182
	private readonly Vector SightForwardPoint = Vector.Create();

	// Token: 0x04000887 RID: 2183
	private readonly Vector TmpSightDir = Vector.Create();

	// Token: 0x04000888 RID: 2184
	private readonly Vector TmpTargetDir = Vector.Create();

	// Token: 0x04000889 RID: 2185
	private readonly Vector TmpArrowEnd = Vector.Create();

	// Token: 0x0400088A RID: 2186
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSetSightToTarget.TsTaskSetSightToTarget_C";

	// Token: 0x0400088B RID: 2187
	private static IntPtr _ClassPtr;

	// Token: 0x0400088C RID: 2188
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400088D RID: 2189
	private static int __PropertyOffset_TargetBlackboardKey;

	// Token: 0x0400088E RID: 2190
	private static int __PropertyOffset_BoneName;

	// Token: 0x0400088F RID: 2191
	private static int __PropertyOffset_EnableDebugDraw;
}
