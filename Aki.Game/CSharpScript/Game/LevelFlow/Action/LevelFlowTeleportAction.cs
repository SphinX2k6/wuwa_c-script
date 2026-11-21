using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006124 RID: 24868
	public class LevelFlowTeleportAction : LevelFlowActionBase
	{
		// Token: 0x0603B932 RID: 244018 RVA: 0x010E5600 File Offset: 0x010E3800
		[NullableContext(1)]
		public LevelFlowTeleportAction Init(int targetEntityId)
		{
			this.TargetEntityId = targetEntityId;
			return this;
		}

		// Token: 0x0603B933 RID: 244019 RVA: 0x010E560A File Offset: 0x010E380A
		protected override void OnExecute()
		{
			if (LevelFlowModel.Instance.IsEnd)
			{
				base.FinishExecute(true);
				return;
			}
			LevelFlowController.Instance.LevelFlowTeleportRequest(this.TargetEntityId, new Action<bool>(base.FinishExecute));
		}

		// Token: 0x0401F6AE RID: 128686
		private int TargetEntityId;
	}
}
