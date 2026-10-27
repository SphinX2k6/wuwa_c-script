using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F81 RID: 28545
	public class LevelFlowDeadEyeMode : LevelFlowActionBase
	{
		// Token: 0x060456D7 RID: 284375 RVA: 0x01137314 File Offset: 0x01135514
		[NullableContext(1)]
		public LevelFlowDeadEyeMode Init(DeadEyeModeParams params_)
		{
			this.Params = params_;
			return this;
		}

		// Token: 0x060456D8 RID: 284376 RVA: 0x0113731E File Offset: 0x0113551E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnDeadEyeModeFinish, new Action(this.OnDeadEyeModeFinish));
		}

		// Token: 0x060456D9 RID: 284377 RVA: 0x0113733C File Offset: 0x0113553C
		protected override void OnExecute()
		{
			if (this.Params == null)
			{
				Log.Instance.Error(ELogModule.LevelFlow, ELogAuthor.BB, "执行行为LevelFlowDeadEyeMode失败，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false);
				return;
			}
			DeadEyeModeController.Instance.EnterDeadEyeModeWithoutEntity(this.Params);
		}

		// Token: 0x060456DA RID: 284378 RVA: 0x01137389 File Offset: 0x01135589
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDeadEyeModeFinish, new Action(this.OnDeadEyeModeFinish));
		}

		// Token: 0x060456DB RID: 284379 RVA: 0x011373A7 File Offset: 0x011355A7
		private void OnDeadEyeModeFinish()
		{
			base.FinishExecute(true);
		}

		// Token: 0x040243B0 RID: 148400
		[Nullable(2)]
		private DeadEyeModeParams Params;
	}
}
