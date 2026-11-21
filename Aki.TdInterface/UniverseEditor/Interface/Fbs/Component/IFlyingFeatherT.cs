using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F1 RID: 22513
	public class IFlyingFeatherT
	{
		// Token: 0x1700A2E6 RID: 41702
		// (get) Token: 0x06024667 RID: 149095 RVA: 0x00500862 File Offset: 0x004FEA62
		// (set) Token: 0x06024668 RID: 149096 RVA: 0x0050086A File Offset: 0x004FEA6A
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A2E7 RID: 41703
		// (get) Token: 0x06024669 RID: 149097 RVA: 0x00500873 File Offset: 0x004FEA73
		// (set) Token: 0x0602466A RID: 149098 RVA: 0x0050087B File Offset: 0x004FEA7B
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A2E8 RID: 41704
		// (get) Token: 0x0602466B RID: 149099 RVA: 0x00500884 File Offset: 0x004FEA84
		// (set) Token: 0x0602466C RID: 149100 RVA: 0x0050088C File Offset: 0x004FEA8C
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A2E9 RID: 41705
		// (get) Token: 0x0602466D RID: 149101 RVA: 0x00500895 File Offset: 0x004FEA95
		// (set) Token: 0x0602466E RID: 149102 RVA: 0x0050089D File Offset: 0x004FEA9D
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A2EA RID: 41706
		// (get) Token: 0x0602466F RID: 149103 RVA: 0x005008A6 File Offset: 0x004FEAA6
		// (set) Token: 0x06024670 RID: 149104 RVA: 0x005008AE File Offset: 0x004FEAAE
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A2EB RID: 41707
		// (get) Token: 0x06024671 RID: 149105 RVA: 0x005008B7 File Offset: 0x004FEAB7
		// (set) Token: 0x06024672 RID: 149106 RVA: 0x005008BF File Offset: 0x004FEABF
		public int EntityId { get; set; }

		// Token: 0x1700A2EC RID: 41708
		// (get) Token: 0x06024673 RID: 149107 RVA: 0x005008C8 File Offset: 0x004FEAC8
		// (set) Token: 0x06024674 RID: 149108 RVA: 0x005008D0 File Offset: 0x004FEAD0
		public byte NullMask { get; set; }

		// Token: 0x06024675 RID: 149109 RVA: 0x005008D9 File Offset: 0x004FEAD9
		public IFlyingFeatherT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.EntityId = 0;
			this.NullMask = 0;
		}
	}
}
