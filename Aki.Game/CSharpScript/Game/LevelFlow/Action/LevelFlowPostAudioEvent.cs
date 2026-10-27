using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F94 RID: 28564
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowPostAudioEvent : LevelFlowActionBase
	{
		// Token: 0x06045744 RID: 284484 RVA: 0x01139FA9 File Offset: 0x011381A9
		public LevelFlowPostAudioEvent Init(string audioEventName)
		{
			this.AudioEventName = audioEventName;
			return this;
		}

		// Token: 0x06045745 RID: 284485 RVA: 0x01139FB3 File Offset: 0x011381B3
		protected override void OnExecute()
		{
			AudioSystem.Instance.PostEvent(this.AudioEventName);
			base.FinishExecute(true);
		}

		// Token: 0x040243D9 RID: 148441
		private string AudioEventName = string.Empty;
	}
}
