using System;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200557B RID: 21883
	public class MapLifeEventTriggerLevelPlayParam : IMapSceneGameplayUnlockData
	{
		// Token: 0x17008633 RID: 34355
		// (get) Token: 0x06037C70 RID: 228464 RVA: 0x00D3926B File Offset: 0x00D3746B
		// (set) Token: 0x06037C71 RID: 228465 RVA: 0x00D39273 File Offset: 0x00D37473
		int IMapSceneGameplayUnlockData.RelativeType
		{
			get
			{
				return (int)this.RelativeType;
			}
			set
			{
				this.RelativeType = (EMarkRelativeType)value;
			}
		}

		// Token: 0x17008634 RID: 34356
		// (get) Token: 0x06037C72 RID: 228466 RVA: 0x00D3927C File Offset: 0x00D3747C
		// (set) Token: 0x06037C73 RID: 228467 RVA: 0x00D39284 File Offset: 0x00D37484
		int IMapSceneGameplayUnlockData.RelativeSubType
		{
			get
			{
				return this.RelativeSubType;
			}
			set
			{
				this.RelativeSubType = value;
			}
		}

		// Token: 0x0401D51E RID: 120094
		public EMarkRelativeType RelativeType;

		// Token: 0x0401D51F RID: 120095
		public int RelativeSubType;
	}
}
