using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058FA RID: 22778
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class SolarSchoolTaskStateBase : ActivityGameplayTurnStateBase<ESolarSchoolStageStateType>
	{
		// Token: 0x17006BBC RID: 27580
		// (get) Token: 0x06038270 RID: 230000 RVA: 0x00FB27CC File Offset: 0x00FB09CC
		// (set) Token: 0x06038271 RID: 230001 RVA: 0x00FB27D4 File Offset: 0x00FB09D4
		private protected bool IsActive { protected get; private set; }

		// Token: 0x17006BBD RID: 27581
		// (get) Token: 0x06038272 RID: 230002 RVA: 0x00FB27DD File Offset: 0x00FB09DD
		// (set) Token: 0x06038273 RID: 230003 RVA: 0x00FB27E5 File Offset: 0x00FB09E5
		private protected SolarSchoolTaskBase CurrentTask { protected get; private set; }

		// Token: 0x06038274 RID: 230004 RVA: 0x00FB27EE File Offset: 0x00FB09EE
		public sealed override void Enter(ESolarSchoolStageStateType? prev)
		{
			this.IsActive = true;
			this.CurrentTask = null;
			this.PendingClosePresentView = false;
			this.OnEnterState(prev);
		}

		// Token: 0x06038275 RID: 230005 RVA: 0x00FB280C File Offset: 0x00FB0A0C
		public sealed override void Exit(ESolarSchoolStageStateType? next)
		{
			this.AbortCurrentTask();
			this.IsActive = false;
			this.PendingClosePresentView = false;
			this.OnExitState(next);
		}

		// Token: 0x06038276 RID: 230006 RVA: 0x00FB2829 File Offset: 0x00FB0A29
		public override void Tick(float delta)
		{
			SolarSchoolTaskBase currentTask = this.CurrentTask;
			if (currentTask != null)
			{
				currentTask.Tick(delta);
			}
			this.TryClosePresentView();
		}

		// Token: 0x06038277 RID: 230007 RVA: 0x00FB2843 File Offset: 0x00FB0A43
		private void TryClosePresentView()
		{
			if (!this.PendingClosePresentView)
			{
				return;
			}
			this.PendingClosePresentView = false;
			if (this.CurrentTask != null && this.CurrentTask.HandlerHasWork)
			{
				return;
			}
			SolarSchoolGamePlayModel.Instance.CloseFinishedPresentView();
		}

		// Token: 0x06038278 RID: 230008 RVA: 0x00FB2875 File Offset: 0x00FB0A75
		[NullableContext(1)]
		protected void RunTask(SolarSchoolTaskBase task)
		{
			this.CurrentTask = task;
			task.BindCompleteCallBack(new Action<int, Action>(this.OnCurrentTaskComplete));
			task.BindPresentViewCloseRequestCallback(new Action(this.OnPresentViewCloseRequest));
			task.Execute();
		}

		// Token: 0x06038279 RID: 230009 RVA: 0x00FB28A8 File Offset: 0x00FB0AA8
		private void OnPresentViewCloseRequest()
		{
			this.PendingClosePresentView = true;
		}

		// Token: 0x0603827A RID: 230010 RVA: 0x00FB28B4 File Offset: 0x00FB0AB4
		private void OnCurrentTaskComplete(int taskId, Action preExecuteNextCallback)
		{
			if (this.CurrentTask == null || this.CurrentTask.TaskId != taskId)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] OnTaskFinish 任务不匹配";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", taskId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.CurrentTask = null;
			if (preExecuteNextCallback != null)
			{
				preExecuteNextCallback();
			}
			if (!this.IsActive)
			{
				return;
			}
			this.OnTaskFinish(taskId);
		}

		// Token: 0x0603827B RID: 230011 RVA: 0x00FB2927 File Offset: 0x00FB0B27
		public void AbortCurrentTask()
		{
			if (this.CurrentTask == null)
			{
				return;
			}
			this.CurrentTask.ForceFinish();
			this.CurrentTask = null;
		}

		// Token: 0x0603827C RID: 230012
		protected abstract void OnEnterState(ESolarSchoolStageStateType? prev);

		// Token: 0x0603827D RID: 230013
		protected abstract void OnTaskFinish(int taskId);

		// Token: 0x0603827E RID: 230014 RVA: 0x00FB2944 File Offset: 0x00FB0B44
		protected virtual void OnExitState(ESolarSchoolStageStateType? next)
		{
		}

		// Token: 0x0603827F RID: 230015 RVA: 0x00FB2946 File Offset: 0x00FB0B46
		public virtual bool CanPlayerFreeChoose()
		{
			return true;
		}

		// Token: 0x06038280 RID: 230016 RVA: 0x00FB2949 File Offset: 0x00FB0B49
		public SolarSchoolTaskBase GetRunningTask()
		{
			if (!this.IsActive || this.CurrentTask == null || !this.CurrentTask.IsExecuting)
			{
				return null;
			}
			return this.CurrentTask;
		}

		// Token: 0x17006BBE RID: 27582
		// (get) Token: 0x06038281 RID: 230017 RVA: 0x00FB2970 File Offset: 0x00FB0B70
		public bool HasRunningTask
		{
			get
			{
				return this.GetRunningTask() != null;
			}
		}

		// Token: 0x06038282 RID: 230018 RVA: 0x00FB297B File Offset: 0x00FB0B7B
		[NullableContext(1)]
		public bool TryPushActionToCurrentTask(SolarSchoolActionBase action)
		{
			if (!this.IsActive || this.CurrentTask == null)
			{
				return false;
			}
			if (!this.CurrentTask.TryPushAction(action))
			{
				return false;
			}
			SolarSchoolGamePlayModel.Instance.TimeData.SyncDisplaySlot();
			return true;
		}

		// Token: 0x0401D91B RID: 121115
		private bool PendingClosePresentView;
	}
}
