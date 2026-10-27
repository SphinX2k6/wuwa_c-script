using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057F9 RID: 22521
	public class RewardExploreAccumulatedScoreItem : UiPanelBase
	{
		// Token: 0x0603942A RID: 234538 RVA: 0x00D93DD4 File Offset: 0x00D91FD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603942B RID: 234539 RVA: 0x00D93EC4 File Offset: 0x00D920C4
		protected override void OnStart()
		{
			this.DetailScoreLayout = new GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData>(base.GetVerticalLayout(0), new Func<RewardExploreAccumulatedScoreItem.ScoreItem>(this.CreateScoreItem), null, false, true);
			this.TotalScoreLayout = new GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData>(base.GetVerticalLayout(2), new Func<RewardExploreAccumulatedScoreItem.ScoreItem>(this.CreateScoreItem), null, false, true);
		}

		// Token: 0x0603942C RID: 234540 RVA: 0x00D93F13 File Offset: 0x00D92113
		[NullableContext(1)]
		private RewardExploreAccumulatedScoreItem.ScoreItem CreateScoreItem()
		{
			return new RewardExploreAccumulatedScoreItem.ScoreItem();
		}

		// Token: 0x0603942D RID: 234541 RVA: 0x00D93F1C File Offset: 0x00D9211C
		[NullableContext(1)]
		public void Refresh(AccumulatedScoreData data)
		{
			List<IAccumulatedScoreLineData> list = data.DetailScoreDataList;
			if (list != null)
			{
				GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> detailScoreLayout = this.DetailScoreLayout;
				if (detailScoreLayout != null)
				{
					detailScoreLayout.RefreshByData(list, null, false);
				}
			}
			list = data.TotalScoreDataList;
			if (list != null)
			{
				GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> totalScoreLayout = this.TotalScoreLayout;
				if (totalScoreLayout != null)
				{
					totalScoreLayout.RefreshByData(list, null, false);
				}
			}
			int curScore = data.CurScore;
			int maxScore = data.MaxScore;
			bool flag = curScore >= maxScore;
			if (!flag)
			{
				UUIText text = base.GetText(4);
				if (text != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(curScore);
					defaultInterpolatedStringHandler.AppendLiteral("/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(maxScore);
					text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "riskofrain_UIScore", new <>z__ReadOnlyArray<object>(new object[]
				{
					curScore,
					maxScore
				}));
			}
			base.GetItem(5).SetUIActive(flag);
		}

		// Token: 0x0401DF2E RID: 122670
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> DetailScoreLayout;

		// Token: 0x0401DF2F RID: 122671
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RewardExploreAccumulatedScoreItem.ScoreItem, IAccumulatedScoreLineData> TotalScoreLayout;

		// Token: 0x0200B9EB RID: 47595
		private class EChildType
		{
			// Token: 0x0403835A RID: 230234
			public const int DetailScoreLayout = 0;

			// Token: 0x0403835B RID: 230235
			public const int DetailScoreTemplateItem = 1;

			// Token: 0x0403835C RID: 230236
			public const int TotalScoreLayout = 2;

			// Token: 0x0403835D RID: 230237
			public const int TotalScoreTemplateItem = 3;

			// Token: 0x0403835E RID: 230238
			public const int LimitScoreText = 4;

			// Token: 0x0403835F RID: 230239
			public const int ArriveMaxScoreItem = 5;
		}

		// Token: 0x0200B9EC RID: 47596
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class ScoreItem : GridProxyAbstract<IAccumulatedScoreLineData>
		{
			// Token: 0x0604F6F9 RID: 325369 RVA: 0x01542B00 File Offset: 0x01540D00
			protected unsafe override void OnRegisterComponent()
			{
				int num = 2;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x0604F6FA RID: 325370 RVA: 0x01542B69 File Offset: 0x01540D69
			[NullableContext(1)]
			public override void Refresh(IAccumulatedScoreLineData data, bool isSelected, int gridIndex)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.DescTextId, Array.Empty<object>());
				base.GetText(1).SetText(data.ScoreText, true);
			}

			// Token: 0x0200D16A RID: 53610
			private class EScoreItemComponent
			{
				// Token: 0x0403ED92 RID: 257426
				public const int DescText = 0;

				// Token: 0x0403ED93 RID: 257427
				public const int ScoreText = 1;
			}
		}
	}
}
