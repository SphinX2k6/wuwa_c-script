using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200743A RID: 29754
	public class IPhotographicTipT
	{
		// Token: 0x1700DA88 RID: 55944
		// (get) Token: 0x06034100 RID: 213248 RVA: 0x00704073 File Offset: 0x00702273
		// (set) Token: 0x06034101 RID: 213249 RVA: 0x0070407B File Offset: 0x0070227B
		public ECommonTipType Type { get; set; }

		// Token: 0x1700DA89 RID: 55945
		// (get) Token: 0x06034102 RID: 213250 RVA: 0x00704084 File Offset: 0x00702284
		// (set) Token: 0x06034103 RID: 213251 RVA: 0x0070408C File Offset: 0x0070228C
		public string MainText { get; set; }

		// Token: 0x06034104 RID: 213252 RVA: 0x00704095 File Offset: 0x00702295
		public IPhotographicTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.MainText = null;
		}
	}
}
