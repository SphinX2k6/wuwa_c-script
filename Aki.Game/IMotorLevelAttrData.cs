using System;

// Token: 0x0200224B RID: 8779
public interface IMotorLevelAttrData
{
	// Token: 0x170015B0 RID: 5552
	// (get) Token: 0x06011213 RID: 70163
	// (set) Token: 0x06011214 RID: 70164
	int AttrId { get; set; }

	// Token: 0x170015B1 RID: 5553
	// (get) Token: 0x06011215 RID: 70165
	// (set) Token: 0x06011216 RID: 70166
	int Level { get; set; }

	// Token: 0x170015B2 RID: 5554
	// (get) Token: 0x06011217 RID: 70167
	// (set) Token: 0x06011218 RID: 70168
	bool IsShowBg { get; set; }

	// Token: 0x170015B3 RID: 5555
	// (get) Token: 0x06011219 RID: 70169
	// (set) Token: 0x0601121A RID: 70170
	bool IsSpecial { get; set; }
}
