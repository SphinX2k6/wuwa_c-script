using System;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02002F9F RID: 12191
[NullableContext(1)]
[Nullable(0)]
public class ModifySlotSpecialEnergy : PeriodExecution
{
	// Token: 0x06019DD8 RID: 105944 RVA: 0x006C21FE File Offset: 0x006C03FE
	public ModifySlotSpecialEnergy(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x06019DD9 RID: 105945 RVA: 0x006C2214 File Offset: 0x006C0414
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

	// Token: 0x06019DDA RID: 105946 RVA: 0x006C2264 File Offset: 0x006C0464
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
			SpecialSkillBase specialSkillBase = (component != null) ? component.SpecialSkill : null;
			if (specialSkillBase != null)
			{
				MethodInfo method = specialSkillBase.GetType().GetMethod("ModifySlotSpecialEnergy", new Type[]
				{
					typeof(int[])
				});
				if (method != null)
				{
					method.Invoke(specialSkillBase, new object[]
					{
						this.NumberParams
					});
				}
			}
		}
		return null;
	}

	// Token: 0x06019DDB RID: 105947 RVA: 0x006C22F4 File Offset: 0x006C04F4
	public override string GetDebugEffectString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
		defaultInterpolatedStringHandler.AppendLiteral("buff");
		defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
		defaultInterpolatedStringHandler.AppendLiteral(" 修改槽位型特殊能量 ");
		defaultInterpolatedStringHandler.AppendFormatted(string.Join<int>(",", this.NumberParams));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0400C37C RID: 50044
	private int[] NumberParams = Array.Empty<int>();
}
