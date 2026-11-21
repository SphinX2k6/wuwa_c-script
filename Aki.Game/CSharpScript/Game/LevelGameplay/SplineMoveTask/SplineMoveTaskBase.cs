using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B8A RID: 23434
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineMoveTaskBase
	{
		// Token: 0x060399F7 RID: 236023 RVA: 0x0102F958 File Offset: 0x0102DB58
		protected SplineMoveTaskBase(EntityHandle entityHandle)
		{
			this.EntityHandle = entityHandle;
		}

		// Token: 0x060399F8 RID: 236024 RVA: 0x0102F968 File Offset: 0x0102DB68
		public void StartTask()
		{
			if ((this.TaskState & ESplineMoveTaskState.Start) != ESplineMoveTaskState.None)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SplineMoveTaskBase] StartTask";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.EntityHandle.Id);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			if (!SplineMoveTaskController.Instance.RegisterTask(this))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelEvent;
				ELogAuthor author2 = ELogAuthor.ZYL;
				string message2 = "[SplineMoveTaskBase] Task注册失败，停止";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", this.EntityHandle.Id);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			this.OnStartTask();
			this.TaskState |= ESplineMoveTaskState.Start;
		}

		// Token: 0x060399F9 RID: 236025 RVA: 0x0102FA10 File Offset: 0x0102DC10
		public unsafe void EndTask(bool success)
		{
			if ((this.TaskState & ESplineMoveTaskState.End) != ESplineMoveTaskState.None)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "[SplineMoveTaskBase] EndTask";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.EntityHandle.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Success", success);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			SplineMoveTaskController.Instance.UnregisterTask(this);
			this.OnEndTask(success);
			this.TaskState |= ESplineMoveTaskState.End;
		}

		// Token: 0x060399FA RID: 236026 RVA: 0x0102FAB0 File Offset: 0x0102DCB0
		public void TickTask(double delta)
		{
			this.OnTickTask(delta);
		}

		// Token: 0x060399FB RID: 236027 RVA: 0x0102FAB9 File Offset: 0x0102DCB9
		protected virtual void OnStartTask()
		{
		}

		// Token: 0x060399FC RID: 236028 RVA: 0x0102FABB File Offset: 0x0102DCBB
		protected virtual void OnEndTask(bool success)
		{
		}

		// Token: 0x060399FD RID: 236029 RVA: 0x0102FABD File Offset: 0x0102DCBD
		protected virtual void OnTickTask(double delta)
		{
		}

		// Token: 0x0401E6B3 RID: 124595
		public readonly EntityHandle EntityHandle;

		// Token: 0x0401E6B4 RID: 124596
		private ESplineMoveTaskState TaskState;
	}
}
