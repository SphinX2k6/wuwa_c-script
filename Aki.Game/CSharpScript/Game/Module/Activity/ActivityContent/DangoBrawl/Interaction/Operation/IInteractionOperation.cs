using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x020057C2 RID: 22466
	public interface IInteractionOperation
	{
		// Token: 0x17006ADA RID: 27354
		// (get) Token: 0x06037795 RID: 227221
		EDangoBrawlOptionType Type { get; }

		// Token: 0x06037796 RID: 227222
		bool CanExecute(in OperationContext ctx);

		// Token: 0x06037797 RID: 227223
		UniTask<bool> Execute(in OperationContext ctx);
	}
}
