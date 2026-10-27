using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A2E RID: 18990
	public class ICheckFollowShooterActiveT
	{
		// Token: 0x17008978 RID: 35192
		// (get) Token: 0x0601DB85 RID: 121733 RVA: 0x0042E0BE File Offset: 0x0042C2BE
		// (set) Token: 0x0601DB86 RID: 121734 RVA: 0x0042E0C6 File Offset: 0x0042C2C6
		public ECondition Type { get; set; }

		// Token: 0x17008979 RID: 35193
		// (get) Token: 0x0601DB87 RID: 121735 RVA: 0x0042E0CF File Offset: 0x0042C2CF
		// (set) Token: 0x0601DB88 RID: 121736 RVA: 0x0042E0D7 File Offset: 0x0042C2D7
		public bool Active { get; set; }

		// Token: 0x1700897A RID: 35194
		// (get) Token: 0x0601DB89 RID: 121737 RVA: 0x0042E0E0 File Offset: 0x0042C2E0
		// (set) Token: 0x0601DB8A RID: 121738 RVA: 0x0042E0E8 File Offset: 0x0042C2E8
		public int Id { get; set; }

		// Token: 0x0601DB8B RID: 121739 RVA: 0x0042E0F1 File Offset: 0x0042C2F1
		public ICheckFollowShooterActiveT()
		{
			this.Type = ECondition.CompareVar;
			this.Active = false;
			this.Id = 0;
		}
	}
}
