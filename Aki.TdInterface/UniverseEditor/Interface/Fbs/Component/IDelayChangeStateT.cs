using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200507F RID: 20607
	public class IDelayChangeStateT
	{
		// Token: 0x17009581 RID: 38273
		// (get) Token: 0x0602109B RID: 135323 RVA: 0x00496CF9 File Offset: 0x00494EF9
		// (set) Token: 0x0602109C RID: 135324 RVA: 0x00496D01 File Offset: 0x00494F01
		public float Time { get; set; }

		// Token: 0x17009582 RID: 38274
		// (get) Token: 0x0602109D RID: 135325 RVA: 0x00496D0A File Offset: 0x00494F0A
		// (set) Token: 0x0602109E RID: 135326 RVA: 0x00496D12 File Offset: 0x00494F12
		public string NewState { get; set; }

		// Token: 0x17009583 RID: 38275
		// (get) Token: 0x0602109F RID: 135327 RVA: 0x00496D1B File Offset: 0x00494F1B
		// (set) Token: 0x060210A0 RID: 135328 RVA: 0x00496D23 File Offset: 0x00494F23
		public IVarIntervalT DelayInterval { get; set; }

		// Token: 0x17009584 RID: 38276
		// (get) Token: 0x060210A1 RID: 135329 RVA: 0x00496D2C File Offset: 0x00494F2C
		// (set) Token: 0x060210A2 RID: 135330 RVA: 0x00496D34 File Offset: 0x00494F34
		public bool WaitActionGroupEnd { get; set; }

		// Token: 0x17009585 RID: 38277
		// (get) Token: 0x060210A3 RID: 135331 RVA: 0x00496D3D File Offset: 0x00494F3D
		// (set) Token: 0x060210A4 RID: 135332 RVA: 0x00496D45 File Offset: 0x00494F45
		public byte NullMask { get; set; }

		// Token: 0x060210A5 RID: 135333 RVA: 0x00496D4E File Offset: 0x00494F4E
		public IDelayChangeStateT()
		{
			this.Time = 0f;
			this.NewState = null;
			this.DelayInterval = null;
			this.WaitActionGroupEnd = false;
			this.NullMask = 0;
		}
	}
}
