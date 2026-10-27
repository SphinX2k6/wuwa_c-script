using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064DE RID: 25822
	public class IControlTrackingTypeT
	{
		// Token: 0x1700C021 RID: 49185
		// (get) Token: 0x0602CCB4 RID: 183476 RVA: 0x00627BCA File Offset: 0x00625DCA
		// (set) Token: 0x0602CCB5 RID: 183477 RVA: 0x00627BD2 File Offset: 0x00625DD2
		public EControlTrackingType Type { get; set; }

		// Token: 0x0602CCB6 RID: 183478 RVA: 0x00627BDB File Offset: 0x00625DDB
		public IControlTrackingTypeT()
		{
			this.Type = EControlTrackingType.Self;
		}
	}
}
