using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073FE RID: 29694
	public class IPermanentRogueRandomEventT
	{
		// Token: 0x1700DA1F RID: 55839
		// (get) Token: 0x06033F38 RID: 212792 RVA: 0x00700FF9 File Offset: 0x006FF1F9
		// (set) Token: 0x06033F39 RID: 212793 RVA: 0x00701001 File Offset: 0x006FF201
		public ESystemOptionType Type { get; set; }

		// Token: 0x1700DA20 RID: 55840
		// (get) Token: 0x06033F3A RID: 212794 RVA: 0x0070100A File Offset: 0x006FF20A
		// (set) Token: 0x06033F3B RID: 212795 RVA: 0x00701012 File Offset: 0x006FF212
		public List<ISystemOptionT> SystemOptions { get; set; }

		// Token: 0x1700DA21 RID: 55841
		// (get) Token: 0x06033F3C RID: 212796 RVA: 0x0070101B File Offset: 0x006FF21B
		// (set) Token: 0x06033F3D RID: 212797 RVA: 0x00701023 File Offset: 0x006FF223
		public bool KeepPreTalkItem { get; set; }

		// Token: 0x1700DA22 RID: 55842
		// (get) Token: 0x06033F3E RID: 212798 RVA: 0x0070102C File Offset: 0x006FF22C
		// (set) Token: 0x06033F3F RID: 212799 RVA: 0x00701034 File Offset: 0x006FF234
		public int EventId { get; set; }

		// Token: 0x1700DA23 RID: 55843
		// (get) Token: 0x06033F40 RID: 212800 RVA: 0x0070103D File Offset: 0x006FF23D
		// (set) Token: 0x06033F41 RID: 212801 RVA: 0x00701045 File Offset: 0x006FF245
		public byte NullMask { get; set; }

		// Token: 0x06033F42 RID: 212802 RVA: 0x0070104E File Offset: 0x006FF24E
		public IPermanentRogueRandomEventT()
		{
			this.Type = ESystemOptionType.RogueRandomEvent;
			this.SystemOptions = null;
			this.KeepPreTalkItem = false;
			this.EventId = 0;
			this.NullMask = 0;
		}
	}
}
