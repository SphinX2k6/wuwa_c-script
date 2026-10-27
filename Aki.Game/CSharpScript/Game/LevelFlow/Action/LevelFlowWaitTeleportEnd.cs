using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FAD RID: 28589
	public class LevelFlowWaitTeleportEnd : LevelFlowActionBase
	{
		// Token: 0x060457B7 RID: 284599 RVA: 0x0113CA1C File Offset: 0x0113AC1C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		}

		// Token: 0x060457B8 RID: 284600 RVA: 0x0113CA3A File Offset: 0x0113AC3A
		protected override void OnExecute()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x060457B9 RID: 284601 RVA: 0x0113CA4F File Offset: 0x0113AC4F
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		}

		// Token: 0x060457BA RID: 284602 RVA: 0x0113CA6D File Offset: 0x0113AC6D
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext context)
		{
			base.FinishExecute(true);
		}
	}
}
