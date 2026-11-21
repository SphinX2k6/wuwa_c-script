using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x020001F6 RID: 502
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraAutoController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x06002011 RID: 8209 RVA: 0x000A359C File Offset: 0x000A179C
	public CameraAutoController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x000A35F2 File Offset: 0x000A17F2
	public override string Name()
	{
		return "AutoController";
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x000A35FC File Offset: 0x000A17FC
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraAuto.目标比角色更靠近镜头时额外臂长, "AutoCameraArmLengthWhenTargetNearer");
		base.SetConfigMap(EFightCameraAuto.角色屏幕高度参考, "AutoCameraScreenStandardRectangleBottom");
		base.SetConfigMap(EFightCameraAuto.额外臂垂直偏移系数_角色屏幕高度与参考值差_, "AutoCameraArmOffsetRateVertical");
		base.SetConfigMap(EFightCameraAuto.臂长过渡速度, "AutoCameraArmPullLagSpeed");
		base.SetConfigMap(EFightCameraAuto.臂偏移过渡速度, "AutoCameraArmMoveLagSpeed");
		base.SetConfigMap(EFightCameraAuto.检测屏幕内MinX_外_, "CheckAdjustInScreenMinX");
		base.SetConfigMap(EFightCameraAuto.检测屏幕内MaxX_外_, "CheckAdjustInScreenMaxX");
		base.SetConfigMap(EFightCameraAuto.检测屏幕内MinY_外_, "CheckAdjustInScreenMinY");
		base.SetConfigMap(EFightCameraAuto.检测屏幕内MaxY_外_, "CheckAdjustInScreenMaxY");
		base.SetConfigMap(EFightCameraAuto.额外臂垂直偏移速度, "AutoCameraArmOffsetSpeedVertical");
		base.SetConfigMap(EFightCameraAuto.额外臂长最小增量_目标距离_, "ExtraArmLengthMinByDist");
		base.SetConfigMap(EFightCameraAuto.额外臂长最大增量_目标距离_, "ExtraArmLengthMaxByDist");
		base.SetConfigMap(EFightCameraAuto.额外臂长最大距离_目标距离_, "ExtraArmLengthDist");
		base.SetCurveConfigMap(EFightCameraAuto.额外臂长最大距离_目标距离_, "ExtraArmLengthCurveByDist");
		base.SetConfigMap(EFightCameraAuto.额外臂长最小增量_目标高度_, "ExtraArmLengthMinByHeight");
		base.SetConfigMap(EFightCameraAuto.额外臂长最大增量_目标高度_, "ExtraArmLengthMaxByHeight");
		base.SetConfigMap(EFightCameraAuto.额外臂长最大距离_目标高度_, "ExtraArmLengthHeight");
		base.SetCurveConfigMap(EFightCameraAuto.额外臂长最大距离_目标高度_, "ExtraArmLengthCurveByHeight");
		base.SetConfigMap(EFightCameraAuto.额外臂水平偏移最小偏移_目标距离_, "ExtraArmHorizontalMinByDist");
		base.SetConfigMap(EFightCameraAuto.额外臂水平偏移最大偏移_目标距离_, "ExtraArmHorizontalMaxByDist");
		base.SetConfigMap(EFightCameraAuto.额外臂水平偏移最大距离_目标距离_, "ExtraArmHorizontalDist");
		base.SetCurveConfigMap(EFightCameraAuto.额外臂水平偏移最大距离_目标距离_, "ExtraArmHorizontalCurveByDist");
		base.SetConfigMap(EFightCameraAuto.额外臂垂直偏移最小偏移_目标高度差_, "ExtraArmVerticalMinByHeight");
		base.SetConfigMap(EFightCameraAuto.额外臂垂直偏移最大偏移_目标高度差_, "ExtraArmVerticalMaxByHeight");
		base.SetConfigMap(EFightCameraAuto.额外臂垂直偏移与目标最小高度差_目标高度差_, "ExtraArmVerticalHeightMin");
		base.SetConfigMap(EFightCameraAuto.额外臂垂直偏移与目标最大高度差_目标高度差_, "ExtraArmVerticalHeightMax");
		base.SetCurveConfigMap(EFightCameraAuto.额外臂垂直偏移与目标最大高度差_目标高度差_, "ExtraArmVerticalCurveByHeight");
		base.RegisterPairConfigKey(EFightCameraAuto.检测屏幕内MinX_外_, EFightCameraAuto.检测屏幕内MaxX_外_, true);
		base.RegisterPairConfigKey(EFightCameraAuto.检测屏幕内MinY_外_, EFightCameraAuto.检测屏幕内MaxY_外_, true);
		base.RegisterPairConfigKey(EFightCameraAuto.额外臂长最小增量_目标距离_, EFightCameraAuto.额外臂长最大增量_目标距离_, true);
		base.RegisterPairConfigKey(EFightCameraAuto.额外臂长最小增量_目标高度_, EFightCameraAuto.额外臂长最大增量_目标高度_, true);
		base.RegisterPairConfigKey(EFightCameraAuto.额外臂水平偏移最小偏移_目标距离_, EFightCameraAuto.额外臂水平偏移最大偏移_目标距离_, true);
		base.RegisterPairConfigKey(EFightCameraAuto.额外臂垂直偏移最小偏移_目标高度差_, EFightCameraAuto.额外臂垂直偏移最大偏移_目标高度差_, true);
		base.RegisterPairConfigKey(EFightCameraAuto.额外臂垂直偏移与目标最小高度差_目标高度差_, EFightCameraAuto.额外臂垂直偏移与目标最大高度差_目标高度差_, true);
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000A3875 File Offset: 0x000A1A75
	protected override void OnEnable()
	{
		this.DesiredOffsetHeight = 0f;
		this.CurrentOffsetHeight = 0f;
		this.Camera.CameraSidestepController.Lock(this);
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000A389E File Offset: 0x000A1A9E
	protected override void OnDisable()
	{
		this.Camera.CameraSidestepController.Unlock(this);
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000A38B1 File Offset: 0x000A1AB1
	public void EnableForce(object control)
	{
		this.ForceEnableSet.Add(control);
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x000A38C0 File Offset: 0x000A1AC0
	public void DisableForce(object control)
	{
		this.ForceEnableSet.Remove(control);
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000A38D0 File Offset: 0x000A1AD0
	protected override bool UpdateCustomEnableCondition()
	{
		if (this.Camera.TargetEntity == null)
		{
			return false;
		}
		if (this.ForceEnableSet.Count > 0)
		{
			return true;
		}
		CameraUtility.GetSocketLocation(null, this.Camera.TargetSocketName, this.TmpVector, this.Camera.TargetEntity);
		return this.IsActivate && this.Camera.CheckPositionInScreen(this.TmpVector, this.CheckAdjustInScreenMinX, this.CheckAdjustInScreenMaxX, this.CheckAdjustInScreenMinY, this.CheckAdjustInScreenMaxY);
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000A3954 File Offset: 0x000A1B54
	protected override void UpdateInternal(float deltaTime)
	{
		if (this.Camera.TargetEntity == null || !this.Camera.IsTargetLocationValid)
		{
			return;
		}
		Vector playerLocation = this.Camera.PlayerLocation;
		Vector targetLocation = this.Camera.TargetLocation;
		Vector cameraForward = this.Camera.CameraForward;
		Vector vector = Vector.Create();
		targetLocation.Subtraction(playerLocation, vector);
		bool flag = !vector.IsNearlyZero(9.999999747378752E-05) && !cameraForward.IsNearlyZero(9.999999747378752E-05);
		double num = vector.CosineAngle2D(cameraForward, 9.999999747378752E-05);
		double num2 = Vector.Dist(playerLocation, targetLocation);
		CameraUtility.GetVectorInGravity(targetLocation, this.TmpVector);
		this.DesiredAutoCameraArmLengthAddition = MathUtils.Instance.Lerp(this.ExtraArmLengthMinByDist, this.ExtraArmLengthMaxByDist, this.ExtraArmLengthCurveByDist.GetCurrentValue((float)(num2 / (double)this.ExtraArmLengthDist))) + MathUtils.Instance.Lerp(this.ExtraArmLengthMinByHeight, this.ExtraArmLengthMaxByHeight, this.ExtraArmLengthCurveByHeight.GetCurrentValue((float)(Math.Abs(this.Camera.PlayerLocationInGravity.Z - this.TmpVector.Z) / (double)this.ExtraArmLengthHeight)));
		if (flag && num < 0.0)
		{
			this.DesiredAutoCameraArmLengthAddition += this.AutoCameraArmLengthWhenTargetNearer;
		}
		Vector vector2 = Vector.Create();
		Vector tmpVector = this.TmpVector2;
		targetLocation.Subtraction(playerLocation, vector2);
		CameraUtility.GetVectorInGravity(vector2, tmpVector);
		float num3 = MathUtils.Instance.Lerp(this.ExtraArmHorizontalMinByDist, this.ExtraArmHorizontalMaxByDist, this.ExtraArmHorizontalCurveByDist.GetCurrentValue((float)(num2 / (double)this.ExtraArmHorizontalDist)));
		tmpVector.Z = 0.0;
		if (tmpVector.IsNearlyZero(9.999999747378752E-05))
		{
			this.DesiredAutoCameraArmOffset.Reset();
		}
		else
		{
			tmpVector.Multiply((double)num3 / tmpVector.Size2D(), this.DesiredAutoCameraArmOffset);
		}
		double value = this.TmpVector.Z - this.Camera.PlayerLocationInGravity.Z;
		double num4 = (double)MathUtils.Instance.Lerp(this.ExtraArmVerticalMinByHeight, this.ExtraArmVerticalMaxByHeight, this.ExtraArmVerticalCurveByHeight.GetCurrentValue((float)MathUtils.Instance.RangeClamp(value, (double)this.ExtraArmVerticalHeightMin, (double)this.ExtraArmVerticalHeightMax, 0.0, 1.0)));
		double? distanceToScreenCenter = this.GetDistanceToScreenCenter(playerLocation);
		this.DesiredOffsetHeight = (float)(((double)this.AutoCameraScreenStandardRectangleBottom - distanceToScreenCenter) * (double)this.AutoCameraArmOffsetRateVertical).Value;
		double num5 = (double)(this.DesiredOffsetHeight - this.CurrentOffsetHeight);
		this.CurrentOffsetHeight += (float)((Math.Abs(num5) > (double)this.AutoCameraArmOffsetSpeedVertical) ? ((double)((float)Math.Sign(num5) * this.AutoCameraArmOffsetSpeedVertical)) : num5);
		num4 += (double)this.CurrentOffsetHeight;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.DesiredAutoCameraArmOffset.Z = num4;
		}
		else
		{
			CameraUtility.SetZnInGravity(this.DesiredAutoCameraArmOffset, num4, this.DesiredAutoCameraArmOffset);
		}
		this.UpdateInterp(deltaTime, true);
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000A3CA4 File Offset: 0x000A1EA4
	protected override void UpdateDeactivateInternal(float deltaTime)
	{
		this.DesiredAutoCameraArmLengthAddition = 0f;
		this.DesiredAutoCameraArmOffset.Reset();
		this.UpdateInterp(deltaTime, false);
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x000A3CC4 File Offset: 0x000A1EC4
	private void UpdateInterp(float deltaTime, bool isAutoCamera)
	{
		CameraModify modifySettings = this.Camera.CameraModifyController.ModifySettings;
		if ((modifySettings == null || !modifySettings.IsModifiedArmLength) && !this.Camera.CameraModifyController.ModifyFadeOutData.ModifyArmLength)
		{
			this.CurrentAutoCameraArmLengthAddition = (float)MathUtils.Instance.InterpTo((double)this.CurrentAutoCameraArmLengthAddition, (double)this.DesiredAutoCameraArmLengthAddition, (double)deltaTime, (double)this.AutoCameraArmPullLagSpeed);
		}
		CameraModify modifySettings2 = this.Camera.CameraModifyController.ModifySettings;
		if (modifySettings2 == null || !modifySettings2.IsLerpArmLocation)
		{
			MathUtils.Instance.VectorInterpTo(this.CurrentAutoCameraArmOffset, this.DesiredAutoCameraArmOffset, (double)deltaTime, (double)this.AutoCameraArmMoveLagSpeed, this.CurrentAutoCameraArmOffset);
		}
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000A3D78 File Offset: 0x000A1F78
	private double? GetDistanceToScreenCenter(Vector location)
	{
		if (this.Camera.CharacterController == null)
		{
			return new double?(0.0);
		}
		APlayerController characterController = this.Camera.CharacterController;
		FVectorDouble fvectorDouble = location.ToUeVector(false);
		UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ResultPositionRef, false);
		FVector2D resultPositionRef = this.ResultPositionRef;
		int num = 0;
		int num2 = 0;
		this.Camera.CharacterController.GetViewportSize(ref num, ref num2);
		if (MathUtils.Instance.IsNearlyZero((double)num2, new double?(0.0001)))
		{
			return new double?(0.0);
		}
		return new double?((double)(resultPositionRef.Y / (float)num2));
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000A3E1C File Offset: 0x000A201C
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000A3E28 File Offset: 0x000A2028
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 9:
				if (key == "TmpVector")
				{
					value = this.TmpVector;
					return true;
				}
				break;
			case 10:
				if (key == "TmpVector2")
				{
					value = this.TmpVector2;
					return true;
				}
				break;
			case 14:
				if (key == "ForceEnableSet")
				{
					value = this.ForceEnableSet;
					return true;
				}
				break;
			case 17:
				if (key == "ResultPositionRef")
				{
					value = this.ResultPositionRef;
					return true;
				}
				break;
			case 18:
				if (key == "ExtraArmLengthDist")
				{
					value = this.ExtraArmLengthDist;
					return true;
				}
				break;
			case 19:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'D')
					{
						if (key == "DesiredOffsetHeight")
						{
							value = this.DesiredOffsetHeight;
							return true;
						}
					}
				}
				else if (key == "CurrentOffsetHeight")
				{
					value = this.CurrentOffsetHeight;
					return true;
				}
				break;
			}
			case 20:
				if (key == "ExtraArmLengthHeight")
				{
					value = this.ExtraArmLengthHeight;
					return true;
				}
				break;
			case 22:
				if (key == "ExtraArmHorizontalDist")
				{
					value = this.ExtraArmHorizontalDist;
					return true;
				}
				break;
			case 23:
			{
				char c = key[15];
				if (c != 'a')
				{
					if (c != 'i')
					{
						if (c == 'r')
						{
							if (key == "CheckAdjustInScreenMinX")
							{
								value = this.CheckAdjustInScreenMinX;
								return true;
							}
							if (key == "CheckAdjustInScreenMaxX")
							{
								value = this.CheckAdjustInScreenMaxX;
								return true;
							}
							if (key == "CheckAdjustInScreenMinY")
							{
								value = this.CheckAdjustInScreenMinY;
								return true;
							}
							if (key == "CheckAdjustInScreenMaxY")
							{
								value = this.CheckAdjustInScreenMaxY;
								return true;
							}
						}
					}
					else if (key == "ExtraArmLengthMinByDist")
					{
						value = this.ExtraArmLengthMinByDist;
						return true;
					}
				}
				else if (key == "ExtraArmLengthMaxByDist")
				{
					value = this.ExtraArmLengthMaxByDist;
					return true;
				}
				break;
			}
			case 25:
			{
				char c = key[16];
				if (c <= 'l')
				{
					if (c != 'H')
					{
						if (c != 'e')
						{
							if (c == 'l')
							{
								if (key == "AutoCameraArmPullLagSpeed")
								{
									value = this.AutoCameraArmPullLagSpeed;
									return true;
								}
							}
						}
						else if (key == "AutoCameraArmMoveLagSpeed")
						{
							value = this.AutoCameraArmMoveLagSpeed;
							return true;
						}
					}
					else
					{
						if (key == "ExtraArmVerticalHeightMin")
						{
							value = this.ExtraArmVerticalHeightMin;
							return true;
						}
						if (key == "ExtraArmVerticalHeightMax")
						{
							value = this.ExtraArmVerticalHeightMax;
							return true;
						}
					}
				}
				else if (c != 'n')
				{
					if (c != 'r')
					{
						if (c == 'x')
						{
							if (key == "ExtraArmLengthMaxByHeight")
							{
								value = this.ExtraArmLengthMaxByHeight;
								return true;
							}
						}
					}
					else if (key == "ExtraArmLengthCurveByDist")
					{
						value = this.ExtraArmLengthCurveByDist;
						return true;
					}
				}
				else if (key == "ExtraArmLengthMinByHeight")
				{
					value = this.ExtraArmLengthMinByHeight;
					return true;
				}
				break;
			}
			case 26:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'D')
					{
						if (key == "DesiredAutoCameraArmOffset")
						{
							value = this.DesiredAutoCameraArmOffset;
							return true;
						}
					}
				}
				else if (key == "CurrentAutoCameraArmOffset")
				{
					value = this.CurrentAutoCameraArmOffset;
					return true;
				}
				break;
			}
			case 27:
			{
				char c = key[17];
				if (c <= 'i')
				{
					if (c != 'a')
					{
						if (c == 'i')
						{
							if (key == "ExtraArmVerticalMinByHeight")
							{
								value = this.ExtraArmVerticalMinByHeight;
								return true;
							}
						}
					}
					else if (key == "ExtraArmVerticalMaxByHeight")
					{
						value = this.ExtraArmVerticalMaxByHeight;
						return true;
					}
				}
				else if (c != 'l')
				{
					if (c == 'v')
					{
						if (key == "ExtraArmLengthCurveByHeight")
						{
							value = this.ExtraArmLengthCurveByHeight;
							return true;
						}
					}
				}
				else
				{
					if (key == "ExtraArmHorizontalMinByDist")
					{
						value = this.ExtraArmHorizontalMinByDist;
						return true;
					}
					if (key == "ExtraArmHorizontalMaxByDist")
					{
						value = this.ExtraArmHorizontalMaxByDist;
						return true;
					}
				}
				break;
			}
			case 29:
			{
				char c = key[8];
				if (c != 'H')
				{
					if (c == 'V')
					{
						if (key == "ExtraArmVerticalCurveByHeight")
						{
							value = this.ExtraArmVerticalCurveByHeight;
							return true;
						}
					}
				}
				else if (key == "ExtraArmHorizontalCurveByDist")
				{
					value = this.ExtraArmHorizontalCurveByDist;
					return true;
				}
				break;
			}
			case 31:
				if (key == "AutoCameraArmOffsetRateVertical")
				{
					value = this.AutoCameraArmOffsetRateVertical;
					return true;
				}
				break;
			case 32:
				if (key == "AutoCameraArmOffsetSpeedVertical")
				{
					value = this.AutoCameraArmOffsetSpeedVertical;
					return true;
				}
				break;
			case 34:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'D')
					{
						if (key == "DesiredAutoCameraArmLengthAddition")
						{
							value = this.DesiredAutoCameraArmLengthAddition;
							return true;
						}
					}
				}
				else if (key == "CurrentAutoCameraArmLengthAddition")
				{
					value = this.CurrentAutoCameraArmLengthAddition;
					return true;
				}
				break;
			}
			case 35:
				if (key == "AutoCameraArmLengthWhenTargetNearer")
				{
					value = this.AutoCameraArmLengthWhenTargetNearer;
					return true;
				}
				break;
			case 39:
				if (key == "AutoCameraScreenStandardRectangleBottom")
				{
					value = this.AutoCameraScreenStandardRectangleBottom;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000A44DC File Offset: 0x000A26DC
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 17:
				if (key == "ResultPositionRef")
				{
					this.ResultPositionRef = (FVector2D)value;
					return;
				}
				break;
			case 18:
				if (key == "ExtraArmLengthDist")
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
					this.ExtraArmLengthDist = num2;
					return;
				}
				break;
			case 19:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'D')
					{
						if (key == "DesiredOffsetHeight")
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
							this.DesiredOffsetHeight = num2;
							return;
						}
					}
				}
				else if (key == "CurrentOffsetHeight")
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
					this.CurrentOffsetHeight = num2;
					return;
				}
				break;
			}
			case 20:
				if (key == "ExtraArmLengthHeight")
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
					this.ExtraArmLengthHeight = num2;
					return;
				}
				break;
			case 22:
				if (key == "ExtraArmHorizontalDist")
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
					this.ExtraArmHorizontalDist = num2;
					return;
				}
				break;
			case 23:
			{
				char c = key[15];
				if (c != 'a')
				{
					if (c != 'i')
					{
						if (c == 'r')
						{
							if (key == "CheckAdjustInScreenMinX")
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
								this.CheckAdjustInScreenMinX = num2;
								return;
							}
							if (key == "CheckAdjustInScreenMaxX")
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
								this.CheckAdjustInScreenMaxX = num2;
								return;
							}
							if (key == "CheckAdjustInScreenMinY")
							{
								float num2;
								if (value is double)
								{
									double num30 = (double)value;
									num2 = (float)num30;
								}
								else if (value is float)
								{
									float num31 = (float)value;
									num2 = num31;
								}
								else if (value is int)
								{
									int num32 = (int)value;
									num2 = (float)num32;
								}
								else if (value is long)
								{
									long num33 = (long)value;
									num2 = (float)num33;
								}
								else
								{
									num2 = (float)value;
								}
								this.CheckAdjustInScreenMinY = num2;
								return;
							}
							if (key == "CheckAdjustInScreenMaxY")
							{
								float num2;
								if (value is double)
								{
									double num34 = (double)value;
									num2 = (float)num34;
								}
								else if (value is float)
								{
									float num35 = (float)value;
									num2 = num35;
								}
								else if (value is int)
								{
									int num36 = (int)value;
									num2 = (float)num36;
								}
								else if (value is long)
								{
									long num37 = (long)value;
									num2 = (float)num37;
								}
								else
								{
									num2 = (float)value;
								}
								this.CheckAdjustInScreenMaxY = num2;
								return;
							}
						}
					}
					else if (key == "ExtraArmLengthMinByDist")
					{
						float num2;
						if (value is double)
						{
							double num38 = (double)value;
							num2 = (float)num38;
						}
						else if (value is float)
						{
							float num39 = (float)value;
							num2 = num39;
						}
						else if (value is int)
						{
							int num40 = (int)value;
							num2 = (float)num40;
						}
						else if (value is long)
						{
							long num41 = (long)value;
							num2 = (float)num41;
						}
						else
						{
							num2 = (float)value;
						}
						this.ExtraArmLengthMinByDist = num2;
						return;
					}
				}
				else if (key == "ExtraArmLengthMaxByDist")
				{
					float num2;
					if (value is double)
					{
						double num42 = (double)value;
						num2 = (float)num42;
					}
					else if (value is float)
					{
						float num43 = (float)value;
						num2 = num43;
					}
					else if (value is int)
					{
						int num44 = (int)value;
						num2 = (float)num44;
					}
					else if (value is long)
					{
						long num45 = (long)value;
						num2 = (float)num45;
					}
					else
					{
						num2 = (float)value;
					}
					this.ExtraArmLengthMaxByDist = num2;
					return;
				}
				break;
			}
			case 25:
			{
				char c = key[16];
				if (c <= 'l')
				{
					if (c != 'H')
					{
						if (c != 'e')
						{
							if (c == 'l')
							{
								if (key == "AutoCameraArmPullLagSpeed")
								{
									float num2;
									if (value is double)
									{
										double num46 = (double)value;
										num2 = (float)num46;
									}
									else if (value is float)
									{
										float num47 = (float)value;
										num2 = num47;
									}
									else if (value is int)
									{
										int num48 = (int)value;
										num2 = (float)num48;
									}
									else if (value is long)
									{
										long num49 = (long)value;
										num2 = (float)num49;
									}
									else
									{
										num2 = (float)value;
									}
									this.AutoCameraArmPullLagSpeed = num2;
									return;
								}
							}
						}
						else if (key == "AutoCameraArmMoveLagSpeed")
						{
							float num2;
							if (value is double)
							{
								double num50 = (double)value;
								num2 = (float)num50;
							}
							else if (value is float)
							{
								float num51 = (float)value;
								num2 = num51;
							}
							else if (value is int)
							{
								int num52 = (int)value;
								num2 = (float)num52;
							}
							else if (value is long)
							{
								long num53 = (long)value;
								num2 = (float)num53;
							}
							else
							{
								num2 = (float)value;
							}
							this.AutoCameraArmMoveLagSpeed = num2;
							return;
						}
					}
					else
					{
						if (key == "ExtraArmVerticalHeightMin")
						{
							float num2;
							if (value is double)
							{
								double num54 = (double)value;
								num2 = (float)num54;
							}
							else if (value is float)
							{
								float num55 = (float)value;
								num2 = num55;
							}
							else if (value is int)
							{
								int num56 = (int)value;
								num2 = (float)num56;
							}
							else if (value is long)
							{
								long num57 = (long)value;
								num2 = (float)num57;
							}
							else
							{
								num2 = (float)value;
							}
							this.ExtraArmVerticalHeightMin = num2;
							return;
						}
						if (key == "ExtraArmVerticalHeightMax")
						{
							float num2;
							if (value is double)
							{
								double num58 = (double)value;
								num2 = (float)num58;
							}
							else if (value is float)
							{
								float num59 = (float)value;
								num2 = num59;
							}
							else if (value is int)
							{
								int num60 = (int)value;
								num2 = (float)num60;
							}
							else if (value is long)
							{
								long num61 = (long)value;
								num2 = (float)num61;
							}
							else
							{
								num2 = (float)value;
							}
							this.ExtraArmVerticalHeightMax = num2;
							return;
						}
					}
				}
				else if (c != 'n')
				{
					if (c != 'r')
					{
						if (c == 'x')
						{
							if (key == "ExtraArmLengthMaxByHeight")
							{
								float num2;
								if (value is double)
								{
									double num62 = (double)value;
									num2 = (float)num62;
								}
								else if (value is float)
								{
									float num63 = (float)value;
									num2 = num63;
								}
								else if (value is int)
								{
									int num64 = (int)value;
									num2 = (float)num64;
								}
								else if (value is long)
								{
									long num65 = (long)value;
									num2 = (float)num65;
								}
								else
								{
									num2 = (float)value;
								}
								this.ExtraArmLengthMaxByHeight = num2;
								return;
							}
						}
					}
					else if (key == "ExtraArmLengthCurveByDist")
					{
						this.ExtraArmLengthCurveByDist = (CurveBase)value;
						return;
					}
				}
				else if (key == "ExtraArmLengthMinByHeight")
				{
					float num2;
					if (value is double)
					{
						double num66 = (double)value;
						num2 = (float)num66;
					}
					else if (value is float)
					{
						float num67 = (float)value;
						num2 = num67;
					}
					else if (value is int)
					{
						int num68 = (int)value;
						num2 = (float)num68;
					}
					else if (value is long)
					{
						long num69 = (long)value;
						num2 = (float)num69;
					}
					else
					{
						num2 = (float)value;
					}
					this.ExtraArmLengthMinByHeight = num2;
					return;
				}
				break;
			}
			case 26:
				if (key == "CurrentAutoCameraArmOffset")
				{
					this.CurrentAutoCameraArmOffset = (Vector)value;
					return;
				}
				break;
			case 27:
			{
				char c = key[17];
				if (c <= 'i')
				{
					if (c != 'a')
					{
						if (c == 'i')
						{
							if (key == "ExtraArmVerticalMinByHeight")
							{
								float num2;
								if (value is double)
								{
									double num70 = (double)value;
									num2 = (float)num70;
								}
								else if (value is float)
								{
									float num71 = (float)value;
									num2 = num71;
								}
								else if (value is int)
								{
									int num72 = (int)value;
									num2 = (float)num72;
								}
								else if (value is long)
								{
									long num73 = (long)value;
									num2 = (float)num73;
								}
								else
								{
									num2 = (float)value;
								}
								this.ExtraArmVerticalMinByHeight = num2;
								return;
							}
						}
					}
					else if (key == "ExtraArmVerticalMaxByHeight")
					{
						float num2;
						if (value is double)
						{
							double num74 = (double)value;
							num2 = (float)num74;
						}
						else if (value is float)
						{
							float num75 = (float)value;
							num2 = num75;
						}
						else if (value is int)
						{
							int num76 = (int)value;
							num2 = (float)num76;
						}
						else if (value is long)
						{
							long num77 = (long)value;
							num2 = (float)num77;
						}
						else
						{
							num2 = (float)value;
						}
						this.ExtraArmVerticalMaxByHeight = num2;
						return;
					}
				}
				else if (c != 'l')
				{
					if (c == 'v')
					{
						if (key == "ExtraArmLengthCurveByHeight")
						{
							this.ExtraArmLengthCurveByHeight = (CurveBase)value;
							return;
						}
					}
				}
				else
				{
					if (key == "ExtraArmHorizontalMinByDist")
					{
						float num2;
						if (value is double)
						{
							double num78 = (double)value;
							num2 = (float)num78;
						}
						else if (value is float)
						{
							float num79 = (float)value;
							num2 = num79;
						}
						else if (value is int)
						{
							int num80 = (int)value;
							num2 = (float)num80;
						}
						else if (value is long)
						{
							long num81 = (long)value;
							num2 = (float)num81;
						}
						else
						{
							num2 = (float)value;
						}
						this.ExtraArmHorizontalMinByDist = num2;
						return;
					}
					if (key == "ExtraArmHorizontalMaxByDist")
					{
						float num2;
						if (value is double)
						{
							double num82 = (double)value;
							num2 = (float)num82;
						}
						else if (value is float)
						{
							float num83 = (float)value;
							num2 = num83;
						}
						else if (value is int)
						{
							int num84 = (int)value;
							num2 = (float)num84;
						}
						else if (value is long)
						{
							long num85 = (long)value;
							num2 = (float)num85;
						}
						else
						{
							num2 = (float)value;
						}
						this.ExtraArmHorizontalMaxByDist = num2;
						return;
					}
				}
				break;
			}
			case 29:
			{
				char c = key[8];
				if (c != 'H')
				{
					if (c == 'V')
					{
						if (key == "ExtraArmVerticalCurveByHeight")
						{
							this.ExtraArmVerticalCurveByHeight = (CurveBase)value;
							return;
						}
					}
				}
				else if (key == "ExtraArmHorizontalCurveByDist")
				{
					this.ExtraArmHorizontalCurveByDist = (CurveBase)value;
					return;
				}
				break;
			}
			case 31:
				if (key == "AutoCameraArmOffsetRateVertical")
				{
					float num2;
					if (value is double)
					{
						double num86 = (double)value;
						num2 = (float)num86;
					}
					else if (value is float)
					{
						float num87 = (float)value;
						num2 = num87;
					}
					else if (value is int)
					{
						int num88 = (int)value;
						num2 = (float)num88;
					}
					else if (value is long)
					{
						long num89 = (long)value;
						num2 = (float)num89;
					}
					else
					{
						num2 = (float)value;
					}
					this.AutoCameraArmOffsetRateVertical = num2;
					return;
				}
				break;
			case 32:
				if (key == "AutoCameraArmOffsetSpeedVertical")
				{
					float num2;
					if (value is double)
					{
						double num90 = (double)value;
						num2 = (float)num90;
					}
					else if (value is float)
					{
						float num91 = (float)value;
						num2 = num91;
					}
					else if (value is int)
					{
						int num92 = (int)value;
						num2 = (float)num92;
					}
					else if (value is long)
					{
						long num93 = (long)value;
						num2 = (float)num93;
					}
					else
					{
						num2 = (float)value;
					}
					this.AutoCameraArmOffsetSpeedVertical = num2;
					return;
				}
				break;
			case 34:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'D')
					{
						if (key == "DesiredAutoCameraArmLengthAddition")
						{
							float num2;
							if (value is double)
							{
								double num94 = (double)value;
								num2 = (float)num94;
							}
							else if (value is float)
							{
								float num95 = (float)value;
								num2 = num95;
							}
							else if (value is int)
							{
								int num96 = (int)value;
								num2 = (float)num96;
							}
							else if (value is long)
							{
								long num97 = (long)value;
								num2 = (float)num97;
							}
							else
							{
								num2 = (float)value;
							}
							this.DesiredAutoCameraArmLengthAddition = num2;
							return;
						}
					}
				}
				else if (key == "CurrentAutoCameraArmLengthAddition")
				{
					float num2;
					if (value is double)
					{
						double num98 = (double)value;
						num2 = (float)num98;
					}
					else if (value is float)
					{
						float num99 = (float)value;
						num2 = num99;
					}
					else if (value is int)
					{
						int num100 = (int)value;
						num2 = (float)num100;
					}
					else if (value is long)
					{
						long num101 = (long)value;
						num2 = (float)num101;
					}
					else
					{
						num2 = (float)value;
					}
					this.CurrentAutoCameraArmLengthAddition = num2;
					return;
				}
				break;
			}
			case 35:
				if (key == "AutoCameraArmLengthWhenTargetNearer")
				{
					float num2;
					if (value is double)
					{
						double num102 = (double)value;
						num2 = (float)num102;
					}
					else if (value is float)
					{
						float num103 = (float)value;
						num2 = num103;
					}
					else if (value is int)
					{
						int num104 = (int)value;
						num2 = (float)num104;
					}
					else if (value is long)
					{
						long num105 = (long)value;
						num2 = (float)num105;
					}
					else
					{
						num2 = (float)value;
					}
					this.AutoCameraArmLengthWhenTargetNearer = num2;
					return;
				}
				break;
			case 39:
				if (key == "AutoCameraScreenStandardRectangleBottom")
				{
					float num2;
					if (value is double)
					{
						double num106 = (double)value;
						num2 = (float)num106;
					}
					else if (value is float)
					{
						float num107 = (float)value;
						num2 = num107;
					}
					else if (value is int)
					{
						int num108 = (int)value;
						num2 = (float)num108;
					}
					else if (value is long)
					{
						long num109 = (long)value;
						num2 = (float)num109;
					}
					else
					{
						num2 = (float)value;
					}
					this.AutoCameraScreenStandardRectangleBottom = num2;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000A55A2 File Offset: 0x000A37A2
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraAutoController.<MemberIter>d__52 <MemberIter>d__ = new CameraAutoController.<MemberIter>d__52(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x0400134B RID: 4939
	public float AutoCameraArmLengthWhenTargetNearer;

	// Token: 0x0400134C RID: 4940
	public float AutoCameraScreenStandardRectangleBottom;

	// Token: 0x0400134D RID: 4941
	public float AutoCameraArmOffsetRateVertical;

	// Token: 0x0400134E RID: 4942
	public float AutoCameraArmPullLagSpeed;

	// Token: 0x0400134F RID: 4943
	public float AutoCameraArmMoveLagSpeed;

	// Token: 0x04001350 RID: 4944
	public float CheckAdjustInScreenMinX;

	// Token: 0x04001351 RID: 4945
	public float CheckAdjustInScreenMaxX;

	// Token: 0x04001352 RID: 4946
	public float CheckAdjustInScreenMinY;

	// Token: 0x04001353 RID: 4947
	public float CheckAdjustInScreenMaxY;

	// Token: 0x04001354 RID: 4948
	public float AutoCameraArmOffsetSpeedVertical;

	// Token: 0x04001355 RID: 4949
	public float ExtraArmLengthMinByDist;

	// Token: 0x04001356 RID: 4950
	public float ExtraArmLengthMaxByDist;

	// Token: 0x04001357 RID: 4951
	public float ExtraArmLengthDist;

	// Token: 0x04001358 RID: 4952
	[Nullable(2)]
	public CurveBase ExtraArmLengthCurveByDist;

	// Token: 0x04001359 RID: 4953
	public float ExtraArmLengthMinByHeight;

	// Token: 0x0400135A RID: 4954
	public float ExtraArmLengthMaxByHeight;

	// Token: 0x0400135B RID: 4955
	public float ExtraArmLengthHeight;

	// Token: 0x0400135C RID: 4956
	[Nullable(2)]
	public CurveBase ExtraArmLengthCurveByHeight;

	// Token: 0x0400135D RID: 4957
	public float ExtraArmHorizontalMinByDist;

	// Token: 0x0400135E RID: 4958
	public float ExtraArmHorizontalMaxByDist;

	// Token: 0x0400135F RID: 4959
	public float ExtraArmHorizontalDist;

	// Token: 0x04001360 RID: 4960
	[Nullable(2)]
	public CurveBase ExtraArmHorizontalCurveByDist;

	// Token: 0x04001361 RID: 4961
	public float ExtraArmVerticalMinByHeight;

	// Token: 0x04001362 RID: 4962
	public float ExtraArmVerticalMaxByHeight;

	// Token: 0x04001363 RID: 4963
	public float ExtraArmVerticalHeightMin;

	// Token: 0x04001364 RID: 4964
	public float ExtraArmVerticalHeightMax;

	// Token: 0x04001365 RID: 4965
	[Nullable(2)]
	public CurveBase ExtraArmVerticalCurveByHeight;

	// Token: 0x04001366 RID: 4966
	public float CurrentAutoCameraArmLengthAddition;

	// Token: 0x04001367 RID: 4967
	private float DesiredAutoCameraArmLengthAddition;

	// Token: 0x04001368 RID: 4968
	public Vector CurrentAutoCameraArmOffset = Vector.Create();

	// Token: 0x04001369 RID: 4969
	private readonly Vector DesiredAutoCameraArmOffset = Vector.Create();

	// Token: 0x0400136A RID: 4970
	protected float DesiredOffsetHeight;

	// Token: 0x0400136B RID: 4971
	protected float CurrentOffsetHeight;

	// Token: 0x0400136C RID: 4972
	private readonly HashSet<object> ForceEnableSet = new HashSet<object>();

	// Token: 0x0400136D RID: 4973
	protected FVector2D ResultPositionRef = new FVector2D();

	// Token: 0x0400136E RID: 4974
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400136F RID: 4975
	private readonly Vector TmpVector2 = Vector.Create();
}
