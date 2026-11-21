using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006118 RID: 24856
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowReleaseLevelSequence : LevelFlowActionBase
	{
		// Token: 0x0603B905 RID: 243973 RVA: 0x010E43BC File Offset: 0x010E25BC
		public LevelFlowReleaseLevelSequence Init(string sequencePath)
		{
			this.SequencePath = sequencePath;
			return this;
		}

		// Token: 0x0603B906 RID: 243974 RVA: 0x010E43C6 File Offset: 0x010E25C6
		protected override void OnExecute()
		{
			LevelFlowResourceManager.ReleaseSequence(this.SequencePath);
			base.FinishExecute(true);
		}

		// Token: 0x0401F697 RID: 128663
		private string SequencePath = string.Empty;
	}
}
