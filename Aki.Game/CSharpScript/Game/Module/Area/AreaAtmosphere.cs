using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02004E82 RID: 20098
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaAtmosphere
	{
		// Token: 0x06032981 RID: 207233 RVA: 0x00E31E2F File Offset: 0x00E3002F
		public AreaAtmosphere()
		{
			this.Init();
		}

		// Token: 0x06032982 RID: 207234 RVA: 0x00E31E3D File Offset: 0x00E3003D
		private void Init()
		{
			this.AddEventListener();
		}

		// Token: 0x06032983 RID: 207235 RVA: 0x00E31E45 File Offset: 0x00E30045
		public void Destroy()
		{
			this.RemoveEventListener();
			this.ClearActorInfo();
		}

		// Token: 0x06032984 RID: 207236 RVA: 0x00E31E53 File Offset: 0x00E30053
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

		// Token: 0x06032985 RID: 207237 RVA: 0x00E31E89 File Offset: 0x00E30089
		public void OnTick(float delta)
		{
			this.UpdateBlendWeight(this.CurActorInfo, delta);
			this.UpdateBlendWeight(this.LastActorInfo, delta);
		}

		// Token: 0x06032986 RID: 207238 RVA: 0x00E31EA8 File Offset: 0x00E300A8
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

		// Token: 0x06032987 RID: 207239 RVA: 0x00E31FB8 File Offset: 0x00E301B8
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add<int?, int>(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent));
		}

		// Token: 0x06032988 RID: 207240 RVA: 0x00E3201C File Offset: 0x00E3021C
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.ClearWorld, new Action(this.OnClearWorld));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.ChangeArea, new Action<int?, int>(this.OnChangeAreaEvent));
		}

		// Token: 0x06032989 RID: 207241 RVA: 0x00E3207D File Offset: 0x00E3027D
		private void OnClearWorld()
		{
			this.ClearActorInfo();
		}

		// Token: 0x0603298A RID: 207242 RVA: 0x00E32088 File Offset: 0x00E30288
		private void OnWorldDone()
		{
			this.OnChangeArea(null, null);
		}

		// Token: 0x0603298B RID: 207243 RVA: 0x00E320AD File Offset: 0x00E302AD
		private void OnChangeAreaEvent(int? preAreaId, int curAreaId)
		{
			this.OnChangeArea(preAreaId, new int?(curAreaId));
		}

		// Token: 0x0603298C RID: 207244 RVA: 0x00E320BC File Offset: 0x00E302BC
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

		// Token: 0x0603298D RID: 207245 RVA: 0x00E322AC File Offset: 0x00E304AC
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

		// Token: 0x0603298E RID: 207246 RVA: 0x00E3230C File Offset: 0x00E3050C
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

		// Token: 0x0603298F RID: 207247 RVA: 0x00E3236C File Offset: 0x00E3056C
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

		// Token: 0x06032990 RID: 207248 RVA: 0x00E32450 File Offset: 0x00E30650
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

		// Token: 0x06032991 RID: 207249 RVA: 0x00E324C0 File Offset: 0x00E306C0
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

		// Token: 0x0401AD44 RID: 109892
		private AreaAtmosphereActorInfo CurActorInfo;

		// Token: 0x0401AD45 RID: 109893
		private AreaAtmosphereActorInfo LastActorInfo;
	}
}
