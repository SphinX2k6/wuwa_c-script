using System;
using System.Runtime.CompilerServices;

// Token: 0x02002448 RID: 9288
[NullableContext(1)]
[Nullable(0)]
public class AddBuffTrigger : PassiveEffects
{
	// Token: 0x060173F8 RID: 95224 RVA: 0x006D5542 File Offset: 0x006D3742
	public AddBuffTrigger(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x060173F9 RID: 95225 RVA: 0x006D5564 File Offset: 0x006D3764
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		this.EventType = (EBuffTriggerType)int.Parse(extraEffectParameters_[0]);
		this.TargetType = (EPassiveEffectTargetType)int.Parse(extraEffectParameters_[1]);
		string[] array = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
		this.BuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.BuffIds[i] = long.Parse(array[i]);
		}
		this.InstigatorType = (EPassiveEffectTargetType)((extraEffectParameters_.Length > 3) ? int.Parse(extraEffectParameters_[3]) : 2);
	}

	// Token: 0x060173FA RID: 95226 RVA: 0x006D55E4 File Offset: 0x006D37E4
	[return: Nullable(2)]
	public override object OnExecute(params object[] parameters)
	{
		IBuffComponent effectTarget = base.GetEffectTarget();
		IBuffComponent targetByType = base.GetTargetByType(this.InstigatorType);
		if (effectTarget == null)
		{
			return null;
		}
		IActiveBuff buffByHandle = this.OwnerBuffComponent.GetBuffByHandle(base.ActiveHandleId);
		if (buffByHandle != null && buffByHandle.IsValid())
		{
			for (int i = 0; i < this.BuffIds.Length; i++)
			{
				IBuffComponent buffComponent = effectTarget;
				long buffId = this.BuffIds[i];
				IActiveBuff preBuff = buffByHandle;
				int? stackCount = null;
				bool isIterable = true;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 2);
				defaultInterpolatedStringHandler.AppendLiteral("因为触发其它buff额外效果而添加（前置buff Id=");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral(", handle=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(base.ActiveHandleId);
				defaultInterpolatedStringHandler.AppendLiteral("）");
				string reason = defaultInterpolatedStringHandler.ToStringAndClear();
				Partial_RequirementPayload executeContext = this.ExecuteContext;
				buffComponent.AddIterativeBuff(buffId, preBuff, stackCount, isIterable, reason, (executeContext != null) ? executeContext.BulletMessageId : null, targetByType);
			}
		}
		return null;
	}

	// Token: 0x060173FB RID: 95227 RVA: 0x006D56CC File Offset: 0x006D38CC
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C450 RID: 50256
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C451 RID: 50257
	private EPassiveEffectTargetType InstigatorType = EPassiveEffectTargetType.ForBuffInstigator;
}
