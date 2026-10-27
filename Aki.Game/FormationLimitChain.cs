using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001BBA RID: 7098
[NullableContext(1)]
[Nullable(0)]
public class FormationLimitChain : IStaticVariableResetter
{
	// Token: 0x0600D39E RID: 54174 RVA: 0x0030A887 File Offset: 0x00308A87
	static FormationLimitChain()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationLimitChain.CreateStaticDefaultValue), new Action(FormationLimitChain.ResetStaticDefaultValue));
	}

	// Token: 0x0600D39F RID: 54175 RVA: 0x0030A8A6 File Offset: 0x00308AA6
	public FormationLimitChain(IReadOnlyList<ILimitStrategy> strategies)
	{
		this.Strategies = strategies;
	}

	// Token: 0x0600D3A0 RID: 54176 RVA: 0x0030A8C0 File Offset: 0x00308AC0
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

	// Token: 0x0600D3A1 RID: 54177 RVA: 0x0030A920 File Offset: 0x00308B20
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

	// Token: 0x0600D3A2 RID: 54178 RVA: 0x0030A952 File Offset: 0x00308B52
	public static void ResetStaticDefaultValue()
	{
		FormationLimitChain.StandardLimitChain = null;
	}

	// Token: 0x040060C8 RID: 24776
	private readonly IReadOnlyList<ILimitStrategy> Strategies = new List<ILimitStrategy>();

	// Token: 0x040060C9 RID: 24777
	public static FormationLimitChain StandardLimitChain;
}
