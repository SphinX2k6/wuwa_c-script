using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D3 RID: 13779
	public class ViewHotKeyHandleTrapDefenseRoulette : ViewHotKeyHandleRoulette
	{
		// Token: 0x0602313B RID: 143675 RVA: 0x009F9C5E File Offset: 0x009F7E5E
		[NullableContext(1)]
		public ViewHotKeyHandleTrapDefenseRoulette(IOpenAndCloseViewHotKey parameters) : base(parameters)
		{
		}

		// Token: 0x0602313C RID: 143676 RVA: 0x009F9C68 File Offset: 0x009F7E68
		protected override void OnOpenViewImplement()
		{
			TrapDefenseRouletteMainViewProxy trapDefenseRouletteMainViewProxy = new TrapDefenseRouletteMainViewProxy();
			trapDefenseRouletteMainViewProxy.ActionType = (ERouletteActionType)Convert.ToInt32(this.ViewParam[0]);
			RouletteController.Instance.OpenRouletteMainView(trapDefenseRouletteMainViewProxy);
		}
	}
}
