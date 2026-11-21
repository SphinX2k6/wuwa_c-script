using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FC5 RID: 4037
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchTechnologyData
{
	// Token: 0x0600A174 RID: 41332 RVA: 0x002F810B File Offset: 0x002F630B
	public FloroRanchTechnologyData(FloroRanchTech config)
	{
		this.Config = config;
	}

	// Token: 0x0600A175 RID: 41333 RVA: 0x002F811A File Offset: 0x002F631A
	public void UpdateUnLockState(bool isUnLock)
	{
		this.IsUnLockInternal = isUnLock;
	}

	// Token: 0x17001145 RID: 4421
	// (get) Token: 0x0600A176 RID: 41334 RVA: 0x002F8123 File Offset: 0x002F6323
	public bool IsUnLock
	{
		get
		{
			return this.IsUnLockInternal;
		}
	}

	// Token: 0x17001146 RID: 4422
	// (get) Token: 0x0600A177 RID: 41335 RVA: 0x002F812B File Offset: 0x002F632B
	public int Id
	{
		get
		{
			return this.Config.Id;
		}
	}

	// Token: 0x17001147 RID: 4423
	// (get) Token: 0x0600A178 RID: 41336 RVA: 0x002F8138 File Offset: 0x002F6338
	public string Name
	{
		get
		{
			return this.Config.Name;
		}
	}

	// Token: 0x17001148 RID: 4424
	// (get) Token: 0x0600A179 RID: 41337 RVA: 0x002F8145 File Offset: 0x002F6345
	public int Column
	{
		get
		{
			return this.Config.Column;
		}
	}

	// Token: 0x17001149 RID: 4425
	// (get) Token: 0x0600A17A RID: 41338 RVA: 0x002F8152 File Offset: 0x002F6352
	public int Row
	{
		get
		{
			return this.Config.Row;
		}
	}

	// Token: 0x1700114A RID: 4426
	// (get) Token: 0x0600A17B RID: 41339 RVA: 0x002F815F File Offset: 0x002F635F
	public int Cost
	{
		get
		{
			return this.Config.Cost;
		}
	}

	// Token: 0x1700114B RID: 4427
	// (get) Token: 0x0600A17C RID: 41340 RVA: 0x002F816C File Offset: 0x002F636C
	public string Des
	{
		get
		{
			return this.Config.Desc;
		}
	}

	// Token: 0x1700114C RID: 4428
	// (get) Token: 0x0600A17D RID: 41341 RVA: 0x002F8179 File Offset: 0x002F6379
	public int[] PreNode
	{
		get
		{
			return this.Config.GetPreNodeArray();
		}
	}

	// Token: 0x1700114D RID: 4429
	// (get) Token: 0x0600A17E RID: 41342 RVA: 0x002F8186 File Offset: 0x002F6386
	public string Icon
	{
		get
		{
			return this.Config.Icon;
		}
	}

	// Token: 0x04005F04 RID: 24324
	private FloroRanchTech Config;

	// Token: 0x04005F05 RID: 24325
	private bool IsUnLockInternal;
}
