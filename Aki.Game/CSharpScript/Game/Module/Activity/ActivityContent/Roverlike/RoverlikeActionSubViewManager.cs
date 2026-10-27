using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006108 RID: 24840
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActionSubViewManager
	{
		// Token: 0x0603ECBB RID: 257211 RVA: 0x00F2A07C File Offset: 0x00F2827C
		public void RegisterHost(UUIItem hostViewItem)
		{
			this.HostParentItem = hostViewItem;
			this.IsHostReadyInternal = true;
			foreach (UiAsyncTask task in this.PendingTasks)
			{
				this.TaskManager.RunTask(task);
			}
			this.PendingTasks.Clear();
			this.PendingTaskMap.Clear();
		}

		// Token: 0x0603ECBC RID: 257212 RVA: 0x00F2A0FC File Offset: 0x00F282FC
		public void UnregisterHost()
		{
			this.FinishAllSubView();
			this.OnAllSubViewsFinished = null;
			this.IsHostReadyInternal = false;
			this.HostParentItem = null;
			this.ActionTopPanel = null;
		}

		// Token: 0x0603ECBD RID: 257213 RVA: 0x00F2A120 File Offset: 0x00F28320
		public void RegisterTopPanel(RoverlikeBattleTopPanel panel)
		{
			this.ActionTopPanel = panel;
		}

		// Token: 0x0603ECBE RID: 257214 RVA: 0x00F2A129 File Offset: 0x00F28329
		[NullableContext(2)]
		public RoverlikeBattleTopPanel GetActionTopPanel()
		{
			return this.ActionTopPanel;
		}

		// Token: 0x0603ECBF RID: 257215 RVA: 0x00F2A134 File Offset: 0x00F28334
		[NullableContext(2)]
		public int AddSubView(ERoverActionSubViewType type, object openParam = null)
		{
			RoverlikeActionSubViewManager.<>c__DisplayClass15_0 CS$<>8__locals1 = new RoverlikeActionSubViewManager.<>c__DisplayClass15_0();
			CS$<>8__locals1.<>4__this = this;
			if (this.IsDisposed)
			{
				return -1;
			}
			RoverlikeActionSubViewManager.<>c__DisplayClass15_0 CS$<>8__locals2 = CS$<>8__locals1;
			int nextIncId = this.NextIncId;
			this.NextIncId = nextIncId + 1;
			CS$<>8__locals2.incId = nextIncId;
			CS$<>8__locals1.subView = RoverlikeActionSubViewFactory.CreateSubView(type);
			if (CS$<>8__locals1.subView == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Roverlike;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[俯视角肉鸽] 未注册的子界面类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return -1;
			}
			CS$<>8__locals1.subView.IncId = CS$<>8__locals1.incId;
			CS$<>8__locals1.subView.OpenParam = openParam;
			this.SubViewStack.Add(CS$<>8__locals1.subView);
			this.SubViewMap[CS$<>8__locals1.incId] = CS$<>8__locals1.subView;
			RoverlikeActionStack actionStack = this.GetActionStack();
			if (actionStack != null)
			{
				actionStack.Push(CS$<>8__locals1.subView);
			}
			UiAsyncTask uiAsyncTask = new UiAsyncTask("RoverlikeActionSubView.Create", delegate()
			{
				RoverlikeActionSubViewManager.<>c__DisplayClass15_0.<<AddSubView>b__0>d <<AddSubView>b__0>d;
				<<AddSubView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<AddSubView>b__0>d.<>4__this = CS$<>8__locals1;
				<<AddSubView>b__0>d.<>1__state = -1;
				<<AddSubView>b__0>d.<>t__builder.Start<RoverlikeActionSubViewManager.<>c__DisplayClass15_0.<<AddSubView>b__0>d>(ref <<AddSubView>b__0>d);
				return <<AddSubView>b__0>d.<>t__builder.Task;
			}, null);
			if (this.IsHostReadyInternal)
			{
				this.TaskManager.RunTask(uiAsyncTask);
			}
			else
			{
				this.PendingTasks.Add(uiAsyncTask);
				this.PendingTaskMap[CS$<>8__locals1.incId] = uiAsyncTask;
			}
			return CS$<>8__locals1.incId;
		}

		// Token: 0x0603ECC0 RID: 257216 RVA: 0x00F2A264 File Offset: 0x00F28464
		public void FinishSubView(int incId)
		{
			RoverlikeActionSubViewManager.<>c__DisplayClass16_0 CS$<>8__locals1 = new RoverlikeActionSubViewManager.<>c__DisplayClass16_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.incId = incId;
			if (this.IsDisposed)
			{
				return;
			}
			if (!this.SubViewMap.TryGetValue(CS$<>8__locals1.incId, out CS$<>8__locals1.subView) || CS$<>8__locals1.subView.Finished)
			{
				return;
			}
			if (CS$<>8__locals1.subView.State == ERoverlikeActionSubViewState.Wait)
			{
				this.FinishWaitingSubView(CS$<>8__locals1.subView);
				this.CheckAllFinished();
				return;
			}
			UiAsyncTask task = new UiAsyncTask("RoverlikeActionSubView.Finish", delegate()
			{
				RoverlikeActionSubViewManager.<>c__DisplayClass16_0.<<FinishSubView>b__0>d <<FinishSubView>b__0>d;
				<<FinishSubView>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<FinishSubView>b__0>d.<>4__this = CS$<>8__locals1;
				<<FinishSubView>b__0>d.<>1__state = -1;
				<<FinishSubView>b__0>d.<>t__builder.Start<RoverlikeActionSubViewManager.<>c__DisplayClass16_0.<<FinishSubView>b__0>d>(ref <<FinishSubView>b__0>d);
				return <<FinishSubView>b__0>d.<>t__builder.Task;
			}, null);
			this.TaskManager.RunTask(task);
		}

		// Token: 0x0603ECC1 RID: 257217 RVA: 0x00F2A2FC File Offset: 0x00F284FC
		public unsafe void FinishAllSubView()
		{
			if (this.IsDisposed)
			{
				return;
			}
			for (int i = this.SubViewStack.Count - 1; i >= 0; i--)
			{
				RoverlikeActionSubViewBase roverlikeActionSubViewBase = this.SubViewStack[i];
				if (!roverlikeActionSubViewBase.Finished)
				{
					if (roverlikeActionSubViewBase.State == ERoverlikeActionSubViewState.Wait)
					{
						this.FinishWaitingSubView(roverlikeActionSubViewBase);
					}
					else
					{
						roverlikeActionSubViewBase.SetState(ERoverlikeActionSubViewState.Finished);
						RoverlikeActionStack actionStack = this.GetActionStack();
						if (actionStack != null)
						{
							actionStack.Pop(roverlikeActionSubViewBase);
						}
						this.RemoveFromStack(roverlikeActionSubViewBase);
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Roverlike;
						ELogAuthor author = ELogAuthor.YYZ;
						string message = "[俯视角肉鸽] 完成行为子界面";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", roverlikeActionSubViewBase.IncId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", roverlikeActionSubViewBase.SubViewType.ToEnumString());
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StackSize", this.SubViewStack.Count);
						instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
				}
			}
		}

		// Token: 0x0603ECC2 RID: 257218 RVA: 0x00F2A40D File Offset: 0x00F2860D
		[NullableContext(2)]
		public RoverlikeActionSubViewBase GetCurrentSubView()
		{
			if (this.SubViewStack.Count == 0)
			{
				return null;
			}
			return this.SubViewStack[this.SubViewStack.Count - 1];
		}

		// Token: 0x0603ECC3 RID: 257219 RVA: 0x00F2A438 File Offset: 0x00F28638
		[NullableContext(2)]
		public RoverlikeActionSubViewBase GetSubViewByIncId(int incId)
		{
			RoverlikeActionSubViewBase result;
			this.SubViewMap.TryGetValue(incId, out result);
			return result;
		}

		// Token: 0x0603ECC4 RID: 257220 RVA: 0x00F2A455 File Offset: 0x00F28655
		public bool HasSubViews()
		{
			return this.SubViewStack.Count > 0;
		}

		// Token: 0x17009175 RID: 37237
		// (get) Token: 0x0603ECC5 RID: 257221 RVA: 0x00F2A465 File Offset: 0x00F28665
		public bool HostReady
		{
			get
			{
				return this.IsHostReadyInternal;
			}
		}

		// Token: 0x0603ECC6 RID: 257222 RVA: 0x00F2A470 File Offset: 0x00F28670
		public void Dispose()
		{
			if (this.IsDisposed)
			{
				return;
			}
			this.IsDisposed = true;
			this.TaskManager.CancelAllTask();
			this.PendingTasks.Clear();
			this.PendingTaskMap.Clear();
			this.SubViewStack.Clear();
			this.SubViewMap.Clear();
			this.HostParentItem = null;
			this.IsHostReadyInternal = false;
			this.ActionTopPanel = null;
			this.OnAllSubViewsFinished = null;
		}

		// Token: 0x0603ECC7 RID: 257223 RVA: 0x00F2A4E0 File Offset: 0x00F286E0
		[NullableContext(2)]
		private RoverlikeActionSubViewBase GetTopActiveSubView()
		{
			for (int i = this.SubViewStack.Count - 1; i >= 0; i--)
			{
				if (!this.SubViewStack[i].Finished)
				{
					return this.SubViewStack[i];
				}
			}
			return null;
		}

		// Token: 0x0603ECC8 RID: 257224 RVA: 0x00F2A526 File Offset: 0x00F28726
		private void CheckAllFinished()
		{
			if (this.SubViewStack.Count > 0)
			{
				return;
			}
			Action onAllSubViewsFinished = this.OnAllSubViewsFinished;
			if (onAllSubViewsFinished != null)
			{
				onAllSubViewsFinished();
			}
			this.UnregisterHost();
		}

		// Token: 0x0603ECC9 RID: 257225 RVA: 0x00F2A550 File Offset: 0x00F28750
		private unsafe void FinishWaitingSubView(RoverlikeActionSubViewBase subView)
		{
			int incId = subView.IncId;
			UiAsyncTask uiAsyncTask;
			if (this.PendingTaskMap.TryGetValue(incId, out uiAsyncTask))
			{
				int num = -1;
				for (int i = 0; i < this.PendingTasks.Count; i++)
				{
					if (this.PendingTasks[i] == uiAsyncTask)
					{
						num = i;
						break;
					}
				}
				if (num != -1)
				{
					this.PendingTasks.RemoveAt(num);
				}
				this.PendingTaskMap.Remove(incId);
			}
			subView.SetState(ERoverlikeActionSubViewState.Finished);
			RoverlikeActionStack actionStack = this.GetActionStack();
			if (actionStack != null)
			{
				actionStack.Pop(subView);
			}
			this.RemoveFromStack(subView);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Roverlike;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[俯视角肉鸽] 取消未创建的子界面";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IncId", incId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Type", subView.SubViewType.ToEnumString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("StackSize", this.SubViewStack.Count);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}

		// Token: 0x0603ECCA RID: 257226 RVA: 0x00F2A670 File Offset: 0x00F28870
		private void RemoveFromStack(RoverlikeActionSubViewBase subView)
		{
			int num = -1;
			for (int i = 0; i < this.SubViewStack.Count; i++)
			{
				if (this.SubViewStack[i] == subView)
				{
					num = i;
					break;
				}
			}
			if (num != -1)
			{
				this.SubViewStack.RemoveAt(num);
			}
			this.SubViewMap.Remove(subView.IncId);
		}

		// Token: 0x0603ECCB RID: 257227 RVA: 0x00F2A6CA File Offset: 0x00F288CA
		[NullableContext(2)]
		private RoverlikeActionStack GetActionStack()
		{
			RoverlikeModel instance = RoverlikeModel.Instance;
			if (instance == null)
			{
				return null;
			}
			return instance.ActionStack;
		}

		// Token: 0x04020CEF RID: 134383
		private readonly List<RoverlikeActionSubViewBase> SubViewStack = new List<RoverlikeActionSubViewBase>();

		// Token: 0x04020CF0 RID: 134384
		private readonly Dictionary<int, RoverlikeActionSubViewBase> SubViewMap = new Dictionary<int, RoverlikeActionSubViewBase>();

		// Token: 0x04020CF1 RID: 134385
		private readonly UiAsyncTaskManager TaskManager = new UiAsyncTaskManager();

		// Token: 0x04020CF2 RID: 134386
		private readonly List<UiAsyncTask> PendingTasks = new List<UiAsyncTask>();

		// Token: 0x04020CF3 RID: 134387
		private readonly Dictionary<int, UiAsyncTask> PendingTaskMap = new Dictionary<int, UiAsyncTask>();

		// Token: 0x04020CF4 RID: 134388
		private int NextIncId = 1;

		// Token: 0x04020CF5 RID: 134389
		public bool IsDisposed;

		// Token: 0x04020CF6 RID: 134390
		[Nullable(2)]
		private UUIItem HostParentItem;

		// Token: 0x04020CF7 RID: 134391
		private bool IsHostReadyInternal;

		// Token: 0x04020CF8 RID: 134392
		[Nullable(2)]
		private RoverlikeBattleTopPanel ActionTopPanel;

		// Token: 0x04020CF9 RID: 134393
		[Nullable(2)]
		public Action OnAllSubViewsFinished;
	}
}
