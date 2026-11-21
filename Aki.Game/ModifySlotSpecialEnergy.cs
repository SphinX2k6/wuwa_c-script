using System;
using System.Runtime.CompilerServices;

// Token: 0x020024F3 RID: 9459
[NullableContext(1)]
[Nullable(0)]
public class ModifySlotSpecialEnergy : PeriodExecution
{
	// Token: 0x060176EA RID: 95978 RVA: 0x006E8AC6 File Offset: 0x006E6CC6
	public ModifySlotSpecialEnergy(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176EB RID: 95979 RVA: 0x006E8ADC File Offset: 0x006E6CDC
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null)
		{
			this.NumberParams = Array.Empty<int>();
			return;
		}
		this.NumberParams = new int[extraEffectParameters_.Length];
		for (int i = 0; i < extraEffectParameters_.Length; i++)
		{
			this.NumberParams[i] = int.Parse(extraEffectParameters_[i]);
		}
	}

	// Token: 0x060176EC RID: 95980 RVA: 0x006E8B2C File Offset: 0x006E6D2C
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		if (base.OwnerEntity != null)
		{
			int num = (this.NumberParams.Length != 0) ? this.NumberParams[0] : -1;
			if (num <= -1 || num >= 1)
			{
				return null;
			}
			CharacterSpecialSkillComponent component = base.OwnerEntity.GetComponent<CharacterSpecialSkillComponent>();
			SpecialSkillBuling specialSkillBuling = ((component != null) ? component.SpecialSkill : null) as SpecialSkillBuling;
			if (specialSkillBuling != null)
			{
				specialSkillBuling.ModifySlotSpecialEnergy(this.NumberParams);
			}
		}
		return null;
	}

	// Token: 0x060176ED RID: 95981 RVA: 0x006E8B90 File Offset: 0x006E6D90
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 修改槽位型特殊能量 ");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", this.NumberParams));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C725 RID: 50981
	private int[] NumberParams = Array.Empty<int>();
}
