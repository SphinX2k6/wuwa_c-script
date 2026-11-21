using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060F2 RID: 24818
	public class ITriggeredConfigT
	{
		// Token: 0x1700B8B4 RID: 47284
		// (get) Token: 0x0602A0E0 RID: 172256 RVA: 0x005BDA9E File Offset: 0x005BBC9E
		// (set) Token: 0x0602A0E1 RID: 172257 RVA: 0x005BDAA6 File Offset: 0x005BBCA6
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B8B5 RID: 47285
		// (get) Token: 0x0602A0E2 RID: 172258 RVA: 0x005BDAAF File Offset: 0x005BBCAF
		// (set) Token: 0x0602A0E3 RID: 172259 RVA: 0x005BDAB7 File Offset: 0x005BBCB7
		public int MaxTriggerTimes { get; set; }

		// Token: 0x1700B8B6 RID: 47286
		// (get) Token: 0x0602A0E4 RID: 172260 RVA: 0x005BDAC0 File Offset: 0x005BBCC0
		// (set) Token: 0x0602A0E5 RID: 172261 RVA: 0x005BDAC8 File Offset: 0x005BBCC8
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700B8B7 RID: 47287
		// (get) Token: 0x0602A0E6 RID: 172262 RVA: 0x005BDAD1 File Offset: 0x005BBCD1
		// (set) Token: 0x0602A0E7 RID: 172263 RVA: 0x005BDAD9 File Offset: 0x005BBCD9
		public bool OnlineDisableTip { get; set; }

		// Token: 0x1700B8B8 RID: 47288
		// (get) Token: 0x0602A0E8 RID: 172264 RVA: 0x005BDAE2 File Offset: 0x005BBCE2
		// (set) Token: 0x0602A0E9 RID: 172265 RVA: 0x005BDAEA File Offset: 0x005BBCEA
		public byte NullMask { get; set; }

		// Token: 0x0602A0EA RID: 172266 RVA: 0x005BDAF3 File Offset: 0x005BBCF3
		public ITriggeredConfigT()
		{
			this.Condition = null;
			this.MaxTriggerTimes = 0;
			this.Actions = null;
			this.OnlineDisableTip = false;
			this.NullMask = 0;
		}
	}
}
