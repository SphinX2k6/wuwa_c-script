using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200612E RID: 24878
	public class LevelFlowWaitTeleportEnd : LevelFlowActionBase
	{
		// Token: 0x0603B966 RID: 244070 RVA: 0x010E6880 File Offset: 0x010E4A80
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		}

		// Token: 0x0603B967 RID: 244071 RVA: 0x010E689E File Offset: 0x010E4A9E
		protected override void OnExecute()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0603B968 RID: 244072 RVA: 0x010E68B3 File Offset: 0x010E4AB3
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		}

		// Token: 0x0603B969 RID: 244073 RVA: 0x010E68D1 File Offset: 0x010E4AD1
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext context)
		{
			base.FinishExecute(true);
		}
	}
}
