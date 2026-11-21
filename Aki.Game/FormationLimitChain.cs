using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001079 RID: 4217
[NullableContext(1)]
[Nullable(0)]
public class FormationLimitChain : IStaticVariableResetter
{
	// Token: 0x0600A7B0 RID: 42928 RVA: 0x0031597B File Offset: 0x00313B7B
	static FormationLimitChain()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationLimitChain.CreateStaticDefaultValue), new Action(FormationLimitChain.ResetStaticDefaultValue));
	}

	// Token: 0x0600A7B1 RID: 42929 RVA: 0x0031599A File Offset: 0x00313B9A
	public FormationLimitChain(IReadOnlyList<ILimitStrategy> strategies)
	{
		this.Strategies = strategies;
	}

	// Token: 0x0600A7B2 RID: 42930 RVA: 0x003159B4 File Offset: 0x00313BB4
	public IValidationResult<ELimitReason> Check(ILimitContext ctx)
	{
		foreach (ILimitStrategy limitStrategy in this.Strategies)
		{
			IValidationResult<ELimitReason> validationResult = limitStrategy.CheckLimit(ctx);
			if (!validationResult.Pass)
			{
				return validationResult;
			}
		}
		return FormationLimitResult.Ok();
	}

	// Token: 0x0600A7B3 RID: 42931 RVA: 0x00315A14 File Offset: 0x00313C14
	public static void CreateStaticDefaultValue()
	{
		FormationLimitChain.StandardLimitChain = new FormationLimitChain(new ILimitStrategy[]
		{
			new LimitRoleStrategy(),
			new LimitCountStrategy(),
			new LimitElementStrategy(),
			new LimitExtraStrategy()
		});
	}

	// Token: 0x0600A7B4 RID: 42932 RVA: 0x00315A46 File Offset: 0x00313C46
	public static void ResetStaticDefaultValue()
	{
		FormationLimitChain.StandardLimitChain = null;
	}

	// Token: 0x04006197 RID: 24983
	private readonly IReadOnlyList<ILimitStrategy> Strategies = new List<ILimitStrategy>();

	// Token: 0x04006198 RID: 24984
	public static FormationLimitChain StandardLimitChain;
}
