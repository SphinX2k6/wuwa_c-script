using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200465A RID: 18010
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class UiViewContainer
	{
		// Token: 0x0602E7E5 RID: 190437 RVA: 0x00ABDD88 File Offset: 0x00ABBF88
		protected UniTask OpenViewImplementAsync(UiViewBase view)
		{
			UiViewContainer.<OpenViewImplementAsync>d__1 <OpenViewImplementAsync>d__;
			<OpenViewImplementAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewImplementAsync>d__.<>4__this = this;
			<OpenViewImplementAsync>d__.view = view;
			<OpenViewImplementAsync>d__.<>1__state = -1;
			<OpenViewImplementAsync>d__.<>t__builder.Start<UiViewContainer.<OpenViewImplementAsync>d__1>(ref <OpenViewImplementAsync>d__);
			return <OpenViewImplementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7E6 RID: 190438 RVA: 0x00ABDDD4 File Offset: 0x00ABBFD4
		[NullableContext(0)]
		protected UniTask<bool> CloseViewImplementAsync([Nullable(1)] UiViewBase view)
		{
			UiViewContainer.<CloseViewImplementAsync>d__2 <CloseViewImplementAsync>d__;
			<CloseViewImplementAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseViewImplementAsync>d__.view = view;
			<CloseViewImplementAsync>d__.<>1__state = -1;
			<CloseViewImplementAsync>d__.<>t__builder.Start<UiViewContainer.<CloseViewImplementAsync>d__2>(ref <CloseViewImplementAsync>d__);
			return <CloseViewImplementAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7E7 RID: 190439 RVA: 0x00ABDE17 File Offset: 0x00ABC017
		protected bool IsIgnoreOpenViewMask(UiViewBase view)
		{
			return (UiConfig.Instance.TryGetViewInfo(view.ViewInfo.Name).Type & (ELayerType.Float | ELayerType.Guide)) > (ELayerType)0;
		}

		// Token: 0x0602E7E8 RID: 190440 RVA: 0x00ABDE3C File Offset: 0x00ABC03C
		protected void OnContainerOpenView(UiViewBase view)
		{
			UiPopViewData uiPopViewData = view.OpenParam as UiPopViewData;
			if (uiPopViewData != null && !uiPopViewData.NotAddChildToTopStackView)
			{
				UiViewBase uiViewBase = UiModel.Instance.NormalStack.Peek();
				if (uiViewBase != null)
				{
					uiViewBase.AddChild(view);
				}
			}
		}

		// Token: 0x0602E7E9 RID: 190441 RVA: 0x00ABDE7C File Offset: 0x00ABC07C
		protected unsafe void TryCatchViewDestroyCompatible(UiViewBase view)
		{
			try
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiViewContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "[Clear] 尝试执行销毁的界面";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", view.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", view.ComponentId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				view.ClearAsync();
			}
			catch (Exception ex)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiViewContainer;
				ELogAuthor author2 = ELogAuthor.XXJ;
				string message2 = "界面同步关闭异常,业务变量可能未初始化完成,需要关注";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x0602E7EA RID: 190442
		[NullableContext(0)]
		public abstract UniTask<bool> OpenViewAsync([Nullable(1)] UiViewBase view);

		// Token: 0x0602E7EB RID: 190443
		public abstract UniTask PreOpenViewAsync(UiViewBase view);

		// Token: 0x0602E7EC RID: 190444
		public abstract UniTask OpenViewAfterPreOpenedAsync(UiViewBase view);

		// Token: 0x0602E7ED RID: 190445
		public abstract UniTask CloseViewAsync(UiViewBase view);

		// Token: 0x0602E7EE RID: 190446
		public abstract void ClearContainer(bool isSeamlessTravel);

		// Token: 0x0602E7EF RID: 190447 RVA: 0x00ABDF40 File Offset: 0x00ABC140
		public virtual UniTask BeforeClearContainerAsync(bool isSeamlessTravel)
		{
			return UniTask.CompletedTask;
		}

		// Token: 0x04018E36 RID: 101942
		protected UiMask OpenViewMask = new UiMask();
	}
}
