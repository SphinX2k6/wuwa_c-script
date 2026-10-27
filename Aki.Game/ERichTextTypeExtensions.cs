using System;

// Token: 0x02003557 RID: 13655
public static class ERichTextTypeExtensions
{
	// Token: 0x0601DFAE RID: 122798 RVA: 0x0086CC84 File Offset: 0x0086AE84
	public static string ToEnumString(this ERichTextType value)
	{
		string result;
		switch (value)
		{
		case ERichTextType.PlayerName:
			result = "PlayerName";
			break;
		case ERichTextType.SexChooseName:
			result = "TA";
			break;
		case ERichTextType.SexShowName:
			result = "SexShowName";
			break;
		case ERichTextType.InputType:
			result = "Ipt";
			break;
		case ERichTextType.SingularAndPlural:
			result = "Sap";
			break;
		case ERichTextType.Var:
			result = "Var";
			break;
		default:
			result = value.ToString();
			break;
		}
		return result;
	}

	// Token: 0x0601DFAF RID: 122799 RVA: 0x0086CCF0 File Offset: 0x0086AEF0
	public static ERichTextType FromString(string name)
	{
		ERichTextType result;
		if (!ERichTextTypeExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ERichTextType 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601DFB0 RID: 122800 RVA: 0x0086CD1C File Offset: 0x0086AF1C
	public static bool TryFromString(string name, out ERichTextType value)
	{
		if (string.IsNullOrEmpty(name))
		{
			value = ERichTextType.PlayerName;
			return false;
		}
		if (name == "PlayerName")
		{
			value = ERichTextType.PlayerName;
			return true;
		}
		if (name == "TA")
		{
			value = ERichTextType.SexChooseName;
			return true;
		}
		if (name == "SexShowName")
		{
			value = ERichTextType.SexShowName;
			return true;
		}
		if (name == "Ipt")
		{
			value = ERichTextType.InputType;
			return true;
		}
		if (name == "Sap")
		{
			value = ERichTextType.SingularAndPlural;
			return true;
		}
		if (!(name == "Var"))
		{
			value = ERichTextType.PlayerName;
			return false;
		}
		value = ERichTextType.Var;
		return true;
	}

	// Token: 0x0601DFB1 RID: 122801 RVA: 0x0086CDA8 File Offset: 0x0086AFA8
	public static string[] GetStringValues()
	{
		return new string[]
		{
			"PlayerName",
			"TA",
			"SexShowName",
			"Ipt",
			"Sap",
			"Var"
		};
	}

	// Token: 0x0601DFB2 RID: 122802 RVA: 0x0086CDE0 File Offset: 0x0086AFE0
	public static ERichTextType[] GetValues()
	{
		return new ERichTextType[]
		{
			ERichTextType.PlayerName,
			ERichTextType.SexChooseName,
			ERichTextType.SexShowName,
			ERichTextType.InputType,
			ERichTextType.SingularAndPlural,
			ERichTextType.Var
		};
	}

	// Token: 0x0601DFB3 RID: 122803 RVA: 0x0086CDF3 File Offset: 0x0086AFF3
	public static string[] GetNames()
	{
		return new string[]
		{
			"PlayerName",
			"SexChooseName",
			"SexShowName",
			"InputType",
			"SingularAndPlural",
			"Var"
		};
	}
}
