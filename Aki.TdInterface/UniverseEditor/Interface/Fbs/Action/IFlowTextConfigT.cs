using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB8 RID: 28344
	public class IFlowTextConfigT
	{
		// Token: 0x1700CFE7 RID: 53223
		// (get) Token: 0x06031099 RID: 200857 RVA: 0x006A68E0 File Offset: 0x006A4AE0
		// (set) Token: 0x0603109A RID: 200858 RVA: 0x006A68E8 File Offset: 0x006A4AE8
		public string Text { get; set; }

		// Token: 0x1700CFE8 RID: 53224
		// (get) Token: 0x0603109B RID: 200859 RVA: 0x006A68F1 File Offset: 0x006A4AF1
		// (set) Token: 0x0603109C RID: 200860 RVA: 0x006A68F9 File Offset: 0x006A4AF9
		public string PlotLineKey { get; set; }

		// Token: 0x1700CFE9 RID: 53225
		// (get) Token: 0x0603109D RID: 200861 RVA: 0x006A6902 File Offset: 0x006A4B02
		// (set) Token: 0x0603109E RID: 200862 RVA: 0x006A690A File Offset: 0x006A4B0A
		public string StringKey { get; set; }

		// Token: 0x1700CFEA RID: 53226
		// (get) Token: 0x0603109F RID: 200863 RVA: 0x006A6913 File Offset: 0x006A4B13
		// (set) Token: 0x060310A0 RID: 200864 RVA: 0x006A691B File Offset: 0x006A4B1B
		public int FlowListId { get; set; }

		// Token: 0x1700CFEB RID: 53227
		// (get) Token: 0x060310A1 RID: 200865 RVA: 0x006A6924 File Offset: 0x006A4B24
		// (set) Token: 0x060310A2 RID: 200866 RVA: 0x006A692C File Offset: 0x006A4B2C
		public bool IsNoPlotText { get; set; }

		// Token: 0x1700CFEC RID: 53228
		// (get) Token: 0x060310A3 RID: 200867 RVA: 0x006A6935 File Offset: 0x006A4B35
		// (set) Token: 0x060310A4 RID: 200868 RVA: 0x006A693D File Offset: 0x006A4B3D
		public byte NullMask { get; set; }

		// Token: 0x060310A5 RID: 200869 RVA: 0x006A6946 File Offset: 0x006A4B46
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
