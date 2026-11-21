using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C15 RID: 27669
	public class IDestroyVisionDisplayT
	{
		// Token: 0x1700CAD4 RID: 51924
		// (get) Token: 0x0602F9F3 RID: 195059 RVA: 0x0067D306 File Offset: 0x0067B506
		// (set) Token: 0x0602F9F4 RID: 195060 RVA: 0x0067D30E File Offset: 0x0067B50E
		public EDynamicEntityType Type { get; set; }

		// Token: 0x0602F9F5 RID: 195061 RVA: 0x0067D317 File Offset: 0x0067B517
		public IDestroyVisionDisplayT()
		{
			this.Type = EDynamicEntityType.VisionDisplay;
		}
	}
}
