using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200358D RID: 13709
	[NullableContext(1)]
	[Nullable(0)]
	public class UiViewPlotContainer : UiViewContainer
	{
		// Token: 0x06022F44 RID: 143172 RVA: 0x009EB8BC File Offset: 0x009E9ABC
		private void PushView(UiViewBase view)
		{
			this.Stack.Push(view);
		}

		// Token: 0x06022F45 RID: 143173 RVA: 0x009EB8CC File Offset: 0x009E9ACC
		[NullableContext(2)]
		private UiViewBase PopView()
		{
			UiViewBase uiViewBase = this.Stack.Pop();
			if (uiViewBase == null)
			{
				Log.Instance.Error(ELogModule.PlotContainer, ELogAuthor.XXJ, "PlotContainer_PopView 出栈失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return uiViewBase;
		}

		// Token: 0x06022F46 RID: 143174 RVA: 0x009EB90C File Offset: 0x009E9B0C
		private bool DeleteView(UiViewBase view)
		{
			bool flag = this.Stack.Delete(view);
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PlotContainer;
				ELogAuthor author = ELogAuthor.XXJ;
				string message = "PlotContainer_DeleteView删除界面不在栈内";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return flag;
		}

		// Token: 0x06022F47 RID: 143175 RVA: 0x009EB961 File Offset: 0x009E9B61
		public UiViewPlotContainer(global::Stack<UiViewBase> stack)
		{
			this.Stack = stack;
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x06022F48 RID: 143176 RVA: 0x009EB97B File Offset: 0x009E9B7B
		private bool IsLock
		{
			get
			{
				return this.Operating;
			}
		}

		// Token: 0x06022F49 RID: 143177 RVA: 0x009EB983 File Offset: 0x009E9B83
		private void Lock()
		{
			this.Operating = true;
			this.LockOperationPromise = new CustomPromise();
		}

		// Token: 0x06022F4A RID: 143178 RVA: 0x009EB997 File Offset: 0x009E9B97
		private void Unlock(bool needHandlePending = true)
		{
			this.Operating = false;
			CustomPromise lockOperationPromise = this.LockOperationPromise;
			if (lockOperationPromise != null)
			{
				lockOperationPromise.SetResult();
			}
			this.LockOperationPromise = null;
			if (needHandlePending)
			{
				this.ProcessViewPending();
			}
		}

		// Token: 0x06022F4B RID: 143179 RVA: 0x009EB9C4 File Offset: 0x009E9BC4
		private unsafe UiViewPending AddPendingView(UiViewBase view, EViewPendingType type)
		{
			UiViewPending uiViewPending = new UiViewPending(view, type, null);
			if (this.ViewPendingList.Count > 0)
			{
				UiViewPending uiViewPending2 = this.ViewPendingList[this.ViewPendingList.Count - 1];
				if (uiViewPending2.Equal(uiViewPending))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PlotContainer;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "界面缓存操做重复";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					CustomPromise<bool> executePromise = uiViewPending.ExecutePromise;
					if (executePromise != null)
					{
						executePromise.SetResult(true);
					}
					return uiViewPending;
				}
				if (uiViewPending2.IsPairWith(uiViewPending))
				{
					this.ViewPendingList.RemoveAt(this.ViewPendingList.Count - 1);
					UiManager.Instance.RemoveView(view.GetViewId());
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.PlotContainer;
					ELogAuthor author2 = ELogAuthor.XXJ;
					string message2 = "界面缓存操作成对, 自动移除上一个";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ViewName", view.ViewInfo.Name);
					instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					CustomPromise<bool> executePromise2 = uiViewPending.ExecutePromise;
					if (executePromise2 != null)
					{
						executePromise2.SetResult(true);
					}
					return uiViewPending;
				}
			}
			this.ViewPendingList.Add(uiViewPending);
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.PlotContainer;
			ELogAuthor author3 = ELogAuthor.XXJ;
			string message3 = "缓存界面操作";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("界面", view.ViewInfo.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("操作类型", type);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return uiViewPending;
		}

		// Token: 0x06022F4C RID: 143180 RVA: 0x009EBB54 File Offset: 0x009E9D54
		private UniTask ProcessViewPending()
		{
			UiViewPlotContainer.<ProcessViewPending>d__13 <ProcessViewPending>d__;
			<ProcessViewPending>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ProcessViewPending>d__.<>4__this = this;
			<ProcessViewPending>d__.<>1__state = -1;
			<ProcessViewPending>d__.<>t__builder.Start<UiViewPlotContainer.<ProcessViewPending>d__13>(ref <ProcessViewPending>d__);
			return <ProcessViewPending>d__.<>t__builder.Task;
		}

		// Token: 0x06022F4D RID: 143181 RVA: 0x009EBB98 File Offset: 0x009E9D98
		private UniTask OpenStackViewAsync(UiViewBase view, [Nullable(2)] UiViewBase lastView)
		{
			UiViewPlotContainer.<OpenStackViewAsync>d__14 <OpenStackViewAsync>d__;
			<OpenStackViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenStackViewAsync>d__.view = view;
			<OpenStackViewAsync>d__.lastView = lastView;
			<OpenStackViewAsync>d__.<>1__state = -1;
			<OpenStackViewAsync>d__.<>t__builder.Start<UiViewPlotContainer.<OpenStackViewAsync>d__14>(ref <OpenStackViewAsync>d__);
			return <OpenStackViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F4E RID: 143182 RVA: 0x009EBBE4 File Offset: 0x009E9DE4
		private UniTask CloseViewInternal(UiViewBase view, [Nullable(2)] UiViewBase nextView)
		{
			UiViewPlotContainer.<CloseViewInternal>d__15 <CloseViewInternal>d__;
			<CloseViewInternal>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewInternal>d__.<>4__this = this;
			<CloseViewInternal>d__.view = view;
			<CloseViewInternal>d__.nextView = nextView;
			<CloseViewInternal>d__.<>1__state = -1;
			<CloseViewInternal>d__.<>t__builder.Start<UiViewPlotContainer.<CloseViewInternal>d__15>(ref <CloseViewInternal>d__);
			return <CloseViewInternal>d__.<>t__builder.Task;
		}

		// Token: 0x06022F4F RID: 143183 RVA: 0x009EBC38 File Offset: 0x009E9E38
		[NullableContext(0)]
		public override UniTask<bool> OpenViewAsync([Nullable(1)] UiViewBase view)
		{
			UiViewPlotContainer.<OpenViewAsync>d__16 <OpenViewAsync>d__;
			<OpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenViewAsync>d__.<>4__this = this;
			<OpenViewAsync>d__.view = view;
			<OpenViewAsync>d__.<>1__state = -1;
			<OpenViewAsync>d__.<>t__builder.Start<UiViewPlotContainer.<OpenViewAsync>d__16>(ref <OpenViewAsync>d__);
			return <OpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F50 RID: 143184 RVA: 0x009EBC84 File Offset: 0x009E9E84
		public override UniTask PreOpenViewAsync(UiViewBase view)
		{
			UiViewPlotContainer.<PreOpenViewAsync>d__17 <PreOpenViewAsync>d__;
			<PreOpenViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PreOpenViewAsync>d__.view = view;
			<PreOpenViewAsync>d__.<>1__state = -1;
			<PreOpenViewAsync>d__.<>t__builder.Start<UiViewPlotContainer.<PreOpenViewAsync>d__17>(ref <PreOpenViewAsync>d__);
			return <PreOpenViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F51 RID: 143185 RVA: 0x009EBCC8 File Offset: 0x009E9EC8
		public override UniTask OpenViewAfterPreOpenedAsync(UiViewBase view)
		{
			UiViewPlotContainer.<OpenViewAfterPreOpenedAsync>d__18 <OpenViewAfterPreOpenedAsync>d__;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenViewAfterPreOpenedAsync>d__.view = view;
			<OpenViewAfterPreOpenedAsync>d__.<>1__state = -1;
			<OpenViewAfterPreOpenedAsync>d__.<>t__builder.Start<UiViewPlotContainer.<OpenViewAfterPreOpenedAsync>d__18>(ref <OpenViewAfterPreOpenedAsync>d__);
			return <OpenViewAfterPreOpenedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F52 RID: 143186 RVA: 0x009EBD0C File Offset: 0x009E9F0C
		public override UniTask CloseViewAsync(UiViewBase view)
		{
			UiViewPlotContainer.<CloseViewAsync>d__19 <CloseViewAsync>d__;
			<CloseViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseViewAsync>d__.<>4__this = this;
			<CloseViewAsync>d__.view = view;
			<CloseViewAsync>d__.<>1__state = -1;
			<CloseViewAsync>d__.<>t__builder.Start<UiViewPlotContainer.<CloseViewAsync>d__19>(ref <CloseViewAsync>d__);
			return <CloseViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06022F53 RID: 143187 RVA: 0x009EBD58 File Offset: 0x009E9F58
		public unsafe override void ClearContainer(bool isSeamlessTravel)
		{
			List<UiViewBase> list = new List<UiViewBase>();
			for (int i = this.ViewPendingList.Count - 1; i >= 0; i--)
			{
				UiViewBase view = this.ViewPendingList[i].View;
				view.IsExistInLeaveLevel = true;
				if (!view.ViewInfo.IsPermanent)
				{
					CustomPromise<bool> openPromise = view.OpenPromise;
					if (openPromise != null)
					{
						openPromise.SetResult(false);
					}
					UiManager.Instance.RemoveView(view.GetViewId());
					this.ViewPendingList.RemoveAt(this.ViewPendingList.Count - 1);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.PlotContainer;
					ELogAuthor author = ELogAuthor.XXJ;
					string message = "[Clear] 清理缓存的界面数据";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", view.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ComponentId", view.ComponentId);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
			list.Clear();
			foreach (UiViewBase uiViewBase in this.Stack)
			{
				uiViewBase.IsExistInLeaveLevel = true;
				if (!uiViewBase.ViewInfo.IsPermanent && (!isSeamlessTravel || !UiModel.Instance.SeamlessStackWhileList.Contains(uiViewBase.ViewInfo.Name)))
				{
					base.TryCatchViewDestroyCompatible(uiViewBase);
					list.Add(uiViewBase);
				}
			}
			foreach (UiViewBase view2 in list)
			{
				this.DeleteView(view2);
			}
			Log.Instance.Info(ELogModule.PlotContainer, ELogAuthor.XXJ, "ClearContainer 清栈", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x04013492 RID: 78994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly global::Stack<UiViewBase> Stack;

		// Token: 0x04013493 RID: 78995
		[Nullable(2)]
		private CustomPromise LockOperationPromise;

		// Token: 0x04013494 RID: 78996
		private bool Operating;

		// Token: 0x04013495 RID: 78997
		private readonly List<UiViewPending> ViewPendingList = new List<UiViewPending>();
	}
}
