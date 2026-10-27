using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02006BBA RID: 27578
	[NullableContext(1)]
	public interface ISimpleGameplayOpenHost
	{
		// Token: 0x1700999C RID: 39324
		// (get) Token: 0x06044343 RID: 279363
		GeneralContext Context { get; }

		// Token: 0x1700999D RID: 39325
		// (get) Token: 0x06044344 RID: 279364
		[Nullable(new byte[]
		{
			1,
			2
		})]
		Action<string> SetFinishSendSelfEvent { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; }

		// Token: 0x1700999E RID: 39326
		// (get) Token: 0x06044345 RID: 279365
		[Nullable(new byte[]
		{
			1,
			2
		})]
		Action<string> SetFailSendSelfEvent { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; }

		// Token: 0x1700999F RID: 39327
		// (get) Token: 0x06044346 RID: 279366
		Action<long> SetCreatureDataId { get; }

		// Token: 0x170099A0 RID: 39328
		// (get) Token: 0x06044347 RID: 279367
		Action FinishCallback { get; }

		// Token: 0x170099A1 RID: 39329
		// (get) Token: 0x06044348 RID: 279368
		Action<bool> FinishWithResultCallback { get; }
	}
}
