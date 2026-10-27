using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005531 RID: 21809
	public class IMechascoutDragTypeBaseT
	{
		// Token: 0x1700A10B RID: 41227
		// (get) Token: 0x06024097 RID: 147607 RVA: 0x004FA9F2 File Offset: 0x004F8BF2
		// (set) Token: 0x06024098 RID: 147608 RVA: 0x004FA9FA File Offset: 0x004F8BFA
		public EMechascoutDragType Type { get; set; }

		// Token: 0x06024099 RID: 147609 RVA: 0x004FAA03 File Offset: 0x004F8C03
		public IMechascoutDragTypeBaseT()
		{
			this.Type = EMechascoutDragType.Instant;
		}
	}
}
