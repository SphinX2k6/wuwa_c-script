using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054CB RID: 21707
	public class ILevelAiCycleLooplyT
	{
		// Token: 0x17009FF8 RID: 40952
		// (get) Token: 0x06023C6C RID: 146540 RVA: 0x004F2304 File Offset: 0x004F0504
		// (set) Token: 0x06023C6D RID: 146541 RVA: 0x004F230C File Offset: 0x004F050C
		public ELevelAiCycleMode Type { get; set; }

		// Token: 0x17009FF9 RID: 40953
		// (get) Token: 0x06023C6E RID: 146542 RVA: 0x004F2315 File Offset: 0x004F0515
		// (set) Token: 0x06023C6F RID: 146543 RVA: 0x004F231D File Offset: 0x004F051D
		public bool IsCircle { get; set; }

		// Token: 0x06023C70 RID: 146544 RVA: 0x004F2326 File Offset: 0x004F0526
		public ILevelAiCycleLooplyT()
		{
			this.Type = ELevelAiCycleMode.Loop;
			this.IsCircle = false;
		}
	}
}
