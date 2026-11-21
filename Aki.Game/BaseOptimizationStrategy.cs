using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;

// Token: 0x020027FD RID: 10237
[NullableContext(1)]
[Nullable(0)]
[OverrideFunctionRoot]
public class BaseOptimizationStrategy
{
	// Token: 0x06019C4C RID: 105548 RVA: 0x007F0EB1 File Offset: 0x007EF0B1
	public BaseOptimizationStrategy()
	{
		this.NeedEnable = this.NeedEnableInternal;
		this.NeedTriggerMyPlayerInOutRange = this.NeedMyPlayerInOutRangeLocalInternal;
		this.NeedTriggerEntityInOutRange = this.NeedEntityInOutRangeLocalInternal;
		this.NeedDisable = this.NeedDisableInternal;
	}

	// Token: 0x06019C4D RID: 105549 RVA: 0x007F0EE9 File Offset: 0x007EF0E9
	public void Enable()
	{
		if (!this.NeedEnable)
		{
			return;
		}
		this.OnEnable();
	}

	// Token: 0x06019C4E RID: 105550 RVA: 0x007F0EFA File Offset: 0x007EF0FA
	public void MyPlayerEntityInOutRange(bool isEnter)
	{
		if (!this.NeedTriggerMyPlayerInOutRange)
		{
			return;
		}
		this.OnMyPlayerInOutRangeLocal(isEnter);
	}

	// Token: 0x06019C4F RID: 105551 RVA: 0x007F0F0C File Offset: 0x007EF10C
	public void EntityInOutRange(bool isEnter, EntityHandle handle)
	{
		if (!this.NeedTriggerEntityInOutRange)
		{
			return;
		}
		this.OnEntityInOutRangeLocal(isEnter, handle);
	}

	// Token: 0x06019C50 RID: 105552 RVA: 0x007F0F1F File Offset: 0x007EF11F
	public void Disable()
	{
		if (!this.NeedDisable)
		{
			return;
		}
		this.OnDisable();
	}

	// Token: 0x06019C51 RID: 105553 RVA: 0x007F0F30 File Offset: 0x007EF130
	[OverrideFunction]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06019C52 RID: 105554 RVA: 0x007F0F32 File Offset: 0x007EF132
	[OverrideFunction]
	protected virtual void OnMyPlayerInOutRangeLocal(bool isEnter)
	{
	}

	// Token: 0x06019C53 RID: 105555 RVA: 0x007F0F34 File Offset: 0x007EF134
	[OverrideFunction]
	protected virtual void OnEntityInOutRangeLocal(bool isEnter, EntityHandle handle)
	{
	}

	// Token: 0x06019C54 RID: 105556 RVA: 0x007F0F36 File Offset: 0x007EF136
	[OverrideFunction]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x17002978 RID: 10616
	// (get) Token: 0x06019C55 RID: 105557 RVA: 0x007F0F38 File Offset: 0x007EF138
	public virtual bool NeedEnableInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17002979 RID: 10617
	// (get) Token: 0x06019C56 RID: 105558 RVA: 0x007F0F3B File Offset: 0x007EF13B
	public virtual bool NeedMyPlayerInOutRangeLocalInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700297A RID: 10618
	// (get) Token: 0x06019C57 RID: 105559 RVA: 0x007F0F3E File Offset: 0x007EF13E
	public virtual bool NeedEntityInOutRangeLocalInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700297B RID: 10619
	// (get) Token: 0x06019C58 RID: 105560 RVA: 0x007F0F41 File Offset: 0x007EF141
	public virtual bool NeedDisableInternal
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0400E228 RID: 57896
	public readonly bool NeedEnable;

	// Token: 0x0400E229 RID: 57897
	public readonly bool NeedTriggerMyPlayerInOutRange;

	// Token: 0x0400E22A RID: 57898
	public readonly bool NeedTriggerEntityInOutRange;

	// Token: 0x0400E22B RID: 57899
	public readonly bool NeedDisable;
}
