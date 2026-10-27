using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E72 RID: 20082
	public class IAiAlertNotifyComponentT
	{
		// Token: 0x17008FCC RID: 36812
		// (get) Token: 0x0601F8CE RID: 129230 RVA: 0x00464DAF File Offset: 0x00462FAF
		// (set) Token: 0x0601F8CF RID: 129231 RVA: 0x00464DB7 File Offset: 0x00462FB7
		public bool Disabled { get; set; }

		// Token: 0x17008FCD RID: 36813
		// (get) Token: 0x0601F8D0 RID: 129232 RVA: 0x00464DC0 File Offset: 0x00462FC0
		// (set) Token: 0x0601F8D1 RID: 129233 RVA: 0x00464DC8 File Offset: 0x00462FC8
		public IExtraAiAlertT ExtraAiAlert { get; set; }

		// Token: 0x17008FCE RID: 36814
		// (get) Token: 0x0601F8D2 RID: 129234 RVA: 0x00464DD1 File Offset: 0x00462FD1
		// (set) Token: 0x0601F8D3 RID: 129235 RVA: 0x00464DD9 File Offset: 0x00462FD9
		public List<int> ExcludeEntities { get; set; }

		// Token: 0x17008FCF RID: 36815
		// (get) Token: 0x0601F8D4 RID: 129236 RVA: 0x00464DE2 File Offset: 0x00462FE2
		// (set) Token: 0x0601F8D5 RID: 129237 RVA: 0x00464DEA File Offset: 0x00462FEA
		public string AlertSound { get; set; }

		// Token: 0x17008FD0 RID: 36816
		// (get) Token: 0x0601F8D6 RID: 129238 RVA: 0x00464DF3 File Offset: 0x00462FF3
		// (set) Token: 0x0601F8D7 RID: 129239 RVA: 0x00464DFB File Offset: 0x00462FFB
		public byte NullMask { get; set; }

		// Token: 0x0601F8D8 RID: 129240 RVA: 0x00464E04 File Offset: 0x00463004
		public IAiAlertNotifyComponentT()
		{
			this.Disabled = false;
			this.ExtraAiAlert = null;
			this.ExcludeEntities = null;
			this.AlertSound = null;
			this.NullMask = 0;
		}
	}
}
