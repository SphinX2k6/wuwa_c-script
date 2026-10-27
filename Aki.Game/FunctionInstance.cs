using System;

// Token: 0x02001C4E RID: 7246
public class FunctionInstance
{
	// Token: 0x0600DA8C RID: 55948 RVA: 0x0032C3BA File Offset: 0x0032A5BA
	public FunctionInstance(int flag, EFunctionType functionId)
	{
		this.Flag = flag;
		this.FunctionType = functionId;
		this.IsLockByBehaviorTree = false;
	}

	// Token: 0x0600DA8D RID: 55949 RVA: 0x0032C3D7 File Offset: 0x0032A5D7
	public int GetFunctionId()
	{
		return (int)this.FunctionType;
	}

	// Token: 0x0600DA8E RID: 55950 RVA: 0x0032C3DF File Offset: 0x0032A5DF
	public bool GetIsShow()
	{
		return (this.Flag & 1) > 0;
	}

	// Token: 0x0600DA8F RID: 55951 RVA: 0x0032C3EC File Offset: 0x0032A5EC
	public bool GetIsOpen()
	{
		return (this.Flag & 2) > 0;
	}

	// Token: 0x0600DA90 RID: 55952 RVA: 0x0032C3F9 File Offset: 0x0032A5F9
	public bool GetHasManualShowUi()
	{
		return (this.Flag & 4) > 0;
	}

	// Token: 0x0600DA91 RID: 55953 RVA: 0x0032C406 File Offset: 0x0032A606
	public void SetFlag(int value)
	{
		this.Flag = value;
	}

	// Token: 0x0600DA92 RID: 55954 RVA: 0x0032C40F File Offset: 0x0032A60F
	public void SetIsLockByBehaviorTree(bool value)
	{
		this.IsLockByBehaviorTree = value;
	}

	// Token: 0x0600DA93 RID: 55955 RVA: 0x0032C418 File Offset: 0x0032A618
	public bool GetIsLockByBehaviorTree()
	{
		return this.IsLockByBehaviorTree;
	}

	// Token: 0x04006402 RID: 25602
	private readonly EFunctionType FunctionType;

	// Token: 0x04006403 RID: 25603
	private int Flag;

	// Token: 0x04006404 RID: 25604
	private bool IsLockByBehaviorTree;
}
