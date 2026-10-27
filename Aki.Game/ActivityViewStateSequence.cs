using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010A5 RID: 4261
public class ActivityViewStateSequence : IStaticVariableResetter
{
	// Token: 0x06006ED2 RID: 28370 RVA: 0x0016B291 File Offset: 0x00169491
	static ActivityViewStateSequence()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityViewStateSequence.CreateStaticDefaultValue), new Action(ActivityViewStateSequence.ResetStaticDefaultValue));
	}

	// Token: 0x06006ED3 RID: 28371 RVA: 0x0016B2B0 File Offset: 0x001694B0
	public static void CreateStaticDefaultValue()
	{
		ActivityViewStateSequence.Value = new Dictionary<EActivityViewState, string[]>
		{
			{
				EActivityViewState.Side,
				new string[]
				{
					"SideIn",
					"SideOut"
				}
			},
			{
				EActivityViewState.Global,
				new string[]
				{
					"GlobalIn",
					"GlobalOut"
				}
			}
		};
	}

	// Token: 0x06006ED4 RID: 28372 RVA: 0x0016B303 File Offset: 0x00169503
	public static void ResetStaticDefaultValue()
	{
		ActivityViewStateSequence.Value = null;
	}

	// Token: 0x04003390 RID: 13200
	[Nullable(1)]
	public static Dictionary<EActivityViewState, string[]> Value;
}
