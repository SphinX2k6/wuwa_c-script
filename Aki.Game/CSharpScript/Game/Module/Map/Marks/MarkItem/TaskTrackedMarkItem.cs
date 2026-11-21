using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044CD RID: 17613
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskTrackedMarkItem
	{
		// Token: 0x0602C802 RID: 182274 RVA: 0x00C80038 File Offset: 0x00C7E238
		public TaskTrackedMarkItem(QuestMarkCreateInfo markPointInfo, ETrackSource trackSource)
		{
			this.MarkPointInfo = markPointInfo;
			this.TrackTarget = markPointInfo.TrackTarget;
			this.NodeId = markPointInfo.NodeId;
			this.TrackSource = trackSource;
			if (this.NodeId != 0)
			{
				this.TreeIncId = new long?(markPointInfo.TreeId);
				this.Tree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.TreeIncId.Value), false);
				if (this.Tree == null)
				{
					return;
				}
				this.BtType = new BtType?(this.Tree.BtType);
				this.TreeConfigId = this.Tree.TreeConfigId;
				BehaviorNodeBase node = this.Tree.GetNode(this.NodeId);
				bool flag;
				if (node == null)
				{
					flag = (null != null);
				}
				else
				{
					ITrackTarget trackTarget = node.TrackTarget;
					flag = (((trackTarget != null) ? trackTarget.ZaxisViewRange : null) != null);
				}
				if (flag)
				{
					this.RangeMarkShowDisUp = (double)((float)node.TrackTarget.ZaxisViewRange.Up.Value / 100f);
					this.RangeMarkShowDisDown = (double)((float)(-(float)node.TrackTarget.ZaxisViewRange.Down.Value) / 100f);
				}
				double rangeMarkSize = this.Tree.GetRangeMarkSize(this.NodeId);
				if (rangeMarkSize > 0.0)
				{
					this.MarkRange = rangeMarkSize / 100.0;
				}
				double rangeMarkShowDis = this.Tree.GetRangeMarkShowDis(this.NodeId);
				if (rangeMarkShowDis > 0.0)
				{
					this.RangeMarkShowDis = rangeMarkShowDis / 100.0;
				}
			}
			else
			{
				this.TreeConfigId = (int)markPointInfo.TreeId;
				global::Quest quest = QuestNewModel.Instance.GetQuest(this.TreeConfigId);
				this.BtType = new BtType?((quest != null && quest.Type == EQuest.Recall) ? Aki.Protocol.BtType.Recall : Aki.Protocol.BtType.Quest);
			}
			double markRange = this.MarkRange;
			this.IsRangeTrack = (markRange > 0.0);
			if (this.TreeIncId != null)
			{
				EventSystem.Instance.Emit<ETrackSource, long, int, int, bool>(EEventName.TaskRangeTrackStateChange, this.TrackSource, this.TreeIncId.Value, this.MarkPointInfo.NodeId, this.MarkPointInfo.MarkId.Value, false);
			}
		}

		// Token: 0x0602C803 RID: 182275 RVA: 0x00C80264 File Offset: 0x00C7E464
		public void Update()
		{
			if (!this.IsRangeTrack)
			{
				return;
			}
			if (this.TargetInDiffWorld())
			{
				return;
			}
			global::Vector playerLocation = GeneralLogicTreeUtil.Instance.GetPlayerLocation();
			if (playerLocation != null)
			{
				this.UpdateRangeShow(playerLocation);
			}
		}

		// Token: 0x0602C804 RID: 182276 RVA: 0x00C80298 File Offset: 0x00C7E498
		private void UpdateRangeShow(global::Vector playerLocation)
		{
			if (!this.IsRangeTrack)
			{
				return;
			}
			double rangeMarkShowDis = this.RangeMarkShowDis;
			double num = rangeMarkShowDis + 2.0;
			bool flag = true;
			double num3;
			bool flag2;
			if (this.RangeMarkShowDisUp != 0.0 || this.RangeMarkShowDisDown != 0.0)
			{
				double num2 = (playerLocation.Z - this.WorldPosition.Z) * 0.009999999776482582;
				num3 = global::Vector.Dist2D(playerLocation, this.WorldPosition) * 0.009999999776482582;
				flag = (num2 < this.RangeMarkShowDisUp && num2 > this.RangeMarkShowDisDown);
				flag2 = (num3 > rangeMarkShowDis && num2 > this.RangeMarkShowDisUp && num2 < this.RangeMarkShowDisDown);
			}
			else
			{
				num3 = global::Vector.Dist(playerLocation, this.WorldPosition) * 0.009999999776482582;
				flag2 = (num3 > rangeMarkShowDis);
			}
			if (this.Flag)
			{
				this.SetRangeActive(!flag2);
				this.Flag = false;
				return;
			}
			this.SetRangeActive(num3 < num && flag);
		}

		// Token: 0x17005920 RID: 22816
		// (get) Token: 0x0602C805 RID: 182277 RVA: 0x00C803A1 File Offset: 0x00C7E5A1
		public global::Vector WorldPosition
		{
			get
			{
				return MapUtil.GetTrackPositionByTrackTarget(this.TrackTarget, false, null, new int?(this.MarkPointInfo.MapId), true);
			}
		}

		// Token: 0x17005921 RID: 22817
		// (get) Token: 0x0602C806 RID: 182278 RVA: 0x00C803C4 File Offset: 0x00C7E5C4
		public int? InstanceDungeonId
		{
			get
			{
				BaseBehaviorTree tree = this.Tree;
				if (tree == null)
				{
					return null;
				}
				return new int?(tree.DungeonId);
			}
		}

		// Token: 0x0602C807 RID: 182279 RVA: 0x00C803F0 File Offset: 0x00C7E5F0
		private void SetRangeActive(bool active)
		{
			if (!this.IsRangeTrack)
			{
				return;
			}
			if (this.RangeActive == active)
			{
				return;
			}
			this.RangeActive = active;
			EventSystem.Instance.Emit<ETrackSource, long, int, int, bool>(EEventName.TaskRangeTrackStateChange, this.TrackSource, this.TreeIncId.Value, this.MarkPointInfo.NodeId, this.MarkPointInfo.MarkId.Value, active);
		}

		// Token: 0x0602C808 RID: 182280 RVA: 0x00C80458 File Offset: 0x00C7E658
		public bool TargetInDiffWorld()
		{
			if (this.Tree != null)
			{
				int dungeonId = this.Tree.DungeonId;
				int instanceId = CreatureModel.Instance.GetInstanceId();
				return (WorldMapModel.Instance.IsPlayerInStoryInstanceDungeon() && this.IsInConsistentBigWorldDungeon()) || MapUtil.IsDungeonDiffWorld(instanceId, dungeonId).GetValueOrDefault();
			}
			QuestMarkCreateInfo markPointInfo = this.MarkPointInfo;
			int valueOrDefault = ((markPointInfo != null) ? markPointInfo.InstanceDungeonId : null).GetValueOrDefault();
			return MapUtil.IsDungeonDiffWorld(CreatureModel.Instance.GetInstanceId(), valueOrDefault).GetValueOrDefault();
		}

		// Token: 0x0602C809 RID: 182281 RVA: 0x00C804E8 File Offset: 0x00C7E6E8
		private bool IsInConsistentBigWorldDungeon()
		{
			int? instanceDungeonId = this.InstanceDungeonId;
			int num = 0;
			if ((instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null) || this.InstanceDungeonId == null)
			{
				return false;
			}
			instanceDungeonId = this.InstanceDungeonId;
			num = CreatureModel.Instance.GetInstanceId();
			return !(instanceDungeonId.GetValueOrDefault() == num & instanceDungeonId != null);
		}

		// Token: 0x04017E74 RID: 97908
		public double MarkRange;

		// Token: 0x04017E75 RID: 97909
		public double RangeMarkShowDisUp;

		// Token: 0x04017E76 RID: 97910
		public double RangeMarkShowDisDown;

		// Token: 0x04017E77 RID: 97911
		public double RangeMarkShowDis;

		// Token: 0x04017E78 RID: 97912
		public BtType? BtType;

		// Token: 0x04017E79 RID: 97913
		public long? TreeIncId;

		// Token: 0x04017E7A RID: 97914
		public int TreeConfigId;

		// Token: 0x04017E7B RID: 97915
		[Nullable(2)]
		public BaseBehaviorTree Tree;

		// Token: 0x04017E7C RID: 97916
		public int NodeId;

		// Token: 0x04017E7D RID: 97917
		[Nullable(2)]
		public TTrackTarget TrackTarget;

		// Token: 0x04017E7E RID: 97918
		[Nullable(2)]
		public QuestMarkCreateInfo MarkPointInfo;

		// Token: 0x04017E7F RID: 97919
		private bool RangeActive;

		// Token: 0x04017E80 RID: 97920
		private readonly ETrackSource TrackSource = ETrackSource.Instance;

		// Token: 0x04017E81 RID: 97921
		private readonly bool IsRangeTrack;

		// Token: 0x04017E82 RID: 97922
		private bool Flag;
	}
}
