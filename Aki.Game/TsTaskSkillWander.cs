using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020000BF RID: 191
[NullableContext(1)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSkillWander.TsTaskSkillWander_C")]
public class TsTaskSkillWander : TsTaskAbortImmediatelyBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x17000206 RID: 518
	// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00036B6B File Offset: 0x00034D6B
	// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00036B7B File Offset: 0x00034D7B
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool ForwardFirst
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_ForwardFirst) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_ForwardFirst) = (value ? 1 : 0);
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00036B8C File Offset: 0x00034D8C
	// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00036B9C File Offset: 0x00034D9C
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CheckSkillPeriod
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_CheckSkillPeriod);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_CheckSkillPeriod) = value;
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00036BAD File Offset: 0x00034DAD
	// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00036BBD File Offset: 0x00034DBD
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int MoveState
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_MoveState);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_MoveState) = value;
		}
	}

	// Token: 0x17000209 RID: 521
	// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00036BCE File Offset: 0x00034DCE
	// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00036BDE File Offset: 0x00034DDE
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe int SkillType
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_SkillType);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_SkillType) = value;
		}
	}

	// Token: 0x1700020A RID: 522
	// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00036BEF File Offset: 0x00034DEF
	// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00036BFF File Offset: 0x00034DFF
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool DebugLog
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_DebugLog) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_DebugLog) = (value ? 1 : 0);
		}
	}

	// Token: 0x1700020B RID: 523
	// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00036C10 File Offset: 0x00034E10
	// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00036C20 File Offset: 0x00034E20
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool WalkOff
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_WalkOff) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsTaskSkillWander.__PropertyOffset_WalkOff) = (value ? 1 : 0);
		}
	}

	// Token: 0x06000B13 RID: 2835 RVA: 0x00036C34 File Offset: 0x00034E34
	private void InitTsVariables()
	{
		if (!this.IsInitTsVariables || GlobalData.IsPlayInEditor)
		{
			this.IsInitTsVariables = true;
			this.TsForwardFirst = this.ForwardFirst;
			this.TsCheckSkillPeriod = this.CheckSkillPeriod;
			this.TsMoveState = ((this.MoveState == 2) ? ECharMoveState.Run : ECharMoveState.Walk);
			this.TsSkillType = this.SkillType;
			this.TsDebugLog = this.DebugLog;
			this.TsWalkOff = this.WalkOff;
			this.TmpVector = global::Vector.Create();
			this.TmpSelfToTarget = global::Vector.Create();
			this.TmpForward = global::Vector.Create();
			this.TmpBackward = global::Vector.Create();
			this.TmpVector2 = global::Vector.Create();
			this.TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);
			this.LastDestination = global::Vector.Create();
		}
	}

	// Token: 0x06000B14 RID: 2836 RVA: 0x00036D1C File Offset: 0x00034F1C
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

	// Token: 0x06000B15 RID: 2837 RVA: 0x00036DB8 File Offset: 0x00034FB8
	[NullableContext(2)]
	protected virtual void ReceiveExecuteAI_Implementation(AAIController ownerController, APawn controlledPawn)
	{
		this.NavigationInterval = 3f;
		this.InitTsVariables();
		TsAiController tsAiController = ownerController as TsAiController;
		AiController aiController = (tsAiController != null) ? tsAiController.AiController : null;
		if (aiController == null)
		{
			return;
		}
		if (!this.TsWalkOff)
		{
			CharacterMoveComponent component = aiController.CharActorComp.Entity.GetComponent<CharacterMoveComponent>();
			if (component != null)
			{
				component.SetWalkOffLedgeRecord(false);
			}
		}
		CharacterUnifiedStateComponent component2 = aiController.CharActorComp.Entity.GetComponent<CharacterUnifiedStateComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.SetMoveState(this.TsMoveState);
	}

	// Token: 0x06000B16 RID: 2838 RVA: 0x00036E34 File Offset: 0x00035034
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe override void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ReceiveTickAI"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams*)ptr + 15L / (long)sizeof(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->OwnerController) = ((ownerController != null) ? ownerController.NativePtr : ((IntPtr)0));
			*(&ptr2->ControlledPawn) = ((controlledPawn != null) ? controlledPawn.NativePtr : ((IntPtr)0));
			ptr2->DeltaSeconds = deltaSeconds;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06000B17 RID: 2839 RVA: 0x00036ED4 File Offset: 0x000350D4
	[NullableContext(2)]
	protected virtual void ReceiveTickAI_Implementation(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
	{
		this.NavigationInterval += deltaSeconds;
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
		EntityHandle currentTarget = aiController.AiHateList.GetCurrentTarget();
		if (currentTarget == null || !currentTarget.Valid)
		{
			base.Finish(false);
			return;
		}
		CharacterActorComponent charActorComp = aiController.CharActorComp;
		CharacterActorComponent component = currentTarget.Entity.GetComponent<CharacterActorComponent>();
		MathUtils.Instance.InverseTransformPositionNoScale(component.FloorLocation, component.ActorRotationProxy, charActorComp.FloorLocation, this.TmpVector);
		double angleByVector2D = MathUtils.Instance.GetAngleByVector2D(this.TmpVector);
		component.FloorLocation.Subtraction(charActorComp.FloorLocation, this.TmpSelfToTarget);
		double height = GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, this.TmpSelfToTarget);
		double num = this.TmpSelfToTarget.Size();
		double num2 = Math.Max(num - (double)charActorComp.ScaledRadius - (double)component.ScaledRadius, 1E-08);
		this.TmpVector.DeepCopy(this.TmpSelfToTarget);
		this.TmpVector.DivisionEqual(num);
		float angleOffsetInGravityForActor = GravityUtils.Instance.GetAngleOffsetInGravityForActor(charActorComp, charActorComp.ActorForwardProxy, this.TmpVector);
		if (this.NextCheckSkillTime == 0.0 || this.NextCheckSkillTime < Time.Instance.WorldTime)
		{
			this.NextCheckSkillTime = Time.Instance.WorldTime + (double)this.TsCheckSkillPeriod;
			if (!this.FindArea(aiController, num2, angleByVector2D, height, this.TmpVector))
			{
				base.Finish(false);
				return;
			}
		}
		else if (this.SelectedSkillPrecondition == null)
		{
			base.Finish(false);
			return;
		}
		bool flag = MathUtils.Instance.InRange(num2, this.SelectedSkillPrecondition.Value.DistanceRange.Value);
		bool flag2 = MathUtils.Instance.InRange((double)angleOffsetInGravityForActor, this.SelectedSkillPrecondition.Value.AngleRange.Value);
		if (flag && flag2)
		{
			base.Finish(true);
			return;
		}
		AiBattleWanderGroup currentBattleWander = aiController.AiWanderInfos.GetCurrentBattleWander();
		FloatRange value = this.SelectedSkillPrecondition.Value.DistanceRange.Value;
		double num3 = this.PreForward ? ((double)value.Min * 0.6666666666666667 + (double)value.Max * 0.3333333333333333) : ((double)value.Min * 0.3333333333333333 + (double)value.Max * 0.6666666666666667);
		BaseUnifiedStateComponent component2 = charActorComp.Entity.GetComponent<BaseUnifiedStateComponent>();
		ECharMoveState echarMoveState = this.TsMoveState;
		if ((flag && !flag2) || num2 < num3)
		{
			echarMoveState = ECharMoveState.Walk;
		}
		if ((component2 == null || component2.MoveState != echarMoveState) && component2 != null)
		{
			component2.SetMoveState(echarMoveState);
		}
		float num4 = currentBattleWander.RunTurnSpeed;
		this.TmpVector.DeepCopy(this.TmpSelfToTarget);
		if (num2 < num3)
		{
			num4 = ((echarMoveState == ECharMoveState.Run) ? num4 : currentBattleWander.TurnSpeeds(1));
			this.TmpVector.UnaryNegation(this.TmpVector);
			this.PreForward = false;
		}
		else
		{
			num4 = ((echarMoveState == ECharMoveState.Run) ? num4 : currentBattleWander.TurnSpeeds(0));
			this.PreForward = true;
		}
		GravityUtils.Instance.ConvertToPlanarVectorForActor(charActorComp, this.TmpVector);
		if (!flag && this.NavigationInterval > 3f)
		{
			this.NavigationInterval = 0f;
			if (this.SetMoveToLocation(this.TmpVector, charActorComp, num4, component.ActorLocationProxy))
			{
				return;
			}
			this.StopMoveToLocation(charActorComp);
		}
		BaseMoveComponent component3 = charActorComp.Entity.GetComponent<BaseMoveComponent>();
		if (component3 == null || !component3.MoveController.IsMovingToLocation())
		{
			if (component2 == null || component2.MoveState != ECharMoveState.Walk)
			{
				AiControllerLibrary.TurnToDirect(charActorComp, this.TmpVector, num4, false, 0f);
				charActorComp.SetInputDirect(charActorComp.ActorForwardProxy, false);
				return;
			}
			AiControllerLibrary.InputNearestDirection(charActorComp, this.TmpVector, this.TmpQuat, this.TmpVector2, num4, true, this.TmpSelfToTarget);
		}
	}

	// Token: 0x06000B18 RID: 2840 RVA: 0x00037314 File Offset: 0x00035514
	private void StopMoveToLocation(CharacterActorComponent character)
	{
		BaseMoveComponent component = character.Entity.GetComponent<BaseMoveComponent>();
		if (component != null && component.MoveController.IsMovingToLocation())
		{
			component.MoveController.StopMoveToLocation("TsTaskSkillWander.StopMoveToLocation");
		}
		global::Vector lastDestination = this.LastDestination;
		if (lastDestination == null)
		{
			return;
		}
		lastDestination.Reset();
	}

	// Token: 0x06000B19 RID: 2841 RVA: 0x00037360 File Offset: 0x00035560
	private bool SetMoveToLocation(global::Vector target, CharacterActorComponent actorComp, float turnSpeed, global::Vector facingDirection)
	{
		this.TmpVector2.DeepCopy(target);
		this.TmpVector2.AdditionEqual(actorComp.ActorLocationProxy);
		BaseMoveComponent component = actorComp.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return false;
		}
		if ((!this.LastDestination.IsNearlyZero(9.999999747378752E-05) || global::Vector.Dist(this.LastDestination, this.TmpVector2) < 100.0) && component.MoveController.IsMovingToLocation())
		{
			this.LastDestination.DeepCopy(this.TmpVector2);
			return true;
		}
		this.LastDestination.DeepCopy(this.TmpVector2);
		MoveToLocationController moveController = component.MoveController;
		MoveToPointConfigImpl moveToPointConfigImpl = new MoveToPointConfigImpl();
		moveToPointConfigImpl.Position = this.TmpVector2;
		moveToPointConfigImpl.TurnSpeed = new float?(turnSpeed);
		moveToPointConfigImpl.UseNearestDirection = new bool?(true);
		moveToPointConfigImpl.FaceToPosition = facingDirection;
		moveToPointConfigImpl.ResetCondition = (() => false);
		return moveController.NavigateMoveToLocation(moveToPointConfigImpl, new bool?(true), false, "TsTaskSkillWander.SetMoveToLocation");
	}

	// Token: 0x06000B1A RID: 2842 RVA: 0x0003746C File Offset: 0x0003566C
	private unsafe bool FindArea(AiController aiController, double distance, double targetAngle, double height, global::Vector selfToTarget)
	{
		CharacterSkillComponent component = aiController.CharAiDesignComp.Entity.GetComponent<CharacterSkillComponent>();
		BaseTagComponent component2 = component.Entity.GetComponent<BaseTagComponent>();
		this.TmpForward.DeepCopy(selfToTarget);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(aiController.CharActorComp, this.TmpForward);
		this.TmpForward.Normalize(9.99999993922529E-09);
		this.TmpForward.UnaryNegation(this.TmpBackward);
		double num = 3.402823466E+38;
		double num2 = 3.402823466E+38;
		this.SelectedSkillPrecondition = null;
		global::EMoveDirection emoveDirection = global::EMoveDirection.None;
		double num3 = 3.402823466E+38;
		if (this.TsDebugLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SkillWander Find Area";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Owner", aiController.CharActorComp.Actor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BT", base.TreeAsset);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		foreach (int num4 in aiController.AiSkill.ActiveSkillGroup)
		{
			Span<int> arrayIntBytes = aiController.AiSkill.BaseSkill.Value.RandomSkills()[num4].GetArrayIntBytes();
			for (int i = 0; i < arrayIntBytes.Length; i++)
			{
				int num5 = *arrayIntBytes[i];
				AiSkillInfos aiSkillInfos;
				AiSkillPrecondition value;
				if (!aiController.AiSkill.SkillInfos.TryGetValue(num5, out aiSkillInfos))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.BehaviorTree;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "没有配置技能库";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", num5);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else if (!aiController.AiSkill.SkillPreconditionMap.TryGetValue(aiSkillInfos.SkillPreconditionId, out value))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.BehaviorTree;
					ELogAuthor author3 = ELogAuthor.LCZ;
					string message3 = "没有配置技能前置条件";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", aiSkillInfos.SkillPreconditionId);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else if (aiSkillInfos.SkillWeight > 0 && AiLibrary.IsSkillAvailable(aiController, num5, component, component2, this.TsSkillType, targetAngle, height, 0.0, 0.0, false, this.TsDebugLog))
				{
					FloatRange value2 = value.DistanceRange.Value;
					if (distance < (double)value2.Min)
					{
						if (this.TsForwardFirst && emoveDirection == global::EMoveDirection.Forward)
						{
							if (this.TsDebugLog)
							{
								Log.Instance.Info(ELogModule.AI, ELogAuthor.LCZ, "    Failed: ForwardFirst", default(ReadOnlySpan<ValueTuple<string, object>>));
							}
						}
						else
						{
							double num6 = (double)value2.Min - distance;
							if (num3 < num6 || num2 < num6)
							{
								if (this.TsDebugLog)
								{
									Log instance4 = Log.Instance;
									ELogModule module4 = ELogModule.AI;
									ELogAuthor author4 = ELogAuthor.LCZ;
									string message4 = "    Failed: BackwardBlock or MinDistance";
									<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("MoveDist", num6);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("MinDistance", num3);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("MinBackwardBlock", num2);
									instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
								}
							}
							else if (AiControllerLibrary.NavigationBlockDirection(base.AIOwner, aiController.CharActorComp.ActorLocationProxy, this.TmpBackward, (float)num6, true))
							{
								num2 = num6;
								if (this.TsDebugLog)
								{
									Log instance5 = Log.Instance;
									ELogModule module5 = ELogModule.AI;
									ELogAuthor author5 = ELogAuthor.LCZ;
									string message5 = "    Failed: BackwardBlock";
									ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("MoveDist", num6);
									instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
								}
							}
							else
							{
								emoveDirection = global::EMoveDirection.Backward;
								num3 = num6;
								this.SelectedSkillPrecondition = new AiSkillPrecondition?(value);
							}
						}
					}
					else
					{
						if (distance <= (double)value2.Max)
						{
							this.SelectedSkillPrecondition = new AiSkillPrecondition?(value);
							break;
						}
						if (!this.TsForwardFirst && emoveDirection == global::EMoveDirection.Backward)
						{
							if (this.TsDebugLog)
							{
								Log.Instance.Info(ELogModule.AI, ELogAuthor.LCZ, "    Failed: BackwardFirst", default(ReadOnlySpan<ValueTuple<string, object>>));
							}
						}
						else
						{
							double num7 = distance - (double)value2.Max;
							if (num3 < num7 || num < num7)
							{
								if (this.TsDebugLog)
								{
									Log instance6 = Log.Instance;
									ELogModule module6 = ELogModule.AI;
									ELogAuthor author6 = ELogAuthor.LCZ;
									string message6 = "    Failed: ForwardBlock or MinDistance";
									<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("MoveDist", num7);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("MinDistance", num3);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("MinForwardBlock", num);
									instance6.Info(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
								}
							}
							else if (AiControllerLibrary.NavigationBlockDirection(base.AIOwner, aiController.CharActorComp.ActorLocationProxy, this.TmpForward, (float)num7, true))
							{
								num = num7;
								if (this.TsDebugLog)
								{
									Log instance7 = Log.Instance;
									ELogModule module7 = ELogModule.AI;
									ELogAuthor author7 = ELogAuthor.LCZ;
									string message7 = "    Failed: ForwardBlock";
									ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("MoveDist", num7);
									instance7.Info(module7, author7, message7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
								}
							}
							else
							{
								emoveDirection = global::EMoveDirection.Forward;
								num3 = num7;
								this.SelectedSkillPrecondition = new AiSkillPrecondition?(value);
							}
						}
					}
				}
			}
		}
		return this.SelectedSkillPrecondition != null;
	}

	// Token: 0x06000B1B RID: 2843 RVA: 0x000379E8 File Offset: 0x00035BE8
	protected override void OnClear()
	{
		TsAiController tsAiController = base.AIOwner as TsAiController;
		if (tsAiController != null)
		{
			BaseMoveComponent component = tsAiController.AiController.CharActorComp.Entity.GetComponent<BaseMoveComponent>();
			if (component != null)
			{
				component.MoveController.StopMoveToLocation("TsTaskSkillWander.OnClear");
			}
			global::Vector lastDestination = this.LastDestination;
			if (lastDestination != null)
			{
				lastDestination.Reset();
			}
			AiControllerLibrary.ClearInput(tsAiController);
			if (!this.TsWalkOff && component != null)
			{
				component.SetWalkOffLedgeRecord(true);
			}
		}
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00037A56 File Offset: 0x00035C56
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsTaskSkillWander._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSkillWander.TsTaskSkillWander_C");
		}
		return TsTaskSkillWander._ClassPtr;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00037A7C File Offset: 0x00035C7C
	public TsTaskSkillWander() : this(BuiltinUtils.AllocNativeUObject(TsTaskSkillWander.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00037AA4 File Offset: 0x00035CA4
	public TsTaskSkillWander(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTaskSkillWander.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00037AD8 File Offset: 0x00035CD8
	protected TsTaskSkillWander(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00037B64 File Offset: 0x00035D64
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveExecuteAI_Implementation(UBTTask_BlueprintBase.__ReceiveExecuteAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveExecuteAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00037B94 File Offset: 0x00035D94
	[NullableContext(0)]
	protected unsafe virtual void __CPPCALL_ReceiveTickAI_Implementation(UBTTask_BlueprintBase.__ReceiveTickAI_FunctionParams* __Params)
	{
		AAIController orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AAIController>(__Params->OwnerController);
		APawn orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->ControlledPawn);
		this.ReceiveTickAI_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, __Params->DeltaSeconds);
	}

	// Token: 0x040008A0 RID: 2208
	private const double THRESHOLD_RATE = 0.3333333333333333;

	// Token: 0x040008A1 RID: 2209
	private const double OTHER_THRESHOLD_RATE = 0.6666666666666667;

	// Token: 0x040008A2 RID: 2210
	private const int NAV_INTERVAL_TIME = 3;

	// Token: 0x040008A3 RID: 2211
	private bool IsInitTsVariables;

	// Token: 0x040008A4 RID: 2212
	private bool TsForwardFirst;

	// Token: 0x040008A5 RID: 2213
	private float TsCheckSkillPeriod;

	// Token: 0x040008A6 RID: 2214
	private ECharMoveState TsMoveState = ECharMoveState.Walk;

	// Token: 0x040008A7 RID: 2215
	private int TsSkillType;

	// Token: 0x040008A8 RID: 2216
	private global::Vector TmpVector = global::Vector.Create();

	// Token: 0x040008A9 RID: 2217
	private global::Vector TmpSelfToTarget = global::Vector.Create();

	// Token: 0x040008AA RID: 2218
	private global::Vector TmpForward = global::Vector.Create();

	// Token: 0x040008AB RID: 2219
	private global::Vector TmpBackward = global::Vector.Create();

	// Token: 0x040008AC RID: 2220
	private global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x040008AD RID: 2221
	private Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040008AE RID: 2222
	private global::Vector LastDestination = global::Vector.Create();

	// Token: 0x040008AF RID: 2223
	private bool PreForward;

	// Token: 0x040008B0 RID: 2224
	private bool TsDebugLog;

	// Token: 0x040008B1 RID: 2225
	private bool TsWalkOff;

	// Token: 0x040008B2 RID: 2226
	private float NavigationInterval;

	// Token: 0x040008B3 RID: 2227
	private double NextCheckSkillTime;

	// Token: 0x040008B4 RID: 2228
	private AiSkillPrecondition? SelectedSkillPrecondition;

	// Token: 0x040008B5 RID: 2229
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/AI/BehaviorTree/Task/TsTaskSkillWander.TsTaskSkillWander_C";

	// Token: 0x040008B6 RID: 2230
	private static IntPtr _ClassPtr;

	// Token: 0x040008B7 RID: 2231
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x040008B8 RID: 2232
	private static int __PropertyOffset_ForwardFirst;

	// Token: 0x040008B9 RID: 2233
	private static int __PropertyOffset_CheckSkillPeriod;

	// Token: 0x040008BA RID: 2234
	private static int __PropertyOffset_MoveState;

	// Token: 0x040008BB RID: 2235
	private static int __PropertyOffset_SkillType;

	// Token: 0x040008BC RID: 2236
	private static int __PropertyOffset_DebugLog;

	// Token: 0x040008BD RID: 2237
	private static int __PropertyOffset_WalkOff;
}
