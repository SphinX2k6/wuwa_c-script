using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000559 RID: 1369
public class ActivityViewStateSequence : IStaticVariableResetter
{
	// Token: 0x06004268 RID: 17000 RVA: 0x00173C09 File Offset: 0x00171E09
	static ActivityViewStateSequence()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivityViewStateSequence.CreateStaticDefaultValue), new Action(ActivityViewStateSequence.ResetStaticDefaultValue));
	}

	// Token: 0x06004269 RID: 17001 RVA: 0x00173C28 File Offset: 0x00171E28
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

	// Token: 0x0600426A RID: 17002 RVA: 0x00173C7B File Offset: 0x00171E7B
	public static void ResetStaticDefaultValue()
	{
		ActivityViewStateSequence.Value = null;
	}

	// Token: 0x04003429 RID: 13353
	[Nullable(1)]
	public static Dictionary<EActivityViewState, string[]> Value;
}
