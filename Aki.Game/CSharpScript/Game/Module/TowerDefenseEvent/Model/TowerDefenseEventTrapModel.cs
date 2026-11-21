using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003ABB RID: 15035
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseEventTrapModel : TowerDefenseEventEntityModel, ITowerDefenseEventTrapInfo, ITowerDefenseEventTrapBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004EE8 RID: 20200
		// (get) Token: 0x060269FD RID: 158205 RVA: 0x00AD246F File Offset: 0x00AD066F
		// (set) Token: 0x060269FE RID: 158206 RVA: 0x00AD2477 File Offset: 0x00AD0677
		public int ConfigId { get; set; }

		// Token: 0x17004EE9 RID: 20201
		// (get) Token: 0x060269FF RID: 158207 RVA: 0x00AD2480 File Offset: 0x00AD0680
		// (set) Token: 0x06026A00 RID: 158208 RVA: 0x00AD2488 File Offset: 0x00AD0688
		public int TrapId { get; set; }

		// Token: 0x17004EEA RID: 20202
		// (get) Token: 0x06026A01 RID: 158209 RVA: 0x00AD2491 File Offset: 0x00AD0691
		// (set) Token: 0x06026A02 RID: 158210 RVA: 0x00AD2499 File Offset: 0x00AD0699
		public int Level { get; set; }

		// Token: 0x17004EEB RID: 20203
		// (get) Token: 0x06026A03 RID: 158211 RVA: 0x00AD24A2 File Offset: 0x00AD06A2
		// (set) Token: 0x06026A04 RID: 158212 RVA: 0x00AD24AA File Offset: 0x00AD06AA
		public int BranchId { get; set; }

		// Token: 0x17004EEC RID: 20204
		// (get) Token: 0x06026A05 RID: 158213 RVA: 0x00AD24B3 File Offset: 0x00AD06B3
		// (set) Token: 0x06026A06 RID: 158214 RVA: 0x00AD24BB File Offset: 0x00AD06BB
		public int DefaultCost { get; set; }

		// Token: 0x17004EED RID: 20205
		// (get) Token: 0x06026A07 RID: 158215 RVA: 0x00AD24C4 File Offset: 0x00AD06C4
		// (set) Token: 0x06026A08 RID: 158216 RVA: 0x00AD24CC File Offset: 0x00AD06CC
		public int DeconstructReturn { get; set; }

		// Token: 0x17004EEE RID: 20206
		// (get) Token: 0x06026A09 RID: 158217 RVA: 0x00AD24D5 File Offset: 0x00AD06D5
		// (set) Token: 0x06026A0A RID: 158218 RVA: 0x00AD24DD File Offset: 0x00AD06DD
		public Vector2D GridSize { get; set; } = new Vector2D();

		// Token: 0x17004EEF RID: 20207
		// (get) Token: 0x06026A0B RID: 158219 RVA: 0x00AD24E6 File Offset: 0x00AD06E6
		// (set) Token: 0x06026A0C RID: 158220 RVA: 0x00AD24EE File Offset: 0x00AD06EE
		public ETowerDefenseEventTrapPlacementType PlacementType { get; set; } = ETowerDefenseEventTrapPlacementType.Ground;

		// Token: 0x17004EF0 RID: 20208
		// (get) Token: 0x06026A0D RID: 158221 RVA: 0x00AD24F7 File Offset: 0x00AD06F7
		// (set) Token: 0x06026A0E RID: 158222 RVA: 0x00AD24FF File Offset: 0x00AD06FF
		public bool CanRotate { get; set; } = true;

		// Token: 0x17004EF1 RID: 20209
		// (get) Token: 0x06026A0F RID: 158223 RVA: 0x00AD2508 File Offset: 0x00AD0708
		// (set) Token: 0x06026A10 RID: 158224 RVA: 0x00AD2510 File Offset: 0x00AD0710
		[Nullable(2)]
		public string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004EF2 RID: 20210
		// (get) Token: 0x06026A11 RID: 158225 RVA: 0x00AD2519 File Offset: 0x00AD0719
		// (set) Token: 0x06026A12 RID: 158226 RVA: 0x00AD2521 File Offset: 0x00AD0721
		public Vector2D Coords { get; set; } = new Vector2D();

		// Token: 0x17004EF3 RID: 20211
		// (get) Token: 0x06026A13 RID: 158227 RVA: 0x00AD252A File Offset: 0x00AD072A
		// (set) Token: 0x06026A14 RID: 158228 RVA: 0x00AD2532 File Offset: 0x00AD0732
		public int Degree { get; set; }

		// Token: 0x06026A15 RID: 158229 RVA: 0x00AD253C File Offset: 0x00AD073C
		[return: Nullable(2)]
		public new static ITowerDefenseEventCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			EntityComponentPb entityComponentPb;
			if (!componentDataMap.ContainsKey("SimpleCombatComponentPb") || !componentDataMap.ContainsKey("GridObjectComponentPb") || !componentDataMap.TryGetValue("TrapDefenseComponentPb", out entityComponentPb))
			{
				return null;
			}
			if (entityComponentPb.TrapDefenseComponentPb.BuildingPbData == null)
			{
				return null;
			}
			TowerDefenseEventTrapModel towerDefenseEventTrapModel = TowerDefenseEventTrapModel.TrapPool.Get() ?? TowerDefenseEventTrapModel.TrapPool.Create();
			towerDefenseEventTrapModel.InitFromProto(entityData, componentDataMap);
			return towerDefenseEventTrapModel;
		}

		// Token: 0x06026A16 RID: 158230 RVA: 0x00AD25A3 File Offset: 0x00AD07A3
		public new static void Clear()
		{
			TowerDefenseEventTrapModel.TrapPool.Clear();
		}

		// Token: 0x06026A17 RID: 158231 RVA: 0x00AD25AF File Offset: 0x00AD07AF
		public static TowerDefenseEventTrapModel GetTrapModel(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			TowerDefenseEventTrapModel towerDefenseEventTrapModel = TowerDefenseEventTrapModel.TrapPool.Get() ?? TowerDefenseEventTrapModel.TrapPool.Create();
			towerDefenseEventTrapModel.Update(baseInfo);
			return towerDefenseEventTrapModel;
		}

		// Token: 0x06026A18 RID: 158232 RVA: 0x00AD25D0 File Offset: 0x00AD07D0
		protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			base.InitFromProto(entityData, componentDataMap);
			GridObjectComponentPb gridObjectComponentPb = componentDataMap["GridObjectComponentPb"].GridObjectComponentPb;
			this.GridId = gridObjectComponentPb.InitGridPlacementPbInfo.ActorGuid;
			this.Coords.Set((double)gridObjectComponentPb.InitGridPlacementPbInfo.X, (double)gridObjectComponentPb.InitGridPlacementPbInfo.Y);
			this.Degree = TowerDefenseEventUtility.ConvertDirection2Degree(new GridPbDirection?(gridObjectComponentPb.InitGridPlacementPbInfo.Direction));
			TrapDefenseComponentPb trapDefenseComponentPb = componentDataMap["TrapDefenseComponentPb"].TrapDefenseComponentPb;
			this.ConfigId = trapDefenseComponentPb.BuildingPbData.ConfigId;
			this.TrapId = 0;
			this.Level = trapDefenseComponentPb.BuildingPbData.BattleLevel;
			this.BranchId = 0;
			this.DefaultCost = 0;
			this.DeconstructReturn = trapDefenseComponentPb.BuildingPbData.DeconstructReturn;
			this.GridSize.Set(0.0, 0.0);
			this.PlacementType = ETowerDefenseEventTrapPlacementType.Ground;
			this.CanRotate = true;
		}

		// Token: 0x06026A19 RID: 158233 RVA: 0x00AD26CC File Offset: 0x00AD08CC
		public override void Update(ITowerDefenseEventCombatInfo other)
		{
			base.Update(other);
			ITowerDefenseEventTrapBaseInfo towerDefenseEventTrapBaseInfo = other as ITowerDefenseEventTrapBaseInfo;
			if (towerDefenseEventTrapBaseInfo != null)
			{
				this.ConfigId = towerDefenseEventTrapBaseInfo.ConfigId;
				this.TrapId = towerDefenseEventTrapBaseInfo.TrapId;
				this.Level = towerDefenseEventTrapBaseInfo.Level;
				this.BranchId = towerDefenseEventTrapBaseInfo.BranchId;
				this.DefaultCost = towerDefenseEventTrapBaseInfo.DefaultCost;
				this.GridSize.Set(towerDefenseEventTrapBaseInfo.GridSize.X, towerDefenseEventTrapBaseInfo.GridSize.Y);
				this.PlacementType = towerDefenseEventTrapBaseInfo.PlacementType;
				this.CanRotate = towerDefenseEventTrapBaseInfo.CanRotate;
				this.Degree = towerDefenseEventTrapBaseInfo.Degree;
			}
			else
			{
				this.ConfigId = 0;
				this.TrapId = 0;
				this.Level = 0;
				this.BranchId = 0;
				this.DefaultCost = 0;
				this.GridSize.Set(0.0, 0.0);
				this.PlacementType = ETowerDefenseEventTrapPlacementType.Ground;
				this.CanRotate = true;
				this.Degree = 0;
			}
			ITowerDefenseEventTrapInfo towerDefenseEventTrapInfo = other as ITowerDefenseEventTrapInfo;
			if (towerDefenseEventTrapInfo != null)
			{
				this.GridId = towerDefenseEventTrapInfo.GridId;
				this.Coords.Set(towerDefenseEventTrapInfo.Coords.X, towerDefenseEventTrapInfo.Coords.Y);
				return;
			}
			this.GridId = null;
			this.Coords.Set(0.0, 0.0);
		}

		// Token: 0x06026A1A RID: 158234 RVA: 0x00AD2821 File Offset: 0x00AD0A21
		public void UpdateTransform(FVectorDouble position, FRotator rotation)
		{
			base.Position.Set(position.X, position.Y, position.Z);
			base.Rotation.Set(rotation.Pitch, rotation.Yaw, rotation.Roll);
		}

		// Token: 0x06026A1B RID: 158235 RVA: 0x00AD285D File Offset: 0x00AD0A5D
		public void UpdateData(string gridId, Vector2D coords)
		{
			this.GridId = gridId;
			this.Coords.Set(coords.X, coords.Y);
		}

		// Token: 0x06026A1C RID: 158236 RVA: 0x00AD2880 File Offset: 0x00AD0A80
		public override void Reset()
		{
			base.Reset();
			this.ConfigId = 0;
			this.TrapId = 0;
			this.Level = 0;
			this.BranchId = 0;
			this.DefaultCost = 0;
			this.GridSize.Set(0.0, 0.0);
			this.PlacementType = ETowerDefenseEventTrapPlacementType.Ground;
			this.CanRotate = true;
			this.GridId = null;
			this.Coords.Set(0.0, 0.0);
			this.Degree = 0;
		}

		// Token: 0x06026A1D RID: 158237 RVA: 0x00AD290C File Offset: 0x00AD0B0C
		public override void Release()
		{
			this.Reset();
			TowerDefenseEventTrapModel.TrapPool.Put(this);
		}

		// Token: 0x06026A1E RID: 158238 RVA: 0x00AD2920 File Offset: 0x00AD0B20
		public new ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventTrapModel towerDefenseEventTrapModel = TowerDefenseEventTrapModel.TrapPool.Get() ?? TowerDefenseEventTrapModel.TrapPool.Create();
			towerDefenseEventTrapModel.Update(this);
			return towerDefenseEventTrapModel;
		}

		// Token: 0x04015279 RID: 86649
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventTrapModel> TrapPool = new Pool<TowerDefenseEventTrapModel>(100, () => new TowerDefenseEventTrapModel(), null);
	}
}
