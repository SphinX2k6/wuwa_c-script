using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006F8C RID: 28556
	public class LevelFlowHideHookEffectAction : LevelFlowActionBase
	{
		// Token: 0x06045717 RID: 284439 RVA: 0x01138733 File Offset: 0x01136933
		[NullableContext(1)]
		public LevelFlowHideHookEffectAction Init(int entityId)
		{
			this.EntityId = entityId;
			return this;
		}

		// Token: 0x06045718 RID: 284440 RVA: 0x0113873D File Offset: 0x0113693D
		protected override void OnExecute()
		{
			LevelFlowResourceManager.HideHookEffect(this.EntityId);
			base.FinishExecute(true);
		}

		// Token: 0x040243BE RID: 148414
		private int EntityId;
	}
}
