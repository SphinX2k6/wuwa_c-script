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
	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000806 RID: 2054 RVA: 0x00028B19 File Offset: 0x00026D19
	// (set) Token: 0x06000807 RID: 2055 RVA: 0x00028B29 File Offset: 0x00026D29
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

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000808 RID: 2056 RVA: 0x00028B3A File Offset: 0x00026D3A
	// (set) Token: 0x06000809 RID: 2057 RVA: 0x00028B4A File Offset: 0x00026D4A
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

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x0600080A RID: 2058 RVA: 0x00028B5B File Offset: 0x00026D5B
	// (set) Token: 0x0600080B RID: 2059 RVA: 0x00028B6B File Offset: 0x00026D6B
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

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x0600080C RID: 2060 RVA: 0x00028B7C File Offset: 0x00026D7C
	// (set) Token: 0x0600080D RID: 2061 RVA: 0x00028B8C File Offset: 0x00026D8C
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

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x0600080E RID: 2062 RVA: 0x00028B9D File Offset: 0x00026D9D
	// (set) Token: 0x0600080F RID: 2063 RVA: 0x00028BAD File Offset: 0x00026DAD
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

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000810 RID: 2064 RVA: 0x00028BBE File Offset: 0x00026DBE
	// (set) Token: 0x06000811 RID: 2065 RVA: 0x00028BD2 File Offset: 0x00026DD2
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

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000812 RID: 2066 RVA: 0x00028BE7 File Offset: 0x00026DE7
	// (set) Token: 0x06000813 RID: 2067 RVA: 0x00028BF7 File Offset: 0x00026DF7
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

	// Token: 0x06000814 RID: 2068 RVA: 0x00028C08 File Offset: 0x00026E08
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

	// Token: 0x06000815 RID: 2069 RVA: 0x00028C8C File Offset: 0x00026E8C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFindPlayerAroundPoint) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFindPlayerAroundPoint.StaticClass(), out intPtr, out num))
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

	// Token: 0x06000816 RID: 2070 RVA: 0x00028D3C File Offset: 0x00026F3C
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

	// Token: 0x06000817 RID: 2071 RVA: 0x00028F77 File Offset: 0x00027177
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindPlayerAroundPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPlayerAroundPoint.TsTaskFindPlayerAroundPoint_C");
		}
		return TsTaskFindPlayerAroundPoint._ClassPtr;
	}

	// Token: 0x06000818 RID: 2072 RVA: 0x00028F9C File Offset: 0x0002719C
	public TsTaskFindPlayerAroundPoint() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindPlayerAroundPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000819 RID: 2073 RVA: 0x00028FC4 File Offset: 0x000271C4
	public TsTaskFindPlayerAroundPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindPlayerAroundPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0600081A RID: 2074 RVA: 0x00028FF8 File Offset: 0x000271F8
	protected TsTaskFindPlayerAroundPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0600081B RID: 2075 RVA: 0x00029070 File Offset: 0x00027270
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005F4 RID: 1524
	private const double CHECK_DIRECTION_ANGLE = 40.0;

	// Token: 0x040005F5 RID: 1525
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

	// Token: 0x040005F6 RID: 1526
	private const string PROFILE_KEY = "TsTaskFindPlayerAroundPoint";

	// Token: 0x040005F7 RID: 1527
	private bool IsInitTsVariables;

	// Token: 0x040005F8 RID: 1528
	private float TsFallbackSearchRadius;

	// Token: 0x040005F9 RID: 1529
	private float TsMaxHeightDiff;

	// Token: 0x040005FA RID: 1530
	private float TsObstacleHeight;

	// Token: 0x040005FB RID: 1531
	private float TsFloorDetectRange;

	// Token: 0x040005FC RID: 1532
	private bool TsCheckHeightDiff;

	// Token: 0x040005FD RID: 1533
	private bool TsDebugDraw;

	// Token: 0x040005FE RID: 1534
	private string TsStandPointKey = "";

	// Token: 0x040005FF RID: 1535
	private readonly Transform TransformCache = Transform.Create();

	// Token: 0x04000600 RID: 1536
	private readonly Vector Candidate = Vector.Create();

	// Token: 0x04000601 RID: 1537
	private readonly Vector Offset = Vector.Create();

	// Token: 0x04000602 RID: 1538
	private readonly Vector RotatedOffset = Vector.Create();

	// Token: 0x04000603 RID: 1539
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x04000604 RID: 1540
	[Nullable(2)]
	private UTraceSphereElement Element;

	// Token: 0x04000605 RID: 1541
	private readonly Vector FloorHit = Vector.Create();

	// Token: 0x04000606 RID: 1542
	private readonly Vector TmpStart = Vector.Create();

	// Token: 0x04000607 RID: 1543
	private readonly Vector TmpEnd = Vector.Create();

	// Token: 0x04000608 RID: 1544
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindPlayerAroundPoint.TsTaskFindPlayerAroundPoint_C";

	// Token: 0x04000609 RID: 1545
	private static IntPtr _ClassPtr;

	// Token: 0x0400060A RID: 1546
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400060B RID: 1547
	private static int __PropertyOffset_FallbackSearchRadius;

	// Token: 0x0400060C RID: 1548
	private static int __PropertyOffset_MaxHeightDiff;

	// Token: 0x0400060D RID: 1549
	private static int __PropertyOffset_ObstacleHeight;

	// Token: 0x0400060E RID: 1550
	private static int __PropertyOffset_FloorDetectRange;

	// Token: 0x0400060F RID: 1551
	private static int __PropertyOffset_CheckHeightDiff;

	// Token: 0x04000610 RID: 1552
	private static int __PropertyOffset_StandPointKey;

	// Token: 0x04000611 RID: 1553
	private static int __PropertyOffset_DebugDraw;
}
