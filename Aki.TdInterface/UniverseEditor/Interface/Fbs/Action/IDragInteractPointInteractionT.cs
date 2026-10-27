using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200660A RID: 26122
	public class IDragInteractPointInteractionT
	{
		// Token: 0x1700C216 RID: 49686
		// (get) Token: 0x0602D5B5 RID: 185781 RVA: 0x00637448 File Offset: 0x00635648
		// (set) Token: 0x0602D5B6 RID: 185782 RVA: 0x00637450 File Offset: 0x00635650
		public EInteractPointInteractionType Type { get; set; }

		// Token: 0x1700C217 RID: 49687
		// (get) Token: 0x0602D5B7 RID: 185783 RVA: 0x00637459 File Offset: 0x00635659
		// (set) Token: 0x0602D5B8 RID: 185784 RVA: 0x00637461 File Offset: 0x00635661
		public int DragItemTag { get; set; }

		// Token: 0x1700C218 RID: 49688
		// (get) Token: 0x0602D5B9 RID: 185785 RVA: 0x0063746A File Offset: 0x0063566A
		// (set) Token: 0x0602D5BA RID: 185786 RVA: 0x00637472 File Offset: 0x00635672
		public float CheckDistance { get; set; }

		// Token: 0x1700C219 RID: 49689
		// (get) Token: 0x0602D5BB RID: 185787 RVA: 0x0063747B File Offset: 0x0063567B
		// (set) Token: 0x0602D5BC RID: 185788 RVA: 0x00637483 File Offset: 0x00635683
		public byte NullMask { get; set; }

		// Token: 0x0602D5BD RID: 185789 RVA: 0x0063748C File Offset: 0x0063568C
		public IDragInteractPointInteractionT()
		{
			this.Type = EInteractPointInteractionType.Drag;
			this.DragItemTag = 0;
			this.CheckDistance = 0f;
			this.NullMask = 0;
		}
	}
}
