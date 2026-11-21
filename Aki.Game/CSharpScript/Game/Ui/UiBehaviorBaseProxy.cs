using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003553 RID: 13651
	public class UiBehaviorBaseProxy : ComponentAction
	{
		// Token: 0x06022B4E RID: 142158 RVA: 0x009DEEF5 File Offset: 0x009DD0F5
		[NullableContext(1)]
		public UiBehaviorBaseProxy(IUiBehavior uiBehaviorBase)
		{
			this.UiBehavior = uiBehaviorBase;
		}

		// Token: 0x06022B4F RID: 142159 RVA: 0x009DEF04 File Offset: 0x009DD104
		protected override UniTask<bool> OnCreateAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnCreateAsyncImplement>d__2 <OnCreateAsyncImplement>d__;
			<OnCreateAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnCreateAsyncImplement>d__.<>4__this = this;
			<OnCreateAsyncImplement>d__.<>1__state = -1;
			<OnCreateAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnCreateAsyncImplement>d__2>(ref <OnCreateAsyncImplement>d__);
			return <OnCreateAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022B50 RID: 142160 RVA: 0x009DEF48 File Offset: 0x009DD148
		protected override UniTask OnStartAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnStartAsyncImplement>d__3 <OnStartAsyncImplement>d__;
			<OnStartAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnStartAsyncImplement>d__.<>4__this = this;
			<OnStartAsyncImplement>d__.<>1__state = -1;
			<OnStartAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnStartAsyncImplement>d__3>(ref <OnStartAsyncImplement>d__);
			return <OnStartAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022B51 RID: 142161 RVA: 0x009DEF8C File Offset: 0x009DD18C
		protected override UniTask OnShowAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnShowAsyncImplement>d__4 <OnShowAsyncImplement>d__;
			<OnShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplement>d__.<>4__this = this;
			<OnShowAsyncImplement>d__.<>1__state = -1;
			<OnShowAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnShowAsyncImplement>d__4>(ref <OnShowAsyncImplement>d__);
			return <OnShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022B52 RID: 142162 RVA: 0x009DEFD0 File Offset: 0x009DD1D0
		protected override UniTask OnHideAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnHideAsyncImplement>d__5 <OnHideAsyncImplement>d__;
			<OnHideAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplement>d__.<>4__this = this;
			<OnHideAsyncImplement>d__.<>1__state = -1;
			<OnHideAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnHideAsyncImplement>d__5>(ref <OnHideAsyncImplement>d__);
			return <OnHideAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022B53 RID: 142163 RVA: 0x009DF014 File Offset: 0x009DD214
		protected override UniTask OnDestroyAsyncImplement()
		{
			UiBehaviorBaseProxy.<OnDestroyAsyncImplement>d__6 <OnDestroyAsyncImplement>d__;
			<OnDestroyAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnDestroyAsyncImplement>d__.<>4__this = this;
			<OnDestroyAsyncImplement>d__.<>1__state = -1;
			<OnDestroyAsyncImplement>d__.<>t__builder.Start<UiBehaviorBaseProxy.<OnDestroyAsyncImplement>d__6>(ref <OnDestroyAsyncImplement>d__);
			return <OnDestroyAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06022B54 RID: 142164 RVA: 0x009DF057 File Offset: 0x009DD257
		protected override void OnDestroyImplementCompatible()
		{
			if (this.UiBehavior == null)
			{
				return;
			}
			this.UiBehavior.OnDestroy();
			this.UiBehavior = null;
		}

		// Token: 0x0401339F RID: 78751
		[Nullable(1)]
		private IUiBehavior UiBehavior;
	}
}
