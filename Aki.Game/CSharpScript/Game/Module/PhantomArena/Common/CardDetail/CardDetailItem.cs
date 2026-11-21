using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardDetail
{
	// Token: 0x020041E4 RID: 16868
	[NullableContext(1)]
	[Nullable(0)]
	public class CardDetailItem : UiPanelBase
	{
		// Token: 0x0602AAB6 RID: 174774 RVA: 0x00C05D84 File Offset: 0x00C03F84
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

		// Token: 0x0602AAB7 RID: 174775 RVA: 0x00C05F60 File Offset: 0x00C04160
		private UniTask InitTaskItem()
		{
			CardDetailItem.<InitTaskItem>d__10 <InitTaskItem>d__;
			<InitTaskItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitTaskItem>d__.<>4__this = this;
			<InitTaskItem>d__.<>1__state = -1;
			<InitTaskItem>d__.<>t__builder.Start<CardDetailItem.<InitTaskItem>d__10>(ref <InitTaskItem>d__);
			return <InitTaskItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AAB8 RID: 174776 RVA: 0x00C05FA4 File Offset: 0x00C041A4
		private UniTask InitActiveSkillItem()
		{
			CardDetailItem.<InitActiveSkillItem>d__11 <InitActiveSkillItem>d__;
			<InitActiveSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitActiveSkillItem>d__.<>4__this = this;
			<InitActiveSkillItem>d__.<>1__state = -1;
			<InitActiveSkillItem>d__.<>t__builder.Start<CardDetailItem.<InitActiveSkillItem>d__11>(ref <InitActiveSkillItem>d__);
			return <InitActiveSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AAB9 RID: 174777 RVA: 0x00C05FE8 File Offset: 0x00C041E8
		private UniTask InitPassiveSkillItem()
		{
			CardDetailItem.<InitPassiveSkillItem>d__12 <InitPassiveSkillItem>d__;
			<InitPassiveSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPassiveSkillItem>d__.<>4__this = this;
			<InitPassiveSkillItem>d__.<>1__state = -1;
			<InitPassiveSkillItem>d__.<>t__builder.Start<CardDetailItem.<InitPassiveSkillItem>d__12>(ref <InitPassiveSkillItem>d__);
			return <InitPassiveSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AABA RID: 174778 RVA: 0x00C0602C File Offset: 0x00C0422C
		private UniTask InitLockItem()
		{
			CardDetailItem.<InitLockItem>d__13 <InitLockItem>d__;
			<InitLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLockItem>d__.<>4__this = this;
			<InitLockItem>d__.<>1__state = -1;
			<InitLockItem>d__.<>t__builder.Start<CardDetailItem.<InitLockItem>d__13>(ref <InitLockItem>d__);
			return <InitLockItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AABB RID: 174779 RVA: 0x00C06070 File Offset: 0x00C04270
		private UniTask InitDurationItem()
		{
			CardDetailItem.<InitDurationItem>d__14 <InitDurationItem>d__;
			<InitDurationItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDurationItem>d__.<>4__this = this;
			<InitDurationItem>d__.<>1__state = -1;
			<InitDurationItem>d__.<>t__builder.Start<CardDetailItem.<InitDurationItem>d__14>(ref <InitDurationItem>d__);
			return <InitDurationItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AABC RID: 174780 RVA: 0x00C060B4 File Offset: 0x00C042B4
		private UniTask InitRemainRoundItem()
		{
			CardDetailItem.<InitRemainRoundItem>d__15 <InitRemainRoundItem>d__;
			<InitRemainRoundItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitRemainRoundItem>d__.<>4__this = this;
			<InitRemainRoundItem>d__.<>1__state = -1;
			<InitRemainRoundItem>d__.<>t__builder.Start<CardDetailItem.<InitRemainRoundItem>d__15>(ref <InitRemainRoundItem>d__);
			return <InitRemainRoundItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AABD RID: 174781 RVA: 0x00C060F8 File Offset: 0x00C042F8
		protected override UniTask OnBeforeStartAsync()
		{
			CardDetailItem.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CardDetailItem.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AABE RID: 174782 RVA: 0x00C0613C File Offset: 0x00C0433C
		protected override void OnStart()
		{
			this.AttributeLayout = new CardDetailAttributeLayoutItem(base.GetMultiTemplateLayout(1), base.GetItem(2));
			this.FactorDescLayout = new CardDetailFactorDescLayoutItem(base.GetLayoutBase(6), base.GetItem(7));
			base.GetItem(19).SetUIActive(false);
		}

		// Token: 0x0602AABF RID: 174783 RVA: 0x00C0618C File Offset: 0x00C0438C
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

		// Token: 0x0602AAC0 RID: 174784 RVA: 0x00C06218 File Offset: 0x00C04418
		public void RefreshName()
		{
			if (this.Data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.Name, Array.Empty<object>());
		}

		// Token: 0x0602AAC1 RID: 174785 RVA: 0x00C06244 File Offset: 0x00C04444
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

		// Token: 0x0602AAC2 RID: 174786 RVA: 0x00C06310 File Offset: 0x00C04510
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

		// Token: 0x0602AAC3 RID: 174787 RVA: 0x00C06378 File Offset: 0x00C04578
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

		// Token: 0x0602AAC4 RID: 174788 RVA: 0x00C06400 File Offset: 0x00C04600
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

		// Token: 0x0602AAC5 RID: 174789 RVA: 0x00C06468 File Offset: 0x00C04668
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

		// Token: 0x0602AAC6 RID: 174790 RVA: 0x00C064F8 File Offset: 0x00C046F8
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

		// Token: 0x0602AAC7 RID: 174791 RVA: 0x00C0652B File Offset: 0x00C0472B
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

		// Token: 0x0602AAC8 RID: 174792 RVA: 0x00C0655E File Offset: 0x00C0475E
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

		// Token: 0x0602AAC9 RID: 174793 RVA: 0x00C06591 File Offset: 0x00C04791
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

		// Token: 0x0602AACA RID: 174794 RVA: 0x00C065C4 File Offset: 0x00C047C4
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

		// Token: 0x0602AACB RID: 174795 RVA: 0x00C065F8 File Offset: 0x00C047F8
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

		// Token: 0x040171F2 RID: 94706
		private CardDetailItemData Data;

		// Token: 0x040171F3 RID: 94707
		private CardDetailAttributeLayoutItem AttributeLayout;

		// Token: 0x040171F4 RID: 94708
		private CardDetailFactorDescLayoutItem FactorDescLayout;

		// Token: 0x040171F5 RID: 94709
		private CardDetailTaskDescItem TaskDescItem;

		// Token: 0x040171F6 RID: 94710
		private CardDetailActiveSkillItem ActiveSkillItem;

		// Token: 0x040171F7 RID: 94711
		private CardDetailPassiveSkillItem PassiveSkillItem;

		// Token: 0x040171F8 RID: 94712
		private CardDetailLockItem LockItem;

		// Token: 0x040171F9 RID: 94713
		private CardDetailDurationItem DurationItem;

		// Token: 0x040171FA RID: 94714
		private CardDetailRemainRoundItem RemainRoundItem;

		// Token: 0x02009DE8 RID: 40424
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040311A9 RID: 201129
			public const int NameText = 0;

			// Token: 0x040311AA RID: 201130
			public const int AttributeLayout = 1;

			// Token: 0x040311AB RID: 201131
			public const int AttributeItem = 2;

			// Token: 0x040311AC RID: 201132
			public const int CardDescTitleItem = 3;

			// Token: 0x040311AD RID: 201133
			public const int CardDescItem = 4;

			// Token: 0x040311AE RID: 201134
			public const int CardDescText = 5;

			// Token: 0x040311AF RID: 201135
			public const int FactorDescLayout = 6;

			// Token: 0x040311B0 RID: 201136
			public const int FactorDescItem = 7;

			// Token: 0x040311B1 RID: 201137
			public const int FactorTitleItem = 8;

			// Token: 0x040311B2 RID: 201138
			public const int BgDescText = 9;

			// Token: 0x040311B3 RID: 201139
			public const int BgDescRootItem = 10;

			// Token: 0x040311B4 RID: 201140
			public const int TaskTitleItem = 11;

			// Token: 0x040311B5 RID: 201141
			public const int TaskTitleText = 12;

			// Token: 0x040311B6 RID: 201142
			public const int TaskDescLayout = 13;

			// Token: 0x040311B7 RID: 201143
			public const int TaskDescItem = 14;

			// Token: 0x040311B8 RID: 201144
			public const int ActiveSkillItem = 15;

			// Token: 0x040311B9 RID: 201145
			public const int PassiveSkillItem = 16;

			// Token: 0x040311BA RID: 201146
			public const int LockItem = 17;

			// Token: 0x040311BB RID: 201147
			public const int DurationItem = 18;

			// Token: 0x040311BC RID: 201148
			public const int RemainRoundItem = 19;
		}
	}
}
