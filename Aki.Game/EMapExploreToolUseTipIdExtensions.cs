using System;

// Token: 0x0200354F RID: 13647
public static class EMapExploreToolUseTipIdExtensions
{
	// Token: 0x0601DF8A RID: 122762 RVA: 0x008664C8 File Offset: 0x008646C8
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

	// Token: 0x0601DF8B RID: 122763 RVA: 0x00866500 File Offset: 0x00864700
	public static EMapExploreToolUseTipId FromString(string name)
	{
		EMapExploreToolUseTipId result;
		if (!EMapExploreToolUseTipIdExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 EMapExploreToolUseTipId 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601DF8C RID: 122764 RVA: 0x00866529 File Offset: 0x00864729
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

	// Token: 0x0601DF8D RID: 122765 RVA: 0x00866562 File Offset: 0x00864762
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"ExploreDeploySuccess",
			"ShengXiaDetectTip"
		};
	}

	// Token: 0x0601DF8E RID: 122766 RVA: 0x0086657A File Offset: 0x0086477A
	public static EMapExploreToolUseTipId[] GetValues()
	{
		return new EMapExploreToolUseTipId[]
		{
			EMapExploreToolUseTipId.MapExploreToolDeploySuccess,
			EMapExploreToolUseTipId.SoundBoxUseReachLimit
		};
	}

	// Token: 0x0601DF8F RID: 122767 RVA: 0x00866586 File Offset: 0x00864786
	public static string[] GetNames()
	{
		return new string[]
		{
			"MapExploreToolDeploySuccess",
			"SoundBoxUseReachLimit"
		};
	}
}
