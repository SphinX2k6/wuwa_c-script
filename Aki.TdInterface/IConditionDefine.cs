using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
public static class IConditionDefine
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002174 File Offset: 0x00000374
	// Note: this type is marked as 'beforefieldinit'.
	static IConditionDefine()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary["[EConditionCount.All]"] = "全部满足";
		dictionary["[EConditionCount.Any]"] = "任意满足";
		dictionary["[EConditionCount.Two]"] = "满足2个";
		dictionary["[EConditionCount.Three]"] = "满足3个";
		dictionary["[EConditionCount.Four]"] = "满足4个";
		dictionary["[EConditionCount.Five]"] = "满足5个";
		IConditionDefine.countNameMap = dictionary;
	}

	// Token: 0x04000005 RID: 5
	[Nullable(1)]
	public static readonly IReadOnlyDictionary<string, string> countNameMap;
}
