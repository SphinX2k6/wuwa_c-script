using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559F RID: 21919
	public class ICreateBulletConfigT
	{
		// Token: 0x17009CF5 RID: 40181
		// (get) Token: 0x06022DD3 RID: 142803 RVA: 0x004CD478 File Offset: 0x004CB678
		// (set) Token: 0x06022DD4 RID: 142804 RVA: 0x004CD480 File Offset: 0x004CB680
		public long BulletId { get; set; }

		// Token: 0x17009CF6 RID: 40182
		// (get) Token: 0x06022DD5 RID: 142805 RVA: 0x004CD489 File Offset: 0x004CB689
		// (set) Token: 0x06022DD6 RID: 142806 RVA: 0x004CD491 File Offset: 0x004CB691
		public float Delay { get; set; }

		// Token: 0x06022DD7 RID: 142807 RVA: 0x004CD49A File Offset: 0x004CB69A
		public ICreateBulletConfigT()
		{
			this.BulletId = 0L;
			this.Delay = 0f;
		}
	}
}
