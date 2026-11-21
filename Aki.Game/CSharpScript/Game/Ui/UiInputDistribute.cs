using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035BF RID: 13759
	public class UiInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230F2 RID: 143602 RVA: 0x009F8568 File Offset: 0x009F6768
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
