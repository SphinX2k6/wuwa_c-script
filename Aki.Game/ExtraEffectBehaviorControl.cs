using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02002477 RID: 9335
[NullableContext(1)]
[Nullable(0)]
public class ExtraEffectBehaviorControl : BuffEffect
{
	// Token: 0x0601747E RID: 95358 RVA: 0x006D8256 File Offset: 0x006D6456
	public ExtraEffectBehaviorControl(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x0601747F RID: 95359 RVA: 0x006D8268 File Offset: 0x006D6468
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		int controlType = (extraEffectParameters_ != null && extraEffectParameters_.Length != 0) ? int.Parse(extraEffectParameters_[0] ?? "0") : 0;
		this.ControlType = (EControlType)controlType;
	}

	// Token: 0x06017480 RID: 95360 RVA: 0x006D82A0 File Offset: 0x006D64A0
	public override void OnCreated()
	{
		if (!base.TryExecute(new Partial_RequirementPayload(), this.OwnerBuffComponent, Array.Empty<object>()))
		{
			this.IsActive = false;
			this.OwnerBuffComponent.RemoveBuffByHandle(this.ActiveHandleId, -1, "怪物类型不满足条件，移除自身", null, null, null);
		}
	}

	// Token: 0x06017481 RID: 95361 RVA: 0x006D82FF File Offset: 0x006D64FF
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

	// Token: 0x06017482 RID: 95362 RVA: 0x006D8324 File Offset: 0x006D6524
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

	// Token: 0x06017483 RID: 95363 RVA: 0x006D8400 File Offset: 0x006D6600
	private void ApplyTaunt(bool addOrRemove)
	{
		EventSystem.Instance.EmitWithTarget<bool, int, int>(base.OwnerEntity, EEventName.AiTauntAddOrRemove, addOrRemove, this.InstigatorEntityId, this.ActiveHandleId);
	}

	// Token: 0x06017484 RID: 95364 RVA: 0x006D8428 File Offset: 0x006D6628
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

	// Token: 0x0400C565 RID: 50533
	private EControlType ControlType;

	// Token: 0x0400C566 RID: 50534
	private bool IsActive;
}
