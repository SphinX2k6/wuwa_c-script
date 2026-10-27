using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Common;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.World.Controller;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200708A RID: 28810
	[NullableContext(2)]
	[Nullable(0)]
	public class PostProcessBridgeComponent : EntityComponent
	{
		// Token: 0x060462ED RID: 287469 RVA: 0x01189EBC File Offset: 0x011880BC
		protected override bool OnInitData(IEntityArgs args = null)
		{
			SkyboxComponent skyboxComponent = args.GetP1<CreateEntityData>().GetParam<PostProcessBridgeComponent>() as SkyboxComponent;
			int? skyboxSetting = skyboxComponent.SkyboxSetting;
			if (skyboxSetting != null && skyboxSetting.GetValueOrDefault() != 0)
			{
				Skybox? config = ConfigSkyboxById.GetConfig(skyboxComponent.SkyboxSetting.Value, true);
				if (config != null)
				{
					this.WeatherDataAssetPath = config.Value.StaticSkybox;
					this.TodDataAssetPath = config.Value.DynamicSkybox;
				}
			}
			else
			{
				this.WeatherDataAssetPath = skyboxComponent.WeatherDataAsset;
				this.TodDataAssetPath = skyboxComponent.PPTODDataAsset;
			}
			float? num;
			float num2;
			if (skyboxComponent.FadeTime != null)
			{
				num = skyboxComponent.FadeTime;
				num2 = 0f;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					this.ChangeSpeed = (1f / (skyboxComponent.FadeTime * (float)TimeUtil.Instance.InverseMillisecond)).Value;
					goto IL_147;
				}
			}
			this.ChangeSpeed = 0f;
			IL_147:
			num = skyboxComponent.Priority;
			num2 = 0f;
			this.Priority = ((!(num.GetValueOrDefault() == num2 & num != null)) ? skyboxComponent.Priority.Value : 10f);
			this.ActiveByTriggerComponent = (skyboxComponent.TriggerMode == null);
			this.TriggerMode = skyboxComponent.TriggerMode;
			ISkyboxTrigger triggerMode = skyboxComponent.TriggerMode;
			if (triggerMode != null && triggerMode.Type == ETriggerMode.Distance)
			{
				ISkyboxDistanceTrigger skyboxDistanceTrigger = skyboxComponent.TriggerMode as ISkyboxDistanceTrigger;
				this.TriggerDistanceSquared = new float?(skyboxDistanceTrigger.Distance * skyboxDistanceTrigger.Distance);
			}
			else
			{
				this.TriggerDistanceSquared = new float?(0f);
			}
			this.TickTime = 0f;
			this.InTrigger = false;
			return true;
		}

		// Token: 0x060462EE RID: 287470 RVA: 0x0118A0D0 File Offset: 0x011882D0
		protected unsafe override bool OnStart()
		{
			AActor owner = base.Entity.GetComponent<BaseActorComponent>().Owner;
			if (owner == null || !owner.IsValid())
			{
				Log.Instance.Error(ELogModule.Entity, ELogAuthor.CFT, "氛围组件初始化失败, actor为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.Actor = owner;
			this.KuroPostProcessComponent = (owner.GetComponentByClass(UKuroPostProcessComponent.StaticClass()) as UKuroPostProcessComponent);
			UKuroPostProcessComponent kuroPostProcessComponent = this.KuroPostProcessComponent;
			if (kuroPostProcessComponent == null || !kuroPostProcessComponent.IsValid())
			{
				this.KuroPostProcessComponent = (owner.AddComponentByClass(UKuroPostProcessComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UKuroPostProcessComponent);
			}
			this.KuroPostProcessComponent.bUnbound = true;
			this.KuroPostProcessComponent.BlendWeight = this.CurBlendWeight;
			this.UpdatePostProcessComponentEnable();
			if (this.ActiveByTriggerComponent)
			{
				this.RangeComponent = base.Entity.GetComponent<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>();
				if (!this.RangeComponent)
				{
					this.IsInit = false;
					Log.Instance.Error(ELogModule.Entity, ELogAuthor.CFT, "氛围组件初始化失败，缺少RangeComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
					return false;
				}
				this.RangeComponent.AddOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerTrigger));
			}
			this.IsInit = true;
			this.EnableComponent();
			if (!string.IsNullOrEmpty(this.WeatherDataAssetPath))
			{
				ResourceSystem.Instance.LoadAsync<UKuroWeatherDataAsset>(this.WeatherDataAssetPath, delegate([Nullable(2)] UKuroWeatherDataAsset dataAsset, string _)
				{
					if (dataAsset == null || !dataAsset.IsValid())
					{
						return;
					}
					this.WeatherDataAsset = dataAsset;
					this.KuroPostProcessComponent.WeatherDataAsset = this.WeatherDataAsset;
					this.KuroPostProcessComponent.SetPriority(this.Priority);
				}, 100, "js_undefined");
				return true;
			}
			if (!string.IsNullOrEmpty(this.TodDataAssetPath))
			{
				ResourceSystem.Instance.LoadAsync<UKuroTODData>(this.TodDataAssetPath, delegate([Nullable(2)] UKuroTODData dataAsset, string _)
				{
					if (dataAsset == null || !dataAsset.IsValid())
					{
						return;
					}
					this.TodDataAsset = dataAsset;
					this.KuroPostProcessComponent.PPTODDataAsset = this.TodDataAsset;
					this.KuroPostProcessComponent.SetPriority(this.Priority);
				}, 100, "js_undefined");
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "氛围组件初始化失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("WeatherDataAssetPath", this.WeatherDataAssetPath);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TodDataAssetPath", this.TodDataAssetPath);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x060462EF RID: 287471 RVA: 0x0118A2DE File Offset: 0x011884DE
		private void OnPlayerTrigger(bool isEnter)
		{
			if (isEnter)
			{
				this.OnTriggerEnter();
				return;
			}
			this.OnTriggerExit();
		}

		// Token: 0x060462F0 RID: 287472 RVA: 0x0118A2F0 File Offset: 0x011884F0
		public void OnTriggerEnter()
		{
			if (!this.IsInit || !this.IsEnabled)
			{
				return;
			}
			this.InTrigger = true;
			this.SetTargetBlendWeight(1f, false);
		}

		// Token: 0x060462F1 RID: 287473 RVA: 0x0118A316 File Offset: 0x01188516
		public void OnTriggerExit()
		{
			if (!this.IsInit || !this.IsEnabled)
			{
				return;
			}
			this.InTrigger = false;
			this.SetTargetBlendWeight(0f, false);
		}

		// Token: 0x060462F2 RID: 287474 RVA: 0x0118A33C File Offset: 0x0118853C
		public void SetTargetBlendWeight(float blendWeight, bool immediately = false)
		{
			if (!this.IsInit)
			{
				return;
			}
			this.TargetBlendWeight = blendWeight;
			if (immediately || this.ChangeSpeed == 0f)
			{
				this.CurBlendWeight = blendWeight;
				this.KuroPostProcessComponent.BlendWeight = this.CurBlendWeight;
				this.UpdatePostProcessComponentEnable();
			}
		}

		// Token: 0x060462F3 RID: 287475 RVA: 0x0118A37C File Offset: 0x0118857C
		public void EnableComponent()
		{
			if (!this.IsInit)
			{
				return;
			}
			this.IsEnabled = true;
			this.TickTime = 1000f;
			this.InTrigger = false;
			if (this.ActiveByTriggerComponent)
			{
				if (this.RangeComponent.IsOverlappingPlayer())
				{
					this.OnTriggerEnter();
					return;
				}
			}
			else
			{
				ISkyboxTrigger triggerMode = this.TriggerMode;
				if (triggerMode != null && triggerMode.Type == ETriggerMode.Global)
				{
					this.OnTriggerEnter();
				}
			}
		}

		// Token: 0x060462F4 RID: 287476 RVA: 0x0118A3E4 File Offset: 0x011885E4
		public void DisableComponent()
		{
			if (!this.IsInit)
			{
				return;
			}
			this.IsEnabled = false;
			this.SetTargetBlendWeight(0f, false);
		}

		// Token: 0x060462F5 RID: 287477 RVA: 0x0118A402 File Offset: 0x01188602
		protected override void OnActivate()
		{
			if (!Info.Instance.EnableForceTick && base.Active)
			{
				ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.ForceTickInternal));
			}
		}

		// Token: 0x060462F6 RID: 287478 RVA: 0x0118A42F File Offset: 0x0118862F
		protected override void OnEnable()
		{
			if (!Info.Instance.EnableForceTick)
			{
				Entity entity = base.Entity;
				if (entity != null && entity.IsInit)
				{
					ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.ForceTickInternal));
				}
			}
		}

		// Token: 0x060462F7 RID: 287479 RVA: 0x0118A468 File Offset: 0x01188668
		[NullableContext(1)]
		protected override void OnDisable(string reason)
		{
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterTick(this);
			}
		}

		// Token: 0x060462F8 RID: 287480 RVA: 0x0118A481 File Offset: 0x01188681
		protected override void OnForceTick(float delta)
		{
			this.ForceTickInternal(delta);
		}

		// Token: 0x060462F9 RID: 287481 RVA: 0x0118A48C File Offset: 0x0118868C
		private void ForceTickInternal(float delta)
		{
			if (!this.IsInit)
			{
				return;
			}
			float? triggerDistanceSquared = this.TriggerDistanceSquared;
			float num = 0f;
			if (triggerDistanceSquared.GetValueOrDefault() > num & triggerDistanceSquared != null)
			{
				this.CheckInTriggerByTriggerDistance(delta);
			}
			if (Math.Abs(this.CurBlendWeight - this.TargetBlendWeight) < 1.1754944E-38f)
			{
				return;
			}
			if (this.TargetBlendWeight > this.CurBlendWeight)
			{
				this.CurBlendWeight += delta * this.ChangeSpeed;
				this.CurBlendWeight = Math.Min(this.CurBlendWeight, this.TargetBlendWeight);
			}
			else
			{
				this.CurBlendWeight -= delta * this.ChangeSpeed;
				this.CurBlendWeight = Math.Max(this.CurBlendWeight, this.TargetBlendWeight);
			}
			this.KuroPostProcessComponent.BlendWeight = this.CurBlendWeight;
			this.UpdatePostProcessComponentEnable();
		}

		// Token: 0x060462FA RID: 287482 RVA: 0x0118A564 File Offset: 0x01188764
		private void CheckInTriggerByTriggerDistance(float delta)
		{
			this.TickTime += delta;
			if (this.TickTime < 1000f)
			{
				return;
			}
			this.TickTime = 0f;
			AActor myRoleTrigger = RoleTriggerController.Instance.GetMyRoleTrigger();
			if (myRoleTrigger != null && myRoleTrigger.IsValid())
			{
				AActor actor = this.Actor;
				if (actor != null && actor.IsValid())
				{
					float squaredDistanceTo = myRoleTrigger.GetSquaredDistanceTo(this.Actor);
					float? triggerDistanceSquared = this.TriggerDistanceSquared;
					bool flag = squaredDistanceTo < triggerDistanceSquared.GetValueOrDefault() & triggerDistanceSquared != null;
					if (!this.InTrigger)
					{
						if (flag)
						{
							this.OnTriggerEnter();
							return;
						}
					}
					else if (!flag)
					{
						this.OnTriggerExit();
					}
					return;
				}
			}
		}

		// Token: 0x060462FB RID: 287483 RVA: 0x0118A60C File Offset: 0x0118880C
		private void UpdatePostProcessComponentEnable()
		{
			this.KuroPostProcessComponent.bEnabled = (this.CurBlendWeight > 0f);
		}

		// Token: 0x060462FC RID: 287484 RVA: 0x0118A628 File Offset: 0x01188828
		protected override bool OnEnd()
		{
			if (this.RangeComponent != null)
			{
				this.RangeComponent.RemoveOnPlayerOverlapCallback(new Action<bool>(this.OnPlayerTrigger));
				this.RangeComponent = null;
			}
			this.IsInit = false;
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterTick(this);
			}
			return true;
		}

		// Token: 0x060462FD RID: 287485 RVA: 0x0118A67C File Offset: 0x0118887C
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PostProcessBridgeComponent postProcessBridgeComponent = (PostProcessBridgeComponent)componentTemplate;
			if (base.CanResetComponentProperty("IsInit"))
			{
				this.IsInit = postProcessBridgeComponent.IsInit;
			}
			if (base.CanResetComponentProperty("IsEnabled"))
			{
				this.IsEnabled = postProcessBridgeComponent.IsEnabled;
			}
			if (base.CanResetComponentProperty("WeatherDataAssetPath"))
			{
				this.WeatherDataAssetPath = postProcessBridgeComponent.WeatherDataAssetPath;
			}
			if (base.CanResetComponentProperty("TodDataAssetPath"))
			{
				this.TodDataAssetPath = postProcessBridgeComponent.TodDataAssetPath;
			}
			if (base.CanResetComponentProperty("WeatherDataAsset"))
			{
				if (postProcessBridgeComponent.WeatherDataAsset == null)
				{
					this.WeatherDataAsset = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroWeatherDataAsset>(this.WeatherDataAsset), "WeatherDataAsset"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TodDataAsset"))
			{
				if (postProcessBridgeComponent.TodDataAsset == null)
				{
					this.TodDataAsset = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroTODData>(this.TodDataAsset), "TodDataAsset"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("RangeComponent"))
			{
				if (postProcessBridgeComponent.RangeComponent == null)
				{
					this.RangeComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent>(this.RangeComponent), "RangeComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("KuroPostProcessComponent"))
			{
				if (postProcessBridgeComponent.KuroPostProcessComponent == null)
				{
					this.KuroPostProcessComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroPostProcessComponent>(this.KuroPostProcessComponent), "KuroPostProcessComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("Actor"))
			{
				if (postProcessBridgeComponent.Actor == null)
				{
					this.Actor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.Actor), "Actor"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActiveByTriggerComponent"))
			{
				this.ActiveByTriggerComponent = postProcessBridgeComponent.ActiveByTriggerComponent;
			}
			if (base.CanResetComponentProperty("TriggerMode"))
			{
				if (postProcessBridgeComponent.TriggerMode == null)
				{
					this.TriggerMode = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ISkyboxTrigger>(this.TriggerMode), "TriggerMode"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TriggerDistanceSquared"))
			{
				this.TriggerDistanceSquared = postProcessBridgeComponent.TriggerDistanceSquared;
			}
			if (base.CanResetComponentProperty("TickTime"))
			{
				this.TickTime = postProcessBridgeComponent.TickTime;
			}
			if (base.CanResetComponentProperty("InTrigger"))
			{
				this.InTrigger = postProcessBridgeComponent.InTrigger;
			}
			if (base.CanResetComponentProperty("ChangeSpeed"))
			{
				this.ChangeSpeed = postProcessBridgeComponent.ChangeSpeed;
			}
			if (base.CanResetComponentProperty("Priority"))
			{
				this.Priority = postProcessBridgeComponent.Priority;
			}
			if (base.CanResetComponentProperty("TargetBlendWeight"))
			{
				this.TargetBlendWeight = postProcessBridgeComponent.TargetBlendWeight;
			}
			if (base.CanResetComponentProperty("CurBlendWeight"))
			{
				this.CurBlendWeight = postProcessBridgeComponent.CurBlendWeight;
			}
			return true;
		}

		// Token: 0x04024C30 RID: 150576
		private const int DEFAULT_PRIORITY = 10;

		// Token: 0x04024C31 RID: 150577
		private const int TICK_TIME = 1000;

		// Token: 0x04024C32 RID: 150578
		private bool IsInit;

		// Token: 0x04024C33 RID: 150579
		private bool IsEnabled;

		// Token: 0x04024C34 RID: 150580
		private string WeatherDataAssetPath;

		// Token: 0x04024C35 RID: 150581
		private string TodDataAssetPath;

		// Token: 0x04024C36 RID: 150582
		private UKuroWeatherDataAsset WeatherDataAsset;

		// Token: 0x04024C37 RID: 150583
		private UKuroTODData TodDataAsset;

		// Token: 0x04024C38 RID: 150584
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComponent;

		// Token: 0x04024C39 RID: 150585
		private UKuroPostProcessComponent KuroPostProcessComponent;

		// Token: 0x04024C3A RID: 150586
		private AActor Actor;

		// Token: 0x04024C3B RID: 150587
		private bool ActiveByTriggerComponent = true;

		// Token: 0x04024C3C RID: 150588
		private ISkyboxTrigger TriggerMode;

		// Token: 0x04024C3D RID: 150589
		private float? TriggerDistanceSquared;

		// Token: 0x04024C3E RID: 150590
		private float TickTime;

		// Token: 0x04024C3F RID: 150591
		private bool InTrigger;

		// Token: 0x04024C40 RID: 150592
		private float ChangeSpeed = 0.001f;

		// Token: 0x04024C41 RID: 150593
		private float Priority = 10f;

		// Token: 0x04024C42 RID: 150594
		private float TargetBlendWeight;

		// Token: 0x04024C43 RID: 150595
		private float CurBlendWeight;
	}
}
