using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200632A RID: 25386
	public class IChangeTeamPositionT
	{
		// Token: 0x1700BD7E RID: 48510
		// (get) Token: 0x0602BE9D RID: 179869 RVA: 0x00609682 File Offset: 0x00607882
		// (set) Token: 0x0602BE9E RID: 179870 RVA: 0x0060968A File Offset: 0x0060788A
		public int PositionId { get; set; }

		// Token: 0x1700BD7F RID: 48511
		// (get) Token: 0x0602BE9F RID: 179871 RVA: 0x00609693 File Offset: 0x00607893
		// (set) Token: 0x0602BEA0 RID: 179872 RVA: 0x0060969B File Offset: 0x0060789B
		public bool RestoreToPrevious { get; set; }

		// Token: 0x1700BD80 RID: 48512
		// (get) Token: 0x0602BEA1 RID: 179873 RVA: 0x006096A4 File Offset: 0x006078A4
		// (set) Token: 0x0602BEA2 RID: 179874 RVA: 0x006096AC File Offset: 0x006078AC
		public byte NullMask { get; set; }

		// Token: 0x0602BEA3 RID: 179875 RVA: 0x006096B5 File Offset: 0x006078B5
		public IChangeTeamPositionT()
		{
			this.PositionId = 0;
			this.RestoreToPrevious = false;
			this.NullMask = 0;
		}
	}
}
