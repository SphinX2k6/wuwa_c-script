using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B6C RID: 19308
	public class IRunningFlowInfoT
	{
		// Token: 0x17008855 RID: 34901
		// (get) Token: 0x0601D5C4 RID: 120260 RVA: 0x0041F7FF File Offset: 0x0041D9FF
		// (set) Token: 0x0601D5C5 RID: 120261 RVA: 0x0041F807 File Offset: 0x0041DA07
		public bool IsPlaying { get; set; }

		// Token: 0x17008856 RID: 34902
		// (get) Token: 0x0601D5C6 RID: 120262 RVA: 0x0041F810 File Offset: 0x0041DA10
		// (set) Token: 0x0601D5C7 RID: 120263 RVA: 0x0041F818 File Offset: 0x0041DA18
		public List<Record_Int_EActionStateT> ActionInfo { get; set; }

		// Token: 0x0601D5C8 RID: 120264 RVA: 0x0041F821 File Offset: 0x0041DA21
		public IRunningFlowInfoT()
		{
			this.IsPlaying = false;
			this.ActionInfo = null;
		}
	}
}
