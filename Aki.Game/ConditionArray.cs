using System;
using System.Runtime.CompilerServices;

// Token: 0x0200315C RID: 12636
[NullableContext(1)]
[Nullable(0)]
public class ConditionArray
{
	// Token: 0x0601B30C RID: 111372 RVA: 0x007684F4 File Offset: 0x007666F4
	public ConditionArray(bool[] conditions, ILogicalStructure structure)
	{
		this.Conditions = conditions;
		this.Structure = structure;
	}

	// Token: 0x0601B30D RID: 111373 RVA: 0x0076850A File Offset: 0x0076670A
	public bool EvaluateByConditions(bool[] conditions)
	{
		this.Conditions = conditions;
		return this.Evaluate();
	}

	// Token: 0x0601B30E RID: 111374 RVA: 0x00768519 File Offset: 0x00766719
	public bool Evaluate()
	{
		return this.EvaluateStructure(this.Structure);
	}

	// Token: 0x0601B30F RID: 111375 RVA: 0x00768528 File Offset: 0x00766728
	private bool EvaluateStructure(ILogicalStructure structure)
	{
		if (structure.Index != null)
		{
			return this.Conditions[structure.Index.Value];
		}
		if (structure.Or != null)
		{
			for (int i = 0; i < structure.Or.Length; i++)
			{
				if (this.EvaluateStructure(structure.Or[i]))
				{
					return true;
				}
			}
			return false;
		}
		if (structure.And != null)
		{
			for (int j = 0; j < structure.And.Length; j++)
			{
				if (!this.EvaluateStructure(structure.And[j]))
				{
					return false;
				}
			}
			return true;
		}
		return structure.Not != null && !this.EvaluateStructure(structure.Not);
	}

	// Token: 0x0400D3A2 RID: 54178
	private bool[] Conditions;

	// Token: 0x0400D3A3 RID: 54179
	private readonly ILogicalStructure Structure;
}
