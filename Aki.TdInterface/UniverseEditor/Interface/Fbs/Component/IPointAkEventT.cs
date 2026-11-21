using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D53 RID: 23891
	public class IPointAkEventT
	{
		// Token: 0x1700AFE1 RID: 45025
		// (get) Token: 0x06027C57 RID: 162903 RVA: 0x00571135 File Offset: 0x0056F335
		// (set) Token: 0x06027C58 RID: 162904 RVA: 0x0057113D File Offset: 0x0056F33D
		public EAkEventType Type { get; set; }

		// Token: 0x1700AFE2 RID: 45026
		// (get) Token: 0x06027C59 RID: 162905 RVA: 0x00571146 File Offset: 0x0056F346
		// (set) Token: 0x06027C5A RID: 162906 RVA: 0x0057114E File Offset: 0x0056F34E
		public List<int> PointIds { get; set; }

		// Token: 0x1700AFE3 RID: 45027
		// (get) Token: 0x06027C5B RID: 162907 RVA: 0x00571157 File Offset: 0x0056F357
		// (set) Token: 0x06027C5C RID: 162908 RVA: 0x0057115F File Offset: 0x0056F35F
		public bool UseListenerCone { get; set; }

		// Token: 0x1700AFE4 RID: 45028
		// (get) Token: 0x06027C5D RID: 162909 RVA: 0x00571168 File Offset: 0x0056F368
		// (set) Token: 0x06027C5E RID: 162910 RVA: 0x00571170 File Offset: 0x0056F370
		public bool EnableOcclusion { get; set; }

		// Token: 0x1700AFE5 RID: 45029
		// (get) Token: 0x06027C5F RID: 162911 RVA: 0x00571179 File Offset: 0x0056F379
		// (set) Token: 0x06027C60 RID: 162912 RVA: 0x00571181 File Offset: 0x0056F381
		public byte NullMask { get; set; }

		// Token: 0x06027C61 RID: 162913 RVA: 0x0057118A File Offset: 0x0056F38A
		public IPointAkEventT()
		{
			this.Type = EAkEventType.Point;
			this.PointIds = null;
			this.UseListenerCone = false;
			this.EnableOcclusion = false;
			this.NullMask = 0;
		}
	}
}
