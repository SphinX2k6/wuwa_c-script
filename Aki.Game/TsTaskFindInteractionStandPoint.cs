using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000099 RID: 153
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindInteractionStandPoint.TsTaskFindInteractionStandPoint_C")]
public class TsTaskFindInteractionStandPoint : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00026CA1 File Offset: 0x00024EA1
	// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00026CB1 File Offset: 0x00024EB1
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CheckObstacle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CheckObstacle) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CheckObstacle) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00026CC2 File Offset: 0x00024EC2
	// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00026CD2 File Offset: 0x00024ED2
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MaxHeightDiff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_MaxHeightDiff);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_MaxHeightDiff) = value;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00026CE3 File Offset: 0x00024EE3
	// (set) Token: 0x060007D5 RID: 2005 RVA: 0x00026CF3 File Offset: 0x00024EF3
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ObstacleHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_ObstacleHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_ObstacleHeight) = value;
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00026D04 File Offset: 0x00024F04
	// (set) Token: 0x060007D7 RID: 2007 RVA: 0x00026D14 File Offset: 0x00024F14
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float FloorDetectRange
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_FloorDetectRange);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_FloorDetectRange) = value;
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00026D25 File Offset: 0x00024F25
	// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00026D35 File Offset: 0x00024F35
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CheckHeightDiff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CheckHeightDiff) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CheckHeightDiff) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x060007DA RID: 2010 RVA: 0x00026D46 File Offset: 0x00024F46
	// (set) Token: 0x060007DB RID: 2011 RVA: 0x00026D56 File Offset: 0x00024F56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CapsuleRadiusScaleRate
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CapsuleRadiusScaleRate);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CapsuleRadiusScaleRate) = value;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x060007DC RID: 2012 RVA: 0x00026D67 File Offset: 0x00024F67
	// (set) Token: 0x060007DD RID: 2013 RVA: 0x00026D7B File Offset: 0x00024F7B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string StandPointKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_StandPointKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_StandPointKey)), value);
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x060007DE RID: 2014 RVA: 0x00026D90 File Offset: 0x00024F90
	// (set) Token: 0x060007DF RID: 2015 RVA: 0x00026DA4 File Offset: 0x00024FA4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe string InteractionEntityKey
	{
		get
		{
			return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_InteractionEntityKey)));
		}
		set
		{
			FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_InteractionEntityKey)), value);
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00026DB9 File Offset: 0x00024FB9
	// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00026DC9 File Offset: 0x00024FC9
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugDraw
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_DebugDraw) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00026DDA File Offset: 0x00024FDA
	// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00026DEA File Offset: 0x00024FEA
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool CanStandFarther
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CanStandFarther) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFindInteractionStandPoint.__PropertyOffset_CanStandFarther) = (value ? 1 : 0);
		}
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00026DFC File Offset: 0x00024FFC
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsCheckObstacle = this.CheckObstacle;
			this.TsMaxHeightDiff = this.MaxHeightDiff;
			this.TsObstacleHeight = this.ObstacleHeight;
			this.TsFloorDetectRange = this.FloorDetectRange;
			this.TsCheckHeightDiff = this.CheckHeightDiff;
			this.TsCapsuleRadiusScaleRate = this.CapsuleRadiusScaleRate;
			this.TsDebugDraw = this.DebugDraw;
			this.TsStandPointKey = this.StandPointKey;
			this.TsInteractionEntityKey = this.InteractionEntityKey;
			this.TsCanStandFarther = this.CanStandFarther;
			this.Element = new UTraceSphereElement();
		}
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00026EA8 File Offset: 0x000250A8
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

	// Token: 0x060007E6 RID: 2022 RVA: 0x00026F44 File Offset: 0x00025144
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
		Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.FloorLocation : null);
		}
		Vector vector2 = vector;
		if (vector2 == null)
		{
			base.Finish(false);
			return;
		}
		this.PlayerPos.DeepCopy(vector2);
		if (!this.ResolveNpcAndWriteBlackboard(id))
		{
			base.Finish(false);
			return;
		}
		this.ComputeStandPoint(charActorComp);
		if (this.TsCheckObstacle && !this.PickStandPointWithObstacle(charActorComp))
		{
			base.Finish(false);
			return;
		}
		if (!this.TsCheckObstacle)
		{
			GravityUtils.Instance.AddZnInGravityForActor(charActorComp, this.TargetPos, (double)charActorComp.ScaledHalfHeight);
		}
		if (this.TsDebugDraw)
		{
			this.DrawDebugPoints(charActorComp);
		}
		if (this.TsStandPointKey != "")
		{
			BlackboardController.Instance.SetVectorValueByEntity(id, this.TsStandPointKey, (double)((float)this.TargetPos.X), (double)((float)this.TargetPos.Y), (double)((float)this.TargetPos.Z));
		}
		base.Finish(true);
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00027078 File Offset: 0x00025278
	private void DrawDebugPoints(CharacterActorComponent character)
	{
		UWorld world = GlobalData.World;
		float num = 30f;
		int segments = 12;
		float duration = 12f;
		UKismetSystemLibrary.D_DrawDebugSphere(world, this.PlayerPos.ToUeVector(false), num, segments, new FLinearColor?(ColorUtils.LinearYellow), duration, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(world, this.NpcPos.ToUeVector(false), num, segments, new FLinearColor?(ColorUtils.LinearYellow), duration, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(world, this.Candidate.ToUeVector(false), num, segments, new FLinearColor?(ColorUtils.LinearGreen), duration, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(world, this.TargetPos.ToUeVector(false), num * 1.2f, segments, new FLinearColor?(ColorUtils.LinearWhite), duration, 0f);
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00027130 File Offset: 0x00025330
	private bool ResolveNpcAndWriteBlackboard(int ownerEntityId)
	{
		int? currentInteractEntityId = InteractionModel.Instance.CurrentInteractEntityId;
		Entity entity = (currentInteractEntityId != null) ? EntitySystem.Instance.Get(currentInteractEntityId.Value) : null;
		if (entity != null && entity.Valid)
		{
			this.NpcPos.DeepCopy(AiControllerLibrary.GetLocationFromEntity(entity));
			if (this.TsInteractionEntityKey != "")
			{
				BlackboardController.Instance.SetEntityIdByEntity(ownerEntityId, this.TsInteractionEntityKey, currentInteractEntityId.Value);
			}
			return true;
		}
		Vector interactPoint = FlowController.Instance.GetInteractPoint();
		if (interactPoint == null)
		{
			return false;
		}
		this.NpcPos.DeepCopy(interactPoint);
		if (this.TsInteractionEntityKey != "")
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			int? num;
			if (baseCharacter == null)
			{
				num = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				if (characterActorComponent == null)
				{
					num = null;
				}
				else
				{
					Entity entity2 = characterActorComponent.Entity;
					num = ((entity2 != null) ? new int?(entity2.Id) : null);
				}
			}
			int? num2 = num;
			if (num2 != null)
			{
				BlackboardController.Instance.SetEntityIdByEntity(ownerEntityId, this.TsInteractionEntityKey, num2.Value);
			}
		}
		return true;
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x00027248 File Offset: 0x00025448
	private void ComputeStandPoint(CharacterActorComponent character)
	{
		this.NpcPos.Subtraction(this.PlayerPos, this.BaseVec);
		this.BaseVec.Z = 0.0;
		double num = this.BaseVec.Size2D();
		if (num < 1.0)
		{
			this.MidPoint.DeepCopy(this.PlayerPos);
			this.Perp.Set(this.BaseVec.Y, -this.BaseVec.X, 0.0);
			if (!this.Perp.Normalize(9.99999993922529E-09))
			{
				this.Perp.Set(1.0, 0.0, 0.0);
			}
			this.height = (double)character.ScaledRadius;
			this.Perp.Multiply(this.height, this.ScaledPerp);
			this.MidPoint.Addition(this.ScaledPerp, this.Candidate);
			this.Candidate.Z = this.PlayerPos.Z;
			this.TargetPos.DeepCopy(this.Candidate);
			return;
		}
		this.PlayerPos.Addition(this.NpcPos, this.MidPoint);
		this.MidPoint.DivisionEqual(2.0);
		this.Perp.Set(this.BaseVec.Y, -this.BaseVec.X, 0.0);
		this.Perp.Normalize(9.99999993922529E-09);
		this.height = 0.8660254 * num;
		this.Perp.Multiply(this.height, this.ScaledPerp);
		this.MidPoint.Addition(this.ScaledPerp, this.Candidate);
		this.Candidate.Z = this.PlayerPos.Z;
		this.TargetPos.DeepCopy(this.Candidate);
	}

	// Token: 0x060007EA RID: 2026 RVA: 0x00027450 File Offset: 0x00025650
	private void OffsetPoint(CharacterActorComponent character, int counter, Vector candidate)
	{
		bool flag = counter % 2 == 0;
		int num = counter / 2;
		double inB = (double)character.ScaledRadius * 0.25 * (double)num + this.height;
		this.Perp.Multiply(inB, this.ScaledPerp);
		if (flag)
		{
			this.MidPoint.Addition(this.ScaledPerp, candidate);
			return;
		}
		this.MidPoint.Subtraction(this.ScaledPerp, candidate);
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x000274C0 File Offset: 0x000256C0
	private bool PickStandPointWithObstacle(CharacterActorComponent character)
	{
		UTraceSphereElement element = this.Element;
		AiLibrary.SetupStandPointTraceElement(element, character, character.ScaledRadius * this.TsCapsuleRadiusScaleRate, this.TsDebugDraw);
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Vector vector;
		if (baseCharacter == null)
		{
			vector = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			vector = ((characterActorComponent != null) ? characterActorComponent.FloorLocation : null);
		}
		Vector vector2 = vector;
		double playerFloorZ = (vector2 != null) ? vector2.Z : this.PlayerPos.Z;
		int num = this.TsCanStandFarther ? 9 : 1;
		for (int i = 0; i <= num; i++)
		{
			this.OffsetPoint(character, i, this.Candidate);
			if (AiLibrary.TryValidateStandPoint(character, element, this.Candidate, this.TargetPos, playerFloorZ, this.TsFloorDetectRange, this.TsObstacleHeight, this.TsMaxHeightDiff, this.TsCheckHeightDiff, this.TsDebugDraw, "TsTaskFindInteractionStandPoint", this.TraceHitLocation, this.TmpStart, this.TmpEnd))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060007EC RID: 2028 RVA: 0x0002759E File Offset: 0x0002579E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFindInteractionStandPoint._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindInteractionStandPoint.TsTaskFindInteractionStandPoint_C");
		}
		return TsTaskFindInteractionStandPoint._ClassPtr;
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x000275C4 File Offset: 0x000257C4
	public TsTaskFindInteractionStandPoint() : this(BuiltinUtils.AllocNativeUObject(TsTaskFindInteractionStandPoint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060007EE RID: 2030 RVA: 0x000275EC File Offset: 0x000257EC
	public TsTaskFindInteractionStandPoint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFindInteractionStandPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060007EF RID: 2031 RVA: 0x00027620 File Offset: 0x00025820
	protected TsTaskFindInteractionStandPoint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060007F0 RID: 2032 RVA: 0x000276C4 File Offset: 0x000258C4
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x040005B7 RID: 1463
	private const double HALF_SQRT3 = 0.8660254;

	// Token: 0x040005B8 RID: 1464
	private const double DEGENERATE_SIDE = 1.0;

	// Token: 0x040005B9 RID: 1465
	private const string PROFILE_KEY = "TsTaskFindInteractionStandPoint";

	// Token: 0x040005BA RID: 1466
	private bool IsInitTsVariables;

	// Token: 0x040005BB RID: 1467
	private bool TsCheckObstacle;

	// Token: 0x040005BC RID: 1468
	private float TsMaxHeightDiff;

	// Token: 0x040005BD RID: 1469
	private float TsObstacleHeight;

	// Token: 0x040005BE RID: 1470
	private float TsFloorDetectRange;

	// Token: 0x040005BF RID: 1471
	private bool TsCheckHeightDiff;

	// Token: 0x040005C0 RID: 1472
	private float TsCapsuleRadiusScaleRate;

	// Token: 0x040005C1 RID: 1473
	private bool TsDebugDraw;

	// Token: 0x040005C2 RID: 1474
	private bool TsCanStandFarther;

	// Token: 0x040005C3 RID: 1475
	private string TsStandPointKey = "";

	// Token: 0x040005C4 RID: 1476
	private string TsInteractionEntityKey = "";

	// Token: 0x040005C5 RID: 1477
	private readonly Vector PlayerPos = Vector.Create();

	// Token: 0x040005C6 RID: 1478
	private readonly Vector NpcPos = Vector.Create();

	// Token: 0x040005C7 RID: 1479
	private readonly Vector BaseVec = Vector.Create();

	// Token: 0x040005C8 RID: 1480
	private readonly Vector MidPoint = Vector.Create();

	// Token: 0x040005C9 RID: 1481
	private readonly Vector Perp = Vector.Create();

	// Token: 0x040005CA RID: 1482
	private readonly Vector ScaledPerp = Vector.Create();

	// Token: 0x040005CB RID: 1483
	private readonly Vector Candidate = Vector.Create();

	// Token: 0x040005CC RID: 1484
	private readonly Vector TargetPos = Vector.Create();

	// Token: 0x040005CD RID: 1485
	[Nullable(2)]
	private UTraceSphereElement Element;

	// Token: 0x040005CE RID: 1486
	private readonly Vector TraceHitLocation = Vector.Create();

	// Token: 0x040005CF RID: 1487
	private readonly Vector TmpStart = Vector.Create();

	// Token: 0x040005D0 RID: 1488
	private readonly Vector TmpEnd = Vector.Create();

	// Token: 0x040005D1 RID: 1489
	private double height;

	// Token: 0x040005D2 RID: 1490
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFindInteractionStandPoint.TsTaskFindInteractionStandPoint_C";

	// Token: 0x040005D3 RID: 1491
	private static IntPtr _ClassPtr;

	// Token: 0x040005D4 RID: 1492
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040005D5 RID: 1493
	private static int __PropertyOffset_CheckObstacle;

	// Token: 0x040005D6 RID: 1494
	private static int __PropertyOffset_MaxHeightDiff;

	// Token: 0x040005D7 RID: 1495
	private static int __PropertyOffset_ObstacleHeight;

	// Token: 0x040005D8 RID: 1496
	private static int __PropertyOffset_FloorDetectRange;

	// Token: 0x040005D9 RID: 1497
	private static int __PropertyOffset_CheckHeightDiff;

	// Token: 0x040005DA RID: 1498
	private static int __PropertyOffset_CapsuleRadiusScaleRate;

	// Token: 0x040005DB RID: 1499
	private static int __PropertyOffset_StandPointKey;

	// Token: 0x040005DC RID: 1500
	private static int __PropertyOffset_InteractionEntityKey;

	// Token: 0x040005DD RID: 1501
	private static int __PropertyOffset_DebugDraw;

	// Token: 0x040005DE RID: 1502
	private static int __PropertyOffset_CanStandFarther;
}
