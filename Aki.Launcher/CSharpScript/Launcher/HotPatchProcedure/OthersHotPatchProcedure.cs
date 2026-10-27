using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.Ui.HotFix;
using CSharpScript.Launcher.Update;

namespace CSharpScript.Launcher.HotPatchProcedure
{
	// Token: 0x020001D8 RID: 472
	public class OthersHotPatchProcedure : BaseHotPatchProcedure
	{
		// Token: 0x06000C87 RID: 3207 RVA: 0x0004CB5E File Offset: 0x0004AD5E
		[NullableContext(1)]
		public OthersHotPatchProcedure(AppPathMisc pathMisc, HotFixManager viewMgr) : base(pathMisc, viewMgr)
		{
		}
	}
}
