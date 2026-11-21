using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002014 RID: 8212
public static class SubPackageDefineClearTypeToTipsNumber
{
	// Token: 0x06014554 RID: 83284 RVA: 0x005ECEFA File Offset: 0x005EB0FA
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

	// Token: 0x0400AC7C RID: 44156
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	public static Dictionary<ESubPackageDownLoadPackageType, int> clearTypeToTipsNumber;
}
