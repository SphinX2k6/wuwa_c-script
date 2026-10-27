using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005868 RID: 22632
	public class IRewardComponentT
	{
		// Token: 0x1700A943 RID: 43331
		// (get) Token: 0x0602620F RID: 156175 RVA: 0x00541F2E File Offset: 0x0054012E
		// (set) Token: 0x06026210 RID: 156176 RVA: 0x00541F36 File Offset: 0x00540136
		public bool Disabled { get; set; }

		// Token: 0x1700A944 RID: 43332
		// (get) Token: 0x06026211 RID: 156177 RVA: 0x00541F3F File Offset: 0x0054013F
		// (set) Token: 0x06026212 RID: 156178 RVA: 0x00541F47 File Offset: 0x00540147
		public int RewardId { get; set; }

		// Token: 0x1700A945 RID: 43333
		// (get) Token: 0x06026213 RID: 156179 RVA: 0x00541F50 File Offset: 0x00540150
		// (set) Token: 0x06026214 RID: 156180 RVA: 0x00541F58 File Offset: 0x00540158
		public ERewardType RewardType { get; set; }

		// Token: 0x1700A946 RID: 43334
		// (get) Token: 0x06026215 RID: 156181 RVA: 0x00541F61 File Offset: 0x00540161
		// (set) Token: 0x06026216 RID: 156182 RVA: 0x00541F69 File Offset: 0x00540169
		public EDropEvent DropOnEvent { get; set; }

		// Token: 0x1700A947 RID: 43335
		// (get) Token: 0x06026217 RID: 156183 RVA: 0x00541F72 File Offset: 0x00540172
		// (set) Token: 0x06026218 RID: 156184 RVA: 0x00541F7A File Offset: 0x0054017A
		public IRewardRefreshConfigT RefreshConfig { get; set; }

		// Token: 0x1700A948 RID: 43336
		// (get) Token: 0x06026219 RID: 156185 RVA: 0x00541F83 File Offset: 0x00540183
		// (set) Token: 0x0602621A RID: 156186 RVA: 0x00541F8B File Offset: 0x0054018B
		public List<int> RewardIdList { get; set; }

		// Token: 0x1700A949 RID: 43337
		// (get) Token: 0x0602621B RID: 156187 RVA: 0x00541F94 File Offset: 0x00540194
		// (set) Token: 0x0602621C RID: 156188 RVA: 0x00541F9C File Offset: 0x0054019C
		public byte NullMask { get; set; }

		// Token: 0x0602621D RID: 156189 RVA: 0x00541FA5 File Offset: 0x005401A5
		public IRewardComponentT()
		{
			this.Disabled = false;
			this.RewardId = 0;
			this.RewardType = ERewardType.Nearby;
			this.DropOnEvent = EDropEvent.All;
			this.RefreshConfig = null;
			this.RewardIdList = null;
			this.NullMask = 0;
		}
	}
}
