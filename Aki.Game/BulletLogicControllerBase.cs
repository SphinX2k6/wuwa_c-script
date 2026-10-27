using System;
using System.Runtime.CompilerServices;

// Token: 0x02002DCA RID: 11722
[NullableContext(1)]
[Nullable(0)]
public abstract class BulletLogicControllerBase
{
	// Token: 0x170021BA RID: 8634
	// (get) Token: 0x060189F8 RID: 100856 RVA: 0x0064BEC7 File Offset: 0x0064A0C7
	// (set) Token: 0x060189F9 RID: 100857 RVA: 0x0064BECF File Offset: 0x0064A0CF
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

	// Token: 0x060189FA RID: 100858 RVA: 0x0064BED8 File Offset: 0x0064A0D8
	protected BulletLogicControllerBase(Entity bullet)
	{
		this.Bullet = (bullet as BulletEntity);
		this.NeedTickInternal = false;
	}

	// Token: 0x060189FB RID: 100859 RVA: 0x0064BEF3 File Offset: 0x0064A0F3
	public virtual void OnInit()
	{
	}

	// Token: 0x060189FC RID: 100860
	[NullableContext(2)]
	public abstract void BulletLogicActionFromBase(object param = null);

	// Token: 0x060189FD RID: 100861
	[NullableContext(2)]
	public abstract void BulletLogicActionOnHitObstaclesFromBase(object param = null);

	// Token: 0x060189FE RID: 100862 RVA: 0x0064BEF5 File Offset: 0x0064A0F5
	protected virtual void Update(float deltaTime)
	{
	}

	// Token: 0x060189FF RID: 100863 RVA: 0x0064BEF7 File Offset: 0x0064A0F7
	public void Tick(float deltaTime)
	{
		this.Update(deltaTime);
	}

	// Token: 0x06018A00 RID: 100864 RVA: 0x0064BF00 File Offset: 0x0064A100
	public virtual void OnBulletDestroy()
	{
	}

	// Token: 0x0400B74D RID: 46925
	protected BulletEntity Bullet;

	// Token: 0x0400B74E RID: 46926
	private bool NeedTickInternal;
}
