using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x02005214 RID: 21012
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailItem : UiPanelBase
	{
		// Token: 0x06035BBB RID: 220091 RVA: 0x00CB8740 File Offset: 0x00CB6940
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIMultiTemplateLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIText)),
				new ValueTuple<int, Type>(13, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem))
			};
		}

		// Token: 0x06035BBC RID: 220092 RVA: 0x00CB891C File Offset: 0x00CB6B1C
		private UniTask InitTaskItem()
		{
			CardDetailItem.<InitTaskItem>d__10 <InitTaskItem>d__;
			<InitTaskItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTaskItem>d__.<>4__this = this;
			<InitTaskItem>d__.<>1__state = -1;
			<InitTaskItem>d__.<>t__builder.Start<CardDetailItem.<InitTaskItem>d__10>(ref <InitTaskItem>d__);
			return <InitTaskItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035BBD RID: 220093 RVA: 0x00CB8960 File Offset: 0x00CB6B60
		private UniTask InitActiveSkillItem()
		{
			CardDetailItem.<InitActiveSkillItem>d__11 <InitActiveSkillItem>d__;
			<InitActiveSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitActiveSkillItem>d__.<>4__this = this;
			<InitActiveSkillItem>d__.<>1__state = -1;
			<InitActiveSkillItem>d__.<>t__builder.Start<CardDetailItem.<InitActiveSkillItem>d__11>(ref <InitActiveSkillItem>d__);
			return <InitActiveSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035BBE RID: 220094 RVA: 0x00CB89A4 File Offset: 0x00CB6BA4
		private UniTask InitPassiveSkillItem()
		{
			CardDetailItem.<InitPassiveSkillItem>d__12 <InitPassiveSkillItem>d__;
			<InitPassiveSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPassiveSkillItem>d__.<>4__this = this;
			<InitPassiveSkillItem>d__.<>1__state = -1;
			<InitPassiveSkillItem>d__.<>t__builder.Start<CardDetailItem.<InitPassiveSkillItem>d__12>(ref <InitPassiveSkillItem>d__);
			return <InitPassiveSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035BBF RID: 220095 RVA: 0x00CB89E8 File Offset: 0x00CB6BE8
		private UniTask InitLockItem()
		{
			CardDetailItem.<InitLockItem>d__13 <InitLockItem>d__;
			<InitLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLockItem>d__.<>4__this = this;
			<InitLockItem>d__.<>1__state = -1;
			<InitLockItem>d__.<>t__builder.Start<CardDetailItem.<InitLockItem>d__13>(ref <InitLockItem>d__);
			return <InitLockItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035BC0 RID: 220096 RVA: 0x00CB8A2C File Offset: 0x00CB6C2C
		private UniTask InitDurationItem()
		{
			CardDetailItem.<InitDurationItem>d__14 <InitDurationItem>d__;
			<InitDurationItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDurationItem>d__.<>4__this = this;
			<InitDurationItem>d__.<>1__state = -1;
			<InitDurationItem>d__.<>t__builder.Start<CardDetailItem.<InitDurationItem>d__14>(ref <InitDurationItem>d__);
			return <InitDurationItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035BC1 RID: 220097 RVA: 0x00CB8A70 File Offset: 0x00CB6C70
		private UniTask InitRemainRoundItem()
		{
			CardDetailItem.<InitRemainRoundItem>d__15 <InitRemainRoundItem>d__;
			<InitRemainRoundItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRemainRoundItem>d__.<>4__this = this;
			<InitRemainRoundItem>d__.<>1__state = -1;
			<InitRemainRoundItem>d__.<>t__builder.Start<CardDetailItem.<InitRemainRoundItem>d__15>(ref <InitRemainRoundItem>d__);
			return <InitRemainRoundItem>d__.<>t__builder.Task;
		}

		// Token: 0x06035BC2 RID: 220098 RVA: 0x00CB8AB4 File Offset: 0x00CB6CB4
		protected override UniTask OnBeforeStartAsync()
		{
			CardDetailItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CardDetailItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035BC3 RID: 220099 RVA: 0x00CB8AF8 File Offset: 0x00CB6CF8
		protected override void OnStart()
		{
			this.AttributeLayout = new CardDetailAttributeLayoutItem(base.GetMultiTemplateLayout(1), base.GetItem(2));
			this.FactorDescLayout = new CardDetailFactorDescLayoutItem(base.GetLayoutBase(6), base.GetItem(7));
			base.GetItem(19).SetUIActive(false);
		}

		// Token: 0x06035BC4 RID: 220100 RVA: 0x00CB8B48 File Offset: 0x00CB6D48
		public void Refresh(CardDetailItemData data)
		{
			this.Data = data;
			this.RefreshName();
			this.RefreshAttributeLayout(data.AttributeData);
			this.RefreshCardDesc(data.CardDescriptionData);
			this.RefreshFactorDescLayout(data.FactorDataList);
			this.RefreshBgDescription();
			this.RefreshTask(data.TaskData);
			this.RefreshActiveSkill(data.ActiveSkillData);
			this.RefreshPassiveSkill(data.PassiveSkillData);
			this.RefreshLock(data.LockData);
			this.RefreshDuration(data.DurationData);
			this.RefreshRemainRound(data.RemainRoundData);
		}

		// Token: 0x06035BC5 RID: 220101 RVA: 0x00CB8BD4 File Offset: 0x00CB6DD4
		public void RefreshName()
		{
			if (this.Data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.Name, Array.Empty<object>());
		}

		// Token: 0x06035BC6 RID: 220102 RVA: 0x00CB8C00 File Offset: 0x00CB6E00
		public void RefreshAttributeLayout(ICardAttributeData attributeData)
		{
			if (attributeData == null)
			{
				CardDetailAttributeLayoutItem attributeLayout = this.AttributeLayout;
				if (attributeLayout == null)
				{
					return;
				}
				attributeLayout.SetLayoutActive(false);
				return;
			}
			else
			{
				CardDetailAttributeItemData item = new CardDetailAttributeItemData
				{
					AttributeName = "PhantomBattle_1001",
					AttributeValue = attributeData.Cost,
					IsHighLight = true
				};
				CardDetailAttributeItemData item2 = new CardDetailAttributeItemData
				{
					AttributeName = "PhantomBattle_1002",
					AttributeValue = attributeData.Attack,
					IsHighLight = false
				};
				CardDetailAttributeItemData item3 = new CardDetailAttributeItemData
				{
					AttributeName = "PhantomBattle_1003",
					AttributeValue = attributeData.Life,
					IsHighLight = false
				};
				List<CardDetailAttributeItemData> dataList = new List<CardDetailAttributeItemData>
				{
					item,
					item2,
					item3
				};
				CardDetailAttributeLayoutItem attributeLayout2 = this.AttributeLayout;
				if (attributeLayout2 != null)
				{
					attributeLayout2.SetLayoutActive(true);
				}
				CardDetailAttributeLayoutItem attributeLayout3 = this.AttributeLayout;
				if (attributeLayout3 == null)
				{
					return;
				}
				attributeLayout3.Refresh(dataList);
				return;
			}
		}

		// Token: 0x06035BC7 RID: 220103 RVA: 0x00CB8CCC File Offset: 0x00CB6ECC
		public void RefreshCardDesc(ICardDescriptionData cardDescriptionData)
		{
			if (cardDescriptionData == null)
			{
				base.GetItem(3).SetUIActive(false);
				base.GetItem(4).SetUIActive(false);
				return;
			}
			base.GetItem(3).SetUIActive(true);
			base.GetItem(4).SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), cardDescriptionData.Description, cardDescriptionData.DescriptionParams.ToArray());
		}

		// Token: 0x06035BC8 RID: 220104 RVA: 0x00CB8D34 File Offset: 0x00CB6F34
		public void RefreshFactorDescLayout(List<CardDetailFactorDescItemData> factorDataList)
		{
			if (factorDataList == null)
			{
				CardDetailFactorDescLayoutItem factorDescLayout = this.FactorDescLayout;
				if (factorDescLayout != null)
				{
					factorDescLayout.SetLayoutActive(false);
				}
				base.GetItem(8).SetUIActive(false);
				return;
			}
			bool flag = factorDataList.Count > 0;
			base.GetItem(8).SetUIActive(flag);
			base.GetLayoutBase(6).RootUIComp.Get().SetUIActive(flag);
			if (flag)
			{
				CardDetailFactorDescLayoutItem factorDescLayout2 = this.FactorDescLayout;
				if (factorDescLayout2 != null)
				{
					factorDescLayout2.SetLayoutActive(true);
				}
				CardDetailFactorDescLayoutItem factorDescLayout3 = this.FactorDescLayout;
				if (factorDescLayout3 == null)
				{
					return;
				}
				factorDescLayout3.Refresh(factorDataList);
			}
		}

		// Token: 0x06035BC9 RID: 220105 RVA: 0x00CB8DBC File Offset: 0x00CB6FBC
		public void RefreshBgDescription()
		{
			if (this.Data == null)
			{
				return;
			}
			string bgDescription = this.Data.BgDescription;
			if (bgDescription != null && !StringUtils.IsBlank(bgDescription))
			{
				base.GetItem(10).SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), bgDescription, Array.Empty<object>());
				return;
			}
			base.GetItem(10).SetUIActive(false);
		}

		// Token: 0x06035BCA RID: 220106 RVA: 0x00CB8E24 File Offset: 0x00CB7024
		private void RefreshTask(ICardDetailTaskData taskData)
		{
			if (taskData == null)
			{
				base.GetItem(11).SetUIActive(false);
				base.GetLayoutBase(13).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetItem(11).SetUIActive(true);
			base.GetLayoutBase(13).RootUIComp.Get().SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "PhantomBattle_1081", Array.Empty<object>());
			CardDetailTaskDescItem taskDescItem = this.TaskDescItem;
			if (taskDescItem == null)
			{
				return;
			}
			taskDescItem.Refresh(taskData);
		}

		// Token: 0x06035BCB RID: 220107 RVA: 0x00CB8EB4 File Offset: 0x00CB70B4
		private void RefreshActiveSkill(ICardDetailActiveSkillData activeSkillData)
		{
			if (activeSkillData == null)
			{
				base.GetItem(15).SetUIActive(false);
				return;
			}
			base.GetItem(15).SetUIActive(true);
			CardDetailActiveSkillItem activeSkillItem = this.ActiveSkillItem;
			if (activeSkillItem == null)
			{
				return;
			}
			activeSkillItem.Refresh(activeSkillData);
		}

		// Token: 0x06035BCC RID: 220108 RVA: 0x00CB8EE7 File Offset: 0x00CB70E7
		private void RefreshPassiveSkill(ICardDetailPassiveSkillData passiveSkillData)
		{
			if (passiveSkillData == null)
			{
				base.GetItem(16).SetUIActive(false);
				return;
			}
			base.GetItem(16).SetUIActive(true);
			CardDetailPassiveSkillItem passiveSkillItem = this.PassiveSkillItem;
			if (passiveSkillItem == null)
			{
				return;
			}
			passiveSkillItem.Refresh(passiveSkillData);
		}

		// Token: 0x06035BCD RID: 220109 RVA: 0x00CB8F1A File Offset: 0x00CB711A
		private void RefreshLock(ICardDetailLockData lockData)
		{
			if (lockData == null)
			{
				base.GetItem(17).SetUIActive(false);
				return;
			}
			base.GetItem(17).SetUIActive(true);
			CardDetailLockItem lockItem = this.LockItem;
			if (lockItem == null)
			{
				return;
			}
			lockItem.Refresh(lockData);
		}

		// Token: 0x06035BCE RID: 220110 RVA: 0x00CB8F4D File Offset: 0x00CB714D
		private void RefreshDuration(ICardDetailDurationData durationData)
		{
			if (durationData == null)
			{
				base.GetItem(18).SetUIActive(false);
				return;
			}
			base.GetItem(18).SetUIActive(true);
			CardDetailDurationItem durationItem = this.DurationItem;
			if (durationItem == null)
			{
				return;
			}
			durationItem.Refresh(durationData);
		}

		// Token: 0x06035BCF RID: 220111 RVA: 0x00CB8F80 File Offset: 0x00CB7180
		private void RefreshRemainRound(ICardDetailRemainRoundData remainRoundData)
		{
			if (remainRoundData == null)
			{
				base.GetItem(19).SetUIActive(false);
				return;
			}
			base.GetItem(19).SetUIActive(true);
			CardDetailRemainRoundItem remainRoundItem = this.RemainRoundItem;
			if (remainRoundItem == null)
			{
				return;
			}
			remainRoundItem.Refresh(remainRoundData);
		}

		// Token: 0x06035BD0 RID: 220112 RVA: 0x00CB8FB4 File Offset: 0x00CB71B4
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "CardEffect")
			{
				CardDetailFactorDescLayoutItem factorDescLayout = this.FactorDescLayout;
				if (factorDescLayout == null)
				{
					return null;
				}
				return factorDescLayout.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else if (a == "CardAttr")
			{
				UUIMultiTemplateLayout multiTemplateLayout = base.GetMultiTemplateLayout(1);
				UUIItem uuiitem = (multiTemplateLayout != null) ? multiTemplateLayout.GetRootComponent() : null;
				if (uuiitem == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem,
					uuiitem
				};
			}
			else
			{
				if (!(a == "Task"))
				{
					return null;
				}
				CardDetailTaskDescItem taskDescItem = this.TaskDescItem;
				UUIItem uuiitem2 = (taskDescItem != null) ? taskDescItem.GetRootItem() : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
		}

		// Token: 0x0401C7BD RID: 116669
		private CardDetailItemData Data;

		// Token: 0x0401C7BE RID: 116670
		private CardDetailAttributeLayoutItem AttributeLayout;

		// Token: 0x0401C7BF RID: 116671
		private CardDetailFactorDescLayoutItem FactorDescLayout;

		// Token: 0x0401C7C0 RID: 116672
		private CardDetailTaskDescItem TaskDescItem;

		// Token: 0x0401C7C1 RID: 116673
		private CardDetailActiveSkillItem ActiveSkillItem;

		// Token: 0x0401C7C2 RID: 116674
		private CardDetailPassiveSkillItem PassiveSkillItem;

		// Token: 0x0401C7C3 RID: 116675
		private CardDetailLockItem LockItem;

		// Token: 0x0401C7C4 RID: 116676
		private CardDetailDurationItem DurationItem;

		// Token: 0x0401C7C5 RID: 116677
		private CardDetailRemainRoundItem RemainRoundItem;

		// Token: 0x0200B3B0 RID: 46000
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036756 RID: 223062
			public const int NameText = 0;

			// Token: 0x04036757 RID: 223063
			public const int AttributeLayout = 1;

			// Token: 0x04036758 RID: 223064
			public const int AttributeItem = 2;

			// Token: 0x04036759 RID: 223065
			public const int CardDescTitleItem = 3;

			// Token: 0x0403675A RID: 223066
			public const int CardDescItem = 4;

			// Token: 0x0403675B RID: 223067
			public const int CardDescText = 5;

			// Token: 0x0403675C RID: 223068
			public const int FactorDescLayout = 6;

			// Token: 0x0403675D RID: 223069
			public const int FactorDescItem = 7;

			// Token: 0x0403675E RID: 223070
			public const int FactorTitleItem = 8;

			// Token: 0x0403675F RID: 223071
			public const int BgDescText = 9;

			// Token: 0x04036760 RID: 223072
			public const int BgDescRootItem = 10;

			// Token: 0x04036761 RID: 223073
			public const int TaskTitleItem = 11;

			// Token: 0x04036762 RID: 223074
			public const int TaskTitleText = 12;

			// Token: 0x04036763 RID: 223075
			public const int TaskDescLayout = 13;

			// Token: 0x04036764 RID: 223076
			public const int TaskDescItem = 14;

			// Token: 0x04036765 RID: 223077
			public const int ActiveSkillItem = 15;

			// Token: 0x04036766 RID: 223078
			public const int PassiveSkillItem = 16;

			// Token: 0x04036767 RID: 223079
			public const int LockItem = 17;

			// Token: 0x04036768 RID: 223080
			public const int DurationItem = 18;

			// Token: 0x04036769 RID: 223081
			public const int RemainRoundItem = 19;
		}
	}
}
