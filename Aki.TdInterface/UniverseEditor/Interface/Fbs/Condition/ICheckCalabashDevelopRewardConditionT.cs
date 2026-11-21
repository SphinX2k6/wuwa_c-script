using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E49 RID: 20041
	public class ICheckCalabashDevelopRewardConditionT
	{
		// Token: 0x17008ECA RID: 36554
		// (get) Token: 0x0601F017 RID: 126999 RVA: 0x00454486 File Offset: 0x00452686
		// (set) Token: 0x0601F018 RID: 127000 RVA: 0x0045448E File Offset: 0x0045268E
		public ECondition Type { get; set; }

		// Token: 0x17008ECB RID: 36555
		// (get) Token: 0x0601F019 RID: 127001 RVA: 0x00454497 File Offset: 0x00452697
		// (set) Token: 0x0601F01A RID: 127002 RVA: 0x0045449F File Offset: 0x0045269F
		public int MonsterId { get; set; }

		// Token: 0x17008ECC RID: 36556
		// (get) Token: 0x0601F01B RID: 127003 RVA: 0x004544A8 File Offset: 0x004526A8
		// (set) Token: 0x0601F01C RID: 127004 RVA: 0x004544B0 File Offset: 0x004526B0
		public ECalabashDevelop Develop { get; set; }

		// Token: 0x0601F01D RID: 127005 RVA: 0x004544B9 File Offset: 0x004526B9
		public ICheckCalabashDevelopRewardConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.MonsterId = 0;
			this.Develop = ECalabashDevelop.None;
		}
	}
}
