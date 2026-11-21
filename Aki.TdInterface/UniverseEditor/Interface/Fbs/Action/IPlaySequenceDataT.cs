using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BA RID: 29882
	public class IPlaySequenceDataT
	{
		// Token: 0x1700DBD2 RID: 56274
		// (get) Token: 0x060345F1 RID: 214513 RVA: 0x0070DB15 File Offset: 0x0070BD15
		// (set) Token: 0x060345F2 RID: 214514 RVA: 0x0070DB1D File Offset: 0x0070BD1D
		public string Path { get; set; }

		// Token: 0x1700DBD3 RID: 56275
		// (get) Token: 0x060345F3 RID: 214515 RVA: 0x0070DB26 File Offset: 0x0070BD26
		// (set) Token: 0x060345F4 RID: 214516 RVA: 0x0070DB2E File Offset: 0x0070BD2E
		public bool ResetCamera { get; set; }

		// Token: 0x1700DBD4 RID: 56276
		// (get) Token: 0x060345F5 RID: 214517 RVA: 0x0070DB37 File Offset: 0x0070BD37
		// (set) Token: 0x060345F6 RID: 214518 RVA: 0x0070DB3F File Offset: 0x0070BD3F
		public bool KeepCamera { get; set; }

		// Token: 0x1700DBD5 RID: 56277
		// (get) Token: 0x060345F7 RID: 214519 RVA: 0x0070DB48 File Offset: 0x0070BD48
		// (set) Token: 0x060345F8 RID: 214520 RVA: 0x0070DB50 File Offset: 0x0070BD50
		public bool PreLoadRenderAssets { get; set; }

		// Token: 0x1700DBD6 RID: 56278
		// (get) Token: 0x060345F9 RID: 214521 RVA: 0x0070DB59 File Offset: 0x0070BD59
		// (set) Token: 0x060345FA RID: 214522 RVA: 0x0070DB61 File Offset: 0x0070BD61
		public List<ISequenceFrameEventT> FrameEvents { get; set; }

		// Token: 0x1700DBD7 RID: 56279
		// (get) Token: 0x060345FB RID: 214523 RVA: 0x0070DB6A File Offset: 0x0070BD6A
		// (set) Token: 0x060345FC RID: 214524 RVA: 0x0070DB72 File Offset: 0x0070BD72
		public bool SaveFinalPos { get; set; }

		// Token: 0x1700DBD8 RID: 56280
		// (get) Token: 0x060345FD RID: 214525 RVA: 0x0070DB7B File Offset: 0x0070BD7B
		// (set) Token: 0x060345FE RID: 214526 RVA: 0x0070DB83 File Offset: 0x0070BD83
		public ISetBlendAnimT SeqBlendAnim { get; set; }

		// Token: 0x1700DBD9 RID: 56281
		// (get) Token: 0x060345FF RID: 214527 RVA: 0x0070DB8C File Offset: 0x0070BD8C
		// (set) Token: 0x06034600 RID: 214528 RVA: 0x0070DB94 File Offset: 0x0070BD94
		public byte NullMask { get; set; }

		// Token: 0x06034601 RID: 214529 RVA: 0x0070DB9D File Offset: 0x0070BD9D
		public IPlaySequenceDataT()
		{
			this.Path = null;
			this.ResetCamera = false;
			this.KeepCamera = false;
			this.PreLoadRenderAssets = false;
			this.FrameEvents = null;
			this.SaveFinalPos = false;
			this.SeqBlendAnim = null;
			this.NullMask = 0;
		}
	}
}
