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
	// Token: 0x0200589B RID: 22683
	[NullableContext(2)]
	[Nullable(0)]
	public class InstanceDungeonInfoItem : UiPanelBase
	{
		// Token: 0x06039B63 RID: 236387 RVA: 0x00DB6E78 File Offset: 0x00DB5078
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

		// Token: 0x06039B64 RID: 236388 RVA: 0x00DB6F64 File Offset: 0x00DB5164
		protected override UniTask OnBeforeStartAsync()
		{
			InstanceDungeonInfoItem.<OnBeforeStartAsync>d__25 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InstanceDungeonInfoItem.<OnBeforeStartAsync>d__25>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039B65 RID: 236389 RVA: 0x00DB6FA7 File Offset: 0x00DB51A7
		protected override void OnStart()
		{
			EventSystem.Instance.Add(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x06039B66 RID: 236390 RVA: 0x00DB6FC5 File Offset: 0x00DB51C5
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRefreshInstancedRecommendLevel, new Action(this.OnRefreshInstancedRecommendLevel));
		}

		// Token: 0x06039B67 RID: 236391 RVA: 0x00DB6FE3 File Offset: 0x00DB51E3
		[NullableContext(1)]
		public void InitButton(Action onClickBtnSoloCallBack, Action onClickBtnMultipleCallBack, Action onClickBtnTeamCallBack)
		{
			this.InstanceDungeonStartButtonItem.OnClickBtnSoloCallBack = onClickBtnSoloCallBack;
			this.InstanceDungeonStartButtonItem.OnClickBtnMultipleCallBack = onClickBtnMultipleCallBack;
			this.InstanceDungeonStartButtonItem.OnClickBtnTeamCallBack = onClickBtnTeamCallBack;
		}

		// Token: 0x06039B68 RID: 236392 RVA: 0x00DB700C File Offset: 0x00DB520C
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

		// Token: 0x06039B69 RID: 236393 RVA: 0x00DB7058 File Offset: 0x00DB5258
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

		// Token: 0x06039B6A RID: 236394 RVA: 0x00DB7120 File Offset: 0x00DB5320
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

		// Token: 0x06039B6B RID: 236395 RVA: 0x00DB71B4 File Offset: 0x00DB53B4
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

		// Token: 0x06039B6C RID: 236396 RVA: 0x00DB7224 File Offset: 0x00DB5424
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

		// Token: 0x06039B6D RID: 236397 RVA: 0x00DB735C File Offset: 0x00DB555C
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

		// Token: 0x06039B6E RID: 236398 RVA: 0x00DB749C File Offset: 0x00DB569C
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

		// Token: 0x06039B6F RID: 236399 RVA: 0x00DB7520 File Offset: 0x00DB5720
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

		// Token: 0x06039B70 RID: 236400 RVA: 0x00DB7664 File Offset: 0x00DB5864
		private UniTask LoadInstanceDungeonBottomTipTemplateItem()
		{
			InstanceDungeonInfoItem.<LoadInstanceDungeonBottomTipTemplateItem>d__37 <LoadInstanceDungeonBottomTipTemplateItem>d__;
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>4__this = this;
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>1__state = -1;
			<LoadInstanceDungeonBottomTipTemplateItem>d__.<>t__builder.Start<InstanceDungeonInfoItem.<LoadInstanceDungeonBottomTipTemplateItem>d__37>(ref <LoadInstanceDungeonBottomTipTemplateItem>d__);
			return <LoadInstanceDungeonBottomTipTemplateItem>d__.<>t__builder.Task;
		}

		// Token: 0x06039B71 RID: 236401 RVA: 0x00DB76A8 File Offset: 0x00DB58A8
		private void InitInstanceDungeonBottomTipLayout()
		{
			if (this.InstanceDungeonBottomTipLayout != null)
			{
				return;
			}
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(4);
			this.InstanceDungeonBottomTipLayout = new GenericLayout<InstanceDungeonBottomTipItem, InstanceDungeonBottomTipItemData>(verticalLayout, new Func<InstanceDungeonBottomTipItem>(this.CreateInstanceDungeonBottomTipItem), null, false, true);
		}

		// Token: 0x06039B72 RID: 236402 RVA: 0x00DB76E1 File Offset: 0x00DB58E1
		[NullableContext(1)]
		private InstanceDungeonBottomTipItem CreateInstanceDungeonBottomTipItem()
		{
			return new InstanceDungeonBottomTipItem();
		}

		// Token: 0x06039B73 RID: 236403 RVA: 0x00DB76E8 File Offset: 0x00DB58E8
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

		// Token: 0x06039B74 RID: 236404 RVA: 0x00DB776C File Offset: 0x00DB596C
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

		// Token: 0x06039B75 RID: 236405 RVA: 0x00DB77B4 File Offset: 0x00DB59B4
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

		// Token: 0x06039B76 RID: 236406 RVA: 0x00DB7874 File Offset: 0x00DB5A74
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

		// Token: 0x06039B77 RID: 236407 RVA: 0x00DB78EC File Offset: 0x00DB5AEC
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

		// Token: 0x06039B78 RID: 236408 RVA: 0x00DB7980 File Offset: 0x00DB5B80
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

		// Token: 0x06039B79 RID: 236409 RVA: 0x00DB7A14 File Offset: 0x00DB5C14
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

		// Token: 0x06039B7A RID: 236410 RVA: 0x00DB7AA8 File Offset: 0x00DB5CA8
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

		// Token: 0x06039B7B RID: 236411 RVA: 0x00DB7B3C File Offset: 0x00DB5D3C
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

		// Token: 0x06039B7C RID: 236412 RVA: 0x00DB7BD1 File Offset: 0x00DB5DD1
		[NullableContext(1)]
		public void SetLockText(string lockText)
		{
			this.InstanceDungeonLockItem.SetActive(true);
			this.InstanceDungeonLockItem.SetLockText(lockText);
		}

		// Token: 0x06039B7D RID: 236413 RVA: 0x00DB7BEC File Offset: 0x00DB5DEC
		private void OnRefreshInstancedRecommendLevel()
		{
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(this.InstanceId);
			if (config == null)
			{
				return;
			}
			this.UpdateInstanceDungeonRecommendLevelItem((EDungeonSubType)config.Value.InstSubType);
		}

		// Token: 0x0401E24E RID: 123470
		private int InstanceId;

		// Token: 0x0401E24F RID: 123471
		private InstanceDungeonRightTitleItem InstanceDungeonRightTitleItem;

		// Token: 0x0401E250 RID: 123472
		private InstanceDungeonBuffItem InstanceDungeonBuffItem;

		// Token: 0x0401E251 RID: 123473
		private InstanceDungeonEntranceTowerDefenceItem InstanceDungeonEntranceTowerDefenceItem;

		// Token: 0x0401E252 RID: 123474
		private InstanceDungeonRecommendLevelItem InstanceDungeonRecommendLevelItem;

		// Token: 0x0401E253 RID: 123475
		private InstanceDungeonCostItem InstanceDungeonCostItem;

		// Token: 0x0401E254 RID: 123476
		private InstanceDungeonTimeCountAndCostItem InstanceDungeonTimeCountAndCostItem;

		// Token: 0x0401E255 RID: 123477
		private InstanceDungeonEntranceRewardItem InstanceDungeonEntranceRewardItem;

		// Token: 0x0401E256 RID: 123478
		private InstanceDungeonMowingDropDownItem InstanceDungeonMowingDropDownItem;

		// Token: 0x0401E257 RID: 123479
		private InstanceDungeonStartButtonItem InstanceDungeonStartButtonItem;

		// Token: 0x0401E258 RID: 123480
		private InstanceDungeonMatchingItem InstanceDungeonMatchingItem;

		// Token: 0x0401E259 RID: 123481
		private InstanceDungeonLockItem InstanceDungeonLockItem;

		// Token: 0x0401E25A RID: 123482
		private RoguelikeBlackFlowerInstanceItem RogueBlackFlowerItem;

		// Token: 0x0401E25B RID: 123483
		private UUIItem LineItem;

		// Token: 0x0401E25C RID: 123484
		private InstanceDungeonBottomTipItem InstanceDungeonBottomTipTemplateItem;

		// Token: 0x0401E25D RID: 123485
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<InstanceDungeonBottomTipItem, InstanceDungeonBottomTipItemData> InstanceDungeonBottomTipLayout;

		// Token: 0x0401E25E RID: 123486
		private InstanceDungeonPicItem InstanceDungeonPicItem;

		// Token: 0x0401E25F RID: 123487
		private InstanceDungeonDescWidelyItem InstanceDungeonDescWidelyItem;

		// Token: 0x0401E260 RID: 123488
		private InstanceDungeonTitleWidelyItem InstanceDungeonTitleWidelyItem;

		// Token: 0x0401E261 RID: 123489
		private InstanceDungeonScoreListItem InstanceDungeonScoreListItem;

		// Token: 0x0401E262 RID: 123490
		private InstanceDungeonRankTimeItem InstanceDungeonRankTimeItem;

		// Token: 0x0401E263 RID: 123491
		[Nullable(1)]
		private List<Func<UniTask>> LoadList = new List<Func<UniTask>>();

		// Token: 0x0401E264 RID: 123492
		[Nullable(1)]
		private InstanceDungeonViewModelBase ParentModel;

		// Token: 0x0200BAF4 RID: 47860
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040387CD RID: 231373
			TopItem,
			// Token: 0x040387CE RID: 231374
			BottomItem,
			// Token: 0x040387CF RID: 231375
			ButtonItem,
			// Token: 0x040387D0 RID: 231376
			RewardItem,
			// Token: 0x040387D1 RID: 231377
			BottomTipLayout
		}
	}
}
