using System;
using System.Runtime.CompilerServices;

// Token: 0x02002D81 RID: 11649
[NullableContext(2)]
[Nullable(0)]
public class BulletActionBase
{
	// Token: 0x060187BC RID: 100284 RVA: 0x0063B2F4 File Offset: 0x006394F4
	public BulletActionBase(EBulletAction type)
	{
		this.Type = type;
		if (BulletConstant.Instance.OpenAllActionStat)
		{
			Stat tickStat = null;
			this.TickStat = tickStat;
		}
	}

	// Token: 0x060187BD RID: 100285 RVA: 0x0063B323 File Offset: 0x00639523
	[NullableContext(1)]
	public void Execute(BulletInfo bulletInfo, BulletActionInfoBase actionInfo)
	{
		this.BulletInfo = bulletInfo;
		this.ActionInfo = actionInfo;
		this.OnExecute();
	}

	// Token: 0x060187BE RID: 100286 RVA: 0x0063B339 File Offset: 0x00639539
	protected virtual void OnExecute()
	{
	}

	// Token: 0x060187BF RID: 100287 RVA: 0x0063B33B File Offset: 0x0063953B
	public void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x060187C0 RID: 100288 RVA: 0x0063B344 File Offset: 0x00639544
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x060187C1 RID: 100289 RVA: 0x0063B346 File Offset: 0x00639546
	public virtual void AfterTick(float delta)
	{
	}

	// Token: 0x060187C2 RID: 100290 RVA: 0x0063B348 File Offset: 0x00639548
	public BulletActionInfoBase GetActionInfo()
	{
		return this.ActionInfo;
	}

	// Token: 0x060187C3 RID: 100291 RVA: 0x0063B350 File Offset: 0x00639550
	public virtual void Clear()
	{
		this.IsFinish = false;
		this.BulletInfo = null;
		this.ActionInfo = null;
	}

	// Token: 0x0400B574 RID: 46452
	public readonly EBulletAction Type;

	// Token: 0x0400B575 RID: 46453
	public bool IsInPool;

	// Token: 0x0400B576 RID: 46454
	public int Index;

	// Token: 0x0400B577 RID: 46455
	public bool IsFinish;

	// Token: 0x0400B578 RID: 46456
	public BulletInfo BulletInfo;

	// Token: 0x0400B579 RID: 46457
	public BulletActionInfoBase ActionInfo;

	// Token: 0x0400B57A RID: 46458
	private readonly Stat TickStat;
}
