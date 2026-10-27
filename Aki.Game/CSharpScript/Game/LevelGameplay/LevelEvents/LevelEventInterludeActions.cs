using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B3B RID: 27451
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventInterludeActions : LevelEventBase
	{
		// Token: 0x06044146 RID: 278854 RVA: 0x010BD41E File Offset: 0x010BB61E
		public LevelEventInterludeActions(int id) : base(id)
		{
		}

		// Token: 0x06044147 RID: 278855 RVA: 0x010BD427 File Offset: 0x010BB627
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x06044148 RID: 278856 RVA: 0x010BD432 File Offset: 0x010BB632
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

		// Token: 0x06044149 RID: 278857 RVA: 0x010BD46E File Offset: 0x010BB66E
		private void OnStateIn()
		{
		}

		// Token: 0x0604414A RID: 278858 RVA: 0x010BD470 File Offset: 0x010BB670
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

		// Token: 0x0604414B RID: 278859 RVA: 0x010BD4D7 File Offset: 0x010BB6D7
		private void OnActionsDone(ELevelEventState _)
		{
			this.OnStateOut();
		}

		// Token: 0x0604414C RID: 278860 RVA: 0x010BD4DF File Offset: 0x010BB6DF
		private void OnStateOut()
		{
			InterludeActions param = this.Param;
			if (param == null || !param.IsFadeOut)
			{
				base.FinishExecute(true, false, true);
				return;
			}
		}

		// Token: 0x04023906 RID: 145670
		[Nullable(2)]
		private InterludeActions Param;

		// Token: 0x04023907 RID: 145671
		[Nullable(2)]
		private GeneralContext Context;
	}
}
