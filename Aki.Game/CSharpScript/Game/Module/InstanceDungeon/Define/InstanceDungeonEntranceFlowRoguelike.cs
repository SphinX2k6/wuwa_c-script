using System;
using System.Linq;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020058DF RID: 22751
	public class InstanceDungeonEntranceFlowRoguelike : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x06039CCC RID: 236748 RVA: 0x00DBB0D4 File Offset: 0x00DB92D4
		protected override void OnCreate()
		{
			base.AddStep(delegate
			{
				RoguelikeController.Instance.OpenRoguelikeInstanceView();
			});
			base.AddStep(delegate
			{
				RoguelikeController.Instance.OpenRoguelikeSelectRoleView(InstanceDungeonEntranceModel.Instance.InstanceId);
			});
			base.AddStep(delegate
			{
				RoguelikeController.Instance.RoguelikeStartRequest(false, InstanceDungeonEntranceModel.Instance.InstanceId, (from id in RoguelikeModel.Instance.GetEntranceViewModel().FormationIdList
				where id != 0
				select id).ToList<int>(), RoguelikeModel.Instance.GetEntranceViewModel().CurrentEntriesGroupData.Id);
			});
		}
	}
}
