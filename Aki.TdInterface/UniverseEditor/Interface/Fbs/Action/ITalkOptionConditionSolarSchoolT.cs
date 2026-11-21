using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AFE RID: 31486
	public class ITalkOptionConditionSolarSchoolT
	{
		// Token: 0x1700EBF0 RID: 60400
		// (get) Token: 0x06038B3B RID: 232251 RVA: 0x007ABCE0 File Offset: 0x007A9EE0
		// (set) Token: 0x06038B3C RID: 232252 RVA: 0x007ABCE8 File Offset: 0x007A9EE8
		public ETalkOptionConditionSystem Type { get; set; }

		// Token: 0x1700EBF1 RID: 60401
		// (get) Token: 0x06038B3D RID: 232253 RVA: 0x007ABCF1 File Offset: 0x007A9EF1
		// (set) Token: 0x06038B3E RID: 232254 RVA: 0x007ABCF9 File Offset: 0x007A9EF9
		public int ConditionGroupId { get; set; }

		// Token: 0x06038B3F RID: 232255 RVA: 0x007ABD02 File Offset: 0x007A9F02
		public ITalkOptionConditionSolarSchoolT()
		{
			this.Type = ETalkOptionConditionSystem.SolarSchool;
			this.ConditionGroupId = 0;
		}
	}
}
