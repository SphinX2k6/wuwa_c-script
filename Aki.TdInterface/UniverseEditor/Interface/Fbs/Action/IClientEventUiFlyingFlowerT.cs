using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A27 RID: 27175
	public class IClientEventUiFlyingFlowerT
	{
		// Token: 0x1700C7C1 RID: 51137
		// (get) Token: 0x0602E9E3 RID: 190947 RVA: 0x0065B3A7 File Offset: 0x006595A7
		// (set) Token: 0x0602E9E4 RID: 190948 RVA: 0x0065B3AF File Offset: 0x006595AF
		public EClientEventUiType Type { get; set; }

		// Token: 0x1700C7C2 RID: 51138
		// (get) Token: 0x0602E9E5 RID: 190949 RVA: 0x0065B3B8 File Offset: 0x006595B8
		// (set) Token: 0x0602E9E6 RID: 190950 RVA: 0x0065B3C0 File Offset: 0x006595C0
		public IClientEventFlyingFlowerUpdateSubtitleT EventType { get; set; }

		// Token: 0x0602E9E7 RID: 190951 RVA: 0x0065B3C9 File Offset: 0x006595C9
		public IClientEventUiFlyingFlowerT()
		{
			this.Type = EClientEventUiType.PlayPiano;
			this.EventType = null;
		}
	}
}
