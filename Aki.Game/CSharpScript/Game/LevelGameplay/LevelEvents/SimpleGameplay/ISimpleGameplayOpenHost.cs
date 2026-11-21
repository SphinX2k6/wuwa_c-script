using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay
{
	// Token: 0x02005D33 RID: 23859
	[NullableContext(1)]
	public interface ISimpleGameplayOpenHost
	{
		// Token: 0x17006E9F RID: 28319
		// (get) Token: 0x0603A49B RID: 238747
		GeneralContext Context { get; }

		// Token: 0x17006EA0 RID: 28320
		// (get) Token: 0x0603A49C RID: 238748
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

		// Token: 0x17006EA1 RID: 28321
		// (get) Token: 0x0603A49D RID: 238749
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

		// Token: 0x17006EA2 RID: 28322
		// (get) Token: 0x0603A49E RID: 238750
		Action<long> SetCreatureDataId { get; }

		// Token: 0x17006EA3 RID: 28323
		// (get) Token: 0x0603A49F RID: 238751
		Action FinishCallback { get; }

		// Token: 0x17006EA4 RID: 28324
		// (get) Token: 0x0603A4A0 RID: 238752
		Action<bool> FinishWithResultCallback { get; }
	}
}
