using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ECA RID: 16074
	public class IKillMonsterT
	{
		// Token: 0x17006F9C RID: 28572
		// (get) Token: 0x06016BBF RID: 93119 RVA: 0x003485E5 File Offset: 0x003467E5
		// (set) Token: 0x06016BC0 RID: 93120 RVA: 0x003485ED File Offset: 0x003467ED
		public int NormalAddTime { get; set; }

		// Token: 0x17006F9D RID: 28573
		// (get) Token: 0x06016BC1 RID: 93121 RVA: 0x003485F6 File Offset: 0x003467F6
		// (set) Token: 0x06016BC2 RID: 93122 RVA: 0x003485FE File Offset: 0x003467FE
		public List<IKillSingleMonsterT> SpecialTime { get; set; }

		// Token: 0x17006F9E RID: 28574
		// (get) Token: 0x06016BC3 RID: 93123 RVA: 0x00348607 File Offset: 0x00346807
		// (set) Token: 0x06016BC4 RID: 93124 RVA: 0x0034860F File Offset: 0x0034680F
		public byte NullMask { get; set; }

		// Token: 0x06016BC5 RID: 93125 RVA: 0x00348618 File Offset: 0x00346818
		public IKillMonsterT()
		{
			this.NormalAddTime = 0;
			this.SpecialTime = null;
			this.NullMask = 0;
		}
	}
}
