using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B7 RID: 21943
	public class ICustomBulletLogicT
	{
		// Token: 0x17009D1D RID: 40221
		// (get) Token: 0x06022E89 RID: 142985 RVA: 0x004CE76E File Offset: 0x004CC96E
		// (set) Token: 0x06022E8A RID: 142986 RVA: 0x004CE776 File Offset: 0x004CC976
		public ECustomBulletLogic Type { get; set; }

		// Token: 0x06022E8B RID: 142987 RVA: 0x004CE77F File Offset: 0x004CC97F
		public ICustomBulletLogicT()
		{
			this.Type = ECustomBulletLogic.TrafficBullet;
		}
	}
}
