using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Module.InstanceDungeon;

namespace CSharpScript.Game.Module.InstanceDungeon.Define
{
	// Token: 0x020048B7 RID: 18615
	public class InstanceDungeonEntranceFlowRoguelike : InstanceDungeonEntranceFlowBase
	{
		// Token: 0x0602EBEF RID: 191471 RVA: 0x00D0A02C File Offset: 0x00D0822C
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
				List<int> list = new List<int>();
				foreach (int num in RoguelikeModel.Instance.GetEntranceViewModel().FormationIdList)
				{
					if (num != 0)
					{
						list.Add(num);
					}
				}
				RoguelikeController.Instance.RoguelikeStartRequest(false, InstanceDungeonEntranceModel.Instance.InstanceId, list, RoguelikeModel.Instance.GetEntranceViewModel().CurrentEntriesGroupData.Id);
			});
		}
	}
}
