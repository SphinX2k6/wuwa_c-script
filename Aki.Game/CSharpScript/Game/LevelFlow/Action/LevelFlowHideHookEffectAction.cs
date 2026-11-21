using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200610D RID: 24845
	public class LevelFlowHideHookEffectAction : LevelFlowActionBase
	{
		// Token: 0x0603B8C5 RID: 243909 RVA: 0x010E2537 File Offset: 0x010E0737
		[NullableContext(1)]
		public LevelFlowHideHookEffectAction Init(int entityId)
		{
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x0603B8C6 RID: 243910 RVA: 0x010E2541 File Offset: 0x010E0741
		protected override void OnExecute()
		{
			LevelFlowResourceManager.HideHookEffect(this.EntityId);
			base.FinishExecute(true);
		}

		// Token: 0x0401F673 RID: 128627
		private int EntityId;
	}
}
