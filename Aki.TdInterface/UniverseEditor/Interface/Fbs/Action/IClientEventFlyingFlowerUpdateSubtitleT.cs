using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0F RID: 27151
	public class IClientEventFlyingFlowerUpdateSubtitleT
	{
		// Token: 0x1700C7A5 RID: 51109
		// (get) Token: 0x0602E94F RID: 190799 RVA: 0x0065A58F File Offset: 0x0065878F
		// (set) Token: 0x0602E950 RID: 190800 RVA: 0x0065A597 File Offset: 0x00658797
		public EClientEventFlyingFlowerEventType Type { get; set; }

		// Token: 0x1700C7A6 RID: 51110
		// (get) Token: 0x0602E951 RID: 190801 RVA: 0x0065A5A0 File Offset: 0x006587A0
		// (set) Token: 0x0602E952 RID: 190802 RVA: 0x0065A5A8 File Offset: 0x006587A8
		public IPlayFlowT Flow { get; set; }

		// Token: 0x0602E953 RID: 190803 RVA: 0x0065A5B1 File Offset: 0x006587B1
		public IClientEventFlyingFlowerUpdateSubtitleT()
		{
			this.Type = EClientEventFlyingFlowerEventType.UpdateSubtitle;
			this.Flow = null;
		}
	}
}
