using System;

// Token: 0x02001487 RID: 5255
public class BuffItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D274 RID: 53876 RVA: 0x003E71DB File Offset: 0x003E53DB
	public override bool IsMatch(int itemId)
	{
		return BuffItemConfig.Instance.IsBuffItem(itemId);
	}

	// Token: 0x0600D275 RID: 53877 RVA: 0x003E71E8 File Offset: 0x003E53E8
	public override void OnUse(int itemId, int num)
	{
		ItemUseLogic.TryUseBuffItem(itemId, num);
	}
}
