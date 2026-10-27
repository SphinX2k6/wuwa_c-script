using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B13 RID: 19219
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseEventTrapModel : TowerDefenseEventEntityModel, ITowerDefenseEventTrapInfo, ITowerDefenseEventTrapBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B3B RID: 31547
		// (get) Token: 0x06031C6D RID: 203885 RVA: 0x00B8E403 File Offset: 0x00B8C603
		// (set) Token: 0x06031C6E RID: 203886 RVA: 0x00B8E40B File Offset: 0x00B8C60B
		public int ConfigId { get; set; }

		// Token: 0x17007B3C RID: 31548
		// (get) Token: 0x06031C6F RID: 203887 RVA: 0x00B8E414 File Offset: 0x00B8C614
		// (set) Token: 0x06031C70 RID: 203888 RVA: 0x00B8E41C File Offset: 0x00B8C61C
		public int TrapId { get; set; }

		// Token: 0x17007B3D RID: 31549
		// (get) Token: 0x06031C71 RID: 203889 RVA: 0x00B8E425 File Offset: 0x00B8C625
		// (set) Token: 0x06031C72 RID: 203890 RVA: 0x00B8E42D File Offset: 0x00B8C62D
		public int Level { get; set; }

		// Token: 0x17007B3E RID: 31550
		// (get) Token: 0x06031C73 RID: 203891 RVA: 0x00B8E436 File Offset: 0x00B8C636
		// (set) Token: 0x06031C74 RID: 203892 RVA: 0x00B8E43E File Offset: 0x00B8C63E
		public int BranchId { get; set; }

		// Token: 0x17007B3F RID: 31551
		// (get) Token: 0x06031C75 RID: 203893 RVA: 0x00B8E447 File Offset: 0x00B8C647
		// (set) Token: 0x06031C76 RID: 203894 RVA: 0x00B8E44F File Offset: 0x00B8C64F
		public int DefaultCost { get; set; }

		// Token: 0x17007B40 RID: 31552
		// (get) Token: 0x06031C77 RID: 203895 RVA: 0x00B8E458 File Offset: 0x00B8C658
		// (set) Token: 0x06031C78 RID: 203896 RVA: 0x00B8E460 File Offset: 0x00B8C660
		public int DeconstructReturn { get; set; }

		// Token: 0x17007B41 RID: 31553
		// (get) Token: 0x06031C79 RID: 203897 RVA: 0x00B8E469 File Offset: 0x00B8C669
		// (set) Token: 0x06031C7A RID: 203898 RVA: 0x00B8E471 File Offset: 0x00B8C671
		public Vector2D GridSize { get; set; } = new Vector2D();

		// Token: 0x17007B42 RID: 31554
		// (get) Token: 0x06031C7B RID: 203899 RVA: 0x00B8E47A File Offset: 0x00B8C67A
		// (set) Token: 0x06031C7C RID: 203900 RVA: 0x00B8E482 File Offset: 0x00B8C682
		public ETowerDefenseEventTrapPlacementType PlacementType { get; set; } = ETowerDefenseEventTrapPlacementType.Ground;

		// Token: 0x17007B43 RID: 31555
		// (get) Token: 0x06031C7D RID: 203901 RVA: 0x00B8E48B File Offset: 0x00B8C68B
		// (set) Token: 0x06031C7E RID: 203902 RVA: 0x00B8E493 File Offset: 0x00B8C693
		public bool CanRotate { get; set; } = true;

		// Token: 0x17007B44 RID: 31556
		// (get) Token: 0x06031C7F RID: 203903 RVA: 0x00B8E49C File Offset: 0x00B8C69C
		// (set) Token: 0x06031C80 RID: 203904 RVA: 0x00B8E4A4 File Offset: 0x00B8C6A4
		[Nullable(2)]
		public string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B45 RID: 31557
		// (get) Token: 0x06031C81 RID: 203905 RVA: 0x00B8E4AD File Offset: 0x00B8C6AD
		// (set) Token: 0x06031C82 RID: 203906 RVA: 0x00B8E4B5 File Offset: 0x00B8C6B5
		public Vector2D Coords { get; set; } = new Vector2D();

		// Token: 0x17007B46 RID: 31558
		// (get) Token: 0x06031C83 RID: 203907 RVA: 0x00B8E4BE File Offset: 0x00B8C6BE
		// (set) Token: 0x06031C84 RID: 203908 RVA: 0x00B8E4C6 File Offset: 0x00B8C6C6
		public int Degree { get; set; }

		// Token: 0x06031C85 RID: 203909 RVA: 0x00B8E4D0 File Offset: 0x00B8C6D0
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

		// Token: 0x06031C86 RID: 203910 RVA: 0x00B8E537 File Offset: 0x00B8C737
		public new static void Clear()
		{
			TowerDefenseEventTrapModel.TrapPool.Clear();
		}

		// Token: 0x06031C87 RID: 203911 RVA: 0x00B8E543 File Offset: 0x00B8C743
		public static TowerDefenseEventTrapModel GetTrapModel(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			TowerDefenseEventTrapModel towerDefenseEventTrapModel = TowerDefenseEventTrapModel.TrapPool.Get() ?? TowerDefenseEventTrapModel.TrapPool.Create();
			towerDefenseEventTrapModel.Update(baseInfo);
			return towerDefenseEventTrapModel;
		}

		// Token: 0x06031C88 RID: 203912 RVA: 0x00B8E564 File Offset: 0x00B8C764
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

		// Token: 0x06031C89 RID: 203913 RVA: 0x00B8E660 File Offset: 0x00B8C860
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

		// Token: 0x06031C8A RID: 203914 RVA: 0x00B8E7B5 File Offset: 0x00B8C9B5
		public void UpdateTransform(FVectorDouble position, FRotator rotation)
		{
			base.Position.Set(position.X, position.Y, position.Z);
			base.Rotation.Set(rotation.Pitch, rotation.Yaw, rotation.Roll);
		}

		// Token: 0x06031C8B RID: 203915 RVA: 0x00B8E7F1 File Offset: 0x00B8C9F1
		public void UpdateData(string gridId, Vector2D coords)
		{
			this.GridId = gridId;
			this.Coords.Set(coords.X, coords.Y);
		}

		// Token: 0x06031C8C RID: 203916 RVA: 0x00B8E814 File Offset: 0x00B8CA14
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

		// Token: 0x06031C8D RID: 203917 RVA: 0x00B8E8A0 File Offset: 0x00B8CAA0
		public override void Release()
		{
			this.Reset();
			TowerDefenseEventTrapModel.TrapPool.Put(this);
		}

		// Token: 0x06031C8E RID: 203918 RVA: 0x00B8E8B4 File Offset: 0x00B8CAB4
		public new ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventTrapModel towerDefenseEventTrapModel = TowerDefenseEventTrapModel.TrapPool.Get() ?? TowerDefenseEventTrapModel.TrapPool.Create();
			towerDefenseEventTrapModel.Update(this);
			return towerDefenseEventTrapModel;
		}

		// Token: 0x0401A927 RID: 108839
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventTrapModel> TrapPool = new Pool<TowerDefenseEventTrapModel>(100, () => new TowerDefenseEventTrapModel(), null);
	}
}
