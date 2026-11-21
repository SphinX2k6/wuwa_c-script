using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058EC RID: 22764
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolTaskBase : IStaticVariableResetter
	{
		// Token: 0x060381FF RID: 229887 RVA: 0x00FB026E File Offset: 0x00FAE46E
		static SolarSchoolTaskBase()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolTaskBase.CreateStaticDefaultValue), new Action(SolarSchoolTaskBase.ResetStaticDefaultValue));
		}

		// Token: 0x17006BB2 RID: 27570
		// (get) Token: 0x06038200 RID: 229888 RVA: 0x00FB028D File Offset: 0x00FAE48D
		// (set) Token: 0x06038201 RID: 229889 RVA: 0x00FB0295 File Offset: 0x00FAE495
		public ESolarSchoolTimeSlot SlotTag { get; set; }

		// Token: 0x17006BB3 RID: 27571
		// (get) Token: 0x06038202 RID: 229890 RVA: 0x00FB029E File Offset: 0x00FAE49E
		public bool IsExecuting
		{
			get
			{
				return this.IsExecute;
			}
		}

		// Token: 0x17006BB4 RID: 27572
		// (get) Token: 0x06038203 RID: 229891 RVA: 0x00FB02A6 File Offset: 0x00FAE4A6
		public bool IsPause
		{
			get
			{
				return this.IsPauseInternal;
			}
		}

		// Token: 0x06038204 RID: 229892 RVA: 0x00FB02AE File Offset: 0x00FAE4AE
		public static void CreateStaticDefaultValue()
		{
			SolarSchoolTaskBase.SelfIncrementId = 0;
		}

		// Token: 0x06038205 RID: 229893 RVA: 0x00FB02B6 File Offset: 0x00FAE4B6
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolTaskBase.SelfIncrementId = 0;
		}

		// Token: 0x06038206 RID: 229894 RVA: 0x00FB02BE File Offset: 0x00FAE4BE
		public SolarSchoolTaskBase()
		{
			this.TaskId = SolarSchoolTaskBase.SelfIncrementId++;
		}

		// Token: 0x06038207 RID: 229895 RVA: 0x00FB02E4 File Offset: 0x00FAE4E4
		public void BindCompleteCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<int, Action> completeCallBack)
		{
			this.CompleteCallBack = completeCallBack;
		}

		// Token: 0x06038208 RID: 229896 RVA: 0x00FB02ED File Offset: 0x00FAE4ED
		[NullableContext(2)]
		public void BindPresentViewCloseRequestCallback(Action callback)
		{
			this.PresentViewCloseRequestCallback = callback;
		}

		// Token: 0x06038209 RID: 229897 RVA: 0x00FB02F6 File Offset: 0x00FAE4F6
		public void Execute()
		{
			this.IsExecute = true;
			this.OnAddEventListener();
			this.OnExecute();
			SolarSchoolQuestCenter.Instance.TryDeliverPending();
		}

		// Token: 0x0603820A RID: 229898 RVA: 0x00FB0315 File Offset: 0x00FAE515
		public void Tick(float deltaTime)
		{
			if (!this.IsExecute)
			{
				return;
			}
			this.OnTick(deltaTime);
			this.TryRunPendingNext();
		}

		// Token: 0x0603820B RID: 229899 RVA: 0x00FB032D File Offset: 0x00FAE52D
		[NullableContext(2)]
		public void Complete(Action preExecuteNextCallback = null)
		{
			if (!this.IsExecute)
			{
				return;
			}
			this.IsExecute = false;
			this.PendingNext = null;
			this.DisposeHandler();
			this.OnRemoveEventListener();
			this.OnComplete();
			this.CompleteCallBack(this.TaskId, preExecuteNextCallback);
		}

		// Token: 0x0603820C RID: 229900 RVA: 0x00FB036A File Offset: 0x00FAE56A
		[NullableContext(2)]
		public void AsyncComplete(Action preExecuteNextCallback = null)
		{
			this.IsDataCompleteInternal = true;
			if (this.IsExecute && !this.IsPauseInternal)
			{
				this.Complete(preExecuteNextCallback);
			}
		}

		// Token: 0x0603820D RID: 229901 RVA: 0x00FB038A File Offset: 0x00FAE58A
		public void ForceFinish()
		{
			if (!this.IsExecute)
			{
				return;
			}
			this.IsExecute = false;
			this.PendingNext = null;
			this.DisposeHandler();
			this.OnRemoveEventListener();
		}

		// Token: 0x0603820E RID: 229902 RVA: 0x00FB03AF File Offset: 0x00FAE5AF
		private bool CanComplete()
		{
			return this.IsExecute && !this.IsPauseInternal && this.IsDataCompleteInternal;
		}

		// Token: 0x0603820F RID: 229903 RVA: 0x00FB03C9 File Offset: 0x00FAE5C9
		public void Pause()
		{
			if (!this.IsExecute)
			{
				return;
			}
			this.IsExecute = false;
			this.IsPauseInternal = true;
		}

		// Token: 0x06038210 RID: 229904 RVA: 0x00FB03E2 File Offset: 0x00FAE5E2
		public void Resume()
		{
			if (!this.IsPauseInternal)
			{
				return;
			}
			this.IsExecute = true;
			this.IsPauseInternal = false;
			if (this.CanComplete())
			{
				this.Complete(null);
			}
		}

		// Token: 0x06038211 RID: 229905 RVA: 0x00FB040A File Offset: 0x00FAE60A
		protected virtual void OnExecute()
		{
		}

		// Token: 0x06038212 RID: 229906 RVA: 0x00FB040C File Offset: 0x00FAE60C
		protected virtual void OnAddEventListener()
		{
		}

		// Token: 0x06038213 RID: 229907 RVA: 0x00FB040E File Offset: 0x00FAE60E
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x06038214 RID: 229908 RVA: 0x00FB0410 File Offset: 0x00FAE610
		protected virtual void OnRemoveEventListener()
		{
		}

		// Token: 0x06038215 RID: 229909 RVA: 0x00FB0412 File Offset: 0x00FAE612
		protected virtual void OnComplete()
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06038216 RID: 229910 RVA: 0x00FB0414 File Offset: 0x00FAE614
		// (remove) Token: 0x06038217 RID: 229911 RVA: 0x00FB044C File Offset: 0x00FAE64C
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<SolarSchoolTaskBase> ActionSequenceFinished;

		// Token: 0x17006BB5 RID: 27573
		// (get) Token: 0x06038218 RID: 229912 RVA: 0x00FB0481 File Offset: 0x00FAE681
		protected bool HasHandler
		{
			get
			{
				return this.SequenceHandler != null;
			}
		}

		// Token: 0x17006BB6 RID: 27574
		// (get) Token: 0x06038219 RID: 229913 RVA: 0x00FB048C File Offset: 0x00FAE68C
		public bool HandlerHasWork
		{
			get
			{
				return this.SequenceHandler != null && this.SequenceHandler.HasWork;
			}
		}

		// Token: 0x17006BB7 RID: 27575
		// (get) Token: 0x0603821A RID: 229914 RVA: 0x00FB04A3 File Offset: 0x00FAE6A3
		protected ActivityActionExecuteHandler ActionSequenceHandler
		{
			get
			{
				if (this.SequenceHandler == null)
				{
					this.SequenceHandler = ActivityActionModel.Instance.GetHandler();
					this.SequenceHandler.SetWorkFinishedCallback(new Action(this.OnSequenceWorkFinished));
				}
				return this.SequenceHandler;
			}
		}

		// Token: 0x0603821B RID: 229915 RVA: 0x00FB04DA File Offset: 0x00FAE6DA
		private void OnSequenceWorkFinished()
		{
			Action<SolarSchoolTaskBase> actionSequenceFinished = this.ActionSequenceFinished;
			if (actionSequenceFinished != null)
			{
				actionSequenceFinished(this);
			}
			Action presentViewCloseRequestCallback = this.PresentViewCloseRequestCallback;
			if (presentViewCloseRequestCallback != null)
			{
				presentViewCloseRequestCallback();
			}
			this.TryRunPendingNext();
		}

		// Token: 0x0603821C RID: 229916 RVA: 0x00FB0508 File Offset: 0x00FAE708
		public ActivityActionExecuteHandler AcquireParallelHandler()
		{
			ActivityActionExecuteHandler handler = ActivityActionModel.Instance.GetHandler();
			this.ParallelHandlers.Add(handler);
			return handler;
		}

		// Token: 0x0603821D RID: 229917 RVA: 0x00FB052E File Offset: 0x00FAE72E
		public void ReleaseParallelHandler(ActivityActionExecuteHandler handler)
		{
			if (handler == null || !this.ParallelHandlers.Remove(handler))
			{
				return;
			}
			if (!handler.IsDisposed)
			{
				handler.Dispose();
			}
		}

		// Token: 0x0603821E RID: 229918 RVA: 0x00FB0550 File Offset: 0x00FAE750
		private void DisposeParallelHandlers()
		{
			if (this.ParallelHandlers.Count == 0)
			{
				return;
			}
			foreach (ActivityActionExecuteHandler activityActionExecuteHandler in this.ParallelHandlers)
			{
				if (!activityActionExecuteHandler.IsDisposed)
				{
					activityActionExecuteHandler.Dispose();
				}
			}
			this.ParallelHandlers.Clear();
		}

		// Token: 0x0603821F RID: 229919 RVA: 0x00FB05C4 File Offset: 0x00FAE7C4
		protected void PushAction(int actionId)
		{
			SolarSchoolActionBase solarSchoolActionBase = SolarSchoolGamePlayModel.Instance.CreateAction(actionId);
			if (solarSchoolActionBase == null)
			{
				return;
			}
			this.ActionSequenceHandler.Push(solarSchoolActionBase);
		}

		// Token: 0x06038220 RID: 229920 RVA: 0x00FB05EE File Offset: 0x00FAE7EE
		protected void PushAction(SolarSchoolActionBase action)
		{
			this.ActionSequenceHandler.Push(action);
		}

		// Token: 0x06038221 RID: 229921 RVA: 0x00FB0600 File Offset: 0x00FAE800
		protected void RunThen([Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<SolarSchoolActionBase> actions, Action next)
		{
			if (actions != null)
			{
				foreach (SolarSchoolActionBase solarSchoolActionBase in actions)
				{
					if (solarSchoolActionBase != null)
					{
						this.PushAction(solarSchoolActionBase);
					}
				}
			}
			this.PendingNext = next;
		}

		// Token: 0x06038222 RID: 229922 RVA: 0x00FB0658 File Offset: 0x00FAE858
		protected void RunThen([Nullable(2)] int[] actionIds, Action next)
		{
			if (actionIds != null)
			{
				foreach (int actionId in actionIds)
				{
					this.PushAction(actionId);
				}
			}
			this.PendingNext = next;
		}

		// Token: 0x06038223 RID: 229923 RVA: 0x00FB068A File Offset: 0x00FAE88A
		protected void ClearPendingNext()
		{
			this.PendingNext = null;
		}

		// Token: 0x06038224 RID: 229924 RVA: 0x00FB0693 File Offset: 0x00FAE893
		private void TryRunPendingNext()
		{
			if (this.PendingNext == null || this.HandlerHasWork)
			{
				return;
			}
			Action pendingNext = this.PendingNext;
			this.PendingNext = null;
			pendingNext();
		}

		// Token: 0x06038225 RID: 229925 RVA: 0x00FB06B8 File Offset: 0x00FAE8B8
		public virtual bool TryPushAction(SolarSchoolActionBase action)
		{
			if (!this.IsExecute || action == null)
			{
				return false;
			}
			this.PushAction(action);
			return true;
		}

		// Token: 0x06038226 RID: 229926 RVA: 0x00FB06D0 File Offset: 0x00FAE8D0
		private void DisposeHandler()
		{
			this.ActionSequenceFinished = null;
			this.DisposeParallelHandlers();
			if (this.SequenceHandler == null)
			{
				return;
			}
			ActivityActionExecuteHandler sequenceHandler = this.SequenceHandler;
			this.SequenceHandler = null;
			if (!sequenceHandler.IsDisposed)
			{
				sequenceHandler.Dispose();
			}
		}

		// Token: 0x0401D8F8 RID: 121080
		public readonly int TaskId;

		// Token: 0x0401D8F9 RID: 121081
		private static int SelfIncrementId;

		// Token: 0x0401D8FA RID: 121082
		private bool IsExecute;

		// Token: 0x0401D8FB RID: 121083
		private bool IsPauseInternal;

		// Token: 0x0401D8FC RID: 121084
		private bool IsDataCompleteInternal;

		// Token: 0x0401D8FE RID: 121086
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private Action<int, Action> CompleteCallBack;

		// Token: 0x0401D8FF RID: 121087
		[Nullable(2)]
		private Action PresentViewCloseRequestCallback;

		// Token: 0x0401D900 RID: 121088
		[Nullable(2)]
		private Action PendingNext;

		// Token: 0x0401D901 RID: 121089
		[Nullable(2)]
		private ActivityActionExecuteHandler SequenceHandler;

		// Token: 0x0401D903 RID: 121091
		private readonly HashSet<ActivityActionExecuteHandler> ParallelHandlers = new HashSet<ActivityActionExecuteHandler>();
	}
}
