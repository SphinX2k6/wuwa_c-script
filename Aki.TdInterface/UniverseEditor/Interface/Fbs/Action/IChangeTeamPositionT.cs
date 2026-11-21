using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699B RID: 27035
	public class IChangeTeamPositionT
	{
		// Token: 0x1700C707 RID: 50951
		// (get) Token: 0x0602E609 RID: 189961 RVA: 0x006547D7 File Offset: 0x006529D7
		// (set) Token: 0x0602E60A RID: 189962 RVA: 0x006547DF File Offset: 0x006529DF
		public int PositionId { get; set; }

		// Token: 0x1700C708 RID: 50952
		// (get) Token: 0x0602E60B RID: 189963 RVA: 0x006547E8 File Offset: 0x006529E8
		// (set) Token: 0x0602E60C RID: 189964 RVA: 0x006547F0 File Offset: 0x006529F0
		public TTeamTypeUnion TeamType { get; set; }

		// Token: 0x0602E60D RID: 189965 RVA: 0x006547F9 File Offset: 0x006529F9
		public IChangeTeamPositionT()
		{
			this.PositionId = 0;
			this.TeamType = null;
		}
	}
}
