using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C74 RID: 11380
public class RoleSpecialCaseConfig : IStaticVariableResetter
{
	// Token: 0x06017C46 RID: 97350 RVA: 0x0060B996 File Offset: 0x00609B96
	static RoleSpecialCaseConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSpecialCaseConfig.CreateStaticDefaultValue), new Action(RoleSpecialCaseConfig.ResetStaticDefaultValue));
	}

	// Token: 0x17001FEB RID: 8171
	// (get) Token: 0x06017C47 RID: 97351 RVA: 0x0060B9B5 File Offset: 0x00609BB5
	[Nullable(1)]
	public static IReadOnlyDictionary<int, RoleSpecialCaseData> RoleSpecialCaseMap
	{
		[NullableContext(1)]
		get
		{
			return RoleSpecialCaseConfig._roleSpecialCaseMap;
		}
	}

	// Token: 0x06017C48 RID: 97352 RVA: 0x0060B9BC File Offset: 0x00609BBC
	public static void CreateStaticDefaultValue()
	{
		Dictionary<int, RoleSpecialCaseData> dictionary = new Dictionary<int, RoleSpecialCaseData>();
		dictionary[1309] = new RoleSpecialCaseData
		{
			Tags = new string[]
			{
				"角色.R2T1ThunderNanzhuMd10011.角色ui.雷漂泊者.男"
			}
		};
		dictionary[1310] = new RoleSpecialCaseData
		{
			Tags = new string[]
			{
				"角色.R2T1ThunderNanzhuMd10011.角色ui.雷漂泊者.女"
			}
		};
		RoleSpecialCaseConfig._roleSpecialCaseMap = dictionary;
	}

	// Token: 0x06017C49 RID: 97353 RVA: 0x0060BA21 File Offset: 0x00609C21
	public static void ResetStaticDefaultValue()
	{
		RoleSpecialCaseConfig._roleSpecialCaseMap = null;
	}

	// Token: 0x0400B122 RID: 45346
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, RoleSpecialCaseData> _roleSpecialCaseMap;
}
