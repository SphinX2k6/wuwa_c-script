using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006121 RID: 24865
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowShowHookEffectAction : LevelFlowActionBase
	{
		// Token: 0x0603B928 RID: 244008 RVA: 0x010E4FE6 File Offset: 0x010E31E6
		public LevelFlowShowHookEffectAction Init(int entityId, string targetTag, int cueId)
		{
			this.EntityId = entityId;
			this.TargetTag = targetTag;
			this.CueId = cueId;
			return this;
		}

		// Token: 0x0603B929 RID: 244009 RVA: 0x010E4FFE File Offset: 0x010E31FE
		protected override void OnExecute()
		{
			LevelFlowResourceManager.ShowHookEffect(this.EntityId, this.TargetTag, this.CueId);
			base.FinishExecute(true);
		}

		// Token: 0x0401F6A7 RID: 128679
		private int EntityId;

		// Token: 0x0401F6A8 RID: 128680
		private string TargetTag = string.Empty;

		// Token: 0x0401F6A9 RID: 128681
		private int CueId;
	}
}
