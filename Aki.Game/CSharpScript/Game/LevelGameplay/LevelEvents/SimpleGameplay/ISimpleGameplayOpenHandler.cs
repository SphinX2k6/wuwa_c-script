using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02005D35 RID: 23861
	public interface ISimpleGameplayOpenHandler : ISimpleGameplayHandlerBase
	{
		// Token: 0x0603A4A2 RID: 238754
		[NullableContext(1)]
		void Open(IUiGame config, OpenSimpleGameplay parameters, ISimpleGameplayOpenHost host);
	}
}
