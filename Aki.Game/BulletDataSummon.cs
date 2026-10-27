using System;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002DB3 RID: 11699
public class BulletDataSummon
{
	// Token: 0x170021AB RID: 8619
	// (get) Token: 0x0601899D RID: 100765 RVA: 0x006496A6 File Offset: 0x006478A6
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

	// Token: 0x170021AC RID: 8620
	// (get) Token: 0x0601899E RID: 100766 RVA: 0x006496D6 File Offset: 0x006478D6
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

	// Token: 0x0601899F RID: 100767 RVA: 0x00649706 File Offset: 0x00647906
	public BulletDataSummon(SReBulletDataEntity data)
	{
		this.Data = data;
	}

	// Token: 0x0400B6C8 RID: 46792
	private readonly SReBulletDataEntity Data;

	// Token: 0x0400B6C9 RID: 46793
	private int? EntityIdInternal;

	// Token: 0x0400B6CA RID: 46794
	private bool? DestroyEntityOnBulletEndInternal;
}
