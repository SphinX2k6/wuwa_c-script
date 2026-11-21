using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039CE RID: 14798
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingTypeData
	{
		// Token: 0x06026201 RID: 156161 RVA: 0x00AB17AC File Offset: 0x00AAF9AC
		public static TrapDefenseBuildingTypeData Create(ETrapDefenseMachineType type, bool isInDungeon, List<TrapDefenseBuildingDevelopItemData> haveList, ETrapDefensePlacementType? placementType = null)
		{
			TrapDefenseBuildingTypeData trapDefenseBuildingTypeData = new TrapDefenseBuildingTypeData(type, isInDungeon, placementType);
			if (!trapDefenseBuildingTypeData.Init(haveList))
			{
				return null;
			}
			return trapDefenseBuildingTypeData;
		}

		// Token: 0x06026202 RID: 156162 RVA: 0x00AB17CE File Offset: 0x00AAF9CE
		private TrapDefenseBuildingTypeData(ETrapDefenseMachineType type, bool isInDungeon, ETrapDefensePlacementType? placementType = null)
		{
			this.Type = type;
			this.PlacementType = placementType.GetValueOrDefault();
			this.IsInDungeon = isInDungeon;
		}

		// Token: 0x06026203 RID: 156163 RVA: 0x00AB1808 File Offset: 0x00AAFA08
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

		// Token: 0x06026204 RID: 156164 RVA: 0x00AB1855 File Offset: 0x00AAFA55
		private bool Init(List<TrapDefenseBuildingDevelopItemData> haveList)
		{
			if (!this.IsInDungeon)
			{
				return this.InitNotInDungeon(haveList);
			}
			return this.InitInDungeon();
		}

		// Token: 0x06026205 RID: 156165 RVA: 0x00AB1870 File Offset: 0x00AAFA70
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

		// Token: 0x06026206 RID: 156166 RVA: 0x00AB1AAC File Offset: 0x00AAFCAC
		private bool InitInDungeon()
		{
			this.DataList = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetInBattleDataByType(this.PlacementType);
			return this.DataList.Count > 0;
		}

		// Token: 0x06026207 RID: 156167 RVA: 0x00AB1AD7 File Offset: 0x00AAFCD7
		public List<TrapDefenseBuildingDevelopItemData> GetDataList()
		{
			return this.DataList;
		}

		// Token: 0x06026208 RID: 156168 RVA: 0x00AB1ADF File Offset: 0x00AAFCDF
		public Dictionary<int, TrapDefenseBuildingDevelopItemData> GetDataMap()
		{
			return this.DataMap;
		}

		// Token: 0x06026209 RID: 156169 RVA: 0x00AB1AE8 File Offset: 0x00AAFCE8
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

		// Token: 0x0602620A RID: 156170 RVA: 0x00AB1B6A File Offset: 0x00AAFD6A
		protected void SortList()
		{
			this.DataList.Sort((TrapDefenseBuildingDevelopItemData a, TrapDefenseBuildingDevelopItemData b) => a.GetSortId() - b.GetSortId());
		}

		// Token: 0x04014ED0 RID: 85712
		public bool IsInDungeon;

		// Token: 0x04014ED1 RID: 85713
		public ETrapDefenseMachineType Type;

		// Token: 0x04014ED2 RID: 85714
		public ETrapDefensePlacementType PlacementType;

		// Token: 0x04014ED3 RID: 85715
		protected List<TrapDefenseBuildingDevelopItemData> DataList = new List<TrapDefenseBuildingDevelopItemData>();

		// Token: 0x04014ED4 RID: 85716
		protected Dictionary<int, TrapDefenseBuildingDevelopItemData> DataMap = new Dictionary<int, TrapDefenseBuildingDevelopItemData>();

		// Token: 0x04014ED5 RID: 85717
		[Nullable(2)]
		public TrapDefenseBuildingDevelopItemData CurSelectedData;

		// Token: 0x04014ED6 RID: 85718
		[Nullable(2)]
		public TrapDefenseBuildingDevelopItemData TempSelectedData;
	}
}
