using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleLangCustomModel;

// Token: 0x02001DE3 RID: 7651
public class RoleFavorUtil
{
	// Token: 0x06012ECA RID: 77514 RVA: 0x0058BF3C File Offset: 0x0058A13C
	[NullableContext(1)]
	public static string GetCurLanguageCvName(int roleId)
	{
		FavorRoleInfo? favorRoleInfoConfig = RoleFavorConfig.Instance.GetFavorRoleInfoConfig(roleId);
		if (favorRoleInfoConfig == null)
		{
			return "";
		}
		int roleLangType = RoleLangCustomModel.Instance.GetRoleLangType(roleId);
		string audioCode = LanguageSystem.Instance.GetLanguageDefineByType(roleLangType).AudioCode;
		if (audioCode == "zh")
		{
			return favorRoleInfoConfig.Value.CVNameCn;
		}
		if (audioCode == "ja")
		{
			return favorRoleInfoConfig.Value.CVNameJp;
		}
		if (audioCode == "en")
		{
			return favorRoleInfoConfig.Value.CVNameEn;
		}
		if (!(audioCode == "ko"))
		{
			return favorRoleInfoConfig.Value.CVNameCn;
		}
		return favorRoleInfoConfig.Value.CVNameKo;
	}
}
