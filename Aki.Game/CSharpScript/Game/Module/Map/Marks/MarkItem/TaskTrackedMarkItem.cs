using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.WorldMap;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020054FA RID: 21754
	[NullableContext(1)]
	[Nullable(0)]
	public class TaskTrackedMarkItem
	{
		// Token: 0x06037933 RID: 227635 RVA: 0x00D320AC File Offset: 0x00D302AC
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

		// Token: 0x06037934 RID: 227636 RVA: 0x00D322D8 File Offset: 0x00D304D8
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

		// Token: 0x06037935 RID: 227637 RVA: 0x00D3230C File Offset: 0x00D3050C
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

		// Token: 0x17008585 RID: 34181
		// (get) Token: 0x06037936 RID: 227638 RVA: 0x00D32415 File Offset: 0x00D30615
		public global::Vector WorldPosition
		{
			get
			{
				return MapUtil.GetTrackPositionByTrackTarget(this.TrackTarget, false, null, new int?(this.MarkPointInfo.MapId), true);
			}
		}

		// Token: 0x17008586 RID: 34182
		// (get) Token: 0x06037937 RID: 227639 RVA: 0x00D32438 File Offset: 0x00D30638
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

		// Token: 0x06037938 RID: 227640 RVA: 0x00D32464 File Offset: 0x00D30664
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

		// Token: 0x06037939 RID: 227641 RVA: 0x00D324CC File Offset: 0x00D306CC
		public bool TargetInDiffWorld()
		{
			if (this.Tree != null)
			{
				int dungeonId = this.Tree.DungeonId;
				int instanceId = CreatureModel.Instance.GetInstanceId();
				return (WorldMapModel.Instance.IsPlayerInStoryInstanceDungeon() && this.IsInConsistentBigWorldDungeon()) || MapUtil.IsDungeonDiffWorld(instanceId, dungeonId).GetValueOrDefault();
			}
			return false;
		}

		// Token: 0x0603793A RID: 227642 RVA: 0x00D32520 File Offset: 0x00D30720
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

		// Token: 0x0401D3ED RID: 119789
		public double MarkRange;

		// Token: 0x0401D3EE RID: 119790
		public double RangeMarkShowDisUp;

		// Token: 0x0401D3EF RID: 119791
		public double RangeMarkShowDisDown;

		// Token: 0x0401D3F0 RID: 119792
		public double RangeMarkShowDis;

		// Token: 0x0401D3F1 RID: 119793
		public BtType? BtType;

		// Token: 0x0401D3F2 RID: 119794
		public long? TreeIncId;

		// Token: 0x0401D3F3 RID: 119795
		public int TreeConfigId;

		// Token: 0x0401D3F4 RID: 119796
		[Nullable(2)]
		public BaseBehaviorTree Tree;

		// Token: 0x0401D3F5 RID: 119797
		public int NodeId;

		// Token: 0x0401D3F6 RID: 119798
		[Nullable(2)]
		public TTrackTarget TrackTarget;

		// Token: 0x0401D3F7 RID: 119799
		[Nullable(2)]
		public QuestMarkCreateInfo MarkPointInfo;

		// Token: 0x0401D3F8 RID: 119800
		private bool RangeActive;

		// Token: 0x0401D3F9 RID: 119801
		private readonly ETrackSource TrackSource = ETrackSource.Instance;

		// Token: 0x0401D3FA RID: 119802
		private readonly bool IsRangeTrack;

		// Token: 0x0401D3FB RID: 119803
		private bool Flag;
	}
}
