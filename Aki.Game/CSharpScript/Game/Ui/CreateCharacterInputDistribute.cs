using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035B2 RID: 13746
	public class CreateCharacterInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230D0 RID: 143568 RVA: 0x009F7840 File Offset: 0x009F5A40
		public override bool OnRefresh()
		{
			if (!UiManager.Instance.IsViewShow(EUiViewName.CreateCharacterView))
			{
				return false;
			}
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]在创角中，则设置输入分发tag为 UiInputRootTag", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.SetInputDistributeTag("UiInputRoot");
			return true;
		}
	}
}
