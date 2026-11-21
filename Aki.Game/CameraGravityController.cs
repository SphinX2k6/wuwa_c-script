using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02000204 RID: 516
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public class CameraGravityController : CameraControllerBase, ICanGetConfigMapValue, IStaticVariableResetter
{
	// Token: 0x060020E4 RID: 8420 RVA: 0x000B3193 File Offset: 0x000B1393
	public CameraGravityController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x000B31C8 File Offset: 0x000B13C8
	static CameraGravityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CameraGravityController.CreateStaticDefaultValue), new Action(CameraGravityController.ResetStaticDefaultValue));
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000B3276 File Offset: 0x000B1476
	public override string Name()
	{
		return "GravityController";
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000B327D File Offset: 0x000B147D
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraGravity.开启过渡到指定重力方向, "EnableGravityLerp");
		base.SetConfigMap(EFightCameraGravity.过渡角速度, "GravityLerpAngleVelocity");
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x000B32A1 File Offset: 0x000B14A1
	public override void PostProcessConfig(Dictionary<int, float> config, Dictionary<int, CurveBase> curveConfig)
	{
		base.PostProcessConfig(config, curveConfig);
		this.RefreshDefaultCameraGravityLerpConfig();
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000B32B1 File Offset: 0x000B14B1
	protected override bool UpdateCustomEnableCondition()
	{
		BaseCameraGravityLerpExecutor baseCameraGravityLerpExecutor = this.BaseCameraGravityLerpExecutor;
		return baseCameraGravityLerpExecutor != null && baseCameraGravityLerpExecutor.EnableUpdate();
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000B32C4 File Offset: 0x000B14C4
	protected override void UpdateInternal(float deltaTime)
	{
		BaseCameraGravityLerpExecutor baseCameraGravityLerpExecutor = this.BaseCameraGravityLerpExecutor;
		if (baseCameraGravityLerpExecutor != null)
		{
			baseCameraGravityLerpExecutor.Update(deltaTime);
		}
		BaseCameraGravityLerpExecutor baseCameraGravityLerpExecutor2 = this.BaseCameraGravityLerpExecutor;
		if (baseCameraGravityLerpExecutor2 != null && baseCameraGravityLerpExecutor2.IsFinished && this.OverrideCameraGravityLerpConfig != null)
		{
			this.OverrideCameraGravityLerpConfig = null;
		}
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000B32FB File Offset: 0x000B14FB
	public void DrawCameraGravityDebugArrow(Vector direction, FLinearColor color)
	{
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000B32FD File Offset: 0x000B14FD
	public void DrawCameraGravityDebugLine(Vector direction, FLinearColor color)
	{
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x000B3300 File Offset: 0x000B1500
	private void RefreshDefaultCameraGravityLerpConfig()
	{
		this.DefaultCameraGravityLerpConfig.LerpTime = 0f;
		this.DefaultCameraGravityLerpConfig.LerpTimeCurve = null;
		this.DefaultCameraGravityLerpConfig.LerpAngleWhenFinish = false;
		float lerpAngleVelocity = Math.Max(this.GravityLerpAngleVelocity, 0f);
		if (!MathUtils.Instance.IsNearlyZero((double)this.EnableGravityLerp, null))
		{
			this.DefaultCameraGravityLerpConfig.LerpMode = ECameraGravityLerpMode.AngleVelocity;
			this.DefaultCameraGravityLerpConfig.LerpAngleVelocity = lerpAngleVelocity;
			return;
		}
		this.DefaultCameraGravityLerpConfig.LerpMode = ECameraGravityLerpMode.None;
		this.DefaultCameraGravityLerpConfig.LerpAngleVelocity = 0f;
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x000B3398 File Offset: 0x000B1598
	private void SetOverrideCameraGravityLerpConfig(CameraGravityConfig config)
	{
		if (this.OverrideCameraGravityLerpConfig == null)
		{
			this.OverrideCameraGravityLerpConfig = new CameraGravityLerpConfig();
		}
		this.OverrideCameraGravityLerpConfig.LerpMode = config.LerpMode;
		this.OverrideCameraGravityLerpConfig.LerpTime = config.LerpTime;
		this.OverrideCameraGravityLerpConfig.LerpTimeCurve = config.LerpTimeCurve;
		this.OverrideCameraGravityLerpConfig.LerpAngleVelocity = config.LerpAngleVelocity;
		this.OverrideCameraGravityLerpConfig.LerpAngleWhenFinish = config.LerpAngleWhenFinish;
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000B340D File Offset: 0x000B160D
	private void SetCameraGravityDirConfig(CameraGravityConfig config)
	{
		this.CameraGravityDirConfig.GravityMode = config.GravityMode;
		this.CameraGravityDirConfig.TargetGravity.DeepCopy(config.TargetGravity);
		this.RebuildBaseCameraGravity();
		this.RebuildBaseCameraGravityLerpExecutor();
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000B3444 File Offset: 0x000B1644
	private void RebuildBaseCameraGravity()
	{
		Type type;
		if (!CameraGravityController.ECameraGravityMap.TryGetValue(this.GetCurrentCameraGravityMode(), out type))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraGravity]未找到对应的GravityMode";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("config.GravityMode", this.GetCurrentCameraGravityMode());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.BaseCameraGravity = (BaseCameraGravity)Activator.CreateInstance(type);
		this.BaseCameraGravity.Init(this, this.CameraGravityDirConfig);
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x000B34BC File Offset: 0x000B16BC
	private void RebuildBaseCameraGravityLerpExecutor()
	{
		CameraGravityLerpConfig cameraGravityLerpConfig = this.OverrideCameraGravityLerpConfig ?? this.DefaultCameraGravityLerpConfig;
		Type type;
		if (!CameraGravityController.ECameraGravityLerpExecutorMap.TryGetValue(cameraGravityLerpConfig.LerpMode, out type))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraGravity]未找到对应的LerpMode";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activeLerpConfig.LerpMode", cameraGravityLerpConfig.LerpMode);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.BaseCameraGravityLerpExecutor = (BaseCameraGravityLerpExecutor)Activator.CreateInstance(type);
		this.BaseCameraGravityLerpExecutor.Init(this, cameraGravityLerpConfig);
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000B353E File Offset: 0x000B173E
	public ECameraGravityMode GetCurrentCameraGravityMode()
	{
		return this.CameraGravityDirConfig.GravityMode;
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000B354B File Offset: 0x000B174B
	public Vector GetGravityStartLerpVector()
	{
		BaseCameraGravity baseCameraGravity = this.BaseCameraGravity;
		return ((baseCameraGravity != null) ? baseCameraGravity.GravityStartLerpVector() : null) ?? Vector.DownVectorProxy;
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000B3568 File Offset: 0x000B1768
	public Vector GetGravityEndLerpVector()
	{
		BaseCameraGravity baseCameraGravity = this.BaseCameraGravity;
		return ((baseCameraGravity != null) ? baseCameraGravity.GravityEndLerpVector() : null) ?? Vector.DownVectorProxy;
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000B3585 File Offset: 0x000B1785
	public Vector GetGravityDirectForActor()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter character = this.Camera.Character;
		return instance.GetGravityDirectForActor((character != null) ? character.CharacterActorComponent : null);
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000B35A8 File Offset: 0x000B17A8
	public Vector GetCurrentCameraGravityDirect()
	{
		return this.Camera.GravityDirect;
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000B35B8 File Offset: 0x000B17B8
	public void SetCurrentCameraGravityMode(ECameraGravityMode cameraGravityMode)
	{
		this.Camera.GravityMode = cameraGravityMode;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[CameraGravity]InternalSetCameraGravityMode";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("this.CameraGravityMode", cameraGravityMode);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000B3600 File Offset: 0x000B1800
	[NullableContext(2)]
	public void SetCameraGravityMode(ECameraGravityMode cameraGravityMode, Vector gravityDirect = null)
	{
		if (gravityDirect == null)
		{
			gravityDirect = Vector.DownVectorProxy;
		}
		if (!gravityDirect.IsNormalized())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[CameraGravity]设置相机重力方向失败，因为不是归一化的向量";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("gravityDirect", gravityDirect);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		CameraGravityController.TempCameraGravityConfig.Reset();
		if (cameraGravityMode == ECameraGravityMode.None)
		{
			CameraGravityController.TempCameraGravityConfig.GravityMode = ECameraGravityMode.None;
			CameraGravityController.TempCameraGravityConfig.LerpMode = ECameraGravityLerpMode.Time;
			CameraGravityController.TempCameraGravityConfig.LerpTime = 0f;
		}
		else if (cameraGravityMode == ECameraGravityMode.FixedGravityDirect)
		{
			CameraGravityController.TempCameraGravityConfig.GravityMode = ECameraGravityMode.FixedGravityDirect;
			CameraGravityController.TempCameraGravityConfig.LerpMode = ECameraGravityLerpMode.Time;
			CameraGravityController.TempCameraGravityConfig.TargetGravity.DeepCopy(gravityDirect);
			CameraGravityController.TempCameraGravityConfig.LerpTime = 0f;
		}
		else if (cameraGravityMode == ECameraGravityMode.CameraTargetGravityDirect)
		{
			CameraGravityController.TempCameraGravityConfig.GravityMode = ECameraGravityMode.CameraTargetGravityDirect;
			CameraGravityController.TempCameraGravityConfig.LerpMode = ECameraGravityLerpMode.Time;
			CameraGravityController.TempCameraGravityConfig.LerpTime = 0f;
		}
		else
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[CameraGravity]设置相机重力模式失败，因为传入了未知的重力模式, 回退到默认的CameraTargetGravityDirect模式";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("cameraGravityMode", cameraGravityMode);
			instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		this.SetCameraGravityModeByConfig(CameraGravityController.TempCameraGravityConfig);
		Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraGravity]SetCameraGravityMode", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000B3737 File Offset: 0x000B1937
	public void SetCameraGravityModeByUeConfig(SCamera_ChangeGravity config)
	{
		CameraGravityController.TempCameraGravityConfig.SetConfig(config);
		this.SetOverrideCameraGravityLerpConfig(CameraGravityController.TempCameraGravityConfig);
		this.SetCameraGravityDirConfig(CameraGravityController.TempCameraGravityConfig);
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000B375A File Offset: 0x000B195A
	public void SetCameraGravityModeByConfig(CameraGravityConfig config)
	{
		this.SetOverrideCameraGravityLerpConfig(config);
		this.SetCameraGravityDirConfig(config);
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000B376C File Offset: 0x000B196C
	public void UpdateCharacterGravity()
	{
		if (this.Camera.GravityMode != ECameraGravityMode.CameraTargetGravityDirect)
		{
			return;
		}
		if (this.BaseCameraGravityLerpExecutor != null && this.BaseCameraGravityLerpExecutor.EnableUpdate())
		{
			return;
		}
		this.RebuildBaseCameraGravityLerpExecutor();
		Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraGravity]CharGravityDirectChanged", default(ReadOnlySpan<ValueTuple<string, object>>));
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x000B37C0 File Offset: 0x000B19C0
	public bool IsInNormalGravityMode()
	{
		return this.Camera.GravityMode == ECameraGravityMode.None || MathUtils.Instance.IsNearlyEqual(this.Camera.GravityDirect.Z, -1.0, new double?((double)1E-08f));
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x000B37FF File Offset: 0x000B19FF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000B3801 File Offset: 0x000B1A01
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000B3804 File Offset: 0x000B1A04
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			int length = key.Length;
			if (length <= 18)
			{
				if (length != 12)
				{
					if (length != 17)
					{
						if (length == 18)
						{
							if (key == "DebugLineDirection")
							{
								value = this.DebugLineDirection;
								return true;
							}
						}
					}
					else
					{
						char c = key[0];
						if (c != 'B')
						{
							if (c == 'E')
							{
								if (key == "EnableGravityLerp")
								{
									value = this.EnableGravityLerp;
									return true;
								}
							}
						}
						else if (key == "BaseCameraGravity")
						{
							value = this.BaseCameraGravity;
							return true;
						}
					}
				}
				else if (key == "DebugLineEnd")
				{
					value = this.DebugLineEnd;
					return true;
				}
			}
			else if (length != 22)
			{
				if (length != 24)
				{
					switch (length)
					{
					case 29:
						if (key == "BaseCameraGravityLerpExecutor")
						{
							value = this.BaseCameraGravityLerpExecutor;
							return true;
						}
						break;
					case 30:
						if (key == "DefaultCameraGravityLerpConfig")
						{
							value = this.DefaultCameraGravityLerpConfig;
							return true;
						}
						break;
					case 31:
						if (key == "OverrideCameraGravityLerpConfig")
						{
							value = this.OverrideCameraGravityLerpConfig;
							return true;
						}
						break;
					}
				}
				else if (key == "GravityLerpAngleVelocity")
				{
					value = this.GravityLerpAngleVelocity;
					return true;
				}
			}
			else if (key == "CameraGravityDirConfig")
			{
				value = this.CameraGravityDirConfig;
				return true;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000B3988 File Offset: 0x000B1B88
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key == "EnableGravityLerp")
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
			this.EnableGravityLerp = num2;
			return;
		}
		if (key == "GravityLerpAngleVelocity")
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
			this.GravityLerpAngleVelocity = num2;
			return;
		}
		if (key == "OverrideCameraGravityLerpConfig")
		{
			this.OverrideCameraGravityLerpConfig = (CameraGravityLerpConfig)value;
			return;
		}
		if (key == "BaseCameraGravityLerpExecutor")
		{
			this.BaseCameraGravityLerpExecutor = (BaseCameraGravityLerpExecutor)value;
			return;
		}
		if (!(key == "BaseCameraGravity"))
		{
			base.SetMember(key, value);
			return;
		}
		this.BaseCameraGravity = (BaseCameraGravity)value;
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000B3AF8 File Offset: 0x000B1CF8
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraGravityController.<MemberIter>d__44 <MemberIter>d__ = new CameraGravityController.<MemberIter>d__44(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x04001478 RID: 5240
	[StaticVariableRuleIgnore]
	public static CameraGravityConfig TempCameraGravityConfig = new CameraGravityConfig();

	// Token: 0x04001479 RID: 5241
	public float EnableGravityLerp;

	// Token: 0x0400147A RID: 5242
	public float GravityLerpAngleVelocity;

	// Token: 0x0400147B RID: 5243
	private readonly CameraGravityLerpConfig DefaultCameraGravityLerpConfig = new CameraGravityLerpConfig();

	// Token: 0x0400147C RID: 5244
	[Nullable(2)]
	private CameraGravityLerpConfig OverrideCameraGravityLerpConfig;

	// Token: 0x0400147D RID: 5245
	[Nullable(2)]
	private BaseCameraGravityLerpExecutor BaseCameraGravityLerpExecutor;

	// Token: 0x0400147E RID: 5246
	private readonly CameraGravityDirectionConfig CameraGravityDirConfig = new CameraGravityDirectionConfig();

	// Token: 0x0400147F RID: 5247
	[Nullable(2)]
	private BaseCameraGravity BaseCameraGravity;

	// Token: 0x04001480 RID: 5248
	private readonly Vector DebugLineDirection = Vector.Create();

	// Token: 0x04001481 RID: 5249
	private readonly Vector DebugLineEnd = Vector.Create();

	// Token: 0x04001482 RID: 5250
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ECameraGravityLerpMode, Type> ECameraGravityLerpExecutorMap = new Dictionary<ECameraGravityLerpMode, Type>
	{
		{
			ECameraGravityLerpMode.None,
			typeof(CameraGravityLerpByImmediatelySetExecutor)
		},
		{
			ECameraGravityLerpMode.Time,
			typeof(CameraGravityLerpByTimeExecutor)
		},
		{
			ECameraGravityLerpMode.AngleVelocity,
			typeof(CameraGravityLerpByAngleExecutor)
		}
	};

	// Token: 0x04001483 RID: 5251
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<ECameraGravityMode, Type> ECameraGravityMap = new Dictionary<ECameraGravityMode, Type>
	{
		{
			ECameraGravityMode.None,
			typeof(DefaultCameraGravity)
		},
		{
			ECameraGravityMode.FixedGravityDirect,
			typeof(FixedCameraGravity)
		},
		{
			ECameraGravityMode.CameraTargetGravityDirect,
			typeof(TargetCameraGravity)
		}
	};

	// Token: 0x04001484 RID: 5252
	private const float CAMERA_GRAVITY_DEBUG_LINE_LENGTH = 1800f;

	// Token: 0x04001485 RID: 5253
	private const float CAMERA_GRAVITY_DEBUG_LINE_SIZE = 6f;

	// Token: 0x04001486 RID: 5254
	private const float CAMERA_GRAVITY_DEBUG_GRAVITY_FORWARD_ARROW_SIZE = 300f;
}
