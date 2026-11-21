using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FB RID: 22779
	public class IHitBulletTypeCrystalAttackT
	{
		// Token: 0x1700A534 RID: 42292
		// (get) Token: 0x06025028 RID: 151592 RVA: 0x00514687 File Offset: 0x00512887
		// (set) Token: 0x06025029 RID: 151593 RVA: 0x0051468F File Offset: 0x0051288F
		public EHitBulletType Type { get; set; }

		// Token: 0x1700A535 RID: 42293
		// (get) Token: 0x0602502A RID: 151594 RVA: 0x00514698 File Offset: 0x00512898
		// (set) Token: 0x0602502B RID: 151595 RVA: 0x005146A0 File Offset: 0x005128A0
		public IVectorInfoT TrackOffset { get; set; }

		// Token: 0x0602502C RID: 151596 RVA: 0x005146A9 File Offset: 0x005128A9
		public IHitBulletTypeCrystalAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
			this.TrackOffset = null;
		}
	}
}
