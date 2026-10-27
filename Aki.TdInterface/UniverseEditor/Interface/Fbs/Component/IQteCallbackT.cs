using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BE RID: 22462
	public class IQteCallbackT
	{
		// Token: 0x1700A7A8 RID: 42920
		// (get) Token: 0x06025B3A RID: 154426 RVA: 0x005332A1 File Offset: 0x005314A1
		// (set) Token: 0x06025B3B RID: 154427 RVA: 0x005332A9 File Offset: 0x005314A9
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A7A9 RID: 42921
		// (get) Token: 0x06025B3C RID: 154428 RVA: 0x005332B2 File Offset: 0x005314B2
		// (set) Token: 0x06025B3D RID: 154429 RVA: 0x005332BA File Offset: 0x005314BA
		public string SendSelfEvent { get; set; }

		// Token: 0x06025B3E RID: 154430 RVA: 0x005332C3 File Offset: 0x005314C3
		public IQteCallbackT()
		{
			this.Actions = null;
			this.SendSelfEvent = null;
		}
	}
}
