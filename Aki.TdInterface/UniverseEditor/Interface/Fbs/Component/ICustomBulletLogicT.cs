using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005055 RID: 20565
	public class ICustomBulletLogicT
	{
		// Token: 0x17009537 RID: 38199
		// (get) Token: 0x06020F4F RID: 134991 RVA: 0x00494ABA File Offset: 0x00492CBA
		// (set) Token: 0x06020F50 RID: 134992 RVA: 0x00494AC2 File Offset: 0x00492CC2
		public ECustomBulletLogic Type { get; set; }

		// Token: 0x06020F51 RID: 134993 RVA: 0x00494ACB File Offset: 0x00492CCB
		public ICustomBulletLogicT()
		{
			this.Type = ECustomBulletLogic.TrafficBullet;
		}
	}
}
