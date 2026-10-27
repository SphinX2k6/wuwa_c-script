using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004688 RID: 18056
	public class LoginInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E999 RID: 190873 RVA: 0x00ACA39C File Offset: 0x00AC859C
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

		// Token: 0x0602E99A RID: 190874 RVA: 0x00ACA3F8 File Offset: 0x00AC85F8
		private bool IsLogin()
		{
			return !LoginModel.Instance.IsLoginStatus(LoginDefine.ELoginStatus.EnterGameRet);
		}
	}
}
