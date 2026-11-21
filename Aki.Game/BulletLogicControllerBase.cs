using System;
using System.Runtime.CompilerServices;

// Token: 0x02002324 RID: 8996
[NullableContext(1)]
[Nullable(0)]
public abstract class BulletLogicControllerBase
{
	// Token: 0x17002216 RID: 8726
	// (get) Token: 0x060162A0 RID: 90784 RVA: 0x00671CAB File Offset: 0x0066FEAB
	// (set) Token: 0x060162A1 RID: 90785 RVA: 0x00671CB3 File Offset: 0x0066FEB3
	public bool NeedTick
	{
		get
		{
			return this.NeedTickInternal;
		}
		set
		{
			this.NeedTickInternal = value;
		}
	}

	// Token: 0x060162A2 RID: 90786 RVA: 0x00671CBC File Offset: 0x0066FEBC
	protected BulletLogicControllerBase(Entity bullet)
	{
		this.Bullet = (bullet as BulletEntity);
		this.NeedTickInternal = false;
	}

	// Token: 0x060162A3 RID: 90787 RVA: 0x00671CD7 File Offset: 0x0066FED7
	public virtual void OnInit()
	{
	}

	// Token: 0x060162A4 RID: 90788
	[NullableContext(2)]
	public abstract void BulletLogicActionFromBase(object param = null);

	// Token: 0x060162A5 RID: 90789
	[NullableContext(2)]
	public abstract void BulletLogicActionOnHitObstaclesFromBase(object param = null);

	// Token: 0x060162A6 RID: 90790 RVA: 0x00671CD9 File Offset: 0x0066FED9
	protected virtual void Update(float deltaTime)
	{
	}

	// Token: 0x060162A7 RID: 90791 RVA: 0x00671CDB File Offset: 0x0066FEDB
	public void Tick(float deltaTime)
	{
		this.Update(deltaTime);
	}

	// Token: 0x060162A8 RID: 90792 RVA: 0x00671CE4 File Offset: 0x0066FEE4
	public virtual void OnBulletDestroy()
	{
	}

	// Token: 0x0400BAC8 RID: 47816
	protected BulletEntity Bullet;

	// Token: 0x0400BAC9 RID: 47817
	private bool NeedTickInternal;
}
