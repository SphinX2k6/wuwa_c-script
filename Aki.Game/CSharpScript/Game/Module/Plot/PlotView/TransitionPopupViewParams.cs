using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02005071 RID: 20593
	[NullableContext(2)]
	[Nullable(0)]
	public class TransitionPopupViewParams
	{
		// Token: 0x17008041 RID: 32833
		// (get) Token: 0x06034C21 RID: 216097 RVA: 0x00C7BDFB File Offset: 0x00C79FFB
		// (set) Token: 0x06034C22 RID: 216098 RVA: 0x00C7BE03 File Offset: 0x00C7A003
		public int? BoardId { get; set; }

		// Token: 0x17008042 RID: 32834
		// (get) Token: 0x06034C23 RID: 216099 RVA: 0x00C7BE0C File Offset: 0x00C7A00C
		// (set) Token: 0x06034C24 RID: 216100 RVA: 0x00C7BE14 File Offset: 0x00C7A014
		public bool InPlot { get; set; }

		// Token: 0x17008043 RID: 32835
		// (get) Token: 0x06034C25 RID: 216101 RVA: 0x00C7BE1D File Offset: 0x00C7A01D
		// (set) Token: 0x06034C26 RID: 216102 RVA: 0x00C7BE25 File Offset: 0x00C7A025
		public float? Duration { get; set; }

		// Token: 0x17008044 RID: 32836
		// (get) Token: 0x06034C27 RID: 216103 RVA: 0x00C7BE2E File Offset: 0x00C7A02E
		// (set) Token: 0x06034C28 RID: 216104 RVA: 0x00C7BE36 File Offset: 0x00C7A036
		public ITransitionPopupStyle Style { get; set; }
	}
}
