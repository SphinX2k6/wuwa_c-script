using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x02005404 RID: 21508
	public class MenuTool
	{
		// Token: 0x06036F5C RID: 225116 RVA: 0x00D05015 File Offset: 0x00D03215
		[NullableContext(1)]
		public static IReadOnlyList<LanguageDefine> GetLanguageDefineData()
		{
			return LanguageSystem.Instance.GetAllLanguageDefines();
		}
	}
}
