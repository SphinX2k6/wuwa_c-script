using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200358C RID: 13708
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewListContainer : UiViewContainer
	{
		// Token: 0x06022F3B RID: 143163 RVA: 0x009EB5DA File Offset: 0x009E97DA
		public UiViewListContainer(List<UiViewBase> viewBaseList)
		{
			this.ViewBaseList = viewBaseList;
		}

		// Token: 0x06022F3C RID: 143164 RVA: 0x009EB5F4 File Offset: 0x009E97F4
		[NullableContext(0)]
		public override UniTask<bool> OpenViewAsync([Nullable(1)] UiViewBase view)
		{
			UiViewListContainer.<OpenViewAsync>d__3 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.view = view;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiViewListContainer.<OpenViewAsync>d__3>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F3D RID: 143165 RVA: 0x009EB640 File Offset: 0x009E9840
		public override UniTask CloseViewAsync(UiViewBase view)
		{
			UiViewListContainer.<CloseViewAsync>d__4 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.view = view;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiViewListContainer.<CloseViewAsync>d__4>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F3E RID: 143166 RVA: 0x009EB68C File Offset: 0x009E988C
		public override void ClearContainer(bool isSeamlessTravel)
		{
			List<UiViewBase> list = new List<UiViewBase>(this.ViewBaseList.Count);
			for (int i = this.ViewBaseList.Count - 1; i >= 0; i--)
			{
				UiViewBase uiViewBase = this.ViewBaseList[i];
				uiViewBase.IsExistInLeaveLevel = true;
				if (!uiViewBase.ViewInfo.IsPermanent)
				{
					this.ViewBaseList.RemoveAt(i);
					list.Add(uiViewBase);
				}
			}
			foreach (UiViewBase uiViewBase2 in list)
			{
				if (!uiViewBase2.IsDestroyOrDestroying)
				{
					base.TryCatchViewDestroyCompatible(uiViewBase2);
				}
			}
		}

		// Token: 0x06022F3F RID: 143167 RVA: 0x009EB744 File Offset: 0x009E9944
		public void CloseAllView()
		{
			for (int i = this.ViewBaseList.Count - 1; i >= 0; i--)
			{
				this.ViewBaseList[i].Destroy(null);
				this.ViewBaseList.RemoveAt(i);
			}
		}

		// Token: 0x06022F40 RID: 143168 RVA: 0x009EB788 File Offset: 0x009E9988
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewListContainer.<PreOpenViewAsync>d__7 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewListContainer.<PreOpenViewAsync>d__7>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F41 RID: 143169 RVA: 0x009EB7CC File Offset: 0x009E99CC
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewListContainer.<OpenViewAfterPreOpenedAsync>d__8 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewListContainer.<OpenViewAfterPreOpenedAsync>d__8>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F42 RID: 143170 RVA: 0x009EB810 File Offset: 0x009E9A10
		public UniTask HideView()
		{
			UiViewListContainer.<HideView>d__9 <HideView>d__;
			<HideView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideView>d__.<>4__this = this;
			<HideView>d__.<>1__state = -1;
			<HideView>d__.<>t__builder.Start<UiViewListContainer.<HideView>d__9>(ref <HideView>d__);
			return <HideView>d__.<>t__builder.Task;
		}

		// Token: 0x06022F43 RID: 143171 RVA: 0x009EB854 File Offset: 0x009E9A54
		public void ShowView()
		{
			foreach (UiViewBase uiViewBase in this.HideViewList)
			{
				if (!uiViewBase.IsDestroyOrDestroying)
				{
					uiViewBase.SetActive(true);
				}
			}
			this.HideViewList.Clear();
		}

		// Token: 0x04013490 RID: 78992
		private readonly List<UiViewBase> ViewBaseList;

		// Token: 0x04013491 RID: 78993
		private readonly List<UiViewBase> HideViewList = new List<UiViewBase>();
	}
}
