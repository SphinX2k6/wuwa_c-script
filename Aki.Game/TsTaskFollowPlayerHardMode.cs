using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000A0 RID: 160
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowPlayerHardMode.TsTaskFollowPlayerHardMode_C")]
public class TsTaskFollowPlayerHardMode : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x1700016A RID: 362
	// (get) Token: 0x0600086C RID: 2156 RVA: 0x0002AADB File Offset: 0x00028CDB
	// (set) Token: 0x0600086D RID: 2157 RVA: 0x0002AAEB File Offset: 0x00028CEB
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float MoveSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_MoveSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_MoveSpeed) = value;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x0600086E RID: 2158 RVA: 0x0002AAFC File Offset: 0x00028CFC
	// (set) Token: 0x0600086F RID: 2159 RVA: 0x0002AB0C File Offset: 0x00028D0C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float RotateSpeed
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_RotateSpeed);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_RotateSpeed) = value;
		}
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000870 RID: 2160 RVA: 0x0002AB1D File Offset: 0x00028D1D
	// (set) Token: 0x06000871 RID: 2161 RVA: 0x0002AB31 File Offset: 0x00028D31
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe FVector LocationOffset
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_LocationOffset);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_LocationOffset) = value;
		}
	}

	// Token: 0x1700016D RID: 365
	// (get) Token: 0x06000872 RID: 2162 RVA: 0x0002AB46 File Offset: 0x00028D46
	// (set) Token: 0x06000873 RID: 2163 RVA: 0x0002AB56 File Offset: 0x00028D56
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float ForceMoveDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_ForceMoveDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_ForceMoveDistance) = value;
		}
	}

	// Token: 0x1700016E RID: 366
	// (get) Token: 0x06000874 RID: 2164 RVA: 0x0002AB67 File Offset: 0x00028D67
	// (set) Token: 0x06000875 RID: 2165 RVA: 0x0002AB77 File Offset: 0x00028D77
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool LookAtTarget
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_LookAtTarget) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_LookAtTarget) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000876 RID: 2166 RVA: 0x0002AB88 File Offset: 0x00028D88
	// (set) Token: 0x06000877 RID: 2167 RVA: 0x0002AB98 File Offset: 0x00028D98
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float DetectTargetDistance
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_DetectTargetDistance);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_DetectTargetDistance) = value;
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002ABAC File Offset: 0x00028DAC
	// (set) Token: 0x06000879 RID: 2169 RVA: 0x0002ABE5 File Offset: 0x00028DE5
	[Nullable(new byte[]
	{
		1,
		0
	})]
	[UProperty(EPropertyFlags.CPF_None)]
	public TArray<TEnumAsByte<EObjectTypeQuery>> DetectTargetTypes
	{
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		get
		{
			base.FastCheckIsValid();
			TArray<TEnumAsByte<EObjectTypeQuery>> result;
			if ((result = this._DetectTargetTypes) == null)
			{
				result = (this._DetectTargetTypes = new TArray<TEnumAsByte<EObjectTypeQuery>>(base.NativePtr + (IntPtr)TsTaskFollowPlayerHardMode.__PropertyOffset_DetectTargetTypes, this));
			}
			return result;
		}
		[param: Nullable(new byte[]
		{
			1,
			0
		})]
		set
		{
			this.DetectTargetTypes.CopyAssign(value);
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x0002ABF4 File Offset: 0x00028DF4
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsMoveSpeed = this.MoveSpeed;
			this.TsRotateSpeed = this.RotateSpeed;
			this.TsForceMoveDistance = this.ForceMoveDistance;
			this.TsLookAtTarget = this.LookAtTarget;
			this.TsDetectTargetDistance = this.DetectTargetDistance;
			this.RotateOffset = Rotator.Create();
			this.TempRotator = Rotator.Create();
			this.TsLocationOffset = Vector.Create();
			this.TempTargetLocation = Vector.Create();
			this.TempTargetForward = Vector.Create();
			this.TempMoveVector = Vector.Create();
			this.TempVector = Vector.Create();
			FVector locationOffset = this.LocationOffset;
			Vector tsLocationOffset = this.TsLocationOffset;
			FVector locationOffset2 = this.LocationOffset;
			tsLocationOffset.FromUeVector(locationOffset2);
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x0002ACC0 File Offset: 0x00028EC0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFollowPlayerHardMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveExecuteAI"), TsTaskFollowPlayerHardMode.StaticClass(), out intPtr, out num))
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

	// Token: 0x0600087C RID: 2172 RVA: 0x0002AD70 File Offset: 0x00028F70
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LYY;
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
		this.InitTsVariables();
		Entity entity = charActorComp.Entity;
		this.MoveComp = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
		CharacterActorComponent charActorComp2 = aiController.CharActorComp;
		if (charActorComp2 != null)
		{
			charActorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Flying,
				Context = "[TsTaskFollowPlayerHardMode.ReceiveExecuteAI]"
			});
		}
		this.UpdateRotateOffsetTime = 0f;
		this.RotateOffset.Reset();
		if (this.TraceElement == null)
		{
			this.TraceElement = new UTraceCapsuleElement();
			this.TraceElement.bIsSingle = true;
			this.TraceElement.bIgnoreSelf = true;
			this.TraceElement.WorldContextObject = charActorComp.Owner;
			this.TraceElement.HalfHeight = charActorComp.DefaultHalfHeight;
			this.TraceElement.Radius = charActorComp.DefaultRadius;
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
			this.TraceElement.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStaticIgnoreBullet);
		}
		if (this.TsLookAtTarget && this.LineElement == null && this.DetectTargetTypes != null && this.DetectTargetTypes.Num() > 0)
		{
			this.LineElement = new UTraceLineElement();
			this.LineElement.bIsSingle = true;
			this.LineElement.bIgnoreSelf = true;
			this.LineElement.WorldContextObject = charActorComp.Owner;
			for (int i = 0; i < this.DetectTargetTypes.Num(); i++)
			{
				this.LineElement.AddObjectTypeQuery(this.DetectTargetTypes.Get(i));
			}
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x0002AF68 File Offset: 0x00029168
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsTaskFollowPlayerHardMode) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("ReceiveTickAI"), TsTaskFollowPlayerHardMode.StaticClass(), out intPtr, out num))
		{
			this.ReceiveTickAI_Implementation(ownerController, controlledPawn, deltaSeconds);
			return;
		}
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr = stackalloc UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		*(&ptr->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
		*(&ptr->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
		ptr->DeltaSeconds = deltaSeconds;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x0002B020 File Offset: 0x00029220
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.BehaviorTree;
			ELogAuthor author = ELogAuthor.LYY;
			string message = "错误的Controller类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", ownerController.GetClass().GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			base.FinishExecute(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		CharacterActorComponent characterActorComponent = (baseCharacter != null) ? baseCharacter.CharacterActorComponent : null;
		if (characterActorComponent == null || !characterActorComponent.Valid || (charActorComp == null || !charActorComp.Valid))
		{
			base.FinishExecute(false);
			return;
		}
		if (this.MoveComp != null && this.MoveComp.CharacterMovement.MovementMode != EMovementMode.MOVE_Flying)
		{
			charActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Flying,
				Context = "[TsTaskFollowPlayerHardMode.ReceiveTickAI]"
			});
		}
		float num = deltaSeconds * charActorComp.Actor.CustomTimeDilation;
		Vector actorLocationProxy = characterActorComponent.ActorLocationProxy;
		Vector actorLocationProxy2 = charActorComp.ActorLocationProxy;
		Vector actorUpProxy = characterActorComponent.ActorUpProxy;
		Rotator tempRotator = this.TempRotator;
		FRotator cameraRotation = Global.CharacterCameraManager.GetCameraRotation();
		tempRotator.FromUeRotator(cameraRotation);
		if (this.TsLookAtTarget)
		{
			this.UpdateRotateOffset(num, actorLocationProxy2);
		}
		this.TempRotator.AdditionEqual(this.RotateOffset);
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp != null)
		{
			moveComp.SmoothCharacterRotation(this.TempRotator.ToUeRotator(), this.TsRotateSpeed, num, false, "FollowPlayerHardMode", true);
		}
		this.TempTargetLocation.DeepCopy(actorLocationProxy);
		Vector tempTargetForward = this.TempTargetForward;
		FVector actorForwardVector = Global.CharacterCameraManager.GetActorForwardVector();
		tempTargetForward.FromUeVector(actorForwardVector);
		Vector.VectorPlaneProject(this.TempTargetForward, actorUpProxy, this.TempVector);
		this.TempTargetForward.DeepCopy(this.TempVector);
		this.TempTargetForward.Normalize(9.99999993922529E-09);
		this.TempTargetForward.Multiply(this.TsLocationOffset.X, this.TempVector);
		this.TempTargetLocation.AdditionEqual(this.TempVector);
		this.TempTargetForward.RotateAngleAxis(90.0, actorUpProxy, this.TempTargetForward);
		this.TempTargetForward.Multiply(this.TsLocationOffset.Y, this.TempVector);
		this.TempTargetLocation.AdditionEqual(this.TempVector);
		actorUpProxy.Multiply(this.TsLocationOffset.Z, this.TempVector);
		this.TempTargetLocation.AdditionEqual(this.TempVector);
		actorLocationProxy2.Subtraction(actorLocationProxy, this.TempVector);
		if (this.TempVector.SizeSquared() > (double)(this.TsForceMoveDistance * this.TsForceMoveDistance))
		{
			if (this.CheckObstacle(actorLocationProxy, this.TempTargetLocation))
			{
				charActorComp.SetActorLocation(actorLocationProxy.ToUeVector(false), "FollowPlayerHardMode", false);
				return;
			}
			charActorComp.SetActorLocation(this.TempTargetLocation.ToUeVector(false), "FollowPlayerHardMode", false);
			return;
		}
		else
		{
			this.TempTargetLocation.Subtraction(actorLocationProxy2, this.TempMoveVector);
			double num2 = this.TempMoveVector.SizeSquared();
			float num3 = this.TsMoveSpeed * num;
			if (num2 > (double)(num3 * num3))
			{
				this.TempMoveVector.Normalize(9.99999993922529E-09);
				this.TempMoveVector.MultiplyEqual((double)num3);
			}
			BaseMoveComponent moveComp2 = this.MoveComp;
			if (moveComp2 == null)
			{
				return;
			}
			moveComp2.MoveCharacter(this.TempMoveVector, 1f, "FollowPlayerHardMode");
			return;
		}
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x0002B380 File Offset: 0x00029580
	private bool CheckObstacle(Vector startLocation, Vector endLocation)
	{
		if (this.TraceElement == null)
		{
			return false;
		}
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, startLocation);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, endLocation);
		if (TraceElementCommon.Instance.CapsuleTrace(this.TraceElement, "FollowPlayerHardMode"))
		{
			UKuroHitResult hitResult = this.TraceElement.HitResult;
			return hitResult != null && hitResult.bBlockingHit;
		}
		return false;
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x0002B3E8 File Offset: 0x000295E8
	private void UpdateRotateOffset(float deltaSeconds, Vector selfLocation)
	{
		if (this.LineElement == null)
		{
			return;
		}
		this.UpdateRotateOffsetTime += deltaSeconds * 1000f;
		if (this.UpdateRotateOffsetTime < 200f)
		{
			return;
		}
		this.UpdateRotateOffsetTime = 0f;
		Vector tempVector = this.TempVector;
		FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetCameraLocation();
		tempVector.FromUeVector(fvectorDouble);
		Vector tempMoveVector = this.TempMoveVector;
		FVector actorForwardVector = Global.CharacterCameraManager.GetActorForwardVector();
		tempMoveVector.FromUeVector(actorForwardVector);
		this.TempMoveVector.MultiplyEqual((double)this.TsDetectTargetDistance);
		this.TempMoveVector.AdditionEqual(this.TempVector);
		TraceElementCommon.Instance.SetStartLocation(this.LineElement, this.TempVector);
		TraceElementCommon.Instance.SetEndLocation(this.LineElement, this.TempMoveVector);
		bool flag = TraceElementCommon.Instance.LineTrace(this.LineElement, "FollowPlayerHardMode DetectTarget");
		UKuroHitResult hitResult = this.LineElement.HitResult;
		if (flag && hitResult != null && hitResult.bBlockingHit)
		{
			TraceElementCommon.Instance.GetHitLocation(hitResult, 0, this.TempVector);
			Rotator rotateOffset = this.RotateOffset;
			fvectorDouble = selfLocation.ToUeVector(false);
			FVectorDouble fvectorDouble2 = this.TempVector.ToUeVector(false);
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble2);
			rotateOffset.FromUeRotator(frotator);
		}
		else
		{
			Rotator rotateOffset2 = this.RotateOffset;
			fvectorDouble = selfLocation.ToUeVector(false);
			FVectorDouble fvectorDouble2 = this.TempMoveVector.ToUeVector(false);
			FRotator frotator = UKismetMathLibrary.D_FindLookAtRotation(fvectorDouble, fvectorDouble2);
			rotateOffset2.FromUeRotator(frotator);
		}
		this.RotateOffset.SubtractionEqual(this.TempRotator);
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x0002B55A File Offset: 0x0002975A
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskFollowPlayerHardMode._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowPlayerHardMode.TsTaskFollowPlayerHardMode_C");
		}
		return TsTaskFollowPlayerHardMode._ClassPtr;
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x0002B580 File Offset: 0x00029780
	public TsTaskFollowPlayerHardMode() : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowPlayerHardMode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x0002B5A8 File Offset: 0x000297A8
	public TsTaskFollowPlayerHardMode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskFollowPlayerHardMode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x0002B5DC File Offset: 0x000297DC
	protected TsTaskFollowPlayerHardMode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x0002B640 File Offset: 0x00029840
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x0002B670 File Offset: 0x00029870
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x04000657 RID: 1623
	private const float UPDATE_ROTATE_OFFSET_INTERVAL = 200f;

	// Token: 0x04000658 RID: 1624
	private float TsMoveSpeed;

	// Token: 0x04000659 RID: 1625
	private float TsRotateSpeed;

	// Token: 0x0400065A RID: 1626
	private Vector TsLocationOffset = Vector.Create();

	// Token: 0x0400065B RID: 1627
	private float TsForceMoveDistance;

	// Token: 0x0400065C RID: 1628
	private bool TsLookAtTarget;

	// Token: 0x0400065D RID: 1629
	private float TsDetectTargetDistance;

	// Token: 0x0400065E RID: 1630
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400065F RID: 1631
	[Nullable(2)]
	private UTraceCapsuleElement TraceElement;

	// Token: 0x04000660 RID: 1632
	[Nullable(2)]
	private UTraceLineElement LineElement;

	// Token: 0x04000661 RID: 1633
	private Rotator RotateOffset = Rotator.Create();

	// Token: 0x04000662 RID: 1634
	private float UpdateRotateOffsetTime;

	// Token: 0x04000663 RID: 1635
	private Rotator TempRotator = Rotator.Create();

	// Token: 0x04000664 RID: 1636
	private Vector TempTargetLocation = Vector.Create();

	// Token: 0x04000665 RID: 1637
	private Vector TempTargetForward = Vector.Create();

	// Token: 0x04000666 RID: 1638
	private Vector TempMoveVector = Vector.Create();

	// Token: 0x04000667 RID: 1639
	private Vector TempVector = Vector.Create();

	// Token: 0x04000668 RID: 1640
	private bool IsInitTsVariables;

	// Token: 0x04000669 RID: 1641
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskFollowPlayerHardMode.TsTaskFollowPlayerHardMode_C";

	// Token: 0x0400066A RID: 1642
	private static IntPtr _ClassPtr;

	// Token: 0x0400066B RID: 1643
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400066C RID: 1644
	private static int __PropertyOffset_MoveSpeed;

	// Token: 0x0400066D RID: 1645
	private static int __PropertyOffset_RotateSpeed;

	// Token: 0x0400066E RID: 1646
	private static int __PropertyOffset_LocationOffset;

	// Token: 0x0400066F RID: 1647
	private static int __PropertyOffset_ForceMoveDistance;

	// Token: 0x04000670 RID: 1648
	private static int __PropertyOffset_LookAtTarget;

	// Token: 0x04000671 RID: 1649
	private static int __PropertyOffset_DetectTargetDistance;

	// Token: 0x04000672 RID: 1650
	private static int __PropertyOffset_DetectTargetTypes;

	// Token: 0x04000673 RID: 1651
	[Nullable(new byte[]
	{
		2,
		0
	})]
	private TArray<TEnumAsByte<EObjectTypeQuery>> _DetectTargetTypes;
}
