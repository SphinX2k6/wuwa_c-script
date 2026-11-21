using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004548 RID: 17736
	public class IScheduleTimeConditionT
	{
		// Token: 0x17007B5F RID: 31583
		// (get) Token: 0x06019B0A RID: 105226 RVA: 0x003A872C File Offset: 0x003A692C
		// (set) Token: 0x06019B0B RID: 105227 RVA: 0x003A8734 File Offset: 0x003A6934
		public EChildQuest Type { get; set; }

		// Token: 0x17007B60 RID: 31584
		// (get) Token: 0x06019B0C RID: 105228 RVA: 0x003A873D File Offset: 0x003A693D
		// (set) Token: 0x06019B0D RID: 105229 RVA: 0x003A8745 File Offset: 0x003A6945
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007B61 RID: 31585
		// (get) Token: 0x06019B0E RID: 105230 RVA: 0x003A874E File Offset: 0x003A694E
		// (set) Token: 0x06019B0F RID: 105231 RVA: 0x003A8756 File Offset: 0x003A6956
		public IBaseTimeT StartTime { get; set; }

		// Token: 0x17007B62 RID: 31586
		// (get) Token: 0x06019B10 RID: 105232 RVA: 0x003A875F File Offset: 0x003A695F
		// (set) Token: 0x06019B11 RID: 105233 RVA: 0x003A8767 File Offset: 0x003A6967
		public IBaseTimeT EndTime { get; set; }

		// Token: 0x17007B63 RID: 31587
		// (get) Token: 0x06019B12 RID: 105234 RVA: 0x003A8770 File Offset: 0x003A6970
		// (set) Token: 0x06019B13 RID: 105235 RVA: 0x003A8778 File Offset: 0x003A6978
		public int Day { get; set; }

		// Token: 0x17007B64 RID: 31588
		// (get) Token: 0x06019B14 RID: 105236 RVA: 0x003A8781 File Offset: 0x003A6981
		// (set) Token: 0x06019B15 RID: 105237 RVA: 0x003A8789 File Offset: 0x003A6989
		public byte NullMask { get; set; }

		// Token: 0x06019B16 RID: 105238 RVA: 0x003A8792 File Offset: 0x003A6992
		public IScheduleTimeConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.StartTime = null;
			this.EndTime = null;
			this.Day = 0;
			this.NullMask = 0;
		}
	}
}
