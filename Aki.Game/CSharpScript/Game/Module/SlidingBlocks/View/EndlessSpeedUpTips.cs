using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks.View
{
	// Token: 0x02004B90 RID: 19344
	public class EndlessSpeedUpTips : UiPanelBase
	{
		// Token: 0x0603220F RID: 205327 RVA: 0x00BA525C File Offset: 0x00BA345C
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06032210 RID: 205328 RVA: 0x00BA5270 File Offset: 0x00BA3470
		protected override UniTask OnShowAsyncImplementImplement()
		{
			EndlessSpeedUpTips.<OnShowAsyncImplementImplement>d__2 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<EndlessSpeedUpTips.<OnShowAsyncImplementImplement>d__2>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06032211 RID: 205329 RVA: 0x00BA52B4 File Offset: 0x00BA34B4
		protected override UniTask OnHideAsyncImplementImplement()
		{
			EndlessSpeedUpTips.<OnHideAsyncImplementImplement>d__3 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<EndlessSpeedUpTips.<OnHideAsyncImplementImplement>d__3>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0401AB4A RID: 109386
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;
	}
}
