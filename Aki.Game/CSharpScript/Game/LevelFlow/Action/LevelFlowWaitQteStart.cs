using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200612B RID: 24875
	public class LevelFlowWaitQteStart : LevelFlowActionBase
	{
		// Token: 0x0603B953 RID: 244051 RVA: 0x010E62CA File Offset: 0x010E44CA
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
		}

		// Token: 0x0603B954 RID: 244052 RVA: 0x010E62E8 File Offset: 0x010E44E8
		protected override void OnExecute()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0603B955 RID: 244053 RVA: 0x010E62FD File Offset: 0x010E44FD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int?>(EEventName.CommonQteStart, new Action<int?>(this.OnCommonQteStart));
		}

		// Token: 0x0603B956 RID: 244054 RVA: 0x010E631B File Offset: 0x010E451B
		private void OnCommonQteStart(int? handleId)
		{
			base.FinishExecute(true);
		}
	}
}
