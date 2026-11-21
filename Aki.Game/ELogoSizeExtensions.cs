using System;
using System.Runtime.CompilerServices;

// Token: 0x020002DA RID: 730
public static class ELogoSizeExtensions
{
	// Token: 0x06002A86 RID: 10886 RVA: 0x001019CC File Offset: 0x000FFBCC
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
