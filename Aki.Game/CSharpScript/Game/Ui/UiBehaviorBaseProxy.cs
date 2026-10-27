using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004629 RID: 17961
	public class UiBehaviorBaseProxy : ComponentAction
	{
		// Token: 0x0602E43B RID: 189499 RVA: 0x00AB2164 File Offset: 0x00AB0364
		[NullableContext(1)]
		public UiBehaviorBaseProxy(IUiBehavior uiBehaviorBase)
		{
			this.UiBehavior = uiBehaviorBase;
		}

		// Token: 0x0602E43C RID: 189500 RVA: 0x00AB2174 File Offset: 0x00AB0374
		protected override UniTask<bool> OnCreateAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnCreateAsyncImplement>d__2 <OnCreateAsyncImplement>d__;
			<OnCreateAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnCreateAsyncImplement>d__.<>4__this = this;
			<OnCreateAsyncImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnCreateAsyncImplement>d__2>(ref <OnCreateAsyncImplement>d__);
			return <OnCreateAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E43D RID: 189501 RVA: 0x00AB21B8 File Offset: 0x00AB03B8
		protected override UniTask OnStartAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnStartAsyncImplement>d__3 <OnStartAsyncImplement>d__;
			<OnStartAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnStartAsyncImplement>d__.<>4__this = this;
			<OnStartAsyncImplement>d__.<>1__state = -1;
			<OnStartAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnStartAsyncImplement>d__3>(ref <OnStartAsyncImplement>d__);
			return <OnStartAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E43E RID: 189502 RVA: 0x00AB21FC File Offset: 0x00AB03FC
		protected override UniTask OnShowAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnShowAsyncImplement>d__4 <OnShowAsyncImplement>d__;
			<OnShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplement>d__.<>4__this = this;
			<OnShowAsyncImplement>d__.<>1__state = -1;
			<OnShowAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnShowAsyncImplement>d__4>(ref <OnShowAsyncImplement>d__);
			return <OnShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E43F RID: 189503 RVA: 0x00AB2240 File Offset: 0x00AB0440
		protected override UniTask OnHideAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnHideAsyncImplement>d__5 <OnHideAsyncImplement>d__;
			<OnHideAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplement>d__.<>4__this = this;
			<OnHideAsyncImplement>d__.<>1__state = -1;
			<OnHideAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnHideAsyncImplement>d__5>(ref <OnHideAsyncImplement>d__);
			return <OnHideAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E440 RID: 189504 RVA: 0x00AB2284 File Offset: 0x00AB0484
		protected override UniTask OnDestroyAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnDestroyAsyncImplement>d__6 <OnDestroyAsyncImplement>d__;
			<OnDestroyAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnDestroyAsyncImplement>d__6>(ref <OnDestroyAsyncImplement>d__);
			return <OnDestroyAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602E441 RID: 189505 RVA: 0x00AB22C7 File Offset: 0x00AB04C7
		protected override void OnDestroyImplementCompatible()
		{
			if (this.UiBehavior == null)
			{
				return;
			}
			this.UiBehavior.OnBeforeDestroy();
			this.UiBehavior = null;
		}

		// Token: 0x04018D52 RID: 101714
		[Nullable(1)]
		private IUiBehavior UiBehavior;
	}
}
