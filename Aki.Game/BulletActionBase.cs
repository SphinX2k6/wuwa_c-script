using System;
using System.Runtime.CompilerServices;

// Token: 0x020022DB RID: 8923
[NullableContext(2)]
[Nullable(0)]
public class BulletActionBase
{
	// Token: 0x0601605E RID: 90206 RVA: 0x00661304 File Offset: 0x0065F504
	public BulletActionBase(EBulletAction type)
	{
		this.Type = type;
		if (BulletConstant.Instance.OpenAllActionStat)
		{
			Stat tickStat = null;
			this.TickStat = tickStat;
		}
	}

	// Token: 0x0601605F RID: 90207 RVA: 0x00661333 File Offset: 0x0065F533
	[NullableContext(1)]
	public void Execute(BulletInfo bulletInfo, BulletActionInfoBase actionInfo)
	{
		this.BulletInfo = bulletInfo;
		this.ActionInfo = actionInfo;
		this.OnExecute();
	}

	// Token: 0x06016060 RID: 90208 RVA: 0x00661349 File Offset: 0x0065F549
	protected virtual void OnExecute()
	{
	}

	// Token: 0x06016061 RID: 90209 RVA: 0x0066134B File Offset: 0x0065F54B
	public void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x06016062 RID: 90210 RVA: 0x00661354 File Offset: 0x0065F554
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06016063 RID: 90211 RVA: 0x00661356 File Offset: 0x0065F556
	public virtual void AfterTick(float delta)
	{
	}

	// Token: 0x06016064 RID: 90212 RVA: 0x00661358 File Offset: 0x0065F558
	public BulletActionInfoBase GetActionInfo()
	{
		return this.ActionInfo;
	}

	// Token: 0x06016065 RID: 90213 RVA: 0x00661360 File Offset: 0x0065F560
	public virtual void Clear()
	{
		this.IsFinish = false;
		this.BulletInfo = null;
		this.ActionInfo = null;
	}

	// Token: 0x0400B8E9 RID: 47337
	public readonly EBulletAction Type;

	// Token: 0x0400B8EA RID: 47338
	public bool IsInPool;

	// Token: 0x0400B8EB RID: 47339
	public int Index;

	// Token: 0x0400B8EC RID: 47340
	public bool IsFinish;

	// Token: 0x0400B8ED RID: 47341
	public BulletInfo BulletInfo;

	// Token: 0x0400B8EE RID: 47342
	public BulletActionInfoBase ActionInfo;

	// Token: 0x0400B8EF RID: 47343
	private readonly Stat TickStat;
}
