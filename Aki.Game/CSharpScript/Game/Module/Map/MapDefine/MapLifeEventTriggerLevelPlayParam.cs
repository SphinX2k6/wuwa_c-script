using System;
using CSharpScript.Game.Module.Map.View.BaseMap.Assistant.MapLifeEvent;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200454E RID: 17742
	public class MapLifeEventTriggerLevelPlayParam : IMapSceneGameplayUnlockData
	{
		// Token: 0x170059DC RID: 23004
		// (get) Token: 0x0602CB4A RID: 183114 RVA: 0x00C86D3F File Offset: 0x00C84F3F
		// (set) Token: 0x0602CB4B RID: 183115 RVA: 0x00C86D47 File Offset: 0x00C84F47
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

		// Token: 0x170059DD RID: 23005
		// (get) Token: 0x0602CB4C RID: 183116 RVA: 0x00C86D50 File Offset: 0x00C84F50
		// (set) Token: 0x0602CB4D RID: 183117 RVA: 0x00C86D58 File Offset: 0x00C84F58
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

		// Token: 0x04017FA7 RID: 98215
		public EMarkRelativeType RelativeType;

		// Token: 0x04017FA8 RID: 98216
		public int RelativeSubType;
	}
}
