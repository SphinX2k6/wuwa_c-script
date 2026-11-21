using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB7 RID: 23223
	public class IMechascoutDragTypeBaseT
	{
		// Token: 0x1700A945 RID: 43333
		// (get) Token: 0x06026151 RID: 155985 RVA: 0x00537B16 File Offset: 0x00535D16
		// (set) Token: 0x06026152 RID: 155986 RVA: 0x00537B1E File Offset: 0x00535D1E
		public EMechascoutDragType Type { get; set; }

		// Token: 0x06026153 RID: 155987 RVA: 0x00537B27 File Offset: 0x00535D27
		public IMechascoutDragTypeBaseT()
		{
			this.Type = EMechascoutDragType.Instant;
		}
	}
}
