using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

// Token: 0x02000221 RID: 545
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraSplineMoveController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x0600215F RID: 8543 RVA: 0x000C0205 File Offset: 0x000BE405
	public CameraSplineMoveController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002160 RID: 8544 RVA: 0x000C0245 File Offset: 0x000BE445
	public override string Name()
	{
		return "SplineMoveController";
	}

	// Token: 0x06002161 RID: 8545 RVA: 0x000C024C File Offset: 0x000BE44C
	protected override void OnInit()
	{
		base.Lock(this);
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x000C0258 File Offset: 0x000BE458
	public void ApplyCameraSpline(int splineId, float yawAngle, float pitchAngle, float fadeInTime, bool? isSyncRoll, float? rollAngle = 0f)
	{
		int? splineId2 = this.SplineId;
		if (splineId2.GetValueOrDefault() == splineId & splineId2 != null)
		{
			this.ApplyCameraSplineInternal(splineId, this.Spline, yawAngle, pitchAngle, fadeInTime, isSyncRoll, rollAngle);
			return;
		}
		if (this.SplineId != null)
		{
			GameSplineModel.Instance.ReleaseSpline(this.SplineId.Value, (long)this.Camera.Entity.Id, EIdType.EntityId);
		}
		USplineComponent spline = GameSplineModel.Instance.LoadAndGetSplineComponent(splineId, this.Camera.Entity.Id, EIdType.EntityId);
		this.ApplyCameraSplineInternal(splineId, spline, yawAngle, pitchAngle, fadeInTime, isSyncRoll, rollAngle);
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x000C02FC File Offset: 0x000BE4FC
	[NullableContext(2)]
	public void ApplyCameraSplineInternal(int splineId, USplineComponent spline, float yawAngle, float pitchAngle, float fadeInTime, bool? isSyncRoll, float? rollAngle = 0f)
	{
		if (this.SplineId == null)
		{
			base.Unlock(this);
		}
		this.TmpRotator.Set(pitchAngle, yawAngle, rollAngle.GetValueOrDefault());
		CameraUtility.GetRotatorInGravity(this.TmpRotator, this.TmpRotator);
		this.SplineId = new int?(splineId);
		this.Spline = spline;
		this.YawAngle = this.TmpRotator.Yaw;
		this.PitchAngle = this.TmpRotator.Pitch;
		this.RollAngle = ((isSyncRoll != null && isSyncRoll.Value) ? this.TmpRotator.Roll : 0f);
		this.FadeInTime = fadeInTime;
		this.CurrentFadeIn = 0f;
		this.CurrentFadeOut = 0f;
		this.RollFadeOutStart = 0f;
		this.IsRollFadeOut = false;
		this.IsSyncRoll = isSyncRoll;
		this.StartRotator.DeepCopy(this.Camera.CameraRotationInGravity);
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x000C03F4 File Offset: 0x000BE5F4
	public void EndCameraSpline()
	{
		if (this.SplineId == null)
		{
			return;
		}
		GameSplineModel.Instance.ReleaseSpline(this.SplineId.Value, (long)this.Camera.Entity.Id, EIdType.EntityId);
		this.SplineId = null;
		this.Spline = null;
		this.IsSyncRoll = null;
		base.Lock(this);
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x000C045C File Offset: 0x000BE65C
	protected override void OnEnable()
	{
		this.Camera.CameraAdjustController.Lock(this);
		this.Camera.CameraInputController.Lock(this);
		this.Camera.CameraClimbController.Lock(this);
		this.Camera.CameraFocusController.Lock(this);
		this.Camera.CameraModifyController.Lock(this);
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x000C04C0 File Offset: 0x000BE6C0
	protected override void OnDisable()
	{
		this.Camera.CameraAdjustController.Unlock(this);
		this.Camera.CameraInputController.Unlock(this);
		this.Camera.CameraClimbController.Unlock(this);
		this.Camera.CameraFocusController.Unlock(this);
		this.Camera.CameraModifyController.Unlock(this);
		if (this.IsModifyingRoll)
		{
			this.StartRollFadeOut();
		}
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x000C0530 File Offset: 0x000BE730
	private void StartRollFadeOut()
	{
		this.CurrentFadeOut = 0f;
		this.RollFadeOutStart = CameraUtility.GetRollInGravity(this.Camera.DesiredCamera.ArmRotation);
		this.IsRollFadeOut = true;
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x000C0560 File Offset: 0x000BE760
	private void UpdateRollFadeOut(float deltaTime)
	{
		if (!this.IsRollFadeOut)
		{
			return;
		}
		this.CurrentFadeOut = Math.Min(0.1f, this.CurrentFadeOut + deltaTime);
		float alpha = (float)MathUtils.Instance.GetCubicValue((double)(this.CurrentFadeOut / 0.1f));
		CameraUtility.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
		this.TmpRotator.Roll = Rotator.AxisLerp(this.RollFadeOutStart, 0f, alpha);
		CameraUtility.SetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
		if (this.CurrentFadeOut >= 0.1f)
		{
			this.CurrentFadeOut = 0f;
			this.RollFadeOutStart = 0f;
			this.IsRollFadeOut = false;
			this.TmpRotator.Roll = 0f;
			CameraUtility.SetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
		}
		this.CheckAndApplyRollSuppression();
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x000C0658 File Offset: 0x000BE858
	protected unsafe override void UpdateInternal(float deltaTime)
	{
		if (this.Spline == null || Global.BaseCharacter == null)
		{
			return;
		}
		USplineComponent spline = this.Spline;
		FVectorDouble fvectorDouble = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy.ToUeVector(false);
		float inKey = spline.D_FindInputKeyClosestToWorldLocation(fvectorDouble);
		Vector splineDirect = this.SplineDirect;
		FVector fvector = this.Spline.GetDirectionAtSplineInputKey(inKey, ESplineCoordinateSpace.World);
		splineDirect.FromUeVector(fvector);
		CameraUtility.GetVectorInGravity(this.SplineDirect, this.SplineDirect);
		float num = (float)(this.SplineDirect.HeadingAngle() * 57.295780181884766);
		float num2 = 0f;
		if (this.IsSyncRoll != null && this.IsSyncRoll.Value)
		{
			Vector splineUp = this.SplineUp;
			fvector = this.Spline.GetUpVectorAtSplineInputKey(inKey, ESplineCoordinateSpace.World);
			splineUp.FromUeVector(fvector);
			CameraUtility.GetVectorInGravity(this.SplineUp, this.SplineUp);
			MathUtils.Instance.LookRotationForwardFirst(this.SplineDirect, this.SplineUp, this.TmpRotator2);
			num2 = this.TmpRotator2.Roll;
		}
		if (this.CurrentFadeIn < this.FadeInTime)
		{
			this.CurrentFadeIn = Math.Min(this.FadeInTime, this.CurrentFadeIn + deltaTime);
			float alpha = (float)MathUtils.Instance.GetCubicValue((double)(this.CurrentFadeIn / this.FadeInTime));
			this.TmpRotator.Set(this.PitchAngle, num + this.YawAngle, num2 + this.RollAngle);
			Rotator.Lerp(this.StartRotator, this.TmpRotator, alpha, this.TmpRotator);
		}
		else
		{
			this.TmpRotator.Set(this.PitchAngle, num + this.YawAngle, num2 + this.RollAngle);
		}
		CameraUtility.SetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.TmpRotator);
		this.Camera.IsModifiedArmRotationPitch = true;
		this.Camera.IsModifiedArmRotationYaw = true;
		this.CheckAndApplyRollSuppression();
		if (this.IsDebugSyncRoll)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "CameraSplineMoveController Update";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("SplineRoll", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FinalRoll", this.TmpRotator.Roll);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x000C089D File Offset: 0x000BEA9D
	protected override void UpdateDeactivateInternal(float deltaTime)
	{
		this.UpdateRollFadeOut(deltaTime);
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x000C08A8 File Offset: 0x000BEAA8
	private void CheckAndApplyRollSuppression()
	{
		this.IsModifyingRoll = !MathUtils.Instance.IsNearlyZero((double)CameraUtility.GetRollInGravity(this.Camera.DesiredCamera.ArmRotation), null);
		if (this.IsModifyingRoll)
		{
			this.Camera.SetSuppressClearRoll(ESuppressClearRollFlag.SplineMove);
			return;
		}
		this.Camera.ClearSuppressClearRoll(ESuppressClearRollFlag.SplineMove);
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x000C0908 File Offset: 0x000BEB08
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x000C0914 File Offset: 0x000BEB14
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 6:
				if (key == "Spline")
				{
					value = this.Spline;
					return true;
				}
				break;
			case 8:
			{
				char c = key[6];
				if (c != 'I')
				{
					if (c != 'U')
					{
						if (c == 'l')
						{
							if (key == "YawAngle")
							{
								value = this.YawAngle;
								return true;
							}
						}
					}
					else if (key == "SplineUp")
					{
						value = this.SplineUp;
						return true;
					}
				}
				else if (key == "SplineId")
				{
					value = this.SplineId;
					return true;
				}
				break;
			}
			case 9:
				if (key == "RollAngle")
				{
					value = this.RollAngle;
					return true;
				}
				break;
			case 10:
			{
				char c = key[0];
				if (c <= 'I')
				{
					if (c != 'F')
					{
						if (c == 'I')
						{
							if (key == "IsSyncRoll")
							{
								value = this.IsSyncRoll;
								return true;
							}
						}
					}
					else if (key == "FadeInTime")
					{
						value = this.FadeInTime;
						return true;
					}
				}
				else if (c != 'P')
				{
					if (c == 'T')
					{
						if (key == "TmpRotator")
						{
							value = this.TmpRotator;
							return true;
						}
					}
				}
				else if (key == "PitchAngle")
				{
					value = this.PitchAngle;
					return true;
				}
				break;
			}
			case 11:
				if (key == "TmpRotator2")
				{
					value = this.TmpRotator2;
					return true;
				}
				break;
			case 12:
			{
				char c = key[1];
				if (c != 'p')
				{
					if (c == 't')
					{
						if (key == "StartRotator")
						{
							value = this.StartRotator;
							return true;
						}
					}
				}
				else if (key == "SplineDirect")
				{
					value = this.SplineDirect;
					return true;
				}
				break;
			}
			case 13:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'I')
					{
						if (key == "IsRollFadeOut")
						{
							value = this.IsRollFadeOut;
							return true;
						}
					}
				}
				else if (key == "CurrentFadeIn")
				{
					value = this.CurrentFadeIn;
					return true;
				}
				break;
			}
			case 14:
				if (key == "CurrentFadeOut")
				{
					value = this.CurrentFadeOut;
					return true;
				}
				break;
			case 15:
			{
				char c = key[2];
				if (c != 'D')
				{
					if (c == 'M')
					{
						if (key == "IsModifyingRoll")
						{
							value = this.IsModifyingRoll;
							return true;
						}
					}
				}
				else if (key == "IsDebugSyncRoll")
				{
					value = this.IsDebugSyncRoll;
					return true;
				}
				break;
			}
			case 16:
				if (key == "RollFadeOutStart")
				{
					value = this.RollFadeOutStart;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x000C0C8C File Offset: 0x000BEE8C
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 6:
				if (key == "Spline")
				{
					this.Spline = (USplineComponent)value;
					return;
				}
				break;
			case 8:
			{
				char c = key[0];
				if (c != 'S')
				{
					if (c == 'Y')
					{
						if (key == "YawAngle")
						{
							float num2;
							if (value is double)
							{
								double num = (double)value;
								num2 = (float)num;
							}
							else if (value is float)
							{
								float num3 = (float)value;
								num2 = num3;
							}
							else if (value is int)
							{
								int num4 = (int)value;
								num2 = (float)num4;
							}
							else if (value is long)
							{
								long num5 = (long)value;
								num2 = (float)num5;
							}
							else
							{
								num2 = (float)value;
							}
							this.YawAngle = num2;
							return;
						}
					}
				}
				else if (key == "SplineId")
				{
					this.SplineId = (int?)value;
					return;
				}
				break;
			}
			case 9:
				if (key == "RollAngle")
				{
					float num2;
					if (value is double)
					{
						double num6 = (double)value;
						num2 = (float)num6;
					}
					else if (value is float)
					{
						float num7 = (float)value;
						num2 = num7;
					}
					else if (value is int)
					{
						int num8 = (int)value;
						num2 = (float)num8;
					}
					else if (value is long)
					{
						long num9 = (long)value;
						num2 = (float)num9;
					}
					else
					{
						num2 = (float)value;
					}
					this.RollAngle = num2;
					return;
				}
				break;
			case 10:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c != 'I')
					{
						if (c == 'P')
						{
							if (key == "PitchAngle")
							{
								float num2;
								if (value is double)
								{
									double num10 = (double)value;
									num2 = (float)num10;
								}
								else if (value is float)
								{
									float num11 = (float)value;
									num2 = num11;
								}
								else if (value is int)
								{
									int num12 = (int)value;
									num2 = (float)num12;
								}
								else if (value is long)
								{
									long num13 = (long)value;
									num2 = (float)num13;
								}
								else
								{
									num2 = (float)value;
								}
								this.PitchAngle = num2;
								return;
							}
						}
					}
					else if (key == "IsSyncRoll")
					{
						this.IsSyncRoll = (bool?)value;
						return;
					}
				}
				else if (key == "FadeInTime")
				{
					float num2;
					if (value is double)
					{
						double num14 = (double)value;
						num2 = (float)num14;
					}
					else if (value is float)
					{
						float num15 = (float)value;
						num2 = num15;
					}
					else if (value is int)
					{
						int num16 = (int)value;
						num2 = (float)num16;
					}
					else if (value is long)
					{
						long num17 = (long)value;
						num2 = (float)num17;
					}
					else
					{
						num2 = (float)value;
					}
					this.FadeInTime = num2;
					return;
				}
				break;
			}
			case 13:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'I')
					{
						if (key == "IsRollFadeOut")
						{
							this.IsRollFadeOut = (bool)value;
							return;
						}
					}
				}
				else if (key == "CurrentFadeIn")
				{
					float num2;
					if (value is double)
					{
						double num18 = (double)value;
						num2 = (float)num18;
					}
					else if (value is float)
					{
						float num19 = (float)value;
						num2 = num19;
					}
					else if (value is int)
					{
						int num20 = (int)value;
						num2 = (float)num20;
					}
					else if (value is long)
					{
						long num21 = (long)value;
						num2 = (float)num21;
					}
					else
					{
						num2 = (float)value;
					}
					this.CurrentFadeIn = num2;
					return;
				}
				break;
			}
			case 14:
				if (key == "CurrentFadeOut")
				{
					float num2;
					if (value is double)
					{
						double num22 = (double)value;
						num2 = (float)num22;
					}
					else if (value is float)
					{
						float num23 = (float)value;
						num2 = num23;
					}
					else if (value is int)
					{
						int num24 = (int)value;
						num2 = (float)num24;
					}
					else if (value is long)
					{
						long num25 = (long)value;
						num2 = (float)num25;
					}
					else
					{
						num2 = (float)value;
					}
					this.CurrentFadeOut = num2;
					return;
				}
				break;
			case 15:
				if (key == "IsModifyingRoll")
				{
					this.IsModifyingRoll = (bool)value;
					return;
				}
				break;
			case 16:
				if (key == "RollFadeOutStart")
				{
					float num2;
					if (value is double)
					{
						double num26 = (double)value;
						num2 = (float)num26;
					}
					else if (value is float)
					{
						float num27 = (float)value;
						num2 = num27;
					}
					else if (value is int)
					{
						int num28 = (int)value;
						num2 = (float)num28;
					}
					else if (value is long)
					{
						long num29 = (long)value;
						num2 = (float)num29;
					}
					else
					{
						num2 = (float)value;
					}
					this.RollFadeOutStart = num2;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x000C11A3 File Offset: 0x000BF3A3
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraSplineMoveController.<MemberIter>d__35 <MemberIter>d__ = new CameraSplineMoveController.<MemberIter>d__35(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040015F8 RID: 5624
	protected float YawAngle;

	// Token: 0x040015F9 RID: 5625
	protected float PitchAngle;

	// Token: 0x040015FA RID: 5626
	protected float RollAngle;

	// Token: 0x040015FB RID: 5627
	protected float FadeInTime;

	// Token: 0x040015FC RID: 5628
	protected int? SplineId;

	// Token: 0x040015FD RID: 5629
	[Nullable(2)]
	protected USplineComponent Spline;

	// Token: 0x040015FE RID: 5630
	protected bool? IsSyncRoll;

	// Token: 0x040015FF RID: 5631
	private bool IsModifyingRoll;

	// Token: 0x04001600 RID: 5632
	private const float ROLL_FADE_OUT_TIME = 0.1f;

	// Token: 0x04001601 RID: 5633
	private readonly bool IsDebugSyncRoll;

	// Token: 0x04001602 RID: 5634
	private readonly Rotator StartRotator = Rotator.Create();

	// Token: 0x04001603 RID: 5635
	private readonly Vector SplineDirect = Vector.Create();

	// Token: 0x04001604 RID: 5636
	private readonly Vector SplineUp = Vector.Create();

	// Token: 0x04001605 RID: 5637
	private float CurrentFadeIn;

	// Token: 0x04001606 RID: 5638
	private float CurrentFadeOut;

	// Token: 0x04001607 RID: 5639
	private float RollFadeOutStart;

	// Token: 0x04001608 RID: 5640
	private bool IsRollFadeOut;

	// Token: 0x04001609 RID: 5641
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400160A RID: 5642
	private readonly Rotator TmpRotator2 = Rotator.Create();
}
