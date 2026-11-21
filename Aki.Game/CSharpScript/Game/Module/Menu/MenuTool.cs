using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E7 RID: 17383
	public class MenuTool
	{
		// Token: 0x0602BEA4 RID: 179876 RVA: 0x00C54459 File Offset: 0x00C52659
		[NullableContext(1)]
		public static IReadOnlyList<LanguageDefine> GetLanguageDefineData()
		{
			return LanguageSystem.Instance.GetAllLanguageDefines();
		}
	}
}
