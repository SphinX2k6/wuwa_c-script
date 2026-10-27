using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F97 RID: 28567
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowReleaseLevelSequence : LevelFlowActionBase
	{
		// Token: 0x06045757 RID: 284503 RVA: 0x0113A5B8 File Offset: 0x011387B8
		public LevelFlowReleaseLevelSequence Init(string sequencePath)
		{
			this.SequencePath = sequencePath;
			return this;
		}

		// Token: 0x06045758 RID: 284504 RVA: 0x0113A5C2 File Offset: 0x011387C2
		protected override void OnExecute()
		{
			LevelFlowResourceManager.ReleaseSequence(this.SequencePath);
			base.FinishExecute(true);
		}

		// Token: 0x040243E2 RID: 148450
		private string SequencePath = string.Empty;
	}
}
