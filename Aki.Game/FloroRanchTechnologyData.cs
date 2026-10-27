using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001B06 RID: 6918
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechnologyData
{
	// Token: 0x0600CD63 RID: 52579 RVA: 0x002ED01F File Offset: 0x002EB21F
	public FloroRanchTechnologyData(FloroRanchTech config)
	{
		this.Config = config;
	}

	// Token: 0x0600CD64 RID: 52580 RVA: 0x002ED02E File Offset: 0x002EB22E
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
	}

	// Token: 0x17001120 RID: 4384
	// (get) Token: 0x0600CD65 RID: 52581 RVA: 0x002ED037 File Offset: 0x002EB237
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x17001121 RID: 4385
	// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x002ED03F File Offset: 0x002EB23F
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001122 RID: 4386
	// (get) Token: 0x0600CD67 RID: 52583 RVA: 0x002ED04C File Offset: 0x002EB24C
	public string Name
	{
		get
		{
			return this.Config.Name;
		}
	}

	// Token: 0x17001123 RID: 4387
	// (get) Token: 0x0600CD68 RID: 52584 RVA: 0x002ED059 File Offset: 0x002EB259
	public int Column
	{
		get
		{
			return this.Config.Column;
		}
	}

	// Token: 0x17001124 RID: 4388
	// (get) Token: 0x0600CD69 RID: 52585 RVA: 0x002ED066 File Offset: 0x002EB266
	public int Row
	{
		get
		{
			return this.Config.Row;
		}
	}

	// Token: 0x17001125 RID: 4389
	// (get) Token: 0x0600CD6A RID: 52586 RVA: 0x002ED073 File Offset: 0x002EB273
	public int Cost
	{
		get
		{
			return this.Config.Cost;
		}
	}

	// Token: 0x17001126 RID: 4390
	// (get) Token: 0x0600CD6B RID: 52587 RVA: 0x002ED080 File Offset: 0x002EB280
	public string Des
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x17001127 RID: 4391
	// (get) Token: 0x0600CD6C RID: 52588 RVA: 0x002ED08D File Offset: 0x002EB28D
	public int[] PreNode
	{
		get
		{
			return this.Config.GetPreNodeArray();
		}
	}

	// Token: 0x17001128 RID: 4392
	// (get) Token: 0x0600CD6D RID: 52589 RVA: 0x002ED09A File Offset: 0x002EB29A
	public string Icon
	{
		get
		{
			return this.Config.Icon;
		}
	}

	// Token: 0x04005E35 RID: 24117
	private FloroRanchTech Config;

	// Token: 0x04005E36 RID: 24118
	private bool IsUnLockInternal;
}
