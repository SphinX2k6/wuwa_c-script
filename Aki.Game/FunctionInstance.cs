using System;

// Token: 0x0200110D RID: 4365
public class FunctionInstance
{
	// Token: 0x0600AEA2 RID: 44706 RVA: 0x003377C2 File Offset: 0x003359C2
	public FunctionInstance(int flag, EFunctionType functionId)
	{
		this.Flag = flag;
		this.FunctionType = functionId;
		this.IsLockByBehaviorTree = false;
	}

	// Token: 0x0600AEA3 RID: 44707 RVA: 0x003377DF File Offset: 0x003359DF
	public int GetFunctionId()
	{
		return (int)this.FunctionType;
	}

	// Token: 0x0600AEA4 RID: 44708 RVA: 0x003377E7 File Offset: 0x003359E7
	public bool GetIsShow()
	{
		return (this.Flag & 1) > 0;
	}

	// Token: 0x0600AEA5 RID: 44709 RVA: 0x003377F4 File Offset: 0x003359F4
	public bool GetIsOpen()
	{
		return (this.Flag & 2) > 0;
	}

	// Token: 0x0600AEA6 RID: 44710 RVA: 0x00337801 File Offset: 0x00335A01
	public bool GetHasManualShowUi()
	{
		return (this.Flag & 4) > 0;
	}

	// Token: 0x0600AEA7 RID: 44711 RVA: 0x0033780E File Offset: 0x00335A0E
	public void SetFlag(int value)
	{
		this.Flag = value;
	}

	// Token: 0x0600AEA8 RID: 44712 RVA: 0x00337817 File Offset: 0x00335A17
	public void SetIsLockByBehaviorTree(bool value)
	{
		this.IsLockByBehaviorTree = value;
	}

	// Token: 0x0600AEA9 RID: 44713 RVA: 0x00337820 File Offset: 0x00335A20
	public bool GetIsLockByBehaviorTree()
	{
		return this.IsLockByBehaviorTree;
	}

	// Token: 0x040064D4 RID: 25812
	private readonly EFunctionType FunctionType;

	// Token: 0x040064D5 RID: 25813
	private int Flag;

	// Token: 0x040064D6 RID: 25814
	private bool IsLockByBehaviorTree;
}
