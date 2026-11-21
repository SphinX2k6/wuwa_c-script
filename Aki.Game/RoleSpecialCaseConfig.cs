using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021CD RID: 8653
public class RoleSpecialCaseConfig : IStaticVariableResetter
{
	// Token: 0x060154B8 RID: 87224 RVA: 0x0063143E File Offset: 0x0062F63E
	static RoleSpecialCaseConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleSpecialCaseConfig.CreateStaticDefaultValue), new Action(RoleSpecialCaseConfig.ResetStaticDefaultValue));
	}

	// Token: 0x1700203C RID: 8252
	// (get) Token: 0x060154B9 RID: 87225 RVA: 0x0063145D File Offset: 0x0062F65D
	[Nullable(1)]
	public static IReadOnlyDictionary<int, RoleSpecialCaseData> RoleSpecialCaseMap
	{
		[NullableContext(1)]
		get
		{
			return RoleSpecialCaseConfig._roleSpecialCaseMap;
		}
	}

	// Token: 0x060154BA RID: 87226 RVA: 0x00631464 File Offset: 0x0062F664
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

	// Token: 0x060154BB RID: 87227 RVA: 0x006314C9 File Offset: 0x0062F6C9
	public static void ResetStaticDefaultValue()
	{
		RoleSpecialCaseConfig._roleSpecialCaseMap = null;
	}

	// Token: 0x0400B48D RID: 46221
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, RoleSpecialCaseData> _roleSpecialCaseMap;
}
