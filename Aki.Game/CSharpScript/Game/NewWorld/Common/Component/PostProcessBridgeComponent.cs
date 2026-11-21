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
	// Token: 0x0200620B RID: 25099
	[NullableContext(2)]
	[Nullable(0)]
	public class PostProcessBridgeComponent : EntityComponent
	{
		// Token: 0x0603C51C RID: 247068 RVA: 0x01133258 File Offset: 0x01131458
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

		// Token: 0x0603C51D RID: 247069 RVA: 0x0113346C File Offset: 0x0113166C
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

		// Token: 0x0603C51E RID: 247070 RVA: 0x0113367A File Offset: 0x0113187A
		private void OnPlayerTrigger(bool isEnter)
		{
			if (isEnter)
			{
				this.OnTriggerEnter();
				return;
			}
			this.OnTriggerExit();
		}

		// Token: 0x0603C51F RID: 247071 RVA: 0x0113368C File Offset: 0x0113188C
		public void OnTriggerEnter()
		{
			if (!this.IsInit || !this.IsEnabled)
			{
				return;
			}
			this.InTrigger = true;
			this.SetTargetBlendWeight(1f, false);
		}

		// Token: 0x0603C520 RID: 247072 RVA: 0x011336B2 File Offset: 0x011318B2
		public void OnTriggerExit()
		{
			if (!this.IsInit || !this.IsEnabled)
			{
				return;
			}
			this.InTrigger = false;
			this.SetTargetBlendWeight(0f, false);
		}

		// Token: 0x0603C521 RID: 247073 RVA: 0x011336D8 File Offset: 0x011318D8
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

		// Token: 0x0603C522 RID: 247074 RVA: 0x01133718 File Offset: 0x01131918
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

		// Token: 0x0603C523 RID: 247075 RVA: 0x01133780 File Offset: 0x01131980
		public void DisableComponent()
		{
			if (!this.IsInit)
			{
				return;
			}
			this.IsEnabled = false;
			this.SetTargetBlendWeight(0f, false);
		}

		// Token: 0x0603C524 RID: 247076 RVA: 0x0113379E File Offset: 0x0113199E
		protected override void OnActivate()
		{
			if (!Info.Instance.EnableForceTick && base.Active)
			{
				ComponentForceTickController.Instance.RegisterTick(this, new Action<float>(this.ForceTickInternal));
			}
		}

		// Token: 0x0603C525 RID: 247077 RVA: 0x011337CB File Offset: 0x011319CB
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

		// Token: 0x0603C526 RID: 247078 RVA: 0x01133804 File Offset: 0x01131A04
		[NullableContext(1)]
		protected override void OnDisable(string reason)
		{
			if (!Info.Instance.EnableForceTick)
			{
				ComponentForceTickController.Instance.UnregisterTick(this);
			}
		}

		// Token: 0x0603C527 RID: 247079 RVA: 0x0113381D File Offset: 0x01131A1D
		protected override void OnForceTick(float delta)
		{
			this.ForceTickInternal(delta);
		}

		// Token: 0x0603C528 RID: 247080 RVA: 0x01133828 File Offset: 0x01131A28
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

		// Token: 0x0603C529 RID: 247081 RVA: 0x01133900 File Offset: 0x01131B00
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

		// Token: 0x0603C52A RID: 247082 RVA: 0x011339A8 File Offset: 0x01131BA8
		private void UpdatePostProcessComponentEnable()
		{
			this.KuroPostProcessComponent.bEnabled = (this.CurBlendWeight > 0f);
		}

		// Token: 0x0603C52B RID: 247083 RVA: 0x011339C4 File Offset: 0x01131BC4
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

		// Token: 0x0603C52C RID: 247084 RVA: 0x01133A18 File Offset: 0x01131C18
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PostProcessBridgeComponent postProcessBridgeComponent = (PostProcessBridgeComponent)componentTemplate;
			this.IsInit = postProcessBridgeComponent.IsInit;
			this.IsEnabled = postProcessBridgeComponent.IsEnabled;
			this.WeatherDataAssetPath = postProcessBridgeComponent.WeatherDataAssetPath;
			this.TodDataAssetPath = postProcessBridgeComponent.TodDataAssetPath;
			if (postProcessBridgeComponent.WeatherDataAsset == null)
			{
				this.WeatherDataAsset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WeatherDataAsset), "WeatherDataAsset"))
			{
				return false;
			}
			if (postProcessBridgeComponent.TodDataAsset == null)
			{
				this.TodDataAsset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TodDataAsset), "TodDataAsset"))
			{
				return false;
			}
			if (postProcessBridgeComponent.RangeComponent == null)
			{
				this.RangeComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.RangeComponent), "RangeComponent"))
			{
				return false;
			}
			if (postProcessBridgeComponent.KuroPostProcessComponent == null)
			{
				this.KuroPostProcessComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.KuroPostProcessComponent), "KuroPostProcessComponent"))
			{
				return false;
			}
			if (postProcessBridgeComponent.Actor == null)
			{
				this.Actor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Actor), "Actor"))
			{
				return false;
			}
			this.ActiveByTriggerComponent = postProcessBridgeComponent.ActiveByTriggerComponent;
			if (postProcessBridgeComponent.TriggerMode == null)
			{
				this.TriggerMode = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TriggerMode), "TriggerMode"))
			{
				return false;
			}
			this.TriggerDistanceSquared = postProcessBridgeComponent.TriggerDistanceSquared;
			this.TickTime = postProcessBridgeComponent.TickTime;
			this.InTrigger = postProcessBridgeComponent.InTrigger;
			this.ChangeSpeed = postProcessBridgeComponent.ChangeSpeed;
			this.Priority = postProcessBridgeComponent.Priority;
			this.TargetBlendWeight = postProcessBridgeComponent.TargetBlendWeight;
			this.CurBlendWeight = postProcessBridgeComponent.CurBlendWeight;
			return true;
		}

		// Token: 0x170071DA RID: 29146
		// (get) Token: 0x0603C52D RID: 247085 RVA: 0x01133BCA File Offset: 0x01131DCA
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071DB RID: 29147
		// (get) Token: 0x0603C52E RID: 247086 RVA: 0x01133BCD File Offset: 0x01131DCD
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071DC RID: 29148
		// (get) Token: 0x0603C52F RID: 247087 RVA: 0x01133BD0 File Offset: 0x01131DD0
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071DD RID: 29149
		// (get) Token: 0x0603C530 RID: 247088 RVA: 0x01133BD3 File Offset: 0x01131DD3
		public override bool NeedEnableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071DE RID: 29150
		// (get) Token: 0x0603C531 RID: 247089 RVA: 0x01133BD6 File Offset: 0x01131DD6
		public override bool NeedDisableInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071DF RID: 29151
		// (get) Token: 0x0603C532 RID: 247090 RVA: 0x01133BD9 File Offset: 0x01131DD9
		public override bool NeedForceTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FEEB RID: 130795
		private const int DEFAULT_PRIORITY = 10;

		// Token: 0x0401FEEC RID: 130796
		private const int TICK_TIME = 1000;

		// Token: 0x0401FEED RID: 130797
		private bool IsInit;

		// Token: 0x0401FEEE RID: 130798
		private bool IsEnabled;

		// Token: 0x0401FEEF RID: 130799
		private string WeatherDataAssetPath;

		// Token: 0x0401FEF0 RID: 130800
		private string TodDataAssetPath;

		// Token: 0x0401FEF1 RID: 130801
		private UKuroWeatherDataAsset WeatherDataAsset;

		// Token: 0x0401FEF2 RID: 130802
		private UKuroTODData TodDataAsset;

		// Token: 0x0401FEF3 RID: 130803
		private CSharpScript.Game.NewWorld.Character.Custom.Components.RangeComponent RangeComponent;

		// Token: 0x0401FEF4 RID: 130804
		private UKuroPostProcessComponent KuroPostProcessComponent;

		// Token: 0x0401FEF5 RID: 130805
		private AActor Actor;

		// Token: 0x0401FEF6 RID: 130806
		private bool ActiveByTriggerComponent = true;

		// Token: 0x0401FEF7 RID: 130807
		private ISkyboxTrigger TriggerMode;

		// Token: 0x0401FEF8 RID: 130808
		private float? TriggerDistanceSquared;

		// Token: 0x0401FEF9 RID: 130809
		private float TickTime;

		// Token: 0x0401FEFA RID: 130810
		private bool InTrigger;

		// Token: 0x0401FEFB RID: 130811
		private float ChangeSpeed = 0.001f;

		// Token: 0x0401FEFC RID: 130812
		private float Priority = 10f;

		// Token: 0x0401FEFD RID: 130813
		private float TargetBlendWeight;

		// Token: 0x0401FEFE RID: 130814
		private float CurBlendWeight;
	}
}
