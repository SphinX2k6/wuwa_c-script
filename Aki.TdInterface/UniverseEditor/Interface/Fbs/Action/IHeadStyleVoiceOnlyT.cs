using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D4 RID: 26836
	public class IHeadStyleVoiceOnlyT
	{
		// Token: 0x1700C71F RID: 50975
		// (get) Token: 0x0602ECEC RID: 191724 RVA: 0x006631C0 File Offset: 0x006613C0
		// (set) Token: 0x0602ECED RID: 191725 RVA: 0x006631C8 File Offset: 0x006613C8
		public EHeadStyle Type { get; set; }

		// Token: 0x1700C720 RID: 50976
		// (get) Token: 0x0602ECEE RID: 191726 RVA: 0x006631D1 File Offset: 0x006613D1
		// (set) Token: 0x0602ECEF RID: 191727 RVA: 0x006631D9 File Offset: 0x006613D9
		public int WhoId { get; set; }

		// Token: 0x0602ECF0 RID: 191728 RVA: 0x006631E2 File Offset: 0x006613E2
		public IHeadStyleVoiceOnlyT()
		{
			this.Type = EHeadStyle.Normal;
			this.WhoId = 0;
		}
	}
}
