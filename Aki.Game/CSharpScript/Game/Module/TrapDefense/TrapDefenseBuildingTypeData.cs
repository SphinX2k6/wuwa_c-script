using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A26 RID: 18982
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingTypeData
	{
		// Token: 0x06031471 RID: 201841 RVA: 0x00B6D7B0 File Offset: 0x00B6B9B0
		public static TrapDefenseBuildingTypeData Create(ETrapDefenseMachineType type, bool isInDungeon, List<TrapDefenseBuildingDevelopItemData> haveList, ETrapDefensePlacementType? placementType = null)
		{
			TrapDefenseBuildingTypeData trapDefenseBuildingTypeData = new TrapDefenseBuildingTypeData(type, isInDungeon, placementType);
			if (!trapDefenseBuildingTypeData.Init(haveList))
			{
				return null;
			}
			return trapDefenseBuildingTypeData;
		}

		// Token: 0x06031472 RID: 201842 RVA: 0x00B6D7D2 File Offset: 0x00B6B9D2
		private TrapDefenseBuildingTypeData(ETrapDefenseMachineType type, bool isInDungeon, ETrapDefensePlacementType? placementType = null)
		{
			this.Type = type;
			this.PlacementType = placementType.GetValueOrDefault();
			this.IsInDungeon = isInDungeon;
		}

		// Token: 0x06031473 RID: 201843 RVA: 0x00B6D80C File Offset: 0x00B6BA0C
		public string GetTitleId()
		{
			if (this.Type == ETrapDefenseMachineType.Auxiliary)
			{
				if (!this.IsInDungeon)
				{
					return "TowerDefense_Building_AuxiliaryType_Text";
				}
				return "TowerDefense_Building_AuxiliaryTypeDungeon_Text";
			}
			else
			{
				if (this.PlacementType == ETrapDefensePlacementType.Floor)
				{
					return "TowerDefense_Building_FloorBuildingType_Text";
				}
				if (this.PlacementType == ETrapDefensePlacementType.Wall)
				{
					return "TowerDefense_Building_WallBuildingType_Text";
				}
				return "TowerDefense_Building_TopBuildingType_Text";
			}
		}

		// Token: 0x06031474 RID: 201844 RVA: 0x00B6D859 File Offset: 0x00B6BA59
		private bool Init(List<TrapDefenseBuildingDevelopItemData> haveList)
		{
			if (!this.IsInDungeon)
			{
				return this.InitNotInDungeon(haveList);
			}
			return this.InitInDungeon();
		}

		// Token: 0x06031475 RID: 201845 RVA: 0x00B6D874 File Offset: 0x00B6BA74
		private bool InitNotInDungeon(List<TrapDefenseBuildingDevelopItemData> haveList)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData in haveList)
			{
				hashSet.Add(trapDefenseBuildingDevelopItemData.GetDataType());
				this.DataList.Add(trapDefenseBuildingDevelopItemData);
				this.DataMap[trapDefenseBuildingDevelopItemData.GetDataType()] = trapDefenseBuildingDevelopItemData;
			}
			if (this.Type == ETrapDefenseMachineType.Auxiliary)
			{
				using (IEnumerator<TrapDefenseAuxiliaryType> enumerator2 = TrapDefenseConfig.Instance.GetAllAuxiliaryTypeList().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						TrapDefenseAuxiliaryType trapDefenseAuxiliaryType = enumerator2.Current;
						if (!hashSet.Contains(trapDefenseAuxiliaryType.Id))
						{
							ITrapDefenseMachineIdInfo info = new ITrapDefenseMachineIdInfo
							{
								MachineType = this.Type,
								DataType = trapDefenseAuxiliaryType.Id,
								Level = 1,
								Branch = 0
							};
							TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData2 = TrapDefenseBuildingDevelopItemData.Create(TrapDefenseModel.Instance.ComposeMachineId(info), this.Type);
							trapDefenseBuildingDevelopItemData2.SetIsUnLock(false);
							this.DataList.Add(trapDefenseBuildingDevelopItemData2);
							this.DataMap[trapDefenseAuxiliaryType.Id] = trapDefenseBuildingDevelopItemData2;
						}
					}
					goto IL_1F1;
				}
			}
			foreach (TrapDefenseBuildingType trapDefenseBuildingType in TrapDefenseConfig.Instance.GetAllBuildingTypeList())
			{
				if (this.Type == ETrapDefenseMachineType.Building)
				{
					TrapDefenseBuildingType trapDefenseBuildingType2 = trapDefenseBuildingType;
					if (this.PlacementType != (ETrapDefensePlacementType)trapDefenseBuildingType2.PlacementType)
					{
						continue;
					}
				}
				if (!hashSet.Contains(trapDefenseBuildingType.Id))
				{
					ITrapDefenseMachineIdInfo info2 = new ITrapDefenseMachineIdInfo
					{
						MachineType = this.Type,
						DataType = trapDefenseBuildingType.Id,
						Level = 1,
						Branch = 0
					};
					TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData3 = TrapDefenseBuildingDevelopItemData.Create(TrapDefenseModel.Instance.ComposeMachineId(info2), this.Type);
					trapDefenseBuildingDevelopItemData3.SetIsUnLock(false);
					this.DataList.Add(trapDefenseBuildingDevelopItemData3);
					this.DataMap[trapDefenseBuildingType.Id] = trapDefenseBuildingDevelopItemData3;
				}
			}
			IL_1F1:
			this.SortList();
			return this.DataList.Count > 0;
		}

		// Token: 0x06031476 RID: 201846 RVA: 0x00B6DAB0 File Offset: 0x00B6BCB0
		private bool InitInDungeon()
		{
			this.DataList = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetInBattleDataByType(this.PlacementType);
			return this.DataList.Count > 0;
		}

		// Token: 0x06031477 RID: 201847 RVA: 0x00B6DADB File Offset: 0x00B6BCDB
		public List<TrapDefenseBuildingDevelopItemData> GetDataList()
		{
			return this.DataList;
		}

		// Token: 0x06031478 RID: 201848 RVA: 0x00B6DAE3 File Offset: 0x00B6BCE3
		public Dictionary<int, TrapDefenseBuildingDevelopItemData> GetDataMap()
		{
			return this.DataMap;
		}

		// Token: 0x06031479 RID: 201849 RVA: 0x00B6DAEC File Offset: 0x00B6BCEC
		public void UpdateItemData(int id, bool needEmit = true)
		{
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(id);
			if (!this.DataMap.ContainsKey(trapDefenseMachineIdInfo.DataType))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.TowerDefense;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "机关养成更新无效";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ID", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			TrapDefenseBuildingDevelopItemData p = this.DataMap[trapDefenseMachineIdInfo.DataType];
			if (needEmit)
			{
				EventSystem.Instance.Emit<TrapDefenseBuildingDevelopItemData>(EEventName.TrapDefenseOnDevelopUpdate, p);
			}
		}

		// Token: 0x0603147A RID: 201850 RVA: 0x00B6DB6E File Offset: 0x00B6BD6E
		protected void SortList()
		{
			this.DataList.Sort((TrapDefenseBuildingDevelopItemData a, TrapDefenseBuildingDevelopItemData b) => a.GetSortId() - b.GetSortId());
		}

		// Token: 0x0401A579 RID: 107897
		public bool IsInDungeon;

		// Token: 0x0401A57A RID: 107898
		public ETrapDefenseMachineType Type;

		// Token: 0x0401A57B RID: 107899
		public ETrapDefensePlacementType PlacementType;

		// Token: 0x0401A57C RID: 107900
		protected List<TrapDefenseBuildingDevelopItemData> DataList = new List<TrapDefenseBuildingDevelopItemData>();

		// Token: 0x0401A57D RID: 107901
		protected Dictionary<int, TrapDefenseBuildingDevelopItemData> DataMap = new Dictionary<int, TrapDefenseBuildingDevelopItemData>();

		// Token: 0x0401A57E RID: 107902
		[Nullable(2)]
		public TrapDefenseBuildingDevelopItemData CurSelectedData;

		// Token: 0x0401A57F RID: 107903
		[Nullable(2)]
		public TrapDefenseBuildingDevelopItemData TempSelectedData;
	}
}
