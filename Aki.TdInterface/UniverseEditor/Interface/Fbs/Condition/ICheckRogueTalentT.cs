using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005005 RID: 20485
	public class ICheckRogueTalentT
	{
		// Token: 0x1700928B RID: 37515
		// (get) Token: 0x0601FF81 RID: 130945 RVA: 0x0046FEA4 File Offset: 0x0046E0A4
		// (set) Token: 0x0601FF82 RID: 130946 RVA: 0x0046FEAC File Offset: 0x0046E0AC
		public ERogueStateType Type { get; set; }

		// Token: 0x1700928C RID: 37516
		// (get) Token: 0x0601FF83 RID: 130947 RVA: 0x0046FEB5 File Offset: 0x0046E0B5
		// (set) Token: 0x0601FF84 RID: 130948 RVA: 0x0046FEBD File Offset: 0x0046E0BD
		public int Id { get; set; }

		// Token: 0x0601FF85 RID: 130949 RVA: 0x0046FEC6 File Offset: 0x0046E0C6
		public ICheckRogueTalentT()
		{
			this.Type = ERogueStateType.Talent;
			this.Id = 0;
		}
	}
}
