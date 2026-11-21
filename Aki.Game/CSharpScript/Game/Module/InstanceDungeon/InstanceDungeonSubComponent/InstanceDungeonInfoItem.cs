using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Mowing;
using CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk;
using CSharpScript.Game.Module.AdventureGuide;
using CSharpScript.Game.Module.InstanceDungeon.ExchangeReward;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonViewModel;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.TowerDefence;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004873 RID: 18547
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonInfoItem : UiPanelBase
	{
		// Token: 0x0602EA86 RID: 191110 RVA: 0x00D05D90 File Offset: 0x00D03F90
		protected unsafe override void OnRegisterComponent()
		{
			InstanceDungeonViewModelBase instanceDungeonViewModelBase = this.OpenParam as InstanceDungeonViewModelBase;
			if (instanceDungeonViewModelBase == null)
			{
				throw new ArgumentNullException("OpenParam");
			}
			this.ParentModel = instanceDungeonViewModelBase;
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602EA87 RID: 191111 RVA: 0x00D05E7C File Offset: 0x00D0407C
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonInfoItem.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonInfoItem.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA88 RID: 191112 RVA: 0x00D05EBF File Offset: 0x00D040BF
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x0602EA89 RID: 191113 RVA: 0x00D05EDD File Offset: 0x00D040DD
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x0602EA8A RID: 191114 RVA: 0x00D05EFB File Offset: 0x00D040FB
		[NullableContext(1)]
		public void InitButton(Action onClickBtnSoloCallBack, Action onClickBtnMultipleCallBack, Action onClickBtnTeamCallBack)
		{
			this.InstanceDungeonStartButtonItem.OnClickBtnSoloCallBack = onClickBtnSoloCallBack;
			this.InstanceDungeonStartButtonItem.OnClickBtnMultipleCallBack = onClickBtnMultipleCallBack;
			this.InstanceDungeonStartButtonItem.OnClickBtnTeamCallBack = onClickBtnTeamCallBack;
		}

		// Token: 0x0602EA8B RID: 191115 RVA: 0x00D05F24 File Offset: 0x00D04124
		public UniTask RefreshItem(int instanceId)
		{
			InstanceDungeonInfoItem.<RefreshItem>d__29 <RefreshItem>d__;
			<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItem>d__.<>4__this = this;
			<RefreshItem>d__.instanceId = instanceId;
			<RefreshItem>d__.<>1__state = -1;
			<RefreshItem>d__.<>t__builder.Start<InstanceDungeonInfoItem.<RefreshItem>d__29>(ref <RefreshItem>d__);
			return <RefreshItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA8C RID: 191116 RVA: 0x00D05F70 File Offset: 0x00D04170
		[NullableContext(1)]
		private void UpdateInstanceDungeonBuffItem(InstanceDungeon config, string monsterTips, bool showMonsterPreview)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass30_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass30_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.monsterTips = monsterTips;
			CS$<>8__locals1.showMonsterPreview = showMonsterPreview;
			if (string.IsNullOrEmpty(CS$<>8__locals1.monsterTips) && !CS$<>8__locals1.showMonsterPreview)
			{
				InstanceDungeonBuffItem instanceDungeonBuffItem = this.InstanceDungeonBuffItem;
				if (instanceDungeonBuffItem == null)
				{
					return;
				}
				instanceDungeonBuffItem.SetActive(false);
				return;
			}
			else
			{
				bool flag = config.InstSubType == 4;
				CS$<>8__locals1.showType = (flag ? InstanceDungeonBuffItem.EBuffInfoType.Resistance : InstanceDungeonBuffItem.EBuffInfoType.Buff);
				if (this.InstanceDungeonBuffItem == null)
				{
					this.InstanceDungeonBuffItem = new InstanceDungeonBuffItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass30_0.<<UpdateInstanceDungeonBuffItem>b__0>d <<UpdateInstanceDungeonBuffItem>b__0>d;
						<<UpdateInstanceDungeonBuffItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateInstanceDungeonBuffItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdateInstanceDungeonBuffItem>b__0>d.<>1__state = -1;
						<<UpdateInstanceDungeonBuffItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass30_0.<<UpdateInstanceDungeonBuffItem>b__0>d>(ref <<UpdateInstanceDungeonBuffItem>b__0>d);
						return <<UpdateInstanceDungeonBuffItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				InstanceDungeonBuffItem instanceDungeonBuffItem2 = this.InstanceDungeonBuffItem;
				if (instanceDungeonBuffItem2 != null)
				{
					instanceDungeonBuffItem2.SetActive(true);
				}
				InstanceDungeonBuffItem instanceDungeonBuffItem3 = this.InstanceDungeonBuffItem;
				if (instanceDungeonBuffItem3 == null)
				{
					return;
				}
				instanceDungeonBuffItem3.RefreshItem(CS$<>8__locals1.monsterTips, CS$<>8__locals1.showMonsterPreview, CS$<>8__locals1.showType);
				return;
			}
		}

		// Token: 0x0602EA8D RID: 191117 RVA: 0x00D06038 File Offset: 0x00D04238
		private void UpdateInstanceDungeonEntranceTowerDefenceItem(EDungeonSubType subType)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass31_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass31_0();
			CS$<>8__locals1.<>4__this = this;
			if (subType != EDungeonSubType.TowerDefense)
			{
				InstanceDungeonEntranceTowerDefenceItem instanceDungeonEntranceTowerDefenceItem = this.InstanceDungeonEntranceTowerDefenceItem;
				if (instanceDungeonEntranceTowerDefenceItem == null)
				{
					return;
				}
				instanceDungeonEntranceTowerDefenceItem.SetActive(false);
				return;
			}
			else
			{
				CS$<>8__locals1.data = TowerDefenseController.Instance.BuildPhantomForInstanceDungeonEntranceData(this.InstanceId);
				if (this.InstanceDungeonEntranceTowerDefenceItem == null)
				{
					this.InstanceDungeonEntranceTowerDefenceItem = new InstanceDungeonEntranceTowerDefenceItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass31_0.<<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d <<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d;
						<<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d.<>1__state = -1;
						<<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass31_0.<<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d>(ref <<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d);
						return <<UpdateInstanceDungeonEntranceTowerDefenceItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonEntranceTowerDefenceItem.SetActive(true);
				this.InstanceDungeonEntranceTowerDefenceItem.RefreshItem(CS$<>8__locals1.data);
				return;
			}
		}

		// Token: 0x0602EA8E RID: 191118 RVA: 0x00D060CC File Offset: 0x00D042CC
		private void UpdateLineItem(EDungeonSubType subType)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass32_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass32_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.isNeedLineItem = (subType == EDungeonSubType.MowingRisk);
			if (!CS$<>8__locals1.isNeedLineItem && this.LineItem != null)
			{
				this.LineItem.SetUIActive(false);
				return;
			}
			if (this.LineItem == null)
			{
				this.LoadList.Add(delegate
				{
					InstanceDungeonInfoItem.<>c__DisplayClass32_0.<<UpdateLineItem>b__0>d <<UpdateLineItem>b__0>d;
					<<UpdateLineItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<UpdateLineItem>b__0>d.<>4__this = CS$<>8__locals1;
					<<UpdateLineItem>b__0>d.<>1__state = -1;
					<<UpdateLineItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass32_0.<<UpdateLineItem>b__0>d>(ref <<UpdateLineItem>b__0>d);
					return <<UpdateLineItem>b__0>d.<>t__builder.Task;
				});
				return;
			}
			this.LineItem.SetUIActive(true);
		}

		// Token: 0x0602EA8F RID: 191119 RVA: 0x00D0613C File Offset: 0x00D0433C
		private void UpdateInstanceDungeonRecommendLevelItem(EDungeonSubType subType)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass33_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass33_0();
			CS$<>8__locals1.<>4__this = this;
			if (subType != EDungeonSubType.TowerDefense && subType != EDungeonSubType.Mowing && subType != EDungeonSubType.MowingRisk)
			{
				InstanceDungeonRecommendLevelItem instanceDungeonRecommendLevelItem = this.InstanceDungeonRecommendLevelItem;
				if (instanceDungeonRecommendLevelItem == null)
				{
					return;
				}
				instanceDungeonRecommendLevelItem.SetActive(false);
				return;
			}
			else
			{
				CS$<>8__locals1.level = new TowerDefenseRecommendLevel
				{
					TextId = "RecommendLevel",
					Level = 0
				};
				if (subType == EDungeonSubType.TowerDefense)
				{
					CS$<>8__locals1.level = TowerDefenseController.Instance.BuildRecommendLevelForInstanceDungeonEntranceData(this.InstanceId);
				}
				else if (subType == EDungeonSubType.MowingRisk)
				{
					IMowingRiskInstanceRecommendData mowingRiskInstanceRecommendData = MowingRiskModel.Instance.BuildInstanceRecommendDataByInstanceId(this.InstanceId);
					CS$<>8__locals1.level.TextId = mowingRiskInstanceRecommendData.TextId;
					CS$<>8__locals1.level.Level = mowingRiskInstanceRecommendData.RecommendLevel;
				}
				else
				{
					ActivityMowingData mowingActivityData = ActivityMowingController.Instance.GetMowingActivityData();
					int? num = (mowingActivityData != null) ? new int?(mowingActivityData.GetLevelDiffRecommendLevel(this.InstanceId)) : null;
					CS$<>8__locals1.level.Level = num.GetValueOrDefault();
				}
				if (this.InstanceDungeonRecommendLevelItem == null)
				{
					this.InstanceDungeonRecommendLevelItem = new InstanceDungeonRecommendLevelItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass33_0.<<UpdateInstanceDungeonRecommendLevelItem>b__0>d <<UpdateInstanceDungeonRecommendLevelItem>b__0>d;
						<<UpdateInstanceDungeonRecommendLevelItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateInstanceDungeonRecommendLevelItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdateInstanceDungeonRecommendLevelItem>b__0>d.<>1__state = -1;
						<<UpdateInstanceDungeonRecommendLevelItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass33_0.<<UpdateInstanceDungeonRecommendLevelItem>b__0>d>(ref <<UpdateInstanceDungeonRecommendLevelItem>b__0>d);
						return <<UpdateInstanceDungeonRecommendLevelItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonRecommendLevelItem.SetActive(true);
				this.InstanceDungeonRecommendLevelItem.RefreshItem(CS$<>8__locals1.level);
				return;
			}
		}

		// Token: 0x0602EA90 RID: 191120 RVA: 0x00D06274 File Offset: 0x00D04474
		private void UpdateInstanceDungeonTimeCountCostItem()
		{
			InstanceDungeonInfoItem.<>c__DisplayClass34_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass34_0();
			CS$<>8__locals1.<>4__this = this;
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			if (config == null)
			{
				return;
			}
			bool flag = config.Value.InstSubType == 4;
			int? instancePowerCost = InstanceDungeonEntranceModel.Instance.GetInstancePowerCost(this.InstanceId);
			if (instancePowerCost != null)
			{
				int? num = instancePowerCost;
				int num2 = 0;
				if (!(num.GetValueOrDefault() <= num2 & num != null))
				{
					CS$<>8__locals1.costItem = ExchangeRewardModel.Instance.GetExchangeNormalConsume(this.InstanceId);
					if (flag)
					{
						if (this.InstanceDungeonTimeCountAndCostItem == null)
						{
							this.InstanceDungeonTimeCountAndCostItem = new InstanceDungeonTimeCountAndCostItem();
							this.LoadList.Add(delegate
							{
								InstanceDungeonInfoItem.<>c__DisplayClass34_0.<<UpdateInstanceDungeonTimeCountCostItem>b__0>d <<UpdateInstanceDungeonTimeCountCostItem>b__0>d;
								<<UpdateInstanceDungeonTimeCountCostItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
								<<UpdateInstanceDungeonTimeCountCostItem>b__0>d.<>4__this = CS$<>8__locals1;
								<<UpdateInstanceDungeonTimeCountCostItem>b__0>d.<>1__state = -1;
								<<UpdateInstanceDungeonTimeCountCostItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass34_0.<<UpdateInstanceDungeonTimeCountCostItem>b__0>d>(ref <<UpdateInstanceDungeonTimeCountCostItem>b__0>d);
								return <<UpdateInstanceDungeonTimeCountCostItem>b__0>d.<>t__builder.Task;
							});
							return;
						}
						this.InstanceDungeonTimeCountAndCostItem.SetActive(true);
						this.InstanceDungeonTimeCountAndCostItem.RefreshItem(CS$<>8__locals1.costItem[0], this.InstanceId);
						return;
					}
					else
					{
						if (this.InstanceDungeonCostItem == null)
						{
							this.InstanceDungeonCostItem = new InstanceDungeonCostItem();
							this.LoadList.Add(delegate
							{
								InstanceDungeonInfoItem.<>c__DisplayClass34_0.<<UpdateInstanceDungeonTimeCountCostItem>b__1>d <<UpdateInstanceDungeonTimeCountCostItem>b__1>d;
								<<UpdateInstanceDungeonTimeCountCostItem>b__1>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
								<<UpdateInstanceDungeonTimeCountCostItem>b__1>d.<>4__this = CS$<>8__locals1;
								<<UpdateInstanceDungeonTimeCountCostItem>b__1>d.<>1__state = -1;
								<<UpdateInstanceDungeonTimeCountCostItem>b__1>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass34_0.<<UpdateInstanceDungeonTimeCountCostItem>b__1>d>(ref <<UpdateInstanceDungeonTimeCountCostItem>b__1>d);
								return <<UpdateInstanceDungeonTimeCountCostItem>b__1>d.<>t__builder.Task;
							});
							return;
						}
						this.InstanceDungeonCostItem.SetActive(true);
						this.InstanceDungeonCostItem.RefreshItem(CS$<>8__locals1.costItem[0]);
						return;
					}
				}
			}
		}

		// Token: 0x0602EA91 RID: 191121 RVA: 0x00D063B4 File Offset: 0x00D045B4
		private void UpdateRewardItem()
		{
			if (InstanceDungeonEntranceModel.Instance.GetInstanceDungeonReward(this.InstanceId).Item1.Count <= 0)
			{
				InstanceDungeonEntranceRewardItem instanceDungeonEntranceRewardItem = this.InstanceDungeonEntranceRewardItem;
				if (instanceDungeonEntranceRewardItem == null)
				{
					return;
				}
				instanceDungeonEntranceRewardItem.SetActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonEntranceRewardItem == null)
				{
					this.InstanceDungeonEntranceRewardItem = new InstanceDungeonEntranceRewardItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<<UpdateRewardItem>b__35_0>d <<UpdateRewardItem>b__35_0>d;
						<<UpdateRewardItem>b__35_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateRewardItem>b__35_0>d.<>4__this = this;
						<<UpdateRewardItem>b__35_0>d.<>1__state = -1;
						<<UpdateRewardItem>b__35_0>d.<>t__builder.Start<InstanceDungeonInfoItem.<<UpdateRewardItem>b__35_0>d>(ref <<UpdateRewardItem>b__35_0>d);
						return <<UpdateRewardItem>b__35_0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonEntranceRewardItem.SetActive(true);
				this.InstanceDungeonEntranceRewardItem.RefreshItem(this.InstanceId);
				return;
			}
		}

		// Token: 0x0602EA92 RID: 191122 RVA: 0x00D06438 File Offset: 0x00D04638
		private void UpdateBottomTips(EDungeonSubType subType)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass36_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass36_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dataList = null;
			if (subType == EDungeonSubType.MowingRisk)
			{
				CS$<>8__locals1.dataList = new List<InstanceDungeonBottomTipItemData>();
				MowingRiskModel instance = MowingRiskModel.Instance;
				RiskHarvestInst riskHarvestInstConfigByInstanceId = instance.GetRiskHarvestInstConfigByInstanceId(this.InstanceId);
				int maxScoreByInstanceId = instance.GetMaxScoreByInstanceId(this.InstanceId);
				InstanceDungeonBottomTipItemData item = new InstanceDungeonBottomTipItemData
				{
					TextId = "riskofrain_total_num",
					TextArgs = new string[]
					{
						maxScoreByInstanceId.ToString()
					}
				};
				CS$<>8__locals1.dataList.Add(item);
				if (!riskHarvestInstConfigByInstanceId.Accumulate)
				{
					int monsterRatioByInstanceId = instance.GetMonsterRatioByInstanceId(this.InstanceId);
					InstanceDungeonBottomTipItemData item2 = new InstanceDungeonBottomTipItemData
					{
						TextId = "riskofrain_ratio_num",
						TextArgs = new string[]
						{
							monsterRatioByInstanceId.ToString()
						}
					};
					CS$<>8__locals1.dataList.Add(item2);
				}
			}
			if (CS$<>8__locals1.dataList == null || CS$<>8__locals1.dataList.Count == 0)
			{
				base.GetVerticalLayout(4).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetVerticalLayout(4).RootUIComp.Get().SetUIActive(true);
			this.LoadList.Add(delegate
			{
				InstanceDungeonInfoItem.<>c__DisplayClass36_0.<<UpdateBottomTips>b__0>d <<UpdateBottomTips>b__0>d;
				<<UpdateBottomTips>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<UpdateBottomTips>b__0>d.<>4__this = CS$<>8__locals1;
				<<UpdateBottomTips>b__0>d.<>1__state = -1;
				<<UpdateBottomTips>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass36_0.<<UpdateBottomTips>b__0>d>(ref <<UpdateBottomTips>b__0>d);
				return <<UpdateBottomTips>b__0>d.<>t__builder.Task;
			});
		}

		// Token: 0x0602EA93 RID: 191123 RVA: 0x00D0657C File Offset: 0x00D0477C
		private UniTask LoadInstanceDungeonBottomTipTemplateItem()
		{
			InstanceDungeonInfoItem.<LoadInstanceDungeonBottomTipTemplateItem>d__37 <LoadInstanceDungeonBottomTipTemplateItem>d__;
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>4__this = this;
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>1__state = -1;
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>t__builder.Start<InstanceDungeonInfoItem.<LoadInstanceDungeonBottomTipTemplateItem>d__37>(ref <LoadInstanceDungeonBottomTipTemplateItem>d__);
			return <LoadInstanceDungeonBottomTipTemplateItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602EA94 RID: 191124 RVA: 0x00D065C0 File Offset: 0x00D047C0
		private void InitInstanceDungeonBottomTipLayout()
		{
			if (this.InstanceDungeonBottomTipLayout != null)
			{
				return;
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(4);
			this.InstanceDungeonBottomTipLayout = new GenericLayout<InstanceDungeonBottomTipItem, InstanceDungeonBottomTipItemData>(verticalLayout, new Func<InstanceDungeonBottomTipItem>(this.CreateInstanceDungeonBottomTipItem), null, false, true);
		}

		// Token: 0x0602EA95 RID: 191125 RVA: 0x00D065F9 File Offset: 0x00D047F9
		[NullableContext(1)]
		private InstanceDungeonBottomTipItem CreateInstanceDungeonBottomTipItem()
		{
			return new InstanceDungeonBottomTipItem();
		}

		// Token: 0x0602EA96 RID: 191126 RVA: 0x00D06600 File Offset: 0x00D04800
		private void UpdateInstanceDungeonMowingDropDownItem(EDungeonSubType subType)
		{
			bool flag = subType == EDungeonSubType.Mowing;
			bool flag2 = InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(this.InstanceId);
			if (!flag || !flag2)
			{
				InstanceDungeonMowingDropDownItem instanceDungeonMowingDropDownItem = this.InstanceDungeonMowingDropDownItem;
				if (instanceDungeonMowingDropDownItem == null)
				{
					return;
				}
				instanceDungeonMowingDropDownItem.SetActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonMowingDropDownItem == null)
				{
					this.InstanceDungeonMowingDropDownItem = new InstanceDungeonMowingDropDownItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d <<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d;
						<<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d.<>4__this = this;
						<<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d.<>1__state = -1;
						<<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d.<>t__builder.Start<InstanceDungeonInfoItem.<<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d>(ref <<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d);
						return <<UpdateInstanceDungeonMowingDropDownItem>b__40_0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonMowingDropDownItem.SetActive(true);
				this.InstanceDungeonMowingDropDownItem.RefreshItem(this.InstanceId);
				return;
			}
		}

		// Token: 0x0602EA97 RID: 191127 RVA: 0x00D06684 File Offset: 0x00D04884
		public void SetMatchingItemActive(bool isShow)
		{
			bool flag = InstanceDungeonEntranceModel.Instance.CheckInstanceUnlock(this.InstanceId);
			InstanceDungeonStartButtonItem instanceDungeonStartButtonItem = this.InstanceDungeonStartButtonItem;
			if (instanceDungeonStartButtonItem != null)
			{
				instanceDungeonStartButtonItem.SetActive(!isShow && flag);
			}
			InstanceDungeonMatchingItem instanceDungeonMatchingItem = this.InstanceDungeonMatchingItem;
			if (instanceDungeonMatchingItem == null)
			{
				return;
			}
			instanceDungeonMatchingItem.SetActive(isShow);
		}

		// Token: 0x0602EA98 RID: 191128 RVA: 0x00D066CC File Offset: 0x00D048CC
		public void UpdateInstanceDungeonLockItemAndCostItem()
		{
			bool flag = InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching;
			InstanceDungeonTimeCountAndCostItem instanceDungeonTimeCountAndCostItem = this.InstanceDungeonTimeCountAndCostItem;
			if (instanceDungeonTimeCountAndCostItem != null)
			{
				instanceDungeonTimeCountAndCostItem.SetActive(false);
			}
			if (this.ParentModel.CheckInstanceUnlock(this.InstanceId))
			{
				this.UpdateInstanceDungeonTimeCountCostItem();
				this.InstanceDungeonStartButtonItem.SetActive(!flag);
				this.InstanceDungeonLockItem.SetActive(false);
				InstanceDungeonMatchingItem instanceDungeonMatchingItem = this.InstanceDungeonMatchingItem;
				if (instanceDungeonMatchingItem == null)
				{
					return;
				}
				instanceDungeonMatchingItem.SetActive(flag);
				return;
			}
			else
			{
				TableTextArgNew unlockConditionTextId = this.ParentModel.GetUnlockConditionTextId(this.InstanceId);
				if (unlockConditionTextId != null)
				{
					this.InstanceDungeonLockItem.RefreshItem(unlockConditionTextId);
				}
				this.InstanceDungeonStartButtonItem.SetActive(false);
				this.InstanceDungeonLockItem.SetActive(true);
				InstanceDungeonMatchingItem instanceDungeonMatchingItem2 = this.InstanceDungeonMatchingItem;
				if (instanceDungeonMatchingItem2 == null)
				{
					return;
				}
				instanceDungeonMatchingItem2.SetActive(false);
				return;
			}
		}

		// Token: 0x0602EA99 RID: 191129 RVA: 0x00D0678C File Offset: 0x00D0498C
		private void UpdateRogueBlackFlowerItem(InstanceDungeon dungeonConfig)
		{
			bool flag = dungeonConfig.InstSubType == 15;
			bool flag2 = RoguelikeModel.Instance.HasBlackFlowerExchanged(this.InstanceId);
			if (!flag || !flag2)
			{
				RoguelikeBlackFlowerInstanceItem rogueBlackFlowerItem = this.RogueBlackFlowerItem;
				if (rogueBlackFlowerItem == null)
				{
					return;
				}
				rogueBlackFlowerItem.SetActive(false);
				return;
			}
			else
			{
				if (this.RogueBlackFlowerItem == null)
				{
					this.RogueBlackFlowerItem = new RoguelikeBlackFlowerInstanceItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<<UpdateRogueBlackFlowerItem>b__43_0>d <<UpdateRogueBlackFlowerItem>b__43_0>d;
						<<UpdateRogueBlackFlowerItem>b__43_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateRogueBlackFlowerItem>b__43_0>d.<>4__this = this;
						<<UpdateRogueBlackFlowerItem>b__43_0>d.<>1__state = -1;
						<<UpdateRogueBlackFlowerItem>b__43_0>d.<>t__builder.Start<InstanceDungeonInfoItem.<<UpdateRogueBlackFlowerItem>b__43_0>d>(ref <<UpdateRogueBlackFlowerItem>b__43_0>d);
						return <<UpdateRogueBlackFlowerItem>b__43_0>d.<>t__builder.Task;
					});
					return;
				}
				this.RogueBlackFlowerItem.SetActive(true);
				return;
			}
		}

		// Token: 0x0602EA9A RID: 191130 RVA: 0x00D06804 File Offset: 0x00D04A04
		private void UpdatePictureItem(int uid)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass44_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass44_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dataGetter = InstanceDungeonEntranceController.Instance.GetPictureItemDataGetter(uid);
			if (CS$<>8__locals1.dataGetter == null)
			{
				InstanceDungeonPicItem instanceDungeonPicItem = this.InstanceDungeonPicItem;
				if (instanceDungeonPicItem == null)
				{
					return;
				}
				instanceDungeonPicItem.SetUiActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonPicItem == null)
				{
					this.InstanceDungeonPicItem = new InstanceDungeonPicItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass44_0.<<UpdatePictureItem>b__0>d <<UpdatePictureItem>b__0>d;
						<<UpdatePictureItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdatePictureItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdatePictureItem>b__0>d.<>1__state = -1;
						<<UpdatePictureItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass44_0.<<UpdatePictureItem>b__0>d>(ref <<UpdatePictureItem>b__0>d);
						return <<UpdatePictureItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonPicItem.SetUiActive(true);
				this.InstanceDungeonPicItem.RefreshItem(CS$<>8__locals1.dataGetter());
				return;
			}
		}

		// Token: 0x0602EA9B RID: 191131 RVA: 0x00D06898 File Offset: 0x00D04A98
		private void UpdateDescWidelyItem(int uid)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass45_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass45_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dataGetter = InstanceDungeonEntranceController.Instance.GetDescWidelyItemDataGetter(uid);
			if (CS$<>8__locals1.dataGetter == null)
			{
				InstanceDungeonDescWidelyItem instanceDungeonDescWidelyItem = this.InstanceDungeonDescWidelyItem;
				if (instanceDungeonDescWidelyItem == null)
				{
					return;
				}
				instanceDungeonDescWidelyItem.SetUiActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonDescWidelyItem == null)
				{
					this.InstanceDungeonDescWidelyItem = new InstanceDungeonDescWidelyItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass45_0.<<UpdateDescWidelyItem>b__0>d <<UpdateDescWidelyItem>b__0>d;
						<<UpdateDescWidelyItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateDescWidelyItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdateDescWidelyItem>b__0>d.<>1__state = -1;
						<<UpdateDescWidelyItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass45_0.<<UpdateDescWidelyItem>b__0>d>(ref <<UpdateDescWidelyItem>b__0>d);
						return <<UpdateDescWidelyItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonDescWidelyItem.SetUiActive(true);
				this.InstanceDungeonDescWidelyItem.RefreshItem(CS$<>8__locals1.dataGetter());
				return;
			}
		}

		// Token: 0x0602EA9C RID: 191132 RVA: 0x00D0692C File Offset: 0x00D04B2C
		private void UpdateTitleWidelyItem(int uid)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass46_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass46_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dataGetter = InstanceDungeonEntranceController.Instance.GetTitleWidelyItemDataGetter(uid);
			if (CS$<>8__locals1.dataGetter == null)
			{
				InstanceDungeonTitleWidelyItem instanceDungeonTitleWidelyItem = this.InstanceDungeonTitleWidelyItem;
				if (instanceDungeonTitleWidelyItem == null)
				{
					return;
				}
				instanceDungeonTitleWidelyItem.SetUiActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonTitleWidelyItem == null)
				{
					this.InstanceDungeonTitleWidelyItem = new InstanceDungeonTitleWidelyItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass46_0.<<UpdateTitleWidelyItem>b__0>d <<UpdateTitleWidelyItem>b__0>d;
						<<UpdateTitleWidelyItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateTitleWidelyItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdateTitleWidelyItem>b__0>d.<>1__state = -1;
						<<UpdateTitleWidelyItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass46_0.<<UpdateTitleWidelyItem>b__0>d>(ref <<UpdateTitleWidelyItem>b__0>d);
						return <<UpdateTitleWidelyItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonTitleWidelyItem.SetUiActive(true);
				this.InstanceDungeonTitleWidelyItem.RefreshItem(CS$<>8__locals1.dataGetter());
				return;
			}
		}

		// Token: 0x0602EA9D RID: 191133 RVA: 0x00D069C0 File Offset: 0x00D04BC0
		private void UpdateScoreListItem(int uid)
		{
			InstanceDungeonInfoItem.<>c__DisplayClass47_0 CS$<>8__locals1 = new InstanceDungeonInfoItem.<>c__DisplayClass47_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.dataGetter = InstanceDungeonEntranceController.Instance.GetScoreListItemDataGetter(uid);
			if (CS$<>8__locals1.dataGetter == null)
			{
				InstanceDungeonScoreListItem instanceDungeonScoreListItem = this.InstanceDungeonScoreListItem;
				if (instanceDungeonScoreListItem == null)
				{
					return;
				}
				instanceDungeonScoreListItem.SetUiActive(false);
				return;
			}
			else
			{
				if (this.InstanceDungeonScoreListItem == null)
				{
					this.InstanceDungeonScoreListItem = new InstanceDungeonScoreListItem();
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<>c__DisplayClass47_0.<<UpdateScoreListItem>b__0>d <<UpdateScoreListItem>b__0>d;
						<<UpdateScoreListItem>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateScoreListItem>b__0>d.<>4__this = CS$<>8__locals1;
						<<UpdateScoreListItem>b__0>d.<>1__state = -1;
						<<UpdateScoreListItem>b__0>d.<>t__builder.Start<InstanceDungeonInfoItem.<>c__DisplayClass47_0.<<UpdateScoreListItem>b__0>d>(ref <<UpdateScoreListItem>b__0>d);
						return <<UpdateScoreListItem>b__0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonScoreListItem.SetUiActive(true);
				this.InstanceDungeonScoreListItem.RefreshItem(CS$<>8__locals1.dataGetter());
				return;
			}
		}

		// Token: 0x0602EA9E RID: 191134 RVA: 0x00D06A54 File Offset: 0x00D04C54
		private void UpdateRankTimeItem(int instanceId)
		{
			if (this.ParentModel.RankItemModel == null)
			{
				InstanceDungeonRankTimeItem instanceDungeonRankTimeItem = this.InstanceDungeonRankTimeItem;
				if (instanceDungeonRankTimeItem == null)
				{
					return;
				}
				instanceDungeonRankTimeItem.SetUiActive(false);
				return;
			}
			else
			{
				this.ParentModel.RankItemModel.RefreshInstance(instanceId);
				if (this.InstanceDungeonRankTimeItem == null)
				{
					this.InstanceDungeonRankTimeItem = new InstanceDungeonRankTimeItem();
					this.InstanceDungeonRankTimeItem.OpenParam = this.ParentModel.RankItemModel;
					this.LoadList.Add(delegate
					{
						InstanceDungeonInfoItem.<<UpdateRankTimeItem>b__48_0>d <<UpdateRankTimeItem>b__48_0>d;
						<<UpdateRankTimeItem>b__48_0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
						<<UpdateRankTimeItem>b__48_0>d.<>4__this = this;
						<<UpdateRankTimeItem>b__48_0>d.<>1__state = -1;
						<<UpdateRankTimeItem>b__48_0>d.<>t__builder.Start<InstanceDungeonInfoItem.<<UpdateRankTimeItem>b__48_0>d>(ref <<UpdateRankTimeItem>b__48_0>d);
						return <<UpdateRankTimeItem>b__48_0>d.<>t__builder.Task;
					});
					return;
				}
				this.InstanceDungeonRankTimeItem.SetUiActive(true);
				this.InstanceDungeonRankTimeItem.Refresh();
				return;
			}
		}

		// Token: 0x0602EA9F RID: 191135 RVA: 0x00D06AE9 File Offset: 0x00D04CE9
		[NullableContext(1)]
		public void SetLockText(string lockText)
		{
			this.InstanceDungeonLockItem.SetActive(true);
			this.InstanceDungeonLockItem.SetLockText(lockText);
		}

		// Token: 0x0602EAA0 RID: 191136 RVA: 0x00D06B04 File Offset: 0x00D04D04
		private void OnRefreshInstancedRecommendLevel()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			if (config == null)
			{
				return;
			}
			this.UpdateInstanceDungeonRecommendLevelItem((EDungeonSubType)config.Value.InstSubType);
		}

		// Token: 0x04018CEB RID: 101611
		private int InstanceId;

		// Token: 0x04018CEC RID: 101612
		private InstanceDungeonRightTitleItem InstanceDungeonRightTitleItem;

		// Token: 0x04018CED RID: 101613
		private InstanceDungeonBuffItem InstanceDungeonBuffItem;

		// Token: 0x04018CEE RID: 101614
		private InstanceDungeonEntranceTowerDefenceItem InstanceDungeonEntranceTowerDefenceItem;

		// Token: 0x04018CEF RID: 101615
		private InstanceDungeonRecommendLevelItem InstanceDungeonRecommendLevelItem;

		// Token: 0x04018CF0 RID: 101616
		private InstanceDungeonCostItem InstanceDungeonCostItem;

		// Token: 0x04018CF1 RID: 101617
		private InstanceDungeonTimeCountAndCostItem InstanceDungeonTimeCountAndCostItem;

		// Token: 0x04018CF2 RID: 101618
		private InstanceDungeonEntranceRewardItem InstanceDungeonEntranceRewardItem;

		// Token: 0x04018CF3 RID: 101619
		private InstanceDungeonMowingDropDownItem InstanceDungeonMowingDropDownItem;

		// Token: 0x04018CF4 RID: 101620
		private InstanceDungeonStartButtonItem InstanceDungeonStartButtonItem;

		// Token: 0x04018CF5 RID: 101621
		private InstanceDungeonMatchingItem InstanceDungeonMatchingItem;

		// Token: 0x04018CF6 RID: 101622
		private InstanceDungeonLockItem InstanceDungeonLockItem;

		// Token: 0x04018CF7 RID: 101623
		private RoguelikeBlackFlowerInstanceItem RogueBlackFlowerItem;

		// Token: 0x04018CF8 RID: 101624
		private UUIItem LineItem;

		// Token: 0x04018CF9 RID: 101625
		private InstanceDungeonBottomTipItem InstanceDungeonBottomTipTemplateItem;

		// Token: 0x04018CFA RID: 101626
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InstanceDungeonBottomTipItem, InstanceDungeonBottomTipItemData> InstanceDungeonBottomTipLayout;

		// Token: 0x04018CFB RID: 101627
		private InstanceDungeonPicItem InstanceDungeonPicItem;

		// Token: 0x04018CFC RID: 101628
		private InstanceDungeonDescWidelyItem InstanceDungeonDescWidelyItem;

		// Token: 0x04018CFD RID: 101629
		private InstanceDungeonTitleWidelyItem InstanceDungeonTitleWidelyItem;

		// Token: 0x04018CFE RID: 101630
		private InstanceDungeonScoreListItem InstanceDungeonScoreListItem;

		// Token: 0x04018CFF RID: 101631
		private InstanceDungeonRankTimeItem InstanceDungeonRankTimeItem;

		// Token: 0x04018D00 RID: 101632
		[Nullable(1)]
		private List<Func<UniTask>> LoadList = new List<Func<UniTask>>();

		// Token: 0x04018D01 RID: 101633
		[Nullable(1)]
		private InstanceDungeonViewModelBase ParentModel;

		// Token: 0x0200A50D RID: 42253
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040331CE RID: 209358
			TopItem,
			// Token: 0x040331CF RID: 209359
			BottomItem,
			// Token: 0x040331D0 RID: 209360
			ButtonItem,
			// Token: 0x040331D1 RID: 209361
			RewardItem,
			// Token: 0x040331D2 RID: 209362
			BottomTipLayout
		}
	}
}
