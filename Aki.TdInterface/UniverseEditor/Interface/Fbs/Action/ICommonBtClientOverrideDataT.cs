using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC8 RID: 27336
	public class ICommonBtClientOverrideDataT
	{
		// Token: 0x1700C8BD RID: 51389
		// (get) Token: 0x0602EEC3 RID: 192195 RVA: 0x006643DF File Offset: 0x006625DF
		// (set) Token: 0x0602EEC4 RID: 192196 RVA: 0x006643E7 File Offset: 0x006625E7
		public int TaskId { get; set; }

		// Token: 0x1700C8BE RID: 51390
		// (get) Token: 0x0602EEC5 RID: 192197 RVA: 0x006643F0 File Offset: 0x006625F0
		// (set) Token: 0x0602EEC6 RID: 192198 RVA: 0x006643F8 File Offset: 0x006625F8
		public string Data { get; set; }

		// Token: 0x0602EEC7 RID: 192199 RVA: 0x00664401 File Offset: 0x00662601
		public ICommonBtClientOverrideDataT()
		{
			this.TaskId = 0;
			this.Data = null;
		}
	}
}
