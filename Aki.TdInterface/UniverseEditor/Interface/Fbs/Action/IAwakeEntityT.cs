using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061CE RID: 25038
	public class IAwakeEntityT
	{
		// Token: 0x1700BAB5 RID: 47797
		// (get) Token: 0x0602B27C RID: 176764 RVA: 0x005F2EFC File Offset: 0x005F10FC
		// (set) Token: 0x0602B27D RID: 176765 RVA: 0x005F2F04 File Offset: 0x005F1104
		public IAwakeWithTransformVarT Position { get; set; }

		// Token: 0x1700BAB6 RID: 47798
		// (get) Token: 0x0602B27E RID: 176766 RVA: 0x005F2F0D File Offset: 0x005F110D
		// (set) Token: 0x0602B27F RID: 176767 RVA: 0x005F2F15 File Offset: 0x005F1115
		public bool IsSnap { get; set; }

		// Token: 0x1700BAB7 RID: 47799
		// (get) Token: 0x0602B280 RID: 176768 RVA: 0x005F2F1E File Offset: 0x005F111E
		// (set) Token: 0x0602B281 RID: 176769 RVA: 0x005F2F26 File Offset: 0x005F1126
		public List<int> EntityIds { get; set; }

		// Token: 0x1700BAB8 RID: 47800
		// (get) Token: 0x0602B282 RID: 176770 RVA: 0x005F2F2F File Offset: 0x005F112F
		// (set) Token: 0x0602B283 RID: 176771 RVA: 0x005F2F37 File Offset: 0x005F1137
		public byte NullMask { get; set; }

		// Token: 0x0602B284 RID: 176772 RVA: 0x005F2F40 File Offset: 0x005F1140
		public IAwakeEntityT()
		{
			this.Position = null;
			this.IsSnap = false;
			this.EntityIds = null;
			this.NullMask = 0;
		}
	}
}
