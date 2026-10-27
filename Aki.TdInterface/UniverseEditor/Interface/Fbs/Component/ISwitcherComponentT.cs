using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A11 RID: 23057
	public class ISwitcherComponentT
	{
		// Token: 0x1700AD44 RID: 44356
		// (get) Token: 0x0602725F RID: 160351 RVA: 0x00562AAB File Offset: 0x00560CAB
		// (set) Token: 0x06027260 RID: 160352 RVA: 0x00562AB3 File Offset: 0x00560CB3
		public bool Disabled { get; set; }

		// Token: 0x1700AD45 RID: 44357
		// (get) Token: 0x06027261 RID: 160353 RVA: 0x00562ABC File Offset: 0x00560CBC
		// (set) Token: 0x06027262 RID: 160354 RVA: 0x00562AC4 File Offset: 0x00560CC4
		public string Content { get; set; }

		// Token: 0x1700AD46 RID: 44358
		// (get) Token: 0x06027263 RID: 160355 RVA: 0x00562ACD File Offset: 0x00560CCD
		// (set) Token: 0x06027264 RID: 160356 RVA: 0x00562AD5 File Offset: 0x00560CD5
		public string Icon { get; set; }

		// Token: 0x1700AD47 RID: 44359
		// (get) Token: 0x06027265 RID: 160357 RVA: 0x00562ADE File Offset: 0x00560CDE
		// (set) Token: 0x06027266 RID: 160358 RVA: 0x00562AE6 File Offset: 0x00560CE6
		public List<IActionInfoT> OnActions { get; set; }

		// Token: 0x1700AD48 RID: 44360
		// (get) Token: 0x06027267 RID: 160359 RVA: 0x00562AEF File Offset: 0x00560CEF
		// (set) Token: 0x06027268 RID: 160360 RVA: 0x00562AF7 File Offset: 0x00560CF7
		public List<IActionInfoT> OffActions { get; set; }

		// Token: 0x1700AD49 RID: 44361
		// (get) Token: 0x06027269 RID: 160361 RVA: 0x00562B00 File Offset: 0x00560D00
		// (set) Token: 0x0602726A RID: 160362 RVA: 0x00562B08 File Offset: 0x00560D08
		public byte NullMask { get; set; }

		// Token: 0x0602726B RID: 160363 RVA: 0x00562B11 File Offset: 0x00560D11
		public ISwitcherComponentT()
		{
			this.Disabled = false;
			this.Content = null;
			this.Icon = null;
			this.OnActions = null;
			this.OffActions = null;
			this.NullMask = 0;
		}
	}
}
