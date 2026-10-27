using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565A RID: 22106
	public class INpcStandbyShowFinitelyT
	{
		// Token: 0x1700A3B8 RID: 41912
		// (get) Token: 0x06024C0B RID: 150539 RVA: 0x00512328 File Offset: 0x00510528
		// (set) Token: 0x06024C0C RID: 150540 RVA: 0x00512330 File Offset: 0x00510530
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700A3B9 RID: 41913
		// (get) Token: 0x06024C0D RID: 150541 RVA: 0x00512339 File Offset: 0x00510539
		// (set) Token: 0x06024C0E RID: 150542 RVA: 0x00512341 File Offset: 0x00510541
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700A3BA RID: 41914
		// (get) Token: 0x06024C0F RID: 150543 RVA: 0x0051234A File Offset: 0x0051054A
		// (set) Token: 0x06024C10 RID: 150544 RVA: 0x00512352 File Offset: 0x00510552
		public ENpcStandbyShowFinitelyPlayMode PlayMode { get; set; }

		// Token: 0x1700A3BB RID: 41915
		// (get) Token: 0x06024C11 RID: 150545 RVA: 0x0051235B File Offset: 0x0051055B
		// (set) Token: 0x06024C12 RID: 150546 RVA: 0x00512363 File Offset: 0x00510563
		public List<INpcStandbyShowFinitelyInfoT> Montages { get; set; }

		// Token: 0x1700A3BC RID: 41916
		// (get) Token: 0x06024C13 RID: 150547 RVA: 0x0051236C File Offset: 0x0051056C
		// (set) Token: 0x06024C14 RID: 150548 RVA: 0x00512374 File Offset: 0x00510574
		public byte NullMask { get; set; }

		// Token: 0x06024C15 RID: 150549 RVA: 0x0051237D File Offset: 0x0051057D
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
