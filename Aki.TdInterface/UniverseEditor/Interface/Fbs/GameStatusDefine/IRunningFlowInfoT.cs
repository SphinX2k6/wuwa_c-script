using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004704 RID: 18180
	public class IRunningFlowInfoT
	{
		// Token: 0x17008214 RID: 33300
		// (get) Token: 0x0601BDEF RID: 114159 RVA: 0x003F3563 File Offset: 0x003F1763
		// (set) Token: 0x0601BDF0 RID: 114160 RVA: 0x003F356B File Offset: 0x003F176B
		public bool IsPlaying { get; set; }

		// Token: 0x17008215 RID: 33301
		// (get) Token: 0x0601BDF1 RID: 114161 RVA: 0x003F3574 File Offset: 0x003F1774
		// (set) Token: 0x0601BDF2 RID: 114162 RVA: 0x003F357C File Offset: 0x003F177C
		public List<Record_Int_EActionStateT> ActionInfo { get; set; }

		// Token: 0x0601BDF3 RID: 114163 RVA: 0x003F3585 File Offset: 0x003F1785
		public IRunningFlowInfoT()
		{
			this.IsPlaying = false;
			this.ActionInfo = null;
		}
	}
}
