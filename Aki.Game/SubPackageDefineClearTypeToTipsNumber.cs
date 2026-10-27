using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A98 RID: 10904
public static class SubPackageDefineClearTypeToTipsNumber
{
	// Token: 0x06016B2A RID: 92970 RVA: 0x005C08EA File Offset: 0x005BEAEA
	// Note: this type is marked as 'beforefieldinit'.
	static SubPackageDefineClearTypeToTipsNumber()
	{
		Dictionary<ESubPackageDownLoadPackageType, int> dictionary = new Dictionary<ESubPackageDownLoadPackageType, int>();
		dictionary[ESubPackageDownLoadPackageType.Key] = 0;
		dictionary[ESubPackageDownLoadPackageType.Expand] = 0;
		dictionary[ESubPackageDownLoadPackageType.OptionalPlot] = 1;
		dictionary[ESubPackageDownLoadPackageType.OptionalScene] = 2;
		dictionary[ESubPackageDownLoadPackageType.Voice] = 3;
		SubPackageDefineClearTypeToTipsNumber.clearTypeToTipsNumber = dictionary;
	}

	// Token: 0x0400A876 RID: 43126
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static Dictionary<ESubPackageDownLoadPackageType, int> clearTypeToTipsNumber;
}
