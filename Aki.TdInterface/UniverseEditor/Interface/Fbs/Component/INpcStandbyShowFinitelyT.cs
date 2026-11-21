using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BFB RID: 23547
	public class INpcStandbyShowFinitelyT
	{
		// Token: 0x1700AC47 RID: 44103
		// (get) Token: 0x06026E44 RID: 159300 RVA: 0x00552EC4 File Offset: 0x005510C4
		// (set) Token: 0x06026E45 RID: 159301 RVA: 0x00552ECC File Offset: 0x005510CC
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700AC48 RID: 44104
		// (get) Token: 0x06026E46 RID: 159302 RVA: 0x00552ED5 File Offset: 0x005510D5
		// (set) Token: 0x06026E47 RID: 159303 RVA: 0x00552EDD File Offset: 0x005510DD
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700AC49 RID: 44105
		// (get) Token: 0x06026E48 RID: 159304 RVA: 0x00552EE6 File Offset: 0x005510E6
		// (set) Token: 0x06026E49 RID: 159305 RVA: 0x00552EEE File Offset: 0x005510EE
		public ENpcStandbyShowFinitelyPlayMode PlayMode { get; set; }

		// Token: 0x1700AC4A RID: 44106
		// (get) Token: 0x06026E4A RID: 159306 RVA: 0x00552EF7 File Offset: 0x005510F7
		// (set) Token: 0x06026E4B RID: 159307 RVA: 0x00552EFF File Offset: 0x005510FF
		public List<INpcStandbyShowFinitelyInfoT> Montages { get; set; }

		// Token: 0x1700AC4B RID: 44107
		// (get) Token: 0x06026E4C RID: 159308 RVA: 0x00552F08 File Offset: 0x00551108
		// (set) Token: 0x06026E4D RID: 159309 RVA: 0x00552F10 File Offset: 0x00551110
		public byte NullMask { get; set; }

		// Token: 0x06026E4E RID: 159310 RVA: 0x00552F19 File Offset: 0x00551119
		public INpcStandbyShowFinitelyT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.PlayMode = ENpcStandbyShowFinitelyPlayMode.Randomly;
			this.Montages = null;
			this.NullMask = 0;
		}
	}
}
