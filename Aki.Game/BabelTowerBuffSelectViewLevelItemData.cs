using System;

// Token: 0x020005CD RID: 1485
public class BabelTowerBuffSelectViewLevelItemData : IBabelTowerBuffSelectViewLevelItemData
{
	// Token: 0x170009CE RID: 2510
	// (get) Token: 0x06004620 RID: 17952 RVA: 0x00180380 File Offset: 0x0017E580
	// (set) Token: 0x06004621 RID: 17953 RVA: 0x00180388 File Offset: 0x0017E588
	public int LevelId { get; set; }

	// Token: 0x170009CF RID: 2511
	// (get) Token: 0x06004622 RID: 17954 RVA: 0x00180391 File Offset: 0x0017E591
	// (set) Token: 0x06004623 RID: 17955 RVA: 0x00180399 File Offset: 0x0017E599
	public int BuffId { get; set; }

	// Token: 0x170009D0 RID: 2512
	// (get) Token: 0x06004624 RID: 17956 RVA: 0x001803A2 File Offset: 0x0017E5A2
	// (set) Token: 0x06004625 RID: 17957 RVA: 0x001803AA File Offset: 0x0017E5AA
	public EBabelTowerBuffState State { get; set; }
}
