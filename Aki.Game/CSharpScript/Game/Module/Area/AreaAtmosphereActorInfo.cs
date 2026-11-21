using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Area
{
	// Token: 0x02004E81 RID: 20097
	[NullableContext(2)]
	[Nullable(0)]
	public class AreaAtmosphereActorInfo
	{
		// Token: 0x0603297F RID: 207231 RVA: 0x00E31DEC File Offset: 0x00E2FFEC
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

		// Token: 0x0401AD3D RID: 109885
		public AreaAtmosphereInfo? AreaAtmosphereInfo;

		// Token: 0x0401AD3E RID: 109886
		public AActor Actor;

		// Token: 0x0401AD3F RID: 109887
		public UKuroPostProcessComponent KuroPostProcessComponent;

		// Token: 0x0401AD40 RID: 109888
		public float TargetBlendWeight;

		// Token: 0x0401AD41 RID: 109889
		public float CurBlendWeight;

		// Token: 0x0401AD42 RID: 109890
		public float ChangeSpeed;

		// Token: 0x0401AD43 RID: 109891
		public bool IsLoadCompleted;
	}
}
