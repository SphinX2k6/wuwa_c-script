using System;
using System.Runtime.CompilerServices;

// Token: 0x02002499 RID: 9369
[NullableContext(1)]
[Nullable(0)]
public class FrozenEffect : BuffEffect
{
	// Token: 0x0601754A RID: 95562 RVA: 0x006DD773 File Offset: 0x006DB973
	public FrozenEffect(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601754B RID: 95563 RVA: 0x006DD790 File Offset: 0x006DB990
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActiveHandleId);
		this.LockName = defaultInterpolatedStringHandler.ToStringAndClear();
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ != null && extraEffectParameters_.Length != 0)
		{
			this.PanelQteId = int.Parse(extraEffectParameters_[0]);
		}
	}

	// Token: 0x0601754C RID: 95564 RVA: 0x006DD7DC File Offset: 0x006DB9DC
	public override void OnCreated()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		object obj;
		if (ownerBuffComponent == null)
		{
			obj = null;
		}
		else
		{
			Entity entity = ownerBuffComponent.GetEntity();
			obj = ((entity != null) ? entity.CheckGetComponent<BaseFrozenComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.LockFrozen(this.LockName);
		}
		if (this.PanelQteId != 0)
		{
			PanelQteController instance = PanelQteController.Instance;
			int panelQteId = this.PanelQteId;
			long buffId = this.BuffId;
			int activeHandleId = this.ActiveHandleId;
			IBuffComponent ownerBuffComponent2 = this.OwnerBuffComponent;
			this.PanelQteHandleId = instance.StartBuffQte(panelQteId, buffId, activeHandleId, (ownerBuffComponent2 != null) ? ownerBuffComponent2.GetEntity() : null, base.Buff.MessageId);
		}
	}

	// Token: 0x0601754D RID: 95565 RVA: 0x006DD85F File Offset: 0x006DBA5F
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		return null;
	}

	// Token: 0x0601754E RID: 95566 RVA: 0x006DD864 File Offset: 0x006DBA64
	public override void OnRemoved(bool bPremature)
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		object obj;
		if (ownerBuffComponent == null)
		{
			obj = null;
		}
		else
		{
			Entity entity = ownerBuffComponent.GetEntity();
			obj = ((entity != null) ? entity.CheckGetComponent<BaseFrozenComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.UnlockFrozen(this.LockName);
		}
		if (this.PanelQteId != 0 && this.PanelQteHandleId > 0)
		{
			PanelQteController.Instance.StopQte(this.PanelQteHandleId, false);
		}
	}

	// Token: 0x0601754F RID: 95567 RVA: 0x006DD8C4 File Offset: 0x006DBAC4
	public override string GetDebugEffectString()
	{
		string str = "冻结";
		string str2;
		if (this.PanelQteId <= 0)
		{
			str2 = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
			defaultInterpolatedStringHandler.AppendLiteral("并播放QTE");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.PanelQteId);
			str2 = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return str + str2;
	}

	// Token: 0x0400C5DA RID: 50650
	protected string LockName = "";

	// Token: 0x0400C5DB RID: 50651
	protected int PanelQteId;

	// Token: 0x0400C5DC RID: 50652
	protected int PanelQteHandleId;
}
