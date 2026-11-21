using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004104 RID: 16644
	public class IActionBtNodeT
	{
		// Token: 0x1700708F RID: 28815
		// (get) Token: 0x06016CBB RID: 93371 RVA: 0x003413D5 File Offset: 0x0033F5D5
		// (set) Token: 0x06016CBC RID: 93372 RVA: 0x003413DD File Offset: 0x0033F5DD
		public EBtNode Type { get; set; }

		// Token: 0x17007090 RID: 28816
		// (get) Token: 0x06016CBD RID: 93373 RVA: 0x003413E6 File Offset: 0x0033F5E6
		// (set) Token: 0x06016CBE RID: 93374 RVA: 0x003413EE File Offset: 0x0033F5EE
		public int Id { get; set; }

		// Token: 0x17007091 RID: 28817
		// (get) Token: 0x06016CBF RID: 93375 RVA: 0x003413F7 File Offset: 0x0033F5F7
		// (set) Token: 0x06016CC0 RID: 93376 RVA: 0x003413FF File Offset: 0x0033F5FF
		public string Desc { get; set; }

		// Token: 0x17007092 RID: 28818
		// (get) Token: 0x06016CC1 RID: 93377 RVA: 0x00341408 File Offset: 0x0033F608
		// (set) Token: 0x06016CC2 RID: 93378 RVA: 0x00341410 File Offset: 0x0033F610
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007093 RID: 28819
		// (get) Token: 0x06016CC3 RID: 93379 RVA: 0x00341419 File Offset: 0x0033F619
		// (set) Token: 0x06016CC4 RID: 93380 RVA: 0x00341421 File Offset: 0x0033F621
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007094 RID: 28820
		// (get) Token: 0x06016CC5 RID: 93381 RVA: 0x0034142A File Offset: 0x0033F62A
		// (set) Token: 0x06016CC6 RID: 93382 RVA: 0x00341432 File Offset: 0x0033F632
		public bool Disabled { get; set; }

		// Token: 0x17007095 RID: 28821
		// (get) Token: 0x06016CC7 RID: 93383 RVA: 0x0034143B File Offset: 0x0033F63B
		// (set) Token: 0x06016CC8 RID: 93384 RVA: 0x00341443 File Offset: 0x0033F643
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x17007096 RID: 28822
		// (get) Token: 0x06016CC9 RID: 93385 RVA: 0x0034144C File Offset: 0x0033F64C
		// (set) Token: 0x06016CCA RID: 93386 RVA: 0x00341454 File Offset: 0x0033F654
		public byte NullMask { get; set; }

		// Token: 0x06016CCB RID: 93387 RVA: 0x0034145D File Offset: 0x0033F65D
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
