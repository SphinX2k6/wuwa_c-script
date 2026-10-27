using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064CF RID: 25807
	public class IControlElementalBoxReturnT
	{
		// Token: 0x1700C010 RID: 49168
		// (get) Token: 0x0602CC50 RID: 183376 RVA: 0x006272CB File Offset: 0x006254CB
		// (set) Token: 0x0602CC51 RID: 183377 RVA: 0x006272D3 File Offset: 0x006254D3
		public EControlElementalBoxType Type { get; set; }

		// Token: 0x1700C011 RID: 49169
		// (get) Token: 0x0602CC52 RID: 183378 RVA: 0x006272DC File Offset: 0x006254DC
		// (set) Token: 0x0602CC53 RID: 183379 RVA: 0x006272E4 File Offset: 0x006254E4
		public string ReturnBeforeMoveSeq { get; set; }

		// Token: 0x0602CC54 RID: 183380 RVA: 0x006272ED File Offset: 0x006254ED
		public IControlElementalBoxReturnT()
		{
			this.Type = EControlElementalBoxType.Capture;
			this.ReturnBeforeMoveSeq = null;
		}
	}
}
