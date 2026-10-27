using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070BF RID: 28863
	public class ISheriffChangeCriminalStateT
	{
		// Token: 0x1700D66C RID: 54892
		// (get) Token: 0x060331F8 RID: 209400 RVA: 0x006E4E84 File Offset: 0x006E3084
		// (set) Token: 0x060331F9 RID: 209401 RVA: 0x006E4E8C File Offset: 0x006E308C
		public int CriminalId { get; set; }

		// Token: 0x1700D66D RID: 54893
		// (get) Token: 0x060331FA RID: 209402 RVA: 0x006E4E95 File Offset: 0x006E3095
		// (set) Token: 0x060331FB RID: 209403 RVA: 0x006E4E9D File Offset: 0x006E309D
		public ESheriffCriminalState CriminalState { get; set; }

		// Token: 0x060331FC RID: 209404 RVA: 0x006E4EA6 File Offset: 0x006E30A6
		public ISheriffChangeCriminalStateT()
		{
			this.CriminalId = 0;
			this.CriminalState = ESheriffCriminalState.None;
		}
	}
}
