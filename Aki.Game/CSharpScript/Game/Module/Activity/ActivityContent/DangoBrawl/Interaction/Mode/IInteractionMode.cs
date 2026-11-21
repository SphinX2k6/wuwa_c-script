using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x020057CB RID: 22475
	[NullableContext(1)]
	public interface IInteractionMode
	{
		// Token: 0x17006AE9 RID: 27369
		// (get) Token: 0x060377D2 RID: 227282
		EInteractionModeKind Kind { get; }

		// Token: 0x17006AEA RID: 27370
		// (get) Token: 0x060377D3 RID: 227283
		bool IsActive { get; }

		// Token: 0x17006AEB RID: 27371
		// (get) Token: 0x060377D4 RID: 227284
		ICommitStrategy CommitStrategy { get; }

		// Token: 0x060377D5 RID: 227285
		bool AllowInteract(int configId);

		// Token: 0x060377D6 RID: 227286
		bool AllowBuyShopSlot();

		// Token: 0x060377D7 RID: 227287
		bool TryEnter();

		// Token: 0x060377D8 RID: 227288
		[NullableContext(0)]
		UniTask<bool> TryExit();

		// Token: 0x060377D9 RID: 227289
		void Discard();

		// Token: 0x060377DA RID: 227290
		void EnqueueBagToBench(int uid);
	}
}
