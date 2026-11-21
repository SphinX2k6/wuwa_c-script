using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020024D7 RID: 9431
[NullableContext(1)]
[Nullable(0)]
public abstract class BuffExecution : BuffEffectBase
{
	// Token: 0x06017681 RID: 95873 RVA: 0x006E504F File Offset: 0x006E324F
	protected BuffExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06017682 RID: 95874
	[return: Nullable(2)]
	public abstract object OnExecute(params object[] args);

	// Token: 0x06017683 RID: 95875 RVA: 0x006E5058 File Offset: 0x006E3258
	public virtual void OnBuffRemovedCallback(ActiveBuffInternal buff)
	{
	}

	// Token: 0x06017684 RID: 95876 RVA: 0x006E505A File Offset: 0x006E325A
	public virtual void OnBuffActiveChangedCallback(ActiveBuffInternal buff, bool isActive)
	{
	}

	// Token: 0x06017685 RID: 95877 RVA: 0x006E505C File Offset: 0x006E325C
	public static BuffExecution Create(Type buffExecutionType, long buffId, int index, RequireAndLimits requireAndLimits, [Nullable(2)] ExtraEffectParameters parameters)
	{
		BuffExecution buffExecution = (BuffExecution)Activator.CreateInstance(buffExecutionType, new object[]
		{
			requireAndLimits
		});
		buffExecution.BuffId = buffId;
		buffExecution.Index = index;
		if (parameters != null)
		{
			buffExecution.InitParameters(parameters);
		}
		return buffExecution;
	}

	// Token: 0x06017686 RID: 95878 RVA: 0x006E509A File Offset: 0x006E329A
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x06017687 RID: 95879 RVA: 0x006E50AD File Offset: 0x006E32AD
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

	// Token: 0x06017688 RID: 95880 RVA: 0x006E50EC File Offset: 0x006E32EC
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

	// Token: 0x06017689 RID: 95881 RVA: 0x006E51AB File Offset: 0x006E33AB
	public void ClearExecuteContext()
	{
		this.OwnerBuffComponent = null;
		this.Buff = null;
	}

	// Token: 0x0601768A RID: 95882 RVA: 0x006E51BC File Offset: 0x006E33BC
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

	// Token: 0x0601768B RID: 95883 RVA: 0x006E521C File Offset: 0x006E341C
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

	// Token: 0x0601768C RID: 95884 RVA: 0x006E524E File Offset: 0x006E344E
	public virtual void OnBuffAddedCallback(ActiveBuffInternal buff, bool isIterable)
	{
	}

	// Token: 0x0601768D RID: 95885 RVA: 0x006E5250 File Offset: 0x006E3450
	public virtual void OnPeriodCallback(ActiveBuffInternal buff)
	{
	}

	// Token: 0x0601768E RID: 95886 RVA: 0x006E5252 File Offset: 0x006E3452
	public override void OnBuffStackOverflow(ActiveBuffInternal buff, int oldStack, int newStack, int stackLimitMax)
	{
		if (!this.SetExecuteContext(buff))
		{
			return;
		}
		this.DoBuffStackOverflow(oldStack, newStack, stackLimitMax);
		this.ClearExecuteContext();
	}

	// Token: 0x0601768F RID: 95887 RVA: 0x006E5270 File Offset: 0x006E3470
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

	// Token: 0x06017690 RID: 95888 RVA: 0x006E5308 File Offset: 0x006E3508
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

	// Token: 0x0400C6CF RID: 50895
	[Nullable(2)]
	protected IActiveBuff Buff;

	// Token: 0x0400C6D0 RID: 50896
	protected int Index;

	// Token: 0x0400C6D1 RID: 50897
	protected EExecutionTargetType TargetType;
}
