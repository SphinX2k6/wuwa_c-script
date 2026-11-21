using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003ABE RID: 15038
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TowerDefenseEventModel : ModelBase
	{
		// Token: 0x06026A3A RID: 158266 RVA: 0x00AD2D60 File Offset: 0x00AD0F60
		public void InitInstance(TrapDefenseActivity? config)
		{
			this.Waves.Clear();
			if (config != null)
			{
				IReadOnlyList<TrapDefenseWave> configList = ConfigTrapDefenseWaveByTrapDefenseLevelId.GetConfigList(config.Value.Id, true);
				if (configList != null && configList.Count > 0)
				{
					foreach (TrapDefenseWave item in configList)
					{
						this.Waves.Add(item);
					}
					this.Waves.Sort((TrapDefenseWave a, TrapDefenseWave b) => a.WaveId - b.WaveId);
				}
			}
		}

		// Token: 0x17004EF9 RID: 20217
		// (get) Token: 0x06026A3B RID: 158267 RVA: 0x00AD2E10 File Offset: 0x00AD1010
		public int CurrentTrapCount
		{
			get
			{
				return this.TrapEntities.Count;
			}
		}

		// Token: 0x06026A3C RID: 158268 RVA: 0x00AD2E20 File Offset: 0x00AD1020
		public bool HasPlaceToBuildTrap()
		{
			long maxTrapCount = TrapDefenseModel.Instance.BattleData.GetMaxTrapCount();
			return (long)this.CurrentTrapCount < maxTrapCount;
		}

		// Token: 0x06026A3D RID: 158269 RVA: 0x00AD2E48 File Offset: 0x00AD1048
		public void GetWaveSplineIds(List<int> splineIds)
		{
			splineIds.Clear();
			int batch = TrapDefenseModel.Instance.BattleData.GetBatch();
			if (batch < 1 || batch > this.Waves.Count)
			{
				return;
			}
			splineIds.AddRange(this.Waves[batch - 1].GetSplineListBytes());
		}

		// Token: 0x06026A3E RID: 158270 RVA: 0x00AD2EA0 File Offset: 0x00AD10A0
		public bool IsEnoughGoldToBuildTrap(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			long goldNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData;
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.InBuildingDataMap.TryGetValue(baseInfo.TrapId, out trapDefenseBuildingDevelopItemData);
			return trapDefenseBuildingDevelopItemData != null && (long)trapDefenseBuildingDevelopItemData.GetBuildingCost(true) <= goldNum;
		}

		// Token: 0x06026A3F RID: 158271 RVA: 0x00AD2EED File Offset: 0x00AD10ED
		public bool ValidateBuildTrap(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			return this.HasPlaceToBuildTrap() && this.IsEnoughGoldToBuildTrap(baseInfo);
		}

		// Token: 0x06026A40 RID: 158272 RVA: 0x00AD2F00 File Offset: 0x00AD1100
		[return: Nullable(2)]
		public string TryAddEntity(ITowerDefenseEventCombatInfo entityModel)
		{
			if (entityModel == null || !entityModel.IsValid())
			{
				return "实体数据无效";
			}
			long uid = entityModel.Uid;
			if (!this.AllEntities.TryAdd(uid, entityModel))
			{
				return "实体数据已存在";
			}
			ITowerDefenseEventTrapInfo towerDefenseEventTrapInfo = entityModel as ITowerDefenseEventTrapInfo;
			if (towerDefenseEventTrapInfo != null)
			{
				this.TrapEntities[uid] = towerDefenseEventTrapInfo;
			}
			return null;
		}

		// Token: 0x06026A41 RID: 158273 RVA: 0x00AD2F54 File Offset: 0x00AD1154
		[NullableContext(2)]
		public ITowerDefenseEventCombatInfo GetEntity(long uid)
		{
			ITowerDefenseEventCombatInfo result;
			this.AllEntities.TryGetValue(uid, out result);
			return result;
		}

		// Token: 0x06026A42 RID: 158274 RVA: 0x00AD2F74 File Offset: 0x00AD1174
		public void GetAllEntities(List<ITowerDefenseEventCombatInfo> entities)
		{
			entities.Clear();
			foreach (ITowerDefenseEventCombatInfo item in this.AllEntities.Values)
			{
				entities.Add(item);
			}
		}

		// Token: 0x06026A43 RID: 158275 RVA: 0x00AD2FD4 File Offset: 0x00AD11D4
		public bool HasAnyTrapByType(int type)
		{
			using (Dictionary<long, ITowerDefenseEventTrapInfo>.ValueCollection.Enumerator enumerator = this.TrapEntities.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.TrapId == type)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06026A44 RID: 158276 RVA: 0x00AD3034 File Offset: 0x00AD1234
		[NullableContext(2)]
		public ITowerDefenseEventCombatInfo RemoveEntity(long uid)
		{
			ITowerDefenseEventCombatInfo towerDefenseEventCombatInfo;
			this.AllEntities.TryGetValue(uid, out towerDefenseEventCombatInfo);
			if (towerDefenseEventCombatInfo != null)
			{
				this.AllEntities.Remove(uid);
				ITowerDefenseEventTrapInfo towerDefenseEventTrapInfo;
				this.TrapEntities.Remove(uid, out towerDefenseEventTrapInfo);
			}
			return towerDefenseEventCombatInfo;
		}

		// Token: 0x06026A45 RID: 158277 RVA: 0x00AD3070 File Offset: 0x00AD1270
		public bool HasEntity(int uid)
		{
			return this.AllEntities.ContainsKey((long)uid);
		}

		// Token: 0x06026A46 RID: 158278 RVA: 0x00AD3080 File Offset: 0x00AD1280
		public int? GetMachineIdByIndex(int index)
		{
			List<TrapDefenseBuildingSlotData> slotData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetSlotData();
			if (index < 0 || index >= slotData.Count)
			{
				return null;
			}
			TrapDefenseBuildingDevelopItemData slotData2 = slotData[index].GetSlotData();
			if (slotData2 == null)
			{
				return null;
			}
			return new int?(slotData2.Id);
		}

		// Token: 0x17004EFA RID: 20218
		// (get) Token: 0x06026A47 RID: 158279 RVA: 0x00AD30D8 File Offset: 0x00AD12D8
		public static TowerDefenseEventModel Instance
		{
			get
			{
				return TowerDefenseEventModel._Instance;
			}
		}

		// Token: 0x06026A48 RID: 158280 RVA: 0x00AD30DF File Offset: 0x00AD12DF
		public static TowerDefenseEventModel GetOrCreateInstance()
		{
			if (TowerDefenseEventModel._Instance == null)
			{
				TowerDefenseEventModel.CreateInstance();
			}
			return TowerDefenseEventModel._Instance;
		}

		// Token: 0x06026A49 RID: 158281 RVA: 0x00AD30F3 File Offset: 0x00AD12F3
		public static bool CreateInstance()
		{
			if (TowerDefenseEventModel._Instance != null)
			{
				return true;
			}
			TowerDefenseEventModel._Instance = new TowerDefenseEventModel();
			return true;
		}

		// Token: 0x06026A4A RID: 158282 RVA: 0x00AD3109 File Offset: 0x00AD1309
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06026A4B RID: 158283 RVA: 0x00AD310B File Offset: 0x00AD130B
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseEventModel._Instance = null;
		}

		// Token: 0x06026A4C RID: 158284 RVA: 0x00AD3113 File Offset: 0x00AD1313
		static TowerDefenseEventModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseEventModel.CreateStaticDefaultValue), new Action(TowerDefenseEventModel.ResetStaticDefaultValue));
		}

		// Token: 0x04015280 RID: 86656
		private readonly List<TrapDefenseWave> Waves = new List<TrapDefenseWave>();

		// Token: 0x04015281 RID: 86657
		private readonly Dictionary<long, ITowerDefenseEventCombatInfo> AllEntities = new Dictionary<long, ITowerDefenseEventCombatInfo>();

		// Token: 0x04015282 RID: 86658
		private readonly Dictionary<long, ITowerDefenseEventTrapInfo> TrapEntities = new Dictionary<long, ITowerDefenseEventTrapInfo>();

		// Token: 0x04015283 RID: 86659
		[Nullable(2)]
		private static TowerDefenseEventModel _Instance;
	}
}
