using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006075 RID: 24693
	public class IThrowMotionT
	{
		// Token: 0x1700B763 RID: 46947
		// (get) Token: 0x06029BA9 RID: 170921 RVA: 0x005B28C6 File Offset: 0x005B0AC6
		// (set) Token: 0x06029BAA RID: 170922 RVA: 0x005B28CE File Offset: 0x005B0ACE
		public EThrowMotion Type { get; set; }

		// Token: 0x06029BAB RID: 170923 RVA: 0x005B28D7 File Offset: 0x005B0AD7
		public IThrowMotionT()
		{
			this.Type = EThrowMotion.Projectile;
		}
	}
}
