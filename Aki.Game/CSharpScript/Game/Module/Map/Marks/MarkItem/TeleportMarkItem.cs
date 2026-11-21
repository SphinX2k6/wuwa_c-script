using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;
using CSharpScript.Game.Module.WorldMap;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItem
{
	// Token: 0x020044CE RID: 17614
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportMarkItem : ConfigMarkItem
	{
		// Token: 0x17005922 RID: 22818
		// (get) Token: 0x0602C80A RID: 182282 RVA: 0x00C8054C File Offset: 0x00C7E74C
		public override bool IsFogUnlock
		{
			get
			{
				if (base.MarkConfig.Value.ObjectType == 6)
				{
					return !this.IsLocked || base.IsFogUnlock;
				}
				return base.IsFogUnlock;
			}
		}

		// Token: 0x0602C80B RID: 182283 RVA: 0x00C80589 File Offset: 0x00C7E789
		public TeleportMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0602C80C RID: 182284 RVA: 0x00C8059F File Offset: 0x00C7E79F
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TeleportMarkItemView;
		}

		// Token: 0x0602C80D RID: 182285 RVA: 0x00C805A3 File Offset: 0x00C7E7A3
		[PreserveBaseOverrides]
		protected new virtual TeleportMarkItemView CreateView()
		{
			return new TeleportMarkItemView(this);
		}

		// Token: 0x17005923 RID: 22819
		// (get) Token: 0x0602C80E RID: 182286 RVA: 0x00C805AC File Offset: 0x00C7E7AC
		// (set) Token: 0x0602C80F RID: 182287 RVA: 0x00C805EE File Offset: 0x00C7E7EE
		public override string IconPath
		{
			get
			{
				if (!this.IsLocked)
				{
					return base.MarkConfig.Value.UnlockMarkPic;
				}
				return base.MarkConfig.Value.LockMarkPic;
			}
			set
			{
			}
		}

		// Token: 0x17005924 RID: 22820
		// (get) Token: 0x0602C810 RID: 182288 RVA: 0x00C805F0 File Offset: 0x00C7E7F0
		public bool IsActivity
		{
			get
			{
				return base.MarkConfig.Value.ObjectType == 13;
			}
		}

		// Token: 0x17005925 RID: 22821
		// (get) Token: 0x0602C811 RID: 182289 RVA: 0x00C8061C File Offset: 0x00C7E81C
		public bool IsDungeonEntrance
		{
			get
			{
				return base.MarkConfig.Value.RelativeType == 2 || InstanceDungeonEntranceConfig.Instance.CheckMarkIdLinkDungeonEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x17005926 RID: 22822
		// (get) Token: 0x0602C812 RID: 182290 RVA: 0x00C80654 File Offset: 0x00C7E854
		public bool IsTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsTowerEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x17005927 RID: 22823
		// (get) Token: 0x0602C813 RID: 182291 RVA: 0x00C80666 File Offset: 0x00C7E866
		public bool IsRoguelike
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsRoguelike(base.MarkConfigId);
			}
		}

		// Token: 0x17005928 RID: 22824
		// (get) Token: 0x0602C814 RID: 182292 RVA: 0x00C80678 File Offset: 0x00C7E878
		public bool IsWeeklyRogue
		{
			get
			{
				InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(base.MarkConfigId);
				return dungeonConfig != null && dungeonConfig.Value.InstSubType == 29;
			}
		}

		// Token: 0x17005929 RID: 22825
		// (get) Token: 0x0602C815 RID: 182293 RVA: 0x00C806B4 File Offset: 0x00C7E8B4
		public bool IsRogueRes
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsRogueRes(base.MarkConfigId);
			}
		}

		// Token: 0x1700592A RID: 22826
		// (get) Token: 0x0602C816 RID: 182294 RVA: 0x00C806C6 File Offset: 0x00C7E8C6
		public bool IsShipTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsShipTowerEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x1700592B RID: 22827
		// (get) Token: 0x0602C817 RID: 182295 RVA: 0x00C806D8 File Offset: 0x00C7E8D8
		public bool IsWheelTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsWheelTower(base.MarkConfigId);
			}
		}

		// Token: 0x0602C818 RID: 182296 RVA: 0x00C806EC File Offset: 0x00C7E8EC
		public override bool IsMultiMap()
		{
			return base.MarkConfig.Value.MultiMapFloorId != 0;
		}

		// Token: 0x0602C819 RID: 182297 RVA: 0x00C80714 File Offset: 0x00C7E914
		public override int GetMultiMapId()
		{
			return base.MarkConfig.Value.MultiMapFloorId;
		}

		// Token: 0x0602C81A RID: 182298 RVA: 0x00C80738 File Offset: 0x00C7E938
		public override ESecondaryPanel GetSecondaryUiType()
		{
			if (this.IsActivity)
			{
				return base.GetSecondaryUiType();
			}
			if (!this.IsDungeonEntrance)
			{
				return ESecondaryPanel.TeleportPanel;
			}
			if (this.IsTowerEntrance)
			{
				return ESecondaryPanel.TowerEntrancePanel;
			}
			if (this.IsRoguelike)
			{
				return ESecondaryPanel.RoguelikePanel;
			}
			if (this.IsWeeklyRogue)
			{
				return ESecondaryPanel.WeeklyRoguePanel;
			}
			if (this.IsRogueRes)
			{
				return ESecondaryPanel.RogueResPanel;
			}
			if (this.IsShipTowerEntrance)
			{
				return ESecondaryPanel.ShipTowerEntrancePanel;
			}
			if (this.IsWheelTowerEntrance)
			{
				return ESecondaryPanel.WheelTowerEntrancePanel;
			}
			return ESecondaryPanel.InstanceDungeonEntrancePanel;
		}

		// Token: 0x04017E83 RID: 97923
		public bool IsDirty;
	}
}
