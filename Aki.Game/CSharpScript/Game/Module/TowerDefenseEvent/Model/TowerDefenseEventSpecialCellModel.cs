using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B14 RID: 19220
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseEventSpecialCellModel : TowerDefenseEventEntityModel, ITowerDefenseEventSpecialCellInfo, ITowerDefenseEventSpecialCellBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B47 RID: 31559
		// (get) Token: 0x06031C91 RID: 203921 RVA: 0x00B8E920 File Offset: 0x00B8CB20
		// (set) Token: 0x06031C92 RID: 203922 RVA: 0x00B8E928 File Offset: 0x00B8CB28
		public int ConfigId { get; set; }

		// Token: 0x17007B48 RID: 31560
		// (get) Token: 0x06031C93 RID: 203923 RVA: 0x00B8E931 File Offset: 0x00B8CB31
		// (set) Token: 0x06031C94 RID: 203924 RVA: 0x00B8E939 File Offset: 0x00B8CB39
		public int CellType { get; set; }

		// Token: 0x17007B49 RID: 31561
		// (get) Token: 0x06031C95 RID: 203925 RVA: 0x00B8E942 File Offset: 0x00B8CB42
		// (set) Token: 0x06031C96 RID: 203926 RVA: 0x00B8E94A File Offset: 0x00B8CB4A
		public Vector2D GridSize { get; set; } = new Vector2D();

		// Token: 0x17007B4A RID: 31562
		// (get) Token: 0x06031C97 RID: 203927 RVA: 0x00B8E953 File Offset: 0x00B8CB53
		// (set) Token: 0x06031C98 RID: 203928 RVA: 0x00B8E95B File Offset: 0x00B8CB5B
		[Nullable(2)]
		public string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B4B RID: 31563
		// (get) Token: 0x06031C99 RID: 203929 RVA: 0x00B8E964 File Offset: 0x00B8CB64
		// (set) Token: 0x06031C9A RID: 203930 RVA: 0x00B8E96C File Offset: 0x00B8CB6C
		public Vector2D Coords { get; set; } = new Vector2D();

		// Token: 0x06031C9B RID: 203931 RVA: 0x00B8E978 File Offset: 0x00B8CB78
		[return: Nullable(2)]
		public new static ITowerDefenseEventCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			EntityComponentPb entityComponentPb;
			if (!componentDataMap.ContainsKey("SimpleCombatComponentPb") || !componentDataMap.ContainsKey("GridObjectComponentPb") || !componentDataMap.TryGetValue("TrapDefenseComponentPb", out entityComponentPb))
			{
				return null;
			}
			if (entityComponentPb.TrapDefenseComponentPb.SpecialCellPbData == null)
			{
				return null;
			}
			TowerDefenseEventSpecialCellModel towerDefenseEventSpecialCellModel = TowerDefenseEventSpecialCellModel.SpecialCellPool.Get() ?? TowerDefenseEventSpecialCellModel.SpecialCellPool.Create();
			towerDefenseEventSpecialCellModel.InitFromProto(entityData, componentDataMap);
			return towerDefenseEventSpecialCellModel;
		}

		// Token: 0x06031C9C RID: 203932 RVA: 0x00B8E9DF File Offset: 0x00B8CBDF
		public new static void Clear()
		{
			TowerDefenseEventSpecialCellModel.SpecialCellPool.Clear();
		}

		// Token: 0x06031C9D RID: 203933 RVA: 0x00B8E9EB File Offset: 0x00B8CBEB
		public static TowerDefenseEventSpecialCellModel GetSpecialCellModel(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			TowerDefenseEventSpecialCellModel towerDefenseEventSpecialCellModel = TowerDefenseEventSpecialCellModel.SpecialCellPool.Get() ?? TowerDefenseEventSpecialCellModel.SpecialCellPool.Create();
			towerDefenseEventSpecialCellModel.Update(baseInfo);
			return towerDefenseEventSpecialCellModel;
		}

		// Token: 0x06031C9E RID: 203934 RVA: 0x00B8EA0C File Offset: 0x00B8CC0C
		protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			base.InitFromProto(entityData, componentDataMap);
			GridObjectComponentPb gridObjectComponentPb = componentDataMap["GridObjectComponentPb"].GridObjectComponentPb;
			this.GridId = gridObjectComponentPb.InitGridPlacementPbInfo.ActorGuid;
			this.Coords.Set((double)gridObjectComponentPb.InitGridPlacementPbInfo.X, (double)gridObjectComponentPb.InitGridPlacementPbInfo.Y);
			this.GridSize.Set(0.0, 0.0);
			TrapDefenseComponentPb trapDefenseComponentPb = componentDataMap["TrapDefenseComponentPb"].TrapDefenseComponentPb;
			this.ConfigId = trapDefenseComponentPb.SpecialCellPbData.ConfigId;
		}

		// Token: 0x06031C9F RID: 203935 RVA: 0x00B8EAA8 File Offset: 0x00B8CCA8
		public override void Update(ITowerDefenseEventCombatInfo other)
		{
			base.Update(other);
			ITowerDefenseEventSpecialCellInfo towerDefenseEventSpecialCellInfo = other as ITowerDefenseEventSpecialCellInfo;
			if (towerDefenseEventSpecialCellInfo != null)
			{
				this.ConfigId = towerDefenseEventSpecialCellInfo.ConfigId;
				this.CellType = towerDefenseEventSpecialCellInfo.CellType;
				this.GridId = towerDefenseEventSpecialCellInfo.GridId;
				this.GridSize.Set(towerDefenseEventSpecialCellInfo.GridSize.X, towerDefenseEventSpecialCellInfo.GridSize.Y);
				this.Coords.Set(towerDefenseEventSpecialCellInfo.Coords.X, towerDefenseEventSpecialCellInfo.Coords.Y);
				return;
			}
			this.ConfigId = 0;
			this.CellType = 0;
			this.GridId = null;
			this.GridSize.Set(0.0, 0.0);
			this.Coords.Set(0.0, 0.0);
		}

		// Token: 0x06031CA0 RID: 203936 RVA: 0x00B8EB7C File Offset: 0x00B8CD7C
		public void UpdateTransform(FVectorDouble position, FRotator rotation)
		{
			base.Position.Set(position.X, position.Y, position.Z);
			base.Rotation.Set(rotation.Pitch, rotation.Yaw, rotation.Roll);
		}

		// Token: 0x06031CA1 RID: 203937 RVA: 0x00B8EBB8 File Offset: 0x00B8CDB8
		public void UpdateData(string gridId, FKuroBuildingGridCellVector coords)
		{
			this.GridId = gridId;
			this.Coords.Set((double)coords.X, (double)coords.Y);
		}

		// Token: 0x06031CA2 RID: 203938 RVA: 0x00B8EBDC File Offset: 0x00B8CDDC
		public override void Reset()
		{
			base.Reset();
			this.ConfigId = 0;
			this.GridId = null;
			this.Coords.Set(0.0, 0.0);
			this.GridSize.Set(0.0, 0.0);
		}

		// Token: 0x06031CA3 RID: 203939 RVA: 0x00B8EC37 File Offset: 0x00B8CE37
		public override void Release()
		{
			this.Reset();
			TowerDefenseEventSpecialCellModel.SpecialCellPool.Put(this);
		}

		// Token: 0x06031CA4 RID: 203940 RVA: 0x00B8EC4B File Offset: 0x00B8CE4B
		public new ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventSpecialCellModel towerDefenseEventSpecialCellModel = TowerDefenseEventSpecialCellModel.SpecialCellPool.Get() ?? TowerDefenseEventSpecialCellModel.SpecialCellPool.Create();
			towerDefenseEventSpecialCellModel.Update(this);
			return towerDefenseEventSpecialCellModel;
		}

		// Token: 0x0401A92D RID: 108845
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventSpecialCellModel> SpecialCellPool = new Pool<TowerDefenseEventSpecialCellModel>(100, () => new TowerDefenseEventSpecialCellModel(), null);
	}
}
