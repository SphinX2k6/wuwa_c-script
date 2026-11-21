using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AB9 RID: 15033
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseEventEntityModel : ITowerDefenseEventCombatInfo, ITowerDefenseEventEntityBaseModel
	{
		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x060269C3 RID: 158147 RVA: 0x00AD1D7B File Offset: 0x00ACFF7B
		// (set) Token: 0x060269C4 RID: 158148 RVA: 0x00AD1D83 File Offset: 0x00ACFF83
		public long Uid { get; set; }

		// Token: 0x17004ED6 RID: 20182
		// (get) Token: 0x060269C5 RID: 158149 RVA: 0x00AD1D8C File Offset: 0x00ACFF8C
		// (set) Token: 0x060269C6 RID: 158150 RVA: 0x00AD1D94 File Offset: 0x00ACFF94
		public long OwnerId { get; set; }

		// Token: 0x17004ED7 RID: 20183
		// (get) Token: 0x060269C7 RID: 158151 RVA: 0x00AD1D9D File Offset: 0x00ACFF9D
		// (set) Token: 0x060269C8 RID: 158152 RVA: 0x00AD1DA5 File Offset: 0x00ACFFA5
		public int TemplateId { get; set; }

		// Token: 0x17004ED8 RID: 20184
		// (get) Token: 0x060269C9 RID: 158153 RVA: 0x00AD1DAE File Offset: 0x00ACFFAE
		// (set) Token: 0x060269CA RID: 158154 RVA: 0x00AD1DB6 File Offset: 0x00ACFFB6
		public int CombatId { get; set; }

		// Token: 0x17004ED9 RID: 20185
		// (get) Token: 0x060269CB RID: 158155 RVA: 0x00AD1DBF File Offset: 0x00ACFFBF
		// (set) Token: 0x060269CC RID: 158156 RVA: 0x00AD1DC7 File Offset: 0x00ACFFC7
		public int SubTypeId { get; set; }

		// Token: 0x17004EDA RID: 20186
		// (get) Token: 0x060269CD RID: 158157 RVA: 0x00AD1DD0 File Offset: 0x00ACFFD0
		// (set) Token: 0x060269CE RID: 158158 RVA: 0x00AD1DD8 File Offset: 0x00ACFFD8
		[Nullable(2)]
		public string PrefabPath { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004EDB RID: 20187
		// (get) Token: 0x060269CF RID: 158159 RVA: 0x00AD1DE1 File Offset: 0x00ACFFE1
		// (set) Token: 0x060269D0 RID: 158160 RVA: 0x00AD1DE9 File Offset: 0x00ACFFE9
		[Nullable(2)]
		public string AssetPath { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004EDC RID: 20188
		// (get) Token: 0x060269D1 RID: 158161 RVA: 0x00AD1DF2 File Offset: 0x00ACFFF2
		// (set) Token: 0x060269D2 RID: 158162 RVA: 0x00AD1DFA File Offset: 0x00ACFFFA
		public int PropertyId { get; set; }

		// Token: 0x17004EDD RID: 20189
		// (get) Token: 0x060269D3 RID: 158163 RVA: 0x00AD1E03 File Offset: 0x00AD0003
		// (set) Token: 0x060269D4 RID: 158164 RVA: 0x00AD1E0B File Offset: 0x00AD000B
		public int? SplineId { get; set; }

		// Token: 0x17004EDE RID: 20190
		// (get) Token: 0x060269D5 RID: 158165 RVA: 0x00AD1E14 File Offset: 0x00AD0014
		// (set) Token: 0x060269D6 RID: 158166 RVA: 0x00AD1E1C File Offset: 0x00AD001C
		[Nullable(2)]
		public Dictionary<int, int> BuffIdLayers { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004EDF RID: 20191
		// (get) Token: 0x060269D7 RID: 158167 RVA: 0x00AD1E25 File Offset: 0x00AD0025
		// (set) Token: 0x060269D8 RID: 158168 RVA: 0x00AD1E2D File Offset: 0x00AD002D
		public global::Vector Position { get; set; } = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x17004EE0 RID: 20192
		// (get) Token: 0x060269D9 RID: 158169 RVA: 0x00AD1E36 File Offset: 0x00AD0036
		// (set) Token: 0x060269DA RID: 158170 RVA: 0x00AD1E3E File Offset: 0x00AD003E
		public global::Rotator Rotation { get; set; } = global::Rotator.Create(0f, 0f, 0f);

		// Token: 0x17004EE1 RID: 20193
		// (get) Token: 0x060269DB RID: 158171 RVA: 0x00AD1E47 File Offset: 0x00AD0047
		// (set) Token: 0x060269DC RID: 158172 RVA: 0x00AD1E4F File Offset: 0x00AD004F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<ETowerDefenseEventCombatExtraInfoType, CombatExtraInfoBase> ExtraInfo { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x060269DD RID: 158173 RVA: 0x00AD1E58 File Offset: 0x00AD0058
		[return: Nullable(2)]
		public static ITowerDefenseEventCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			if (!componentDataMap.ContainsKey("SimpleCombatComponentPb"))
			{
				return null;
			}
			TowerDefenseEventEntityModel towerDefenseEventEntityModel = TowerDefenseEventEntityModel.EntityPool.Get() ?? TowerDefenseEventEntityModel.EntityPool.Create();
			towerDefenseEventEntityModel.InitFromProto(entityData, componentDataMap);
			return towerDefenseEventEntityModel;
		}

		// Token: 0x060269DE RID: 158174 RVA: 0x00AD1E89 File Offset: 0x00AD0089
		public static void Clear()
		{
			TowerDefenseEventEntityModel.EntityPool.Clear();
		}

		// Token: 0x060269DF RID: 158175 RVA: 0x00AD1E98 File Offset: 0x00AD0098
		protected virtual void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			SimpleCombatComponentPb simpleCombatComponentPb = componentDataMap["SimpleCombatComponentPb"].SimpleCombatComponentPb;
			this.Uid = entityData.Id;
			this.OwnerId = entityData.OwnerIncId;
			this.TemplateId = entityData.ConfigId;
			this.CombatId = 0;
			this.SubTypeId = simpleCombatComponentPb.SubTypeId;
			this.PrefabPath = null;
			this.AssetPath = null;
			this.PropertyId = 0;
			this.BuffIdLayers = new Dictionary<int, int>();
			foreach (KeyValuePair<int, int> keyValuePair in simpleCombatComponentPb.BuffLayers)
			{
				this.BuffIdLayers[keyValuePair.Key] = keyValuePair.Value;
			}
			if (simpleCombatComponentPb.SplineMoveType != null)
			{
				this.SplineId = new int?(simpleCombatComponentPb.SplineMoveType.ConfigId);
			}
			Aki.Protocol.Vector pos = entityData.Pos;
			if (pos != null)
			{
				this.Position.Set((double)pos.X, (double)pos.Y, (double)pos.Z);
			}
			Aki.Protocol.Rotator rot = entityData.Rot;
			if (rot != null)
			{
				this.Rotation.Set(rot.Pitch, rot.Yaw, rot.Roll);
			}
		}

		// Token: 0x060269E0 RID: 158176 RVA: 0x00AD1FD0 File Offset: 0x00AD01D0
		public virtual void Update(ITowerDefenseEventCombatInfo other)
		{
			this.Uid = other.Uid;
			this.OwnerId = other.OwnerId;
			this.TemplateId = other.TemplateId;
			this.CombatId = other.CombatId;
			this.SubTypeId = other.SubTypeId;
			this.PrefabPath = other.PrefabPath;
			this.AssetPath = other.AssetPath;
			this.PropertyId = other.PropertyId;
			this.SplineId = other.SplineId;
			this.BuffIdLayers = other.BuffIdLayers;
			this.Position.Set(other.Position.X, other.Position.Y, other.Position.Z);
			this.Rotation.Set(other.Rotation.Pitch, other.Rotation.Yaw, other.Rotation.Roll);
		}

		// Token: 0x060269E1 RID: 158177 RVA: 0x00AD20AD File Offset: 0x00AD02AD
		public virtual bool IsValid()
		{
			return this.Uid > 0L;
		}

		// Token: 0x060269E2 RID: 158178 RVA: 0x00AD20BC File Offset: 0x00AD02BC
		public virtual void Reset()
		{
			this.Uid = 0L;
			this.OwnerId = 0L;
			this.TemplateId = 0;
			this.CombatId = 0;
			this.SubTypeId = 0;
			this.PrefabPath = null;
			this.AssetPath = null;
			this.PropertyId = 0;
			this.SplineId = null;
			this.BuffIdLayers = null;
			this.Position.Set(0.0, 0.0, 0.0);
			this.Rotation.Set(0f, 0f, 0f);
		}

		// Token: 0x060269E3 RID: 158179 RVA: 0x00AD2159 File Offset: 0x00AD0359
		public virtual void Release()
		{
			this.Reset();
			TowerDefenseEventEntityModel.EntityPool.Put(this);
		}

		// Token: 0x060269E4 RID: 158180 RVA: 0x00AD216D File Offset: 0x00AD036D
		public ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventEntityModel towerDefenseEventEntityModel = TowerDefenseEventEntityModel.EntityPool.Get() ?? TowerDefenseEventEntityModel.EntityPool.Create();
			towerDefenseEventEntityModel.Update(this);
			return towerDefenseEventEntityModel;
		}

		// Token: 0x04015257 RID: 86615
		public const int ENTITY_POOL_SIZE = 100;

		// Token: 0x04015265 RID: 86629
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventEntityModel> EntityPool = new Pool<TowerDefenseEventEntityModel>(100, () => new TowerDefenseEventEntityModel(), null);
	}
}
