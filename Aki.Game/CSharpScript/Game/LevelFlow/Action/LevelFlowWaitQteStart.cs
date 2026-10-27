using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FAA RID: 28586
	public class LevelFlowWaitQteStart : LevelFlowActionBase
	{
		// Token: 0x060457A5 RID: 284581 RVA: 0x0113C4C6 File Offset: 0x0113A6C6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
		}

		// Token: 0x060457A6 RID: 284582 RVA: 0x0113C4E4 File Offset: 0x0113A6E4
		protected override void OnExecute()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x060457A7 RID: 284583 RVA: 0x0113C4F9 File Offset: 0x0113A6F9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
		}

		// Token: 0x060457A8 RID: 284584 RVA: 0x0113C517 File Offset: 0x0113A717
		private void OnCommonQteStart(int? handleId)
		{
			base.FinishExecute(true);
		}
	}
}
