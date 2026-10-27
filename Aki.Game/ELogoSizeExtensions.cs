using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E25 RID: 3621
public static class ELogoSizeExtensions
{
	// Token: 0x060056F6 RID: 22262 RVA: 0x000FA1E4 File Offset: 0x000F83E4
	[NullableContext(1)]
	public static string ToValue(this ELogoSize size)
	{
		string result;
		switch (size)
		{
		case ELogoSize.Small:
			result = "36";
			break;
		case ELogoSize.Medium:
			result = "40";
			break;
		case ELogoSize.Large:
			result = "52";
			break;
		default:
			result = "36";
			break;
		}
		return result;
	}
}
