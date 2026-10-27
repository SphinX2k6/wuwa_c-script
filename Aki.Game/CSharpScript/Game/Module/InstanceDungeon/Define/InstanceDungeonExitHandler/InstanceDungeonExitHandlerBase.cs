using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.Define.InstanceDungeonExitHandler
{
	// Token: 0x020058EE RID: 22766
	public abstract class InstanceDungeonExitHandlerBase
	{
		// Token: 0x06039D13 RID: 236819
		public abstract bool Checker();

		// Token: 0x06039D14 RID: 236820
		[NullableContext(2)]
		public abstract void HandleExit(InstanceDungeonExitHandlerData param);
	}
}
