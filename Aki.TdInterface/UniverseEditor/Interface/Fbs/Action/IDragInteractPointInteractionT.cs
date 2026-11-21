using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7B RID: 27771
	public class IDragInteractPointInteractionT
	{
		// Token: 0x1700CBB4 RID: 52148
		// (get) Token: 0x0602FD86 RID: 195974 RVA: 0x00683FB0 File Offset: 0x006821B0
		// (set) Token: 0x0602FD87 RID: 195975 RVA: 0x00683FB8 File Offset: 0x006821B8
		public EInteractPointInteractionType Type { get; set; }

		// Token: 0x1700CBB5 RID: 52149
		// (get) Token: 0x0602FD88 RID: 195976 RVA: 0x00683FC1 File Offset: 0x006821C1
		// (set) Token: 0x0602FD89 RID: 195977 RVA: 0x00683FC9 File Offset: 0x006821C9
		public int DragItemTag { get; set; }

		// Token: 0x1700CBB6 RID: 52150
		// (get) Token: 0x0602FD8A RID: 195978 RVA: 0x00683FD2 File Offset: 0x006821D2
		// (set) Token: 0x0602FD8B RID: 195979 RVA: 0x00683FDA File Offset: 0x006821DA
		public float CheckDistance { get; set; }

		// Token: 0x1700CBB7 RID: 52151
		// (get) Token: 0x0602FD8C RID: 195980 RVA: 0x00683FE3 File Offset: 0x006821E3
		// (set) Token: 0x0602FD8D RID: 195981 RVA: 0x00683FEB File Offset: 0x006821EB
		public byte NullMask { get; set; }

		// Token: 0x0602FD8E RID: 195982 RVA: 0x00683FF4 File Offset: 0x006821F4
		public IDragInteractPointInteractionT()
		{
			this.Type = EInteractPointInteractionType.Drag;
			this.DragItemTag = 0;
			this.CheckDistance = 0f;
			this.NullMask = 0;
		}
	}
}
