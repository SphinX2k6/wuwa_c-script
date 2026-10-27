using System;

// Token: 0x02002437 RID: 9271
public class VisionDetailMonsterItemData
{
	// Token: 0x06012986 RID: 76166 RVA: 0x004965E5 File Offset: 0x004947E5
	public VisionDetailMonsterItemData(int monsterId = 0, int qualityId = 0, int roleId = 0)
	{
		this.MonsterId = monsterId;
		this.QualityId = qualityId;
		this.RoleId = roleId;
	}

	// Token: 0x04008C2B RID: 35883
	public int MonsterId;

	// Token: 0x04008C2C RID: 35884
	public int QualityId;

	// Token: 0x04008C2D RID: 35885
	public int RoleId;
}
