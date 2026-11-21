using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003ABC RID: 15036
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseEventSpecialCellModel : TowerDefenseEventEntityModel, ITowerDefenseEventSpecialCellInfo, ITowerDefenseEventSpecialCellBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x06026A21 RID: 158241 RVA: 0x00AD298C File Offset: 0x00AD0B8C
		// (set) Token: 0x06026A22 RID: 158242 RVA: 0x00AD2994 File Offset: 0x00AD0B94
		public int ConfigId { get; set; }

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x06026A23 RID: 158243 RVA: 0x00AD299D File Offset: 0x00AD0B9D
		// (set) Token: 0x06026A24 RID: 158244 RVA: 0x00AD29A5 File Offset: 0x00AD0BA5
		public int CellType { get; set; }

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x06026A25 RID: 158245 RVA: 0x00AD29AE File Offset: 0x00AD0BAE
		// (set) Token: 0x06026A26 RID: 158246 RVA: 0x00AD29B6 File Offset: 0x00AD0BB6
		public Vector2D GridSize { get; set; } = new Vector2D();

		// Token: 0x17004EF7 RID: 20215
		// (get) Token: 0x06026A27 RID: 158247 RVA: 0x00AD29BF File Offset: 0x00AD0BBF
		// (set) Token: 0x06026A28 RID: 158248 RVA: 0x00AD29C7 File Offset: 0x00AD0BC7
		[Nullable(2)]
		public string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004EF8 RID: 20216
		// (get) Token: 0x06026A29 RID: 158249 RVA: 0x00AD29D0 File Offset: 0x00AD0BD0
		// (set) Token: 0x06026A2A RID: 158250 RVA: 0x00AD29D8 File Offset: 0x00AD0BD8
		public Vector2D Coords { get; set; } = new Vector2D();

		// Token: 0x06026A2B RID: 158251 RVA: 0x00AD29E4 File Offset: 0x00AD0BE4
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

		// Token: 0x06026A2C RID: 158252 RVA: 0x00AD2A4B File Offset: 0x00AD0C4B
		public new static void Clear()
		{
			TowerDefenseEventSpecialCellModel.SpecialCellPool.Clear();
		}

		// Token: 0x06026A2D RID: 158253 RVA: 0x00AD2A57 File Offset: 0x00AD0C57
		public static TowerDefenseEventSpecialCellModel GetSpecialCellModel(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			TowerDefenseEventSpecialCellModel towerDefenseEventSpecialCellModel = TowerDefenseEventSpecialCellModel.SpecialCellPool.Get() ?? TowerDefenseEventSpecialCellModel.SpecialCellPool.Create();
			towerDefenseEventSpecialCellModel.Update(baseInfo);
			return towerDefenseEventSpecialCellModel;
		}

		// Token: 0x06026A2E RID: 158254 RVA: 0x00AD2A78 File Offset: 0x00AD0C78
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

		// Token: 0x06026A2F RID: 158255 RVA: 0x00AD2B14 File Offset: 0x00AD0D14
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

		// Token: 0x06026A30 RID: 158256 RVA: 0x00AD2BE8 File Offset: 0x00AD0DE8
		public void UpdateTransform(FVectorDouble position, FRotator rotation)
		{
			base.Position.Set(position.X, position.Y, position.Z);
			base.Rotation.Set(rotation.Pitch, rotation.Yaw, rotation.Roll);
		}

		// Token: 0x06026A31 RID: 158257 RVA: 0x00AD2C24 File Offset: 0x00AD0E24
		public void UpdateData(string gridId, FKuroBuildingGridCellVector coords)
		{
			this.GridId = gridId;
			this.Coords.Set((double)coords.X, (double)coords.Y);
		}

		// Token: 0x06026A32 RID: 158258 RVA: 0x00AD2C48 File Offset: 0x00AD0E48
		public override void Reset()
		{
			base.Reset();
			this.ConfigId = 0;
			this.GridId = null;
			this.Coords.Set(0.0, 0.0);
			this.GridSize.Set(0.0, 0.0);
		}

		// Token: 0x06026A33 RID: 158259 RVA: 0x00AD2CA3 File Offset: 0x00AD0EA3
		public override void Release()
		{
			this.Reset();
			TowerDefenseEventSpecialCellModel.SpecialCellPool.Put(this);
		}

		// Token: 0x06026A34 RID: 158260 RVA: 0x00AD2CB7 File Offset: 0x00AD0EB7
		public new ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventSpecialCellModel towerDefenseEventSpecialCellModel = TowerDefenseEventSpecialCellModel.SpecialCellPool.Get() ?? TowerDefenseEventSpecialCellModel.SpecialCellPool.Create();
			towerDefenseEventSpecialCellModel.Update(this);
			return towerDefenseEventSpecialCellModel;
		}

		// Token: 0x0401527F RID: 86655
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventSpecialCellModel> SpecialCellPool = new Pool<TowerDefenseEventSpecialCellModel>(100, () => new TowerDefenseEventSpecialCellModel(), null);
	}
}
