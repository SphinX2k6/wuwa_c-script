using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA3 RID: 28579
	public class LevelFlowTeleportAction : LevelFlowActionBase
	{
		// Token: 0x06045784 RID: 284548 RVA: 0x0113B7FC File Offset: 0x011399FC
		[NullableContext(1)]
		public LevelFlowTeleportAction Init(int targetEntityId)
		{
			this.TargetEntityId = targetEntityId;
			return this;
		}

		// Token: 0x06045785 RID: 284549 RVA: 0x0113B806 File Offset: 0x01139A06
		protected override void OnExecute()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				base.FinishExecute(true);
				return;
			}
			LevelFlowController.Instance.LevelFlowTeleportRequest(this.TargetEntityId, new Action<bool>(base.FinishExecute));
		}

		// Token: 0x040243F9 RID: 148473
		private int TargetEntityId;
	}
}
