using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200644F RID: 25679
	public class ICollectibleMarkerTypeT
	{
		// Token: 0x1700BF29 RID: 48937
		// (get) Token: 0x0602C718 RID: 182040 RVA: 0x006189DA File Offset: 0x00616BDA
		// (set) Token: 0x0602C719 RID: 182041 RVA: 0x006189E2 File Offset: 0x00616BE2
		public ECollectibleMarkerType Type { get; set; }

		// Token: 0x0602C71A RID: 182042 RVA: 0x006189EB File Offset: 0x00616BEB
		public ICollectibleMarkerTypeT()
		{
			this.Type = ECollectibleMarkerType.Placeholder;
		}
	}
}
