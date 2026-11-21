using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020048C6 RID: 18630
	public abstract class InstanceDungeonExitHandlerBase
	{
		// Token: 0x0602EC36 RID: 191542
		public abstract bool Checker();

		// Token: 0x0602EC37 RID: 191543
		[NullableContext(2)]
		public abstract void HandleExit(InstanceDungeonExitHandlerData param);
	}
}
