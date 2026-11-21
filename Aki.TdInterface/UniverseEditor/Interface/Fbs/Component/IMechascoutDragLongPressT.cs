using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB4 RID: 23220
	public class IMechascoutDragLongPressT
	{
		// Token: 0x1700A941 RID: 43329
		// (get) Token: 0x0602613D RID: 155965 RVA: 0x00537974 File Offset: 0x00535B74
		// (set) Token: 0x0602613E RID: 155966 RVA: 0x0053797C File Offset: 0x00535B7C
		public EMechascoutDragType Type { get; set; }

		// Token: 0x1700A942 RID: 43330
		// (get) Token: 0x0602613F RID: 155967 RVA: 0x00537985 File Offset: 0x00535B85
		// (set) Token: 0x06026140 RID: 155968 RVA: 0x0053798D File Offset: 0x00535B8D
		public float LongPressDuration { get; set; }

		// Token: 0x06026141 RID: 155969 RVA: 0x00537996 File Offset: 0x00535B96
		public IMechascoutDragLongPressT()
		{
			this.Type = EMechascoutDragType.Instant;
			this.LongPressDuration = 0f;
		}
	}
}
