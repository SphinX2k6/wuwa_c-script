using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051B8 RID: 20920
	public class ISeasonAndWeatherT
	{
		// Token: 0x170095D7 RID: 38359
		// (get) Token: 0x06020EFB RID: 134907 RVA: 0x0048E34A File Offset: 0x0048C54A
		// (set) Token: 0x06020EFC RID: 134908 RVA: 0x0048E352 File Offset: 0x0048C552
		public EVisibleCondition Type { get; set; }

		// Token: 0x170095D8 RID: 38360
		// (get) Token: 0x06020EFD RID: 134909 RVA: 0x0048E35B File Offset: 0x0048C55B
		// (set) Token: 0x06020EFE RID: 134910 RVA: 0x0048E363 File Offset: 0x0048C563
		public ECompare Compare { get; set; }

		// Token: 0x170095D9 RID: 38361
		// (get) Token: 0x06020EFF RID: 134911 RVA: 0x0048E36C File Offset: 0x0048C56C
		// (set) Token: 0x06020F00 RID: 134912 RVA: 0x0048E374 File Offset: 0x0048C574
		public int Season { get; set; }

		// Token: 0x170095DA RID: 38362
		// (get) Token: 0x06020F01 RID: 134913 RVA: 0x0048E37D File Offset: 0x0048C57D
		// (set) Token: 0x06020F02 RID: 134914 RVA: 0x0048E385 File Offset: 0x0048C585
		public int Weather { get; set; }

		// Token: 0x170095DB RID: 38363
		// (get) Token: 0x06020F03 RID: 134915 RVA: 0x0048E38E File Offset: 0x0048C58E
		// (set) Token: 0x06020F04 RID: 134916 RVA: 0x0048E396 File Offset: 0x0048C596
		public byte NullMask { get; set; }

		// Token: 0x06020F05 RID: 134917 RVA: 0x0048E39F File Offset: 0x0048C59F
		public ISeasonAndWeatherT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.Season = 0;
			this.Weather = 0;
			this.NullMask = 0;
		}
	}
}
