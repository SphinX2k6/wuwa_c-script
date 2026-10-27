using System;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation
{
	// Token: 0x02006872 RID: 26738
	public interface IInteractionOperation
	{
		// Token: 0x17009799 RID: 38809
		// (get) Token: 0x06042C3E RID: 273470
		EDangoBrawlOptionType Type { get; }

		// Token: 0x06042C3F RID: 273471
		bool CanExecute(in OperationContext ctx);

		// Token: 0x06042C40 RID: 273472
		UniTask<bool> Execute(in OperationContext ctx);
	}
}
