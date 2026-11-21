using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EE2 RID: 20194
	public class ICheckExploreSkillStateT
	{
		// Token: 0x17009031 RID: 36913
		// (get) Token: 0x0601F598 RID: 128408 RVA: 0x0045E3E3 File Offset: 0x0045C5E3
		// (set) Token: 0x0601F599 RID: 128409 RVA: 0x0045E3EB File Offset: 0x0045C5EB
		public ECondition Type { get; set; }

		// Token: 0x17009032 RID: 36914
		// (get) Token: 0x0601F59A RID: 128410 RVA: 0x0045E3F4 File Offset: 0x0045C5F4
		// (set) Token: 0x0601F59B RID: 128411 RVA: 0x0045E3FC File Offset: 0x0045C5FC
		public ICheckPlayerAirBubbleEnabledT Condition { get; set; }

		// Token: 0x0601F59C RID: 128412 RVA: 0x0045E405 File Offset: 0x0045C605
		public ICheckExploreSkillStateT()
		{
			this.Type = ECondition.CompareVar;
			this.Condition = null;
		}
	}
}
