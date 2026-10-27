using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Role.Common;
using AkiClient.Game.Aki.Data.Level.Ski;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x020030F7 RID: 12535
[NullableContext(1)]
[Nullable(0)]
public class CharacterSlideComponent : EntityComponent, IComponentDependency, IStaticVariableResetter
{
	// Token: 0x0601AE09 RID: 110089 RVA: 0x007445C8 File Offset: 0x007427C8
	static CharacterSlideComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterSlideComponent.CreateStaticDefaultValue), new Action(CharacterSlideComponent.ResetStaticDefaultValue));
	}

	// Token: 0x17002511 RID: 9489
	// (get) Token: 0x0601AE0A RID: 110090 RVA: 0x00744633 File Offset: 0x00742833
	protected static float[] SlideFallingCoefficientArray
	{
		get
		{
			return CharacterSlideComponent._SlideFallingCoefficientArray;
		}
	}

	// Token: 0x17002512 RID: 9490
	// (get) Token: 0x0601AE0B RID: 110091 RVA: 0x0074463A File Offset: 0x0074283A
	public static Slide SlideConfig
	{
		get
		{
			if (CharacterSlideComponent.SlideConfigInternal == null)
			{
				CharacterSlideComponent.SetSlideConfig(0);
			}
			return CharacterSlideComponent.SlideConfigInternal.Value;
		}
	}

	// Token: 0x0601AE0C RID: 110092 RVA: 0x00744658 File Offset: 0x00742858
	public static void SetSlideConfig(int slideId)
	{
		if (((CharacterSlideComponent.SlideConfigInternal != null) ? CharacterSlideComponent.SlideConfigInternal.GetValueOrDefault().Id : null) == slideId.ToString())
		{
			return;
		}
		CharacterSlideComponent.SlideConfigInternal = ConfigSlideById.GetConfig(slideId.ToString(), true);
		List<float[]> list = new List<float[]>();
		foreach (DicIntFloat dicIntFloat in CharacterSlideComponent.SlideConfigInternal.Value.FallingLateralFrictionsIter())
		{
			float key = (float)dicIntFloat.Key;
			float value = dicIntFloat.Value;
			float num = (float)Math.Cos((double)(key * 0.017453292f));
			float[] item = new float[]
			{
				num * num * num,
				num * num,
				num,
				1f,
				value
			};
			list.Add(item);
		}
		for (int i = list.Count - 1; i >= 0; i--)
		{
			for (int j = 0; j < i; j++)
			{
				float num2 = list[j][i] / list[i][i];
				for (int k = 0; k < list[i].Length; k++)
				{
					list[j][k] -= list[i][k] * num2;
				}
			}
		}
		for (int l = 0; l < list.Count; l++)
		{
			for (int m = l + 1; m < list.Count; m++)
			{
				float num3 = list[m][l] / list[l][l];
				for (int n = 0; n < list[l].Length; n++)
				{
					list[m][n] -= list[l][n] * num3;
				}
			}
			CharacterSlideComponent.SlideFallingCoefficientArray[l] = list[l][4] / list[l][l];
		}
		if (!string.IsNullOrEmpty(CharacterSlideComponent.SlideConfigInternal.Value.SpeedReduceCurve))
		{
			ResourceSystem.Instance.LoadAsync<UCurveFloat>(CharacterSlideComponent.SlideConfigInternal.Value.SpeedReduceCurve, delegate([Nullable(2)] UCurveFloat curve, string _)
			{
				CharacterSlideComponent.SpeedReduceCurve = curve;
			}, 100, "js_undefined");
			return;
		}
		CharacterSlideComponent.SpeedReduceCurve = null;
	}

	// Token: 0x0601AE0D RID: 110093 RVA: 0x007448C8 File Offset: 0x00742AC8
	protected static float GetSlideFallingFriction(float cos)
	{
		if (CharacterSlideComponent.SlideConfigInternal == null)
		{
			CharacterSlideComponent.SetSlideConfig(0);
		}
		float num = 0f;
		foreach (float num2 in CharacterSlideComponent.SlideFallingCoefficientArray)
		{
			num = num * cos + num2;
		}
		return num;
	}

	// Token: 0x17002513 RID: 9491
	// (get) Token: 0x0601AE0E RID: 110094 RVA: 0x0074490C File Offset: 0x00742B0C
	protected static UCurveFloat JumpAddMoveCurve
	{
		get
		{
			if (CharacterSlideComponent._jumpAddMoveCurveInternal == null)
			{
				CharacterSlideComponent._jumpAddMoveCurveInternal = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/BaseCharacter/Curves/CharacterMovementCurves/SpeedAirSlideSprint.SpeedAirSlideSprint");
			}
			return CharacterSlideComponent._jumpAddMoveCurveInternal;
		}
	}

	// Token: 0x17002514 RID: 9492
	// (get) Token: 0x0601AE0F RID: 110095 RVA: 0x0074492E File Offset: 0x00742B2E
	[StaticVariableRuleIgnore]
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterMoveComponent),
				typeof(CharacterUnifiedStateComponent)
			};
		}
	}

	// Token: 0x0601AE10 RID: 110096 RVA: 0x00744960 File Offset: 0x00742B60
	private void OnMoveStateChanged(global::ECharMoveState oldState, global::ECharMoveState newState)
	{
		if (newState != global::ECharMoveState.Slide)
		{
			this.MoveComp.CharacterMovement.FallingLateralFriction = 0f;
		}
		if (newState == global::ECharMoveState.NormalSki)
		{
			this.SkiDirection.DeepCopy(this.ActorComp.ActorForwardProxy);
			this.MoveComp.ResetTurnRate();
			if (!this.VelocityBeforeJump.Equality(global::Vector.ZeroVectorProxy))
			{
				this.TmpVector.DeepCopy(this.VelocityBeforeJump);
				this.CacheBlockDirect.Multiply(this.TmpVector.DotProduct(this.CacheBlockDirect), this.TmpVector2);
				this.TmpVector.Subtraction(this.TmpVector2, this.TmpVector2);
				double inB = Math.Min(this.TmpVector2.Size(), 3500.0);
				this.TmpVector.DeepCopy(this.ActorComp.ActorForwardProxy);
				this.CacheBlockDirect.Multiply(this.TmpVector.DotProduct(this.CacheBlockDirect), this.TmpVector3);
				this.TmpVector.Subtraction(this.TmpVector3, this.TmpVector3);
				if (!this.TmpVector3.Normalize(9.99999993922529E-09))
				{
					this.TmpVector3.DeepCopy(this.ActorComp.ActorForwardProxy);
				}
				this.TmpVector3.MultiplyEqual(inB);
				this.MoveComp.SetForceSpeed(this.TmpVector3);
				this.VelocityBeforeJump.Reset();
			}
		}
	}

	// Token: 0x0601AE11 RID: 110097 RVA: 0x00744AD4 File Offset: 0x00742CD4
	private unsafe void OnMoveSki(float delta)
	{
		if (this.NeedInitSpeed)
		{
			this.ActorComp.ActorForwardProxy.Multiply((double)this.SkiConfig.InitSpeed, this.TmpVector);
			this.MoveComp.SetForceSpeed(this.TmpVector);
			this.NeedInitSpeed = false;
		}
		this.CalcSkiDirection(delta, this.SkiDirection);
		this.CalcSkiSpeedParams(this.TmpVector);
		int num = UKuroMovementBPLibrary.KuroSki(delta, this.MoveComp.CharacterMovement, this.GroundNormal.ToUeVectorOld(), this.SkiDirection.ToUeVectorOld(), this.TmpVector.ToUeVectorOld(), this.SkiConfig.IgnoreStepHeight, null);
		if (num != 0)
		{
			if (this.DetectFloor() != null)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Walking,
						Context = "[CharacterSlideComponent.OnMoveSki] Walking"
					});
				}
				this.UnifiedStateComp.SetMoveState(global::ECharMoveState.Run);
			}
			else
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 != null)
				{
					actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						Context = "[CharacterSlideComponent.OnMoveSki] Falling"
					});
				}
			}
			this.ExitSlideThisFrame = true;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "滑雪中断";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (!this.CheckSkiException(delta))
		{
			this.LeaveSlideCountDown -= delta;
			if (this.LeaveSlideCountDown < 0f)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.Movement;
				ELogAuthor author2 = ELogAuthor.YJX;
				string message2 = "检测到异常，退出滑雪模式";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Angle", Math.Acos(global::Vector.DotProduct(this.GroundNormal, this.ActorComp.MoveComp.GravityUp)));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("MoveDelta", global::Vector.Dist(this.ActorComp.LastActorLocation, this.TmpVector));
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.ExitSkiMode(true);
			}
		}
	}

	// Token: 0x0601AE12 RID: 110098 RVA: 0x00744CE8 File Offset: 0x00742EE8
	private void CalcSkiSpeedParams(global::Vector outVec)
	{
		float num = this.SkiConfig.BaseAccForSpeedUp;
		float num2 = this.SkiConfig.BaseTargetSpeed;
		global::Vector gravityUp = this.ActorComp.MoveComp.GravityUp;
		float num3 = (float)(Math.Acos(MathUtils.Instance.Clamp(global::Vector.DotProduct(this.SlideForward, gravityUp), -1.0, 1.0)) * 57.295780181884766) / 90f;
		float num4 = this.SkiConfig.SlopExtraAccel * num3;
		float num5 = this.SkiConfig.SlopExtraTargetSpeed * num3;
		int num6 = Math.Sign(global::Vector.DotProduct(this.ActorComp.ActorForwardProxy, this.SlideForward));
		num += (float)num6 * num4;
		num2 += (float)num6 * num5;
		if (this.SkiAccelConfig != null)
		{
			num += (float)this.SkiAccelConfig.Acceleration;
			num2 += (float)this.SkiAccelConfig.LimitSpeed;
		}
		num2 = Math.Min(num2, 3500f);
		outVec.Set((double)num, (double)this.SkiConfig.BaseAccForSpeedDown, (double)num2);
	}

	// Token: 0x0601AE13 RID: 110099 RVA: 0x00744DF4 File Offset: 0x00742FF4
	private void CalcSkiDirection(float deltaTime, global::Vector outDirection)
	{
		global::Vector tmpVector = this.TmpVector;
		global::Vector tmpVector2 = this.TmpVector2;
		global::Vector tmpVector3 = this.TmpVector3;
		global::Vector tmpVector4 = this.TmpVector4;
		float turnSpeed = this.SkiConfig.TurnSpeed;
		float num = -50f;
		float num2 = 50f;
		CharacterSplineMoveComponent component = base.Entity.GetComponent<CharacterSplineMoveComponent>();
		tmpVector.DeepCopy(this.ActorComp.ActorForwardProxy);
		if (component != null && component.Active)
		{
			num = component.MinTurnAngle;
			num2 = component.MaxTurnAngle;
			tmpVector.DeepCopy(component.SplineDirection);
		}
		double inB = global::Vector.DotProduct(tmpVector, this.SlideForward);
		this.SlideForward.Multiply(inB, this.TmpVector5);
		tmpVector.SubtractionEqual(this.TmpVector5);
		tmpVector.Normalize(9.99999993922529E-09);
		this.SlideForward.CrossProduct(tmpVector, tmpVector3);
		if (!tmpVector3.Normalize(9.99999993922529E-09))
		{
			tmpVector3.DeepCopy(this.ActorComp.ActorRightProxy);
		}
		tmpVector2.DeepCopy(this.ActorComp.InputDirectProxy);
		if (!tmpVector2.Normalize(9.99999993922529E-09))
		{
			tmpVector2.Reset();
		}
		else
		{
			tmpVector3.Multiply(tmpVector3.DotProduct(tmpVector2), tmpVector2);
		}
		if (tmpVector2.ContainsNaN())
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "滑雪输入中有NaN";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Input", tmpVector2);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		tmpVector4.DeepCopy(this.ActorComp.ActorVelocityProxy);
		if (!tmpVector4.Normalize(9.99999993922529E-09))
		{
			tmpVector4.DeepCopy(this.ActorComp.ActorForwardProxy);
		}
		inB = global::Vector.DotProduct(tmpVector4, this.SlideForward);
		this.SlideForward.Multiply(inB, this.TmpVector5);
		tmpVector4.SubtractionEqual(this.TmpVector5);
		tmpVector4.Normalize(9.99999993922529E-09);
		float num3 = (float)(Math.Acos(MathUtils.Instance.Clamp(tmpVector4.DotProduct(tmpVector), -1.0, 1.0)) * 57.295780181884766);
		float num4 = this.AngleNormalize((float)Math.Sign(tmpVector4.DotProduct(tmpVector3)) * num3);
		double num5 = tmpVector2.DotProduct(tmpVector3) * (double)turnSpeed * (double)deltaTime;
		double num6 = MathUtils.Instance.Clamp((double)num4 + num5, (double)num, (double)num2);
		this.TmpVector5.DeepCopy(this.SlideForward);
		this.TmpVector5.MultiplyEqual((double)((float)Math.Sin(num6 * 0.01745329238474369 * 0.5)));
		this.TmpQuat.Set(this.TmpVector5.X, this.TmpVector5.Y, this.TmpVector5.Z, Math.Cos(num6 * 0.01745329238474369 * 0.5));
		this.TmpQuat.RotateVector(tmpVector, outDirection);
		inB = global::Vector.DotProduct(outDirection, this.SlideForward);
		this.SlideForward.Multiply(inB, this.TmpVector5);
		outDirection.SubtractionEqual(this.TmpVector5);
		outDirection.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601AE14 RID: 110100 RVA: 0x0074510C File Offset: 0x0074330C
	private float AngleNormalize(float angle)
	{
		float num;
		for (num = angle; num > 180f; num -= 360f)
		{
		}
		while (num < -180f)
		{
			num += 360f;
		}
		return num;
	}

	// Token: 0x0601AE15 RID: 110101 RVA: 0x00745140 File Offset: 0x00743340
	private void OnMoveSlide(float delta)
	{
		Slide slideConfig = CharacterSlideComponent.SlideConfig;
		this.TmpVector3.DeepCopy(this.ActorComp.InputDirectProxy);
		global::Vector tmpVector = this.TmpVector3;
		bool flag = false;
		if (tmpVector.Normalize(9.99999993922529E-09))
		{
			flag = slideConfig.Ski;
			this.TmpVector.DeepCopy(this.SlideForward);
			this.MoveComp.GravityDirect.CrossProduct(this.TmpVector, this.TmpVector2);
			this.TmpVector2.CrossProduct(this.TmpVector, this.SlideUp);
			if (this.SlideUp.Normalize(9.99999993922529E-09))
			{
				bool flag2 = true;
				if (slideConfig.Ski)
				{
					this.TmpVector.DeepCopy(this.SlideForward);
					GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
					this.TmpVector.Normalize(9.99999993922529E-09);
					flag2 = (GravityUtils.Instance.GetAngleOffsetInGravityAbsForActor(this.ActorComp, this.TmpVector, tmpVector) < 135f);
					if (flag2)
					{
						this.TmpVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
						GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.TmpVector);
						if (!this.TmpVector.Normalize(9.99999993922529E-09))
						{
							this.SlideUp.UnaryNegation(this.TmpVector);
						}
						float angleOffsetInGravityForActor = GravityUtils.Instance.GetAngleOffsetInGravityForActor(this.ActorComp, this.TmpVector, this.ActorComp.InputDirectProxy);
						if (Math.Abs(angleOffsetInGravityForActor) > 135f)
						{
							this.MoveComp.GravityDirect.CrossProduct(this.TmpVector, this.TmpVector2);
							float num = (float)Math.Sign(angleOffsetInGravityForActor) * 135f * 0.017453292f;
							this.TmpVector.MultiplyEqual((double)((float)Math.Cos((double)num)));
							this.TmpVector2.MultiplyEqual((double)((float)Math.Sin((double)num)));
							this.TmpVector.Addition(this.TmpVector2, tmpVector);
						}
					}
				}
				double num2 = tmpVector.DotProduct(this.SlideUp);
				double num3;
				if (num2 > 0.0)
				{
					num3 = num2 * (double)slideConfig.SlideAccelUp;
					double num4 = this.ActorComp.ActorVelocityProxy.DotProduct(this.SlideUp);
					if (slideConfig.Ski)
					{
						num3 *= MathUtils.Instance.RangeClamp(num4, (double)(-(double)slideConfig.SkiHorizontalInputSpeedThreshold.Value.Max), (double)(-(double)slideConfig.SkiHorizontalInputSpeedThreshold.Value.Min), 1.0, 0.0);
					}
					else if (num3 * (double)slideConfig.SlideAccel * (double)delta > num4)
					{
						num3 = 0.0;
					}
				}
				else
				{
					num3 = num2 * (double)slideConfig.SlideAccelDown;
				}
				this.SlideUp.Multiply(num3, this.TmpVector);
				if (flag2)
				{
					this.TmpVector2.MultiplyEqual(this.TmpVector2.DotProduct(tmpVector) / this.TmpVector2.SizeSquared());
					this.TmpVector.AdditionEqual(this.TmpVector2);
				}
				this.TmpVector.MultiplyEqual((double)slideConfig.SlideAccel);
			}
			else
			{
				tmpVector.Multiply((double)slideConfig.SlideAccel, this.TmpVector);
			}
		}
		else
		{
			this.TmpVector.Reset();
		}
		if (this.TmpVector.ContainsNaN())
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "Slide speed has NaN";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("velocity", this.TmpVector);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		float airFriction;
		float slideFriction;
		float num5;
		float maxSlideVerticalSpeed;
		if (this.SkiAccelConfig != null)
		{
			airFriction = 0f;
			slideFriction = 0f;
			num5 = (float)this.SkiAccelConfig.LimitSpeed;
			maxSlideVerticalSpeed = num5;
		}
		else
		{
			airFriction = this.CurrentAirFriction;
			slideFriction = slideConfig.SlideFriction;
			if (flag)
			{
				num5 = slideConfig.SkiMaxSpHor;
				maxSlideVerticalSpeed = slideConfig.SkiMaxSpVer;
			}
			else
			{
				num5 = slideConfig.MaxSlideHorizontalSeed;
				maxSlideVerticalSpeed = -1f;
			}
		}
		if (!this.MoveComp.CharacterMovement.KuroSlide(delta, airFriction, slideFriction, (this.LeaveSlideCountDown == 0.25f) ? this.TmpVector.ToUeVectorOld() : global::Vector.ZeroVector, num5, this.GroundNormal.ToUeVectorOld(), maxSlideVerticalSpeed, CharacterSlideComponent.SpeedReduceCurve))
		{
			if (this.MoveComp.CharacterMovement.Kuro_GetBlockActorWhenMove() != null)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Walking,
						Context = "[CharacterSlideComponent.OnMoveSlide] Walking"
					});
				}
				this.ExitSlideThisFrame = true;
				return;
			}
			this.LeaveSlideCountDown -= delta;
			if (this.LeaveSlideCountDown < 0f && this.CheckExitSlide())
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 != null)
				{
					actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						Context = "[CharacterSlideComponent.OnMoveSlide] Falling"
					});
				}
				this.ExitSlideThisFrame = true;
				return;
			}
		}
		else
		{
			this.LeaveSlideCountDown = 0.25f;
		}
	}

	// Token: 0x0601AE16 RID: 110102 RVA: 0x0074563C File Offset: 0x0074383C
	private void OnInherit(Entity oldEntity, bool notInheritMoveAndAnim)
	{
		if (notInheritMoveAndAnim)
		{
			return;
		}
		CharacterSlideComponent component = oldEntity.GetComponent<CharacterSlideComponent>();
		if (this.UnifiedStateComp.MoveState != global::ECharMoveState.Slide && this.UnifiedStateComp.MoveState != global::ECharMoveState.NormalSki && component.UnifiedStateComp.MoveState != global::ECharMoveState.Slide && component.UnifiedStateComp.MoveState != global::ECharMoveState.NormalSki)
		{
			return;
		}
		this.LeaveSlideCountDown = component.LeaveSlideCountDown;
		this.SlideForward.DeepCopy(component.SlideForward);
		this.LastZ = component.LastZ;
		this.CurrentAirFriction = component.CurrentAirFriction;
		this.SlideSwitchThisFrame = component.SlideSwitchThisFrame;
		this.StandMode = component.StandMode;
		this.LastAngleOffset = component.LastAngleOffset;
		this.SkiConfig = component.SkiConfig;
		this.SkiAccelConfig = component.SkiAccelConfig;
		this.SkiAccelCountDown = component.SkiAccelCountDown;
	}

	// Token: 0x0601AE17 RID: 110103 RVA: 0x00745710 File Offset: 0x00743910
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		this.AnimComp = base.Entity.GetComponent<CharacterAnimationComponent>();
		this.AttributeComp = base.Entity.GetComponent<BaseAttributeComponent>();
		this.InputComp = base.Entity.GetComponent<CharacterInputComponent>();
		this.UnifiedStateComp = base.Entity.GetComponent<CharacterUnifiedStateComponent>();
		this.SkillComp = base.Entity.GetComponent<CharacterSkillComponent>();
		this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
		this.TmpVector.Reset();
		this.SlideUp.Reset();
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null && tagComp.Valid)
		{
			int[] disableTags = CharacterSlideComponent.DisableTags;
			for (int i = 0; i < disableTags.Length; i++)
			{
				int tagId = disableTags[i];
				this.TagListeners.Add(this.TagComp.ListenForTagAnyCountChanged(tagId, delegate(int newCount, int _, int _, int _)
				{
					this.OnDisableTagChanged(tagId, newCount);
				}));
				if (this.TagComp.HasTag(tagId))
				{
					this.DisableTagSet.Add(tagId);
				}
			}
		}
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChanged));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CustomMoveSlide, new Action<float>(this.OnMoveSlide));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CustomMoveSki, new Action<float>(this.OnMoveSki));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnInherit));
		return true;
	}

	// Token: 0x0601AE18 RID: 110104 RVA: 0x007458CC File Offset: 0x00743ACC
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.OnMoveStateChanged));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CustomMoveSlide, new Action<float>(this.OnMoveSlide));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CustomMoveSki, new Action<float>(this.OnMoveSki));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.RoleOnStateInherit, new Action<Entity, bool>(this.OnInherit));
		foreach (ITagTask tagTask in this.TagListeners)
		{
			tagTask.EndTask();
		}
		this.TagListeners.Clear();
		return true;
	}

	// Token: 0x0601AE19 RID: 110105 RVA: 0x007459AC File Offset: 0x00743BAC
	protected override void OnTick(float delta)
	{
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsMoveAutonomousProxy)
		{
			return;
		}
		if (this.UnifiedStateComp.MoveState == global::ECharMoveState.Glide || this.UnifiedStateComp.MoveState == global::ECharMoveState.Soar || this.MoveComp.IsJump)
		{
			return;
		}
		if (this.UnifiedStateComp.PositionState == global::ECharPositionState.Ride)
		{
			return;
		}
		CharacterSkillComponent skillComp = this.SkillComp;
		if (((skillComp != null) ? skillComp.CurrentSkill : null) != null)
		{
			CharacterUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
			if (unifiedStateComp != null && unifiedStateComp.MoveState == global::ECharMoveState.Slide)
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 == null)
				{
					return;
				}
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Falling,
					Context = "[CharacterSlideComponent.OnTick]"
				});
			}
			return;
		}
		if (this.InputComp.IsInAutomaticFlightMode())
		{
			return;
		}
		if (this.IsInSkiMode)
		{
			this.TickSkiMode(delta);
			return;
		}
		this.TickSlideMode(delta);
	}

	// Token: 0x0601AE1A RID: 110106 RVA: 0x00745A8C File Offset: 0x00743C8C
	private void FindStandMode(bool enterSlideFrame, Slide slideConfig)
	{
		this.SlideSwitchThisFrame = false;
		if (this.SkiConfig != null)
		{
			if (enterSlideFrame)
			{
				this.SlideSwitchThisFrame = false;
			}
			else
			{
				this.SlideSwitchThisFrame = !this.StandMode;
			}
			this.StandMode = true;
			return;
		}
		if (enterSlideFrame)
		{
			this.SlideSwitchThisFrame = false;
			this.StandMode = (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.SlideForward) > (double)((float)Math.Cos((double)((slideConfig.SlideModeSwitchRange.Value.Min + slideConfig.SlideModeSwitchRange.Value.Max) / 2f * 0.017453292f))));
			return;
		}
		if (this.StandMode)
		{
			if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.SlideForward) < (double)((float)Math.Cos((double)(slideConfig.SlideModeSwitchRange.Value.Max * 0.017453292f))))
			{
				this.StandMode = false;
				this.SlideSwitchThisFrame = true;
				return;
			}
		}
		else if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.SlideForward) > (double)((float)Math.Cos((double)(slideConfig.SlideModeSwitchRange.Value.Min * 0.017453292f))))
		{
			this.StandMode = true;
			this.SlideSwitchThisFrame = true;
		}
	}

	// Token: 0x0601AE1B RID: 110107 RVA: 0x00745BD8 File Offset: 0x00743DD8
	private void SetInputRotator(bool enterSlideFrame)
	{
		if (this.SkiConfig != null)
		{
			global::Vector tmpVector = this.TmpVector;
			FVector velocity = this.MoveComp.CharacterMovement.Velocity;
			tmpVector.FromUeVector(velocity);
			this.ActorComp.SetInputFacing(this.TmpVector, true);
			this.ActorComp.SetOverrideTurnSpeed(new float?(this.SkiConfig.TurnSpeed));
			return;
		}
		if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.屏蔽滑坡转体"]) || this.StandMode)
		{
			this.ActorComp.SetInputFacing(this.SlideForward, true);
			this.LastAngleOffset = 0f;
		}
		else
		{
			if (enterSlideFrame || this.ActorComp.InputDirectProxy.IsNearlyZero(9.999999747378752E-05))
			{
				this.TmpVector.DeepCopy(this.ActorComp.ActorForwardProxy);
			}
			else
			{
				this.TmpVector.DeepCopy(this.ActorComp.InputDirectProxy);
			}
			GravityUtils.Instance.GetBaseQuatInGravityForActor(this.ActorComp, this.TmpQuat2);
			this.TmpQuat2.Inverse(this.TmpQuat);
			this.TmpQuat.RotateVector(this.SlideForward, this.TmpVector2);
			this.TmpQuat.RotateVector(this.TmpVector, this.TmpVector3);
			double angleByVector2D = MathUtils.Instance.GetAngleByVector2D(this.TmpVector2);
			double angleByVector2D2 = MathUtils.Instance.GetAngleByVector2D(this.TmpVector3);
			double num = MathUtils.Instance.WrapAngle(angleByVector2D2 - angleByVector2D);
			if (enterSlideFrame)
			{
				this.LastAngleOffset = (float)Math.Round(num / 180.0) * 180f;
			}
			else if (Math.Abs(MathUtils.Instance.WrapAngle((double)this.LastAngleOffset - num)) > 135.0)
			{
				this.LastAngleOffset = (float)Math.Round(num / 180.0) * 180f;
			}
			this.TmpRotator.Set(0f, (float)(angleByVector2D + (double)this.LastAngleOffset), 0f);
			this.TmpQuat2.Multiply(this.TmpRotator.Quaternion(null), this.TmpQuat);
			this.ActorComp.SetInputRotator(this.TmpQuat.Rotator(null));
		}
		this.ActorComp.SetOverrideTurnSpeed(new float?(CharacterSlideComponent.SlideConfig.TurnSpeed));
	}

	// Token: 0x0601AE1C RID: 110108 RVA: 0x00745E2D File Offset: 0x0074402D
	private void OnDisableTagChanged(int tagId, int newCount)
	{
		if (newCount == 0)
		{
			this.DisableTagSet.Remove(tagId);
			return;
		}
		this.DisableTagSet.Add(tagId);
	}

	// Token: 0x0601AE1D RID: 110109 RVA: 0x00745E50 File Offset: 0x00744050
	private bool CheckExitSlide()
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = this.ActorComp.ScaledRadius;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.ActorComp.ActorLocationProxy);
		this.TmpVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)(-(double)(this.ActorComp.ScaledHalfHeight - this.ActorComp.Radius + 5f)));
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector);
		return !TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "slide", "slide");
	}

	// Token: 0x0601AE1E RID: 110110 RVA: 0x00745F28 File Offset: 0x00744128
	[NullableContext(2)]
	private UKuroHitResult DetectFloor()
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = this.ActorComp.ScaledRadius;
		this.TmpVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)(-(double)(this.ActorComp.ScaledHalfHeight - this.ActorComp.ScaledRadius)));
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TmpVector);
		this.TmpVector2.DeepCopy(this.ActorComp.ActorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector2, (double)(-(double)this.ActorComp.ScaledHalfHeight));
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector2);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		if (!TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "slide", "slide"))
		{
			return null;
		}
		return actorTrace.HitResult;
	}

	// Token: 0x0601AE1F RID: 110111 RVA: 0x0074608C File Offset: 0x0074428C
	private bool TraceDetect()
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = this.ActorComp.ScaledRadius;
		this.TmpVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)(-(double)(this.ActorComp.ScaledHalfHeight - this.ActorComp.ScaledRadius)));
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TmpVector);
		this.ActorComp.MoveComp.GravityUp.CrossProduct(this.SlideForward, this.TmpVector3);
		this.TmpVector3.CrossProduct(this.SlideForward, this.TmpVector3);
		this.TmpVector3.Normalize(9.99999993922529E-09);
		this.TmpVector3.MultiplyEqual(100.0);
		this.TmpVector.Addition(this.TmpVector3, this.TmpVector2);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector2);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		if (TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "slide", "slide"))
		{
			TraceElementCommon.Instance.GetImpactNormal(actorTrace.HitResult, 0, this.TmpVector3);
			this.TmpVector3.AdditionEqual(this.SlideForward);
			return this.TmpVector3.Normalize(9.99999993922529E-09) && GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVector3) < 0.7070000171661377;
		}
		return true;
	}

	// Token: 0x0601AE20 RID: 110112 RVA: 0x00746290 File Offset: 0x00744490
	private bool TraceDetect2()
	{
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = this.ActorComp.Actor;
		actorTrace.Radius = this.ActorComp.ScaledRadius;
		this.TmpVector.DeepCopy(this.ActorComp.ActorLocationProxy);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)(-(double)(this.ActorComp.ScaledHalfHeight - this.ActorComp.ScaledRadius)));
		TraceElementCommon.Instance.SetStartLocation(actorTrace, this.TmpVector);
		this.ActorComp.MoveComp.GravityUp.CrossProduct(this.SlideForward, this.TmpVector3);
		this.TmpVector3.CrossProduct(this.SlideForward, this.TmpVector3);
		this.TmpVector3.Normalize(9.99999993922529E-09);
		this.TmpVector3.MultiplyEqual(100.0);
		this.TmpVector.Addition(this.TmpVector3, this.TmpVector2);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, this.TmpVector2);
		actorTrace.ActorsToIgnore.Empty(true);
		foreach (AActor value in WorldModel.Instance.ActorsToIgnoreSet)
		{
			actorTrace.ActorsToIgnore.Add(value);
		}
		if (!TraceElementCommon.Instance.ShapeTrace(this.ActorComp.Actor.CapsuleComponent, actorTrace, "slide", "slide"))
		{
			return true;
		}
		TraceElementCommon.Instance.GetImpactNormal(actorTrace.HitResult, 0, this.TmpVector3);
		this.TmpVector3.AdditionEqual(this.SlideForward);
		return this.TmpVector3.Normalize(9.99999993922529E-09);
	}

	// Token: 0x0601AE21 RID: 110113 RVA: 0x00746474 File Offset: 0x00744674
	public void OnJump()
	{
		if (this.ActorComp == null)
		{
			return;
		}
		this.VelocityBeforeJump.DeepCopy(this.ActorComp.ActorVelocityProxy);
		this.TmpVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
		this.CacheBlockDirect.Multiply(this.TmpVector.DotProduct(this.CacheBlockDirect), this.TmpVector2);
		this.TmpVector.Subtraction(this.TmpVector2, this.TmpVector3);
		CharacterMoveComponent moveComp = this.MoveComp;
		this.JumpAddMoveHandler = ((moveComp != null) ? new int?(moveComp.SetAddMoveWorld(new FVectorDouble?(this.TmpVector3.ToUeVector(false)), 2f, null, this.JumpAddMoveHandler, null, EVelocityCurveType.LinearityDown, 0f, 1f)) : null);
		this.MoveComp.SetTurnRate(this.SkiConfig.JumpTurnRate);
		this.TagComp.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑雪"], new BaseTagComponent.TTagSwitchedCallback(this.OnExitSkiWhenJump), null);
	}

	// Token: 0x0601AE22 RID: 110114 RVA: 0x00746584 File Offset: 0x00744784
	public void SetSkiAccel(IAccelerateSkiConfig config)
	{
		CharacterUnifiedStateComponent unifiedStateComp = this.UnifiedStateComp;
		if (unifiedStateComp == null || unifiedStateComp.PositionState > global::ECharPositionState.Ground)
		{
			CharacterUnifiedStateComponent unifiedStateComp2 = this.UnifiedStateComp;
			if (unifiedStateComp2 == null || unifiedStateComp2.MoveState != global::ECharMoveState.NormalSki)
			{
				return;
			}
		}
		this.SkiAccelCountDown = (float)config.Duration;
		this.SkiAccelConfig = config;
		int? instantSpeed = this.SkiAccelConfig.InstantSpeed;
		if (instantSpeed != null && instantSpeed.GetValueOrDefault() != 0)
		{
			double inB = Math.Min(this.ActorComp.ActorVelocityProxy.Size() + (double)this.SkiAccelConfig.InstantSpeed.Value, 3500.0);
			this.TmpVector.DeepCopy(this.ActorComp.ActorVelocityProxy);
			if (!this.TmpVector.Normalize(9.99999993922529E-09))
			{
				this.TmpVector.DeepCopy(this.ActorComp.ActorForwardProxy);
			}
			this.TmpVector.MultiplyEqual(inB);
			this.MoveComp.SetForceSpeed(this.TmpVector);
		}
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.滑雪加速"]));
	}

	// Token: 0x0601AE23 RID: 110115 RVA: 0x007466B0 File Offset: 0x007448B0
	public void TickSlideMode(float delta)
	{
		if (this.ExitSlideThisFrame)
		{
			this.ExitSlideThisFrame = false;
			return;
		}
		if (this.DisableTagSet.Count <= 0)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null || !animComp.Valid || !animComp.HasKuroRootMotion)
			{
				bool flag = false;
				FVector fvector = this.MoveComp.CharacterMovement.Kuro_GetBlockDirectWhenMove();
				this.TmpVector.FromUeVector(fvector);
				AActor aactor = this.MoveComp.CharacterMovement.Kuro_GetBlockActorWhenMove();
				int instanceIndex = this.MoveComp.CharacterMovement.Kuro_GetKuroBlockHitIndexWhenMove();
				Slide slideConfig = CharacterSlideComponent.SlideConfig;
				this.GroundNormal.Reset();
				global::Vector tmpVector = this.TmpVector3;
				FVector velocity = this.MoveComp.CharacterMovement.Velocity;
				tmpVector.FromUeVector(velocity);
				if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVector) > 0.10000000149011612 && (this.SkiConfig != null || GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVector3) < -0.0001) && aactor != null && !UKuroCollisionLibrary.ActorHasTag(aactor, CharacterNameDefines.Instance.NO_SLIDE, instanceIndex))
				{
					this.SlideForward.FromUeVector(fvector);
					this.GroundNormal.DeepCopy(this.SlideForward);
					if (this.UnifiedStateComp.MoveState != global::ECharMoveState.Slide && !this.TraceDetect())
					{
						return;
					}
					if (this.UnifiedStateComp.MoveState != global::ECharMoveState.Slide)
					{
						CharacterActorComponent actorComp = this.ActorComp;
						if (actorComp != null)
						{
							actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
							{
								Mode = EMovementMode.MOVE_Custom,
								CustomMode = 4,
								Context = "[CharacterSlideComponent.TickSlideMode]"
							});
						}
						this.UnifiedStateComp.SetMoveState(global::ECharMoveState.Slide);
						flag = true;
						this.LastZ = 0f;
						this.LeaveSlideCountDown = 0.25f;
					}
				}
				else if (this.UnifiedStateComp.MoveState != global::ECharMoveState.Slide)
				{
					return;
				}
				double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.SlideForward);
				if (Math.Abs((double)this.LastZ - znInGravityForActor) > 0.0001)
				{
					this.LastZ = (float)znInGravityForActor;
					this.CurrentAirFriction = CharacterSlideComponent.GetSlideFallingFriction(this.LastZ);
				}
				this.SetInputRotator(flag);
				this.FindStandMode(flag, slideConfig);
				return;
			}
		}
		if (this.UnifiedStateComp.MoveState == global::ECharMoveState.Slide)
		{
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 == null)
			{
				return;
			}
			actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Falling,
				Context = "[CharacterSlideComponent.TickSlideMode]"
			});
		}
	}

	// Token: 0x0601AE24 RID: 110116 RVA: 0x00746920 File Offset: 0x00744B20
	public void TickSkiMode(float delta)
	{
		if (this.SkiAccelCountDown > 0f)
		{
			float customTimeDilation = this.ActorComp.Owner.CustomTimeDilation;
			this.SkiAccelCountDown -= delta * 0.001f * customTimeDilation;
			if (this.SkiAccelCountDown < 0f)
			{
				this.SkiAccelCountDown = 0f;
				this.SkiAccelConfig = null;
				this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.滑雪加速"]));
			}
		}
		if (this.ExitSlideThisFrame)
		{
			this.ExitSlideThisFrame = false;
			return;
		}
		CharacterWalkOnWaterComponent component = base.Entity.GetComponent<CharacterWalkOnWaterComponent>();
		if (component != null && component.IsActive && component.WalkOnWaterStage != EWalkOnWaterStage.WalkOnWaterSurface)
		{
			return;
		}
		if (this.UnifiedStateComp.PositionState != global::ECharPositionState.Ground && this.UnifiedStateComp.PositionState != global::ECharPositionState.Floating && this.UnifiedStateComp.PositionState != global::ECharPositionState.Ski)
		{
			return;
		}
		if (this.DisableTagSet.Count <= 0)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp == null || !animComp.Valid || !animComp.HasKuroRootMotion)
			{
				this.GroundNormal.Reset();
				global::Vector tmpVector = this.TmpVector3;
				FVector velocity = this.MoveComp.CharacterMovement.Velocity;
				tmpVector.FromUeVector(velocity);
				bool flag = false;
				UKuroHitResult ukuroHitResult = this.DetectFloor();
				if (ukuroHitResult == null)
				{
					this.CacheBlockComp = null;
					this.CacheBlockActor = null;
					this.CacheBlockIndex = 0;
					this.CacheBlockDirect.Reset();
				}
				else
				{
					this.CacheBlockComp = ukuroHitResult.Components.Get(0);
					UPrimitiveComponent cacheBlockComp = this.CacheBlockComp;
					this.CacheBlockActor = ((cacheBlockComp != null) ? cacheBlockComp.GetOwner() : null);
					this.CacheBlockIndex = ukuroHitResult.ItemArray.Get(0);
					TraceElementCommon.Instance.GetImpactNormal(ukuroHitResult, 0, this.CacheBlockDirect);
				}
				if (this.CheckSkiCondition())
				{
					this.SlideForward.DeepCopy(this.CacheBlockDirect);
					this.GroundNormal.DeepCopy(this.SlideForward);
					if (this.SkiNeedSetBase)
					{
						UKuroStaticLibrary.SetBaseAndSaveBaseLocation(this.ActorComp.Actor.CharacterMovement, this.CacheBlockComp);
					}
					if (this.UnifiedStateComp.MoveState != global::ECharMoveState.NormalSki)
					{
						if (!this.TraceDetect2())
						{
							return;
						}
						UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
						CharacterAnimationComponent component2 = base.Entity.GetComponent<CharacterAnimationComponent>();
						TraceElementCommon.Instance.GetHitLocation(actorTrace.HitResult, 0, this.TmpVector);
						if (component2 != null)
						{
							component2.SetLocationAndRotatorWithModelBuffer(this.TmpVector.ToUeVector(false), this.ActorComp.ActorRotation, 300f, "CharacterSlideComp.EnterSki", ESetRotationPriority.Anim, true);
						}
						CharacterMoveComponent moveComp = this.MoveComp;
						if (moveComp != null)
						{
							CharacterActorComponent actorComp = moveComp.ActorComp;
							if (actorComp != null)
							{
								actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
								{
									Mode = EMovementMode.MOVE_Custom,
									CustomMode = 8,
									Context = "[CharacterSlideComponent.TickSkiMode]"
								});
							}
						}
						this.UnifiedStateComp.SetMoveState(global::ECharMoveState.NormalSki);
						flag = true;
						this.LastZ = 0f;
					}
				}
				else if (this.UnifiedStateComp.MoveState != global::ECharMoveState.NormalSki)
				{
					return;
				}
				Slide slideConfig = CharacterSlideComponent.SlideConfig;
				this.SetInputRotator(flag);
				this.FindStandMode(flag, slideConfig);
				return;
			}
		}
		if (this.UnifiedStateComp.MoveState == global::ECharMoveState.NormalSki)
		{
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Walking,
					Context = "[CharacterSlideComponent.TickSkiMode]"
				});
			}
			this.UnifiedStateComp.SetMoveState(global::ECharMoveState.Run);
		}
	}

	// Token: 0x0601AE25 RID: 110117 RVA: 0x00746C68 File Offset: 0x00744E68
	public void EnterSkiMode(IOpenSkiConfig config, bool needSetBase = false)
	{
		if (this.SkiConfig != null)
		{
			return;
		}
		if (!this.InitSkiParams(config))
		{
			return;
		}
		this.ApplySkiSpecialSettings();
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑雪"]));
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
		this.IsInSkiMode = true;
		this.NeedInitSpeed = true;
		this.SkiNeedSetBase = needSetBase;
		this.LeaveSlideCountDown = 3f;
		this.VelocityBeforeJump.Reset();
		this.EnterSkiModeRequest();
	}

	// Token: 0x0601AE26 RID: 110118 RVA: 0x00746D00 File Offset: 0x00744F00
	public void ExitSkiMode(bool sync = true)
	{
		if (this.SkiConfig == null)
		{
			return;
		}
		this.RemoveSkiSpecialSettings();
		this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑雪"]));
		this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
		this.SkiConfig = null;
		this.NeedInitSpeed = false;
		this.SkiNeedSetBase = false;
		this.IsInSkiMode = false;
		this.VelocityBeforeJump.Reset();
		if (this.UnifiedStateComp.PositionState == global::ECharPositionState.Ski)
		{
			if (this.DetectFloor() != null)
			{
				CharacterActorComponent actorComp = this.ActorComp;
				if (actorComp != null)
				{
					actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Walking,
						Context = "[CharacterSlideComponent.ExitSkiMode] Walking"
					});
				}
				this.UnifiedStateComp.SetMoveState(global::ECharMoveState.Run);
			}
			else
			{
				CharacterActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 != null)
				{
					actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
					{
						Mode = EMovementMode.MOVE_Falling,
						Context = "[CharacterSlideComponent.ExitSkiMode] Falling"
					});
				}
			}
		}
		if (sync)
		{
			this.ExitSkiModeRequest();
		}
	}

	// Token: 0x0601AE27 RID: 110119 RVA: 0x00746E0C File Offset: 0x0074500C
	private bool CheckSkiCondition()
	{
		return this.CacheBlockComp != null && (this.CacheBlockActor == null || !UKuroCollisionLibrary.ActorHasTag(this.CacheBlockActor, CharacterNameDefines.Instance.NO_SLIDE, this.CacheBlockIndex)) && !this.CacheBlockDirect.ContainsNaN() && GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.CacheBlockDirect) != 0.0 && (float)Math.Acos(global::Vector.DotProduct(this.CacheBlockDirect, this.ActorComp.MoveComp.GravityUp)) * 57.29578f < 75f;
	}

	// Token: 0x0601AE28 RID: 110120 RVA: 0x00746EAC File Offset: 0x007450AC
	private bool CheckSkiException(float delta)
	{
		if ((float)Math.Acos(global::Vector.DotProduct(this.GroundNormal, this.ActorComp.MoveComp.GravityUp)) * 57.29578f >= 75f)
		{
			return false;
		}
		global::Vector tmpVector = this.TmpVector;
		FVectorDouble fvectorDouble = this.ActorComp.Actor.D_K2_GetActorLocation();
		tmpVector.FromUeVector(fvectorDouble);
		if (global::Vector.Dist(this.ActorComp.LastActorLocation, this.TmpVector) < (double)(delta * 20f))
		{
			return false;
		}
		this.LeaveSlideCountDown = 3f;
		return true;
	}

	// Token: 0x0601AE29 RID: 110121 RVA: 0x00746F38 File Offset: 0x00745138
	private void OnExitSkiWhenJump(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			if (this.JumpAddMoveHandler != null)
			{
				this.MoveComp.StopAddMove(this.JumpAddMoveHandler.Value);
			}
			this.MoveComp.ResetTurnRate();
			this.TagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["关卡.关卡运动.关卡运动类型.滑雪"], new BaseTagComponent.TTagSwitchedCallback(this.OnExitSkiWhenJump));
		}
	}

	// Token: 0x0601AE2A RID: 110122 RVA: 0x00746FA0 File Offset: 0x007451A0
	private void EnterSkiModeRequest()
	{
		LevelPlaySwitchSportModeRequest levelPlaySwitchSportModeRequest = LevelPlaySwitchSportModeRequest.Create();
		levelPlaySwitchSportModeRequest.OldSportMode = ELevelPlaySportMode.None;
		levelPlaySwitchSportModeRequest.NewSportMode = ELevelPlaySportMode.Ski;
		Net.Instance.Call(ERequestMessageId.LevelPlaySwitchSportModeRequest, levelPlaySwitchSportModeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			LevelPlaySwitchSportModeResponse levelPlaySwitchSportModeResponse = (LevelPlaySwitchSportModeResponse)msg;
			if (levelPlaySwitchSportModeResponse == null)
			{
				return;
			}
			if (levelPlaySwitchSportModeResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
			{
				global::Log.Instance.Warn(ELogModule.Movement, ELogAuthor.YJX, "请求切换滑雪模式失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ExitSkiMode(false);
			}
		}, 0);
	}

	// Token: 0x0601AE2B RID: 110123 RVA: 0x00746FE0 File Offset: 0x007451E0
	private void ExitSkiModeRequest()
	{
		LevelPlaySwitchSportModeRequest levelPlaySwitchSportModeRequest = LevelPlaySwitchSportModeRequest.Create();
		levelPlaySwitchSportModeRequest.OldSportMode = ELevelPlaySportMode.Ski;
		levelPlaySwitchSportModeRequest.NewSportMode = ELevelPlaySportMode.None;
		Net.Instance.Call(ERequestMessageId.LevelPlaySwitchSportModeRequest, levelPlaySwitchSportModeRequest, null, 0);
	}

	// Token: 0x0601AE2C RID: 110124 RVA: 0x00747014 File Offset: 0x00745214
	private void ApplySkiSpecialSettings()
	{
		if (this.SkiConfig == null)
		{
			return;
		}
		this.ApplySpecialJumpSettings();
		foreach (int value in this.SkiConfig.TagList)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.AddTag(new int?(value));
			}
		}
	}

	// Token: 0x0601AE2D RID: 110125 RVA: 0x0074708C File Offset: 0x0074528C
	private void RemoveSkiSpecialSettings()
	{
		this.RemoveSpecialJumpSettings();
		foreach (int value in this.SkiConfig.TagList)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp != null)
			{
				tagComp.RemoveTag(new int?(value));
			}
		}
	}

	// Token: 0x0601AE2E RID: 110126 RVA: 0x007470FC File Offset: 0x007452FC
	private void ApplySpecialJumpSettings()
	{
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.超级跳跃"]));
		this.MoveComp.SetFallingHorizontalMaxSpeed(this.SkiConfig.JumpMaxHorizontalSpeed);
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (UKuroStaticLibrary.IsObjectClassByName(uanimInstance, CharacterNameDefines.Instance.ABP_BASEROLE))
		{
			((ABP_BaseRole_C)uanimInstance).设置跳跃速率(this.SkiConfig.JumpTimeScale);
		}
		this.AttributeComp.SetBaseValue(EAttributeType.Jump, 10000f * this.SkiConfig.JumpHeightRate);
	}

	// Token: 0x0601AE2F RID: 110127 RVA: 0x0074719C File Offset: 0x0074539C
	private void RemoveSpecialJumpSettings()
	{
		this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.超级跳跃"]));
		this.MoveComp.ClearFallingHorizontalMaxSpeed();
		CharacterAnimationComponent animComp = this.AnimComp;
		UAnimInstance uanimInstance = (animComp != null) ? animComp.MainAnimInstance : null;
		if (UKuroStaticLibrary.IsObjectClassByName(uanimInstance, CharacterNameDefines.Instance.ABP_BASEROLE))
		{
			((ABP_BaseRole_C)uanimInstance).设置跳跃速率(1f);
		}
		this.AttributeComp.SetBaseValue(EAttributeType.Jump, 10000f);
	}

	// Token: 0x0601AE30 RID: 110128 RVA: 0x00747220 File Offset: 0x00745420
	private unsafe bool InitSkiParams(IOpenSkiConfig config)
	{
		string skiConfig = config.SkiConfig;
		BP_SkiConfig_C bp_SkiConfig_C = ResourceSystem.Instance.Load<BP_SkiConfig_C>(skiConfig, "js_undefined");
		if (bp_SkiConfig_C == null || !bp_SkiConfig_C.IsValid())
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "获取滑雪参数DA失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DaPath", skiConfig);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "PbDataId";
			CharacterActorComponent actorComp = this.ActorComp;
			ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new int?(actorComp.CreatureData.GetPbDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		this.SkiConfig = new SkiParams(bp_SkiConfig_C);
		return true;
	}

	// Token: 0x0601AE31 RID: 110129 RVA: 0x007472DA File Offset: 0x007454DA
	public static void CreateStaticDefaultValue()
	{
		CharacterSlideComponent.SlideConfigInternal = null;
		CharacterSlideComponent.SpeedReduceCurve = null;
		CharacterSlideComponent._jumpAddMoveCurveInternal = null;
		CharacterSlideComponent._SlideFallingCoefficientArray = new float[4];
	}

	// Token: 0x0601AE32 RID: 110130 RVA: 0x007472FE File Offset: 0x007454FE
	public static void ResetStaticDefaultValue()
	{
		CharacterSlideComponent.SlideConfigInternal = null;
		CharacterSlideComponent.SpeedReduceCurve = null;
		CharacterSlideComponent._jumpAddMoveCurveInternal = null;
		CharacterSlideComponent._SlideFallingCoefficientArray = null;
	}

	// Token: 0x0601AE33 RID: 110131 RVA: 0x00747320 File Offset: 0x00745520
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterSlideComponent characterSlideComponent = (CharacterSlideComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterSlideComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterSlideComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (characterSlideComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AttributeComp"))
		{
			if (characterSlideComponent.AttributeComp == null)
			{
				this.AttributeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComp), "AttributeComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedStateComp"))
		{
			if (characterSlideComponent.UnifiedStateComp == null)
			{
				this.UnifiedStateComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterUnifiedStateComponent>(this.UnifiedStateComp), "UnifiedStateComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkillComp"))
		{
			if (characterSlideComponent.SkillComp == null)
			{
				this.SkillComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSkillComponent>(this.SkillComp), "SkillComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TagComp"))
		{
			if (characterSlideComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("InputComp"))
		{
			if (characterSlideComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputComponent>(this.InputComp), "InputComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpVector") && characterSlideComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector), "TmpVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpVector2") && characterSlideComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector2), "TmpVector2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpVector3") && characterSlideComponent.TmpVector3 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector3), "TmpVector3"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpVector4") && characterSlideComponent.TmpVector4 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector4), "TmpVector4"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpVector5") && characterSlideComponent.TmpVector5 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector5), "TmpVector5"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpRotator") && characterSlideComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.TmpRotator), "TmpRotator"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpQuat") && characterSlideComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat), "TmpQuat"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpQuat2") && characterSlideComponent.TmpQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat2), "TmpQuat2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SlideUp") && characterSlideComponent.SlideUp != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SlideUp), "SlideUp"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("LeaveSlideCountDown"))
		{
			this.LeaveSlideCountDown = characterSlideComponent.LeaveSlideCountDown;
		}
		if (base.CanResetComponentProperty("SlideForward") && characterSlideComponent.SlideForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SlideForward), "SlideForward"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("GroundNormal") && characterSlideComponent.GroundNormal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.GroundNormal), "GroundNormal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TagListeners") && characterSlideComponent.TagListeners != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ITagTask>>(this.TagListeners), "TagListeners"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DisableTagSet") && characterSlideComponent.DisableTagSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.DisableTagSet), "DisableTagSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("LastZ"))
		{
			this.LastZ = characterSlideComponent.LastZ;
		}
		if (base.CanResetComponentProperty("CurrentAirFriction"))
		{
			this.CurrentAirFriction = characterSlideComponent.CurrentAirFriction;
		}
		if (base.CanResetComponentProperty("SlideSwitchThisFrame"))
		{
			this.SlideSwitchThisFrame = characterSlideComponent.SlideSwitchThisFrame;
		}
		if (base.CanResetComponentProperty("StandMode"))
		{
			this.StandMode = characterSlideComponent.StandMode;
		}
		if (base.CanResetComponentProperty("LastAngleOffset"))
		{
			this.LastAngleOffset = characterSlideComponent.LastAngleOffset;
		}
		if (base.CanResetComponentProperty("JumpAddMoveHandler"))
		{
			this.JumpAddMoveHandler = characterSlideComponent.JumpAddMoveHandler;
		}
		if (base.CanResetComponentProperty("SkiAccelConfig"))
		{
			if (characterSlideComponent.SkiAccelConfig == null)
			{
				this.SkiAccelConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<IAccelerateSkiConfig>(this.SkiAccelConfig), "SkiAccelConfig"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SkiAccelCountDown"))
		{
			this.SkiAccelCountDown = characterSlideComponent.SkiAccelCountDown;
		}
		if (base.CanResetComponentProperty("SkiConfig"))
		{
			if (characterSlideComponent.SkiConfig == null)
			{
				this.SkiConfig = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SkiParams>(this.SkiConfig), "SkiConfig"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NeedInitSpeed"))
		{
			this.NeedInitSpeed = characterSlideComponent.NeedInitSpeed;
		}
		if (base.CanResetComponentProperty("IsInSkiMode"))
		{
			this.IsInSkiMode = characterSlideComponent.IsInSkiMode;
		}
		if (base.CanResetComponentProperty("CacheBlockActor"))
		{
			if (characterSlideComponent.CacheBlockActor == null)
			{
				this.CacheBlockActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.CacheBlockActor), "CacheBlockActor"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CacheBlockComp"))
		{
			if (characterSlideComponent.CacheBlockComp == null)
			{
				this.CacheBlockComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.CacheBlockComp), "CacheBlockComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CacheBlockIndex"))
		{
			this.CacheBlockIndex = characterSlideComponent.CacheBlockIndex;
		}
		if (base.CanResetComponentProperty("CacheBlockDirect") && characterSlideComponent.CacheBlockDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CacheBlockDirect), "CacheBlockDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("VelocityBeforeJump") && characterSlideComponent.VelocityBeforeJump != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.VelocityBeforeJump), "VelocityBeforeJump"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SkiDirection") && characterSlideComponent.SkiDirection != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SkiDirection), "SkiDirection"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SkiNeedSetBase"))
		{
			this.SkiNeedSetBase = characterSlideComponent.SkiNeedSetBase;
		}
		if (base.CanResetComponentProperty("ExitSlideThisFrame"))
		{
			this.ExitSlideThisFrame = characterSlideComponent.ExitSlideThisFrame;
		}
		return true;
	}

	// Token: 0x0400CFF6 RID: 53238
	private const float LEAVE_SLIDE_TIME = 0.25f;

	// Token: 0x0400CFF7 RID: 53239
	private const float LEAVE_SLIDE_MIN_HEIGHT = 5f;

	// Token: 0x0400CFF8 RID: 53240
	private const string PROFILE_KEY = "slide";

	// Token: 0x0400CFF9 RID: 53241
	private const float CHANGE_FORWARD_ANGLE_THRESHOLD = 135f;

	// Token: 0x0400CFFA RID: 53242
	private const float COMBINE_NORMAL_Z_THRESHOLD = 0.707f;

	// Token: 0x0400CFFB RID: 53243
	private const float SLIDE_Z_THRESHOLD = 0.1f;

	// Token: 0x0400CFFC RID: 53244
	private const float LEAVE_SKI_TIME = 3f;

	// Token: 0x0400CFFD RID: 53245
	private const float SKI_GROUND_MAX_ANGLE = 75f;

	// Token: 0x0400CFFE RID: 53246
	private const float SKI_BRAKE_ANGLE_THRESHOLD = 135f;

	// Token: 0x0400CFFF RID: 53247
	private const float SKI_MAX_INPUT_ANGLE = 135f;

	// Token: 0x0400D000 RID: 53248
	private const float DEFAULT_SKI_MAX_TURN_ANGLE = 50f;

	// Token: 0x0400D001 RID: 53249
	private const float DEFAULT_SKI_MAX_SPEED = 3500f;

	// Token: 0x0400D002 RID: 53250
	private const float DEFAULT_SKI_MIN_SPEED = 20f;

	// Token: 0x0400D003 RID: 53251
	private const float ENTER_SKI_BUFFER_TIME = 300f;

	// Token: 0x0400D004 RID: 53252
	protected static Slide? SlideConfigInternal;

	// Token: 0x0400D005 RID: 53253
	[Nullable(2)]
	private static float[] _SlideFallingCoefficientArray;

	// Token: 0x0400D006 RID: 53254
	[Nullable(2)]
	protected static UCurveFloat SpeedReduceCurve;

	// Token: 0x0400D007 RID: 53255
	[Nullable(2)]
	private static UCurveFloat _jumpAddMoveCurveInternal;

	// Token: 0x0400D008 RID: 53256
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D009 RID: 53257
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D00A RID: 53258
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D00B RID: 53259
	[Nullable(2)]
	private BaseAttributeComponent AttributeComp;

	// Token: 0x0400D00C RID: 53260
	[Nullable(2)]
	private CharacterUnifiedStateComponent UnifiedStateComp;

	// Token: 0x0400D00D RID: 53261
	[Nullable(2)]
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400D00E RID: 53262
	[Nullable(2)]
	private BaseTagComponent TagComp;

	// Token: 0x0400D00F RID: 53263
	[Nullable(2)]
	private CharacterInputComponent InputComp;

	// Token: 0x0400D010 RID: 53264
	private readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400D011 RID: 53265
	private readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400D012 RID: 53266
	private readonly global::Vector TmpVector3 = global::Vector.Create();

	// Token: 0x0400D013 RID: 53267
	private readonly global::Vector TmpVector4 = global::Vector.Create();

	// Token: 0x0400D014 RID: 53268
	private readonly global::Vector TmpVector5 = global::Vector.Create();

	// Token: 0x0400D015 RID: 53269
	private readonly global::Rotator TmpRotator = global::Rotator.Create();

	// Token: 0x0400D016 RID: 53270
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D017 RID: 53271
	private readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D018 RID: 53272
	private readonly global::Vector SlideUp = global::Vector.Create();

	// Token: 0x0400D019 RID: 53273
	private float LeaveSlideCountDown;

	// Token: 0x0400D01A RID: 53274
	public readonly global::Vector SlideForward = global::Vector.Create();

	// Token: 0x0400D01B RID: 53275
	public readonly global::Vector GroundNormal = global::Vector.Create();

	// Token: 0x0400D01C RID: 53276
	private readonly List<ITagTask> TagListeners = new List<ITagTask>();

	// Token: 0x0400D01D RID: 53277
	private readonly HashSet<int> DisableTagSet = new HashSet<int>();

	// Token: 0x0400D01E RID: 53278
	private float LastZ;

	// Token: 0x0400D01F RID: 53279
	private float CurrentAirFriction;

	// Token: 0x0400D020 RID: 53280
	public bool SlideSwitchThisFrame;

	// Token: 0x0400D021 RID: 53281
	public bool StandMode;

	// Token: 0x0400D022 RID: 53282
	public float LastAngleOffset;

	// Token: 0x0400D023 RID: 53283
	private int? JumpAddMoveHandler;

	// Token: 0x0400D024 RID: 53284
	[Nullable(2)]
	private IAccelerateSkiConfig SkiAccelConfig;

	// Token: 0x0400D025 RID: 53285
	private float SkiAccelCountDown;

	// Token: 0x0400D026 RID: 53286
	[Nullable(2)]
	private SkiParams SkiConfig;

	// Token: 0x0400D027 RID: 53287
	private bool NeedInitSpeed;

	// Token: 0x0400D028 RID: 53288
	private bool IsInSkiMode;

	// Token: 0x0400D029 RID: 53289
	[Nullable(2)]
	private AActor CacheBlockActor;

	// Token: 0x0400D02A RID: 53290
	[Nullable(2)]
	private UPrimitiveComponent CacheBlockComp;

	// Token: 0x0400D02B RID: 53291
	private int CacheBlockIndex;

	// Token: 0x0400D02C RID: 53292
	private readonly global::Vector CacheBlockDirect = global::Vector.Create();

	// Token: 0x0400D02D RID: 53293
	private readonly global::Vector VelocityBeforeJump = global::Vector.Create();

	// Token: 0x0400D02E RID: 53294
	private readonly global::Vector SkiDirection = global::Vector.Create();

	// Token: 0x0400D02F RID: 53295
	[StaticVariableRuleIgnore]
	private static readonly int[] DisableTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.濒死"],
		GameplayTagDefine.EGameplayTagId["Damage.Frozen"]
	};

	// Token: 0x0400D030 RID: 53296
	private bool SkiNeedSetBase;

	// Token: 0x0400D031 RID: 53297
	private bool ExitSlideThisFrame;
}
