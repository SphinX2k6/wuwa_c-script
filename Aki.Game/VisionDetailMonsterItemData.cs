using System;

// Token: 0x0200191C RID: 6428
public class VisionDetailMonsterItemData
{
	// Token: 0x0600FE3C RID: 65084 RVA: 0x004A3BB1 File Offset: 0x004A1DB1
	public VisionDetailMonsterItemData(int monsterId = 0, int qualityId = 0, int roleId = 0)
	{
		this.MonsterId = monsterId;
		this.QualityId = qualityId;
		this.RoleId = roleId;
	}

	// Token: 0x04008D72 RID: 36210
	public int MonsterId;

	// Token: 0x04008D73 RID: 36211
	public int QualityId;

	// Token: 0x04008D74 RID: 36212
	public int RoleId;
}
