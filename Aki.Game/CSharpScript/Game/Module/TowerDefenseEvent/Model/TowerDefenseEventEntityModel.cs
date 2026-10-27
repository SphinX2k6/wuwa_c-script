using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B11 RID: 19217
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseEventEntityModel : ITowerDefenseEventCombatInfo, ITowerDefenseEventEntityBaseModel
	{
		// Token: 0x17007B28 RID: 31528
		// (get) Token: 0x06031C33 RID: 203827 RVA: 0x00B8DD0F File Offset: 0x00B8BF0F
		// (set) Token: 0x06031C34 RID: 203828 RVA: 0x00B8DD17 File Offset: 0x00B8BF17
		public long Uid { get; set; }

		// Token: 0x17007B29 RID: 31529
		// (get) Token: 0x06031C35 RID: 203829 RVA: 0x00B8DD20 File Offset: 0x00B8BF20
		// (set) Token: 0x06031C36 RID: 203830 RVA: 0x00B8DD28 File Offset: 0x00B8BF28
		public long OwnerId { get; set; }

		// Token: 0x17007B2A RID: 31530
		// (get) Token: 0x06031C37 RID: 203831 RVA: 0x00B8DD31 File Offset: 0x00B8BF31
		// (set) Token: 0x06031C38 RID: 203832 RVA: 0x00B8DD39 File Offset: 0x00B8BF39
		public int TemplateId { get; set; }

		// Token: 0x17007B2B RID: 31531
		// (get) Token: 0x06031C39 RID: 203833 RVA: 0x00B8DD42 File Offset: 0x00B8BF42
		// (set) Token: 0x06031C3A RID: 203834 RVA: 0x00B8DD4A File Offset: 0x00B8BF4A
		public int CombatId { get; set; }

		// Token: 0x17007B2C RID: 31532
		// (get) Token: 0x06031C3B RID: 203835 RVA: 0x00B8DD53 File Offset: 0x00B8BF53
		// (set) Token: 0x06031C3C RID: 203836 RVA: 0x00B8DD5B File Offset: 0x00B8BF5B
		public int SubTypeId { get; set; }

		// Token: 0x17007B2D RID: 31533
		// (get) Token: 0x06031C3D RID: 203837 RVA: 0x00B8DD64 File Offset: 0x00B8BF64
		// (set) Token: 0x06031C3E RID: 203838 RVA: 0x00B8DD6C File Offset: 0x00B8BF6C
		[Nullable(2)]
		public string PrefabPath { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B2E RID: 31534
		// (get) Token: 0x06031C3F RID: 203839 RVA: 0x00B8DD75 File Offset: 0x00B8BF75
		// (set) Token: 0x06031C40 RID: 203840 RVA: 0x00B8DD7D File Offset: 0x00B8BF7D
		[Nullable(2)]
		public string AssetPath { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B2F RID: 31535
		// (get) Token: 0x06031C41 RID: 203841 RVA: 0x00B8DD86 File Offset: 0x00B8BF86
		// (set) Token: 0x06031C42 RID: 203842 RVA: 0x00B8DD8E File Offset: 0x00B8BF8E
		public int PropertyId { get; set; }

		// Token: 0x17007B30 RID: 31536
		// (get) Token: 0x06031C43 RID: 203843 RVA: 0x00B8DD97 File Offset: 0x00B8BF97
		// (set) Token: 0x06031C44 RID: 203844 RVA: 0x00B8DD9F File Offset: 0x00B8BF9F
		public int? SplineId { get; set; }

		// Token: 0x17007B31 RID: 31537
		// (get) Token: 0x06031C45 RID: 203845 RVA: 0x00B8DDA8 File Offset: 0x00B8BFA8
		// (set) Token: 0x06031C46 RID: 203846 RVA: 0x00B8DDB0 File Offset: 0x00B8BFB0
		[Nullable(2)]
		public Dictionary<int, int> BuffIdLayers { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B32 RID: 31538
		// (get) Token: 0x06031C47 RID: 203847 RVA: 0x00B8DDB9 File Offset: 0x00B8BFB9
		// (set) Token: 0x06031C48 RID: 203848 RVA: 0x00B8DDC1 File Offset: 0x00B8BFC1
		public global::Vector Position { get; set; } = global::Vector.Create(0.0, 0.0, 0.0);

		// Token: 0x17007B33 RID: 31539
		// (get) Token: 0x06031C49 RID: 203849 RVA: 0x00B8DDCA File Offset: 0x00B8BFCA
		// (set) Token: 0x06031C4A RID: 203850 RVA: 0x00B8DDD2 File Offset: 0x00B8BFD2
		public global::Rotator Rotation { get; set; } = global::Rotator.Create(0f, 0f, 0f);

		// Token: 0x17007B34 RID: 31540
		// (get) Token: 0x06031C4B RID: 203851 RVA: 0x00B8DDDB File Offset: 0x00B8BFDB
		// (set) Token: 0x06031C4C RID: 203852 RVA: 0x00B8DDE3 File Offset: 0x00B8BFE3
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

		// Token: 0x06031C4D RID: 203853 RVA: 0x00B8DDEC File Offset: 0x00B8BFEC
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

		// Token: 0x06031C4E RID: 203854 RVA: 0x00B8DE1D File Offset: 0x00B8C01D
		public static void Clear()
		{
			TowerDefenseEventEntityModel.EntityPool.Clear();
		}

		// Token: 0x06031C4F RID: 203855 RVA: 0x00B8DE2C File Offset: 0x00B8C02C
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

		// Token: 0x06031C50 RID: 203856 RVA: 0x00B8DF64 File Offset: 0x00B8C164
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

		// Token: 0x06031C51 RID: 203857 RVA: 0x00B8E041 File Offset: 0x00B8C241
		public virtual bool IsValid()
		{
			return this.Uid > 0L;
		}

		// Token: 0x06031C52 RID: 203858 RVA: 0x00B8E050 File Offset: 0x00B8C250
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

		// Token: 0x06031C53 RID: 203859 RVA: 0x00B8E0ED File Offset: 0x00B8C2ED
		public virtual void Release()
		{
			this.Reset();
			TowerDefenseEventEntityModel.EntityPool.Put(this);
		}

		// Token: 0x06031C54 RID: 203860 RVA: 0x00B8E101 File Offset: 0x00B8C301
		public ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventEntityModel towerDefenseEventEntityModel = TowerDefenseEventEntityModel.EntityPool.Get() ?? TowerDefenseEventEntityModel.EntityPool.Create();
			towerDefenseEventEntityModel.Update(this);
			return towerDefenseEventEntityModel;
		}

		// Token: 0x0401A905 RID: 108805
		public const int ENTITY_POOL_SIZE = 100;

		// Token: 0x0401A913 RID: 108819
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventEntityModel> EntityPool = new Pool<TowerDefenseEventEntityModel>(100, () => new TowerDefenseEventEntityModel(), null);
	}
}
