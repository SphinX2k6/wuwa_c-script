using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004681 RID: 18049
	public class CreateCharacterInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E986 RID: 190854 RVA: 0x00AC9B0C File Offset: 0x00AC7D0C
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
