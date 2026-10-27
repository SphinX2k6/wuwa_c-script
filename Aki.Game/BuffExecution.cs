using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002F83 RID: 12163
[NullableContext(1)]
[Nullable(0)]
public abstract class BuffExecution : BuffEffectBase
{
	// Token: 0x06019D6F RID: 105839 RVA: 0x006BE757 File Offset: 0x006BC957
	protected BuffExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019D70 RID: 105840
	[return: Nullable(2)]
	public abstract object OnExecute(params object[] args);

	// Token: 0x06019D71 RID: 105841 RVA: 0x006BE760 File Offset: 0x006BC960
	public virtual void OnBuffRemovedCallback(ActiveBuffInternal buff)
	{
	}

	// Token: 0x06019D72 RID: 105842 RVA: 0x006BE762 File Offset: 0x006BC962
	public virtual void OnBuffActiveChangedCallback(ActiveBuffInternal buff, bool isActive)
	{
	}

	// Token: 0x06019D73 RID: 105843 RVA: 0x006BE764 File Offset: 0x006BC964
	public static T Create<[Nullable(0)] T>(long buffId, int index, RequireAndLimits requireAndLimits, ExtraEffectParameters parameters) where T : BuffExecution
	{
		T t = (T)((object)Activator.CreateInstance(typeof(T), new object[]
		{
			requireAndLimits
		}));
		t.BuffId = buffId;
		t.Index = index;
		if (parameters != null)
		{
			t.InitParameters(parameters);
		}
		return t;
	}

	// Token: 0x06019D74 RID: 105844 RVA: 0x006BE7B8 File Offset: 0x006BC9B8
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06019D75 RID: 105845 RVA: 0x006BE7CB File Offset: 0x006BC9CB
	[NullableContext(2)]
	protected bool Check(Partial_RequirementPayload context)
	{
		if (!this.CheckExecutable())
		{
			return false;
		}
		Entity entity = this.OwnerBuffComponent.GetEntity();
		this.OpponentEntityId = ((entity != null) ? entity.Id : 0);
		return base.CheckRequirements(context ?? new Partial_RequirementPayload());
	}

	// Token: 0x06019D76 RID: 105846 RVA: 0x006BE80C File Offset: 0x006BCA0C
	public unsafe bool SetExecuteContext(ActiveBuffInternal buff)
	{
		this.Level = buff.Level;
		this.Buff = buff;
		IBuffComponent ownerBuffComponent = buff.GetOwnerBuffComponent();
		if (ownerBuffComponent == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = null;
			string message = "设置执行效果上下文失败";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("handle", (buff != null) ? buff.Handle : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", (buff != null) ? buff.Id : 0L);
			instance.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		bool instigatorBuffComponent = buff.GetInstigatorBuffComponent() != null;
		this.OwnerBuffComponent = ownerBuffComponent;
		if (instigatorBuffComponent)
		{
			this.InstigatorEntityId = buff.GetInstigator().Id;
		}
		return true;
	}

	// Token: 0x06019D77 RID: 105847 RVA: 0x006BE8CB File Offset: 0x006BCACB
	public void ClearExecuteContext()
	{
		this.OwnerBuffComponent = null;
		this.Buff = null;
	}

	// Token: 0x06019D78 RID: 105848 RVA: 0x006BE8DC File Offset: 0x006BCADC
	public bool TryExecute(ActiveBuffInternal buff, params object[] parameters)
	{
		if (!base.CheckLoop())
		{
			return false;
		}
		if (!this.SetExecuteContext(buff))
		{
			return false;
		}
		if (!this.Check(new Partial_RequirementPayload()))
		{
			return false;
		}
		this.LoopLock = Time.Instance.Frame;
		this.OnExecute(parameters);
		this.PostExecuted();
		this.LoopLock = -1;
		this.ClearExecuteContext();
		return true;
	}

	// Token: 0x06019D79 RID: 105849 RVA: 0x006BE93C File Offset: 0x006BCB3C
	[NullableContext(2)]
	protected IBuffComponent GetEffectTarget()
	{
		EExecutionTargetType targetType = this.TargetType;
		IBuffComponent result;
		if (targetType != EExecutionTargetType.Self)
		{
			if (targetType != EExecutionTargetType.Instigator)
			{
				result = null;
			}
			else
			{
				result = base.InstigatorBuffComponent;
			}
		}
		else
		{
			result = this.OwnerBuffComponent;
		}
		return result;
	}

	// Token: 0x06019D7A RID: 105850 RVA: 0x006BE96E File Offset: 0x006BCB6E
	public virtual void OnBuffAddedCallback(ActiveBuffInternal buff, bool isIterable)
	{
	}

	// Token: 0x06019D7B RID: 105851 RVA: 0x006BE970 File Offset: 0x006BCB70
	public virtual void OnPeriodCallback(ActiveBuffInternal buff)
	{
	}

	// Token: 0x06019D7C RID: 105852 RVA: 0x006BE972 File Offset: 0x006BCB72
	public override void OnBuffStackOverflow(ActiveBuffInternal buff, int oldStack, int newStack, int stackLimitMax)
	{
		if (!this.SetExecuteContext(buff))
		{
			return;
		}
		this.DoBuffStackOverflow(oldStack, newStack, stackLimitMax);
		this.ClearExecuteContext();
	}

	// Token: 0x06019D7D RID: 105853 RVA: 0x006BE990 File Offset: 0x006BCB90
	public void BuffEffectExecutePush()
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		if (exactOwnerEntity == null)
		{
			CombatLog instance = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Buff;
			Entity entity = null;
			string message = "[Buff]EffectExecutePush失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", this.BuffId);
			instance.Warn(flag, entity, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		BuffEffectExecutePush buffEffectExecutePush = new BuffEffectExecutePush();
		buffEffectExecutePush.HandleId = this.Buff.Handle;
		buffEffectExecutePush.Index = this.Index;
		CombatNet.Instance.Send(EPushMessageId.BuffEffectExecutePush, exactOwnerEntity, buffEffectExecutePush, null, null, null);
	}

	// Token: 0x06019D7E RID: 105854 RVA: 0x006BEA28 File Offset: 0x006BCC28
	protected void PostExecuted()
	{
		if (this.Buff == null || this.Buff.Handle < 0 || this.OwnerBuffComponent == null)
		{
			return;
		}
		int extraEffectRemoveStackNum = this.RequireAndLimits.Limits.ExtraEffectRemoveStackNum;
		if (this.CheckAuthority() && extraEffectRemoveStackNum > 0)
		{
			this.OwnerBuffComponent.RemoveBuffByHandle(this.Buff.Handle, extraEffectRemoveStackNum, "buff额外效果触发后移除", null, null, null);
		}
	}

	// Token: 0x0400C326 RID: 49958
	[Nullable(2)]
	protected IActiveBuff Buff;

	// Token: 0x0400C327 RID: 49959
	protected int Index;

	// Token: 0x0400C328 RID: 49960
	protected EExecutionTargetType TargetType;
}
