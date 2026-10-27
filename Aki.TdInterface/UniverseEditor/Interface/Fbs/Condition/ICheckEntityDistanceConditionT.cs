using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049FE RID: 18942
	public class ICheckEntityDistanceConditionT
	{
		// Token: 0x17008909 RID: 35081
		// (get) Token: 0x0601D9C6 RID: 121286 RVA: 0x0042ADB5 File Offset: 0x00428FB5
		// (set) Token: 0x0601D9C7 RID: 121287 RVA: 0x0042ADBD File Offset: 0x00428FBD
		public ECondition Type { get; set; }

		// Token: 0x1700890A RID: 35082
		// (get) Token: 0x0601D9C8 RID: 121288 RVA: 0x0042ADC6 File Offset: 0x00428FC6
		// (set) Token: 0x0601D9C9 RID: 121289 RVA: 0x0042ADCE File Offset: 0x00428FCE
		public TTargetEntityUnion TargetA { get; set; }

		// Token: 0x1700890B RID: 35083
		// (get) Token: 0x0601D9CA RID: 121290 RVA: 0x0042ADD7 File Offset: 0x00428FD7
		// (set) Token: 0x0601D9CB RID: 121291 RVA: 0x0042ADDF File Offset: 0x00428FDF
		public TTargetEntityUnion TargetB { get; set; }

		// Token: 0x1700890C RID: 35084
		// (get) Token: 0x0601D9CC RID: 121292 RVA: 0x0042ADE8 File Offset: 0x00428FE8
		// (set) Token: 0x0601D9CD RID: 121293 RVA: 0x0042ADF0 File Offset: 0x00428FF0
		public ECompare Compare { get; set; }

		// Token: 0x1700890D RID: 35085
		// (get) Token: 0x0601D9CE RID: 121294 RVA: 0x0042ADF9 File Offset: 0x00428FF9
		// (set) Token: 0x0601D9CF RID: 121295 RVA: 0x0042AE01 File Offset: 0x00429001
		public int Distance { get; set; }

		// Token: 0x0601D9D0 RID: 121296 RVA: 0x0042AE0A File Offset: 0x0042900A
		public ICheckEntityDistanceConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.TargetA = null;
			this.TargetB = null;
			this.Compare = ECompare.Eq;
			this.Distance = 0;
		}
	}
}
