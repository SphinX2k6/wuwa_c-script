using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.LevelGamePlay.Common;
using UnrealEngine;

// Token: 0x02000225 RID: 549
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraSplineMoveController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x0600220D RID: 8717 RVA: 0x000C7525 File Offset: 0x000C5725
	public CameraSplineMoveController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000C7565 File Offset: 0x000C5765
	public override string Name()
	{
		return "SplineMoveController";
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000C756C File Offset: 0x000C576C
	protected override void OnInit()
	{
		base.Lock(this);
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000C7578 File Offset: 0x000C5778
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

	// Token: 0x06002211 RID: 8721 RVA: 0x000C761C File Offset: 0x000C581C
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

	// Token: 0x06002212 RID: 8722 RVA: 0x000C7714 File Offset: 0x000C5914
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

	// Token: 0x06002213 RID: 8723 RVA: 0x000C777C File Offset: 0x000C597C
	protected override void OnEnable()
	{
		this.Camera.CameraAdjustController.Lock(this);
		this.Camera.CameraInputController.Lock(this);
		this.Camera.CameraClimbController.Lock(this);
		this.Camera.CameraFocusController.Lock(this);
		this.Camera.CameraModifyController.Lock(this);
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x000C77E0 File Offset: 0x000C59E0
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

	// Token: 0x06002215 RID: 8725 RVA: 0x000C7850 File Offset: 0x000C5A50
	private void StartRollFadeOut()
	{
		this.CurrentFadeOut = 0f;
		this.RollFadeOutStart = CameraUtility.GetRollInGravity(this.Camera.DesiredCamera.ArmRotation);
		this.IsRollFadeOut = true;
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x000C7880 File Offset: 0x000C5A80
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

	// Token: 0x06002217 RID: 8727 RVA: 0x000C7978 File Offset: 0x000C5B78
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

	// Token: 0x06002218 RID: 8728 RVA: 0x000C7BBD File Offset: 0x000C5DBD
	protected override void UpdateDeactivateInternal(float deltaTime)
	{
		this.UpdateRollFadeOut(deltaTime);
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x000C7BC8 File Offset: 0x000C5DC8
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

	// Token: 0x0600221A RID: 8730 RVA: 0x000C7C28 File Offset: 0x000C5E28
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x000C7C34 File Offset: 0x000C5E34
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

	// Token: 0x0600221C RID: 8732 RVA: 0x000C7FAC File Offset: 0x000C61AC
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

	// Token: 0x0600221D RID: 8733 RVA: 0x000C84C3 File Offset: 0x000C66C3
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraSplineMoveController.<MemberIter>d__35 <MemberIter>d__ = new CameraSplineMoveController.<MemberIter>d__35(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x0400163A RID: 5690
	protected float YawAngle;

	// Token: 0x0400163B RID: 5691
	protected float PitchAngle;

	// Token: 0x0400163C RID: 5692
	protected float RollAngle;

	// Token: 0x0400163D RID: 5693
	protected float FadeInTime;

	// Token: 0x0400163E RID: 5694
	protected int? SplineId;

	// Token: 0x0400163F RID: 5695
	[Nullable(2)]
	protected USplineComponent Spline;

	// Token: 0x04001640 RID: 5696
	protected bool? IsSyncRoll;

	// Token: 0x04001641 RID: 5697
	private bool IsModifyingRoll;

	// Token: 0x04001642 RID: 5698
	private const float ROLL_FADE_OUT_TIME = 0.1f;

	// Token: 0x04001643 RID: 5699
	private readonly bool IsDebugSyncRoll;

	// Token: 0x04001644 RID: 5700
	private readonly Rotator StartRotator = Rotator.Create();

	// Token: 0x04001645 RID: 5701
	private readonly Vector SplineDirect = Vector.Create();

	// Token: 0x04001646 RID: 5702
	private readonly Vector SplineUp = Vector.Create();

	// Token: 0x04001647 RID: 5703
	private float CurrentFadeIn;

	// Token: 0x04001648 RID: 5704
	private float CurrentFadeOut;

	// Token: 0x04001649 RID: 5705
	private float RollFadeOutStart;

	// Token: 0x0400164A RID: 5706
	private bool IsRollFadeOut;

	// Token: 0x0400164B RID: 5707
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x0400164C RID: 5708
	private readonly Rotator TmpRotator2 = Rotator.Create();
}
