using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065AD RID: 26029
	public class IDestroyVisionDisplayT
	{
		// Token: 0x1700C145 RID: 49477
		// (get) Token: 0x0602D26F RID: 184943 RVA: 0x00631142 File Offset: 0x0062F342
		// (set) Token: 0x0602D270 RID: 184944 RVA: 0x0063114A File Offset: 0x0062F34A
		public EDynamicEntityType Type { get; set; }

		// Token: 0x0602D271 RID: 184945 RVA: 0x00631153 File Offset: 0x0062F353
		public IDestroyVisionDisplayT()
		{
			this.Type = EDynamicEntityType.VisionDisplay;
		}
	}
}
