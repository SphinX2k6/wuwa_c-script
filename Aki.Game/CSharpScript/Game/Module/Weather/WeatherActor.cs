using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Render.Data.Weather;
using UnrealEngine;

namespace CSharpScript.Game.Module.Weather
{
	// Token: 0x02003792 RID: 14226
	[NullableContext(2)]
	[Nullable(0)]
	public class WeatherActor
	{
		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x06024FAD RID: 151469 RVA: 0x00A72BA3 File Offset: 0x00A70DA3
		public bool IsWeatherForbidden
		{
			get
			{
				return this.ForbidWeather;
			}
		}

		// Token: 0x06024FAE RID: 151470 RVA: 0x00A72BAC File Offset: 0x00A70DAC
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

		// Token: 0x06024FAF RID: 151471 RVA: 0x00A72C79 File Offset: 0x00A70E79
		public void BanWeather()
		{
			this.Destroy();
			this.BanState = !this.BanState;
		}

		// Token: 0x06024FB0 RID: 151472 RVA: 0x00A72C90 File Offset: 0x00A70E90
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

		// Token: 0x06024FB1 RID: 151473 RVA: 0x00A72CC5 File Offset: 0x00A70EC5
		private void CancelCurrentLoadTask()
		{
			if (this.CurrentLoadTask != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.CurrentLoadTask);
				this.CurrentLoadTask = 0;
			}
		}

		// Token: 0x06024FB2 RID: 151474 RVA: 0x00A72CE8 File Offset: 0x00A70EE8
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

		// Token: 0x06024FB3 RID: 151475 RVA: 0x00A72EA0 File Offset: 0x00A710A0
		public void SetWeatherForbidden(bool bForbidWeather)
		{
			this.ForbidWeather = bForbidWeather;
			if (this.Ticker == -1)
			{
				this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "WeatherActor", ETickingGroup.TG_PrePhysics, false, 0, false).Id;
			}
		}

		// Token: 0x06024FB4 RID: 151476 RVA: 0x00A72EDC File Offset: 0x00A710DC
		public void SetWeatherForbiddenImmediately(bool bForbidWeather)
		{
			this.ForbidWeather = bForbidWeather;
			this.WeatherScalar = (bForbidWeather ? 0f : 1f);
			this.ApplyWeight(this.CurrentComponent);
			this.ApplyWeight(this.TargetComponent);
		}

		// Token: 0x06024FB5 RID: 151477 RVA: 0x00A72F12 File Offset: 0x00A71112
		private void ClearTimer()
		{
			if (this.Ticker != -1)
			{
				TickSystem.Instance.Remove(this.Ticker);
				this.Ticker = -1;
			}
		}

		// Token: 0x06024FB6 RID: 151478 RVA: 0x00A72F38 File Offset: 0x00A71138
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

		// Token: 0x06024FB7 RID: 151479 RVA: 0x00A73047 File Offset: 0x00A71247
		private void OnTweenCurrentUpdate(float value)
		{
			if (this.CurrentComponent != null)
			{
				this.CurrentComponent.BlendWeightNonScale = value;
				this.ApplyWeight(this.CurrentComponent);
			}
		}

		// Token: 0x06024FB8 RID: 151480 RVA: 0x00A73069 File Offset: 0x00A71269
		private void OnTweenTargetUpdate(float value)
		{
			if (this.TargetComponent != null)
			{
				this.TargetComponent.BlendWeightNonScale = value;
				this.ApplyWeight(this.TargetComponent);
			}
		}

		// Token: 0x06024FB9 RID: 151481 RVA: 0x00A7308B File Offset: 0x00A7128B
		private void OnActorDestroy(AActor _)
		{
			this.ClearTimer();
			this.CurrentComponent = null;
			this.TargetComponent = null;
			this.WeatherActorInternal = null;
		}

		// Token: 0x06024FBA RID: 151482 RVA: 0x00A730A8 File Offset: 0x00A712A8
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

		// Token: 0x06024FBB RID: 151483 RVA: 0x00A730D7 File Offset: 0x00A712D7
		public void SuppressPostProcessWeight()
		{
			this.SetExternalWeightScale(0f);
		}

		// Token: 0x06024FBC RID: 151484 RVA: 0x00A730E4 File Offset: 0x00A712E4
		public void RestorePostProcessWeight()
		{
			this.SetExternalWeightScale(1f);
		}

		// Token: 0x06024FBD RID: 151485 RVA: 0x00A730F4 File Offset: 0x00A712F4
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

		// Token: 0x06024FBE RID: 151486 RVA: 0x00A7314F File Offset: 0x00A7134F
		private void ApplyWeight(WeatherComponent component)
		{
			if (((component != null) ? component.Component : null) == null)
			{
				return;
			}
			component.Component.BlendWeight = component.BlendWeightNonScale * this.WeatherScalar * this.ExternalWeightScale;
		}

		// Token: 0x0401477B RID: 83835
		private BP_Weather_C WeatherActorInternal;

		// Token: 0x0401477C RID: 83836
		[Nullable(1)]
		private readonly WeatherComponent WeatherComponent1 = new WeatherComponent();

		// Token: 0x0401477D RID: 83837
		[Nullable(1)]
		private readonly WeatherComponent WeatherComponent2 = new WeatherComponent();

		// Token: 0x0401477E RID: 83838
		private WeatherComponent CurrentComponent;

		// Token: 0x0401477F RID: 83839
		private WeatherComponent TargetComponent;

		// Token: 0x04014780 RID: 83840
		private float Timer1StartValue;

		// Token: 0x04014781 RID: 83841
		private float Timer2StartValue;

		// Token: 0x04014782 RID: 83842
		private float Timer1EndValue;

		// Token: 0x04014783 RID: 83843
		private float Timer2EndValue;

		// Token: 0x04014784 RID: 83844
		private float CurrentRunningTime;

		// Token: 0x04014785 RID: 83845
		private float TweenTime;

		// Token: 0x04014786 RID: 83846
		private bool BanState;

		// Token: 0x04014787 RID: 83847
		private int Ticker = -1;

		// Token: 0x04014788 RID: 83848
		private bool CurrentState;

		// Token: 0x04014789 RID: 83849
		private int CurrentLoadTask;

		// Token: 0x0401478A RID: 83850
		private bool ForbidWeather;

		// Token: 0x0401478B RID: 83851
		private float WeatherScalar = 1f;

		// Token: 0x0401478C RID: 83852
		private float ExternalWeightScale = 1f;
	}
}
