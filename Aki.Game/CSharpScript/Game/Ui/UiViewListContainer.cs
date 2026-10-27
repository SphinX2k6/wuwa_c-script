using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200465B RID: 18011
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewListContainer : UiViewContainer
	{
		// Token: 0x0602E7F1 RID: 190449 RVA: 0x00ABDF5A File Offset: 0x00ABC15A
		public UiViewListContainer(List<UiViewBase> viewBaseList)
		{
			this.ViewBaseList = viewBaseList;
		}

		// Token: 0x0602E7F2 RID: 190450 RVA: 0x00ABDF74 File Offset: 0x00ABC174
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

		// Token: 0x0602E7F3 RID: 190451 RVA: 0x00ABDFC0 File Offset: 0x00ABC1C0
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

		// Token: 0x0602E7F4 RID: 190452 RVA: 0x00ABE00C File Offset: 0x00ABC20C
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

		// Token: 0x0602E7F5 RID: 190453 RVA: 0x00ABE0C4 File Offset: 0x00ABC2C4
		public void CloseAllView()
		{
			for (int i = this.ViewBaseList.Count - 1; i >= 0; i--)
			{
				this.ViewBaseList[i].Destroy(null);
				this.ViewBaseList.RemoveAt(i);
			}
		}

		// Token: 0x0602E7F6 RID: 190454 RVA: 0x00ABE108 File Offset: 0x00ABC308
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewListContainer.<PreOpenViewAsync>d__7 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewListContainer.<PreOpenViewAsync>d__7>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7F7 RID: 190455 RVA: 0x00ABE14C File Offset: 0x00ABC34C
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewListContainer.<OpenViewAfterPreOpenedAsync>d__8 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewListContainer.<OpenViewAfterPreOpenedAsync>d__8>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7F8 RID: 190456 RVA: 0x00ABE190 File Offset: 0x00ABC390
		public UniTask HideView()
		{
			UiViewListContainer.<HideView>d__9 <HideView>d__;
			<HideView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<HideView>d__.<>4__this = this;
			<HideView>d__.<>1__state = -1;
			<HideView>d__.<>t__builder.Start<UiViewListContainer.<HideView>d__9>(ref <HideView>d__);
			return <HideView>d__.<>t__builder.Task;
		}

		// Token: 0x0602E7F9 RID: 190457 RVA: 0x00ABE1D4 File Offset: 0x00ABC3D4
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

		// Token: 0x04018E37 RID: 101943
		private readonly List<UiViewBase> ViewBaseList;

		// Token: 0x04018E38 RID: 101944
		private readonly List<UiViewBase> HideViewList = new List<UiViewBase>();
	}
}
