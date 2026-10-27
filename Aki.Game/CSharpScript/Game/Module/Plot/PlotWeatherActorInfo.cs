using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02005008 RID: 20488
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWeatherActorInfo
	{
		// Token: 0x060346EB RID: 214763 RVA: 0x00C58C14 File Offset: 0x00C56E14
		public void Disable()
		{
			if (this.WeatherConfig == null)
			{
				return;
			}
			this.WeatherConfig = null;
			UKuroPostProcessComponent kuroPostProcessComponent = this.KuroPostProcessComponent;
			if (kuroPostProcessComponent != null && kuroPostProcessComponent.IsValid())
			{
				this.KuroPostProcessComponent.bEnabled = false;
			}
			this.IsLoadCompleted = false;
			this.CurBlendWeight = 0f;
			this.IsLoadCompleted = false;
		}

		// Token: 0x060346EC RID: 214764 RVA: 0x00C58C74 File Offset: 0x00C56E74
		public void Destroy()
		{
			this.WeatherConfig = null;
			AActor actor = this.Actor;
			if (actor != null && actor.IsValid())
			{
				ActorSystem.Instance.Put("PlotWeatherActorInfo.Destroy", this.Actor, null);
				this.Actor = null;
			}
			this.KuroPostProcessComponent = null;
		}

		// Token: 0x0401BEDE RID: 114398
		public Weather? WeatherConfig;

		// Token: 0x0401BEDF RID: 114399
		public AActor Actor;

		// Token: 0x0401BEE0 RID: 114400
		public UKuroPostProcessComponent KuroPostProcessComponent;

		// Token: 0x0401BEE1 RID: 114401
		public float TargetBlendWeight;

		// Token: 0x0401BEE2 RID: 114402
		public float CurBlendWeight;

		// Token: 0x0401BEE3 RID: 114403
		public float ChangeSpeed;

		// Token: 0x0401BEE4 RID: 114404
		public int Priority;

		// Token: 0x0401BEE5 RID: 114405
		public bool IsLoadCompleted;
	}
}
