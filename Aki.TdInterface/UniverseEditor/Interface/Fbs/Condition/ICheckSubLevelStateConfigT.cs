using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200501A RID: 20506
	public class ICheckSubLevelStateConfigT
	{
		// Token: 0x170092BA RID: 37562
		// (get) Token: 0x06020043 RID: 131139 RVA: 0x004714E7 File Offset: 0x0046F6E7
		// (set) Token: 0x06020044 RID: 131140 RVA: 0x004714EF File Offset: 0x0046F6EF
		public string SubLevelName { get; set; }

		// Token: 0x170092BB RID: 37563
		// (get) Token: 0x06020045 RID: 131141 RVA: 0x004714F8 File Offset: 0x0046F6F8
		// (set) Token: 0x06020046 RID: 131142 RVA: 0x00471500 File Offset: 0x0046F700
		public ESubLevelState SubLevelState { get; set; }

		// Token: 0x06020047 RID: 131143 RVA: 0x00471509 File Offset: 0x0046F709
		public ICheckSubLevelStateConfigT()
		{
			this.SubLevelName = null;
			this.SubLevelState = ESubLevelState.Enable;
		}
	}
}
