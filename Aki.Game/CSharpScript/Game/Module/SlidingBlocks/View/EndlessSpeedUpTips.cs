using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02003B3A RID: 15162
	public class EndlessSpeedUpTips : UiPanelBase
	{
		// Token: 0x06026F9F RID: 159647 RVA: 0x00AE93A8 File Offset: 0x00AE75A8
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06026FA0 RID: 159648 RVA: 0x00AE93BC File Offset: 0x00AE75BC
		protected override UniTask OnShowAsyncImplementImplement()
		{
			EndlessSpeedUpTips.<OnShowAsyncImplementImplement>d__2 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<EndlessSpeedUpTips.<OnShowAsyncImplementImplement>d__2>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06026FA1 RID: 159649 RVA: 0x00AE9400 File Offset: 0x00AE7600
		protected override UniTask OnHideAsyncImplementImplement()
		{
			EndlessSpeedUpTips.<OnHideAsyncImplementImplement>d__3 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<EndlessSpeedUpTips.<OnHideAsyncImplementImplement>d__3>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0401549E RID: 87198
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
