using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02005D36 RID: 23862
	public interface ISimpleGameplayOpenHandler<in TConfig> : ISimpleGameplayOpenHandler, ISimpleGameplayHandlerBase where TConfig : IUiGame
	{
		// Token: 0x0603A4A3 RID: 238755
		[NullableContext(1)]
		void Open(TConfig config, OpenSimpleGameplay parameters, ISimpleGameplayOpenHost host);

		// Token: 0x0603A4A4 RID: 238756 RVA: 0x0107A0C3 File Offset: 0x010782C3
		[NullableContext(1)]
		void Open(IUiGame config, OpenSimpleGameplay parameters, ISimpleGameplayOpenHost host)
		{
			this.Open((TConfig)((object)config), parameters, host);
		}
	}
}
