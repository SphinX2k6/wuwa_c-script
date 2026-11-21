using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB1 RID: 23217
	public class IMechascoutDragInstantT
	{
		// Token: 0x1700A93D RID: 43325
		// (get) Token: 0x06026129 RID: 155945 RVA: 0x0053778E File Offset: 0x0053598E
		// (set) Token: 0x0602612A RID: 155946 RVA: 0x00537796 File Offset: 0x00535996
		public EMechascoutDragType Type { get; set; }

		// Token: 0x0602612B RID: 155947 RVA: 0x0053779F File Offset: 0x0053599F
		public IMechascoutDragInstantT()
		{
			this.Type = EMechascoutDragType.Instant;
		}
	}
}
