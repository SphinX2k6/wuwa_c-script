using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E40 RID: 28224
	public class IFireBulletTypeT
	{
		// Token: 0x1700CEE5 RID: 52965
		// (get) Token: 0x06030C11 RID: 199697 RVA: 0x0069E0CE File Offset: 0x0069C2CE
		// (set) Token: 0x06030C12 RID: 199698 RVA: 0x0069E0D6 File Offset: 0x0069C2D6
		public EFireBulletType Type { get; set; }

		// Token: 0x06030C13 RID: 199699 RVA: 0x0069E0DF File Offset: 0x0069C2DF
		public IFireBulletTypeT()
		{
			this.Type = EFireBulletType.TrackTarget;
		}
	}
}
