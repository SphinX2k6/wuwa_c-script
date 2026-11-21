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
	// Token: 0x020061D9 RID: 25049
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerFlashLightComponent : EntityComponent
	{
		// Token: 0x0603C1D9 RID: 246233 RVA: 0x0111C5FC File Offset: 0x0111A7FC
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

		// Token: 0x0603C1DA RID: 246234 RVA: 0x0111C69B File Offset: 0x0111A89B
		protected override void OnTick(float delta)
		{
			if (!this.IsEnabled)
			{
				return;
			}
			this.UpdateFlashLightTransform(delta * 0.001f);
		}

		// Token: 0x0603C1DB RID: 246235 RVA: 0x0111C6B4 File Offset: 0x0111A8B4
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

		// Token: 0x0603C1DC RID: 246236 RVA: 0x0111C70B File Offset: 0x0111A90B
		protected override void OnEnable()
		{
			this.EnableFlashLight(true);
		}

		// Token: 0x0603C1DD RID: 246237 RVA: 0x0111C714 File Offset: 0x0111A914
		protected override void OnDisable(string reason)
		{
			this.EnableFlashLight(false);
		}

		// Token: 0x0603C1DE RID: 246238 RVA: 0x0111C720 File Offset: 0x0111A920
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

		// Token: 0x0603C1DF RID: 246239 RVA: 0x0111C7B7 File Offset: 0x0111A9B7
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

		// Token: 0x0603C1E0 RID: 246240 RVA: 0x0111C7DC File Offset: 0x0111A9DC
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

		// Token: 0x0603C1E1 RID: 246241 RVA: 0x0111C828 File Offset: 0x0111AA28
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

		// Token: 0x0603C1E2 RID: 246242 RVA: 0x0111CB2F File Offset: 0x0111AD2F
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

		// Token: 0x0603C1E3 RID: 246243 RVA: 0x0111CB60 File Offset: 0x0111AD60
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

		// Token: 0x0603C1E4 RID: 246244 RVA: 0x0111CBB0 File Offset: 0x0111ADB0
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PlayerFlashLightComponent playerFlashLightComponent = (PlayerFlashLightComponent)componentTemplate;
			if (playerFlashLightComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			this.DisableKey = playerFlashLightComponent.DisableKey;
			if (playerFlashLightComponent.SwitchFlashLight == null)
			{
				this.SwitchFlashLight = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SwitchFlashLight), "SwitchFlashLight"))
			{
				return false;
			}
			if (playerFlashLightComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (playerFlashLightComponent.FlashLightActor == null)
			{
				this.FlashLightActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FlashLightActor), "FlashLightActor"))
			{
				return false;
			}
			this.IsEnabled = playerFlashLightComponent.IsEnabled;
			this.LastPitchRad = playerFlashLightComponent.LastPitchRad;
			if (playerFlashLightComponent.TmpVector1 == null)
			{
				this.TmpVector1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector1), "TmpVector1"))
			{
				return false;
			}
			if (playerFlashLightComponent.TmpVector2 == null)
			{
				this.TmpVector2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2"))
			{
				return false;
			}
			if (playerFlashLightComponent.TmpRotator == null)
			{
				this.TmpRotator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator), "TmpRotator"))
			{
				return false;
			}
			if (playerFlashLightComponent.TmpTrans1 == null)
			{
				this.TmpTrans1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpTrans1), "TmpTrans1"))
			{
				return false;
			}
			if (playerFlashLightComponent.TmpTrans2 == null)
			{
				this.TmpTrans2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpTrans2), "TmpTrans2"))
			{
				return false;
			}
			if (playerFlashLightComponent.TmpQuat1 == null)
			{
				this.TmpQuat1 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat1), "TmpQuat1"))
			{
				return false;
			}
			if (playerFlashLightComponent.TmpQuat2 == null)
			{
				this.TmpQuat2 = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat2), "TmpQuat2"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700716B RID: 29035
		// (get) Token: 0x0603C1E5 RID: 246245 RVA: 0x0111CDCD File Offset: 0x0111AFCD
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700716C RID: 29036
		// (get) Token: 0x0603C1E6 RID: 246246 RVA: 0x0111CDD0 File Offset: 0x0111AFD0
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700716D RID: 29037
		// (get) Token: 0x0603C1E7 RID: 246247 RVA: 0x0111CDD3 File Offset: 0x0111AFD3
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700716E RID: 29038
		// (get) Token: 0x0603C1E8 RID: 246248 RVA: 0x0111CDD6 File Offset: 0x0111AFD6
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700716F RID: 29039
		// (get) Token: 0x0603C1E9 RID: 246249 RVA: 0x0111CDD9 File Offset: 0x0111AFD9
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FD07 RID: 130311
		private const string FLASH_LIGHT_CONFIG_PATH = "/Game/Aki/Character/Role/Common/Data/DA/DA_FlashLightCommon.DA_FlashLightCommon";

		// Token: 0x0401FD08 RID: 130312
		private const float INVALID_PITCH_RAD = 360f;

		// Token: 0x0401FD09 RID: 130313
		[Nullable(2)]
		protected PlayerTagComponent TagComp;

		// Token: 0x0401FD0A RID: 130314
		private int? DisableKey;

		// Token: 0x0401FD0B RID: 130315
		[Nullable(2)]
		private ITagTask SwitchFlashLight;

		// Token: 0x0401FD0C RID: 130316
		[Nullable(2)]
		protected FlashLightConfig Config;

		// Token: 0x0401FD0D RID: 130317
		[Nullable(2)]
		protected AActor FlashLightActor;

		// Token: 0x0401FD0E RID: 130318
		protected bool IsEnabled;

		// Token: 0x0401FD0F RID: 130319
		protected float LastPitchRad = 360f;

		// Token: 0x0401FD10 RID: 130320
		protected Vector TmpVector1 = Vector.Create();

		// Token: 0x0401FD11 RID: 130321
		protected Vector TmpVector2 = Vector.Create();

		// Token: 0x0401FD12 RID: 130322
		protected Rotator TmpRotator = Rotator.Create();

		// Token: 0x0401FD13 RID: 130323
		protected Transform TmpTrans1 = Transform.Create();

		// Token: 0x0401FD14 RID: 130324
		protected Transform TmpTrans2 = Transform.Create();

		// Token: 0x0401FD15 RID: 130325
		protected Quat TmpQuat1 = Quat.Create(0.0, 0.0, 0.0, 1.0);

		// Token: 0x0401FD16 RID: 130326
		protected Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);
	}
}
