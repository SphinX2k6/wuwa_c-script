using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C0 RID: 26560
	public class IFireBulletTypeT
	{
		// Token: 0x1700C52F RID: 50479
		// (get) Token: 0x0602E3CB RID: 189387 RVA: 0x0065098A File Offset: 0x0064EB8A
		// (set) Token: 0x0602E3CC RID: 189388 RVA: 0x00650992 File Offset: 0x0064EB92
		public EFireBulletType Type { get; set; }

		// Token: 0x0602E3CD RID: 189389 RVA: 0x0065099B File Offset: 0x0064EB9B
		public IFireBulletTypeT()
		{
			this.Type = EFireBulletType.TrackTarget;
		}
	}
}
