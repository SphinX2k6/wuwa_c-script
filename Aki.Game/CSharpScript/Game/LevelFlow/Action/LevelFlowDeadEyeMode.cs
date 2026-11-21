using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006102 RID: 24834
	public class LevelFlowDeadEyeMode : LevelFlowActionBase
	{
		// Token: 0x0603B885 RID: 243845 RVA: 0x010E1118 File Offset: 0x010DF318
		[NullableContext(1)]
		public LevelFlowDeadEyeMode Init(DeadEyeModeParams params_)
		{
			this.Params = params_;
			return this;
		}

		// Token: 0x0603B886 RID: 243846 RVA: 0x010E1122 File Offset: 0x010DF322
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnDeadEyeModeFinish, new Action(this.OnDeadEyeModeFinish));
		}

		// Token: 0x0603B887 RID: 243847 RVA: 0x010E1140 File Offset: 0x010DF340
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

		// Token: 0x0603B888 RID: 243848 RVA: 0x010E118D File Offset: 0x010DF38D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDeadEyeModeFinish, new Action(this.OnDeadEyeModeFinish));
		}

		// Token: 0x0603B889 RID: 243849 RVA: 0x010E11AB File Offset: 0x010DF3AB
		private void OnDeadEyeModeFinish()
		{
			base.FinishExecute(true);
		}

		// Token: 0x0401F665 RID: 128613
		[Nullable(2)]
		private DeadEyeModeParams Params;
	}
}
