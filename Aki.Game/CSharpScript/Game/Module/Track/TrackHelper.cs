using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Controller;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.Track
{
	// Token: 0x02004AFB RID: 19195
	[NullableContext(1)]
	[Nullable(0)]
	public static class TrackHelper
	{
		// Token: 0x06031B60 RID: 203616 RVA: 0x00B8B628 File Offset: 0x00B89828
		public static void SetMarkItemTrack(MarkItem markItem, [Nullable(2)] Action finishCallback = null)
		{
			TaskMarkItem taskMarkItem = markItem as TaskMarkItem;
			if (taskMarkItem != null)
			{
				TrackHelper.HandleTaskMarkItemTracking(taskMarkItem, finishCallback);
				return;
			}
			TrackHelper.HandleNormalMarkItemTracking(markItem, finishCallback);
		}

		// Token: 0x06031B61 RID: 203617 RVA: 0x00B8B650 File Offset: 0x00B89850
		private static void HandleTaskMarkItemTracking(TaskMarkItem taskMarkItem, [Nullable(2)] Action finishCallback)
		{
			if (taskMarkItem.NodeId != 0)
			{
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(taskMarkItem.InstanceDungeonId.GetValueOrDefault());
				int num = (config != null) ? config.GetValueOrDefault().RelatedQuestId : 0;
				int treeConfigId = taskMarkItem.TreeConfigId;
				QuestNewModel instance = QuestNewModel.Instance;
				if (!((num != 0) ? instance.IsTrackingQuest(num) : instance.IsTrackingQuest(treeConfigId)))
				{
					QuestNewController.Instance.RequestTrackQuest((num != 0) ? num : taskMarkItem.TreeConfigId, true, ERequestTrackOperate.Manual, ESetTrackReason.None, finishCallback);
					return;
				}
				if (finishCallback != null)
				{
					finishCallback();
					return;
				}
			}
			else
			{
				TrackHelper.HandleTaskMarkWithoutBehaviorId(taskMarkItem, finishCallback);
			}
		}

		// Token: 0x06031B62 RID: 203618 RVA: 0x00B8B6EC File Offset: 0x00B898EC
		private static void HandleTaskMarkWithoutBehaviorId(TaskMarkItem taskMarkItem, [Nullable(2)] Action finishCallback)
		{
			TrackMapMarkParams curTrackMark = MapModel.Instance.GetCurTrackMark();
			if (curTrackMark == null || curTrackMark.MarkId != taskMarkItem.MarkId)
			{
				MapController.Instance.RequestTrackMapMark(new TrackMapMarkParams
				{
					MarkType = EMarkType.Quest,
					MarkId = taskMarkItem.MarkId,
					Track = true
				}, delegate(ETrackMapMarkResultType result, bool track)
				{
					Action finishCallback3 = finishCallback;
					if (finishCallback3 == null)
					{
						return;
					}
					finishCallback3();
				});
				return;
			}
			Action finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2();
		}

		// Token: 0x06031B63 RID: 203619 RVA: 0x00B8B774 File Offset: 0x00B89974
		private static void HandleNormalMarkItemTracking(MarkItem markItem, [Nullable(2)] Action finishCallback)
		{
			if (!markItem.IsTracked)
			{
				MapController.Instance.RequestTrackMapMark(new TrackMapMarkParams
				{
					MarkType = markItem.MarkType,
					MarkId = markItem.MarkId,
					Track = true
				}, delegate(ETrackMapMarkResultType result, bool track)
				{
					Action finishCallback3 = finishCallback;
					if (finishCallback3 == null)
					{
						return;
					}
					finishCallback3();
				});
				return;
			}
			Action finishCallback2 = finishCallback;
			if (finishCallback2 == null)
			{
				return;
			}
			finishCallback2();
		}
	}
}
