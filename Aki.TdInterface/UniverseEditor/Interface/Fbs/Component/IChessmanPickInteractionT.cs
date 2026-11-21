using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054C7 RID: 21703
	public class IChessmanPickInteractionT
	{
		// Token: 0x17009AEC RID: 39660
		// (get) Token: 0x060223AF RID: 140207 RVA: 0x004B7F66 File Offset: 0x004B6166
		// (set) Token: 0x060223B0 RID: 140208 RVA: 0x004B7F6E File Offset: 0x004B616E
		public EPickInteraction Type { get; set; }

		// Token: 0x17009AED RID: 39661
		// (get) Token: 0x060223B1 RID: 140209 RVA: 0x004B7F77 File Offset: 0x004B6177
		// (set) Token: 0x060223B2 RID: 140210 RVA: 0x004B7F7F File Offset: 0x004B617F
		public List<IActionInfoT> CheckedActions { get; set; }

		// Token: 0x17009AEE RID: 39662
		// (get) Token: 0x060223B3 RID: 140211 RVA: 0x004B7F88 File Offset: 0x004B6188
		// (set) Token: 0x060223B4 RID: 140212 RVA: 0x004B7F90 File Offset: 0x004B6190
		public List<IActionInfoT> UncheckedActions { get; set; }

		// Token: 0x17009AEF RID: 39663
		// (get) Token: 0x060223B5 RID: 140213 RVA: 0x004B7F99 File Offset: 0x004B6199
		// (set) Token: 0x060223B6 RID: 140214 RVA: 0x004B7FA1 File Offset: 0x004B61A1
		public int TargetChessboard { get; set; }

		// Token: 0x17009AF0 RID: 39664
		// (get) Token: 0x060223B7 RID: 140215 RVA: 0x004B7FAA File Offset: 0x004B61AA
		// (set) Token: 0x060223B8 RID: 140216 RVA: 0x004B7FB2 File Offset: 0x004B61B2
		public string AvailablePosEffect { get; set; }

		// Token: 0x17009AF1 RID: 39665
		// (get) Token: 0x060223B9 RID: 140217 RVA: 0x004B7FBB File Offset: 0x004B61BB
		// (set) Token: 0x060223BA RID: 140218 RVA: 0x004B7FC3 File Offset: 0x004B61C3
		public byte NullMask { get; set; }

		// Token: 0x060223BB RID: 140219 RVA: 0x004B7FCC File Offset: 0x004B61CC
		public IChessmanPickInteractionT()
		{
			this.Type = EPickInteraction.ChessmanInteract;
			this.CheckedActions = null;
			this.UncheckedActions = null;
			this.TargetChessboard = 0;
			this.AvailablePosEffect = null;
			this.NullMask = 0;
		}
	}
}
