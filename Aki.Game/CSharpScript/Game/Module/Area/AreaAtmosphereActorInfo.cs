using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02005E9C RID: 24220
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaAtmosphereActorInfo
	{
		// Token: 0x0603D9EF RID: 252399 RVA: 0x00EE0838 File Offset: 0x00EDEA38
		public void Clear()
		{
			this.AreaAtmosphereInfo = null;
			if (this.Actor != null)
			{
				ActorSystem.Instance.Put("AreaAtmosphereActorInfo.Clear", this.Actor, null);
			}
			this.Actor = null;
			this.KuroPostProcessComponent = null;
		}

		// Token: 0x04020276 RID: 131702
		public AreaAtmosphereInfo? AreaAtmosphereInfo;

		// Token: 0x04020277 RID: 131703
		public AActor Actor;

		// Token: 0x04020278 RID: 131704
		public UKuroPostProcessComponent KuroPostProcessComponent;

		// Token: 0x04020279 RID: 131705
		public float TargetBlendWeight;

		// Token: 0x0402027A RID: 131706
		public float CurBlendWeight;

		// Token: 0x0402027B RID: 131707
		public float ChangeSpeed;

		// Token: 0x0402027C RID: 131708
		public bool IsLoadCompleted;
	}
}
