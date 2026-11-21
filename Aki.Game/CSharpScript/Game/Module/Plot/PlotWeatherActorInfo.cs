using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FD2 RID: 16338
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWeatherActorInfo
	{
		// Token: 0x0602958E RID: 169358 RVA: 0x00BA4114 File Offset: 0x00BA2314
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

		// Token: 0x0602958F RID: 169359 RVA: 0x00BA4174 File Offset: 0x00BA2374
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

		// Token: 0x040168C7 RID: 92359
		public Weather? WeatherConfig;

		// Token: 0x040168C8 RID: 92360
		public AActor Actor;

		// Token: 0x040168C9 RID: 92361
		public UKuroPostProcessComponent KuroPostProcessComponent;

		// Token: 0x040168CA RID: 92362
		public float TargetBlendWeight;

		// Token: 0x040168CB RID: 92363
		public float CurBlendWeight;

		// Token: 0x040168CC RID: 92364
		public float ChangeSpeed;

		// Token: 0x040168CD RID: 92365
		public int Priority;

		// Token: 0x040168CE RID: 92366
		public bool IsLoadCompleted;
	}
}
