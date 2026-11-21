using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DC RID: 22492
	public class IFixedPointHookT
	{
		// Token: 0x1700A2AB RID: 41643
		// (get) Token: 0x06024557 RID: 148823 RVA: 0x004FE1DE File Offset: 0x004FC3DE
		// (set) Token: 0x06024558 RID: 148824 RVA: 0x004FE1E6 File Offset: 0x004FC3E6
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A2AC RID: 41644
		// (get) Token: 0x06024559 RID: 148825 RVA: 0x004FE1EF File Offset: 0x004FC3EF
		// (set) Token: 0x0602455A RID: 148826 RVA: 0x004FE1F7 File Offset: 0x004FC3F7
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A2AD RID: 41645
		// (get) Token: 0x0602455B RID: 148827 RVA: 0x004FE200 File Offset: 0x004FC400
		// (set) Token: 0x0602455C RID: 148828 RVA: 0x004FE208 File Offset: 0x004FC408
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A2AE RID: 41646
		// (get) Token: 0x0602455D RID: 148829 RVA: 0x004FE211 File Offset: 0x004FC411
		// (set) Token: 0x0602455E RID: 148830 RVA: 0x004FE219 File Offset: 0x004FC419
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A2AF RID: 41647
		// (get) Token: 0x0602455F RID: 148831 RVA: 0x004FE222 File Offset: 0x004FC422
		// (set) Token: 0x06024560 RID: 148832 RVA: 0x004FE22A File Offset: 0x004FC42A
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A2B0 RID: 41648
		// (get) Token: 0x06024561 RID: 148833 RVA: 0x004FE233 File Offset: 0x004FC433
		// (set) Token: 0x06024562 RID: 148834 RVA: 0x004FE23B File Offset: 0x004FC43B
		public float ExitDistance { get; set; }

		// Token: 0x1700A2B1 RID: 41649
		// (get) Token: 0x06024563 RID: 148835 RVA: 0x004FE244 File Offset: 0x004FC444
		// (set) Token: 0x06024564 RID: 148836 RVA: 0x004FE24C File Offset: 0x004FC44C
		public byte NullMask { get; set; }

		// Token: 0x06024565 RID: 148837 RVA: 0x004FE255 File Offset: 0x004FC455
		public IFixedPointHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.ExitDistance = 0f;
			this.NullMask = 0;
		}
	}
}
