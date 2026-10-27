using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B36 RID: 27446
	internal class LeaveAreaItemInfo
	{
		// Token: 0x0604413C RID: 278844 RVA: 0x010BD0A0 File Offset: 0x010BB2A0
		[NullableContext(1)]
		public static bool TryLeave(ILeaveAreaItem info)
		{
			global::Quest quest = QuestNewModel.Instance.GetQuest(info.QuestId);
			if (quest == null || !quest.IsProgressing)
			{
				return false;
			}
			BehaviorNodeBase node = quest.GetNode(info.NodeId);
			if (node == null || node.Status != info.NodeState)
			{
				return false;
			}
			Area? area;
			int? num = (AreaModel.Instance.AreaInfo != null) ? new int?(area.GetValueOrDefault().AreaId) : null;
			int leaveAreaId = info.LeaveAreaId;
			if (!(num.GetValueOrDefault() == leaveAreaId & num != null))
			{
				return false;
			}
			AreaController.Instance.EndOverlap(info.LeaveAreaId);
			return true;
		}
	}
}
