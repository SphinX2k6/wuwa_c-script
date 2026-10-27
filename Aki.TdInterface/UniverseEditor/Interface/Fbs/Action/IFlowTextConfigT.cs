using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006832 RID: 26674
	public class IFlowTextConfigT
	{
		// Token: 0x1700C623 RID: 50723
		// (get) Token: 0x0602E811 RID: 190481 RVA: 0x006589A0 File Offset: 0x00656BA0
		// (set) Token: 0x0602E812 RID: 190482 RVA: 0x006589A8 File Offset: 0x00656BA8
		public string Text { get; set; }

		// Token: 0x1700C624 RID: 50724
		// (get) Token: 0x0602E813 RID: 190483 RVA: 0x006589B1 File Offset: 0x00656BB1
		// (set) Token: 0x0602E814 RID: 190484 RVA: 0x006589B9 File Offset: 0x00656BB9
		public string PlotLineKey { get; set; }

		// Token: 0x1700C625 RID: 50725
		// (get) Token: 0x0602E815 RID: 190485 RVA: 0x006589C2 File Offset: 0x00656BC2
		// (set) Token: 0x0602E816 RID: 190486 RVA: 0x006589CA File Offset: 0x00656BCA
		public string StringKey { get; set; }

		// Token: 0x1700C626 RID: 50726
		// (get) Token: 0x0602E817 RID: 190487 RVA: 0x006589D3 File Offset: 0x00656BD3
		// (set) Token: 0x0602E818 RID: 190488 RVA: 0x006589DB File Offset: 0x00656BDB
		public int FlowListId { get; set; }

		// Token: 0x1700C627 RID: 50727
		// (get) Token: 0x0602E819 RID: 190489 RVA: 0x006589E4 File Offset: 0x00656BE4
		// (set) Token: 0x0602E81A RID: 190490 RVA: 0x006589EC File Offset: 0x00656BEC
		public bool IsNoPlotText { get; set; }

		// Token: 0x1700C628 RID: 50728
		// (get) Token: 0x0602E81B RID: 190491 RVA: 0x006589F5 File Offset: 0x00656BF5
		// (set) Token: 0x0602E81C RID: 190492 RVA: 0x006589FD File Offset: 0x00656BFD
		public byte NullMask { get; set; }

		// Token: 0x0602E81D RID: 190493 RVA: 0x00658A06 File Offset: 0x00656C06
		public IFlowTextConfigT()
		{
			this.Text = null;
			this.PlotLineKey = null;
			this.StringKey = null;
			this.FlowListId = 0;
			this.IsNoPlotText = false;
			this.NullMask = 0;
		}
	}
}
