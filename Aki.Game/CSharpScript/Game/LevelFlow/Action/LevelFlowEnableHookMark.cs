using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F82 RID: 28546
	public class LevelFlowEnableHookMark : LevelFlowActionBase
	{
		// Token: 0x060456DD RID: 284381 RVA: 0x011373B8 File Offset: 0x011355B8
		[NullableContext(1)]
		public LevelFlowEnableHookMark Init(bool isEnable)
		{
			this.IsEnable = isEnable;
			return this;
		}

		// Token: 0x060456DE RID: 284382 RVA: 0x011373C2 File Offset: 0x011355C2
		protected override void OnExecute()
		{
			EventSystem.Instance.Emit<bool>(EEventName.EnableGrapplingHookMark, this.IsEnable);
			base.FinishExecute(true);
		}

		// Token: 0x040243B1 RID: 148401
		private bool IsEnable;
	}
}
