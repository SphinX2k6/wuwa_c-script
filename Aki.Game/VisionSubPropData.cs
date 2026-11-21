using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020018DB RID: 6363
[NullableContext(1)]
[Nullable(0)]
public class VisionSubPropData
{
	// Token: 0x0600FAF2 RID: 64242 RVA: 0x00495F69 File Offset: 0x00494169
	public VisionSubPropData(int slotIndex, PhantomDataBase sourceData)
	{
		this.SlotIndex = slotIndex;
		this.Data = sourceData;
	}

	// Token: 0x0600FAF3 RID: 64243 RVA: 0x00495F7F File Offset: 0x0049417F
	public string GetSubPropName()
	{
		return this.GetSubPropNameByPropId(this.PhantomSubProp.PhantomPropId);
	}

	// Token: 0x0600FAF4 RID: 64244 RVA: 0x00495F94 File Offset: 0x00494194
	public string GetSubPropNameByPropId(int propId)
	{
		int propId2 = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(propId).PropId;
		return PropertyIndexConfig.Instance.GetPropertyIndexInfo(propId2).Value.Name;
	}

	// Token: 0x0600FAF5 RID: 64245 RVA: 0x00495FD0 File Offset: 0x004941D0
	public int GetSlotIndex()
	{
		return this.SlotIndex;
	}

	// Token: 0x0600FAF6 RID: 64246 RVA: 0x00495FD8 File Offset: 0x004941D8
	public string GetAttributeValueString()
	{
		return this.GetAttributeValueStringByPropId(this.PhantomSubProp.PhantomPropId, this.PhantomSubProp.Value);
	}

	// Token: 0x0600FAF7 RID: 64247 RVA: 0x00495FF8 File Offset: 0x004941F8
	public string GetAttributeValueStringByPropId(int propId, int propValue)
	{
		PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(propId);
		bool isRatio = phantomSubPropertyById.AddType == 2;
		double propRatioValue = TipsDataTool.GetPropRatioValue((double)propValue, isRatio);
		return AttributeModel.Instance.GetFormatAttributeValueString(phantomSubPropertyById.PropId, propRatioValue, isRatio);
	}

	// Token: 0x0600FAF8 RID: 64248 RVA: 0x00496038 File Offset: 0x00494238
	public int GetUnlockLevel()
	{
		int quality = this.Data.GetQuality();
		int[] phantomSlotUnlockLevel = PhantomBattleConfig.Instance.GetPhantomSlotUnlockLevel(quality);
		if (phantomSlotUnlockLevel.Length > this.SlotIndex)
		{
			return phantomSlotUnlockLevel[this.SlotIndex];
		}
		return 0;
	}

	// Token: 0x04008C79 RID: 35961
	private readonly int SlotIndex;

	// Token: 0x04008C7A RID: 35962
	[Nullable(2)]
	private readonly PhantomDataBase Data;

	// Token: 0x04008C7B RID: 35963
	public EVisionSlotState SlotState;

	// Token: 0x04008C7C RID: 35964
	[Nullable(2)]
	public Aki.Protocol.PhantomPropInfo PhantomSubProp;
}
