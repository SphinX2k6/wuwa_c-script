using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB3 RID: 23731
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventInterludeActions : LevelEventBase
	{
		// Token: 0x0603A298 RID: 238232 RVA: 0x01066CAA File Offset: 0x01064EAA
		public LevelEventInterludeActions(int id) : base(id)
		{
		}

		// Token: 0x0603A299 RID: 238233 RVA: 0x01066CB3 File Offset: 0x01064EB3
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A29A RID: 238234 RVA: 0x01066CBE File Offset: 0x01064EBE
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			this.Param = (inParams as InterludeActions);
			this.Context = context;
			if (this.Param.IsFadeIn)
			{
				this.OnStateIn();
				return;
			}
			this.OnStateStay();
		}

		// Token: 0x0603A29B RID: 238235 RVA: 0x01066CFA File Offset: 0x01064EFA
		private void OnStateIn()
		{
		}

		// Token: 0x0603A29C RID: 238236 RVA: 0x01066CFC File Offset: 0x01064EFC
		private void OnStateStay()
		{
			InterludeActions param = this.Param;
			if (((param != null) ? param.InterludeActionList : null) != null && this.Param.InterludeActionList.Count > 0)
			{
				LevelGeneralController.Instance.ExecuteActionsNew(this.Param.InterludeActionList, GeneralContext.Copy(this.Context), new Action<ELevelEventState>(this.OnActionsDone));
				return;
			}
			this.OnStateOut();
		}

		// Token: 0x0603A29D RID: 238237 RVA: 0x01066D63 File Offset: 0x01064F63
		private void OnActionsDone(ELevelEventState _)
		{
			this.OnStateOut();
		}

		// Token: 0x0603A29E RID: 238238 RVA: 0x01066D6B File Offset: 0x01064F6B
		private void OnStateOut()
		{
			InterludeActions param = this.Param;
			if (param == null || !param.IsFadeOut)
			{
				base.FinishExecute(true, false, true);
				return;
			}
		}

		// Token: 0x0401EBA8 RID: 125864
		[Nullable(2)]
		private InterludeActions Param;

		// Token: 0x0401EBA9 RID: 125865
		[Nullable(2)]
		private GeneralContext Context;
	}
}
