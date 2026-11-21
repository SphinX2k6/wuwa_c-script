using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003ABA RID: 15034
	[NullableContext(2)]
	[Nullable(0)]
	public class TowerDefenseEventMonsterModel : TowerDefenseEventEntityModel, ITowerDefenseEventMonsterInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004EE2 RID: 20194
		// (get) Token: 0x060269E7 RID: 158183 RVA: 0x00AD2202 File Offset: 0x00AD0402
		// (set) Token: 0x060269E8 RID: 158184 RVA: 0x00AD220A File Offset: 0x00AD040A
		public int ConfigId { get; set; }

		// Token: 0x17004EE3 RID: 20195
		// (get) Token: 0x060269E9 RID: 158185 RVA: 0x00AD2213 File Offset: 0x00AD0413
		// (set) Token: 0x060269EA RID: 158186 RVA: 0x00AD221B File Offset: 0x00AD041B
		public ETowerDefenseEventMonsterDeathType DeathType { get; set; }

		// Token: 0x17004EE4 RID: 20196
		// (get) Token: 0x060269EB RID: 158187 RVA: 0x00AD2224 File Offset: 0x00AD0424
		// (set) Token: 0x060269EC RID: 158188 RVA: 0x00AD222C File Offset: 0x00AD042C
		public int BuffRadius { get; set; }

		// Token: 0x17004EE5 RID: 20197
		// (get) Token: 0x060269ED RID: 158189 RVA: 0x00AD2235 File Offset: 0x00AD0435
		// (set) Token: 0x060269EE RID: 158190 RVA: 0x00AD223D File Offset: 0x00AD043D
		public List<int> BuffIds { get; set; }

		// Token: 0x17004EE6 RID: 20198
		// (get) Token: 0x060269EF RID: 158191 RVA: 0x00AD2246 File Offset: 0x00AD0446
		// (set) Token: 0x060269F0 RID: 158192 RVA: 0x00AD224E File Offset: 0x00AD044E
		public List<int> SpawnIds { get; set; }

		// Token: 0x17004EE7 RID: 20199
		// (get) Token: 0x060269F1 RID: 158193 RVA: 0x00AD2257 File Offset: 0x00AD0457
		// (set) Token: 0x060269F2 RID: 158194 RVA: 0x00AD225F File Offset: 0x00AD045F
		public int PolluteRadius { get; set; }

		// Token: 0x060269F3 RID: 158195 RVA: 0x00AD2268 File Offset: 0x00AD0468
		[NullableContext(1)]
		public static TowerDefenseEventMonsterModel InitFromConfigId(int configId)
		{
			TowerDefenseEventMonsterModel towerDefenseEventMonsterModel = TowerDefenseEventMonsterModel.MonsterPool.Get() ?? TowerDefenseEventMonsterModel.MonsterPool.Create();
			towerDefenseEventMonsterModel.ConfigId = configId;
			return towerDefenseEventMonsterModel;
		}

		// Token: 0x060269F4 RID: 158196 RVA: 0x00AD228C File Offset: 0x00AD048C
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

		// Token: 0x060269F5 RID: 158197 RVA: 0x00AD22E6 File Offset: 0x00AD04E6
		public new static void Clear()
		{
			TowerDefenseEventMonsterModel.MonsterPool.Clear();
		}

		// Token: 0x060269F6 RID: 158198 RVA: 0x00AD22F4 File Offset: 0x00AD04F4
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

		// Token: 0x060269F7 RID: 158199 RVA: 0x00AD2350 File Offset: 0x00AD0550
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

		// Token: 0x060269F8 RID: 158200 RVA: 0x00AD23E1 File Offset: 0x00AD05E1
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

		// Token: 0x060269F9 RID: 158201 RVA: 0x00AD2413 File Offset: 0x00AD0613
		public override void Release()
		{
			this.Reset();
			TowerDefenseEventMonsterModel.MonsterPool.Put(this);
		}

		// Token: 0x060269FA RID: 158202 RVA: 0x00AD2427 File Offset: 0x00AD0627
		[NullableContext(1)]
		public new ITowerDefenseEventCombatInfo Clone()
		{
			TowerDefenseEventMonsterModel towerDefenseEventMonsterModel = TowerDefenseEventMonsterModel.MonsterPool.Get() ?? TowerDefenseEventMonsterModel.MonsterPool.Create();
			towerDefenseEventMonsterModel.Update(this);
			return towerDefenseEventMonsterModel;
		}

		// Token: 0x0401526C RID: 86636
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Pool<TowerDefenseEventMonsterModel> MonsterPool = new Pool<TowerDefenseEventMonsterModel>(100, () => new TowerDefenseEventMonsterModel(), null);
	}
}
