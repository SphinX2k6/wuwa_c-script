using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004260 RID: 16992
	public class IUseWeatherSwitchConditionT
	{
		// Token: 0x170078A9 RID: 30889
		// (get) Token: 0x06019263 RID: 103011 RVA: 0x0039D845 File Offset: 0x0039BA45
		// (set) Token: 0x06019264 RID: 103012 RVA: 0x0039D84D File Offset: 0x0039BA4D
		public EChildQuest Type { get; set; }

		// Token: 0x170078AA RID: 30890
		// (get) Token: 0x06019265 RID: 103013 RVA: 0x0039D856 File Offset: 0x0039BA56
		// (set) Token: 0x06019266 RID: 103014 RVA: 0x0039D85E File Offset: 0x0039BA5E
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170078AB RID: 30891
		// (get) Token: 0x06019267 RID: 103015 RVA: 0x0039D867 File Offset: 0x0039BA67
		// (set) Token: 0x06019268 RID: 103016 RVA: 0x0039D86F File Offset: 0x0039BA6F
		public TUseWeatherSwitchConditionUnion CheckType { get; set; }

		// Token: 0x06019269 RID: 103017 RVA: 0x0039D878 File Offset: 0x0039BA78
		public IUseWeatherSwitchConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.CheckType = null;
		}
	}
}
