using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.Data.Weather;
using UnrealEngine;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02004861 RID: 18529
	[NullableContext(2)]
	[Nullable(0)]
	public class WeatherActor
	{
		// Token: 0x17007922 RID: 31010
		// (get) Token: 0x060307DE RID: 198622 RVA: 0x00B4295F File Offset: 0x00B40B5F
		public bool IsWeatherForbidden
		{
			get
			{
				return this.ForbidWeather;
			}
		}

		// Token: 0x060307DF RID: 198623 RVA: 0x00B42968 File Offset: 0x00B40B68
		private void CheckActorExistThenInit()
		{
			BP_Weather_C weatherActorInternal = this.WeatherActorInternal;
			if (weatherActorInternal == null || !weatherActorInternal.IsValid())
			{
				this.WeatherActorInternal = (ActorSystem.Instance.Get(BP_Weather_C.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as BP_Weather_C);
				this.WeatherActorInternal.OnDestroyed.Add(new Action<AActor>(this.OnActorDestroy));
				this.WeatherComponent1.Component = this.WeatherActorInternal.KuroPostProcess_1;
				this.WeatherComponent1.BlendWeightNonScale = 1f;
				this.WeatherComponent2.Component = this.WeatherActorInternal.KuroPostProcess_2;
				this.WeatherComponent2.BlendWeightNonScale = 0f;
				this.ApplyWeight(this.WeatherComponent1);
				this.ApplyWeight(this.WeatherComponent2);
			}
		}

		// Token: 0x060307E0 RID: 198624 RVA: 0x00B42A35 File Offset: 0x00B40C35
		public void BanWeather()
		{
			this.Destroy();
			this.BanState = !this.BanState;
		}

		// Token: 0x060307E1 RID: 198625 RVA: 0x00B42A4C File Offset: 0x00B40C4C
		public void SetActorState(bool state)
		{
			if (this.CurrentState != state)
			{
				BP_Weather_C weatherActorInternal = this.WeatherActorInternal;
				if (weatherActorInternal != null && weatherActorInternal.IsValid())
				{
					this.WeatherActorInternal.SetActorHiddenInGame(!state);
				}
				this.CurrentState = state;
			}
		}

		// Token: 0x060307E2 RID: 198626 RVA: 0x00B42A81 File Offset: 0x00B40C81
		private void CancelCurrentLoadTask()
		{
			if (this.CurrentLoadTask != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.CurrentLoadTask);
				this.CurrentLoadTask = 0;
			}
		}

		// Token: 0x060307E3 RID: 198627 RVA: 0x00B42AA4 File Offset: 0x00B40CA4
		public unsafe void ChangeWeather(int targetId, float tweenTime)
		{
			this.ClearTimer();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.YZY;
			string message = "改变天气";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("targetId", targetId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tweentime", tweenTime);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (this.BanState)
			{
				return;
			}
			Weather? weatherConfig = WeatherModuleConfig.Instance.GetWeatherConfig(targetId);
			if (weatherConfig == null)
			{
				return;
			}
			string dapath = weatherConfig.Value.DAPath;
			this.CheckActorExistThenInit();
			if (this.WeatherComponent1.BlendWeightNonScale >= this.WeatherComponent2.BlendWeightNonScale)
			{
				this.CurrentComponent = this.WeatherComponent1;
				this.TargetComponent = this.WeatherComponent2;
			}
			else
			{
				this.CurrentComponent = this.WeatherComponent2;
				this.TargetComponent = this.WeatherComponent1;
			}
			this.CancelCurrentLoadTask();
			this.CurrentLoadTask = ResourceSystem.Instance.LoadAsync<UKuroWeatherDataAsset>(dapath, delegate([Nullable(2)] UKuroWeatherDataAsset dataAsset, string path)
			{
				if (dataAsset == null || !dataAsset.IsValid())
				{
					return;
				}
				if (this.TargetComponent == null || this.TargetComponent.Component == null)
				{
					return;
				}
				this.CurrentLoadTask = 0;
				this.TargetComponent.Component.WeatherDataAsset = dataAsset;
			}, ResourceSystem.EResourceLoadPriority.Default, "Ui.WeatherUi");
			if (tweenTime == 0f)
			{
				this.OnTweenCurrentUpdate(0f);
				this.OnTweenTargetUpdate(1f);
				return;
			}
			this.Timer1StartValue = this.CurrentComponent.BlendWeightNonScale;
			this.Timer1EndValue = 0f;
			this.Timer2StartValue = this.TargetComponent.BlendWeightNonScale;
			this.Timer2EndValue = 1f;
			this.TweenTime = tweenTime;
			this.CurrentRunningTime = 0f;
			if (this.Ticker == -1)
			{
				this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "WeatherActor", ETickingGroup.TG_PrePhysics, false, 0, false).Id;
			}
		}

		// Token: 0x060307E4 RID: 198628 RVA: 0x00B42C5C File Offset: 0x00B40E5C
		public void SetWeatherForbidden(bool bForbidWeather)
		{
			this.ForbidWeather = bForbidWeather;
			if (this.Ticker == -1)
			{
				this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "WeatherActor", ETickingGroup.TG_PrePhysics, false, 0, false).Id;
			}
		}

		// Token: 0x060307E5 RID: 198629 RVA: 0x00B42C98 File Offset: 0x00B40E98
		private void ClearTimer()
		{
			if (this.Ticker != -1)
			{
				TickSystem.Instance.Remove(this.Ticker);
				this.Ticker = -1;
			}
		}

		// Token: 0x060307E6 RID: 198630 RVA: 0x00B42CBC File Offset: 0x00B40EBC
		private void OnTick(float _)
		{
			this.CurrentRunningTime += Time.Instance.DeltaTime;
			float num = this.CurrentRunningTime / (this.TweenTime * 1000f);
			num = MathUtils.Instance.Clamp(num, 0f, 1f);
			float value = MathUtils.Instance.Lerp(this.Timer1StartValue, this.Timer1EndValue, num);
			float value2 = MathUtils.Instance.Lerp(this.Timer2StartValue, this.Timer2EndValue, num);
			float deltaTimeSeconds = Time.Instance.DeltaTimeSeconds;
			this.WeatherScalar = (this.ForbidWeather ? (this.WeatherScalar - deltaTimeSeconds) : (this.WeatherScalar + deltaTimeSeconds));
			this.WeatherScalar = MathUtils.Instance.Clamp(this.WeatherScalar, 0f, 1f);
			this.OnTweenCurrentUpdate(value);
			this.OnTweenTargetUpdate(value2);
			if (num >= 1f && ((this.ForbidWeather && this.WeatherScalar <= 0f) || (!this.ForbidWeather && this.WeatherScalar >= 1f)))
			{
				this.ClearTimer();
			}
		}

		// Token: 0x060307E7 RID: 198631 RVA: 0x00B42DCB File Offset: 0x00B40FCB
		private void OnTweenCurrentUpdate(float value)
		{
			if (this.CurrentComponent != null)
			{
				this.CurrentComponent.BlendWeightNonScale = value;
				this.ApplyWeight(this.CurrentComponent);
			}
		}

		// Token: 0x060307E8 RID: 198632 RVA: 0x00B42DED File Offset: 0x00B40FED
		private void OnTweenTargetUpdate(float value)
		{
			if (this.TargetComponent != null)
			{
				this.TargetComponent.BlendWeightNonScale = value;
				this.ApplyWeight(this.TargetComponent);
			}
		}

		// Token: 0x060307E9 RID: 198633 RVA: 0x00B42E0F File Offset: 0x00B4100F
		private void OnActorDestroy(AActor _)
		{
			this.ClearTimer();
			this.CurrentComponent = null;
			this.TargetComponent = null;
			this.WeatherActorInternal = null;
		}

		// Token: 0x060307EA RID: 198634 RVA: 0x00B42E2C File Offset: 0x00B4102C
		public void Destroy()
		{
			BP_Weather_C weatherActorInternal = this.WeatherActorInternal;
			if (weatherActorInternal != null && weatherActorInternal.IsValid())
			{
				this.WeatherActorInternal.K2_DestroyActor();
			}
			this.CurrentState = false;
			this.WeatherActorInternal = null;
		}

		// Token: 0x060307EB RID: 198635 RVA: 0x00B42E5B File Offset: 0x00B4105B
		public void SuppressPostProcessWeight()
		{
			this.SetExternalWeightScale(0f);
		}

		// Token: 0x060307EC RID: 198636 RVA: 0x00B42E68 File Offset: 0x00B41068
		public void RestorePostProcessWeight()
		{
			this.SetExternalWeightScale(1f);
		}

		// Token: 0x060307ED RID: 198637 RVA: 0x00B42E78 File Offset: 0x00B41078
		private void SetExternalWeightScale(float scale)
		{
			this.ExternalWeightScale = scale;
			this.ApplyWeight(this.CurrentComponent);
			this.ApplyWeight(this.TargetComponent);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Weather;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "世界天气后处理权重外部倍率变更";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("scale", scale);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x060307EE RID: 198638 RVA: 0x00B42ED3 File Offset: 0x00B410D3
		private void ApplyWeight(WeatherComponent component)
		{
			if (((component != null) ? component.Component : null) == null)
			{
				return;
			}
			component.Component.BlendWeight = component.BlendWeightNonScale * this.WeatherScalar * this.ExternalWeightScale;
		}

		// Token: 0x0401A0C7 RID: 106695
		private BP_Weather_C WeatherActorInternal;

		// Token: 0x0401A0C8 RID: 106696
		[Nullable(1)]
		private readonly WeatherComponent WeatherComponent1 = new WeatherComponent();

		// Token: 0x0401A0C9 RID: 106697
		[Nullable(1)]
		private readonly WeatherComponent WeatherComponent2 = new WeatherComponent();

		// Token: 0x0401A0CA RID: 106698
		private WeatherComponent CurrentComponent;

		// Token: 0x0401A0CB RID: 106699
		private WeatherComponent TargetComponent;

		// Token: 0x0401A0CC RID: 106700
		private float Timer1StartValue;

		// Token: 0x0401A0CD RID: 106701
		private float Timer2StartValue;

		// Token: 0x0401A0CE RID: 106702
		private float Timer1EndValue;

		// Token: 0x0401A0CF RID: 106703
		private float Timer2EndValue;

		// Token: 0x0401A0D0 RID: 106704
		private float CurrentRunningTime;

		// Token: 0x0401A0D1 RID: 106705
		private float TweenTime;

		// Token: 0x0401A0D2 RID: 106706
		private bool BanState;

		// Token: 0x0401A0D3 RID: 106707
		private int Ticker = -1;

		// Token: 0x0401A0D4 RID: 106708
		private bool CurrentState;

		// Token: 0x0401A0D5 RID: 106709
		private int CurrentLoadTask;

		// Token: 0x0401A0D6 RID: 106710
		private bool ForbidWeather;

		// Token: 0x0401A0D7 RID: 106711
		private float WeatherScalar = 1f;

		// Token: 0x0401A0D8 RID: 106712
		private float ExternalWeightScale = 1f;
	}
}
