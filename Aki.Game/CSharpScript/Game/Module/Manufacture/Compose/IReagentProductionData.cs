using System;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004636 RID: 17974
	public class IReagentProductionData : IBaseItemData
	{
		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x0602D307 RID: 185095 RVA: 0x00CA35BF File Offset: 0x00CA17BF
		// (set) Token: 0x0602D308 RID: 185096 RVA: 0x00CA35C7 File Offset: 0x00CA17C7
		public ESubComposeDataType SubType { get; set; }

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x0602D309 RID: 185097 RVA: 0x00CA35D0 File Offset: 0x00CA17D0
		// (set) Token: 0x0602D30A RID: 185098 RVA: 0x00CA35D8 File Offset: 0x00CA17D8
		public int UniqueId { get; set; }

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x0602D30B RID: 185099 RVA: 0x00CA35E1 File Offset: 0x00CA17E1
		// (set) Token: 0x0602D30C RID: 185100 RVA: 0x00CA35E9 File Offset: 0x00CA17E9
		public int ComposeCount { get; set; }

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x0602D30D RID: 185101 RVA: 0x00CA35F2 File Offset: 0x00CA17F2
		// (set) Token: 0x0602D30E RID: 185102 RVA: 0x00CA35FA File Offset: 0x00CA17FA
		public int LastRoleId { get; set; }

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x0602D30F RID: 185103 RVA: 0x00CA3603 File Offset: 0x00CA1803
		// (set) Token: 0x0602D310 RID: 185104 RVA: 0x00CA360B File Offset: 0x00CA180B
		public int EffectType { get; set; }
	}
}
