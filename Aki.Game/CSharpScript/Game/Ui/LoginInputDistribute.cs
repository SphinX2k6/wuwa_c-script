using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035B9 RID: 13753
	public class LoginInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230E3 RID: 143587 RVA: 0x009F80D0 File Offset: 0x009F62D0
		public override bool OnRefresh()
		{
			if (WorldModel.Instance.IsStandalone || !this.IsLogin())
			{
				return false;
			}
			Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新登录状态输入Tag时", default(ReadOnlySpan<ValueTuple<string, object>>));
			base.SetInputDistributeTags(new string[]
			{
				"UiInputRoot.MouseInputTag",
				"UiInputRoot.Navigation"
			});
			return true;
		}

		// Token: 0x060230E4 RID: 143588 RVA: 0x009F812C File Offset: 0x009F632C
		private bool IsLogin()
		{
			return !LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.EnterGameRet);
		}
	}
}
