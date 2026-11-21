using System;
using System.Runtime.CompilerServices;

// Token: 0x020026C9 RID: 9929
[NullableContext(1)]
[Nullable(0)]
public class ConditionArray
{
	// Token: 0x06018E11 RID: 101905 RVA: 0x0078FEC0 File Offset: 0x0078E0C0
	public ConditionArray(bool[] conditions, ILogicalStructure structure)
	{
		this.Conditions = conditions;
		this.Structure = structure;
	}

	// Token: 0x06018E12 RID: 101906 RVA: 0x0078FED6 File Offset: 0x0078E0D6
	public bool EvaluateByConditions(bool[] conditions)
	{
		this.Conditions = conditions;
		return this.Evaluate();
	}

	// Token: 0x06018E13 RID: 101907 RVA: 0x0078FEE5 File Offset: 0x0078E0E5
	public bool Evaluate()
	{
		return this.EvaluateStructure(this.Structure);
	}

	// Token: 0x06018E14 RID: 101908 RVA: 0x0078FEF4 File Offset: 0x0078E0F4
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

	// Token: 0x0400D805 RID: 55301
	private bool[] Conditions;

	// Token: 0x0400D806 RID: 55302
	private readonly ILogicalStructure Structure;
}
