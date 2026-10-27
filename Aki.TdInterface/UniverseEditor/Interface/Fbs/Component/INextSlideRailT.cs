using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FA RID: 22010
	public class INextSlideRailT
	{
		// Token: 0x1700A2DE RID: 41694
		// (get) Token: 0x06024855 RID: 149589 RVA: 0x0050A564 File Offset: 0x00508764
		// (set) Token: 0x06024856 RID: 149590 RVA: 0x0050A56C File Offset: 0x0050876C
		public ETriggerKey TriggerKey { get; set; }

		// Token: 0x1700A2DF RID: 41695
		// (get) Token: 0x06024857 RID: 149591 RVA: 0x0050A575 File Offset: 0x00508775
		// (set) Token: 0x06024858 RID: 149592 RVA: 0x0050A57D File Offset: 0x0050877D
		public int TargetRailEntityId { get; set; }

		// Token: 0x1700A2E0 RID: 41696
		// (get) Token: 0x06024859 RID: 149593 RVA: 0x0050A586 File Offset: 0x00508786
		// (set) Token: 0x0602485A RID: 149594 RVA: 0x0050A58E File Offset: 0x0050878E
		public bool IsFallbackRail { get; set; }

		// Token: 0x1700A2E1 RID: 41697
		// (get) Token: 0x0602485B RID: 149595 RVA: 0x0050A597 File Offset: 0x00508797
		// (set) Token: 0x0602485C RID: 149596 RVA: 0x0050A59F File Offset: 0x0050879F
		public byte NullMask { get; set; }

		// Token: 0x0602485D RID: 149597 RVA: 0x0050A5A8 File Offset: 0x005087A8
		public INextSlideRailT()
		{
			this.TriggerKey = ETriggerKey.Left;
			this.TargetRailEntityId = 0;
			this.IsFallbackRail = false;
			this.NullMask = 0;
		}
	}
}
