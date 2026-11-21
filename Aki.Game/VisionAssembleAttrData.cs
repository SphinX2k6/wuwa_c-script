using System;
using Aki.Config;

// Token: 0x0200192B RID: 6443
public class VisionAssembleAttrData
{
	// Token: 0x0600FEA4 RID: 65188 RVA: 0x004A5A98 File Offset: 0x004A3C98
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

	// Token: 0x0600FEA5 RID: 65189 RVA: 0x004A5ADC File Offset: 0x004A3CDC
	public int GetId()
	{
		PropertyIndex? propertyIndexInfo = PropertyIndexConfig.Instance.GetPropertyIndexInfo(this.AttrId);
		if (propertyIndexInfo == null)
		{
			return 0;
		}
		return propertyIndexInfo.Value.Id;
	}

	// Token: 0x04008D9F RID: 36255
	public bool CompareMode;

	// Token: 0x04008DA0 RID: 36256
	public int AttrId;

	// Token: 0x04008DA1 RID: 36257
	public bool IfPercentage;

	// Token: 0x04008DA2 RID: 36258
	public int CurrentValue;

	// Token: 0x04008DA3 RID: 36259
	public int CompareValue;

	// Token: 0x04008DA4 RID: 36260
	public bool IsHighLight;
}
