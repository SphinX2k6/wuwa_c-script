using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Role.Common.Data.Structure;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Player.Component
{
	// Token: 0x02007058 RID: 28760
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerFlashLightComponent : EntityComponent
	{
		// Token: 0x06045FEB RID: 286699 RVA: 0x0117293C File Offset: 0x01170B3C
		protected override bool OnStart()
		{
			this.TagComp = base.Entity.CheckGetComponent<PlayerTagComponent>();
			this.DisableKey = new int?(base.Disable("OnStart"));
			this.SwitchFlashLight = this.TagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["功能.功能制作.启动手电筒"]), delegate(int tagId, bool tagExists)
			{
				this.EnableFlashLight(tagExists);
			}, null);
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x06045FEC RID: 286700 RVA: 0x011729DB File Offset: 0x01170BDB
		protected override void OnTick(float delta)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.UpdateFlashLightTransform(delta * 0.001f);
		}

		// Token: 0x06045FED RID: 286701 RVA: 0x011729F4 File Offset: 0x01170BF4
		protected override bool OnEnd()
		{
			ITagTask switchFlashLight = this.SwitchFlashLight;
			if (switchFlashLight != null)
			{
				switchFlashLight.EndTask();
			}
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			return true;
		}

		// Token: 0x06045FEE RID: 286702 RVA: 0x01172A4B File Offset: 0x01170C4B
		protected override void OnEnable()
		{
			this.EnableFlashLight(true);
		}

		// Token: 0x06045FEF RID: 286703 RVA: 0x01172A54 File Offset: 0x01170C54
		protected override void OnDisable(string reason)
		{
			this.EnableFlashLight(false);
		}

		// Token: 0x06045FF0 RID: 286704 RVA: 0x01172A60 File Offset: 0x01170C60
		protected void EnableFlashLight(bool enable)
		{
			if (this.IsEnabled == enable)
			{
				return;
			}
			this.IsEnabled = enable;
			if (enable && this.DisableKey != null)
			{
				this.LoadAndInitFlashLightActor();
				base.Enable(this.DisableKey, "EnableFlashLight");
				this.DisableKey = null;
				return;
			}
			if (!enable && this.DisableKey == null)
			{
				ActorSystem.Instance.Put("DisableFlashLight", this.FlashLightActor, null);
				this.FlashLightActor = null;
				this.DisableKey = new int?(base.Disable("DisableFlashLight"));
			}
		}

		// Token: 0x06045FF1 RID: 286705 RVA: 0x01172AF7 File Offset: 0x01170CF7
		protected void LoadAndInitFlashLightActor()
		{
			ResourceSystem.Instance.LoadTypeAsync("BP_FlashLightConfig_C", delegate
			{
				ResourceSystem.Instance.LoadAsync<BP_FlashLightConfig_C>("/Game/Aki/Character/Role/Common/Data/DA/DA_FlashLightCommon.DA_FlashLightCommon", delegate([Nullable(2)] BP_FlashLightConfig_C asset, string _)
				{
					if (asset == null || !asset.IsValid())
					{
						return;
					}
					if (!this.IsEnabled)
					{
						return;
					}
					FlashLightConfig flashLightConfig = new FlashLightConfig();
					flashLightConfig.Init(asset);
					if (!flashLightConfig.IsValid())
					{
						return;
					}
					this.InitFlashLightParams(flashLightConfig).Forget();
				}, 100, "js_undefined");
			}, "js_undefined");
		}

		// Token: 0x06045FF2 RID: 286706 RVA: 0x01172B1C File Offset: 0x01170D1C
		protected UniTask InitFlashLightParams(FlashLightConfig config)
		{
			PlayerFlashLightComponent.<InitFlashLightParams>d__23 <InitFlashLightParams>d__;
			<InitFlashLightParams>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitFlashLightParams>d__.<>4__this = this;
			<InitFlashLightParams>d__.config = config;
			<InitFlashLightParams>d__.<>1__state = -1;
			<InitFlashLightParams>d__.<>t__builder.Start<PlayerFlashLightComponent.<InitFlashLightParams>d__23>(ref <InitFlashLightParams>d__);
			return <InitFlashLightParams>d__.<>t__builder.Task;
		}

		// Token: 0x06045FF3 RID: 286707 RVA: 0x01172B68 File Offset: 0x01170D68
		protected void UpdateFlashLightTransform(float deltaSecond)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity != null)
			{
				FlashLightConfig config = this.Config;
				if (config != null && config.IsValid())
				{
					AActor flashLightActor = this.FlashLightActor;
					if (flashLightActor != null && flashLightActor.IsValid())
					{
						BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
						Transform tmpTrans = this.TmpTrans1;
						FTransformDouble ftransformDouble = component.ActorTransform;
						tmpTrans.FromUeTransform(ftransformDouble);
						this.Config.RelativeTrans.ComposeTransforms(this.TmpTrans1, this.TmpTrans2);
						this.TmpTrans1.Reset();
						this.TmpTrans1.SetLocation(this.TmpTrans2.GetLocation());
						this.TmpVector1.DeepCopy(component.ActorForwardProxy);
						GravityUtils.Instance.ConvertToPlanarVectorForActor(component, this.TmpVector1);
						GravityUtils.Instance.GetBaseQuatInGravityForActor(component, this.TmpQuat1);
						this.TmpQuat1.Inverse(this.TmpQuat2);
						this.TmpQuat2.RotateVector(this.TmpVector1, this.TmpVector2);
						this.TmpVector2.GetSafeNormal(this.TmpVector1, 9.99999993922529E-09);
						double num = this.TmpVector1.HeadingAngle();
						double num2 = 1.5707963267948966;
						if (this.Config.IsUseCameraPitch)
						{
							CameraController.Instance.GetCameraRotation(this.TmpRotator, "MainCamera");
							this.TmpRotator.Vector(this.TmpVector1);
							double znInGravityForActor = GravityUtils.Instance.GetZnInGravityForActor(component, this.TmpVector1);
							double num3 = Math.Acos(MathUtils.Instance.Clamp(znInGravityForActor, -1.0, 1.0));
							num2 = num3;
							if (this.Config.IsUsePitchLerp && this.LastPitchRad != 360f && deltaSecond > 0f)
							{
								double num4 = Math.Abs(num3 - (double)this.LastPitchRad) * 57.295780181884766;
								float lerpDegAlpha = this.Config.GetLerpDegAlpha((float)MathUtils.Instance.Clamp(num4 / (double)this.Config.LerpBeginDeg, 0.0, 1.0));
								float num5 = MathUtils.Instance.Lerp(this.Config.MinTurnSpeed, this.Config.MaxTurnSpeed, lerpDegAlpha) * 0.017453292f;
								num2 = MathUtils.Instance.InterpConstantTo((double)this.LastPitchRad, num3, (double)deltaSecond, (double)num5);
							}
						}
						double inX = Math.Cos(num) * Math.Sin(num2);
						double inY = Math.Sin(num) * Math.Sin(num2);
						double inZ = Math.Cos(num2);
						this.TmpVector1.Set(inX, inY, inZ);
						this.TmpVector1.Rotation(this.TmpRotator);
						this.TmpQuat1.Multiply(this.TmpRotator.Quaternion(null), this.TmpQuat2);
						this.TmpTrans1.SetRotation(this.TmpQuat2);
						AActor flashLightActor2 = this.FlashLightActor;
						ftransformDouble = this.TmpTrans1.ToUeTransform();
						flashLightActor2.D_K2_SetActorTransform(ftransformDouble, false, null, false);
						this.LastPitchRad = (float)num2;
						return;
					}
				}
			}
		}

		// Token: 0x06045FF4 RID: 286708 RVA: 0x01172E6F File Offset: 0x0117106F
		protected void OnClearWorld()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (this.FlashLightActor != null)
			{
				ActorSystem.Instance.Put("FlashLightComp.OnClearWorld", this.FlashLightActor, null);
				this.FlashLightActor = null;
			}
		}

		// Token: 0x06045FF5 RID: 286709 RVA: 0x01172EA0 File Offset: 0x011710A0
		protected void OnWorldDone()
		{
			if (!this.IsEnabled)
			{
				return;
			}
			if (this.FlashLightActor != null)
			{
				ActorSystem.Instance.Put("FlashLightComp.OnWorldDone", this.FlashLightActor, null);
				this.FlashLightActor = null;
			}
			this.InitFlashLightParams(this.Config).Forget();
		}

		// Token: 0x06045FF6 RID: 286710 RVA: 0x01172EF0 File Offset: 0x011710F0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PlayerFlashLightComponent playerFlashLightComponent = (PlayerFlashLightComponent)componentTemplate;
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (playerFlashLightComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PlayerTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("DisableKey"))
			{
				this.DisableKey = playerFlashLightComponent.DisableKey;
			}
			if (base.CanResetComponentProperty("SwitchFlashLight"))
			{
				if (playerFlashLightComponent.SwitchFlashLight == null)
				{
					this.SwitchFlashLight = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ITagTask>(this.SwitchFlashLight), "SwitchFlashLight"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Config"))
			{
				if (playerFlashLightComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FlashLightConfig>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FlashLightActor"))
			{
				if (playerFlashLightComponent.FlashLightActor == null)
				{
					this.FlashLightActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.FlashLightActor), "FlashLightActor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("IsEnabled"))
			{
				this.IsEnabled = playerFlashLightComponent.IsEnabled;
			}
			if (base.CanResetComponentProperty("LastPitchRad"))
			{
				this.LastPitchRad = playerFlashLightComponent.LastPitchRad;
			}
			if (base.CanResetComponentProperty("TmpVector1"))
			{
				if (playerFlashLightComponent.TmpVector1 == null)
				{
					this.TmpVector1 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector1), "TmpVector1"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpVector2"))
			{
				if (playerFlashLightComponent.TmpVector2 == null)
				{
					this.TmpVector2 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.TmpVector2), "TmpVector2"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpRotator"))
			{
				if (playerFlashLightComponent.TmpRotator == null)
				{
					this.TmpRotator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Rotator>(this.TmpRotator), "TmpRotator"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpTrans1"))
			{
				if (playerFlashLightComponent.TmpTrans1 == null)
				{
					this.TmpTrans1 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Transform>(this.TmpTrans1), "TmpTrans1"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpTrans2"))
			{
				if (playerFlashLightComponent.TmpTrans2 == null)
				{
					this.TmpTrans2 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Transform>(this.TmpTrans2), "TmpTrans2"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpQuat1"))
			{
				if (playerFlashLightComponent.TmpQuat1 == null)
				{
					this.TmpQuat1 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat1), "TmpQuat1"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TmpQuat2"))
			{
				if (playerFlashLightComponent.TmpQuat2 == null)
				{
					this.TmpQuat2 = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat2), "TmpQuat2"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04024A51 RID: 150097
		private const string FLASH_LIGHT_CONFIG_PATH = "/Game/Aki/Character/Role/Common/Data/DA/DA_FlashLightCommon.DA_FlashLightCommon";

		// Token: 0x04024A52 RID: 150098
		private const float INVALID_PITCH_RAD = 360f;

		// Token: 0x04024A53 RID: 150099
		[Nullable(2)]
		protected PlayerTagComponent TagComp;

		// Token: 0x04024A54 RID: 150100
		private int? DisableKey;

		// Token: 0x04024A55 RID: 150101
		[Nullable(2)]
		private ITagTask SwitchFlashLight;

		// Token: 0x04024A56 RID: 150102
		[Nullable(2)]
		protected FlashLightConfig Config;

		// Token: 0x04024A57 RID: 150103
		[Nullable(2)]
		protected AActor FlashLightActor;

		// Token: 0x04024A58 RID: 150104
		protected bool IsEnabled;

		// Token: 0x04024A59 RID: 150105
		protected float LastPitchRad = 360f;

		// Token: 0x04024A5A RID: 150106
		protected Vector TmpVector1 = Vector.Create();

		// Token: 0x04024A5B RID: 150107
		protected Vector TmpVector2 = Vector.Create();

		// Token: 0x04024A5C RID: 150108
		protected Rotator TmpRotator = Rotator.Create();

		// Token: 0x04024A5D RID: 150109
		protected Transform TmpTrans1 = Transform.Create();

		// Token: 0x04024A5E RID: 150110
		protected Transform TmpTrans2 = Transform.Create();

		// Token: 0x04024A5F RID: 150111
		protected Quat TmpQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x04024A60 RID: 150112
		protected Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
