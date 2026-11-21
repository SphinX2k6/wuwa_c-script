using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006113 RID: 24851
	public class IUndergroundComponentT
	{
		// Token: 0x1700B902 RID: 47362
		// (get) Token: 0x0602A216 RID: 172566 RVA: 0x005C0132 File Offset: 0x005BE332
		// (set) Token: 0x0602A217 RID: 172567 RVA: 0x005C013A File Offset: 0x005BE33A
		public bool Disabled { get; set; }

		// Token: 0x1700B903 RID: 47363
		// (get) Token: 0x0602A218 RID: 172568 RVA: 0x005C0143 File Offset: 0x005BE343
		// (set) Token: 0x0602A219 RID: 172569 RVA: 0x005C014B File Offset: 0x005BE34B
		public int TestState { get; set; }

		// Token: 0x1700B904 RID: 47364
		// (get) Token: 0x0602A21A RID: 172570 RVA: 0x005C0154 File Offset: 0x005BE354
		// (set) Token: 0x0602A21B RID: 172571 RVA: 0x005C015C File Offset: 0x005BE35C
		public bool IsRestartPlayer { get; set; }

		// Token: 0x1700B905 RID: 47365
		// (get) Token: 0x0602A21C RID: 172572 RVA: 0x005C0165 File Offset: 0x005BE365
		// (set) Token: 0x0602A21D RID: 172573 RVA: 0x005C016D File Offset: 0x005BE36D
		public List<string> DestroyTag { get; set; }

		// Token: 0x1700B906 RID: 47366
		// (get) Token: 0x0602A21E RID: 172574 RVA: 0x005C0176 File Offset: 0x005BE376
		// (set) Token: 0x0602A21F RID: 172575 RVA: 0x005C017E File Offset: 0x005BE37E
		public List<IUndergroundStateInfoT> StateInfo { get; set; }

		// Token: 0x1700B907 RID: 47367
		// (get) Token: 0x0602A220 RID: 172576 RVA: 0x005C0187 File Offset: 0x005BE387
		// (set) Token: 0x0602A221 RID: 172577 RVA: 0x005C018F File Offset: 0x005BE38F
		public byte NullMask { get; set; }

		// Token: 0x0602A222 RID: 172578 RVA: 0x005C0198 File Offset: 0x005BE398
		public IUndergroundComponentT()
		{
			this.Disabled = false;
			this.TestState = 0;
			this.IsRestartPlayer = false;
			this.DestroyTag = null;
			this.StateInfo = null;
			this.NullMask = 0;
		}
	}
}
