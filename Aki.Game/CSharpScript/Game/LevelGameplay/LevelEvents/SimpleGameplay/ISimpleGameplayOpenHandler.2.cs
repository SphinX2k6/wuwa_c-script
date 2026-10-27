using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02006BBD RID: 27581
	public interface ISimpleGameplayOpenHandler<in TConfig> : ISimpleGameplayOpenHandler, ISimpleGameplayHandlerBase where TConfig : IUiGame
	{
		// Token: 0x0604434B RID: 279371
		[NullableContext(1)]
		void Open(TConfig config, OpenSimpleGameplay parameters, ISimpleGameplayOpenHost host);

		// Token: 0x0604434C RID: 279372 RVA: 0x010D016F File Offset: 0x010CE36F
		[NullableContext(1)]
		void Open(IUiGame config, OpenSimpleGameplay parameters, ISimpleGameplayOpenHost host)
		{
			this.Open((TConfig)((object)config), parameters, host);
		}
	}
}
