using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using UnrealEngine;

// Token: 0x02000200 RID: 512
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraGravityController : CameraControllerBase, ICanGetConfigMapValue, IStaticVariableResetter
{
	// Token: 0x06002036 RID: 8246 RVA: 0x000ABE3F File Offset: 0x000AA03F
	public CameraGravityController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x000ABE74 File Offset: 0x000AA074
	static CameraGravityController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CameraGravityController.CreateStaticDefaultValue), new Action(CameraGravityController.ResetStaticDefaultValue));
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000ABF22 File Offset: 0x000AA122
	public override string Name()
	{
		return "GravityController";
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x000ABF29 File Offset: 0x000AA129
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraGravity.开启过渡到指定重力方向, "EnableGravityLerp");
		base.SetConfigMap(EFightCameraGravity.过渡角速度, "GravityLerpAngleVelocity");
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x000ABF4D File Offset: 0x000AA14D
	public override void PostProcessConfig(Dictionary<int, float> config, Dictionary<int, CurveBase> curveConfig)
	{
		base.PostProcessConfig(config, curveConfig);
		this.RefreshDefaultCameraGravityLerpConfig();
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x000ABF5D File Offset: 0x000AA15D
	protected override bool UpdateCustomEnableCondition()
	{
		BaseCameraGravityLerpExecutor baseCameraGravityLerpExecutor = this.BaseCameraGravityLerpExecutor;
		return baseCameraGravityLerpExecutor != null && baseCameraGravityLerpExecutor.EnableUpdate();
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000ABF70 File Offset: 0x000AA170
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

	// Token: 0x0600203D RID: 8253 RVA: 0x000ABFA7 File Offset: 0x000AA1A7
	public void DrawCameraGravityDebugArrow(Vector direction, FLinearColor color)
	{
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000ABFA9 File Offset: 0x000AA1A9
	public void DrawCameraGravityDebugLine(Vector direction, FLinearColor color)
	{
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000ABFAC File Offset: 0x000AA1AC
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
		}
		else
		{
			this.DefaultCameraGravityLerpConfig.LerpMode = ECameraGravityLerpMode.None;
			this.DefaultCameraGravityLerpConfig.LerpAngleVelocity = 0f;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[CameraGravity]刷新默认的重力方向插值配置";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("DefaultCameraGravityLerpConfig", this.DefaultCameraGravityLerpConfig.ToString());
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x000AC078 File Offset: 0x000AA278
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

	// Token: 0x06002041 RID: 8257 RVA: 0x000AC0ED File Offset: 0x000AA2ED
	private void SetCameraGravityDirConfig(CameraGravityConfig config)
	{
		this.CameraGravityDirConfig.GravityMode = config.GravityMode;
		this.CameraGravityDirConfig.TargetGravity.DeepCopy(config.TargetGravity);
		this.RebuildBaseCameraGravity();
		this.RebuildBaseCameraGravityLerpExecutor();
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x000AC124 File Offset: 0x000AA324
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

	// Token: 0x06002043 RID: 8259 RVA: 0x000AC19C File Offset: 0x000AA39C
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

	// Token: 0x06002044 RID: 8260 RVA: 0x000AC21E File Offset: 0x000AA41E
	public ECameraGravityMode GetCurrentCameraGravityMode()
	{
		return this.CameraGravityDirConfig.GravityMode;
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000AC22B File Offset: 0x000AA42B
	public Vector GetGravityStartLerpVector()
	{
		BaseCameraGravity baseCameraGravity = this.BaseCameraGravity;
		return ((baseCameraGravity != null) ? baseCameraGravity.GravityStartLerpVector() : null) ?? Vector.DownVectorProxy;
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000AC248 File Offset: 0x000AA448
	public Vector GetGravityEndLerpVector()
	{
		BaseCameraGravity baseCameraGravity = this.BaseCameraGravity;
		return ((baseCameraGravity != null) ? baseCameraGravity.GravityEndLerpVector() : null) ?? Vector.DownVectorProxy;
	}

	// Token: 0x06002047 RID: 8263 RVA: 0x000AC265 File Offset: 0x000AA465
	public Vector GetGravityDirectForActor()
	{
		GravityUtils instance = GravityUtils.Instance;
		TsBaseCharacter character = this.Camera.Character;
		return instance.GetGravityDirectForActor((character != null) ? character.CharacterActorComponent : null);
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000AC288 File Offset: 0x000AA488
	public Vector GetCurrentCameraGravityDirect()
	{
		return this.Camera.GravityDirect;
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000AC298 File Offset: 0x000AA498
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

	// Token: 0x0600204A RID: 8266 RVA: 0x000AC2E0 File Offset: 0x000AA4E0
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

	// Token: 0x0600204B RID: 8267 RVA: 0x000AC417 File Offset: 0x000AA617
	public void SetCameraGravityModeByUeConfig(SCamera_ChangeGravity config)
	{
		CameraGravityController.TempCameraGravityConfig.SetConfig(config);
		this.SetOverrideCameraGravityLerpConfig(CameraGravityController.TempCameraGravityConfig);
		this.SetCameraGravityDirConfig(CameraGravityController.TempCameraGravityConfig);
	}

	// Token: 0x0600204C RID: 8268 RVA: 0x000AC43A File Offset: 0x000AA63A
	public void SetCameraGravityModeByConfig(CameraGravityConfig config)
	{
		this.SetOverrideCameraGravityLerpConfig(config);
		this.SetCameraGravityDirConfig(config);
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x000AC44C File Offset: 0x000AA64C
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

	// Token: 0x0600204E RID: 8270 RVA: 0x000AC4A0 File Offset: 0x000AA6A0
	public bool IsInNormalGravityMode()
	{
		return this.Camera.GravityMode == ECameraGravityMode.None || MathUtils.Instance.IsNearlyEqual(this.Camera.GravityDirect.Z, -1.0, new double?((double)1E-08f));
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x000AC4DF File Offset: 0x000AA6DF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000AC4E1 File Offset: 0x000AA6E1
	public static void ResetStaticDefaultValue()
	{
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000AC4E4 File Offset: 0x000AA6E4
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

	// Token: 0x06002052 RID: 8274 RVA: 0x000AC668 File Offset: 0x000AA868
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

	// Token: 0x06002053 RID: 8275 RVA: 0x000AC7D8 File Offset: 0x000AA9D8
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraGravityController.<MemberIter>d__44 <MemberIter>d__ = new CameraGravityController.<MemberIter>d__44(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x04001436 RID: 5174
	[StaticVariableRuleIgnore]
	public static CameraGravityConfig TempCameraGravityConfig = new CameraGravityConfig();

	// Token: 0x04001437 RID: 5175
	public float EnableGravityLerp;

	// Token: 0x04001438 RID: 5176
	public float GravityLerpAngleVelocity;

	// Token: 0x04001439 RID: 5177
	private readonly CameraGravityLerpConfig DefaultCameraGravityLerpConfig = new CameraGravityLerpConfig();

	// Token: 0x0400143A RID: 5178
	[Nullable(2)]
	private CameraGravityLerpConfig OverrideCameraGravityLerpConfig;

	// Token: 0x0400143B RID: 5179
	[Nullable(2)]
	private BaseCameraGravityLerpExecutor BaseCameraGravityLerpExecutor;

	// Token: 0x0400143C RID: 5180
	private readonly CameraGravityDirectionConfig CameraGravityDirConfig = new CameraGravityDirectionConfig();

	// Token: 0x0400143D RID: 5181
	[Nullable(2)]
	private BaseCameraGravity BaseCameraGravity;

	// Token: 0x0400143E RID: 5182
	private readonly Vector DebugLineDirection = Vector.Create();

	// Token: 0x0400143F RID: 5183
	private readonly Vector DebugLineEnd = Vector.Create();

	// Token: 0x04001440 RID: 5184
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

	// Token: 0x04001441 RID: 5185
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

	// Token: 0x04001442 RID: 5186
	private const float CAMERA_GRAVITY_DEBUG_LINE_LENGTH = 1800f;

	// Token: 0x04001443 RID: 5187
	private const float CAMERA_GRAVITY_DEBUG_LINE_SIZE = 6f;

	// Token: 0x04001444 RID: 5188
	private const float CAMERA_GRAVITY_DEBUG_GRAVITY_FORWARD_ARROW_SIZE = 300f;
}
