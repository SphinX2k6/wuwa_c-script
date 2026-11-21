using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A81 RID: 23169
	public class ILifeStageConfigT
	{
		// Token: 0x1700A8C5 RID: 43205
		// (get) Token: 0x06025F5B RID: 155483 RVA: 0x0053424C File Offset: 0x0053244C
		// (set) Token: 0x06025F5C RID: 155484 RVA: 0x00534254 File Offset: 0x00532454
		public float PerformDuration { get; set; }

		// Token: 0x1700A8C6 RID: 43206
		// (get) Token: 0x06025F5D RID: 155485 RVA: 0x0053425D File Offset: 0x0053245D
		// (set) Token: 0x06025F5E RID: 155486 RVA: 0x00534265 File Offset: 0x00532465
		public byte NullMask { get; set; }

		// Token: 0x06025F5F RID: 155487 RVA: 0x0053426E File Offset: 0x0053246E
		public ILifeStageConfigT()
		{
			this.PerformDuration = 0f;
			this.NullMask = 0;
		}
	}
}
