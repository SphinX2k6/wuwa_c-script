using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020023F6 RID: 9206
[NullableContext(1)]
[Nullable(0)]
public class VisionSubPropData
{
	// Token: 0x06012640 RID: 75328 RVA: 0x00488A61 File Offset: 0x00486C61
	public VisionSubPropData(int slotIndex, PhantomDataBase sourceData)
	{
		this.SlotIndex = slotIndex;
		this.Data = sourceData;
	}

	// Token: 0x06012641 RID: 75329 RVA: 0x00488A77 File Offset: 0x00486C77
	public string GetSubPropName()
	{
		return this.GetSubPropNameByPropId(this.PhantomSubProp.PhantomPropId);
	}

	// Token: 0x06012642 RID: 75330 RVA: 0x00488A8C File Offset: 0x00486C8C
	public string GetSubPropNameByPropId(int propId)
	{
		int propId2 = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(propId).PropId;
		return PropertyIndexConfig.Instance.GetPropertyIndexInfo(propId2).Value.Name;
	}

	// Token: 0x06012643 RID: 75331 RVA: 0x00488AC8 File Offset: 0x00486CC8
	public int GetSlotIndex()
	{
		return this.SlotIndex;
	}

	// Token: 0x06012644 RID: 75332 RVA: 0x00488AD0 File Offset: 0x00486CD0
	public string GetAttributeValueString()
	{
		return this.GetAttributeValueStringByPropId(this.PhantomSubProp.PhantomPropId, this.PhantomSubProp.Value);
	}

	// Token: 0x06012645 RID: 75333 RVA: 0x00488AF0 File Offset: 0x00486CF0
	public string GetAttributeValueStringByPropId(int propId, int propValue)
	{
		PhantomSubProperty phantomSubPropertyById = PhantomBattleConfig.Instance.GetPhantomSubPropertyById(propId);
		bool isRatio = phantomSubPropertyById.AddType == 2;
		double propRatioValue = TipsDataTool.GetPropRatioValue((double)propValue, isRatio);
		return AttributeModel.Instance.GetFormatAttributeValueString(phantomSubPropertyById.PropId, propRatioValue, isRatio);
	}

	// Token: 0x06012646 RID: 75334 RVA: 0x00488B30 File Offset: 0x00486D30
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

	// Token: 0x04008B32 RID: 35634
	private readonly int SlotIndex;

	// Token: 0x04008B33 RID: 35635
	[Nullable(2)]
	private readonly PhantomDataBase Data;

	// Token: 0x04008B34 RID: 35636
	public EVisionSlotState SlotState;

	// Token: 0x04008B35 RID: 35637
	[Nullable(2)]
	public Aki.Protocol.PhantomPropInfo PhantomSubProp;
}
