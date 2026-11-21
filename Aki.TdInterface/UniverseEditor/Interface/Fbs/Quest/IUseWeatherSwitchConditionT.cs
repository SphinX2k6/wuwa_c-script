using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046BC RID: 18108
	public class IUseWeatherSwitchConditionT
	{
		// Token: 0x17007EDA RID: 32474
		// (get) Token: 0x0601A9CF RID: 109007 RVA: 0x003C8F1D File Offset: 0x003C711D
		// (set) Token: 0x0601A9D0 RID: 109008 RVA: 0x003C8F25 File Offset: 0x003C7125
		public EChildQuest Type { get; set; }

		// Token: 0x17007EDB RID: 32475
		// (get) Token: 0x0601A9D1 RID: 109009 RVA: 0x003C8F2E File Offset: 0x003C712E
		// (set) Token: 0x0601A9D2 RID: 109010 RVA: 0x003C8F36 File Offset: 0x003C7136
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007EDC RID: 32476
		// (get) Token: 0x0601A9D3 RID: 109011 RVA: 0x003C8F3F File Offset: 0x003C713F
		// (set) Token: 0x0601A9D4 RID: 109012 RVA: 0x003C8F47 File Offset: 0x003C7147
		public TUseWeatherSwitchConditionUnion CheckType { get; set; }

		// Token: 0x0601A9D5 RID: 109013 RVA: 0x003C8F50 File Offset: 0x003C7150
		public IUseWeatherSwitchConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.CheckType = null;
		}
	}
}
