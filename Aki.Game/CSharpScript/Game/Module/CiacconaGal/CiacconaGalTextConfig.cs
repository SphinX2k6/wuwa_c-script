using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BCA RID: 23498
	public class CiacconaGalTextConfig
	{
		// Token: 0x0603B671 RID: 243313 RVA: 0x00E2B028 File Offset: 0x00E29228
		[NullableContext(1)]
		public static string GetTextId(int numberId)
		{
			CiacconaGalText? ciacconaGalText;
			return ((ConfigCiacconaGalTextById.GetConfig(numberId, true) != null) ? ciacconaGalText.GetValueOrDefault().TextId : null) ?? "";
		}
	}
}
