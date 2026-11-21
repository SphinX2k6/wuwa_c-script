using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalComponents
{
	// Token: 0x02004F5C RID: 20316
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonConditionView : UiViewBase
	{
		// Token: 0x06033013 RID: 208915 RVA: 0x00E4BA58 File Offset: 0x00E49C58
		public CommonConditionView(UiViewInfo info) : base(info)
		{
			this.TextIdMap.Add("FinishAllConditionOpen", "TaskNotOpen_Tips01");
			this.TextIdMap.Add("FinishAnyConditionOpen", "TaskNotOpen_Tips02");
			this.TextIdMap.Add("FinishAllConditionPreOpen", "TaskNotPreOpen_Tips01");
			this.TextIdMap.Add("FinishAnyConditionPreOpen", "TaskNotPreOpen_Tips02");
		}

		// Token: 0x06033014 RID: 208916 RVA: 0x00E4BACC File Offset: 0x00E49CCC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033015 RID: 208917 RVA: 0x00E4BB77 File Offset: 0x00E49D77
		protected override void OnStart()
		{
			this.ConditionGroupData = (this.OpenParam as ConditionGroupData);
			this.CreateConditionLayout();
		}

		// Token: 0x06033016 RID: 208918 RVA: 0x00E4BB90 File Offset: 0x00E49D90
		protected override void OnBeforeShow()
		{
			if (this.ConditionGroupData == null)
			{
				return;
			}
			List<IActivityConditionData> dataList = this.ConditionGroupData.DataList;
			LoopScrollView<ActivityConditionItem, IActivityConditionData> conditionLayout = this.ConditionLayout;
			if (conditionLayout != null)
			{
				conditionLayout.RefreshByData(dataList, false, null, false);
			}
			this.SetDescription();
		}

		// Token: 0x06033017 RID: 208919 RVA: 0x00E4BBD0 File Offset: 0x00E49DD0
		protected void CreateConditionLayout()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
			UUIItem item = base.GetItem(3);
			this.ConditionLayout = new LoopScrollView<ActivityConditionItem, IActivityConditionData>(loopScrollViewComponent, item.GetOwner() as AUIBaseActor, new Func<ActivityConditionItem>(this.CreateConditionItem), false);
		}

		// Token: 0x06033018 RID: 208920 RVA: 0x00E4BC14 File Offset: 0x00E49E14
		private void SetDescription()
		{
			ConditionGroupData conditionGroupData = this.ConditionGroupData;
			if (conditionGroupData == null)
			{
				return;
			}
			ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(conditionGroupData.ConditionGroupId);
			string textStringId = string.Empty;
			if (!conditionGroupData.IsPreOpen)
			{
				textStringId = ((conditionGroupConfig == null || conditionGroupConfig.GetValueOrDefault().Relation != 0) ? this.TextIdMap["FinishAnyConditionOpen"] : this.TextIdMap["FinishAllConditionOpen"]);
			}
			else
			{
				textStringId = ((conditionGroupConfig == null || conditionGroupConfig.GetValueOrDefault().Relation != 0) ? this.TextIdMap["FinishAnyConditionPreOpen"] : this.TextIdMap["FinishAllConditionPreOpen"]);
			}
			string item = StringUtils.IsEmpty(conditionGroupData.TitleId) ? string.Empty : ConfigMultiTextLang.GetLocalTextNew(conditionGroupData.TitleId, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlySingleElementList<object>(item));
		}

		// Token: 0x06033019 RID: 208921 RVA: 0x00E4BD0E File Offset: 0x00E49F0E
		private ActivityConditionItem CreateConditionItem()
		{
			return new ActivityConditionItem();
		}

		// Token: 0x0401B119 RID: 110873
		[Nullable(2)]
		protected ConditionGroupData ConditionGroupData;

		// Token: 0x0401B11A RID: 110874
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ActivityConditionItem, IActivityConditionData> ConditionLayout;

		// Token: 0x0401B11B RID: 110875
		protected Dictionary<string, string> TextIdMap = new Dictionary<string, string>();

		// Token: 0x0200AC7B RID: 44155
		[NullableContext(0)]
		internal class EComponents
		{
			// Token: 0x040355AA RID: 218538
			public const int Title = 0;

			// Token: 0x040355AB RID: 218539
			public const int TxtTips = 1;

			// Token: 0x040355AC RID: 218540
			public const int ConditionLayout = 2;

			// Token: 0x040355AD RID: 218541
			public const int ConditionItem = 3;
		}
	}
}
