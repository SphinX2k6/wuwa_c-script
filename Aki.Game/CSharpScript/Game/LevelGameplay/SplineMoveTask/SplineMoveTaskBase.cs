using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A2D RID: 27181
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineMoveTaskBase
	{
		// Token: 0x060439A9 RID: 276905 RVA: 0x0108B128 File Offset: 0x01089328
		protected SplineMoveTaskBase(EntityHandle entityHandle)
		{
			this.EntityHandle = entityHandle;
		}

		// Token: 0x060439AA RID: 276906 RVA: 0x0108B138 File Offset: 0x01089338
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

		// Token: 0x060439AB RID: 276907 RVA: 0x0108B1E0 File Offset: 0x010893E0
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

		// Token: 0x060439AC RID: 276908 RVA: 0x0108B280 File Offset: 0x01089480
		public void TickTask(double delta)
		{
			this.OnTickTask(delta);
		}

		// Token: 0x060439AD RID: 276909 RVA: 0x0108B289 File Offset: 0x01089489
		protected virtual void OnStartTask()
		{
		}

		// Token: 0x060439AE RID: 276910 RVA: 0x0108B28B File Offset: 0x0108948B
		protected virtual void OnEndTask(bool success)
		{
		}

		// Token: 0x060439AF RID: 276911 RVA: 0x0108B28D File Offset: 0x0108948D
		protected virtual void OnTickTask(double delta)
		{
		}

		// Token: 0x040234C1 RID: 144577
		public readonly EntityHandle EntityHandle;

		// Token: 0x040234C2 RID: 144578
		private ESplineMoveTaskState TaskState;
	}
}
