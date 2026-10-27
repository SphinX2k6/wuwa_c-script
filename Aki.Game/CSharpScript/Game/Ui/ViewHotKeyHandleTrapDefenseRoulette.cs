using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A2 RID: 18082
	public class ViewHotKeyHandleTrapDefenseRoulette : ViewHotKeyHandleRoulette
	{
		// Token: 0x0602E9EF RID: 190959 RVA: 0x00ACB38A File Offset: 0x00AC958A
		[NullableContext(1)]
		public ViewHotKeyHandleTrapDefenseRoulette(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602E9F0 RID: 190960 RVA: 0x00ACB394 File Offset: 0x00AC9594
		protected override void OnOpenViewImplement()
		{
			TrapDefenseRouletteMainViewProxy trapDefenseRouletteMainViewProxy = new TrapDefenseRouletteMainViewProxy();
			trapDefenseRouletteMainViewProxy.ActionType = (ERouletteActionType)Convert.ToInt32(this.ViewParam[0]);
			RouletteController.Instance.OpenRouletteMainView(trapDefenseRouletteMainViewProxy);
		}
	}
}
