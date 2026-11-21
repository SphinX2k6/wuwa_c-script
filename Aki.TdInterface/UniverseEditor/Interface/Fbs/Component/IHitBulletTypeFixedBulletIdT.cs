using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FE RID: 22782
	public class IHitBulletTypeFixedBulletIdT
	{
		// Token: 0x1700A53B RID: 42299
		// (get) Token: 0x0602504A RID: 151626 RVA: 0x00514A9F File Offset: 0x00512C9F
		// (set) Token: 0x0602504B RID: 151627 RVA: 0x00514AA7 File Offset: 0x00512CA7
		public EHitBulletType Type { get; set; }

		// Token: 0x1700A53C RID: 42300
		// (get) Token: 0x0602504C RID: 151628 RVA: 0x00514AB0 File Offset: 0x00512CB0
		// (set) Token: 0x0602504D RID: 151629 RVA: 0x00514AB8 File Offset: 0x00512CB8
		public List<long> BulletId { get; set; }

		// Token: 0x1700A53D RID: 42301
		// (get) Token: 0x0602504E RID: 151630 RVA: 0x00514AC1 File Offset: 0x00512CC1
		// (set) Token: 0x0602504F RID: 151631 RVA: 0x00514AC9 File Offset: 0x00512CC9
		public bool PlayerAttack { get; set; }

		// Token: 0x1700A53E RID: 42302
		// (get) Token: 0x06025050 RID: 151632 RVA: 0x00514AD2 File Offset: 0x00512CD2
		// (set) Token: 0x06025051 RID: 151633 RVA: 0x00514ADA File Offset: 0x00512CDA
		public byte NullMask { get; set; }

		// Token: 0x06025052 RID: 151634 RVA: 0x00514AE3 File Offset: 0x00512CE3
		public IHitBulletTypeFixedBulletIdT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
			this.BulletId = null;
			this.PlayerAttack = false;
			this.NullMask = 0;
		}
	}
}
