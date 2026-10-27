using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A27 RID: 18983
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBuildingDevelopItemData
	{
		// Token: 0x0603147B RID: 201851 RVA: 0x00B6DB9A File Offset: 0x00B6BD9A
		public static TrapDefenseBuildingDevelopItemData Create(int id, ETrapDefenseMachineType type)
		{
			TrapDefenseBuildingDevelopItemData trapDefenseBuildingDevelopItemData = new TrapDefenseBuildingDevelopItemData(id, type);
			trapDefenseBuildingDevelopItemData.UpdateConfig();
			return trapDefenseBuildingDevelopItemData;
		}

		// Token: 0x0603147C RID: 201852 RVA: 0x00B6DBAC File Offset: 0x00B6BDAC
		private TrapDefenseBuildingDevelopItemData(int id, ETrapDefenseMachineType type)
		{
			this.Id = id;
			this.Type = type;
		}

		// Token: 0x0603147D RID: 201853 RVA: 0x00B6DBFC File Offset: 0x00B6BDFC
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

		// Token: 0x0603147E RID: 201854 RVA: 0x00B6DC84 File Offset: 0x00B6BE84
		public string GetIconPath()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.Icon;
			}
			return this.BuildingTypeConfig.Value.Icon;
		}

		// Token: 0x0603147F RID: 201855 RVA: 0x00B6DCC0 File Offset: 0x00B6BEC0
		public string GetName()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.Name;
			}
			return this.BuildingTypeConfig.Value.Name;
		}

		// Token: 0x06031480 RID: 201856 RVA: 0x00B6DCFC File Offset: 0x00B6BEFC
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

		// Token: 0x06031481 RID: 201857 RVA: 0x00B6DD68 File Offset: 0x00B6BF68
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

		// Token: 0x06031482 RID: 201858 RVA: 0x00B6DDD4 File Offset: 0x00B6BFD4
		public void SetIsUnLock(bool isUnlock)
		{
			this.IsUnlock = isUnlock;
		}

		// Token: 0x06031483 RID: 201859 RVA: 0x00B6DDDD File Offset: 0x00B6BFDD
		public int GetLevel()
		{
			return TrapDefenseModel.Instance.DecomposeMachineId(this.Id).Level;
		}

		// Token: 0x06031484 RID: 201860 RVA: 0x00B6DDF4 File Offset: 0x00B6BFF4
		public ETrapDefensePlacementType GetPlacementType()
		{
			if (!this.IsBuilding)
			{
				return ETrapDefensePlacementType.None;
			}
			return (ETrapDefensePlacementType)this.BuildingTypeConfig.Value.PlacementType;
		}

		// Token: 0x06031485 RID: 201861 RVA: 0x00B6DE20 File Offset: 0x00B6C020
		public int GetUpgradeCost()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.UpgradeCost;
			}
			return this.BuildingConfig.Value.UpgradeCost;
		}

		// Token: 0x06031486 RID: 201862 RVA: 0x00B6DE5C File Offset: 0x00B6C05C
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

		// Token: 0x06031487 RID: 201863 RVA: 0x00B6DE99 File Offset: 0x00B6C099
		public float GetCoolDown()
		{
			if (!this.IsBuilding)
			{
				return TowerDefensePlayerController.GetFollowerSkillCD(this.Id);
			}
			return 0f;
		}

		// Token: 0x06031488 RID: 201864 RVA: 0x00B6DEB4 File Offset: 0x00B6C0B4
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

		// Token: 0x06031489 RID: 201865 RVA: 0x00B6DF10 File Offset: 0x00B6C110
		public bool GetIsMaxLevel(bool needCur)
		{
			int num = needCur ? this.CurMaxLevel : this.GetMaxLevel();
			int level = this.GetLevel();
			return num == level;
		}

		// Token: 0x0603148A RID: 201866 RVA: 0x00B6DF38 File Offset: 0x00B6C138
		public void SetBuildingPrice(int origin, int discount)
		{
			this.BuildingCostPriceDiscount = discount;
		}

		// Token: 0x0603148B RID: 201867 RVA: 0x00B6DF41 File Offset: 0x00B6C141
		public void SetCurMaxLevel(int max)
		{
			this.CurMaxLevel = max;
		}

		// Token: 0x0603148C RID: 201868 RVA: 0x00B6DF4A File Offset: 0x00B6C14A
		public int GetCurMaxLevel()
		{
			return this.CurMaxLevel;
		}

		// Token: 0x0603148D RID: 201869 RVA: 0x00B6DF54 File Offset: 0x00B6C154
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

		// Token: 0x0603148E RID: 201870 RVA: 0x00B6DFB8 File Offset: 0x00B6C1B8
		public bool GetIsUnlock()
		{
			return this.IsUnlock;
		}

		// Token: 0x0603148F RID: 201871 RVA: 0x00B6DFC0 File Offset: 0x00B6C1C0
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

		// Token: 0x06031490 RID: 201872 RVA: 0x00B6E060 File Offset: 0x00B6C260
		public int GetBranchCount()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.BranchCount;
			}
			return this.BuildingTypeConfig.Value.BranchCount;
		}

		// Token: 0x06031491 RID: 201873 RVA: 0x00B6E09C File Offset: 0x00B6C29C
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
							PropertyInfo property = buffData.GetType().GetProperty(attrShow.Value.Key, BindingFlags.Instance | BindingFlags.Public);
							int num2 = 0;
							if (property != null)
							{
								num2 = (int)property.GetValue(buffData);
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
								string text2;
								if (!float.IsNaN((float)num2))
								{
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
									defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
									text2 = defaultInterpolatedStringHandler.ToStringAndClear();
								}
								else
								{
									text2 = attrShow.Value.Key + "Error";
								}
								value = text2;
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
					goto IL_57A;
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
						string text3;
						if (num7 % 1f != 0f)
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
							defaultInterpolatedStringHandler.AppendFormatted<float>(num7, "F1");
							text3 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						else
						{
							DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
							defaultInterpolatedStringHandler.AppendFormatted<float>(num7, "F0");
							text3 = defaultInterpolatedStringHandler.ToStringAndClear();
						}
						value2 = text3;
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
			IL_57A:
			return this.AttrItems;
		}

		// Token: 0x06031492 RID: 201874 RVA: 0x00B6E660 File Offset: 0x00B6C860
		public int GetBranch()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.Branch;
			}
			return this.BuildingConfig.Value.Branch;
		}

		// Token: 0x06031493 RID: 201875 RVA: 0x00B6E69C File Offset: 0x00B6C89C
		public string GetBranchDesc()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.BranchDesc;
			}
			return this.BuildingConfig.Value.BranchDesc;
		}

		// Token: 0x06031494 RID: 201876 RVA: 0x00B6E6D8 File Offset: 0x00B6C8D8
		public string[] GetBranchDescArgs()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryConfig.Value.BranchDescArgs();
			}
			return this.BuildingConfig.Value.BranchDescArgs();
		}

		// Token: 0x06031495 RID: 201877 RVA: 0x00B6E714 File Offset: 0x00B6C914
		public bool CheckNeedRedDot()
		{
			return this.GetIsMaxLevel(false) && this.GetBranchCount() > 1 && TrapDefenseModel.Instance.DecomposeMachineId(this.Id).Branch == 0;
		}

		// Token: 0x17007A2D RID: 31277
		// (get) Token: 0x06031496 RID: 201878 RVA: 0x00B6E744 File Offset: 0x00B6C944
		public bool IsBuilding
		{
			get
			{
				return this.Type == ETrapDefenseMachineType.Building;
			}
		}

		// Token: 0x06031497 RID: 201879 RVA: 0x00B6E74F File Offset: 0x00B6C94F
		public void UpdateId(int newId)
		{
			this.Id = newId;
			this.AttrItems.Clear();
			this.UpdateConfig();
		}

		// Token: 0x06031498 RID: 201880 RVA: 0x00B6E76C File Offset: 0x00B6C96C
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

		// Token: 0x06031499 RID: 201881 RVA: 0x00B6E7AC File Offset: 0x00B6C9AC
		public int GetSortId()
		{
			if (!this.IsBuilding)
			{
				return this.AuxiliaryTypeConfig.Value.SortId;
			}
			return this.BuildingTypeConfig.Value.SortId;
		}

		// Token: 0x0603149A RID: 201882 RVA: 0x00B6E7E8 File Offset: 0x00B6C9E8
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

		// Token: 0x0603149B RID: 201883 RVA: 0x00B6E824 File Offset: 0x00B6CA24
		public void SetLockInBattle(bool isLocked)
		{
			this.NeedLockInBattle = isLocked;
		}

		// Token: 0x0603149C RID: 201884 RVA: 0x00B6E82D File Offset: 0x00B6CA2D
		public bool GetLockInBattle()
		{
			return this.NeedLockInBattle;
		}

		// Token: 0x0603149D RID: 201885 RVA: 0x00B6E835 File Offset: 0x00B6CA35
		public void SetSellPrice(int price)
		{
			this.SellPrice = price;
		}

		// Token: 0x0603149E RID: 201886 RVA: 0x00B6E83E File Offset: 0x00B6CA3E
		public int GetSellPrice()
		{
			return this.SellPrice;
		}

		// Token: 0x0401A580 RID: 107904
		public int Id;

		// Token: 0x0401A581 RID: 107905
		public ETrapDefenseMachineType Type;

		// Token: 0x0401A582 RID: 107906
		public bool IsInDungeon;

		// Token: 0x0401A583 RID: 107907
		private int DataType = -1;

		// Token: 0x0401A584 RID: 107908
		private int MaxLevel = -1;

		// Token: 0x0401A585 RID: 107909
		private int CurMaxLevel = -1;

		// Token: 0x0401A586 RID: 107910
		private int SellPrice;

		// Token: 0x0401A587 RID: 107911
		private readonly List<ITrapDefenseBuildingDevelopAttrInfo> AttrItems = new List<ITrapDefenseBuildingDevelopAttrInfo>();

		// Token: 0x0401A588 RID: 107912
		private bool IsUnlock = true;

		// Token: 0x0401A589 RID: 107913
		private bool NeedLockInBattle;

		// Token: 0x0401A58A RID: 107914
		private TrapDefenseAuxiliary? AuxiliaryConfig;

		// Token: 0x0401A58B RID: 107915
		private TrapDefenseAuxiliaryType? AuxiliaryTypeConfig;

		// Token: 0x0401A58C RID: 107916
		private TrapDefenseBuilding? BuildingConfig;

		// Token: 0x0401A58D RID: 107917
		private TrapDefenseBuildingType? BuildingTypeConfig;

		// Token: 0x0401A58E RID: 107918
		private int BuildingCostPriceDiscount = -1;
	}
}
