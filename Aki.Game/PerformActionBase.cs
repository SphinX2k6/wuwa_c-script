using System;
using System.Runtime.CompilerServices;

// Token: 0x02003112 RID: 12562
[NullableContext(2)]
[Nullable(0)]
public class PerformActionBase : IPerformActionBase
{
	// Token: 0x0601B00B RID: 110603 RVA: 0x00754B94 File Offset: 0x00752D94
	public PerformActionBase(EPerformAction name)
	{
		this.Name = name;
	}

	// Token: 0x17002556 RID: 9558
	// (get) Token: 0x0601B00C RID: 110604 RVA: 0x00754BA3 File Offset: 0x00752DA3
	// (set) Token: 0x0601B00D RID: 110605 RVA: 0x00754BAB File Offset: 0x00752DAB
	public EPerformAction Name { get; private set; }

	// Token: 0x17002557 RID: 9559
	// (get) Token: 0x0601B00E RID: 110606 RVA: 0x00754BB4 File Offset: 0x00752DB4
	// (set) Token: 0x0601B00F RID: 110607 RVA: 0x00754BBC File Offset: 0x00752DBC
	public int Id { get; set; }

	// Token: 0x17002558 RID: 9560
	// (get) Token: 0x0601B010 RID: 110608 RVA: 0x00754BC5 File Offset: 0x00752DC5
	// (set) Token: 0x0601B011 RID: 110609 RVA: 0x00754BCD File Offset: 0x00752DCD
	public EPerformMode Mode { get; set; }

	// Token: 0x17002559 RID: 9561
	// (get) Token: 0x0601B012 RID: 110610 RVA: 0x00754BD6 File Offset: 0x00752DD6
	// (set) Token: 0x0601B013 RID: 110611 RVA: 0x00754BDE File Offset: 0x00752DDE
	public EPerformGroup Group { get; set; }

	// Token: 0x1700255A RID: 9562
	// (get) Token: 0x0601B014 RID: 110612 RVA: 0x00754BE7 File Offset: 0x00752DE7
	// (set) Token: 0x0601B015 RID: 110613 RVA: 0x00754BEF File Offset: 0x00752DEF
	public bool Executed { get; set; }

	// Token: 0x1700255B RID: 9563
	// (get) Token: 0x0601B016 RID: 110614 RVA: 0x00754BF8 File Offset: 0x00752DF8
	public virtual bool IsAtomic { get; }

	// Token: 0x1700255C RID: 9564
	// (get) Token: 0x0601B017 RID: 110615 RVA: 0x00754C00 File Offset: 0x00752E00
	// (set) Token: 0x0601B018 RID: 110616 RVA: 0x00754C08 File Offset: 0x00752E08
	public bool IsValid { get; set; }

	// Token: 0x1700255D RID: 9565
	// (get) Token: 0x0601B019 RID: 110617 RVA: 0x00754C11 File Offset: 0x00752E11
	// (set) Token: 0x0601B01A RID: 110618 RVA: 0x00754C19 File Offset: 0x00752E19
	public bool IsPersistent { get; set; }

	// Token: 0x0601B01B RID: 110619 RVA: 0x00754C24 File Offset: 0x00752E24
	public void Execute()
	{
		if (this.IsValid)
		{
			if (this.Executed)
			{
				this.OnRestore();
				return;
			}
			this.Executed = true;
			Action<int> onBeforeExecute = this.OnBeforeExecute;
			if (onBeforeExecute != null)
			{
				onBeforeExecute(this.Id);
			}
			this.OnExecute();
			return;
		}
		else
		{
			Action onFinish = this.OnFinish;
			if (onFinish == null)
			{
				return;
			}
			onFinish();
			return;
		}
	}

	// Token: 0x0601B01C RID: 110620 RVA: 0x00754C7D File Offset: 0x00752E7D
	protected void FinishExecute()
	{
		Action<int> onAfterExecute = this.OnAfterExecute;
		if (onAfterExecute != null)
		{
			onAfterExecute(this.Id);
		}
		Action onFinish = this.OnFinish;
		if (onFinish == null)
		{
			return;
		}
		onFinish();
	}

	// Token: 0x0601B01D RID: 110621 RVA: 0x00754CA6 File Offset: 0x00752EA6
	public void Interrupt()
	{
		this.OnInterrupt();
	}

	// Token: 0x0601B01E RID: 110622 RVA: 0x00754CB0 File Offset: 0x00752EB0
	public void Reset()
	{
		this.IsValid = false;
		this.Id = 0;
		this.Executed = false;
		this.Param = null;
		this.PerformComp = null;
		this.Mode = EPerformMode.Undetermined;
		this.Group = EPerformGroup.DefaultGroup;
		this.IsPersistent = false;
		this.OnFinish = null;
		this.OnBeforeExecute = null;
		this.OnReset();
	}

	// Token: 0x0601B01F RID: 110623 RVA: 0x00754D09 File Offset: 0x00752F09
	protected virtual void OnExecute()
	{
	}

	// Token: 0x0601B020 RID: 110624 RVA: 0x00754D0B File Offset: 0x00752F0B
	protected virtual void OnInterrupt()
	{
	}

	// Token: 0x0601B021 RID: 110625 RVA: 0x00754D0D File Offset: 0x00752F0D
	protected virtual void OnRestore()
	{
		this.OnExecute();
	}

	// Token: 0x0601B022 RID: 110626 RVA: 0x00754D15 File Offset: 0x00752F15
	protected virtual void OnReset()
	{
	}

	// Token: 0x0400D1FC RID: 53756
	public IActionParamMap Param;

	// Token: 0x0400D1FD RID: 53757
	public BasePerformComponent PerformComp;

	// Token: 0x0400D1FE RID: 53758
	public Action OnFinish;

	// Token: 0x0400D1FF RID: 53759
	public Action<int> OnBeforeExecute;

	// Token: 0x0400D200 RID: 53760
	public Action<int> OnAfterExecute;
}
