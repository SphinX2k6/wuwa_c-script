using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B12 RID: 19218
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerDefenseEventMonsterModel : TowerDefenseEventEntityModel, ITowerDefenseEventMonsterInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B35 RID: 31541
		// (get) Token: 0x06031C57 RID: 203863 RVA: 0x00B8E196 File Offset: 0x00B8C396
		// (set) Token: 0x06031C58 RID: 203864 RVA: 0x00B8E19E File Offset: 0x00B8C39E
		public int ConfigId { get; set; }

		// Token: 0x17007B36 RID: 31542
		// (get) Token: 0x06031C59 RID: 203865 RVA: 0x00B8E1A7 File Offset: 0x00B8C3A7
		// (set) Token: 0x06031C5A RID: 203866 RVA: 0x00B8E1AF File Offset: 0x00B8C3AF
		public ETowerDefenseEventMonsterDeathType DeathType { get; set; }

		// Token: 0x17007B37 RID: 31543
		// (get) Token: 0x06031C5B RID: 203867 RVA: 0x00B8E1B8 File Offset: 0x00B8C3B8
		// (set) Token: 0x06031C5C RID: 203868 RVA: 0x00B8E1C0 File Offset: 0x00B8C3C0
		public int BuffRadius { get; set; }

		// Token: 0x17007B38 RID: 31544
		// (get) Token: 0x06031C5D RID: 203869 RVA: 0x00B8E1C9 File Offset: 0x00B8C3C9
		// (set) Token: 0x06031C5E RID: 203870 RVA: 0x00B8E1D1 File Offset: 0x00B8C3D1
		public List<int> BuffIds { get; set; }

		// Token: 0x17007B39 RID: 31545
		// (get) Token: 0x06031C5F RID: 203871 RVA: 0x00B8E1DA File Offset: 0x00B8C3DA
		// (set) Token: 0x06031C60 RID: 203872 RVA: 0x00B8E1E2 File Offset: 0x00B8C3E2
		public List<int> SpawnIds { get; set; }

		// Token: 0x17007B3A RID: 31546
		// (get) Token: 0x06031C61 RID: 203873 RVA: 0x00B8E1EB File Offset: 0x00B8C3EB
		// (set) Token: 0x06031C62 RID: 203874 RVA: 0x00B8E1F3 File Offset: 0x00B8C3F3
		public int PolluteRadius { get; set; }

		// Token: 0x06031C63 RID: 203875 RVA: 0x00B8E1FC File Offset: 0x00B8C3FC
		[NullableContext(1)]
		public static TowerDefenseEventMonsterModel InitFromConfigId(int configId)
		{
			TowerDefenseEventMonsterModel towerDefenseEventMonsterModel = TowerDefenseEventMonsterModel.MonsterPool.Get() ?? TowerDefenseEventMonsterModel.MonsterPool.Create();
			towerDefenseEventMonsterModel.ConfigId = configId;
			return towerDefenseEventMonsterModel;
		}

		// Token: 0x06031C64 RID: 203876 RVA: 0x00B8E220 File Offset: 0x00B8C420
		[NullableContext(1)]
		[return: Nullable(2)]
		public new static ITowerDefenseEventCombatInfo BuildModel(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			EntityComponentPb entityComponentPb;
			if (!componentDataMap.ContainsKey("SimpleCombatComponentPb") || !componentDataMap.TryGetValue("TrapDefenseComponentPb", out entityComponentPb))
			{
				return null;
			}
			if (entityComponentPb.TrapDefenseComponentPb.MonsterPbData == null)
			{
				return null;
			}
			TowerDefenseEventMonsterModel towerDefenseEventMonsterModel = TowerDefenseEventMonsterModel.MonsterPool.Get() ?? TowerDefenseEventMonsterModel.MonsterPool.Create();
			towerDefenseEventMonsterModel.InitFromProto(entityData, componentDataMap);
			return towerDefenseEventMonsterModel;
		}

		// Token: 0x06031C65 RID: 203877 RVA: 0x00B8E27A File Offset: 0x00B8C47A
		public new static void Clear()
		{
			TowerDefenseEventMonsterModel.MonsterPool.Clear();
		}

		// Token: 0x06031C66 RID: 203878 RVA: 0x00B8E288 File Offset: 0x00B8C488
		[NullableContext(1)]
		protected override void InitFromProto(EntityPb entityData, Dictionary<string, EntityComponentPb> componentDataMap)
		{
			base.InitFromProto(entityData, componentDataMap);
			TrapDefenseComponentPb trapDefenseComponentPb = componentDataMap["TrapDefenseComponentPb"].TrapDefenseComponentPb;
			this.ConfigId = trapDefenseComponentPb.MonsterPbData.ConfigId;
			this.DeathType = ETowerDefenseEventMonsterDeathType.Normal;
			this.BuffRadius = 0;
			this.BuffIds = null;
			this.SpawnIds = null;
			this.PolluteRadius = 0;
		}

		// Token: 0x06031C67 RID: 203879 RVA: 0x00B8E2E4 File Offset: 0x00B8C4E4
		[NullableContext(1)]
		public override void Update(ITowerDefenseEventCombatInfo other)
		{
			base.Update(other);
			ITowerDefenseEventMonsterInfo towerDefenseEventMonsterInfo = other as ITowerDefenseEventMonsterInfo;
			if (towerDefenseEventMonsterInfo != null)
			{
				this.ConfigId = towerDefenseEventMonsterInfo.ConfigId;
				this.DeathType = towerDefenseEventMonsterInfo.DeathType;
				this.BuffRadius = towerDefenseEventMonsterInfo.BuffRadius;
				this.BuffIds = towerDefenseEventMonsterInfo.BuffIds;
				this.SpawnIds = towerDefenseEventMonsterInfo.SpawnIds;
				this.PolluteRadius = towerDefenseEventMonsterInfo.PolluteRadius;
				return;
			}
			this.ConfigId = 0;
			this.DeathType = ETowerDefenseEventMonsterDeathType.Normal;
			this.BuffRadius = 0;
			this.BuffIds = null;
			this.SpawnIds = null;
			this.PolluteRadius = 0;
		}

		// Token: 0x06031C68 RID: 203880 RVA: 0x00B8E375 File Offset: 0x00B8C575
		public override void Reset()
		{
			base.Reset();
			this.ConfigId = 0;
			this.DeathType = ETowerDefenseEventMonsterDeathType.Normal;
			this.BuffRadius = 0;
			this.BuffIds = null;
			this.SpawnIds = null;
			this.PolluteRadius = 0;
		}

		// Token: 0x06031C69 RID: 203881 RVA: 0x00B8E3A7 File Offset: 0x00B8C5A7
		public override void Release()
		{
			this.Reset();
			TowerDefenseEventMonsterModel.MonsterPool.Put(this);
		}

		// Token: 0x06031C6A RID: 203882 RVA: 0x00B8E3BB File Offset: 0x00B8C5BB
		[NullableContext(1)]
		public new ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventMonsterModel towerDefenseEventMonsterModel = TowerDefenseEventMonsterModel.MonsterPool.Get() ?? TowerDefenseEventMonsterModel.MonsterPool.Create();
			towerDefenseEventMonsterModel.Update(this);
			return towerDefenseEventMonsterModel;
		}

		// Token: 0x0401A91A RID: 108826
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventMonsterModel> MonsterPool = new Pool<TowerDefenseEventMonsterModel>(100, () => new TowerDefenseEventMonsterModel(), null);
	}
}
