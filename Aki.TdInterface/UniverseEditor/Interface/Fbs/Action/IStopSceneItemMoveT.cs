using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079C6 RID: 31174
	public class IStopSceneItemMoveT
	{
		// Token: 0x1700E495 RID: 58517
		// (get) Token: 0x06036EDA RID: 224986 RVA: 0x0075852D File Offset: 0x0075672D
		// (set) Token: 0x06036EDB RID: 224987 RVA: 0x00758535 File Offset: 0x00756735
		public List<int> EntityIds { get; set; }

		// Token: 0x1700E496 RID: 58518
		// (get) Token: 0x06036EDC RID: 224988 RVA: 0x0075853E File Offset: 0x0075673E
		// (set) Token: 0x06036EDD RID: 224989 RVA: 0x00758546 File Offset: 0x00756746
		public EStopSceneItemMoveType StopType { get; set; }

		// Token: 0x1700E497 RID: 58519
		// (get) Token: 0x06036EDE RID: 224990 RVA: 0x0075854F File Offset: 0x0075674F
		// (set) Token: 0x06036EDF RID: 224991 RVA: 0x00758557 File Offset: 0x00756757
		public byte NullMask { get; set; }

		// Token: 0x06036EE0 RID: 224992 RVA: 0x00758560 File Offset: 0x00756760
		public IStopSceneItemMoveT()
		{
			this.EntityIds = null;
			this.StopType = EStopSceneItemMoveType.StopAtCurrentPos;
			this.NullMask = 0;
		}
	}
}
