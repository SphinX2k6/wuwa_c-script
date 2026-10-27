using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005040 RID: 20544
	public class ICreateBulletConfigT
	{
		// Token: 0x17009514 RID: 38164
		// (get) Token: 0x06020EB3 RID: 134835 RVA: 0x00493A28 File Offset: 0x00491C28
		// (set) Token: 0x06020EB4 RID: 134836 RVA: 0x00493A30 File Offset: 0x00491C30
		public long BulletId { get; set; }

		// Token: 0x17009515 RID: 38165
		// (get) Token: 0x06020EB5 RID: 134837 RVA: 0x00493A39 File Offset: 0x00491C39
		// (set) Token: 0x06020EB6 RID: 134838 RVA: 0x00493A41 File Offset: 0x00491C41
		public float Delay { get; set; }

		// Token: 0x06020EB7 RID: 134839 RVA: 0x00493A4A File Offset: 0x00491C4A
		public ICreateBulletConfigT()
		{
			this.BulletId = 0L;
			this.Delay = 0f;
		}
	}
}
