using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA0 RID: 28576
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowShowHookEffectAction : LevelFlowActionBase
	{
		// Token: 0x0604577A RID: 284538 RVA: 0x0113B1E2 File Offset: 0x011393E2
		public LevelFlowShowHookEffectAction Init(int entityId, string targetTag, int cueId)
		{
			this.EntityId = entityId;
			this.TargetTag = targetTag;
			this.CueId = cueId;
			return this;
		}

		// Token: 0x0604577B RID: 284539 RVA: 0x0113B1FA File Offset: 0x011393FA
		protected override void OnExecute()
		{
			LevelFlowResourceManager.ShowHookEffect(this.EntityId, this.TargetTag, this.CueId);
			base.FinishExecute(true);
		}

		// Token: 0x040243F2 RID: 148466
		private int EntityId;

		// Token: 0x040243F3 RID: 148467
		private string TargetTag = string.Empty;

		// Token: 0x040243F4 RID: 148468
		private int CueId;
	}
}
