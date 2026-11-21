using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D31 RID: 23857
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventWaitTime : LevelEventBase
	{
		// Token: 0x0603A494 RID: 238740 RVA: 0x01079D64 File Offset: 0x01077F64
		public LevelEventWaitTime(int id) : base(id)
		{
		}

		// Token: 0x0603A495 RID: 238741 RVA: 0x01079D6D File Offset: 0x01077F6D
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A496 RID: 238742 RVA: 0x01079D78 File Offset: 0x01077F78
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			Wait wait = inParams as Wait;
			this.TotalTime = wait.Time * 1000f;
			if (wait.BanInput.GetValueOrDefault())
			{
				this.DisableInput = true;
				GeneralLogicTreeModel.Instance.DisableInput = true;
				InputDistributeController.Instance.RefreshInputTag();
			}
			EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, "LevelEventWait");
			if (this.TotalTime <= 0f)
			{
				if (this.DisableInput)
				{
					GeneralLogicTreeModel.Instance.DisableInput = false;
					InputDistributeController.Instance.RefreshInputTag();
					this.DisableInput = false;
				}
				base.FinishExecute(false, false, true);
			}
		}

		// Token: 0x0603A497 RID: 238743 RVA: 0x01079E1C File Offset: 0x0107801C
		protected override void OnTick(float deltaTime)
		{
			float num = (this.BaseContext != null) ? (deltaTime * LevelGamePlayUtils.GetCustomTimeDilationByContext(this.BaseContext).GetValueOrDefault(1f)) : deltaTime;
			this.TotalTime -= num;
			if (this.TotalTime < 0f)
			{
				if (this.DisableInput)
				{
					GeneralLogicTreeModel.Instance.DisableInput = false;
					InputDistributeController.Instance.RefreshInputTag();
					this.DisableInput = false;
				}
				base.FinishExecute(true, false, true);
			}
		}

		// Token: 0x0603A498 RID: 238744 RVA: 0x01079E97 File Offset: 0x01078097
		protected override void OnReset()
		{
			this.DisableInput = false;
			this.TotalTime = 0f;
		}

		// Token: 0x0401EC24 RID: 125988
		private float TotalTime;

		// Token: 0x0401EC25 RID: 125989
		private bool DisableInput;
	}
}
