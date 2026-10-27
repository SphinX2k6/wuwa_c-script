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
	// Token: 0x020054FB RID: 21755
	[NullableContext(1)]
	[Nullable(0)]
	public class TeleportMarkItem : ConfigMarkItem
	{
		// Token: 0x17008587 RID: 34183
		// (get) Token: 0x0603793B RID: 227643 RVA: 0x00D32584 File Offset: 0x00D30784
		public override bool IsFogUnlock
		{
			get
			{
				if (this.MarkConfig.Value.ObjectType == 6)
				{
					return !this.IsLocked || base.IsFogUnlock;
				}
				return base.IsFogUnlock;
			}
		}

		// Token: 0x0603793C RID: 227644 RVA: 0x00D325BE File Offset: 0x00D307BE
		public TeleportMarkItem(int markId, MapMark markConfig, UUIItem parent, EMapType mapType, float markScale, ETrackSource trackSource = ETrackSource.MapMark) : base(markId, markConfig, parent, mapType, markScale, new ETrackSource?(trackSource))
		{
		}

		// Token: 0x0603793D RID: 227645 RVA: 0x00D325D4 File Offset: 0x00D307D4
		protected override EMarkItemViewType GetMarkItemViewType()
		{
			return EMarkItemViewType.TeleportMarkItemView;
		}

		// Token: 0x0603793E RID: 227646 RVA: 0x00D325D8 File Offset: 0x00D307D8
		[PreserveBaseOverrides]
		protected new virtual TeleportMarkItemView CreateView()
		{
			return new TeleportMarkItemView(this);
		}

		// Token: 0x17008588 RID: 34184
		// (get) Token: 0x0603793F RID: 227647 RVA: 0x00D325E0 File Offset: 0x00D307E0
		// (set) Token: 0x06037940 RID: 227648 RVA: 0x00D3261C File Offset: 0x00D3081C
		public override string IconPath
		{
			get
			{
				if (!this.IsLocked)
				{
					return this.MarkConfig.Value.UnlockMarkPic;
				}
				return this.MarkConfig.Value.LockMarkPic;
			}
			set
			{
			}
		}

		// Token: 0x17008589 RID: 34185
		// (get) Token: 0x06037941 RID: 227649 RVA: 0x00D32620 File Offset: 0x00D30820
		public bool IsActivity
		{
			get
			{
				return this.MarkConfig.Value.ObjectType == 13;
			}
		}

		// Token: 0x1700858A RID: 34186
		// (get) Token: 0x06037942 RID: 227650 RVA: 0x00D32648 File Offset: 0x00D30848
		public bool IsDungeonEntrance
		{
			get
			{
				return this.MarkConfig.Value.RelativeType == 2 || InstanceDungeonEntranceConfig.Instance.CheckMarkIdLinkDungeonEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x1700858B RID: 34187
		// (get) Token: 0x06037943 RID: 227651 RVA: 0x00D3267D File Offset: 0x00D3087D
		public bool IsTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsTowerEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x1700858C RID: 34188
		// (get) Token: 0x06037944 RID: 227652 RVA: 0x00D3268F File Offset: 0x00D3088F
		public bool IsRoguelike
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsRoguelike(base.MarkConfigId);
			}
		}

		// Token: 0x1700858D RID: 34189
		// (get) Token: 0x06037945 RID: 227653 RVA: 0x00D326A4 File Offset: 0x00D308A4
		public bool IsWeeklyRogue
		{
			get
			{
				InstanceDungeon? dungeonConfig = WorldMapConfig.Instance.GetDungeonConfig(base.MarkConfigId);
				return dungeonConfig != null && dungeonConfig.Value.InstSubType == 29;
			}
		}

		// Token: 0x1700858E RID: 34190
		// (get) Token: 0x06037946 RID: 227654 RVA: 0x00D326E0 File Offset: 0x00D308E0
		public bool IsRogueRes
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsRogueRes(base.MarkConfigId);
			}
		}

		// Token: 0x1700858F RID: 34191
		// (get) Token: 0x06037947 RID: 227655 RVA: 0x00D326F2 File Offset: 0x00D308F2
		public bool IsShipTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsShipTowerEntrance(base.MarkConfigId);
			}
		}

		// Token: 0x17008590 RID: 34192
		// (get) Token: 0x06037948 RID: 227656 RVA: 0x00D32704 File Offset: 0x00D30904
		public bool IsWheelTowerEntrance
		{
			get
			{
				return InstanceDungeonEntranceConfig.Instance.CheckMarkIdIsWheelTower(base.MarkConfigId);
			}
		}

		// Token: 0x06037949 RID: 227657 RVA: 0x00D32718 File Offset: 0x00D30918
		public override bool IsMultiMap()
		{
			return this.MarkConfig.Value.MultiMapFloorId != 0;
		}

		// Token: 0x0603794A RID: 227658 RVA: 0x00D3273C File Offset: 0x00D3093C
		public override int GetMultiMapId()
		{
			return this.MarkConfig.Value.MultiMapFloorId;
		}

		// Token: 0x0603794B RID: 227659 RVA: 0x00D3275C File Offset: 0x00D3095C
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

		// Token: 0x0401D3FC RID: 119804
		[Nullable(2)]
		public TeleportMarkItemView InnerView;

		// Token: 0x0401D3FD RID: 119805
		public bool IsDirty;
	}
}
