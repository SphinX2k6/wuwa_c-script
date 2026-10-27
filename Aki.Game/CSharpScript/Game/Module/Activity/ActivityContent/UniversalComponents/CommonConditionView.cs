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
	// Token: 0x02005F75 RID: 24437
	[NullableContext(1)]
	[Nullable(0)]
	public class CommonConditionView : UiViewBase
	{
		// Token: 0x0603E079 RID: 254073 RVA: 0x00EF9D70 File Offset: 0x00EF7F70
		public CommonConditionView(UiViewInfo info) : base(info)
		{
			this.TextIdMap.Add("FinishAllConditionOpen", "TaskNotOpen_Tips01");
			this.TextIdMap.Add("FinishAnyConditionOpen", "TaskNotOpen_Tips02");
			this.TextIdMap.Add("FinishAllConditionPreOpen", "TaskNotPreOpen_Tips01");
			this.TextIdMap.Add("FinishAnyConditionPreOpen", "TaskNotPreOpen_Tips02");
		}

		// Token: 0x0603E07A RID: 254074 RVA: 0x00EF9DE4 File Offset: 0x00EF7FE4
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

		// Token: 0x0603E07B RID: 254075 RVA: 0x00EF9E8F File Offset: 0x00EF808F
		protected override void OnStart()
		{
			this.ConditionGroupData = (this.OpenParam as ConditionGroupData);
			this.CreateConditionLayout();
		}

		// Token: 0x0603E07C RID: 254076 RVA: 0x00EF9EA8 File Offset: 0x00EF80A8
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

		// Token: 0x0603E07D RID: 254077 RVA: 0x00EF9EE8 File Offset: 0x00EF80E8
		protected void CreateConditionLayout()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(2);
			UUIItem item = base.GetItem(3);
			this.ConditionLayout = new LoopScrollView<ActivityConditionItem, IActivityConditionData>(loopScrollViewComponent, item.GetOwner() as AUIBaseActor, new Func<ActivityConditionItem>(this.CreateConditionItem), false);
		}

		// Token: 0x0603E07E RID: 254078 RVA: 0x00EF9F2C File Offset: 0x00EF812C
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

		// Token: 0x0603E07F RID: 254079 RVA: 0x00EFA026 File Offset: 0x00EF8226
		private ActivityConditionItem CreateConditionItem()
		{
			return new ActivityConditionItem();
		}

		// Token: 0x04020647 RID: 132679
		[Nullable(2)]
		protected ConditionGroupData ConditionGroupData;

		// Token: 0x04020648 RID: 132680
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ActivityConditionItem, IActivityConditionData> ConditionLayout;

		// Token: 0x04020649 RID: 132681
		protected Dictionary<string, string> TextIdMap = new Dictionary<string, string>();

		// Token: 0x0200C270 RID: 49776
		[NullableContext(0)]
		internal class EComponents
		{
			// Token: 0x0403ABCE RID: 240590
			public const int Title = 0;

			// Token: 0x0403ABCF RID: 240591
			public const int TxtTips = 1;

			// Token: 0x0403ABD0 RID: 240592
			public const int ConditionLayout = 2;

			// Token: 0x0403ABD1 RID: 240593
			public const int ConditionItem = 3;
		}
	}
}
