using System;
using Aki.Config;

// Token: 0x02002446 RID: 9286
public class VisionAssembleAttrData
{
	// Token: 0x060129EE RID: 76270 RVA: 0x004984CC File Offset: 0x004966CC
	public int GetPriority()
	{
		int[] visionAttrSortArray = PhantomBattleConfig.Instance.GetVisionAttrSortArray();
		int num = -1;
		for (int i = 0; i < visionAttrSortArray.Length; i++)
		{
			if (visionAttrSortArray[i] == this.AttrId)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return 0;
		}
		return 999 - num;
	}

	// Token: 0x060129EF RID: 76271 RVA: 0x00498510 File Offset: 0x00496710
	public int GetId()
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.AttrId);
		if (propertyIndexInfo == null)
		{
			return 0;
		}
		return propertyIndexInfo.Value.Id;
	}

	// Token: 0x04008C58 RID: 35928
	public bool CompareMode;

	// Token: 0x04008C59 RID: 35929
	public int AttrId;

	// Token: 0x04008C5A RID: 35930
	public bool IfPercentage;

	// Token: 0x04008C5B RID: 35931
	public int CurrentValue;

	// Token: 0x04008C5C RID: 35932
	public int CompareValue;

	// Token: 0x04008C5D RID: 35933
	public bool IsHighLight;
}
