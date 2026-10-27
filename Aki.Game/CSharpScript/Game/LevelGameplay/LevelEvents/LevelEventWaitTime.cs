using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BB8 RID: 27576
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventWaitTime : LevelEventBase
	{
		// Token: 0x0604433C RID: 279356 RVA: 0x010CFE10 File Offset: 0x010CE010
		public LevelEventWaitTime(int id) : base(id)
		{
		}

		// Token: 0x0604433D RID: 279357 RVA: 0x010CFE19 File Offset: 0x010CE019
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0604433E RID: 279358 RVA: 0x010CFE24 File Offset: 0x010CE024
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

		// Token: 0x0604433F RID: 279359 RVA: 0x010CFEC8 File Offset: 0x010CE0C8
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

		// Token: 0x06044340 RID: 279360 RVA: 0x010CFF43 File Offset: 0x010CE143
		protected override void OnReset()
		{
			this.DisableInput = false;
			this.TotalTime = 0f;
		}

		// Token: 0x04023982 RID: 145794
		private float TotalTime;

		// Token: 0x04023983 RID: 145795
		private bool DisableInput;
	}
}
