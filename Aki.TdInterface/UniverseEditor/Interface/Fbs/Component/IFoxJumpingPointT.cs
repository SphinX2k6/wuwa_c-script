using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200582A RID: 22570
	public class IFoxJumpingPointT
	{
		// Token: 0x1700A35F RID: 41823
		// (get) Token: 0x0602487F RID: 149631 RVA: 0x00504E20 File Offset: 0x00503020
		// (set) Token: 0x06024880 RID: 149632 RVA: 0x00504E28 File Offset: 0x00503028
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A360 RID: 41824
		// (get) Token: 0x06024881 RID: 149633 RVA: 0x00504E31 File Offset: 0x00503031
		// (set) Token: 0x06024882 RID: 149634 RVA: 0x00504E39 File Offset: 0x00503039
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A361 RID: 41825
		// (get) Token: 0x06024883 RID: 149635 RVA: 0x00504E42 File Offset: 0x00503042
		// (set) Token: 0x06024884 RID: 149636 RVA: 0x00504E4A File Offset: 0x0050304A
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A362 RID: 41826
		// (get) Token: 0x06024885 RID: 149637 RVA: 0x00504E53 File Offset: 0x00503053
		// (set) Token: 0x06024886 RID: 149638 RVA: 0x00504E5B File Offset: 0x0050305B
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A363 RID: 41827
		// (get) Token: 0x06024887 RID: 149639 RVA: 0x00504E64 File Offset: 0x00503064
		// (set) Token: 0x06024888 RID: 149640 RVA: 0x00504E6C File Offset: 0x0050306C
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A364 RID: 41828
		// (get) Token: 0x06024889 RID: 149641 RVA: 0x00504E75 File Offset: 0x00503075
		// (set) Token: 0x0602488A RID: 149642 RVA: 0x00504E7D File Offset: 0x0050307D
		public byte NullMask { get; set; }

		// Token: 0x0602488B RID: 149643 RVA: 0x00504E86 File Offset: 0x00503086
		public IFoxJumpingPointT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.NullMask = 0;
		}
	}
}
