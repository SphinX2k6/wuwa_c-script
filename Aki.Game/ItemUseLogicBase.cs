using System;

// Token: 0x02001489 RID: 5257
public abstract class ItemUseLogicBase
{
	// Token: 0x0600D27E RID: 53886 RVA: 0x003E75DA File Offset: 0x003E57DA
	public virtual bool IsMatch(int itemId)
	{
		return false;
	}

	// Token: 0x0600D27F RID: 53887 RVA: 0x003E75DD File Offset: 0x003E57DD
	public virtual bool CheckUseCondition(int itemId, int num)
	{
		return true;
	}

	// Token: 0x0600D280 RID: 53888
	public abstract void OnUse(int itemId, int num);
}
