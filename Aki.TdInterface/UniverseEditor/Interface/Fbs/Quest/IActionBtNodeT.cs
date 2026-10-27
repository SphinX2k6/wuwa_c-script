using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CED RID: 15597
	public class IActionBtNodeT
	{
		// Token: 0x17006AD5 RID: 27349
		// (get) Token: 0x06015783 RID: 87939 RVA: 0x0031A15D File Offset: 0x0031835D
		// (set) Token: 0x06015784 RID: 87940 RVA: 0x0031A165 File Offset: 0x00318365
		public EBtNode Type { get; set; }

		// Token: 0x17006AD6 RID: 27350
		// (get) Token: 0x06015785 RID: 87941 RVA: 0x0031A16E File Offset: 0x0031836E
		// (set) Token: 0x06015786 RID: 87942 RVA: 0x0031A176 File Offset: 0x00318376
		public int Id { get; set; }

		// Token: 0x17006AD7 RID: 27351
		// (get) Token: 0x06015787 RID: 87943 RVA: 0x0031A17F File Offset: 0x0031837F
		// (set) Token: 0x06015788 RID: 87944 RVA: 0x0031A187 File Offset: 0x00318387
		public string Desc { get; set; }

		// Token: 0x17006AD8 RID: 27352
		// (get) Token: 0x06015789 RID: 87945 RVA: 0x0031A190 File Offset: 0x00318390
		// (set) Token: 0x0601578A RID: 87946 RVA: 0x0031A198 File Offset: 0x00318398
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006AD9 RID: 27353
		// (get) Token: 0x0601578B RID: 87947 RVA: 0x0031A1A1 File Offset: 0x003183A1
		// (set) Token: 0x0601578C RID: 87948 RVA: 0x0031A1A9 File Offset: 0x003183A9
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006ADA RID: 27354
		// (get) Token: 0x0601578D RID: 87949 RVA: 0x0031A1B2 File Offset: 0x003183B2
		// (set) Token: 0x0601578E RID: 87950 RVA: 0x0031A1BA File Offset: 0x003183BA
		public bool Disabled { get; set; }

		// Token: 0x17006ADB RID: 27355
		// (get) Token: 0x0601578F RID: 87951 RVA: 0x0031A1C3 File Offset: 0x003183C3
		// (set) Token: 0x06015790 RID: 87952 RVA: 0x0031A1CB File Offset: 0x003183CB
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17006ADC RID: 27356
		// (get) Token: 0x06015791 RID: 87953 RVA: 0x0031A1D4 File Offset: 0x003183D4
		// (set) Token: 0x06015792 RID: 87954 RVA: 0x0031A1DC File Offset: 0x003183DC
		public byte NullMask { get; set; }

		// Token: 0x06015793 RID: 87955 RVA: 0x0031A1E5 File Offset: 0x003183E5
		public IActionBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
