using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Weather;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FD3 RID: 16339
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWeather
	{
		// Token: 0x06029591 RID: 169361 RVA: 0x00BA41CE File Offset: 0x00BA23CE
		public void Init()
		{
			this.WeatherId = 0;
			this.IsInherit = false;
		}

		// Token: 0x06029592 RID: 169362 RVA: 0x00BA41DE File Offset: 0x00BA23DE
		public void Clear()
		{
			this.WeatherId = 0;
			this.IsInherit = false;
			this.ClearAllWeather();
		}

		// Token: 0x06029593 RID: 169363 RVA: 0x00BA41F4 File Offset: 0x00BA23F4
		public void OnPlotEnd()
		{
			if (this.IsInherit)
			{
				this.IsInherit = false;
				WeatherController.Instance.RequestChangeWeather(this.WeatherId, null);
			}
			this.ClearAllWeather();
		}

		// Token: 0x06029594 RID: 169364 RVA: 0x00BA422F File Offset: 0x00BA242F
		public void StopAllWeather()
		{
			if (!this.IsInherit)
			{
				return;
			}
			PlotWeatherActorInfo curActorInfo = this.CurActorInfo;
			if (curActorInfo != null)
			{
				curActorInfo.Disable();
			}
			PlotWeatherActorInfo lastActorInfo = this.LastActorInfo;
			if (lastActorInfo == null)
			{
				return;
			}
			lastActorInfo.Disable();
		}

		// Token: 0x06029595 RID: 169365 RVA: 0x00BA425B File Offset: 0x00BA245B
		private void ClearAllWeather()
		{
			PlotWeatherActorInfo curActorInfo = this.CurActorInfo;
			if (curActorInfo != null)
			{
				curActorInfo.Destroy();
			}
			this.CurActorInfo = null;
			PlotWeatherActorInfo lastActorInfo = this.LastActorInfo;
			if (lastActorInfo != null)
			{
				lastActorInfo.Destroy();
			}
			this.LastActorInfo = null;
		}

		// Token: 0x06029596 RID: 169366 RVA: 0x00BA428D File Offset: 0x00BA248D
		public void OnTick(float delta)
		{
			this.UpdateBlendWeight(this.LastActorInfo, delta);
			this.UpdateBlendWeight(this.CurActorInfo, delta);
		}

		// Token: 0x06029597 RID: 169367 RVA: 0x00BA42AC File Offset: 0x00BA24AC
		private void UpdateBlendWeight(PlotWeatherActorInfo actorInfo, float delta)
		{
			if (actorInfo == null || !actorInfo.IsLoadCompleted)
			{
				return;
			}
			if (MathUtils.Instance.IsNearlyEqual((double)actorInfo.CurBlendWeight, (double)actorInfo.TargetBlendWeight, null))
			{
				return;
			}
			float curBlendWeight = actorInfo.CurBlendWeight;
			if (MathUtils.Instance.IsNearlyEqual((double)actorInfo.ChangeSpeed, 0.0, null))
			{
				actorInfo.CurBlendWeight = actorInfo.TargetBlendWeight;
			}
			else
			{
				if (delta <= 0f)
				{
					return;
				}
				if (actorInfo.TargetBlendWeight > actorInfo.CurBlendWeight)
				{
					actorInfo.CurBlendWeight += delta * actorInfo.ChangeSpeed;
					actorInfo.CurBlendWeight = Math.Min(actorInfo.CurBlendWeight, actorInfo.TargetBlendWeight);
				}
				else
				{
					actorInfo.CurBlendWeight -= delta * actorInfo.ChangeSpeed;
					actorInfo.CurBlendWeight = Math.Max(actorInfo.CurBlendWeight, actorInfo.TargetBlendWeight);
				}
			}
			actorInfo.KuroPostProcessComponent.BlendWeight = actorInfo.CurBlendWeight;
			if (curBlendWeight == 0f && actorInfo.CurBlendWeight > 0f)
			{
				actorInfo.KuroPostProcessComponent.bEnabled = true;
			}
			if (curBlendWeight > 0f && MathUtils.Instance.IsNearlyEqual((double)actorInfo.CurBlendWeight, 0.0, null))
			{
				actorInfo.KuroPostProcessComponent.bEnabled = false;
			}
		}

		// Token: 0x06029598 RID: 169368 RVA: 0x00BA4404 File Offset: 0x00BA2604
		public void ChangeWeather(int weatherId, bool isInherit, float tweenTime, int priority = 100)
		{
			this.WeatherId = weatherId;
			this.IsInherit = isInherit;
			if (this.CurActorInfo != null)
			{
				this.CurActorInfo.TargetBlendWeight = 0f;
			}
			Weather? weatherConfig = WeatherModuleConfig.Instance.GetWeatherConfig(weatherId);
			if (weatherConfig == null)
			{
				return;
			}
			if (this.CurActorInfo == null)
			{
				this.CurActorInfo = new PlotWeatherActorInfo();
				this.UpdateCurWeatherActorInfo(weatherConfig.Value, tweenTime);
				this.UpdateCurPriority(priority);
				this.CreateWeatherActor();
				return;
			}
			PlotWeatherActorInfo curActorInfo = this.CurActorInfo;
			int? num = (curActorInfo.WeatherConfig != null) ? new int?(curActorInfo.WeatherConfig.GetValueOrDefault().Id) : null;
			int id = weatherConfig.Value.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				this.CurActorInfo.TargetBlendWeight = 1f;
				this.UpdateBlendWeight(this.CurActorInfo, 0f);
				this.UpdateCurActorTransform();
				this.UpdateCurWeatherActorInfo(weatherConfig.Value, tweenTime);
				this.UpdateCurPriority(priority);
				return;
			}
			if (this.LastActorInfo == null)
			{
				this.LastActorInfo = this.CurActorInfo;
				this.CurActorInfo = new PlotWeatherActorInfo();
				this.UpdateCurWeatherActorInfo(weatherConfig.Value, tweenTime);
				this.UpdateCurPriority(priority);
				this.CreateWeatherActor();
				return;
			}
			PlotWeatherActorInfo curActorInfo2 = this.CurActorInfo;
			PlotWeatherActorInfo lastActorInfo = this.LastActorInfo;
			this.LastActorInfo = curActorInfo2;
			this.CurActorInfo = lastActorInfo;
			PlotWeatherActorInfo curActorInfo3 = this.CurActorInfo;
			num = ((curActorInfo3.WeatherConfig != null) ? new int?(curActorInfo3.WeatherConfig.GetValueOrDefault().Id) : null);
			id = weatherConfig.Value.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				this.CurActorInfo.TargetBlendWeight = 1f;
				this.UpdateBlendWeight(this.CurActorInfo, 0f);
				this.UpdateCurActorTransform();
				this.UpdateCurWeatherActorInfo(weatherConfig.Value, tweenTime);
				this.UpdateCurPriority(priority);
				return;
			}
			this.UpdateCurWeatherActorInfo(weatherConfig.Value, tweenTime);
			this.UpdateAtmosphereActor();
			this.UpdateCurPriority(priority);
		}

		// Token: 0x06029599 RID: 169369 RVA: 0x00BA4624 File Offset: 0x00BA2824
		private void UpdateCurWeatherActorInfo(Weather weatherConfig, float tweenTime)
		{
			this.CurActorInfo.WeatherConfig = new Weather?(weatherConfig);
			if (tweenTime > 0f)
			{
				this.CurActorInfo.ChangeSpeed = 1f / (tweenTime * (float)TimeUtil.Instance.InverseMillisecond);
			}
			else
			{
				this.CurActorInfo.ChangeSpeed = 0f;
			}
			if (this.LastActorInfo != null)
			{
				this.LastActorInfo.ChangeSpeed = this.CurActorInfo.ChangeSpeed;
			}
		}

		// Token: 0x0602959A RID: 169370 RVA: 0x00BA4698 File Offset: 0x00BA2898
		private void UpdateCurActorTransform()
		{
			if (this.CurActorInfo != null)
			{
				AActor actor = this.CurActorInfo.Actor;
				if (actor != null && actor.IsValid())
				{
					if (Global.BaseCharacter != null)
					{
						this.CurActorInfo.Actor.D_K2_SetActorLocation(Global.BaseCharacter.D_K2_GetActorLocation(), false, ref WorldGlobal.SweepHitResult, true);
					}
					return;
				}
			}
		}

		// Token: 0x0602959B RID: 169371 RVA: 0x00BA46F4 File Offset: 0x00BA28F4
		private void CreateWeatherActor()
		{
			FTransformDouble? ftransformDouble = null;
			if (Global.BaseCharacter != null)
			{
				ftransformDouble = new FTransformDouble?(Global.BaseCharacter.D_GetTransform());
			}
			else
			{
				ftransformDouble = new FTransformDouble?(new FTransformDouble());
			}
			AActor aactor = ActorSystem.Instance.Get(AActor.StaticClass(), ftransformDouble.Value, null, true);
			UKuroPostProcessComponent ukuroPostProcessComponent = (UKuroPostProcessComponent)aactor.AddComponentByClass(UKuroPostProcessComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
			ukuroPostProcessComponent.bUnbound = true;
			ukuroPostProcessComponent.BlendWeight = 0f;
			ukuroPostProcessComponent.bEnabled = false;
			this.CurActorInfo.Actor = aactor;
			this.CurActorInfo.KuroPostProcessComponent = ukuroPostProcessComponent;
			this.CurActorInfo.TargetBlendWeight = 1f;
			this.CurActorInfo.CurBlendWeight = 0f;
			this.CurActorInfo.IsLoadCompleted = false;
			this.LoadDaAsset();
		}

		// Token: 0x0602959C RID: 169372 RVA: 0x00BA47D8 File Offset: 0x00BA29D8
		private void UpdateAtmosphereActor()
		{
			UKuroPostProcessComponent kuroPostProcessComponent = this.CurActorInfo.KuroPostProcessComponent;
			this.CurActorInfo.TargetBlendWeight = 1f;
			this.CurActorInfo.CurBlendWeight = 0f;
			this.CurActorInfo.IsLoadCompleted = false;
			kuroPostProcessComponent.PPTODDataAsset = null;
			kuroPostProcessComponent.WeatherDataAsset = null;
			kuroPostProcessComponent.BlendWeight = 0f;
			kuroPostProcessComponent.bEnabled = false;
			this.UpdateCurActorTransform();
			this.LoadDaAsset();
		}

		// Token: 0x0602959D RID: 169373 RVA: 0x00BA4848 File Offset: 0x00BA2A48
		private void LoadDaAsset()
		{
			Weather? weatherConfig = this.CurActorInfo.WeatherConfig;
			UKuroPostProcessComponent kuroPostProcessComponent = this.CurActorInfo.KuroPostProcessComponent;
			ResourceSystem.Instance.LoadAsync<UKuroWeatherDataAsset>(weatherConfig.Value.DAPath, delegate([Nullable(2)] UKuroWeatherDataAsset dataAsset, string _)
			{
				if (dataAsset == null || !dataAsset.IsValid())
				{
					return;
				}
				PlotWeatherActorInfo curActorInfo = this.CurActorInfo;
				int? num = (curActorInfo.WeatherConfig != null) ? new int?(curActorInfo.WeatherConfig.GetValueOrDefault().Id) : null;
				int id = weatherConfig.Value.Id;
				if (!(num.GetValueOrDefault() == id & num != null))
				{
					return;
				}
				kuroPostProcessComponent.WeatherDataAsset = dataAsset;
				kuroPostProcessComponent.SetPriority((float)this.CurActorInfo.Priority);
				this.CurActorInfo.IsLoadCompleted = true;
				this.UpdateBlendWeight(this.CurActorInfo, 0f);
			}, 100, "js_undefined");
		}

		// Token: 0x0602959E RID: 169374 RVA: 0x00BA48B8 File Offset: 0x00BA2AB8
		private void UpdateCurPriority(int priority)
		{
			if (this.CurActorInfo == null || this.CurActorInfo.Priority == priority)
			{
				return;
			}
			this.CurActorInfo.Priority = priority;
			if (this.CurActorInfo.IsLoadCompleted)
			{
				UKuroPostProcessComponent kuroPostProcessComponent = this.CurActorInfo.KuroPostProcessComponent;
				if (kuroPostProcessComponent != null && kuroPostProcessComponent.IsValid())
				{
					this.CurActorInfo.KuroPostProcessComponent.SetPriority((float)priority);
				}
			}
		}

		// Token: 0x040168CF RID: 92367
		private const int PLOT_WEATHER_PRIORITY = 100;

		// Token: 0x040168D0 RID: 92368
		private int WeatherId;

		// Token: 0x040168D1 RID: 92369
		private bool IsInherit;

		// Token: 0x040168D2 RID: 92370
		private PlotWeatherActorInfo CurActorInfo;

		// Token: 0x040168D3 RID: 92371
		private PlotWeatherActorInfo LastActorInfo;
	}
}
