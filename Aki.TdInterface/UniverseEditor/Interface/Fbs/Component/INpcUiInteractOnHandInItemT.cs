using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005678 RID: 22136
	public class INpcUiInteractOnHandInItemT
	{
		// Token: 0x1700A442 RID: 42050
		// (get) Token: 0x06024DD3 RID: 150995 RVA: 0x005165AB File Offset: 0x005147AB
		// (set) Token: 0x06024DD4 RID: 150996 RVA: 0x005165B3 File Offset: 0x005147B3
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A443 RID: 42051
		// (get) Token: 0x06024DD5 RID: 150997 RVA: 0x005165BC File Offset: 0x005147BC
		// (set) Token: 0x06024DD6 RID: 150998 RVA: 0x005165C4 File Offset: 0x005147C4
		public string EnterMontage { get; set; }

		// Token: 0x1700A444 RID: 42052
		// (get) Token: 0x06024DD7 RID: 150999 RVA: 0x005165CD File Offset: 0x005147CD
		// (set) Token: 0x06024DD8 RID: 151000 RVA: 0x005165D5 File Offset: 0x005147D5
		public string StandByMontage { get; set; }

		// Token: 0x1700A445 RID: 42053
		// (get) Token: 0x06024DD9 RID: 151001 RVA: 0x005165DE File Offset: 0x005147DE
		// (set) Token: 0x06024DDA RID: 151002 RVA: 0x005165E6 File Offset: 0x005147E6
		public string HandInFailedMontage { get; set; }

		// Token: 0x1700A446 RID: 42054
		// (get) Token: 0x06024DDB RID: 151003 RVA: 0x005165EF File Offset: 0x005147EF
		// (set) Token: 0x06024DDC RID: 151004 RVA: 0x005165F7 File Offset: 0x005147F7
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A447 RID: 42055
		// (get) Token: 0x06024DDD RID: 151005 RVA: 0x00516600 File Offset: 0x00514800
		// (set) Token: 0x06024DDE RID: 151006 RVA: 0x00516608 File Offset: 0x00514808
		public IPlayFlowT HandInFailedFlow { get; set; }

		// Token: 0x06024DDF RID: 151007 RVA: 0x00516611 File Offset: 0x00514811
		public INpcUiInteractOnHandInItemT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.HandInFailedMontage = null;
			this.EnterFlow = null;
			this.HandInFailedFlow = null;
		}
	}
}
