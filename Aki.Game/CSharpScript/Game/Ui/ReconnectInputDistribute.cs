using System;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035BD RID: 13757
	public class ReconnectInputDistribute : InputDistributeSetup
	{
		// Token: 0x060230EC RID: 143596 RVA: 0x009F8430 File Offset: 0x009F6630
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

		// Token: 0x060230ED RID: 143597 RVA: 0x009F84B1 File Offset: 0x009F66B1
		private bool CanClickInReconnect()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.NetWorkConfirmBoxView) != null;
		}

		// Token: 0x060230EE RID: 143598 RVA: 0x009F84C5 File Offset: 0x009F66C5
		private bool IsReConnect()
		{
			return ReConnectModel.Instance.GetReConnectStatus() == EReConnectStatus.ReConnectDoing;
		}
	}
}
