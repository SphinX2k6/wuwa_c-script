using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A09 RID: 27145
	public class IClientEventFlyingFlowerEventT
	{
		// Token: 0x1700C79F RID: 51103
		// (get) Token: 0x0602E92F RID: 190767 RVA: 0x0065A24E File Offset: 0x0065844E
		// (set) Token: 0x0602E930 RID: 190768 RVA: 0x0065A256 File Offset: 0x00658456
		public EClientEventFlyingFlowerEventType Type { get; set; }

		// Token: 0x0602E931 RID: 190769 RVA: 0x0065A25F File Offset: 0x0065845F
		public IClientEventFlyingFlowerEventT()
		{
			this.Type = EClientEventFlyingFlowerEventType.UpdateSubtitle;
		}
	}
}
