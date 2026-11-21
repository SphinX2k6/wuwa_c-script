using System;

// Token: 0x02002ACC RID: 10956
public static class ERichTextTypeExtensions
{
	// Token: 0x0601BCD6 RID: 113878 RVA: 0x008948E4 File Offset: 0x00892AE4
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

	// Token: 0x0601BCD7 RID: 113879 RVA: 0x00894950 File Offset: 0x00892B50
	public static ERichTextType FromString(string name)
	{
		ERichTextType result;
		if (!ERichTextTypeExtensions.TryFromString(name, out result))
		{
			throw new InvalidCastException("从字符串转成枚举 ERichTextType 失败, 字符串: " + name);
		}
		return result;
	}

	// Token: 0x0601BCD8 RID: 113880 RVA: 0x0089497C File Offset: 0x00892B7C
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

	// Token: 0x0601BCD9 RID: 113881 RVA: 0x00894A08 File Offset: 0x00892C08
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

	// Token: 0x0601BCDA RID: 113882 RVA: 0x00894A40 File Offset: 0x00892C40
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

	// Token: 0x0601BCDB RID: 113883 RVA: 0x00894A53 File Offset: 0x00892C53
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
