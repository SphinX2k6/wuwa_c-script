using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200433B RID: 17211
	public class ILevelPlayInformationViewT
	{
		// Token: 0x170075CA RID: 30154
		// (get) Token: 0x06018385 RID: 99205 RVA: 0x00373DB7 File Offset: 0x00371FB7
		// (set) Token: 0x06018386 RID: 99206 RVA: 0x00373DBF File Offset: 0x00371FBF
		public EInformationViewType Type { get; set; }

		// Token: 0x170075CB RID: 30155
		// (get) Token: 0x06018387 RID: 99207 RVA: 0x00373DC8 File Offset: 0x00371FC8
		// (set) Token: 0x06018388 RID: 99208 RVA: 0x00373DD0 File Offset: 0x00371FD0
		public List<ILevelPlayInformationT> InformationConfig { get; set; }

		// Token: 0x06018389 RID: 99209 RVA: 0x00373DD9 File Offset: 0x00371FD9
		public ILevelPlayInformationViewT()
		{
			this.Type = EInformationViewType.LevelPlay;
			this.InformationConfig = null;
		}
	}
}
