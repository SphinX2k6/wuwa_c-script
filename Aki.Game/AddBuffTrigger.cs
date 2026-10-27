using System;
using System.Runtime.CompilerServices;

// Token: 0x02002EF5 RID: 12021
[NullableContext(1)]
[Nullable(0)]
public class AddBuffTrigger : PassiveEffects
{
	// Token: 0x06019AED RID: 105197 RVA: 0x006AF24E File Offset: 0x006AD44E
	public AddBuffTrigger(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
	{
	}

	// Token: 0x06019AEE RID: 105198 RVA: 0x006AF270 File Offset: 0x006AD470
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

	// Token: 0x06019AEF RID: 105199 RVA: 0x006AF2F0 File Offset: 0x006AD4F0
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

	// Token: 0x06019AF0 RID: 105200 RVA: 0x006AF3D8 File Offset: 0x006AD5D8
	public override string GetDebugEffectString()
	{
		return string.Empty;
	}

	// Token: 0x0400C0AF RID: 49327
	private long[] BuffIds = Array.Empty<long>();

	// Token: 0x0400C0B0 RID: 49328
	private EPassiveEffectTargetType InstigatorType = EPassiveEffectTargetType.ForBuffInstigator;
}
