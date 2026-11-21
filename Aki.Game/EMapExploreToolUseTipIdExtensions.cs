using System;

// Token: 0x02002AC4 RID: 10948
public static class EMapExploreToolUseTipIdExtensions
{
	// Token: 0x0601BCB2 RID: 113842 RVA: 0x0088E030 File Offset: 0x0088C230
	public static string ToEnumString(this EMapExploreToolUseTipId value)
	{
		string result;
		if (value != EMapExploreToolUseTipId.MapExploreToolDeploySuccess)
		{
			if (value != EMapExploreToolUseTipId.SoundBoxUseReachLimit)
			{
				result = value.ToString();
			}
			else
			{
				result = "ShengXiaDetectTip";
			}
		}
		else
		{
			result = "ExploreDeploySuccess";
		}
		return result;
	}

	// Token: 0x0601BCB3 RID: 113843 RVA: 0x0088E068 File Offset: 0x0088C268
	public static EMapExploreToolUseTipId FromString(string name)
	{
		EMapExploreToolUseTipId result;
		if (!EMapExploreToolUseTipIdExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EMapExploreToolUseTipId 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601BCB4 RID: 113844 RVA: 0x0088E091 File Offset: 0x0088C291
	public static bool TryFromString(string name, out EMapExploreToolUseTipId value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = EMapExploreToolUseTipId.MapExploreToolDeploySuccess;
			return false;
		}
		if (name == "ExploreDeploySuccess")
		{
			value = EMapExploreToolUseTipId.MapExploreToolDeploySuccess;
			return true;
		}
		if (!(name == "ShengXiaDetectTip"))
		{
			value = EMapExploreToolUseTipId.MapExploreToolDeploySuccess;
			return false;
		}
		value = EMapExploreToolUseTipId.SoundBoxUseReachLimit;
		return true;
	}

	// Token: 0x0601BCB5 RID: 113845 RVA: 0x0088E0CA File Offset: 0x0088C2CA
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"ExploreDeploySuccess",
			"ShengXiaDetectTip"
		};
	}

	// Token: 0x0601BCB6 RID: 113846 RVA: 0x0088E0E2 File Offset: 0x0088C2E2
	public static EMapExploreToolUseTipId[] GetValues()
	{
		return new EMapExploreToolUseTipId[]
		{
			EMapExploreToolUseTipId.MapExploreToolDeploySuccess,
			EMapExploreToolUseTipId.SoundBoxUseReachLimit
		};
	}

	// Token: 0x0601BCB7 RID: 113847 RVA: 0x0088E0EE File Offset: 0x0088C2EE
	public static string[] GetNames()
	{
		return new string[]
		{
			"MapExploreToolDeploySuccess",
			"SoundBoxUseReachLimit"
		};
	}
}
