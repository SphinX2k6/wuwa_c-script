using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BAA RID: 19370
	public class CiacconaGalTextConfig
	{
		// Token: 0x060305BD RID: 198077 RVA: 0x00D7B31C File Offset: 0x00D7951C
		[NullableContext(1)]
		public static string GetTextId(int numberId)
		{
			CiacconaGalText? ciacconaGalText;
			return ((ConfigCiacconaGalTextById.GetConfig(numberId, true) != null) ? ciacconaGalText.GetValueOrDefault().TextId : null) ?? "";
		}
	}
}
