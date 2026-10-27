using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FA4 RID: 20388
	public class IClientConditionListenerT
	{
		// Token: 0x1700939E RID: 37790
		// (get) Token: 0x060206F9 RID: 132857 RVA: 0x004833F7 File Offset: 0x004815F7
		// (set) Token: 0x060206FA RID: 132858 RVA: 0x004833FF File Offset: 0x004815FF
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700939F RID: 37791
		// (get) Token: 0x060206FB RID: 132859 RVA: 0x00483408 File Offset: 0x00481608
		// (set) Token: 0x060206FC RID: 132860 RVA: 0x00483410 File Offset: 0x00481610
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x170093A0 RID: 37792
		// (get) Token: 0x060206FD RID: 132861 RVA: 0x00483419 File Offset: 0x00481619
		// (set) Token: 0x060206FE RID: 132862 RVA: 0x00483421 File Offset: 0x00481621
		public string SendSelfEvent { get; set; }

		// Token: 0x170093A1 RID: 37793
		// (get) Token: 0x060206FF RID: 132863 RVA: 0x0048342A File Offset: 0x0048162A
		// (set) Token: 0x06020700 RID: 132864 RVA: 0x00483432 File Offset: 0x00481632
		public bool OnlyTriggerWhenConditionBecomesTrue { get; set; }

		// Token: 0x170093A2 RID: 37794
		// (get) Token: 0x06020701 RID: 132865 RVA: 0x0048343B File Offset: 0x0048163B
		// (set) Token: 0x06020702 RID: 132866 RVA: 0x00483443 File Offset: 0x00481643
		public byte NullMask { get; set; }

		// Token: 0x06020703 RID: 132867 RVA: 0x0048344C File Offset: 0x0048164C
		public IClientConditionListenerT()
		{
			this.Condition = null;
			this.Actions = null;
			this.SendSelfEvent = null;
			this.OnlyTriggerWhenConditionBecomesTrue = false;
			this.NullMask = 0;
		}
	}
}
