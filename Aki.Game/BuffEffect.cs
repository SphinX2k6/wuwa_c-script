using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EFE RID: 12030
[NullableContext(1)]
[Nullable(0)]
public abstract class BuffEffect : BuffEffectBase
{
	// Token: 0x17002393 RID: 9107
	// (get) Token: 0x06019B2E RID: 105262 RVA: 0x006B16A2 File Offset: 0x006AF8A2
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

	// Token: 0x17002394 RID: 9108
	// (get) Token: 0x06019B2F RID: 105263 RVA: 0x006B16CC File Offset: 0x006AF8CC
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

	// Token: 0x17002395 RID: 9109
	// (get) Token: 0x06019B30 RID: 105264 RVA: 0x006B1725 File Offset: 0x006AF925
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

	// Token: 0x17002396 RID: 9110
	// (get) Token: 0x06019B31 RID: 105265 RVA: 0x006B173E File Offset: 0x006AF93E
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

	// Token: 0x06019B32 RID: 105266 RVA: 0x006B1758 File Offset: 0x006AF958
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

	// Token: 0x06019B33 RID: 105267 RVA: 0x006B17C8 File Offset: 0x006AF9C8
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

	// Token: 0x06019B34 RID: 105268 RVA: 0x006B1814 File Offset: 0x006AFA14
	public virtual void OnCreated()
	{
	}

	// Token: 0x06019B35 RID: 105269 RVA: 0x006B1816 File Offset: 0x006AFA16
	public virtual void OnRemoved(bool bPremature)
	{
	}

	// Token: 0x06019B36 RID: 105270 RVA: 0x006B1818 File Offset: 0x006AFA18
	public virtual void OnStackDecreased(int newCount, int oldCount, bool bPremature)
	{
	}

	// Token: 0x06019B37 RID: 105271 RVA: 0x006B181A File Offset: 0x006AFA1A
	public virtual void OnStackIncreased(int newCount, int oldCount, long? instigatorId)
	{
	}

	// Token: 0x06019B38 RID: 105272 RVA: 0x006B181C File Offset: 0x006AFA1C
	public virtual void OnPeriodCallback()
	{
	}

	// Token: 0x06019B39 RID: 105273 RVA: 0x006B181E File Offset: 0x006AFA1E
	public override void OnBuffStackOverflow(ActiveBuffInternal buff, int oldStack, int newStack, int stackLimitMax)
	{
	}

	// Token: 0x06019B3A RID: 105274 RVA: 0x006B1820 File Offset: 0x006AFA20
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

	// Token: 0x06019B3B RID: 105275 RVA: 0x006B1848 File Offset: 0x006AFA48
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

	// Token: 0x06019B3C RID: 105276 RVA: 0x006B18D7 File Offset: 0x006AFAD7
	[return: Nullable(2)]
	public object Execute(params object[] parameters)
	{
		this.LoopLock = Time.Instance.Frame;
		object result = this.OnExecute(parameters);
		this.PostExecuted();
		this.LoopLock = -1;
		return result;
	}

	// Token: 0x06019B3D RID: 105277
	[return: Nullable(2)]
	public abstract object OnExecute(params object[] parameters);

	// Token: 0x06019B3E RID: 105278 RVA: 0x006B1900 File Offset: 0x006AFB00
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

	// Token: 0x0400C0D9 RID: 49369
	protected int Timeout;

	// Token: 0x0400C0DA RID: 49370
	[Nullable(2)]
	protected Partial_RequirementPayload ExecuteContext;

	// Token: 0x0400C0DB RID: 49371
	public readonly int ActiveHandleId;

	// Token: 0x0400C0DC RID: 49372
	public readonly int Index;
}
