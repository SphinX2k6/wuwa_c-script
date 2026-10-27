using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02006BBC RID: 27580
	public interface ISimpleGameplayOpenHandler : ISimpleGameplayHandlerBase
	{
		// Token: 0x0604434A RID: 279370
		[NullableContext(1)]
		void Open(IUiGame config, OpenSimpleGameplay parameters, ISimpleGameplayOpenHost host);
	}
}
