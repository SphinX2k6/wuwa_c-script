using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Mode
{
	// Token: 0x0200687B RID: 26747
	[NullableContext(1)]
	public interface IInteractionMode
	{
		// Token: 0x170097A8 RID: 38824
		// (get) Token: 0x06042C7B RID: 273531
		EInteractionModeKind Kind { get; }

		// Token: 0x170097A9 RID: 38825
		// (get) Token: 0x06042C7C RID: 273532
		bool IsActive { get; }

		// Token: 0x170097AA RID: 38826
		// (get) Token: 0x06042C7D RID: 273533
		ICommitStrategy CommitStrategy { get; }

		// Token: 0x06042C7E RID: 273534
		bool AllowInteract(int configId);

		// Token: 0x06042C7F RID: 273535
		bool AllowBuyShopSlot();

		// Token: 0x06042C80 RID: 273536
		bool TryEnter();

		// Token: 0x06042C81 RID: 273537
		[NullableContext(0)]
		UniTask<bool> TryExit();

		// Token: 0x06042C82 RID: 273538
		void Discard();

		// Token: 0x06042C83 RID: 273539
		void EnqueueBagToBench(int uid);
	}
}
