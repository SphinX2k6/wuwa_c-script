using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD3 RID: 27859
	public class IPlaceholderCollectibleMarkerTypeT
	{
		// Token: 0x1700CF69 RID: 53097
		// (get) Token: 0x060311A5 RID: 201125 RVA: 0x006A9B16 File Offset: 0x006A7D16
		// (set) Token: 0x060311A6 RID: 201126 RVA: 0x006A9B1E File Offset: 0x006A7D1E
		public ECollectibleMarkerType Type { get; set; }

		// Token: 0x060311A7 RID: 201127 RVA: 0x006A9B27 File Offset: 0x006A7D27
		public IPlaceholderCollectibleMarkerTypeT()
		{
			this.Type = ECollectibleMarkerType.Placeholder;
		}
	}
}
