using System;
using System.Runtime.CompilerServices;

// Token: 0x02002451 RID: 9297
[NullableContext(1)]
[Nullable(0)]
public abstract class BuffEffect : BuffEffectBase
{
	// Token: 0x17002455 RID: 9301
	// (get) Token: 0x06017439 RID: 95289 RVA: 0x006D79BA File Offset: 0x006D5BBA
	public double RemainCd
	{
		get
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent == null)
			{
				return 0.0;
			}
			return ownerBuffComponent.GetBuffEffectCd(this.BuffId, this.Index);
		}
	}

	// Token: 0x17002456 RID: 9302
	// (get) Token: 0x0601743A RID: 95290 RVA: 0x006D79E4 File Offset: 0x006D5BE4
	public double RemainCdForTarget
	{
		get
		{
			if (this.RequireAndLimits.Limits.ExtraEffectCdForTarget <= 0f)
			{
				return 0.0;
			}
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent == null)
			{
				return 0.0;
			}
			return ownerBuffComponent.GetBuffEffectCdForTarget(this.BuffId, this.Index, this.OpponentEntityId);
		}
	}

	// Token: 0x17002457 RID: 9303
	// (get) Token: 0x0601743B RID: 95291 RVA: 0x006D7A3D File Offset: 0x006D5C3D
	[Nullable(2)]
	protected IActiveBuff Buff
	{
		[NullableContext(2)]
		get
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent == null)
			{
				return null;
			}
			return ownerBuffComponent.GetBuffByHandle(this.ActiveHandleId);
		}
	}

	// Token: 0x17002458 RID: 9304
	// (get) Token: 0x0601743C RID: 95292 RVA: 0x006D7A56 File Offset: 0x006D5C56
	[Nullable(2)]
	protected IActiveBuff PendingBuff
	{
		[NullableContext(2)]
		get
		{
			IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
			if (ownerBuffComponent == null)
			{
				return null;
			}
			return ownerBuffComponent.GetPendingBuffByHandle(this.ActiveHandleId);
		}
	}

	// Token: 0x0601743D RID: 95293 RVA: 0x006D7A70 File Offset: 0x006D5C70
	protected BuffEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(requireAndLimits)
	{
		this.ActiveHandleId = activeHandleId;
		this.Index = index;
		this.OwnerBuffComponent = ownerBuffComponent;
		IActiveBuff buffByHandle = ownerBuffComponent.GetBuffByHandle(activeHandleId);
		if (buffByHandle != null)
		{
			this.Level = buffByHandle.Level;
			this.ServerId = buffByHandle.ServerId;
			this.BuffId = buffByHandle.Id;
			if (instigatorBuffComponent != null)
			{
				this.InstigatorEntityId = instigatorBuffComponent.Entity.Id;
			}
		}
	}

	// Token: 0x0601743E RID: 95294 RVA: 0x006D7AE0 File Offset: 0x006D5CE0
	public static BuffEffect Create(Type typeOfBuffEffect, int handleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent, [Nullable(2)] ExtraEffectParameters parameters = null)
	{
		BuffEffect buffEffect = (BuffEffect)Activator.CreateInstance(typeOfBuffEffect, new object[]
		{
			handleId,
			index,
			requireAndLimits,
			ownerBuffComponent,
			instigatorBuffComponent
		});
		if (parameters != null)
		{
			buffEffect.InitParameters(parameters);
		}
		return buffEffect;
	}

	// Token: 0x0601743F RID: 95295 RVA: 0x006D7B2C File Offset: 0x006D5D2C
	public virtual void OnCreated()
	{
	}

	// Token: 0x06017440 RID: 95296 RVA: 0x006D7B2E File Offset: 0x006D5D2E
	public virtual void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06017441 RID: 95297 RVA: 0x006D7B30 File Offset: 0x006D5D30
	public virtual void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
	}

	// Token: 0x06017442 RID: 95298 RVA: 0x006D7B32 File Offset: 0x006D5D32
	public virtual void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
	}

	// Token: 0x06017443 RID: 95299 RVA: 0x006D7B34 File Offset: 0x006D5D34
	public virtual void OnPeriodCallback()
	{
	}

	// Token: 0x06017444 RID: 95300 RVA: 0x006D7B36 File Offset: 0x006D5D36
	public override void OnBuffStackOverflow(ActiveBuffInternal buff, int oldStack, int newStack, int stackLimitMax)
	{
	}

	// Token: 0x06017445 RID: 95301 RVA: 0x006D7B38 File Offset: 0x006D5D38
	public bool TryExecute(Partial_RequirementPayload context, IBuffComponent opponent, params object[] parameters)
	{
		if (!this.Check(context, opponent))
		{
			return false;
		}
		this.ExecuteContext = context;
		this.Execute(parameters);
		this.ExecuteContext = null;
		return true;
	}

	// Token: 0x06017446 RID: 95302 RVA: 0x006D7B60 File Offset: 0x006D5D60
	public bool Check(Partial_RequirementPayload context, IBuffComponent opponent)
	{
		if (!this.CheckExecutable())
		{
			return false;
		}
		Entity entity = opponent.GetEntity();
		this.OpponentEntityId = ((entity != null) ? entity.Id : 0);
		return base.CheckLoop() && base.CheckRequirements(context) && (this.ActiveHandleId < 0 || (this.RemainCd <= 0.0 && this.RemainCdForTarget <= 0.0 && RandomSystem.GetRandomPercent() <= this.RequireAndLimits.Limits.ExtraEffectProbability));
	}

	// Token: 0x06017447 RID: 95303 RVA: 0x006D7BEF File Offset: 0x006D5DEF
	[return: Nullable(2)]
	public object Execute(params object[] parameters)
	{
		this.LoopLock = Time.Instance.Frame;
		object result = this.OnExecute(parameters);
		this.PostExecuted();
		this.LoopLock = -1;
		return result;
	}

	// Token: 0x06017448 RID: 95304
	[return: Nullable(2)]
	public abstract object OnExecute(params object[] parameters);

	// Token: 0x06017449 RID: 95305 RVA: 0x006D7C18 File Offset: 0x006D5E18
	protected virtual void PostExecuted()
	{
		if (this.ActiveHandleId < 0 || this.OwnerBuffComponent == null)
		{
			return;
		}
		if (this.CheckAuthority())
		{
			float remainCd = this.RequireAndLimits.Limits.ExtraEffectCd * 1000f;
			this.OwnerBuffComponent.SetBuffEffectCd(this.BuffId, this.Index, remainCd);
			float num = this.RequireAndLimits.Limits.ExtraEffectCdForTarget * 1000f;
			if (num > 0f)
			{
				this.OwnerBuffComponent.SetBuffEffectCdForTarget(this.BuffId, this.Index, this.OpponentEntityId, num);
			}
		}
		int extraEffectRemoveStackNum = this.RequireAndLimits.Limits.ExtraEffectRemoveStackNum;
		if (this.CheckAuthority() && extraEffectRemoveStackNum > 0)
		{
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, extraEffectRemoveStackNum, "buff额外效果触发后移除", null, null, null);
		}
	}

	// Token: 0x0400C47A RID: 50298
	protected int Timeout;

	// Token: 0x0400C47B RID: 50299
	[Nullable(2)]
	protected Partial_RequirementPayload ExecuteContext;

	// Token: 0x0400C47C RID: 50300
	public readonly int ActiveHandleId;

	// Token: 0x0400C47D RID: 50301
	public readonly int Index;
}
