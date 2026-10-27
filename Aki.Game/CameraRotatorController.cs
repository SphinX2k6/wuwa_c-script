using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;

// Token: 0x0200021E RID: 542
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraRotatorController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x06002132 RID: 8498 RVA: 0x000BD8A0 File Offset: 0x000BBAA0
	public CameraRotatorController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x000BD8F2 File Offset: 0x000BBAF2
	public override string Name()
	{
		return "RotatorController";
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000BD8FC File Offset: 0x000BBAFC
	public void PlayCameraRotator(Vector lookAt1, Vector lookAt2, Rotator addRotator, float time, bool canBreakByInput = true, float stayTime = 0f)
	{
		this.BeginCameraRotator(lookAt1, lookAt2, addRotator, time, stayTime, 0f, 1f, canBreakByInput, null);
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x000BD924 File Offset: 0x000BBB24
	public void PlayCameraRotatorWithCurve(Vector lookAt1, Vector lookAt2, Rotator addRotator, float time, float minAlpha, float maxAlpha, CurveBase curve, bool canBreakByInput = true, float stayTime = 0f, [Nullable(2)] Action callback = null)
	{
		this.RotatorAlphaCurve = curve;
		this.BeginCameraRotator(lookAt1, lookAt2, addRotator, time, stayTime, minAlpha, maxAlpha, canBreakByInput, callback);
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x000BD94E File Offset: 0x000BBB4E
	public void PlayCameraEulerRotator(Rotator desRotator, float time, bool canBreakByInput = true, float stayTime = 0f)
	{
		this.BeginCameraEulerRotator(desRotator, time, stayTime, 0f, 1f, canBreakByInput);
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x000BD965 File Offset: 0x000BBB65
	public void PlayCameraEulerRotatorWithCurve(Rotator desRotator, float time, float minAlpha, float maxAlpha, CurveBase curve, bool canBreakByInput = true, float stayTime = 0f)
	{
		this.RotatorAlphaCurve = curve;
		this.BeginCameraEulerRotator(desRotator, time, stayTime, minAlpha, maxAlpha, canBreakByInput);
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x000BD980 File Offset: 0x000BBB80
	private void UpdateArmRotationModifier(float deltaTime)
	{
		if (!this.IsActive)
		{
			return;
		}
		ValueTuple<float, float> cameraInput = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float item = cameraInput.Item1;
		float item2 = cameraInput.Item2;
		if (this.CanBreakByInput && (Math.Abs(item) > 0f || Math.Abs(item2) > 0f))
		{
			this.FinishCameraRotator();
			return;
		}
		float num = this.CurrentTime / this.Time;
		if (this.RotatorAlphaCurve != null)
		{
			this.Alpha = this.RotatorAlphaCurve.GetCurrentValue(num);
		}
		else
		{
			this.Alpha = num;
		}
		this.Alpha = MathUtils.Instance.Clamp(this.Alpha, this.MinAlpha, this.MaxAlpha);
		if (this.IsSustainingMode)
		{
			this.SustainingLookAt.Subtraction(this.Camera.PlayerLocation, this.SustainingTemp);
			this.SustainingTemp.Rotation(this.DesRotator);
			if (!this.Camera.IsInNormalGravityMode())
			{
				CameraUtility.GetRotatorInGravity(this.DesRotator, this.DesRotator);
			}
		}
		Rotator.Lerp(this.StartRotator, this.DesRotator, this.Alpha, this.CurrentRotator);
		if (this.Camera.IsInNormalGravityMode())
		{
			this.Camera.DesiredCamera.ArmRotation = Rotator.Create(this.CurrentRotator);
		}
		else
		{
			CameraUtility.SetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.CurrentRotator);
		}
		if (this.CurrentTime >= this.Time + this.StayTime)
		{
			this.FinishCameraRotator();
		}
		this.CurrentTime += deltaTime;
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x000BDB1C File Offset: 0x000BBD1C
	private void BeginCameraRotator(Vector lookAt1, Vector lookAt2, Rotator addRotator, float time, float stayTime, float minAlpha, float maxAlpha, bool canBreakByInput, [Nullable(2)] Action finishCallback = null)
	{
		this.IsActive = true;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.StartRotator.FromUeRotator(this.Camera.CurrentCamera.ArmRotation);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.StartRotator);
		}
		Vector vector = Vector.Create();
		lookAt2.Subtraction(lookAt1, vector);
		vector.Rotation(this.DesRotator);
		if (!this.Camera.IsInNormalGravityMode())
		{
			CameraUtility.GetRotatorInGravity(this.DesRotator, this.DesRotator);
		}
		this.Time = time;
		this.StayTime = stayTime;
		this.CurrentTime = 0f;
		this.Alpha = 0f;
		this.MinAlpha = minAlpha;
		this.MaxAlpha = maxAlpha;
		this.CanBreakByInput = canBreakByInput;
		this.FinishCallback = finishCallback;
		MathUtils.Instance.ComposeRotator(this.DesRotator, addRotator, this.DesRotator);
		this.UpdateCameraInputState();
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x000BDC14 File Offset: 0x000BBE14
	public void BeginCameraSustainingRotator(Vector lookAtPosition, float time, float stayTime, int minAlpha, int maxAlpha, bool canBreakByInput, [Nullable(2)] Action callback = null)
	{
		this.IsActive = true;
		this.IsSustainingMode = true;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.StartRotator.FromUeRotator(this.Camera.CurrentCamera.ArmRotation);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.StartRotator);
		}
		this.SustainingLookAt.DeepCopy(lookAtPosition);
		this.Time = time;
		this.StayTime = stayTime;
		this.CurrentTime = 0f;
		this.Alpha = 0f;
		this.MinAlpha = (float)minAlpha;
		this.MaxAlpha = (float)maxAlpha;
		this.CanBreakByInput = canBreakByInput;
		this.FinishCallback = callback;
		this.UpdateCameraInputState();
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000BDCD0 File Offset: 0x000BBED0
	private void BeginCameraEulerRotator(Rotator desRotator, float time, float stayTime, float minAlpha, float maxAlpha, bool canBreakByInput)
	{
		this.IsActive = true;
		if (this.Camera.IsInNormalGravityMode())
		{
			this.StartRotator.FromUeRotator(this.Camera.CurrentCamera.ArmRotation);
			this.DesRotator.Set(desRotator.Pitch, desRotator.Yaw, desRotator.Roll);
		}
		else
		{
			CameraUtility.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.StartRotator);
			CameraUtility.GetRotatorInGravity(desRotator, this.DesRotator);
		}
		this.Time = time;
		this.StayTime = stayTime;
		this.CurrentTime = 0f;
		this.Alpha = 0f;
		this.MinAlpha = minAlpha;
		this.MaxAlpha = maxAlpha;
		this.CanBreakByInput = canBreakByInput;
		this.UpdateCameraInputState();
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000BDD98 File Offset: 0x000BBF98
	private void FinishCameraRotator()
	{
		this.IsActive = false;
		this.IsSustainingMode = false;
		this.RotatorAlphaCurve = null;
		this.Camera.CameraInputController.Unlock(this);
		this.Camera.CameraRotationZone.Unlock(this);
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		this.FinishCallback = null;
	}

	// Token: 0x0600213D RID: 8509 RVA: 0x000BDDF4 File Offset: 0x000BBFF4
	private void UpdateCameraInputState()
	{
		if (this.CanBreakByInput)
		{
			this.Camera.CameraInputController.Unlock(this);
		}
		else
		{
			this.Camera.CameraInputController.Lock(this);
		}
		this.Camera.CameraRotationZone.Lock(this);
	}

	// Token: 0x0600213E RID: 8510 RVA: 0x000BDE33 File Offset: 0x000BC033
	protected override void UpdateInternal(float deltaTime)
	{
		this.UpdateArmRotationModifier(deltaTime);
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x000BDE3C File Offset: 0x000BC03C
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x000BDE48 File Offset: 0x000BC048
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 4:
				if (key == "Time")
				{
					value = this.Time;
					return true;
				}
				break;
			case 5:
				if (key == "Alpha")
				{
					value = this.Alpha;
					return true;
				}
				break;
			case 8:
			{
				char c = key[1];
				if (c <= 'i')
				{
					if (c != 'a')
					{
						if (c == 'i')
						{
							if (key == "MinAlpha")
							{
								value = this.MinAlpha;
								return true;
							}
						}
					}
					else if (key == "MaxAlpha")
					{
						value = this.MaxAlpha;
						return true;
					}
				}
				else if (c != 's')
				{
					if (c == 't')
					{
						if (key == "StayTime")
						{
							value = this.StayTime;
							return true;
						}
					}
				}
				else if (key == "IsActive")
				{
					value = this.IsActive;
					return true;
				}
				break;
			}
			case 10:
				if (key == "DesRotator")
				{
					value = this.DesRotator;
					return true;
				}
				break;
			case 11:
				if (key == "CurrentTime")
				{
					value = this.CurrentTime;
					return true;
				}
				break;
			case 12:
				if (key == "StartRotator")
				{
					value = this.StartRotator;
					return true;
				}
				break;
			case 14:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c != 'F')
					{
						if (c == 'S')
						{
							if (key == "SustainingTemp")
							{
								value = this.SustainingTemp;
								return true;
							}
						}
					}
					else if (key == "FinishCallback")
					{
						value = this.FinishCallback;
						return true;
					}
				}
				else if (key == "CurrentRotator")
				{
					value = this.CurrentRotator;
					return true;
				}
				break;
			}
			case 15:
				if (key == "CanBreakByInput")
				{
					value = this.CanBreakByInput;
					return true;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c == 'S')
					{
						if (key == "SustainingLookAt")
						{
							value = this.SustainingLookAt;
							return true;
						}
					}
				}
				else if (key == "IsSustainingMode")
				{
					value = this.IsSustainingMode;
					return true;
				}
				break;
			}
			case 17:
				if (key == "RotatorAlphaCurve")
				{
					value = this.RotatorAlphaCurve;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x000BE148 File Offset: 0x000BC348
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 4:
				if (key == "Time")
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
					this.Time = num2;
					return;
				}
				break;
			case 5:
				if (key == "Alpha")
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
					this.Alpha = num2;
					return;
				}
				break;
			case 8:
			{
				char c = key[1];
				if (c <= 'i')
				{
					if (c != 'a')
					{
						if (c == 'i')
						{
							if (key == "MinAlpha")
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
								this.MinAlpha = num2;
								return;
							}
						}
					}
					else if (key == "MaxAlpha")
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
						this.MaxAlpha = num2;
						return;
					}
				}
				else if (c != 's')
				{
					if (c == 't')
					{
						if (key == "StayTime")
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
							this.StayTime = num2;
							return;
						}
					}
				}
				else if (key == "IsActive")
				{
					this.IsActive = (bool)value;
					return;
				}
				break;
			}
			case 11:
				if (key == "CurrentTime")
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
					this.CurrentTime = num2;
					return;
				}
				break;
			case 14:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'S')
					{
						if (key == "SustainingTemp")
						{
							this.SustainingTemp = (Vector)value;
							return;
						}
					}
				}
				else if (key == "FinishCallback")
				{
					this.FinishCallback = (Action)value;
					return;
				}
				break;
			}
			case 15:
				if (key == "CanBreakByInput")
				{
					this.CanBreakByInput = (bool)value;
					return;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c == 'S')
					{
						if (key == "SustainingLookAt")
						{
							this.SustainingLookAt = (Vector)value;
							return;
						}
					}
				}
				else if (key == "IsSustainingMode")
				{
					this.IsSustainingMode = (bool)value;
					return;
				}
				break;
			}
			case 17:
				if (key == "RotatorAlphaCurve")
				{
					this.RotatorAlphaCurve = (CurveBase)value;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x000BE63D File Offset: 0x000BC83D
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraRotatorController.<MemberIter>d__32 <MemberIter>d__ = new CameraRotatorController.<MemberIter>d__32(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040015CC RID: 5580
	public readonly Rotator StartRotator = Rotator.Create();

	// Token: 0x040015CD RID: 5581
	public readonly Rotator DesRotator = Rotator.Create();

	// Token: 0x040015CE RID: 5582
	public readonly Rotator CurrentRotator = Rotator.Create();

	// Token: 0x040015CF RID: 5583
	private bool IsActive;

	// Token: 0x040015D0 RID: 5584
	private float Time;

	// Token: 0x040015D1 RID: 5585
	private float StayTime;

	// Token: 0x040015D2 RID: 5586
	private float CurrentTime;

	// Token: 0x040015D3 RID: 5587
	public float Alpha;

	// Token: 0x040015D4 RID: 5588
	private float MinAlpha;

	// Token: 0x040015D5 RID: 5589
	private float MaxAlpha;

	// Token: 0x040015D6 RID: 5590
	[Nullable(2)]
	private CurveBase RotatorAlphaCurve;

	// Token: 0x040015D7 RID: 5591
	private bool CanBreakByInput = true;

	// Token: 0x040015D8 RID: 5592
	private Vector SustainingLookAt = Vector.Create();

	// Token: 0x040015D9 RID: 5593
	private Vector SustainingTemp = Vector.Create();

	// Token: 0x040015DA RID: 5594
	private bool IsSustainingMode;

	// Token: 0x040015DB RID: 5595
	[Nullable(2)]
	private Action FinishCallback;
}
