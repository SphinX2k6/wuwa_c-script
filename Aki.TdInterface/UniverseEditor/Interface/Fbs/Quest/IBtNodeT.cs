using System;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004152 RID: 16722
	public class IBtNodeT
	{
		// Token: 0x17007140 RID: 28992
		// (get) Token: 0x06016FAD RID: 94125 RVA: 0x003472D1 File Offset: 0x003454D1
		// (set) Token: 0x06016FAE RID: 94126 RVA: 0x003472D9 File Offset: 0x003454D9
		public EBtNode Type { get; set; }

		// Token: 0x17007141 RID: 28993
		// (get) Token: 0x06016FAF RID: 94127 RVA: 0x003472E2 File Offset: 0x003454E2
		// (set) Token: 0x06016FB0 RID: 94128 RVA: 0x003472EA File Offset: 0x003454EA
		public int Id { get; set; }

		// Token: 0x17007142 RID: 28994
		// (get) Token: 0x06016FB1 RID: 94129 RVA: 0x003472F3 File Offset: 0x003454F3
		// (set) Token: 0x06016FB2 RID: 94130 RVA: 0x003472FB File Offset: 0x003454FB
		public string Desc { get; set; }

		// Token: 0x17007143 RID: 28995
		// (get) Token: 0x06016FB3 RID: 94131 RVA: 0x00347304 File Offset: 0x00345504
		// (set) Token: 0x06016FB4 RID: 94132 RVA: 0x0034730C File Offset: 0x0034550C
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007144 RID: 28996
		// (get) Token: 0x06016FB5 RID: 94133 RVA: 0x00347315 File Offset: 0x00345515
		// (set) Token: 0x06016FB6 RID: 94134 RVA: 0x0034731D File Offset: 0x0034551D
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007145 RID: 28997
		// (get) Token: 0x06016FB7 RID: 94135 RVA: 0x00347326 File Offset: 0x00345526
		// (set) Token: 0x06016FB8 RID: 94136 RVA: 0x0034732E File Offset: 0x0034552E
		public bool Disabled { get; set; }

		// Token: 0x17007146 RID: 28998
		// (get) Token: 0x06016FB9 RID: 94137 RVA: 0x00347337 File Offset: 0x00345537
		// (set) Token: 0x06016FBA RID: 94138 RVA: 0x0034733F File Offset: 0x0034553F
		public byte NullMask { get; set; }

		// Token: 0x06016FBB RID: 94139 RVA: 0x00347348 File Offset: 0x00345548
		public IBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
