using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.TrapDefense;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B16 RID: 19222
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class TowerDefenseEventModel : ModelBase
	{
		// Token: 0x06031CAA RID: 203946 RVA: 0x00B8ECF4 File Offset: 0x00B8CEF4
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

		// Token: 0x17007B4C RID: 31564
		// (get) Token: 0x06031CAB RID: 203947 RVA: 0x00B8EDA4 File Offset: 0x00B8CFA4
		public int CurrentTrapCount
		{
			get
			{
				return this.TrapEntities.Count;
			}
		}

		// Token: 0x06031CAC RID: 203948 RVA: 0x00B8EDB4 File Offset: 0x00B8CFB4
		public bool HasPlaceToBuildTrap()
		{
			long maxTrapCount = TrapDefenseModel.Instance.BattleData.GetMaxTrapCount();
			return (long)this.CurrentTrapCount < maxTrapCount;
		}

		// Token: 0x06031CAD RID: 203949 RVA: 0x00B8EDDC File Offset: 0x00B8CFDC
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

		// Token: 0x06031CAE RID: 203950 RVA: 0x00B8EE34 File Offset: 0x00B8D034
		public bool IsEnoughGoldToBuildTrap(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			long goldNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData;
			TrapDefenseModel.Instance.ViewModelBuildingDevelop.InBuildingDataMap.TryGetValue(baseInfo.TrapId, out trapDefenseBuildingDevelopItemData);
			return trapDefenseBuildingDevelopItemData != null && (long)trapDefenseBuildingDevelopItemData.GetBuildingCost(true) <= goldNum;
		}

		// Token: 0x06031CAF RID: 203951 RVA: 0x00B8EE81 File Offset: 0x00B8D081
		public bool ValidateBuildTrap(ITowerDefenseEventTrapBaseInfo baseInfo)
		{
			return this.HasPlaceToBuildTrap() && this.IsEnoughGoldToBuildTrap(baseInfo);
		}

		// Token: 0x06031CB0 RID: 203952 RVA: 0x00B8EE94 File Offset: 0x00B8D094
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

		// Token: 0x06031CB1 RID: 203953 RVA: 0x00B8EEE8 File Offset: 0x00B8D0E8
		[NullableContext(2)]
		public ITowerDefenseEventCombatInfo GetEntity(long uid)
		{
			ITowerDefenseEventCombatInfo result;
			this.AllEntities.TryGetValue(uid, out result);
			return result;
		}

		// Token: 0x06031CB2 RID: 203954 RVA: 0x00B8EF08 File Offset: 0x00B8D108
		public void GetAllEntities(List<ITowerDefenseEventCombatInfo> entities)
		{
			entities.Clear();
			foreach (ITowerDefenseEventCombatInfo item in this.AllEntities.Values)
			{
				entities.Add(item);
			}
		}

		// Token: 0x06031CB3 RID: 203955 RVA: 0x00B8EF68 File Offset: 0x00B8D168
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

		// Token: 0x06031CB4 RID: 203956 RVA: 0x00B8EFC8 File Offset: 0x00B8D1C8
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

		// Token: 0x06031CB5 RID: 203957 RVA: 0x00B8F004 File Offset: 0x00B8D204
		public bool HasEntity(int uid)
		{
			return this.AllEntities.ContainsKey((long)uid);
		}

		// Token: 0x06031CB6 RID: 203958 RVA: 0x00B8F014 File Offset: 0x00B8D214
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

		// Token: 0x17007B4D RID: 31565
		// (get) Token: 0x06031CB7 RID: 203959 RVA: 0x00B8F06C File Offset: 0x00B8D26C
		public static TowerDefenseEventModel Instance
		{
			get
			{
				return TowerDefenseEventModel._Instance;
			}
		}

		// Token: 0x06031CB8 RID: 203960 RVA: 0x00B8F073 File Offset: 0x00B8D273
		public static TowerDefenseEventModel GetOrCreateInstance()
		{
			if (TowerDefenseEventModel._Instance == null)
			{
				TowerDefenseEventModel.CreateInstance();
			}
			return TowerDefenseEventModel._Instance;
		}

		// Token: 0x06031CB9 RID: 203961 RVA: 0x00B8F087 File Offset: 0x00B8D287
		public static bool CreateInstance()
		{
			if (TowerDefenseEventModel._Instance != null)
			{
				return true;
			}
			TowerDefenseEventModel._Instance = new TowerDefenseEventModel();
			return true;
		}

		// Token: 0x06031CBA RID: 203962 RVA: 0x00B8F09D File Offset: 0x00B8D29D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06031CBB RID: 203963 RVA: 0x00B8F09F File Offset: 0x00B8D29F
		public static void ResetStaticDefaultValue()
		{
			TowerDefenseEventModel._Instance = null;
		}

		// Token: 0x06031CBC RID: 203964 RVA: 0x00B8F0A7 File Offset: 0x00B8D2A7
		static TowerDefenseEventModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TowerDefenseEventModel.CreateStaticDefaultValue), new Action(TowerDefenseEventModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401A92E RID: 108846
		private readonly List<TrapDefenseWave> Waves = new List<TrapDefenseWave>();

		// Token: 0x0401A92F RID: 108847
		private readonly Dictionary<long, ITowerDefenseEventCombatInfo> AllEntities = new Dictionary<long, ITowerDefenseEventCombatInfo>();

		// Token: 0x0401A930 RID: 108848
		private readonly Dictionary<long, ITowerDefenseEventTrapInfo> TrapEntities = new Dictionary<long, ITowerDefenseEventTrapInfo>();

		// Token: 0x0401A931 RID: 108849
		[Nullable(2)]
		private static TowerDefenseEventModel _Instance;
	}
}
