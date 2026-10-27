using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleLangCustomModel;

// Token: 0x02002868 RID: 10344
public class RoleFavorUtil
{
	// Token: 0x060154CC RID: 87244 RVA: 0x005611E0 File Offset: 0x0055F3E0
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
