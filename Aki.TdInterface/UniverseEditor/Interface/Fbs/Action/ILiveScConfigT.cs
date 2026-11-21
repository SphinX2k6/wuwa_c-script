using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200711C RID: 28956
	public class ILiveScConfigT
	{
		// Token: 0x1700D411 RID: 54289
		// (get) Token: 0x060324D9 RID: 206041 RVA: 0x006CD3BC File Offset: 0x006CB5BC
		// (set) Token: 0x060324DA RID: 206042 RVA: 0x006CD3C4 File Offset: 0x006CB5C4
		public int ScId { get; set; }

		// Token: 0x1700D412 RID: 54290
		// (get) Token: 0x060324DB RID: 206043 RVA: 0x006CD3CD File Offset: 0x006CB5CD
		// (set) Token: 0x060324DC RID: 206044 RVA: 0x006CD3D5 File Offset: 0x006CB5D5
		public float DelayTime { get; set; }

		// Token: 0x060324DD RID: 206045 RVA: 0x006CD3DE File Offset: 0x006CB5DE
		public ILiveScConfigT()
		{
			this.ScId = 0;
			this.DelayTime = 0f;
		}
	}
}
