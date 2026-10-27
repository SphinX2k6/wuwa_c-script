using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002F24 RID: 12068
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectBehaviorControl : BuffEffect
{
	// Token: 0x06019B73 RID: 105331 RVA: 0x006B1F3E File Offset: 0x006B013E
	public ExtraEffectBehaviorControl(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019B74 RID: 105332 RVA: 0x006B1F50 File Offset: 0x006B0150
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		int controlType = (extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0] ?? "0") : 0;
		this.ControlType = (EControlType)controlType;
	}

	// Token: 0x06019B75 RID: 105333 RVA: 0x006B1F88 File Offset: 0x006B0188
	public override void OnCreated()
	{
		if (!base.TryExecute(new Partial_RequirementPayload(), this.OwnerBuffComponent, Array.Empty<object>()))
		{
			this.IsActive = false;
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, -1, "怪物类型不满足条件，移除自身", null, null, null);
		}
	}

	// Token: 0x06019B76 RID: 105334 RVA: 0x006B1FE7 File Offset: 0x006B01E7
	public override void OnRemoved(bool bPremature)
	{
		if (!this.IsActive)
		{
			return;
		}
		this.ApplyTaunt(false);
		if (this.ControlType == EControlType.Tempt)
		{
			this.ApplyTemptation(false);
		}
	}

	// Token: 0x06019B77 RID: 105335 RVA: 0x006B200C File Offset: 0x006B020C
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		this.IsActive = true;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
		defaultInterpolatedStringHandler.AppendLiteral("被嘲讽buff ");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral("覆盖");
		string reason = defaultInterpolatedStringHandler.ToStringAndClear();
		foreach (ExtraEffectBehaviorControl extraEffectBehaviorControl in base.OwnerEffectManager.FilterById<ExtraEffectBehaviorControl>(EExtraEffectId.Control, null))
		{
			if (extraEffectBehaviorControl != this)
			{
				this.OwnerBuffComponent.RemoveBuffByHandle(extraEffectBehaviorControl.ActiveHandleId, -1, reason, null, null, null);
			}
		}
		this.ApplyTaunt(true);
		if (this.ControlType == EControlType.Tempt)
		{
			this.ApplyTemptation(true);
		}
		return null;
	}

	// Token: 0x06019B78 RID: 105336 RVA: 0x006B20E8 File Offset: 0x006B02E8
	private void ApplyTaunt(bool addOrRemove)
	{
		EventSystem.Instance.EmitWithTarget<bool, int, int>(base.OwnerEntity, EEventName.AiTauntAddOrRemove, addOrRemove, this.InstigatorEntityId, this.ActiveHandleId);
	}

	// Token: 0x06019B79 RID: 105337 RVA: 0x006B2110 File Offset: 0x006B0310
	private void ApplyTemptation(bool addOrRemove)
	{
		if (addOrRemove)
		{
			BlackboardController.Instance.SetEntityIdByEntity(base.OwnerEntity.Id, "TemptTarget", this.InstigatorEntityId);
			return;
		}
		if (BlackboardController.Instance.HasValueByEntity(base.OwnerEntity.Id, "TemptTarget"))
		{
			BlackboardController.Instance.RemoveValueByEntity(base.OwnerEntity.Id, "TemptTarget");
		}
	}

	// Token: 0x0400C1C3 RID: 49603
	private EControlType ControlType;

	// Token: 0x0400C1C4 RID: 49604
	private bool IsActive;
}
