using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FAE RID: 20398
	public class ICheckPlayerCanJoinActivityConditionT
	{
		// Token: 0x170091E6 RID: 37350
		// (get) Token: 0x0601FCAD RID: 130221 RVA: 0x0046AC8B File Offset: 0x00468E8B
		// (set) Token: 0x0601FCAE RID: 130222 RVA: 0x0046AC93 File Offset: 0x00468E93
		public ECondition Type { get; set; }

		// Token: 0x170091E7 RID: 37351
		// (get) Token: 0x0601FCAF RID: 130223 RVA: 0x0046AC9C File Offset: 0x00468E9C
		// (set) Token: 0x0601FCB0 RID: 130224 RVA: 0x0046ACA4 File Offset: 0x00468EA4
		public ICheckPlayerCanJoinRogueT Config { get; set; }

		// Token: 0x0601FCB1 RID: 130225 RVA: 0x0046ACAD File Offset: 0x00468EAD
		public ICheckPlayerCanJoinActivityConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Config = null;
		}
	}
}
