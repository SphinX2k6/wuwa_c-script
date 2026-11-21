using System;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x0200230D RID: 8973
public class BulletDataSummon
{
	// Token: 0x17002207 RID: 8711
	// (get) Token: 0x06016245 RID: 90693 RVA: 0x0066F4AE File Offset: 0x0066D6AE
	public int EntityId
	{
		get
		{
			if (this.EntityIdInternal == null)
			{
				this.EntityIdInternal = new int?(this.Data.实体ID);
			}
			return this.EntityIdInternal.Value;
		}
	}

	// Token: 0x17002208 RID: 8712
	// (get) Token: 0x06016246 RID: 90694 RVA: 0x0066F4DE File Offset: 0x0066D6DE
	public bool DestroyEntityOnBulletEnd
	{
		get
		{
			if (this.DestroyEntityOnBulletEndInternal == null)
			{
				this.DestroyEntityOnBulletEndInternal = new bool?(this.Data.是否随子弹销毁而销毁);
			}
			return this.DestroyEntityOnBulletEndInternal.Value;
		}
	}

	// Token: 0x06016247 RID: 90695 RVA: 0x0066F50E File Offset: 0x0066D70E
	public BulletDataSummon(SReBulletDataEntity data)
	{
		this.Data = data;
	}

	// Token: 0x0400BA42 RID: 47682
	private readonly SReBulletDataEntity Data;

	// Token: 0x0400BA43 RID: 47683
	private int? EntityIdInternal;

	// Token: 0x0400BA44 RID: 47684
	private bool? DestroyEntityOnBulletEndInternal;
}
