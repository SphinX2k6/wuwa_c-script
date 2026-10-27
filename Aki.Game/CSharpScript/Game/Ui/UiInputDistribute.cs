using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200468E RID: 18062
	public class UiInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E9A8 RID: 190888 RVA: 0x00ACA834 File Offset: 0x00AC8A34
		public override bool OnRefresh()
		{
			if (UiManager.Instance.IsViewShow(UiModel.Instance.MainViewName))
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新UI输入时，主界面已经打开，设置输入分发Tag为 UiInputRootTag", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTag("UiInputRoot");
				return true;
			}
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新UI输入时，主界面没有打开，设置输入分发Tag为 ShortcutKeyTag，MouseInputTag，NavigationTag", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.SetInputDistributeTags(new string[]
			{
				"UiInputRoot.ShortcutKeyTag",
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			});
			return true;
		}
	}
}
