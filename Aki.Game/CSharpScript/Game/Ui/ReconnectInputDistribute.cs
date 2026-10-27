using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200468C RID: 18060
	public class ReconnectInputDistribute : InputDistributeSetup
	{
		// Token: 0x0602E9A2 RID: 190882 RVA: 0x00ACA6FC File Offset: 0x00AC88FC
		public override bool OnRefresh()
		{
			if (!this.IsReConnect())
			{
				return false;
			}
			if (this.CanClickInReconnect())
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新重连状态输入Tag时，可点击鼠标", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTags(new string[]
				{
					"UiInputRoot.MouseInputTag",
					"UiInputRoot.Navigation"
				});
			}
			else
			{
				Log.Instance.Info(ELogModule.Input, ELogAuthor.XXJ, "[InputDistribute]刷新重连状态输入Tag时，禁用所有操作", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.SetInputDistributeTag("BlockAllInputTag");
			}
			return true;
		}

		// Token: 0x0602E9A3 RID: 190883 RVA: 0x00ACA77D File Offset: 0x00AC897D
		private bool CanClickInReconnect()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.NetWorkConfirmBoxView) != null;
		}

		// Token: 0x0602E9A4 RID: 190884 RVA: 0x00ACA791 File Offset: 0x00AC8991
		private bool IsReConnect()
		{
			return ReConnectModel.Instance.GetReConnectStatus() == EReConnectStatus.ReConnectDoing;
		}
	}
}
