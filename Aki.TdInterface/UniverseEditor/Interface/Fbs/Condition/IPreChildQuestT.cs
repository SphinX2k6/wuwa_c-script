using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C8F RID: 19599
	public class IPreChildQuestT
	{
		// Token: 0x17008E4F RID: 36431
		// (get) Token: 0x0601F161 RID: 127329 RVA: 0x004580DD File Offset: 0x004562DD
		// (set) Token: 0x0601F162 RID: 127330 RVA: 0x004580E5 File Offset: 0x004562E5
		public EVisibleCondition Type { get; set; }

		// Token: 0x17008E50 RID: 36432
		// (get) Token: 0x0601F163 RID: 127331 RVA: 0x004580EE File Offset: 0x004562EE
		// (set) Token: 0x0601F164 RID: 127332 RVA: 0x004580F6 File Offset: 0x004562F6
		public ECompare Compare { get; set; }

		// Token: 0x17008E51 RID: 36433
		// (get) Token: 0x0601F165 RID: 127333 RVA: 0x004580FF File Offset: 0x004562FF
		// (set) Token: 0x0601F166 RID: 127334 RVA: 0x00458107 File Offset: 0x00456307
		public IChildQuestConditionT PreChildQuest { get; set; }

		// Token: 0x0601F167 RID: 127335 RVA: 0x00458110 File Offset: 0x00456310
		public IPreChildQuestT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.PreChildQuest = null;
		}
	}
}
