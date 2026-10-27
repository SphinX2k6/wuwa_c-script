using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002F9A RID: 12186
[NullableContext(1)]
[Nullable(0)]
public class InvokePeriod : PeriodExecution
{
	// Token: 0x06019DC9 RID: 105929 RVA: 0x006C1A6A File Offset: 0x006BFC6A
	public InvokePeriod(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DCA RID: 105930 RVA: 0x006C1A80 File Offset: 0x006BFC80
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

	// Token: 0x06019DCB RID: 105931 RVA: 0x006C1AEC File Offset: 0x006BFCEC
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

	// Token: 0x0400C371 RID: 50033
	private long[] SourceBuffIds = Array.Empty<long>();
}
