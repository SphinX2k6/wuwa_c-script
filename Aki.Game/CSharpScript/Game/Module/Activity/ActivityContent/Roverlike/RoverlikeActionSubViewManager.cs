using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005086 RID: 20614
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActionSubViewManager
	{
		// Token: 0x0603397D RID: 211325 RVA: 0x00E70E90 File Offset: 0x00E6F090
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

		// Token: 0x0603397E RID: 211326 RVA: 0x00E70F10 File Offset: 0x00E6F110
		public void UnregisterHost()
		{
			this.FinishAllSubView();
			this.OnAllSubViewsFinished = null;
			this.IsHostReadyInternal = false;
			this.HostParentItem = null;
			this.ActionTopPanel = null;
		}

		// Token: 0x0603397F RID: 211327 RVA: 0x00E70F34 File Offset: 0x00E6F134
		public void RegisterTopPanel(RoverlikeBattleTopPanel panel)
		{
			this.ActionTopPanel = panel;
		}

		// Token: 0x06033980 RID: 211328 RVA: 0x00E70F3D File Offset: 0x00E6F13D
		[NullableContext(2)]
		public RoverlikeBattleTopPanel GetActionTopPanel()
		{
			return this.ActionTopPanel;
		}

		// Token: 0x06033981 RID: 211329 RVA: 0x00E70F48 File Offset: 0x00E6F148
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

		// Token: 0x06033982 RID: 211330 RVA: 0x00E71078 File Offset: 0x00E6F278
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

		// Token: 0x06033983 RID: 211331 RVA: 0x00E71110 File Offset: 0x00E6F310
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

		// Token: 0x06033984 RID: 211332 RVA: 0x00E71221 File Offset: 0x00E6F421
		[NullableContext(2)]
		public RoverlikeActionSubViewBase GetCurrentSubView()
		{
			if (this.SubViewStack.Count == 0)
			{
				return null;
			}
			return this.SubViewStack[this.SubViewStack.Count - 1];
		}

		// Token: 0x06033985 RID: 211333 RVA: 0x00E7124C File Offset: 0x00E6F44C
		[NullableContext(2)]
		public RoverlikeActionSubViewBase GetSubViewByIncId(int incId)
		{
			RoverlikeActionSubViewBase result;
			this.SubViewMap.TryGetValue(incId, out result);
			return result;
		}

		// Token: 0x06033986 RID: 211334 RVA: 0x00E71269 File Offset: 0x00E6F469
		public bool HasSubViews()
		{
			return this.SubViewStack.Count > 0;
		}

		// Token: 0x170064D7 RID: 25815
		// (get) Token: 0x06033987 RID: 211335 RVA: 0x00E71279 File Offset: 0x00E6F479
		public bool HostReady
		{
			get
			{
				return this.IsHostReadyInternal;
			}
		}

		// Token: 0x06033988 RID: 211336 RVA: 0x00E71284 File Offset: 0x00E6F484
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

		// Token: 0x06033989 RID: 211337 RVA: 0x00E712F4 File Offset: 0x00E6F4F4
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

		// Token: 0x0603398A RID: 211338 RVA: 0x00E7133A File Offset: 0x00E6F53A
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

		// Token: 0x0603398B RID: 211339 RVA: 0x00E71364 File Offset: 0x00E6F564
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

		// Token: 0x0603398C RID: 211340 RVA: 0x00E71484 File Offset: 0x00E6F684
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

		// Token: 0x0603398D RID: 211341 RVA: 0x00E714DE File Offset: 0x00E6F6DE
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

		// Token: 0x0401B61C RID: 112156
		private readonly List<RoverlikeActionSubViewBase> SubViewStack = new List<RoverlikeActionSubViewBase>();

		// Token: 0x0401B61D RID: 112157
		private readonly Dictionary<int, RoverlikeActionSubViewBase> SubViewMap = new Dictionary<int, RoverlikeActionSubViewBase>();

		// Token: 0x0401B61E RID: 112158
		private readonly UiAsyncTaskManager TaskManager = new UiAsyncTaskManager();

		// Token: 0x0401B61F RID: 112159
		private readonly List<UiAsyncTask> PendingTasks = new List<UiAsyncTask>();

		// Token: 0x0401B620 RID: 112160
		private readonly Dictionary<int, UiAsyncTask> PendingTaskMap = new Dictionary<int, UiAsyncTask>();

		// Token: 0x0401B621 RID: 112161
		private int NextIncId = 1;

		// Token: 0x0401B622 RID: 112162
		public bool IsDisposed;

		// Token: 0x0401B623 RID: 112163
		[Nullable(2)]
		private UUIItem HostParentItem;

		// Token: 0x0401B624 RID: 112164
		private bool IsHostReadyInternal;

		// Token: 0x0401B625 RID: 112165
		[Nullable(2)]
		private RoverlikeBattleTopPanel ActionTopPanel;

		// Token: 0x0401B626 RID: 112166
		[Nullable(2)]
		public Action OnAllSubViewsFinished;
	}
}
