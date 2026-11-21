using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C2D RID: 27693
	public class IDisableAlertAreaConditionT
	{
		// Token: 0x1700CAEE RID: 51950
		// (get) Token: 0x0602FA7E RID: 195198 RVA: 0x0067DF76 File Offset: 0x0067C176
		// (set) Token: 0x0602FA7F RID: 195199 RVA: 0x0067DF7E File Offset: 0x0067C17E
		public EDisableAlertAreaCondition Type { get; set; }

		// Token: 0x0602FA80 RID: 195200 RVA: 0x0067DF87 File Offset: 0x0067C187
		public IDisableAlertAreaConditionT()
		{
			this.Type = EDisableAlertAreaCondition.DungeonCondition;
		}
	}
}
