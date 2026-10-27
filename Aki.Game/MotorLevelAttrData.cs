using System;

// Token: 0x0200224C RID: 8780
public class MotorLevelAttrData : IMotorLevelAttrData
{
	// Token: 0x170015B4 RID: 5556
	// (get) Token: 0x0601121B RID: 70171 RVA: 0x0042E0EC File Offset: 0x0042C2EC
	// (set) Token: 0x0601121C RID: 70172 RVA: 0x0042E0F4 File Offset: 0x0042C2F4
	public int AttrId { get; set; }

	// Token: 0x170015B5 RID: 5557
	// (get) Token: 0x0601121D RID: 70173 RVA: 0x0042E0FD File Offset: 0x0042C2FD
	// (set) Token: 0x0601121E RID: 70174 RVA: 0x0042E105 File Offset: 0x0042C305
	public int Level { get; set; }

	// Token: 0x170015B6 RID: 5558
	// (get) Token: 0x0601121F RID: 70175 RVA: 0x0042E10E File Offset: 0x0042C30E
	// (set) Token: 0x06011220 RID: 70176 RVA: 0x0042E116 File Offset: 0x0042C316
	public bool IsShowBg { get; set; }

	// Token: 0x170015B7 RID: 5559
	// (get) Token: 0x06011221 RID: 70177 RVA: 0x0042E11F File Offset: 0x0042C31F
	// (set) Token: 0x06011222 RID: 70178 RVA: 0x0042E127 File Offset: 0x0042C327
	public bool IsSpecial { get; set; }
}
