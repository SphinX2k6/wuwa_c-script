using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200530D RID: 21261
	public class IGraph3dEdgeNormalT
	{
		// Token: 0x17009C20 RID: 39968
		// (get) Token: 0x06022BBE RID: 142270 RVA: 0x004D0172 File Offset: 0x004CE372
		// (set) Token: 0x06022BBF RID: 142271 RVA: 0x004D017A File Offset: 0x004CE37A
		public int Id { get; set; }

		// Token: 0x17009C21 RID: 39969
		// (get) Token: 0x06022BC0 RID: 142272 RVA: 0x004D0183 File Offset: 0x004CE383
		// (set) Token: 0x06022BC1 RID: 142273 RVA: 0x004D018B File Offset: 0x004CE38B
		public int From { get; set; }

		// Token: 0x17009C22 RID: 39970
		// (get) Token: 0x06022BC2 RID: 142274 RVA: 0x004D0194 File Offset: 0x004CE394
		// (set) Token: 0x06022BC3 RID: 142275 RVA: 0x004D019C File Offset: 0x004CE39C
		public int To { get; set; }

		// Token: 0x06022BC4 RID: 142276 RVA: 0x004D01A5 File Offset: 0x004CE3A5
		public IGraph3dEdgeNormalT()
		{
			this.Id = 0;
			this.From = 0;
			this.To = 0;
		}
	}
}
