using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006103 RID: 24835
	public class LevelFlowEnableHookMark : LevelFlowActionBase
	{
		// Token: 0x0603B88B RID: 243851 RVA: 0x010E11BC File Offset: 0x010DF3BC
		[NullableContext(1)]
		public LevelFlowEnableHookMark Init(bool isEnable)
		{
			this.IsEnable = isEnable;
			return this;
		}

		// Token: 0x0603B88C RID: 243852 RVA: 0x010E11C6 File Offset: 0x010DF3C6
		protected override void OnExecute()
		{
			EventSystem.Instance.Emit<bool>(EEventName.EnableGrapplingHookMark, this.IsEnable);
			base.FinishExecute(true);
		}

		// Token: 0x0401F666 RID: 128614
		private bool IsEnable;
	}
}
