using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x0200009B RID: 155
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPlayerAroundPoint.TsTaskFindPlayerAroundPoint_C")]
public class TsTaskFindPlayerAroundPoint : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000802 RID: 2050 RVA: 0x00027D19 File Offset: 0x00025F19
	// (set) Token: 0x06000803 RID: 2051 RVA: 0x00027D29 File Offset: 0x00025F29
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FallbackSearchRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_FallbackSearchRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_FallbackSearchRadius) = value;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000804 RID: 2052 RVA: 0x00027D3A File Offset: 0x00025F3A
	// (set) Token: 0x06000805 RID: 2053 RVA: 0x00027D4A File Offset: 0x00025F4A
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxHeightDiff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_MaxHeightDiff);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_MaxHeightDiff) = value;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000806 RID: 2054 RVA: 0x00027D5B File Offset: 0x00025F5B
	// (set) Token: 0x06000807 RID: 2055 RVA: 0x00027D6B File Offset: 0x00025F6B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ObstacleHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_ObstacleHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_ObstacleHeight) = value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000808 RID: 2056 RVA: 0x00027D7C File Offset: 0x00025F7C
	// (set) Token: 0x06000809 RID: 2057 RVA: 0x00027D8C File Offset: 0x00025F8C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FloorDetectRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_FloorDetectRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_FloorDetectRange) = value;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x0600080A RID: 2058 RVA: 0x00027D9D File Offset: 0x00025F9D
	// (set) Token: 0x0600080B RID: 2059 RVA: 0x00027DAD File Offset: 0x00025FAD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CheckHeightDiff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_CheckHeightDiff) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_CheckHeightDiff) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x0600080C RID: 2060 RVA: 0x00027DBE File Offset: 0x00025FBE
	// (set) Token: 0x0600080D RID: 2061 RVA: 0x00027DD2 File Offset: 0x00025FD2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StandPointKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_StandPointKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_StandPointKey)), value);
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x0600080E RID: 2062 RVA: 0x00027DE7 File Offset: 0x00025FE7
	// (set) Token: 0x0600080F RID: 2063 RVA: 0x00027DF7 File Offset: 0x00025FF7
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindPlayerAroundPoint.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000810 RID: 2064 RVA: 0x00027E08 File Offset: 0x00026008
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsFallbackSearchRadius = this.FallbackSearchRadius;
			this.TsMaxHeightDiff = this.MaxHeightDiff;
			this.TsObstacleHeight = this.ObstacleHeight;
			this.TsFloorDetectRange = this.FloorDetectRange;
			this.TsCheckHeightDiff = this.CheckHeightDiff;
			this.TsStandPointKey = this.StandPointKey;
			this.TsDebugDraw = this.DebugDraw;
			this.Element = new UTraceSphereElement();
		}
	}

	// Token: 0x06000811 RID: 2065 RVA: 0x00027E8C File Offset: 0x0002608C
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

	// Token: 0x06000812 RID: 2066 RVA: 0x00027F28 File Offset: 0x00026128
	[NullableContext(2)]
	protected void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		int id = aiController.CharAiDesignComp.Entity.Id;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null)
		{
			base.Finish(false);
			return;
		}
		Vector floorLocation = characterActorComponent.FloorLocation;
		if (floorLocation == null)
		{
			base.Finish(false);
			return;
		}
		double z = floorLocation.Z;
		UTraceSphereElement element = this.Element;
		AiLibrary.SetupStandPointTraceElement(element, charActorComp, charActorComp.ScaledRadius, this.TsDebugDraw);
		this.Offset.Set((double)(-(double)this.TsFallbackSearchRadius), 0.0, 0.0);
		Vector actorGravityDirectProxy = characterActorComponent.ActorGravityDirectProxy;
		Transform transformCache = this.TransformCache;
		FTransformDouble actorTransform = characterActorComponent.ActorTransform;
		transformCache.FromUeTransform(actorTransform);
		foreach (int num in TsTaskFindPlayerAroundPoint.CheckDirectionList)
		{
			double angleDeg = 40.0 * (double)num;
			this.Offset.RotateAngleAxis(angleDeg, actorGravityDirectProxy, this.RotatedOffset);
			this.TransformCache.TransformPosition(this.RotatedOffset, this.Candidate);
			GravityUtils.Instance.AddZnInGravityForActor(characterActorComponent, this.Candidate, (double)(-(double)characterActorComponent.ScaledHalfHeight));
			if (this.TsDebugDraw)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.Candidate.ToUeVector(false), 25f, 10, new FLinearColor?(ColorUtils.LinearGreen), 12f, 0f);
			}
			if (AiLibrary.TryValidateStandPoint(charActorComp, element, this.Candidate, this.TargetPos, z, this.TsFloorDetectRange, this.TsObstacleHeight, this.TsMaxHeightDiff, this.TsCheckHeightDiff, this.TsDebugDraw, "TsTaskFindPlayerAroundPoint", this.FloorHit, this.TmpStart, this.TmpEnd))
			{
				if (this.TsStandPointKey != "")
				{
					BlackboardController.Instance.SetVectorValueByEntity(id, this.TsStandPointKey, (double)((float)this.TargetPos.X), (double)((float)this.TargetPos.Y), (double)((float)this.TargetPos.Z));
				}
				base.Finish(true);
				return;
			}
		}
		base.Finish(false);
	}

	// Token: 0x06000813 RID: 2067 RVA: 0x00028163 File Offset: 0x00026363
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindPlayerAroundPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPlayerAroundPoint.TsTaskFindPlayerAroundPoint_C");
		}
		return TsTaskFindPlayerAroundPoint._ClassPtr;
	}

	// Token: 0x06000814 RID: 2068 RVA: 0x00028188 File Offset: 0x00026388
	public TsTaskFindPlayerAroundPoint() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindPlayerAroundPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000815 RID: 2069 RVA: 0x000281B0 File Offset: 0x000263B0
	public TsTaskFindPlayerAroundPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindPlayerAroundPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000816 RID: 2070 RVA: 0x000281E4 File Offset: 0x000263E4
	protected TsTaskFindPlayerAroundPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0002825C File Offset: 0x0002645C
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005F0 RID: 1520
	private const double CHECK_DIRECTION_ANGLE = 40.0;

	// Token: 0x040005F1 RID: 1521
	[StaticVariableRuleIgnore]
	private static readonly int[] CheckDirectionList = new int[]
	{
		0,
		1,
		-1,
		2,
		-2,
		3,
		-3,
		4,
		-4
	};

	// Token: 0x040005F2 RID: 1522
	private const string PROFILE_KEY = "TsTaskFindPlayerAroundPoint";

	// Token: 0x040005F3 RID: 1523
	private bool IsInitTsVariables;

	// Token: 0x040005F4 RID: 1524
	private float TsFallbackSearchRadius;

	// Token: 0x040005F5 RID: 1525
	private float TsMaxHeightDiff;

	// Token: 0x040005F6 RID: 1526
	private float TsObstacleHeight;

	// Token: 0x040005F7 RID: 1527
	private float TsFloorDetectRange;

	// Token: 0x040005F8 RID: 1528
	private bool TsCheckHeightDiff;

	// Token: 0x040005F9 RID: 1529
	private bool TsDebugDraw;

	// Token: 0x040005FA RID: 1530
	private string TsStandPointKey = "";

	// Token: 0x040005FB RID: 1531
	private readonly Transform TransformCache = Transform.Create();

	// Token: 0x040005FC RID: 1532
	private readonly Vector Candidate = Vector.Create();

	// Token: 0x040005FD RID: 1533
	private readonly Vector Offset = Vector.Create();

	// Token: 0x040005FE RID: 1534
	private readonly Vector RotatedOffset = Vector.Create();

	// Token: 0x040005FF RID: 1535
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x04000600 RID: 1536
	[Nullable(2)]
	private UTraceSphereElement Element;

	// Token: 0x04000601 RID: 1537
	private readonly Vector FloorHit = Vector.Create();

	// Token: 0x04000602 RID: 1538
	private readonly Vector TmpStart = Vector.Create();

	// Token: 0x04000603 RID: 1539
	private readonly Vector TmpEnd = Vector.Create();

	// Token: 0x04000604 RID: 1540
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPlayerAroundPoint.TsTaskFindPlayerAroundPoint_C";

	// Token: 0x04000605 RID: 1541
	private static IntPtr _ClassPtr;

	// Token: 0x04000606 RID: 1542
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x04000607 RID: 1543
	private static int __PropertyOffset_FallbackSearchRadius;

	// Token: 0x04000608 RID: 1544
	private static int __PropertyOffset_MaxHeightDiff;

	// Token: 0x04000609 RID: 1545
	private static int __PropertyOffset_ObstacleHeight;

	// Token: 0x0400060A RID: 1546
	private static int __PropertyOffset_FloorDetectRange;

	// Token: 0x0400060B RID: 1547
	private static int __PropertyOffset_CheckHeightDiff;

	// Token: 0x0400060C RID: 1548
	private static int __PropertyOffset_StandPointKey;

	// Token: 0x0400060D RID: 1549
	private static int __PropertyOffset_DebugDraw;
}
