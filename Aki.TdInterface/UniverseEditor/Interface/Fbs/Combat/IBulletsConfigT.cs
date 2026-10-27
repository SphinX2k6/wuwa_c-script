using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Combat
{
	// Token: 0x02005EEE RID: 24302
	public class IBulletsConfigT
	{
		// Token: 0x1700B5B3 RID: 46515
		// (get) Token: 0x06029BCE RID: 170958 RVA: 0x005BA531 File Offset: 0x005B8731
		// (set) Token: 0x06029BCF RID: 170959 RVA: 0x005BA539 File Offset: 0x005B8739
		public List<IBulletConfigT> Bullets { get; set; }

		// Token: 0x06029BD0 RID: 170960 RVA: 0x005BA542 File Offset: 0x005B8742
		public IBulletsConfigT()
		{
			this.Bullets = null;
		}
	}
}
