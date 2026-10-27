using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A5 RID: 22949
	public class IStateConfigT
	{
		// Token: 0x1700AC3D RID: 44093
		// (get) Token: 0x06026E0C RID: 159244 RVA: 0x00559A2B File Offset: 0x00557C2B
		// (set) Token: 0x06026E0D RID: 159245 RVA: 0x00559A33 File Offset: 0x00557C33
		public string State { get; set; }

		// Token: 0x1700AC3E RID: 44094
		// (get) Token: 0x06026E0E RID: 159246 RVA: 0x00559A3C File Offset: 0x00557C3C
		// (set) Token: 0x06026E0F RID: 159247 RVA: 0x00559A44 File Offset: 0x00557C44
		public float Duration { get; set; }

		// Token: 0x06026E10 RID: 159248 RVA: 0x00559A4D File Offset: 0x00557C4D
		public IStateConfigT()
		{
			this.State = null;
			this.Duration = 0f;
		}
	}
}
