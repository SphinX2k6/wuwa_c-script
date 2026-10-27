using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064DB RID: 25819
	public class IControlTrackingSelfT
	{
		// Token: 0x1700C01E RID: 49182
		// (get) Token: 0x0602CCA2 RID: 183458 RVA: 0x00627A52 File Offset: 0x00625C52
		// (set) Token: 0x0602CCA3 RID: 183459 RVA: 0x00627A5A File Offset: 0x00625C5A
		public EControlTrackingType Type { get; set; }

		// Token: 0x0602CCA4 RID: 183460 RVA: 0x00627A63 File Offset: 0x00625C63
		public IControlTrackingSelfT()
		{
			this.Type = EControlTrackingType.Self;
		}
	}
}
