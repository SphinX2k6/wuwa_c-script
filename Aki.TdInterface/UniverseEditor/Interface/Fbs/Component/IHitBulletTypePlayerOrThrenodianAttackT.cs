using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005907 RID: 22791
	public class IHitBulletTypePlayerOrThrenodianAttackT
	{
		// Token: 0x1700A547 RID: 42311
		// (get) Token: 0x06025086 RID: 151686 RVA: 0x00514F86 File Offset: 0x00513186
		// (set) Token: 0x06025087 RID: 151687 RVA: 0x00514F8E File Offset: 0x0051318E
		public EHitBulletType Type { get; set; }

		// Token: 0x06025088 RID: 151688 RVA: 0x00514F97 File Offset: 0x00513197
		public IHitBulletTypePlayerOrThrenodianAttackT()
		{
			this.Type = EHitBulletType.OnlyDropAttack;
		}
	}
}
