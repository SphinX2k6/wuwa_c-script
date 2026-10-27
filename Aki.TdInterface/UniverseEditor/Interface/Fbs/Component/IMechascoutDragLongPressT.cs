using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552E RID: 21806
	public class IMechascoutDragLongPressT
	{
		// Token: 0x1700A107 RID: 41223
		// (get) Token: 0x06024083 RID: 147587 RVA: 0x004FA850 File Offset: 0x004F8A50
		// (set) Token: 0x06024084 RID: 147588 RVA: 0x004FA858 File Offset: 0x004F8A58
		public EMechascoutDragType Type { get; set; }

		// Token: 0x1700A108 RID: 41224
		// (get) Token: 0x06024085 RID: 147589 RVA: 0x004FA861 File Offset: 0x004F8A61
		// (set) Token: 0x06024086 RID: 147590 RVA: 0x004FA869 File Offset: 0x004F8A69
		public float LongPressDuration { get; set; }

		// Token: 0x06024087 RID: 147591 RVA: 0x004FA872 File Offset: 0x004F8A72
		public IMechascoutDragLongPressT()
		{
			this.Type = EMechascoutDragType.Instant;
			this.LongPressDuration = 0f;
		}
	}
}
