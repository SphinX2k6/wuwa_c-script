using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02005E9D RID: 24221
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaAtmosphere
	{
		// Token: 0x0603D9F1 RID: 252401 RVA: 0x00EE087B File Offset: 0x00EDEA7B
		public AreaAtmosphere()
		{
			this.Init();
		}

		// Token: 0x0603D9F2 RID: 252402 RVA: 0x00EE0889 File Offset: 0x00EDEA89
		private void Init()
		{
			this.AddEventListener();
		}

		// Token: 0x0603D9F3 RID: 252403 RVA: 0x00EE0891 File Offset: 0x00EDEA91
		public void Destroy()
		{
			this.RemoveEventListener();
			this.ClearActorInfo();
		}

		// Token: 0x0603D9F4 RID: 252404 RVA: 0x00EE089F File Offset: 0x00EDEA9F
		private void ClearActorInfo()
		{
			if (this.CurActorInfo != null)
			{
				this.CurActorInfo.Clear();
				this.CurActorInfo = null;
			}
			if (this.LastActorInfo != null)
			{
				this.LastActorInfo.Clear();
				this.LastActorInfo = null;
			}
		}

		// Token: 0x0603D9F5 RID: 252405 RVA: 0x00EE08D5 File Offset: 0x00EDEAD5
		public void OnTick(float delta)
		{
			this.UpdateBlendWeight(this.CurActorInfo, delta);
			this.UpdateBlendWeight(this.LastActorInfo, delta);
		}

		// Token: 0x0603D9F6 RID: 252406 RVA: 0x00EE08F4 File Offset: 0x00EDEAF4
		private void UpdateBlendWeight(AreaAtmosphereActorInfo actorInfo, float delta)
		{
			if (actorInfo == null || !actorInfo.IsLoadCompleted)
			{
				return;
			}
			if (actorInfo.CurBlendWeight == actorInfo.TargetBlendWeight)
			{
				return;
			}
			float curBlendWeight = actorInfo.CurBlendWeight;
			if (actorInfo.ChangeSpeed == 0f)
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
			if (curBlendWeight > 0f && actorInfo.CurBlendWeight == 0f)
			{
				actorInfo.KuroPostProcessComponent.bEnabled = false;
			}
		}

		// Token: 0x0603D9F7 RID: 252407 RVA: 0x00EE0A04 File Offset: 0x00EDEC04
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent));
		}

		// Token: 0x0603D9F8 RID: 252408 RVA: 0x00EE0A68 File Offset: 0x00EDEC68
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent));
		}

		// Token: 0x0603D9F9 RID: 252409 RVA: 0x00EE0AC9 File Offset: 0x00EDECC9
		private void OnClearWorld()
		{
			this.ClearActorInfo();
		}

		// Token: 0x0603D9FA RID: 252410 RVA: 0x00EE0AD4 File Offset: 0x00EDECD4
		private void OnWorldDone()
		{
			this.OnChangeArea(null, null);
		}

		// Token: 0x0603D9FB RID: 252411 RVA: 0x00EE0AF9 File Offset: 0x00EDECF9
		private void OnChangeAreaEvent(int? preAreaId, int curAreaId)
		{
			this.OnChangeArea(preAreaId, new int?(curAreaId));
		}

		// Token: 0x0603D9FC RID: 252412 RVA: 0x00EE0B08 File Offset: 0x00EDED08
		private void OnChangeArea(int? preAreaId, int? curAreaId)
		{
			if (this.CurActorInfo != null)
			{
				this.CurActorInfo.TargetBlendWeight = 0f;
			}
			Area? areaInfo = AreaModel.Instance.AreaInfo;
			if (areaInfo == null)
			{
				return;
			}
			int atmosphereId = areaInfo.Value.AtmosphereId;
			if (atmosphereId == 0)
			{
				if (areaInfo.Value.Father == 0)
				{
					return;
				}
				Area? areaInfo2 = AreaConfig.Instance.GetAreaInfo(areaInfo.Value.Father);
				if (areaInfo2 == null || areaInfo2.Value.AtmosphereId == 0)
				{
					return;
				}
				atmosphereId = areaInfo2.Value.AtmosphereId;
			}
			AreaAtmosphereInfo? areaAtmosphereInfo = AreaConfig.Instance.GetAreaAtmosphereInfo(atmosphereId);
			if (areaAtmosphereInfo == null)
			{
				return;
			}
			if (this.CurActorInfo == null)
			{
				this.CurActorInfo = new AreaAtmosphereActorInfo();
				this.UpdateCurAreaAtmosphereInfo(areaAtmosphereInfo.Value);
				this.CreateAtmosphereActor();
				return;
			}
			if (this.CurActorInfo.AreaAtmosphereInfo.Value.Id == areaAtmosphereInfo.Value.Id)
			{
				this.CurActorInfo.TargetBlendWeight = 1f;
				this.UpdateBlendWeight(this.CurActorInfo, 0f);
				this.UpdateCurActorTransform();
				return;
			}
			if (this.LastActorInfo == null)
			{
				this.LastActorInfo = this.CurActorInfo;
				this.CurActorInfo = new AreaAtmosphereActorInfo();
				this.UpdateCurAreaAtmosphereInfo(areaAtmosphereInfo.Value);
				this.CreateAtmosphereActor();
				return;
			}
			AreaAtmosphereActorInfo lastActorInfo = this.LastActorInfo;
			this.LastActorInfo = this.CurActorInfo;
			this.CurActorInfo = lastActorInfo;
			if (this.CurActorInfo.AreaAtmosphereInfo.Value.Id == areaAtmosphereInfo.Value.Id)
			{
				this.CurActorInfo.TargetBlendWeight = 1f;
				this.UpdateBlendWeight(this.CurActorInfo, 0f);
				this.UpdateCurActorTransform();
				return;
			}
			this.UpdateCurAreaAtmosphereInfo(areaAtmosphereInfo.Value);
			this.UpdateAtmosphereActor();
		}

		// Token: 0x0603D9FD RID: 252413 RVA: 0x00EE0CF8 File Offset: 0x00EDEEF8
		private void UpdateCurAreaAtmosphereInfo(AreaAtmosphereInfo areaAtmosphereInfo)
		{
			this.CurActorInfo.AreaAtmosphereInfo = new AreaAtmosphereInfo?(areaAtmosphereInfo);
			if (areaAtmosphereInfo.FadeTime > 0)
			{
				this.CurActorInfo.ChangeSpeed = 1f / (float)(areaAtmosphereInfo.FadeTime * TimeUtil.Instance.InverseMillisecond);
				return;
			}
			this.CurActorInfo.ChangeSpeed = 0f;
		}

		// Token: 0x0603D9FE RID: 252414 RVA: 0x00EE0D58 File Offset: 0x00EDEF58
		private void UpdateCurActorTransform()
		{
			if (this.CurActorInfo != null)
			{
				AActor actor = this.CurActorInfo.Actor;
				if (actor != null && actor.IsValid())
				{
					if (Global.BaseCharacter != null)
					{
						FHitResult fhitResult = new FHitResult();
						this.CurActorInfo.Actor.D_K2_SetActorLocation(Global.BaseCharacter.D_K2_GetActorLocation(), false, ref fhitResult, true);
					}
					return;
				}
			}
		}

		// Token: 0x0603D9FF RID: 252415 RVA: 0x00EE0DB8 File Offset: 0x00EDEFB8
		private void CreateAtmosphereActor()
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
			UKuroPostProcessComponent ukuroPostProcessComponent = aactor.AddComponentByClass(UKuroPostProcessComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName)) as UKuroPostProcessComponent;
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

		// Token: 0x0603DA00 RID: 252416 RVA: 0x00EE0E9C File Offset: 0x00EDF09C
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

		// Token: 0x0603DA01 RID: 252417 RVA: 0x00EE0F0C File Offset: 0x00EDF10C
		private void LoadDaAsset()
		{
			AreaAtmosphereInfo? areaAtmosphereInfo = this.CurActorInfo.AreaAtmosphereInfo;
			UKuroPostProcessComponent kuroPostProcessComponent = this.CurActorInfo.KuroPostProcessComponent;
			if (areaAtmosphereInfo.Value.IsTOD)
			{
				ResourceSystem.Instance.LoadAsync<UKuroTODData>(areaAtmosphereInfo.Value.DAPath, delegate([Nullable(2)] UKuroTODData dataAsset, string _)
				{
					if (dataAsset == null || !dataAsset.IsValid())
					{
						return;
					}
					if (this.CurActorInfo.AreaAtmosphereInfo.Value.Id != areaAtmosphereInfo.Value.Id)
					{
						return;
					}
					this.CurActorInfo.IsLoadCompleted = true;
					kuroPostProcessComponent.PPTODDataAsset = dataAsset;
					kuroPostProcessComponent.SetPriority((float)areaAtmosphereInfo.Value.Priority);
					this.UpdateBlendWeight(this.CurActorInfo, 0f);
				}, 100, "js_undefined");
				return;
			}
			ResourceSystem.Instance.LoadAsync<UKuroWeatherDataAsset>(areaAtmosphereInfo.Value.DAPath, delegate([Nullable(2)] UKuroWeatherDataAsset dataAsset, string _)
			{
				if (dataAsset == null || !dataAsset.IsValid())
				{
					return;
				}
				if (this.CurActorInfo.AreaAtmosphereInfo.Value.Id != areaAtmosphereInfo.Value.Id)
				{
					return;
				}
				this.CurActorInfo.IsLoadCompleted = true;
				kuroPostProcessComponent.WeatherDataAsset = dataAsset;
				kuroPostProcessComponent.SetPriority((float)areaAtmosphereInfo.Value.Priority);
				this.UpdateBlendWeight(this.CurActorInfo, 0f);
			}, 100, "js_undefined");
		}

		// Token: 0x0402027D RID: 131709
		private AreaAtmosphereActorInfo CurActorInfo;

		// Token: 0x0402027E RID: 131710
		private AreaAtmosphereActorInfo LastActorInfo;
	}
}
