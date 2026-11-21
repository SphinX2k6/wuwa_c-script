using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039CF RID: 14799
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopItemData
	{
		// Token: 0x0602620B RID: 156171 RVA: 0x00AB1B96 File Offset: 0x00AAFD96
		public static TrapDefenseBuildingDevelopItemData Create(int id, ETrapDefenseMachineType type)
		{
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = new TrapDefenseBuildingDevelopItemData(id, type);
			trapDefenseBuildingDevelopItemData.UpdateConfig();
			return trapDefenseBuildingDevelopItemData;
		}

		// Token: 0x0602620C RID: 156172 RVA: 0x00AB1BA8 File Offset: 0x00AAFDA8
		private TrapDefenseBuildingDevelopItemData(int id, ETrapDefenseMachineType type)
		{
			this.Id = id;
			this.Type = type;
		}

		// Token: 0x0602620D RID: 156173 RVA: 0x00AB1BF8 File Offset: 0x00AAFDF8
		private void UpdateConfig()
		{
			if (this.IsBuilding)
			{
				this.BuildingConfig = TrapDefenseConfig.Instance.GetBuildingById(this.Id);
				this.BuildingTypeConfig = TrapDefenseConfig.Instance.GetBuildingTypeById(this.BuildingConfig.Value.BuildingType);
				return;
			}
			this.AuxiliaryConfig = TrapDefenseConfig.Instance.GetAuxiliaryById(this.Id);
			this.AuxiliaryTypeConfig = TrapDefenseConfig.Instance.GetAuxiliaryTypeById(this.AuxiliaryConfig.Value.AuxiliaryType);
		}

		// Token: 0x0602620E RID: 156174 RVA: 0x00AB1C80 File Offset: 0x00AAFE80
		public string GetIconPath()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.Icon;
			}
			return this.BuildingTypeConfig.Value.Icon;
		}

		// Token: 0x0602620F RID: 156175 RVA: 0x00AB1CBC File Offset: 0x00AAFEBC
		public string GetName()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.Name;
			}
			return this.BuildingTypeConfig.Value.Name;
		}

		// Token: 0x06026210 RID: 156176 RVA: 0x00AB1CF8 File Offset: 0x00AAFEF8
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public ValueTuple<string, string[]> GetDesc()
		{
			if (this.IsBuilding)
			{
				return new ValueTuple<string, string[]>(this.BuildingConfig.Value.Desc, this.BuildingConfig.Value.DescArgs());
			}
			return new ValueTuple<string, string[]>(this.AuxiliaryConfig.Value.Desc, this.AuxiliaryConfig.Value.DescArgs());
		}

		// Token: 0x06026211 RID: 156177 RVA: 0x00AB1D64 File Offset: 0x00AAFF64
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<string, string> GetVideo()
		{
			if (this.IsBuilding)
			{
				return new ValueTuple<string, string>(this.BuildingTypeConfig.Value.VideoName, this.BuildingTypeConfig.Value.VideoPath);
			}
			return new ValueTuple<string, string>(this.AuxiliaryTypeConfig.Value.VideoName, this.AuxiliaryTypeConfig.Value.VideoPath);
		}

		// Token: 0x06026212 RID: 156178 RVA: 0x00AB1DD0 File Offset: 0x00AAFFD0
		public void SetIsUnLock(bool isUnlock)
		{
			this.IsUnlock = isUnlock;
		}

		// Token: 0x06026213 RID: 156179 RVA: 0x00AB1DD9 File Offset: 0x00AAFFD9
		public int GetLevel()
		{
			return TrapDefenseModel.Instance.DecomposeMachineId(this.Id).Level;
		}

		// Token: 0x06026214 RID: 156180 RVA: 0x00AB1DF0 File Offset: 0x00AAFFF0
		public ETrapDefensePlacementType GetPlacementType()
		{
			if (!this.IsBuilding)
			{
				return ETrapDefensePlacementType.None;
			}
			return (ETrapDefensePlacementType)this.BuildingTypeConfig.Value.PlacementType;
		}

		// Token: 0x06026215 RID: 156181 RVA: 0x00AB1E1C File Offset: 0x00AB001C
		public int GetUpgradeCost()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.UpgradeCost;
			}
			return this.BuildingConfig.Value.UpgradeCost;
		}

		// Token: 0x06026216 RID: 156182 RVA: 0x00AB1E58 File Offset: 0x00AB0058
		public int GetBuildingCost(bool isDynamic)
		{
			if (!this.IsBuilding)
			{
				return 0;
			}
			if (isDynamic && this.BuildingCostPriceDiscount != -1)
			{
				return this.BuildingCostPriceDiscount;
			}
			return this.BuildingConfig.Value.ConstructDefaultCost;
		}

		// Token: 0x06026217 RID: 156183 RVA: 0x00AB1E95 File Offset: 0x00AB0095
		public float GetCoolDown()
		{
			if (!this.IsBuilding)
			{
				return TowerDefensePlayerController.GetFollowerSkillCD(this.Id);
			}
			return 0f;
		}

		// Token: 0x06026218 RID: 156184 RVA: 0x00AB1EB0 File Offset: 0x00AB00B0
		public float GetRemainCd()
		{
			if (this.IsBuilding)
			{
				return 0f;
			}
			if (this.AuxiliaryConfig.Value.CDSkill == 0)
			{
				return 0f;
			}
			float followerSkillRemainCD = TowerDefensePlayerController.GetFollowerSkillRemainCD(this.Id);
			if (followerSkillRemainCD != 0f && !float.IsNaN(followerSkillRemainCD))
			{
				return followerSkillRemainCD;
			}
			return 0f;
		}

		// Token: 0x06026219 RID: 156185 RVA: 0x00AB1F0C File Offset: 0x00AB010C
		public bool GetIsMaxLevel(bool needCur)
		{
			int num = needCur ? this.CurMaxLevel : this.GetMaxLevel();
			int level = this.GetLevel();
			return num == level;
		}

		// Token: 0x0602621A RID: 156186 RVA: 0x00AB1F34 File Offset: 0x00AB0134
		public void SetBuildingPrice(int origin, int discount)
		{
			this.BuildingCostPriceDiscount = discount;
		}

		// Token: 0x0602621B RID: 156187 RVA: 0x00AB1F3D File Offset: 0x00AB013D
		public void SetCurMaxLevel(int max)
		{
			this.CurMaxLevel = max;
		}

		// Token: 0x0602621C RID: 156188 RVA: 0x00AB1F46 File Offset: 0x00AB0146
		public int GetCurMaxLevel()
		{
			return this.CurMaxLevel;
		}

		// Token: 0x0602621D RID: 156189 RVA: 0x00AB1F50 File Offset: 0x00AB0150
		public int GetMaxLevel()
		{
			if (this.MaxLevel >= 0)
			{
				return this.MaxLevel;
			}
			if (this.IsBuilding)
			{
				this.MaxLevel = this.BuildingTypeConfig.Value.MaxLevel;
				return this.MaxLevel;
			}
			this.MaxLevel = this.AuxiliaryTypeConfig.Value.MaxLevel;
			return this.MaxLevel;
		}

		// Token: 0x0602621E RID: 156190 RVA: 0x00AB1FB4 File Offset: 0x00AB01B4
		public bool GetIsUnlock()
		{
			return this.IsUnlock;
		}

		// Token: 0x0602621F RID: 156191 RVA: 0x00AB1FBC File Offset: 0x00AB01BC
		public bool GetHasBranch()
		{
			if (this.IsBuilding)
			{
				TrapDefenseBuilding? buildingConfig = this.BuildingConfig;
				TrapDefenseBuildingType? buildingTypeConfig = this.BuildingTypeConfig;
				return buildingConfig.Value.Level == buildingTypeConfig.Value.MaxLevel && buildingTypeConfig.Value.BranchCount > 1;
			}
			TrapDefenseAuxiliary? auxiliaryConfig = this.AuxiliaryConfig;
			TrapDefenseAuxiliaryType? auxiliaryTypeConfig = this.AuxiliaryTypeConfig;
			return auxiliaryConfig.Value.Level == auxiliaryTypeConfig.Value.MaxLevel && auxiliaryTypeConfig.Value.BranchCount > 1;
		}

		// Token: 0x06026220 RID: 156192 RVA: 0x00AB205C File Offset: 0x00AB025C
		public int GetBranchCount()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.BranchCount;
			}
			return this.BuildingTypeConfig.Value.BranchCount;
		}

		// Token: 0x06026221 RID: 156193 RVA: 0x00AB2098 File Offset: 0x00AB0298
		public unsafe List<ITrapDefenseBuildingDevelopAttrInfo> GetAttrItem()
		{
			if (this.AttrItems.Count > 0)
			{
				return this.AttrItems;
			}
			if (this.IsBuilding)
			{
				string icon = TrapDefenseBuildingDevelopDataDefine.placementAttrIcon[this.GetPlacementType()];
				ITrapDefenseBuildingDevelopAttrInfo item = new ITrapDefenseBuildingDevelopAttrInfo
				{
					Name = "TowerDefense_BuildingAttr_Type",
					Icon = icon,
					Value = this.GetPlacementId(),
					MultiTxt = new bool?(true)
				};
				this.AttrItems.Add(item);
				ITrapDefenseBuildingDevelopAttrInfo trapDefenseBuildingDevelopAttrInfo = new ITrapDefenseBuildingDevelopAttrInfo();
				trapDefenseBuildingDevelopAttrInfo.Name = "TowerDefense_BuildingAttr_Cost";
				trapDefenseBuildingDevelopAttrInfo.Icon = "/Game/Aki/UI/UIResources/Common/Image/IconAttribute/T_RogueSkill_Coin_UI.T_RogueSkill_Coin_UI";
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.GetBuildingCost(false));
				trapDefenseBuildingDevelopAttrInfo.Value = defaultInterpolatedStringHandler.ToStringAndClear();
				ITrapDefenseBuildingDevelopAttrInfo item2 = trapDefenseBuildingDevelopAttrInfo;
				this.AttrItems.Add(item2);
			}
			if (this.IsBuilding)
			{
				TrapDefenseBuilding? buildingConfig = this.BuildingConfig;
				TrapDefenseBuildingType? buildingTypeConfig = this.BuildingTypeConfig;
				KSCBaseProperty? buffData = TrapDefenseModel.Instance.ViewModelBuildingDevelop.GetBuffData(buildingTypeConfig.Value.TemplateId, buildingConfig.Value.SimpleCombatSubtypeIds(0));
				if (buffData == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.TowerDefense;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "无法获得Buff模板";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("机关ID", this.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("模板ID", buildingTypeConfig.Value.TemplateId);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return this.AttrItems;
				}
				KSCBaseProperty valueOrDefault = buffData.GetValueOrDefault();
				using (IEnumerator<int> enumerator = buildingTypeConfig.Value.AttrShowIter().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						int num = enumerator.Current;
						TrapDefenseAttributeShow? attrShow = TrapDefenseConfig.Instance.GetAttrShow(num);
						if (attrShow == null)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.TowerDefense;
							ELogAuthor author2 = ELogAuthor.WHJ;
							string message2 = "缺少属性字段配置";
							ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("属性ID", num);
							instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						}
						else
						{
							int num2;
							if (!valueOrDefault.TryGetMember(attrShow.Value.Key, out num2))
							{
								num2 = 0;
							}
							string value = string.Empty;
							if (attrShow.Value.Key == "SkillCoolDown")
							{
								float num3 = (float)num2 / 10000f;
								string text;
								if (num3 % 1f != 0f)
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
									defaultInterpolatedStringHandler.AppendFormatted<float>(num3, "F1");
									text = defaultInterpolatedStringHandler.ToStringAndClear();
								}
								else
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
									defaultInterpolatedStringHandler.AppendFormatted<float>(num3, "F0");
									text = defaultInterpolatedStringHandler.ToStringAndClear();
								}
								value = text;
							}
							else
							{
								value = num2.ToString();
							}
							ITrapDefenseBuildingDevelopAttrInfo item3 = new ITrapDefenseBuildingDevelopAttrInfo
							{
								Name = attrShow.Value.Name,
								Icon = attrShow.Value.Icon,
								Value = value
							};
							this.AttrItems.Add(item3);
						}
					}
					goto IL_524;
				}
			}
			TrapDefenseAuxiliaryType? auxiliaryTypeConfig = this.AuxiliaryTypeConfig;
			Dictionary<EKSC_AttrType, float> followerAttrsByProxy = KscUtil.GetFollowerAttrsByProxy(this.Id);
			if (followerAttrsByProxy == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.TowerDefense;
				ELogAuthor author3 = ELogAuthor.WHJ;
				string message3 = "无法读取辅助机属性";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("AttrID", this.Id);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return this.AttrItems;
			}
			foreach (int num4 in auxiliaryTypeConfig.Value.AttrShowIter())
			{
				TrapDefenseAttributeShow? attrShow2 = TrapDefenseConfig.Instance.GetAttrShow(num4);
				float num5;
				if (attrShow2 == null)
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.TowerDefense;
					ELogAuthor author4 = ELogAuthor.WHJ;
					string message4 = "数据库未找到属性键";
					ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("AttrID", num4);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				}
				else if (!followerAttrsByProxy.TryGetValue((EKSC_AttrType)num4, out num5))
				{
					Log instance5 = Log.Instance;
					ELogModule module5 = ELogModule.TowerDefense;
					ELogAuthor author5 = ELogAuthor.WHJ;
					string message5 = "属性值Map未找到键";
					ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("AttrID", num4);
					instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				}
				else
				{
					float num6 = followerAttrsByProxy[(EKSC_AttrType)num4];
					string value2 = string.Empty;
					if (attrShow2.Value.Key == "SkillCoolDown")
					{
						float num7 = num6 / 10000f;
						string text2;
						if (num7 % 1f != 0f)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
							defaultInterpolatedStringHandler.AppendFormatted<float>(num7, "F1");
							text2 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
							defaultInterpolatedStringHandler.AppendFormatted<float>(num7, "F0");
							text2 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						value2 = text2;
					}
					else
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
						defaultInterpolatedStringHandler.AppendFormatted<float>(num6);
						value2 = defaultInterpolatedStringHandler.ToStringAndClear();
					}
					ITrapDefenseBuildingDevelopAttrInfo item4 = new ITrapDefenseBuildingDevelopAttrInfo
					{
						Name = attrShow2.Value.Name,
						Icon = attrShow2.Value.Icon,
						Value = value2
					};
					this.AttrItems.Add(item4);
				}
			}
			IL_524:
			return this.AttrItems;
		}

		// Token: 0x06026222 RID: 156194 RVA: 0x00AB2604 File Offset: 0x00AB0804
		public int GetBranch()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.Branch;
			}
			return this.BuildingConfig.Value.Branch;
		}

		// Token: 0x06026223 RID: 156195 RVA: 0x00AB2640 File Offset: 0x00AB0840
		public string GetBranchDesc()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.BranchDesc;
			}
			return this.BuildingConfig.Value.BranchDesc;
		}

		// Token: 0x06026224 RID: 156196 RVA: 0x00AB267C File Offset: 0x00AB087C
		public string[] GetBranchDescArgs()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.BranchDescArgs();
			}
			return this.BuildingConfig.Value.BranchDescArgs();
		}

		// Token: 0x06026225 RID: 156197 RVA: 0x00AB26B8 File Offset: 0x00AB08B8
		public bool CheckNeedRedDot()
		{
			return this.GetIsMaxLevel(false) && this.GetBranchCount() > 1 && TrapDefenseModel.Instance.DecomposeMachineId(this.Id).Branch == 0;
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x06026226 RID: 156198 RVA: 0x00AB26E8 File Offset: 0x00AB08E8
		public bool IsBuilding
		{
			get
			{
				return this.Type == ETrapDefenseMachineType.Building;
			}
		}

		// Token: 0x06026227 RID: 156199 RVA: 0x00AB26F3 File Offset: 0x00AB08F3
		public void UpdateId(int newId)
		{
			this.Id = newId;
			this.AttrItems.Clear();
			this.UpdateConfig();
		}

		// Token: 0x06026228 RID: 156200 RVA: 0x00AB2710 File Offset: 0x00AB0910
		public int GetDataType()
		{
			if (this.DataType != -1)
			{
				return this.DataType;
			}
			ITrapDefenseMachineIdInfo trapDefenseMachineIdInfo = TrapDefenseModel.Instance.DecomposeMachineId(this.Id);
			this.DataType = trapDefenseMachineIdInfo.DataType;
			return this.DataType;
		}

		// Token: 0x06026229 RID: 156201 RVA: 0x00AB2750 File Offset: 0x00AB0950
		public int GetSortId()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.SortId;
			}
			return this.BuildingTypeConfig.Value.SortId;
		}

		// Token: 0x0602622A RID: 156202 RVA: 0x00AB278C File Offset: 0x00AB098C
		public string GetPlacementId()
		{
			if (this.Type == ETrapDefenseMachineType.Auxiliary)
			{
				return "TowerDefense_Building_AuxiliaryType_Text";
			}
			ETrapDefensePlacementType placementType = this.GetPlacementType();
			if (placementType == ETrapDefensePlacementType.Floor)
			{
				return "TowerDefense_Building_FloorBuildingType_Text";
			}
			if (placementType == ETrapDefensePlacementType.Wall)
			{
				return "TowerDefense_Building_WallBuildingType_Text";
			}
			return "TowerDefense_Building_TopBuildingType_Text";
		}

		// Token: 0x0602622B RID: 156203 RVA: 0x00AB27C8 File Offset: 0x00AB09C8
		public void SetLockInBattle(bool isLocked)
		{
			this.NeedLockInBattle = isLocked;
		}

		// Token: 0x0602622C RID: 156204 RVA: 0x00AB27D1 File Offset: 0x00AB09D1
		public bool GetLockInBattle()
		{
			return this.NeedLockInBattle;
		}

		// Token: 0x0602622D RID: 156205 RVA: 0x00AB27D9 File Offset: 0x00AB09D9
		public void SetSellPrice(int price)
		{
			this.SellPrice = price;
		}

		// Token: 0x0602622E RID: 156206 RVA: 0x00AB27E2 File Offset: 0x00AB09E2
		public int GetSellPrice()
		{
			return this.SellPrice;
		}

		// Token: 0x04014ED7 RID: 85719
		public int Id;

		// Token: 0x04014ED8 RID: 85720
		public ETrapDefenseMachineType Type;

		// Token: 0x04014ED9 RID: 85721
		public bool IsInDungeon;

		// Token: 0x04014EDA RID: 85722
		private int DataType = -1;

		// Token: 0x04014EDB RID: 85723
		private int MaxLevel = -1;

		// Token: 0x04014EDC RID: 85724
		private int CurMaxLevel = -1;

		// Token: 0x04014EDD RID: 85725
		private int SellPrice;

		// Token: 0x04014EDE RID: 85726
		private readonly List<ITrapDefenseBuildingDevelopAttrInfo> AttrItems = new List<ITrapDefenseBuildingDevelopAttrInfo>();

		// Token: 0x04014EDF RID: 85727
		private bool IsUnlock = true;

		// Token: 0x04014EE0 RID: 85728
		private bool NeedLockInBattle;

		// Token: 0x04014EE1 RID: 85729
		private TrapDefenseAuxiliary? AuxiliaryConfig;

		// Token: 0x04014EE2 RID: 85730
		private TrapDefenseAuxiliaryType? AuxiliaryTypeConfig;

		// Token: 0x04014EE3 RID: 85731
		private TrapDefenseBuilding? BuildingConfig;

		// Token: 0x04014EE4 RID: 85732
		private TrapDefenseBuildingType? BuildingTypeConfig;

		// Token: 0x04014EE5 RID: 85733
		private int BuildingCostPriceDiscount = -1;
	}
}
