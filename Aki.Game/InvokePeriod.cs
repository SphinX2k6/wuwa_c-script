using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024EE RID: 9454
[NullableContext(1)]
[Nullable(0)]
public class InvokePeriod : PeriodExecution
{
	// Token: 0x060176DB RID: 95963 RVA: 0x006E8332 File Offset: 0x006E6532
	public InvokePeriod(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176DC RID: 95964 RVA: 0x006E8348 File Offset: 0x006E6548
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0 || string.IsNullOrEmpty(extraEffectParameters_[0]))
		{
			this.SourceBuffIds = Array.Empty<long>();
			return;
		}
		string[] array = extraEffectParameters_[0].Split('#', StringSplitOptions.None);
		this.SourceBuffIds = new long[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			this.SourceBuffIds[i] = long.Parse(array[i]);
		}
	}

	// Token: 0x060176DD RID: 95965 RVA: 0x006E83B4 File Offset: 0x006E65B4
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		Entity exactOwnerEntity = base.ExactOwnerEntity;
		BaseBuffComponent baseBuffComponent = (exactOwnerEntity != null) ? exactOwnerEntity.CheckGetComponent<BaseBuffComponent>() : null;
		List<BaseBuffComponent> list = ((baseBuffComponent != null) ? baseBuffComponent.GetTargetComponents<BaseBuffComponent>(EComponent.BaseBuffComponent, null) : null) ?? new List<BaseBuffComponent>();
		for (int i = 0; i < list.Count; i++)
		{
			BaseBuffComponent baseBuffComponent2 = list[i];
			if (baseBuffComponent2 != null)
			{
				for (int j = 0; j < this.SourceBuffIds.Length; j++)
				{
					ActiveBuffInternal buffById = baseBuffComponent2.GetBuffById(this.SourceBuffIds[j]);
					if (buffById != null && buffById.IsValid() && buffById.IsActive())
					{
						baseBuffComponent2.ApplyPeriodExecution(buffById);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0400C71A RID: 50970
	private long[] SourceBuffIds = Array.Empty<long>();
}
